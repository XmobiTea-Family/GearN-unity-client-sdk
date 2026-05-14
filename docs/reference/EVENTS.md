# Reference: Server Events

SDK cung cấp 6 server event handler đẩy realtime update từ backend qua socket. Mỗi handler expose 1 static callback `onUpdate: Action1<Payload>` — subscribe bằng cách gán function vào field này.

## Chọn handler nhanh

<!-- prettier-ignore -->
| Tôi cần lắng nghe... | Handler |
| --- | --- |
| Tin nhắn mới/edit trong group | `OnGroupMessageUpdateEventHandler` |
| Member join/leave/kick/role thay đổi trong group | `OnGroupMemberUpdateEventHandler` |
| Quan hệ friend của **game player** hiện tại đổi | `OnGamePlayerFriendUpdateEventHandler` |
| Quan hệ group của **game player** hiện tại đổi | `OnGamePlayerGroupUpdateEventHandler` |
| Quan hệ friend của **character player** hiện tại đổi | `OnCharacterPlayerFriendUpdateEventHandler` |
| Quan hệ group của **character player** hiện tại đổi | `OnCharacterPlayerGroupUpdateEventHandler` |

## Rule cứng

- Event chỉ đến khi **socket đã connect + đã authenticate**. Xem [RULES.md § 7](/docs/RULES.md#7-auth--socket-flow).
- Callback là **static field** dùng chung toàn app session. Gán lần cuối ghi đè lần trước; không có mechanism multi-subscriber built-in. Nếu cần fan-out, tự wrap dispatcher.
- Cleanup copy-safe = gán callback no-op hoặc remove listener trong wrapper dispatcher của app. Không có event nào “drain” callback khi socket disconnect.
- Callback nhận đã-deserialized payload. Không thao tác với `OperationEvent` raw trừ khi viết handler custom.
- Không giả định realtime tự chạy chỉ vì đã gọi method HTTP (friend, group, …). Chỉ các event liệt kê dưới đây được SDK lắng nghe mặc định.

## Delivery guarantee

- Best-effort. Nếu socket disconnect, event mất trong khoảng ngắt; SDK không replay.
- Sau khi reconnect + re-auth, backend có thể gửi snapshot mới; ứng dụng nên merge idempotent theo id entity.

<a id="custom-operationevent"></a>

## Custom `OperationEvent` từ CloudScript / MasterPlayer

Ngoài 6 handler built-in ở trên, backend có thể đẩy event tự định nghĩa bằng `OperationEvent`:

- CloudScript: `socket.sendEventTo(...)`, `socket.sendEventToMoreUser(...)`, `socket.sendEventToAllPlayer(...)`, `socket.sendEventToRoom(...)`; nếu project có wrapper dạng `event.send(operationEvent)` thì client-side pattern vẫn giống nhau.
- SDK/Admin/Server API có thể phát custom event qua `sendSocketOperationEventAsync(...)`.

Client nhận các event này qua socket giống event built-in. Khác biệt chính: SDK không biết sẵn payload class của event custom, nên app phải tự route theo `event.getEventCode()` và đọc `event.getParameters()`.

### Cách nhanh: raw event handler

`GNNetwork.setOnEventHandler(...)` nhận **mọi** server event raw. Đây là cách đơn giản nhất khi app chỉ cần vài custom event.

```csharp
using UnityEngine;
using XmobiTea.GearN;

GNNetwork.setOnEventHandler(operationEvent =>
{
    if (operationEvent.getEventCode() == "cloudScript.rewardGranted")
    {
        var p = operationEvent.getParameters();
        if (p == null) return;

        var rewardId = p.getString("rewardId", string.Empty);
        var amount = p.getInt("amount", 0);
        var reason = p.getString("reason", string.Empty);

        // update UI/cache
        Debug.Log($"reward event {rewardId} {amount} {reason}");
    }
});
```

Rule quan trọng:

- Gọi `GNNetwork.setOnEventHandler(null)` để clear raw slot khi teardown.
- Cleanup bằng cách gán no-op: `GNNetwork.setOnEventHandler(_ => { });`.
- `setOnEventHandler` là single-slot; gọi lần sau sẽ ghi đè lần trước. Nếu nhiều module cần nghe custom event, tự build dispatcher.
- Handler này cũng thấy event built-in. Luôn filter bằng `event.getEventCode()`.
- `event.getParameters()` là `GNHashtable` hoặc `null`; đọc field bằng `getString`, `getInt`/`getLong`/`getDouble`, `getBool`, `getGNHashtable`, `getGNArray`.

### Cách có cấu trúc: custom `IServerEventHandler` + DTO attribute

Khi custom event nhiều hơn hoặc muốn payload typed giống các handler built-in, tạo payload class có một hoặc nhiều attribute trong bộ `[DataMember]`, `[StringDataMember]`, `[NumberDataMember]`, `[BooleanDataMember]`, `[GNHashtableDataMember]`, `[GNArrayDataMember]`, rồi tạo class implement `IServerEventHandler`.

Pattern này giống `OnCharacterPlayerGroupUpdateEventHandler`: `handle()` nhận raw `OperationEvent`, gọi `ConverterService.deserializeObject<PayloadClass>(operationEvent.getParameters())`, rồi forward sang `onUpdate`.

Chi tiết đầy đủ về các attribute `[DataMember]`, `[StringDataMember]`, `[NumberDataMember]`, `[BooleanDataMember]`, `[GNHashtableDataMember]`, `[GNArrayDataMember]`: [DATAMEMBER.md](/docs/reference/DATAMEMBER.md).

```csharp
using UnityEngine;
using XmobiTea.GearN;
using XmobiTea.GearN.Common;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity;
using XmobiTea.GearN.Helper;
using XmobiTea.GearN.Networking;

public class CloudScriptRewardGranted
{
    [StringDataMember(code = "rewardId")]
    public string rewardId;

    [NumberDataMember(code = ParameterCode.Amount)]
    public int amount;

    [StringDataMember(code = ParameterCode.Reason, isOptional = true)]
    public string reason;

    [StringDataMember(code = "sourceUserId", isOptional = true)]
    public string sourceUserId;

    [NumberDataMember(code = ParameterCode.Ts, isOptional = true)]
    public long ts;
}

public class CloudScriptRewardEventHandler : IServerEventHandler
{
    public static Action1<CloudScriptRewardGranted> onUpdate;

    public string getEventCode() => "cloudScript.rewardGranted";

    public void handle(OperationEvent operationEvent)
    {
        CloudScriptRewardEventHandler.onUpdate?.Invoke(
            ConverterService.deserializeObject<CloudScriptRewardGranted>(operationEvent.getParameters())
        );
    }
}

// Subscribe trước khi connect socket để không miss event sau handshake.
GNNetwork.subscriberServerEventHandler(new CloudScriptRewardEventHandler());

CloudScriptRewardEventHandler.onUpdate = payload =>
{
    Debug.Log($"reward event {payload.rewardId} {payload.amount} {payload.reason}");
};
```

Ghi chú:

- `getEventCode()` phải trả đúng string mà CloudScript tạo trong `new OperationEvent(eventCode, parameters)` hoặc field `request.eventCode`.
- Attribute `code` phải trùng key trong `GNHashtable` payload. Có thể dùng `ParameterCode.*` cho key chuẩn của SDK, hoặc string literal cho key custom như `"rewardId"`.
- Với integration app, cách chắc nhất là tạo instance và gọi `GNNetwork.subscriberServerEventHandler(...)` trước `GNNetwork.connectSocket()`.

### Gửi custom event bằng `GNNetwork.masterPlayer.sendSocketOperationEvent`

Operation này là HTTP operation backend-routed để bắn socket event tới player đang online. Nó vẫn phải check 2 tầng `returnCode` / `errorCode` như API bình thường.

```csharp
using System;
using XmobiTea.GearN;
using XmobiTea.GearN.Common;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var eventParameters = new GNHashtable();
eventParameters.add("rewardId", "daily-login");
eventParameters.add("amount", 100);
eventParameters.add("reason", "dailyLogin");
eventParameters.add("sourceUserId", "server");
eventParameters.add("ts", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());

var request = new MasterPlayerModels.SendSocketOperationEventRequestData();
request.userId = targetUserId; // optional trên client route nếu gửi cho chính user đang auth
request.eventCode = "cloudScript.rewardGranted";
request.eventParameters = eventParameters;

var res = await GNNetwork.masterPlayer.sendSocketOperationEventAsync(request);
if (res.returnCode != ReturnCode.Ok) return;
if (res.errorCode != ErrorCode.Ok) return;
```

## Bảng event

<!-- prettier-ignore -->
| Handler | EventCode (logical) | Payload class | Trigger |
| --- | --- | --- | --- |
| `OnGroupMessageUpdateEventHandler` | `OnGroupMessageUpdate` | `GroupMessageUpdate` | Tin nhắn group mới, edit, hoặc stream sync |
| `OnGroupMemberUpdateEventHandler` | `OnGroupMemberUpdate` | `GroupMemberUpdate` | Member join/leave/kick/role thay đổi |
| `OnGamePlayerFriendUpdateEventHandler` | `OnGamePlayerFriendUpdate` | `GamePlayerFriendUpdate` | Friend relation của game player hiện tại đổi |
| `OnGamePlayerGroupUpdateEventHandler` | `OnGamePlayerGroupUpdate` | `GamePlayerGroupUpdate` | Group relation của game player hiện tại đổi |
| `OnCharacterPlayerFriendUpdateEventHandler` | `OnCharacterPlayerFriendUpdate` | `CharacterPlayerFriendUpdate` | Friend relation của character hiện tại đổi |
| `OnCharacterPlayerGroupUpdateEventHandler` | `OnCharacterPlayerGroupUpdate` | `CharacterPlayerGroupUpdate` | Group relation của character hiện tại đổi |

---

## `OnGroupMessageUpdateEventHandler`

**Import:**

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;
```

**Subscribe shape:** `static onUpdate: Action1<GroupMessageUpdate>`

**Payload `GroupMessageUpdate`:**

<!-- prettier-ignore -->
| Field | Type | Optional | Notes |
| --- | --- | --- | --- |
| `groupMessages` | `Array<GroupModels.GroupMessageResponseData>` | no | Batch message item mới/changed |
| `groupId` | `string` | no | Group id có message stream đổi |
| `characterId` | `string` | yes | Có khi update scope theo character context |

**Ví dụ:**

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

OnGroupMessageUpdateEventHandler.onUpdate = payload => {
    UnityEngine.Debug.Log("group " + payload.groupId + " received " + payload.groupMessages.Count + " messages");
    foreach (var msg in payload.groupMessages) {
        // render msg
    }
};

// Cleanup copy-safe
OnGroupMessageUpdateEventHandler.onUpdate = _ => {};
```

---

## `OnGroupMemberUpdateEventHandler`

**C# namespace:** `XmobiTea.GearN.Networking.Handler` (`OnGroupMemberUpdateEventHandler`)

**Subscribe:** `static onUpdate: Action1<GroupMemberUpdate>`

**Payload `GroupMemberUpdate`:**

<!-- prettier-ignore -->
| Field | Type | Optional | Notes |
| --- | --- | --- | --- |
| `members` | `Array<GenericModels.MemberItem>` | no | Member relation item đổi trong batch |
| `groupId` | `string` | no | Group id có member roster đổi |

**Ví dụ:**

```csharp
OnGroupMemberUpdateEventHandler.onUpdate = payload => {
    var groupId = payload.groupId;
    foreach (var m in payload.members) {
        // update member cache
    }
};
```

---

## `OnGamePlayerFriendUpdateEventHandler`

**C# namespace:** `XmobiTea.GearN.Networking.Handler` (`OnGamePlayerFriendUpdateEventHandler`)

**Subscribe:** `static onUpdate: Action1<GamePlayerFriendUpdate>`

**Payload `GamePlayerFriendUpdate`:**

<!-- prettier-ignore -->
| Field | Type | Optional | Notes |
| --- | --- | --- | --- |
| `playerFriends` | `Array<GenericModels.FriendItem>` | no | Friend relation item đổi (add/accept/remove/status) |

**Ví dụ:**

```csharp
OnGamePlayerFriendUpdateEventHandler.onUpdate = payload => {
    foreach (var f in payload.playerFriends) {
        // switch (f.status) { ... }
    }
};
```

---

## `OnGamePlayerGroupUpdateEventHandler`

**C# namespace:** `XmobiTea.GearN.Networking.Handler` (`OnGamePlayerGroupUpdateEventHandler`)

**Subscribe:** `static onUpdate: Action1<GamePlayerGroupUpdate>`

**Payload `GamePlayerGroupUpdate`:**

<!-- prettier-ignore -->
| Field | Type | Optional | Notes |
| --- | --- | --- | --- |
| `playerGroups` | `Array<GenericModels.GroupItem>` | no | Group relation item đổi (join/leave/status) |

**Ví dụ:**

```csharp
OnGamePlayerGroupUpdateEventHandler.onUpdate = payload => {
    foreach (var f in payload.playerGroups) {
        // switch (f.status) { ... }
    }
};
```

---

## `OnCharacterPlayerFriendUpdateEventHandler`

**C# namespace:** `XmobiTea.GearN.Networking.Handler` (`OnCharacterPlayerFriendUpdateEventHandler`)

**Subscribe:** `static onUpdate: Action1<CharacterPlayerFriendUpdate>`

**Payload `CharacterPlayerFriendUpdate`:**

<!-- prettier-ignore -->
| Field | Type | Optional | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | no | Character id có friend relation đổi |
| `playerFriends` | `Array<GenericModels.FriendItem>` | no | Friend relation item đổi |

**Ví dụ:**

```csharp
OnCharacterPlayerFriendUpdateEventHandler.onUpdate = payload => {
    var characterId = payload.characterId;
    foreach (var f in payload.playerFriends) {
        // switch (f.status) { ... }
    }
};
```

---

## `OnCharacterPlayerGroupUpdateEventHandler`

**C# namespace:** `XmobiTea.GearN.Networking.Handler` (`OnCharacterPlayerGroupUpdateEventHandler`)

**Subscribe:** `static onUpdate: Action1<CharacterPlayerGroupUpdate>`

**Payload `CharacterPlayerGroupUpdate`:**

<!-- prettier-ignore -->
| Field | Type | Optional | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | no | Character id có group relation đổi |
| `playerGroups` | `Array<GenericModels.GroupItem>` | no | Group relation item đổi |

**Ví dụ:**

```csharp
OnCharacterPlayerGroupUpdateEventHandler.onUpdate = payload => {
    var characterId = payload.characterId;
    foreach (var f in payload.playerGroups) {
        // switch (f.status) { ... }
    }
};
```

---

## Pattern khuyến nghị

- Subscribe trước khi gọi `GNNetwork.connectSocket()` để không bỏ lỡ event ngay sau handshake.
- Callback phải nhanh; delegate work nặng sang queue/dispatcher riêng để tránh block socket loop.
- Nếu app có nhiều consumer cho cùng event, build wrapper:

```csharp
var groupMessageListeners = new System.Collections.Generic.List<System.Action<GroupMessageUpdate>>();

OnGroupMessageUpdateEventHandler.onUpdate = payload => {
    foreach (var listener in groupMessageListeners) listener(payload);
};

System.Action SubscribeGroupMessage(System.Action<GroupMessageUpdate> listener)
{
    groupMessageListeners.Add(listener);
    return () => {
        groupMessageListeners.Remove(listener);
    };
}
```

---

## Liên kết

- Socket auth flow: [RULES.md § 7](/docs/RULES.md#7-auth--socket-flow)
- `FriendStatus` / `GroupStatus` giá trị numeric: [ENUMS.md](/docs/reference/ENUMS.md)
- API gây event: [API group guides](/docs/guides/)
