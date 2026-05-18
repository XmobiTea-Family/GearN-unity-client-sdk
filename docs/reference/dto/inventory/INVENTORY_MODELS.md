### CustomDataParam

Defines the reusable parameter block CustomDataParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `object` | yes | Arbitrary value to store for this custom data key. May be a primitive, `GNHashtable`, or `GNArray`. |

### InfoRequestParam

Selects which optional inventory fields should be returned in `infoResponseParameters`. Boolean flags default to `false`; key arrays narrow list-style fields to specific keys only.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `catalogId` | `bool?` | no | Includes the catalog ID from which this inventory item was created. — _default=false_ |
| `classId` | `bool?` | no | Includes the class ID of the inventory item. — _default=false_ |
| `itemType` | `bool?` | no | Includes the item type mapped by the public `ItemType` enum. — _default=false_ |
| `amount` | `bool?` | no | Includes the current item amount. — _default=false_ |
| `owner` | `bool?` | no | Includes the current owner descriptor. — _default=false_ |
| `removeStatus` | `bool?` | no | Includes soft-remove metadata for the item. — _default=false_ |
| `segments` | `bool?` | no | Includes segment names assigned to the item. — _default=false_ |
| `customDatas` | `bool?` | no | Includes custom data entries, optionally filtered by `customDataKeys`. — _default=false_ |
| `displayName` | `bool?` | no | Includes the item's display name. — _default=false_ |
| `avatar` | `bool?` | no | Includes the item's avatar descriptor. — _default=false_ |
| `tsCreate` | `bool?` | no | Includes the item creation timestamp. — _default=false_ |
| `tags` | `bool?` | no | Includes tag entries, optionally filtered by `tagKeys`. — _default=false_ |
| `itemStatistics` | `bool?` | no | Includes item statistics values, optionally filtered by `itemStatisticsKeys`. — _default=false_ |
| `itemDatas` | `bool?` | no | Includes item data entries, optionally filtered by `itemDataKeys`. — _default=false_ |
| `itemDataKeys` | `List<string>?` | no | Restricts `itemDatas` to the specified keys when that field is requested. — _elementCls=String_ |
| `itemStatisticsKeys` | `List<string>?` | no | Restricts `itemStatistics` to the specified statistic keys when that field is requested. — _elementCls=String_ |
| `customDataKeys` | `List<string>?` | no | Restricts `customDatas` to the specified keys when that field is requested. — _elementCls=String_ |
| `tagKeys` | `List<string>?` | no | Restricts `tags` to the specified tag keys when that field is requested. — _elementCls=String_ |

### ItemDataParam

Defines the reusable parameter block ItemDataParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `object` | yes | Arbitrary value to store for this item data key. May be a primitive, `GNHashtable`, or `GNArray`. |

### ItemStatisticsParam

Defines the reusable parameter block ItemStatisticsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `double` | yes | Statistic value to apply; interpretation depends on the configured aggregation method. |

### AddSegmentRequestData

Defines the request payload for AddSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `value` | `string` | yes | _minLength=6, maxLength=32_ |

### ServerAddSegmentRequestData

Extends: `AddSegmentRequestData`

Defines the request payload for ServerAddSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `AddSegmentRequestData`._

Reference links:

- [InventoryModels.AddSegmentRequestData:57-66](/docs/reference/dto/inventory/INVENTORY_MODELS.md#addsegmentrequestdata)

### AdminAddSegmentRequestData

Extends: `ServerAddSegmentRequestData`

Defines the request payload for AdminAddSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerAddSegmentRequestData`._

Reference links:

- [InventoryModels.ServerAddSegmentRequestData:57-78](/docs/reference/dto/inventory/INVENTORY_MODELS.md#serveraddsegmentrequestdata)

### GetAmountRequestData

Defines the request payload for GetAmount.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetAmountRequestData

Extends: `GetAmountRequestData`

Defines the request payload for ServerGetAmount.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetAmountRequestData`._

Reference links:

- [InventoryModels.GetAmountRequestData:91-99](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getamountrequestdata)

### AdminGetAmountRequestData

Extends: `ServerGetAmountRequestData`

Defines the request payload for AdminGetAmount.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetAmountRequestData`._

Reference links:

- [InventoryModels.ServerGetAmountRequestData:91-111](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetamountrequestdata)

### GetAvatarRequestData

Defines the request payload for GetAvatar.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetAvatarRequestData

Extends: `GetAvatarRequestData`

Defines the request payload for ServerGetAvatar.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetAvatarRequestData`._

Reference links:

- [InventoryModels.GetAvatarRequestData:124-132](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getavatarrequestdata)

### AdminGetAvatarRequestData

Extends: `ServerGetAvatarRequestData`

Defines the request payload for AdminGetAvatar.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetAvatarRequestData`._

Reference links:

- [InventoryModels.ServerGetAvatarRequestData:124-144](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetavatarrequestdata)

### GetCatalogIdRequestData

Defines the request payload for GetCatalogId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetCatalogIdRequestData

Extends: `GetCatalogIdRequestData`

Defines the request payload for ServerGetCatalogId.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCatalogIdRequestData`._

Reference links:

- [InventoryModels.GetCatalogIdRequestData:157-165](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getcatalogidrequestdata)

### AdminGetCatalogIdRequestData

Extends: `ServerGetCatalogIdRequestData`

Defines the request payload for AdminGetCatalogId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCatalogIdRequestData`._

Reference links:

- [InventoryModels.ServerGetCatalogIdRequestData:157-177](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetcatalogidrequestdata)

### GetClassIdRequestData

Defines the request payload for GetClassId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetClassIdRequestData

Extends: `GetClassIdRequestData`

Defines the request payload for ServerGetClassId.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetClassIdRequestData`._

Reference links:

- [InventoryModels.GetClassIdRequestData:190-198](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getclassidrequestdata)

### AdminGetClassIdRequestData

Extends: `ServerGetClassIdRequestData`

Defines the request payload for AdminGetClassId.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetClassIdRequestData`._

Reference links:

- [InventoryModels.ServerGetClassIdRequestData:190-210](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetclassidrequestdata)

### GetCustomDataRequestData

Defines the request payload for GetCustomData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `customDataKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetCustomDataRequestData

Extends: `GetCustomDataRequestData`

Defines the request payload for ServerGetCustomData.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCustomDataRequestData`._

Reference links:

- [InventoryModels.GetCustomDataRequestData:223-232](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getcustomdatarequestdata)

### AdminGetCustomDataRequestData

Extends: `ServerGetCustomDataRequestData`

Defines the request payload for AdminGetCustomData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCustomDataRequestData`._

Reference links:

- [InventoryModels.ServerGetCustomDataRequestData:223-244](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetcustomdatarequestdata)

### GetDisplayNameRequestData

Defines the request payload for GetDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetDisplayNameRequestData

Extends: `GetDisplayNameRequestData`

Defines the request payload for ServerGetDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetDisplayNameRequestData`._

Reference links:

- [InventoryModels.GetDisplayNameRequestData:257-265](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getdisplaynamerequestdata)

### AdminGetDisplayNameRequestData

Extends: `ServerGetDisplayNameRequestData`

Defines the request payload for AdminGetDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetDisplayNameRequestData`._

Reference links:

- [InventoryModels.ServerGetDisplayNameRequestData:257-277](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetdisplaynamerequestdata)

### GetItemDataRequestData

Defines the request payload for GetItemData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `itemDataKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetItemDataRequestData

Extends: `GetItemDataRequestData`

Defines the request payload for ServerGetItemData.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetItemDataRequestData`._

Reference links:

- [InventoryModels.GetItemDataRequestData:290-299](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getitemdatarequestdata)

### AdminGetItemDataRequestData

Extends: `ServerGetItemDataRequestData`

Defines the request payload for AdminGetItemData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetItemDataRequestData`._

Reference links:

- [InventoryModels.ServerGetItemDataRequestData:290-311](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetitemdatarequestdata)

### GetItemInformationRequestData

Defines the request payload for GetItemInformation.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional inventory item fields are included in the response. |

Reference links:

- [InventoryModels.InfoRequestParam:11-36](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inforequestparam)

### ServerGetItemInformationRequestData

Extends: `GetItemInformationRequestData`

Defines the request payload for ServerGetItemInformation.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetItemInformationRequestData`._

Reference links:

- [InventoryModels.GetItemInformationRequestData:324-337](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getiteminformationrequestdata)

### AdminGetItemInformationRequestData

Extends: `ServerGetItemInformationRequestData`

Defines the request payload for AdminGetItemInformation.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetItemInformationRequestData`._

Reference links:

- [InventoryModels.ServerGetItemInformationRequestData:324-349](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetiteminformationrequestdata)

### GetItemStatisticsRequestData

Reads statistics for one inventory item. Note that this request uses `statisticsKeys`, while `InfoRequestParam` uses `itemStatisticsKeys`.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `statisticsKeys` | `List<string>?` | no | _elementCls=String_ |

Reference links:

- [InventoryModels.InfoRequestParam:11-36](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inforequestparam)

### ServerGetItemStatisticsRequestData

Extends: `GetItemStatisticsRequestData`

Defines the request payload for ServerGetItemStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetItemStatisticsRequestData`._

Reference links:

- [InventoryModels.GetItemStatisticsRequestData:362-375](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getitemstatisticsrequestdata)

### AdminGetItemStatisticsRequestData

Extends: `ServerGetItemStatisticsRequestData`

Defines the request payload for AdminGetItemStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetItemStatisticsRequestData`._

Reference links:

- [InventoryModels.ServerGetItemStatisticsRequestData:362-387](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetitemstatisticsrequestdata)

### GetItemsWithDisplayNameRequestData

Defines the request payload for GetItemsWithDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keyword` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional inventory item fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

Reference links:

- [InventoryModels.InfoRequestParam:11-36](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inforequestparam)

### ServerGetItemsWithDisplayNameRequestData

Extends: `GetItemsWithDisplayNameRequestData`

Defines the request payload for ServerGetItemsWithDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetItemsWithDisplayNameRequestData`._

Reference links:

- [InventoryModels.GetItemsWithDisplayNameRequestData:400-415](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getitemswithdisplaynamerequestdata)

### AdminGetItemsWithDisplayNameRequestData

Extends: `ServerGetItemsWithDisplayNameRequestData`

Defines the request payload for AdminGetItemsWithDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetItemsWithDisplayNameRequestData`._

Reference links:

- [InventoryModels.ServerGetItemsWithDisplayNameRequestData:400-427](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetitemswithdisplaynamerequestdata)

### GetItemsWithSegmentRequestData

Defines the request payload for GetItemsWithSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional inventory item fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

Reference links:

- [InventoryModels.InfoRequestParam:11-36](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inforequestparam)

### ServerGetItemsWithSegmentRequestData

Extends: `GetItemsWithSegmentRequestData`

Defines the request payload for ServerGetItemsWithSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetItemsWithSegmentRequestData`._

Reference links:

- [InventoryModels.GetItemsWithSegmentRequestData:440-455](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getitemswithsegmentrequestdata)

### AdminGetItemsWithSegmentRequestData

Extends: `ServerGetItemsWithSegmentRequestData`

Defines the request payload for AdminGetItemsWithSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetItemsWithSegmentRequestData`._

Reference links:

- [InventoryModels.ServerGetItemsWithSegmentRequestData:440-467](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetitemswithsegmentrequestdata)

### GetItemsWithTagRequestData

Defines the request payload for GetItemsWithTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional inventory item fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

Reference links:

- [InventoryModels.InfoRequestParam:11-36](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inforequestparam)

### ServerGetItemsWithTagRequestData

Extends: `GetItemsWithTagRequestData`

Defines the request payload for ServerGetItemsWithTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetItemsWithTagRequestData`._

Reference links:

- [InventoryModels.GetItemsWithTagRequestData:480-496](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getitemswithtagrequestdata)

### AdminGetItemsWithTagRequestData

Extends: `ServerGetItemsWithTagRequestData`

Defines the request payload for AdminGetItemsWithTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetItemsWithTagRequestData`._

Reference links:

- [InventoryModels.ServerGetItemsWithTagRequestData:480-508](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetitemswithtagrequestdata)

### GetItemTypeRequestData

Defines the request payload for GetItemType.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetItemTypeRequestData

Extends: `GetItemTypeRequestData`

Defines the request payload for ServerGetItemType.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetItemTypeRequestData`._

Reference links:

- [InventoryModels.GetItemTypeRequestData:521-529](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getitemtyperequestdata)

### AdminGetItemTypeRequestData

Extends: `ServerGetItemTypeRequestData`

Defines the request payload for AdminGetItemType.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetItemTypeRequestData`._

Reference links:

- [InventoryModels.ServerGetItemTypeRequestData:521-541](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetitemtyperequestdata)

### GetOwnerRequestData

Defines the request payload for GetOwner.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetOwnerRequestData

Extends: `GetOwnerRequestData`

Defines the request payload for ServerGetOwner.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetOwnerRequestData`._

Reference links:

- [InventoryModels.GetOwnerRequestData:554-562](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getownerrequestdata)

### AdminGetOwnerRequestData

Extends: `ServerGetOwnerRequestData`

Defines the request payload for AdminGetOwner.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetOwnerRequestData`._

Reference links:

- [InventoryModels.ServerGetOwnerRequestData:554-574](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetownerrequestdata)

### GetRemoveStatusRequestData

Defines the request payload for GetRemoveStatus.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetRemoveStatusRequestData

Extends: `GetRemoveStatusRequestData`

Defines the request payload for ServerGetRemoveStatus.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetRemoveStatusRequestData`._

Reference links:

- [InventoryModels.GetRemoveStatusRequestData:587-595](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getremovestatusrequestdata)

### AdminGetRemoveStatusRequestData

Extends: `ServerGetRemoveStatusRequestData`

Defines the request payload for AdminGetRemoveStatus.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetRemoveStatusRequestData`._

Reference links:

- [InventoryModels.ServerGetRemoveStatusRequestData:587-607](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetremovestatusrequestdata)

### GetSegmentRequestData

Defines the request payload for GetSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetSegmentRequestData

Extends: `GetSegmentRequestData`

Defines the request payload for ServerGetSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetSegmentRequestData`._

Reference links:

- [InventoryModels.GetSegmentRequestData:620-628](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getsegmentrequestdata)

### AdminGetSegmentRequestData

Extends: `ServerGetSegmentRequestData`

Defines the request payload for AdminGetSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetSegmentRequestData`._

Reference links:

- [InventoryModels.ServerGetSegmentRequestData:620-640](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetsegmentrequestdata)

### GetStatisticsLeaderboardAroundItemRequestData

Defines the request payload for GetStatisticsLeaderboardAroundItem.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional inventory item fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |
| `catalogId` | `string?` | no | _minLength=2, maxLength=32_ |

Reference links:

- [InventoryModels.InfoRequestParam:11-36](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inforequestparam)

### ServerGetStatisticsLeaderboardAroundItemRequestData

Extends: `GetStatisticsLeaderboardAroundItemRequestData`

Defines the request payload for ServerGetStatisticsLeaderboardAroundItem.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetStatisticsLeaderboardAroundItemRequestData`._

Reference links:

- [InventoryModels.GetStatisticsLeaderboardAroundItemRequestData:653-671](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getstatisticsleaderboardarounditemrequestdata)

### AdminGetStatisticsLeaderboardAroundItemRequestData

Extends: `ServerGetStatisticsLeaderboardAroundItemRequestData`

Defines the request payload for AdminGetStatisticsLeaderboardAroundItem.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStatisticsLeaderboardAroundItemRequestData`._

Reference links:

- [InventoryModels.ServerGetStatisticsLeaderboardAroundItemRequestData:653-683](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetstatisticsleaderboardarounditemrequestdata)

### GetStatisticsLeaderboardRequestData

Defines the request payload for GetStatisticsLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional inventory item fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |
| `version` | `string?` | no | _minLength=2, maxLength=32_ |
| `catalogId` | `string?` | no | _minLength=2, maxLength=32_ |

Reference links:

- [InventoryModels.InfoRequestParam:11-36](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inforequestparam)

### ServerGetStatisticsLeaderboardRequestData

Extends: `GetStatisticsLeaderboardRequestData`

Defines the request payload for ServerGetStatisticsLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetStatisticsLeaderboardRequestData`._

Reference links:

- [InventoryModels.GetStatisticsLeaderboardRequestData:696-714](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getstatisticsleaderboardrequestdata)

### AdminGetStatisticsLeaderboardRequestData

Extends: `ServerGetStatisticsLeaderboardRequestData`

Defines the request payload for AdminGetStatisticsLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStatisticsLeaderboardRequestData`._

Reference links:

- [InventoryModels.ServerGetStatisticsLeaderboardRequestData:696-726](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetstatisticsleaderboardrequestdata)

### GetCreateLeaderboardRequestData

Defines the request payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional inventory item fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Reference links:

- [InventoryModels.InfoRequestParam:11-36](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inforequestparam)

### ServerGetCreateLeaderboardRequestData

Extends: `GetCreateLeaderboardRequestData`

Defines the request payload for ServerGetCreateLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCreateLeaderboardRequestData`._

Reference links:

- [InventoryModels.GetCreateLeaderboardRequestData:739-754](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getcreateleaderboardrequestdata)

### AdminGetCreateLeaderboardRequestData

Extends: `ServerGetCreateLeaderboardRequestData`

Defines the request payload for AdminGetCreateLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCreateLeaderboardRequestData`._

Reference links:

- [InventoryModels.ServerGetCreateLeaderboardRequestData:739-766](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetcreateleaderboardrequestdata)

### GetTagRequestData

Defines the request payload for GetTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `tagKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetTagRequestData

Extends: `GetTagRequestData`

Defines the request payload for ServerGetTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetTagRequestData`._

Reference links:

- [InventoryModels.GetTagRequestData:779-788](/docs/reference/dto/inventory/INVENTORY_MODELS.md#gettagrequestdata)

### AdminGetTagRequestData

Extends: `ServerGetTagRequestData`

Defines the request payload for AdminGetTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetTagRequestData`._

Reference links:

- [InventoryModels.ServerGetTagRequestData:779-800](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergettagrequestdata)

### GetTsCreateRequestData

Defines the request payload for GetTsCreate.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetTsCreateRequestData

Extends: `GetTsCreateRequestData`

Defines the request payload for ServerGetTsCreate.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetTsCreateRequestData`._

Reference links:

- [InventoryModels.GetTsCreateRequestData:813-821](/docs/reference/dto/inventory/INVENTORY_MODELS.md#gettscreaterequestdata)

### AdminGetTsCreateRequestData

Extends: `ServerGetTsCreateRequestData`

Defines the request payload for AdminGetTsCreate.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetTsCreateRequestData`._

Reference links:

- [InventoryModels.ServerGetTsCreateRequestData:813-833](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergettscreaterequestdata)

### RemoveSegmentRequestData

Defines the request payload for RemoveSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerRemoveSegmentRequestData

Extends: `RemoveSegmentRequestData`

Defines the request payload for ServerRemoveSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `RemoveSegmentRequestData`._

Reference links:

- [InventoryModels.RemoveSegmentRequestData:846-855](/docs/reference/dto/inventory/INVENTORY_MODELS.md#removesegmentrequestdata)

### AdminRemoveSegmentRequestData

Extends: `ServerRemoveSegmentRequestData`

Defines the request payload for AdminRemoveSegment.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemoveSegmentRequestData`._

Reference links:

- [InventoryModels.ServerRemoveSegmentRequestData:846-867](/docs/reference/dto/inventory/INVENTORY_MODELS.md#serverremovesegmentrequestdata)

### RemoveTagRequestData

Defines the request payload for RemoveTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerRemoveTagRequestData

Extends: `RemoveTagRequestData`

Defines the request payload for ServerRemoveTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `RemoveTagRequestData`._

Reference links:

- [InventoryModels.RemoveTagRequestData:880-889](/docs/reference/dto/inventory/INVENTORY_MODELS.md#removetagrequestdata)

### AdminRemoveTagRequestData

Extends: `ServerRemoveTagRequestData`

Defines the request payload for AdminRemoveTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemoveTagRequestData`._

Reference links:

- [InventoryModels.ServerRemoveTagRequestData:880-901](/docs/reference/dto/inventory/INVENTORY_MODELS.md#serverremovetagrequestdata)

### SetAmountRequestData

Replaces the stored amount with an absolute value. Use `ChangeItemStatistics` for statistics deltas; this contract is not a delta operation.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `amount` | `long` | yes | Absolute item amount to set (replaces the current value, not a delta). |

### ServerSetAmountRequestData

Extends: `SetAmountRequestData`

Defines the request payload for ServerSetAmount.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetAmountRequestData`._

Reference links:

- [InventoryModels.SetAmountRequestData:914-923](/docs/reference/dto/inventory/INVENTORY_MODELS.md#setamountrequestdata)

### AdminSetAmountRequestData

Extends: `ServerSetAmountRequestData`

Defines the request payload for AdminSetAmount.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetAmountRequestData`._

Reference links:

- [InventoryModels.ServerSetAmountRequestData:914-935](/docs/reference/dto/inventory/INVENTORY_MODELS.md#serversetamountrequestdata)

### SetAvatarRequestData

Defines the request payload for SetAvatar.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `type` | `int` | yes | App-defined avatar type integer; not mapped to a built-in GearN enum. |
| `value` | `string` | yes | Avatar value such as a URL, file ID, or provider-specific string. — _minLength=1, maxLength=128_ |

### ServerSetAvatarRequestData

Extends: `SetAvatarRequestData`

Defines the request payload for ServerSetAvatar.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetAvatarRequestData`._

Reference links:

- [InventoryModels.SetAvatarRequestData:948-958](/docs/reference/dto/inventory/INVENTORY_MODELS.md#setavatarrequestdata)

### AdminSetAvatarRequestData

Extends: `ServerSetAvatarRequestData`

Defines the request payload for AdminSetAvatar.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetAvatarRequestData`._

Reference links:

- [InventoryModels.ServerSetAvatarRequestData:948-970](/docs/reference/dto/inventory/INVENTORY_MODELS.md#serversetavatarrequestdata)

### SetCustomDataRequestData

Defines the request payload for SetCustomData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `customDatas` | `List<CustomDataParam>` | yes | _minLength=1, maxLength=32, elementCls=CustomDataParam_ |

Reference links:

- [InventoryModels.CustomDataParam:1-10](/docs/reference/dto/inventory/INVENTORY_MODELS.md#customdataparam)

### ServerSetCustomDataRequestData

Extends: `SetCustomDataRequestData`

Defines the request payload for ServerSetCustomData.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetCustomDataRequestData`._

Reference links:

- [InventoryModels.SetCustomDataRequestData:983-996](/docs/reference/dto/inventory/INVENTORY_MODELS.md#setcustomdatarequestdata)

### AdminSetCustomDataRequestData

Extends: `ServerSetCustomDataRequestData`

Defines the request payload for AdminSetCustomData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetCustomDataRequestData`._

Reference links:

- [InventoryModels.ServerSetCustomDataRequestData:983-1008](/docs/reference/dto/inventory/INVENTORY_MODELS.md#serversetcustomdatarequestdata)

### SetDisplayNameRequestData

Defines the request payload for SetDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `displayName` | `string` | yes | _minLength=5, maxLength=32_ |

### ServerSetDisplayNameRequestData

Extends: `SetDisplayNameRequestData`

Defines the request payload for ServerSetDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetDisplayNameRequestData`._

Reference links:

- [InventoryModels.SetDisplayNameRequestData:1021-1030](/docs/reference/dto/inventory/INVENTORY_MODELS.md#setdisplaynamerequestdata)

### AdminSetDisplayNameRequestData

Extends: `ServerSetDisplayNameRequestData`

Defines the request payload for AdminSetDisplayName.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetDisplayNameRequestData`._

Reference links:

- [InventoryModels.ServerSetDisplayNameRequestData:1021-1042](/docs/reference/dto/inventory/INVENTORY_MODELS.md#serversetdisplaynamerequestdata)

### SetItemDataRequestData

Defines the request payload for SetItemData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `itemDatas` | `List<ItemDataParam>` | yes | _minLength=1, maxLength=32, elementCls=ItemDataParam_ |

Reference links:

- [InventoryModels.ItemDataParam:37-46](/docs/reference/dto/inventory/INVENTORY_MODELS.md#itemdataparam)

### ServerSetItemDataRequestData

Extends: `SetItemDataRequestData`

Defines the request payload for ServerSetItemData.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetItemDataRequestData`._

Reference links:

- [InventoryModels.SetItemDataRequestData:1055-1068](/docs/reference/dto/inventory/INVENTORY_MODELS.md#setitemdatarequestdata)

### AdminSetItemDataRequestData

Extends: `ServerSetItemDataRequestData`

Defines the request payload for AdminSetItemData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetItemDataRequestData`._

Reference links:

- [InventoryModels.ServerSetItemDataRequestData:1055-1080](/docs/reference/dto/inventory/INVENTORY_MODELS.md#serversetitemdatarequestdata)

### ChangeItemStatisticsRequestData

Applies delta updates to one or more item statistics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `itemStatistics` | `List<ItemStatisticsParam>` | yes | _minLength=1, maxLength=32, elementCls=ItemStatisticsParam_ |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

Reference links:

- [InventoryModels.ItemStatisticsParam:47-56](/docs/reference/dto/inventory/INVENTORY_MODELS.md#itemstatisticsparam)

### ServerChangeItemStatisticsRequestData

Extends: `ChangeItemStatisticsRequestData`

Defines the request payload for ServerChangeItemStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `ChangeItemStatisticsRequestData`._

Reference links:

- [InventoryModels.ChangeItemStatisticsRequestData:1093-1107](/docs/reference/dto/inventory/INVENTORY_MODELS.md#changeitemstatisticsrequestdata)

### AdminChangeItemStatisticsRequestData

Extends: `ServerChangeItemStatisticsRequestData`

Defines the request payload for AdminChangeItemStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerChangeItemStatisticsRequestData`._

Reference links:

- [InventoryModels.ServerChangeItemStatisticsRequestData:1093-1119](/docs/reference/dto/inventory/INVENTORY_MODELS.md#serverchangeitemstatisticsrequestdata)

### SetOwnerRequestData

Transfers ownership of the inventory item to a different owner.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=11, maxLength=11_ |
| `newOwnerId` | `string` | yes | New owner identifier matching the selected `newOwnerType`. — _minLength=10, maxLength=12_ |
| `newOwnerType` | `int` | yes | New owner type mapped by the public `OwnerType` enum. |

### ServerSetOwnerRequestData

Extends: `SetOwnerRequestData`

Defines the request payload for ServerSetOwner.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetOwnerRequestData`._

Reference links:

- [InventoryModels.SetOwnerRequestData:1132-1142](/docs/reference/dto/inventory/INVENTORY_MODELS.md#setownerrequestdata)

### AdminSetOwnerRequestData

Extends: `ServerSetOwnerRequestData`

Defines the request payload for AdminSetOwner.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetOwnerRequestData`._

Reference links:

- [InventoryModels.ServerSetOwnerRequestData:1132-1154](/docs/reference/dto/inventory/INVENTORY_MODELS.md#serversetownerrequestdata)

### SetRemoveStatusRequestData

Defines the request payload for SetRemoveStatus.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `reason` | `string?` | no | _default=""_ |

### ServerSetRemoveStatusRequestData

Extends: `SetRemoveStatusRequestData`

Defines the request payload for ServerSetRemoveStatus.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetRemoveStatusRequestData`._

Reference links:

- [InventoryModels.SetRemoveStatusRequestData:1167-1176](/docs/reference/dto/inventory/INVENTORY_MODELS.md#setremovestatusrequestdata)

### AdminSetRemoveStatusRequestData

Extends: `ServerSetRemoveStatusRequestData`

Defines the request payload for AdminSetRemoveStatus.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetRemoveStatusRequestData`._

Reference links:

- [InventoryModels.ServerSetRemoveStatusRequestData:1167-1188](/docs/reference/dto/inventory/INVENTORY_MODELS.md#serversetremovestatusrequestdata)

### SetTagRequestData

Defines the request payload for SetTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerSetTagRequestData

Extends: `SetTagRequestData`

Defines the request payload for ServerSetTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetTagRequestData`._

Reference links:

- [InventoryModels.SetTagRequestData:1201-1211](/docs/reference/dto/inventory/INVENTORY_MODELS.md#settagrequestdata)

### AdminSetTagRequestData

Extends: `ServerSetTagRequestData`

Defines the request payload for AdminSetTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetTagRequestData`._

Reference links:

- [InventoryModels.ServerSetTagRequestData:1201-1223](/docs/reference/dto/inventory/INVENTORY_MODELS.md#serversettagrequestdata)

### GetStatisticsLogRequestData

Reads statistic change logs for one inventory item. Pagination is token-based rather than skip-based.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keys` | `List<string>?` | no | _minLength=1, maxLength=32, elementCls=String_ |
| `itemId` | `string?` | no | _minLength=12, maxLength=12_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `token` | `string?` | no | Continuation token returned by the previous page. — _minLength=24, maxLength=24_ |

### ServerGetStatisticsLogRequestData

Extends: `GetStatisticsLogRequestData`

Defines the request payload for ServerGetStatisticsLog.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetStatisticsLogRequestData`._

Reference links:

- [InventoryModels.GetStatisticsLogRequestData:1236-1247](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getstatisticslogrequestdata)

### AdminGetStatisticsLogRequestData

Extends: `ServerGetStatisticsLogRequestData`

Defines the request payload for AdminGetStatisticsLog.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStatisticsLogRequestData`._

Reference links:

- [InventoryModels.ServerGetStatisticsLogRequestData:1236-1259](/docs/reference/dto/inventory/INVENTORY_MODELS.md#servergetstatisticslogrequestdata)

### InfoResponseParameters

Contains the optional fields requested through `InfoRequestParam`.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `catalogId` | `string?` | no | Catalog ID the item belongs to; present when requested. |
| `classId` | `string?` | no | Class ID of the item; present when requested. |
| `itemType` | `int?` | no | Item type mapped by the public `ItemType` enum; present when requested. |
| `amount` | `int?` | no | Current item amount; present when requested. |
| `owner` | `GenericModels.OwnerItem?` | no | Owner descriptor mapped by the public `OwnerType` enum. |
| `removeStatus` | `GenericModels.RemoveStatusItem?` | no | Soft-remove metadata; present when the item has been marked for removal. |
| `segments` | `List<string>?` | no | Segment names assigned to the item. — _elementCls=String_ |
| `customDatas` | `List<GenericModels.DataItem>?` | no | Custom data entries; present when `customDatas` is enabled in `InfoRequestParam`. — _elementCls=GenericModels.DataItem_ |
| `displayName` | `string?` | no | Display name of the item; present when requested. |
| `avatar` | `GenericModels.AvatarItem?` | no | Avatar descriptor of the item; present when requested. |
| `tsCreate` | `long?` | no | Creation timestamp of the item; present when requested. |
| `tags` | `List<GenericModels.TagItem>?` | no | Tag entries assigned to the item. — _elementCls=GenericModels.TagItem_ |
| `itemDatas` | `List<GenericModels.DataItem>?` | no | Item data entries; present when `itemDatas` is enabled. — _elementCls=GenericModels.DataItem_ |
| `itemStatistics` | `List<GenericModels.StatisticsItem>?` | no | Item statistics values; present when `itemStatistics` is enabled. — _elementCls=GenericModels.StatisticsItem_ |

Reference links:

- [InventoryModels.InfoRequestParam:11-36](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inforequestparam)
- [Generic.OwnerItem:71-80](/docs/reference/dto/generic/GENERIC_MODELS.md#owneritem)
- [Generic.RemoveStatusItem:81-90](/docs/reference/dto/generic/GENERIC_MODELS.md#removestatusitem)
- [Generic.DataItem:31-40](/docs/reference/dto/generic/GENERIC_MODELS.md#dataitem)
- [Generic.AvatarItem:1-10](/docs/reference/dto/generic/GENERIC_MODELS.md#avataritem)
- [Generic.TagItem:11-20](/docs/reference/dto/generic/GENERIC_MODELS.md#tagitem)
- [Generic.StatisticsItem:51-60](/docs/reference/dto/generic/GENERIC_MODELS.md#statisticsitem)

### InventoryResponseData

Base inventory response envelope.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoResponseParameters` | `InfoResponseParameters` | yes | Optional field bag controlled by the corresponding `InfoRequestParam`. |

Reference links:

- [InventoryModels.InfoResponseParameters:1272-1303](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inforesponseparameters)
- [InventoryModels.InfoRequestParam:11-36](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inforequestparam)

### InventoryWithItemIdResponseData

Extends: `InventoryResponseData`

Inventory envelope that also exposes the resolved item ID.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `InventoryResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | Inventory item identifier. |

Reference links:

- [InventoryModels.InventoryResponseData:1304-1317](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inventoryresponsedata)

### InventoryLeaderboardResponseData

Extends: `InventoryWithItemIdResponseData`

Defines the response payload for InventoryLeaderboard.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `InventoryWithItemIdResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `position` | `int` | yes | Zero-based leaderboard rank position of this inventory item. |
| `backupValue` | `double?` | no | Backup statistic value used as a tiebreaker when present. |

Reference links:

- [InventoryModels.InventoryWithItemIdResponseData:1304-1334](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inventorywithitemidresponsedata)

### InventoryLogResponseData

Describes one inventory-statistics change log entry.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | Inventory item ID this log entry belongs to. |
| `tsCreate` | `long` | yes | Timestamp when this log entry was recorded. |
| `log` | `string` | yes | Human-readable log message describing the change. |
| `key` | `string` | yes | Statistics key that was changed. |
| `amount` | `double` | yes | Delta amount applied in this change. |
| `startValue` | `double` | yes | Value before the change was applied. |
| `finalValue` | `double` | yes | Value after the change was applied. |

### GetStatisticsLeaderboardResponseData

Defines the response payload for GetStatisticsLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<InventoryLeaderboardResponseData>` | yes | _elementCls=InventoryLeaderboardResponseData_ |
| `tsCreate` | `long?` | no | Snapshot timestamp used for this leaderboard page when returned by the backend. |

Reference links:

- [InventoryModels.InventoryLeaderboardResponseData:1304-1352](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inventoryleaderboardresponsedata)

### InventoriesWithItemIdResponseData

Defines the response payload for InventoriesWithItemId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<InventoryWithItemIdResponseData>` | yes | _elementCls=InventoryWithItemIdResponseData_ |

Reference links:

- [InventoryModels.InventoryWithItemIdResponseData:1304-1334](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inventorywithitemidresponsedata)

### GetCreateLeaderboardResponseData

Defines the response payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<InventoryLeaderboardResponseData>` | yes | _elementCls=InventoryLeaderboardResponseData_ |

Reference links:

- [InventoryModels.InventoryLeaderboardResponseData:1304-1352](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inventoryleaderboardresponsedata)

### GetStatisticsLogResponseData

Returns one page of inventory statistics logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<InventoryLogResponseData>` | yes | _elementCls=InventoryLogResponseData_ |
| `token` | `string?` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

Reference links:

- [InventoryModels.InventoryLogResponseData:1353-1367](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inventorylogresponsedata)

### EmptyResponseData

Defines an intentionally empty response payload.

_Không có field public (payload rỗng)._
