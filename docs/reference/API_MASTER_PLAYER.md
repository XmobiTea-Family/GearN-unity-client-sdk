# API Reference: MasterPlayerApi

Master-player account: identity linking, profile, contact info, external providers.

- Domain guide: [guides/MASTER_PLAYER.md](/docs/guides/MASTER_PLAYER.md)
- DTO shapes: [dto/MASTER_PLAYER.md](/docs/reference/dto/MASTER_PLAYER.md)
- Enums: [ENUMS.md](/docs/reference/ENUMS.md)
- Error handling: [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md)
- Permission rules: [PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md)

## Namespaces

- `GNNetwork.masterPlayer` — `RequestRole.Client`
- `GNNetwork.masterPlayer.server` — `RequestRole.Server`
- `GNNetwork.masterPlayer.admin` — `RequestRole.Admin`

## Convention

Mỗi method dưới đây có 2 form — callback và `*Async()` Task. Ưu tiên `*Async()`.

```text
// Callback
GNNetwork.masterPlayer.<method>(requestData, onResponse?, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);

// Async
var res = await GNNetwork.masterPlayer.<method>Async(requestData, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);
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

## Client methods (`GNNetwork.masterPlayer.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules | Permission Rules khi truyền `userId` khác với `masterPlayer` đang authenticated |
| --- | --- | --- | --- | --- | --- |
| `addSegment` | `MasterPlayerModels.AddSegmentRequestData` | `addSegmentAsync(...)` | `MasterPlayerResponseModels.AddSegmentOperationResponse` | `masterPlayer.addSegment.selfEnable` | `masterPlayer.addSegment.otherSelfEnable` |
| `changeAccountPassword` | `MasterPlayerModels.ChangeAccountPasswordRequestData` | `changeAccountPasswordAsync(...)` | `MasterPlayerResponseModels.ChangeAccountPasswordOperationResponse` | `masterPlayer.changeAccountPassword.selfEnable` | `masterPlayer.changeAccountPassword.otherSelfEnable` |
| `getAvatar` | `MasterPlayerModels.GetAvatarRequestData` | `getAvatarAsync(...)` | `MasterPlayerResponseModels.GetAvatarOperationResponse` | `masterPlayer.getAvatar.selfEnable` | `masterPlayer.getAvatar.otherSelfEnable` |
| `getCountryCode` | `MasterPlayerModels.GetCountryCodeRequestData` | `getCountryCodeAsync(...)` | `MasterPlayerResponseModels.GetCountryCodeOperationResponse` | `masterPlayer.getCountryCode.selfEnable` | `masterPlayer.getCountryCode.otherSelfEnable` |
| `getCustomData` | `MasterPlayerModels.GetCustomDataRequestData` | `getCustomDataAsync(...)` | `MasterPlayerResponseModels.GetCustomDataOperationResponse` | `masterPlayer.getCustomData.selfEnable` | `masterPlayer.getCustomData.otherSelfEnable` |
| `getDisplayName` | `MasterPlayerModels.GetDisplayNameRequestData` | `getDisplayNameAsync(...)` | `MasterPlayerResponseModels.GetDisplayNameOperationResponse` | `masterPlayer.getDisplayName.selfEnable` | `masterPlayer.getDisplayName.otherSelfEnable` |
| `getEmail` | `MasterPlayerModels.GetEmailRequestData` | `getEmailAsync(...)` | `MasterPlayerResponseModels.GetEmailOperationResponse` | `masterPlayer.getEmail.selfEnable` | `masterPlayer.getEmail.otherSelfEnable` |
| `getExternal` | `MasterPlayerModels.GetExternalRequestData` | `getExternalAsync(...)` | `MasterPlayerResponseModels.GetExternalOperationResponse` | `masterPlayer.getExternal.selfEnable` | `masterPlayer.getExternal.otherSelfEnable` |
| `getIpAddressCreate` | `MasterPlayerModels.GetIpAddressCreateRequestData` | `getIpAddressCreateAsync(...)` | `MasterPlayerResponseModels.GetIpAddressCreateOperationResponse` | `masterPlayer.getIpAddressCreate.selfEnable` | `masterPlayer.getIpAddressCreate.otherSelfEnable` |
| `getPlayerBan` | `MasterPlayerModels.GetPlayerBanRequestData` | `getPlayerBanAsync(...)` | `MasterPlayerResponseModels.GetPlayerBanOperationResponse` | `masterPlayer.getPlayerBan.selfEnable` | `masterPlayer.getPlayerBan.otherSelfEnable` |
| `getPlayerCurrency` | `MasterPlayerModels.GetPlayerCurrencyRequestData` | `getPlayerCurrencyAsync(...)` | `MasterPlayerResponseModels.GetPlayerCurrencyOperationResponse` | `masterPlayer.getPlayerCurrency.selfEnable` | `masterPlayer.getPlayerCurrency.otherSelfEnable` |
| `getPlayerData` | `MasterPlayerModels.GetPlayerDataRequestData` | `getPlayerDataAsync(...)` | `MasterPlayerResponseModels.GetPlayerDataOperationResponse` | `masterPlayer.getPlayerData.selfEnable` | `masterPlayer.getPlayerData.otherSelfEnable` |
| `getPlayerInformation` | `MasterPlayerModels.GetPlayerInformationRequestData` | `getPlayerInformationAsync(...)` | `MasterPlayerResponseModels.GetPlayerInformationOperationResponse` | `masterPlayer.getPlayerInformation.selfEnable` | `masterPlayer.getPlayerInformation.otherSelfEnable` |
| `getPlayerStatistics` | `MasterPlayerModels.GetPlayerStatisticsRequestData` | `getPlayerStatisticsAsync(...)` | `MasterPlayerResponseModels.GetPlayerStatisticsOperationResponse` | `masterPlayer.getPlayerStatistics.selfEnable` | `masterPlayer.getPlayerStatistics.otherSelfEnable` |
| `getPlayersWithApple` | `MasterPlayerModels.GetPlayersWithAppleRequestData` | `getPlayersWithAppleAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithAppleOperationResponse` | `masterPlayer.getPlayersWithApple.otherSelfEnable` | |
| `getPlayersWithDisplayName` | `MasterPlayerModels.GetPlayersWithDisplayNameRequestData` | `getPlayersWithDisplayNameAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse` | `masterPlayer.getPlayersWithDisplayName.otherSelfEnable` | |
| `getPlayersWithFacebook` | `MasterPlayerModels.GetPlayersWithFacebookRequestData` | `getPlayersWithFacebookAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithFacebookOperationResponse` | `masterPlayer.getPlayersWithFacebook.otherSelfEnable` | |
| `getPlayersWithGenericService` | `MasterPlayerModels.GetPlayersWithGenericServiceRequestData` | `getPlayersWithGenericServiceAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithGenericServiceOperationResponse` | `masterPlayer.getPlayersWithGenericService.selfEnable` | `masterPlayer.getPlayersWithGenericService.otherSelfEnable` |
| `getPlayersWithGoogle` | `MasterPlayerModels.GetPlayersWithGoogleRequestData` | `getPlayersWithGoogleAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithGoogleOperationResponse` | `masterPlayer.getPlayersWithGoogle.otherSelfEnable` | |
| `getPlayersWithGooglePlayGameService` | `MasterPlayerModels.GetPlayersWithGooglePlayGameServiceRequestData` | `getPlayersWithGooglePlayGameServiceAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithGooglePlayGameServiceOperationResponse` | `masterPlayer.getPlayersWithGooglePlayGameService.otherSelfEnable` | |
| `getPlayersWithGameCenter` | `MasterPlayerModels.GetPlayersWithGameCenterRequestData` | `getPlayersWithGameCenterAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithGameCenterOperationResponse` | `masterPlayer.getPlayersWithGameCenter.otherSelfEnable` | |
| `getPlayersWithSegment` | `MasterPlayerModels.GetPlayersWithSegmentRequestData` | `getPlayersWithSegmentAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithSegmentOperationResponse` | `masterPlayer.getPlayersWithSegment.otherSelfEnable` | |
| `getPlayersWithTag` | `MasterPlayerModels.GetPlayersWithTagRequestData` | `getPlayersWithTagAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithTagOperationResponse` | `masterPlayer.getPlayersWithTag.otherSelfEnable` | |
| `getSegment` | `MasterPlayerModels.GetSegmentRequestData` | `getSegmentAsync(...)` | `MasterPlayerResponseModels.GetSegmentOperationResponse` | `masterPlayer.getSegment.selfEnable` | `masterPlayer.getSegment.otherSelfEnable` |
| `getStatisticsLeaderboardAroundPlayer` | `MasterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData` | `getStatisticsLeaderboardAroundPlayerAsync(...)` | `MasterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse` | `masterPlayer.getStatisticsLeaderboardAroundPlayer.selfEnable` | `masterPlayer.getStatisticsLeaderboardAroundPlayer.otherSelfEnable` |
| `getStatisticsLeaderboard` | `MasterPlayerModels.GetStatisticsLeaderboardRequestData` | `getStatisticsLeaderboardAsync(...)` | `MasterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse` | `masterPlayer.getStatisticsLeaderboard.otherSelfEnable` | |
| `getTag` | `MasterPlayerModels.GetTagRequestData` | `getTagAsync(...)` | `MasterPlayerResponseModels.GetTagOperationResponse` | `masterPlayer.getTag.selfEnable` | `masterPlayer.getTag.otherSelfEnable` |
| `getTsCreate` | `MasterPlayerModels.GetTsCreateRequestData` | `getTsCreateAsync(...)` | `MasterPlayerResponseModels.GetTsCreateOperationResponse` | `masterPlayer.getTsCreate.selfEnable` | `masterPlayer.getTsCreate.otherSelfEnable` |
| `getTsLastLogin` | `MasterPlayerModels.GetTsLastLoginRequestData` | `getTsLastLoginAsync(...)` | `MasterPlayerResponseModels.GetTsLastLoginOperationResponse` | `masterPlayer.getTsLastLogin.selfEnable` | `masterPlayer.getTsLastLogin.otherSelfEnable` |
| `linkAccount` | `MasterPlayerModels.LinkAccountRequestData` | `linkAccountAsync(...)` | `MasterPlayerResponseModels.LinkAccountOperationResponse` | `masterPlayer.linkAccount.selfEnable` | `masterPlayer.linkAccount.otherSelfEnable` |
| `linkAndroidDeviceId` | `MasterPlayerModels.LinkAndroidDeviceIdRequestData` | `linkAndroidDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkAndroidDeviceIdOperationResponse` | `masterPlayer.linkAndroidDeviceId.selfEnable` | `masterPlayer.linkAndroidDeviceId.otherSelfEnable` |
| `linkApple` | `MasterPlayerModels.LinkAppleRequestData` | `linkAppleAsync(...)` | `MasterPlayerResponseModels.LinkAppleOperationResponse` | `masterPlayer.linkApple.selfEnable` | `masterPlayer.linkApple.otherSelfEnable` |
| `linkCustomDeviceId` | `MasterPlayerModels.LinkCustomDeviceIdRequestData` | `linkCustomDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkCustomDeviceIdOperationResponse` | `masterPlayer.linkCustomDeviceId.selfEnable` | `masterPlayer.linkCustomDeviceId.otherSelfEnable` |
| `linkCustomId` | `MasterPlayerModels.LinkCustomIdRequestData` | `linkCustomIdAsync(...)` | `MasterPlayerResponseModels.LinkCustomIdOperationResponse` | `masterPlayer.linkCustomId.selfEnable` | `masterPlayer.linkCustomId.otherSelfEnable` |
| `linkEditorDeviceId` | `MasterPlayerModels.LinkEditorDeviceIdRequestData` | `linkEditorDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkEditorDeviceIdOperationResponse` | `masterPlayer.linkEditorDeviceId.selfEnable` | `masterPlayer.linkEditorDeviceId.otherSelfEnable` |
| `linkFacebook` | `MasterPlayerModels.LinkFacebookRequestData` | `linkFacebookAsync(...)` | `MasterPlayerResponseModels.LinkFacebookOperationResponse` | `masterPlayer.linkFacebook.selfEnable` | `masterPlayer.linkFacebook.otherSelfEnable` |
| `linkGenericService` | `MasterPlayerModels.LinkGenericServiceRequestData` | `linkGenericServiceAsync(...)` | `MasterPlayerResponseModels.LinkGenericServiceOperationResponse` | `masterPlayer.linkGenericService.selfEnable` | `masterPlayer.linkGenericService.otherSelfEnable` |
| `linkGoogle` | `MasterPlayerModels.LinkGoogleRequestData` | `linkGoogleAsync(...)` | `MasterPlayerResponseModels.LinkGoogleOperationResponse` | `masterPlayer.linkGoogle.selfEnable` | `masterPlayer.linkGoogle.otherSelfEnable` |
| `linkGooglePlayGameService` | `MasterPlayerModels.LinkGooglePlayGameServiceRequestData` | `linkGooglePlayGameServiceAsync(...)` | `MasterPlayerResponseModels.LinkGooglePlayGameServiceOperationResponse` | `masterPlayer.linkGooglePlayGameService.selfEnable` | `masterPlayer.linkGooglePlayGameService.otherSelfEnable` |
| `linkGameCenter` | `MasterPlayerModels.LinkGameCenterRequestData` | `linkGameCenterAsync(...)` | `MasterPlayerResponseModels.LinkGameCenterOperationResponse` | `masterPlayer.linkGameCenter.selfEnable` | `masterPlayer.linkGameCenter.otherSelfEnable` |
| `linkiOSDeviceId` | `MasterPlayerModels.LinkiOSDeviceIdRequestData` | `linkiOSDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkiOSDeviceIdOperationResponse` | `masterPlayer.linkiOSDeviceId.selfEnable` | `masterPlayer.linkiOSDeviceId.otherSelfEnable` |
| `linkLinuxDeviceId` | `MasterPlayerModels.LinkLinuxDeviceIdRequestData` | `linkLinuxDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkLinuxDeviceIdOperationResponse` | `masterPlayer.linkLinuxDeviceId.selfEnable` | `masterPlayer.linkLinuxDeviceId.otherSelfEnable` |
| `linkMacOSDeviceId` | `MasterPlayerModels.LinkMacOSDeviceIdRequestData` | `linkMacOSDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkMacOSDeviceIdOperationResponse` | `masterPlayer.linkMacOSDeviceId.selfEnable` | `masterPlayer.linkMacOSDeviceId.otherSelfEnable` |
| `linkWindowsDeviceId` | `MasterPlayerModels.LinkWindowsDeviceIdRequestData` | `linkWindowsDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkWindowsDeviceIdOperationResponse` | `masterPlayer.linkWindowsDeviceId.selfEnable` | `masterPlayer.linkWindowsDeviceId.otherSelfEnable` |
| `linkWindowsPhoneDeviceId` | `MasterPlayerModels.LinkWindowsPhoneDeviceIdRequestData` | `linkWindowsPhoneDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkWindowsPhoneDeviceIdOperationResponse` | `masterPlayer.linkWindowsPhoneDeviceId.selfEnable` | `masterPlayer.linkWindowsPhoneDeviceId.otherSelfEnable` |
| `removeSegment` | `MasterPlayerModels.RemoveSegmentRequestData` | `removeSegmentAsync(...)` | `MasterPlayerResponseModels.RemoveSegmentOperationResponse` | `masterPlayer.removeSegment.selfEnable` | `masterPlayer.removeSegment.otherSelfEnable` |
| `removeTag` | `MasterPlayerModels.RemoveTagRequestData` | `removeTagAsync(...)` | `MasterPlayerResponseModels.RemoveTagOperationResponse` | `masterPlayer.removeTag.selfEnable` | `masterPlayer.removeTag.otherSelfEnable` |
| `resetAccountPassword` | `MasterPlayerModels.ResetAccountPasswordRequestData` | `resetAccountPasswordAsync(...)` | `MasterPlayerResponseModels.ResetAccountPasswordOperationResponse` | `masterPlayer.resetAccountPassword.selfEnable` | `masterPlayer.resetAccountPassword.otherSelfEnable` |
| `setAvatar` | `MasterPlayerModels.SetAvatarRequestData` | `setAvatarAsync(...)` | `MasterPlayerResponseModels.SetAvatarOperationResponse` | `masterPlayer.setAvatar.selfEnable` | `masterPlayer.setAvatar.otherSelfEnable` |
| `setCountryCode` | `MasterPlayerModels.SetCountryCodeRequestData` | `setCountryCodeAsync(...)` | `MasterPlayerResponseModels.SetCountryCodeOperationResponse` | `masterPlayer.setCountryCode.selfEnable` | `masterPlayer.setCountryCode.otherSelfEnable` |
| `setCustomData` | `MasterPlayerModels.SetCustomDataRequestData` | `setCustomDataAsync(...)` | `MasterPlayerResponseModels.SetCustomDataOperationResponse` | `masterPlayer.setCustomData.selfEnable` | `masterPlayer.setCustomData.otherSelfEnable` |
| `setDisplayName` | `MasterPlayerModels.SetDisplayNameRequestData` | `setDisplayNameAsync(...)` | `MasterPlayerResponseModels.SetDisplayNameOperationResponse` | `masterPlayer.setDisplayName.selfEnable` | `masterPlayer.setDisplayName.otherSelfEnable` |
| `setEmail` | `MasterPlayerModels.SetEmailRequestData` | `setEmailAsync(...)` | `MasterPlayerResponseModels.SetEmailOperationResponse` | `masterPlayer.setEmail.selfEnable` | `masterPlayer.setEmail.otherSelfEnable` |
| `setPlayerBan` | `MasterPlayerModels.SetPlayerBanRequestData` | `setPlayerBanAsync(...)` | `MasterPlayerResponseModels.SetPlayerBanOperationResponse` | `masterPlayer.setPlayerBan.selfEnable` | `masterPlayer.setPlayerBan.otherSelfEnable` |
| `changePlayerCurrency` | `MasterPlayerModels.ChangePlayerCurrencyRequestData` | `changePlayerCurrencyAsync(...)` | `MasterPlayerResponseModels.ChangePlayerCurrencyOperationResponse` | `masterPlayer.changePlayerCurrency.selfEnable` | `masterPlayer.changePlayerCurrency.otherSelfEnable` |
| `setPlayerData` | `MasterPlayerModels.SetPlayerDataRequestData` | `setPlayerDataAsync(...)` | `MasterPlayerResponseModels.SetPlayerDataOperationResponse` | `masterPlayer.setPlayerData.selfEnable` | `masterPlayer.setPlayerData.otherSelfEnable` |
| `changePlayerStatistics` | `MasterPlayerModels.ChangePlayerStatisticsRequestData` | `changePlayerStatisticsAsync(...)` | `MasterPlayerResponseModels.ChangePlayerStatisticsOperationResponse` | `masterPlayer.changePlayerStatistics.selfEnable` | `masterPlayer.changePlayerStatistics.otherSelfEnable` |
| `setTag` | `MasterPlayerModels.SetTagRequestData` | `setTagAsync(...)` | `MasterPlayerResponseModels.SetTagOperationResponse` | `masterPlayer.setTag.selfEnable` | `masterPlayer.setTag.otherSelfEnable` |
| `updateTsLastLogin` | `MasterPlayerModels.UpdateTsLastLoginRequestData` | `updateTsLastLoginAsync(...)` | `MasterPlayerResponseModels.UpdateTsLastLoginOperationResponse` | `masterPlayer.updateTsLastLogin.selfEnable` | `masterPlayer.updateTsLastLogin.otherSelfEnable` |
| `unlinkAccount` | `MasterPlayerModels.UnlinkAccountRequestData` | `unlinkAccountAsync(...)` | `MasterPlayerResponseModels.UnlinkAccountOperationResponse` | `masterPlayer.unlinkAccount.selfEnable` | `masterPlayer.unlinkAccount.otherSelfEnable` |
| `unlinkAndroidDeviceId` | `MasterPlayerModels.UnlinkAndroidDeviceIdRequestData` | `unlinkAndroidDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkAndroidDeviceIdOperationResponse` | `masterPlayer.unlinkAndroidDeviceId.selfEnable` | `masterPlayer.unlinkAndroidDeviceId.otherSelfEnable` |
| `unlinkApple` | `MasterPlayerModels.UnlinkAppleRequestData` | `unlinkAppleAsync(...)` | `MasterPlayerResponseModels.UnlinkAppleOperationResponse` | `masterPlayer.unlinkApple.selfEnable` | `masterPlayer.unlinkApple.otherSelfEnable` |
| `unlinkCustomDeviceId` | `MasterPlayerModels.UnlinkCustomDeviceIdRequestData` | `unlinkCustomDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkCustomDeviceIdOperationResponse` | `masterPlayer.unlinkCustomDeviceId.selfEnable` | `masterPlayer.unlinkCustomDeviceId.otherSelfEnable` |
| `unlinkCustomId` | `MasterPlayerModels.UnlinkCustomIdRequestData` | `unlinkCustomIdAsync(...)` | `MasterPlayerResponseModels.UnlinkCustomIdOperationResponse` | `masterPlayer.unlinkCustomId.selfEnable` | `masterPlayer.unlinkCustomId.otherSelfEnable` |
| `unlinkEditorDeviceId` | `MasterPlayerModels.UnlinkEditorDeviceIdRequestData` | `unlinkEditorDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkEditorDeviceIdOperationResponse` | `masterPlayer.unlinkEditorDeviceId.selfEnable` | `masterPlayer.unlinkEditorDeviceId.otherSelfEnable` |
| `unlinkFacebook` | `MasterPlayerModels.UnlinkFacebookRequestData` | `unlinkFacebookAsync(...)` | `MasterPlayerResponseModels.UnlinkFacebookOperationResponse` | `masterPlayer.unlinkFacebook.selfEnable` | `masterPlayer.unlinkFacebook.otherSelfEnable` |
| `unlinkGenericService` | `MasterPlayerModels.UnlinkGenericServiceRequestData` | `unlinkGenericServiceAsync(...)` | `MasterPlayerResponseModels.UnlinkGenericServiceOperationResponse` | `masterPlayer.unlinkGenericService.selfEnable` | `masterPlayer.unlinkGenericService.otherSelfEnable` |
| `unlinkGoogle` | `MasterPlayerModels.UnlinkGoogleRequestData` | `unlinkGoogleAsync(...)` | `MasterPlayerResponseModels.UnlinkGoogleOperationResponse` | `masterPlayer.unlinkGoogle.selfEnable` | `masterPlayer.unlinkGoogle.otherSelfEnable` |
| `unlinkGooglePlayGameService` | `MasterPlayerModels.UnlinkGooglePlayGameServiceRequestData` | `unlinkGooglePlayGameServiceAsync(...)` | `MasterPlayerResponseModels.UnlinkGooglePlayGameServiceOperationResponse` | `masterPlayer.unlinkGooglePlayGameService.selfEnable` | `masterPlayer.unlinkGooglePlayGameService.otherSelfEnable` |
| `unlinkGameCenter` | `MasterPlayerModels.UnlinkGameCenterRequestData` | `unlinkGameCenterAsync(...)` | `MasterPlayerResponseModels.UnlinkGameCenterOperationResponse` | `masterPlayer.unlinkGameCenter.selfEnable` | `masterPlayer.unlinkGameCenter.otherSelfEnable` |
| `unlinkiOSDeviceId` | `MasterPlayerModels.UnlinkiOSDeviceIdRequestData` | `unlinkiOSDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkiOSDeviceIdOperationResponse` | `masterPlayer.unlinkiOSDeviceId.selfEnable` | `masterPlayer.unlinkiOSDeviceId.otherSelfEnable` |
| `unlinkLinuxDeviceId` | `MasterPlayerModels.UnlinkLinuxDeviceIdRequestData` | `unlinkLinuxDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkLinuxDeviceIdOperationResponse` | `masterPlayer.unlinkLinuxDeviceId.selfEnable` | `masterPlayer.unlinkLinuxDeviceId.otherSelfEnable` |
| `unlinkMacOSDeviceId` | `MasterPlayerModels.UnlinkMacOSDeviceIdRequestData` | `unlinkMacOSDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkMacOSDeviceIdOperationResponse` | `masterPlayer.unlinkMacOSDeviceId.selfEnable` | `masterPlayer.unlinkMacOSDeviceId.otherSelfEnable` |
| `unlinkWindowsDeviceId` | `MasterPlayerModels.UnlinkWindowsDeviceIdRequestData` | `unlinkWindowsDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkWindowsDeviceIdOperationResponse` | `masterPlayer.unlinkWindowsDeviceId.selfEnable` | `masterPlayer.unlinkWindowsDeviceId.otherSelfEnable` |
| `unlinkWindowsPhoneDeviceId` | `MasterPlayerModels.UnlinkWindowsPhoneDeviceIdRequestData` | `unlinkWindowsPhoneDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkWindowsPhoneDeviceIdOperationResponse` | `masterPlayer.unlinkWindowsPhoneDeviceId.selfEnable` | `masterPlayer.unlinkWindowsPhoneDeviceId.otherSelfEnable` |
| `getCurrencyLeaderboard` | `MasterPlayerModels.GetCurrencyLeaderboardRequestData` | `getCurrencyLeaderboardAsync(...)` | `MasterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse` | `masterPlayer.getCurrencyLeaderboard.otherSelfEnable` | |
| `getCreateLeaderboard` | `MasterPlayerModels.GetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `MasterPlayerResponseModels.GetCreateLeaderboardOperationResponse` | `masterPlayer.getCreateLeaderboard.selfEnable` | `masterPlayer.getCreateLeaderboard.otherSelfEnable` |
| `getLastLoginLeaderboard` | `MasterPlayerModels.GetLastLoginLeaderboardRequestData` | `getLastLoginLeaderboardAsync(...)` | `MasterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse` | `masterPlayer.getLastLoginLeaderboard.otherSelfEnable` | |
| `getStatisticsLog` | `MasterPlayerModels.GetStatisticsLogRequestData` | `getStatisticsLogAsync(...)` | `MasterPlayerResponseModels.GetStatisticsLogOperationResponse` | `masterPlayer.getStatisticsLog.selfEnable` | `masterPlayer.getStatisticsLog.otherSelfEnable` |
| `getCurrencyLog` | `MasterPlayerModels.GetCurrencyLogRequestData` | `getCurrencyLogAsync(...)` | `MasterPlayerResponseModels.GetCurrencyLogOperationResponse` | `masterPlayer.getCurrencyLog.selfEnable` | `masterPlayer.getCurrencyLog.otherSelfEnable` |
| `sendSocketOperationEvent` | `MasterPlayerModels.SendSocketOperationEventRequestData` | `sendSocketOperationEventAsync(...)` | `MasterPlayerResponseModels.SendSocketOperationEventOperationResponse` | `masterPlayer.sendSocketOperationEvent.selfEnable` | `masterPlayer.sendSocketOperationEvent.otherSelfEnable` |
| `sendEmail` | `MasterPlayerModels.SendEmailRequestData` | `sendEmailAsync(...)` | `MasterPlayerResponseModels.SendEmailOperationResponse` | `masterPlayer.sendEmail.selfEnable` | `masterPlayer.sendEmail.otherSelfEnable` |
| `addPushNotification` | `MasterPlayerModels.AddPushNotificationRequestData` | `addPushNotificationAsync(...)` | `MasterPlayerResponseModels.AddPushNotificationOperationResponse` | `masterPlayer.addPushNotification.selfEnable` | `masterPlayer.addPushNotification.otherSelfEnable` |
| `removePushNotification` | `MasterPlayerModels.RemovePushNotificationRequestData` | `removePushNotificationAsync(...)` | `MasterPlayerResponseModels.RemovePushNotificationOperationResponse` | `masterPlayer.removePushNotification.selfEnable` | `masterPlayer.removePushNotification.otherSelfEnable` |
| `getPushNotification` | `MasterPlayerModels.GetPushNotificationRequestData` | `getPushNotificationAsync(...)` | `MasterPlayerResponseModels.GetPushNotificationOperationResponse` | `masterPlayer.getPushNotification.selfEnable` | `masterPlayer.getPushNotification.otherSelfEnable` |
| `sendPushNotification` | `MasterPlayerModels.SendPushNotificationRequestData` | `sendPushNotificationAsync(...)` | `MasterPlayerResponseModels.SendPushNotificationOperationResponse` | `masterPlayer.sendPushNotification.selfEnable` | `masterPlayer.sendPushNotification.otherSelfEnable` |
| `getOnlineStatus` | `MasterPlayerModels.GetOnlineStatusRequestData` | `getOnlineStatusAsync(...)` | `MasterPlayerResponseModels.GetOnlineStatusOperationResponse` | `masterPlayer.getOnlineStatus.selfEnable` | `masterPlayer.getOnlineStatus.otherSelfEnable` |

## Server methods (`GNNetwork.masterPlayer.server.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules |
| --- | --- | --- | --- | --- |
| `addSegment` | `MasterPlayerModels.ServerAddSegmentRequestData` | `addSegmentAsync(...)` | `MasterPlayerResponseModels.AddSegmentOperationResponse` | `masterPlayer.addSegment.serverSelfEnable` |
| `getAvatar` | `MasterPlayerModels.ServerGetAvatarRequestData` | `getAvatarAsync(...)` | `MasterPlayerResponseModels.GetAvatarOperationResponse` | `masterPlayer.getAvatar.serverSelfEnable` |
| `getCountryCode` | `MasterPlayerModels.ServerGetCountryCodeRequestData` | `getCountryCodeAsync(...)` | `MasterPlayerResponseModels.GetCountryCodeOperationResponse` | `masterPlayer.getCountryCode.serverSelfEnable` |
| `getCustomData` | `MasterPlayerModels.ServerGetCustomDataRequestData` | `getCustomDataAsync(...)` | `MasterPlayerResponseModels.GetCustomDataOperationResponse` | `masterPlayer.getCustomData.serverSelfEnable` |
| `getDisplayName` | `MasterPlayerModels.ServerGetDisplayNameRequestData` | `getDisplayNameAsync(...)` | `MasterPlayerResponseModels.GetDisplayNameOperationResponse` | `masterPlayer.getDisplayName.serverSelfEnable` |
| `getEmail` | `MasterPlayerModels.ServerGetEmailRequestData` | `getEmailAsync(...)` | `MasterPlayerResponseModels.GetEmailOperationResponse` | `masterPlayer.getEmail.serverSelfEnable` |
| `getExternal` | `MasterPlayerModels.ServerGetExternalRequestData` | `getExternalAsync(...)` | `MasterPlayerResponseModels.GetExternalOperationResponse` | `masterPlayer.getExternal.serverSelfEnable` |
| `getIpAddressCreate` | `MasterPlayerModels.ServerGetIpAddressCreateRequestData` | `getIpAddressCreateAsync(...)` | `MasterPlayerResponseModels.GetIpAddressCreateOperationResponse` | `masterPlayer.getIpAddressCreate.serverSelfEnable` |
| `getPlayerBan` | `MasterPlayerModels.ServerGetPlayerBanRequestData` | `getPlayerBanAsync(...)` | `MasterPlayerResponseModels.GetPlayerBanOperationResponse` | `masterPlayer.getPlayerBan.serverSelfEnable` |
| `getPlayerCurrency` | `MasterPlayerModels.ServerGetPlayerCurrencyRequestData` | `getPlayerCurrencyAsync(...)` | `MasterPlayerResponseModels.GetPlayerCurrencyOperationResponse` | `masterPlayer.getPlayerCurrency.serverSelfEnable` |
| `getPlayerData` | `MasterPlayerModels.ServerGetPlayerDataRequestData` | `getPlayerDataAsync(...)` | `MasterPlayerResponseModels.GetPlayerDataOperationResponse` | `masterPlayer.getPlayerData.serverSelfEnable` |
| `getPlayerInformation` | `MasterPlayerModels.ServerGetPlayerInformationRequestData` | `getPlayerInformationAsync(...)` | `MasterPlayerResponseModels.GetPlayerInformationOperationResponse` | `masterPlayer.getPlayerInformation.serverSelfEnable` |
| `getPlayerStatistics` | `MasterPlayerModels.ServerGetPlayerStatisticsRequestData` | `getPlayerStatisticsAsync(...)` | `MasterPlayerResponseModels.GetPlayerStatisticsOperationResponse` | `masterPlayer.getPlayerStatistics.serverSelfEnable` |
| `getPlayersWithApple` | `MasterPlayerModels.ServerGetPlayersWithAppleRequestData` | `getPlayersWithAppleAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithAppleOperationResponse` | `masterPlayer.getPlayersWithApple.serverSelfEnable` |
| `getPlayersWithDisplayName` | `MasterPlayerModels.ServerGetPlayersWithDisplayNameRequestData` | `getPlayersWithDisplayNameAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse` | `masterPlayer.getPlayersWithDisplayName.serverSelfEnable` |
| `getPlayersWithFacebook` | `MasterPlayerModels.ServerGetPlayersWithFacebookRequestData` | `getPlayersWithFacebookAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithFacebookOperationResponse` | `masterPlayer.getPlayersWithFacebook.serverSelfEnable` |
| `getPlayersWithGenericService` | `MasterPlayerModels.ServerGetPlayersWithGenericServiceRequestData` | `getPlayersWithGenericServiceAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithGenericServiceOperationResponse` | `masterPlayer.getPlayersWithGenericService.serverSelfEnable` |
| `getPlayersWithGoogle` | `MasterPlayerModels.ServerGetPlayersWithGoogleRequestData` | `getPlayersWithGoogleAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithGoogleOperationResponse` | `masterPlayer.getPlayersWithGoogle.serverSelfEnable` |
| `getPlayersWithGooglePlayGameService` | `MasterPlayerModels.ServerGetPlayersWithGooglePlayGameServiceRequestData` | `getPlayersWithGooglePlayGameServiceAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithGooglePlayGameServiceOperationResponse` | `masterPlayer.getPlayersWithGooglePlayGameService.serverSelfEnable` |
| `getPlayersWithGameCenter` | `MasterPlayerModels.ServerGetPlayersWithGameCenterRequestData` | `getPlayersWithGameCenterAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithGameCenterOperationResponse` | `masterPlayer.getPlayersWithGameCenter.serverSelfEnable` |
| `getPlayersWithSegment` | `MasterPlayerModels.ServerGetPlayersWithSegmentRequestData` | `getPlayersWithSegmentAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithSegmentOperationResponse` | `masterPlayer.getPlayersWithSegment.serverSelfEnable` |
| `getPlayersWithTag` | `MasterPlayerModels.ServerGetPlayersWithTagRequestData` | `getPlayersWithTagAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithTagOperationResponse` | `masterPlayer.getPlayersWithTag.serverSelfEnable` |
| `getSegment` | `MasterPlayerModels.ServerGetSegmentRequestData` | `getSegmentAsync(...)` | `MasterPlayerResponseModels.GetSegmentOperationResponse` | `masterPlayer.getSegment.serverSelfEnable` |
| `getStatisticsLeaderboardAroundPlayer` | `MasterPlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData` | `getStatisticsLeaderboardAroundPlayerAsync(...)` | `MasterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse` | `masterPlayer.getStatisticsLeaderboardAroundPlayer.serverSelfEnable` |
| `getStatisticsLeaderboard` | `MasterPlayerModels.ServerGetStatisticsLeaderboardRequestData` | `getStatisticsLeaderboardAsync(...)` | `MasterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse` | `masterPlayer.getStatisticsLeaderboard.serverSelfEnable` |
| `getTag` | `MasterPlayerModels.ServerGetTagRequestData` | `getTagAsync(...)` | `MasterPlayerResponseModels.GetTagOperationResponse` | `masterPlayer.getTag.serverSelfEnable` |
| `getTsCreate` | `MasterPlayerModels.ServerGetTsCreateRequestData` | `getTsCreateAsync(...)` | `MasterPlayerResponseModels.GetTsCreateOperationResponse` | `masterPlayer.getTsCreate.serverSelfEnable` |
| `getTsLastLogin` | `MasterPlayerModels.ServerGetTsLastLoginRequestData` | `getTsLastLoginAsync(...)` | `MasterPlayerResponseModels.GetTsLastLoginOperationResponse` | `masterPlayer.getTsLastLogin.serverSelfEnable` |
| `linkAccount` | `MasterPlayerModels.ServerLinkAccountRequestData` | `linkAccountAsync(...)` | `MasterPlayerResponseModels.LinkAccountOperationResponse` | `masterPlayer.linkAccount.serverSelfEnable` |
| `linkAndroidDeviceId` | `MasterPlayerModels.ServerLinkAndroidDeviceIdRequestData` | `linkAndroidDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkAndroidDeviceIdOperationResponse` | `masterPlayer.linkAndroidDeviceId.serverSelfEnable` |
| `linkApple` | `MasterPlayerModels.ServerLinkAppleRequestData` | `linkAppleAsync(...)` | `MasterPlayerResponseModels.LinkAppleOperationResponse` | `masterPlayer.linkApple.serverSelfEnable` |
| `linkCustomDeviceId` | `MasterPlayerModels.ServerLinkCustomDeviceIdRequestData` | `linkCustomDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkCustomDeviceIdOperationResponse` | `masterPlayer.linkCustomDeviceId.serverSelfEnable` |
| `linkCustomId` | `MasterPlayerModels.ServerLinkCustomIdRequestData` | `linkCustomIdAsync(...)` | `MasterPlayerResponseModels.LinkCustomIdOperationResponse` | `masterPlayer.linkCustomId.serverSelfEnable` |
| `linkEditorDeviceId` | `MasterPlayerModels.ServerLinkEditorDeviceIdRequestData` | `linkEditorDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkEditorDeviceIdOperationResponse` | `masterPlayer.linkEditorDeviceId.serverSelfEnable` |
| `linkFacebook` | `MasterPlayerModels.ServerLinkFacebookRequestData` | `linkFacebookAsync(...)` | `MasterPlayerResponseModels.LinkFacebookOperationResponse` | `masterPlayer.linkFacebook.serverSelfEnable` |
| `linkGenericService` | `MasterPlayerModels.ServerLinkGenericServiceRequestData` | `linkGenericServiceAsync(...)` | `MasterPlayerResponseModels.LinkGenericServiceOperationResponse` | `masterPlayer.linkGenericService.serverSelfEnable` |
| `linkGoogle` | `MasterPlayerModels.ServerLinkGoogleRequestData` | `linkGoogleAsync(...)` | `MasterPlayerResponseModels.LinkGoogleOperationResponse` | `masterPlayer.linkGoogle.serverSelfEnable` |
| `linkGooglePlayGameService` | `MasterPlayerModels.ServerLinkGooglePlayGameServiceRequestData` | `linkGooglePlayGameServiceAsync(...)` | `MasterPlayerResponseModels.LinkGooglePlayGameServiceOperationResponse` | `masterPlayer.linkGooglePlayGameService.serverSelfEnable` |
| `linkGameCenter` | `MasterPlayerModels.ServerLinkGameCenterRequestData` | `linkGameCenterAsync(...)` | `MasterPlayerResponseModels.LinkGameCenterOperationResponse` | `masterPlayer.linkGameCenter.serverSelfEnable` |
| `linkiOSDeviceId` | `MasterPlayerModels.ServerLinkiOSDeviceIdRequestData` | `linkiOSDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkiOSDeviceIdOperationResponse` | `masterPlayer.linkiOSDeviceId.serverSelfEnable` |
| `linkLinuxDeviceId` | `MasterPlayerModels.ServerLinkLinuxDeviceIdRequestData` | `linkLinuxDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkLinuxDeviceIdOperationResponse` | `masterPlayer.linkLinuxDeviceId.serverSelfEnable` |
| `linkMacOSDeviceId` | `MasterPlayerModels.ServerLinkMacOSDeviceIdRequestData` | `linkMacOSDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkMacOSDeviceIdOperationResponse` | `masterPlayer.linkMacOSDeviceId.serverSelfEnable` |
| `linkWindowsDeviceId` | `MasterPlayerModels.ServerLinkWindowsDeviceIdRequestData` | `linkWindowsDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkWindowsDeviceIdOperationResponse` | `masterPlayer.linkWindowsDeviceId.serverSelfEnable` |
| `linkWindowsPhoneDeviceId` | `MasterPlayerModels.ServerLinkWindowsPhoneDeviceIdRequestData` | `linkWindowsPhoneDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkWindowsPhoneDeviceIdOperationResponse` | `masterPlayer.linkWindowsPhoneDeviceId.serverSelfEnable` |
| `removeSegment` | `MasterPlayerModels.ServerRemoveSegmentRequestData` | `removeSegmentAsync(...)` | `MasterPlayerResponseModels.RemoveSegmentOperationResponse` | `masterPlayer.removeSegment.serverSelfEnable` |
| `removeTag` | `MasterPlayerModels.ServerRemoveTagRequestData` | `removeTagAsync(...)` | `MasterPlayerResponseModels.RemoveTagOperationResponse` | `masterPlayer.removeTag.serverSelfEnable` |
| `resetAccountPassword` | `MasterPlayerModels.ServerResetAccountPasswordRequestData` | `resetAccountPasswordAsync(...)` | `MasterPlayerResponseModels.ResetAccountPasswordOperationResponse` | `masterPlayer.resetAccountPassword.serverSelfEnable` |
| `setAvatar` | `MasterPlayerModels.ServerSetAvatarRequestData` | `setAvatarAsync(...)` | `MasterPlayerResponseModels.SetAvatarOperationResponse` | `masterPlayer.setAvatar.serverSelfEnable` |
| `setCountryCode` | `MasterPlayerModels.ServerSetCountryCodeRequestData` | `setCountryCodeAsync(...)` | `MasterPlayerResponseModels.SetCountryCodeOperationResponse` | `masterPlayer.setCountryCode.serverSelfEnable` |
| `setCustomData` | `MasterPlayerModels.ServerSetCustomDataRequestData` | `setCustomDataAsync(...)` | `MasterPlayerResponseModels.SetCustomDataOperationResponse` | `masterPlayer.setCustomData.serverSelfEnable` |
| `setDisplayName` | `MasterPlayerModels.ServerSetDisplayNameRequestData` | `setDisplayNameAsync(...)` | `MasterPlayerResponseModels.SetDisplayNameOperationResponse` | `masterPlayer.setDisplayName.serverSelfEnable` |
| `setEmail` | `MasterPlayerModels.ServerSetEmailRequestData` | `setEmailAsync(...)` | `MasterPlayerResponseModels.SetEmailOperationResponse` | `masterPlayer.setEmail.serverSelfEnable` |
| `setPlayerBan` | `MasterPlayerModels.ServerSetPlayerBanRequestData` | `setPlayerBanAsync(...)` | `MasterPlayerResponseModels.SetPlayerBanOperationResponse` | `masterPlayer.setPlayerBan.serverSelfEnable` |
| `changePlayerCurrency` | `MasterPlayerModels.ServerChangePlayerCurrencyRequestData` | `changePlayerCurrencyAsync(...)` | `MasterPlayerResponseModels.ChangePlayerCurrencyOperationResponse` | `masterPlayer.changePlayerCurrency.serverSelfEnable` |
| `setPlayerData` | `MasterPlayerModels.ServerSetPlayerDataRequestData` | `setPlayerDataAsync(...)` | `MasterPlayerResponseModels.SetPlayerDataOperationResponse` | `masterPlayer.setPlayerData.serverSelfEnable` |
| `changePlayerStatistics` | `MasterPlayerModels.ServerChangePlayerStatisticsRequestData` | `changePlayerStatisticsAsync(...)` | `MasterPlayerResponseModels.ChangePlayerStatisticsOperationResponse` | `masterPlayer.changePlayerStatistics.serverSelfEnable` |
| `setTag` | `MasterPlayerModels.ServerSetTagRequestData` | `setTagAsync(...)` | `MasterPlayerResponseModels.SetTagOperationResponse` | `masterPlayer.setTag.serverSelfEnable` |
| `updateTsLastLogin` | `MasterPlayerModels.ServerUpdateTsLastLoginRequestData` | `updateTsLastLoginAsync(...)` | `MasterPlayerResponseModels.UpdateTsLastLoginOperationResponse` | `masterPlayer.updateTsLastLogin.serverSelfEnable` |
| `unlinkAccount` | `MasterPlayerModels.ServerUnlinkAccountRequestData` | `unlinkAccountAsync(...)` | `MasterPlayerResponseModels.UnlinkAccountOperationResponse` | `masterPlayer.unlinkAccount.serverSelfEnable` |
| `unlinkAndroidDeviceId` | `MasterPlayerModels.ServerUnlinkAndroidDeviceIdRequestData` | `unlinkAndroidDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkAndroidDeviceIdOperationResponse` | `masterPlayer.unlinkAndroidDeviceId.serverSelfEnable` |
| `unlinkApple` | `MasterPlayerModels.ServerUnlinkAppleRequestData` | `unlinkAppleAsync(...)` | `MasterPlayerResponseModels.UnlinkAppleOperationResponse` | `masterPlayer.unlinkApple.serverSelfEnable` |
| `unlinkCustomDeviceId` | `MasterPlayerModels.ServerUnlinkCustomDeviceIdRequestData` | `unlinkCustomDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkCustomDeviceIdOperationResponse` | `masterPlayer.unlinkCustomDeviceId.serverSelfEnable` |
| `unlinkCustomId` | `MasterPlayerModels.ServerUnlinkCustomIdRequestData` | `unlinkCustomIdAsync(...)` | `MasterPlayerResponseModels.UnlinkCustomIdOperationResponse` | `masterPlayer.unlinkCustomId.serverSelfEnable` |
| `unlinkEditorDeviceId` | `MasterPlayerModels.ServerUnlinkEditorDeviceIdRequestData` | `unlinkEditorDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkEditorDeviceIdOperationResponse` | `masterPlayer.unlinkEditorDeviceId.serverSelfEnable` |
| `unlinkFacebook` | `MasterPlayerModels.ServerUnlinkFacebookRequestData` | `unlinkFacebookAsync(...)` | `MasterPlayerResponseModels.UnlinkFacebookOperationResponse` | `masterPlayer.unlinkFacebook.serverSelfEnable` |
| `unlinkGenericService` | `MasterPlayerModels.ServerUnlinkGenericServiceRequestData` | `unlinkGenericServiceAsync(...)` | `MasterPlayerResponseModels.UnlinkGenericServiceOperationResponse` | `masterPlayer.unlinkGenericService.serverSelfEnable` |
| `unlinkGoogle` | `MasterPlayerModels.ServerUnlinkGoogleRequestData` | `unlinkGoogleAsync(...)` | `MasterPlayerResponseModels.UnlinkGoogleOperationResponse` | `masterPlayer.unlinkGoogle.serverSelfEnable` |
| `unlinkGooglePlayGameService` | `MasterPlayerModels.ServerUnlinkGooglePlayGameServiceRequestData` | `unlinkGooglePlayGameServiceAsync(...)` | `MasterPlayerResponseModels.UnlinkGooglePlayGameServiceOperationResponse` | `masterPlayer.unlinkGooglePlayGameService.serverSelfEnable` |
| `unlinkGameCenter` | `MasterPlayerModels.ServerUnlinkGameCenterRequestData` | `unlinkGameCenterAsync(...)` | `MasterPlayerResponseModels.UnlinkGameCenterOperationResponse` | `masterPlayer.unlinkGameCenter.serverSelfEnable` |
| `unlinkiOSDeviceId` | `MasterPlayerModels.ServerUnlinkiOSDeviceIdRequestData` | `unlinkiOSDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkiOSDeviceIdOperationResponse` | `masterPlayer.unlinkiOSDeviceId.serverSelfEnable` |
| `unlinkLinuxDeviceId` | `MasterPlayerModels.ServerUnlinkLinuxDeviceIdRequestData` | `unlinkLinuxDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkLinuxDeviceIdOperationResponse` | `masterPlayer.unlinkLinuxDeviceId.serverSelfEnable` |
| `unlinkMacOSDeviceId` | `MasterPlayerModels.ServerUnlinkMacOSDeviceIdRequestData` | `unlinkMacOSDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkMacOSDeviceIdOperationResponse` | `masterPlayer.unlinkMacOSDeviceId.serverSelfEnable` |
| `unlinkWindowsDeviceId` | `MasterPlayerModels.ServerUnlinkWindowsDeviceIdRequestData` | `unlinkWindowsDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkWindowsDeviceIdOperationResponse` | `masterPlayer.unlinkWindowsDeviceId.serverSelfEnable` |
| `unlinkWindowsPhoneDeviceId` | `MasterPlayerModels.ServerUnlinkWindowsPhoneDeviceIdRequestData` | `unlinkWindowsPhoneDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkWindowsPhoneDeviceIdOperationResponse` | `masterPlayer.unlinkWindowsPhoneDeviceId.serverSelfEnable` |
| `getCurrencyLeaderboard` | `MasterPlayerModels.ServerGetCurrencyLeaderboardRequestData` | `getCurrencyLeaderboardAsync(...)` | `MasterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse` | `masterPlayer.getCurrencyLeaderboard.serverSelfEnable` |
| `getCreateLeaderboard` | `MasterPlayerModels.ServerGetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `MasterPlayerResponseModels.GetCreateLeaderboardOperationResponse` | `masterPlayer.getCreateLeaderboard.serverSelfEnable` |
| `getLastLoginLeaderboard` | `MasterPlayerModels.ServerGetLastLoginLeaderboardRequestData` | `getLastLoginLeaderboardAsync(...)` | `MasterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse` | `masterPlayer.getLastLoginLeaderboard.serverSelfEnable` |
| `getStatisticsLog` | `MasterPlayerModels.ServerGetStatisticsLogRequestData` | `getStatisticsLogAsync(...)` | `MasterPlayerResponseModels.GetStatisticsLogOperationResponse` | `masterPlayer.getStatisticsLog.serverSelfEnable` |
| `getCurrencyLog` | `MasterPlayerModels.ServerGetCurrencyLogRequestData` | `getCurrencyLogAsync(...)` | `MasterPlayerResponseModels.GetCurrencyLogOperationResponse` | `masterPlayer.getCurrencyLog.serverSelfEnable` |
| `sendSocketOperationEvent` | `MasterPlayerModels.ServerSendSocketOperationEventRequestData` | `sendSocketOperationEventAsync(...)` | `MasterPlayerResponseModels.SendSocketOperationEventOperationResponse` | `masterPlayer.sendSocketOperationEvent.serverSelfEnable` |
| `sendEmail` | `MasterPlayerModels.ServerSendEmailRequestData` | `sendEmailAsync(...)` | `MasterPlayerResponseModels.SendEmailOperationResponse` | `masterPlayer.sendEmail.serverSelfEnable` |
| `addPushNotification` | `MasterPlayerModels.ServerAddPushNotificationRequestData` | `addPushNotificationAsync(...)` | `MasterPlayerResponseModels.AddPushNotificationOperationResponse` | `masterPlayer.addPushNotification.serverSelfEnable` |
| `removePushNotification` | `MasterPlayerModels.ServerRemovePushNotificationRequestData` | `removePushNotificationAsync(...)` | `MasterPlayerResponseModels.RemovePushNotificationOperationResponse` | `masterPlayer.removePushNotification.serverSelfEnable` |
| `getPushNotification` | `MasterPlayerModels.ServerGetPushNotificationRequestData` | `getPushNotificationAsync(...)` | `MasterPlayerResponseModels.GetPushNotificationOperationResponse` | `masterPlayer.getPushNotification.serverSelfEnable` |
| `sendPushNotification` | `MasterPlayerModels.ServerSendPushNotificationRequestData` | `sendPushNotificationAsync(...)` | `MasterPlayerResponseModels.SendPushNotificationOperationResponse` | `masterPlayer.sendPushNotification.serverSelfEnable` |
| `getOnlineStatus` | `MasterPlayerModels.ServerGetOnlineStatusRequestData` | `getOnlineStatusAsync(...)` | `MasterPlayerResponseModels.GetOnlineStatusOperationResponse` | `masterPlayer.getOnlineStatus.serverSelfEnable` |

## Admin methods (`GNNetwork.masterPlayer.admin.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules |
| --- | --- | --- | --- | --- |
| `addSegment` | `MasterPlayerModels.AdminAddSegmentRequestData` | `addSegmentAsync(...)` | `MasterPlayerResponseModels.AddSegmentOperationResponse` | `masterPlayer.addSegment.adminSelfEnable` |
| `getAvatar` | `MasterPlayerModels.AdminGetAvatarRequestData` | `getAvatarAsync(...)` | `MasterPlayerResponseModels.GetAvatarOperationResponse` | `masterPlayer.getAvatar.adminSelfEnable` |
| `getCountryCode` | `MasterPlayerModels.AdminGetCountryCodeRequestData` | `getCountryCodeAsync(...)` | `MasterPlayerResponseModels.GetCountryCodeOperationResponse` | `masterPlayer.getCountryCode.adminSelfEnable` |
| `getCustomData` | `MasterPlayerModels.AdminGetCustomDataRequestData` | `getCustomDataAsync(...)` | `MasterPlayerResponseModels.GetCustomDataOperationResponse` | `masterPlayer.getCustomData.adminSelfEnable` |
| `getDisplayName` | `MasterPlayerModels.AdminGetDisplayNameRequestData` | `getDisplayNameAsync(...)` | `MasterPlayerResponseModels.GetDisplayNameOperationResponse` | `masterPlayer.getDisplayName.adminSelfEnable` |
| `getEmail` | `MasterPlayerModels.AdminGetEmailRequestData` | `getEmailAsync(...)` | `MasterPlayerResponseModels.GetEmailOperationResponse` | `masterPlayer.getEmail.adminSelfEnable` |
| `getExternal` | `MasterPlayerModels.AdminGetExternalRequestData` | `getExternalAsync(...)` | `MasterPlayerResponseModels.GetExternalOperationResponse` | `masterPlayer.getExternal.adminSelfEnable` |
| `getIpAddressCreate` | `MasterPlayerModels.AdminGetIpAddressCreateRequestData` | `getIpAddressCreateAsync(...)` | `MasterPlayerResponseModels.GetIpAddressCreateOperationResponse` | `masterPlayer.getIpAddressCreate.adminSelfEnable` |
| `getPlayerBan` | `MasterPlayerModels.AdminGetPlayerBanRequestData` | `getPlayerBanAsync(...)` | `MasterPlayerResponseModels.GetPlayerBanOperationResponse` | `masterPlayer.getPlayerBan.adminSelfEnable` |
| `getPlayerCurrency` | `MasterPlayerModels.AdminGetPlayerCurrencyRequestData` | `getPlayerCurrencyAsync(...)` | `MasterPlayerResponseModels.GetPlayerCurrencyOperationResponse` | `masterPlayer.getPlayerCurrency.adminSelfEnable` |
| `getPlayerData` | `MasterPlayerModels.AdminGetPlayerDataRequestData` | `getPlayerDataAsync(...)` | `MasterPlayerResponseModels.GetPlayerDataOperationResponse` | `masterPlayer.getPlayerData.adminSelfEnable` |
| `getPlayerInformation` | `MasterPlayerModels.AdminGetPlayerInformationRequestData` | `getPlayerInformationAsync(...)` | `MasterPlayerResponseModels.GetPlayerInformationOperationResponse` | `masterPlayer.getPlayerInformation.adminSelfEnable` |
| `getPlayerStatistics` | `MasterPlayerModels.AdminGetPlayerStatisticsRequestData` | `getPlayerStatisticsAsync(...)` | `MasterPlayerResponseModels.GetPlayerStatisticsOperationResponse` | `masterPlayer.getPlayerStatistics.adminSelfEnable` |
| `getPlayersWithApple` | `MasterPlayerModels.AdminGetPlayersWithAppleRequestData` | `getPlayersWithAppleAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithAppleOperationResponse` | `masterPlayer.getPlayersWithApple.adminSelfEnable` |
| `getPlayersWithDisplayName` | `MasterPlayerModels.AdminGetPlayersWithDisplayNameRequestData` | `getPlayersWithDisplayNameAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse` | `masterPlayer.getPlayersWithDisplayName.adminSelfEnable` |
| `getPlayersWithFacebook` | `MasterPlayerModels.AdminGetPlayersWithFacebookRequestData` | `getPlayersWithFacebookAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithFacebookOperationResponse` | `masterPlayer.getPlayersWithFacebook.adminSelfEnable` |
| `getPlayersWithGenericService` | `MasterPlayerModels.AdminGetPlayersWithGenericServiceRequestData` | `getPlayersWithGenericServiceAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithGenericServiceOperationResponse` | `masterPlayer.getPlayersWithGenericService.adminSelfEnable` |
| `getPlayersWithGoogle` | `MasterPlayerModels.AdminGetPlayersWithGoogleRequestData` | `getPlayersWithGoogleAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithGoogleOperationResponse` | `masterPlayer.getPlayersWithGoogle.adminSelfEnable` |
| `getPlayersWithGooglePlayGameService` | `MasterPlayerModels.AdminGetPlayersWithGooglePlayGameServiceRequestData` | `getPlayersWithGooglePlayGameServiceAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithGooglePlayGameServiceOperationResponse` | `masterPlayer.getPlayersWithGooglePlayGameService.adminSelfEnable` |
| `getPlayersWithGameCenter` | `MasterPlayerModels.AdminGetPlayersWithGameCenterRequestData` | `getPlayersWithGameCenterAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithGameCenterOperationResponse` | `masterPlayer.getPlayersWithGameCenter.adminSelfEnable` |
| `getPlayersWithSegment` | `MasterPlayerModels.AdminGetPlayersWithSegmentRequestData` | `getPlayersWithSegmentAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithSegmentOperationResponse` | `masterPlayer.getPlayersWithSegment.adminSelfEnable` |
| `getPlayersWithTag` | `MasterPlayerModels.AdminGetPlayersWithTagRequestData` | `getPlayersWithTagAsync(...)` | `MasterPlayerResponseModels.GetPlayersWithTagOperationResponse` | `masterPlayer.getPlayersWithTag.adminSelfEnable` |
| `getSegment` | `MasterPlayerModels.AdminGetSegmentRequestData` | `getSegmentAsync(...)` | `MasterPlayerResponseModels.GetSegmentOperationResponse` | `masterPlayer.getSegment.adminSelfEnable` |
| `getStatisticsLeaderboardAroundPlayer` | `MasterPlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData` | `getStatisticsLeaderboardAroundPlayerAsync(...)` | `MasterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse` | `masterPlayer.getStatisticsLeaderboardAroundPlayer.adminSelfEnable` |
| `getStatisticsLeaderboard` | `MasterPlayerModels.AdminGetStatisticsLeaderboardRequestData` | `getStatisticsLeaderboardAsync(...)` | `MasterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse` | `masterPlayer.getStatisticsLeaderboard.adminSelfEnable` |
| `getTag` | `MasterPlayerModels.AdminGetTagRequestData` | `getTagAsync(...)` | `MasterPlayerResponseModels.GetTagOperationResponse` | `masterPlayer.getTag.adminSelfEnable` |
| `getTsCreate` | `MasterPlayerModels.AdminGetTsCreateRequestData` | `getTsCreateAsync(...)` | `MasterPlayerResponseModels.GetTsCreateOperationResponse` | `masterPlayer.getTsCreate.adminSelfEnable` |
| `getTsLastLogin` | `MasterPlayerModels.AdminGetTsLastLoginRequestData` | `getTsLastLoginAsync(...)` | `MasterPlayerResponseModels.GetTsLastLoginOperationResponse` | `masterPlayer.getTsLastLogin.adminSelfEnable` |
| `linkAccount` | `MasterPlayerModels.AdminLinkAccountRequestData` | `linkAccountAsync(...)` | `MasterPlayerResponseModels.LinkAccountOperationResponse` | `masterPlayer.linkAccount.adminSelfEnable` |
| `linkAndroidDeviceId` | `MasterPlayerModels.AdminLinkAndroidDeviceIdRequestData` | `linkAndroidDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkAndroidDeviceIdOperationResponse` | `masterPlayer.linkAndroidDeviceId.adminSelfEnable` |
| `linkApple` | `MasterPlayerModels.AdminLinkAppleRequestData` | `linkAppleAsync(...)` | `MasterPlayerResponseModels.LinkAppleOperationResponse` | `masterPlayer.linkApple.adminSelfEnable` |
| `linkCustomDeviceId` | `MasterPlayerModels.AdminLinkCustomDeviceIdRequestData` | `linkCustomDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkCustomDeviceIdOperationResponse` | `masterPlayer.linkCustomDeviceId.adminSelfEnable` |
| `linkCustomId` | `MasterPlayerModels.AdminLinkCustomIdRequestData` | `linkCustomIdAsync(...)` | `MasterPlayerResponseModels.LinkCustomIdOperationResponse` | `masterPlayer.linkCustomId.adminSelfEnable` |
| `linkEditorDeviceId` | `MasterPlayerModels.AdminLinkEditorDeviceIdRequestData` | `linkEditorDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkEditorDeviceIdOperationResponse` | `masterPlayer.linkEditorDeviceId.adminSelfEnable` |
| `linkFacebook` | `MasterPlayerModels.AdminLinkFacebookRequestData` | `linkFacebookAsync(...)` | `MasterPlayerResponseModels.LinkFacebookOperationResponse` | `masterPlayer.linkFacebook.adminSelfEnable` |
| `linkGenericService` | `MasterPlayerModels.AdminLinkGenericServiceRequestData` | `linkGenericServiceAsync(...)` | `MasterPlayerResponseModels.LinkGenericServiceOperationResponse` | `masterPlayer.linkGenericService.adminSelfEnable` |
| `linkGoogle` | `MasterPlayerModels.AdminLinkGoogleRequestData` | `linkGoogleAsync(...)` | `MasterPlayerResponseModels.LinkGoogleOperationResponse` | `masterPlayer.linkGoogle.adminSelfEnable` |
| `linkGooglePlayGameService` | `MasterPlayerModels.AdminLinkGooglePlayGameServiceRequestData` | `linkGooglePlayGameServiceAsync(...)` | `MasterPlayerResponseModels.LinkGooglePlayGameServiceOperationResponse` | `masterPlayer.linkGooglePlayGameService.adminSelfEnable` |
| `linkGameCenter` | `MasterPlayerModels.AdminLinkGameCenterRequestData` | `linkGameCenterAsync(...)` | `MasterPlayerResponseModels.LinkGameCenterOperationResponse` | `masterPlayer.linkGameCenter.adminSelfEnable` |
| `linkiOSDeviceId` | `MasterPlayerModels.AdminLinkiOSDeviceIdRequestData` | `linkiOSDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkiOSDeviceIdOperationResponse` | `masterPlayer.linkiOSDeviceId.adminSelfEnable` |
| `linkLinuxDeviceId` | `MasterPlayerModels.AdminLinkLinuxDeviceIdRequestData` | `linkLinuxDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkLinuxDeviceIdOperationResponse` | `masterPlayer.linkLinuxDeviceId.adminSelfEnable` |
| `linkMacOSDeviceId` | `MasterPlayerModels.AdminLinkMacOSDeviceIdRequestData` | `linkMacOSDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkMacOSDeviceIdOperationResponse` | `masterPlayer.linkMacOSDeviceId.adminSelfEnable` |
| `linkWindowsDeviceId` | `MasterPlayerModels.AdminLinkWindowsDeviceIdRequestData` | `linkWindowsDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkWindowsDeviceIdOperationResponse` | `masterPlayer.linkWindowsDeviceId.adminSelfEnable` |
| `linkWindowsPhoneDeviceId` | `MasterPlayerModels.AdminLinkWindowsPhoneDeviceIdRequestData` | `linkWindowsPhoneDeviceIdAsync(...)` | `MasterPlayerResponseModels.LinkWindowsPhoneDeviceIdOperationResponse` | `masterPlayer.linkWindowsPhoneDeviceId.adminSelfEnable` |
| `removeSegment` | `MasterPlayerModels.AdminRemoveSegmentRequestData` | `removeSegmentAsync(...)` | `MasterPlayerResponseModels.RemoveSegmentOperationResponse` | `masterPlayer.removeSegment.adminSelfEnable` |
| `removeTag` | `MasterPlayerModels.AdminRemoveTagRequestData` | `removeTagAsync(...)` | `MasterPlayerResponseModels.RemoveTagOperationResponse` | `masterPlayer.removeTag.adminSelfEnable` |
| `resetAccountPassword` | `MasterPlayerModels.AdminResetAccountPasswordRequestData` | `resetAccountPasswordAsync(...)` | `MasterPlayerResponseModels.ResetAccountPasswordOperationResponse` | `masterPlayer.resetAccountPassword.adminSelfEnable` |
| `setAvatar` | `MasterPlayerModels.AdminSetAvatarRequestData` | `setAvatarAsync(...)` | `MasterPlayerResponseModels.SetAvatarOperationResponse` | `masterPlayer.setAvatar.adminSelfEnable` |
| `setCountryCode` | `MasterPlayerModels.AdminSetCountryCodeRequestData` | `setCountryCodeAsync(...)` | `MasterPlayerResponseModels.SetCountryCodeOperationResponse` | `masterPlayer.setCountryCode.adminSelfEnable` |
| `setCustomData` | `MasterPlayerModels.AdminSetCustomDataRequestData` | `setCustomDataAsync(...)` | `MasterPlayerResponseModels.SetCustomDataOperationResponse` | `masterPlayer.setCustomData.adminSelfEnable` |
| `setDisplayName` | `MasterPlayerModels.AdminSetDisplayNameRequestData` | `setDisplayNameAsync(...)` | `MasterPlayerResponseModels.SetDisplayNameOperationResponse` | `masterPlayer.setDisplayName.adminSelfEnable` |
| `setEmail` | `MasterPlayerModels.AdminSetEmailRequestData` | `setEmailAsync(...)` | `MasterPlayerResponseModels.SetEmailOperationResponse` | `masterPlayer.setEmail.adminSelfEnable` |
| `setPlayerBan` | `MasterPlayerModels.AdminSetPlayerBanRequestData` | `setPlayerBanAsync(...)` | `MasterPlayerResponseModels.SetPlayerBanOperationResponse` | `masterPlayer.setPlayerBan.adminSelfEnable` |
| `changePlayerCurrency` | `MasterPlayerModels.AdminChangePlayerCurrencyRequestData` | `changePlayerCurrencyAsync(...)` | `MasterPlayerResponseModels.ChangePlayerCurrencyOperationResponse` | `masterPlayer.changePlayerCurrency.adminSelfEnable` |
| `setPlayerData` | `MasterPlayerModels.AdminSetPlayerDataRequestData` | `setPlayerDataAsync(...)` | `MasterPlayerResponseModels.SetPlayerDataOperationResponse` | `masterPlayer.setPlayerData.adminSelfEnable` |
| `changePlayerStatistics` | `MasterPlayerModels.AdminChangePlayerStatisticsRequestData` | `changePlayerStatisticsAsync(...)` | `MasterPlayerResponseModels.ChangePlayerStatisticsOperationResponse` | `masterPlayer.changePlayerStatistics.adminSelfEnable` |
| `setTag` | `MasterPlayerModels.AdminSetTagRequestData` | `setTagAsync(...)` | `MasterPlayerResponseModels.SetTagOperationResponse` | `masterPlayer.setTag.adminSelfEnable` |
| `updateTsLastLogin` | `MasterPlayerModels.AdminUpdateTsLastLoginRequestData` | `updateTsLastLoginAsync(...)` | `MasterPlayerResponseModels.UpdateTsLastLoginOperationResponse` | `masterPlayer.updateTsLastLogin.adminSelfEnable` |
| `unlinkAccount` | `MasterPlayerModels.AdminUnlinkAccountRequestData` | `unlinkAccountAsync(...)` | `MasterPlayerResponseModels.UnlinkAccountOperationResponse` | `masterPlayer.unlinkAccount.adminSelfEnable` |
| `unlinkAndroidDeviceId` | `MasterPlayerModels.AdminUnlinkAndroidDeviceIdRequestData` | `unlinkAndroidDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkAndroidDeviceIdOperationResponse` | `masterPlayer.unlinkAndroidDeviceId.adminSelfEnable` |
| `unlinkApple` | `MasterPlayerModels.AdminUnlinkAppleRequestData` | `unlinkAppleAsync(...)` | `MasterPlayerResponseModels.UnlinkAppleOperationResponse` | `masterPlayer.unlinkApple.adminSelfEnable` |
| `unlinkCustomDeviceId` | `MasterPlayerModels.AdminUnlinkCustomDeviceIdRequestData` | `unlinkCustomDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkCustomDeviceIdOperationResponse` | `masterPlayer.unlinkCustomDeviceId.adminSelfEnable` |
| `unlinkCustomId` | `MasterPlayerModels.AdminUnlinkCustomIdRequestData` | `unlinkCustomIdAsync(...)` | `MasterPlayerResponseModels.UnlinkCustomIdOperationResponse` | `masterPlayer.unlinkCustomId.adminSelfEnable` |
| `unlinkEditorDeviceId` | `MasterPlayerModels.AdminUnlinkEditorDeviceIdRequestData` | `unlinkEditorDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkEditorDeviceIdOperationResponse` | `masterPlayer.unlinkEditorDeviceId.adminSelfEnable` |
| `unlinkFacebook` | `MasterPlayerModels.AdminUnlinkFacebookRequestData` | `unlinkFacebookAsync(...)` | `MasterPlayerResponseModels.UnlinkFacebookOperationResponse` | `masterPlayer.unlinkFacebook.adminSelfEnable` |
| `unlinkGenericService` | `MasterPlayerModels.AdminUnlinkGenericServiceRequestData` | `unlinkGenericServiceAsync(...)` | `MasterPlayerResponseModels.UnlinkGenericServiceOperationResponse` | `masterPlayer.unlinkGenericService.adminSelfEnable` |
| `unlinkGoogle` | `MasterPlayerModels.AdminUnlinkGoogleRequestData` | `unlinkGoogleAsync(...)` | `MasterPlayerResponseModels.UnlinkGoogleOperationResponse` | `masterPlayer.unlinkGoogle.adminSelfEnable` |
| `unlinkGooglePlayGameService` | `MasterPlayerModels.AdminUnlinkGooglePlayGameServiceRequestData` | `unlinkGooglePlayGameServiceAsync(...)` | `MasterPlayerResponseModels.UnlinkGooglePlayGameServiceOperationResponse` | `masterPlayer.unlinkGooglePlayGameService.adminSelfEnable` |
| `unlinkGameCenter` | `MasterPlayerModels.AdminUnlinkGameCenterRequestData` | `unlinkGameCenterAsync(...)` | `MasterPlayerResponseModels.UnlinkGameCenterOperationResponse` | `masterPlayer.unlinkGameCenter.adminSelfEnable` |
| `unlinkiOSDeviceId` | `MasterPlayerModels.AdminUnlinkiOSDeviceIdRequestData` | `unlinkiOSDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkiOSDeviceIdOperationResponse` | `masterPlayer.unlinkiOSDeviceId.adminSelfEnable` |
| `unlinkLinuxDeviceId` | `MasterPlayerModels.AdminUnlinkLinuxDeviceIdRequestData` | `unlinkLinuxDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkLinuxDeviceIdOperationResponse` | `masterPlayer.unlinkLinuxDeviceId.adminSelfEnable` |
| `unlinkMacOSDeviceId` | `MasterPlayerModels.AdminUnlinkMacOSDeviceIdRequestData` | `unlinkMacOSDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkMacOSDeviceIdOperationResponse` | `masterPlayer.unlinkMacOSDeviceId.adminSelfEnable` |
| `unlinkWindowsDeviceId` | `MasterPlayerModels.AdminUnlinkWindowsDeviceIdRequestData` | `unlinkWindowsDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkWindowsDeviceIdOperationResponse` | `masterPlayer.unlinkWindowsDeviceId.adminSelfEnable` |
| `unlinkWindowsPhoneDeviceId` | `MasterPlayerModels.AdminUnlinkWindowsPhoneDeviceIdRequestData` | `unlinkWindowsPhoneDeviceIdAsync(...)` | `MasterPlayerResponseModels.UnlinkWindowsPhoneDeviceIdOperationResponse` | `masterPlayer.unlinkWindowsPhoneDeviceId.adminSelfEnable` |
| `getCurrencyLeaderboard` | `MasterPlayerModels.AdminGetCurrencyLeaderboardRequestData` | `getCurrencyLeaderboardAsync(...)` | `MasterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse` | `masterPlayer.getCurrencyLeaderboard.adminSelfEnable` |
| `getCreateLeaderboard` | `MasterPlayerModels.AdminGetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `MasterPlayerResponseModels.GetCreateLeaderboardOperationResponse` | `masterPlayer.getCreateLeaderboard.adminSelfEnable` |
| `getLastLoginLeaderboard` | `MasterPlayerModels.AdminGetLastLoginLeaderboardRequestData` | `getLastLoginLeaderboardAsync(...)` | `MasterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse` | `masterPlayer.getLastLoginLeaderboard.adminSelfEnable` |
| `getStatisticsLog` | `MasterPlayerModels.AdminGetStatisticsLogRequestData` | `getStatisticsLogAsync(...)` | `MasterPlayerResponseModels.GetStatisticsLogOperationResponse` | `masterPlayer.getStatisticsLog.adminSelfEnable` |
| `getCurrencyLog` | `MasterPlayerModels.AdminGetCurrencyLogRequestData` | `getCurrencyLogAsync(...)` | `MasterPlayerResponseModels.GetCurrencyLogOperationResponse` | `masterPlayer.getCurrencyLog.adminSelfEnable` |
| `sendSocketOperationEvent` | `MasterPlayerModels.AdminSendSocketOperationEventRequestData` | `sendSocketOperationEventAsync(...)` | `MasterPlayerResponseModels.SendSocketOperationEventOperationResponse` | `masterPlayer.sendSocketOperationEvent.adminSelfEnable` |
| `sendEmail` | `MasterPlayerModels.AdminSendEmailRequestData` | `sendEmailAsync(...)` | `MasterPlayerResponseModels.SendEmailOperationResponse` | `masterPlayer.sendEmail.adminSelfEnable` |
| `addPushNotification` | `MasterPlayerModels.AdminAddPushNotificationRequestData` | `addPushNotificationAsync(...)` | `MasterPlayerResponseModels.AddPushNotificationOperationResponse` | `masterPlayer.addPushNotification.adminSelfEnable` |
| `removePushNotification` | `MasterPlayerModels.AdminRemovePushNotificationRequestData` | `removePushNotificationAsync(...)` | `MasterPlayerResponseModels.RemovePushNotificationOperationResponse` | `masterPlayer.removePushNotification.adminSelfEnable` |
| `getPushNotification` | `MasterPlayerModels.AdminGetPushNotificationRequestData` | `getPushNotificationAsync(...)` | `MasterPlayerResponseModels.GetPushNotificationOperationResponse` | `masterPlayer.getPushNotification.adminSelfEnable` |
| `sendPushNotification` | `MasterPlayerModels.AdminSendPushNotificationRequestData` | `sendPushNotificationAsync(...)` | `MasterPlayerResponseModels.SendPushNotificationOperationResponse` | `masterPlayer.sendPushNotification.adminSelfEnable` |
| `getOnlineStatus` | `MasterPlayerModels.AdminGetOnlineStatusRequestData` | `getOnlineStatusAsync(...)` | `MasterPlayerResponseModels.GetOnlineStatusOperationResponse` | `masterPlayer.getOnlineStatus.adminSelfEnable` |

## Ví dụ tối thiểu

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

// requestData: MasterPlayerModels.AddSegmentRequestData đã build theo dto/MASTER_PLAYER.md
var res = await GNNetwork.masterPlayer.addSegmentAsync(requestData);
if (res.returnCode != ReturnCode.Ok) return;
if (res.errorCode != ErrorCode.Ok) return;
// res.responseData có typed payload
```
