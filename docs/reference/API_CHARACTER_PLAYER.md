# API Reference: CharacterPlayerApi

Character-level gameplay: profile, inventory relation, friend/group relation, statistics, currency, segments, tags.

- Domain guide: [guides/CHARACTER_PLAYER.md](/docs/guides/CHARACTER_PLAYER.md)
- DTO shapes: [dto/CHARACTER_PLAYER.md](/docs/reference/dto/CHARACTER_PLAYER.md)
- Enums: [ENUMS.md](/docs/reference/ENUMS.md)
- Error handling: [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md)
- Permission rules: [PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md)

## Namespaces

- `GNNetwork.characterPlayer` — `RequestRole.Client`
- `GNNetwork.characterPlayer.server` — `RequestRole.Server`
- `GNNetwork.characterPlayer.admin` — `RequestRole.Admin`

## Convention

Mỗi method dưới đây có 2 form — callback và `*Async()` Task. Ưu tiên `*Async()`.

```text
// Callback
GNNetwork.characterPlayer.<method>(requestData, onResponse?, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);

// Async
var res = await GNNetwork.characterPlayer.<method>Async(requestData, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);
```

Param chung:

<!-- prettier-ignore -->
| Param | Type | Optional | Notes |
| --- | --- | --- | --- |
| `requestData` | domain-specific (xem bảng dưới) | no | Payload chính |
| `onResponse` | `Action1<TResponse>` | yes | Chỉ có ở callback form |
| `overrideAuthToken` | `string` | yes | Override `authToken` cache cho request này |
| `overrideSecretKey` | `string` | yes | Override secret key mặc định của route |
| `customTags` | `GNHashtable` | yes | Tags gắn vào request, backend có thể log/route |
| `timeout` | `int` | yes | Timeout giây; default = `OperationRequest.defaultTimeOut` |

Response class expose field: `returnCode`, `errorCode`, `invalidMembers`, `debugMessage`, `responseData`. Xem [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).

