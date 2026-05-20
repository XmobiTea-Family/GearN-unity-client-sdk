# Ví dụ: Daily Reward — cooldown 24h, streak counter, anti-double-claim

Tính năng: user claim reward mỗi 24h. Streak tăng nếu claim trong khung 24-48h từ lần trước; reset về 1 nếu vượt 48h. Payout cộng currency `gold` qua `admin.gamePlayer.changePlayerCurrencyAsync` (đi qua audit log của SDK, không tự ghi DB). Anti-double-claim bằng atomic `findOneAndUpdate` filter theo `tsLastClaim`.

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md), [docs/cloudScript/CLOUDSCRIPT_admin.md](/docs/cloudScript/CLOUDSCRIPT_admin.md).

---

## 1. Mô hình dữ liệu

- Collection (đọc/ghi): `database.runtimeGameCollection("DailyReward.State", gameId)`
- Full name (index): `"Runtime." + gameId + ".DailyReward.State"`

Document shape (1 doc / user):

```ts
type DailyRewardState = {
    userId: string;        // unique key
    streak: number;        // số ngày liên tiếp đã claim
    tsLastClaim: number;   // Date.now() lần claim gần nhất; 0 nếu chưa từng claim
};
```

Index: `{ userId: 1 }` **unique** — cho atomic upsert + filter trên `tsLastClaim`.

Constants:

- `COOLDOWN_MS = 24h = 86_400_000`
- `STREAK_BREAK_MS = 48h = 172_800_000` — vượt mốc này streak reset về 1.
- Reward theo streak: bảng `[100, 150, 200, 300, 500, 700, 1000]`; streak ≥ 7 dùng giá trị cuối.

---

## 2. Script TypeScript

```ts
const DR_COLLECTION = "DailyReward.State";
const DR_COOLDOWN_MS = 24 * 60 * 60 * 1000;
const DR_STREAK_BREAK_MS = 48 * 60 * 60 * 1000;
const DR_REWARD_TABLE = [100, 150, 200, 300, 500, 700, 1000];
const DR_CURRENCY_KEY = "gold";

const assertResponseOk = (response: CustomOperationResponse, actionName: string): void => {
    if (response.hasReturnCodeError()) {
        throw new Error(actionName + " return-code error: " + (response.debugMessage ?? response.toString()));
    }
    if (response.errorCode !== ErrorCode.Ok) {
        throw new Error(actionName + " business error: " + response.errorCode);
    }
};

const computeReward = (streak: number): number => {
    const idx = Math.min(Math.max(streak, 1), DR_REWARD_TABLE.length) - 1;
    return DR_REWARD_TABLE[idx];
};

handlers["dailyRewardStatus"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const collection = database.runtimeGameCollection(DR_COLLECTION, gameId);
    const doc = await collection.findOne({ userId: userId }, { projection: { _id: 0 } });

    const now = Date.now();
    const tsLastClaim = doc?.tsLastClaim ?? 0;
    const streak = doc?.streak ?? 0;
    const elapsed = now - tsLastClaim;
    const canClaim = tsLastClaim === 0 || elapsed >= DR_COOLDOWN_MS;
    const nextClaimAt = tsLastClaim === 0 ? now : tsLastClaim + DR_COOLDOWN_MS;

    // Streak hiện tại có thể đã "chết" do quá 48h — preview giá trị reward kế tiếp
    const nextStreak = tsLastClaim === 0 || elapsed > DR_STREAK_BREAK_MS ? 1 : streak + 1;

    return {
        canClaim: canClaim,
        streak: streak,
        nextStreak: nextStreak,
        nextReward: computeReward(nextStreak),
        tsLastClaim: tsLastClaim,
        nextClaimAt: nextClaimAt,
        msUntilClaim: Math.max(0, nextClaimAt - now),
    };
};

handlers["dailyRewardClaim"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const collection = database.runtimeGameCollection(DR_COLLECTION, gameId);
    const now = Date.now();

    // 1) Đọc state hiện tại (có thể null)
    const existing = await collection.findOne({ userId: userId }, { projection: { _id: 0 } });
    const tsLastClaim = existing?.tsLastClaim ?? 0;
    const prevStreak = existing?.streak ?? 0;
    const elapsed = now - tsLastClaim;

    if (tsLastClaim !== 0 && elapsed < DR_COOLDOWN_MS) {
        throw new Error("cooldown: msRemaining=" + (DR_COOLDOWN_MS - elapsed));
    }

    const newStreak = tsLastClaim === 0 || elapsed > DR_STREAK_BREAK_MS ? 1 : prevStreak + 1;
    const reward = computeReward(newStreak);

    // 2) Atomic CAS: cập nhật chỉ khi tsLastClaim chưa đổi (anti-double-claim concurrent)
    const filter = tsLastClaim === 0
        ? { userId: userId, tsLastClaim: { $exists: false } }
        : { userId: userId, tsLastClaim: tsLastClaim };

    const updateResult = await collection.updateOne(
        filter,
        { $set: { userId: userId, streak: newStreak, tsLastClaim: now } },
        { upsert: tsLastClaim === 0 },
    );

    if (updateResult.modifiedCount === 0 && updateResult.upsertedCount === 0) {
        throw new Error("race_lost: claim đã được xử lý bởi request khác");
    }

    // 3) Payout currency qua admin (audit log của SDK tự ghi)
    const currencyParam = new GamePlayerModels.PlayerCurrencyParam();
    currencyParam.key = DR_CURRENCY_KEY;
    currencyParam.value = reward;

    const payoutRequest = new GamePlayerModels.AdminChangePlayerCurrencyRequestData();
    payoutRequest.userId = userId;
    payoutRequest.playerCurrencies = [currencyParam];
    payoutRequest.log = "dailyReward claim streak=" + newStreak;

    const payoutResponse = await admin.gamePlayer.changePlayerCurrencyAsync(payoutRequest);
    assertResponseOk(payoutResponse, "admin.gamePlayer.changePlayerCurrencyAsync");

    return {
        claimed: true,
        streak: newStreak,
        reward: reward,
        currencyKey: DR_CURRENCY_KEY,
        tsClaim: now,
        nextClaimAt: now + DR_COOLDOWN_MS,
    };
};
```

