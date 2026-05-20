# Ví dụ: Inbox / Hộp thư hệ thống — server gửi mail + reward, user list / read / claim

Tính năng: hộp thư hệ thống. Server (admin tool / trusted backend) gửi mail kèm phần thưởng currency cho 1 user; user list mail, đánh dấu đã đọc, và claim reward 1 lần duy nhất. Persistence trong MongoDB nội bộ qua `database.runtimeGameCollection(...)`. Khi có mail mới, server push realtime event qua `socket` để client cập nhật badge — nhưng mail vẫn nằm bền trong DB nên user offline lúc gửi vẫn nhận được khi mở app.

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md), [docs/cloudScript/CLOUDSCRIPT_socket.md](/docs/cloudScript/CLOUDSCRIPT_socket.md).

---

## 1. Mô hình dữ liệu

- Collection (đọc/ghi): `database.runtimeGameCollection("Inbox.Mails", gameId)`
- Full name (index): `"Runtime." + gameId + ".Inbox.Mails"`

Document shape (1 doc / mail):

```ts
type InboxMail = {
    mailId: string;        // id duy nhất, server tự sinh
    toUserId: string;      // người nhận
    subject: string;       // tiêu đề
    body: string;          // nội dung
    reward: {              // phần thưởng đính kèm; { } rỗng nếu mail thuần text
        currencyKey?: string;
        amount?: number;
    };
    isRead: boolean;       // user đã mở chưa
    isClaimed: boolean;    // reward đã nhận chưa
    tsCreate: number;      // Date.now() lúc gửi
    tsExpire: number;      // Date.now() + TTL; index TTL tự xóa mail hết hạn
};
```

Index:

- `{ mailId: 1 }` **unique** — khóa claim atomic.
- `{ toUserId: 1, tsCreate: -1 }` — list mail của 1 user, mới nhất trước.
- `{ tsExpire: 1 }` với `{ expireAfterSeconds: 0 }` — Mongo TTL tự dọn mail quá hạn.

Constants:

- `INBOX_TTL_MS = 30 ngày` — mail tự hết hạn sau 30 ngày.
- `INBOX_LIST_MAX = 100`.

Event code realtime: `"inboxNewMail"`.

---

## 2. Script TypeScript

