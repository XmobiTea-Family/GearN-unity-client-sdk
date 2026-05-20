# Ví dụ: Referral — user A mời B, B nhập code, A nhận reward khi B đạt mốc

Tính năng: mỗi user có 1 mã giới thiệu. User mới nhập mã của người mời để tạo liên kết referral (1 lần / đời). Khi invitee đạt mốc (vd lên level 10), inviter nhận reward. Persistence trong MongoDB nội bộ qua `database.runtimeGameCollection(...)`; payout currency account-level qua `admin.masterPlayer.changePlayerCurrencyAsync`.

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md), [docs/cloudScript/CLOUDSCRIPT_admin.md](/docs/cloudScript/CLOUDSCRIPT_admin.md).

---

## 1. Mô hình dữ liệu

Hai collection runtime:

- `database.runtimeGameCollection("Referral.Code", gameId)` — mã của mỗi user.
  - Full name: `"Runtime." + gameId + ".Referral.Code"`
  - Shape: `{ userId: string; code: string; tsCreate: number }`
- `database.runtimeGameCollection("Referral.Link", gameId)` — liên kết inviter ↔ invitee.
  - Full name: `"Runtime." + gameId + ".Referral.Link"`
  - Shape:

```ts
type ReferralLink = {
    inviterId: string;        // người sở hữu code
    inviteeId: string;        // người nhập code — khóa unique, mỗi user chỉ redeem 1 lần
    milestoneReached: boolean;// invitee đã đạt mốc chưa
    inviterRewarded: boolean; // inviter đã được trả reward chưa
    tsCreate: number;
};
```

Index:

- `Referral.Code`: `{ code: 1 }` **unique**, `{ userId: 1 }` **unique**.
- `Referral.Link`: `{ inviteeId: 1 }` **unique** (mỗi user redeem 1 lần), `{ inviterId: 1 }` (đếm số người đã mời).

Constants: reward inviter = `200 gem`; mốc kích hoạt do server gọi `referralReportMilestone` quyết định.

---

## 2. Script TypeScript

```ts
const RF_CODE_COLLECTION = "Referral.Code";
const RF_LINK_COLLECTION = "Referral.Link";
const RF_CODE_CHARS = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789"; // bỏ ký tự dễ nhầm: I,O,0,1
const RF_CODE_LEN = 6;
const RF_REWARD_CURRENCY_KEY = "gem";
const RF_REWARD_AMOUNT = 200;

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

const randomCode = (): string => {
    let code = "";
    for (let i = 0; i < RF_CODE_LEN; i++) {
        code += RF_CODE_CHARS[Math.floor(Math.random() * RF_CODE_CHARS.length)];
    }
    return code;
};

// Lấy (hoặc tạo lần đầu) code của user hiện tại
handlers["referralGetMyCode"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const collection = database.runtimeGameCollection(RF_CODE_COLLECTION, gameId);

    const existing = await collection.findOne({ userId: userId }, { projection: { _id: 0 } });
    if (existing !== null) {
        return { code: existing.code, isNew: false };
    }

    // Sinh code, retry khi đụng unique index { code: 1 }
    for (let attempt = 0; attempt < 8; attempt++) {
        const code = randomCode();
        try {
            await collection.insertOne({ userId: userId, code: code, tsCreate: Date.now() });
            return { code: code, isNew: true };
        } catch (insertError) {
            // Có thể là trùng code, hoặc đã có doc cho userId (request song song) → đọc lại
            const reread = await collection.findOne({ userId: userId }, { projection: { _id: 0 } });
            if (reread !== null) {
                return { code: reread.code, isNew: false };
            }
            // còn lại: trùng code → thử lại
        }
    }
    throw new Error("code_generation_failed");
};

// Invitee nhập code của inviter
handlers["referralRedeem"] = async (args: Record<string, unknown>, context, log) => {
    const inviteeId = context.userId;
    const code = requireString(args?.code, "code").toUpperCase();

    const codeCollection = database.runtimeGameCollection(RF_CODE_COLLECTION, gameId);
    const linkCollection = database.runtimeGameCollection(RF_LINK_COLLECTION, gameId);

    const codeDoc = await codeCollection.findOne({ code: code }, { projection: { _id: 0 } });
    if (codeDoc === null) {
        throw new Error("invalid_code");
    }
    const inviterId = codeDoc.userId;
    if (inviterId === inviteeId) {
        throw new Error("cannot_refer_self");
    }

    // Unique index { inviteeId: 1 } đảm bảo mỗi invitee chỉ redeem 1 lần
    try {
        await linkCollection.insertOne({
            inviterId: inviterId,
            inviteeId: inviteeId,
            milestoneReached: false,
            inviterRewarded: false,
            tsCreate: Date.now(),
        });
    } catch (insertError) {
        throw new Error("already_redeemed");
    }

    return { inviterId: inviterId, inviteeId: inviteeId, redeemed: true };
};

// Server-side: gọi khi invitee đạt mốc → trả reward cho inviter.
// CHỈ gọi từ trusted backend / handler server-authoritative — KHÔNG cho client gọi (xem §5).
handlers["referralReportMilestone"] = async (args: Record<string, unknown>, context, log) => {
    const inviteeId = requireString(args?.inviteeId, "inviteeId");

    const linkCollection = database.runtimeGameCollection(RF_LINK_COLLECTION, gameId);
    const link = await linkCollection.findOne({ inviteeId: inviteeId }, { projection: { _id: 0 } });
    if (link === null) {
        return { rewarded: false, reason: "no_referral_link" };
    }
    if (link.inviterRewarded === true) {
        return { rewarded: false, reason: "already_rewarded" };
    }

    // CAS: chỉ trả reward khi inviterRewarded đang false → chống trả đôi concurrent
    const claimResult = await linkCollection.updateOne(
        { inviteeId: inviteeId, inviterRewarded: false },
        { $set: { milestoneReached: true, inviterRewarded: true } },
    );
    if ((claimResult.modifiedCount ?? 0) === 0) {
        return { rewarded: false, reason: "already_rewarded" };
    }

    try {
        const currencyParam = new MasterPlayerModels.PlayerCurrencyParam();
        currencyParam.key = RF_REWARD_CURRENCY_KEY;
        currencyParam.value = RF_REWARD_AMOUNT;

        const payoutRequest = new MasterPlayerModels.AdminChangePlayerCurrencyRequestData();
        payoutRequest.userId = link.inviterId;
        payoutRequest.playerCurrencies = [currencyParam];
        payoutRequest.log = "referral reward inviteeId=" + inviteeId;

        const payoutResponse = await admin.masterPlayer.changePlayerCurrencyAsync(payoutRequest);
        assertResponseOk(payoutResponse, "admin.masterPlayer.changePlayerCurrencyAsync");
    } catch (payoutError) {
        // Rollback cờ reward để retry
        await linkCollection.updateOne({ inviteeId: inviteeId }, { $set: { inviterRewarded: false } });
        throw payoutError;
    }

    return {
        rewarded: true,
        inviterId: link.inviterId,
        rewardCurrencyKey: RF_REWARD_CURRENCY_KEY,
        rewardAmount: RF_REWARD_AMOUNT,
    };
};

// Inviter xem mình đã mời được bao nhiêu người
handlers["referralMyStats"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const linkCollection = database.runtimeGameCollection(RF_LINK_COLLECTION, gameId);

    const total = await linkCollection.countDocuments({ inviterId: userId });
    const rewarded = await linkCollection.countDocuments({ inviterId: userId, inviterRewarded: true });

    return { invitedCount: total, rewardedCount: rewarded };
};
```

