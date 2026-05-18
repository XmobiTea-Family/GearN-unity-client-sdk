### InfoRequestParam

Selects which optional group fields and lightweight relations should be returned. Boolean flags default to `false`; key arrays narrow list-style fields to specific keys only.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `catalogId` | `bool?` | no | Includes the group catalog ID. — _default=false_ |
| `members` | `bool?` | no | Includes lightweight member items for the group. — _default=false_ |
| `removeStatus` | `bool?` | no | _default=false_ |
| `segments` | `bool?` | no | _default=false_ |
| `customDatas` | `bool?` | no | _default=false_ |
| `displayName` | `bool?` | no | _default=false_ |
| `avatar` | `bool?` | no | _default=false_ |
| `tsCreate` | `bool?` | no | _default=false_ |
| `tags` | `bool?` | no | _default=false_ |
| `groupCurrencies` | `bool?` | no | _default=false_ |
| `groupStatistics` | `bool?` | no | _default=false_ |
| `groupDatas` | `bool?` | no | _default=false_ |
| `groupInventories` | `bool?` | no | Includes lightweight inventory relation items for the group, optionally filtered by `itemCatalogIds`. — _default=false_ |
| `groupDataKeys` | `List<string>?` | no | _elementCls=String_ |
| `groupCurrencyKeys` | `List<string>?` | no | _elementCls=String_ |
| `groupStatisticsKeys` | `List<string>?` | no | _elementCls=String_ |
| `customDataKeys` | `List<string>?` | no | _elementCls=String_ |
| `tagKeys` | `List<string>?` | no | _elementCls=String_ |
| `itemCatalogIds` | `List<string>?` | no | Restricts `groupInventories` to relation items whose catalog IDs match this list. — _elementCls=String_ |

### CustomDataParam

Defines the reusable parameter block CustomDataParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `object` | yes | Arbitrary value to store for this custom data key. May be a primitive, `GNHashtable`, or `GNArray`. |

### GroupCurrencyParam

Defines the reusable parameter block GroupCurrencyParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `amount` | `double` | yes | Currency amount delta to apply (positive to add, negative to subtract). |

### GroupDataParam

Defines the reusable parameter block GroupDataParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `object` | yes | Arbitrary value to store for this group data key. May be a primitive, `GNHashtable`, or `GNArray`. |

### GroupMemberParam

Describes one game-player member referenced by a group workflow.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | _minLength=10, maxLength=11_ |

### GroupStatisticsParam

Defines the reusable parameter block GroupStatisticsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `double` | yes | Statistic value to apply; interpretation depends on the configured aggregation method. |

### AddMemberRequestData

Defines the request payload for AddMember.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `memberId` | `string` | yes | _minLength=10, maxLength=11_ |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerAddMemberRequestData

Extends: `AddMemberRequestData`

Defines the request payload for ServerAddMember.

_Không khai báo field mới; kế thừa toàn bộ field từ `AddMemberRequestData`._

Reference links:

- [GroupModels.AddMemberRequestData:77-86](/docs/reference/dto/group/GROUP_MODELS.md#addmemberrequestdata)

### AdminAddMemberRequestData

Extends: `ServerAddMemberRequestData`

Defines the request payload for AdminAddMember.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerAddMemberRequestData`._

Reference links:

- [GroupModels.ServerAddMemberRequestData:77-98](/docs/reference/dto/group/GROUP_MODELS.md#serveraddmemberrequestdata)

### AddSegmentRequestData

Defines the request payload for AddSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `value` | `string` | yes | _minLength=6, maxLength=32_ |

### ServerAddSegmentRequestData

Extends: `AddSegmentRequestData`

Defines the request payload for ServerAddSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `AddSegmentRequestData`._

Reference links:

- [GroupModels.AddSegmentRequestData:111-120](/docs/reference/dto/group/GROUP_MODELS.md#addsegmentrequestdata)

### AdminAddSegmentRequestData

Extends: `ServerAddSegmentRequestData`

Defines the request payload for AdminAddSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerAddSegmentRequestData`._

Reference links:

- [GroupModels.ServerAddSegmentRequestData:111-132](/docs/reference/dto/group/GROUP_MODELS.md#serveraddsegmentrequestdata)

### GetAvatarRequestData

Defines the request payload for GetAvatar.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerGetAvatarRequestData

Extends: `GetAvatarRequestData`

Defines the request payload for ServerGetAvatar.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetAvatarRequestData`._

Reference links:

- [GroupModels.GetAvatarRequestData:145-153](/docs/reference/dto/group/GROUP_MODELS.md#getavatarrequestdata)

### AdminGetAvatarRequestData

Extends: `ServerGetAvatarRequestData`

Defines the request payload for AdminGetAvatar.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetAvatarRequestData`._

Reference links:

- [GroupModels.ServerGetAvatarRequestData:145-165](/docs/reference/dto/group/GROUP_MODELS.md#servergetavatarrequestdata)

### GetCatalogIdRequestData

Defines the request payload for GetCatalogId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerGetCatalogIdRequestData

Extends: `GetCatalogIdRequestData`

Defines the request payload for ServerGetCatalogId.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCatalogIdRequestData`._

Reference links:

- [GroupModels.GetCatalogIdRequestData:178-186](/docs/reference/dto/group/GROUP_MODELS.md#getcatalogidrequestdata)

### AdminGetCatalogIdRequestData

Extends: `ServerGetCatalogIdRequestData`

Defines the request payload for AdminGetCatalogId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCatalogIdRequestData`._

Reference links:

- [GroupModels.ServerGetCatalogIdRequestData:178-198](/docs/reference/dto/group/GROUP_MODELS.md#servergetcatalogidrequestdata)

### GetCustomDataRequestData

Defines the request payload for GetCustomData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `customDataKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetCustomDataRequestData

Extends: `GetCustomDataRequestData`

Defines the request payload for ServerGetCustomData.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCustomDataRequestData`._

Reference links:

- [GroupModels.GetCustomDataRequestData:211-220](/docs/reference/dto/group/GROUP_MODELS.md#getcustomdatarequestdata)

### AdminGetCustomDataRequestData

Extends: `ServerGetCustomDataRequestData`

Defines the request payload for AdminGetCustomData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCustomDataRequestData`._

Reference links:

- [GroupModels.ServerGetCustomDataRequestData:211-232](/docs/reference/dto/group/GROUP_MODELS.md#servergetcustomdatarequestdata)

### GetDisplayNameRequestData

Defines the request payload for GetDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerGetDisplayNameRequestData

Extends: `GetDisplayNameRequestData`

Defines the request payload for ServerGetDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetDisplayNameRequestData`._

Reference links:

- [GroupModels.GetDisplayNameRequestData:245-253](/docs/reference/dto/group/GROUP_MODELS.md#getdisplaynamerequestdata)

### AdminGetDisplayNameRequestData

Extends: `ServerGetDisplayNameRequestData`

Defines the request payload for AdminGetDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetDisplayNameRequestData`._

Reference links:

- [GroupModels.ServerGetDisplayNameRequestData:245-265](/docs/reference/dto/group/GROUP_MODELS.md#servergetdisplaynamerequestdata)

### GetGroupCurrencyRequestData

Defines the request payload for GetGroupCurrency.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `groupCurrencyKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetGroupCurrencyRequestData

Extends: `GetGroupCurrencyRequestData`

Defines the request payload for ServerGetGroupCurrency.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetGroupCurrencyRequestData`._

Reference links:

- [GroupModels.GetGroupCurrencyRequestData:278-287](/docs/reference/dto/group/GROUP_MODELS.md#getgroupcurrencyrequestdata)

### AdminGetGroupCurrencyRequestData

Extends: `ServerGetGroupCurrencyRequestData`

Defines the request payload for AdminGetGroupCurrency.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetGroupCurrencyRequestData`._

Reference links:

- [GroupModels.ServerGetGroupCurrencyRequestData:278-299](/docs/reference/dto/group/GROUP_MODELS.md#servergetgroupcurrencyrequestdata)

### GetGroupDataRequestData

Defines the request payload for GetGroupData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `groupDataKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetGroupDataRequestData

Extends: `GetGroupDataRequestData`

Defines the request payload for ServerGetGroupData.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetGroupDataRequestData`._

Reference links:

- [GroupModels.GetGroupDataRequestData:312-321](/docs/reference/dto/group/GROUP_MODELS.md#getgroupdatarequestdata)

### AdminGetGroupDataRequestData

Extends: `ServerGetGroupDataRequestData`

Defines the request payload for AdminGetGroupData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetGroupDataRequestData`._

Reference links:

- [GroupModels.ServerGetGroupDataRequestData:312-333](/docs/reference/dto/group/GROUP_MODELS.md#servergetgroupdatarequestdata)

### GetGroupInformationRequestData

Defines the request payload for GetGroupInformation.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional group fields are included in the response. |

Reference links:

- [GroupModels.InfoRequestParam:1-27](/docs/reference/dto/group/GROUP_MODELS.md#inforequestparam)

### ServerGetGroupInformationRequestData

Extends: `GetGroupInformationRequestData`

Defines the request payload for ServerGetGroupInformation.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetGroupInformationRequestData`._

Reference links:

- [GroupModels.GetGroupInformationRequestData:346-359](/docs/reference/dto/group/GROUP_MODELS.md#getgroupinformationrequestdata)

### AdminGetGroupInformationRequestData

Extends: `ServerGetGroupInformationRequestData`

Defines the request payload for AdminGetGroupInformation.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetGroupInformationRequestData`._

Reference links:

- [GroupModels.ServerGetGroupInformationRequestData:346-371](/docs/reference/dto/group/GROUP_MODELS.md#servergetgroupinformationrequestdata)

### GetGroupInventoryRequestData

Defines the request payload for GetGroupInventory.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `itemCatalogIds` | `List<string>?` | no | _elementCls=String_ |

### ServerGetGroupInventoryRequestData

Extends: `GetGroupInventoryRequestData`

Defines the request payload for ServerGetGroupInventory.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetGroupInventoryRequestData`._

Reference links:

- [GroupModels.GetGroupInventoryRequestData:384-393](/docs/reference/dto/group/GROUP_MODELS.md#getgroupinventoryrequestdata)

### AdminGetGroupInventoryRequestData

Extends: `ServerGetGroupInventoryRequestData`

Defines the request payload for AdminGetGroupInventory.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetGroupInventoryRequestData`._

Reference links:

- [GroupModels.ServerGetGroupInventoryRequestData:384-405](/docs/reference/dto/group/GROUP_MODELS.md#servergetgroupinventoryrequestdata)

### GetGroupMessageRequestData

Reads persisted group messages using skip/limit pagination.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

### ServerGetGroupMessageRequestData

Extends: `GetGroupMessageRequestData`

Defines the request payload for ServerGetGroupMessage.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetGroupMessageRequestData`._

Reference links:

- [GroupModels.GetGroupMessageRequestData:418-428](/docs/reference/dto/group/GROUP_MODELS.md#getgroupmessagerequestdata)

### AdminGetGroupMessageRequestData

Extends: `ServerGetGroupMessageRequestData`

Defines the request payload for AdminGetGroupMessage.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetGroupMessageRequestData`._

Reference links:

- [GroupModels.ServerGetGroupMessageRequestData:418-440](/docs/reference/dto/group/GROUP_MODELS.md#servergetgroupmessagerequestdata)

### GetGroupStatisticsRequestData

Defines the request payload for GetGroupStatistics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `statisticsKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetGroupStatisticsRequestData

Extends: `GetGroupStatisticsRequestData`

Defines the request payload for ServerGetGroupStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetGroupStatisticsRequestData`._

Reference links:

- [GroupModels.GetGroupStatisticsRequestData:453-462](/docs/reference/dto/group/GROUP_MODELS.md#getgroupstatisticsrequestdata)

### AdminGetGroupStatisticsRequestData

Extends: `ServerGetGroupStatisticsRequestData`

Defines the request payload for AdminGetGroupStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetGroupStatisticsRequestData`._

Reference links:

- [GroupModels.ServerGetGroupStatisticsRequestData:453-474](/docs/reference/dto/group/GROUP_MODELS.md#servergetgroupstatisticsrequestdata)

### GetGroupsWithDisplayNameRequestData

Defines the request payload for GetGroupsWithDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keyword` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional group fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

Reference links:

- [GroupModels.InfoRequestParam:1-27](/docs/reference/dto/group/GROUP_MODELS.md#inforequestparam)

### ServerGetGroupsWithDisplayNameRequestData

Extends: `GetGroupsWithDisplayNameRequestData`

Defines the request payload for ServerGetGroupsWithDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetGroupsWithDisplayNameRequestData`._

Reference links:

- [GroupModels.GetGroupsWithDisplayNameRequestData:487-502](/docs/reference/dto/group/GROUP_MODELS.md#getgroupswithdisplaynamerequestdata)

### AdminGetGroupsWithDisplayNameRequestData

Extends: `ServerGetGroupsWithDisplayNameRequestData`

Defines the request payload for AdminGetGroupsWithDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetGroupsWithDisplayNameRequestData`._

Reference links:

- [GroupModels.ServerGetGroupsWithDisplayNameRequestData:487-514](/docs/reference/dto/group/GROUP_MODELS.md#servergetgroupswithdisplaynamerequestdata)

### GetGroupsWithSegmentRequestData

Defines the request payload for GetGroupsWithSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional group fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

Reference links:

- [GroupModels.InfoRequestParam:1-27](/docs/reference/dto/group/GROUP_MODELS.md#inforequestparam)

### ServerGetGroupsWithSegmentRequestData

Extends: `GetGroupsWithSegmentRequestData`

Defines the request payload for ServerGetGroupsWithSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetGroupsWithSegmentRequestData`._

Reference links:

- [GroupModels.GetGroupsWithSegmentRequestData:527-542](/docs/reference/dto/group/GROUP_MODELS.md#getgroupswithsegmentrequestdata)

### AdminGetGroupsWithSegmentRequestData

Extends: `ServerGetGroupsWithSegmentRequestData`

Defines the request payload for AdminGetGroupsWithSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetGroupsWithSegmentRequestData`._

Reference links:

- [GroupModels.ServerGetGroupsWithSegmentRequestData:527-554](/docs/reference/dto/group/GROUP_MODELS.md#servergetgroupswithsegmentrequestdata)

### GetGroupsWithTagRequestData

Defines the request payload for GetGroupsWithTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional group fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

Reference links:

- [GroupModels.InfoRequestParam:1-27](/docs/reference/dto/group/GROUP_MODELS.md#inforequestparam)

### ServerGetGroupsWithTagRequestData

Extends: `GetGroupsWithTagRequestData`

Defines the request payload for ServerGetGroupsWithTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetGroupsWithTagRequestData`._

Reference links:

- [GroupModels.GetGroupsWithTagRequestData:567-583](/docs/reference/dto/group/GROUP_MODELS.md#getgroupswithtagrequestdata)

### AdminGetGroupsWithTagRequestData

Extends: `ServerGetGroupsWithTagRequestData`

Defines the request payload for AdminGetGroupsWithTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetGroupsWithTagRequestData`._

Reference links:

- [GroupModels.ServerGetGroupsWithTagRequestData:567-595](/docs/reference/dto/group/GROUP_MODELS.md#servergetgroupswithtagrequestdata)

### GetMembersRequestData

Defines the request payload for GetMembers.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerGetMembersRequestData

Extends: `GetMembersRequestData`

Defines the request payload for ServerGetMembers.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetMembersRequestData`._

Reference links:

- [GroupModels.GetMembersRequestData:608-616](/docs/reference/dto/group/GROUP_MODELS.md#getmembersrequestdata)

### AdminGetMembersRequestData

Extends: `ServerGetMembersRequestData`

Defines the request payload for AdminGetMembers.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetMembersRequestData`._

Reference links:

- [GroupModels.ServerGetMembersRequestData:608-628](/docs/reference/dto/group/GROUP_MODELS.md#servergetmembersrequestdata)

### GetRemoveStatusRequestData

Defines the request payload for GetRemoveStatus.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerGetRemoveStatusRequestData

Extends: `GetRemoveStatusRequestData`

Defines the request payload for ServerGetRemoveStatus.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetRemoveStatusRequestData`._

Reference links:

- [GroupModels.GetRemoveStatusRequestData:641-649](/docs/reference/dto/group/GROUP_MODELS.md#getremovestatusrequestdata)

### AdminGetRemoveStatusRequestData

Extends: `ServerGetRemoveStatusRequestData`

Defines the request payload for AdminGetRemoveStatus.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetRemoveStatusRequestData`._

Reference links:

- [GroupModels.ServerGetRemoveStatusRequestData:641-661](/docs/reference/dto/group/GROUP_MODELS.md#servergetremovestatusrequestdata)

### GetSegmentRequestData

Defines the request payload for GetSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerGetSegmentRequestData

Extends: `GetSegmentRequestData`

Defines the request payload for ServerGetSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetSegmentRequestData`._

Reference links:

- [GroupModels.GetSegmentRequestData:674-682](/docs/reference/dto/group/GROUP_MODELS.md#getsegmentrequestdata)

### AdminGetSegmentRequestData

Extends: `ServerGetSegmentRequestData`

Defines the request payload for AdminGetSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetSegmentRequestData`._

Reference links:

- [GroupModels.ServerGetSegmentRequestData:674-694](/docs/reference/dto/group/GROUP_MODELS.md#servergetsegmentrequestdata)

### GetStatisticsLeaderboardAroundGroupRequestData

Defines the request payload for GetStatisticsLeaderboardAroundGroup.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional group fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |
| `catalogId` | `string?` | no | _minLength=2, maxLength=32_ |

Reference links:

- [GroupModels.InfoRequestParam:1-27](/docs/reference/dto/group/GROUP_MODELS.md#inforequestparam)

### ServerGetStatisticsLeaderboardAroundGroupRequestData

Extends: `GetStatisticsLeaderboardAroundGroupRequestData`

Defines the request payload for ServerGetStatisticsLeaderboardAroundGroup.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetStatisticsLeaderboardAroundGroupRequestData`._

Reference links:

- [GroupModels.GetStatisticsLeaderboardAroundGroupRequestData:707-725](/docs/reference/dto/group/GROUP_MODELS.md#getstatisticsleaderboardaroundgrouprequestdata)

### AdminGetStatisticsLeaderboardAroundGroupRequestData

Extends: `ServerGetStatisticsLeaderboardAroundGroupRequestData`

Defines the request payload for AdminGetStatisticsLeaderboardAroundGroup.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStatisticsLeaderboardAroundGroupRequestData`._

Reference links:

- [GroupModels.ServerGetStatisticsLeaderboardAroundGroupRequestData:707-737](/docs/reference/dto/group/GROUP_MODELS.md#servergetstatisticsleaderboardaroundgrouprequestdata)

### GetStatisticsLeaderboardRequestData

Defines the request payload for GetStatisticsLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional group fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |
| `version` | `string?` | no | _minLength=2, maxLength=32_ |
| `catalogId` | `string?` | no | _minLength=2, maxLength=32_ |

Reference links:

- [GroupModels.InfoRequestParam:1-27](/docs/reference/dto/group/GROUP_MODELS.md#inforequestparam)

### ServerGetStatisticsLeaderboardRequestData

Extends: `GetStatisticsLeaderboardRequestData`

Defines the request payload for ServerGetStatisticsLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetStatisticsLeaderboardRequestData`._

Reference links:

- [GroupModels.GetStatisticsLeaderboardRequestData:750-768](/docs/reference/dto/group/GROUP_MODELS.md#getstatisticsleaderboardrequestdata)

### AdminGetStatisticsLeaderboardRequestData

Extends: `ServerGetStatisticsLeaderboardRequestData`

Defines the request payload for AdminGetStatisticsLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStatisticsLeaderboardRequestData`._

Reference links:

- [GroupModels.ServerGetStatisticsLeaderboardRequestData:750-780](/docs/reference/dto/group/GROUP_MODELS.md#servergetstatisticsleaderboardrequestdata)

### GetCreateLeaderboardRequestData

Defines the request payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional group fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Reference links:

- [GroupModels.InfoRequestParam:1-27](/docs/reference/dto/group/GROUP_MODELS.md#inforequestparam)

### ServerGetCreateLeaderboardRequestData

Extends: `GetCreateLeaderboardRequestData`

Defines the request payload for ServerGetCreateLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCreateLeaderboardRequestData`._

Reference links:

- [GroupModels.GetCreateLeaderboardRequestData:793-808](/docs/reference/dto/group/GROUP_MODELS.md#getcreateleaderboardrequestdata)

### AdminGetCreateLeaderboardRequestData

Extends: `ServerGetCreateLeaderboardRequestData`

Defines the request payload for AdminGetCreateLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCreateLeaderboardRequestData`._

Reference links:

- [GroupModels.ServerGetCreateLeaderboardRequestData:793-820](/docs/reference/dto/group/GROUP_MODELS.md#servergetcreateleaderboardrequestdata)

### GetTagRequestData

Defines the request payload for GetTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `tagKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetTagRequestData

Extends: `GetTagRequestData`

Defines the request payload for ServerGetTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetTagRequestData`._

Reference links:

- [GroupModels.GetTagRequestData:833-842](/docs/reference/dto/group/GROUP_MODELS.md#gettagrequestdata)

### AdminGetTagRequestData

Extends: `ServerGetTagRequestData`

Defines the request payload for AdminGetTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetTagRequestData`._

Reference links:

- [GroupModels.ServerGetTagRequestData:833-854](/docs/reference/dto/group/GROUP_MODELS.md#servergettagrequestdata)

### GetTsCreateRequestData

Defines the request payload for GetTsCreate.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerGetTsCreateRequestData

Extends: `GetTsCreateRequestData`

Defines the request payload for ServerGetTsCreate.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetTsCreateRequestData`._

Reference links:

- [GroupModels.GetTsCreateRequestData:867-875](/docs/reference/dto/group/GROUP_MODELS.md#gettscreaterequestdata)

### AdminGetTsCreateRequestData

Extends: `ServerGetTsCreateRequestData`

Defines the request payload for AdminGetTsCreate.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetTsCreateRequestData`._

Reference links:

- [GroupModels.ServerGetTsCreateRequestData:867-887](/docs/reference/dto/group/GROUP_MODELS.md#servergettscreaterequestdata)

### CreateGroupItemRequestData

Defines the request payload for CreateGroupItem.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `catalogId` | `string` | yes | _minLength=2, maxLength=32_ |
| `classId` | `string` | yes | _minLength=2, maxLength=32_ |
| `displayName` | `string?` | no | _default=""_ |
| `amount` | `int?` | no | _default=1_ |

### ServerCreateGroupItemRequestData

Extends: `CreateGroupItemRequestData`

Defines the request payload for ServerCreateGroupItem.

_Không khai báo field mới; kế thừa toàn bộ field từ `CreateGroupItemRequestData`._

Reference links:

- [GroupModels.CreateGroupItemRequestData:900-912](/docs/reference/dto/group/GROUP_MODELS.md#creategroupitemrequestdata)

### AdminCreateGroupItemRequestData

Extends: `ServerCreateGroupItemRequestData`

Defines the request payload for AdminCreateGroupItem.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerCreateGroupItemRequestData`._

Reference links:

- [GroupModels.ServerCreateGroupItemRequestData:900-924](/docs/reference/dto/group/GROUP_MODELS.md#servercreategroupitemrequestdata)

### RemoveGroupItemRequestData

Defines the request payload for RemoveGroupItem.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerRemoveGroupItemRequestData

Extends: `RemoveGroupItemRequestData`

Defines the request payload for ServerRemoveGroupItem.

_Không khai báo field mới; kế thừa toàn bộ field từ `RemoveGroupItemRequestData`._

Reference links:

- [GroupModels.RemoveGroupItemRequestData:937-946](/docs/reference/dto/group/GROUP_MODELS.md#removegroupitemrequestdata)

### AdminRemoveGroupItemRequestData

Extends: `ServerRemoveGroupItemRequestData`

Defines the request payload for AdminRemoveGroupItem.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemoveGroupItemRequestData`._

Reference links:

- [GroupModels.ServerRemoveGroupItemRequestData:937-958](/docs/reference/dto/group/GROUP_MODELS.md#serverremovegroupitemrequestdata)

### RemoveMemberRequestData

Defines the request payload for RemoveMember.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `memberId` | `string` | yes | _minLength=10, maxLength=11_ |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerRemoveMemberRequestData

Extends: `RemoveMemberRequestData`

Defines the request payload for ServerRemoveMember.

_Không khai báo field mới; kế thừa toàn bộ field từ `RemoveMemberRequestData`._

Reference links:

- [GroupModels.RemoveMemberRequestData:971-980](/docs/reference/dto/group/GROUP_MODELS.md#removememberrequestdata)

### AdminRemoveMemberRequestData

Extends: `ServerRemoveMemberRequestData`

Defines the request payload for AdminRemoveMember.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemoveMemberRequestData`._

Reference links:

- [GroupModels.ServerRemoveMemberRequestData:971-992](/docs/reference/dto/group/GROUP_MODELS.md#serverremovememberrequestdata)

### RemoveSegmentRequestData

Defines the request payload for RemoveSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerRemoveSegmentRequestData

Extends: `RemoveSegmentRequestData`

Defines the request payload for ServerRemoveSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `RemoveSegmentRequestData`._

Reference links:

- [GroupModels.RemoveSegmentRequestData:1005-1014](/docs/reference/dto/group/GROUP_MODELS.md#removesegmentrequestdata)

### AdminRemoveSegmentRequestData

Extends: `ServerRemoveSegmentRequestData`

Defines the request payload for AdminRemoveSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemoveSegmentRequestData`._

Reference links:

- [GroupModels.ServerRemoveSegmentRequestData:1005-1026](/docs/reference/dto/group/GROUP_MODELS.md#serverremovesegmentrequestdata)

### RemoveTagRequestData

Defines the request payload for RemoveTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerRemoveTagRequestData

Extends: `RemoveTagRequestData`

Defines the request payload for ServerRemoveTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `RemoveTagRequestData`._

Reference links:

- [GroupModels.RemoveTagRequestData:1039-1048](/docs/reference/dto/group/GROUP_MODELS.md#removetagrequestdata)

### AdminRemoveTagRequestData

Extends: `ServerRemoveTagRequestData`

Defines the request payload for AdminRemoveTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemoveTagRequestData`._

Reference links:

- [GroupModels.ServerRemoveTagRequestData:1039-1060](/docs/reference/dto/group/GROUP_MODELS.md#serverremovetagrequestdata)

### SendGroupMessageRequestData

Sends a group message through the HTTP group workflow. `senderId` is always required and must identify the logical sender explicitly.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `senderId` | `string` | yes | _minLength=10, maxLength=11_ |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `message` | `string` | yes | _minLength=2, maxLength=256_ |

### ServerSendGroupMessageRequestData

Extends: `SendGroupMessageRequestData`

Defines the request payload for ServerSendGroupMessage.

_Không khai báo field mới; kế thừa toàn bộ field từ `SendGroupMessageRequestData`._

Reference links:

- [GroupModels.SendGroupMessageRequestData:1073-1083](/docs/reference/dto/group/GROUP_MODELS.md#sendgroupmessagerequestdata)

### AdminSendGroupMessageRequestData

Extends: `ServerSendGroupMessageRequestData`

Defines the request payload for AdminSendGroupMessage.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSendGroupMessageRequestData`._

Reference links:

- [GroupModels.ServerSendGroupMessageRequestData:1073-1095](/docs/reference/dto/group/GROUP_MODELS.md#serversendgroupmessagerequestdata)

### SetAvatarRequestData

Defines the request payload for SetAvatar.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `type` | `int` | yes | App-defined avatar type integer; not mapped to a built-in GearN enum. |
| `value` | `string` | yes | Avatar value such as a URL, file ID, or provider-specific string. — _minLength=1, maxLength=128_ |

### ServerSetAvatarRequestData

Extends: `SetAvatarRequestData`

Defines the request payload for ServerSetAvatar.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetAvatarRequestData`._

Reference links:

- [GroupModels.SetAvatarRequestData:1108-1118](/docs/reference/dto/group/GROUP_MODELS.md#setavatarrequestdata)

### AdminSetAvatarRequestData

Extends: `ServerSetAvatarRequestData`

Defines the request payload for AdminSetAvatar.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetAvatarRequestData`._

Reference links:

- [GroupModels.ServerSetAvatarRequestData:1108-1130](/docs/reference/dto/group/GROUP_MODELS.md#serversetavatarrequestdata)

### SetCustomDataRequestData

Defines the request payload for SetCustomData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `customDatas` | `List<CustomDataParam>` | yes | _minLength=1, maxLength=32, elementCls=CustomDataParam_ |

Reference links:

- [GroupModels.CustomDataParam:28-37](/docs/reference/dto/group/GROUP_MODELS.md#customdataparam)

### ServerSetCustomDataRequestData

Extends: `SetCustomDataRequestData`

Defines the request payload for ServerSetCustomData.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetCustomDataRequestData`._

Reference links:

- [GroupModels.SetCustomDataRequestData:1143-1156](/docs/reference/dto/group/GROUP_MODELS.md#setcustomdatarequestdata)

### AdminSetCustomDataRequestData

Extends: `ServerSetCustomDataRequestData`

Defines the request payload for AdminSetCustomData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetCustomDataRequestData`._

Reference links:

- [GroupModels.ServerSetCustomDataRequestData:1143-1168](/docs/reference/dto/group/GROUP_MODELS.md#serversetcustomdatarequestdata)

### SetDisplayNameRequestData

Defines the request payload for SetDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `displayName` | `string` | yes | _minLength=5, maxLength=32_ |

### ServerSetDisplayNameRequestData

Extends: `SetDisplayNameRequestData`

Defines the request payload for ServerSetDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetDisplayNameRequestData`._

Reference links:

- [GroupModels.SetDisplayNameRequestData:1181-1190](/docs/reference/dto/group/GROUP_MODELS.md#setdisplaynamerequestdata)

### AdminSetDisplayNameRequestData

Extends: `ServerSetDisplayNameRequestData`

Defines the request payload for AdminSetDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetDisplayNameRequestData`._

Reference links:

- [GroupModels.ServerSetDisplayNameRequestData:1181-1202](/docs/reference/dto/group/GROUP_MODELS.md#serversetdisplaynamerequestdata)

### ChangeGroupCurrencyRequestData

Defines the request payload for ChangeGroupCurrency.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `groupCurrencies` | `List<GroupCurrencyParam>` | yes | _minLength=1, maxLength=32, elementCls=GroupCurrencyParam_ |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

Reference links:

- [GroupModels.GroupCurrencyParam:38-47](/docs/reference/dto/group/GROUP_MODELS.md#groupcurrencyparam)

### ServerChangeGroupCurrencyRequestData

Extends: `ChangeGroupCurrencyRequestData`

Defines the request payload for ServerChangeGroupCurrency.

_Không khai báo field mới; kế thừa toàn bộ field từ `ChangeGroupCurrencyRequestData`._

Reference links:

- [GroupModels.ChangeGroupCurrencyRequestData:1215-1229](/docs/reference/dto/group/GROUP_MODELS.md#changegroupcurrencyrequestdata)

### AdminChangeGroupCurrencyRequestData

Extends: `ServerChangeGroupCurrencyRequestData`

Defines the request payload for AdminChangeGroupCurrency.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerChangeGroupCurrencyRequestData`._

Reference links:

- [GroupModels.ServerChangeGroupCurrencyRequestData:1215-1241](/docs/reference/dto/group/GROUP_MODELS.md#serverchangegroupcurrencyrequestdata)

### SetGroupDataRequestData

Defines the request payload for SetGroupData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `groupDatas` | `List<GroupDataParam>` | yes | _minLength=1, maxLength=32, elementCls=GroupDataParam_ |

Reference links:

- [GroupModels.GroupDataParam:48-57](/docs/reference/dto/group/GROUP_MODELS.md#groupdataparam)

### ServerSetGroupDataRequestData

Extends: `SetGroupDataRequestData`

Defines the request payload for ServerSetGroupData.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetGroupDataRequestData`._

Reference links:

- [GroupModels.SetGroupDataRequestData:1254-1267](/docs/reference/dto/group/GROUP_MODELS.md#setgroupdatarequestdata)

### AdminSetGroupDataRequestData

Extends: `ServerSetGroupDataRequestData`

Defines the request payload for AdminSetGroupData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetGroupDataRequestData`._

Reference links:

- [GroupModels.ServerSetGroupDataRequestData:1254-1279](/docs/reference/dto/group/GROUP_MODELS.md#serversetgroupdatarequestdata)

### ChangeGroupStatisticsRequestData

Defines the request payload for ChangeGroupStatistics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `groupStatistics` | `List<GroupStatisticsParam>` | yes | _minLength=1, maxLength=32, elementCls=GroupStatisticsParam_ |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

Reference links:

- [GroupModels.GroupStatisticsParam:67-76](/docs/reference/dto/group/GROUP_MODELS.md#groupstatisticsparam)

### ServerChangeGroupStatisticsRequestData

Extends: `ChangeGroupStatisticsRequestData`

Defines the request payload for ServerChangeGroupStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `ChangeGroupStatisticsRequestData`._

Reference links:

- [GroupModels.ChangeGroupStatisticsRequestData:1292-1306](/docs/reference/dto/group/GROUP_MODELS.md#changegroupstatisticsrequestdata)

### AdminChangeGroupStatisticsRequestData

Extends: `ServerChangeGroupStatisticsRequestData`

Defines the request payload for AdminChangeGroupStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerChangeGroupStatisticsRequestData`._

Reference links:

- [GroupModels.ServerChangeGroupStatisticsRequestData:1292-1318](/docs/reference/dto/group/GROUP_MODELS.md#serverchangegroupstatisticsrequestdata)

### SetRemoveStatusRequestData

Defines the request payload for SetRemoveStatus.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `reason` | `string?` | no | _default=""_ |

### ServerSetRemoveStatusRequestData

Extends: `SetRemoveStatusRequestData`

Defines the request payload for ServerSetRemoveStatus.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetRemoveStatusRequestData`._

Reference links:

- [GroupModels.SetRemoveStatusRequestData:1331-1340](/docs/reference/dto/group/GROUP_MODELS.md#setremovestatusrequestdata)

### AdminSetRemoveStatusRequestData

Extends: `ServerSetRemoveStatusRequestData`

Defines the request payload for AdminSetRemoveStatus.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetRemoveStatusRequestData`._

Reference links:

- [GroupModels.ServerSetRemoveStatusRequestData:1331-1352](/docs/reference/dto/group/GROUP_MODELS.md#serversetremovestatusrequestdata)

### SetTagRequestData

Defines the request payload for SetTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerSetTagRequestData

Extends: `SetTagRequestData`

Defines the request payload for ServerSetTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetTagRequestData`._

Reference links:

- [GroupModels.SetTagRequestData:1365-1375](/docs/reference/dto/group/GROUP_MODELS.md#settagrequestdata)

### AdminSetTagRequestData

Extends: `ServerSetTagRequestData`

Defines the request payload for AdminSetTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetTagRequestData`._

Reference links:

- [GroupModels.ServerSetTagRequestData:1365-1387](/docs/reference/dto/group/GROUP_MODELS.md#serversettagrequestdata)

### GetCurrencyLogRequestData

Reads currency change logs for one group. Pagination is token-based rather than skip-based.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keys` | `List<string>?` | no | _minLength=1, maxLength=32, elementCls=String_ |
| `groupId` | `string?` | no | _minLength=10, maxLength=10_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `token` | `string?` | no | Continuation token returned by the previous page. — _minLength=24, maxLength=24_ |

### ServerGetCurrencyLogRequestData

Extends: `GetCurrencyLogRequestData`

Defines the request payload for ServerGetCurrencyLog.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCurrencyLogRequestData`._

Reference links:

- [GroupModels.GetCurrencyLogRequestData:1400-1411](/docs/reference/dto/group/GROUP_MODELS.md#getcurrencylogrequestdata)

### AdminGetCurrencyLogRequestData

Extends: `ServerGetCurrencyLogRequestData`

Defines the request payload for AdminGetCurrencyLog.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCurrencyLogRequestData`._

Reference links:

- [GroupModels.ServerGetCurrencyLogRequestData:1400-1423](/docs/reference/dto/group/GROUP_MODELS.md#servergetcurrencylogrequestdata)

### GetStatisticsLogRequestData

Reads statistic change logs for one group. Pagination is token-based rather than skip-based.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keys` | `List<string>?` | no | _minLength=1, maxLength=32, elementCls=String_ |
| `groupId` | `string?` | no | _minLength=10, maxLength=10_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `token` | `string?` | no | Continuation token returned by the previous page. — _minLength=24, maxLength=24_ |

### ServerGetStatisticsLogRequestData

Extends: `GetStatisticsLogRequestData`

Defines the request payload for ServerGetStatisticsLog.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetStatisticsLogRequestData`._

Reference links:

- [GroupModels.GetStatisticsLogRequestData:1436-1447](/docs/reference/dto/group/GROUP_MODELS.md#getstatisticslogrequestdata)

### AdminGetStatisticsLogRequestData

Extends: `ServerGetStatisticsLogRequestData`

Defines the request payload for AdminGetStatisticsLog.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStatisticsLogRequestData`._

Reference links:

- [GroupModels.ServerGetStatisticsLogRequestData:1436-1459](/docs/reference/dto/group/GROUP_MODELS.md#servergetstatisticslogrequestdata)

### InfoResponseParameters

Contains the optional fields requested through `InfoRequestParam`.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `catalogId` | `string?` | no | Catalog ID the group belongs to; present when requested. |
| `members` | `List<GenericModels.MemberItem>?` | no | Lightweight member items for the group, not full player snapshots. — _elementCls=GenericModels.MemberItem_ |
| `removeStatus` | `GenericModels.RemoveStatusItem?` | no | Soft-remove metadata; present when the group has been marked for removal. |
| `segments` | `List<string>?` | no | Segment names currently assigned to the group. — _elementCls=String_ |
| `customDatas` | `List<GenericModels.DataItem>?` | no | Custom data entries; present when `customDatas` is enabled in `InfoRequestParam`. — _elementCls=GenericModels.DataItem_ |
| `displayName` | `string?` | no | Display name of the group; present when requested. |
| `avatar` | `GenericModels.AvatarItem?` | no | Avatar descriptor of the group; present when requested. |
| `tsCreate` | `long?` | no | Creation timestamp of the group; present when requested. |
| `tags` | `List<GenericModels.TagItem>?` | no | Tag entries assigned to the group. — _elementCls=GenericModels.TagItem_ |
| `groupDatas` | `List<GenericModels.DataItem>?` | no | Group data entries; present when `groupDatas` is enabled. — _elementCls=GenericModels.DataItem_ |
| `groupCurrencies` | `List<GenericModels.CurrencyItem>?` | no | Currency balances of the group; present when `groupCurrencies` is enabled. — _elementCls=GenericModels.CurrencyItem_ |
| `groupStatistics` | `List<GenericModels.StatisticsItem>?` | no | Statistics values of the group; present when `groupStatistics` is enabled. — _elementCls=GenericModels.StatisticsItem_ |
| `groupInventories` | `List<GenericModels.InventoryItem>?` | no | Lightweight inventory relation items owned by the group. — _elementCls=GenericModels.InventoryItem_ |

Reference links:

- [Generic.MemberItem:126-134](/docs/reference/dto/generic/GENERIC_MODELS.md#memberitem)
- [Generic.RemoveStatusItem:81-90](/docs/reference/dto/generic/GENERIC_MODELS.md#removestatusitem)
- [Generic.DataItem:31-40](/docs/reference/dto/generic/GENERIC_MODELS.md#dataitem)
- [Generic.AvatarItem:1-10](/docs/reference/dto/generic/GENERIC_MODELS.md#avataritem)
- [Generic.TagItem:11-20](/docs/reference/dto/generic/GENERIC_MODELS.md#tagitem)
- [Generic.CurrencyItem:41-50](/docs/reference/dto/generic/GENERIC_MODELS.md#currencyitem)
- [Generic.StatisticsItem:51-60](/docs/reference/dto/generic/GENERIC_MODELS.md#statisticsitem)
- [Generic.InventoryItem:91-101](/docs/reference/dto/generic/GENERIC_MODELS.md#inventoryitem)

### GroupResponseData

Base group response envelope.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoResponseParameters` | `InfoResponseParameters` | yes | Optional field bag controlled by the corresponding `InfoRequestParam`. |

Reference links:

- [GroupModels.InfoResponseParameters:1472-1503](/docs/reference/dto/group/GROUP_MODELS.md#inforesponseparameters)

### GroupWithGroupIdResponseData

Extends: `GroupResponseData`

Group envelope that also exposes the resolved group ID.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `GroupResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | Group identifier. |

Reference links:

- [GroupModels.GroupResponseData:1504-1516](/docs/reference/dto/group/GROUP_MODELS.md#groupresponsedata)

### GroupLeaderboardResponseData

Extends: `GroupWithGroupIdResponseData`

Defines the response payload for GroupLeaderboard.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `GroupWithGroupIdResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `position` | `int` | yes | Zero-based leaderboard rank position of this group. |
| `backupValue` | `double?` | no | Backup statistic or currency value used as a tiebreaker when present. |

Reference links:

- [GroupModels.GroupWithGroupIdResponseData:1504-1533](/docs/reference/dto/group/GROUP_MODELS.md#groupwithgroupidresponsedata)

### GroupLogResponseData

Describes one group statistics or currency change log entry.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | Group identifier this log entry belongs to. |
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
| `results` | `List<GroupLeaderboardResponseData>` | yes | Ordered list of group leaderboard entries. — _elementCls=GroupLeaderboardResponseData_ |
| `tsCreate` | `long?` | no | Timestamp when this leaderboard snapshot was last generated; present when available. |

Reference links:

- [GroupModels.GroupLeaderboardResponseData:1504-1551](/docs/reference/dto/group/GROUP_MODELS.md#groupleaderboardresponsedata)

### GroupsWithGroupIdResponseData

Defines the response payload for GroupsWithGroupId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GroupWithGroupIdResponseData>` | yes | _elementCls=GroupWithGroupIdResponseData_ |

Reference links:

- [GroupModels.GroupWithGroupIdResponseData:1504-1533](/docs/reference/dto/group/GROUP_MODELS.md#groupwithgroupidresponsedata)

### GroupMessageResponseData

Describes one persisted group-message entry.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `message` | `string` | yes | Message content text. |
| `senderId` | `string` | yes | User or system ID of the sender. |
| `senderType` | `int` | yes | Sender type value defined by backend message semantics. |
| `tsCreate` | `long` | yes | Timestamp when the message was sent. |

### GroupMessagesResponseData

Returns one page of persisted group messages.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupMessages` | `List<GroupMessageResponseData>` | yes | _elementCls=GroupMessageResponseData_ |

Reference links:

- [GroupModels.GroupMessageResponseData:1594-1605](/docs/reference/dto/group/GROUP_MODELS.md#groupmessageresponsedata)

### GetCurrencyLeaderboardRequestData

Defines the request payload for GetCurrencyLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional group fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |
| `catalogId` | `string?` | no | _minLength=2, maxLength=32_ |

Reference links:

- [GroupModels.InfoRequestParam:1-27](/docs/reference/dto/group/GROUP_MODELS.md#inforequestparam)

### ServerGetCurrencyLeaderboardRequestData

Extends: `GetCurrencyLeaderboardRequestData`

Defines the request payload for ServerGetCurrencyLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCurrencyLeaderboardRequestData`._

Reference links:

- [GroupModels.GetCurrencyLeaderboardRequestData:1619-1636](/docs/reference/dto/group/GROUP_MODELS.md#getcurrencyleaderboardrequestdata)

### AdminGetCurrencyLeaderboardRequestData

Extends: `ServerGetCurrencyLeaderboardRequestData`

Defines the request payload for AdminGetCurrencyLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCurrencyLeaderboardRequestData`._

Reference links:

- [GroupModels.ServerGetCurrencyLeaderboardRequestData:1619-1648](/docs/reference/dto/group/GROUP_MODELS.md#servergetcurrencyleaderboardrequestdata)

### GetCurrencyLeaderboardResponseData

Defines the response payload for GetCurrencyLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GroupLeaderboardResponseData>` | yes | _elementCls=GroupLeaderboardResponseData_ |

Reference links:

- [GroupModels.GroupLeaderboardResponseData:1504-1551](/docs/reference/dto/group/GROUP_MODELS.md#groupleaderboardresponsedata)

### GetCreateLeaderboardResponseData

Defines the response payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GroupLeaderboardResponseData>` | yes | _elementCls=GroupLeaderboardResponseData_ |

Reference links:

- [GroupModels.GroupLeaderboardResponseData:1504-1551](/docs/reference/dto/group/GROUP_MODELS.md#groupleaderboardresponsedata)

### GetStatisticsLogResponseData

Returns one page of statistics logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GroupLogResponseData>` | yes | _elementCls=GroupLogResponseData_ |
| `token` | `string?` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

Reference links:

- [GroupModels.GroupLogResponseData:1552-1566](/docs/reference/dto/group/GROUP_MODELS.md#grouplogresponsedata)

### GetCurrencyLogResponseData

Returns one page of currency logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GroupLogResponseData>` | yes | _elementCls=GroupLogResponseData_ |
| `token` | `string?` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

Reference links:

- [GroupModels.GroupLogResponseData:1552-1566](/docs/reference/dto/group/GROUP_MODELS.md#grouplogresponsedata)

### EmptyResponseData

Defines an intentionally empty response payload.

_Không có field public (payload rỗng)._
