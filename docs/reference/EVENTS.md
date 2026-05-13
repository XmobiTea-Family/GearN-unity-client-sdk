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
