# DTO Reference: StoreInventory

Store catalog, buy/present, receipt validation, store log.

Related API reference: [API_STORE_INVENTORY.md](/docs/reference/API_STORE_INVENTORY.md).

Mỗi section bên dưới là 1 class DTO trong namespace `<Models>`. Field table cho biết: tên field, kiểu C# tương ứng, có `required` hay không (suy từ metadata `DataMember` / nullable / optional), doc comment, và ràng buộc length/range/default nếu có.

> **Cách dùng**: khi gọi `*Async()`, bạn truyền instance DTO (`new StoreInventoryModels.<Method>RequestData()`) với các field required (+ optional nếu cần). Response class expose `responseData` là instance của class `*ResponseData` tương ứng. Không dùng object literal cast — xem [RULES § 8.1](/docs/RULES.md#81-build-request-dto-trong-code-copy-paste).

> **Naming pattern**: Mỗi method có 3 variant DTO — `XxxRequestData` (client), `ServerXxxRequestData` (server), `AdminXxxRequestData` (admin). Variant `Server`/`Admin` thường thêm field bắt buộc như `userId`. Khi tìm DTO cho một route cụ thể, nhảy thẳng tới section `[Server|Admin]XxxRequestData` tương ứng — không cần đọc cả 3.

> Nếu cần sử dụng `GNArray` hoặc `GNHashtable` đọc [GNDATA.md](/docs/reference/GNDATA.md)

## Danh sách

- **StoreInventoryModels** (from `Runtime/Entity/Models/StoreInventoryModels.cs`)
    - [AvatarParam](#avatarparam)
    - [CurrencyParam](#currencyparam)
    - [InAppPurchaseParam](#inapppurchaseparam)
    - [InfoRequestParam](#inforequestparam)
    - [StoreDataParam](#storedataparam)
    - [StoreItemParam](#storeitemparam)
    - [TagParam](#tagparam)
    - [InAppPurchaseItem](#inapppurchaseitem)
    - [PriceCurrencyItem](#pricecurrencyitem)
    - [OwnerStoreInventoryItem](#ownerstoreinventoryitem)
    - [StoreInventoryItem](#storeinventoryitem)
    - [BuyStoreItemRequestData](#buystoreitemrequestdata)
    - [ServerBuyStoreItemRequestData](#serverbuystoreitemrequestdata)
    - [AdminBuyStoreItemRequestData](#adminbuystoreitemrequestdata)
    - [PresentStoreItemRequestData](#presentstoreitemrequestdata)
    - [ServerPresentStoreItemRequestData](#serverpresentstoreitemrequestdata)
    - [AdminPresentStoreItemRequestData](#adminpresentstoreitemrequestdata)
    - [GetStoreLogRequestData](#getstorelogrequestdata)
    - [ServerGetStoreLogRequestData](#servergetstorelogrequestdata)
    - [AdminGetStoreLogRequestData](#admingetstorelogrequestdata)
    - [GetStoreUsedRequestData](#getstoreusedrequestdata)
    - [ServerGetStoreUsedRequestData](#servergetstoreusedrequestdata)
    - [AdminGetStoreUsedRequestData](#admingetstoreusedrequestdata)
    - [RemoveStoreUsedRequestData](#removestoreusedrequestdata)
    - [ServerRemoveStoreUsedRequestData](#serverremovestoreusedrequestdata)
    - [AdminRemoveStoreUsedRequestData](#adminremovestoreusedrequestdata)
    - [GetStoreItemInformationRequestData](#getstoreiteminformationrequestdata)
    - [ServerGetStoreItemInformationRequestData](#servergetstoreiteminformationrequestdata)
    - [AdminGetStoreItemInformationRequestData](#admingetstoreiteminformationrequestdata)
    - [GetStoreItemsWithTagRequestData](#getstoreitemswithtagrequestdata)
    - [ServerGetStoreItemsWithTagRequestData](#servergetstoreitemswithtagrequestdata)
    - [AdminGetStoreItemsWithTagRequestData](#admingetstoreitemswithtagrequestdata)
    - [CreateStoreItemRequestData](#createstoreitemrequestdata)
    - [ServerCreateStoreItemRequestData](#servercreatestoreitemrequestdata)
    - [AdminCreateStoreItemRequestData](#admincreatestoreitemrequestdata)
    - [SetRemoveStatusRequestData](#setremovestatusrequestdata)
    - [ServerSetRemoveStatusRequestData](#serversetremovestatusrequestdata)
    - [AdminSetRemoveStatusRequestData](#adminsetremovestatusrequestdata)
    - [SetStoreItemInformationRequestData](#setstoreiteminformationrequestdata)
    - [ServerSetStoreItemInformationRequestData](#serversetstoreiteminformationrequestdata)
    - [AdminSetStoreItemInformationRequestData](#adminsetstoreiteminformationrequestdata)
    - [ValidateAppleAppStoreReceiptRequestData](#validateappleappstorereceiptrequestdata)
    - [ServerValidateAppleAppStoreReceiptRequestData](#servervalidateappleappstorereceiptrequestdata)
    - [AdminValidateAppleAppStoreReceiptRequestData](#adminvalidateappleappstorereceiptrequestdata)
    - [ValidateFacebookStoreReceiptRequestData](#validatefacebookstorereceiptrequestdata)
    - [ServerValidateFacebookStoreReceiptRequestData](#servervalidatefacebookstorereceiptrequestdata)
    - [AdminValidateFacebookStoreReceiptRequestData](#adminvalidatefacebookstorereceiptrequestdata)
    - [ValidateGooglePlayStoreReceiptRequestData](#validategoogleplaystorereceiptrequestdata)
    - [ServerValidateGooglePlayStoreReceiptRequestData](#servervalidategoogleplaystorereceiptrequestdata)
    - [AdminValidateGooglePlayStoreReceiptRequestData](#adminvalidategoogleplaystorereceiptrequestdata)
    - [GetCreateLeaderboardRequestData](#getcreateleaderboardrequestdata)
    - [ServerGetCreateLeaderboardRequestData](#servergetcreateleaderboardrequestdata)
    - [AdminGetCreateLeaderboardRequestData](#admingetcreateleaderboardrequestdata)
    - [InfoResponseParameters](#inforesponseparameters)
    - [StoreInventoryResponseData](#storeinventoryresponsedata)
    - [StoreInventoryWithStoreIdResponseData](#storeinventorywithstoreidresponsedata)
    - [StoreInventoryLeaderboardResponseData](#storeinventoryleaderboardresponsedata)
    - [StoreInventoriesWithStoreIdResponseData](#storeinventorieswithstoreidresponsedata)
    - [CreateStoreItemResponseData](#createstoreitemresponsedata)
    - [OwnerInfoResponseParameters](#ownerinforesponseparameters)
    - [BuyStoreInventoryResponseData](#buystoreinventoryresponsedata)
    - [PresentStoreInventoryResponseData](#presentstoreinventoryresponsedata)
    - [CurrencyResponseData](#currencyresponsedata)
    - [StoreItemResponseData](#storeitemresponsedata)
    - [StoreLogResponseData](#storelogresponsedata)
    - [StoreUsedResponseData](#storeusedresponsedata)
    - [GetCreateLeaderboardResponseData](#getcreateleaderboardresponsedata)
    - [GetStoreLogResponseData](#getstorelogresponsedata)
    - [GetStoreUsedResponseData](#getstoreusedresponsedata)
    - [EmptyResponseData](#emptyresponsedata)
- **StoreInventoryRequestModels** (from `Runtime/Entity/Models/StoreInventoryRequestModels.cs`)
    - [BuyStoreItemOperationRequest](#buystoreitemoperationrequest)
    - [ServerBuyStoreItemOperationRequest](#serverbuystoreitemoperationrequest)
    - [AdminBuyStoreItemOperationRequest](#adminbuystoreitemoperationrequest)
    - [GetStoreItemInformationOperationRequest](#getstoreiteminformationoperationrequest)
    - [ServerGetStoreItemInformationOperationRequest](#servergetstoreiteminformationoperationrequest)
    - [AdminGetStoreItemInformationOperationRequest](#admingetstoreiteminformationoperationrequest)
    - [GetStoreItemsWithTagOperationRequest](#getstoreitemswithtagoperationrequest)
    - [ServerGetStoreItemsWithTagOperationRequest](#servergetstoreitemswithtagoperationrequest)
    - [AdminGetStoreItemsWithTagOperationRequest](#admingetstoreitemswithtagoperationrequest)
    - [CreateStoreItemOperationRequest](#createstoreitemoperationrequest)
    - [ServerCreateStoreItemOperationRequest](#servercreatestoreitemoperationrequest)
    - [AdminCreateStoreItemOperationRequest](#admincreatestoreitemoperationrequest)
    - [SetRemoveStatusOperationRequest](#setremovestatusoperationrequest)
    - [ServerSetRemoveStatusOperationRequest](#serversetremovestatusoperationrequest)
    - [AdminSetRemoveStatusOperationRequest](#adminsetremovestatusoperationrequest)
    - [SetStoreItemInformationOperationRequest](#setstoreiteminformationoperationrequest)
    - [ServerSetStoreItemInformationOperationRequest](#serversetstoreiteminformationoperationrequest)
    - [AdminSetStoreItemInformationOperationRequest](#adminsetstoreiteminformationoperationrequest)
    - [ValidateAppleAppStoreReceiptOperationRequest](#validateappleappstorereceiptoperationrequest)
    - [ServerValidateAppleAppStoreReceiptOperationRequest](#servervalidateappleappstorereceiptoperationrequest)
    - [AdminValidateAppleAppStoreReceiptOperationRequest](#adminvalidateappleappstorereceiptoperationrequest)
    - [ValidateFacebookStoreReceiptOperationRequest](#validatefacebookstorereceiptoperationrequest)
    - [ServerValidateFacebookStoreReceiptOperationRequest](#servervalidatefacebookstorereceiptoperationrequest)
    - [AdminValidateFacebookStoreReceiptOperationRequest](#adminvalidatefacebookstorereceiptoperationrequest)
    - [ValidateGooglePlayStoreReceiptOperationRequest](#validategoogleplaystorereceiptoperationrequest)
    - [ServerValidateGooglePlayStoreReceiptOperationRequest](#servervalidategoogleplaystorereceiptoperationrequest)
    - [AdminValidateGooglePlayStoreReceiptOperationRequest](#adminvalidategoogleplaystorereceiptoperationrequest)
    - [GetCreateLeaderboardOperationRequest](#getcreateleaderboardoperationrequest)
    - [ServerGetCreateLeaderboardOperationRequest](#servergetcreateleaderboardoperationrequest)
    - [AdminGetCreateLeaderboardOperationRequest](#admingetcreateleaderboardoperationrequest)
    - [PresentStoreItemOperationRequest](#presentstoreitemoperationrequest)
    - [ServerPresentStoreItemOperationRequest](#serverpresentstoreitemoperationrequest)
    - [AdminPresentStoreItemOperationRequest](#adminpresentstoreitemoperationrequest)
    - [GetStoreLogOperationRequest](#getstorelogoperationrequest)
    - [ServerGetStoreLogOperationRequest](#servergetstorelogoperationrequest)
    - [AdminGetStoreLogOperationRequest](#admingetstorelogoperationrequest)
    - [GetStoreUsedOperationRequest](#getstoreusedoperationrequest)
    - [ServerGetStoreUsedOperationRequest](#servergetstoreusedoperationrequest)
    - [AdminGetStoreUsedOperationRequest](#admingetstoreusedoperationrequest)
    - [RemoveStoreUsedOperationRequest](#removestoreusedoperationrequest)
    - [ServerRemoveStoreUsedOperationRequest](#serverremovestoreusedoperationrequest)
    - [AdminRemoveStoreUsedOperationRequest](#adminremovestoreusedoperationrequest)
- **StoreInventoryResponseModels** (from `Runtime/Entity/Models/StoreInventoryResponseModels.cs`)
    - [BuyStoreItemOperationResponse](#buystoreitemoperationresponse)
    - [GetStoreItemInformationOperationResponse](#getstoreiteminformationoperationresponse)
    - [GetStoreItemsWithTagOperationResponse](#getstoreitemswithtagoperationresponse)
    - [CreateStoreItemOperationResponse](#createstoreitemoperationresponse)
    - [SetRemoveStatusOperationResponse](#setremovestatusoperationresponse)
    - [SetStoreItemInformationOperationResponse](#setstoreiteminformationoperationresponse)
    - [ValidateAppleAppStoreReceiptOperationResponse](#validateappleappstorereceiptoperationresponse)
    - [ValidateFacebookStoreReceiptOperationResponse](#validatefacebookstorereceiptoperationresponse)
    - [ValidateGooglePlayStoreReceiptOperationResponse](#validategoogleplaystorereceiptoperationresponse)
    - [GetCreateLeaderboardOperationResponse](#getcreateleaderboardoperationresponse)
    - [GetStoreLogOperationResponse](#getstorelogoperationresponse)
    - [PresentStoreItemOperationResponse](#presentstoreitemoperationresponse)
    - [GetStoreUsedOperationResponse](#getstoreusedoperationresponse)
    - [RemoveStoreUsedOperationResponse](#removestoreusedoperationresponse)

---

## Namespace `StoreInventoryModels`

### AvatarParam

Defines the reusable parameter block AvatarParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `type` | `int` | yes | Avatar type identifier. User custom this type enum. |
| `value` | `string` | yes | Avatar value such as a URL, file ID, or provider-specific string. — _minLength=1, maxLength=128_ |

### CurrencyParam

Defines the reusable parameter block CurrencyParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `double` | yes | Currency price value for this key. |

### InAppPurchaseParam

Defines the reusable parameter block InAppPurchaseParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `facebookStoreId` | `string?` | yes | Product ID in the Facebook store. — _minLength=1, maxLength=128_ |
| `googlePlayStoreId` | `string?` | yes | Product ID in the Google Play store (SKU). — _minLength=1, maxLength=128_ |
| `appleAppStoreId` | `string?` | yes | Product ID in the Apple App Store. — _minLength=1, maxLength=128_ |
| `analyticsPrice` | `double?` | no | Estimated real-money price used for analytics reporting. |

### InfoRequestParam

Selects which optional store fields should be returned in `infoResponseParameters`. Boolean flags default to `false`.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeItems` | `bool?` | no | _default=false_ |
| `storeItemType` | `bool?` | no | _default=false_ |
| `storeCurrencies` | `bool?` | no | _default=false_ |
| `priceCurrencies` | `bool?` | no | _default=false_ |
| `inAppPurchase` | `bool?` | no | _default=false_ |
| `removeStatus` | `bool?` | no | _default=false_ |
| `displayName` | `bool?` | no | _default=false_ |
| `avatar` | `bool?` | no | _default=false_ |
| `tsCreate` | `bool?` | no | _default=false_ |
| `tags` | `bool?` | no | _default=false_ |
| `storeDatas` | `bool?` | no | _default=false_ |

### StoreDataParam

Defines the reusable parameter block StoreDataParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `object` | yes | Arbitrary value to store for this store data key. May be a primitive, `GNHashtable`, or `GNArray`. |

### StoreItemParam

Defines the reusable parameter block StoreItemParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `catalogId` | `string` | yes | Catalog ID of the item granted on purchase. — _minLength=2, maxLength=32_ |
| `classId` | `string` | yes | Class ID of the item granted on purchase. — _minLength=2, maxLength=32_ |
| `amount` | `double` | yes | Quantity of items granted on purchase. |

### TagParam

Defines the reusable parameter block TagParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |

### InAppPurchaseItem

Represents in-app purchase product IDs and analytics price for a store item.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `facebookStoreId` | `string` | yes | Product ID in the Facebook store. |
| `appleAppStoreId` | `string` | yes | Product ID in the Apple App Store. |
| `googlePlayStoreId` | `string` | yes | Product ID in the Google Play store (SKU). |
| `analyticsPrice` | `double` | yes | Estimated real-money price used for analytics reporting. |

### PriceCurrencyItem

Represents one in-game currency price entry for a store item.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | Currency key identifying the currency used for payment. |
| `value` | `double` | yes | Currency amount charged when purchasing with this currency. |

### OwnerStoreInventoryItem

Represents one inventory item currently owned by the target entity.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | Inventory item identifier of the owned item. |
| `catalogId` | `string` | yes | Catalog ID the owned item belongs to. |
| `classId` | `string` | yes | Class ID of the owned item. |

### StoreInventoryItem

Represents one inventory item granted by a store purchase.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `catalogId` | `string` | yes | Catalog ID of the granted item. |
| `classId` | `string` | yes | Class ID of the granted item. |
| `amount` | `int` | yes | Quantity of items granted. |

### BuyStoreItemRequestData

Purchases one store item for a target owner.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeId` | `string` | yes | _minLength=10, maxLength=32_ |
| `id` | `string` | yes | Target owner identifier. — _minLength=10, maxLength=11_ |
| `type` | `int` | yes | Target owner type mapped by the public `OwnerType` enum. |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

### ServerBuyStoreItemRequestData

Extends: `BuyStoreItemRequestData`

Defines the request payload for ServerBuyStoreItem.

_Không có field public (payload rỗng)._

### AdminBuyStoreItemRequestData

Extends: `ServerBuyStoreItemRequestData`

Defines the request payload for AdminBuyStoreItem.

_Không có field public (payload rỗng)._

### PresentStoreItemRequestData

Grants one store item to a target owner without the normal purchase flow.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeId` | `string` | yes | _minLength=10, maxLength=32_ |
| `id` | `string` | yes | _minLength=10, maxLength=11_ |
| `type` | `int` | yes | Target owner type mapped by the public `OwnerType` enum. |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

### ServerPresentStoreItemRequestData

Extends: `PresentStoreItemRequestData`

Defines the request payload for ServerPresentStoreItem.

_Không có field public (payload rỗng)._

### AdminPresentStoreItemRequestData

Extends: `ServerPresentStoreItemRequestData`

Defines the request payload for AdminPresentStoreItem.

_Không có field public (payload rỗng)._

### GetStoreLogRequestData

Reads store logs using token-based pagination.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeId` | `string?` | no | _minLength=10, maxLength=32_ |
| `storeReceiveTypes` | `List<int>?` | no | Filters by store receive types mapped by the public `StoreReceiveType` enum. — _minLength=1, maxLength=10, elementCls=Number_ |
| `id` | `string?` | no | _minLength=10, maxLength=11_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `token` | `string?` | no | Continuation token returned by the previous page. — _minLength=24, maxLength=24_ |

### ServerGetStoreLogRequestData

Extends: `GetStoreLogRequestData`

Defines the request payload for ServerGetStoreLog.

_Không có field public (payload rỗng)._

### AdminGetStoreLogRequestData

Extends: `ServerGetStoreLogRequestData`

Defines the request payload for AdminGetStoreLog.

_Không có field public (payload rỗng)._

### GetStoreUsedRequestData

Defines the request payload for GetStoreUsed.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeId` | `string` | yes | _minLength=10, maxLength=32_ |

### ServerGetStoreUsedRequestData

Extends: `GetStoreUsedRequestData`

Defines the request payload for ServerGetStoreUsed.

_Không có field public (payload rỗng)._

### AdminGetStoreUsedRequestData

Extends: `ServerGetStoreUsedRequestData`

Defines the request payload for AdminGetStoreUsed.

_Không có field public (payload rỗng)._

### RemoveStoreUsedRequestData

Defines the request payload for RemoveStoreUsed.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeId` | `string` | yes | _minLength=10, maxLength=32_ |
| `ownerIds` | `List<string>?` | no | _elementCls=String_ |

### ServerRemoveStoreUsedRequestData

Extends: `RemoveStoreUsedRequestData`

Defines the request payload for ServerRemoveStoreUsed.

_Không có field public (payload rỗng)._

### AdminRemoveStoreUsedRequestData

Extends: `ServerRemoveStoreUsedRequestData`

Defines the request payload for AdminRemoveStoreUsed.

_Không có field public (payload rỗng)._

### GetStoreItemInformationRequestData

Defines the request payload for GetStoreItemInformation.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeId` | `string` | yes | _minLength=10, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional store item fields are included in the response. |

### ServerGetStoreItemInformationRequestData

Extends: `GetStoreItemInformationRequestData`

Defines the request payload for ServerGetStoreItemInformation.

_Không có field public (payload rỗng)._

### AdminGetStoreItemInformationRequestData

Extends: `ServerGetStoreItemInformationRequestData`

Defines the request payload for AdminGetStoreItemInformation.

_Không có field public (payload rỗng)._

### GetStoreItemsWithTagRequestData

Defines the request payload for GetStoreItemsWithTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional store item fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

### ServerGetStoreItemsWithTagRequestData

Extends: `GetStoreItemsWithTagRequestData`

Defines the request payload for ServerGetStoreItemsWithTag.

_Không có field public (payload rỗng)._

### AdminGetStoreItemsWithTagRequestData

Extends: `ServerGetStoreItemsWithTagRequestData`

Defines the request payload for AdminGetStoreItemsWithTag.

_Không có field public (payload rỗng)._

### CreateStoreItemRequestData

Defines the request payload for CreateStoreItem.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeId` | `string?` | no | _minLength=10, maxLength=32_ |
| `displayName` | `string?` | no | _default=""_ |

### ServerCreateStoreItemRequestData

Extends: `CreateStoreItemRequestData`

Defines the request payload for ServerCreateStoreItem.

_Không có field public (payload rỗng)._

### AdminCreateStoreItemRequestData

Extends: `ServerCreateStoreItemRequestData`

Defines the request payload for AdminCreateStoreItem.

_Không có field public (payload rỗng)._

### SetRemoveStatusRequestData

Defines the request payload for SetRemoveStatus.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeId` | `string` | yes | _minLength=10, maxLength=32_ |
| `reason` | `string?` | no | _default=""_ |

### ServerSetRemoveStatusRequestData

Extends: `SetRemoveStatusRequestData`

Defines the request payload for ServerSetRemoveStatus.

_Không có field public (payload rỗng)._

### AdminSetRemoveStatusRequestData

Extends: `ServerSetRemoveStatusRequestData`

Defines the request payload for AdminSetRemoveStatus.

_Không có field public (payload rỗng)._

### SetStoreItemInformationRequestData

Updates mutable store metadata for one store entry.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeId` | `string` | yes | _minLength=10, maxLength=32_ |
| `storeItemType` | `int?` | no | Store item type mapped by the public `StoreItemType` enum. — _min=1, max=2_ |
| `storeDatas` | `List<StoreDataParam>?` | no | _minLength=0, maxLength=32, elementCls=StoreDataParam_ |
| `storeItems` | `List<StoreItemParam>?` | no | _minLength=0, maxLength=32, elementCls=StoreItemParam_ |
| `storeCurrencies` | `List<CurrencyParam>?` | no | _minLength=0, maxLength=32, elementCls=CurrencyParam_ |
| `priceCurrencies` | `List<CurrencyParam>?` | no | _minLength=0, maxLength=32, elementCls=CurrencyParam_ |
| `inAppPurchase` | `InAppPurchaseParam?` | no | In-app purchase product IDs; provide to enable real-money purchases for this store item. |
| `displayName` | `string?` | no | Display name of the store item. |
| `avatar` | `AvatarParam?` | no | Avatar descriptor for the store item. |
| `tags` | `List<TagParam>?` | no | _minLength=0, maxLength=32, elementCls=TagParam_ |

### ServerSetStoreItemInformationRequestData

Extends: `SetStoreItemInformationRequestData`

Defines the request payload for ServerSetStoreItemInformation.

_Không có field public (payload rỗng)._

### AdminSetStoreItemInformationRequestData

Extends: `ServerSetStoreItemInformationRequestData`

Defines the request payload for AdminSetStoreItemInformation.

_Không có field public (payload rỗng)._

### ValidateAppleAppStoreReceiptRequestData

Defines the request payload for ValidateAppleAppStoreReceipt.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `receipt` | `string` | yes | Apple App Store receipt data (base64-encoded). — _minLength=10, maxLength=2048_ |
| `id` | `string` | yes | Target owner identifier who will receive the purchased items. — _minLength=10, maxLength=11_ |
| `type` | `int` | yes | Target owner type mapped by the public `OwnerType` enum. |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

### ServerValidateAppleAppStoreReceiptRequestData

Extends: `ValidateAppleAppStoreReceiptRequestData`

Defines the request payload for ServerValidateAppleAppStoreReceipt.

_Không có field public (payload rỗng)._

### AdminValidateAppleAppStoreReceiptRequestData

Extends: `ServerValidateAppleAppStoreReceiptRequestData`

Defines the request payload for AdminValidateAppleAppStoreReceipt.

_Không có field public (payload rỗng)._

### ValidateFacebookStoreReceiptRequestData

Defines the request payload for ValidateFacebookStoreReceipt.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `receipt` | `string` | yes | Facebook purchase payload/receipt data. — _minLength=10, maxLength=2048_ |
| `id` | `string` | yes | Target owner identifier who will receive the purchased items. — _minLength=10, maxLength=11_ |
| `type` | `int` | yes | Target owner type mapped by the public `OwnerType` enum. |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

### ServerValidateFacebookStoreReceiptRequestData

Extends: `ValidateFacebookStoreReceiptRequestData`

Defines the request payload for ServerValidateFacebookStoreReceipt.

_Không có field public (payload rỗng)._

### AdminValidateFacebookStoreReceiptRequestData

Extends: `ServerValidateFacebookStoreReceiptRequestData`

Defines the request payload for AdminValidateFacebookStoreReceipt.

_Không có field public (payload rỗng)._

### ValidateGooglePlayStoreReceiptRequestData

Defines the request payload for ValidateGooglePlayStoreReceipt.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `receipt` | `string` | yes | Google Play purchase token returned by the billing library. — _minLength=10, maxLength=2048_ |
| `id` | `string` | yes | Target owner identifier who will receive the purchased items. — _minLength=10, maxLength=11_ |
| `type` | `int` | yes | Target owner type mapped by the public `OwnerType` enum. |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

### ServerValidateGooglePlayStoreReceiptRequestData

Extends: `ValidateGooglePlayStoreReceiptRequestData`

Defines the request payload for ServerValidateGooglePlayStoreReceipt.

_Không có field public (payload rỗng)._

### AdminValidateGooglePlayStoreReceiptRequestData

Extends: `ServerValidateGooglePlayStoreReceiptRequestData`

Defines the request payload for AdminValidateGooglePlayStoreReceipt.

_Không có field public (payload rỗng)._

### GetCreateLeaderboardRequestData

Defines the request payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional store item fields are included in the response. |
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

### InfoResponseParameters

Contains the optional fields requested through `InfoRequestParam`.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeItems` | `List<StoreInventoryItem>?` | no | Items granted by purchasing this store entry. — _elementCls=StoreInventoryItem_ |
| `storeItemType` | `bool?` | no | Store item type mapped by the public `StoreItemType` enum; present when requested. |
| `storeCurrencies` | `List<PriceCurrencyItem>?` | no | In-game currencies granted by purchasing this store entry. — _elementCls=PriceCurrencyItem_ |
| `priceCurrencies` | `List<PriceCurrencyItem>?` | no | In-game currency prices required to purchase this store entry. — _elementCls=PriceCurrencyItem_ |
| `inAppPurchase` | `InAppPurchaseItem?` | no | In-app purchase product IDs; present when real-money purchase is configured. |
| `removeStatus` | `GenericModels.RemoveStatusItem?` | no | Soft-remove metadata; present when the store item has been marked for removal. |
| `displayName` | `string?` | no | Display name of the store item; present when requested. |
| `avatar` | `GenericModels.AvatarItem?` | no | Avatar descriptor of the store item; present when requested. |
| `tsCreate` | `long?` | no | Creation timestamp of the store item; present when requested. |
| `tags` | `List<GenericModels.TagItem>?` | no | Tag entries assigned to the store item. — _elementCls=GenericModels.TagItem_ |
| `storeDatas` | `List<GenericModels.DataItem>?` | no | Store data entries; present when `storeDatas` is enabled. — _elementCls=GenericModels.DataItem_ |

### StoreInventoryResponseData

Base store-inventory response envelope.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoResponseParameters` | `InfoResponseParameters` | yes | Optional field bag controlled by the corresponding `InfoRequestParam`. |

### StoreInventoryWithStoreIdResponseData

Extends: `StoreInventoryResponseData`

Defines the response payload for StoreInventoryWithStoreId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeId` | `string` | yes | Store item identifier. |

### StoreInventoryLeaderboardResponseData

Extends: `StoreInventoryWithStoreIdResponseData`

Defines the response payload for StoreInventoryLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `position` | `int` | yes | Zero-based leaderboard rank position of this store item. |

### StoreInventoriesWithStoreIdResponseData

Defines the response payload for StoreInventoriesWithStoreId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<StoreInventoryWithStoreIdResponseData>` | yes | _elementCls=StoreInventoryWithStoreIdResponseData_ |

### CreateStoreItemResponseData

Defines the response payload for CreateStoreItem.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeId` | `string` | yes | Backend-assigned store item identifier for the newly created store item. |

### OwnerInfoResponseParameters

Describes the affected owner snapshot returned by buy/present flows.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `currencies` | `List<PriceCurrencyItem>?` | no | _elementCls=PriceCurrencyItem_ |
| `inventories` | `List<OwnerStoreInventoryItem>?` | no | _elementCls=OwnerStoreInventoryItem_ |

### BuyStoreInventoryResponseData

Describes the result of a store purchase workflow.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeItems` | `List<StoreInventoryItem>?` | no | _elementCls=StoreInventoryItem_ |
| `storeCurrencies` | `List<PriceCurrencyItem>?` | no | _elementCls=PriceCurrencyItem_ |
| `priceCurrencies` | `List<PriceCurrencyItem>?` | no | _elementCls=PriceCurrencyItem_ |
| `infoResponseParameters` | `OwnerInfoResponseParameters?` | no | Post-purchase owner snapshot; present when currencies or inventories changed. |

### PresentStoreInventoryResponseData

Describes the result of a store present workflow.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeItems` | `List<StoreInventoryItem>?` | no | Inventory items granted by the present operation. — _elementCls=StoreInventoryItem_ |
| `storeCurrencies` | `List<PriceCurrencyItem>?` | no | In-game currencies granted by the present operation. — _elementCls=PriceCurrencyItem_ |
| `priceCurrencies` | `List<PriceCurrencyItem>?` | no | In-game currencies deducted as payment; typically empty for a present (no payment required). — _elementCls=PriceCurrencyItem_ |
| `infoResponseParameters` | `OwnerInfoResponseParameters?` | no | Post-present owner snapshot; present when currencies or inventories changed. |

### CurrencyResponseData

Defines the response payload for Currency.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | Currency key identifying the currency. |
| `value` | `double` | yes | Currency amount for this entry. |

### StoreItemResponseData

Defines the response payload for StoreItem.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `catalogId` | `string` | yes | Catalog ID of the granted inventory item. |
| `classId` | `string` | yes | Class ID of the granted inventory item. |
| `itemId` | `string` | yes | Inventory item identifier of the granted item. |

### StoreLogResponseData

Describes one store transaction log entry.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeId` | `string` | yes | Store item identifier involved in this transaction. |
| `id` | `string` | yes | Owner identifier who received the store item. |
| `type` | `int` | yes | Owner type mapped by the public `OwnerType` enum. |
| `transactionId` | `string?` | no | External payment transaction ID (e.g. Apple, Google, Facebook receipt ID); present for real-money purchases. |
| `storeReceiveType` | `int` | yes | Receive type mapped by the public `StoreReceiveType` enum. |
| `priceCurrencyStartValues` | `List<CurrencyResponseData>` | yes | Currency balances before the price was deducted. — _elementCls=CurrencyResponseData_ |
| `priceCurrencyAmountValues` | `List<CurrencyResponseData>` | yes | Currency amounts deducted as price payment. — _elementCls=CurrencyResponseData_ |
| `priceCurrencyFinalValues` | `List<CurrencyResponseData>` | yes | Currency balances after the price was deducted. — _elementCls=CurrencyResponseData_ |
| `storeCurrencyStartValues` | `List<CurrencyResponseData>` | yes | Currency balances before the store currencies were granted. — _elementCls=CurrencyResponseData_ |
| `storeCurrencyAmountValues` | `List<CurrencyResponseData>` | yes | Currency amounts granted as part of the purchase. — _elementCls=CurrencyResponseData_ |
| `storeCurrencyFinalValues` | `List<CurrencyResponseData>` | yes | Currency balances after the store currencies were granted. — _elementCls=CurrencyResponseData_ |
| `storeItemFinalValues` | `List<StoreItemResponseData>` | yes | Inventory items granted as part of the purchase. — _elementCls=StoreItemResponseData_ |
| `tsCreate` | `long` | yes | Timestamp when this transaction was recorded. |
| `log` | `string` | yes | Log message describing the transaction. |

### StoreUsedResponseData

Defines the response payload for StoreUsed.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `id` | `string` | yes | Owner identifier who received the store item. |
| `type` | `int` | yes | Owner type mapped by the public `OwnerType` enum. |
| `tsCreate` | `long` | yes | Timestamp when the store item was granted. |

### GetCreateLeaderboardResponseData

Defines the response payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<StoreInventoryLeaderboardResponseData>` | yes | _elementCls=StoreInventoryLeaderboardResponseData_ |

### GetStoreLogResponseData

Returns one page of store logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<StoreLogResponseData>` | yes | _elementCls=StoreLogResponseData_ |
| `token` | `string?` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

### GetStoreUsedResponseData

Defines the response payload for GetStoreUsed.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<StoreUsedResponseData>` | yes | _elementCls=StoreUsedResponseData_ |

### EmptyResponseData

Defines an intentionally empty response payload.

_Không có field public (payload rỗng)._

## Namespace `StoreInventoryRequestModels`

### BuyStoreItemOperationRequest

Extends: `CustomOperationRequestAbstract<StoreInventoryModels.BuyStoreItemRequestData>`

Maps the BuyStoreItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerBuyStoreItemOperationRequest

Extends: `BuyStoreItemOperationRequest`

Maps the ServerBuyStoreItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminBuyStoreItemOperationRequest

Extends: `BuyStoreItemOperationRequest`

Maps the AdminBuyStoreItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetStoreItemInformationOperationRequest

Extends: `CustomOperationRequestAbstract<StoreInventoryModels.GetStoreItemInformationRequestData>`

Maps the GetStoreItemInformation operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetStoreItemInformationOperationRequest

Extends: `GetStoreItemInformationOperationRequest`

Maps the ServerGetStoreItemInformation operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetStoreItemInformationOperationRequest

Extends: `GetStoreItemInformationOperationRequest`

Maps the AdminGetStoreItemInformation operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetStoreItemsWithTagOperationRequest

Extends: `CustomOperationRequestAbstract<StoreInventoryModels.GetStoreItemsWithTagRequestData>`

Maps the GetStoreItemsWithTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetStoreItemsWithTagOperationRequest

Extends: `GetStoreItemsWithTagOperationRequest`

Maps the ServerGetStoreItemsWithTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetStoreItemsWithTagOperationRequest

Extends: `GetStoreItemsWithTagOperationRequest`

Maps the AdminGetStoreItemsWithTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### CreateStoreItemOperationRequest

Extends: `CustomOperationRequestAbstract<StoreInventoryModels.CreateStoreItemRequestData>`

Maps the CreateStoreItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerCreateStoreItemOperationRequest

Extends: `CreateStoreItemOperationRequest`

Maps the ServerCreateStoreItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminCreateStoreItemOperationRequest

Extends: `CreateStoreItemOperationRequest`

Maps the AdminCreateStoreItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetRemoveStatusOperationRequest

Extends: `CustomOperationRequestAbstract<StoreInventoryModels.SetRemoveStatusRequestData>`

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

### SetStoreItemInformationOperationRequest

Extends: `CustomOperationRequestAbstract<StoreInventoryModels.SetStoreItemInformationRequestData>`

Maps the SetStoreItemInformation operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetStoreItemInformationOperationRequest

Extends: `SetStoreItemInformationOperationRequest`

Maps the ServerSetStoreItemInformation operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetStoreItemInformationOperationRequest

Extends: `SetStoreItemInformationOperationRequest`

Maps the AdminSetStoreItemInformation operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ValidateAppleAppStoreReceiptOperationRequest

Extends: `CustomOperationRequestAbstract<StoreInventoryModels.ValidateAppleAppStoreReceiptRequestData>`

Maps the ValidateAppleAppStoreReceipt operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerValidateAppleAppStoreReceiptOperationRequest

Extends: `ValidateAppleAppStoreReceiptOperationRequest`

Maps the ServerValidateAppleAppStoreReceipt operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminValidateAppleAppStoreReceiptOperationRequest

Extends: `ValidateAppleAppStoreReceiptOperationRequest`

Maps the AdminValidateAppleAppStoreReceipt operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ValidateFacebookStoreReceiptOperationRequest

Extends: `CustomOperationRequestAbstract<StoreInventoryModels.ValidateFacebookStoreReceiptRequestData>`

Maps the ValidateFacebookStoreReceipt operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerValidateFacebookStoreReceiptOperationRequest

Extends: `ValidateFacebookStoreReceiptOperationRequest`

Maps the ServerValidateFacebookStoreReceipt operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminValidateFacebookStoreReceiptOperationRequest

Extends: `ValidateFacebookStoreReceiptOperationRequest`

Maps the AdminValidateFacebookStoreReceipt operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ValidateGooglePlayStoreReceiptOperationRequest

Extends: `CustomOperationRequestAbstract<StoreInventoryModels.ValidateGooglePlayStoreReceiptRequestData>`

Maps the ValidateGooglePlayStoreReceipt operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerValidateGooglePlayStoreReceiptOperationRequest

Extends: `ValidateGooglePlayStoreReceiptOperationRequest`

Maps the ServerValidateGooglePlayStoreReceipt operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminValidateGooglePlayStoreReceiptOperationRequest

Extends: `ValidateGooglePlayStoreReceiptOperationRequest`

Maps the AdminValidateGooglePlayStoreReceipt operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetCreateLeaderboardOperationRequest

Extends: `CustomOperationRequestAbstract<StoreInventoryModels.GetCreateLeaderboardRequestData>`

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

### PresentStoreItemOperationRequest

Extends: `CustomOperationRequestAbstract<StoreInventoryModels.PresentStoreItemRequestData>`

Maps the PresentStoreItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerPresentStoreItemOperationRequest

Extends: `PresentStoreItemOperationRequest`

Maps the ServerPresentStoreItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminPresentStoreItemOperationRequest

Extends: `PresentStoreItemOperationRequest`

Maps the AdminPresentStoreItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetStoreLogOperationRequest

Extends: `CustomOperationRequestAbstract<StoreInventoryModels.GetStoreLogRequestData>`

Maps the GetStoreLog operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetStoreLogOperationRequest

Extends: `GetStoreLogOperationRequest`

Maps the ServerGetStoreLog operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetStoreLogOperationRequest

Extends: `GetStoreLogOperationRequest`

Maps the AdminGetStoreLog operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetStoreUsedOperationRequest

Extends: `CustomOperationRequestAbstract<StoreInventoryModels.GetStoreUsedRequestData>`

Maps the GetStoreUsed operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetStoreUsedOperationRequest

Extends: `GetStoreUsedOperationRequest`

Maps the ServerGetStoreUsed operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetStoreUsedOperationRequest

Extends: `GetStoreUsedOperationRequest`

Maps the AdminGetStoreUsed operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### RemoveStoreUsedOperationRequest

Extends: `CustomOperationRequestAbstract<StoreInventoryModels.RemoveStoreUsedRequestData>`

Maps the RemoveStoreUsed operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerRemoveStoreUsedOperationRequest

Extends: `RemoveStoreUsedOperationRequest`

Maps the ServerRemoveStoreUsed operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminRemoveStoreUsedOperationRequest

Extends: `RemoveStoreUsedOperationRequest`

Maps the AdminRemoveStoreUsed operation to a typed request wrapper.

_Không có field public (payload rỗng)._

## Namespace `StoreInventoryResponseModels`

### BuyStoreItemOperationResponse

Extends: `CustomOperationResponseAbstract<StoreInventoryModels.BuyStoreInventoryResponseData>`

Maps the BuyStoreItem operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetStoreItemInformationOperationResponse

Extends: `CustomOperationResponseAbstract<StoreInventoryModels.StoreInventoryResponseData>`

Maps the GetStoreItemInformation operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetStoreItemsWithTagOperationResponse

Extends: `CustomOperationResponseAbstract<StoreInventoryModels.StoreInventoriesWithStoreIdResponseData>`

Maps the GetStoreItemsWithTag operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### CreateStoreItemOperationResponse

Extends: `CustomOperationResponseAbstract<StoreInventoryModels.CreateStoreItemResponseData>`

Maps the CreateStoreItem operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetRemoveStatusOperationResponse

Extends: `CustomOperationResponseAbstract<StoreInventoryModels.EmptyResponseData>`

Maps the SetRemoveStatus operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetStoreItemInformationOperationResponse

Extends: `CustomOperationResponseAbstract<StoreInventoryModels.StoreInventoryResponseData>`

Maps the SetStoreItemInformation operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### ValidateAppleAppStoreReceiptOperationResponse

Extends: `CustomOperationResponseAbstract<StoreInventoryModels.BuyStoreInventoryResponseData>`

Maps the ValidateAppleAppStoreReceipt operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### ValidateFacebookStoreReceiptOperationResponse

Extends: `CustomOperationResponseAbstract<StoreInventoryModels.BuyStoreInventoryResponseData>`

Maps the ValidateFacebookStoreReceipt operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### ValidateGooglePlayStoreReceiptOperationResponse

Extends: `CustomOperationResponseAbstract<StoreInventoryModels.BuyStoreInventoryResponseData>`

Maps the ValidateGooglePlayStoreReceipt operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCreateLeaderboardOperationResponse

Extends: `CustomOperationResponseAbstract<StoreInventoryModels.GetCreateLeaderboardResponseData>`

Maps the GetCreateLeaderboard operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetStoreLogOperationResponse

Extends: `CustomOperationResponseAbstract<StoreInventoryModels.GetStoreLogResponseData>`

Maps the GetStoreLog operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### PresentStoreItemOperationResponse

Extends: `CustomOperationResponseAbstract<StoreInventoryModels.PresentStoreInventoryResponseData>`

Maps the PresentStoreItem operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetStoreUsedOperationResponse

Extends: `CustomOperationResponseAbstract<StoreInventoryModels.GetStoreUsedResponseData>`

Maps the GetStoreUsed operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RemoveStoreUsedOperationResponse

Extends: `CustomOperationResponseAbstract<StoreInventoryModels.EmptyResponseData>`

Maps the RemoveStoreUsed operation to a typed response wrapper.

_Không có field public (payload rỗng)._
