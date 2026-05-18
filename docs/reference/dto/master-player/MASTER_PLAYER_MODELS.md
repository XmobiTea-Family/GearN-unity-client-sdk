### CustomDataParam

Defines the reusable parameter block CustomDataParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `object` | yes | Arbitrary value to store for this custom data key. May be a primitive, `GNHashtable`, or `GNArray`. |

### InfoRequestParam

Selects which optional master-player fields should be returned in `infoResponseParameters`. Boolean flags default to `false`; key arrays narrow list-style fields to specific keys only.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `external` | `bool?` | no | Includes linked external identities such as account, device, Google, Facebook, or Apple. — _default=false_ |
| `segments` | `bool?` | no | Includes the segment names currently attached to the player. — _default=false_ |
| `customDatas` | `bool?` | no | Includes custom data entries. — _default=false_ |
| `displayName` | `bool?` | no | Includes the player's display name. — _default=false_ |
| `avatar` | `bool?` | no | Includes the avatar descriptor. — _default=false_ |
| `tsCreate` | `bool?` | no | Includes the creation timestamp. — _default=false_ |
| `tags` | `bool?` | no | Includes tag entries. — _default=false_ |
| `playerBan` | `bool?` | no | Includes the active ban state when present. — _default=false_ |
| `playerCurrencies` | `bool?` | no | Includes player currency entries. — _default=false_ |
| `playerStatistics` | `bool?` | no | Includes player statistics entries. — _default=false_ |
| `playerDatas` | `bool?` | no | Includes player data entries. — _default=false_ |
| `ipAddressCreate` | `bool?` | no | Includes the creation IP address. — _default=false_ |
| `countryCode` | `bool?` | no | Includes the country code currently stored for the player. — _default=false_ |
| `email` | `bool?` | no | Includes the email currently stored for the player. — _default=false_ |
| `tsLastLogin` | `bool?` | no | Includes the last-login timestamp. — _default=false_ |
| `pushNotifications` | `bool?` | no | Includes registered push-notification endpoints. — _default=false_ |
| `onlineStatus` | `bool?` | no | Includes the player's online status, if supported by the connected game server. — _default=false_ |
| `playerDataKeys` | `List<string>?` | no | Restricts `playerDatas` to the specified keys when that field is requested. — _elementCls=String_ |
| `playerCurrencyKeys` | `List<string>?` | no | Restricts `playerCurrencies` to the specified currency keys when that field is requested. — _elementCls=String_ |
| `playerStatisticsKeys` | `List<string>?` | no | Restricts `playerStatistics` to the specified statistic keys when that field is requested. — _elementCls=String_ |
| `customDataKeys` | `List<string>?` | no | Restricts `customDatas` to the specified keys when that field is requested. — _elementCls=String_ |
| `tagKeys` | `List<string>?` | no | Restricts `tags` to the specified tag keys when that field is requested. — _elementCls=String_ |

### PlayerCurrencyParam

Defines the reusable parameter block PlayerCurrencyParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | Currency key identifying the currency to change. — _minLength=2, maxLength=32_ |
| `amount` | `double` | yes | Currency amount delta to apply (positive to add, negative to subtract). |

### PlayerDataParam

Defines the reusable parameter block PlayerDataParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `object` | yes | Arbitrary value to store for this player data key. May be a primitive, `GNHashtable`, or `GNArray`. |

### PlayerStatisticsParam

Defines the reusable parameter block PlayerStatisticsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `double` | yes | Statistic value to apply; interpretation depends on the configured aggregation method. |

### GenericService

Represents one linked external generic service identity.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `serviceName` | `string` | yes | Name of the external service provider. |
| `serviceId` | `string` | yes | Player identifier within the external service. |

### Device

Represents all device IDs currently linked to the master player.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `customDeviceId` | `string?` | no | Custom device identifier when linked. |
| `androidDeviceId` | `string?` | no | Android device identifier when linked. |
| `iOSDeviceId` | `string?` | no | iOS device identifier when linked. |
| `windowsPhoneDeviceId` | `string?` | no | Windows Phone device identifier when linked. |
| `windowsDeviceId` | `string?` | no | Windows PC device identifier when linked. |
| `linuxDeviceId` | `string?` | no | Linux device identifier when linked. |
| `macOSDeviceId` | `string?` | no | macOS device identifier when linked. |
| `editorDeviceId` | `string?` | no | Editor (development) device identifier when linked. |

### Account

Represents a linked GearN account identity.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `username` | `string?` | no | GearN account username when an account credential is linked. |

### Custom

Represents a linked custom ID identity.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `customId` | `string?` | no | Custom ID value when linked. |

### Apple

Represents a linked Apple identity (Sign in with Apple).

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `appleId` | `string` | yes | Apple user identifier from Sign in with Apple. |
| `email` | `string` | yes | Email address from the Apple identity. |

### Google

Represents a linked Google identity.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `googleId` | `string` | yes | Google user identifier (sub claim from the ID token). |
| `displayName` | `string` | yes | Display name from the Google profile. |
| `email` | `string` | yes | Email address from the Google identity. |

### Facebook

Represents a linked Facebook identity.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `facebookId` | `string` | yes | Facebook user ID from the access token. |
| `displayName` | `string` | yes | Display name from the Facebook profile. |
| `email` | `string` | yes | Email address from the Facebook identity. |

### GooglePlayGameService

Represents a linked Google Play Game Services identity.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `playerId` | `string` | yes | Google Play Games player ID. |
| `displayName` | `string` | yes | Display name from the Google Play Games profile. |
| `email` | `string` | yes | Email address associated with the Google Play Games account. |

### GameCenter

Represents a linked Apple Game Center identity.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `playerId` | `string` | yes | Apple Game Center player ID. |
| `displayName` | `string` | yes | Display name from the Game Center profile. |
| `email` | `string` | yes | Email address associated with the Game Center account. |

### ExternalItem

Groups all external identities that may be linked to one master player.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `device` | `Device?` | no | Linked device IDs; present when at least one device ID is linked. |
| `account` | `Account?` | no | Linked GearN account; present when an account credential is linked. |
| `custom` | `Custom?` | no | Linked custom ID; present when a custom ID is linked. |
| `apple` | `Apple?` | no | Linked Apple identity; present when Sign in with Apple is linked. |
| `google` | `Google?` | no | Linked Google identity; present when Google Sign-In is linked. |
| `facebook` | `Facebook?` | no | Linked Facebook identity; present when Facebook is linked. |
| `genericServices` | `List<GenericService>?` | no | List of linked generic service identities. — _elementCls=GenericService_ |
| `googlePlayGameService` | `GooglePlayGameService?` | no | Linked Google Play Game Services identity; present when linked. |
| `gameCenter` | `GameCenter?` | no | Linked Apple Game Center identity; present when linked. |

Reference links:

- [MasterPlayerModels.Device:81-96](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#device)
- [MasterPlayerModels.Account:97-105](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#account)
- [MasterPlayerModels.Custom:106-114](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#custom)
- [MasterPlayerModels.Apple:115-124](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#apple)
- [MasterPlayerModels.Google:125-135](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#google)
- [MasterPlayerModels.Facebook:136-146](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#facebook)
- [MasterPlayerModels.GenericService:71-80](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#genericservice)
- [MasterPlayerModels.GooglePlayGameService:147-157](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#googleplaygameservice)
- [MasterPlayerModels.GameCenter:158-168](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#gamecenter)

### AddSegmentRequestData

Defines the request payload for AddSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerAddSegmentRequestData

Extends: `AddSegmentRequestData`

Defines the request payload for ServerAddSegment.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `AddSegmentRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.AddSegmentRequestData:198-207](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#addsegmentrequestdata)

### AdminAddSegmentRequestData

Extends: `ServerAddSegmentRequestData`

Defines the request payload for AdminAddSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerAddSegmentRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerAddSegmentRequestData:198-224](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serveraddsegmentrequestdata)

### ChangeAccountPasswordRequestData

Defines the request payload for ChangeAccountPassword.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `currentPassword` | `string` | yes | _minLength=6, maxLength=64_ |
| `password` | `string` | yes | _minLength=6, maxLength=64_ |

### GetAvatarRequestData

Defines the request payload for GetAvatar.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetAvatarRequestData

Extends: `GetAvatarRequestData`

Defines the request payload for ServerGetAvatar.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetAvatarRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetAvatarRequestData:253-261](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getavatarrequestdata)

### AdminGetAvatarRequestData

Extends: `ServerGetAvatarRequestData`

Defines the request payload for AdminGetAvatar.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetAvatarRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetAvatarRequestData:253-278](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetavatarrequestdata)

### GetCountryCodeRequestData

Defines the request payload for GetCountryCode.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetCountryCodeRequestData

Extends: `GetCountryCodeRequestData`

Defines the request payload for ServerGetCountryCode.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetCountryCodeRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetCountryCodeRequestData:296-304](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getcountrycoderequestdata)

### AdminGetCountryCodeRequestData

Extends: `ServerGetCountryCodeRequestData`

Defines the request payload for AdminGetCountryCode.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCountryCodeRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetCountryCodeRequestData:296-321](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetcountrycoderequestdata)

### GetCustomDataRequestData

Defines the request payload for GetCustomData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `customDataKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetCustomDataRequestData

Extends: `GetCustomDataRequestData`

Defines the request payload for ServerGetCustomData.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetCustomDataRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetCustomDataRequestData:339-348](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getcustomdatarequestdata)

### AdminGetCustomDataRequestData

Extends: `ServerGetCustomDataRequestData`

Defines the request payload for AdminGetCustomData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCustomDataRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetCustomDataRequestData:339-365](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetcustomdatarequestdata)

### GetDisplayNameRequestData

Defines the request payload for GetDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetDisplayNameRequestData

Extends: `GetDisplayNameRequestData`

Defines the request payload for ServerGetDisplayName.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetDisplayNameRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetDisplayNameRequestData:383-391](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getdisplaynamerequestdata)

### AdminGetDisplayNameRequestData

Extends: `ServerGetDisplayNameRequestData`

Defines the request payload for AdminGetDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetDisplayNameRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetDisplayNameRequestData:383-408](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetdisplaynamerequestdata)

### GetEmailRequestData

Defines the request payload for GetEmail.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetEmailRequestData

Extends: `GetEmailRequestData`

Defines the request payload for ServerGetEmail.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetEmailRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetEmailRequestData:426-434](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getemailrequestdata)

### AdminGetEmailRequestData

Extends: `ServerGetEmailRequestData`

Defines the request payload for AdminGetEmail.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetEmailRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetEmailRequestData:426-451](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetemailrequestdata)

### GetExternalRequestData

Defines the request payload for GetExternal.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetExternalRequestData

Extends: `GetExternalRequestData`

Defines the request payload for ServerGetExternal.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetExternalRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetExternalRequestData:469-477](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getexternalrequestdata)

### AdminGetExternalRequestData

Extends: `ServerGetExternalRequestData`

Defines the request payload for AdminGetExternal.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetExternalRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetExternalRequestData:469-494](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetexternalrequestdata)

### GetIpAddressCreateRequestData

Defines the request payload for GetIpAddressCreate.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetIpAddressCreateRequestData

Extends: `GetIpAddressCreateRequestData`

Defines the request payload for ServerGetIpAddressCreate.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetIpAddressCreateRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetIpAddressCreateRequestData:512-520](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getipaddresscreaterequestdata)

