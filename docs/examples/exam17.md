# Ví dụ: Presence — track user online/offline, broadcast cho friend list

Tính năng: theo dõi trạng thái online/offline của user và báo cho bạn bè khi có thay đổi. Dựa trên **heartbeat**: client gửi nhịp định kỳ; server coi user online nếu nhịp gần đây còn mới. Trạng thái lưu trong MongoDB nội bộ qua `database.runtimeGameCollection(...)`; thay đổi online/offline broadcast realtime qua `socket.sendEventToMoreUser`.

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md), [docs/cloudScript/CLOUDSCRIPT_socket.md](/docs/cloudScript/CLOUDSCRIPT_socket.md).

---

## 1. Mô hình dữ liệu

- Collection (đọc/ghi): `database.runtimeGameCollection("Presence.State", gameId)`
- Full name (index): `"Runtime." + gameId + ".Presence.State"`

Document shape (1 doc / user):

```ts
type PresenceState = {
    userId: string;
    lastHeartbeatAt: number; // Date.now() nhịp gần nhất
    explicitOffline: boolean;// true khi user chủ động báo offline (thoát app)
    tsUpdate: number;
};
```

Index: `{ userId: 1 }` **unique**.

Cách xác định online: `online = !explicitOffline && (now - lastHeartbeatAt) < PRESENCE_TIMEOUT_MS`. Client gửi heartbeat mỗi `~30s`; timeout đặt `~90s` (3 nhịp) để 1-2 nhịp rớt mạng không bị coi là offline ngay.

Event code realtime: `"presenceChanged"`.

> Vì sao heartbeat thay vì hook disconnect: CloudScript `socket` helper chỉ expose `sendEventTo*` / `joinRoom` ([cloudScript/CLOUDSCRIPT_socket.md:34-43](/docs/cloudScript/CLOUDSCRIPT_socket.md)), KHÔNG có hook chạy khi socket connect/disconnect. Disconnect đột ngột (mất mạng, kill app) không có tín hiệu. Heartbeat + timeout là cách presence đáng tin duy nhất ở tầng CloudScript: hết nhịp → coi như offline.

---

## 2. Script TypeScript

```ts
const PR_COLLECTION = "Presence.State";
const PR_TIMEOUT_MS = 90 * 1000; // không nhịp quá 90s → offline
const PR_EVENT = "presenceChanged";
const PR_MAX_WATCH = 200;        // tối đa số user query 1 lần

const assertUserIdArray = (value: unknown): string[] => {
    if (!Array.isArray(value)) {
        throw new Error("userIds must be an array");
    }
    if (value.length > PR_MAX_WATCH) {
        throw new Error("too_many_userIds: max=" + PR_MAX_WATCH);
    }
    return value.filter((v: unknown) => typeof v === "string" && v.length > 0) as string[];
};

const isOnline = (doc: any, now: number): boolean => {
    if (doc == null || doc.explicitOffline === true) return false;
    return now - (doc.lastHeartbeatAt ?? 0) < PR_TIMEOUT_MS;
};

// Broadcast trạng thái mới cho danh sách bạn bè (client truyền friendIds)
const broadcastPresence = async (userId: string, online: boolean, friendIds: string[]): Promise<void> => {
    if (friendIds.length === 0) return;
    const operationEvent = new OperationEvent(
        PR_EVENT,
        GNHashtable.builder().add("userId", userId).add("online", online).add("ts", Date.now()).build(),
    );
    await socket.sendEventToMoreUser(friendIds, operationEvent);
};

// Client gọi định kỳ ~30s khi đang trong app
handlers["presenceHeartbeat"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const friendIds = Array.isArray(args?.friendIds)
        ? (args.friendIds.filter((v: unknown) => typeof v === "string") as string[])
        : [];

    const collection = database.runtimeGameCollection(PR_COLLECTION, gameId);
    const now = Date.now();

    const before = await collection.findOne({ userId: userId }, { projection: { _id: 0 } });
    const wasOnline = isOnline(before, now);

    await collection.updateOne(
        { userId: userId },
        { $set: { userId: userId, lastHeartbeatAt: now, explicitOffline: false, tsUpdate: now } },
        { upsert: true },
    );

    // Chỉ broadcast khi trạng thái CHUYỂN offline → online (tránh spam mỗi nhịp)
    if (!wasOnline) {
        await broadcastPresence(userId, true, friendIds);
    }

    return { online: true, becameOnline: !wasOnline };
};

// Client gọi khi chủ động thoát / pause app
handlers["presenceOffline"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const friendIds = Array.isArray(args?.friendIds)
        ? (args.friendIds.filter((v: unknown) => typeof v === "string") as string[])
        : [];

    const collection = database.runtimeGameCollection(PR_COLLECTION, gameId);
    const now = Date.now();

    const before = await collection.findOne({ userId: userId }, { projection: { _id: 0 } });
    const wasOnline = isOnline(before, now);

    await collection.updateOne(
        { userId: userId },
        { $set: { userId: userId, explicitOffline: true, tsUpdate: now } },
        { upsert: true },
    );

    if (wasOnline) {
        await broadcastPresence(userId, false, friendIds);
    }

    return { online: false, becameOffline: wasOnline };
};

// Query trạng thái 1 nhóm user (vd friend list khi mở app)
handlers["presenceQuery"] = async (args: Record<string, unknown>, context, log) => {
    const userIds = assertUserIdArray(args?.userIds);
    if (userIds.length === 0) {
        return { presences: [] };
    }

    const collection = database.runtimeGameCollection(PR_COLLECTION, gameId);
    const now = Date.now();
    const docs = await collection.find({ userId: { $in: userIds } }, { projection: { _id: 0 } }).toArray();

    const byId: Record<string, any> = {};
    docs.forEach((d: any) => { byId[d.userId] = d; });

    const presences = userIds.map((uid) => ({
        userId: uid,
        online: isOnline(byId[uid], now),
        lastSeenAt: byId[uid]?.lastHeartbeatAt ?? null,
    }));

    return { presences: presences };
};
```

