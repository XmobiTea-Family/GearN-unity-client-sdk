### InfoRequestParam

Selects which optional character-player fields and lightweight relations should be returned. Boolean flags default to `false`; key arrays narrow list-style fields to specific keys only.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `catalogId` | `bool?` | no | Includes the character catalog ID. — _default=false_ |
| `owner` | `bool?` | no | Includes the current owner descriptor. — _default=false_ |
| `removeStatus` | `bool?` | no | Includes the remove-state descriptor. — _default=false_ |
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
| `playerInventories` | `bool?` | no | Includes relation items for inventory owned by the character, optionally filtered by `itemCatalogIds`. — _default=false_ |
| `playerGroups` | `bool?` | no | Includes relation items for groups joined or owned by the character, optionally filtered by `groupCatalogIds`. — _default=false_ |
| `playerFriends` | `bool?` | no | Includes relation items for friends attached to the character, optionally filtered by `friendCatalogIds`. — _default=false_ |
| `playerDataKeys` | `List<string>?` | no | _elementCls=String_ |
| `playerCurrencyKeys` | `List<string>?` | no | _elementCls=String_ |
| `playerStatisticsKeys` | `List<string>?` | no | _elementCls=String_ |
| `customDataKeys` | `List<string>?` | no | _elementCls=String_ |
| `tagKeys` | `List<string>?` | no | _elementCls=String_ |
| `characterCatalogIds` | `List<string>?` | no | _elementCls=String_ |
| `itemCatalogIds` | `List<string>?` | no | Restricts `playerInventories` to relation items whose catalog IDs match this list. — _elementCls=String_ |
| `groupCatalogIds` | `List<string>?` | no | Restricts `playerGroups` to relation items whose catalog IDs match this list. — _elementCls=String_ |
| `friendCatalogIds` | `List<string>?` | no | Restricts `playerFriends` to relation items whose catalog IDs match this list. — _elementCls=String_ |

### PlayerStatisticsParam

Defines the reusable parameter block PlayerStatisticsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `double` | yes | Statistic value to apply; interpretation depends on the configured aggregation method. |

### PlayerDataParam

Defines the reusable parameter block PlayerDataParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `object` | yes | Arbitrary value to store for this player data key. May be a primitive, `GNHashtable`, or `GNArray`. |

### PlayerCurrencyParam

Defines the reusable parameter block PlayerCurrencyParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `amount` | `double` | yes | Currency amount delta to apply (positive to add, negative to subtract). |

### CustomDataParam

Defines the reusable parameter block CustomDataParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `object` | yes | Arbitrary value to store for this custom data key. May be a primitive, `GNHashtable`, or `GNArray`. |

### GroupMemberParam

Describes one game-player member included when creating a group from a character context.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |

### AddPlayerFriendRequestData

Defines the request payload for AddPlayerFriend.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `friendId` | `string` | yes | _minLength=11, maxLength=11_ |
| `catalogId` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerAddPlayerFriendRequestData

Extends: `AddPlayerFriendRequestData`

Defines the request payload for ServerAddPlayerFriend.

_Không khai báo field mới; kế thừa toàn bộ field từ `AddPlayerFriendRequestData`._

Reference links:

- [CharacterPlayerModels.AddPlayerFriendRequestData:86-96](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#addplayerfriendrequestdata)

### AdminAddPlayerFriendRequestData

Extends: `ServerAddPlayerFriendRequestData`

Defines the request payload for AdminAddPlayerFriend.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerAddPlayerFriendRequestData`._

Reference links:

- [CharacterPlayerModels.AddPlayerFriendRequestData:86-96](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#addplayerfriendrequestdata)
- [CharacterPlayerModels.ServerAddPlayerFriendRequestData:86-108](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serveraddplayerfriendrequestdata)

### AddSegmentRequestData

Defines the request payload for AddSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `value` | `string` | yes | _minLength=6, maxLength=32_ |

### ServerAddSegmentRequestData

Extends: `AddSegmentRequestData`

Defines the request payload for ServerAddSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `AddSegmentRequestData`._

Reference links:

- [CharacterPlayerModels.AddSegmentRequestData:122-131](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#addsegmentrequestdata)

### AdminAddSegmentRequestData

Extends: `ServerAddSegmentRequestData`

Defines the request payload for AdminAddSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerAddSegmentRequestData`._

Reference links:

- [CharacterPlayerModels.AddSegmentRequestData:122-131](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#addsegmentrequestdata)
- [CharacterPlayerModels.ServerAddSegmentRequestData:122-143](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serveraddsegmentrequestdata)

### GetAvatarRequestData

Defines the request payload for GetAvatar.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |

### ServerGetAvatarRequestData

Extends: `GetAvatarRequestData`

Defines the request payload for ServerGetAvatar.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetAvatarRequestData`._

Reference links:

- [CharacterPlayerModels.GetAvatarRequestData:157-165](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getavatarrequestdata)

### AdminGetAvatarRequestData

Extends: `ServerGetAvatarRequestData`

Defines the request payload for AdminGetAvatar.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetAvatarRequestData`._

Reference links:

- [CharacterPlayerModels.GetAvatarRequestData:157-165](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getavatarrequestdata)
- [CharacterPlayerModels.ServerGetAvatarRequestData:157-177](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetavatarrequestdata)

### GetCatalogIdRequestData

Defines the request payload for GetCatalogId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |

### ServerGetCatalogIdRequestData

Extends: `GetCatalogIdRequestData`

Defines the request payload for ServerGetCatalogId.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCatalogIdRequestData`._

Reference links:

- [CharacterPlayerModels.GetCatalogIdRequestData:191-199](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getcatalogidrequestdata)

### AdminGetCatalogIdRequestData

Extends: `ServerGetCatalogIdRequestData`

Defines the request payload for AdminGetCatalogId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCatalogIdRequestData`._

Reference links:

- [CharacterPlayerModels.GetCatalogIdRequestData:191-199](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getcatalogidrequestdata)
- [CharacterPlayerModels.ServerGetCatalogIdRequestData:191-211](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetcatalogidrequestdata)

### GetCountryCodeRequestData

Defines the request payload for GetCountryCode.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |

### ServerGetCountryCodeRequestData

Extends: `GetCountryCodeRequestData`

Defines the request payload for ServerGetCountryCode.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCountryCodeRequestData`._

Reference links:

- [CharacterPlayerModels.GetCountryCodeRequestData:225-233](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getcountrycoderequestdata)

### AdminGetCountryCodeRequestData

Extends: `ServerGetCountryCodeRequestData`

Defines the request payload for AdminGetCountryCode.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCountryCodeRequestData`._

Reference links:

- [CharacterPlayerModels.GetCountryCodeRequestData:225-233](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getcountrycoderequestdata)
- [CharacterPlayerModels.ServerGetCountryCodeRequestData:225-245](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetcountrycoderequestdata)

### GetCustomDataRequestData

Defines the request payload for GetCustomData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `customDataKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetCustomDataRequestData

Extends: `GetCustomDataRequestData`

Defines the request payload for ServerGetCustomData.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCustomDataRequestData`._

Reference links:

- [CharacterPlayerModels.GetCustomDataRequestData:259-268](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getcustomdatarequestdata)

### AdminGetCustomDataRequestData

Extends: `ServerGetCustomDataRequestData`

Defines the request payload for AdminGetCustomData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCustomDataRequestData`._

Reference links:

- [CharacterPlayerModels.GetCustomDataRequestData:259-268](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getcustomdatarequestdata)
- [CharacterPlayerModels.ServerGetCustomDataRequestData:259-280](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetcustomdatarequestdata)

### GetDisplayNameRequestData

Defines the request payload for GetDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |

### ServerGetDisplayNameRequestData

Extends: `GetDisplayNameRequestData`

Defines the request payload for ServerGetDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetDisplayNameRequestData`._

Reference links:

- [CharacterPlayerModels.GetDisplayNameRequestData:294-302](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getdisplaynamerequestdata)

### AdminGetDisplayNameRequestData

Extends: `ServerGetDisplayNameRequestData`

Defines the request payload for AdminGetDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetDisplayNameRequestData`._

Reference links:

- [CharacterPlayerModels.GetDisplayNameRequestData:294-302](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getdisplaynamerequestdata)
- [CharacterPlayerModels.ServerGetDisplayNameRequestData:294-314](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetdisplaynamerequestdata)

### GetFriendStatisticsLeaderboardAroundPlayerRequestData

Defines the request payload for GetFriendStatisticsLeaderboardAroundPlayer.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional character fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Reference links:

- [CharacterPlayerModels.InfoRequestParam:1-36](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData

Extends: `GetFriendStatisticsLeaderboardAroundPlayerRequestData`

Defines the request payload for ServerGetFriendStatisticsLeaderboardAroundPlayer.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetFriendStatisticsLeaderboardAroundPlayerRequestData`._

Reference links:

- [CharacterPlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData:328-345](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getfriendstatisticsleaderboardaroundplayerrequestdata)

### AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData

Extends: `ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData`

Defines the request payload for AdminGetFriendStatisticsLeaderboardAroundPlayer.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData`._

Reference links:

- [CharacterPlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData:328-345](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getfriendstatisticsleaderboardaroundplayerrequestdata)
- [CharacterPlayerModels.ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData:328-357](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetfriendstatisticsleaderboardaroundplayerrequestdata)

### GetFriendStatisticsLeaderboardRequestData

Defines the request payload for GetFriendStatisticsLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional character fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Reference links:

- [CharacterPlayerModels.InfoRequestParam:1-36](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetFriendStatisticsLeaderboardRequestData

Extends: `GetFriendStatisticsLeaderboardRequestData`

Defines the request payload for ServerGetFriendStatisticsLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetFriendStatisticsLeaderboardRequestData`._

Reference links:

- [CharacterPlayerModels.GetFriendStatisticsLeaderboardRequestData:371-388](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getfriendstatisticsleaderboardrequestdata)

### AdminGetFriendStatisticsLeaderboardRequestData

Extends: `ServerGetFriendStatisticsLeaderboardRequestData`

Defines the request payload for AdminGetFriendStatisticsLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetFriendStatisticsLeaderboardRequestData`._

Reference links:

- [CharacterPlayerModels.GetFriendStatisticsLeaderboardRequestData:371-388](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getfriendstatisticsleaderboardrequestdata)
- [CharacterPlayerModels.ServerGetFriendStatisticsLeaderboardRequestData:371-400](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetfriendstatisticsleaderboardrequestdata)

### GetIpAddressCreateRequestData

Defines the request payload for GetIpAddressCreate.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |

### ServerGetIpAddressCreateRequestData

Extends: `GetIpAddressCreateRequestData`

Defines the request payload for ServerGetIpAddressCreate.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetIpAddressCreateRequestData`._

Reference links:

- [CharacterPlayerModels.GetIpAddressCreateRequestData:414-422](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getipaddresscreaterequestdata)

### AdminGetIpAddressCreateRequestData

Extends: `ServerGetIpAddressCreateRequestData`

Defines the request payload for AdminGetIpAddressCreate.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetIpAddressCreateRequestData`._

Reference links:

- [CharacterPlayerModels.GetIpAddressCreateRequestData:414-422](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getipaddresscreaterequestdata)
- [CharacterPlayerModels.ServerGetIpAddressCreateRequestData:414-434](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetipaddresscreaterequestdata)

### GetOwnerRequestData

Defines the request payload for GetOwner.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |

### ServerGetOwnerRequestData

Extends: `GetOwnerRequestData`

Defines the request payload for ServerGetOwner.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetOwnerRequestData`._

Reference links:

- [CharacterPlayerModels.GetOwnerRequestData:448-456](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getownerrequestdata)

### AdminGetOwnerRequestData

Extends: `ServerGetOwnerRequestData`

Defines the request payload for AdminGetOwner.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetOwnerRequestData`._

Reference links:

- [CharacterPlayerModels.GetOwnerRequestData:448-456](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getownerrequestdata)
- [CharacterPlayerModels.ServerGetOwnerRequestData:448-468](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetownerrequestdata)

### GetPlayerBanRequestData

Defines the request payload for GetPlayerBan.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |

### ServerGetPlayerBanRequestData

Extends: `GetPlayerBanRequestData`

Defines the request payload for ServerGetPlayerBan.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayerBanRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayerBanRequestData:482-490](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerbanrequestdata)

### AdminGetPlayerBanRequestData

Extends: `ServerGetPlayerBanRequestData`

Defines the request payload for AdminGetPlayerBan.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerBanRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayerBanRequestData:482-490](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerbanrequestdata)
- [CharacterPlayerModels.ServerGetPlayerBanRequestData:482-502](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetplayerbanrequestdata)

### GetPlayerCurrencyRequestData

Defines the request payload for GetPlayerCurrency.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `playerCurrencyKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerCurrencyRequestData

Extends: `GetPlayerCurrencyRequestData`

Defines the request payload for ServerGetPlayerCurrency.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayerCurrencyRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayerCurrencyRequestData:516-525](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayercurrencyrequestdata)

### AdminGetPlayerCurrencyRequestData

Extends: `ServerGetPlayerCurrencyRequestData`

Defines the request payload for AdminGetPlayerCurrency.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerCurrencyRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayerCurrencyRequestData:516-525](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayercurrencyrequestdata)
- [CharacterPlayerModels.ServerGetPlayerCurrencyRequestData:516-537](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetplayercurrencyrequestdata)

### GetPlayerDataRequestData

