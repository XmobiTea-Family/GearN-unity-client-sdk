### InfoRequestParam

Defines the reusable parameter block `infoRequestParam`. This object controls which optional profile fields should be returned together with the auth response. For login/register requests the `infoRequestParam` field itself is required, but every boolean flag inside it defaults to `false`, so pass an instance and omit flags you do not need.

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

Reference links:

- [InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)

### LoginByAndroidDeviceIdRequestData

Defines the request payload for LoginByAndroidDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `androidDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

Reference links:

- [InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)

### LoginByAppleRequestData

Defines the request payload for LoginByApple.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `token` | `string` | yes | _minLength=32, maxLength=2048_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

Reference links:

- [InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)

### LoginByCustomDeviceIdRequestData

Defines the request payload for LoginByCustomDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `customDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

Reference links:

- [InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)

### LoginByCustomIdRequestData

Defines the request payload for LoginByCustomId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `customId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

Reference links:

- [InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)

### LoginByEditorDeviceIdRequestData

Defines the request payload for LoginByEditorDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `editorDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

Reference links:

- [InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)

### LoginByFacebookRequestData

Defines the request payload for LoginByFacebook.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `token` | `string` | yes | _minLength=32, maxLength=2048_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

Reference links:

- [InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)

### LoginByGenericServiceRequestData

Defines the request payload for `loginByGenericService`. `serviceData` is provider-defined and is not constrained by a public typed schema beyond `GNHashtable`.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `serviceName` | `string` | yes | _minLength=6, maxLength=32_ |
| `serviceData` | `GNHashtable` | yes | Provider-defined payload consumed by the backend integration for `serviceName`. |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

Reference links:

- [InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)

### LoginByGoogleRequestData

Defines the request payload for `loginByGoogle`. The public DTO field `type` is an `int`; use the public `GoogleLoginType` enum as the value source and cast it in C# (for example: `request.type = (int)GoogleLoginType.IdToken;`).

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `token` | `string` | yes | _minLength=32, maxLength=2048_ |
| `type` | `int` | yes | Google token type. Assign with an explicit enum cast, for example `(int)GoogleLoginType.IdToken`. — _min=1, max=2_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

Reference links:

- [InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)

### LoginByGooglePlayGameServiceRequestData

Defines the request payload for LoginByGooglePlayGameService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `token` | `string` | yes | _minLength=32, maxLength=2048_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

Reference links:

- [InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)

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
| `timestamp` | `long` | yes | Game Center authentication timestamp from the platform payload. Keep the original unit/value returned by Apple's Game Center API so the backend can verify the signature. |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

Reference links:

- [InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)

### LoginByiOSDeviceIdRequestData

Defines the request payload for LoginByiOSDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `iOSDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

Reference links:

- [InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)

### LoginByLinuxDeviceIdRequestData

Defines the request payload for LoginByLinuxDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `linuxDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

Reference links:

- [InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)

### LoginByMacOSDeviceIdRequestData

Defines the request payload for LoginByMacOSDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `macOSDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

Reference links:

- [InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)

### LoginByWindowsDeviceIdRequestData

Defines the request payload for LoginByWindowsDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `windowsDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

Reference links:

- [InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)

### LoginByWindowsPhoneDeviceIdRequestData

Defines the request payload for LoginByWindowsPhoneDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `windowsPhoneDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `createPlayerIfNotExists` | `bool?` | no | _default=false_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

Reference links:

- [InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)

### RegisterAccountRequestData

Defines the request payload for `registerAccount`. This creates a GearN account and returns the same profile-style payload shape used by the normal login flows.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `username` | `string` | yes | _minLength=6, maxLength=32_ |
| `password` | `string` | yes | _minLength=6, maxLength=64_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields should be returned together with the auth payload. |

Reference links:

- [InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)

### RefreshAuthTokenRequestData

Defines the request payload for `refreshAuthToken`. The request body is intentionally empty. The current auth context comes from the stored auth token or from `overrideAuthToken` passed to the API call.

_Không có field public (payload rỗng)._

### AuthenticateResponseData

Extends: `MasterPlayerModels.MasterPlayerWithUserIdResponseData`

Defines the response payload returned by most login and register flows. This payload extends `MasterPlayerWithUserIdResponseData`, so inherited fields such as `userId` and `infoResponseParameters` are available in addition to the auth-specific fields below. `infoResponseParameters` contains the profile data requested through `infoRequestParam`.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `newlyCreated` | `bool?` | no | Indicates whether the backend created a new player as part of the login flow. |
| `authToken` | `string?` | no | Auth token to cache locally and reuse for future HTTP or socket auth flows. |
| `playerBan` | `GenericModels.BanItem?` | no | Optional ban state returned together with the auth payload. |

Reference links:

- [MasterPlayer.MasterPlayerWithUserIdResponseData:3603-3643](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerwithuseridresponsedata)
- [Generic.BanItem:21-30](/docs/reference/dto/generic/GENERIC_MODELS.md#banitem)

### GenericServiceAuthenticateResponseData

Extends: `AuthenticateResponseData`

Defines the response payload for `loginByGenericService`. This extends the normal auth response and adds an optional backend error message for the external provider flow.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `AuthenticateResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `errorMessage` | `string?` | no | Optional provider-specific error message returned by the backend integration. |

Reference links:

- [AuthenticateResponseData:281-297](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#authenticateresponsedata)

### RefreshAuthTokenResponseData

Defines the response payload for `refreshAuthToken`. Unlike the normal login flows, this response only returns the refreshed auth token and optional ban state.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `authToken` | `string?` | no | Refreshed auth token that should replace the previously stored token. |
| `playerBan` | `GenericModels.BanItem?` | no | Optional ban state returned together with the refreshed token. |

Reference links:

- [Generic.BanItem:21-30](/docs/reference/dto/generic/GENERIC_MODELS.md#banitem)

### EmptyResponseData

Defines an intentionally empty response payload.

_Không có field public (payload rỗng)._
