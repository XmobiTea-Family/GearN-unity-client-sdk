# Ví dụ: Guild Bank — kho currency chung của group: deposit, withdraw, audit log

Tính năng: kho dùng chung trong group (guild bank). Member nạp currency cá nhân vào kho chung, rút từ kho ra ví cá nhân; mọi giao dịch ghi audit log. Số dư kho lưu trong MongoDB nội bộ qua `database.runtimeGameCollection(...)`; kiểm tra tư cách member qua `admin.group.getMembersAsync`; di chuyển currency cá nhân qua `admin.gamePlayer.changePlayerCurrencyAsync` (giữ audit log SDK).

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md), [docs/cloudScript/CLOUDSCRIPT_admin.md](/docs/cloudScript/CLOUDSCRIPT_admin.md).

---

## 1. Mô hình dữ liệu

Hai collection runtime:

- `database.runtimeGameCollection("GuildBank.Balance", gameId)` — số dư kho mỗi group.
  - Full name: `"Runtime." + gameId + ".GuildBank.Balance"`
  - Shape: `{ groupId: string; balance: number; tsUpdate: number }`
- `database.runtimeGameCollection("GuildBank.Log", gameId)` — audit từng giao dịch.
  - Full name: `"Runtime." + gameId + ".GuildBank.Log"`
  - Shape:

```ts
type GuildBankLog = {
    groupId: string;
    userId: string;
    type: "deposit" | "withdraw";
    amount: number;
    balanceAfter: number;  // số dư kho sau giao dịch
    tsCreate: number;
};
```

Index:

- `GuildBank.Balance`: `{ groupId: 1 }` **unique** — cho atomic `$inc` + CAS theo số dư.
- `GuildBank.Log`: `{ groupId: 1, tsCreate: -1 }` — xem lịch sử kho.

Currency dùng chung: hằng số `GB_CURRENCY_KEY = "gold"`.

> Số dư kho là currency cá nhân đã gộp lại, KHÔNG phải group currency của SDK. `admin.group` ở đây chỉ dùng để xác thực tư cách member; bản thân số dư nằm trong collection custom để toàn quyền kiểm soát atomic CAS rút tiền.

---

## 2. Script TypeScript