Init index (chạy 1 lần):

```ts
handlers["initDailyReward"] = async (args: Record<string, unknown>, context, log) => {
    const fullName = "Runtime." + gameId + "." + DR_COLLECTION;
    await database.createIndex(fullName, { userId: 1 }, { unique: true });
    return { ok: true };
};
```

> Vì sao không lưu `tsLastClaim` vào GamePlayer custom data: pattern này ghi-trên-mỗi-claim; muốn `findOneAndUpdate` filter atomic phải có index riêng. Custom data load qua `InfoRequestParam` không có atomic CAS theo field cụ thể.

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = dailyRewardScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass: gọi `initDailyReward` 1 lần để tạo index, rồi promote live:

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

public System.Threading.Tasks.Task<object> DailyRewardStatusAsync()
    => ExecuteAsync("dailyRewardStatus", GNHashtable.builder().build());

public System.Threading.Tasks.Task<object> DailyRewardClaimAsync()
    => ExecuteAsync("dailyRewardClaim", GNHashtable.builder().build());
```

UI flow:

1. Mở screen → gọi `DailyRewardStatusAsync` → render `canClaim`, `nextStreak`, `nextReward`, countdown `msUntilClaim`.
2. User nhấn Claim → gọi `DailyRewardClaimAsync` → nếu throw với message `cooldown:` thì UI vừa lệch giờ với server, refresh status.
3. Nếu throw `race_lost`: 2 device cùng claim, đã có 1 thắng — refresh status, UI báo "đã claim ở thiết bị khác".

---

## 5. Cảnh báo

- KHÔNG dựa vào `Date.now()` của client để gate UI claim — luôn để server quyết. Client chỉ dùng `nextClaimAt` từ response để countdown.
- KHÔNG thay `updateOne` CAS bằng `replaceOne` không filter — sẽ mất anti-double-claim, 2 request song song sẽ claim đôi.
- KHÔNG payout currency bằng `database.gamePlayerRepository.loadGamePlayerAsync(...)` rồi `saveAsync()` — bỏ qua audit log của SDK. Dùng `admin.gamePlayer.changePlayerCurrencyAsync` để log đi vào `gamePlayerCurrencyLogs`.
- Nếu payout fail SAU khi CAS đã commit, user mất reward. Để chắc chắn idempotent, store thêm field `lastClaimId` (uuid) + retry handler tra `lastClaimId` trước khi insert log. Bỏ qua nếu game của bạn chấp nhận rủi ro này (vd 1 user/ngày, support manual cấp lại).
- `DR_REWARD_TABLE` cứng trong script: muốn config-driven, đọc từ `database.systemGameCollection("DailyReward.Config", gameId)` hoặc qua `admin.content` thay vì hard-code.
- KHÔNG gọi `executeFunctionAsync` qua `.server`/`.admin` từ client ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