```ts
const INBOX_COLLECTION = "Inbox.Mails";
const INBOX_TTL_MS = 30 * 24 * 60 * 60 * 1000;
const INBOX_LIST_DEFAULT = 50;
const INBOX_LIST_MAX = 100;
const INBOX_EVENT_NEW_MAIL = "inboxNewMail";
const INBOX_CURRENCY_LOG = "inbox claim reward";

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

// id duy nhất cho mail: ts + random, đủ chống trùng cho insert tốc độ thường
const newMailId = (toUserId: string): string => {
    return toUserId + ":" + Date.now() + ":" + Math.floor(Math.random() * 1e9);
};

// CHỈ gọi từ admin tool / trusted backend — KHÔNG cho game client gọi (xem §5).
handlers["inboxSend"] = async (args: Record<string, unknown>, context, log) => {
    const toUserId = requireString(args?.toUserId, "toUserId");
    const subject = requireString(args?.subject, "subject");
    const body = typeof args?.body === "string" ? args.body : "";

    // reward optional: { currencyKey, amount }
    const reward: { currencyKey?: string; amount?: number } = {};
    if (args?.rewardCurrencyKey != null && typeof args.rewardAmount === "number" && args.rewardAmount > 0) {
        reward.currencyKey = requireString(args.rewardCurrencyKey, "rewardCurrencyKey");
        reward.amount = Math.floor(args.rewardAmount);
    }

    const now = Date.now();
    const mailId = newMailId(toUserId);
    const collection = database.runtimeGameCollection(INBOX_COLLECTION, gameId);

    await collection.insertOne({
        mailId: mailId,
        toUserId: toUserId,
        subject: subject,
        body: body,
        reward: reward,
        isRead: false,
        isClaimed: false,
        tsCreate: now,
        tsExpire: now + INBOX_TTL_MS,
    });

    // Push realtime: client đang online cập nhật badge số ngay. Fire-and-forget —
    // mail đã nằm trong DB nên user offline vẫn thấy khi mở app.
    const operationEvent = new OperationEvent(
        INBOX_EVENT_NEW_MAIL,
        GNHashtable.builder().add("mailId", mailId).add("subject", subject).add("ts", now).build(),
    );
    await socket.sendEventTo(toUserId, operationEvent);

    return { mailId: mailId, toUserId: toUserId, tsCreate: now };
};

handlers["inboxList"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const collection = database.runtimeGameCollection(INBOX_COLLECTION, gameId);

    const limitRaw = typeof args?.limit === "number" ? Math.floor(args.limit) : INBOX_LIST_DEFAULT;
    const limit = Math.max(1, Math.min(INBOX_LIST_MAX, limitRaw));

    const docs = await collection
        .find({ toUserId: userId }, { projection: { _id: 0, toUserId: 0 } })
        .sort({ tsCreate: -1 })
        .limit(limit)
        .toArray();

    const unreadCount = docs.filter((d: any) => d.isRead !== true).length;
    const unclaimedCount = docs.filter((d: any) => d.isClaimed !== true && d.reward?.amount > 0).length;

    return { count: docs.length, unreadCount: unreadCount, unclaimedCount: unclaimedCount, mails: docs };
};

handlers["inboxRead"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const mailId = requireString(args?.mailId, "mailId");
    const collection = database.runtimeGameCollection(INBOX_COLLECTION, gameId);

    // Filter kèm toUserId: user chỉ đọc được mail của chính mình
    const result = await collection.updateOne(
        { mailId: mailId, toUserId: userId },
        { $set: { isRead: true } },
    );
    if ((result.matchedCount ?? 0) === 0) {
        throw new Error("mail_not_found");
    }
    return { mailId: mailId, isRead: true };
};

handlers["inboxClaim"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const mailId = requireString(args?.mailId, "mailId");
    const collection = database.runtimeGameCollection(INBOX_COLLECTION, gameId);

    const mail = await collection.findOne({ mailId: mailId, toUserId: userId }, { projection: { _id: 0 } });
    if (mail === null) {
        throw new Error("mail_not_found");
    }
    const amount = mail.reward?.amount ?? 0;
    const currencyKey = mail.reward?.currencyKey ?? null;
    if (currencyKey === null || amount <= 0) {
        throw new Error("mail_has_no_reward");
    }

    // 1) Atomic CAS: chỉ claim được nếu isClaimed đang false → chống double-claim concurrent
    const claimResult = await collection.updateOne(
        { mailId: mailId, toUserId: userId, isClaimed: false },
        { $set: { isClaimed: true, isRead: true } },
    );
    if ((claimResult.modifiedCount ?? 0) === 0) {
        throw new Error("already_claimed");
    }

    // 2) Payout currency qua admin (audit log của SDK tự ghi)
    try {
        const currencyParam = new GamePlayerModels.PlayerCurrencyParam();
        currencyParam.key = currencyKey;
        currencyParam.value = amount;

        const payoutRequest = new GamePlayerModels.AdminChangePlayerCurrencyRequestData();
        payoutRequest.userId = userId;
        payoutRequest.playerCurrencies = [currencyParam];
        payoutRequest.log = INBOX_CURRENCY_LOG + " mailId=" + mailId;

        const payoutResponse = await admin.gamePlayer.changePlayerCurrencyAsync(payoutRequest);
        assertResponseOk(payoutResponse, "admin.gamePlayer.changePlayerCurrencyAsync");
    } catch (payoutError) {
        // Rollback cờ claim để user thử lại — payout chưa thành công.
        await collection.updateOne({ mailId: mailId, toUserId: userId }, { $set: { isClaimed: false } });
        throw payoutError;
    }

    return { mailId: mailId, claimed: true, currencyKey: currencyKey, amount: amount };
};
```

Init index (chạy 1 lần sau khi publish live):

```ts
handlers["initInbox"] = async (args: Record<string, unknown>, context, log) => {
    const fullName = "Runtime." + gameId + "." + INBOX_COLLECTION;
    await database.createIndex(fullName, { mailId: 1 }, { unique: true });
    await database.createIndex(fullName, { toUserId: 1, tsCreate: -1 });
    await database.createIndex(fullName, { tsExpire: 1 }, { expireAfterSeconds: 0 });
    return { ok: true };
};
```

> Vì sao kết hợp `database` + `socket` chứ không chỉ `socket`: `socket.sendEventTo` là fire-and-forget, user offline lúc gửi sẽ mất event. Mail phải nằm bền trong DB để `inboxList` đọc lại bất cứ lúc nào; event socket chỉ là tín hiệu "có mail mới, refresh badge đi" cho client đang online. Xem [cloudScript/CLOUDSCRIPT_socket.md:20-24](/docs/cloudScript/CLOUDSCRIPT_socket.md).

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = inboxScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass: gọi `initInbox` 1 lần để tạo index, rồi promote live:

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

### 4.1 List / Read / Claim

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

public System.Threading.Tasks.Task<object> InboxListAsync(int limit = 50)
    => ExecuteAsync("inboxList", GNHashtable.builder().add("limit", limit).build());

public System.Threading.Tasks.Task<object> InboxReadAsync(string mailId)
    => ExecuteAsync("inboxRead", GNHashtable.builder().add("mailId", mailId).build());