## Client methods (`GNNetwork.characterPlayer.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules | Permission Rules khi truyền `characterId` mà `gamePlayer` đang authenticated không phải là owner của `characterPlayer` này |
| --- | --- | --- | --- | --- | --- |
| `addPlayerFriend` | `CharacterPlayerModels.AddPlayerFriendRequestData` | `addPlayerFriendAsync(...)` | `CharacterPlayerResponseModels.AddPlayerFriendOperationResponse` | `characterPlayer.addPlayerFriend.selfEnable` | `characterPlayer.addPlayerFriend.otherSelfEnable` |
| `addSegment` | `CharacterPlayerModels.AddSegmentRequestData` | `addSegmentAsync(...)` | `CharacterPlayerResponseModels.AddSegmentOperationResponse` | `characterPlayer.addSegment.selfEnable` | `characterPlayer.addSegment.otherSelfEnable` |
| `getAvatar` | `CharacterPlayerModels.GetAvatarRequestData` | `getAvatarAsync(...)` | `CharacterPlayerResponseModels.GetAvatarOperationResponse` | `characterPlayer.getAvatar.selfEnable` | `characterPlayer.getAvatar.otherSelfEnable` |
| `getCatalogId` | `CharacterPlayerModels.GetCatalogIdRequestData` | `getCatalogIdAsync(...)` | `CharacterPlayerResponseModels.GetCatalogIdOperationResponse` | `characterPlayer.getCatalogId.selfEnable` | `characterPlayer.getCatalogId.otherSelfEnable` |
| `getCountryCode` | `CharacterPlayerModels.GetCountryCodeRequestData` | `getCountryCodeAsync(...)` | `CharacterPlayerResponseModels.GetCountryCodeOperationResponse` | `characterPlayer.getCountryCode.selfEnable` | `characterPlayer.getCountryCode.otherSelfEnable` |
| `getCustomData` | `CharacterPlayerModels.GetCustomDataRequestData` | `getCustomDataAsync(...)` | `CharacterPlayerResponseModels.GetCustomDataOperationResponse` | `characterPlayer.getCustomData.selfEnable` | `characterPlayer.getCustomData.otherSelfEnable` |
| `getDisplayName` | `CharacterPlayerModels.GetDisplayNameRequestData` | `getDisplayNameAsync(...)` | `CharacterPlayerResponseModels.GetDisplayNameOperationResponse` | `characterPlayer.getDisplayName.selfEnable` | `characterPlayer.getDisplayName.otherSelfEnable` |
| `getFriendStatisticsLeaderboardAroundPlayer` | `CharacterPlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData` | `getFriendStatisticsLeaderboardAroundPlayerAsync(...)` | `CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse` | `characterPlayer.getFriendStatisticsLeaderboardAroundPlayer.selfEnable` | `characterPlayer.getFriendStatisticsLeaderboardAroundPlayer.otherSelfEnable` |
| `getFriendStatisticsLeaderboard` | `CharacterPlayerModels.GetFriendStatisticsLeaderboardRequestData` | `getFriendStatisticsLeaderboardAsync(...)` | `CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse` | `characterPlayer.getFriendStatisticsLeaderboard.selfEnable` | `characterPlayer.getFriendStatisticsLeaderboard.otherSelfEnable` |
| `getIpAddressCreate` | `CharacterPlayerModels.GetIpAddressCreateRequestData` | `getIpAddressCreateAsync(...)` | `CharacterPlayerResponseModels.GetIpAddressCreateOperationResponse` | `characterPlayer.getIpAddressCreate.selfEnable` | `characterPlayer.getIpAddressCreate.otherSelfEnable` |
| `getOwner` | `CharacterPlayerModels.GetOwnerRequestData` | `getOwnerAsync(...)` | `CharacterPlayerResponseModels.GetOwnerOperationResponse` | `characterPlayer.getOwner.selfEnable` | `characterPlayer.getOwner.otherSelfEnable` |
| `getPlayerBan` | `CharacterPlayerModels.GetPlayerBanRequestData` | `getPlayerBanAsync(...)` | `CharacterPlayerResponseModels.GetPlayerBanOperationResponse` | `characterPlayer.getPlayerBan.selfEnable` | `characterPlayer.getPlayerBan.otherSelfEnable` |
| `getPlayerCurrency` | `CharacterPlayerModels.GetPlayerCurrencyRequestData` | `getPlayerCurrencyAsync(...)` | `CharacterPlayerResponseModels.GetPlayerCurrencyOperationResponse` | `characterPlayer.getPlayerCurrency.selfEnable` | `characterPlayer.getPlayerCurrency.otherSelfEnable` |
| `getPlayerData` | `CharacterPlayerModels.GetPlayerDataRequestData` | `getPlayerDataAsync(...)` | `CharacterPlayerResponseModels.GetPlayerDataOperationResponse` | `characterPlayer.getPlayerData.selfEnable` | `characterPlayer.getPlayerData.otherSelfEnable` |
| `getPlayerFriend` | `CharacterPlayerModels.GetPlayerFriendRequestData` | `getPlayerFriendAsync(...)` | `CharacterPlayerResponseModels.GetPlayerFriendOperationResponse` | `characterPlayer.getPlayerFriend.selfEnable` | `characterPlayer.getPlayerFriend.otherSelfEnable` |
| `getPlayerGroup` | `CharacterPlayerModels.GetPlayerGroupRequestData` | `getPlayerGroupAsync(...)` | `CharacterPlayerResponseModels.GetPlayerGroupOperationResponse` | `characterPlayer.getPlayerGroup.selfEnable` | `characterPlayer.getPlayerGroup.otherSelfEnable` |
| `getPlayerInformation` | `CharacterPlayerModels.GetPlayerInformationRequestData` | `getPlayerInformationAsync(...)` | `CharacterPlayerResponseModels.GetPlayerInformationOperationResponse` | `characterPlayer.getPlayerInformation.selfEnable` | `characterPlayer.getPlayerInformation.otherSelfEnable` |
| `getPlayerInventory` | `CharacterPlayerModels.GetPlayerInventoryRequestData` | `getPlayerInventoryAsync(...)` | `CharacterPlayerResponseModels.GetPlayerInventoryOperationResponse` | `characterPlayer.getPlayerInventory.selfEnable` | `characterPlayer.getPlayerInventory.otherSelfEnable` |
| `getPlayerStatistics` | `CharacterPlayerModels.GetPlayerStatisticsRequestData` | `getPlayerStatisticsAsync(...)` | `CharacterPlayerResponseModels.GetPlayerStatisticsOperationResponse` | `characterPlayer.getPlayerStatistics.selfEnable` | `characterPlayer.getPlayerStatistics.otherSelfEnable` |
| `getPlayersWithDisplayName` | `CharacterPlayerModels.GetPlayersWithDisplayNameRequestData` | `getPlayersWithDisplayNameAsync(...)` | `CharacterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse` | `characterPlayer.getPlayersWithDisplayName.otherSelfEnable` | |
| `getPlayersWithSegment` | `CharacterPlayerModels.GetPlayersWithSegmentRequestData` | `getPlayersWithSegmentAsync(...)` | `CharacterPlayerResponseModels.GetPlayersWithSegmentOperationResponse` | `characterPlayer.getPlayersWithSegment.otherSelfEnable` | |
| `getPlayersWithTag` | `CharacterPlayerModels.GetPlayersWithTagRequestData` | `getPlayersWithTagAsync(...)` | `CharacterPlayerResponseModels.GetPlayersWithTagOperationResponse` | `characterPlayer.getPlayersWithTag.otherSelfEnable` | |
| `getRemoveStatus` | `CharacterPlayerModels.GetRemoveStatusRequestData` | `getRemoveStatusAsync(...)` | `CharacterPlayerResponseModels.GetRemoveStatusOperationResponse` | `characterPlayer.getRemoveStatus.selfEnable` | `characterPlayer.getRemoveStatus.otherSelfEnable` |
| `getSegment` | `CharacterPlayerModels.GetSegmentRequestData` | `getSegmentAsync(...)` | `CharacterPlayerResponseModels.GetSegmentOperationResponse` | `characterPlayer.getSegment.selfEnable` | `characterPlayer.getSegment.otherSelfEnable` |
| `getStatisticsLeaderboardAroundPlayer` | `CharacterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData` | `getStatisticsLeaderboardAroundPlayerAsync(...)` | `CharacterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse` | `characterPlayer.getStatisticsLeaderboardAroundPlayer.selfEnable` | `characterPlayer.getStatisticsLeaderboardAroundPlayer.otherSelfEnable` |
| `getStatisticsLeaderboard` | `CharacterPlayerModels.GetStatisticsLeaderboardRequestData` | `getStatisticsLeaderboardAsync(...)` | `CharacterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse` | `characterPlayer.getStatisticsLeaderboard.otherSelfEnable` | |
| `getTag` | `CharacterPlayerModels.GetTagRequestData` | `getTagAsync(...)` | `CharacterPlayerResponseModels.GetTagOperationResponse` | `characterPlayer.getTag.selfEnable` | `characterPlayer.getTag.otherSelfEnable` |
| `getTsCreate` | `CharacterPlayerModels.GetTsCreateRequestData` | `getTsCreateAsync(...)` | `CharacterPlayerResponseModels.GetTsCreateOperationResponse` | `characterPlayer.getTsCreate.selfEnable` | `characterPlayer.getTsCreate.otherSelfEnable` |
| `getTsLastLogin` | `CharacterPlayerModels.GetTsLastLoginRequestData` | `getTsLastLoginAsync(...)` | `CharacterPlayerResponseModels.GetTsLastLoginOperationResponse` | `characterPlayer.getTsLastLogin.selfEnable` | `characterPlayer.getTsLastLogin.otherSelfEnable` |
| `createGroup` | `CharacterPlayerModels.CreateGroupRequestData` | `createGroupAsync(...)` | `CharacterPlayerResponseModels.CreateGroupOperationResponse` | `characterPlayer.createGroup.selfEnable` | `characterPlayer.createGroup.otherSelfEnable` |
| `createPlayerItem` | `CharacterPlayerModels.CreatePlayerItemRequestData` | `createPlayerItemAsync(...)` | `CharacterPlayerResponseModels.CreatePlayerItemOperationResponse` | `characterPlayer.createPlayerItem.selfEnable` | `characterPlayer.createPlayerItem.otherSelfEnable` |
| `joinGroup` | `CharacterPlayerModels.JoinGroupRequestData` | `joinGroupAsync(...)` | `CharacterPlayerResponseModels.JoinGroupOperationResponse` | `characterPlayer.joinGroup.selfEnable` | `characterPlayer.joinGroup.otherSelfEnable` |
| `leaveGroup` | `CharacterPlayerModels.LeaveGroupRequestData` | `leaveGroupAsync(...)` | `CharacterPlayerResponseModels.LeaveGroupOperationResponse` | `characterPlayer.leaveGroup.selfEnable` | `characterPlayer.leaveGroup.otherSelfEnable` |
| `removePlayerFriend` | `CharacterPlayerModels.RemovePlayerFriendRequestData` | `removePlayerFriendAsync(...)` | `CharacterPlayerResponseModels.RemovePlayerFriendOperationResponse` | `characterPlayer.removePlayerFriend.selfEnable` | `characterPlayer.removePlayerFriend.otherSelfEnable` |
| `removePlayerItem` | `CharacterPlayerModels.RemovePlayerItemRequestData` | `removePlayerItemAsync(...)` | `CharacterPlayerResponseModels.RemovePlayerItemOperationResponse` | `characterPlayer.removePlayerItem.selfEnable` | `characterPlayer.removePlayerItem.otherSelfEnable` |
| `removeSegment` | `CharacterPlayerModels.RemoveSegmentRequestData` | `removeSegmentAsync(...)` | `CharacterPlayerResponseModels.RemoveSegmentOperationResponse` | `characterPlayer.removeSegment.selfEnable` | `characterPlayer.removeSegment.otherSelfEnable` |
| `removeTag` | `CharacterPlayerModels.RemoveTagRequestData` | `removeTagAsync(...)` | `CharacterPlayerResponseModels.RemoveTagOperationResponse` | `characterPlayer.removeTag.selfEnable` | `characterPlayer.removeTag.otherSelfEnable` |
| `setAvatar` | `CharacterPlayerModels.SetAvatarRequestData` | `setAvatarAsync(...)` | `CharacterPlayerResponseModels.SetAvatarOperationResponse` | `characterPlayer.setAvatar.selfEnable` | `characterPlayer.setAvatar.otherSelfEnable` |
| `setCountryCode` | `CharacterPlayerModels.SetCountryCodeRequestData` | `setCountryCodeAsync(...)` | `CharacterPlayerResponseModels.SetCountryCodeOperationResponse` | `characterPlayer.setCountryCode.selfEnable` | `characterPlayer.setCountryCode.otherSelfEnable` |
| `setCustomData` | `CharacterPlayerModels.SetCustomDataRequestData` | `setCustomDataAsync(...)` | `CharacterPlayerResponseModels.SetCustomDataOperationResponse` | `characterPlayer.setCustomData.selfEnable` | `characterPlayer.setCustomData.otherSelfEnable` |
| `setDisplayName` | `CharacterPlayerModels.SetDisplayNameRequestData` | `setDisplayNameAsync(...)` | `CharacterPlayerResponseModels.SetDisplayNameOperationResponse` | `characterPlayer.setDisplayName.selfEnable` | `characterPlayer.setDisplayName.otherSelfEnable` |
| `setOwner` | `CharacterPlayerModels.SetOwnerRequestData` | `setOwnerAsync(...)` | `CharacterPlayerResponseModels.SetOwnerOperationResponse` | `characterPlayer.setOwner.selfEnable` | `characterPlayer.setOwner.otherSelfEnable` |
| `setPlayerBan` | `CharacterPlayerModels.SetPlayerBanRequestData` | `setPlayerBanAsync(...)` | `CharacterPlayerResponseModels.SetPlayerBanOperationResponse` | `characterPlayer.setPlayerBan.selfEnable` | `characterPlayer.setPlayerBan.otherSelfEnable` |
| `changePlayerCurrency` | `CharacterPlayerModels.ChangePlayerCurrencyRequestData` | `changePlayerCurrencyAsync(...)` | `CharacterPlayerResponseModels.ChangePlayerCurrencyOperationResponse` | `characterPlayer.changePlayerCurrency.selfEnable` | `characterPlayer.changePlayerCurrency.otherSelfEnable` |
| `setPlayerData` | `CharacterPlayerModels.SetPlayerDataRequestData` | `setPlayerDataAsync(...)` | `CharacterPlayerResponseModels.SetPlayerDataOperationResponse` | `characterPlayer.setPlayerData.selfEnable` | `characterPlayer.setPlayerData.otherSelfEnable` |
| `changePlayerStatistics` | `CharacterPlayerModels.ChangePlayerStatisticsRequestData` | `changePlayerStatisticsAsync(...)` | `CharacterPlayerResponseModels.ChangePlayerStatisticsOperationResponse` | `characterPlayer.changePlayerStatistics.selfEnable` | `characterPlayer.changePlayerStatistics.otherSelfEnable` |
| `setRemoveStatus` | `CharacterPlayerModels.SetRemoveStatusRequestData` | `setRemoveStatusAsync(...)` | `CharacterPlayerResponseModels.SetRemoveStatusOperationResponse` | `characterPlayer.setRemoveStatus.selfEnable` | `characterPlayer.setRemoveStatus.otherSelfEnable` |
| `setTag` | `CharacterPlayerModels.SetTagRequestData` | `setTagAsync(...)` | `CharacterPlayerResponseModels.SetTagOperationResponse` | `characterPlayer.setTag.selfEnable` | `characterPlayer.setTag.otherSelfEnable` |
| `getCurrencyLeaderboard` | `CharacterPlayerModels.GetCurrencyLeaderboardRequestData` | `getCurrencyLeaderboardAsync(...)` | `CharacterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse` | `characterPlayer.getCurrencyLeaderboard.otherSelfEnable` | |
| `getCreateLeaderboard` | `CharacterPlayerModels.GetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `CharacterPlayerResponseModels.GetCreateLeaderboardOperationResponse` | `characterPlayer.getCreateLeaderboard.otherSelfEnable` | |
| `getLastLoginLeaderboard` | `CharacterPlayerModels.GetLastLoginLeaderboardRequestData` | `getLastLoginLeaderboardAsync(...)` | `CharacterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse` | `characterPlayer.getLastLoginLeaderboard.otherSelfEnable` | |
| `getStatisticsLog` | `CharacterPlayerModels.GetStatisticsLogRequestData` | `getStatisticsLogAsync(...)` | `CharacterPlayerResponseModels.GetStatisticsLogOperationResponse` | `characterPlayer.getStatisticsLog.selfEnable` | `characterPlayer.getStatisticsLog.otherSelfEnable` |
| `getCurrencyLog` | `CharacterPlayerModels.GetCurrencyLogRequestData` | `getCurrencyLogAsync(...)` | `CharacterPlayerResponseModels.GetCurrencyLogOperationResponse` | `characterPlayer.getCurrencyLog.selfEnable` | `characterPlayer.getCurrencyLog.otherSelfEnable` |

## Server methods (`GNNetwork.characterPlayer.server.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules |
| --- | --- | --- | --- | --- |
| `addPlayerFriend` | `CharacterPlayerModels.AddPlayerFriendRequestData` | `addPlayerFriendAsync(...)` | `CharacterPlayerResponseModels.AddPlayerFriendOperationResponse` | `characterPlayer.addPlayerFriend.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.addPlayerFriend.otherSelfEnable` |
| `addSegment` | `CharacterPlayerModels.AddSegmentRequestData` | `addSegmentAsync(...)` | `CharacterPlayerResponseModels.AddSegmentOperationResponse` | `characterPlayer.addSegment.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.addSegment.otherSelfEnable` |
| `getAvatar` | `CharacterPlayerModels.GetAvatarRequestData` | `getAvatarAsync(...)` | `CharacterPlayerResponseModels.GetAvatarOperationResponse` | `characterPlayer.getAvatar.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getAvatar.otherSelfEnable` |
| `getCatalogId` | `CharacterPlayerModels.GetCatalogIdRequestData` | `getCatalogIdAsync(...)` | `CharacterPlayerResponseModels.GetCatalogIdOperationResponse` | `characterPlayer.getCatalogId.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getCatalogId.otherSelfEnable` |
| `getCountryCode` | `CharacterPlayerModels.GetCountryCodeRequestData` | `getCountryCodeAsync(...)` | `CharacterPlayerResponseModels.GetCountryCodeOperationResponse` | `characterPlayer.getCountryCode.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getCountryCode.otherSelfEnable` |
| `getCustomData` | `CharacterPlayerModels.GetCustomDataRequestData` | `getCustomDataAsync(...)` | `CharacterPlayerResponseModels.GetCustomDataOperationResponse` | `characterPlayer.getCustomData.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getCustomData.otherSelfEnable` |
| `getDisplayName` | `CharacterPlayerModels.GetDisplayNameRequestData` | `getDisplayNameAsync(...)` | `CharacterPlayerResponseModels.GetDisplayNameOperationResponse` | `characterPlayer.getDisplayName.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getDisplayName.otherSelfEnable` |
| `getFriendStatisticsLeaderboardAroundPlayer` | `CharacterPlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData` | `getFriendStatisticsLeaderboardAroundPlayerAsync(...)` | `CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse` | `characterPlayer.getFriendStatisticsLeaderboardAroundPlayer.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getFriendStatisticsLeaderboardAroundPlayer.otherSelfEnable` |
| `getFriendStatisticsLeaderboard` | `CharacterPlayerModels.GetFriendStatisticsLeaderboardRequestData` | `getFriendStatisticsLeaderboardAsync(...)` | `CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse` | `characterPlayer.getFriendStatisticsLeaderboard.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getFriendStatisticsLeaderboard.otherSelfEnable` |
| `getIpAddressCreate` | `CharacterPlayerModels.GetIpAddressCreateRequestData` | `getIpAddressCreateAsync(...)` | `CharacterPlayerResponseModels.GetIpAddressCreateOperationResponse` | `characterPlayer.getIpAddressCreate.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getIpAddressCreate.otherSelfEnable` |
| `getOwner` | `CharacterPlayerModels.GetOwnerRequestData` | `getOwnerAsync(...)` | `CharacterPlayerResponseModels.GetOwnerOperationResponse` | `characterPlayer.getOwner.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getOwner.otherSelfEnable` |
| `getPlayerBan` | `CharacterPlayerModels.GetPlayerBanRequestData` | `getPlayerBanAsync(...)` | `CharacterPlayerResponseModels.GetPlayerBanOperationResponse` | `characterPlayer.getPlayerBan.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getPlayerBan.otherSelfEnable` |
| `getPlayerCurrency` | `CharacterPlayerModels.GetPlayerCurrencyRequestData` | `getPlayerCurrencyAsync(...)` | `CharacterPlayerResponseModels.GetPlayerCurrencyOperationResponse` | `characterPlayer.getPlayerCurrency.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getPlayerCurrency.otherSelfEnable` |
| `getPlayerData` | `CharacterPlayerModels.GetPlayerDataRequestData` | `getPlayerDataAsync(...)` | `CharacterPlayerResponseModels.GetPlayerDataOperationResponse` | `characterPlayer.getPlayerData.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getPlayerData.otherSelfEnable` |
| `getPlayerFriend` | `CharacterPlayerModels.GetPlayerFriendRequestData` | `getPlayerFriendAsync(...)` | `CharacterPlayerResponseModels.GetPlayerFriendOperationResponse` | `characterPlayer.getPlayerFriend.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getPlayerFriend.otherSelfEnable` |
| `getPlayerGroup` | `CharacterPlayerModels.GetPlayerGroupRequestData` | `getPlayerGroupAsync(...)` | `CharacterPlayerResponseModels.GetPlayerGroupOperationResponse` | `characterPlayer.getPlayerGroup.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getPlayerGroup.otherSelfEnable` |
| `getPlayerInformation` | `CharacterPlayerModels.GetPlayerInformationRequestData` | `getPlayerInformationAsync(...)` | `CharacterPlayerResponseModels.GetPlayerInformationOperationResponse` | `characterPlayer.getPlayerInformation.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getPlayerInformation.otherSelfEnable` |
| `getPlayerInventory` | `CharacterPlayerModels.GetPlayerInventoryRequestData` | `getPlayerInventoryAsync(...)` | `CharacterPlayerResponseModels.GetPlayerInventoryOperationResponse` | `characterPlayer.getPlayerInventory.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getPlayerInventory.otherSelfEnable` |
| `getPlayerStatistics` | `CharacterPlayerModels.GetPlayerStatisticsRequestData` | `getPlayerStatisticsAsync(...)` | `CharacterPlayerResponseModels.GetPlayerStatisticsOperationResponse` | `characterPlayer.getPlayerStatistics.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getPlayerStatistics.otherSelfEnable` |
| `getPlayersWithDisplayName` | `CharacterPlayerModels.GetPlayersWithDisplayNameRequestData` | `getPlayersWithDisplayNameAsync(...)` | `CharacterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse` | `characterPlayer.getPlayersWithDisplayName.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getPlayersWithDisplayName.otherSelfEnable` |
| `getPlayersWithSegment` | `CharacterPlayerModels.GetPlayersWithSegmentRequestData` | `getPlayersWithSegmentAsync(...)` | `CharacterPlayerResponseModels.GetPlayersWithSegmentOperationResponse` | `characterPlayer.getPlayersWithSegment.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getPlayersWithSegment.otherSelfEnable` |
| `getPlayersWithTag` | `CharacterPlayerModels.GetPlayersWithTagRequestData` | `getPlayersWithTagAsync(...)` | `CharacterPlayerResponseModels.GetPlayersWithTagOperationResponse` | `characterPlayer.getPlayersWithTag.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getPlayersWithTag.otherSelfEnable` |
| `getRemoveStatus` | `CharacterPlayerModels.GetRemoveStatusRequestData` | `getRemoveStatusAsync(...)` | `CharacterPlayerResponseModels.GetRemoveStatusOperationResponse` | `characterPlayer.getRemoveStatus.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getRemoveStatus.otherSelfEnable` |
| `getSegment` | `CharacterPlayerModels.GetSegmentRequestData` | `getSegmentAsync(...)` | `CharacterPlayerResponseModels.GetSegmentOperationResponse` | `characterPlayer.getSegment.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getSegment.otherSelfEnable` |
| `getStatisticsLeaderboardAroundPlayer` | `CharacterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData` | `getStatisticsLeaderboardAroundPlayerAsync(...)` | `CharacterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse` | `characterPlayer.getStatisticsLeaderboardAroundPlayer.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getStatisticsLeaderboardAroundPlayer.otherSelfEnable` |
| `getStatisticsLeaderboard` | `CharacterPlayerModels.GetStatisticsLeaderboardRequestData` | `getStatisticsLeaderboardAsync(...)` | `CharacterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse` | `characterPlayer.getStatisticsLeaderboard.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getStatisticsLeaderboard.otherSelfEnable` |
| `getTag` | `CharacterPlayerModels.GetTagRequestData` | `getTagAsync(...)` | `CharacterPlayerResponseModels.GetTagOperationResponse` | `characterPlayer.getTag.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getTag.otherSelfEnable` |
| `getTsCreate` | `CharacterPlayerModels.GetTsCreateRequestData` | `getTsCreateAsync(...)` | `CharacterPlayerResponseModels.GetTsCreateOperationResponse` | `characterPlayer.getTsCreate.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getTsCreate.otherSelfEnable` |
| `getTsLastLogin` | `CharacterPlayerModels.GetTsLastLoginRequestData` | `getTsLastLoginAsync(...)` | `CharacterPlayerResponseModels.GetTsLastLoginOperationResponse` | `characterPlayer.getTsLastLogin.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getTsLastLogin.otherSelfEnable` |
| `createGroup` | `CharacterPlayerModels.CreateGroupRequestData` | `createGroupAsync(...)` | `CharacterPlayerResponseModels.CreateGroupOperationResponse` | `characterPlayer.createGroup.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.createGroup.otherSelfEnable` |
| `createPlayerItem` | `CharacterPlayerModels.CreatePlayerItemRequestData` | `createPlayerItemAsync(...)` | `CharacterPlayerResponseModels.CreatePlayerItemOperationResponse` | `characterPlayer.createPlayerItem.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.createPlayerItem.otherSelfEnable` |
| `joinGroup` | `CharacterPlayerModels.JoinGroupRequestData` | `joinGroupAsync(...)` | `CharacterPlayerResponseModels.JoinGroupOperationResponse` | `characterPlayer.joinGroup.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.joinGroup.otherSelfEnable` |
| `leaveGroup` | `CharacterPlayerModels.LeaveGroupRequestData` | `leaveGroupAsync(...)` | `CharacterPlayerResponseModels.LeaveGroupOperationResponse` | `characterPlayer.leaveGroup.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.leaveGroup.otherSelfEnable` |
| `removePlayerFriend` | `CharacterPlayerModels.RemovePlayerFriendRequestData` | `removePlayerFriendAsync(...)` | `CharacterPlayerResponseModels.RemovePlayerFriendOperationResponse` | `characterPlayer.removePlayerFriend.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.removePlayerFriend.otherSelfEnable` |
| `removePlayerItem` | `CharacterPlayerModels.RemovePlayerItemRequestData` | `removePlayerItemAsync(...)` | `CharacterPlayerResponseModels.RemovePlayerItemOperationResponse` | `characterPlayer.removePlayerItem.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.removePlayerItem.otherSelfEnable` |
| `removeSegment` | `CharacterPlayerModels.RemoveSegmentRequestData` | `removeSegmentAsync(...)` | `CharacterPlayerResponseModels.RemoveSegmentOperationResponse` | `characterPlayer.removeSegment.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.removeSegment.otherSelfEnable` |
| `removeTag` | `CharacterPlayerModels.RemoveTagRequestData` | `removeTagAsync(...)` | `CharacterPlayerResponseModels.RemoveTagOperationResponse` | `characterPlayer.removeTag.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.removeTag.otherSelfEnable` |
| `setAvatar` | `CharacterPlayerModels.SetAvatarRequestData` | `setAvatarAsync(...)` | `CharacterPlayerResponseModels.SetAvatarOperationResponse` | `characterPlayer.setAvatar.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.setAvatar.otherSelfEnable` |
| `setCountryCode` | `CharacterPlayerModels.SetCountryCodeRequestData` | `setCountryCodeAsync(...)` | `CharacterPlayerResponseModels.SetCountryCodeOperationResponse` | `characterPlayer.setCountryCode.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.setCountryCode.otherSelfEnable` |
| `setCustomData` | `CharacterPlayerModels.SetCustomDataRequestData` | `setCustomDataAsync(...)` | `CharacterPlayerResponseModels.SetCustomDataOperationResponse` | `characterPlayer.setCustomData.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.setCustomData.otherSelfEnable` |
| `setDisplayName` | `CharacterPlayerModels.SetDisplayNameRequestData` | `setDisplayNameAsync(...)` | `CharacterPlayerResponseModels.SetDisplayNameOperationResponse` | `characterPlayer.setDisplayName.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.setDisplayName.otherSelfEnable` |
| `setOwner` | `CharacterPlayerModels.SetOwnerRequestData` | `setOwnerAsync(...)` | `CharacterPlayerResponseModels.SetOwnerOperationResponse` | `characterPlayer.setOwner.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.setOwner.otherSelfEnable` |
| `setPlayerBan` | `CharacterPlayerModels.SetPlayerBanRequestData` | `setPlayerBanAsync(...)` | `CharacterPlayerResponseModels.SetPlayerBanOperationResponse` | `characterPlayer.setPlayerBan.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.setPlayerBan.otherSelfEnable` |
| `changePlayerCurrency` | `CharacterPlayerModels.ChangePlayerCurrencyRequestData` | `changePlayerCurrencyAsync(...)` | `CharacterPlayerResponseModels.ChangePlayerCurrencyOperationResponse` | `characterPlayer.changePlayerCurrency.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.changePlayerCurrency.otherSelfEnable` |
| `setPlayerData` | `CharacterPlayerModels.SetPlayerDataRequestData` | `setPlayerDataAsync(...)` | `CharacterPlayerResponseModels.SetPlayerDataOperationResponse` | `characterPlayer.setPlayerData.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.setPlayerData.otherSelfEnable` |
| `changePlayerStatistics` | `CharacterPlayerModels.ChangePlayerStatisticsRequestData` | `changePlayerStatisticsAsync(...)` | `CharacterPlayerResponseModels.ChangePlayerStatisticsOperationResponse` | `characterPlayer.changePlayerStatistics.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.changePlayerStatistics.otherSelfEnable` |
| `setRemoveStatus` | `CharacterPlayerModels.SetRemoveStatusRequestData` | `setRemoveStatusAsync(...)` | `CharacterPlayerResponseModels.SetRemoveStatusOperationResponse` | `characterPlayer.setRemoveStatus.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.setRemoveStatus.otherSelfEnable` |
| `setTag` | `CharacterPlayerModels.SetTagRequestData` | `setTagAsync(...)` | `CharacterPlayerResponseModels.SetTagOperationResponse` | `characterPlayer.setTag.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.setTag.otherSelfEnable` |
| `getCurrencyLeaderboard` | `CharacterPlayerModels.GetCurrencyLeaderboardRequestData` | `getCurrencyLeaderboardAsync(...)` | `CharacterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse` | `characterPlayer.getCurrencyLeaderboard.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getCurrencyLeaderboard.otherSelfEnable` |
| `getCreateLeaderboard` | `CharacterPlayerModels.GetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `CharacterPlayerResponseModels.GetCreateLeaderboardOperationResponse` | `characterPlayer.getCreateLeaderboard.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getCreateLeaderboard.otherSelfEnable` |
| `getLastLoginLeaderboard` | `CharacterPlayerModels.GetLastLoginLeaderboardRequestData` | `getLastLoginLeaderboardAsync(...)` | `CharacterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse` | `characterPlayer.getLastLoginLeaderboard.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getLastLoginLeaderboard.otherSelfEnable` |
| `getStatisticsLog` | `CharacterPlayerModels.GetStatisticsLogRequestData` | `getStatisticsLogAsync(...)` | `CharacterPlayerResponseModels.GetStatisticsLogOperationResponse` | `characterPlayer.getStatisticsLog.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getStatisticsLog.otherSelfEnable` |
| `getCurrencyLog` | `CharacterPlayerModels.GetCurrencyLogRequestData` | `getCurrencyLogAsync(...)` | `CharacterPlayerResponseModels.GetCurrencyLogOperationResponse` | `characterPlayer.getCurrencyLog.selfEnable`, nếu dùng `characterId` thì cần rules `characterPlayer.getCurrencyLog.otherSelfEnable` |

## Admin methods (`GNNetwork.characterPlayer.admin.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules |
| --- | --- | --- | --- | --- |
| `addPlayerFriend` | `CharacterPlayerModels.AdminAddPlayerFriendRequestData` | `addPlayerFriendAsync(...)` | `CharacterPlayerResponseModels.AddPlayerFriendOperationResponse` | `characterPlayer.addPlayerFriend.adminSelfEnable` |
| `addSegment` | `CharacterPlayerModels.AdminAddSegmentRequestData` | `addSegmentAsync(...)` | `CharacterPlayerResponseModels.AddSegmentOperationResponse` | `characterPlayer.addSegment.adminSelfEnable` |
| `getAvatar` | `CharacterPlayerModels.AdminGetAvatarRequestData` | `getAvatarAsync(...)` | `CharacterPlayerResponseModels.GetAvatarOperationResponse` | `characterPlayer.getAvatar.adminSelfEnable` |
| `getCatalogId` | `CharacterPlayerModels.AdminGetCatalogIdRequestData` | `getCatalogIdAsync(...)` | `CharacterPlayerResponseModels.GetCatalogIdOperationResponse` | `characterPlayer.getCatalogId.adminSelfEnable` |
| `getCountryCode` | `CharacterPlayerModels.AdminGetCountryCodeRequestData` | `getCountryCodeAsync(...)` | `CharacterPlayerResponseModels.GetCountryCodeOperationResponse` | `characterPlayer.getCountryCode.adminSelfEnable` |
| `getCustomData` | `CharacterPlayerModels.AdminGetCustomDataRequestData` | `getCustomDataAsync(...)` | `CharacterPlayerResponseModels.GetCustomDataOperationResponse` | `characterPlayer.getCustomData.adminSelfEnable` |
| `getDisplayName` | `CharacterPlayerModels.AdminGetDisplayNameRequestData` | `getDisplayNameAsync(...)` | `CharacterPlayerResponseModels.GetDisplayNameOperationResponse` | `characterPlayer.getDisplayName.adminSelfEnable` |
| `getFriendStatisticsLeaderboardAroundPlayer` | `CharacterPlayerModels.AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData` | `getFriendStatisticsLeaderboardAroundPlayerAsync(...)` | `CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse` | `characterPlayer.getFriendStatisticsLeaderboardAroundPlayer.adminSelfEnable` |
| `getFriendStatisticsLeaderboard` | `CharacterPlayerModels.AdminGetFriendStatisticsLeaderboardRequestData` | `getFriendStatisticsLeaderboardAsync(...)` | `CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse` | `characterPlayer.getFriendStatisticsLeaderboard.adminSelfEnable` |
| `getIpAddressCreate` | `CharacterPlayerModels.AdminGetIpAddressCreateRequestData` | `getIpAddressCreateAsync(...)` | `CharacterPlayerResponseModels.GetIpAddressCreateOperationResponse` | `characterPlayer.getIpAddressCreate.adminSelfEnable` |
| `getOwner` | `CharacterPlayerModels.AdminGetOwnerRequestData` | `getOwnerAsync(...)` | `CharacterPlayerResponseModels.GetOwnerOperationResponse` | `characterPlayer.getOwner.adminSelfEnable` |
| `getPlayerBan` | `CharacterPlayerModels.AdminGetPlayerBanRequestData` | `getPlayerBanAsync(...)` | `CharacterPlayerResponseModels.GetPlayerBanOperationResponse` | `characterPlayer.getPlayerBan.adminSelfEnable` |
| `getPlayerCurrency` | `CharacterPlayerModels.AdminGetPlayerCurrencyRequestData` | `getPlayerCurrencyAsync(...)` | `CharacterPlayerResponseModels.GetPlayerCurrencyOperationResponse` | `characterPlayer.getPlayerCurrency.adminSelfEnable` |
| `getPlayerData` | `CharacterPlayerModels.AdminGetPlayerDataRequestData` | `getPlayerDataAsync(...)` | `CharacterPlayerResponseModels.GetPlayerDataOperationResponse` | `characterPlayer.getPlayerData.adminSelfEnable` |
| `getPlayerFriend` | `CharacterPlayerModels.AdminGetPlayerFriendRequestData` | `getPlayerFriendAsync(...)` | `CharacterPlayerResponseModels.GetPlayerFriendOperationResponse` | `characterPlayer.getPlayerFriend.adminSelfEnable` |
| `getPlayerGroup` | `CharacterPlayerModels.AdminGetPlayerGroupRequestData` | `getPlayerGroupAsync(...)` | `CharacterPlayerResponseModels.GetPlayerGroupOperationResponse` | `characterPlayer.getPlayerGroup.adminSelfEnable` |
| `getPlayerInformation` | `CharacterPlayerModels.AdminGetPlayerInformationRequestData` | `getPlayerInformationAsync(...)` | `CharacterPlayerResponseModels.GetPlayerInformationOperationResponse` | `characterPlayer.getPlayerInformation.adminSelfEnable` |
| `getPlayerInventory` | `CharacterPlayerModels.AdminGetPlayerInventoryRequestData` | `getPlayerInventoryAsync(...)` | `CharacterPlayerResponseModels.GetPlayerInventoryOperationResponse` | `characterPlayer.getPlayerInventory.adminSelfEnable` |
| `getPlayerStatistics` | `CharacterPlayerModels.AdminGetPlayerStatisticsRequestData` | `getPlayerStatisticsAsync(...)` | `CharacterPlayerResponseModels.GetPlayerStatisticsOperationResponse` | `characterPlayer.getPlayerStatistics.adminSelfEnable` |
| `getPlayersWithDisplayName` | `CharacterPlayerModels.AdminGetPlayersWithDisplayNameRequestData` | `getPlayersWithDisplayNameAsync(...)` | `CharacterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse` | `characterPlayer.getPlayersWithDisplayName.adminSelfEnable` |
| `getPlayersWithSegment` | `CharacterPlayerModels.AdminGetPlayersWithSegmentRequestData` | `getPlayersWithSegmentAsync(...)` | `CharacterPlayerResponseModels.GetPlayersWithSegmentOperationResponse` | `characterPlayer.getPlayersWithSegment.adminSelfEnable` |
| `getPlayersWithTag` | `CharacterPlayerModels.AdminGetPlayersWithTagRequestData` | `getPlayersWithTagAsync(...)` | `CharacterPlayerResponseModels.GetPlayersWithTagOperationResponse` | `characterPlayer.getPlayersWithTag.adminSelfEnable` |
| `getRemoveStatus` | `CharacterPlayerModels.AdminGetRemoveStatusRequestData` | `getRemoveStatusAsync(...)` | `CharacterPlayerResponseModels.GetRemoveStatusOperationResponse` | `characterPlayer.getRemoveStatus.adminSelfEnable` |
| `getSegment` | `CharacterPlayerModels.AdminGetSegmentRequestData` | `getSegmentAsync(...)` | `CharacterPlayerResponseModels.GetSegmentOperationResponse` | `characterPlayer.getSegment.adminSelfEnable` |
| `getStatisticsLeaderboardAroundPlayer` | `CharacterPlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData` | `getStatisticsLeaderboardAroundPlayerAsync(...)` | `CharacterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse` | `characterPlayer.getStatisticsLeaderboardAroundPlayer.adminSelfEnable` |
| `getStatisticsLeaderboard` | `CharacterPlayerModels.AdminGetStatisticsLeaderboardRequestData` | `getStatisticsLeaderboardAsync(...)` | `CharacterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse` | `characterPlayer.getStatisticsLeaderboard.adminSelfEnable` |
| `getTag` | `CharacterPlayerModels.AdminGetTagRequestData` | `getTagAsync(...)` | `CharacterPlayerResponseModels.GetTagOperationResponse` | `characterPlayer.getTag.adminSelfEnable` |
| `getTsCreate` | `CharacterPlayerModels.AdminGetTsCreateRequestData` | `getTsCreateAsync(...)` | `CharacterPlayerResponseModels.GetTsCreateOperationResponse` | `characterPlayer.getTsCreate.adminSelfEnable` |
| `getTsLastLogin` | `CharacterPlayerModels.AdminGetTsLastLoginRequestData` | `getTsLastLoginAsync(...)` | `CharacterPlayerResponseModels.GetTsLastLoginOperationResponse` | `characterPlayer.getTsLastLogin.adminSelfEnable` |
| `createGroup` | `CharacterPlayerModels.AdminCreateGroupRequestData` | `createGroupAsync(...)` | `CharacterPlayerResponseModels.CreateGroupOperationResponse` | `characterPlayer.createGroup.adminSelfEnable` |
| `createPlayerItem` | `CharacterPlayerModels.AdminCreatePlayerItemRequestData` | `createPlayerItemAsync(...)` | `CharacterPlayerResponseModels.CreatePlayerItemOperationResponse` | `characterPlayer.createPlayerItem.adminSelfEnable` |
| `joinGroup` | `CharacterPlayerModels.AdminJoinGroupRequestData` | `joinGroupAsync(...)` | `CharacterPlayerResponseModels.JoinGroupOperationResponse` | `characterPlayer.joinGroup.adminSelfEnable` |
| `leaveGroup` | `CharacterPlayerModels.AdminLeaveGroupRequestData` | `leaveGroupAsync(...)` | `CharacterPlayerResponseModels.LeaveGroupOperationResponse` | `characterPlayer.leaveGroup.adminSelfEnable` |
| `removePlayerFriend` | `CharacterPlayerModels.AdminRemovePlayerFriendRequestData` | `removePlayerFriendAsync(...)` | `CharacterPlayerResponseModels.RemovePlayerFriendOperationResponse` | `characterPlayer.removePlayerFriend.adminSelfEnable` |
| `removePlayerItem` | `CharacterPlayerModels.AdminRemovePlayerItemRequestData` | `removePlayerItemAsync(...)` | `CharacterPlayerResponseModels.RemovePlayerItemOperationResponse` | `characterPlayer.removePlayerItem.adminSelfEnable` |
| `removeSegment` | `CharacterPlayerModels.AdminRemoveSegmentRequestData` | `removeSegmentAsync(...)` | `CharacterPlayerResponseModels.RemoveSegmentOperationResponse` | `characterPlayer.removeSegment.adminSelfEnable` |
| `removeTag` | `CharacterPlayerModels.AdminRemoveTagRequestData` | `removeTagAsync(...)` | `CharacterPlayerResponseModels.RemoveTagOperationResponse` | `characterPlayer.removeTag.adminSelfEnable` |
| `setAvatar` | `CharacterPlayerModels.AdminSetAvatarRequestData` | `setAvatarAsync(...)` | `CharacterPlayerResponseModels.SetAvatarOperationResponse` | `characterPlayer.setAvatar.adminSelfEnable` |
| `setCountryCode` | `CharacterPlayerModels.AdminSetCountryCodeRequestData` | `setCountryCodeAsync(...)` | `CharacterPlayerResponseModels.SetCountryCodeOperationResponse` | `characterPlayer.setCountryCode.adminSelfEnable` |
| `setCustomData` | `CharacterPlayerModels.AdminSetCustomDataRequestData` | `setCustomDataAsync(...)` | `CharacterPlayerResponseModels.SetCustomDataOperationResponse` | `characterPlayer.setCustomData.adminSelfEnable` |
| `setDisplayName` | `CharacterPlayerModels.AdminSetDisplayNameRequestData` | `setDisplayNameAsync(...)` | `CharacterPlayerResponseModels.SetDisplayNameOperationResponse` | `characterPlayer.setDisplayName.adminSelfEnable` |
| `setOwner` | `CharacterPlayerModels.AdminSetOwnerRequestData` | `setOwnerAsync(...)` | `CharacterPlayerResponseModels.SetOwnerOperationResponse` | `characterPlayer.setOwner.adminSelfEnable` |
| `setPlayerBan` | `CharacterPlayerModels.AdminSetPlayerBanRequestData` | `setPlayerBanAsync(...)` | `CharacterPlayerResponseModels.SetPlayerBanOperationResponse` | `characterPlayer.setPlayerBan.adminSelfEnable` |
| `changePlayerCurrency` | `CharacterPlayerModels.AdminChangePlayerCurrencyRequestData` | `changePlayerCurrencyAsync(...)` | `CharacterPlayerResponseModels.ChangePlayerCurrencyOperationResponse` | `characterPlayer.changePlayerCurrency.adminSelfEnable` |
| `setPlayerData` | `CharacterPlayerModels.AdminSetPlayerDataRequestData` | `setPlayerDataAsync(...)` | `CharacterPlayerResponseModels.SetPlayerDataOperationResponse` | `characterPlayer.setPlayerData.adminSelfEnable` |
| `changePlayerStatistics` | `CharacterPlayerModels.AdminChangePlayerStatisticsRequestData` | `changePlayerStatisticsAsync(...)` | `CharacterPlayerResponseModels.ChangePlayerStatisticsOperationResponse` | `characterPlayer.changePlayerStatistics.adminSelfEnable` |
| `setRemoveStatus` | `CharacterPlayerModels.AdminSetRemoveStatusRequestData` | `setRemoveStatusAsync(...)` | `CharacterPlayerResponseModels.SetRemoveStatusOperationResponse` | `characterPlayer.setRemoveStatus.adminSelfEnable` |
| `setTag` | `CharacterPlayerModels.AdminSetTagRequestData` | `setTagAsync(...)` | `CharacterPlayerResponseModels.SetTagOperationResponse` | `characterPlayer.setTag.adminSelfEnable` |
| `getCurrencyLeaderboard` | `CharacterPlayerModels.AdminGetCurrencyLeaderboardRequestData` | `getCurrencyLeaderboardAsync(...)` | `CharacterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse` | `characterPlayer.getCurrencyLeaderboard.adminSelfEnable` |
| `getCreateLeaderboard` | `CharacterPlayerModels.AdminGetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `CharacterPlayerResponseModels.GetCreateLeaderboardOperationResponse` | `characterPlayer.getCreateLeaderboard.adminSelfEnable` |
| `getLastLoginLeaderboard` | `CharacterPlayerModels.AdminGetLastLoginLeaderboardRequestData` | `getLastLoginLeaderboardAsync(...)` | `CharacterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse` | `characterPlayer.getLastLoginLeaderboard.adminSelfEnable` |
| `getStatisticsLog` | `CharacterPlayerModels.AdminGetStatisticsLogRequestData` | `getStatisticsLogAsync(...)` | `CharacterPlayerResponseModels.GetStatisticsLogOperationResponse` | `characterPlayer.getStatisticsLog.adminSelfEnable` |
| `getCurrencyLog` | `CharacterPlayerModels.AdminGetCurrencyLogRequestData` | `getCurrencyLogAsync(...)` | `CharacterPlayerResponseModels.GetCurrencyLogOperationResponse` | `characterPlayer.getCurrencyLog.adminSelfEnable` |

## Ví dụ tối thiểu

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

// requestData: CharacterPlayerModels.AddPlayerFriendRequestData đã build theo dto/CHARACTER_PLAYER.md
var res = await GNNetwork.characterPlayer.addPlayerFriendAsync(requestData);
if (res.returnCode != ReturnCode.Ok) return;
if (res.errorCode != ErrorCode.Ok) return;
// res.responseData có typed payload
```