Defines the request payload for GetPlayerData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `playerDataKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerDataRequestData

Extends: `GetPlayerDataRequestData`

Defines the request payload for ServerGetPlayerData.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayerDataRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayerDataRequestData:551-560](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerdatarequestdata)

### AdminGetPlayerDataRequestData

Extends: `ServerGetPlayerDataRequestData`

Defines the request payload for AdminGetPlayerData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerDataRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayerDataRequestData:551-560](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerdatarequestdata)
- [CharacterPlayerModels.ServerGetPlayerDataRequestData:551-572](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetplayerdatarequestdata)

### GetPlayerFriendRequestData

Defines the request payload for GetPlayerFriend.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `friendCatalogIds` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerFriendRequestData

Extends: `GetPlayerFriendRequestData`

Defines the request payload for ServerGetPlayerFriend.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayerFriendRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayerFriendRequestData:586-595](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerfriendrequestdata)

### AdminGetPlayerFriendRequestData

Extends: `ServerGetPlayerFriendRequestData`

Defines the request payload for AdminGetPlayerFriend.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerFriendRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayerFriendRequestData:586-595](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerfriendrequestdata)
- [CharacterPlayerModels.ServerGetPlayerFriendRequestData:586-607](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetplayerfriendrequestdata)

### GetPlayerGroupRequestData

Defines the request payload for GetPlayerGroup.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `groupCatalogIds` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerGroupRequestData

Extends: `GetPlayerGroupRequestData`

Defines the request payload for ServerGetPlayerGroup.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayerGroupRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayerGroupRequestData:621-630](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayergrouprequestdata)

### AdminGetPlayerGroupRequestData

Extends: `ServerGetPlayerGroupRequestData`

Defines the request payload for AdminGetPlayerGroup.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerGroupRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayerGroupRequestData:621-630](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayergrouprequestdata)
- [CharacterPlayerModels.ServerGetPlayerGroupRequestData:621-642](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetplayergrouprequestdata)

### GetPlayerInformationRequestData

Reads one specific character-player profile using the requested projection.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | Character entity to inspect. — _minLength=11, maxLength=11_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Required field projection that controls which optional data is returned. |

Reference links:

- [CharacterPlayerModels.InfoRequestParam:1-36](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayerInformationRequestData

Extends: `GetPlayerInformationRequestData`

Defines the request payload for ServerGetPlayerInformation.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayerInformationRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayerInformationRequestData:656-669](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerinformationrequestdata)

### AdminGetPlayerInformationRequestData

Extends: `ServerGetPlayerInformationRequestData`

Defines the request payload for AdminGetPlayerInformation.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerInformationRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayerInformationRequestData:656-669](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerinformationrequestdata)
- [CharacterPlayerModels.ServerGetPlayerInformationRequestData:656-681](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetplayerinformationrequestdata)

### GetPlayerInventoryRequestData

Defines the request payload for GetPlayerInventory.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `itemCatalogIds` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerInventoryRequestData

Extends: `GetPlayerInventoryRequestData`

Defines the request payload for ServerGetPlayerInventory.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayerInventoryRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayerInventoryRequestData:695-704](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerinventoryrequestdata)

### AdminGetPlayerInventoryRequestData

Extends: `ServerGetPlayerInventoryRequestData`

Defines the request payload for AdminGetPlayerInventory.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerInventoryRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayerInventoryRequestData:695-704](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerinventoryrequestdata)
- [CharacterPlayerModels.ServerGetPlayerInventoryRequestData:695-716](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetplayerinventoryrequestdata)

### GetPlayerStatisticsRequestData

Defines the request payload for GetPlayerStatistics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `statisticsKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerStatisticsRequestData

Extends: `GetPlayerStatisticsRequestData`

Defines the request payload for ServerGetPlayerStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayerStatisticsRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayerStatisticsRequestData:730-739](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerstatisticsrequestdata)

### AdminGetPlayerStatisticsRequestData

Extends: `ServerGetPlayerStatisticsRequestData`

Defines the request payload for AdminGetPlayerStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayerStatisticsRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayerStatisticsRequestData:730-739](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerstatisticsrequestdata)
- [CharacterPlayerModels.ServerGetPlayerStatisticsRequestData:730-751](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetplayerstatisticsrequestdata)

### GetPlayersWithDisplayNameRequestData

Defines the request payload for GetPlayersWithDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keyword` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional character fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

Reference links:

- [CharacterPlayerModels.InfoRequestParam:1-36](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayersWithDisplayNameRequestData

Extends: `GetPlayersWithDisplayNameRequestData`

Defines the request payload for ServerGetPlayersWithDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayersWithDisplayNameRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayersWithDisplayNameRequestData:765-780](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerswithdisplaynamerequestdata)

### AdminGetPlayersWithDisplayNameRequestData

Extends: `ServerGetPlayersWithDisplayNameRequestData`

Defines the request payload for AdminGetPlayersWithDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayersWithDisplayNameRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayersWithDisplayNameRequestData:765-780](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerswithdisplaynamerequestdata)
- [CharacterPlayerModels.ServerGetPlayersWithDisplayNameRequestData:765-792](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetplayerswithdisplaynamerequestdata)

### GetPlayersWithSegmentRequestData

Defines the request payload for GetPlayersWithSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional character fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

Reference links:

- [CharacterPlayerModels.InfoRequestParam:1-36](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayersWithSegmentRequestData

Extends: `GetPlayersWithSegmentRequestData`

Defines the request payload for ServerGetPlayersWithSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayersWithSegmentRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayersWithSegmentRequestData:806-821](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerswithsegmentrequestdata)

### AdminGetPlayersWithSegmentRequestData

Extends: `ServerGetPlayersWithSegmentRequestData`

Defines the request payload for AdminGetPlayersWithSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayersWithSegmentRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayersWithSegmentRequestData:806-821](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerswithsegmentrequestdata)
- [CharacterPlayerModels.ServerGetPlayersWithSegmentRequestData:806-833](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetplayerswithsegmentrequestdata)

### GetPlayersWithTagRequestData

Defines the request payload for GetPlayersWithTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional character fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

Reference links:

- [CharacterPlayerModels.InfoRequestParam:1-36](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetPlayersWithTagRequestData

Extends: `GetPlayersWithTagRequestData`

Defines the request payload for ServerGetPlayersWithTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetPlayersWithTagRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayersWithTagRequestData:847-863](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerswithtagrequestdata)

### AdminGetPlayersWithTagRequestData

Extends: `ServerGetPlayersWithTagRequestData`

Defines the request payload for AdminGetPlayersWithTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetPlayersWithTagRequestData`._

Reference links:

- [CharacterPlayerModels.GetPlayersWithTagRequestData:847-863](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getplayerswithtagrequestdata)
- [CharacterPlayerModels.ServerGetPlayersWithTagRequestData:847-875](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetplayerswithtagrequestdata)

### GetRemoveStatusRequestData

Defines the request payload for GetRemoveStatus.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |

### ServerGetRemoveStatusRequestData

Extends: `GetRemoveStatusRequestData`

Defines the request payload for ServerGetRemoveStatus.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetRemoveStatusRequestData`._

Reference links:

- [CharacterPlayerModels.GetRemoveStatusRequestData:889-897](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getremovestatusrequestdata)

### AdminGetRemoveStatusRequestData

Extends: `ServerGetRemoveStatusRequestData`

Defines the request payload for AdminGetRemoveStatus.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetRemoveStatusRequestData`._

Reference links:

- [CharacterPlayerModels.GetRemoveStatusRequestData:889-897](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getremovestatusrequestdata)
- [CharacterPlayerModels.ServerGetRemoveStatusRequestData:889-909](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetremovestatusrequestdata)

### GetSegmentRequestData

Defines the request payload for GetSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |

### ServerGetSegmentRequestData

Extends: `GetSegmentRequestData`

Defines the request payload for ServerGetSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetSegmentRequestData`._

Reference links:

- [CharacterPlayerModels.GetSegmentRequestData:923-931](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getsegmentrequestdata)

### AdminGetSegmentRequestData

Extends: `ServerGetSegmentRequestData`

Defines the request payload for AdminGetSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetSegmentRequestData`._

Reference links:

- [CharacterPlayerModels.GetSegmentRequestData:923-931](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getsegmentrequestdata)
- [CharacterPlayerModels.ServerGetSegmentRequestData:923-943](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetsegmentrequestdata)

### GetStatisticsLeaderboardAroundPlayerRequestData

