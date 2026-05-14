# DTO Reference: Authenticate

Player login (account, social, device id), register, refresh auth token.

Related API reference: [API_AUTHENTICATE.md](/docs/reference/API_AUTHENTICATE.md).

Mỗi section bên dưới là 1 class DTO trong namespace `<Models>`. Field table cho biết: tên field, kiểu C# tương ứng, có `required` hay không (suy từ metadata `DataMember` / nullable / optional), doc comment, và ràng buộc length/range/default nếu có.

> **Cách dùng**: khi gọi `*Async()`, bạn truyền instance DTO (`new AuthenticateModels.<Method>RequestData()`) với các field required (+ optional nếu cần). Response class expose `responseData` là instance của class `*ResponseData` tương ứng. Không dùng object literal cast — xem [RULES § 8.1](/docs/RULES.md#81-build-request-dto-trong-code-copy-paste).

> **Pitfall**: `infoRequestParam` — truyền instance dù chỉ bật vài field. Đừng `null` (backend không hydrate gì) và đừng bulk-set hết (payload bự, slow). Chỉ bật field bạn thật sự render. Xem [RULES § 10 #11-12](/docs/RULES.md#10-anti-patterns--pitfalls).

> **Lưu ý route**: Login chỉ qua route `client` — không có Server/Admin variant cho login operation.

## Danh sách

- **AuthenticateModels** (from `Runtime/Entity/Models/AuthenticateModels.cs`)
    - [InfoRequestParam](#inforequestparam)
    - [LoginByAccountRequestData](#loginbyaccountrequestdata)
    - [LoginByAndroidDeviceIdRequestData](#loginbyandroiddeviceidrequestdata)
    - [LoginByAppleRequestData](#loginbyapplerequestdata)
    - [LoginByCustomDeviceIdRequestData](#loginbycustomdeviceidrequestdata)
    - [LoginByCustomIdRequestData](#loginbycustomidrequestdata)
    - [LoginByEditorDeviceIdRequestData](#loginbyeditordeviceidrequestdata)
    - [LoginByFacebookRequestData](#loginbyfacebookrequestdata)
    - [LoginByGenericServiceRequestData](#loginbygenericservicerequestdata)
    - [LoginByGoogleRequestData](#loginbygooglerequestdata)
    - [LoginByGooglePlayGameServiceRequestData](#loginbygoogleplaygameservicerequestdata)
    - [LoginByGameCenterRequestData](#loginbygamecenterrequestdata)
    - [LoginByiOSDeviceIdRequestData](#loginbyiosdeviceidrequestdata)
    - [LoginByLinuxDeviceIdRequestData](#loginbylinuxdeviceidrequestdata)
    - [LoginByMacOSDeviceIdRequestData](#loginbymacosdeviceidrequestdata)
    - [LoginByWindowsDeviceIdRequestData](#loginbywindowsdeviceidrequestdata)
    - [LoginByWindowsPhoneDeviceIdRequestData](#loginbywindowsphonedeviceidrequestdata)
    - [RegisterAccountRequestData](#registeraccountrequestdata)
    - [RefreshAuthTokenRequestData](#refreshauthtokenrequestdata)
    - [AuthenticateResponseData](#authenticateresponsedata)
    - [GenericServiceAuthenticateResponseData](#genericserviceauthenticateresponsedata)
    - [RefreshAuthTokenResponseData](#refreshauthtokenresponsedata)
    - [EmptyResponseData](#emptyresponsedata)
- **AuthenticateRequestModels** (from `Runtime/Entity/Models/AuthenticateRequestModels.cs`)
    - [LoginByAccountOperationRequest](#loginbyaccountoperationrequest)
    - [LoginByAndroidDeviceIdOperationRequest](#loginbyandroiddeviceidoperationrequest)
    - [LoginByAppleOperationRequest](#loginbyappleoperationrequest)
    - [LoginByCustomDeviceIdOperationRequest](#loginbycustomdeviceidoperationrequest)
    - [LoginByCustomIdOperationRequest](#loginbycustomidoperationrequest)
    - [LoginByEditorDeviceIdOperationRequest](#loginbyeditordeviceidoperationrequest)
    - [LoginByFacebookOperationRequest](#loginbyfacebookoperationrequest)
    - [LoginByGenericServiceOperationRequest](#loginbygenericserviceoperationrequest)
    - [LoginByGoogleOperationRequest](#loginbygoogleoperationrequest)
    - [LoginByGooglePlayGameServiceOperationRequest](#loginbygoogleplaygameserviceoperationrequest)
    - [LoginByGameCenterOperationRequest](#loginbygamecenteroperationrequest)
    - [LoginByiOSDeviceIdOperationRequest](#loginbyiosdeviceidoperationrequest)
    - [LoginByLinuxDeviceIdOperationRequest](#loginbylinuxdeviceidoperationrequest)
    - [LoginByMacOSDeviceIdOperationRequest](#loginbymacosdeviceidoperationrequest)
    - [LoginByWindowsDeviceIdOperationRequest](#loginbywindowsdeviceidoperationrequest)
    - [LoginByWindowsPhoneDeviceIdOperationRequest](#loginbywindowsphonedeviceidoperationrequest)
    - [RegisterAccountOperationRequest](#registeraccountoperationrequest)
    - [RefreshAuthTokenOperationRequest](#refreshauthtokenoperationrequest)
- **AuthenticateResponseModels** (from `Runtime/Entity/Models/AuthenticateResponseModels.cs`)
    - [LoginByAccountOperationResponse](#loginbyaccountoperationresponse)
    - [LoginByAndroidDeviceIdOperationResponse](#loginbyandroiddeviceidoperationresponse)
    - [LoginByAppleOperationResponse](#loginbyappleoperationresponse)
    - [LoginByCustomDeviceIdOperationResponse](#loginbycustomdeviceidoperationresponse)
    - [LoginByCustomIdOperationResponse](#loginbycustomidoperationresponse)
    - [LoginByEditorDeviceIdOperationResponse](#loginbyeditordeviceidoperationresponse)
    - [LoginByFacebookOperationResponse](#loginbyfacebookoperationresponse)
    - [LoginByGenericServiceOperationResponse](#loginbygenericserviceoperationresponse)
    - [LoginByGoogleOperationResponse](#loginbygoogleoperationresponse)
    - [LoginByGooglePlayGameServiceOperationResponse](#loginbygoogleplaygameserviceoperationresponse)
    - [LoginByGameCenterOperationResponse](#loginbygamecenteroperationresponse)
    - [LoginByiOSDeviceIdOperationResponse](#loginbyiosdeviceidoperationresponse)
    - [LoginByLinuxDeviceIdOperationResponse](#loginbylinuxdeviceidoperationresponse)
    - [LoginByMacOSDeviceIdOperationResponse](#loginbymacosdeviceidoperationresponse)
    - [LoginByWindowsDeviceIdOperationResponse](#loginbywindowsdeviceidoperationresponse)
    - [LoginByWindowsPhoneDeviceIdOperationResponse](#loginbywindowsphonedeviceidoperationresponse)
    - [RegisterAccountOperationResponse](#registeraccountoperationresponse)
    - [RefreshAuthTokenOperationResponse](#refreshauthtokenoperationresponse)

---

## Namespace `AuthenticateModels`

### InfoRequestParam

Defines the reusable parameter block `infoRequestParam`. This object controls which optional profile fields should be returned together with the auth response. Every boolean flag defaults to `false`, so omit fields you do not need.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `external` | `bool?` | no | Include linked external identity data. — _default=false_ |
| `segments` | `bool?` | no | Include segment assignments. — _default=false_ |
| `customDatas` | `bool?` | no | Include custom data entries, optionally filtered by `customDataKeys`. — _default=false_ |
| `displayName` | `bool?` | no | Include display-name data. — _default=false_ |
| `avatar` | `bool?` | no | Include avatar data. — _default=false_ |
| `tsCreate` | `bool?` | no | Include account creation timestamp. — _default=false_ |
| `tags` | `bool?` | no | Include tag entries, optionally filtered by `tagKeys`. — _default=false_ |
| `playerBan` | `bool?` | no | Include ban state of the player. — _default=false_ |
| `playerCurrencies` | `bool?` | no | Include currency balances, optionally filtered by `playerCurrencyKeys`. — _default=false_ |
| `playerStatistics` | `bool?` | no | Include statistics values, optionally filtered by `playerStatisticsKeys`. — _default=false_ |
| `playerDatas` | `bool?` | no | Include player data entries, optionally filtered by `playerDataKeys`. — _default=false_ |
| `ipAddressCreate` | `bool?` | no | Include IP address recorded at the time of account creation. — _default=false_ |
| `countryCode` | `bool?` | no | Include country code associated with the player account. — _default=false_ |
| `email` | `bool?` | no | Include email address linked to the account. — _default=false_ |
| `tsLastLogin` | `bool?` | no | Include timestamp of the player's last successful login. — _default=false_ |
| `pushNotifications` | `bool?` | no | Include push notification token information registered for the player. — _default=false_ |
| `playerDataKeys` | `List<string>?` | no | Filter the returned player data fields. — _elementCls=String_ |
| `playerCurrencyKeys` | `List<string>?` | no | Filter the returned player currency fields. — _elementCls=String_ |
| `playerStatisticsKeys` | `List<string>?` | no | Filter the returned player statistics fields. — _elementCls=String_ |
| `customDataKeys` | `List<string>?` | no | Filter the returned custom-data fields. — _elementCls=String_ |
| `tagKeys` | `List<string>?` | no | Filter the returned tags by key. — _elementCls=String_ |

### LoginByAccountRequestData

Defines the request payload for `loginByAccount`. Use this flow when the player authenticates with a GearN username and password.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `username` | `string` | yes | _minLength=6, maxLength=32_ |
| `password` | `string` | yes | _minLength=6, maxLength=64_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

### LoginByAndroidDeviceIdRequestData

Defines the request payload for LoginByAndroidDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `androidDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

### LoginByAppleRequestData

Defines the request payload for LoginByApple.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `token` | `string` | yes | _minLength=32, maxLength=2048_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

### LoginByCustomDeviceIdRequestData

Defines the request payload for LoginByCustomDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `customDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

### LoginByCustomIdRequestData

Defines the request payload for LoginByCustomId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `customId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

### LoginByEditorDeviceIdRequestData

Defines the request payload for LoginByEditorDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `editorDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

### LoginByFacebookRequestData

Defines the request payload for LoginByFacebook.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `token` | `string` | yes | _minLength=32, maxLength=2048_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

### LoginByGenericServiceRequestData

Defines the request payload for `loginByGenericService`. `serviceData` is provider-defined and is not constrained by a public typed schema beyond `GNHashtable`.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `serviceName` | `string` | yes | _minLength=6, maxLength=32_ |
| `serviceData` | `GNHashtable` | yes | Provider-defined payload consumed by the backend integration for `serviceName`. |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

### LoginByGoogleRequestData

Defines the request payload for `loginByGoogle`. `type` should be mapped with the public `GoogleLoginType` enum.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `token` | `string` | yes | _minLength=32, maxLength=2048_ |
| `type` | `int` | yes | _min=1, max=2_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

### LoginByGooglePlayGameServiceRequestData

Defines the request payload for LoginByGooglePlayGameService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `token` | `string` | yes | _minLength=32, maxLength=2048_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

### LoginByGameCenterRequestData

Defines the request payload for LoginByGameCenter.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `playerId` | `string` | yes | _minLength=2, maxLength=64_ |
| `name` | `string` | yes | _minLength=2, maxLength=128_ |
| `publicKeyUrl` | `string` | yes | _minLength=2, maxLength=2048_ |
| `signature` | `string` | yes | _minLength=2, maxLength=2048_ |
| `salt` | `string` | yes | _minLength=2, maxLength=256_ |
| `timestamp` | `long` | yes | — |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

### LoginByiOSDeviceIdRequestData

Defines the request payload for LoginByiOSDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `iOSDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

### LoginByLinuxDeviceIdRequestData

Defines the request payload for LoginByLinuxDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `linuxDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

### LoginByMacOSDeviceIdRequestData

Defines the request payload for LoginByMacOSDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `macOSDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

### LoginByWindowsDeviceIdRequestData

Defines the request payload for LoginByWindowsDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `windowsDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

### LoginByWindowsPhoneDeviceIdRequestData

Defines the request payload for LoginByWindowsPhoneDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `windowsPhoneDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

### RegisterAccountRequestData

Defines the request payload for `registerAccount`. This creates a GearN account and returns the same profile-style payload shape used by the normal login flows.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `username` | `string` | yes | _minLength=6, maxLength=32_ |
| `password` | `string` | yes | _minLength=6, maxLength=64_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

### RefreshAuthTokenRequestData

Defines the request payload for `refreshAuthToken`. The request body is intentionally empty. The current auth context comes from the stored auth token or from `overrideAuthToken` passed to the API call.

_Không có field public (payload rỗng)._

### AuthenticateResponseData

Extends: `MasterPlayerModels.MasterPlayerWithUserIdResponseData`

Defines the response payload returned by most login and register flows. This payload extends `MasterPlayerWithUserIdResponseData`, so it may already include profile data requested through `infoRequestParam` in addition to auth-specific fields.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `newlyCreated` | `bool?` | no | Indicates whether the backend created a new player as part of the login flow. |
| `authToken` | `string?` | no | Auth token to cache locally and reuse for future HTTP or socket auth flows. |
| `playerBan` | `GenericModels.BanItem?` | no | Optional ban state returned together with the auth payload. |

### GenericServiceAuthenticateResponseData

Extends: `AuthenticateResponseData`

Defines the response payload for `loginByGenericService`. This extends the normal auth response and adds an optional backend error message for the external provider flow.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `errorMessage` | `string?` | no | Optional provider-specific error message returned by the backend integration. |

### RefreshAuthTokenResponseData

Defines the response payload for `refreshAuthToken`. Unlike the normal login flows, this response only returns the refreshed auth token and optional ban state.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `authToken` | `string?` | no | Refreshed auth token that should replace the previously stored token. |
| `playerBan` | `GenericModels.BanItem?` | no | Optional ban state returned together with the refreshed token. |

### EmptyResponseData

Defines an intentionally empty response payload.

_Không có field public (payload rỗng)._

## Namespace `AuthenticateRequestModels`

### LoginByAccountOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.LoginByAccountRequestData>`

Maps the LoginByAccount operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LoginByAndroidDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.LoginByAndroidDeviceIdRequestData>`

Maps the LoginByAndroidDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LoginByAppleOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.LoginByAppleRequestData>`

Maps the LoginByApple operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LoginByCustomDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.LoginByCustomDeviceIdRequestData>`

Maps the LoginByCustomDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LoginByCustomIdOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.LoginByCustomIdRequestData>`

Maps the LoginByCustomId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LoginByEditorDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.LoginByEditorDeviceIdRequestData>`

Maps the LoginByEditorDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LoginByFacebookOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.LoginByFacebookRequestData>`

Maps the LoginByFacebook operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LoginByGenericServiceOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.LoginByGenericServiceRequestData>`

Maps the LoginByGenericService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LoginByGoogleOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.LoginByGoogleRequestData>`

Maps the LoginByGoogle operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LoginByGooglePlayGameServiceOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.LoginByGooglePlayGameServiceRequestData>`

Maps the LoginByGooglePlayGameService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LoginByGameCenterOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.LoginByGameCenterRequestData>`

Maps the LoginByGameCenter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LoginByiOSDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.LoginByiOSDeviceIdRequestData>`

Maps the LoginByiOSDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LoginByLinuxDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.LoginByLinuxDeviceIdRequestData>`

Maps the LoginByLinuxDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LoginByMacOSDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.LoginByMacOSDeviceIdRequestData>`

Maps the LoginByMacOSDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LoginByWindowsDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.LoginByWindowsDeviceIdRequestData>`

Maps the LoginByWindowsDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LoginByWindowsPhoneDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.LoginByWindowsPhoneDeviceIdRequestData>`

Maps the LoginByWindowsPhoneDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### RegisterAccountOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.RegisterAccountRequestData>`

Maps the RegisterAccount operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### RefreshAuthTokenOperationRequest

Extends: `CustomOperationRequestAbstract<AuthenticateModels.RefreshAuthTokenRequestData>`

Maps the `RefreshAuthToken` operation to a typed request wrapper. The wrapped request body is intentionally empty; auth context still comes from the current token.

_Không có field public (payload rỗng)._

## Namespace `AuthenticateResponseModels`

### LoginByAccountOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.AuthenticateResponseData>`

Maps the LoginByAccount operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LoginByAndroidDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.AuthenticateResponseData>`

Maps the LoginByAndroidDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LoginByAppleOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.AuthenticateResponseData>`

Maps the LoginByApple operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LoginByCustomDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.AuthenticateResponseData>`

Maps the LoginByCustomDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LoginByCustomIdOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.AuthenticateResponseData>`

Maps the LoginByCustomId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LoginByEditorDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.AuthenticateResponseData>`

Maps the LoginByEditorDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LoginByFacebookOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.AuthenticateResponseData>`

Maps the LoginByFacebook operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LoginByGenericServiceOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.GenericServiceAuthenticateResponseData>`

Maps the LoginByGenericService operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LoginByGoogleOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.AuthenticateResponseData>`

Maps the LoginByGoogle operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LoginByGooglePlayGameServiceOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.AuthenticateResponseData>`

Maps the LoginByGooglePlayGameService operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LoginByGameCenterOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.AuthenticateResponseData>`

Maps the LoginByGameCenter operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LoginByiOSDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.AuthenticateResponseData>`

Maps the LoginByiOSDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LoginByLinuxDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.AuthenticateResponseData>`

Maps the LoginByLinuxDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LoginByMacOSDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.AuthenticateResponseData>`

Maps the LoginByMacOSDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LoginByWindowsDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.AuthenticateResponseData>`

Maps the LoginByWindowsDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LoginByWindowsPhoneDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.AuthenticateResponseData>`

Maps the LoginByWindowsPhoneDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RegisterAccountOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.AuthenticateResponseData>`

Maps the RegisterAccount operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RefreshAuthTokenOperationResponse

Extends: `CustomOperationResponseAbstract<AuthenticateModels.RefreshAuthTokenResponseData>`

Maps the RefreshAuthToken operation to a typed response wrapper.

_Không có field public (payload rỗng)._
