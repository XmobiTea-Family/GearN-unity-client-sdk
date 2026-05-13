# API Reference: AuthenticateApi

Player login (account, social, device id), register, refresh auth token.

- Domain guide: [guides/AUTHENTICATE.md](/docs/guides/AUTHENTICATE.md)
- DTO shapes: [dto/AUTHENTICATE.md](/docs/reference/dto/AUTHENTICATE.md)
- Enums: [ENUMS.md](/docs/reference/ENUMS.md)
- Error handling: [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md)
- Permission rules: [PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md)

## Namespaces

- `GNNetwork.authenticate` — `RequestRole.Client`

## Convention

Mỗi method dưới đây có 2 form — callback và `*Async()` Task. Ưu tiên `*Async()`.

```text
// Callback
GNNetwork.authenticate.<method>(requestData, onResponse?, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);

// Async
var res = await GNNetwork.authenticate.<method>Async(requestData, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);
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

## Client methods (`GNNetwork.authenticate.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules |
| --- | --- | --- | --- | --- |
| `loginByAccount` | `AuthenticateModels.LoginByAccountRequestData` | `loginByAccountAsync(...)` | `AuthenticateResponseModels.LoginByAccountOperationResponse` | `authenticate.loginByAccount.selfEnable` |
| `loginByAndroidDeviceId` | `AuthenticateModels.LoginByAndroidDeviceIdRequestData` | `loginByAndroidDeviceIdAsync(...)` | `AuthenticateResponseModels.LoginByAndroidDeviceIdOperationResponse` | `authenticate.loginByAndroidDeviceId.selfEnable` |
| `loginByApple` | `AuthenticateModels.LoginByAppleRequestData` | `loginByAppleAsync(...)` | `AuthenticateResponseModels.LoginByAppleOperationResponse` | `authenticate.loginByApple.selfEnable` |
| `loginByCustomDeviceId` | `AuthenticateModels.LoginByCustomDeviceIdRequestData` | `loginByCustomDeviceIdAsync(...)` | `AuthenticateResponseModels.LoginByCustomDeviceIdOperationResponse` | `authenticate.loginByCustomDeviceId.selfEnable` |
| `loginByCustomId` | `AuthenticateModels.LoginByCustomIdRequestData` | `loginByCustomIdAsync(...)` | `AuthenticateResponseModels.LoginByCustomIdOperationResponse` | `authenticate.loginByCustomId.selfEnable` |
| `loginByEditorDeviceId` | `AuthenticateModels.LoginByEditorDeviceIdRequestData` | `loginByEditorDeviceIdAsync(...)` | `AuthenticateResponseModels.LoginByEditorDeviceIdOperationResponse` | `authenticate.loginByEditorDeviceId.selfEnable` |
| `loginByFacebook` | `AuthenticateModels.LoginByFacebookRequestData` | `loginByFacebookAsync(...)` | `AuthenticateResponseModels.LoginByFacebookOperationResponse` | `authenticate.loginByFacebook.selfEnable` |
| `loginByGenericService` | `AuthenticateModels.LoginByGenericServiceRequestData` | `loginByGenericServiceAsync(...)` | `AuthenticateResponseModels.LoginByGenericServiceOperationResponse` | `authenticate.loginByGenericService.selfEnable` |
| `loginByGoogle` | `AuthenticateModels.LoginByGoogleRequestData` | `loginByGoogleAsync(...)` | `AuthenticateResponseModels.LoginByGoogleOperationResponse` | `authenticate.loginByGoogle.selfEnable` |
| `loginByGooglePlayGameService` | `AuthenticateModels.LoginByGooglePlayGameServiceRequestData` | `loginByGooglePlayGameServiceAsync(...)` | `AuthenticateResponseModels.LoginByGooglePlayGameServiceOperationResponse` | `authenticate.loginByGooglePlayGameService.selfEnable` |
| `loginByGameCenter` | `AuthenticateModels.LoginByGameCenterRequestData` | `loginByGameCenterAsync(...)` | `AuthenticateResponseModels.LoginByGameCenterOperationResponse` | `authenticate.loginByGameCenter.selfEnable` |
| `loginByiOSDeviceId` | `AuthenticateModels.LoginByiOSDeviceIdRequestData` | `loginByiOSDeviceIdAsync(...)` | `AuthenticateResponseModels.LoginByiOSDeviceIdOperationResponse` | `authenticate.loginByiOSDeviceId.selfEnable` |
| `loginByLinuxDeviceId` | `AuthenticateModels.LoginByLinuxDeviceIdRequestData` | `loginByLinuxDeviceIdAsync(...)` | `AuthenticateResponseModels.LoginByLinuxDeviceIdOperationResponse` | `authenticate.loginByLinuxDeviceId.selfEnable` |
| `loginByMacOSDeviceId` | `AuthenticateModels.LoginByMacOSDeviceIdRequestData` | `loginByMacOSDeviceIdAsync(...)` | `AuthenticateResponseModels.LoginByMacOSDeviceIdOperationResponse` | `authenticate.loginByMacOSDeviceId.selfEnable` |
| `loginByWindowsDeviceId` | `AuthenticateModels.LoginByWindowsDeviceIdRequestData` | `loginByWindowsDeviceIdAsync(...)` | `AuthenticateResponseModels.LoginByWindowsDeviceIdOperationResponse` | `authenticate.loginByWindowsDeviceId.selfEnable` |
| `loginByWindowsPhoneDeviceId` | `AuthenticateModels.LoginByWindowsPhoneDeviceIdRequestData` | `loginByWindowsPhoneDeviceIdAsync(...)` | `AuthenticateResponseModels.LoginByWindowsPhoneDeviceIdOperationResponse` | `authenticate.loginByWindowsPhoneDeviceId.selfEnable` |
| `registerAccount` | `AuthenticateModels.RegisterAccountRequestData` | `registerAccountAsync(...)` | `AuthenticateResponseModels.RegisterAccountOperationResponse` | `authenticate.registerAccount.selfEnable` |
| `refreshAuthToken` | `AuthenticateModels.RefreshAuthTokenRequestData` | `refreshAuthTokenAsync(...)` | `AuthenticateResponseModels.RefreshAuthTokenOperationResponse` | `authenticate.refreshAuthToken.selfEnable` |

## Ví dụ tối thiểu

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

// requestData: AuthenticateModels.LoginByAccountRequestData đã build theo dto/AUTHENTICATE.md
var res = await GNNetwork.authenticate.loginByAccountAsync(requestData);
if (res.returnCode != ReturnCode.Ok) return;
if (res.errorCode != ErrorCode.Ok) return;
// res.responseData có typed payload
```