Defines the request payload for GetStatisticsLeaderboardAroundPlayer.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional character fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |
| `catalogId` | `string?` | no | _minLength=2, maxLength=32_ |

Reference links:

- [CharacterPlayerModels.InfoRequestParam:1-36](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetStatisticsLeaderboardAroundPlayerRequestData

Extends: `GetStatisticsLeaderboardAroundPlayerRequestData`

Defines the request payload for ServerGetStatisticsLeaderboardAroundPlayer.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetStatisticsLeaderboardAroundPlayerRequestData`._

Reference links:

- [CharacterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData:957-975](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getstatisticsleaderboardaroundplayerrequestdata)

### AdminGetStatisticsLeaderboardAroundPlayerRequestData

Extends: `ServerGetStatisticsLeaderboardAroundPlayerRequestData`

Defines the request payload for AdminGetStatisticsLeaderboardAroundPlayer.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStatisticsLeaderboardAroundPlayerRequestData`._

Reference links:

- [CharacterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData:957-975](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getstatisticsleaderboardaroundplayerrequestdata)
- [CharacterPlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData:957-987](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetstatisticsleaderboardaroundplayerrequestdata)

### GetCurrencyLeaderboardRequestData

Defines the request payload for GetCurrencyLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional character fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |
| `catalogId` | `string?` | no | _minLength=2, maxLength=32_ |

Reference links:

- [CharacterPlayerModels.InfoRequestParam:1-36](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetCurrencyLeaderboardRequestData

Extends: `GetCurrencyLeaderboardRequestData`

Defines the request payload for ServerGetCurrencyLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCurrencyLeaderboardRequestData`._

Reference links:

- [CharacterPlayerModels.GetCurrencyLeaderboardRequestData:1001-1018](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getcurrencyleaderboardrequestdata)

### AdminGetCurrencyLeaderboardRequestData

Extends: `ServerGetCurrencyLeaderboardRequestData`

Defines the request payload for AdminGetCurrencyLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCurrencyLeaderboardRequestData`._

Reference links:

- [CharacterPlayerModels.GetCurrencyLeaderboardRequestData:1001-1018](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getcurrencyleaderboardrequestdata)
- [CharacterPlayerModels.ServerGetCurrencyLeaderboardRequestData:1001-1030](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetcurrencyleaderboardrequestdata)

### GetStatisticsLeaderboardRequestData

Defines the request payload for GetStatisticsLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional character fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |
| `version` | `string?` | no | _minLength=2, maxLength=32_ |
| `catalogId` | `string?` | no | _minLength=2, maxLength=32_ |

Reference links:

- [CharacterPlayerModels.InfoRequestParam:1-36](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetStatisticsLeaderboardRequestData

Extends: `GetStatisticsLeaderboardRequestData`

Defines the request payload for ServerGetStatisticsLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetStatisticsLeaderboardRequestData`._

Reference links:

- [CharacterPlayerModels.GetStatisticsLeaderboardRequestData:1044-1062](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getstatisticsleaderboardrequestdata)

### AdminGetStatisticsLeaderboardRequestData

Extends: `ServerGetStatisticsLeaderboardRequestData`

Defines the request payload for AdminGetStatisticsLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStatisticsLeaderboardRequestData`._

Reference links:

- [CharacterPlayerModels.GetStatisticsLeaderboardRequestData:1044-1062](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getstatisticsleaderboardrequestdata)
- [CharacterPlayerModels.ServerGetStatisticsLeaderboardRequestData:1044-1074](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetstatisticsleaderboardrequestdata)

### GetCreateLeaderboardRequestData

Defines the request payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional character fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Reference links:

- [CharacterPlayerModels.InfoRequestParam:1-36](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetCreateLeaderboardRequestData

Extends: `GetCreateLeaderboardRequestData`

Defines the request payload for ServerGetCreateLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCreateLeaderboardRequestData`._

Reference links:

- [CharacterPlayerModels.GetCreateLeaderboardRequestData:1088-1103](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getcreateleaderboardrequestdata)

### AdminGetCreateLeaderboardRequestData

Extends: `ServerGetCreateLeaderboardRequestData`

Defines the request payload for AdminGetCreateLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCreateLeaderboardRequestData`._

Reference links:

- [CharacterPlayerModels.GetCreateLeaderboardRequestData:1088-1103](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getcreateleaderboardrequestdata)
- [CharacterPlayerModels.ServerGetCreateLeaderboardRequestData:1088-1115](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetcreateleaderboardrequestdata)

### GetLastLoginLeaderboardRequestData

Defines the request payload for GetLastLoginLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional character fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Reference links:

- [CharacterPlayerModels.InfoRequestParam:1-36](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforequestparam)

### ServerGetLastLoginLeaderboardRequestData

Extends: `GetLastLoginLeaderboardRequestData`

Defines the request payload for ServerGetLastLoginLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetLastLoginLeaderboardRequestData`._

Reference links:

- [CharacterPlayerModels.GetLastLoginLeaderboardRequestData:1129-1144](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getlastloginleaderboardrequestdata)

### AdminGetLastLoginLeaderboardRequestData

Extends: `ServerGetLastLoginLeaderboardRequestData`

Defines the request payload for AdminGetLastLoginLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetLastLoginLeaderboardRequestData`._

Reference links:

- [CharacterPlayerModels.GetLastLoginLeaderboardRequestData:1129-1144](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getlastloginleaderboardrequestdata)
- [CharacterPlayerModels.ServerGetLastLoginLeaderboardRequestData:1129-1156](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetlastloginleaderboardrequestdata)

### GetTagRequestData

Defines the request payload for GetTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `tagKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetTagRequestData

Extends: `GetTagRequestData`

Defines the request payload for ServerGetTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetTagRequestData`._

Reference links:

- [CharacterPlayerModels.GetTagRequestData:1170-1179](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#gettagrequestdata)

### AdminGetTagRequestData

Extends: `ServerGetTagRequestData`

Defines the request payload for AdminGetTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetTagRequestData`._

Reference links:

- [CharacterPlayerModels.GetTagRequestData:1170-1179](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#gettagrequestdata)
- [CharacterPlayerModels.ServerGetTagRequestData:1170-1191](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergettagrequestdata)

### GetTsCreateRequestData

Defines the request payload for GetTsCreate.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |

### ServerGetTsCreateRequestData

Extends: `GetTsCreateRequestData`

Defines the request payload for ServerGetTsCreate.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetTsCreateRequestData`._

Reference links:

- [CharacterPlayerModels.GetTsCreateRequestData:1205-1213](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#gettscreaterequestdata)

### AdminGetTsCreateRequestData

Extends: `ServerGetTsCreateRequestData`

Defines the request payload for AdminGetTsCreate.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetTsCreateRequestData`._

Reference links:

- [CharacterPlayerModels.GetTsCreateRequestData:1205-1213](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#gettscreaterequestdata)
- [CharacterPlayerModels.ServerGetTsCreateRequestData:1205-1225](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergettscreaterequestdata)

### GetTsLastLoginRequestData

Defines the request payload for GetTsLastLogin.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |

### ServerGetTsLastLoginRequestData

Extends: `GetTsLastLoginRequestData`

Defines the request payload for ServerGetTsLastLogin.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetTsLastLoginRequestData`._

Reference links:

- [CharacterPlayerModels.GetTsLastLoginRequestData:1239-1247](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#gettslastloginrequestdata)

### AdminGetTsLastLoginRequestData

Extends: `ServerGetTsLastLoginRequestData`

Defines the request payload for AdminGetTsLastLogin.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetTsLastLoginRequestData`._

Reference links:

- [CharacterPlayerModels.GetTsLastLoginRequestData:1239-1247](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#gettslastloginrequestdata)
- [CharacterPlayerModels.ServerGetTsLastLoginRequestData:1239-1259](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergettslastloginrequestdata)

### CreateGroupRequestData

Creates a group from a character-player context.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `catalogId` | `string` | yes | _minLength=2, maxLength=32_ |
| `groupMembers` | `List<GroupMemberParam>?` | no | Additional group members expressed as game-player user IDs, not character IDs. — _elementCls=GroupMemberParam_ |
| `displayName` | `string?` | no | _default=""_ |

Reference links:

- [CharacterPlayerModels.GroupMemberParam:77-85](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#groupmemberparam)

### ServerCreateGroupRequestData

Extends: `CreateGroupRequestData`

Defines the request payload for ServerCreateGroup.

_Không khai báo field mới; kế thừa toàn bộ field từ `CreateGroupRequestData`._

Reference links:

- [CharacterPlayerModels.CreateGroupRequestData:1273-1288](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#creategrouprequestdata)

### AdminCreateGroupRequestData

Extends: `ServerCreateGroupRequestData`

Defines the request payload for AdminCreateGroup.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerCreateGroupRequestData`._

Reference links:

- [CharacterPlayerModels.CreateGroupRequestData:1273-1288](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#creategrouprequestdata)
- [CharacterPlayerModels.ServerCreateGroupRequestData:1273-1300](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servercreategrouprequestdata)

### CreatePlayerItemRequestData

Defines the request payload for CreatePlayerItem.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `catalogId` | `string` | yes | _minLength=2, maxLength=32_ |
| `classId` | `string` | yes | _minLength=2, maxLength=32_ |
| `displayName` | `string?` | no | _default=""_ |
| `amount` | `int?` | no | _default=1_ |

### ServerCreatePlayerItemRequestData

Extends: `CreatePlayerItemRequestData`

Defines the request payload for ServerCreatePlayerItem.

_Không khai báo field mới; kế thừa toàn bộ field từ `CreatePlayerItemRequestData`._

Reference links:

- [CharacterPlayerModels.CreatePlayerItemRequestData:1314-1326](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#createplayeritemrequestdata)

### AdminCreatePlayerItemRequestData

Extends: `ServerCreatePlayerItemRequestData`

Defines the request payload for AdminCreatePlayerItem.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerCreatePlayerItemRequestData`._

Reference links:

- [CharacterPlayerModels.CreatePlayerItemRequestData:1314-1326](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#createplayeritemrequestdata)
- [CharacterPlayerModels.ServerCreatePlayerItemRequestData:1314-1338](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servercreateplayeritemrequestdata)

### JoinGroupRequestData

Defines the request payload for JoinGroup.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerJoinGroupRequestData

Extends: `JoinGroupRequestData`

Defines the request payload for ServerJoinGroup.

_Không khai báo field mới; kế thừa toàn bộ field từ `JoinGroupRequestData`._

Reference links:

- [CharacterPlayerModels.JoinGroupRequestData:1352-1361](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#joingrouprequestdata)

### AdminJoinGroupRequestData

Extends: `ServerJoinGroupRequestData`

Defines the request payload for AdminJoinGroup.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerJoinGroupRequestData`._

Reference links:

- [CharacterPlayerModels.JoinGroupRequestData:1352-1361](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#joingrouprequestdata)
- [CharacterPlayerModels.ServerJoinGroupRequestData:1352-1373](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serverjoingrouprequestdata)

### LeaveGroupRequestData

Defines the request payload for LeaveGroup.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerLeaveGroupRequestData

Extends: `LeaveGroupRequestData`

Defines the request payload for ServerLeaveGroup.

_Không khai báo field mới; kế thừa toàn bộ field từ `LeaveGroupRequestData`._

Reference links:

- [CharacterPlayerModels.LeaveGroupRequestData:1387-1396](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#leavegrouprequestdata)

### AdminLeaveGroupRequestData

Extends: `ServerLeaveGroupRequestData`

Defines the request payload for AdminLeaveGroup.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerLeaveGroupRequestData`._

Reference links:

- [CharacterPlayerModels.LeaveGroupRequestData:1387-1396](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#leavegrouprequestdata)
- [CharacterPlayerModels.ServerLeaveGroupRequestData:1387-1408](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serverleavegrouprequestdata)

### RemovePlayerFriendRequestData

Defines the request payload for RemovePlayerFriend.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `friendId` | `string` | yes | _minLength=11, maxLength=11_ |

### ServerRemovePlayerFriendRequestData

Extends: `RemovePlayerFriendRequestData`

Defines the request payload for ServerRemovePlayerFriend.

_Không khai báo field mới; kế thừa toàn bộ field từ `RemovePlayerFriendRequestData`._

Reference links:

- [CharacterPlayerModels.RemovePlayerFriendRequestData:1422-1431](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#removeplayerfriendrequestdata)

### AdminRemovePlayerFriendRequestData

Extends: `ServerRemovePlayerFriendRequestData`

Defines the request payload for AdminRemovePlayerFriend.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemovePlayerFriendRequestData`._

Reference links:

- [CharacterPlayerModels.RemovePlayerFriendRequestData:1422-1431](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#removeplayerfriendrequestdata)
- [CharacterPlayerModels.ServerRemovePlayerFriendRequestData:1422-1443](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serverremoveplayerfriendrequestdata)

### RemovePlayerItemRequestData

Defines the request payload for RemovePlayerItem.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerRemovePlayerItemRequestData

Extends: `RemovePlayerItemRequestData`

Defines the request payload for ServerRemovePlayerItem.

_Không khai báo field mới; kế thừa toàn bộ field từ `RemovePlayerItemRequestData`._

Reference links:

- [CharacterPlayerModels.RemovePlayerItemRequestData:1457-1466](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#removeplayeritemrequestdata)

### AdminRemovePlayerItemRequestData

Extends: `ServerRemovePlayerItemRequestData`

Defines the request payload for AdminRemovePlayerItem.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemovePlayerItemRequestData`._

Reference links:

- [CharacterPlayerModels.RemovePlayerItemRequestData:1457-1466](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#removeplayeritemrequestdata)
- [CharacterPlayerModels.ServerRemovePlayerItemRequestData:1457-1478](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serverremoveplayeritemrequestdata)

### RemoveSegmentRequestData

Defines the request payload for RemoveSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerRemoveSegmentRequestData

Extends: `RemoveSegmentRequestData`

Defines the request payload for ServerRemoveSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `RemoveSegmentRequestData`._

Reference links:

- [CharacterPlayerModels.RemoveSegmentRequestData:1492-1501](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#removesegmentrequestdata)

### AdminRemoveSegmentRequestData

Extends: `ServerRemoveSegmentRequestData`

Defines the request payload for AdminRemoveSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemoveSegmentRequestData`._

Reference links:

- [CharacterPlayerModels.RemoveSegmentRequestData:1492-1501](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#removesegmentrequestdata)
- [CharacterPlayerModels.ServerRemoveSegmentRequestData:1492-1513](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serverremovesegmentrequestdata)

### RemoveTagRequestData

Defines the request payload for RemoveTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerRemoveTagRequestData

Extends: `RemoveTagRequestData`

Defines the request payload for ServerRemoveTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `RemoveTagRequestData`._

Reference links:

- [CharacterPlayerModels.RemoveTagRequestData:1527-1536](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#removetagrequestdata)

### AdminRemoveTagRequestData

Extends: `ServerRemoveTagRequestData`

Defines the request payload for AdminRemoveTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemoveTagRequestData`._

Reference links:

- [CharacterPlayerModels.RemoveTagRequestData:1527-1536](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#removetagrequestdata)
- [CharacterPlayerModels.ServerRemoveTagRequestData:1527-1548](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serverremovetagrequestdata)

### SetAvatarRequestData

Defines the request payload for SetAvatar.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `type` | `int` | yes | App-defined avatar type integer; not mapped to a built-in GearN enum. |
| `value` | `string` | yes | Avatar value such as a URL, file ID, or provider-specific string. — _minLength=1, maxLength=128_ |

### ServerSetAvatarRequestData

Extends: `SetAvatarRequestData`

Defines the request payload for ServerSetAvatar.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetAvatarRequestData`._

Reference links:

- [CharacterPlayerModels.SetAvatarRequestData:1562-1572](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#setavatarrequestdata)

### AdminSetAvatarRequestData

Extends: `ServerSetAvatarRequestData`

Defines the request payload for AdminSetAvatar.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetAvatarRequestData`._

Reference links:

- [CharacterPlayerModels.SetAvatarRequestData:1562-1572](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#setavatarrequestdata)
- [CharacterPlayerModels.ServerSetAvatarRequestData:1562-1584](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serversetavatarrequestdata)

### SetCountryCodeRequestData

Defines the request payload for SetCountryCode.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `countryCode` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerSetCountryCodeRequestData

Extends: `SetCountryCodeRequestData`

Defines the request payload for ServerSetCountryCode.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetCountryCodeRequestData`._

Reference links:

- [CharacterPlayerModels.SetCountryCodeRequestData:1598-1607](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#setcountrycoderequestdata)

### AdminSetCountryCodeRequestData

Extends: `ServerSetCountryCodeRequestData`

Defines the request payload for AdminSetCountryCode.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetCountryCodeRequestData`._

Reference links:

- [CharacterPlayerModels.SetCountryCodeRequestData:1598-1607](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#setcountrycoderequestdata)
- [CharacterPlayerModels.ServerSetCountryCodeRequestData:1598-1619](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serversetcountrycoderequestdata)

### SetCustomDataRequestData

Defines the request payload for SetCustomData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `customDatas` | `List<CustomDataParam>` | yes | _minLength=1, maxLength=32, elementCls=CustomDataParam_ |

Reference links:

- [CharacterPlayerModels.CustomDataParam:67-76](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#customdataparam)

### ServerSetCustomDataRequestData

Extends: `SetCustomDataRequestData`

Defines the request payload for ServerSetCustomData.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetCustomDataRequestData`._

Reference links:

- [CharacterPlayerModels.SetCustomDataRequestData:1633-1646](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#setcustomdatarequestdata)

### AdminSetCustomDataRequestData

Extends: `ServerSetCustomDataRequestData`

Defines the request payload for AdminSetCustomData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetCustomDataRequestData`._

Reference links:

- [CharacterPlayerModels.SetCustomDataRequestData:1633-1646](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#setcustomdatarequestdata)
- [CharacterPlayerModels.ServerSetCustomDataRequestData:1633-1658](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serversetcustomdatarequestdata)

### SetDisplayNameRequestData

Defines the request payload for SetDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `displayName` | `string` | yes | _minLength=5, maxLength=32_ |
| `uniqueDisplayName` | `bool?` | no | _default=false_ |

### ServerSetDisplayNameRequestData

Extends: `SetDisplayNameRequestData`

Defines the request payload for ServerSetDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetDisplayNameRequestData`._

Reference links:

- [CharacterPlayerModels.SetDisplayNameRequestData:1672-1682](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#setdisplaynamerequestdata)

### AdminSetDisplayNameRequestData

Extends: `ServerSetDisplayNameRequestData`

Defines the request payload for AdminSetDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetDisplayNameRequestData`._

Reference links:

- [CharacterPlayerModels.SetDisplayNameRequestData:1672-1682](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#setdisplaynamerequestdata)
- [CharacterPlayerModels.ServerSetDisplayNameRequestData:1672-1694](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serversetdisplaynamerequestdata)

### SetOwnerRequestData

Transfers ownership of the character to another game player. The public contract currently exposes only the new owner ID, not an owner-type override.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `newOwnerId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerSetOwnerRequestData

Extends: `SetOwnerRequestData`

Defines the request payload for ServerSetOwner.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetOwnerRequestData`._

Reference links:

- [CharacterPlayerModels.SetOwnerRequestData:1708-1717](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#setownerrequestdata)

### AdminSetOwnerRequestData

Extends: `ServerSetOwnerRequestData`

Defines the request payload for AdminSetOwner.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetOwnerRequestData`._

Reference links:

- [CharacterPlayerModels.SetOwnerRequestData:1708-1717](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#setownerrequestdata)
- [CharacterPlayerModels.ServerSetOwnerRequestData:1708-1729](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serversetownerrequestdata)

### SetPlayerBanRequestData

Defines the request payload for SetPlayerBan.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `tsExpire` | `long` | yes | Expiration timestamp of the ban (Unix timestamp); use a far-future value for a permanent ban. |
| `reason` | `string` | yes | Human-readable reason for the ban recorded on the backend. |

### ServerSetPlayerBanRequestData

Extends: `SetPlayerBanRequestData`

Defines the request payload for ServerSetPlayerBan.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetPlayerBanRequestData`._

Reference links:

- [CharacterPlayerModels.SetPlayerBanRequestData:1743-1753](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#setplayerbanrequestdata)

### AdminSetPlayerBanRequestData

Extends: `ServerSetPlayerBanRequestData`

Defines the request payload for AdminSetPlayerBan.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetPlayerBanRequestData`._

Reference links:

- [CharacterPlayerModels.SetPlayerBanRequestData:1743-1753](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#setplayerbanrequestdata)
- [CharacterPlayerModels.ServerSetPlayerBanRequestData:1743-1765](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serversetplayerbanrequestdata)

### ChangePlayerCurrencyRequestData

Defines the request payload for ChangePlayerCurrency.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `playerCurrencies` | `List<PlayerCurrencyParam>` | yes | _minLength=1, maxLength=32, elementCls=PlayerCurrencyParam_ |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

Reference links:

- [CharacterPlayerModels.PlayerCurrencyParam:57-66](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#playercurrencyparam)

### ServerChangePlayerCurrencyRequestData

Extends: `ChangePlayerCurrencyRequestData`

Defines the request payload for ServerChangePlayerCurrency.

_Không khai báo field mới; kế thừa toàn bộ field từ `ChangePlayerCurrencyRequestData`._

Reference links:

- [CharacterPlayerModels.ChangePlayerCurrencyRequestData:1779-1793](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#changeplayercurrencyrequestdata)

### AdminChangePlayerCurrencyRequestData

Extends: `ServerChangePlayerCurrencyRequestData`

Defines the request payload for AdminChangePlayerCurrency.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerChangePlayerCurrencyRequestData`._

Reference links:

- [CharacterPlayerModels.ChangePlayerCurrencyRequestData:1779-1793](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#changeplayercurrencyrequestdata)
- [CharacterPlayerModels.ServerChangePlayerCurrencyRequestData:1779-1805](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serverchangeplayercurrencyrequestdata)

### SetPlayerDataRequestData

Defines the request payload for SetPlayerData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `playerDatas` | `List<PlayerDataParam>` | yes | _minLength=1, maxLength=32, elementCls=PlayerDataParam_ |

Reference links:

- [CharacterPlayerModels.PlayerDataParam:47-56](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#playerdataparam)

### ServerSetPlayerDataRequestData

Extends: `SetPlayerDataRequestData`

Defines the request payload for ServerSetPlayerData.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetPlayerDataRequestData`._

Reference links:

- [CharacterPlayerModels.SetPlayerDataRequestData:1819-1832](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#setplayerdatarequestdata)

### AdminSetPlayerDataRequestData

Extends: `ServerSetPlayerDataRequestData`

Defines the request payload for AdminSetPlayerData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetPlayerDataRequestData`._

Reference links:

- [CharacterPlayerModels.SetPlayerDataRequestData:1819-1832](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#setplayerdatarequestdata)
- [CharacterPlayerModels.ServerSetPlayerDataRequestData:1819-1844](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serversetplayerdatarequestdata)

### ChangePlayerStatisticsRequestData

Defines the request payload for ChangePlayerStatistics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `playerStatistics` | `List<PlayerStatisticsParam>` | yes | _minLength=1, maxLength=32, elementCls=PlayerStatisticsParam_ |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

Reference links:

- [CharacterPlayerModels.PlayerStatisticsParam:37-46](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#playerstatisticsparam)

### ServerChangePlayerStatisticsRequestData

Extends: `ChangePlayerStatisticsRequestData`

Defines the request payload for ServerChangePlayerStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `ChangePlayerStatisticsRequestData`._

Reference links:

- [CharacterPlayerModels.ChangePlayerStatisticsRequestData:1858-1872](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#changeplayerstatisticsrequestdata)

### AdminChangePlayerStatisticsRequestData

Extends: `ServerChangePlayerStatisticsRequestData`

Defines the request payload for AdminChangePlayerStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerChangePlayerStatisticsRequestData`._

Reference links:

- [CharacterPlayerModels.ChangePlayerStatisticsRequestData:1858-1872](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#changeplayerstatisticsrequestdata)
- [CharacterPlayerModels.ServerChangePlayerStatisticsRequestData:1858-1884](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serverchangeplayerstatisticsrequestdata)

### SetRemoveStatusRequestData

Defines the request payload for SetRemoveStatus.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `reason` | `string?` | no | _default=""_ |

### ServerSetRemoveStatusRequestData

Extends: `SetRemoveStatusRequestData`

Defines the request payload for ServerSetRemoveStatus.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetRemoveStatusRequestData`._

Reference links:

- [CharacterPlayerModels.SetRemoveStatusRequestData:1898-1907](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#setremovestatusrequestdata)

### AdminSetRemoveStatusRequestData

Extends: `ServerSetRemoveStatusRequestData`

Defines the request payload for AdminSetRemoveStatus.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetRemoveStatusRequestData`._

Reference links:

- [CharacterPlayerModels.SetRemoveStatusRequestData:1898-1907](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#setremovestatusrequestdata)
- [CharacterPlayerModels.ServerSetRemoveStatusRequestData:1898-1919](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serversetremovestatusrequestdata)

### SetTagRequestData

Defines the request payload for SetTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerSetTagRequestData

Extends: `SetTagRequestData`

Defines the request payload for ServerSetTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetTagRequestData`._

Reference links:

- [CharacterPlayerModels.SetTagRequestData:1933-1943](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#settagrequestdata)

### AdminSetTagRequestData

Extends: `ServerSetTagRequestData`

Defines the request payload for AdminSetTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetTagRequestData`._

Reference links:

- [CharacterPlayerModels.SetTagRequestData:1933-1943](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#settagrequestdata)
- [CharacterPlayerModels.ServerSetTagRequestData:1933-1955](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serversettagrequestdata)

### GetCurrencyLogRequestData

Reads currency change logs for one character player. Pagination is token-based rather than skip-based.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keys` | `List<string>?` | no | _minLength=1, maxLength=32, elementCls=String_ |
| `characterId` | `string?` | no | _minLength=11, maxLength=11_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `token` | `string?` | no | Continuation token returned by the previous page. — _minLength=24, maxLength=24_ |

### ServerGetCurrencyLogRequestData

Extends: `GetCurrencyLogRequestData`

Defines the request payload for ServerGetCurrencyLog.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCurrencyLogRequestData`._

Reference links:

- [CharacterPlayerModels.GetCurrencyLogRequestData:1969-1980](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getcurrencylogrequestdata)

### AdminGetCurrencyLogRequestData

Extends: `ServerGetCurrencyLogRequestData`

Defines the request payload for AdminGetCurrencyLog.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCurrencyLogRequestData`._

Reference links:

- [CharacterPlayerModels.GetCurrencyLogRequestData:1969-1980](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getcurrencylogrequestdata)
- [CharacterPlayerModels.ServerGetCurrencyLogRequestData:1969-1992](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetcurrencylogrequestdata)

### GetStatisticsLogRequestData

Reads statistic change logs for one character player. Pagination is token-based rather than skip-based.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keys` | `List<string>?` | no | _minLength=1, maxLength=32, elementCls=String_ |
| `characterId` | `string?` | no | _minLength=11, maxLength=11_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `token` | `string?` | no | Continuation token returned by the previous page. — _minLength=24, maxLength=24_ |

### ServerGetStatisticsLogRequestData

Extends: `GetStatisticsLogRequestData`

Defines the request payload for ServerGetStatisticsLog.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetStatisticsLogRequestData`._

Reference links:

- [CharacterPlayerModels.GetStatisticsLogRequestData:2006-2017](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getstatisticslogrequestdata)

### AdminGetStatisticsLogRequestData

Extends: `ServerGetStatisticsLogRequestData`

Defines the request payload for AdminGetStatisticsLog.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStatisticsLogRequestData`._

Reference links:

- [CharacterPlayerModels.GetStatisticsLogRequestData:2006-2017](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#getstatisticslogrequestdata)
- [CharacterPlayerModels.ServerGetStatisticsLogRequestData:2006-2029](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#servergetstatisticslogrequestdata)

### InfoResponseParameters

Contains the optional fields requested through `InfoRequestParam`.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `catalogId` | `string?` | no | Catalog ID the character belongs to; present when requested. |
| `owner` | `GenericModels.OwnerItem?` | no | Owner of the character entity; present when requested. |
| `removeStatus` | `GenericModels.RemoveStatusItem?` | no | Soft-remove metadata; present when the character has been marked for removal. |
| `segments` | `List<string>?` | no | Segment names currently assigned to the character. — _elementCls=String_ |
| `customDatas` | `List<GenericModels.DataItem>?` | no | Custom data entries; present when `customDatas` is enabled in `InfoRequestParam`. — _elementCls=GenericModels.DataItem_ |
| `displayName` | `string?` | no | Display name of the character; present when requested. |
| `avatar` | `GenericModels.AvatarItem?` | no | Avatar descriptor; present when requested. |
| `tsCreate` | `long?` | no | Creation timestamp of the character; present when requested. |
| `tags` | `List<GenericModels.TagItem>?` | no | Tag entries assigned to the character. — _elementCls=GenericModels.TagItem_ |
| `playerBan` | `GenericModels.BanItem?` | no | Ban state of the character; present when requested and a ban exists. |
| `playerDatas` | `List<GenericModels.DataItem>?` | no | Player data entries; present when `playerDatas` is enabled in `InfoRequestParam`. — _elementCls=GenericModels.DataItem_ |
| `playerCurrencies` | `List<GenericModels.CurrencyItem>?` | no | Currency balances; present when `playerCurrencies` is enabled. — _elementCls=GenericModels.CurrencyItem_ |
| `playerStatistics` | `List<GenericModels.StatisticsItem>?` | no | Statistics values; present when `playerStatistics` is enabled. — _elementCls=GenericModels.StatisticsItem_ |
| `playerInventories` | `List<GenericModels.InventoryItem>?` | no | Lightweight relation items for inventory owned by the character. — _elementCls=GenericModels.InventoryItem_ |
| `playerGroups` | `List<GenericModels.GroupItem>?` | no | Lightweight relation items for groups attached to the character. — _elementCls=GenericModels.GroupItem_ |
| `playerFriends` | `List<GenericModels.FriendItem>?` | no | Lightweight relation items for friends attached to the character. — _elementCls=GenericModels.FriendItem_ |
| `tsLastLogin` | `long?` | no | Timestamp of the character's last login; present when requested. |
| `ipAddressCreate` | `string?` | no | IP address recorded at character creation; present when requested. |
| `countryCode` | `string?` | no | Country code associated with the character; present when requested. |

Reference links:

- [CharacterPlayerModels.InfoRequestParam:1-36](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforequestparam)
- [Generic.OwnerItem:71-80](/docs/reference/dto/generic/GENERIC_MODELS.md#owneritem)
- [Generic.RemoveStatusItem:81-90](/docs/reference/dto/generic/GENERIC_MODELS.md#removestatusitem)
- [Generic.DataItem:31-40](/docs/reference/dto/generic/GENERIC_MODELS.md#dataitem)
- [Generic.AvatarItem:1-10](/docs/reference/dto/generic/GENERIC_MODELS.md#avataritem)
- [Generic.TagItem:11-20](/docs/reference/dto/generic/GENERIC_MODELS.md#tagitem)
- [Generic.BanItem:21-30](/docs/reference/dto/generic/GENERIC_MODELS.md#banitem)
- [Generic.CurrencyItem:41-50](/docs/reference/dto/generic/GENERIC_MODELS.md#currencyitem)
- [Generic.StatisticsItem:51-60](/docs/reference/dto/generic/GENERIC_MODELS.md#statisticsitem)
- [Generic.InventoryItem:91-101](/docs/reference/dto/generic/GENERIC_MODELS.md#inventoryitem)
- [Generic.GroupItem:102-113](/docs/reference/dto/generic/GENERIC_MODELS.md#groupitem)
- [Generic.FriendItem:114-125](/docs/reference/dto/generic/GENERIC_MODELS.md#frienditem)

### CharacterPlayerResponseData

Base character-player response envelope.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoResponseParameters` | `InfoResponseParameters` | yes | Optional field bag controlled by the corresponding `InfoRequestParam`. |

Reference links:

- [CharacterPlayerModels.InfoResponseParameters:2043-2084](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforesponseparameters)
- [CharacterPlayerModels.InfoRequestParam:1-36](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforequestparam)

### CharacterPlayerWithCharacterIdResponseData

Extends: `CharacterPlayerResponseData`

Character-player envelope that also exposes the resolved character ID.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `CharacterPlayerResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | Character identifier. |

Reference links:

- [CharacterPlayerModels.CharacterPlayerResponseData:2085-2098](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#characterplayerresponsedata)

### CharacterPlayerLeaderboardResponseData

Extends: `CharacterPlayerWithCharacterIdResponseData`

Defines the response payload for CharacterPlayerLeaderboard.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `CharacterPlayerWithCharacterIdResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `position` | `int` | yes | Zero-based leaderboard rank position of this character. |
| `backupValue` | `double?` | no | Backup statistic or currency value used as a tiebreaker when present. |

Reference links:

- [CharacterPlayerModels.CharacterPlayerResponseData:2085-2098](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#characterplayerresponsedata)
- [CharacterPlayerModels.CharacterPlayerWithCharacterIdResponseData:2085-2115](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#characterplayerwithcharacteridresponsedata)

### CharacterPlayerLogResponseData

Defines the response payload for CharacterPlayerLog.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | Character identifier this log entry belongs to. |
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
| `results` | `List<CharacterPlayerLeaderboardResponseData>` | yes | _elementCls=CharacterPlayerLeaderboardResponseData_ |
| `tsCreate` | `long?` | no | Snapshot timestamp used for this leaderboard page when returned by the backend. |

Reference links:

- [CharacterPlayerModels.CharacterPlayerLeaderboardResponseData:2085-2134](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#characterplayerleaderboardresponsedata)

### CharacterPlayersWithCharacterIdResponseData

Defines the response payload for CharacterPlayersWithCharacterId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<CharacterPlayerWithCharacterIdResponseData>` | yes | _elementCls=CharacterPlayerWithCharacterIdResponseData_ |

Reference links:

- [CharacterPlayerModels.CharacterPlayerWithCharacterIdResponseData:2085-2115](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#characterplayerwithcharacteridresponsedata)

### GetCurrencyLeaderboardResponseData

Defines the response payload for GetCurrencyLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<CharacterPlayerLeaderboardResponseData>` | yes | _elementCls=CharacterPlayerLeaderboardResponseData_ |

Reference links:

- [CharacterPlayerModels.CharacterPlayerLeaderboardResponseData:2085-2134](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#characterplayerleaderboardresponsedata)

### GetCreateLeaderboardResponseData

Defines the response payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<CharacterPlayerLeaderboardResponseData>` | yes | _elementCls=CharacterPlayerLeaderboardResponseData_ |

Reference links:

- [CharacterPlayerModels.CharacterPlayerLeaderboardResponseData:2085-2134](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#characterplayerleaderboardresponsedata)

### GetLastLoginLeaderboardResponseData

Defines the response payload for GetLastLoginLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<CharacterPlayerLeaderboardResponseData>` | yes | _elementCls=CharacterPlayerLeaderboardResponseData_ |

Reference links:

- [CharacterPlayerModels.CharacterPlayerLeaderboardResponseData:2085-2134](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#characterplayerleaderboardresponsedata)

### GetStatisticsLogResponseData

Returns one page of statistics logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<CharacterPlayerLogResponseData>` | yes | _elementCls=CharacterPlayerLogResponseData_ |
| `token` | `string?` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

Reference links:

- [CharacterPlayerModels.CharacterPlayerLogResponseData:2135-2149](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#characterplayerlogresponsedata)

### GetCurrencyLogResponseData

Returns one page of currency logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<CharacterPlayerLogResponseData>` | yes | _elementCls=CharacterPlayerLogResponseData_ |
| `token` | `string?` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

Reference links:

- [CharacterPlayerModels.CharacterPlayerLogResponseData:2135-2149](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#characterplayerlogresponsedata)

### EmptyResponseData

Defines an intentionally empty response payload.

_Không có field public (payload rỗng)._