### AdminGetIpAddressCreateRequestData

Extends: `ServerGetIpAddressCreateRequestData`

Defines the request payload for AdminGetIpAddressCreate.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetIpAddressCreateRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetIpAddressCreateRequestData:512-537](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetipaddresscreaterequestdata)

### GetPlayerBanRequestData

Defines the request payload for GetPlayerBan.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetPlayerBanRequestData

Extends: `GetPlayerBanRequestData`

Defines the request payload for ServerGetPlayerBan.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetPlayerBanRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetPlayerBanRequestData:555-563](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getplayerbanrequestdata)

### AdminGetPlayerBanRequestData

Extends: `ServerGetPlayerBanRequestData`

Defines the request payload for AdminGetPlayerBan.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerBanRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetPlayerBanRequestData:555-580](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetplayerbanrequestdata)

### GetPlayerCurrencyRequestData

Defines the request payload for GetPlayerCurrency.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerCurrencyKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerCurrencyRequestData

Extends: `GetPlayerCurrencyRequestData`

Defines the request payload for ServerGetPlayerCurrency.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetPlayerCurrencyRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetPlayerCurrencyRequestData:598-607](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getplayercurrencyrequestdata)

### AdminGetPlayerCurrencyRequestData

Extends: `ServerGetPlayerCurrencyRequestData`

Defines the request payload for AdminGetPlayerCurrency.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerCurrencyRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetPlayerCurrencyRequestData:598-624](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetplayercurrencyrequestdata)

### GetPlayerDataRequestData

Defines the request payload for GetPlayerData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerDataKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerDataRequestData

Extends: `GetPlayerDataRequestData`

Defines the request payload for ServerGetPlayerData.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetPlayerDataRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetPlayerDataRequestData:642-651](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getplayerdatarequestdata)

### AdminGetPlayerDataRequestData

Extends: `ServerGetPlayerDataRequestData`

Defines the request payload for AdminGetPlayerData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerDataRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetPlayerDataRequestData:642-668](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetplayerdatarequestdata)

### GetPlayerInformationRequestData

Reads the current or target master-player profile using the requested projection. On the client route, omit `userId` to target the authenticated player itself.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | Optional self-target shortcut on the client route. — _minLength=10, maxLength=10_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Required field projection that controls which optional data is returned. |

Reference links:

- [MasterPlayerModels.InfoRequestParam:11-40](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayerInformationRequestData

Extends: `GetPlayerInformationRequestData`

Reads a specific target master player on a trusted route.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetPlayerInformationRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetPlayerInformationRequestData:686-699](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getplayerinformationrequestdata)

### AdminGetPlayerInformationRequestData

Extends: `ServerGetPlayerInformationRequestData`

Defines the request payload for AdminGetPlayerInformation.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerInformationRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetPlayerInformationRequestData:686-716](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetplayerinformationrequestdata)

### GetPlayerStatisticsRequestData

Defines the request payload for GetPlayerStatistics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerStatisticsKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerStatisticsRequestData

Extends: `GetPlayerStatisticsRequestData`

Defines the request payload for ServerGetPlayerStatistics.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetPlayerStatisticsRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetPlayerStatisticsRequestData:734-743](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getplayerstatisticsrequestdata)

### AdminGetPlayerStatisticsRequestData

Extends: `ServerGetPlayerStatisticsRequestData`

Defines the request payload for AdminGetPlayerStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerStatisticsRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetPlayerStatisticsRequestData:734-760](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetplayerstatisticsrequestdata)

### GetPlayersWithAppleRequestData

Defines the request payload for GetPlayersWithApple.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `appleIds` | `List<string>` | yes | _elementCls=String_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |

Reference links:

