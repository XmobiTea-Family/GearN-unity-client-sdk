# API Reference: GamePlayerApi

Game-player profile, friend/group relation, currency, statistics, segment, tag, social identity.

- Domain guide: [guides/GAME_PLAYER.md](/docs/guides/GAME_PLAYER.md)
- DTO shapes: [dto/GAME_PLAYER.md](/docs/reference/dto/GAME_PLAYER.md)
- Enums: [ENUMS.md](/docs/reference/ENUMS.md)
- Error handling: [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md)
- Permission rules: [PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md)

## Namespaces

- `GNNetwork.gamePlayer` — `RequestRole.Client`
- `GNNetwork.gamePlayer.server` — `RequestRole.Server`
- `GNNetwork.gamePlayer.admin` — `RequestRole.Admin`

## Convention

Mỗi method dưới đây có 2 form — callback và `*Async()` Task. Ưu tiên `*Async()`.

```text
// Callback
GNNetwork.gamePlayer.<method>(requestData, onResponse?, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);

// Async
var res = await GNNetwork.gamePlayer.<method>Async(requestData, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);
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

## Client methods (`GNNetwork.gamePlayer.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules | Permission Rules khi truyền `userId` khác với `gamePlayer` đang authenticated |
| --- | --- | --- | --- | --- | --- |
| `addPlayerFriend` | `GamePlayerModels.AddPlayerFriendRequestData` | `addPlayerFriendAsync(...)` | `GamePlayerResponseModels.AddPlayerFriendOperationResponse` | `gamePlayer.addPlayerFriend.selfEnable` | `gamePlayer.addPlayerFriend.otherSelfEnable` |
| `addSegment` | `GamePlayerModels.AddSegmentRequestData` | `addSegmentAsync(...)` | `GamePlayerResponseModels.AddSegmentOperationResponse` | `gamePlayer.addSegment.selfEnable` | `gamePlayer.addSegment.otherSelfEnable` |
| `getAvatar` | `GamePlayerModels.GetAvatarRequestData` | `getAvatarAsync(...)` | `GamePlayerResponseModels.GetAvatarOperationResponse` | `gamePlayer.getAvatar.selfEnable` | `gamePlayer.getAvatar.otherSelfEnable` |
| `getCountryCode` | `GamePlayerModels.GetCountryCodeRequestData` | `getCountryCodeAsync(...)` | `GamePlayerResponseModels.GetCountryCodeOperationResponse` | `gamePlayer.getCountryCode.selfEnable` | `gamePlayer.getCountryCode.otherSelfEnable` |
| `getCustomData` | `GamePlayerModels.GetCustomDataRequestData` | `getCustomDataAsync(...)` | `GamePlayerResponseModels.GetCustomDataOperationResponse` | `gamePlayer.getCustomData.selfEnable` | `gamePlayer.getCustomData.otherSelfEnable` |
| `getDisplayName` | `GamePlayerModels.GetDisplayNameRequestData` | `getDisplayNameAsync(...)` | `GamePlayerResponseModels.GetDisplayNameOperationResponse` | `gamePlayer.getDisplayName.selfEnable` | `gamePlayer.getDisplayName.otherSelfEnable` |
| `getFriendStatisticsLeaderboardAroundPlayer` | `GamePlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData` | `getFriendStatisticsLeaderboardAroundPlayerAsync(...)` | `GamePlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse` | `gamePlayer.getFriendStatisticsLeaderboardAroundPlayer.selfEnable` | `gamePlayer.getFriendStatisticsLeaderboardAroundPlayer.otherSelfEnable` |
| `getFriendStatisticsLeaderboard` | `GamePlayerModels.GetFriendStatisticsLeaderboardRequestData` | `getFriendStatisticsLeaderboardAsync(...)` | `GamePlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse` | `gamePlayer.getFriendStatisticsLeaderboard.selfEnable` | `gamePlayer.getFriendStatisticsLeaderboard.otherSelfEnable` |
| `getIpAddressCreate` | `GamePlayerModels.GetIpAddressCreateRequestData` | `getIpAddressCreateAsync(...)` | `GamePlayerResponseModels.GetIpAddressCreateOperationResponse` | `gamePlayer.getIpAddressCreate.selfEnable` | `gamePlayer.getIpAddressCreate.otherSelfEnable` |
| `getOnlineStatus` | `GamePlayerModels.GetOnlineStatusRequestData` | `getOnlineStatusAsync(...)` | `GamePlayerResponseModels.GetOnlineStatusOperationResponse` | `gamePlayer.getOnlineStatus.selfEnable` | `gamePlayer.getOnlineStatus.otherSelfEnable` |
| `getPlayerBan` | `GamePlayerModels.GetPlayerBanRequestData` | `getPlayerBanAsync(...)` | `GamePlayerResponseModels.GetPlayerBanOperationResponse` | `gamePlayer.getPlayerBan.selfEnable` | `gamePlayer.getPlayerBan.otherSelfEnable` |
| `getPlayerCharacter` | `GamePlayerModels.GetPlayerCharacterRequestData` | `getPlayerCharacterAsync(...)` | `GamePlayerResponseModels.GetPlayerCharacterOperationResponse` | `gamePlayer.getPlayerCharacter.selfEnable` | `gamePlayer.getPlayerCharacter.otherSelfEnable` |
| `getPlayerCurrency` | `GamePlayerModels.GetPlayerCurrencyRequestData` | `getPlayerCurrencyAsync(...)` | `GamePlayerResponseModels.GetPlayerCurrencyOperationResponse` | `gamePlayer.getPlayerCurrency.selfEnable` | `gamePlayer.getPlayerCurrency.otherSelfEnable` |
| `getPlayerData` | `GamePlayerModels.GetPlayerDataRequestData` | `getPlayerDataAsync(...)` | `GamePlayerResponseModels.GetPlayerDataOperationResponse` | `gamePlayer.getPlayerData.selfEnable` | `gamePlayer.getPlayerData.otherSelfEnable` |
| `getPlayerFriend` | `GamePlayerModels.GetPlayerFriendRequestData` | `getPlayerFriendAsync(...)` | `GamePlayerResponseModels.GetPlayerFriendOperationResponse` | `gamePlayer.getPlayerFriend.selfEnable` | `gamePlayer.getPlayerFriend.otherSelfEnable` |
| `getPlayerGroup` | `GamePlayerModels.GetPlayerGroupRequestData` | `getPlayerGroupAsync(...)` | `GamePlayerResponseModels.GetPlayerGroupOperationResponse` | `gamePlayer.getPlayerGroup.selfEnable` | `gamePlayer.getPlayerGroup.otherSelfEnable` |
| `getPlayerInformation` | `GamePlayerModels.GetPlayerInformationRequestData` | `getPlayerInformationAsync(...)` | `GamePlayerResponseModels.GetPlayerInformationOperationResponse` | `gamePlayer.getPlayerInformation.selfEnable` | `gamePlayer.getPlayerInformation.otherSelfEnable` |
| `getPlayerInventory` | `GamePlayerModels.GetPlayerInventoryRequestData` | `getPlayerInventoryAsync(...)` | `GamePlayerResponseModels.GetPlayerInventoryOperationResponse` | `gamePlayer.getPlayerInventory.selfEnable` | `gamePlayer.getPlayerInventory.otherSelfEnable` |
| `getPlayerStatistics` | `GamePlayerModels.GetPlayerStatisticsRequestData` | `getPlayerStatisticsAsync(...)` | `GamePlayerResponseModels.GetPlayerStatisticsOperationResponse` | `gamePlayer.getPlayerStatistics.selfEnable` | `gamePlayer.getPlayerStatistics.otherSelfEnable` |
| `getPlayersWithDisplayName` | `GamePlayerModels.GetPlayersWithDisplayNameRequestData` | `getPlayersWithDisplayNameAsync(...)` | `GamePlayerResponseModels.GetPlayersWithDisplayNameOperationResponse` | `gamePlayer.getPlayersWithDisplayName.otherSelfEnable` | |
| `getPlayersWithSegment` | `GamePlayerModels.GetPlayersWithSegmentRequestData` | `getPlayersWithSegmentAsync(...)` | `GamePlayerResponseModels.GetPlayersWithSegmentOperationResponse` | `gamePlayer.getPlayersWithSegment.otherSelfEnable` | |
| `getPlayersWithTag` | `GamePlayerModels.GetPlayersWithTagRequestData` | `getPlayersWithTagAsync(...)` | `GamePlayerResponseModels.GetPlayersWithTagOperationResponse` | `gamePlayer.getPlayersWithTag.otherSelfEnable` | |
| `getSegment` | `GamePlayerModels.GetSegmentRequestData` | `getSegmentAsync(...)` | `GamePlayerResponseModels.GetSegmentOperationResponse` | `gamePlayer.getSegment.selfEnable` | `gamePlayer.getSegment.otherSelfEnable` |
| `getStatisticsLeaderboardAroundPlayer` | `GamePlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData` | `getStatisticsLeaderboardAroundPlayerAsync(...)` | `GamePlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse` | `gamePlayer.getStatisticsLeaderboardAroundPlayer.selfEnable` | `gamePlayer.getStatisticsLeaderboardAroundPlayer.otherSelfEnable` |
| `getStatisticsLeaderboard` | `GamePlayerModels.GetStatisticsLeaderboardRequestData` | `getStatisticsLeaderboardAsync(...)` | `GamePlayerResponseModels.GetStatisticsLeaderboardOperationResponse` | `gamePlayer.getStatisticsLeaderboard.otherSelfEnable` | |
| `getTag` | `GamePlayerModels.GetTagRequestData` | `getTagAsync(...)` | `GamePlayerResponseModels.GetTagOperationResponse` | `gamePlayer.getTag.selfEnable` | `gamePlayer.getTag.otherSelfEnable` |
| `getTsCreate` | `GamePlayerModels.GetTsCreateRequestData` | `getTsCreateAsync(...)` | `GamePlayerResponseModels.GetTsCreateOperationResponse` | `gamePlayer.getTsCreate.selfEnable` | `gamePlayer.getTsCreate.otherSelfEnable` |
| `getTsLastLogin` | `GamePlayerModels.GetTsLastLoginRequestData` | `getTsLastLoginAsync(...)` | `GamePlayerResponseModels.GetTsLastLoginOperationResponse` | `gamePlayer.getTsLastLogin.selfEnable` | `gamePlayer.getTsLastLogin.otherSelfEnable` |
| `createGroup` | `GamePlayerModels.CreateGroupRequestData` | `createGroupAsync(...)` | `GamePlayerResponseModels.CreateGroupOperationResponse` | `gamePlayer.createGroup.selfEnable` | `gamePlayer.createGroup.otherSelfEnable` |
| `createPlayerCharacter` | `GamePlayerModels.CreatePlayerCharacterRequestData` | `createPlayerCharacterAsync(...)` | `GamePlayerResponseModels.CreatePlayerCharacterOperationResponse` | `gamePlayer.createPlayerCharacter.selfEnable` | `gamePlayer.createPlayerCharacter.otherSelfEnable` |
| `createPlayerItem` | `GamePlayerModels.CreatePlayerItemRequestData` | `createPlayerItemAsync(...)` | `GamePlayerResponseModels.CreatePlayerItemOperationResponse` | `gamePlayer.createPlayerItem.selfEnable` | `gamePlayer.createPlayerItem.otherSelfEnable` |
| `joinGroup` | `GamePlayerModels.JoinGroupRequestData` | `joinGroupAsync(...)` | `GamePlayerResponseModels.JoinGroupOperationResponse` | `gamePlayer.joinGroup.selfEnable` | `gamePlayer.joinGroup.otherSelfEnable` |
| `leaveGroup` | `GamePlayerModels.LeaveGroupRequestData` | `leaveGroupAsync(...)` | `GamePlayerResponseModels.LeaveGroupOperationResponse` | `gamePlayer.leaveGroup.selfEnable` | `gamePlayer.leaveGroup.otherSelfEnable` |
| `removePlayerCharacter` | `GamePlayerModels.RemovePlayerCharacterRequestData` | `removePlayerCharacterAsync(...)` | `GamePlayerResponseModels.RemovePlayerCharacterOperationResponse` | `gamePlayer.removePlayerCharacter.selfEnable` | `gamePlayer.removePlayerCharacter.otherSelfEnable` |
| `removePlayerFriend` | `GamePlayerModels.RemovePlayerFriendRequestData` | `removePlayerFriendAsync(...)` | `GamePlayerResponseModels.RemovePlayerFriendOperationResponse` | `gamePlayer.removePlayerFriend.selfEnable` | `gamePlayer.removePlayerFriend.otherSelfEnable` |
| `removePlayerItem` | `GamePlayerModels.RemovePlayerItemRequestData` | `removePlayerItemAsync(...)` | `GamePlayerResponseModels.RemovePlayerItemOperationResponse` | `gamePlayer.removePlayerItem.selfEnable` | `gamePlayer.removePlayerItem.otherSelfEnable` |
| `removeSegment` | `GamePlayerModels.RemoveSegmentRequestData` | `removeSegmentAsync(...)` | `GamePlayerResponseModels.RemoveSegmentOperationResponse` | `gamePlayer.removeSegment.selfEnable` | `gamePlayer.removeSegment.otherSelfEnable` |
| `removeTag` | `GamePlayerModels.RemoveTagRequestData` | `removeTagAsync(...)` | `GamePlayerResponseModels.RemoveTagOperationResponse` | `gamePlayer.removeTag.selfEnable` | `gamePlayer.removeTag.otherSelfEnable` |
| `setAvatar` | `GamePlayerModels.SetAvatarRequestData` | `setAvatarAsync(...)` | `GamePlayerResponseModels.SetAvatarOperationResponse` | `gamePlayer.setAvatar.selfEnable` | `gamePlayer.setAvatar.otherSelfEnable` |
| `setCountryCode` | `GamePlayerModels.SetCountryCodeRequestData` | `setCountryCodeAsync(...)` | `GamePlayerResponseModels.SetCountryCodeOperationResponse` | `gamePlayer.setCountryCode.selfEnable` | `gamePlayer.setCountryCode.otherSelfEnable` |
| `setCustomData` | `GamePlayerModels.SetCustomDataRequestData` | `setCustomDataAsync(...)` | `GamePlayerResponseModels.SetCustomDataOperationResponse` | `gamePlayer.setCustomData.selfEnable` | `gamePlayer.setCustomData.otherSelfEnable` |
| `setDisplayName` | `GamePlayerModels.SetDisplayNameRequestData` | `setDisplayNameAsync(...)` | `GamePlayerResponseModels.SetDisplayNameOperationResponse` | `gamePlayer.setDisplayName.selfEnable` | `gamePlayer.setDisplayName.otherSelfEnable` |
| `setPlayerBan` | `GamePlayerModels.SetPlayerBanRequestData` | `setPlayerBanAsync(...)` | `GamePlayerResponseModels.SetPlayerBanOperationResponse` | `gamePlayer.setPlayerBan.selfEnable` | `gamePlayer.setPlayerBan.otherSelfEnable` |
| `changePlayerCurrency` | `GamePlayerModels.ChangePlayerCurrencyRequestData` | `changePlayerCurrencyAsync(...)` | `GamePlayerResponseModels.ChangePlayerCurrencyOperationResponse` | `gamePlayer.changePlayerCurrency.selfEnable` | `gamePlayer.changePlayerCurrency.otherSelfEnable` |
| `setPlayerData` | `GamePlayerModels.SetPlayerDataRequestData` | `setPlayerDataAsync(...)` | `GamePlayerResponseModels.SetPlayerDataOperationResponse` | `gamePlayer.setPlayerData.selfEnable` | `gamePlayer.setPlayerData.otherSelfEnable` |
| `changePlayerStatistics` | `GamePlayerModels.ChangePlayerStatisticsRequestData` | `changePlayerStatisticsAsync(...)` | `GamePlayerResponseModels.ChangePlayerStatisticsOperationResponse` | `gamePlayer.changePlayerStatistics.selfEnable` | `gamePlayer.changePlayerStatistics.otherSelfEnable` |
| `setTag` | `GamePlayerModels.SetTagRequestData` | `setTagAsync(...)` | `GamePlayerResponseModels.SetTagOperationResponse` | `gamePlayer.setTag.selfEnable` | `gamePlayer.setTag.otherSelfEnable` |
| `getCurrencyLeaderboard` | `GamePlayerModels.GetCurrencyLeaderboardRequestData` | `getCurrencyLeaderboardAsync(...)` | `GamePlayerResponseModels.GetCurrencyLeaderboardOperationResponse` | `gamePlayer.getCurrencyLeaderboard.otherSelfEnable` | |
| `getLastLoginLeaderboard` | `GamePlayerModels.GetLastLoginLeaderboardRequestData` | `getLastLoginLeaderboardAsync(...)` | `GamePlayerResponseModels.GetLastLoginLeaderboardOperationResponse` | `gamePlayer.getLastLoginLeaderboard.otherSelfEnable` | |
| `getCreateLeaderboard` | `GamePlayerModels.GetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `GamePlayerResponseModels.GetCreateLeaderboardOperationResponse` | `gamePlayer.getCreateLeaderboard.otherSelfEnable` | |
| `getStatisticsLog` | `GamePlayerModels.GetStatisticsLogRequestData` | `getStatisticsLogAsync(...)` | `GamePlayerResponseModels.GetStatisticsLogOperationResponse` | `gamePlayer.getStatisticsLog.selfEnable` | `gamePlayer.getStatisticsLog.otherSelfEnable` |
| `getCurrencyLog` | `GamePlayerModels.GetCurrencyLogRequestData` | `getCurrencyLogAsync(...)` | `GamePlayerResponseModels.GetCurrencyLogOperationResponse` | `gamePlayer.getCurrencyLog.selfEnable` | `gamePlayer.getCurrencyLog.otherSelfEnable` |

## Server methods (`GNNetwork.gamePlayer.server.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules |
| --- | --- | --- | --- | --- |
| `addPlayerFriend` | `GamePlayerModels.ServerAddPlayerFriendRequestData` | `addPlayerFriendAsync(...)` | `GamePlayerResponseModels.AddPlayerFriendOperationResponse` | `gamePlayer.addPlayerFriend.serverSelfEnable` |
| `addSegment` | `GamePlayerModels.ServerAddSegmentRequestData` | `addSegmentAsync(...)` | `GamePlayerResponseModels.AddSegmentOperationResponse` | `gamePlayer.addSegment.serverSelfEnable` |
| `getAvatar` | `GamePlayerModels.ServerGetAvatarRequestData` | `getAvatarAsync(...)` | `GamePlayerResponseModels.GetAvatarOperationResponse` | `gamePlayer.getAvatar.serverSelfEnable` |
| `getCountryCode` | `GamePlayerModels.ServerGetCountryCodeRequestData` | `getCountryCodeAsync(...)` | `GamePlayerResponseModels.GetCountryCodeOperationResponse` | `gamePlayer.getCountryCode.serverSelfEnable` |
| `getCustomData` | `GamePlayerModels.ServerGetCustomDataRequestData` | `getCustomDataAsync(...)` | `GamePlayerResponseModels.GetCustomDataOperationResponse` | `gamePlayer.getCustomData.serverSelfEnable` |
| `getDisplayName` | `GamePlayerModels.ServerGetDisplayNameRequestData` | `getDisplayNameAsync(...)` | `GamePlayerResponseModels.GetDisplayNameOperationResponse` | `gamePlayer.getDisplayName.serverSelfEnable` |
| `getFriendStatisticsLeaderboardAroundPlayer` | `GamePlayerModels.ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData` | `getFriendStatisticsLeaderboardAroundPlayerAsync(...)` | `GamePlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse` | `gamePlayer.getFriendStatisticsLeaderboardAroundPlayer.serverSelfEnable` |
| `getFriendStatisticsLeaderboard` | `GamePlayerModels.ServerGetFriendStatisticsLeaderboardRequestData` | `getFriendStatisticsLeaderboardAsync(...)` | `GamePlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse` | `gamePlayer.getFriendStatisticsLeaderboard.serverSelfEnable` |
| `getIpAddressCreate` | `GamePlayerModels.ServerGetIpAddressCreateRequestData` | `getIpAddressCreateAsync(...)` | `GamePlayerResponseModels.GetIpAddressCreateOperationResponse` | `gamePlayer.getIpAddressCreate.serverSelfEnable` |
| `getOnlineStatus` | `GamePlayerModels.ServerGetOnlineStatusRequestData` | `getOnlineStatusAsync(...)` | `GamePlayerResponseModels.GetOnlineStatusOperationResponse` | `gamePlayer.getOnlineStatus.serverSelfEnable` |
| `getPlayerBan` | `GamePlayerModels.ServerGetPlayerBanRequestData` | `getPlayerBanAsync(...)` | `GamePlayerResponseModels.GetPlayerBanOperationResponse` | `gamePlayer.getPlayerBan.serverSelfEnable` |
| `getPlayerCharacter` | `GamePlayerModels.ServerGetPlayerCharacterRequestData` | `getPlayerCharacterAsync(...)` | `GamePlayerResponseModels.GetPlayerCharacterOperationResponse` | `gamePlayer.getPlayerCharacter.serverSelfEnable` |
| `getPlayerCurrency` | `GamePlayerModels.ServerGetPlayerCurrencyRequestData` | `getPlayerCurrencyAsync(...)` | `GamePlayerResponseModels.GetPlayerCurrencyOperationResponse` | `gamePlayer.getPlayerCurrency.serverSelfEnable` |
| `getPlayerData` | `GamePlayerModels.ServerGetPlayerDataRequestData` | `getPlayerDataAsync(...)` | `GamePlayerResponseModels.GetPlayerDataOperationResponse` | `gamePlayer.getPlayerData.serverSelfEnable` |
| `getPlayerFriend` | `GamePlayerModels.ServerGetPlayerFriendRequestData` | `getPlayerFriendAsync(...)` | `GamePlayerResponseModels.GetPlayerFriendOperationResponse` | `gamePlayer.getPlayerFriend.serverSelfEnable` |
| `getPlayerGroup` | `GamePlayerModels.ServerGetPlayerGroupRequestData` | `getPlayerGroupAsync(...)` | `GamePlayerResponseModels.GetPlayerGroupOperationResponse` | `gamePlayer.getPlayerGroup.serverSelfEnable` |
| `getPlayerInformation` | `GamePlayerModels.ServerGetPlayerInformationRequestData` | `getPlayerInformationAsync(...)` | `GamePlayerResponseModels.GetPlayerInformationOperationResponse` | `gamePlayer.getPlayerInformation.serverSelfEnable` |
| `getPlayerInventory` | `GamePlayerModels.ServerGetPlayerInventoryRequestData` | `getPlayerInventoryAsync(...)` | `GamePlayerResponseModels.GetPlayerInventoryOperationResponse` | `gamePlayer.getPlayerInventory.serverSelfEnable` |
| `getPlayerStatistics` | `GamePlayerModels.ServerGetPlayerStatisticsRequestData` | `getPlayerStatisticsAsync(...)` | `GamePlayerResponseModels.GetPlayerStatisticsOperationResponse` | `gamePlayer.getPlayerStatistics.serverSelfEnable` |
| `getPlayersWithDisplayName` | `GamePlayerModels.ServerGetPlayersWithDisplayNameRequestData` | `getPlayersWithDisplayNameAsync(...)` | `GamePlayerResponseModels.GetPlayersWithDisplayNameOperationResponse` | `gamePlayer.getPlayersWithDisplayName.serverSelfEnable` |
| `getPlayersWithSegment` | `GamePlayerModels.ServerGetPlayersWithSegmentRequestData` | `getPlayersWithSegmentAsync(...)` | `GamePlayerResponseModels.GetPlayersWithSegmentOperationResponse` | `gamePlayer.getPlayersWithSegment.serverSelfEnable` |
| `getPlayersWithTag` | `GamePlayerModels.ServerGetPlayersWithTagRequestData` | `getPlayersWithTagAsync(...)` | `GamePlayerResponseModels.GetPlayersWithTagOperationResponse` | `gamePlayer.getPlayersWithTag.serverSelfEnable` |
| `getSegment` | `GamePlayerModels.ServerGetSegmentRequestData` | `getSegmentAsync(...)` | `GamePlayerResponseModels.GetSegmentOperationResponse` | `gamePlayer.getSegment.serverSelfEnable` |
| `getStatisticsLeaderboardAroundPlayer` | `GamePlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData` | `getStatisticsLeaderboardAroundPlayerAsync(...)` | `GamePlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse` | `gamePlayer.getStatisticsLeaderboardAroundPlayer.serverSelfEnable` |
| `getStatisticsLeaderboard` | `GamePlayerModels.ServerGetStatisticsLeaderboardRequestData` | `getStatisticsLeaderboardAsync(...)` | `GamePlayerResponseModels.GetStatisticsLeaderboardOperationResponse` | `gamePlayer.getStatisticsLeaderboard.serverSelfEnable` |
| `getTag` | `GamePlayerModels.ServerGetTagRequestData` | `getTagAsync(...)` | `GamePlayerResponseModels.GetTagOperationResponse` | `gamePlayer.getTag.serverSelfEnable` |
| `getTsCreate` | `GamePlayerModels.ServerGetTsCreateRequestData` | `getTsCreateAsync(...)` | `GamePlayerResponseModels.GetTsCreateOperationResponse` | `gamePlayer.getTsCreate.serverSelfEnable` |
| `getTsLastLogin` | `GamePlayerModels.ServerGetTsLastLoginRequestData` | `getTsLastLoginAsync(...)` | `GamePlayerResponseModels.GetTsLastLoginOperationResponse` | `gamePlayer.getTsLastLogin.serverSelfEnable` |
| `createGroup` | `GamePlayerModels.ServerCreateGroupRequestData` | `createGroupAsync(...)` | `GamePlayerResponseModels.CreateGroupOperationResponse` | `gamePlayer.createGroup.serverSelfEnable` |
| `createPlayerCharacter` | `GamePlayerModels.ServerCreatePlayerCharacterRequestData` | `createPlayerCharacterAsync(...)` | `GamePlayerResponseModels.CreatePlayerCharacterOperationResponse` | `gamePlayer.createPlayerCharacter.serverSelfEnable` |
| `createPlayerItem` | `GamePlayerModels.ServerCreatePlayerItemRequestData` | `createPlayerItemAsync(...)` | `GamePlayerResponseModels.CreatePlayerItemOperationResponse` | `gamePlayer.createPlayerItem.serverSelfEnable` |
| `joinGroup` | `GamePlayerModels.ServerJoinGroupRequestData` | `joinGroupAsync(...)` | `GamePlayerResponseModels.JoinGroupOperationResponse` | `gamePlayer.joinGroup.serverSelfEnable` |
| `leaveGroup` | `GamePlayerModels.ServerLeaveGroupRequestData` | `leaveGroupAsync(...)` | `GamePlayerResponseModels.LeaveGroupOperationResponse` | `gamePlayer.leaveGroup.serverSelfEnable` |
| `removePlayerCharacter` | `GamePlayerModels.ServerRemovePlayerCharacterRequestData` | `removePlayerCharacterAsync(...)` | `GamePlayerResponseModels.RemovePlayerCharacterOperationResponse` | `gamePlayer.removePlayerCharacter.serverSelfEnable` |
| `removePlayerFriend` | `GamePlayerModels.ServerRemovePlayerFriendRequestData` | `removePlayerFriendAsync(...)` | `GamePlayerResponseModels.RemovePlayerFriendOperationResponse` | `gamePlayer.removePlayerFriend.serverSelfEnable` |
| `removePlayerItem` | `GamePlayerModels.ServerRemovePlayerItemRequestData` | `removePlayerItemAsync(...)` | `GamePlayerResponseModels.RemovePlayerItemOperationResponse` | `gamePlayer.removePlayerItem.serverSelfEnable` |
| `removeSegment` | `GamePlayerModels.ServerRemoveSegmentRequestData` | `removeSegmentAsync(...)` | `GamePlayerResponseModels.RemoveSegmentOperationResponse` | `gamePlayer.removeSegment.serverSelfEnable` |
| `removeTag` | `GamePlayerModels.ServerRemoveTagRequestData` | `removeTagAsync(...)` | `GamePlayerResponseModels.RemoveTagOperationResponse` | `gamePlayer.removeTag.serverSelfEnable` |
| `setAvatar` | `GamePlayerModels.ServerSetAvatarRequestData` | `setAvatarAsync(...)` | `GamePlayerResponseModels.SetAvatarOperationResponse` | `gamePlayer.setAvatar.serverSelfEnable` |
| `setCountryCode` | `GamePlayerModels.ServerSetCountryCodeRequestData` | `setCountryCodeAsync(...)` | `GamePlayerResponseModels.SetCountryCodeOperationResponse` | `gamePlayer.setCountryCode.serverSelfEnable` |
| `setCustomData` | `GamePlayerModels.ServerSetCustomDataRequestData` | `setCustomDataAsync(...)` | `GamePlayerResponseModels.SetCustomDataOperationResponse` | `gamePlayer.setCustomData.serverSelfEnable` |
| `setDisplayName` | `GamePlayerModels.ServerSetDisplayNameRequestData` | `setDisplayNameAsync(...)` | `GamePlayerResponseModels.SetDisplayNameOperationResponse` | `gamePlayer.setDisplayName.serverSelfEnable` |
| `setPlayerBan` | `GamePlayerModels.ServerSetPlayerBanRequestData` | `setPlayerBanAsync(...)` | `GamePlayerResponseModels.SetPlayerBanOperationResponse` | `gamePlayer.setPlayerBan.serverSelfEnable` |
| `changePlayerCurrency` | `GamePlayerModels.ServerChangePlayerCurrencyRequestData` | `changePlayerCurrencyAsync(...)` | `GamePlayerResponseModels.ChangePlayerCurrencyOperationResponse` | `gamePlayer.changePlayerCurrency.serverSelfEnable` |
| `setPlayerData` | `GamePlayerModels.ServerSetPlayerDataRequestData` | `setPlayerDataAsync(...)` | `GamePlayerResponseModels.SetPlayerDataOperationResponse` | `gamePlayer.setPlayerData.serverSelfEnable` |
| `changePlayerStatistics` | `GamePlayerModels.ServerChangePlayerStatisticsRequestData` | `changePlayerStatisticsAsync(...)` | `GamePlayerResponseModels.ChangePlayerStatisticsOperationResponse` | `gamePlayer.changePlayerStatistics.serverSelfEnable` |
| `setTag` | `GamePlayerModels.ServerSetTagRequestData` | `setTagAsync(...)` | `GamePlayerResponseModels.SetTagOperationResponse` | `gamePlayer.setTag.serverSelfEnable` |
| `getCurrencyLeaderboard` | `GamePlayerModels.ServerGetCurrencyLeaderboardRequestData` | `getCurrencyLeaderboardAsync(...)` | `GamePlayerResponseModels.GetCurrencyLeaderboardOperationResponse` | `gamePlayer.getCurrencyLeaderboard.serverSelfEnable` |
| `getLastLoginLeaderboard` | `GamePlayerModels.ServerGetLastLoginLeaderboardRequestData` | `getLastLoginLeaderboardAsync(...)` | `GamePlayerResponseModels.GetLastLoginLeaderboardOperationResponse` | `gamePlayer.getLastLoginLeaderboard.serverSelfEnable` |
| `getCreateLeaderboard` | `GamePlayerModels.ServerGetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `GamePlayerResponseModels.GetCreateLeaderboardOperationResponse` | `gamePlayer.getCreateLeaderboard.serverSelfEnable` |
| `getStatisticsLog` | `GamePlayerModels.ServerGetStatisticsLogRequestData` | `getStatisticsLogAsync(...)` | `GamePlayerResponseModels.GetStatisticsLogOperationResponse` | `gamePlayer.getStatisticsLog.serverSelfEnable` |
| `getCurrencyLog` | `GamePlayerModels.ServerGetCurrencyLogRequestData` | `getCurrencyLogAsync(...)` | `GamePlayerResponseModels.GetCurrencyLogOperationResponse` | `gamePlayer.getCurrencyLog.serverSelfEnable` |

## Admin methods (`GNNetwork.gamePlayer.admin.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules |
| --- | --- | --- | --- | --- |
| `addPlayerFriend` | `GamePlayerModels.AdminAddPlayerFriendRequestData` | `addPlayerFriendAsync(...)` | `GamePlayerResponseModels.AddPlayerFriendOperationResponse` | `gamePlayer.addPlayerFriend.adminSelfEnable` |
| `addSegment` | `GamePlayerModels.AdminAddSegmentRequestData` | `addSegmentAsync(...)` | `GamePlayerResponseModels.AddSegmentOperationResponse` | `gamePlayer.addSegment.adminSelfEnable` |
| `getAvatar` | `GamePlayerModels.AdminGetAvatarRequestData` | `getAvatarAsync(...)` | `GamePlayerResponseModels.GetAvatarOperationResponse` | `gamePlayer.getAvatar.adminSelfEnable` |
| `getCountryCode` | `GamePlayerModels.AdminGetCountryCodeRequestData` | `getCountryCodeAsync(...)` | `GamePlayerResponseModels.GetCountryCodeOperationResponse` | `gamePlayer.getCountryCode.adminSelfEnable` |
| `getCustomData` | `GamePlayerModels.AdminGetCustomDataRequestData` | `getCustomDataAsync(...)` | `GamePlayerResponseModels.GetCustomDataOperationResponse` | `gamePlayer.getCustomData.adminSelfEnable` |
| `getDisplayName` | `GamePlayerModels.AdminGetDisplayNameRequestData` | `getDisplayNameAsync(...)` | `GamePlayerResponseModels.GetDisplayNameOperationResponse` | `gamePlayer.getDisplayName.adminSelfEnable` |
| `getFriendStatisticsLeaderboardAroundPlayer` | `GamePlayerModels.AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData` | `getFriendStatisticsLeaderboardAroundPlayerAsync(...)` | `GamePlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse` | `gamePlayer.getFriendStatisticsLeaderboardAroundPlayer.adminSelfEnable` |
| `getFriendStatisticsLeaderboard` | `GamePlayerModels.AdminGetFriendStatisticsLeaderboardRequestData` | `getFriendStatisticsLeaderboardAsync(...)` | `GamePlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse` | `gamePlayer.getFriendStatisticsLeaderboard.adminSelfEnable` |
| `getIpAddressCreate` | `GamePlayerModels.AdminGetIpAddressCreateRequestData` | `getIpAddressCreateAsync(...)` | `GamePlayerResponseModels.GetIpAddressCreateOperationResponse` | `gamePlayer.getIpAddressCreate.adminSelfEnable` |
| `getOnlineStatus` | `GamePlayerModels.AdminGetOnlineStatusRequestData` | `getOnlineStatusAsync(...)` | `GamePlayerResponseModels.GetOnlineStatusOperationResponse` | `gamePlayer.getOnlineStatus.adminSelfEnable` |
| `getPlayerBan` | `GamePlayerModels.AdminGetPlayerBanRequestData` | `getPlayerBanAsync(...)` | `GamePlayerResponseModels.GetPlayerBanOperationResponse` | `gamePlayer.getPlayerBan.adminSelfEnable` |
| `getPlayerCharacter` | `GamePlayerModels.AdminGetPlayerCharacterRequestData` | `getPlayerCharacterAsync(...)` | `GamePlayerResponseModels.GetPlayerCharacterOperationResponse` | `gamePlayer.getPlayerCharacter.adminSelfEnable` |
| `getPlayerCurrency` | `GamePlayerModels.AdminGetPlayerCurrencyRequestData` | `getPlayerCurrencyAsync(...)` | `GamePlayerResponseModels.GetPlayerCurrencyOperationResponse` | `gamePlayer.getPlayerCurrency.adminSelfEnable` |
| `getPlayerData` | `GamePlayerModels.AdminGetPlayerDataRequestData` | `getPlayerDataAsync(...)` | `GamePlayerResponseModels.GetPlayerDataOperationResponse` | `gamePlayer.getPlayerData.adminSelfEnable` |
| `getPlayerFriend` | `GamePlayerModels.AdminGetPlayerFriendRequestData` | `getPlayerFriendAsync(...)` | `GamePlayerResponseModels.GetPlayerFriendOperationResponse` | `gamePlayer.getPlayerFriend.adminSelfEnable` |
| `getPlayerGroup` | `GamePlayerModels.AdminGetPlayerGroupRequestData` | `getPlayerGroupAsync(...)` | `GamePlayerResponseModels.GetPlayerGroupOperationResponse` | `gamePlayer.getPlayerGroup.adminSelfEnable` |
| `getPlayerInformation` | `GamePlayerModels.AdminGetPlayerInformationRequestData` | `getPlayerInformationAsync(...)` | `GamePlayerResponseModels.GetPlayerInformationOperationResponse` | `gamePlayer.getPlayerInformation.adminSelfEnable` |
| `getPlayerInventory` | `GamePlayerModels.AdminGetPlayerInventoryRequestData` | `getPlayerInventoryAsync(...)` | `GamePlayerResponseModels.GetPlayerInventoryOperationResponse` | `gamePlayer.getPlayerInventory.adminSelfEnable` |
| `getPlayerStatistics` | `GamePlayerModels.AdminGetPlayerStatisticsRequestData` | `getPlayerStatisticsAsync(...)` | `GamePlayerResponseModels.GetPlayerStatisticsOperationResponse` | `gamePlayer.getPlayerStatistics.adminSelfEnable` |
| `getPlayersWithDisplayName` | `GamePlayerModels.AdminGetPlayersWithDisplayNameRequestData` | `getPlayersWithDisplayNameAsync(...)` | `GamePlayerResponseModels.GetPlayersWithDisplayNameOperationResponse` | `gamePlayer.getPlayersWithDisplayName.adminSelfEnable` |
| `getPlayersWithSegment` | `GamePlayerModels.AdminGetPlayersWithSegmentRequestData` | `getPlayersWithSegmentAsync(...)` | `GamePlayerResponseModels.GetPlayersWithSegmentOperationResponse` | `gamePlayer.getPlayersWithSegment.adminSelfEnable` |
| `getPlayersWithTag` | `GamePlayerModels.AdminGetPlayersWithTagRequestData` | `getPlayersWithTagAsync(...)` | `GamePlayerResponseModels.GetPlayersWithTagOperationResponse` | `gamePlayer.getPlayersWithTag.adminSelfEnable` |
| `getSegment` | `GamePlayerModels.AdminGetSegmentRequestData` | `getSegmentAsync(...)` | `GamePlayerResponseModels.GetSegmentOperationResponse` | `gamePlayer.getSegment.adminSelfEnable` |
| `getStatisticsLeaderboardAroundPlayer` | `GamePlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData` | `getStatisticsLeaderboardAroundPlayerAsync(...)` | `GamePlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse` | `gamePlayer.getStatisticsLeaderboardAroundPlayer.adminSelfEnable` |
| `getStatisticsLeaderboard` | `GamePlayerModels.AdminGetStatisticsLeaderboardRequestData` | `getStatisticsLeaderboardAsync(...)` | `GamePlayerResponseModels.GetStatisticsLeaderboardOperationResponse` | `gamePlayer.getStatisticsLeaderboard.adminSelfEnable` |
| `getTag` | `GamePlayerModels.AdminGetTagRequestData` | `getTagAsync(...)` | `GamePlayerResponseModels.GetTagOperationResponse` | `gamePlayer.getTag.adminSelfEnable` |
| `getTsCreate` | `GamePlayerModels.AdminGetTsCreateRequestData` | `getTsCreateAsync(...)` | `GamePlayerResponseModels.GetTsCreateOperationResponse` | `gamePlayer.getTsCreate.adminSelfEnable` |
| `getTsLastLogin` | `GamePlayerModels.AdminGetTsLastLoginRequestData` | `getTsLastLoginAsync(...)` | `GamePlayerResponseModels.GetTsLastLoginOperationResponse` | `gamePlayer.getTsLastLogin.adminSelfEnable` |
| `createGroup` | `GamePlayerModels.AdminCreateGroupRequestData` | `createGroupAsync(...)` | `GamePlayerResponseModels.CreateGroupOperationResponse` | `gamePlayer.createGroup.adminSelfEnable` |
| `createPlayerCharacter` | `GamePlayerModels.AdminCreatePlayerCharacterRequestData` | `createPlayerCharacterAsync(...)` | `GamePlayerResponseModels.CreatePlayerCharacterOperationResponse` | `gamePlayer.createPlayerCharacter.adminSelfEnable` |
| `createPlayerItem` | `GamePlayerModels.AdminCreatePlayerItemRequestData` | `createPlayerItemAsync(...)` | `GamePlayerResponseModels.CreatePlayerItemOperationResponse` | `gamePlayer.createPlayerItem.adminSelfEnable` |
| `joinGroup` | `GamePlayerModels.AdminJoinGroupRequestData` | `joinGroupAsync(...)` | `GamePlayerResponseModels.JoinGroupOperationResponse` | `gamePlayer.joinGroup.adminSelfEnable` |
| `leaveGroup` | `GamePlayerModels.AdminLeaveGroupRequestData` | `leaveGroupAsync(...)` | `GamePlayerResponseModels.LeaveGroupOperationResponse` | `gamePlayer.leaveGroup.adminSelfEnable` |
| `removePlayerCharacter` | `GamePlayerModels.AdminRemovePlayerCharacterRequestData` | `removePlayerCharacterAsync(...)` | `GamePlayerResponseModels.RemovePlayerCharacterOperationResponse` | `gamePlayer.removePlayerCharacter.adminSelfEnable` |
| `removePlayerFriend` | `GamePlayerModels.AdminRemovePlayerFriendRequestData` | `removePlayerFriendAsync(...)` | `GamePlayerResponseModels.RemovePlayerFriendOperationResponse` | `gamePlayer.removePlayerFriend.adminSelfEnable` |
| `removePlayerItem` | `GamePlayerModels.AdminRemovePlayerItemRequestData` | `removePlayerItemAsync(...)` | `GamePlayerResponseModels.RemovePlayerItemOperationResponse` | `gamePlayer.removePlayerItem.adminSelfEnable` |
| `removeSegment` | `GamePlayerModels.AdminRemoveSegmentRequestData` | `removeSegmentAsync(...)` | `GamePlayerResponseModels.RemoveSegmentOperationResponse` | `gamePlayer.removeSegment.adminSelfEnable` |
| `removeTag` | `GamePlayerModels.AdminRemoveTagRequestData` | `removeTagAsync(...)` | `GamePlayerResponseModels.RemoveTagOperationResponse` | `gamePlayer.removeTag.adminSelfEnable` |
| `setAvatar` | `GamePlayerModels.AdminSetAvatarRequestData` | `setAvatarAsync(...)` | `GamePlayerResponseModels.SetAvatarOperationResponse` | `gamePlayer.setAvatar.adminSelfEnable` |
| `setCountryCode` | `GamePlayerModels.AdminSetCountryCodeRequestData` | `setCountryCodeAsync(...)` | `GamePlayerResponseModels.SetCountryCodeOperationResponse` | `gamePlayer.setCountryCode.adminSelfEnable` |
| `setCustomData` | `GamePlayerModels.AdminSetCustomDataRequestData` | `setCustomDataAsync(...)` | `GamePlayerResponseModels.SetCustomDataOperationResponse` | `gamePlayer.setCustomData.adminSelfEnable` |
| `setDisplayName` | `GamePlayerModels.AdminSetDisplayNameRequestData` | `setDisplayNameAsync(...)` | `GamePlayerResponseModels.SetDisplayNameOperationResponse` | `gamePlayer.setDisplayName.adminSelfEnable` |
| `setPlayerBan` | `GamePlayerModels.AdminSetPlayerBanRequestData` | `setPlayerBanAsync(...)` | `GamePlayerResponseModels.SetPlayerBanOperationResponse` | `gamePlayer.setPlayerBan.adminSelfEnable` |
| `changePlayerCurrency` | `GamePlayerModels.AdminChangePlayerCurrencyRequestData` | `changePlayerCurrencyAsync(...)` | `GamePlayerResponseModels.ChangePlayerCurrencyOperationResponse` | `gamePlayer.changePlayerCurrency.adminSelfEnable` |
| `setPlayerData` | `GamePlayerModels.AdminSetPlayerDataRequestData` | `setPlayerDataAsync(...)` | `GamePlayerResponseModels.SetPlayerDataOperationResponse` | `gamePlayer.setPlayerData.adminSelfEnable` |
| `changePlayerStatistics` | `GamePlayerModels.AdminChangePlayerStatisticsRequestData` | `changePlayerStatisticsAsync(...)` | `GamePlayerResponseModels.ChangePlayerStatisticsOperationResponse` | `gamePlayer.changePlayerStatistics.adminSelfEnable` |
| `setTag` | `GamePlayerModels.AdminSetTagRequestData` | `setTagAsync(...)` | `GamePlayerResponseModels.SetTagOperationResponse` | `gamePlayer.setTag.adminSelfEnable` |
| `getCurrencyLeaderboard` | `GamePlayerModels.AdminGetCurrencyLeaderboardRequestData` | `getCurrencyLeaderboardAsync(...)` | `GamePlayerResponseModels.GetCurrencyLeaderboardOperationResponse` | `gamePlayer.getCurrencyLeaderboard.adminSelfEnable` |
| `getLastLoginLeaderboard` | `GamePlayerModels.AdminGetLastLoginLeaderboardRequestData` | `getLastLoginLeaderboardAsync(...)` | `GamePlayerResponseModels.GetLastLoginLeaderboardOperationResponse` | `gamePlayer.getLastLoginLeaderboard.adminSelfEnable` |
| `getCreateLeaderboard` | `GamePlayerModels.AdminGetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `GamePlayerResponseModels.GetCreateLeaderboardOperationResponse` | `gamePlayer.getCreateLeaderboard.adminSelfEnable` |
| `getStatisticsLog` | `GamePlayerModels.AdminGetStatisticsLogRequestData` | `getStatisticsLogAsync(...)` | `GamePlayerResponseModels.GetStatisticsLogOperationResponse` | `gamePlayer.getStatisticsLog.adminSelfEnable` |
| `getCurrencyLog` | `GamePlayerModels.AdminGetCurrencyLogRequestData` | `getCurrencyLogAsync(...)` | `GamePlayerResponseModels.GetCurrencyLogOperationResponse` | `gamePlayer.getCurrencyLog.adminSelfEnable` |

## Ví dụ tối thiểu

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

// requestData: GamePlayerModels.AddPlayerFriendRequestData đã build theo dto/GAME_PLAYER.md
var res = await GNNetwork.gamePlayer.addPlayerFriendAsync(requestData);
if (res.returnCode != ReturnCode.Ok) return;
if (res.errorCode != ErrorCode.Ok) return;
// res.responseData có typed payload
```
