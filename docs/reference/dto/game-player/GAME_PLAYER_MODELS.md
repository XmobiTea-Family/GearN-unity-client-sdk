### InfoRequestParam

Selects which optional game-player fields and lightweight relations should be returned. Boolean flags default to `false`; key arrays narrow list-style fields to specific keys only.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `segments` | `bool?` | no | _default=false_ |
| `customDatas` | `bool?` | no | _default=false_ |
| `displayName` | `bool?` | no | _default=false_ |
| `avatar` | `bool?` | no | _default=false_ |
| `tsCreate` | `bool?` | no | _default=false_ |
| `tags` | `bool?` | no | _default=false_ |
| `playerBan` | `bool?` | no | _default=false_ |
| `playerCurrencies` | `bool?` | no | _default=false_ |
| `playerStatistics` | `bool?` | no | _default=false_ |
| `playerDatas` | `bool?` | no | _default=false_ |
| `ipAddressCreate` | `bool?` | no | _default=false_ |
| `countryCode` | `bool?` | no | _default=false_ |
| `tsLastLogin` | `bool?` | no | _default=false_ |
| `playerCharacters` | `bool?` | no | Includes relation items for characters owned by the player, optionally filtered by `characterCatalogIds`. — _default=false_ |
| `playerInventories` | `bool?` | no | Includes relation items for inventory owned by the player, optionally filtered by `itemCatalogIds`. — _default=false_ |
| `playerGroups` | `bool?` | no | Includes relation items for groups joined or owned by the player, optionally filtered by `groupCatalogIds`. — _default=false_ |
| `playerFriends` | `bool?` | no | Includes relation items for friends attached to the player, optionally filtered by `friendCatalogIds`. — _default=false_ |
| `playerDataKeys` | `List<string>?` | no | _elementCls=String_ |
| `playerCurrencyKeys` | `List<string>?` | no | _elementCls=String_ |
| `playerStatisticsKeys` | `List<string>?` | no | _elementCls=String_ |
| `customDataKeys` | `List<string>?` | no | _elementCls=String_ |
| `tagKeys` | `List<string>?` | no | _elementCls=String_ |
| `characterCatalogIds` | `List<string>?` | no | Restricts `playerCharacters` to relation items whose catalog IDs match this list. — _elementCls=String_ |
| `itemCatalogIds` | `List<string>?` | no | Restricts `playerInventories` to relation items whose catalog IDs match this list. — _elementCls=String_ |
| `groupCatalogIds` | `List<string>?` | no | Restricts `playerGroups` to relation items whose catalog IDs match this list. — _elementCls=String_ |
| `friendCatalogIds` | `List<string>?` | no | Restricts `playerFriends` to relation items whose catalog IDs match this list. — _elementCls=String_ |

### CustomDataParam

Defines the reusable parameter block CustomDataParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `object` | yes | Arbitrary value to store for this custom data key. May be a primitive, `GNHashtable`, or `GNArray`. |

### GroupMemberParam

Describes one game-player member included when creating a group.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | _minLength=10, maxLength=10_ |

### PlayerCurrencyParam

Defines the reusable parameter block PlayerCurrencyParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
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

### AddPlayerFriendRequestData

Creates a friend relation between the current or target game player and another game player.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | Optional self-target shortcut on the client route. — _minLength=10, maxLength=10_ |
| `friendId` | `string` | yes | Target friend user ID. — _minLength=10, maxLength=10_ |
| `catalogId` | `string` | yes | Friend catalog used to create the relation record. — _minLength=2, maxLength=32_ |

### ServerAddPlayerFriendRequestData

Extends: `AddPlayerFriendRequestData`

Defines the request payload for ServerAddPlayerFriend.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `AddPlayerFriendRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.AddPlayerFriendRequestData:84-94](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#addplayerfriendrequestdata)

### AdminAddPlayerFriendRequestData

Extends: `ServerAddPlayerFriendRequestData`

Defines the request payload for AdminAddPlayerFriend.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerAddPlayerFriendRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.AddPlayerFriendRequestData:84-94](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#addplayerfriendrequestdata)
- [GamePlayerModels.ServerAddPlayerFriendRequestData:84-111](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serveraddplayerfriendrequestdata)

### AddSegmentRequestData

Defines the request payload for AddSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `value` | `string` | yes | _minLength=6, maxLength=32_ |

### ServerAddSegmentRequestData

Extends: `AddSegmentRequestData`

Defines the request payload for ServerAddSegment.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `AddSegmentRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.AddSegmentRequestData:130-139](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#addsegmentrequestdata)

### AdminAddSegmentRequestData

Extends: `ServerAddSegmentRequestData`

Defines the request payload for AdminAddSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerAddSegmentRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.AddSegmentRequestData:130-139](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#addsegmentrequestdata)
- [GamePlayerModels.ServerAddSegmentRequestData:130-156](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serveraddsegmentrequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetAvatarRequestData:175-183](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getavatarrequestdata)

### AdminGetAvatarRequestData

Extends: `ServerGetAvatarRequestData`

Defines the request payload for AdminGetAvatar.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetAvatarRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetAvatarRequestData:175-183](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getavatarrequestdata)
- [GamePlayerModels.ServerGetAvatarRequestData:175-200](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetavatarrequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetCountryCodeRequestData:219-227](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getcountrycoderequestdata)

### AdminGetCountryCodeRequestData

Extends: `ServerGetCountryCodeRequestData`

Defines the request payload for AdminGetCountryCode.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCountryCodeRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetCountryCodeRequestData:219-227](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getcountrycoderequestdata)
- [GamePlayerModels.ServerGetCountryCodeRequestData:219-244](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetcountrycoderequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetCustomDataRequestData:263-272](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getcustomdatarequestdata)

### AdminGetCustomDataRequestData

Extends: `ServerGetCustomDataRequestData`

Defines the request payload for AdminGetCustomData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCustomDataRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetCustomDataRequestData:263-272](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getcustomdatarequestdata)
- [GamePlayerModels.ServerGetCustomDataRequestData:263-289](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetcustomdatarequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetDisplayNameRequestData:308-316](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getdisplaynamerequestdata)

### AdminGetDisplayNameRequestData