- [MasterPlayerModels.InfoRequestParam:11-40](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayersWithAppleRequestData

Extends: `GetPlayersWithAppleRequestData`

Defines the request payload for ServerGetPlayersWithApple.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayersWithAppleRequestData`._

Reference links:

- [MasterPlayerModels.GetPlayersWithAppleRequestData:778-791](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getplayerswithapplerequestdata)

### AdminGetPlayersWithAppleRequestData

Extends: `ServerGetPlayersWithAppleRequestData`

Defines the request payload for AdminGetPlayersWithApple.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayersWithAppleRequestData`._

Reference links:

- [MasterPlayerModels.ServerGetPlayersWithAppleRequestData:778-803](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetplayerswithapplerequestdata)

### GetPlayersWithDisplayNameRequestData

Defines the request payload for GetPlayersWithDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keyword` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

Reference links:

- [MasterPlayerModels.InfoRequestParam:11-40](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayersWithDisplayNameRequestData

Extends: `GetPlayersWithDisplayNameRequestData`

Defines the request payload for ServerGetPlayersWithDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayersWithDisplayNameRequestData`._

Reference links:

- [MasterPlayerModels.GetPlayersWithDisplayNameRequestData:816-831](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getplayerswithdisplaynamerequestdata)

### AdminGetPlayersWithDisplayNameRequestData

Extends: `ServerGetPlayersWithDisplayNameRequestData`

Defines the request payload for AdminGetPlayersWithDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayersWithDisplayNameRequestData`._

Reference links:

- [MasterPlayerModels.ServerGetPlayersWithDisplayNameRequestData:816-843](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetplayerswithdisplaynamerequestdata)

### GetPlayersWithFacebookRequestData

Defines the request payload for GetPlayersWithFacebook.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `facebookIds` | `List<string>` | yes | _elementCls=String_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |

Reference links:

- [MasterPlayerModels.InfoRequestParam:11-40](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayersWithFacebookRequestData

Extends: `GetPlayersWithFacebookRequestData`

Defines the request payload for ServerGetPlayersWithFacebook.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayersWithFacebookRequestData`._

Reference links:

- [MasterPlayerModels.GetPlayersWithFacebookRequestData:856-869](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getplayerswithfacebookrequestdata)

### AdminGetPlayersWithFacebookRequestData

Extends: `ServerGetPlayersWithFacebookRequestData`

Defines the request payload for AdminGetPlayersWithFacebook.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayersWithFacebookRequestData`._

Reference links:

- [MasterPlayerModels.ServerGetPlayersWithFacebookRequestData:856-881](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetplayerswithfacebookrequestdata)

### GetPlayersWithGenericServiceRequestData

Defines the request payload for GetPlayersWithGenericService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `serviceName` | `string` | yes | _minLength=2, maxLength=32_ |
| `genericIds` | `List<string>` | yes | _elementCls=String_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |

Reference links:

- [MasterPlayerModels.InfoRequestParam:11-40](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayersWithGenericServiceRequestData

Extends: `GetPlayersWithGenericServiceRequestData`

Defines the request payload for ServerGetPlayersWithGenericService.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayersWithGenericServiceRequestData`._

Reference links:

- [MasterPlayerModels.GetPlayersWithGenericServiceRequestData:894-908](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getplayerswithgenericservicerequestdata)

### AdminGetPlayersWithGenericServiceRequestData

Extends: `ServerGetPlayersWithGenericServiceRequestData`

Defines the request payload for AdminGetPlayersWithGenericService.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayersWithGenericServiceRequestData`._

Reference links:

- [MasterPlayerModels.ServerGetPlayersWithGenericServiceRequestData:894-920](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetplayerswithgenericservicerequestdata)

### GetPlayersWithGoogleRequestData

Defines the request payload for GetPlayersWithGoogle.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `googleIds` | `List<string>` | yes | _elementCls=String_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |

Reference links:

- [MasterPlayerModels.InfoRequestParam:11-40](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayersWithGoogleRequestData

Extends: `GetPlayersWithGoogleRequestData`

Defines the request payload for ServerGetPlayersWithGoogle.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayersWithGoogleRequestData`._

Reference links:

- [MasterPlayerModels.GetPlayersWithGoogleRequestData:933-946](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getplayerswithgooglerequestdata)

### AdminGetPlayersWithGoogleRequestData

Extends: `ServerGetPlayersWithGoogleRequestData`

Defines the request payload for AdminGetPlayersWithGoogle.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayersWithGoogleRequestData`._

Reference links:

- [MasterPlayerModels.ServerGetPlayersWithGoogleRequestData:933-958](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetplayerswithgooglerequestdata)

### GetPlayersWithGooglePlayGameServiceRequestData

Defines the request payload for GetPlayersWithGooglePlayGameService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `playerIds` | `List<string>` | yes | _elementCls=String_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |

Reference links:

- [MasterPlayerModels.InfoRequestParam:11-40](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayersWithGooglePlayGameServiceRequestData

Extends: `GetPlayersWithGooglePlayGameServiceRequestData`

Defines the request payload for ServerGetPlayersWithGooglePlayGameService.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayersWithGooglePlayGameServiceRequestData`._

Reference links:

- [MasterPlayerModels.GetPlayersWithGooglePlayGameServiceRequestData:971-984](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getplayerswithgoogleplaygameservicerequestdata)

### AdminGetPlayersWithGooglePlayGameServiceRequestData

Extends: `ServerGetPlayersWithGooglePlayGameServiceRequestData`

Defines the request payload for AdminGetPlayersWithGooglePlayGameService.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayersWithGooglePlayGameServiceRequestData`._

Reference links:

- [MasterPlayerModels.ServerGetPlayersWithGooglePlayGameServiceRequestData:971-996](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetplayerswithgoogleplaygameservicerequestdata)

### GetPlayersWithGameCenterRequestData

Defines the request payload for GetPlayersWithGameCenter.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `playerIds` | `List<string>` | yes | _elementCls=String_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |

Reference links:

- [MasterPlayerModels.InfoRequestParam:11-40](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayersWithGameCenterRequestData

Extends: `GetPlayersWithGameCenterRequestData`

Defines the request payload for ServerGetPlayersWithGameCenter.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayersWithGameCenterRequestData`._

Reference links:

- [MasterPlayerModels.GetPlayersWithGameCenterRequestData:1009-1022](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getplayerswithgamecenterrequestdata)

### AdminGetPlayersWithGameCenterRequestData

Extends: `ServerGetPlayersWithGameCenterRequestData`

Defines the request payload for AdminGetPlayersWithGameCenter.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayersWithGameCenterRequestData`._

Reference links:

- [MasterPlayerModels.ServerGetPlayersWithGameCenterRequestData:1009-1034](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetplayerswithgamecenterrequestdata)

### GetPlayersWithSegmentRequestData

Defines the request payload for GetPlayersWithSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

Reference links:

- [MasterPlayerModels.InfoRequestParam:11-40](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayersWithSegmentRequestData

Extends: `GetPlayersWithSegmentRequestData`

Defines the request payload for ServerGetPlayersWithSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayersWithSegmentRequestData`._

Reference links:

- [MasterPlayerModels.GetPlayersWithSegmentRequestData:1047-1062](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getplayerswithsegmentrequestdata)

### AdminGetPlayersWithSegmentRequestData

Extends: `ServerGetPlayersWithSegmentRequestData`

Defines the request payload for AdminGetPlayersWithSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayersWithSegmentRequestData`._

Reference links:

- [MasterPlayerModels.ServerGetPlayersWithSegmentRequestData:1047-1074](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetplayerswithsegmentrequestdata)

### GetPlayersWithTagRequestData

Defines the request payload for GetPlayersWithTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

Reference links:

- [MasterPlayerModels.InfoRequestParam:11-40](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayersWithTagRequestData

Extends: `GetPlayersWithTagRequestData`

Defines the request payload for ServerGetPlayersWithTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayersWithTagRequestData`._

Reference links:

- [MasterPlayerModels.GetPlayersWithTagRequestData:1087-1103](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getplayerswithtagrequestdata)

### AdminGetPlayersWithTagRequestData

Extends: `ServerGetPlayersWithTagRequestData`

Defines the request payload for AdminGetPlayersWithTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayersWithTagRequestData`._

Reference links:

- [MasterPlayerModels.ServerGetPlayersWithTagRequestData:1087-1115](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetplayerswithtagrequestdata)

### GetSegmentRequestData

Defines the request payload for GetSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetSegmentRequestData

Extends: `GetSegmentRequestData`

Defines the request payload for ServerGetSegment.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetSegmentRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetSegmentRequestData:1128-1136](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getsegmentrequestdata)

### AdminGetSegmentRequestData

Extends: `ServerGetSegmentRequestData`

Defines the request payload for AdminGetSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetSegmentRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetSegmentRequestData:1128-1153](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetsegmentrequestdata)

### GetStatisticsLeaderboardAroundPlayerRequestData

Defines the request payload for GetStatisticsLeaderboardAroundPlayer.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Reference links:

- [MasterPlayerModels.InfoRequestParam:11-40](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetStatisticsLeaderboardAroundPlayerRequestData

Extends: `GetStatisticsLeaderboardAroundPlayerRequestData`

Defines the request payload for ServerGetStatisticsLeaderboardAroundPlayer.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetStatisticsLeaderboardAroundPlayerRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData:1171-1188](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getstatisticsleaderboardaroundplayerrequestdata)

### AdminGetStatisticsLeaderboardAroundPlayerRequestData

Extends: `ServerGetStatisticsLeaderboardAroundPlayerRequestData`

Defines the request payload for AdminGetStatisticsLeaderboardAroundPlayer.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStatisticsLeaderboardAroundPlayerRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData:1171-1205](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetstatisticsleaderboardaroundplayerrequestdata)

### GetStatisticsLeaderboardRequestData

Defines the request payload for GetStatisticsLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |
| `version` | `string?` | no | _minLength=2, maxLength=32_ |

Reference links:

- [MasterPlayerModels.InfoRequestParam:11-40](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetStatisticsLeaderboardRequestData

Extends: `GetStatisticsLeaderboardRequestData`

Defines the request payload for ServerGetStatisticsLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetStatisticsLeaderboardRequestData`._

Reference links:

- [MasterPlayerModels.GetStatisticsLeaderboardRequestData:1223-1240](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getstatisticsleaderboardrequestdata)

### AdminGetStatisticsLeaderboardRequestData

Extends: `ServerGetStatisticsLeaderboardRequestData`

Defines the request payload for AdminGetStatisticsLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStatisticsLeaderboardRequestData`._

Reference links:

- [MasterPlayerModels.ServerGetStatisticsLeaderboardRequestData:1223-1252](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetstatisticsleaderboardrequestdata)

### GetCreateLeaderboardRequestData

Defines the request payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Reference links:

- [MasterPlayerModels.InfoRequestParam:11-40](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetCreateLeaderboardRequestData

Extends: `GetCreateLeaderboardRequestData`

Defines the request payload for ServerGetCreateLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCreateLeaderboardRequestData`._

Reference links:

- [MasterPlayerModels.GetCreateLeaderboardRequestData:1265-1280](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getcreateleaderboardrequestdata)

### AdminGetCreateLeaderboardRequestData

Extends: `ServerGetCreateLeaderboardRequestData`

Defines the request payload for AdminGetCreateLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCreateLeaderboardRequestData`._

Reference links:

- [MasterPlayerModels.ServerGetCreateLeaderboardRequestData:1265-1292](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetcreateleaderboardrequestdata)

### GetLastLoginLeaderboardRequestData

Defines the request payload for GetLastLoginLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Reference links:

- [MasterPlayerModels.InfoRequestParam:11-40](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetLastLoginLeaderboardRequestData

Extends: `GetLastLoginLeaderboardRequestData`

Defines the request payload for ServerGetLastLoginLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetLastLoginLeaderboardRequestData`._

Reference links:

- [MasterPlayerModels.GetLastLoginLeaderboardRequestData:1305-1320](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getlastloginleaderboardrequestdata)

### AdminGetLastLoginLeaderboardRequestData

Extends: `ServerGetLastLoginLeaderboardRequestData`

Defines the request payload for AdminGetLastLoginLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetLastLoginLeaderboardRequestData`._

Reference links:

- [MasterPlayerModels.ServerGetLastLoginLeaderboardRequestData:1305-1332](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetlastloginleaderboardrequestdata)

### GetTagRequestData

Defines the request payload for GetTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `tagKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetTagRequestData

Extends: `GetTagRequestData`

Defines the request payload for ServerGetTag.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetTagRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetTagRequestData:1345-1354](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#gettagrequestdata)

### AdminGetTagRequestData

Extends: `ServerGetTagRequestData`

Defines the request payload for AdminGetTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetTagRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetTagRequestData:1345-1371](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergettagrequestdata)

### GetTsCreateRequestData

Defines the request payload for GetTsCreate.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetTsCreateRequestData

Extends: `GetTsCreateRequestData`

Defines the request payload for ServerGetTsCreate.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetTsCreateRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetTsCreateRequestData:1389-1397](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#gettscreaterequestdata)

### AdminGetTsCreateRequestData

Extends: `ServerGetTsCreateRequestData`

Defines the request payload for AdminGetTsCreate.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetTsCreateRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetTsCreateRequestData:1389-1414](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergettscreaterequestdata)

### GetTsLastLoginRequestData

Defines the request payload for GetTsLastLogin.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetTsLastLoginRequestData

Extends: `GetTsLastLoginRequestData`

Defines the request payload for ServerGetTsLastLogin.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetTsLastLoginRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetTsLastLoginRequestData:1432-1440](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#gettslastloginrequestdata)

### AdminGetTsLastLoginRequestData

Extends: `ServerGetTsLastLoginRequestData`

Defines the request payload for AdminGetTsLastLogin.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetTsLastLoginRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetTsLastLoginRequestData:1432-1457](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergettslastloginrequestdata)

### LinkAccountRequestData

Defines the request payload for LinkAccount.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `username` | `string` | yes | _minLength=6, maxLength=32_ |
| `password` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkAccountRequestData

Extends: `LinkAccountRequestData`

Defines the request payload for ServerLinkAccount.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `LinkAccountRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.LinkAccountRequestData:1475-1486](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#linkaccountrequestdata)

### AdminLinkAccountRequestData

Extends: `ServerLinkAccountRequestData`

Defines the request payload for AdminLinkAccount.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLinkAccountRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerLinkAccountRequestData:1475-1503](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverlinkaccountrequestdata)

### LinkAndroidDeviceIdRequestData

Defines the request payload for LinkAndroidDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `androidDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkAndroidDeviceIdRequestData

Extends: `LinkAndroidDeviceIdRequestData`

Defines the request payload for ServerLinkAndroidDeviceId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `LinkAndroidDeviceIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.LinkAndroidDeviceIdRequestData:1521-1531](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#linkandroiddeviceidrequestdata)

### AdminLinkAndroidDeviceIdRequestData

Extends: `ServerLinkAndroidDeviceIdRequestData`

Defines the request payload for AdminLinkAndroidDeviceId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLinkAndroidDeviceIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerLinkAndroidDeviceIdRequestData:1521-1548](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverlinkandroiddeviceidrequestdata)

### LinkAppleRequestData

Defines the request payload for LinkApple.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `token` | `string` | yes | _minLength=32, maxLength=2048_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkAppleRequestData

Extends: `LinkAppleRequestData`

Defines the request payload for ServerLinkApple.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `LinkAppleRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.LinkAppleRequestData:1566-1576](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#linkapplerequestdata)

### AdminLinkAppleRequestData

Extends: `ServerLinkAppleRequestData`

Defines the request payload for AdminLinkApple.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLinkAppleRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerLinkAppleRequestData:1566-1593](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverlinkapplerequestdata)

### LinkCustomDeviceIdRequestData

