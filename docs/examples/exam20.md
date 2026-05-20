# Ví dụ: Group Chat — chat trong group (built-in `groupRepository` message vs custom collection)

Tính năng: chat trong 1 group. File này dùng **message store built-in của GearN** qua `database.groupRepository.createGroupMessageAsync` / `loadGroupMessagesAsync` — gắn sẵn với entity Group, không phải tự dựng collection. Membership verify qua `admin.group.getMembersAsync`; tin nhắn mới broadcast realtime qua `socket.sendEventToMoreUser`. §5 so sánh khi nào nên dùng built-in, khi nào nên tự dựng collection riêng.

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md), [docs/cloudScript/CLOUDSCRIPT_database_GROUP_REPOSITORY.md](/docs/cloudScript/CLOUDSCRIPT_database_GROUP_REPOSITORY.md), [docs/cloudScript/CLOUDSCRIPT_admin.md](/docs/cloudScript/CLOUDSCRIPT_admin.md), [docs/cloudScript/CLOUDSCRIPT_socket.md](/docs/cloudScript/CLOUDSCRIPT_socket.md).

---

## 1. Mô hình dữ liệu

**Không tạo collection mới.** Message gắn vào entity Group qua message store built-in của GearN:

- Ghi: `database.groupRepository.createGroupMessageAsync(groupId, gameId, senderId, senderType, message, tsCreate)`
- Đọc: `database.groupRepository.loadGroupMessagesAsync(groupId, gameId, skip, limit)` → `FindCursor`, dùng `.toArray()`
- Tham chiếu hàm: [cloudScript/CLOUDSCRIPT_database_GROUP_REPOSITORY.md:22-23](/docs/cloudScript/CLOUDSCRIPT_database_GROUP_REPOSITORY.md)

`senderType` là số map với enum sender-type của GearN; dùng hằng số cho rõ:

- `GC_SENDER_PLAYER = 1` — tin nhắn từ người chơi.

Message document do GearN quản lý shape (gồm `senderId`, `senderType`, `message`, `tsCreate`, …) — script chỉ ghi/đọc, không tự định nghĩa schema.

Membership: xác thực bằng `admin.group.getMembersAsync` — response trả `infoResponseParameters.members` (mỗi phần tử có `memberId`).

Event code realtime: `"groupChatMessage"`.

---

## 2. Script TypeScript

```ts
const GC_SENDER_PLAYER = 1;
const GC_MESSAGE_MAX = 500;
const GC_HISTORY_DEFAULT = 30;
const GC_HISTORY_MAX = 100;
const GC_EVENT = "groupChatMessage";

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

// Lấy danh sách memberId của group, đồng thời verify caller thuộc group
const loadGroupMemberIds = async (groupId: string, callerId: string): Promise<string[]> => {
    const requestData = new GroupModels.AdminGetMembersRequestData();
    requestData.groupId = groupId;

    const response = await admin.group.getMembersAsync(requestData);
    assertResponseOk(response, "admin.group.getMembersAsync");

    const members = response.responseData.infoResponseParameters.members ?? [];
    const memberIds = members.map((m: any) => m.memberId);
    if (memberIds.indexOf(callerId) < 0) {
        throw new Error("not_a_group_member");
    }
    return memberIds;
};

handlers["groupChatSend"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const groupId = requireString(args?.groupId, "groupId");
    const message = requireString(args?.message, "message");
    if (message.length > GC_MESSAGE_MAX) {
        throw new Error("message_too_long: max=" + GC_MESSAGE_MAX);
    }

    const memberIds = await loadGroupMemberIds(groupId, userId);
    const now = Date.now();

    // Ghi vào message store built-in của Group
    await database.groupRepository.createGroupMessageAsync(groupId, gameId, userId, GC_SENDER_PLAYER, message, now);

    // Broadcast realtime cho mọi member đang online
    const operationEvent = new OperationEvent(
        GC_EVENT,
        GNHashtable.builder()
            .add("groupId", groupId)
            .add("senderId", userId)
            .add("message", message)
            .add("ts", now)
            .build(),
    );
    await socket.sendEventToMoreUser(memberIds, operationEvent);

    return { groupId: groupId, senderId: userId, message: message, tsCreate: now };
};

handlers["groupChatHistory"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const groupId = requireString(args?.groupId, "groupId");

    await loadGroupMemberIds(groupId, userId); // verify membership

    const skipRaw = typeof args?.skip === "number" ? Math.floor(args.skip) : 0;
    const skip = Math.max(0, skipRaw);
    const limitRaw = typeof args?.limit === "number" ? Math.floor(args.limit) : GC_HISTORY_DEFAULT;
    const limit = Math.max(1, Math.min(GC_HISTORY_MAX, limitRaw));

    const cursor = await database.groupRepository.loadGroupMessagesAsync(groupId, gameId, skip, limit);
    const messages = await cursor.toArray();

    return { groupId: groupId, count: messages.length, messages: messages, hasMore: messages.length === limit };
};
```

