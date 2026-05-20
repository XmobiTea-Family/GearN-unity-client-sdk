# Ví dụ: 1-1 Direct Chat bằng CloudScript (không dùng Group)

Tính năng: load đoạn chat giữa user hiện tại và 1 user khác, gửi tin nhắn, clear toàn bộ đoạn chat. Toàn bộ persistence nằm trong MongoDB nội bộ của GearN qua `database.runtimeGameCollection(...)` (không dùng `GroupApi`, không dùng `Group.message`).

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md).

---

## 1. Mô hình dữ liệu

Một message direct-chat được lưu trong collection runtime theo `gameId`:

- Collection (đọc/ghi): `database.runtimeGameCollection("DirectChat.Messages", gameId)`
- Full name (dùng cho `createIndex`): `"Runtime." + gameId + ".DirectChat.Messages"`

Document shape:

```ts
type DirectChatMessage = {
    chatId: string;       // canonical id = userId nhỏ + "::" + userId lớn (sort lexicographic)
    senderId: string;     // context.userId tại thời điểm gửi
    receiverId: string;   // user còn lại
    content: string;      // payload text
    tsCreate: number;     // Date.now()
};
```

`chatId` được xây dựng bằng cách sort 2 `userId` để cùng 1 cặp user luôn share đúng 1 `chatId`, không cần lưu 2 chiều.

Index khuyến nghị:

- `{ chatId: 1, tsCreate: -1 }` cho load + clear theo cặp.

---

## 2. Script TypeScript (publish bằng `addFunctionAsync`)

Toàn bộ 3 handler nằm trong cùng 1 version script. Đăng ký lên server bằng `GNNetwork.cloudScript.admin.addFunctionAsync` rồi promote live bằng `editFunctionAsync` (xem [guides/CLOUDSCRIPT.md:136-160](/docs/guides/CLOUDSCRIPT.md) §7).

```ts
const CHAT_COLLECTION = "DirectChat.Messages";
const CHAT_CONTENT_MAX = 1000;
const CHAT_PAGE_DEFAULT = 30;
const CHAT_PAGE_MAX = 100;

const requireString = (value: unknown, fieldName: string): string => {
    if (typeof value !== "string" || value.trim().length === 0) {
        throw new Error(fieldName + " is required");
    }
    return value.trim();
};

const buildChatId = (userA: string, userB: string): string => {
    if (userA === userB) {
        throw new Error("cannot_chat_with_self");
    }
    return userA < userB ? userA + "::" + userB : userB + "::" + userA;
};

handlers["loadDirectChat"] = async (args: any, context, log) => {
    const userId = context.userId;
    const otherUserId = requireString(args?.otherUserId, "otherUserId");

    const limitRaw = typeof args?.limit === "number" ? Math.floor(args.limit) : CHAT_PAGE_DEFAULT;
    const limit = Math.max(1, Math.min(CHAT_PAGE_MAX, limitRaw));
    const beforeTs = typeof args?.beforeTs === "number" ? args.beforeTs : null;

    const chatId = buildChatId(userId, otherUserId);
    const messages = database.runtimeGameCollection(CHAT_COLLECTION, gameId);

    const filter: { [k: string]: any } = { chatId: chatId };
    if (beforeTs !== null) {
        filter.tsCreate = { $lt: beforeTs };
    }

    const docs = await messages
        .find(filter, { projection: { _id: 0 } })
        .sort({ tsCreate: -1 })
        .limit(limit)
        .toArray();

    // Trả về theo thứ tự cũ → mới cho client render trực tiếp
    docs.reverse();

    return {
        chatId: chatId,
        otherUserId: otherUserId,
        messages: docs,
        hasMore: docs.length === limit,
        oldestTsCreate: docs.length > 0 ? docs[0].tsCreate : null,
    };
};

handlers["sendDirectChat"] = async (args: any, context, log) => {
    const userId = context.userId;
    const otherUserId = requireString(args?.otherUserId, "otherUserId");
    const content = requireString(args?.content, "content");

    if (content.length > CHAT_CONTENT_MAX) {
        throw new Error("content_too_long: max=" + CHAT_CONTENT_MAX);
    }

    const chatId = buildChatId(userId, otherUserId);
    const messages = database.runtimeGameCollection(CHAT_COLLECTION, gameId);

    const doc = {
        chatId: chatId,
        senderId: userId,
        receiverId: otherUserId,
        content: content,
        tsCreate: Date.now(),
    };

    await messages.insertOne(doc);

    return {
        chatId: chatId,
        senderId: userId,
        receiverId: otherUserId,
        content: content,
        tsCreate: doc.tsCreate,
    };
};

handlers["clearDirectChat"] = async (args: any, context, log) => {
    const userId = context.userId;
    const otherUserId = requireString(args?.otherUserId, "otherUserId");

    const chatId = buildChatId(userId, otherUserId);
    const messages = database.runtimeGameCollection(CHAT_COLLECTION, gameId);

    const result = await messages.deleteMany({ chatId: chatId });

    return {
        chatId: chatId,
        deletedCount: result.deletedCount ?? 0,
    };
};
```