Defines the request payload for LinkCustomDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `customDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkCustomDeviceIdRequestData

Extends: `LinkCustomDeviceIdRequestData`

Defines the request payload for ServerLinkCustomDeviceId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `LinkCustomDeviceIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.LinkCustomDeviceIdRequestData:1611-1621](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#linkcustomdeviceidrequestdata)

### AdminLinkCustomDeviceIdRequestData

Extends: `ServerLinkCustomDeviceIdRequestData`

Defines the request payload for AdminLinkCustomDeviceId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLinkCustomDeviceIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerLinkCustomDeviceIdRequestData:1611-1638](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverlinkcustomdeviceidrequestdata)

### LinkCustomIdRequestData

Defines the request payload for LinkCustomId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `customId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkCustomIdRequestData

Extends: `LinkCustomIdRequestData`

Defines the request payload for ServerLinkCustomId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `LinkCustomIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.LinkCustomIdRequestData:1656-1666](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#linkcustomidrequestdata)

### AdminLinkCustomIdRequestData

Extends: `ServerLinkCustomIdRequestData`

Defines the request payload for AdminLinkCustomId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLinkCustomIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerLinkCustomIdRequestData:1656-1683](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverlinkcustomidrequestdata)

### LinkEditorDeviceIdRequestData

Defines the request payload for LinkEditorDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `editorDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkEditorDeviceIdRequestData

Extends: `LinkEditorDeviceIdRequestData`

Defines the request payload for ServerLinkEditorDeviceId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `LinkEditorDeviceIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.LinkEditorDeviceIdRequestData:1701-1711](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#linkeditordeviceidrequestdata)

### AdminLinkEditorDeviceIdRequestData

Extends: `ServerLinkEditorDeviceIdRequestData`

Defines the request payload for AdminLinkEditorDeviceId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLinkEditorDeviceIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerLinkEditorDeviceIdRequestData:1701-1728](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverlinkeditordeviceidrequestdata)

### LinkFacebookRequestData

Defines the request payload for LinkFacebook.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `token` | `string` | yes | _minLength=32, maxLength=2048_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkFacebookRequestData

Extends: `LinkFacebookRequestData`

Defines the request payload for ServerLinkFacebook.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `LinkFacebookRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.LinkFacebookRequestData:1746-1756](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#linkfacebookrequestdata)

### AdminLinkFacebookRequestData

Extends: `ServerLinkFacebookRequestData`

Defines the request payload for AdminLinkFacebook.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLinkFacebookRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerLinkFacebookRequestData:1746-1773](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverlinkfacebookrequestdata)

### LinkGenericServiceRequestData

Defines the request payload for LinkGenericService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `serviceName` | `string` | yes | _minLength=6, maxLength=32_ |
| `serviceData` | `GNHashtable` | yes | Service-specific credential or identity data required by the external generic service provider. |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkGenericServiceRequestData

Extends: `LinkGenericServiceRequestData`

Defines the request payload for ServerLinkGenericService.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `LinkGenericServiceRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.LinkGenericServiceRequestData:1791-1802](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#linkgenericservicerequestdata)

### AdminLinkGenericServiceRequestData

Extends: `ServerLinkGenericServiceRequestData`

Defines the request payload for AdminLinkGenericService.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLinkGenericServiceRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerLinkGenericServiceRequestData:1791-1819](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverlinkgenericservicerequestdata)

### LinkGoogleRequestData

Defines the request payload for LinkGoogle.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `token` | `string` | yes | _minLength=32, maxLength=2048_ |
| `type` | `int` | yes | _min=1, max=2_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkGoogleRequestData

Extends: `LinkGoogleRequestData`

Defines the request payload for ServerLinkGoogle.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `LinkGoogleRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.LinkGoogleRequestData:1837-1848](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#linkgooglerequestdata)

### AdminLinkGoogleRequestData

Extends: `ServerLinkGoogleRequestData`

Defines the request payload for AdminLinkGoogle.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLinkGoogleRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerLinkGoogleRequestData:1837-1865](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverlinkgooglerequestdata)

### LinkGooglePlayGameServiceRequestData

Defines the request payload for LinkGooglePlayGameService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `token` | `string` | yes | _minLength=32, maxLength=2048_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkGooglePlayGameServiceRequestData

Extends: `LinkGooglePlayGameServiceRequestData`

Defines the request payload for ServerLinkGooglePlayGameService.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `LinkGooglePlayGameServiceRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.LinkGooglePlayGameServiceRequestData:1883-1893](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#linkgoogleplaygameservicerequestdata)

### AdminLinkGooglePlayGameServiceRequestData

Extends: `ServerLinkGooglePlayGameServiceRequestData`

Defines the request payload for AdminLinkGooglePlayGameService.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLinkGooglePlayGameServiceRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerLinkGooglePlayGameServiceRequestData:1883-1910](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverlinkgoogleplaygameservicerequestdata)

### LinkGameCenterRequestData

Defines the request payload for LinkGameCenter.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerId` | `string` | yes | _minLength=2, maxLength=64_ |
| `name` | `string` | yes | _minLength=2, maxLength=128_ |
| `publicKeyUrl` | `string` | yes | _minLength=2, maxLength=2048_ |
| `signature` | `string` | yes | _minLength=2, maxLength=2048_ |
| `salt` | `string` | yes | _minLength=2, maxLength=256_ |
| `timestamp` | `long` | yes | Unix timestamp from the Game Center signature verification payload. |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkGameCenterRequestData

Extends: `LinkGameCenterRequestData`

Defines the request payload for ServerLinkGameCenter.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `LinkGameCenterRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.LinkGameCenterRequestData:1928-1943](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#linkgamecenterrequestdata)

### AdminLinkGameCenterRequestData

Extends: `ServerLinkGameCenterRequestData`

Defines the request payload for AdminLinkGameCenter.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLinkGameCenterRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerLinkGameCenterRequestData:1928-1960](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverlinkgamecenterrequestdata)

### LinkiOSDeviceIdRequestData

Defines the request payload for LinkiOSDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `iOSDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkiOSDeviceIdRequestData

Extends: `LinkiOSDeviceIdRequestData`

Defines the request payload for ServerLinkiOSDeviceId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `LinkiOSDeviceIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.LinkiOSDeviceIdRequestData:1978-1988](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#linkiosdeviceidrequestdata)

### AdminLinkiOSDeviceIdRequestData

Extends: `ServerLinkiOSDeviceIdRequestData`

Defines the request payload for AdminLinkiOSDeviceId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLinkiOSDeviceIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerLinkiOSDeviceIdRequestData:1978-2005](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverlinkiosdeviceidrequestdata)

### LinkLinuxDeviceIdRequestData

Defines the request payload for LinkLinuxDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `linuxDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkLinuxDeviceIdRequestData

Extends: `LinkLinuxDeviceIdRequestData`

Defines the request payload for ServerLinkLinuxDeviceId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `LinkLinuxDeviceIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.LinkLinuxDeviceIdRequestData:2023-2033](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#linklinuxdeviceidrequestdata)

### AdminLinkLinuxDeviceIdRequestData

Extends: `ServerLinkLinuxDeviceIdRequestData`

Defines the request payload for AdminLinkLinuxDeviceId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLinkLinuxDeviceIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerLinkLinuxDeviceIdRequestData:2023-2050](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverlinklinuxdeviceidrequestdata)

### LinkMacOSDeviceIdRequestData

Defines the request payload for LinkMacOSDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `macOSDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkMacOSDeviceIdRequestData

Extends: `LinkMacOSDeviceIdRequestData`

Defines the request payload for ServerLinkMacOSDeviceId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `LinkMacOSDeviceIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.LinkMacOSDeviceIdRequestData:2068-2078](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#linkmacosdeviceidrequestdata)

### AdminLinkMacOSDeviceIdRequestData

Extends: `ServerLinkMacOSDeviceIdRequestData`

Defines the request payload for AdminLinkMacOSDeviceId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLinkMacOSDeviceIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerLinkMacOSDeviceIdRequestData:2068-2095](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverlinkmacosdeviceidrequestdata)

### LinkWindowsDeviceIdRequestData

Defines the request payload for LinkWindowsDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `windowsDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkWindowsDeviceIdRequestData

Extends: `LinkWindowsDeviceIdRequestData`

Defines the request payload for ServerLinkWindowsDeviceId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `LinkWindowsDeviceIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.LinkWindowsDeviceIdRequestData:2113-2123](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#linkwindowsdeviceidrequestdata)

### AdminLinkWindowsDeviceIdRequestData

Extends: `ServerLinkWindowsDeviceIdRequestData`

Defines the request payload for AdminLinkWindowsDeviceId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLinkWindowsDeviceIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerLinkWindowsDeviceIdRequestData:2113-2140](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverlinkwindowsdeviceidrequestdata)

### LinkWindowsPhoneDeviceIdRequestData

Defines the request payload for LinkWindowsPhoneDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `windowsPhoneDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkWindowsPhoneDeviceIdRequestData

Extends: `LinkWindowsPhoneDeviceIdRequestData`

Defines the request payload for ServerLinkWindowsPhoneDeviceId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `LinkWindowsPhoneDeviceIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.LinkWindowsPhoneDeviceIdRequestData:2158-2168](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#linkwindowsphonedeviceidrequestdata)

### AdminLinkWindowsPhoneDeviceIdRequestData

Extends: `ServerLinkWindowsPhoneDeviceIdRequestData`

Defines the request payload for AdminLinkWindowsPhoneDeviceId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLinkWindowsPhoneDeviceIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerLinkWindowsPhoneDeviceIdRequestData:2158-2185](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverlinkwindowsphonedeviceidrequestdata)

### RemoveSegmentRequestData

Defines the request payload for RemoveSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerRemoveSegmentRequestData

Extends: `RemoveSegmentRequestData`

Defines the request payload for ServerRemoveSegment.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `RemoveSegmentRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.RemoveSegmentRequestData:2203-2212](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#removesegmentrequestdata)

### AdminRemoveSegmentRequestData

Extends: `ServerRemoveSegmentRequestData`

Defines the request payload for AdminRemoveSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemoveSegmentRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerRemoveSegmentRequestData:2203-2229](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverremovesegmentrequestdata)

### RemoveTagRequestData

Defines the request payload for RemoveTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerRemoveTagRequestData

Extends: `RemoveTagRequestData`

Defines the request payload for ServerRemoveTag.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `RemoveTagRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.RemoveTagRequestData:2247-2256](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#removetagrequestdata)

### AdminRemoveTagRequestData

Extends: `ServerRemoveTagRequestData`

Defines the request payload for AdminRemoveTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemoveTagRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerRemoveTagRequestData:2247-2273](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverremovetagrequestdata)