```ts
const GB_BALANCE_COLLECTION = "GuildBank.Balance";
const GB_LOG_COLLECTION = "GuildBank.Log";
const GB_CURRENCY_KEY = "gold";
const GB_LOG_LIMIT_MAX = 100;

const requireString = (value: unknown, fieldName: string): string => {
    if (typeof value !== "string" || value.trim().length === 0) {
        throw new Error(fieldName + " is required");
    }
    return value.trim();
};

const requirePositiveAmount = (value: unknown): number => {
    if (typeof value !== "number" || !isFinite(value) || value <= 0) {
        throw new Error("amount must be a positive number");
    }
    return Math.floor(value);
};

const assertResponseOk = (response: CustomOperationResponse, actionName: string): void => {
    if (response.hasReturnCodeError()) {
        throw new Error(actionName + " return-code error: " + (response.debugMessage ?? response.toString()));
    }
    if (response.errorCode !== ErrorCode.Ok) {
        throw new Error(actionName + " business error: " + response.errorCode);
    }
};

// Xác thực userId là member của group; throw nếu không
const assertGroupMember = async (groupId: string, userId: string): Promise<void> => {
    const requestData = new GroupModels.AdminGetMembersRequestData();
    requestData.groupId = groupId;

    const response = await admin.group.getMembersAsync(requestData);
    assertResponseOk(response, "admin.group.getMembersAsync");

    const members = response.responseData.infoResponseParameters.members ?? [];
    const isMember = members.some((m: any) => m.memberId === userId);
    if (!isMember) {
        throw new Error("not_a_group_member");
    }
};

// Cộng/trừ currency cá nhân. delta âm = trừ.
const changePlayerCurrency = async (userId: string, delta: number, logMessage: string): Promise<void> => {
    const currencyParam = new GamePlayerModels.PlayerCurrencyParam();
    currencyParam.key = GB_CURRENCY_KEY;
    currencyParam.value = delta;

    const requestData = new GamePlayerModels.AdminChangePlayerCurrencyRequestData();
    requestData.userId = userId;
    requestData.playerCurrencies = [currencyParam];
    requestData.log = logMessage;

    const response = await admin.gamePlayer.changePlayerCurrencyAsync(requestData);
    assertResponseOk(response, "admin.gamePlayer.changePlayerCurrencyAsync");
};

const insertBankLog = async (groupId: string, userId: string, type: string, amount: number, balanceAfter: number): Promise<void> => {
    const logCollection = database.runtimeGameCollection(GB_LOG_COLLECTION, gameId);
    await logCollection.insertOne({
        groupId: groupId,
        userId: userId,
        type: type,
        amount: amount,
        balanceAfter: balanceAfter,
        tsCreate: Date.now(),
    });
};

handlers["guildBankDeposit"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const groupId = requireString(args?.groupId, "groupId");
    const amount = requirePositiveAmount(args?.amount);

    await assertGroupMember(groupId, userId);

    const balanceCollection = database.runtimeGameCollection(GB_BALANCE_COLLECTION, gameId);
    const txnId = userId + ":" + Date.now();

    // 1) Trừ currency cá nhân trước. changePlayerCurrency throw nếu không đủ số dư.
    await changePlayerCurrency(userId, -amount, "guildBank deposit groupId=" + groupId + " txnId=" + txnId);

    // 2) Cộng vào kho. $inc atomic; upsert nếu kho chưa có doc.
    try {
        await balanceCollection.updateOne(
            { groupId: groupId },
            { $inc: { balance: amount }, $set: { tsUpdate: Date.now() }, $setOnInsert: { groupId: groupId } },
            { upsert: true },
        );
    } catch (creditError) {
        // Rollback: hoàn lại currency cá nhân
        await changePlayerCurrency(userId, amount, "guildBank deposit ROLLBACK txnId=" + txnId);
        throw creditError;
    }

    const after = await balanceCollection.findOne({ groupId: groupId }, { projection: { _id: 0 } });
    const balanceAfter = after?.balance ?? amount;
    await insertBankLog(groupId, userId, "deposit", amount, balanceAfter);

    return { groupId: groupId, type: "deposit", amount: amount, bankBalance: balanceAfter };
};

handlers["guildBankWithdraw"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const groupId = requireString(args?.groupId, "groupId");
    const amount = requirePositiveAmount(args?.amount);

    await assertGroupMember(groupId, userId);

    const balanceCollection = database.runtimeGameCollection(GB_BALANCE_COLLECTION, gameId);
    const txnId = userId + ":" + Date.now();

    // 1) Atomic CAS: trừ kho CHỈ KHI số dư đủ. Filter balance >= amount chống rút quá tay.
    const debitResult = await balanceCollection.updateOne(
        { groupId: groupId, balance: { $gte: amount } },
        { $inc: { balance: -amount }, $set: { tsUpdate: Date.now() } },
    );
    if ((debitResult.modifiedCount ?? 0) === 0) {
        throw new Error("insufficient_bank_balance");
    }

    // 2) Cộng currency cá nhân
    try {
        await changePlayerCurrency(userId, amount, "guildBank withdraw groupId=" + groupId + " txnId=" + txnId);
    } catch (creditError) {
        // Rollback: hoàn lại kho
        await balanceCollection.updateOne({ groupId: groupId }, { $inc: { balance: amount } });
        throw creditError;
    }

    const after = await balanceCollection.findOne({ groupId: groupId }, { projection: { _id: 0 } });
    const balanceAfter = after?.balance ?? 0;
    await insertBankLog(groupId, userId, "withdraw", amount, balanceAfter);

    return { groupId: groupId, type: "withdraw", amount: amount, bankBalance: balanceAfter };
};

handlers["guildBankInfo"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const groupId = requireString(args?.groupId, "groupId");

    await assertGroupMember(groupId, userId);

    const limitRaw = typeof args?.limit === "number" ? Math.floor(args.limit) : 20;
    const limit = Math.max(1, Math.min(GB_LOG_LIMIT_MAX, limitRaw));

    const balanceCollection = database.runtimeGameCollection(GB_BALANCE_COLLECTION, gameId);
    const logCollection = database.runtimeGameCollection(GB_LOG_COLLECTION, gameId);

    const balanceDoc = await balanceCollection.findOne({ groupId: groupId }, { projection: { _id: 0 } });
    const logs = await logCollection
        .find({ groupId: groupId }, { projection: { _id: 0, groupId: 0 } })
        .sort({ tsCreate: -1 })
        .limit(limit)
        .toArray();

    return { groupId: groupId, bankBalance: balanceDoc?.balance ?? 0, logs: logs };
};
```

