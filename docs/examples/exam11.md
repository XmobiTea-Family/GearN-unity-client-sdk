# Ví dụ: Season Pass — đo XP theo mùa, payout milestone free / premium track

Tính năng: battle-pass / season-pass. User tích XP trong 1 mùa; mỗi tier (mốc XP) có reward ở 2 track — `free` (ai cũng nhận) và `premium` (chỉ user đã mua pass). User claim từng tier 1 lần. Persistence trong MongoDB nội bộ qua `database.runtimeGameCollection(...)`; payout currency qua `admin.gamePlayer.changePlayerCurrencyAsync` (giữ audit log SDK).

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md), [docs/cloudScript/CLOUDSCRIPT_admin.md](/docs/cloudScript/CLOUDSCRIPT_admin.md).

---

## 1. Mô hình dữ liệu

- Collection (đọc/ghi): `database.runtimeGameCollection("SeasonPass.State", gameId)`
- Full name (index): `"Runtime." + gameId + ".SeasonPass.State"`

Document shape (1 doc / (season, user)):

```ts
type SeasonPassState = {
    seasonId: string;        // id mùa, server tự tính — KHÔNG nhận từ client
    userId: string;
    xp: number;              // XP đã tích trong mùa
    isPremium: boolean;      // đã mua premium pass mùa này chưa
    claimedFree: number[];   // các tierIndex đã claim ở track free
    claimedPremium: number[];// các tierIndex đã claim ở track premium
    tsUpdate: number;
};
```

Index: `{ seasonId: 1, userId: 1 }` **unique** — cho atomic `$inc` xp + CAS claim.

Constants:

- `SP_EPOCH_MS` = mốc 0 (vd `1704067200000`).
- `SP_SEASON_MS` = độ dài mùa (vd 30 ngày). `seasonId = "season:" + Math.floor((now - SP_EPOCH_MS) / SP_SEASON_MS)`.
- `SP_TIERS` — mảng tier, mỗi tier có `xp` (mốc), `freeReward`, `premiumReward` (`{ currencyKey, amount }`).

> Vì sao `seasonId` do server tính: nếu client truyền, user có thể claim vào mùa cũ/mới để farm. Server tính từ `Date.now()` → mọi thao tác rơi đúng mùa hiện tại.

---

## 2. Script TypeScript