### ResetAccountPasswordRequestData

Defines the request payload for ResetAccountPassword.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `password` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerResetAccountPasswordRequestData

Extends: `ResetAccountPasswordRequestData`

Defines the request payload for ServerResetAccountPassword.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `ResetAccountPasswordRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ResetAccountPasswordRequestData:2291-2300](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#resetaccountpasswordrequestdata)

### AdminResetAccountPasswordRequestData

Extends: `ServerResetAccountPasswordRequestData`

Defines the request payload for AdminResetAccountPassword.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerResetAccountPasswordRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerResetAccountPasswordRequestData:2291-2317](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverresetaccountpasswordrequestdata)

### SetAvatarRequestData

Defines the request payload for SetAvatar.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `type` | `int` | yes | Avatar type identifier. Maps to the public avatar type enum. |
| `value` | `string` | yes | _minLength=1, maxLength=128_ |

### ServerSetAvatarRequestData

Extends: `SetAvatarRequestData`

Defines the request payload for ServerSetAvatar.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `SetAvatarRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.SetAvatarRequestData:2335-2345](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#setavatarrequestdata)

### AdminSetAvatarRequestData

Extends: `ServerSetAvatarRequestData`

Defines the request payload for AdminSetAvatar.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetAvatarRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerSetAvatarRequestData:2335-2362](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serversetavatarrequestdata)

### SetCountryCodeRequestData

Defines the request payload for SetCountryCode.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `countryCode` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerSetCountryCodeRequestData

Extends: `SetCountryCodeRequestData`

Defines the request payload for ServerSetCountryCode.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `SetCountryCodeRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.SetCountryCodeRequestData:2380-2389](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#setcountrycoderequestdata)

### AdminSetCountryCodeRequestData

Extends: `ServerSetCountryCodeRequestData`

Defines the request payload for AdminSetCountryCode.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetCountryCodeRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerSetCountryCodeRequestData:2380-2406](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serversetcountrycoderequestdata)

### SetCustomDataRequestData

Defines the request payload for SetCustomData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `customDatas` | `List<CustomDataParam>` | yes | _minLength=1, maxLength=32, elementCls=CustomDataParam_ |

Reference links:

- [MasterPlayerModels.CustomDataParam:1-10](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#customdataparam)

### ServerSetCustomDataRequestData

Extends: `SetCustomDataRequestData`

Defines the request payload for ServerSetCustomData.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `SetCustomDataRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.SetCustomDataRequestData:2424-2437](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#setcustomdatarequestdata)

### AdminSetCustomDataRequestData

Extends: `ServerSetCustomDataRequestData`

Defines the request payload for AdminSetCustomData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetCustomDataRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerSetCustomDataRequestData:2424-2454](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serversetcustomdatarequestdata)

### SetDisplayNameRequestData

Defines the request payload for SetDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `displayName` | `string` | yes | _minLength=5, maxLength=32_ |
| `uniqueDisplayName` | `bool?` | no | _default=false_ |

### ServerSetDisplayNameRequestData

Extends: `SetDisplayNameRequestData`

Defines the request payload for ServerSetDisplayName.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `SetDisplayNameRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.SetDisplayNameRequestData:2472-2482](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#setdisplaynamerequestdata)

### AdminSetDisplayNameRequestData

Extends: `ServerSetDisplayNameRequestData`

Defines the request payload for AdminSetDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetDisplayNameRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerSetDisplayNameRequestData:2472-2499](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serversetdisplaynamerequestdata)

### SetEmailRequestData

Defines the request payload for SetEmail.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `email` | `string` | yes | _minLength=5, maxLength=128_ |

### ServerSetEmailRequestData

Extends: `SetEmailRequestData`

Defines the request payload for ServerSetEmail.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `SetEmailRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.SetEmailRequestData:2517-2526](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#setemailrequestdata)

### AdminSetEmailRequestData

Extends: `ServerSetEmailRequestData`

Defines the request payload for AdminSetEmail.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetEmailRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerSetEmailRequestData:2517-2543](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serversetemailrequestdata)

### SetPlayerBanRequestData

Defines the request payload for SetPlayerBan.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `tsExpire` | `long` | yes | Expiration timestamp of the ban (Unix timestamp); use a far-future value for a permanent ban. |
| `reason` | `string` | yes | Human-readable reason for the ban recorded on the backend. |

### ServerSetPlayerBanRequestData

Extends: `SetPlayerBanRequestData`

Defines the request payload for ServerSetPlayerBan.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `SetPlayerBanRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.SetPlayerBanRequestData:2561-2571](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#setplayerbanrequestdata)

### AdminSetPlayerBanRequestData

Extends: `ServerSetPlayerBanRequestData`

Defines the request payload for AdminSetPlayerBan.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetPlayerBanRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerSetPlayerBanRequestData:2561-2588](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serversetplayerbanrequestdata)

### ChangePlayerCurrencyRequestData

Defines the request payload for ChangePlayerCurrency.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerCurrencies` | `List<PlayerCurrencyParam>` | yes | _minLength=1, maxLength=32, elementCls=PlayerCurrencyParam_ |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

Reference links:

- [MasterPlayerModels.PlayerCurrencyParam:41-50](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#playercurrencyparam)

### ServerChangePlayerCurrencyRequestData

Extends: `ChangePlayerCurrencyRequestData`

Defines the request payload for ServerChangePlayerCurrency.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `ChangePlayerCurrencyRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ChangePlayerCurrencyRequestData:2606-2620](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#changeplayercurrencyrequestdata)

### AdminChangePlayerCurrencyRequestData

Extends: `ServerChangePlayerCurrencyRequestData`

Defines the request payload for AdminChangePlayerCurrency.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerChangePlayerCurrencyRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerChangePlayerCurrencyRequestData:2606-2637](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverchangeplayercurrencyrequestdata)

### SetPlayerDataRequestData

Defines the request payload for SetPlayerData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerDatas` | `List<PlayerDataParam>` | yes | _minLength=1, maxLength=32, elementCls=PlayerDataParam_ |

Reference links:

- [MasterPlayerModels.PlayerDataParam:51-60](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#playerdataparam)

### ServerSetPlayerDataRequestData

Extends: `SetPlayerDataRequestData`

Defines the request payload for ServerSetPlayerData.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `SetPlayerDataRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.SetPlayerDataRequestData:2655-2668](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#setplayerdatarequestdata)

### AdminSetPlayerDataRequestData

Extends: `ServerSetPlayerDataRequestData`

Defines the request payload for AdminSetPlayerData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetPlayerDataRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerSetPlayerDataRequestData:2655-2685](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serversetplayerdatarequestdata)

### ChangePlayerStatisticsRequestData

Defines the request payload for ChangePlayerStatistics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerStatistics` | `List<PlayerStatisticsParam>` | yes | _minLength=1, maxLength=32, elementCls=PlayerStatisticsParam_ |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

Reference links:

- [MasterPlayerModels.PlayerStatisticsParam:61-70](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#playerstatisticsparam)

### ServerChangePlayerStatisticsRequestData

Extends: `ChangePlayerStatisticsRequestData`

Defines the request payload for ServerChangePlayerStatistics.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `ChangePlayerStatisticsRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ChangePlayerStatisticsRequestData:2703-2717](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#changeplayerstatisticsrequestdata)

### AdminChangePlayerStatisticsRequestData

Extends: `ServerChangePlayerStatisticsRequestData`

Defines the request payload for AdminChangePlayerStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerChangePlayerStatisticsRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerChangePlayerStatisticsRequestData:2703-2734](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverchangeplayerstatisticsrequestdata)

### SetTagRequestData

Defines the request payload for SetTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerSetTagRequestData

Extends: `SetTagRequestData`

Defines the request payload for ServerSetTag.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `SetTagRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.SetTagRequestData:2752-2762](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#settagrequestdata)

### AdminSetTagRequestData

Extends: `ServerSetTagRequestData`

Defines the request payload for AdminSetTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetTagRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerSetTagRequestData:2752-2779](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serversettagrequestdata)

### GetCurrencyLogRequestData

Reads currency change logs for the current or target master player. Pagination is token-based rather than skip-based.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keys` | `List<string>?` | no | _minLength=1, maxLength=32, elementCls=String_ |
| `userId` | `string?` | no | Optional self-target shortcut on the client route. — _minLength=10, maxLength=10_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `token` | `string?` | no | Continuation token returned by the previous page. — _minLength=24, maxLength=24_ |

### ServerGetCurrencyLogRequestData

Extends: `GetCurrencyLogRequestData`

Defines the request payload for ServerGetCurrencyLog.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCurrencyLogRequestData`._

Reference links:

- [MasterPlayerModels.GetCurrencyLogRequestData:2797-2808](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getcurrencylogrequestdata)

### AdminGetCurrencyLogRequestData

Extends: `ServerGetCurrencyLogRequestData`

Defines the request payload for AdminGetCurrencyLog.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCurrencyLogRequestData`._

Reference links:

- [MasterPlayerModels.ServerGetCurrencyLogRequestData:2797-2820](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetcurrencylogrequestdata)

### GetStatisticsLogRequestData

Reads statistic change logs for the current or target master player. Pagination is token-based rather than skip-based.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keys` | `List<string>?` | no | _minLength=1, maxLength=32, elementCls=String_ |
| `userId` | `string?` | no | Optional self-target shortcut on the client route. — _minLength=10, maxLength=10_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `token` | `string?` | no | Continuation token returned by the previous page. — _minLength=24, maxLength=24_ |

### ServerGetStatisticsLogRequestData

Extends: `GetStatisticsLogRequestData`

Defines the request payload for ServerGetStatisticsLog.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetStatisticsLogRequestData`._

Reference links:

- [MasterPlayerModels.GetStatisticsLogRequestData:2833-2844](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getstatisticslogrequestdata)

### AdminGetStatisticsLogRequestData

Extends: `ServerGetStatisticsLogRequestData`

Defines the request payload for AdminGetStatisticsLog.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStatisticsLogRequestData`._

Reference links:

- [MasterPlayerModels.ServerGetStatisticsLogRequestData:2833-2856](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetstatisticslogrequestdata)

### UpdateTsLastLoginRequestData

Defines the request payload for UpdateTsLastLogin.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerUpdateTsLastLoginRequestData

Extends: `UpdateTsLastLoginRequestData`

Defines the request payload for ServerUpdateTsLastLogin.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `UpdateTsLastLoginRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.UpdateTsLastLoginRequestData:2869-2877](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#updatetslastloginrequestdata)

### AdminUpdateTsLastLoginRequestData

Extends: `ServerUpdateTsLastLoginRequestData`

Defines the request payload for AdminUpdateTsLastLogin.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerUpdateTsLastLoginRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerUpdateTsLastLoginRequestData:2869-2894](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverupdatetslastloginrequestdata)

### UnlinkAccountRequestData

Defines the request payload for UnlinkAccount.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `username` | `string` | yes | _minLength=6, maxLength=32_ |

### ServerUnlinkAccountRequestData

Extends: `UnlinkAccountRequestData`

Defines the request payload for ServerUnlinkAccount.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `UnlinkAccountRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.UnlinkAccountRequestData:2912-2921](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#unlinkaccountrequestdata)

### AdminUnlinkAccountRequestData

Extends: `ServerUnlinkAccountRequestData`

Defines the request payload for AdminUnlinkAccount.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerUnlinkAccountRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerUnlinkAccountRequestData:2912-2938](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverunlinkaccountrequestdata)

### UnlinkAndroidDeviceIdRequestData

Defines the request payload for UnlinkAndroidDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `androidDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkAndroidDeviceIdRequestData

Extends: `UnlinkAndroidDeviceIdRequestData`

Defines the request payload for ServerUnlinkAndroidDeviceId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `UnlinkAndroidDeviceIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.UnlinkAndroidDeviceIdRequestData:2956-2965](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#unlinkandroiddeviceidrequestdata)

### AdminUnlinkAndroidDeviceIdRequestData

Extends: `ServerUnlinkAndroidDeviceIdRequestData`

Defines the request payload for AdminUnlinkAndroidDeviceId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerUnlinkAndroidDeviceIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerUnlinkAndroidDeviceIdRequestData:2956-2982](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverunlinkandroiddeviceidrequestdata)

### UnlinkAppleRequestData

Defines the request payload for UnlinkApple.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `appleId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkAppleRequestData

Extends: `UnlinkAppleRequestData`

Defines the request payload for ServerUnlinkApple.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `UnlinkAppleRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.UnlinkAppleRequestData:3000-3009](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#unlinkapplerequestdata)

### AdminUnlinkAppleRequestData

Extends: `ServerUnlinkAppleRequestData`

Defines the request payload for AdminUnlinkApple.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerUnlinkAppleRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerUnlinkAppleRequestData:3000-3026](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverunlinkapplerequestdata)

### UnlinkCustomDeviceIdRequestData

Defines the request payload for UnlinkCustomDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `customDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkCustomDeviceIdRequestData

Extends: `UnlinkCustomDeviceIdRequestData`

Defines the request payload for ServerUnlinkCustomDeviceId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `UnlinkCustomDeviceIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.UnlinkCustomDeviceIdRequestData:3044-3053](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#unlinkcustomdeviceidrequestdata)

### AdminUnlinkCustomDeviceIdRequestData

Extends: `ServerUnlinkCustomDeviceIdRequestData`

Defines the request payload for AdminUnlinkCustomDeviceId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerUnlinkCustomDeviceIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerUnlinkCustomDeviceIdRequestData:3044-3070](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverunlinkcustomdeviceidrequestdata)

### UnlinkCustomIdRequestData

Defines the request payload for UnlinkCustomId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `customId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkCustomIdRequestData

Extends: `UnlinkCustomIdRequestData`

Defines the request payload for ServerUnlinkCustomId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `UnlinkCustomIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.UnlinkCustomIdRequestData:3088-3097](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#unlinkcustomidrequestdata)

### AdminUnlinkCustomIdRequestData

Extends: `ServerUnlinkCustomIdRequestData`

Defines the request payload for AdminUnlinkCustomId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerUnlinkCustomIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerUnlinkCustomIdRequestData:3088-3114](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverunlinkcustomidrequestdata)

### UnlinkEditorDeviceIdRequestData

Defines the request payload for UnlinkEditorDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `editorDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkEditorDeviceIdRequestData

Extends: `UnlinkEditorDeviceIdRequestData`

Defines the request payload for ServerUnlinkEditorDeviceId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `UnlinkEditorDeviceIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.UnlinkEditorDeviceIdRequestData:3132-3141](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#unlinkeditordeviceidrequestdata)

### AdminUnlinkEditorDeviceIdRequestData

Extends: `ServerUnlinkEditorDeviceIdRequestData`

Defines the request payload for AdminUnlinkEditorDeviceId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerUnlinkEditorDeviceIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerUnlinkEditorDeviceIdRequestData:3132-3158](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverunlinkeditordeviceidrequestdata)

### UnlinkFacebookRequestData

Defines the request payload for UnlinkFacebook.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `facebookId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkFacebookRequestData

Extends: `UnlinkFacebookRequestData`

Defines the request payload for ServerUnlinkFacebook.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `UnlinkFacebookRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.UnlinkFacebookRequestData:3176-3185](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#unlinkfacebookrequestdata)

### AdminUnlinkFacebookRequestData

Extends: `ServerUnlinkFacebookRequestData`

Defines the request payload for AdminUnlinkFacebook.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerUnlinkFacebookRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerUnlinkFacebookRequestData:3176-3202](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverunlinkfacebookrequestdata)

### UnlinkGenericServiceRequestData

Defines the request payload for UnlinkGenericService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `serviceName` | `string` | yes | _minLength=6, maxLength=32_ |
| `serviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkGenericServiceRequestData

Extends: `UnlinkGenericServiceRequestData`

Defines the request payload for ServerUnlinkGenericService.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `UnlinkGenericServiceRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.UnlinkGenericServiceRequestData:3220-3230](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#unlinkgenericservicerequestdata)

### AdminUnlinkGenericServiceRequestData

Extends: `ServerUnlinkGenericServiceRequestData`

Defines the request payload for AdminUnlinkGenericService.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerUnlinkGenericServiceRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerUnlinkGenericServiceRequestData:3220-3247](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverunlinkgenericservicerequestdata)

### UnlinkGoogleRequestData

Defines the request payload for UnlinkGoogle.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `googleId` | `string` | yes | _minLength=6, maxLength=32_ |

### ServerUnlinkGoogleRequestData

Extends: `UnlinkGoogleRequestData`

Defines the request payload for ServerUnlinkGoogle.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `UnlinkGoogleRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.UnlinkGoogleRequestData:3265-3274](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#unlinkgooglerequestdata)

### AdminUnlinkGoogleRequestData

Extends: `ServerUnlinkGoogleRequestData`

Defines the request payload for AdminUnlinkGoogle.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerUnlinkGoogleRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerUnlinkGoogleRequestData:3265-3291](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverunlinkgooglerequestdata)

### UnlinkGooglePlayGameServiceRequestData

Defines the request payload for UnlinkGooglePlayGameService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkGooglePlayGameServiceRequestData

Extends: `UnlinkGooglePlayGameServiceRequestData`

Defines the request payload for ServerUnlinkGooglePlayGameService.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `UnlinkGooglePlayGameServiceRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.UnlinkGooglePlayGameServiceRequestData:3309-3318](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#unlinkgoogleplaygameservicerequestdata)

### AdminUnlinkGooglePlayGameServiceRequestData

Extends: `ServerUnlinkGooglePlayGameServiceRequestData`

Defines the request payload for AdminUnlinkGooglePlayGameService.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerUnlinkGooglePlayGameServiceRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerUnlinkGooglePlayGameServiceRequestData:3309-3335](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverunlinkgoogleplaygameservicerequestdata)

### UnlinkGameCenterRequestData

Defines the request payload for UnlinkGameCenter.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkGameCenterRequestData

Extends: `UnlinkGameCenterRequestData`

Defines the request payload for ServerUnlinkGameCenter.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `UnlinkGameCenterRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.UnlinkGameCenterRequestData:3353-3362](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#unlinkgamecenterrequestdata)

### AdminUnlinkGameCenterRequestData

Extends: `ServerUnlinkGameCenterRequestData`

Defines the request payload for AdminUnlinkGameCenter.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerUnlinkGameCenterRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerUnlinkGameCenterRequestData:3353-3379](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverunlinkgamecenterrequestdata)

### UnlinkiOSDeviceIdRequestData

Defines the request payload for UnlinkiOSDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `iOSDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkiOSDeviceIdRequestData

Extends: `UnlinkiOSDeviceIdRequestData`

Defines the request payload for ServerUnlinkiOSDeviceId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `UnlinkiOSDeviceIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.UnlinkiOSDeviceIdRequestData:3397-3406](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#unlinkiosdeviceidrequestdata)

### AdminUnlinkiOSDeviceIdRequestData

Extends: `ServerUnlinkiOSDeviceIdRequestData`

Defines the request payload for AdminUnlinkiOSDeviceId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerUnlinkiOSDeviceIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerUnlinkiOSDeviceIdRequestData:3397-3423](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverunlinkiosdeviceidrequestdata)

### UnlinkLinuxDeviceIdRequestData

Defines the request payload for UnlinkLinuxDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `linuxDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkLinuxDeviceIdRequestData

Extends: `UnlinkLinuxDeviceIdRequestData`

Defines the request payload for ServerUnlinkLinuxDeviceId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `UnlinkLinuxDeviceIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.UnlinkLinuxDeviceIdRequestData:3441-3450](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#unlinklinuxdeviceidrequestdata)

### AdminUnlinkLinuxDeviceIdRequestData

Extends: `ServerUnlinkLinuxDeviceIdRequestData`

Defines the request payload for AdminUnlinkLinuxDeviceId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerUnlinkLinuxDeviceIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerUnlinkLinuxDeviceIdRequestData:3441-3467](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverunlinklinuxdeviceidrequestdata)

### UnlinkMacOSDeviceIdRequestData

Defines the request payload for UnlinkMacOSDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `macOSDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkMacOSDeviceIdRequestData

Extends: `UnlinkMacOSDeviceIdRequestData`