Init index (chạy 1 lần sau khi publish live):

```ts
handlers["initGuildBank"] = async (args: Record<string, unknown>, context, log) => {
    const balanceName = "Runtime." + gameId + "." + GB_BALANCE_COLLECTION;
    const logName = "Runtime." + gameId + "." + GB_LOG_COLLECTION;
    await database.createIndex(balanceName, { groupId: 1 }, { unique: true });
    await database.createIndex(logName, { groupId: 1, tsCreate: -1 });
    return { ok: true };
};
```

> Vì sao withdraw trừ kho TRƯỚC bằng CAS, deposit trừ ví cá nhân TRƯỚC: luôn trừ phía "nguồn" trước rồi cộng phía "đích". Nếu cộng đích fail còn rollback nguồn được. Filter `balance: { $gte: amount }` trên `updateOne` đảm bảo 2 request rút song song không làm kho âm.

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = guildBankScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass: gọi `initGuildBank` 1 lần để tạo index, rồi promote live:

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

public System.Threading.Tasks.Task<object> GuildBankInfoAsync(string groupId, int limit = 20)
    => ExecuteAsync("guildBankInfo", GNHashtable.builder().add("groupId", groupId).add("limit", limit).build());

public System.Threading.Tasks.Task<object> GuildBankDepositAsync(string groupId, long amount)
    => ExecuteAsync("guildBankDeposit", GNHashtable.builder().add("groupId", groupId).add("amount", amount).build());

public System.Threading.Tasks.Task<object> GuildBankWithdrawAsync(string groupId, long amount)
    => ExecuteAsync("guildBankWithdraw", GNHashtable.builder().add("groupId", groupId).add("amount", amount).build());
```

UI flow:

1. Mở screen Guild Bank → `GuildBankInfoAsync(groupId)` render số dư kho + lịch sử giao dịch.
2. User nạp → `GuildBankDepositAsync`. Throw business error nếu ví cá nhân không đủ (`changePlayerCurrency` từ chối).
3. User rút → `GuildBankWithdrawAsync`. Throw `insufficient_bank_balance` → kho không đủ. Throw `not_a_group_member` → user đã rời group.

---

## 5. Cảnh báo

- Mọi handler check `assertGroupMember` TRƯỚC — `context.userId` đã trust nhưng `groupId` do client truyền, phải xác minh user thực sự thuộc group đó, nếu không user rút trộm kho group lạ.
- KHÔNG thay CAS withdraw (`updateOne` filter `balance: { $gte: amount }`) bằng đọc-`balance`-rồi-`$set` — 2 request rút song song sẽ cùng thấy đủ tiền và làm kho âm.
- Deposit/withdraw KHÔNG atomic across 2 hệ thống (currency cá nhân ↔ collection kho). Có cửa sổ nhỏ giữa 2 bước; handler rollback bước đầu nếu bước hai fail. Trường hợp xấu nhất rollback cũng fail → lệch sổ; thêm fail-log collection nếu giá trị lớn.
- `GuildBank.Log` là audit nghiệp vụ — đừng xóa để tiết kiệm; đây là nguồn đối soát khi member khiếu nại "ai rút tiền kho".
- KHÔNG di chuyển currency cá nhân bằng `loadGamePlayerAsync(...)` + `saveAsync()` — bỏ audit log SDK. Dùng `admin.gamePlayer.changePlayerCurrencyAsync`.
- Quyền rút: ví dụ này cho mọi member rút. Thực tế guild bank thường giới hạn theo role (chỉ leader/officer rút, hoặc hạn mức/ngày). Bổ sung bằng cách đọc role member từ `getMembersAsync` (`member.status`) hoặc thêm bảng quyền riêng + rate-limit theo `userId`.
- KHÔNG gọi `executeFunctionAsync` qua `.server`/`.admin` từ client ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
