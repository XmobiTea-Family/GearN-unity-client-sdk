# Cookbook

16 scenario end-to-end phổ biến. Mỗi scenario có: problem, prerequisites, APIs used, code snippet, return path handling, pitfall.

> Tất cả snippet dùng import từ package name `com.xmobitea.changx.gearn-unity-client-sdk`. Ví dụ dùng dạng `async/await` (form `*Async()`). Các comment trong snippet là điểm nối vào logic ứng dụng của bạn.

## Index

Đọc đúng range của scenario bạn cần — không cần load cả file. Khi dùng Read tool: `offset = startLine - 1`, `limit = endLine - startLine + 1`.

<!-- prettier-ignore -->
| # | Scenario | Range |
| --- | --- | --- |
| 1 | Init SDK + bootstrap tối thiểu | [COOKBOOK.md:33-55](docs/COOKBOOK.md) |
| 2 | Login by account + retrieve profile | [COOKBOOK.md:56-113](docs/COOKBOOK.md) |
| 3 | Refresh token và persist session | [COOKBOOK.md:114-157](docs/COOKBOOK.md) |
| 4 | Login by social (Google/Apple/Facebook) | [COOKBOOK.md:158-206](docs/COOKBOOK.md) |
| 5 | Connect socket + handle reconnect | [COOKBOOK.md:207-249](docs/COOKBOOK.md) |
| 6 | Subscribe friend updates | [COOKBOOK.md:250-303](docs/COOKBOOK.md) |
| 7 | Subscribe + send group message | [COOKBOOK.md:304-356](docs/COOKBOOK.md) |
| 8 | Group member lifecycle (join / leave / kick) + realtime update | [COOKBOOK.md:357-410](docs/COOKBOOK.md) |
| 9 | Matchmaking ticket flow | [COOKBOOK.md:411-479](docs/COOKBOOK.md) |
| 10 | Inventory: query + grant item (server role) | [COOKBOOK.md:480-529](docs/COOKBOOK.md) |
| 11 | Store: list catalog → purchase → validate receipt | [COOKBOOK.md:530-597](docs/COOKBOOK.md) |
| 12 | CloudScript: execute function + customTags | [COOKBOOK.md:598-651](docs/COOKBOOK.md) |
| 13 | Override authToken / secret (impersonate, cross-role) | [COOKBOOK.md:652-705](docs/COOKBOOK.md) |
| 14 | Admin login qua DashboardApi | [COOKBOOK.md:706-752](docs/COOKBOOK.md) |
| 15 | Cleanup & shutdown flow | [COOKBOOK.md:753-797](docs/COOKBOOK.md) |
| 16 | Diagnose `OperationNotAllow` | [COOKBOOK.md:798-908](docs/COOKBOOK.md) |

---

## Scenario 1: Init SDK + bootstrap tối thiểu

**Problem:** Lần đầu khởi chạy ứng dụng — cần init SDK để bất kỳ API nào hoạt động.

**Prerequisites:** biết server address/port và `secretKey` backend cấp.

**APIs used:** `Resources/GNServerSettings`, `GNServerSettings`.