> Không cần `initGroupChat` tạo index: message store built-in do GearN quản lý collection + index nội bộ. Đây là một lợi thế của hướng built-in so với tự dựng collection (xem §5).

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = groupChatScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass, promote live (không cần bước tạo index):

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

### 4.1 Gửi / đọc lịch sử

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

public System.Threading.Tasks.Task<object> GroupChatSendAsync(string groupId, string message)
    => ExecuteAsync("groupChatSend", GNHashtable.builder().add("groupId", groupId).add("message", message).build());

public System.Threading.Tasks.Task<object> GroupChatHistoryAsync(string groupId, int skip = 0, int limit = 30)
    => ExecuteAsync("groupChatHistory", GNHashtable.builder().add("groupId", groupId).add("skip", skip).add("limit", limit).build());
```

### 4.2 Nhận tin nhắn realtime

Subscribe handler cho event code `"groupChatMessage"`. Rule event custom: [cloudScript/CLOUDSCRIPT_socket.md:198-253](/docs/cloudScript/CLOUDSCRIPT_socket.md).

```csharp
using UnityEngine;
using XmobiTea.GearN;
using XmobiTea.GearN.Common;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity;
using XmobiTea.GearN.Helper;
using XmobiTea.GearN.Networking;

public class GroupChatMessageEvent
{
    [StringDataMember(code = "groupId")]
    public string groupId;

    [StringDataMember(code = "senderId")]
    public string senderId;

    [StringDataMember(code = ParameterCode.Message)]
    public string message;

    [NumberDataMember(code = ParameterCode.Ts)]
    public long ts;
}

public class GroupChatMessageEventHandler : IServerEventHandler
{
    private const string EVENT_GROUP_CHAT_MESSAGE = "groupChatMessage";

    public static Action1<GroupChatMessageEvent> onUpdate;

    public string getEventCode() => EVENT_GROUP_CHAT_MESSAGE;

    public void handle(OperationEvent operationEvent)
    {
        GroupChatMessageEventHandler.onUpdate?.Invoke(
            ConverterService.deserializeObject<GroupChatMessageEvent>(operationEvent.getParameters())
        );
    }
}

// Subscribe TRƯỚC GNNetwork.connectSocket()
GNNetwork.subscriberServerEventHandler(new GroupChatMessageEventHandler());

GroupChatMessageEventHandler.onUpdate = payload =>
{
    Debug.Log($"[{payload.groupId}] {payload.senderId}: {payload.message}");
    // append vào UI chat nếu đang mở đúng group
};
```

UI flow:

1. Mở screen chat group → `GroupChatHistoryAsync(groupId)` render lịch sử; cuộn lên → tăng `skip` để lấy trang cũ hơn.
2. User gửi → `GroupChatSendAsync(groupId, message)`.
3. Member online nhận event `groupChatMessage` → append trực tiếp, không cần gọi lại history.

---

## 5. Cảnh báo

- **Built-in `groupRepository` message vs custom collection** — chọn theo nhu cầu:
  - **Dùng built-in** (file này) khi: chat gắn chặt với entity Group, cần ít code, không muốn tự quản index/TTL, schema message tiêu chuẩn (sender + text + ts) là đủ. GearN lo collection + index.
  - **Dùng custom collection** (raw `runtimeGameCollection`, tự dựng schema + index) khi: cần field riêng (reply-to, reactions, attachment, đã đọc bởi ai), cần TTL tự xóa, cần query/filter đặc thù, hoặc chat KHÔNG thuộc 1 Group (vd 1-1 direct chat thì không nên ép tạo Group).
- Mọi handler verify membership TRƯỚC qua `loadGroupMemberIds` — `groupId` do client truyền, phải xác minh caller thực sự thuộc group, nếu không user đọc trộm / spam group lạ.
- `socket.sendEventToMoreUser` là fire-and-forget — member offline lúc gửi sẽ miss event; họ lấy lại qua `groupChatHistory` khi mở app. Event chỉ là kênh realtime, message store mới là nguồn bền vững.
- `senderType` là số map enum của GearN — dùng đúng giá trị cho người chơi; tin nhắn hệ thống (thông báo group) nên dùng senderType khác để client phân biệt.
- Với group đông member, broadcast từng tin nhắn tới mọi member tốn socket. Cân nhắc dùng room (`socket.joinRoom` + `sendEventToRoom`, xem [cloudScript/CLOUDSCRIPT_socket.md:335-365](/docs/cloudScript/CLOUDSCRIPT_socket.md)) nếu member join room sẵn khi vào group.
- `getMembersAsync` gọi mỗi lần send/history thêm 1 round-trip. Group rất active có thể cache danh sách member ngắn hạn, nhưng phải cân nhắc rủi ro member vừa bị kick vẫn gửi được.
- KHÔNG gọi `executeFunctionAsync` qua `.server`/`.admin` từ client ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