public System.Threading.Tasks.Task<object> InboxClaimAsync(string mailId)
    => ExecuteAsync("inboxClaim", GNHashtable.builder().add("mailId", mailId).build());
```

`inboxList` trả `{ count, unreadCount, unclaimedCount, mails[] }` — dùng `unreadCount` để render badge số.

### 4.2 Nhận event mail mới qua socket

Client subscribe handler typed cho event code `"inboxNewMail"` để refresh badge realtime. Rule event custom: [cloudScript/CLOUDSCRIPT_socket.md:198-253](/docs/cloudScript/CLOUDSCRIPT_socket.md).

```csharp
using UnityEngine;
using XmobiTea.GearN;
using XmobiTea.GearN.Common;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity;
using XmobiTea.GearN.Helper;
using XmobiTea.GearN.Networking;

public class InboxNewMailEvent
{
    [StringDataMember(code = "mailId")]
    public string mailId;

    [StringDataMember(code = "subject")]
    public string subject;

    [NumberDataMember(code = ParameterCode.Ts)]
    public long ts;
}

public class InboxNewMailEventHandler : IServerEventHandler
{
    private const string EVENT_INBOX_NEW_MAIL = "inboxNewMail";

    public static Action1<InboxNewMailEvent> onUpdate;

    public string getEventCode() => EVENT_INBOX_NEW_MAIL;

    public void handle(OperationEvent operationEvent)
    {
        InboxNewMailEventHandler.onUpdate?.Invoke(
            ConverterService.deserializeObject<InboxNewMailEvent>(operationEvent.getParameters())
        );
    }
}

// Subscribe TRƯỚC GNNetwork.connectSocket()
GNNetwork.subscriberServerEventHandler(new InboxNewMailEventHandler());

InboxNewMailEventHandler.onUpdate = payload =>
{
    Debug.Log($"new mail {payload.mailId} {payload.subject}");
    // refresh badge / gọi lại InboxListAsync khi user mở inbox
};
```

UI flow:

1. Mở app → `InboxListAsync` render danh sách + badge `unreadCount`.
2. Đang online, server gửi mail → event `inboxNewMail` → tăng badge, optionally gọi lại `InboxListAsync`.
3. User mở 1 mail → `InboxReadAsync(mailId)`.
4. User nhấn Claim → `InboxClaimAsync(mailId)`. Nếu throw `already_claimed` (2 thiết bị cùng claim) → refresh list, báo "đã nhận ở thiết bị khác".

---

## 5. Cảnh báo

- `inboxSend` KHÔNG được cho game client gọi. CloudScript handler thực thi qua `executeFunctionAsync` — bất kỳ user nào cũng gọi được; nếu để mở, user tự gửi mail reward cho chính mình. Gửi mail là hành động trusted: gọi `inboxSend` từ admin tool / trusted backend, hoặc tách thành script khác chỉ promote ở môi trường nội bộ, hoặc check `context.userId` thuộc whitelist GM trong handler.
- KHÔNG thay CAS claim (`updateOne` filter `isClaimed: false`) bằng đọc-doc-rồi-set — 2 request song song sẽ cùng thấy `isClaimed=false` và claim đôi reward.
- Payout fail thì handler rollback `isClaimed` về `false` để user claim lại. Nếu rollback CŨNG fail, mail kẹt ở trạng thái claimed-nhưng-chưa-trả; cân nhắc thêm 1 collection fail-log (`database.runtimeGameCollection("Inbox.FailLog", gameId).insertOne({ mailId, userId, error, tsCreate })`) cho ops xử lý tay nếu reward lớn.
- KHÔNG payout currency bằng `database.gamePlayerRepository.loadGamePlayerAsync(...)` rồi `saveAsync()` — bỏ qua audit log SDK. Dùng `admin.gamePlayer.changePlayerCurrencyAsync`.
- Event `inboxNewMail` chỉ là tín hiệu, KHÔNG mang reward trong payload. Reward sống trong DB; client phải gọi `inboxClaim`. Không bao giờ grant reward dựa trên event socket nhận được.
- `currencyKey` đính kèm mail phải đã khai báo trong dashboard config; nếu chưa, `changePlayerCurrencyAsync` trả lỗi business → handler rollback claim.
- Mail tự xóa sau `INBOX_TTL_MS` nhờ index TTL — user để mail quá 30 ngày sẽ mất cả reward chưa claim. Chỉnh `INBOX_TTL_MS` hoặc bỏ index TTL nếu game không muốn hành vi này.
- Subscribe `InboxNewMailEventHandler` TRƯỚC khi gọi `GNNetwork.connectSocket()`, nếu không sẽ miss event.
- KHÔNG gọi `executeFunctionAsync` qua `.server`/`.admin` từ client ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