Init index (chạy 1 lần sau khi publish live):

```ts
handlers["initPresence"] = async (args: Record<string, unknown>, context, log) => {
    const fullName = "Runtime." + gameId + "." + PR_COLLECTION;
    await database.createIndex(fullName, { userId: 1 }, { unique: true });
    return { ok: true };
};
```

> `presenceQuery` tính `online` từ `now - lastHeartbeatAt` chứ không tin field trạng thái lưu sẵn — user offline do mất mạng không kịp gọi `presenceOffline`, chỉ cách tính theo timeout mới phát hiện được.

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = presenceScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass: gọi `initPresence` 1 lần để tạo index, rồi promote live:

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

### 4.1 Heartbeat + query

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

public System.Threading.Tasks.Task<object> PresenceHeartbeatAsync(System.Collections.Generic.List<string> friendIds)
    => ExecuteAsync("presenceHeartbeat", GNHashtable.builder().add("friendIds", friendIds).build());

public System.Threading.Tasks.Task<object> PresenceOfflineAsync(System.Collections.Generic.List<string> friendIds)
    => ExecuteAsync("presenceOffline", GNHashtable.builder().add("friendIds", friendIds).build());

public System.Threading.Tasks.Task<object> PresenceQueryAsync(System.Collections.Generic.List<string> userIds)
    => ExecuteAsync("presenceQuery", GNHashtable.builder().add("userIds", userIds).build());
```

Heartbeat loop: dùng coroutine / `InvokeRepeating` gọi `PresenceHeartbeatAsync` mỗi 30s khi app foreground. Gọi `PresenceOfflineAsync` ở `OnApplicationPause(true)` / `OnApplicationQuit`.

### 4.2 Nhận event presence của bạn bè

Subscribe handler cho event code `"presenceChanged"`. Rule event custom: [cloudScript/CLOUDSCRIPT_socket.md:198-253](/docs/cloudScript/CLOUDSCRIPT_socket.md).

```csharp
using UnityEngine;
using XmobiTea.GearN;
using XmobiTea.GearN.Common;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity;
using XmobiTea.GearN.Helper;
using XmobiTea.GearN.Networking;

public class PresenceChangedEvent
{
    [StringDataMember(code = "userId")]
    public string userId;

    [BooleanDataMember(code = "online")]
    public bool online;

    [NumberDataMember(code = ParameterCode.Ts)]
    public long ts;
}

public class PresenceChangedEventHandler : IServerEventHandler
{
    private const string EVENT_PRESENCE_CHANGED = "presenceChanged";

    public static Action1<PresenceChangedEvent> onUpdate;

    public string getEventCode() => EVENT_PRESENCE_CHANGED;

    public void handle(OperationEvent operationEvent)
    {
        PresenceChangedEventHandler.onUpdate?.Invoke(
            ConverterService.deserializeObject<PresenceChangedEvent>(operationEvent.getParameters())
        );
    }
}

// Subscribe TRƯỚC GNNetwork.connectSocket()
GNNetwork.subscriberServerEventHandler(new PresenceChangedEventHandler());

PresenceChangedEventHandler.onUpdate = payload =>
{
    Debug.Log($"friend {payload.userId} online={payload.online}");
    // cập nhật chấm xanh/xám trên friend list UI
};
```

UI flow:

1. Mở friend list → `PresenceQueryAsync(friendIds)` render chấm online/offline ban đầu.
2. Heartbeat loop chạy nền; bạn bè nhận event `presenceChanged` khi user lên/xuống.
3. App pause/quit → `PresenceOfflineAsync` để bạn bè thấy offline ngay, không phải đợi timeout 90s.

---

## 5. Cảnh báo

- KHÔNG kỳ vọng có hook disconnect trong CloudScript — `socket` helper không expose. Presence ở đây dựa hoàn toàn vào heartbeat + timeout; disconnect đột ngột chỉ phát hiện sau khi quá `PR_TIMEOUT_MS`.
- `PR_TIMEOUT_MS` phải lớn hơn chu kỳ heartbeat ít nhất 2-3 lần. Timeout quá sát chu kỳ → 1 nhịp rớt mạng là user nhấp nháy offline.
- Chỉ broadcast khi trạng thái CHUYỂN (offline→online hoặc online→offline), KHÔNG broadcast mỗi nhịp heartbeat — nếu không, mỗi user online bắn event cho toàn bộ bạn bè mỗi 30s, ngập socket.
- `friendIds` do client truyền để broadcast — client có thể truyền sai/thiếu. Nếu cần chính xác, server tự load friend list từ `database.gamePlayerRepository` thay vì tin client (đánh đổi: tốn thêm 1 query mỗi heartbeat).
- `socket.sendEventToMoreUser` là fire-and-forget — bạn bè offline lúc đó sẽ miss event; họ lấy trạng thái đúng qua `presenceQuery` khi mở app. Đừng coi event là nguồn sự thật.
- Heartbeat tạo tải đều: N user online → N request/30s. Với lượng user lớn, cân nhắc tăng chu kỳ hoặc gộp presence vào cơ chế socket có sẵn của hạ tầng thay vì CloudScript handler.
- Doc `Presence.State` không tự xóa; user lâu không vào vẫn còn doc (vô hại vì `online` tính theo timeout). Thêm TTL nếu muốn dọn.
- KHÔNG gọi `executeFunctionAsync` qua `.server`/`.admin` từ client ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