Defines the request payload for ServerUnlinkMacOSDeviceId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `UnlinkMacOSDeviceIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.UnlinkMacOSDeviceIdRequestData:3485-3494](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#unlinkmacosdeviceidrequestdata)

### AdminUnlinkMacOSDeviceIdRequestData

Extends: `ServerUnlinkMacOSDeviceIdRequestData`

Defines the request payload for AdminUnlinkMacOSDeviceId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerUnlinkMacOSDeviceIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerUnlinkMacOSDeviceIdRequestData:3485-3511](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverunlinkmacosdeviceidrequestdata)

### UnlinkWindowsDeviceIdRequestData

Defines the request payload for UnlinkWindowsDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `windowsDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkWindowsDeviceIdRequestData

Extends: `UnlinkWindowsDeviceIdRequestData`

Defines the request payload for ServerUnlinkWindowsDeviceId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `UnlinkWindowsDeviceIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.UnlinkWindowsDeviceIdRequestData:3529-3538](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#unlinkwindowsdeviceidrequestdata)

### AdminUnlinkWindowsDeviceIdRequestData

Extends: `ServerUnlinkWindowsDeviceIdRequestData`

Defines the request payload for AdminUnlinkWindowsDeviceId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerUnlinkWindowsDeviceIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerUnlinkWindowsDeviceIdRequestData:3529-3555](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverunlinkwindowsdeviceidrequestdata)

### UnlinkWindowsPhoneDeviceIdRequestData

Defines the request payload for UnlinkWindowsPhoneDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `windowsPhoneDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkWindowsPhoneDeviceIdRequestData

Extends: `UnlinkWindowsPhoneDeviceIdRequestData`

Defines the request payload for ServerUnlinkWindowsPhoneDeviceId.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `UnlinkWindowsPhoneDeviceIdRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.UnlinkWindowsPhoneDeviceIdRequestData:3573-3582](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#unlinkwindowsphonedeviceidrequestdata)

### AdminUnlinkWindowsPhoneDeviceIdRequestData

Extends: `ServerUnlinkWindowsPhoneDeviceIdRequestData`

Defines the request payload for AdminUnlinkWindowsPhoneDeviceId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerUnlinkWindowsPhoneDeviceIdRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerUnlinkWindowsPhoneDeviceIdRequestData:3573-3599](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverunlinkwindowsphonedeviceidrequestdata)

### SendSocketOperationEventRequestData

Sends a backend-routed socket event to the current or target player's active socket session. This is still an HTTP MasterPlayer operation, not a raw socket transport call.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | Optional self-target shortcut on the client route. — _minLength=10, maxLength=10_ |
| `eventCode` | `string` | yes | Backend-defined event code forwarded to socket listeners. — _minLength=1, maxLength=64_ |
| `eventParameters` | `GNHashtable?` | no | Optional raw event payload delivered with the socket event. — _minLength=0, maxLength=128_ |

### ServerSendSocketOperationEventRequestData

Extends: `SendSocketOperationEventRequestData`

Defines the request payload for ServerSendSocketOperationEvent.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `SendSocketOperationEventRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.SendSocketOperationEventRequestData:3617-3627](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#sendsocketoperationeventrequestdata)

### AdminSendSocketOperationEventRequestData

Extends: `ServerSendSocketOperationEventRequestData`

Defines the request payload for AdminSendSocketOperationEvent.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSendSocketOperationEventRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerSendSocketOperationEventRequestData:3617-3644](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serversendsocketoperationeventrequestdata)

### SendEmailRequestData

Defines the request payload for SendEmail.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `subject` | `string` | yes | _minLength=2, maxLength=256_ |
| `contentHtml` | `string` | yes | _minLength=2, maxLength=8192_ |

### ServerSendEmailRequestData

Extends: `SendEmailRequestData`

Defines the request payload for ServerSendEmail.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `SendEmailRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.SendEmailRequestData:3662-3672](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#sendemailrequestdata)

### AdminSendEmailRequestData

Extends: `ServerSendEmailRequestData`

Defines the request payload for AdminSendEmail.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSendEmailRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerSendEmailRequestData:3662-3689](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serversendemailrequestdata)

### AddPushNotificationRequestData

Registers a push-notification endpoint for the current or target master player.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `token` | `string` | yes | Device push token issued by the push provider. — _minLength=10, maxLength=256_ |
| `platformType` | `int` | yes | Push platform mapped by the public `PushPlatformType` enum. — _min=1_ |

### ServerAddPushNotificationRequestData

Extends: `AddPushNotificationRequestData`

Defines the request payload for ServerAddPushNotification.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `AddPushNotificationRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.AddPushNotificationRequestData:3707-3717](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#addpushnotificationrequestdata)

### AdminAddPushNotificationRequestData

Extends: `ServerAddPushNotificationRequestData`

Defines the request payload for AdminAddPushNotification.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerAddPushNotificationRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerAddPushNotificationRequestData:3707-3734](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serveraddpushnotificationrequestdata)

### GetPushNotificationRequestData

Reads registered push-notification endpoints for the current or target master player.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetPushNotificationRequestData

Extends: `GetPushNotificationRequestData`

Defines the request payload for ServerGetPushNotification.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetPushNotificationRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetPushNotificationRequestData:3752-3760](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getpushnotificationrequestdata)

### AdminGetPushNotificationRequestData

Extends: `ServerGetPushNotificationRequestData`

Defines the request payload for AdminGetPushNotification.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPushNotificationRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetPushNotificationRequestData:3752-3777](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetpushnotificationrequestdata)

### RemovePushNotificationRequestData

Defines the request payload for RemovePushNotification.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `pushId` | `string` | yes | _minLength=8, maxLength=8_ |

### ServerRemovePushNotificationRequestData

Extends: `RemovePushNotificationRequestData`

Defines the request payload for ServerRemovePushNotification.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `RemovePushNotificationRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.RemovePushNotificationRequestData:3795-3804](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#removepushnotificationrequestdata)

### AdminRemovePushNotificationRequestData

Extends: `ServerRemovePushNotificationRequestData`

Defines the request payload for AdminRemovePushNotification.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemovePushNotificationRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerRemovePushNotificationRequestData:3795-3821](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serverremovepushnotificationrequestdata)

### SendPushNotificationRequestData

Triggers a push-notification send workflow for the current or target master player.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `title` | `string` | yes | Title text displayed as the push notification header. |
| `body` | `string` | yes | Body text displayed as the push notification message. |
| `badge` | `int?` | no | _default=null_ |
| `sound` | `string?` | no | Sound file name played on notification receipt (platform-specific). |
| `icon` | `string?` | no | Icon resource name or URL shown in the notification (platform-specific). |
| `data` | `GNHashtable?` | no | Platform-specific custom payload forwarded to the push provider. |

### ServerSendPushNotificationRequestData

Extends: `SendPushNotificationRequestData`

Defines the request payload for ServerSendPushNotification.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `SendPushNotificationRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.SendPushNotificationRequestData:3839-3853](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#sendpushnotificationrequestdata)

### AdminSendPushNotificationRequestData

Extends: `ServerSendPushNotificationRequestData`

Defines the request payload for AdminSendPushNotification.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSendPushNotificationRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerSendPushNotificationRequestData:3839-3870](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#serversendpushnotificationrequestdata)

### GetOnlineStatusRequestData

Defines the request payload for GetOnlineStatus.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetOnlineStatusRequestData

Extends: `GetOnlineStatusRequestData`

Defines the request payload for ServerGetOnlineStatus.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetOnlineStatusRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.GetOnlineStatusRequestData:3888-3896](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getonlinestatusrequestdata)

### AdminGetOnlineStatusRequestData

Extends: `ServerGetOnlineStatusRequestData`

Defines the request payload for AdminGetOnlineStatus.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetOnlineStatusRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target master-player user ID. - _minLength=10, maxLength=10_ |

Reference links:

- [MasterPlayerModels.ServerGetOnlineStatusRequestData:3888-3913](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetonlinestatusrequestdata)

### PushNotificationItem

Describes one registered push endpoint stored for a player.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `token` | `string` | yes | FCM device registration token issued by the push provider. |
| `pushId` | `string` | yes | Backend-assigned push endpoint identifier for this registration. |
| `platformType` | `int` | yes | Push platform mapped by the public `PushPlatformType` enum. |

### InfoResponseParameters

Contains the optional fields requested through `InfoRequestParam`.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `external` | `ExternalItem?` | no | Linked external identity snapshot. |
| `segments` | `List<string>?` | no | _elementCls=String_ |
| `customDatas` | `List<GenericModels.DataItem>?` | no | _elementCls=GenericModels.DataItem_ |
| `displayName` | `string?` | no | Display name of the master player. |
| `avatar` | `GenericModels.AvatarItem?` | no | Avatar data of the master player. |
| `tsCreate` | `long?` | no | Account creation timestamp of the master player. |
| `tags` | `List<GenericModels.TagItem>?` | no | _elementCls=GenericModels.TagItem_ |
| `playerBan` | `GenericModels.BanItem?` | no | Ban state of the master player; present when a ban is active. |
| `playerDatas` | `List<GenericModels.DataItem>?` | no | _elementCls=GenericModels.DataItem_ |
| `playerCurrencies` | `List<GenericModels.CurrencyItem>?` | no | _elementCls=GenericModels.CurrencyItem_ |
| `playerStatistics` | `List<GenericModels.StatisticsItem>?` | no | _elementCls=GenericModels.StatisticsItem_ |
| `tsLastLogin` | `long?` | no | Timestamp of the master player's last successful login. |
| `ipAddressCreate` | `string?` | no | IP address recorded at the time of account creation. |
| `countryCode` | `string?` | no | Country code associated with the master player account. |
| `email` | `string?` | no | Email address linked to the master player account. |
| `pushNotifications` | `List<MasterPlayerModels.PushNotificationItem>?` | no | Registered push endpoints when `pushNotifications` was requested. — _elementCls=MasterPlayerModels.PushNotificationItem_ |
| `onlineStatus` | `OnlineStatusItem?` | no | Online status snapshot; present when `onlineStatus` is enabled in `InfoRequestParam`. |

Reference links:

