# API Reference: DashboardApi

Admin login, game/admin account/secret management, analytics, server log, maintenance tools. Uses `RequestRole.Client` transport; admin context resolved from auth token.

- Domain guide: [guides/DASHBOARD.md](/docs/guides/DASHBOARD.md)
- DTO shapes: [dto/DASHBOARD.md](/docs/reference/dto/DASHBOARD.md)
- Enums: [ENUMS.md](/docs/reference/ENUMS.md)
- Error handling: [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md)
- Permission rules: [PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md)

## Namespaces

- `GNNetwork.dashboard` — `RequestRole.Client`

## Convention

Mỗi method dưới đây có 2 form — callback và `*Async()` Task. Ưu tiên `*Async()`.

```text
// Callback
GNNetwork.dashboard.<method>(requestData, onResponse?, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);

// Async
var res = await GNNetwork.dashboard.<method>Async(requestData, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);
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

> `server` / `admin` namespace hiện tại không có method public — giữ để đối xứng API.

## Client methods (`GNNetwork.dashboard.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules |
| --- | --- | --- | --- | --- |
| `changePasswordAdminAccount` | `DashboardModels.ChangePasswordAdminAccountRequestData` | `changePasswordAdminAccountAsync(...)` | `DashboardResponseModels.ChangePasswordAdminAccountOperationResponse` | `dashboard.changePasswordAdminAccount.selfEnable` |
| `getAdminAccountList` | `DashboardModels.GetAdminAccountListRequestData` | `getAdminAccountListAsync(...)` | `DashboardResponseModels.GetAdminAccountListOperationResponse` | `dashboard.getAdminAccountList.selfEnable` |
| `getGameInformation` | `DashboardModels.GetGameInformationRequestData` | `getGameInformationAsync(...)` | `DashboardResponseModels.GetGameInformationOperationResponse` | `dashboard.getGameInformation.selfEnable` |
| `getGameList` | `DashboardModels.GetGameListRequestData` | `getGameListAsync(...)` | `DashboardResponseModels.GetGameListOperationResponse` | `dashboard.getGameList.selfEnable` |
| `getMasterGameSettings` | `DashboardModels.GetMasterGameSettingsRequestData` | `getMasterGameSettingsAsync(...)` | `DashboardResponseModels.GetMasterGameSettingsOperationResponse` | `dashboard.getMasterGameSettings.selfEnable` |
| `getSecretInfoInformation` | `DashboardModels.GetSecretInfoInformationRequestData` | `getSecretInfoInformationAsync(...)` | `DashboardResponseModels.GetSecretInfoInformationOperationResponse` | `dashboard.getSecretInfoInformation.selfEnable` |
| `getSecretInfoList` | `DashboardModels.GetSecretInfoListRequestData` | `getSecretInfoListAsync(...)` | `DashboardResponseModels.GetSecretInfoListOperationResponse` | `dashboard.getSecretInfoList.selfEnable` |
| `getServerLog` | `DashboardModels.GetServerLogRequestData` | `getServerLogAsync(...)` | `DashboardResponseModels.GetServerLogOperationResponse` | `dashboard.getServerLog.selfEnable` |
| `createAdminAccount` | `DashboardModels.CreateAdminAccountRequestData` | `createAdminAccountAsync(...)` | `DashboardResponseModels.CreateAdminAccountOperationResponse` | `dashboard.createAdminAccount.selfEnable` |
| `createGame` | `DashboardModels.CreateGameRequestData` | `createGameAsync(...)` | `DashboardResponseModels.CreateGameOperationResponse` | `dashboard.createGame.selfEnable` |
| `createSecretInfo` | `DashboardModels.CreateSecretInfoRequestData` | `createSecretInfoAsync(...)` | `DashboardResponseModels.CreateSecretInfoOperationResponse` | `dashboard.createSecretInfo.selfEnable` |
| `loginByAdminAccount` | `DashboardModels.LoginByAdminAccountRequestData` | `loginByAdminAccountAsync(...)` | `DashboardResponseModels.LoginByAdminAccountOperationResponse` | `dashboard.loginByAdminAccount.selfEnable` |
| `removeAdminAccount` | `DashboardModels.RemoveAdminAccountRequestData` | `removeAdminAccountAsync(...)` | `DashboardResponseModels.RemoveAdminAccountOperationResponse` | `dashboard.removeAdminAccount.selfEnable` |
| `setGameInformation` | `DashboardModels.SetGameInformationRequestData` | `setGameInformationAsync(...)` | `DashboardResponseModels.SetGameInformationOperationResponse` | `dashboard.setGameInformation.selfEnable` |
| `setMasterGameSettings` | `DashboardModels.SetMasterGameSettingsRequestData` | `setMasterGameSettingsAsync(...)` | `DashboardResponseModels.SetMasterGameSettingsOperationResponse` | `dashboard.setMasterGameSettings.selfEnable` |
| `setPasswordAdminAccount` | `DashboardModels.SetPasswordAdminAccountRequestData` | `setPasswordAdminAccountAsync(...)` | `DashboardResponseModels.SetPasswordAdminAccountOperationResponse` | `dashboard.setPasswordAdminAccount.selfEnable` |
| `setSecretInfoInformation` | `DashboardModels.SetSecretInfoInformationRequestData` | `setSecretInfoInformationAsync(...)` | `DashboardResponseModels.SetSecretInfoInformationOperationResponse` | `dashboard.setSecretInfoInformation.selfEnable` |
| `setSecretKeyAdminAccount` | `DashboardModels.SetSecretKeyAdminAccountRequestData` | `setSecretKeyAdminAccountAsync(...)` | `DashboardResponseModels.SetSecretKeyAdminAccountOperationResponse` | `dashboard.setSecretKeyAdminAccount.selfEnable` |
| `getUsernameAdminAccount` | `DashboardModels.GetUsernameAdminAccountRequestData` | `getUsernameAdminAccountAsync(...)` | `DashboardResponseModels.GetUsernameAdminAccountOperationResponse` | `dashboard.getUsernameAdminAccount.selfEnable` |
| `getAnalytics` | `DashboardModels.GetAnalyticsRequestData` | `getAnalyticsAsync(...)` | `DashboardResponseModels.GetAnalyticsOperationResponse` | `dashboard.getAnalytics.selfEnable` |
| `getEventCallbackCloudScript` | `DashboardModels.GetEventCallbackCloudScriptRequestData` | `getEventCallbackCloudScriptAsync(...)` | `DashboardResponseModels.GetEventCallbackCloudScriptOperationResponse` | `dashboard.getEventCallbackCloudScript.selfEnable` |
| `setEventCallbackCloudScript` | `DashboardModels.SetEventCallbackCloudScriptRequestData` | `setEventCallbackCloudScriptAsync(...)` | `DashboardResponseModels.SetEventCallbackCloudScriptOperationResponse` | `dashboard.setEventCallbackCloudScript.selfEnable` |
| `resetStatisticsLeaderboard` | `DashboardModels.ResetStatisticsLeaderboardRequestData` | `resetStatisticsLeaderboardAsync(...)` | `DashboardResponseModels.ResetStatisticsLeaderboardOperationResponse` | `dashboard.resetStatisticsLeaderboard.selfEnable` |
| `getBackupStatisticsLeaderboardVersion` | `DashboardModels.GetBackupStatisticsLeaderboardVersionRequestData` | `getBackupStatisticsLeaderboardVersionAsync(...)` | `DashboardResponseModels.GetBackupStatisticsLeaderboardVersionOperationResponse` | `dashboard.getBackupStatisticsLeaderboardVersion.selfEnable` |
| `getServerGameData` | `DashboardModels.GetServerGameDataRequestData` | `getServerGameDataAsync(...)` | `DashboardResponseModels.GetServerGameDataOperationResponse` | `dashboard.getServerGameData.selfEnable` |
| `deleteInDatabase` | `DashboardModels.DeleteInDatabaseRequestData` | `deleteInDatabaseAsync(...)` | `DashboardResponseModels.DeleteInDatabaseOperationResponse` | `dashboard.deleteInDatabase.selfEnable` |

## Ví dụ tối thiểu

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

// requestData: DashboardModels.ChangePasswordAdminAccountRequestData đã build theo dto/DASHBOARD.md
var res = await GNNetwork.dashboard.changePasswordAdminAccountAsync(requestData);
if (res.returnCode != ReturnCode.Ok) return;
if (res.errorCode != ErrorCode.Ok) return;
// res.responseData có typed payload
```