```ts
const SP_COLLECTION = "SeasonPass.State";
const SP_EPOCH_MS = 1704067200000;
const SP_SEASON_MS = 30 * 24 * 60 * 60 * 1000;

type Reward = { currencyKey: string; amount: number };
type Tier = { xp: number; freeReward: Reward; premiumReward: Reward };
const SP_TIERS: Tier[] = [
    { xp: 0,    freeReward: { currencyKey: "gold", amount: 100 }, premiumReward: { currencyKey: "gem", amount: 20 } },
    { xp: 500,  freeReward: { currencyKey: "gold", amount: 200 }, premiumReward: { currencyKey: "gem", amount: 30 } },
    { xp: 1500, freeReward: { currencyKey: "gold", amount: 400 }, premiumReward: { currencyKey: "gem", amount: 50 } },
    { xp: 3000, freeReward: { currencyKey: "gold", amount: 800 }, premiumReward: { currencyKey: "gem", amount: 100 } },
];

const requireString = (value: unknown, fieldName: string): string => {
    if (typeof value !== "string" || value.trim().length === 0) {
        throw new Error(fieldName + " is required");
    }
    return value.trim();
};

const assertResponseOk = (response: CustomOperationResponse, actionName: string): void => {
    if (response.hasReturnCodeError()) {
        throw new Error(actionName + " return-code error: " + (response.debugMessage ?? response.toString()));
    }
    if (response.errorCode !== ErrorCode.Ok) {
        throw new Error(actionName + " business error: " + response.errorCode);
    }
};

const currentSeasonId = (now: number): string => {
    return "season:" + Math.floor((now - SP_EPOCH_MS) / SP_SEASON_MS);
};

const payoutCurrency = async (userId: string, reward: Reward, logMessage: string): Promise<void> => {
    const currencyParam = new GamePlayerModels.PlayerCurrencyParam();
    currencyParam.key = reward.currencyKey;
    currencyParam.value = reward.amount;

    const requestData = new GamePlayerModels.AdminChangePlayerCurrencyRequestData();
    requestData.userId = userId;
    requestData.playerCurrencies = [currencyParam];
    requestData.log = logMessage;

    const response = await admin.gamePlayer.changePlayerCurrencyAsync(requestData);
    assertResponseOk(response, "admin.gamePlayer.changePlayerCurrencyAsync");
};

// Cộng XP cho mùa hiện tại
handlers["seasonAddXp"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const amount = typeof args?.amount === "number" ? Math.floor(args.amount) : 0;
    if (amount <= 0) {
        throw new Error("amount must be > 0");
    }

    const now = Date.now();
    const seasonId = currentSeasonId(now);
    const collection = database.runtimeGameCollection(SP_COLLECTION, gameId);

    await collection.updateOne(
        { seasonId: seasonId, userId: userId },
        {
            $inc: { xp: amount },
            $set: { tsUpdate: now },
            $setOnInsert: { seasonId: seasonId, userId: userId, isPremium: false, claimedFree: [], claimedPremium: [] },
        },
        { upsert: true },
    );

    const doc = await collection.findOne({ seasonId: seasonId, userId: userId }, { projection: { _id: 0 } });
    return { seasonId: seasonId, xp: doc?.xp ?? amount };
};

handlers["seasonStatus"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const now = Date.now();
    const seasonId = currentSeasonId(now);
    const collection = database.runtimeGameCollection(SP_COLLECTION, gameId);

    const doc = await collection.findOne({ seasonId: seasonId, userId: userId }, { projection: { _id: 0 } });
    const xp = doc?.xp ?? 0;
    const isPremium = doc?.isPremium === true;
    const claimedFree: number[] = doc?.claimedFree ?? [];
    const claimedPremium: number[] = doc?.claimedPremium ?? [];

    const tiers = SP_TIERS.map((tier, index) => ({
        tierIndex: index,
        requiredXp: tier.xp,
        unlocked: xp >= tier.xp,
        freeReward: tier.freeReward,
        freeClaimed: claimedFree.indexOf(index) >= 0,
        premiumReward: tier.premiumReward,
        premiumClaimed: claimedPremium.indexOf(index) >= 0,
    }));

    return { seasonId: seasonId, xp: xp, isPremium: isPremium, tiers: tiers };
};

handlers["seasonClaim"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const track = requireString(args?.track, "track"); // "free" | "premium"
    if (track !== "free" && track !== "premium") {
        throw new Error("invalid_track: dùng 'free' hoặc 'premium'");
    }
    const tierIndex = typeof args?.tierIndex === "number" ? Math.floor(args.tierIndex) : -1;
    if (tierIndex < 0 || tierIndex >= SP_TIERS.length) {
        throw new Error("invalid_tier_index");
    }

    const now = Date.now();
    const seasonId = currentSeasonId(now);
    const collection = database.runtimeGameCollection(SP_COLLECTION, gameId);
    const tier = SP_TIERS[tierIndex];

    const doc = await collection.findOne({ seasonId: seasonId, userId: userId }, { projection: { _id: 0 } });
    if (doc === null || (doc.xp ?? 0) < tier.xp) {
        throw new Error("tier_locked: cần " + tier.xp + " xp");
    }
    if (track === "premium" && doc.isPremium !== true) {
        throw new Error("premium_not_owned");
    }

    const claimedField = track === "free" ? "claimedFree" : "claimedPremium";
    const reward = track === "free" ? tier.freeReward : tier.premiumReward;

    // CAS: $addToSet vào mảng claimed kèm filter tierIndex chưa có → chống double-claim
    const filter: Record<string, unknown> = { seasonId: seasonId, userId: userId };
    filter[claimedField] = { $ne: tierIndex };
    const claimResult = await collection.updateOne(filter, { $addToSet: { [claimedField]: tierIndex } });
    if ((claimResult.modifiedCount ?? 0) === 0) {
        throw new Error("already_claimed");
    }

    try {
        await payoutCurrency(userId, reward, "seasonPass claim " + track + " tier=" + tierIndex);
    } catch (payoutError) {
        // Rollback: gỡ tierIndex khỏi mảng claimed để user claim lại
        await collection.updateOne(
            { seasonId: seasonId, userId: userId },
            { $pull: { [claimedField]: tierIndex } },
        );
        throw payoutError;
    }

    return { seasonId: seasonId, track: track, tierIndex: tierIndex, reward: reward, claimed: true };
};

// Mở khóa premium pass. CHỈ gọi từ trusted backend sau khi xác nhận thanh toán (xem §5).
handlers["seasonUnlockPremium"] = async (args: Record<string, unknown>, context, log) => {
    const targetUserId = requireString(args?.userId, "userId");
    const now = Date.now();
    const seasonId = currentSeasonId(now);
    const collection = database.runtimeGameCollection(SP_COLLECTION, gameId);

    await collection.updateOne(
        { seasonId: seasonId, userId: targetUserId },
        {
            $set: { isPremium: true, tsUpdate: now },
            $setOnInsert: { seasonId: seasonId, userId: targetUserId, xp: 0, claimedFree: [], claimedPremium: [] },
        },
        { upsert: true },
    );
    return { seasonId: seasonId, userId: targetUserId, isPremium: true };
};
```

Init index (chạy 1 lần sau khi publish live):