Extends: `ServerGetDisplayNameRequestData`

Defines the request payload for AdminGetDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetDisplayNameRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetDisplayNameRequestData:308-316](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getdisplaynamerequestdata)
- [GamePlayerModels.ServerGetDisplayNameRequestData:308-333](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetdisplaynamerequestdata)

### GetFriendStatisticsLeaderboardAroundPlayerRequestData

Defines the request payload for GetFriendStatisticsLeaderboardAroundPlayer.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Reference links:

- [GamePlayerModels.InfoRequestParam:1-34](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#inforequestparam)

### ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData

Extends: `GetFriendStatisticsLeaderboardAroundPlayerRequestData`

Defines the request payload for ServerGetFriendStatisticsLeaderboardAroundPlayer.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetFriendStatisticsLeaderboardAroundPlayerRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData:352-369](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getfriendstatisticsleaderboardaroundplayerrequestdata)

### AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData

Extends: `ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData`

Defines the request payload for AdminGetFriendStatisticsLeaderboardAroundPlayer.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData:352-369](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getfriendstatisticsleaderboardaroundplayerrequestdata)
- [GamePlayerModels.ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData:352-386](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetfriendstatisticsleaderboardaroundplayerrequestdata)

### GetFriendStatisticsLeaderboardRequestData

Defines the request payload for GetFriendStatisticsLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Reference links:

- [GamePlayerModels.InfoRequestParam:1-34](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#inforequestparam)

### ServerGetFriendStatisticsLeaderboardRequestData

Extends: `GetFriendStatisticsLeaderboardRequestData`

Defines the request payload for ServerGetFriendStatisticsLeaderboard.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetFriendStatisticsLeaderboardRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetFriendStatisticsLeaderboardRequestData:405-422](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getfriendstatisticsleaderboardrequestdata)

### AdminGetFriendStatisticsLeaderboardRequestData

Extends: `ServerGetFriendStatisticsLeaderboardRequestData`

Defines the request payload for AdminGetFriendStatisticsLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetFriendStatisticsLeaderboardRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetFriendStatisticsLeaderboardRequestData:405-422](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getfriendstatisticsleaderboardrequestdata)
- [GamePlayerModels.ServerGetFriendStatisticsLeaderboardRequestData:405-439](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetfriendstatisticsleaderboardrequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetIpAddressCreateRequestData:458-466](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getipaddresscreaterequestdata)

### AdminGetIpAddressCreateRequestData

Extends: `ServerGetIpAddressCreateRequestData`

Defines the request payload for AdminGetIpAddressCreate.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetIpAddressCreateRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetIpAddressCreateRequestData:458-466](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getipaddresscreaterequestdata)
- [GamePlayerModels.ServerGetIpAddressCreateRequestData:458-483](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetipaddresscreaterequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetPlayerBanRequestData:502-510](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerbanrequestdata)

### AdminGetPlayerBanRequestData

Extends: `ServerGetPlayerBanRequestData`

Defines the request payload for AdminGetPlayerBan.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerBanRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetPlayerBanRequestData:502-510](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerbanrequestdata)
- [GamePlayerModels.ServerGetPlayerBanRequestData:502-527](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetplayerbanrequestdata)

### GetPlayerCharacterRequestData

Defines the request payload for GetPlayerCharacter.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `characterCatalogIds` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerCharacterRequestData

Extends: `GetPlayerCharacterRequestData`

Defines the request payload for ServerGetPlayerCharacter.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetPlayerCharacterRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetPlayerCharacterRequestData:546-555](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayercharacterrequestdata)

### AdminGetPlayerCharacterRequestData

Extends: `ServerGetPlayerCharacterRequestData`

Defines the request payload for AdminGetPlayerCharacter.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerCharacterRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetPlayerCharacterRequestData:546-555](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayercharacterrequestdata)
- [GamePlayerModels.ServerGetPlayerCharacterRequestData:546-572](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetplayercharacterrequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetPlayerCurrencyRequestData:591-600](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayercurrencyrequestdata)

### AdminGetPlayerCurrencyRequestData

Extends: `ServerGetPlayerCurrencyRequestData`

Defines the request payload for AdminGetPlayerCurrency.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerCurrencyRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetPlayerCurrencyRequestData:591-600](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayercurrencyrequestdata)
- [GamePlayerModels.ServerGetPlayerCurrencyRequestData:591-617](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetplayercurrencyrequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetPlayerDataRequestData:636-645](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerdatarequestdata)

### AdminGetPlayerDataRequestData

Extends: `ServerGetPlayerDataRequestData`

Defines the request payload for AdminGetPlayerData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerDataRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetPlayerDataRequestData:636-645](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerdatarequestdata)
- [GamePlayerModels.ServerGetPlayerDataRequestData:636-662](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetplayerdatarequestdata)

### GetPlayerFriendRequestData

Defines the request payload for GetPlayerFriend.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `friendCatalogIds` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerFriendRequestData

Extends: `GetPlayerFriendRequestData`

Defines the request payload for ServerGetPlayerFriend.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetPlayerFriendRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetPlayerFriendRequestData:681-690](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerfriendrequestdata)

### AdminGetPlayerFriendRequestData

Extends: `ServerGetPlayerFriendRequestData`

Defines the request payload for AdminGetPlayerFriend.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerFriendRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetPlayerFriendRequestData:681-690](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerfriendrequestdata)
- [GamePlayerModels.ServerGetPlayerFriendRequestData:681-707](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetplayerfriendrequestdata)

### GetPlayerGroupRequestData

Defines the request payload for GetPlayerGroup.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `groupCatalogIds` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerGroupRequestData

Extends: `GetPlayerGroupRequestData`

Defines the request payload for ServerGetPlayerGroup.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetPlayerGroupRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetPlayerGroupRequestData:726-735](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayergrouprequestdata)

### AdminGetPlayerGroupRequestData

Extends: `ServerGetPlayerGroupRequestData`

Defines the request payload for AdminGetPlayerGroup.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerGroupRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetPlayerGroupRequestData:726-735](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayergrouprequestdata)
- [GamePlayerModels.ServerGetPlayerGroupRequestData:726-752](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetplayergrouprequestdata)