Code mẫu đầy đủ (có comment từng field): [README § 4](/README.md#4-config-cơ-bản). Minimal pattern: [AI_CHEATSHEET § 1](/docs/AI_CHEATSHEET.md#1-mandatory-pattern-sao-chép--dùng).

### Return paths

- Unity SDK không có `GNNetwork.init(...)`; lần truy cập `GNNetwork` đầu tiên trong Play Mode sẽ load `Resources/GNServerSettings`.
- Không có network call ở bước này; lỗi cấu hình thường gặp là gọi `GNServerSettings asset` thiếu field required trong `GNServerSettings`.

### Pitfalls

- `logType: LogType.All` trong production làm console spam. Dùng `LogType.Error` hoặc `LogType.Off`.
- Gọi lại `Resources/GNServerSettings` để đổi settings không có hiệu lực. Setter trên cùng `settings` object sau init chỉ ảnh hưởng một số request mới và không tự reconnect socket.
- Full anti-patterns: [RULES § 10](/docs/RULES.md#10-anti-patterns--pitfalls). Full field schema: [reference/CONFIG.md](/docs/reference/CONFIG.md).

---

## Scenario 2: Login by account + retrieve profile

**Problem:** User nhập username/password → gọi login → nhận profile + cache auth token để request sau tự động attach.

**Prerequisites:** đã tạo/cấu hình `Resources/GNServerSettings`.

**APIs used:** [`GNNetwork.authenticate.loginByAccountAsync`](/docs/guides/AUTHENTICATE.md), [API_AUTHENTICATE.md](/docs/reference/API_AUTHENTICATE.md), [`AuthenticateModels.LoginByAccountRequestData`](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbyaccountrequestdata), [`AuthenticateModels.InfoRequestParam`](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam).

### Code

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

private async System.Threading.Tasks.Task<object> LoginWithAccountAsync(string username, string password) {
    var infoRequestParam = new AuthenticateModels.InfoRequestParam();
    infoRequestParam.displayName = true;
    infoRequestParam.avatar = true;
    infoRequestParam.playerCurrencies = true;
    infoRequestParam.tsCreate = true;

    var requestData = new AuthenticateModels.LoginByAccountRequestData();
    requestData.username = username;
    requestData.password = password;
    requestData.infoRequestParam = infoRequestParam;

    var response = await GNNetwork.authenticate.loginByAccountAsync(requestData);

    if (response.returnCode != ReturnCode.Ok) {
        UnityEngine.Debug.LogError("transport error: " + response.returnCode + ", " + response.debugMessage);
        return null;
    }
    if (response.errorCode != ErrorCode.Ok) {
        UnityEngine.Debug.LogWarning("business error: " + response.errorCode + ", invalidMembers=" + response.invalidMembers);
        return null;
    }

    // AuthenticateApi success auto-caches authToken + userId into AuthenticateStatus/StorageService.
    return response.responseData; // AuthenticateResponseData
}
```

### Return paths

- Happy: `ReturnCode.Ok` + `ErrorCode.Ok` → SDK cache `authToken` + `userId`; response có profile fields enabled trong `InfoRequestParam`.
- `ReturnCode.OperationTimeout` (-1) → retry sau nếu idempotent.
- `ErrorCode.AccountNotFound` (2) hoặc `ErrorCode.AccountPasswordWrong` → báo user.
- `ReturnCode.InvalidRequestParameters` với `invalidMembers` → có field request sai format (ví dụ username < 6 chars).

### Pitfalls

- Đọc `responseData` trước khi check đủ 2 tầng → có thể dùng payload chưa đáng tin.
- Set `infoRequestParam.customDatas = true` nhưng không set `customDataKeys` → backend có thể trả TẤT CẢ custom data, tốn bandwidth.
- `username`/`password` < 6 ký tự → backend reject với `ReturnCode.InvalidRequestParameters` trước khi query DB.

---

## Scenario 3: Refresh token và persist session

**Problem:** Token sắp hết hạn (hoặc user mở lại app sau 1 ngày) → refresh để lấy token mới, tránh bắt login lại.

**Prerequisites:** đã có `authToken` cache từ lần login trước (stored ở `StorageService`).

**APIs used:** [`GNNetwork.authenticate.refreshAuthTokenAsync`](/docs/guides/AUTHENTICATE.md), [API_AUTHENTICATE.md](/docs/reference/API_AUTHENTICATE.md).

### Code

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

private async System.Threading.Tasks.Task<bool> EnsureValidTokenAsync() {
    // refreshAuthToken uses cached auth context — không cần truyền field nào
    var res = await GNNetwork.authenticate.refreshAuthTokenAsync(new AuthenticateModels.RefreshAuthTokenRequestData());

    if (res.returnCode != ReturnCode.Ok) return false;
    if (res.errorCode != ErrorCode.Ok) return false;

    return true;
}

// On app start:
if (!(await ensureValidToken())) {
    // redirect về login screen
}
```

### Return paths

- Happy → `authToken` mới được SDK cache, session tiếp tục.
- `ReturnCode.OperationNotAuthorized` hoặc `ErrorCode.VerifyTokenError` → token cũ invalid/expired; cần login lại.
- `ErrorCode.PlayerBan` → user bị ban; xem `res.responseData.playerBan` (BanItem với tsExpire + reason).

### Pitfalls

- Không có `authToken` cache → request gửi đi thiếu auth, reject.
- Refresh thành công nhưng app vẫn dùng token tự lưu bên ngoài SDK → đồng bộ lại storage riêng của app từ `GNNetwork.getAuthenticateStatus()` nếu có.

---

## Scenario 4: Login by social (Google/Apple/Facebook)

**Problem:** User chọn đăng nhập bằng Google (hoặc Apple, Facebook, Game Center, GooglePlayGameService …).

**Prerequisites:** đã init; đã có ID token từ social SDK native.

**APIs used:** `loginByGoogleAsync`, `loginByAppleAsync`, `loginByFacebookAsync`, `loginByGameCenterAsync`, `loginByGooglePlayGameServiceAsync` — cùng pattern. Xem [AUTHENTICATE guide](/docs/guides/AUTHENTICATE.md) trước, rồi tra [API_AUTHENTICATE.md](/docs/reference/API_AUTHENTICATE.md).

### Code

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

private async System.Threading.Tasks.Task<object> LoginWithGoogleAsync(string idToken) {
    var infoRequestParam = new AuthenticateModels.InfoRequestParam();
    infoRequestParam.displayName = true;
    infoRequestParam.avatar = true;

    var requestData = new AuthenticateModels.LoginByGoogleRequestData();
    requestData.token = idToken;
    requestData.type = (int)GoogleLoginType.IdToken;
    requestData.createPlayerIfNotExists = true;
    requestData.infoRequestParam = infoRequestParam;

    var response = await GNNetwork.authenticate.loginByGoogleAsync(requestData);

    if (response.returnCode != ReturnCode.Ok || response.errorCode != ErrorCode.Ok) return null;

    // AuthenticateApi success auto-caches authToken + userId.
    if (response.responseData.newlyCreated) UnityEngine.Debug.Log("new player created");
    return response.responseData;
}
```

### Return paths

- Happy → `authToken` + `newlyCreated` flag cho biết user mới hay đã tồn tại.
- `ErrorCode.VerifyTokenError` hoặc `ErrorCode.VerifyFailed` → ID token social invalid/expired.
- `ErrorCode.ExternalLinkedOtherAccount` hoặc `ErrorCode.ExternalLinkedOtherValue` → social id đã liên kết account khác.

### Pitfalls

- `createPlayerIfNotExists: false` với social id chưa từng login → `ErrorCode.AccountNotFound`. Set `true` cho flow "login hoặc register" tự động.
- Apple ID token có lifetime rất ngắn; lấy xong phải call ngay.

---

## Scenario 5: Connect socket + handle reconnect

**Problem:** Cần realtime event (group message, friend update, …) — phải connect socket.

**Prerequisites:** đã login (có `authToken` cache); `useSocket: true` trong settings.

**APIs used:** `GNNetwork.connectSocket`, `GNNetwork.sendRequestAuthSocket`, `GNNetwork.subscriberOnConnectHandler`, `GNNetwork.subscriberOnDisconnectHandler`.

### Code

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

GNNetwork.subscriberOnConnectHandler(() => {
    UnityEngine.Debug.Log("socket connected, sid=", GNNetwork.getSocketSId());
    // SDK auto-auths the socket if an auth token is already cached.
    // Call GNNetwork.sendRequestAuthSocket() manually only when login/token refresh happens after this connect.
});

GNNetwork.subscriberOnDisconnectHandler(() => {
    UnityEngine.Debug.LogWarning("socket disconnected — SDK will auto-reconnect after reconnectDelay ms");
});

GNNetwork.connectSocket(() => {
    // optional one-shot callback on first connect
});
```

### Return paths

- Connect thành công → `onConnect` callback fire; `isSocketConnected()` trả `true`.
- Disconnect do network → SDK tự retry sau `reconnectDelay` (default 5000ms). Mỗi lần reconnect sẽ fire `onConnect` handler lại.

### Pitfalls

- Nếu socket connect trước khi login/token refresh, cần gọi `sendRequestAuthSocket()` sau khi token có trong cache để re-auth thủ công.
- `subscriberOnConnectHandler` gắn MULTIPLE callback, mỗi lần reconnect đều fire tất cả. Dùng `unscriberOnConnectHandler` khi cleanup.
- `connectSocket()` khi thiếu `Resources/GNServerSettings` hoặc chưa cấu hình socket/secret đúng → không handshake hoặc không auth được socket.

---

## Scenario 6: Subscribe friend updates

**Problem:** Hiển thị UI danh sách bạn bè realtime (thêm/xóa/thay đổi status).

**Prerequisites:** socket đã connected + authenticated (scenario 5).

**APIs used:** [`OnGamePlayerFriendUpdateEventHandler`](/docs/reference/EVENTS.md#ongameplayerfriendupdateeventhandler).

### Code

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

OnGamePlayerFriendUpdateEventHandler.onUpdate = (payload) => {
    // payload.playerFriends: Array<GenericModels.FriendItem>
    foreach (var f in payload.playerFriends ?? new System.Collections.Generic.List<GenericModels.FriendItem>()) {
        switch (f.status) {
            case FriendStatus.Friend: {
                upsertFriendInUI(f);
                break;
            }
            case FriendStatus.WaitingAccept:
            case FriendStatus.SentRequestAndWaitingAccept: {
                showFriendRequest(f);
                break;
            }
            case FriendStatus.NotFriend: {
                removeFriendFromUI(f.friendId);
                break;
            }
        }
    }
};

// Cleanup khi user logout hoặc navigate đi
private void Unsubscribe() {
    OnGamePlayerFriendUpdateEventHandler.onUpdate = _ => {};
}
```

### Return paths

- Event fire mỗi khi friend relation thay đổi — hot path, đừng làm heavy work trong handler.
- Không có ACK trả về; delivery là at-most-once khi socket up.

### Pitfalls

- `onUpdate` là field `static` — gán nhiều component sẽ **ghi đè lẫn nhau**, chỉ handler cuối cùng fire. Dùng wrapper pattern (xem [EVENTS.md](/docs/reference/EVENTS.md)) nếu cần fan-out.
- Khi socket tạm mất kết nối → event trong interval đó KHÔNG được replay. App nên resync bằng `GNNetwork.gamePlayer.getFriendList*` sau reconnect.

---

## Scenario 7: Subscribe + send group message

**Problem:** Chat trong group — lắng nghe message đến + gửi message đi.

**Prerequisites:** đã login + connect socket + là member của `groupId`.

**APIs used:** [`OnGroupMessageUpdateEventHandler`](/docs/reference/EVENTS.md#ongroupmessageupdateeventhandler), [`GNNetwork.group.sendGroupMessageAsync`](/docs/guides/GROUP.md), [API_GROUP.md](/docs/reference/API_GROUP.md).

### Code

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

// 1. Subscribe incoming messages
OnGroupMessageUpdateEventHandler.onUpdate = (payload) => {
    if (payload.groupId != currentGroupId) return;
    foreach (var msg in payload.groupMessages ?? new System.Collections.Generic.List<GroupModels.GroupMessageResponseData>()) {
        appendMessageToUI(msg);
    }
};

// 2. Send a new message
private async System.Threading.Tasks.Task<object> SendGroupChatAsync(string groupId, string text) {
    var requestData = new GroupModels.SendGroupMessageRequestData();
    requestData.senderId = GNNetwork.getAuthenticateStatus().getUserId();
    requestData.groupId = groupId;
    requestData.message = text;

    var response = await GNNetwork.group.sendGroupMessageAsync(requestData);

    if (response.returnCode != ReturnCode.Ok || response.errorCode != ErrorCode.Ok) {
        UnityEngine.Debug.LogWarning("send failed: " + response.errorCode + ", " + response.debugMessage);
        return false;
    }
    return true;
}
```

### Return paths

- Response `sendGroupMessageAsync` trả về nhanh khi server đã nhận — event `OnGroupMessageUpdate` sẽ fire cho TẤT CẢ member trong group (bao gồm sender).
- `ErrorCode.PlayerNotMember` hoặc `ReturnCode.OperationNotAllow` → user không phải member hoặc secret thiếu permission gửi message.
- `ErrorCode.GroupNotFound` → `groupId` sai.

### Pitfalls

- Optimistic UI: nếu append message ngay sau khi gọi send thành công, và event handler cũng append → duplicate. Dùng messageId server trả về để dedupe.
- Event `OnGroupMessageUpdate` có thể payload nhiều message cùng lúc (khi backend batch) — luôn lặp `payload.groupMessages`.

---

## Scenario 8: Group member lifecycle (join / leave / kick) + realtime update

**Problem:** User join/leave group, và mọi member khác thấy roster update realtime.

**Prerequisites:** đã login + connect socket.

**APIs used:** `GNNetwork.gamePlayer.joinGroupAsync`, `GNNetwork.gamePlayer.leaveGroupAsync`, `GNNetwork.group.server.removeMemberAsync`, [`OnGroupMemberUpdateEventHandler`](/docs/reference/EVENTS.md#ongroupmemberupdateeventhandler).

### Code

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

OnGroupMemberUpdateEventHandler.onUpdate = (payload) => {
    if (payload.groupId != currentGroupId) return;
    foreach (var m in payload.members ?? new System.Collections.Generic.List<GenericModels.MemberItem>()) {
        // MemberItem.status is backend-defined; update idempotently and resync roster after reconnect.
        roster.upsert(m);
    }
};

private async System.Threading.Tasks.Task<object> JoinAsync(string groupId) {
    var requestData = new GamePlayerModels.JoinGroupRequestData();
    requestData.groupId = groupId;

    var response = await GNNetwork.gamePlayer.joinGroupAsync(requestData);
    if (response.returnCode != ReturnCode.Ok || response.errorCode != ErrorCode.Ok) {
        if (response.errorCode == ErrorCode.GroupNotFound) return "group_not_found";
        return "error";
    }
    return "ok";
}

private async System.Threading.Tasks.Task LeaveAsync(string groupId) {
    var requestData = new GamePlayerModels.LeaveGroupRequestData();
    requestData.groupId = groupId;

    await GNNetwork.gamePlayer.leaveGroupAsync(requestData);
}
```

### Return paths

- Join OK → event `OnGroupMemberUpdate` fire với status `Joined`.
- `ErrorCode.GroupNotFound`, `ErrorCode.GamePlayerNotFound`, `ErrorCode.PlayerBan`, hoặc `ReturnCode.OperationNotAllow` → xử lý theo context.

### Pitfalls

- `removeMember` là method `.server` namespace — chỉ call được nếu có `secretKey` có `permission rules` có `group.removeMember.serverSelfEnable`. Từ client thường expose qua CloudScript.

---

## Scenario 9: Matchmaking ticket flow

**Problem:** User bấm "Find match" → enqueue ticket → poll status → vào match khi ghép xong.

**Prerequisites:** đã login + connect socket.

**APIs used:** `GNNetwork.multiplayer.createMatchmakingTicketAsync`, `getMatchmakingTicketAsync`, `cancelMatchmakingTicketAsync`. Xem [MULTIPLAYER guide](/docs/guides/MULTIPLAYER.md) trước, rồi tra [API_MULTIPLAYER.md](/docs/reference/API_MULTIPLAYER.md).

### Code

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

private async System.Threading.Tasks.Task<object> FindMatchAsync(string queueName) {
    var createRequestData = new MultiplayerModels.CreateMatchmakingTicketRequestData();
    createRequestData.queueName = queueName;
    createRequestData.giveUpAfterSeconds = 60;
    createRequestData.attribute = XmobiTea.GearN.Common.GNHashtable.builder().build();

    var createResponse = await GNNetwork.multiplayer.createMatchmakingTicketAsync(createRequestData);
    if (createResponse.returnCode != ReturnCode.Ok || createResponse.errorCode != ErrorCode.Ok) {
        return null;
    }
    var ticketId = createResponse.responseData.ticketId;

    // Poll mỗi 2s cho tới khi matched hoặc timeout
    for (var i = 0; i < 30; i++) {
        await System.Threading.Tasks.Task.Delay(2000);
        var pollRequestData = new MultiplayerModels.GetMatchmakingTicketRequestData();
        pollRequestData.ticketId = ticketId;
        pollRequestData.returnMember = true;

        var pollResponse = await GNNetwork.multiplayer.getMatchmakingTicketAsync(pollRequestData);
        if (pollResponse.returnCode != ReturnCode.Ok || pollResponse.errorCode != ErrorCode.Ok) continue;

        var ticket = pollResponse.responseData.matchmakingTicket;
        var status = ticket.status;
        if (status == (int)MatchmakingTicketStatus.Matched) {
            return ticket.matchId;
        }
        if (status == (int)MatchmakingTicketStatus.Canceled) {
            return null;
        }
    }

    // Timeout: cancel ticket để queue không giữ slot
    var cancelRequestData = new MultiplayerModels.CancelMatchmakingTicketRequestData();
    cancelRequestData.ticketId = ticketId;

    await GNNetwork.multiplayer.cancelMatchmakingTicketAsync(cancelRequestData);
    return null;
}
```

### Return paths

- `MatchmakingTicketStatus.Matched` → có `matchId`, chuyển sang scene game.
- `WaitingForMembers`, `WaitingForMatch`, `WaitingForServer` → tiếp tục poll.
- `Canceled` → abort.

### Pitfalls

- Không cancel khi user hủy → ticket vẫn trong queue, occupy slot tới khi server timeout.
- Poll interval quá ngắn (<1s) → rate-limit reject.

---

## Scenario 10: Inventory query + grant item (server role)

**Problem:** Client xem inventory; backend/CloudScript grant item cho player khác.

**Prerequisites:** client login; `secretKey` có `permission rules` là `admin` hoặc `server` cấu hình ở backend/CloudScript.

**APIs used:** [`GNNetwork.gamePlayer.getPlayerInventoryAsync`](/docs/guides/GAME_PLAYER.md) (client), `GNNetwork.gamePlayer.server.createPlayerItemAsync` (server), [API_GAME_PLAYER.md](/docs/reference/API_GAME_PLAYER.md).

### Code

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

// Client: xem inventory của chính mình
private async System.Threading.Tasks.Task<object> LoadMyInventoryAsync() {
    var requestData = new GamePlayerModels.GetPlayerInventoryRequestData();
    requestData.itemCatalogIds = new[] { "weapon" };

    var response = await GNNetwork.gamePlayer.getPlayerInventoryAsync(requestData);
    if (response.returnCode != ReturnCode.Ok || response.errorCode != ErrorCode.Ok) return null;
    return response.responseData.infoResponseParameters?.playerInventories;
}

// Server: create/grant 1 sword cho player targetUserId
private async System.Threading.Tasks.Task<object> GrantSwordAsync(string targetUserId) {
    var requestData = new GamePlayerModels.ServerCreatePlayerItemRequestData();
    requestData.userId = targetUserId;
    requestData.catalogId = "weapon";
    requestData.classId = "sword_001";
    requestData.displayName = "Starter Sword";
    requestData.amount = 1;

    var response = await GNNetwork.gamePlayer.server.createPlayerItemAsync(requestData);
    return response.returnCode == ReturnCode.Ok && response.errorCode == ErrorCode.Ok;
}
```

### Return paths

- Client query → không truyền `userId` nên backend resolve inventory của game player đang authenticate.
- Server grant → nếu `secretKey` sai/thiếu → `ReturnCode.SecretInvalid`; nếu secret hợp lệ nhưng thiếu flag → `ReturnCode.OperationNotAllow`.

### Pitfalls

- NÊN gọi `.server` trong backend Node service hoặc CloudScript.

---

## Scenario 11: Store list catalog → purchase → validate receipt

**Problem:** User mở shop → chọn item → mua → xác nhận nhận hàng.

**Prerequisites:** đã login.

**APIs used:** [`GNNetwork.storeInventory.getStoreItemsWithTagAsync`](/docs/guides/STORE_INVENTORY.md), `buyStoreItemAsync`, `server.validateGooglePlayStoreReceiptAsync` / `server.validateAppleAppStoreReceiptAsync`, [API_STORE_INVENTORY.md](/docs/reference/API_STORE_INVENTORY.md).

### Code

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

private async System.Threading.Tasks.Task<object> ListCatalogAsync() {
    var infoRequestParam = new StoreInventoryModels.InfoRequestParam();
    infoRequestParam.displayName = true;
    infoRequestParam.tags = true;

    var requestData = new StoreInventoryModels.GetStoreItemsWithTagRequestData();
    requestData.key = "visible";
    requestData.value = "true";
    requestData.infoRequestParam = infoRequestParam;
    requestData.skip = 0;
    requestData.limit = 50;

    var response = await GNNetwork.storeInventory.getStoreItemsWithTagAsync(requestData);
    if (response.returnCode != ReturnCode.Ok || response.errorCode != ErrorCode.Ok) return null;
    return response.responseData.results;
}

private async System.Threading.Tasks.Task<object> BuyItemAsync(string storeItemId) {
    var requestData = new StoreInventoryModels.BuyStoreItemRequestData();
    requestData.storeId = storeItemId;
    requestData.id = GNNetwork.getAuthenticateStatus().getUserId();
    requestData.type = OwnerType.GamePlayer;
    requestData.log = "shop_purchase";

    var response = await GNNetwork.storeInventory.buyStoreItemAsync(requestData);

    if (response.returnCode != ReturnCode.Ok) return "transport_error";
    switch (response.errorCode) {
        case ErrorCode.Ok:
            return "ok";
        case ErrorCode.NotEnoughCurrency:
            return "not_enough_currency";
        case ErrorCode.StoreItemRemoved:
        case ErrorCode.CanNotBuyThisStoreItem:
            return "not_buyable";
        default:
            return "unhandled_" + response.errorCode;
    }
}
```

### Return paths

- `ErrorCode.Ok` → item đã grant vào inventory player; currency đã trừ.
- `ErrorCode.NotEnoughCurrency` (8) → cần topup.
- `ErrorCode.StoreItemRemoved` hoặc `ErrorCode.CanNotBuyThisStoreItem` → item không còn mua được ở state hiện tại.

### Pitfalls

- In-app purchase (IAP) có receipt native — validate qua method cụ thể theo store, ví dụ `storeInventory.server.validateGooglePlayStoreReceiptAsync` hoặc `validateAppleAppStoreReceiptAsync`, trước khi tin kết quả grant.

---

## Scenario 12: CloudScript execute function + customTags

**Problem:** Trigger function server-side custom (ví dụ "claim daily reward") từ client.

**Prerequisites:** đã login; CloudScript function đã publish ở backend.

**APIs used:** [`GNNetwork.cloudScript.executeFunctionAsync`](/docs/guides/CLOUDSCRIPT.md), [API_CLOUDSCRIPT.md](/docs/reference/API_CLOUDSCRIPT.md).

### Code

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

private async System.Threading.Tasks.Task<object> ClaimDailyRewardAsync() {
    var requestData = new CloudScriptModels.ExecuteFunctionRequestData();
    requestData.functionName = "claimDailyReward";
    requestData.functionParameters = XmobiTea.GearN.Common.GNHashtable.builder()
        .add("date", System.DateTime.UtcNow.ToString("yyyy-MM-dd"))
        .build();

    var response = await GNNetwork.cloudScript.executeFunctionAsync(
        requestData,
        null, // overrideAuthToken
        null, // overrideSecretKey
        XmobiTea.GearN.Common.GNHashtable.builder().add("source", "daily_popup").build(), // customTags
        30 // timeout (seconds)
    );

    if (response.returnCode != ReturnCode.Ok || response.errorCode != ErrorCode.Ok) return null;

    var exec = response.responseData;
    if ((ExecuteResponseStatus)exec.status != ExecuteResponseStatus.Ok) {
        UnityEngine.Debug.LogWarning("function failed: " + exec.errorMessage);
        return null;
    }
    return exec.functionResult; // raw payload từ function
}
```

### Return paths

- `ExecuteResponseStatus.Ok` → function chạy xong, `functionResult` là value function trả về.
- `ExecuteResponseStatus.Exception` → function throw; `exec.errorMessage` chứa message.
- `ExecuteResponseStatus.FunctionNameNotFound` → function chưa publish/export hoặc sai tên.

### Pitfalls

- `customTags` là `GNHashtable`; dùng `GNHashtable.builder()` để giữ đúng public type. Giá trị nên là primitive hoặc string; không nhét object lồng.
- Timeout function mặc định 20s — function nặng (query DB lớn) nên tăng timeout param.

---

## Scenario 13: Override authToken / secret (impersonate, cross-role)

**Problem:** Đang ở role admin/server, cần gọi API như một player cụ thể (impersonate) hoặc override secret key của request cụ thể.

**APIs used:** mọi method — async form nhận `overrideAuthToken`, `overrideSecretKey` là param thứ 2-3; callback form là param thứ 3-4 vì có `onResponse`.

### Code

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

// Impersonate player để query profile của họ
private async System.Threading.Tasks.Task<object> FetchProfileAsAsync(string playerAuthToken, string playerId) {
    var infoRequestParam = new MasterPlayerModels.InfoRequestParam();
    infoRequestParam.displayName = true;
    infoRequestParam.avatar = true;

    var requestData = new MasterPlayerModels.GetPlayerInformationRequestData();
    requestData.userId = playerId;
    requestData.infoRequestParam = infoRequestParam;

    var response = await GNNetwork.masterPlayer.getPlayerInformationAsync(
        requestData,
        playerAuthToken, // overrideAuthToken — thay token cache
        null, // overrideSecretKey — giữ secret key mặc định của role
        null, // customTags
        XmobiTea.GearN.Entity.Request.OperationRequest.defaultTimeOut // timeout
    );
    return response.responseData;
}

// Dùng secret key khác (ví dụ một game khác cùng backend)
private async System.Threading.Tasks.Task<object> CallOtherGameAsync(string gameSecret) {
    var requestData = new ContentModels.GetContentDataRequestData();
    requestData.keys = new[] { "config" };

    return await GNNetwork.content.getContentDataAsync(requestData, null, gameSecret);
}
```

### Return paths

- Token override bypass cache; request này KHÔNG update cached token.
- Secret override bypass `secretKey` mặc định.

### Pitfalls

- Override không persist — mỗi request phải truyền lại.
- Truyền `overrideAuthToken = ""` (rỗng) → request đi KHÔNG CÓ auth header, thường fail với `ReturnCode.OperationNotAuthorized`. Muốn dùng auth cache hiện tại thì truyền `null`.

---

## Scenario 14: Admin login qua DashboardApi

**Problem:** Tool dashboard web — cần admin login bằng username/password admin, rồi query game list / analytics.

**Prerequisites:** đã init; biết admin username/password backend cấp.

**APIs used:** [`GNNetwork.dashboard.loginByAdminAccountAsync`](/docs/guides/DASHBOARD.md), `getGameListAsync`, `getAnalyticsAsync`, [API_DASHBOARD.md](/docs/reference/API_DASHBOARD.md), …

> **Lưu ý thiết kế:** Dashboard API CHỈ có namespace client (`GNNetwork.dashboard`, không có `.server` / `.admin`). Transport dùng `RequestRole.Client`. Admin context backend resolve TỪ auth token trả về sau `loginByAdminAccount` — token này khác token của player thường.

### Code

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

private async System.Threading.Tasks.Task<object> AdminLoginAsync(string username, string password) {
    var requestData = new DashboardModels.LoginByAdminAccountRequestData();
    requestData.username = username;
    requestData.password = password;

    var response = await GNNetwork.dashboard.loginByAdminAccountAsync(requestData);
    if (response.returnCode != ReturnCode.Ok || response.errorCode != ErrorCode.Ok) return false;

    // Dashboard response carries authToken; SDK caches it for later dashboard calls.
    return true;
}

private async System.Threading.Tasks.Task<object> ListGamesAsync() {
    var response = await GNNetwork.dashboard.getGameListAsync(new DashboardModels.GetGameListRequestData());
    return response.responseData != null ? response.responseData.games : null;
}
```

### Return paths

- Happy → admin token được SDK cache; mọi dashboard method sau đó dùng token này.
- `ErrorCode.AccountNotFound` / `ErrorCode.AccountPasswordWrong` → giống player login.

### Pitfalls

- Trộn admin token với player flow → backend reject. Sau admin logout, clear token trước khi login player.
- Dashboard KHÔNG cần socket — có thể set `useSocket: false` trong settings cho web dashboard.

---

## Scenario 15: Cleanup & shutdown flow

**Problem:** User logout hoặc app shutdown — cần close socket + clear auth để session sau không leak state.

### Code

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

private void logoutAndCleanup() {
    // 1. Clear all event handler callbacks (chúng là static, không tự gc)
    OnGroupMessageUpdateEventHandler.onUpdate = _ => {};
    OnGroupMemberUpdateEventHandler.onUpdate = _ => {};
    OnGamePlayerFriendUpdateEventHandler.onUpdate = _ => {};
    OnGamePlayerGroupUpdateEventHandler.onUpdate = _ => {};
    OnCharacterPlayerFriendUpdateEventHandler.onUpdate = _ => {};
    OnCharacterPlayerGroupUpdateEventHandler.onUpdate = _ => {};

    // 2. Close socket
    GNNetwork.disconnectSocket(() => {
        UnityEngine.Debug.Log("socket closed");
    });

    // 3. Clear auth state
    var empty = new AuthenticateStatus();
    empty.setAuthToken("");
    empty.setUserId("");
    GNNetwork.setNewAuthenticateStatus(empty);
}
```

### Return paths

- `disconnectSocket` callback fire khi connection closed. Sau đó socket không auto-reconnect (stop reconnect loop).
- `setNewAuthenticateStatus` với token rỗng xóa state + localStorage entry.

### Pitfalls

- Không clear event handler → new session fire vào callback cũ trỏ tới UI component đã unmount, gây crash.
- Không đợi `disconnectSocket` callback mà shutdown process ngay → socket có thể không gửi packet `logout` tới server → backend phải đợi timeout để cleanup session.

---

## Scenario 16: Diagnose `OperationNotAllow`

**Problem:** Một API call trả `ReturnCode.OperationNotAllow`. Cần xác định root cause và fix.

**Prerequisites:** biết method đang gọi, namespace (`client` / `.server` / `.admin`), target user (nếu có), secret key đang dùng.

**Key insight:** `OperationNotAllow` **không** phải thiếu secret hoặc operation không tồn tại (đó là `SecretInvalid` và `OperationInvalid`). Đây là: secret hợp lệ, operation tồn tại, nhưng **permission rule** của secret không cho phép operation trong target context. Xem [RULES § 5](/docs/RULES.md#5-phân-biệt-3-returncode-dễ-nhầm).

### Decision tree

```
Gặp returnCode == OperationNotAllow
│
├─ Bước 1: Xác định route đang gọi
│    • GNNetwork.<group>.<method>(...)         → route = client
│    • GNNetwork.<group>.server.<method>(...)  → route = server
│    • GNNetwork.<group>.admin.<method>(...)   → route = admin
│
├─ Bước 2: Xác định target (chỉ áp dụng route client)
│    • Bỏ userId HOẶC userId trùng auth       → target = self
│    • userId khác auth user                   → target = other-self
│    • Domain không có ownership (Content,
│      StoreInventory, Multiplayer, CloudScript) → bỏ qua bước 2
│
├─ Bước 3: Map route + target → flag cần (RULES § 6.1)
│    • client + self        → selfEnable
│    • client + other-self  → otherSelfEnable
│    • server               → serverSelfEnable
│    • admin                → adminSelfEnable
│
├─ Bước 4: Check secret active có flag đó cho operation đang gọi không?
│    → xem dashboard GearN Server hoặc hỏi backend admin
│    → danh sách operation: reference/PERMISSION_RULES.md + API_<GROUP>.md
│
└─ Bước 5: Nếu không có flag, chọn 1 trong 3 action:
     (a) Dùng secret khác qua GNServerSettings.secretKey (cần restart process)
     (b) Override per-request: truyền overrideSecretKey vào method
     (c) Yêu cầu backend admin bật flag trong GearN Dashboard tương ứng cho secret hiện tại
```

### Code

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

private async System.Threading.Tasks.Task<object> GrantItemAsync(string userId, string itemId, int amount) {
    var req = new InventoryModels.AdminSetAmountRequestData();
    req.itemId = itemId;
    req.amount = amount;

    // Attempt 1: route admin với secret mặc định của app
    var res = await GNNetwork.inventory.admin.setAmountAsync(req);

    if (res.returnCode == ReturnCode.OperationNotAllow) {
        UnityEngine.Debug.LogWarning("OperationNotAllow on admin route — secret thiếu adminSelfEnable cho inventory.setAmount");
        UnityEngine.Debug.LogWarning("debugMessage: " + res.debugMessage);

        // Attempt 2: fallback override secret admin cho 1 request
        var adminSecret = System.Environment.GetEnvironmentVariable("GEARN_ADMIN_SECRET"); // KHONG hardcode
        if (!string.IsNullOrEmpty(adminSecret)) {
            res = await GNNetwork.inventory.admin.setAmountAsync(
                req,
                null, // overrideAuthToken
                adminSecret // overrideSecretKey
            );
        }
    }

    if (res.returnCode != ReturnCode.Ok) {
        // Vẫn fail sau fallback → báo ops, KHÔNG retry
        throw new System.Exception("grant failed: returnCode=" + res.returnCode + ", debug=" + res.debugMessage);
    }
    return res.responseData;
}
```

### Return paths

- `OperationNotAllow` → **không retry cùng secret**, đó là config fix.
- Sau fallback `overrideSecretKey` vẫn `OperationNotAllow` → secret admin cũng thiếu flag, phải liên hệ backend admin thêm flag trong GearN Dashboard.
- Nếu chuyển sang `SecretInvalid` sau fallback → override secret sai format / không khớp game context (khác lỗi, xem [RULES § 5](/docs/RULES.md#5-phân-biệt-3-returncode-dễ-nhầm)).

### Pitfalls

- **Nhầm `OperationNotAllow` với `SecretInvalid`** → sửa sai hướng, đổi secret vô nghĩa khi rule chưa được bật.
- **Dùng `.server` / `.admin` từ Unity client app để vượt permission** → trust boundary leak, secret bị expose. Route phải match caller thực tế (xem [RULES § 3](/docs/RULES.md#3-route--trust-boundary-của-caller)).
- **Retry tự động khi gặp `OperationNotAllow`** → không bao giờ giải quyết được, chỉ tốn request budget.
- **Giả định rule `selfEnable` tự bật** → backend admin config per-operation, không default bật tất cả.
- **Không check self vs other-self khi ở route `client`** → ví dụ gọi `masterPlayer.getPlayerInformationAsync(otherId)` mà nghĩ vẫn là self → sai flag → debug lâu.

### Liên kết

- Mapping rule đầy đủ: [RULES § 6.1](/docs/RULES.md#61-mapping-route-target--required-flag)
- Checklist nhanh khi gặp OperationNotAllow: [RULES § 6.3](/docs/RULES.md#63-checklist-nhanh-khi-gặp-returncodeoperationnotallow)
- Danh sách operation per-domain: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md)

---

## Pattern chung xuyên scenarios

<!-- prettier-ignore -->
| Pattern | Khi nào | Tham khảo |
| --- | --- | --- |
| Check `returnCode` → `errorCode` → đọc `responseData` | Mọi `*Async()` | [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md) |
| SDK auto-cache `authToken` / `userId` sau authenticate success | Login/refresh player; dashboard login cache `authToken` | Scenario 2, 3, 4, 14 |
| Subscribe event handler trước `connectSocket`; chỉ gọi `sendRequestAuthSocket` khi cần re-auth thủ công | Realtime | Scenario 5, 6, 7, 8 |
| `.server` / `.admin` chỉ ở backend, không bao giờ ở Unity client | Mọi cross-role call | Scenario 10, 13 |
| `customTags` để backend log/route | Khi cần phân loại source | Scenario 12 |
| Clear event handler + `disconnectSocket` + `setNewAuthenticateStatus(empty)` khi logout | Unload/logout | Scenario 15 |