```ts
handlers["initSeasonPass"] = async (args: Record<string, unknown>, context, log) => {
    const fullName = "Runtime." + gameId + "." + SP_COLLECTION;
    await database.createIndex(fullName, { seasonId: 1, userId: 1 }, { unique: true });
    return { ok: true };
};
```

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = seasonPassScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass: gọi `initSeasonPass` 1 lần để tạo index, rồi promote live:

```csharp
var editRequestData = new CloudScriptModels.AdminEditFunctionRequestData();
editRequestData.version = version;
editRequestData.canExecute = "true";
editRequestData.isLive = "true";
await GNNetwork.cloudScript.admin.editFunctionAsync(editRequestData);
```

Lưu ý `canExecute`/`isLive` của `AdminEditFunctionRequestData` là `string` — phải truyền `"true"`/`"false"`, không phải bool literal ([guides/CLOUDSCRIPT.md:127-128](/docs/guides/CLOUDSCRIPT.md)).

---

## 4. Unity client

Pattern 3-tier check (`returnCode` → `errorCode` → `ExecuteResponseStatus`) — [guides/CLOUDSCRIPT.md:162-185](/docs/guides/CLOUDSCRIPT.md).

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Common;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

private async System.Threading.Tasks.Task<object> ExecuteAsync(string functionName, GNHashtable parameters)
{
    var requestData = new CloudScriptModels.ExecuteFunctionRequestData();
    requestData.functionName = functionName;
    requestData.functionParameters = parameters;

    var response = await GNNetwork.cloudScript.executeFunctionAsync(requestData);
    if (response.returnCode != ReturnCode.Ok) throw new System.Exception("transport: " + response.returnCode);
    if (response.errorCode != ErrorCode.Ok) throw new System.Exception("business: " + response.errorCode);

    var exec = response.responseData;
    var status = (ExecuteResponseStatus)exec.status;
    if (status != ExecuteResponseStatus.Ok) throw new System.Exception("execute: " + exec.errorMessage);

    return exec.functionResult;
}

public System.Threading.Tasks.Task<object> SeasonStatusAsync()
    => ExecuteAsync("seasonStatus", GNHashtable.builder().build());

public System.Threading.Tasks.Task<object> SeasonAddXpAsync(int amount)
    => ExecuteAsync("seasonAddXp", GNHashtable.builder().add("amount", amount).build());

public System.Threading.Tasks.Task<object> SeasonClaimAsync(int tierIndex, string track)
    => ExecuteAsync("seasonClaim", GNHashtable.builder().add("tierIndex", tierIndex).add("track", track).build());
```

UI flow:

1. Mở screen Season Pass → `SeasonStatusAsync` render thanh XP + 2 cột tier (free/premium), nút Claim bật khi `unlocked && !claimed`.
2. Gameplay tích XP → `SeasonAddXpAsync(amount)` (xem cảnh báo §5 về nguồn XP).
3. User bấm Claim 1 tier → `SeasonClaimAsync(tierIndex, "free")` hoặc `"premium"`. Throw `tier_locked` / `premium_not_owned` / `already_claimed` → map sang text.

---

## 5. Cảnh báo

- KHÔNG nhận `seasonId` từ client. Mùa do server tính từ `Date.now()`.
- `seasonAddXp` gọi từ client = client tự khai XP → gian lận. Cộng XP từ logic server đã validate (kết quả trận, quest hoàn thành server-authoritative), hoặc validate `amount` + rate-limit.
- `seasonUnlockPremium` KHÔNG cho client gọi — nếu mở, user tự bật premium free. Gọi từ trusted backend SAU khi validate receipt IAP, hoặc từ handler nối với `admin.storeInventory.validateReceipt`.
- KHÔNG thay CAS `$addToSet` + filter `{ $ne: tierIndex }` bằng đọc-mảng-rồi-push — 2 request song song claim đôi cùng tier.
- Payout fail thì handler `$pull` tierIndex khỏi mảng claimed để retry. Rollback fail → kẹt; thêm fail-log nếu reward lớn.
- Khi sang mùa mới, doc mùa cũ vẫn còn (`seasonId` khác). XP và claimed của mùa mới bắt đầu từ 0 vì là doc khác. Dọn doc mùa cũ bằng `deleteMany({ seasonId })` sau khi mùa đóng, hoặc thêm TTL.
- `isPremium` gắn theo từng mùa (nằm trong doc `seasonId`). Mua premium mùa này không tự kế thừa sang mùa sau — đúng ý đồ battle-pass.
- KHÔNG payout bằng `loadGamePlayerAsync(...)` + `saveAsync()` — bỏ audit log SDK. Dùng `admin.gamePlayer.changePlayerCurrencyAsync`.
- KHÔNG gọi `executeFunctionAsync` qua `.server`/`.admin` từ client ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