Init index (chạy 1 lần sau khi publish live):

```ts
handlers["initReferral"] = async (args: Record<string, unknown>, context, log) => {
    const codeName = "Runtime." + gameId + "." + RF_CODE_COLLECTION;
    const linkName = "Runtime." + gameId + "." + RF_LINK_COLLECTION;
    await database.createIndex(codeName, { code: 1 }, { unique: true });
    await database.createIndex(codeName, { userId: 1 }, { unique: true });
    await database.createIndex(linkName, { inviteeId: 1 }, { unique: true });
    await database.createIndex(linkName, { inviterId: 1 });
    return { ok: true };
};
```

> Vì sao payout qua `admin.masterPlayer` chứ không `admin.gamePlayer`: referral là quan hệ cấp tài khoản (1 người, nhiều game). Reward gem account-level đi qua `masterPlayer` đúng domain. Nếu reward của bạn là currency gameplay riêng từng game, đổi sang `admin.gamePlayer.changePlayerCurrencyAsync`.

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = referralScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass: gọi `initReferral` 1 lần để tạo index, rồi promote live:

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

public System.Threading.Tasks.Task<object> ReferralGetMyCodeAsync()
    => ExecuteAsync("referralGetMyCode", GNHashtable.builder().build());

public System.Threading.Tasks.Task<object> ReferralRedeemAsync(string code)
    => ExecuteAsync("referralRedeem", GNHashtable.builder().add("code", code).build());

public System.Threading.Tasks.Task<object> ReferralMyStatsAsync()
    => ExecuteAsync("referralMyStats", GNHashtable.builder().build());
```

UI flow:

1. Screen "Mời bạn bè" → `ReferralGetMyCodeAsync` render code để user share; `ReferralMyStatsAsync` hiện đã mời được bao nhiêu người.
2. User mới nhập code người mời → `ReferralRedeemAsync(code)`. Throw `invalid_code` / `cannot_refer_self` / `already_redeemed` → map sang text bản địa.
3. `referralReportMilestone` KHÔNG gọi từ client — server-authoritative tự gọi khi invitee đạt mốc.

---

## 5. Cảnh báo

- `referralReportMilestone` KHÔNG được cho game client gọi. Nếu để mở, invitee tự "report" để thưởng inviter ngay khi vừa redeem, bỏ qua mốc thật. Gọi nó từ trusted backend, hoặc từ 1 handler server-authoritative đã verify mốc (vd handler xử lý lên level), hoặc check `context.userId` thuộc whitelist.
- KHÔNG thay unique index `{ inviteeId: 1 }` bằng check `findOne` rồi `insertOne` — 2 request song song sẽ cùng thấy "chưa redeem" và tạo 2 link. Unique index ép DB từ chối, `insertOne` throw → bắt thành `already_redeemed`.
- KHÔNG thay CAS reward (`updateOne` filter `inviterRewarded: false`) bằng đọc-rồi-set — trả reward đôi khi 2 request song song.
- Code dùng tập ký tự bỏ `I O 0 1` để user gõ tay không nhầm. `referralRedeem` `.toUpperCase()` input để không phân biệt hoa thường.
- Chống self-referral chỉ bằng `inviterId === inviteeId` là tối thiểu; thực tế còn cần chống nhiều tài khoản clone cùng thiết bị (fraud) — kiểm tra thêm device fingerprint / IP nếu reward giá trị cao.
- Payout fail thì rollback cờ `inviterRewarded`. Rollback fail → kẹt; thêm fail-log nếu reward lớn.
- KHÔNG gọi `executeFunctionAsync` qua `.server`/`.admin` từ client ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