Tạo index 1 lần (chạy ad-hoc bằng admin tool hoặc 1 handler `initDirectChat` riêng):

```ts
handlers["initDirectChat"] = async (args: any, context, log) => {
    const fullName = "Runtime." + gameId + "." + CHAT_COLLECTION;
    await database.createIndex(fullName, { chatId: 1, tsCreate: -1 });
    return { ok: true, index: "chatId_1_tsCreate_-1" };
};
```

> Vì sao không dùng `GroupApi`: feature là 1-1 direct, không có khái niệm member/role/admin/invite. Tạo 1 `Group` cho mỗi cặp user sẽ phình bảng group và mượn semantic không phù hợp. Raw collection cho phép unique key `chatId` thuần (sort 2 userId) và clear bằng 1 `deleteMany`.

---

## 3. Publish version

Lần đầu publish (xem pattern ở [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md) §8):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = directChatScript; // string TS ở §2
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);

if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass với đúng `version` này, promote live:

```csharp
var editRequestData = new CloudScriptModels.AdminEditFunctionRequestData();
editRequestData.version = version;
editRequestData.canExecute = "true";
editRequestData.isLive = "true";

await GNNetwork.cloudScript.admin.editFunctionAsync(editRequestData);
```

Lưu ý field type của `EditFunctionRequestData.canExecute` / `isLive` là `string` — phải truyền `"true"` / `"false"`, không phải bool literal ([guides/CLOUDSCRIPT.md:127-128](/docs/guides/CLOUDSCRIPT.md)).

---

## 4. Unity client — gọi từ app

Pattern bắt buộc 3 tầng check: `returnCode` → `errorCode` → `ExecuteResponseStatus` ([guides/CLOUDSCRIPT.md:162-185](/docs/guides/CLOUDSCRIPT.md) §8 Minimal Pattern).

### 4.1 Load chat

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Common;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