### GetPlayerInformationRequestData

Reads the current or target game-player profile using the requested projection. On the client route, omit `userId` to target the authenticated player itself.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | Optional self-target shortcut on the client route. — _minLength=10, maxLength=10_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Required field projection that controls which optional data is returned. |

Reference links:

- [GamePlayerModels.InfoRequestParam:1-34](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayerInformationRequestData

Extends: `GetPlayerInformationRequestData`

Reads a specific target game player on a trusted route.

_Bảng dưới liệt kê field khai báo lại/thêm mới; trong đó `userId` được đổi Required từ `no` sang `yes`. Các field còn lại kế thừa từ `GetPlayerInformationRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |
| `createPlayerIfNotExists` | `bool?` | no | Allows the backend to create the missing game-player record before returning it. — _default=false_ |

Reference links:

- [GamePlayerModels.GetPlayerInformationRequestData:771-784](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerinformationrequestdata)

### AdminGetPlayerInformationRequestData

Extends: `ServerGetPlayerInformationRequestData`

Defines the request payload for AdminGetPlayerInformation.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerInformationRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetPlayerInformationRequestData:771-784](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerinformationrequestdata)
- [GamePlayerModels.ServerGetPlayerInformationRequestData:771-802](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetplayerinformationrequestdata)

### GetPlayerInventoryRequestData

Defines the request payload for GetPlayerInventory.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `itemCatalogIds` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerInventoryRequestData

Extends: `GetPlayerInventoryRequestData`

Defines the request payload for ServerGetPlayerInventory.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetPlayerInventoryRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetPlayerInventoryRequestData:821-830](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerinventoryrequestdata)

### AdminGetPlayerInventoryRequestData

Extends: `ServerGetPlayerInventoryRequestData`

Defines the request payload for AdminGetPlayerInventory.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerInventoryRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetPlayerInventoryRequestData:821-830](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerinventoryrequestdata)
- [GamePlayerModels.ServerGetPlayerInventoryRequestData:821-847](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetplayerinventoryrequestdata)

### GetPlayerStatisticsRequestData

Defines the request payload for GetPlayerStatistics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `statisticsKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerStatisticsRequestData

Extends: `GetPlayerStatisticsRequestData`

Defines the request payload for ServerGetPlayerStatistics.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetPlayerStatisticsRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetPlayerStatisticsRequestData:866-875](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerstatisticsrequestdata)

### AdminGetPlayerStatisticsRequestData

Extends: `ServerGetPlayerStatisticsRequestData`

Defines the request payload for AdminGetPlayerStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerStatisticsRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetPlayerStatisticsRequestData:866-875](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerstatisticsrequestdata)
- [GamePlayerModels.ServerGetPlayerStatisticsRequestData:866-892](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetplayerstatisticsrequestdata)

### GetPlayersWithDisplayNameRequestData

Defines the request payload for GetPlayersWithDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keyword` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

Reference links:

- [GamePlayerModels.InfoRequestParam:1-34](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayersWithDisplayNameRequestData

Extends: `GetPlayersWithDisplayNameRequestData`

Defines the request payload for ServerGetPlayersWithDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayersWithDisplayNameRequestData`._

Reference links:

- [GamePlayerModels.GetPlayersWithDisplayNameRequestData:911-926](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerswithdisplaynamerequestdata)

### AdminGetPlayersWithDisplayNameRequestData

Extends: `ServerGetPlayersWithDisplayNameRequestData`

Defines the request payload for AdminGetPlayersWithDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayersWithDisplayNameRequestData`._

Reference links:

- [GamePlayerModels.GetPlayersWithDisplayNameRequestData:911-926](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerswithdisplaynamerequestdata)
- [GamePlayerModels.ServerGetPlayersWithDisplayNameRequestData:911-938](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetplayerswithdisplaynamerequestdata)

### GetPlayersWithSegmentRequestData

Defines the request payload for GetPlayersWithSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

Reference links:

- [GamePlayerModels.InfoRequestParam:1-34](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayersWithSegmentRequestData

Extends: `GetPlayersWithSegmentRequestData`

Defines the request payload for ServerGetPlayersWithSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayersWithSegmentRequestData`._

Reference links:

- [GamePlayerModels.GetPlayersWithSegmentRequestData:952-967](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerswithsegmentrequestdata)

### AdminGetPlayersWithSegmentRequestData

Extends: `ServerGetPlayersWithSegmentRequestData`

Defines the request payload for AdminGetPlayersWithSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayersWithSegmentRequestData`._

Reference links:

- [GamePlayerModels.GetPlayersWithSegmentRequestData:952-967](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerswithsegmentrequestdata)
- [GamePlayerModels.ServerGetPlayersWithSegmentRequestData:952-979](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetplayerswithsegmentrequestdata)

### GetPlayersWithTagRequestData

Defines the request payload for GetPlayersWithTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

Reference links:

- [GamePlayerModels.InfoRequestParam:1-34](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayersWithTagRequestData

Extends: `GetPlayersWithTagRequestData`

Defines the request payload for ServerGetPlayersWithTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayersWithTagRequestData`._

Reference links:

- [GamePlayerModels.GetPlayersWithTagRequestData:993-1009](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerswithtagrequestdata)

### AdminGetPlayersWithTagRequestData

Extends: `ServerGetPlayersWithTagRequestData`

Defines the request payload for AdminGetPlayersWithTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayersWithTagRequestData`._

Reference links:

- [GamePlayerModels.GetPlayersWithTagRequestData:993-1009](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getplayerswithtagrequestdata)
- [GamePlayerModels.ServerGetPlayersWithTagRequestData:993-1021](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetplayerswithtagrequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetSegmentRequestData:1035-1043](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getsegmentrequestdata)

### AdminGetSegmentRequestData

Extends: `ServerGetSegmentRequestData`

Defines the request payload for AdminGetSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetSegmentRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetSegmentRequestData:1035-1043](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getsegmentrequestdata)
- [GamePlayerModels.ServerGetSegmentRequestData:1035-1060](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetsegmentrequestdata)

### GetStatisticsLeaderboardAroundPlayerRequestData

Defines the request payload for GetStatisticsLeaderboardAroundPlayer.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Reference links:

- [GamePlayerModels.InfoRequestParam:1-34](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#inforequestparam)

### ServerGetStatisticsLeaderboardAroundPlayerRequestData

Extends: `GetStatisticsLeaderboardAroundPlayerRequestData`

Defines the request payload for ServerGetStatisticsLeaderboardAroundPlayer.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `GetStatisticsLeaderboardAroundPlayerRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData:1079-1096](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getstatisticsleaderboardaroundplayerrequestdata)