- [MasterPlayerModels.ExternalItem:169-197](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#externalitem)
- [MasterPlayerModels.PushNotificationItem:3931-3941](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#pushnotificationitem)
- [MasterPlayerModels.OnlineStatusItem:3973-3982](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#onlinestatusitem)

### OnlineStatusItem

Online status snapshot returned when `InfoRequestParam.onlineStatus` is `true`.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `tsLastLogin` | `long` | yes | Unix timestamp (ms) of the player's last login. |
| `socketId` | `string` | yes | Active socket connection ID, or empty string if the player is offline. |

### MasterPlayerResponseData

Base master-player response envelope.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoResponseParameters` | `InfoResponseParameters` | yes | Optional field bag controlled by the corresponding `InfoRequestParam`. |

Reference links:

- [MasterPlayerModels.InfoResponseParameters:3942-3972](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#inforesponseparameters)

### GenericServiceMasterPlayerResponseData

Extends: `MasterPlayerResponseData`

Master-player envelope for generic-service link or lookup flows.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `MasterPlayerResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `errorMessage` | `string?` | no | Provider-specific error text returned by the backend when available. |

Reference links:

- [MasterPlayerModels.MasterPlayerResponseData:3983-3995](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerresponsedata)

### MasterPlayerWithUserIdResponseData

Extends: `MasterPlayerResponseData`

Master-player envelope that also exposes the resolved master-player user ID.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `MasterPlayerResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Master-player user identifier. |

Reference links:

- [MasterPlayerModels.MasterPlayerResponseData:3983-3995](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerresponsedata)

### MasterPlayerWithAppleIdResponseData

Extends: `MasterPlayerWithUserIdResponseData`

Defines the response payload for MasterPlayerWithAppleId.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `MasterPlayerWithUserIdResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `appleId` | `string` | yes | Apple user identifier from Sign in with Apple. |

Reference links:

- [MasterPlayerModels.MasterPlayerWithUserIdResponseData:3983-4029](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerwithuseridresponsedata)

### GetPlayersWithAppleResponseData

Defines the response payload for GetPlayersWithApple.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerWithAppleIdResponseData>` | yes | _elementCls=MasterPlayerWithAppleIdResponseData_ |

Reference links:

- [MasterPlayerModels.MasterPlayerWithAppleIdResponseData:3983-4046](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerwithappleidresponsedata)

### MasterPlayersWithUserIdResponseData

Defines the response payload for MasterPlayersWithUserId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerWithUserIdResponseData>` | yes | _elementCls=MasterPlayerWithUserIdResponseData_ |

Reference links:

- [MasterPlayerModels.MasterPlayerWithUserIdResponseData:3983-4029](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerwithuseridresponsedata)

### MasterPlayerWithFacebookIdResponseData

Extends: `MasterPlayerWithUserIdResponseData`

Defines the response payload for MasterPlayerWithFacebookId.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `MasterPlayerWithUserIdResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `facebookId` | `string` | yes | Facebook user identifier from the linked Facebook account. |

Reference links:

- [MasterPlayerModels.MasterPlayerWithUserIdResponseData:3983-4029](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerwithuseridresponsedata)

### GetPlayersWithFacebookResponseData

Defines the response payload for GetPlayersWithFacebook.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerWithFacebookIdResponseData>` | yes | _elementCls=MasterPlayerWithFacebookIdResponseData_ |

Reference links:

- [MasterPlayerModels.MasterPlayerWithFacebookIdResponseData:3983-4089](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerwithfacebookidresponsedata)

### MasterPlayerWithGenericServiceIdResponseData

Extends: `MasterPlayerWithUserIdResponseData`

Defines the response payload for MasterPlayerWithGenericServiceId.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `MasterPlayerWithUserIdResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `serviceId` | `string` | yes | Player identifier within the linked external generic service. |

Reference links:

- [MasterPlayerModels.MasterPlayerWithUserIdResponseData:3983-4029](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerwithuseridresponsedata)

### GetPlayersWithGenericServiceResponseData

Defines the response payload for GetPlayersWithGenericService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerWithGenericServiceIdResponseData>` | yes | _elementCls=MasterPlayerWithGenericServiceIdResponseData_ |

Reference links:

- [MasterPlayerModels.MasterPlayerWithGenericServiceIdResponseData:3983-4119](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerwithgenericserviceidresponsedata)

### MasterPlayerWithGoogleIdResponseData

Extends: `MasterPlayerWithUserIdResponseData`

Defines the response payload for MasterPlayerWithGoogleId.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `MasterPlayerWithUserIdResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `googleId` | `string` | yes | Google account identifier from the linked Google account. |

Reference links:

- [MasterPlayerModels.MasterPlayerWithUserIdResponseData:3983-4029](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerwithuseridresponsedata)

### GetPlayersWithGoogleResponseData

Defines the response payload for GetPlayersWithGoogle.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerWithGoogleIdResponseData>` | yes | _elementCls=MasterPlayerWithGoogleIdResponseData_ |

Reference links:

- [MasterPlayerModels.MasterPlayerWithGoogleIdResponseData:3983-4149](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerwithgoogleidresponsedata)

### MasterPlayerWithPlayerIdResponseData

Extends: `MasterPlayerWithUserIdResponseData`

Defines the response payload for MasterPlayerWithPlayerId.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `MasterPlayerWithUserIdResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `playerId` | `string` | yes | Google Play Game Service or Game Center player identifier. |

Reference links:

- [MasterPlayerModels.MasterPlayerWithUserIdResponseData:3983-4029](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerwithuseridresponsedata)

### GetPlayersWithGooglePlayGameServiceResponseData

Defines the response payload for GetPlayersWithGooglePlayGameService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerWithPlayerIdResponseData>` | yes | _elementCls=MasterPlayerWithPlayerIdResponseData_ |

Reference links:

- [MasterPlayerModels.MasterPlayerWithPlayerIdResponseData:3983-4179](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerwithplayeridresponsedata)

### GetPlayersWithGameCenterResponseData

Defines the response payload for GetPlayersWithGameCenter.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerWithPlayerIdResponseData>` | yes | _elementCls=MasterPlayerWithPlayerIdResponseData_ |

Reference links:

- [MasterPlayerModels.MasterPlayerWithPlayerIdResponseData:3983-4179](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerwithplayeridresponsedata)

### MasterPlayerLeaderboardResponseData

Extends: `MasterPlayerWithUserIdResponseData`

One leaderboard row for master-player ranking endpoints.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `MasterPlayerWithUserIdResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `position` | `int` | yes | Ranking position returned by the backend leaderboard implementation. |
| `backupValue` | `double?` | no | Optional archived score value from the last leaderboard backup. |

Reference links:

- [MasterPlayerModels.MasterPlayerWithUserIdResponseData:3983-4029](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerwithuseridresponsedata)

### MasterPlayerLogResponseData

Describes one statistics or currency change log entry.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | User identifier of the master player who owns this log entry. |
| `tsCreate` | `long` | yes | Timestamp when the change was recorded. |
| `log` | `string` | yes | Log message or label describing the operation that caused the change. |
| `key` | `string` | yes | Statistics or currency key that was changed. |
| `amount` | `double` | yes | Delta applied to the value in this operation. |
| `startValue` | `double` | yes | Value of the key before the change was applied. |
| `finalValue` | `double` | yes | Value of the key after the change was applied. |

### GetStatisticsLeaderboardResponseData

Returns a statistics leaderboard page plus its optional snapshot timestamp.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerLeaderboardResponseData>` | yes | _elementCls=MasterPlayerLeaderboardResponseData_ |
| `tsCreate` | `long?` | no | Snapshot timestamp used for this leaderboard page when returned by the backend. |

Reference links:

- [MasterPlayerModels.MasterPlayerLeaderboardResponseData:3983-4223](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerleaderboardresponsedata)

### GetCurrencyLeaderboardResponseData

Defines the response payload for GetCurrencyLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerLeaderboardResponseData>` | yes | _elementCls=MasterPlayerLeaderboardResponseData_ |

Reference links:

- [MasterPlayerModels.MasterPlayerLeaderboardResponseData:3983-4223](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerleaderboardresponsedata)

### GetCreateLeaderboardResponseData

Defines the response payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerLeaderboardResponseData>` | yes | _elementCls=MasterPlayerLeaderboardResponseData_ |

Reference links:

- [MasterPlayerModels.MasterPlayerLeaderboardResponseData:3983-4223](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerleaderboardresponsedata)

### GetLastLoginLeaderboardResponseData

Defines the response payload for GetLastLoginLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerLeaderboardResponseData>` | yes | _elementCls=MasterPlayerLeaderboardResponseData_ |

Reference links:

- [MasterPlayerModels.MasterPlayerLeaderboardResponseData:3983-4223](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerleaderboardresponsedata)

### GetCurrencyLeaderboardRequestData

Defines the request payload for GetCurrencyLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Reference links:

- [MasterPlayerModels.InfoRequestParam:11-40](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetCurrencyLeaderboardRequestData

Extends: `GetCurrencyLeaderboardRequestData`

Defines the request payload for ServerGetCurrencyLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCurrencyLeaderboardRequestData`._

Reference links:

- [MasterPlayerModels.GetCurrencyLeaderboardRequestData:4292-4308](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#getcurrencyleaderboardrequestdata)

### AdminGetCurrencyLeaderboardRequestData

Extends: `ServerGetCurrencyLeaderboardRequestData`

Defines the request payload for AdminGetCurrencyLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCurrencyLeaderboardRequestData`._

Reference links:

- [MasterPlayerModels.ServerGetCurrencyLeaderboardRequestData:4292-4320](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#servergetcurrencyleaderboardrequestdata)

### GetStatisticsLogResponseData

Returns one page of statistics logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerLogResponseData>` | yes | _elementCls=MasterPlayerLogResponseData_ |
| `token` | `string?` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

Reference links:

- [MasterPlayerModels.MasterPlayerLogResponseData:4224-4238](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerlogresponsedata)

### GetCurrencyLogResponseData

Returns one page of currency logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerLogResponseData>` | yes | _elementCls=MasterPlayerLogResponseData_ |
| `token` | `string?` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

Reference links:

- [MasterPlayerModels.MasterPlayerLogResponseData:4224-4238](/docs/reference/dto/master-player/MASTER_PLAYER_MODELS.md#masterplayerlogresponsedata)

### AddPushNotificationResponseData

Returns the backend-generated push endpoint ID.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `pushId` | `string` | yes | Backend-assigned push endpoint identifier for the newly registered device token. |

### SendPushNotificationResponseData

Returns the backend send status message for push-dispatch workflows.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `message` | `string` | yes | Status message returned by the backend after dispatching the push notification. |

### EmptyResponseData

Defines an intentionally empty response payload.

_Không có field public (payload rỗng)._
