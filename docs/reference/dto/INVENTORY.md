# DTO Reference: Inventory

Inventory item metadata, ownership, amount, statistics, activity log.

Related API reference: [API_INVENTORY.md](/docs/reference/API_INVENTORY.md).

Mỗi section bên dưới là 1 class DTO trong namespace `<Models>`. Field table cho biết: tên field, kiểu C# tương ứng, có `required` hay không (suy từ metadata `DataMember` / nullable / optional), doc comment, và ràng buộc length/range/default nếu có.

> **Cách dùng**: khi gọi `*Async()`, bạn truyền instance DTO (`new InventoryModels.<Method>RequestData()`) với các field required (+ optional nếu cần). Response class expose `responseData` là instance của class `*ResponseData` tương ứng. Không dùng object literal cast — xem [RULES § 8.1](/docs/RULES.md#81-build-request-dto-trong-code-copy-paste).

> **Naming pattern**: Mỗi method có 3 variant DTO — `XxxRequestData` (client), `ServerXxxRequestData` (server), `AdminXxxRequestData` (admin). Variant `Server`/`Admin` thường thêm field bắt buộc như `userId`/`inventoryId`. Khi tìm DTO cho một route cụ thể, nhảy thẳng tới section `[Server|Admin]XxxRequestData` tương ứng — không cần đọc cả 3.

## Danh sách

- **InventoryModels** (from `Runtime/Entity/Models/InventoryModels.cs`)
    - [CustomDataParam](#customdataparam)
    - [InfoRequestParam](#inforequestparam)
    - [ItemDataParam](#itemdataparam)
    - [ItemStatisticsParam](#itemstatisticsparam)
    - [AddSegmentRequestData](#addsegmentrequestdata)
    - [ServerAddSegmentRequestData](#serveraddsegmentrequestdata)
    - [AdminAddSegmentRequestData](#adminaddsegmentrequestdata)
    - [GetAmountRequestData](#getamountrequestdata)
    - [ServerGetAmountRequestData](#servergetamountrequestdata)
    - [AdminGetAmountRequestData](#admingetamountrequestdata)
    - [GetAvatarRequestData](#getavatarrequestdata)
    - [ServerGetAvatarRequestData](#servergetavatarrequestdata)
    - [AdminGetAvatarRequestData](#admingetavatarrequestdata)
    - [GetCatalogIdRequestData](#getcatalogidrequestdata)
    - [ServerGetCatalogIdRequestData](#servergetcatalogidrequestdata)
    - [AdminGetCatalogIdRequestData](#admingetcatalogidrequestdata)
    - [GetClassIdRequestData](#getclassidrequestdata)
    - [ServerGetClassIdRequestData](#servergetclassidrequestdata)
    - [AdminGetClassIdRequestData](#admingetclassidrequestdata)
    - [GetCustomDataRequestData](#getcustomdatarequestdata)
    - [ServerGetCustomDataRequestData](#servergetcustomdatarequestdata)
    - [AdminGetCustomDataRequestData](#admingetcustomdatarequestdata)
    - [GetDisplayNameRequestData](#getdisplaynamerequestdata)
    - [ServerGetDisplayNameRequestData](#servergetdisplaynamerequestdata)
    - [AdminGetDisplayNameRequestData](#admingetdisplaynamerequestdata)
    - [GetItemDataRequestData](#getitemdatarequestdata)
    - [ServerGetItemDataRequestData](#servergetitemdatarequestdata)
    - [AdminGetItemDataRequestData](#admingetitemdatarequestdata)
    - [GetItemInformationRequestData](#getiteminformationrequestdata)
    - [ServerGetItemInformationRequestData](#servergetiteminformationrequestdata)
    - [AdminGetItemInformationRequestData](#admingetiteminformationrequestdata)
    - [GetItemStatisticsRequestData](#getitemstatisticsrequestdata)
    - [ServerGetItemStatisticsRequestData](#servergetitemstatisticsrequestdata)
    - [AdminGetItemStatisticsRequestData](#admingetitemstatisticsrequestdata)
    - [GetItemsWithDisplayNameRequestData](#getitemswithdisplaynamerequestdata)
    - [ServerGetItemsWithDisplayNameRequestData](#servergetitemswithdisplaynamerequestdata)
    - [AdminGetItemsWithDisplayNameRequestData](#admingetitemswithdisplaynamerequestdata)
    - [GetItemsWithSegmentRequestData](#getitemswithsegmentrequestdata)
    - [ServerGetItemsWithSegmentRequestData](#servergetitemswithsegmentrequestdata)
    - [AdminGetItemsWithSegmentRequestData](#admingetitemswithsegmentrequestdata)
    - [GetItemsWithTagRequestData](#getitemswithtagrequestdata)
    - [ServerGetItemsWithTagRequestData](#servergetitemswithtagrequestdata)
    - [AdminGetItemsWithTagRequestData](#admingetitemswithtagrequestdata)
    - [GetItemTypeRequestData](#getitemtyperequestdata)
    - [ServerGetItemTypeRequestData](#servergetitemtyperequestdata)
    - [AdminGetItemTypeRequestData](#admingetitemtyperequestdata)
    - [GetOwnerRequestData](#getownerrequestdata)
    - [ServerGetOwnerRequestData](#servergetownerrequestdata)
    - [AdminGetOwnerRequestData](#admingetownerrequestdata)
    - [GetRemoveStatusRequestData](#getremovestatusrequestdata)
    - [ServerGetRemoveStatusRequestData](#servergetremovestatusrequestdata)
    - [AdminGetRemoveStatusRequestData](#admingetremovestatusrequestdata)
    - [GetSegmentRequestData](#getsegmentrequestdata)
    - [ServerGetSegmentRequestData](#servergetsegmentrequestdata)
    - [AdminGetSegmentRequestData](#admingetsegmentrequestdata)
    - [GetStatisticsLeaderboardAroundItemRequestData](#getstatisticsleaderboardarounditemrequestdata)
    - [ServerGetStatisticsLeaderboardAroundItemRequestData](#servergetstatisticsleaderboardarounditemrequestdata)
    - [AdminGetStatisticsLeaderboardAroundItemRequestData](#admingetstatisticsleaderboardarounditemrequestdata)
    - [GetStatisticsLeaderboardRequestData](#getstatisticsleaderboardrequestdata)
    - [ServerGetStatisticsLeaderboardRequestData](#servergetstatisticsleaderboardrequestdata)
    - [AdminGetStatisticsLeaderboardRequestData](#admingetstatisticsleaderboardrequestdata)
    - [GetCreateLeaderboardRequestData](#getcreateleaderboardrequestdata)
    - [ServerGetCreateLeaderboardRequestData](#servergetcreateleaderboardrequestdata)
    - [AdminGetCreateLeaderboardRequestData](#admingetcreateleaderboardrequestdata)
    - [GetTagRequestData](#gettagrequestdata)
    - [ServerGetTagRequestData](#servergettagrequestdata)
    - [AdminGetTagRequestData](#admingettagrequestdata)
    - [GetTsCreateRequestData](#gettscreaterequestdata)
    - [ServerGetTsCreateRequestData](#servergettscreaterequestdata)
    - [AdminGetTsCreateRequestData](#admingettscreaterequestdata)
    - [RemoveSegmentRequestData](#removesegmentrequestdata)
    - [ServerRemoveSegmentRequestData](#serverremovesegmentrequestdata)
    - [AdminRemoveSegmentRequestData](#adminremovesegmentrequestdata)
    - [RemoveTagRequestData](#removetagrequestdata)
    - [ServerRemoveTagRequestData](#serverremovetagrequestdata)
    - [AdminRemoveTagRequestData](#adminremovetagrequestdata)
    - [SetAmountRequestData](#setamountrequestdata)
    - [ServerSetAmountRequestData](#serversetamountrequestdata)
    - [AdminSetAmountRequestData](#adminsetamountrequestdata)
    - [SetAvatarRequestData](#setavatarrequestdata)
    - [ServerSetAvatarRequestData](#serversetavatarrequestdata)
    - [AdminSetAvatarRequestData](#adminsetavatarrequestdata)
    - [SetCustomDataRequestData](#setcustomdatarequestdata)
    - [ServerSetCustomDataRequestData](#serversetcustomdatarequestdata)
    - [AdminSetCustomDataRequestData](#adminsetcustomdatarequestdata)
    - [SetDisplayNameRequestData](#setdisplaynamerequestdata)
    - [ServerSetDisplayNameRequestData](#serversetdisplaynamerequestdata)
    - [AdminSetDisplayNameRequestData](#adminsetdisplaynamerequestdata)
    - [SetItemDataRequestData](#setitemdatarequestdata)
    - [ServerSetItemDataRequestData](#serversetitemdatarequestdata)
    - [AdminSetItemDataRequestData](#adminsetitemdatarequestdata)
    - [ChangeItemStatisticsRequestData](#changeitemstatisticsrequestdata)
    - [ServerChangeItemStatisticsRequestData](#serverchangeitemstatisticsrequestdata)
    - [AdminChangeItemStatisticsRequestData](#adminchangeitemstatisticsrequestdata)
    - [SetOwnerRequestData](#setownerrequestdata)
    - [ServerSetOwnerRequestData](#serversetownerrequestdata)
    - [AdminSetOwnerRequestData](#adminsetownerrequestdata)
    - [SetRemoveStatusRequestData](#setremovestatusrequestdata)
    - [ServerSetRemoveStatusRequestData](#serversetremovestatusrequestdata)
    - [AdminSetRemoveStatusRequestData](#adminsetremovestatusrequestdata)
    - [SetTagRequestData](#settagrequestdata)
    - [ServerSetTagRequestData](#serversettagrequestdata)
    - [AdminSetTagRequestData](#adminsettagrequestdata)
    - [GetStatisticsLogRequestData](#getstatisticslogrequestdata)
    - [ServerGetStatisticsLogRequestData](#servergetstatisticslogrequestdata)
    - [AdminGetStatisticsLogRequestData](#admingetstatisticslogrequestdata)
    - [InfoResponseParameters](#inforesponseparameters)
    - [InventoryResponseData](#inventoryresponsedata)
    - [InventoryWithItemIdResponseData](#inventorywithitemidresponsedata)
    - [InventoryLeaderboardResponseData](#inventoryleaderboardresponsedata)
    - [InventoryLogResponseData](#inventorylogresponsedata)
    - [GetStatisticsLeaderboardResponseData](#getstatisticsleaderboardresponsedata)
    - [InventoriesWithItemIdResponseData](#inventorieswithitemidresponsedata)
    - [GetCreateLeaderboardResponseData](#getcreateleaderboardresponsedata)
    - [GetStatisticsLogResponseData](#getstatisticslogresponsedata)
    - [EmptyResponseData](#emptyresponsedata)
- **InventoryRequestModels** (from `Runtime/Entity/Models/InventoryRequestModels.cs`)
    - [AddSegmentOperationRequest](#addsegmentoperationrequest)
    - [ServerAddSegmentOperationRequest](#serveraddsegmentoperationrequest)
    - [AdminAddSegmentOperationRequest](#adminaddsegmentoperationrequest)
    - [GetAmountOperationRequest](#getamountoperationrequest)
    - [ServerGetAmountOperationRequest](#servergetamountoperationrequest)
    - [AdminGetAmountOperationRequest](#admingetamountoperationrequest)
    - [GetAvatarOperationRequest](#getavataroperationrequest)
    - [ServerGetAvatarOperationRequest](#servergetavataroperationrequest)
    - [AdminGetAvatarOperationRequest](#admingetavataroperationrequest)
    - [GetCatalogIdOperationRequest](#getcatalogidoperationrequest)
    - [ServerGetCatalogIdOperationRequest](#servergetcatalogidoperationrequest)
    - [AdminGetCatalogIdOperationRequest](#admingetcatalogidoperationrequest)
    - [GetClassIdOperationRequest](#getclassidoperationrequest)
    - [ServerGetClassIdOperationRequest](#servergetclassidoperationrequest)
    - [AdminGetClassIdOperationRequest](#admingetclassidoperationrequest)
    - [GetCustomDataOperationRequest](#getcustomdataoperationrequest)
    - [ServerGetCustomDataOperationRequest](#servergetcustomdataoperationrequest)
    - [AdminGetCustomDataOperationRequest](#admingetcustomdataoperationrequest)
    - [GetDisplayNameOperationRequest](#getdisplaynameoperationrequest)
    - [ServerGetDisplayNameOperationRequest](#servergetdisplaynameoperationrequest)
    - [AdminGetDisplayNameOperationRequest](#admingetdisplaynameoperationrequest)
    - [GetItemDataOperationRequest](#getitemdataoperationrequest)
    - [ServerGetItemDataOperationRequest](#servergetitemdataoperationrequest)
    - [AdminGetItemDataOperationRequest](#admingetitemdataoperationrequest)
    - [GetItemInformationOperationRequest](#getiteminformationoperationrequest)
    - [ServerGetItemInformationOperationRequest](#servergetiteminformationoperationrequest)
    - [AdminGetItemInformationOperationRequest](#admingetiteminformationoperationrequest)
    - [GetItemStatisticsOperationRequest](#getitemstatisticsoperationrequest)
    - [ServerGetItemStatisticsOperationRequest](#servergetitemstatisticsoperationrequest)
    - [AdminGetItemStatisticsOperationRequest](#admingetitemstatisticsoperationrequest)
    - [GetItemsWithDisplayNameOperationRequest](#getitemswithdisplaynameoperationrequest)
    - [ServerGetItemsWithDisplayNameOperationRequest](#servergetitemswithdisplaynameoperationrequest)
    - [AdminGetItemsWithDisplayNameOperationRequest](#admingetitemswithdisplaynameoperationrequest)
    - [GetItemsWithSegmentOperationRequest](#getitemswithsegmentoperationrequest)
    - [ServerGetItemsWithSegmentOperationRequest](#servergetitemswithsegmentoperationrequest)
    - [AdminGetItemsWithSegmentOperationRequest](#admingetitemswithsegmentoperationrequest)
    - [GetItemsWithTagOperationRequest](#getitemswithtagoperationrequest)
    - [ServerGetItemsWithTagOperationRequest](#servergetitemswithtagoperationrequest)
    - [AdminGetItemsWithTagOperationRequest](#admingetitemswithtagoperationrequest)
    - [GetItemTypeOperationRequest](#getitemtypeoperationrequest)
    - [ServerGetItemTypeOperationRequest](#servergetitemtypeoperationrequest)
    - [AdminGetItemTypeOperationRequest](#admingetitemtypeoperationrequest)
    - [GetOwnerOperationRequest](#getowneroperationrequest)
    - [ServerGetOwnerOperationRequest](#servergetowneroperationrequest)
    - [AdminGetOwnerOperationRequest](#admingetowneroperationrequest)
    - [GetRemoveStatusOperationRequest](#getremovestatusoperationrequest)
    - [ServerGetRemoveStatusOperationRequest](#servergetremovestatusoperationrequest)
    - [AdminGetRemoveStatusOperationRequest](#admingetremovestatusoperationrequest)
    - [GetSegmentOperationRequest](#getsegmentoperationrequest)
    - [ServerGetSegmentOperationRequest](#servergetsegmentoperationrequest)
    - [AdminGetSegmentOperationRequest](#admingetsegmentoperationrequest)
    - [GetStatisticsLeaderboardAroundItemOperationRequest](#getstatisticsleaderboardarounditemoperationrequest)
    - [ServerGetStatisticsLeaderboardAroundItemOperationRequest](#servergetstatisticsleaderboardarounditemoperationrequest)
    - [AdminGetStatisticsLeaderboardAroundItemOperationRequest](#admingetstatisticsleaderboardarounditemoperationrequest)
    - [GetStatisticsLeaderboardOperationRequest](#getstatisticsleaderboardoperationrequest)
    - [ServerGetStatisticsLeaderboardOperationRequest](#servergetstatisticsleaderboardoperationrequest)
    - [AdminGetStatisticsLeaderboardOperationRequest](#admingetstatisticsleaderboardoperationrequest)
    - [GetTagOperationRequest](#gettagoperationrequest)
    - [ServerGetTagOperationRequest](#servergettagoperationrequest)
    - [AdminGetTagOperationRequest](#admingettagoperationrequest)
    - [GetTsCreateOperationRequest](#gettscreateoperationrequest)
    - [ServerGetTsCreateOperationRequest](#servergettscreateoperationrequest)
    - [AdminGetTsCreateOperationRequest](#admingettscreateoperationrequest)
    - [RemoveSegmentOperationRequest](#removesegmentoperationrequest)
    - [ServerRemoveSegmentOperationRequest](#serverremovesegmentoperationrequest)
    - [AdminRemoveSegmentOperationRequest](#adminremovesegmentoperationrequest)
    - [RemoveTagOperationRequest](#removetagoperationrequest)
    - [ServerRemoveTagOperationRequest](#serverremovetagoperationrequest)
    - [AdminRemoveTagOperationRequest](#adminremovetagoperationrequest)
    - [SetAmountOperationRequest](#setamountoperationrequest)
    - [ServerSetAmountOperationRequest](#serversetamountoperationrequest)
    - [AdminSetAmountOperationRequest](#adminsetamountoperationrequest)
    - [SetAvatarOperationRequest](#setavataroperationrequest)
    - [ServerSetAvatarOperationRequest](#serversetavataroperationrequest)
    - [AdminSetAvatarOperationRequest](#adminsetavataroperationrequest)
    - [SetCustomDataOperationRequest](#setcustomdataoperationrequest)
    - [ServerSetCustomDataOperationRequest](#serversetcustomdataoperationrequest)
    - [AdminSetCustomDataOperationRequest](#adminsetcustomdataoperationrequest)
    - [SetDisplayNameOperationRequest](#setdisplaynameoperationrequest)
    - [ServerSetDisplayNameOperationRequest](#serversetdisplaynameoperationrequest)
    - [AdminSetDisplayNameOperationRequest](#adminsetdisplaynameoperationrequest)
    - [SetItemDataOperationRequest](#setitemdataoperationrequest)
    - [ServerSetItemDataOperationRequest](#serversetitemdataoperationrequest)
    - [AdminSetItemDataOperationRequest](#adminsetitemdataoperationrequest)
    - [ChangeItemStatisticsOperationRequest](#changeitemstatisticsoperationrequest)
    - [ServerChangeItemStatisticsOperationRequest](#serverchangeitemstatisticsoperationrequest)
    - [AdminChangeItemStatisticsOperationRequest](#adminchangeitemstatisticsoperationrequest)
    - [SetOwnerOperationRequest](#setowneroperationrequest)
    - [ServerSetOwnerOperationRequest](#serversetowneroperationrequest)
    - [AdminSetOwnerOperationRequest](#adminsetowneroperationrequest)
    - [SetRemoveStatusOperationRequest](#setremovestatusoperationrequest)
    - [ServerSetRemoveStatusOperationRequest](#serversetremovestatusoperationrequest)
    - [AdminSetRemoveStatusOperationRequest](#adminsetremovestatusoperationrequest)
    - [SetTagOperationRequest](#settagoperationrequest)
    - [ServerSetTagOperationRequest](#serversettagoperationrequest)
    - [AdminSetTagOperationRequest](#adminsettagoperationrequest)
    - [GetCreateLeaderboardOperationRequest](#getcreateleaderboardoperationrequest)
    - [ServerGetCreateLeaderboardOperationRequest](#servergetcreateleaderboardoperationrequest)
    - [AdminGetCreateLeaderboardOperationRequest](#admingetcreateleaderboardoperationrequest)
    - [GetStatisticsLogOperationRequest](#getstatisticslogoperationrequest)
    - [ServerGetStatisticsLogOperationRequest](#servergetstatisticslogoperationrequest)
    - [AdminGetStatisticsLogOperationRequest](#admingetstatisticslogoperationrequest)
- **InventoryResponseModels** (from `Runtime/Entity/Models/InventoryResponseModels.cs`)
    - [AddSegmentOperationResponse](#addsegmentoperationresponse)
    - [GetAmountOperationResponse](#getamountoperationresponse)
    - [GetAvatarOperationResponse](#getavataroperationresponse)
    - [GetCatalogIdOperationResponse](#getcatalogidoperationresponse)
    - [GetClassIdOperationResponse](#getclassidoperationresponse)
    - [GetCustomDataOperationResponse](#getcustomdataoperationresponse)
    - [GetDisplayNameOperationResponse](#getdisplaynameoperationresponse)
    - [GetItemDataOperationResponse](#getitemdataoperationresponse)
    - [GetItemInformationOperationResponse](#getiteminformationoperationresponse)
    - [GetItemStatisticsOperationResponse](#getitemstatisticsoperationresponse)
    - [GetItemsWithDisplayNameOperationResponse](#getitemswithdisplaynameoperationresponse)
    - [GetItemsWithSegmentOperationResponse](#getitemswithsegmentoperationresponse)
    - [GetItemsWithTagOperationResponse](#getitemswithtagoperationresponse)
    - [GetItemTypeOperationResponse](#getitemtypeoperationresponse)
    - [GetOwnerOperationResponse](#getowneroperationresponse)
    - [GetRemoveStatusOperationResponse](#getremovestatusoperationresponse)
    - [GetSegmentOperationResponse](#getsegmentoperationresponse)
    - [GetStatisticsLeaderboardAroundItemOperationResponse](#getstatisticsleaderboardarounditemoperationresponse)
    - [GetStatisticsLeaderboardOperationResponse](#getstatisticsleaderboardoperationresponse)
    - [GetTagOperationResponse](#gettagoperationresponse)
    - [GetTsCreateOperationResponse](#gettscreateoperationresponse)
    - [RemoveSegmentOperationResponse](#removesegmentoperationresponse)
    - [RemoveTagOperationResponse](#removetagoperationresponse)
    - [SetAmountOperationResponse](#setamountoperationresponse)
    - [SetAvatarOperationResponse](#setavataroperationresponse)
    - [SetCustomDataOperationResponse](#setcustomdataoperationresponse)
    - [SetDisplayNameOperationResponse](#setdisplaynameoperationresponse)
    - [SetItemDataOperationResponse](#setitemdataoperationresponse)
    - [ChangeItemStatisticsOperationResponse](#changeitemstatisticsoperationresponse)
    - [SetOwnerOperationResponse](#setowneroperationresponse)
    - [SetRemoveStatusOperationResponse](#setremovestatusoperationresponse)
    - [SetTagOperationResponse](#settagoperationresponse)
    - [GetCreateLeaderboardOperationResponse](#getcreateleaderboardoperationresponse)
    - [GetStatisticsLogOperationResponse](#getstatisticslogoperationresponse)

---

## Namespace `InventoryModels`

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

_Không có field public (payload rỗng)._

### AdminAddSegmentRequestData

Extends: `ServerAddSegmentRequestData`

Defines the request payload for AdminAddSegment.

_Không có field public (payload rỗng)._

### GetAmountRequestData

Defines the request payload for GetAmount.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetAmountRequestData

Extends: `GetAmountRequestData`

Defines the request payload for ServerGetAmount.

_Không có field public (payload rỗng)._

### AdminGetAmountRequestData

Extends: `ServerGetAmountRequestData`

Defines the request payload for AdminGetAmount.

_Không có field public (payload rỗng)._

### GetAvatarRequestData

Defines the request payload for GetAvatar.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetAvatarRequestData

Extends: `GetAvatarRequestData`

Defines the request payload for ServerGetAvatar.

_Không có field public (payload rỗng)._

### AdminGetAvatarRequestData

Extends: `ServerGetAvatarRequestData`

Defines the request payload for AdminGetAvatar.

_Không có field public (payload rỗng)._

### GetCatalogIdRequestData

Defines the request payload for GetCatalogId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetCatalogIdRequestData

Extends: `GetCatalogIdRequestData`

Defines the request payload for ServerGetCatalogId.

_Không có field public (payload rỗng)._

### AdminGetCatalogIdRequestData

Extends: `ServerGetCatalogIdRequestData`

Defines the request payload for AdminGetCatalogId.

_Không có field public (payload rỗng)._

### GetClassIdRequestData

Defines the request payload for GetClassId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetClassIdRequestData

Extends: `GetClassIdRequestData`

Defines the request payload for ServerGetClassId.

_Không có field public (payload rỗng)._

### AdminGetClassIdRequestData

Extends: `ServerGetClassIdRequestData`

Defines the request payload for AdminGetClassId.

_Không có field public (payload rỗng)._

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

_Không có field public (payload rỗng)._

### AdminGetCustomDataRequestData

Extends: `ServerGetCustomDataRequestData`

Defines the request payload for AdminGetCustomData.

_Không có field public (payload rỗng)._

### GetDisplayNameRequestData

Defines the request payload for GetDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetDisplayNameRequestData

Extends: `GetDisplayNameRequestData`

Defines the request payload for ServerGetDisplayName.

_Không có field public (payload rỗng)._

### AdminGetDisplayNameRequestData

Extends: `ServerGetDisplayNameRequestData`

Defines the request payload for AdminGetDisplayName.

_Không có field public (payload rỗng)._

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

_Không có field public (payload rỗng)._

### AdminGetItemDataRequestData

Extends: `ServerGetItemDataRequestData`

Defines the request payload for AdminGetItemData.

_Không có field public (payload rỗng)._

### GetItemInformationRequestData

Defines the request payload for GetItemInformation.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional inventory item fields are included in the response. |

### ServerGetItemInformationRequestData

Extends: `GetItemInformationRequestData`

Defines the request payload for ServerGetItemInformation.

_Không có field public (payload rỗng)._

### AdminGetItemInformationRequestData

Extends: `ServerGetItemInformationRequestData`

Defines the request payload for AdminGetItemInformation.

_Không có field public (payload rỗng)._

### GetItemStatisticsRequestData

Reads statistics for one inventory item. Note that this request uses `statisticsKeys`, while `InfoRequestParam` uses `itemStatisticsKeys`.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `statisticsKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetItemStatisticsRequestData

Extends: `GetItemStatisticsRequestData`

Defines the request payload for ServerGetItemStatistics.

_Không có field public (payload rỗng)._

### AdminGetItemStatisticsRequestData

Extends: `ServerGetItemStatisticsRequestData`

Defines the request payload for AdminGetItemStatistics.

_Không có field public (payload rỗng)._

### GetItemsWithDisplayNameRequestData

Defines the request payload for GetItemsWithDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keyword` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional inventory item fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

### ServerGetItemsWithDisplayNameRequestData

Extends: `GetItemsWithDisplayNameRequestData`

Defines the request payload for ServerGetItemsWithDisplayName.

_Không có field public (payload rỗng)._

### AdminGetItemsWithDisplayNameRequestData

Extends: `ServerGetItemsWithDisplayNameRequestData`

Defines the request payload for AdminGetItemsWithDisplayName.

_Không có field public (payload rỗng)._

### GetItemsWithSegmentRequestData

Defines the request payload for GetItemsWithSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional inventory item fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

### ServerGetItemsWithSegmentRequestData

Extends: `GetItemsWithSegmentRequestData`

Defines the request payload for ServerGetItemsWithSegment.

_Không có field public (payload rỗng)._

### AdminGetItemsWithSegmentRequestData

Extends: `ServerGetItemsWithSegmentRequestData`

Defines the request payload for AdminGetItemsWithSegment.

_Không có field public (payload rỗng)._

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

### ServerGetItemsWithTagRequestData

Extends: `GetItemsWithTagRequestData`

Defines the request payload for ServerGetItemsWithTag.

_Không có field public (payload rỗng)._

### AdminGetItemsWithTagRequestData

Extends: `ServerGetItemsWithTagRequestData`

Defines the request payload for AdminGetItemsWithTag.

_Không có field public (payload rỗng)._

### GetItemTypeRequestData

Defines the request payload for GetItemType.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetItemTypeRequestData

Extends: `GetItemTypeRequestData`

Defines the request payload for ServerGetItemType.

_Không có field public (payload rỗng)._

### AdminGetItemTypeRequestData

Extends: `ServerGetItemTypeRequestData`

Defines the request payload for AdminGetItemType.

_Không có field public (payload rỗng)._

### GetOwnerRequestData

Defines the request payload for GetOwner.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetOwnerRequestData

Extends: `GetOwnerRequestData`

Defines the request payload for ServerGetOwner.

_Không có field public (payload rỗng)._

### AdminGetOwnerRequestData

Extends: `ServerGetOwnerRequestData`

Defines the request payload for AdminGetOwner.

_Không có field public (payload rỗng)._

### GetRemoveStatusRequestData

Defines the request payload for GetRemoveStatus.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetRemoveStatusRequestData

Extends: `GetRemoveStatusRequestData`

Defines the request payload for ServerGetRemoveStatus.

_Không có field public (payload rỗng)._

### AdminGetRemoveStatusRequestData

Extends: `ServerGetRemoveStatusRequestData`

Defines the request payload for AdminGetRemoveStatus.

_Không có field public (payload rỗng)._

### GetSegmentRequestData

Defines the request payload for GetSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetSegmentRequestData

Extends: `GetSegmentRequestData`

Defines the request payload for ServerGetSegment.

_Không có field public (payload rỗng)._

### AdminGetSegmentRequestData

Extends: `ServerGetSegmentRequestData`

Defines the request payload for AdminGetSegment.

_Không có field public (payload rỗng)._

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

### ServerGetStatisticsLeaderboardAroundItemRequestData

Extends: `GetStatisticsLeaderboardAroundItemRequestData`

Defines the request payload for ServerGetStatisticsLeaderboardAroundItem.

_Không có field public (payload rỗng)._

### AdminGetStatisticsLeaderboardAroundItemRequestData

Extends: `ServerGetStatisticsLeaderboardAroundItemRequestData`

Defines the request payload for AdminGetStatisticsLeaderboardAroundItem.

_Không có field public (payload rỗng)._

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

### ServerGetStatisticsLeaderboardRequestData

Extends: `GetStatisticsLeaderboardRequestData`

Defines the request payload for ServerGetStatisticsLeaderboard.

_Không có field public (payload rỗng)._

### AdminGetStatisticsLeaderboardRequestData

Extends: `ServerGetStatisticsLeaderboardRequestData`

Defines the request payload for AdminGetStatisticsLeaderboard.

_Không có field public (payload rỗng)._

### GetCreateLeaderboardRequestData

Defines the request payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional inventory item fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

### ServerGetCreateLeaderboardRequestData

Extends: `GetCreateLeaderboardRequestData`

Defines the request payload for ServerGetCreateLeaderboard.

_Không có field public (payload rỗng)._

### AdminGetCreateLeaderboardRequestData

Extends: `ServerGetCreateLeaderboardRequestData`

Defines the request payload for AdminGetCreateLeaderboard.

_Không có field public (payload rỗng)._

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

_Không có field public (payload rỗng)._

### AdminGetTagRequestData

Extends: `ServerGetTagRequestData`

Defines the request payload for AdminGetTag.

_Không có field public (payload rỗng)._

### GetTsCreateRequestData

Defines the request payload for GetTsCreate.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerGetTsCreateRequestData

Extends: `GetTsCreateRequestData`

Defines the request payload for ServerGetTsCreate.

_Không có field public (payload rỗng)._

### AdminGetTsCreateRequestData

Extends: `ServerGetTsCreateRequestData`

Defines the request payload for AdminGetTsCreate.

_Không có field public (payload rỗng)._

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

_Không có field public (payload rỗng)._

### AdminRemoveSegmentRequestData

Extends: `ServerRemoveSegmentRequestData`

Defines the request payload for AdminRemoveSegment.

_Không có field public (payload rỗng)._

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

_Không có field public (payload rỗng)._

### AdminRemoveTagRequestData

Extends: `ServerRemoveTagRequestData`

Defines the request payload for AdminRemoveTag.

_Không có field public (payload rỗng)._

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

_Không có field public (payload rỗng)._

### AdminSetAmountRequestData

Extends: `ServerSetAmountRequestData`

Defines the request payload for AdminSetAmount.

_Không có field public (payload rỗng)._

### SetAvatarRequestData

Defines the request payload for SetAvatar.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `type` | `int` | yes | Avatar type identifier. User custom this type enum. |
| `value` | `string` | yes | Avatar value such as a URL, file ID, or provider-specific string. — _minLength=1, maxLength=128_ |

### ServerSetAvatarRequestData

Extends: `SetAvatarRequestData`

Defines the request payload for ServerSetAvatar.

_Không có field public (payload rỗng)._

### AdminSetAvatarRequestData

Extends: `ServerSetAvatarRequestData`

Defines the request payload for AdminSetAvatar.

_Không có field public (payload rỗng)._

### SetCustomDataRequestData

Defines the request payload for SetCustomData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `customDatas` | `List<CustomDataParam>` | yes | _minLength=1, maxLength=32, elementCls=CustomDataParam_ |

### ServerSetCustomDataRequestData

Extends: `SetCustomDataRequestData`

Defines the request payload for ServerSetCustomData.

_Không có field public (payload rỗng)._

### AdminSetCustomDataRequestData

Extends: `ServerSetCustomDataRequestData`

Defines the request payload for AdminSetCustomData.

_Không có field public (payload rỗng)._

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

_Không có field public (payload rỗng)._

### AdminSetDisplayNameRequestData

Extends: `ServerSetDisplayNameRequestData`

Defines the request payload for AdminSetDisplayName.

_Không có field public (payload rỗng)._

### SetItemDataRequestData

Defines the request payload for SetItemData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `itemDatas` | `List<ItemDataParam>` | yes | _minLength=1, maxLength=32, elementCls=ItemDataParam_ |

### ServerSetItemDataRequestData

Extends: `SetItemDataRequestData`

Defines the request payload for ServerSetItemData.

_Không có field public (payload rỗng)._

### AdminSetItemDataRequestData

Extends: `ServerSetItemDataRequestData`

Defines the request payload for AdminSetItemData.

_Không có field public (payload rỗng)._

### ChangeItemStatisticsRequestData

Applies delta updates to one or more item statistics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |
| `itemStatistics` | `List<ItemStatisticsParam>` | yes | _minLength=1, maxLength=32, elementCls=ItemStatisticsParam_ |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

### ServerChangeItemStatisticsRequestData

Extends: `ChangeItemStatisticsRequestData`

Defines the request payload for ServerChangeItemStatistics.

_Không có field public (payload rỗng)._

### AdminChangeItemStatisticsRequestData

Extends: `ServerChangeItemStatisticsRequestData`

Defines the request payload for AdminChangeItemStatistics.

_Không có field public (payload rỗng)._

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

_Không có field public (payload rỗng)._

### AdminSetOwnerRequestData

Extends: `ServerSetOwnerRequestData`

Defines the request payload for AdminSetOwner.

_Không có field public (payload rỗng)._

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

_Không có field public (payload rỗng)._

### AdminSetRemoveStatusRequestData

Extends: `ServerSetRemoveStatusRequestData`

Defines the request payload for AdminSetRemoveStatus.

_Không có field public (payload rỗng)._

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

_Không có field public (payload rỗng)._

### AdminSetTagRequestData

Extends: `ServerSetTagRequestData`

Defines the request payload for AdminSetTag.

_Không có field public (payload rỗng)._

### GetStatisticsLogRequestData

Reads statistic change logs for one inventory item. Pagination is token-based rather than skip-based.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keys` | `List<string>?` | yes | _minLength=1, maxLength=32, elementCls=String_ |
| `itemId` | `string?` | yes | _minLength=12, maxLength=12_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `token` | `string?` | yes | Continuation token returned by the previous page. — _minLength=24, maxLength=24_ |

### ServerGetStatisticsLogRequestData

Extends: `GetStatisticsLogRequestData`

Defines the request payload for ServerGetStatisticsLog.

_Không có field public (payload rỗng)._

### AdminGetStatisticsLogRequestData

Extends: `ServerGetStatisticsLogRequestData`

Defines the request payload for AdminGetStatisticsLog.

_Không có field public (payload rỗng)._

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

### InventoryResponseData

Base inventory response envelope.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoResponseParameters` | `InfoResponseParameters` | yes | Optional field bag controlled by the corresponding `InfoRequestParam`. |

### InventoryWithItemIdResponseData

Extends: `InventoryResponseData`

Inventory envelope that also exposes the resolved item ID.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | Inventory item identifier. |

### InventoryLeaderboardResponseData

Extends: `InventoryWithItemIdResponseData`

Defines the response payload for InventoryLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `position` | `int` | yes | Zero-based leaderboard rank position of this inventory item. |
| `backupValue` | `double?` | no | Backup statistic value used as a tiebreaker when present. |

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

### InventoriesWithItemIdResponseData

Defines the response payload for InventoriesWithItemId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<InventoryWithItemIdResponseData>` | yes | _elementCls=InventoryWithItemIdResponseData_ |

### GetCreateLeaderboardResponseData

Defines the response payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<InventoryLeaderboardResponseData>` | yes | _elementCls=InventoryLeaderboardResponseData_ |

### GetStatisticsLogResponseData

Returns one page of inventory statistics logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<InventoryLogResponseData>` | yes | _elementCls=InventoryLogResponseData_ |
| `token` | `string?` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

### EmptyResponseData

Defines an intentionally empty response payload.

_Không có field public (payload rỗng)._

## Namespace `InventoryRequestModels`

### AddSegmentOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.AddSegmentRequestData>`

Maps the AddSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerAddSegmentOperationRequest

Extends: `AddSegmentOperationRequest`

Maps the ServerAddSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminAddSegmentOperationRequest

Extends: `AddSegmentOperationRequest`

Maps the AdminAddSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetAmountOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetAmountRequestData>`

Maps the GetAmount operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetAmountOperationRequest

Extends: `GetAmountOperationRequest`

Maps the ServerGetAmount operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetAmountOperationRequest

Extends: `GetAmountOperationRequest`

Maps the AdminGetAmount operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetAvatarOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetAvatarRequestData>`

Maps the GetAvatar operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetAvatarOperationRequest

Extends: `GetAvatarOperationRequest`

Maps the ServerGetAvatar operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetAvatarOperationRequest

Extends: `GetAvatarOperationRequest`

Maps the AdminGetAvatar operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetCatalogIdOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetCatalogIdRequestData>`

Maps the GetCatalogId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetCatalogIdOperationRequest

Extends: `GetCatalogIdOperationRequest`

Maps the ServerGetCatalogId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetCatalogIdOperationRequest

Extends: `GetCatalogIdOperationRequest`

Maps the AdminGetCatalogId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetClassIdOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetClassIdRequestData>`

Maps the GetClassId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetClassIdOperationRequest

Extends: `GetClassIdOperationRequest`

Maps the ServerGetClassId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetClassIdOperationRequest

Extends: `GetClassIdOperationRequest`

Maps the AdminGetClassId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetCustomDataOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetCustomDataRequestData>`

Maps the GetCustomData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetCustomDataOperationRequest

Extends: `GetCustomDataOperationRequest`

Maps the ServerGetCustomData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetCustomDataOperationRequest

Extends: `GetCustomDataOperationRequest`

Maps the AdminGetCustomData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetDisplayNameOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetDisplayNameRequestData>`

Maps the GetDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetDisplayNameOperationRequest

Extends: `GetDisplayNameOperationRequest`

Maps the ServerGetDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetDisplayNameOperationRequest

Extends: `GetDisplayNameOperationRequest`

Maps the AdminGetDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetItemDataOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetItemDataRequestData>`

Maps the GetItemData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetItemDataOperationRequest

Extends: `GetItemDataOperationRequest`

Maps the ServerGetItemData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetItemDataOperationRequest

Extends: `GetItemDataOperationRequest`

Maps the AdminGetItemData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetItemInformationOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetItemInformationRequestData>`

Maps the GetItemInformation operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetItemInformationOperationRequest

Extends: `GetItemInformationOperationRequest`

Maps the ServerGetItemInformation operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetItemInformationOperationRequest

Extends: `GetItemInformationOperationRequest`

Maps the AdminGetItemInformation operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetItemStatisticsOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetItemStatisticsRequestData>`

Maps the GetItemStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetItemStatisticsOperationRequest

Extends: `GetItemStatisticsOperationRequest`

Maps the ServerGetItemStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetItemStatisticsOperationRequest

Extends: `GetItemStatisticsOperationRequest`

Maps the AdminGetItemStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetItemsWithDisplayNameOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetItemsWithDisplayNameRequestData>`

Maps the GetItemsWithDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetItemsWithDisplayNameOperationRequest

Extends: `GetItemsWithDisplayNameOperationRequest`

Maps the ServerGetItemsWithDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetItemsWithDisplayNameOperationRequest

Extends: `GetItemsWithDisplayNameOperationRequest`

Maps the AdminGetItemsWithDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetItemsWithSegmentOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetItemsWithSegmentRequestData>`

Maps the GetItemsWithSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetItemsWithSegmentOperationRequest

Extends: `GetItemsWithSegmentOperationRequest`

Maps the ServerGetItemsWithSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetItemsWithSegmentOperationRequest

Extends: `GetItemsWithSegmentOperationRequest`

Maps the AdminGetItemsWithSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetItemsWithTagOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetItemsWithTagRequestData>`

Maps the GetItemsWithTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetItemsWithTagOperationRequest

Extends: `GetItemsWithTagOperationRequest`

Maps the ServerGetItemsWithTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetItemsWithTagOperationRequest

Extends: `GetItemsWithTagOperationRequest`

Maps the AdminGetItemsWithTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetItemTypeOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetItemTypeRequestData>`

Maps the GetItemType operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetItemTypeOperationRequest

Extends: `GetItemTypeOperationRequest`

Maps the ServerGetItemType operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetItemTypeOperationRequest

Extends: `GetItemTypeOperationRequest`

Maps the AdminGetItemType operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetOwnerOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetOwnerRequestData>`

Maps the GetOwner operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetOwnerOperationRequest

Extends: `GetOwnerOperationRequest`

Maps the ServerGetOwner operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetOwnerOperationRequest

Extends: `GetOwnerOperationRequest`

Maps the AdminGetOwner operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetRemoveStatusOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetRemoveStatusRequestData>`

Maps the GetRemoveStatus operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetRemoveStatusOperationRequest

Extends: `GetRemoveStatusOperationRequest`

Maps the ServerGetRemoveStatus operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetRemoveStatusOperationRequest

Extends: `GetRemoveStatusOperationRequest`

Maps the AdminGetRemoveStatus operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetSegmentOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetSegmentRequestData>`

Maps the GetSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetSegmentOperationRequest

Extends: `GetSegmentOperationRequest`

Maps the ServerGetSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetSegmentOperationRequest

Extends: `GetSegmentOperationRequest`

Maps the AdminGetSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLeaderboardAroundItemOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetStatisticsLeaderboardAroundItemRequestData>`

Maps the GetStatisticsLeaderboardAroundItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetStatisticsLeaderboardAroundItemOperationRequest

Extends: `GetStatisticsLeaderboardAroundItemOperationRequest`

Maps the ServerGetStatisticsLeaderboardAroundItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetStatisticsLeaderboardAroundItemOperationRequest

Extends: `GetStatisticsLeaderboardAroundItemOperationRequest`

Maps the AdminGetStatisticsLeaderboardAroundItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLeaderboardOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetStatisticsLeaderboardRequestData>`

Maps the GetStatisticsLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetStatisticsLeaderboardOperationRequest

Extends: `GetStatisticsLeaderboardOperationRequest`

Maps the ServerGetStatisticsLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetStatisticsLeaderboardOperationRequest

Extends: `GetStatisticsLeaderboardOperationRequest`

Maps the AdminGetStatisticsLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetTagOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetTagRequestData>`

Maps the GetTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetTagOperationRequest

Extends: `GetTagOperationRequest`

Maps the ServerGetTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetTagOperationRequest

Extends: `GetTagOperationRequest`

Maps the AdminGetTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetTsCreateOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetTsCreateRequestData>`

Maps the GetTsCreate operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetTsCreateOperationRequest

Extends: `GetTsCreateOperationRequest`

Maps the ServerGetTsCreate operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetTsCreateOperationRequest

Extends: `GetTsCreateOperationRequest`

Maps the AdminGetTsCreate operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### RemoveSegmentOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.RemoveSegmentRequestData>`

Maps the RemoveSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerRemoveSegmentOperationRequest

Extends: `RemoveSegmentOperationRequest`

Maps the ServerRemoveSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminRemoveSegmentOperationRequest

Extends: `RemoveSegmentOperationRequest`

Maps the AdminRemoveSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### RemoveTagOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.RemoveTagRequestData>`

Maps the RemoveTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerRemoveTagOperationRequest

Extends: `RemoveTagOperationRequest`

Maps the ServerRemoveTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminRemoveTagOperationRequest

Extends: `RemoveTagOperationRequest`

Maps the AdminRemoveTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetAmountOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.SetAmountRequestData>`

Maps the SetAmount operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetAmountOperationRequest

Extends: `SetAmountOperationRequest`

Maps the ServerSetAmount operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetAmountOperationRequest

Extends: `SetAmountOperationRequest`

Maps the AdminSetAmount operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetAvatarOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.SetAvatarRequestData>`

Maps the SetAvatar operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetAvatarOperationRequest

Extends: `SetAvatarOperationRequest`

Maps the ServerSetAvatar operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetAvatarOperationRequest

Extends: `SetAvatarOperationRequest`

Maps the AdminSetAvatar operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetCustomDataOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.SetCustomDataRequestData>`

Maps the SetCustomData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetCustomDataOperationRequest

Extends: `SetCustomDataOperationRequest`

Maps the ServerSetCustomData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetCustomDataOperationRequest

Extends: `SetCustomDataOperationRequest`

Maps the AdminSetCustomData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetDisplayNameOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.SetDisplayNameRequestData>`

Maps the SetDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetDisplayNameOperationRequest

Extends: `SetDisplayNameOperationRequest`

Maps the ServerSetDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetDisplayNameOperationRequest

Extends: `SetDisplayNameOperationRequest`

Maps the AdminSetDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetItemDataOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.SetItemDataRequestData>`

Maps the SetItemData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetItemDataOperationRequest

Extends: `SetItemDataOperationRequest`

Maps the ServerSetItemData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetItemDataOperationRequest

Extends: `SetItemDataOperationRequest`

Maps the AdminSetItemData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ChangeItemStatisticsOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.ChangeItemStatisticsRequestData>`

Maps the ChangeItemStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerChangeItemStatisticsOperationRequest

Extends: `ChangeItemStatisticsOperationRequest`

Maps the ServerChangeItemStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminChangeItemStatisticsOperationRequest

Extends: `ChangeItemStatisticsOperationRequest`

Maps the AdminChangeItemStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetOwnerOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.SetOwnerRequestData>`

Maps the SetOwner operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetOwnerOperationRequest

Extends: `SetOwnerOperationRequest`

Maps the ServerSetOwner operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetOwnerOperationRequest

Extends: `SetOwnerOperationRequest`

Maps the AdminSetOwner operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetRemoveStatusOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.SetRemoveStatusRequestData>`

Maps the SetRemoveStatus operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetRemoveStatusOperationRequest

Extends: `SetRemoveStatusOperationRequest`

Maps the ServerSetRemoveStatus operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetRemoveStatusOperationRequest

Extends: `SetRemoveStatusOperationRequest`

Maps the AdminSetRemoveStatus operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetTagOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.SetTagRequestData>`

Maps the SetTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetTagOperationRequest

Extends: `SetTagOperationRequest`

Maps the ServerSetTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetTagOperationRequest

Extends: `SetTagOperationRequest`

Maps the AdminSetTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetCreateLeaderboardOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetCreateLeaderboardRequestData>`

Maps the GetCreateLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetCreateLeaderboardOperationRequest

Extends: `GetCreateLeaderboardOperationRequest`

Maps the ServerGetCreateLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetCreateLeaderboardOperationRequest

Extends: `GetCreateLeaderboardOperationRequest`

Maps the AdminGetCreateLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLogOperationRequest

Extends: `CustomOperationRequestAbstract<InventoryModels.GetStatisticsLogRequestData>`

Maps the GetStatisticsLog operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetStatisticsLogOperationRequest

Extends: `GetStatisticsLogOperationRequest`

Maps the ServerGetStatisticsLog operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetStatisticsLogOperationRequest

Extends: `GetStatisticsLogOperationRequest`

Maps the AdminGetStatisticsLog operation to a typed request wrapper.

_Không có field public (payload rỗng)._

## Namespace `InventoryResponseModels`

### AddSegmentOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.EmptyResponseData>`

Maps the AddSegment operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetAmountOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the GetAmount operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetAvatarOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the GetAvatar operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCatalogIdOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the GetCatalogId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetClassIdOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the GetClassId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCustomDataOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the GetCustomData operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetDisplayNameOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the GetDisplayName operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetItemDataOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the GetItemData operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetItemInformationOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the GetItemInformation operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetItemStatisticsOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the GetItemStatistics operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetItemsWithDisplayNameOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoriesWithItemIdResponseData>`

Maps the GetItemsWithDisplayName operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetItemsWithSegmentOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoriesWithItemIdResponseData>`

Maps the GetItemsWithSegment operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetItemsWithTagOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoriesWithItemIdResponseData>`

Maps the GetItemsWithTag operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetItemTypeOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the GetItemType operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetOwnerOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the GetOwner operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetRemoveStatusOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the GetRemoveStatus operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetSegmentOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the GetSegment operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLeaderboardAroundItemOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.GetStatisticsLeaderboardResponseData>`

Maps the GetStatisticsLeaderboardAroundItem operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLeaderboardOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.GetStatisticsLeaderboardResponseData>`

Maps the GetStatisticsLeaderboard operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetTagOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the GetTag operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetTsCreateOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the GetTsCreate operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RemoveSegmentOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.EmptyResponseData>`

Maps the RemoveSegment operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RemoveTagOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.EmptyResponseData>`

Maps the RemoveTag operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetAmountOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the SetAmount operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetAvatarOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.EmptyResponseData>`

Maps the SetAvatar operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetCustomDataOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the SetCustomData operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetDisplayNameOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.EmptyResponseData>`

Maps the SetDisplayName operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetItemDataOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the SetItemData operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### ChangeItemStatisticsOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.InventoryResponseData>`

Maps the ChangeItemStatistics operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetOwnerOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.EmptyResponseData>`

Maps the SetOwner operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetRemoveStatusOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.EmptyResponseData>`

Maps the SetRemoveStatus operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetTagOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.EmptyResponseData>`

Maps the SetTag operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCreateLeaderboardOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.GetCreateLeaderboardResponseData>`

Maps the GetCreateLeaderboard operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLogOperationResponse

Extends: `CustomOperationResponseAbstract<InventoryModels.GetStatisticsLogResponseData>`

Maps the GetStatisticsLog operation to a typed response wrapper.

_Không có field public (payload rỗng)._