### AdminGetStatisticsLeaderboardAroundPlayerRequestData

Extends: `ServerGetStatisticsLeaderboardAroundPlayerRequestData`

Defines the request payload for AdminGetStatisticsLeaderboardAroundPlayer.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStatisticsLeaderboardAroundPlayerRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData:1079-1096](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getstatisticsleaderboardaroundplayerrequestdata)
- [GamePlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData:1079-1113](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetstatisticsleaderboardaroundplayerrequestdata)

### GetStatisticsLeaderboardRequestData

Defines the request payload for GetStatisticsLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |
| `version` | `string?` | no | _minLength=2, maxLength=32_ |

Reference links:

- [GamePlayerModels.InfoRequestParam:1-34](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#inforequestparam)

### ServerGetStatisticsLeaderboardRequestData

Extends: `GetStatisticsLeaderboardRequestData`

Defines the request payload for ServerGetStatisticsLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetStatisticsLeaderboardRequestData`._

Reference links:

- [GamePlayerModels.GetStatisticsLeaderboardRequestData:1132-1149](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getstatisticsleaderboardrequestdata)

### AdminGetStatisticsLeaderboardRequestData

Extends: `ServerGetStatisticsLeaderboardRequestData`

Defines the request payload for AdminGetStatisticsLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStatisticsLeaderboardRequestData`._

Reference links:

- [GamePlayerModels.GetStatisticsLeaderboardRequestData:1132-1149](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getstatisticsleaderboardrequestdata)
- [GamePlayerModels.ServerGetStatisticsLeaderboardRequestData:1132-1161](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetstatisticsleaderboardrequestdata)

### GetCreateLeaderboardRequestData

Defines the request payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Reference links:

- [GamePlayerModels.InfoRequestParam:1-34](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#inforequestparam)

### ServerGetCreateLeaderboardRequestData

Extends: `GetCreateLeaderboardRequestData`

Defines the request payload for ServerGetCreateLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCreateLeaderboardRequestData`._

Reference links:

- [GamePlayerModels.GetCreateLeaderboardRequestData:1175-1190](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getcreateleaderboardrequestdata)

### AdminGetCreateLeaderboardRequestData

Extends: `ServerGetCreateLeaderboardRequestData`

Defines the request payload for AdminGetCreateLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCreateLeaderboardRequestData`._

Reference links:

- [GamePlayerModels.GetCreateLeaderboardRequestData:1175-1190](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getcreateleaderboardrequestdata)
- [GamePlayerModels.ServerGetCreateLeaderboardRequestData:1175-1202](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetcreateleaderboardrequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetTagRequestData:1216-1225](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#gettagrequestdata)

### AdminGetTagRequestData

Extends: `ServerGetTagRequestData`

Defines the request payload for AdminGetTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetTagRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetTagRequestData:1216-1225](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#gettagrequestdata)
- [GamePlayerModels.ServerGetTagRequestData:1216-1242](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergettagrequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetTsCreateRequestData:1261-1269](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#gettscreaterequestdata)

### AdminGetTsCreateRequestData

Extends: `ServerGetTsCreateRequestData`

Defines the request payload for AdminGetTsCreate.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetTsCreateRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetTsCreateRequestData:1261-1269](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#gettscreaterequestdata)
- [GamePlayerModels.ServerGetTsCreateRequestData:1261-1286](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergettscreaterequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetTsLastLoginRequestData:1305-1313](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#gettslastloginrequestdata)

### AdminGetTsLastLoginRequestData

Extends: `ServerGetTsLastLoginRequestData`

Defines the request payload for AdminGetTsLastLogin.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetTsLastLoginRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.GetTsLastLoginRequestData:1305-1313](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#gettslastloginrequestdata)
- [GamePlayerModels.ServerGetTsLastLoginRequestData:1305-1330](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergettslastloginrequestdata)

### CreateGroupRequestData

Creates a group owned by or attached to the current or target game player.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `catalogId` | `string` | yes | _minLength=2, maxLength=32_ |
| `groupMembers` | `List<GroupMemberParam>?` | no | Additional game-player members expressed as user IDs, not character IDs. — _elementCls=GroupMemberParam_ |
| `displayName` | `string?` | no | _default=""_ |

Reference links:

- [GamePlayerModels.GroupMemberParam:45-53](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#groupmemberparam)

### ServerCreateGroupRequestData

Extends: `CreateGroupRequestData`

Defines the request payload for ServerCreateGroup.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `CreateGroupRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.CreateGroupRequestData:1349-1364](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#creategrouprequestdata)

### AdminCreateGroupRequestData

Extends: `ServerCreateGroupRequestData`

Defines the request payload for AdminCreateGroup.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerCreateGroupRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.CreateGroupRequestData:1349-1364](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#creategrouprequestdata)
- [GamePlayerModels.ServerCreateGroupRequestData:1349-1381](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servercreategrouprequestdata)

### CreatePlayerCharacterRequestData

Defines the request payload for CreatePlayerCharacter.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `catalogId` | `string` | yes | _minLength=2, maxLength=32_ |
| `displayName` | `string?` | no | _default=""_ |
| `uniqueDisplayName` | `bool?` | no | _default=false_ |

### ServerCreatePlayerCharacterRequestData

Extends: `CreatePlayerCharacterRequestData`

Defines the request payload for ServerCreatePlayerCharacter.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `CreatePlayerCharacterRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.CreatePlayerCharacterRequestData:1400-1411](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#createplayercharacterrequestdata)

### AdminCreatePlayerCharacterRequestData

Extends: `ServerCreatePlayerCharacterRequestData`

Defines the request payload for AdminCreatePlayerCharacter.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerCreatePlayerCharacterRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.CreatePlayerCharacterRequestData:1400-1411](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#createplayercharacterrequestdata)
- [GamePlayerModels.ServerCreatePlayerCharacterRequestData:1400-1428](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servercreateplayercharacterrequestdata)

### CreatePlayerItemRequestData

Defines the request payload for CreatePlayerItem.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `catalogId` | `string` | yes | _minLength=2, maxLength=32_ |
| `classId` | `string` | yes | _minLength=2, maxLength=32_ |
| `displayName` | `string?` | no | _default=""_ |
| `amount` | `int?` | no | _default=1_ |

### ServerCreatePlayerItemRequestData

Extends: `CreatePlayerItemRequestData`

Defines the request payload for ServerCreatePlayerItem.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `CreatePlayerItemRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.CreatePlayerItemRequestData:1447-1459](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#createplayeritemrequestdata)

### AdminCreatePlayerItemRequestData

Extends: `ServerCreatePlayerItemRequestData`

Defines the request payload for AdminCreatePlayerItem.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerCreatePlayerItemRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.CreatePlayerItemRequestData:1447-1459](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#createplayeritemrequestdata)
- [GamePlayerModels.ServerCreatePlayerItemRequestData:1447-1476](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servercreateplayeritemrequestdata)

### JoinGroupRequestData

Defines the request payload for JoinGroup.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerJoinGroupRequestData

Extends: `JoinGroupRequestData`

Defines the request payload for ServerJoinGroup.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `JoinGroupRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.JoinGroupRequestData:1495-1504](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#joingrouprequestdata)

### AdminJoinGroupRequestData

Extends: `ServerJoinGroupRequestData`

Defines the request payload for AdminJoinGroup.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerJoinGroupRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.JoinGroupRequestData:1495-1504](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#joingrouprequestdata)
- [GamePlayerModels.ServerJoinGroupRequestData:1495-1521](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serverjoingrouprequestdata)

### LeaveGroupRequestData

Defines the request payload for LeaveGroup.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerLeaveGroupRequestData

Extends: `LeaveGroupRequestData`

Defines the request payload for ServerLeaveGroup.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `LeaveGroupRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.LeaveGroupRequestData:1540-1549](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#leavegrouprequestdata)

### AdminLeaveGroupRequestData

Extends: `ServerLeaveGroupRequestData`

Defines the request payload for AdminLeaveGroup.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLeaveGroupRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.LeaveGroupRequestData:1540-1549](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#leavegrouprequestdata)
- [GamePlayerModels.ServerLeaveGroupRequestData:1540-1566](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serverleavegrouprequestdata)

### RemovePlayerCharacterRequestData

Defines the request payload for RemovePlayerCharacter.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |

### ServerRemovePlayerCharacterRequestData

Extends: `RemovePlayerCharacterRequestData`

Defines the request payload for ServerRemovePlayerCharacter.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `RemovePlayerCharacterRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.RemovePlayerCharacterRequestData:1585-1594](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#removeplayercharacterrequestdata)

### AdminRemovePlayerCharacterRequestData

Extends: `ServerRemovePlayerCharacterRequestData`

Defines the request payload for AdminRemovePlayerCharacter.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemovePlayerCharacterRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.RemovePlayerCharacterRequestData:1585-1594](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#removeplayercharacterrequestdata)
- [GamePlayerModels.ServerRemovePlayerCharacterRequestData:1585-1611](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serverremoveplayercharacterrequestdata)

### RemovePlayerFriendRequestData

Defines the request payload for RemovePlayerFriend.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `friendId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerRemovePlayerFriendRequestData

Extends: `RemovePlayerFriendRequestData`

Defines the request payload for ServerRemovePlayerFriend.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `RemovePlayerFriendRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.RemovePlayerFriendRequestData:1630-1639](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#removeplayerfriendrequestdata)

### AdminRemovePlayerFriendRequestData

Extends: `ServerRemovePlayerFriendRequestData`

Defines the request payload for AdminRemovePlayerFriend.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemovePlayerFriendRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.RemovePlayerFriendRequestData:1630-1639](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#removeplayerfriendrequestdata)
- [GamePlayerModels.ServerRemovePlayerFriendRequestData:1630-1656](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serverremoveplayerfriendrequestdata)

### RemovePlayerItemRequestData

Defines the request payload for RemovePlayerItem.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerRemovePlayerItemRequestData

Extends: `RemovePlayerItemRequestData`

Defines the request payload for ServerRemovePlayerItem.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `RemovePlayerItemRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.RemovePlayerItemRequestData:1675-1684](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#removeplayeritemrequestdata)

### AdminRemovePlayerItemRequestData

Extends: `ServerRemovePlayerItemRequestData`

Defines the request payload for AdminRemovePlayerItem.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemovePlayerItemRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.RemovePlayerItemRequestData:1675-1684](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#removeplayeritemrequestdata)
- [GamePlayerModels.ServerRemovePlayerItemRequestData:1675-1701](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serverremoveplayeritemrequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.RemoveSegmentRequestData:1720-1729](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#removesegmentrequestdata)

### AdminRemoveSegmentRequestData

Extends: `ServerRemoveSegmentRequestData`

Defines the request payload for AdminRemoveSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemoveSegmentRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.RemoveSegmentRequestData:1720-1729](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#removesegmentrequestdata)
- [GamePlayerModels.ServerRemoveSegmentRequestData:1720-1746](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serverremovesegmentrequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.RemoveTagRequestData:1765-1774](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#removetagrequestdata)

### AdminRemoveTagRequestData

Extends: `ServerRemoveTagRequestData`

Defines the request payload for AdminRemoveTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemoveTagRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.RemoveTagRequestData:1765-1774](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#removetagrequestdata)
- [GamePlayerModels.ServerRemoveTagRequestData:1765-1791](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serverremovetagrequestdata)

### SetAvatarRequestData

Defines the request payload for SetAvatar.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `type` | `int` | yes | App-defined avatar type integer; not mapped to a built-in GearN enum. |
| `value` | `string` | yes | Avatar value such as a URL, file ID, or provider-specific string. — _minLength=1, maxLength=128_ |

### ServerSetAvatarRequestData

Extends: `SetAvatarRequestData`

Defines the request payload for ServerSetAvatar.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `SetAvatarRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.SetAvatarRequestData:1810-1820](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#setavatarrequestdata)

### AdminSetAvatarRequestData

Extends: `ServerSetAvatarRequestData`

Defines the request payload for AdminSetAvatar.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetAvatarRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.SetAvatarRequestData:1810-1820](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#setavatarrequestdata)
- [GamePlayerModels.ServerSetAvatarRequestData:1810-1837](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serversetavatarrequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.SetCountryCodeRequestData:1856-1865](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#setcountrycoderequestdata)

### AdminSetCountryCodeRequestData

Extends: `ServerSetCountryCodeRequestData`

Defines the request payload for AdminSetCountryCode.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetCountryCodeRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.SetCountryCodeRequestData:1856-1865](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#setcountrycoderequestdata)
- [GamePlayerModels.ServerSetCountryCodeRequestData:1856-1882](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serversetcountrycoderequestdata)

### SetCustomDataRequestData

Defines the request payload for SetCustomData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `customDatas` | `List<CustomDataParam>` | yes | _minLength=1, maxLength=32, elementCls=CustomDataParam_ |

Reference links:

- [GamePlayerModels.CustomDataParam:35-44](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#customdataparam)

### ServerSetCustomDataRequestData

Extends: `SetCustomDataRequestData`

Defines the request payload for ServerSetCustomData.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `SetCustomDataRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.SetCustomDataRequestData:1901-1914](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#setcustomdatarequestdata)

### AdminSetCustomDataRequestData

Extends: `ServerSetCustomDataRequestData`

Defines the request payload for AdminSetCustomData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetCustomDataRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.SetCustomDataRequestData:1901-1914](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#setcustomdatarequestdata)
- [GamePlayerModels.ServerSetCustomDataRequestData:1901-1931](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serversetcustomdatarequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.SetDisplayNameRequestData:1950-1960](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#setdisplaynamerequestdata)

### AdminSetDisplayNameRequestData

Extends: `ServerSetDisplayNameRequestData`

Defines the request payload for AdminSetDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetDisplayNameRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.SetDisplayNameRequestData:1950-1960](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#setdisplaynamerequestdata)
- [GamePlayerModels.ServerSetDisplayNameRequestData:1950-1977](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serversetdisplaynamerequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.SetPlayerBanRequestData:1996-2006](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#setplayerbanrequestdata)

### AdminSetPlayerBanRequestData

Extends: `ServerSetPlayerBanRequestData`

Defines the request payload for AdminSetPlayerBan.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetPlayerBanRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.SetPlayerBanRequestData:1996-2006](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#setplayerbanrequestdata)
- [GamePlayerModels.ServerSetPlayerBanRequestData:1996-2023](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serversetplayerbanrequestdata)

### ChangePlayerCurrencyRequestData

Defines the request payload for ChangePlayerCurrency.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerCurrencies` | `List<PlayerCurrencyParam>` | yes | _minLength=1, maxLength=32, elementCls=PlayerCurrencyParam_ |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

Reference links:

- [GamePlayerModels.PlayerCurrencyParam:54-63](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#playercurrencyparam)

### ServerChangePlayerCurrencyRequestData

Extends: `ChangePlayerCurrencyRequestData`

Defines the request payload for ServerChangePlayerCurrency.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `ChangePlayerCurrencyRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.ChangePlayerCurrencyRequestData:2042-2056](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#changeplayercurrencyrequestdata)

### AdminChangePlayerCurrencyRequestData

Extends: `ServerChangePlayerCurrencyRequestData`

Defines the request payload for AdminChangePlayerCurrency.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerChangePlayerCurrencyRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.ChangePlayerCurrencyRequestData:2042-2056](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#changeplayercurrencyrequestdata)
- [GamePlayerModels.ServerChangePlayerCurrencyRequestData:2042-2073](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serverchangeplayercurrencyrequestdata)

### SetPlayerDataRequestData

Defines the request payload for SetPlayerData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerDatas` | `List<PlayerDataParam>` | yes | _minLength=1, maxLength=32, elementCls=PlayerDataParam_ |

Reference links:

- [GamePlayerModels.PlayerDataParam:64-73](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#playerdataparam)

### ServerSetPlayerDataRequestData

Extends: `SetPlayerDataRequestData`

Defines the request payload for ServerSetPlayerData.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `SetPlayerDataRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.SetPlayerDataRequestData:2092-2105](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#setplayerdatarequestdata)

### AdminSetPlayerDataRequestData

Extends: `ServerSetPlayerDataRequestData`

Defines the request payload for AdminSetPlayerData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetPlayerDataRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.SetPlayerDataRequestData:2092-2105](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#setplayerdatarequestdata)
- [GamePlayerModels.ServerSetPlayerDataRequestData:2092-2122](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serversetplayerdatarequestdata)

### ChangePlayerStatisticsRequestData

Defines the request payload for ChangePlayerStatistics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerStatistics` | `List<PlayerStatisticsParam>` | yes | _minLength=1, maxLength=32, elementCls=PlayerStatisticsParam_ |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

Reference links:

- [GamePlayerModels.PlayerStatisticsParam:74-83](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#playerstatisticsparam)

### ServerChangePlayerStatisticsRequestData

Extends: `ChangePlayerStatisticsRequestData`

Defines the request payload for ServerChangePlayerStatistics.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `ChangePlayerStatisticsRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.ChangePlayerStatisticsRequestData:2141-2155](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#changeplayerstatisticsrequestdata)

### AdminChangePlayerStatisticsRequestData

Extends: `ServerChangePlayerStatisticsRequestData`

Defines the request payload for AdminChangePlayerStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerChangePlayerStatisticsRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.ChangePlayerStatisticsRequestData:2141-2155](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#changeplayerstatisticsrequestdata)
- [GamePlayerModels.ServerChangePlayerStatisticsRequestData:2141-2172](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serverchangeplayerstatisticsrequestdata)

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
| `userId` | `string` | yes | Target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.SetTagRequestData:2191-2201](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#settagrequestdata)

### AdminSetTagRequestData

Extends: `ServerSetTagRequestData`

Defines the request payload for AdminSetTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetTagRequestData` (bao gồm `userId` required)._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Inherited target game-player user ID. — _minLength=10, maxLength=10_ |

Reference links:

- [GamePlayerModels.SetTagRequestData:2191-2201](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#settagrequestdata)
- [GamePlayerModels.ServerSetTagRequestData:2191-2218](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#serversettagrequestdata)

### GetCurrencyLogRequestData

Reads currency change logs for the current or target game player. Pagination is token-based rather than skip-based.

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

- [GamePlayerModels.GetCurrencyLogRequestData:2237-2248](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getcurrencylogrequestdata)

### AdminGetCurrencyLogRequestData

Extends: `ServerGetCurrencyLogRequestData`

Defines the request payload for AdminGetCurrencyLog.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCurrencyLogRequestData`._

Reference links:

- [GamePlayerModels.GetCurrencyLogRequestData:2237-2248](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getcurrencylogrequestdata)
- [GamePlayerModels.ServerGetCurrencyLogRequestData:2237-2260](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetcurrencylogrequestdata)

### GetStatisticsLogRequestData

Reads statistic change logs for the current or target game player. Pagination is token-based rather than skip-based.

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

- [GamePlayerModels.GetStatisticsLogRequestData:2274-2285](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getstatisticslogrequestdata)

### AdminGetStatisticsLogRequestData

Extends: `ServerGetStatisticsLogRequestData`

Defines the request payload for AdminGetStatisticsLog.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStatisticsLogRequestData`._

Reference links:

- [GamePlayerModels.GetStatisticsLogRequestData:2274-2285](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getstatisticslogrequestdata)
- [GamePlayerModels.ServerGetStatisticsLogRequestData:2274-2297](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetstatisticslogrequestdata)

### InfoResponseParameters

Contains the optional fields requested through `InfoRequestParam`.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `segments` | `List<string>?` | no | Segment names currently assigned to the player. — _elementCls=String_ |
| `customDatas` | `List<GenericModels.DataItem>?` | no | Custom data entries; present when `customDatas` is enabled in `InfoRequestParam`. — _elementCls=GenericModels.DataItem_ |
| `displayName` | `string?` | no | Display name of the player; present when requested. |
| `avatar` | `GenericModels.AvatarItem?` | no | Avatar descriptor; present when requested. |
| `tsCreate` | `long?` | no | Creation timestamp of the player account; present when requested. |
| `tags` | `List<GenericModels.TagItem>?` | no | Tag entries assigned to the player. — _elementCls=GenericModels.TagItem_ |
| `playerBan` | `GenericModels.BanItem?` | no | Ban state of the player; present when requested and a ban exists. |
| `playerDatas` | `List<GenericModels.DataItem>?` | no | Player data entries; present when `playerDatas` is enabled in `InfoRequestParam`. — _elementCls=GenericModels.DataItem_ |
| `playerCurrencies` | `List<GenericModels.CurrencyItem>?` | no | Currency balances; present when `playerCurrencies` is enabled. — _elementCls=GenericModels.CurrencyItem_ |
| `playerStatistics` | `List<GenericModels.StatisticsItem>?` | no | Statistics values; present when `playerStatistics` is enabled. — _elementCls=GenericModels.StatisticsItem_ |
| `playerCharacters` | `List<GenericModels.CharacterItem>?` | no | Lightweight relation items for owned character players, not full character snapshots. — _elementCls=GenericModels.CharacterItem_ |
| `playerInventories` | `List<GenericModels.InventoryItem>?` | no | Lightweight relation items for inventory owned by the player. — _elementCls=GenericModels.InventoryItem_ |
| `playerGroups` | `List<GenericModels.GroupItem>?` | no | Lightweight relation items for groups attached to the player. — _elementCls=GenericModels.GroupItem_ |
| `playerFriends` | `List<GenericModels.FriendItem>?` | no | Lightweight relation items for friends attached to the player. — _elementCls=GenericModels.FriendItem_ |
| `tsLastLogin` | `long?` | no | Timestamp of the player's last login; present when requested. |
| `ipAddressCreate` | `string?` | no | IP address recorded at account creation; present when requested. |
| `countryCode` | `string?` | no | Country code associated with the player; present when requested. |

Reference links:

- [GamePlayerModels.InfoRequestParam:1-34](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#inforequestparam)
- [Generic.DataItem:31-40](/docs/reference/dto/generic/GENERIC_MODELS.md#dataitem)
- [Generic.AvatarItem:1-10](/docs/reference/dto/generic/GENERIC_MODELS.md#avataritem)
- [Generic.TagItem:11-20](/docs/reference/dto/generic/GENERIC_MODELS.md#tagitem)
- [Generic.BanItem:21-30](/docs/reference/dto/generic/GENERIC_MODELS.md#banitem)
- [Generic.CurrencyItem:41-50](/docs/reference/dto/generic/GENERIC_MODELS.md#currencyitem)
- [Generic.StatisticsItem:51-60](/docs/reference/dto/generic/GENERIC_MODELS.md#statisticsitem)
- [Generic.CharacterItem:61-70](/docs/reference/dto/generic/GENERIC_MODELS.md#characteritem)
- [Generic.InventoryItem:91-101](/docs/reference/dto/generic/GENERIC_MODELS.md#inventoryitem)
- [Generic.GroupItem:102-113](/docs/reference/dto/generic/GENERIC_MODELS.md#groupitem)
- [Generic.FriendItem:114-125](/docs/reference/dto/generic/GENERIC_MODELS.md#frienditem)

### GamePlayerResponseData

Base game-player response envelope.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoResponseParameters` | `InfoResponseParameters` | yes | Optional field bag controlled by the corresponding `InfoRequestParam`. |

Reference links:

- [GamePlayerModels.InfoResponseParameters:2311-2349](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#inforesponseparameters)
- [GamePlayerModels.InfoRequestParam:1-34](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#inforequestparam)

### GamePlayerWithUserIdResponseData

Extends: `GamePlayerResponseData`

Game-player envelope that also exposes the resolved game-player user ID.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `GamePlayerResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Game-player user identifier. |

Reference links:

- [GamePlayerModels.GamePlayerResponseData:2350-2363](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#gameplayerresponsedata)

### GamePlayerLeaderboardResponseData

Extends: `GamePlayerWithUserIdResponseData`

Defines the response payload for GamePlayerLeaderboard.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `GamePlayerWithUserIdResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `position` | `int` | yes | Zero-based leaderboard rank position of this player. |
| `backupValue` | `double?` | no | Backup statistic or currency value used as a tiebreaker when present. |

Reference links:

- [GamePlayerModels.GamePlayerResponseData:2350-2363](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#gameplayerresponsedata)
- [GamePlayerModels.GamePlayerWithUserIdResponseData:2350-2380](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#gameplayerwithuseridresponsedata)

### GamePlayerLogResponseData

Defines the response payload for GamePlayerLog.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Game-player user ID this log entry belongs to. |
| `tsCreate` | `long` | yes | Timestamp when this log entry was recorded. |
| `log` | `string` | yes | Human-readable log message describing the change. |
| `key` | `string` | yes | Currency or statistics key that was changed. |
| `amount` | `double` | yes | Delta amount applied in this change. |
| `startValue` | `double` | yes | Value before the change was applied. |
| `finalValue` | `double` | yes | Value after the change was applied. |

### GetStatisticsLeaderboardResponseData

Defines the response payload for GetStatisticsLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GamePlayerLeaderboardResponseData>` | yes | Ordered list of game-player leaderboard entries. — _elementCls=GamePlayerLeaderboardResponseData_ |
| `tsCreate` | `long?` | no | Timestamp when this leaderboard snapshot was last generated; present when available. |

Reference links:

- [GamePlayerModels.GamePlayerLeaderboardResponseData:2350-2399](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#gameplayerleaderboardresponsedata)

### GetCurrencyLeaderboardResponseData

Defines the response payload for GetCurrencyLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GamePlayerLeaderboardResponseData>` | yes | _elementCls=GamePlayerLeaderboardResponseData_ |

Reference links:

- [GamePlayerModels.GamePlayerLeaderboardResponseData:2350-2399](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#gameplayerleaderboardresponsedata)

### GetLastLoginLeaderboardResponseData

Defines the response payload for GetLastLoginLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GamePlayerLeaderboardResponseData>` | yes | _elementCls=GamePlayerLeaderboardResponseData_ |

Reference links:

- [GamePlayerModels.GamePlayerLeaderboardResponseData:2350-2399](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#gameplayerleaderboardresponsedata)

### GetCreateLeaderboardResponseData

Defines the response payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GamePlayerLeaderboardResponseData>` | yes | _elementCls=GamePlayerLeaderboardResponseData_ |

Reference links:

- [GamePlayerModels.GamePlayerLeaderboardResponseData:2350-2399](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#gameplayerleaderboardresponsedata)

### GamePlayersWithUserIdResponseData

Defines the response payload for GamePlayersWithUserId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GamePlayerWithUserIdResponseData>` | yes | _elementCls=GamePlayerWithUserIdResponseData_ |

Reference links:

- [GamePlayerModels.GamePlayerWithUserIdResponseData:2350-2380](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#gameplayerwithuseridresponsedata)

### GetCurrencyLeaderboardRequestData

Defines the request payload for GetCurrencyLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Reference links:

- [GamePlayerModels.InfoRequestParam:1-34](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#inforequestparam)

### ServerGetCurrencyLeaderboardRequestData

Extends: `GetCurrencyLeaderboardRequestData`

Defines the request payload for ServerGetCurrencyLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCurrencyLeaderboardRequestData`._

Reference links:

- [GamePlayerModels.GetCurrencyLeaderboardRequestData:2481-2497](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getcurrencyleaderboardrequestdata)

### AdminGetCurrencyLeaderboardRequestData

Extends: `ServerGetCurrencyLeaderboardRequestData`

Defines the request payload for AdminGetCurrencyLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCurrencyLeaderboardRequestData`._

Reference links:

- [GamePlayerModels.GetCurrencyLeaderboardRequestData:2481-2497](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getcurrencyleaderboardrequestdata)
- [GamePlayerModels.ServerGetCurrencyLeaderboardRequestData:2481-2509](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetcurrencyleaderboardrequestdata)

### GetLastLoginLeaderboardRequestData

Defines the request payload for GetLastLoginLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Reference links:

- [GamePlayerModels.InfoRequestParam:1-34](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#inforequestparam)

### ServerGetLastLoginLeaderboardRequestData

Extends: `GetLastLoginLeaderboardRequestData`

Defines the request payload for ServerGetLastLoginLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetLastLoginLeaderboardRequestData`._

Reference links:

- [GamePlayerModels.GetLastLoginLeaderboardRequestData:2523-2538](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getlastloginleaderboardrequestdata)

### AdminGetLastLoginLeaderboardRequestData

Extends: `ServerGetLastLoginLeaderboardRequestData`

Defines the request payload for AdminGetLastLoginLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetLastLoginLeaderboardRequestData`._

Reference links:

- [GamePlayerModels.GetLastLoginLeaderboardRequestData:2523-2538](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#getlastloginleaderboardrequestdata)
- [GamePlayerModels.ServerGetLastLoginLeaderboardRequestData:2523-2550](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#servergetlastloginleaderboardrequestdata)

### GetStatisticsLogResponseData

Returns one page of statistics logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GamePlayerLogResponseData>` | yes | _elementCls=GamePlayerLogResponseData_ |
| `token` | `string?` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

Reference links:

- [GamePlayerModels.GamePlayerLogResponseData:2400-2414](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#gameplayerlogresponsedata)

### GetCurrencyLogResponseData

Returns one page of currency logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GamePlayerLogResponseData>` | yes | _elementCls=GamePlayerLogResponseData_ |
| `token` | `string?` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

Reference links:

- [GamePlayerModels.GamePlayerLogResponseData:2400-2414](/docs/reference/dto/game-player/GAME_PLAYER_MODELS.md#gameplayerlogresponsedata)

### EmptyResponseData

Defines an intentionally empty response payload.

_Không có field public (payload rỗng)._