public async System.Threading.Tasks.Task<object> LoadDirectChatAsync(string otherUserId, long? beforeTs = null, int limit = 30)
{
    var requestData = new CloudScriptModels.ExecuteFunctionRequestData();
    requestData.functionName = "loadDirectChat";

    var builder = GNHashtable.builder()
        .add("otherUserId", otherUserId)
        .add("limit", limit);
    if (beforeTs.HasValue) builder.add("beforeTs", beforeTs.Value);
    requestData.functionParameters = builder.build();

    var response = await GNNetwork.cloudScript.executeFunctionAsync(requestData);

    if (response.returnCode != ReturnCode.Ok) throw new System.Exception("transport: " + response.returnCode);
    if (response.errorCode != ErrorCode.Ok) throw new System.Exception("business: " + response.errorCode);

    var exec = response.responseData;
    var status = (ExecuteResponseStatus)exec.status;
    if (status != ExecuteResponseStatus.Ok) throw new System.Exception("execute: " + exec.errorMessage);

    return exec.functionResult; // { chatId, otherUserId, messages[], hasMore, oldestTsCreate }
}
```

Phân trang: lần đầu gọi không truyền `beforeTs`; lần sau truyền `beforeTs = oldestTsCreate` từ response trước để lấy trang cũ hơn.

### 4.2 Gửi tin nhắn

```csharp
public async System.Threading.Tasks.Task<object> SendDirectChatAsync(string otherUserId, string content)
{
    var requestData = new CloudScriptModels.ExecuteFunctionRequestData();
    requestData.functionName = "sendDirectChat";
    requestData.functionParameters = GNHashtable.builder()
        .add("otherUserId", otherUserId)
        .add("content", content)
        .build();

    var response = await GNNetwork.cloudScript.executeFunctionAsync(requestData);

    if (response.returnCode != ReturnCode.Ok) throw new System.Exception("transport: " + response.returnCode);
    if (response.errorCode != ErrorCode.Ok) throw new System.Exception("business: " + response.errorCode);

    var exec = response.responseData;
    var status = (ExecuteResponseStatus)exec.status;
    if (status != ExecuteResponseStatus.Ok) throw new System.Exception("execute: " + exec.errorMessage);

    return exec.functionResult; // { chatId, senderId, receiverId, content, tsCreate }
}
```

### 4.3 Clear đoạn chat

```csharp
public async System.Threading.Tasks.Task<int> ClearDirectChatAsync(string otherUserId)
{
    var requestData = new CloudScriptModels.ExecuteFunctionRequestData();
    requestData.functionName = "clearDirectChat";
    requestData.functionParameters = GNHashtable.builder()
        .add("otherUserId", otherUserId)
        .build();

    var response = await GNNetwork.cloudScript.executeFunctionAsync(requestData);

    if (response.returnCode != ReturnCode.Ok) throw new System.Exception("transport: " + response.returnCode);
    if (response.errorCode != ErrorCode.Ok) throw new System.Exception("business: " + response.errorCode);

    var exec = response.responseData;
    var status = (ExecuteResponseStatus)exec.status;
    if (status != ExecuteResponseStatus.Ok) throw new System.Exception("execute: " + exec.errorMessage);

    var result = exec.functionResult as GNHashtable;
    return result != null ? System.Convert.ToInt32(result["deletedCount"]) : 0;
}
```

> `clearDirectChat` xoá đối xứng cho cả 2 phía vì cùng `chatId`. Nếu cần "soft clear" chỉ phía caller (đối phương vẫn thấy), thay `deleteMany` bằng cập nhật field `hiddenForUserId` rồi filter ở `loadDirectChat`.

---

## 5. Cảnh báo

- `functionName` 3..30 ký tự, đúng key trong `handlers[...]` ([guides/CLOUDSCRIPT.md:35-35](/docs/guides/CLOUDSCRIPT.md)).
- KHÔNG dùng literal `GNNetwork` trong script — server reject trước compile ([cloudScript/CLOUDSCRIPT_USAGE.md:141-143](/docs/cloudScript/CLOUDSCRIPT_USAGE.md)).
- KHÔNG cần check `typeof context.userId !== "string"` — runtime đã guarantee ([cloudScript/CLOUDSCRIPT_USAGE.md:377-383](/docs/cloudScript/CLOUDSCRIPT_USAGE.md)).
- KHÔNG truyền object vòng tham chiếu cho `log(...)` hoặc làm payload return.
- KHÔNG gọi `executeFunctionAsync` từ `.server` / `.admin` ở Unity client — đó là trust-boundary leak ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
- Nếu cần realtime push tin nhắn mới sang user còn lại, kết hợp `socket` helper trong handler `sendDirectChat`; xem [cloudScript/CLOUDSCRIPT_socket.md](/docs/cloudScript/CLOUDSCRIPT_socket.md).
