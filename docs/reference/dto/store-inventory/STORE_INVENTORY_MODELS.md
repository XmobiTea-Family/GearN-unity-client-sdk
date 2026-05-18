### AvatarParam

Defines the reusable parameter block AvatarParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `type` | `int` | yes | App-defined avatar type integer; not mapped to a built-in GearN enum. |
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
| `facebookStoreId` | `string?` | no | Product ID in the Facebook store. — _minLength=1, maxLength=128_ |
| `googlePlayStoreId` | `string?` | no | Product ID in the Google Play store (SKU). — _minLength=1, maxLength=128_ |
| `appleAppStoreId` | `string?` | no | Product ID in the Apple App Store. — _minLength=1, maxLength=128_ |
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

_Không khai báo field mới; kế thừa toàn bộ field từ `BuyStoreItemRequestData`._

Reference links:

- [StoreInventoryModels.BuyStoreItemRequestData:127-138](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#buystoreitemrequestdata)

### AdminBuyStoreItemRequestData

Extends: `ServerBuyStoreItemRequestData`

Defines the request payload for AdminBuyStoreItem.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerBuyStoreItemRequestData`._

Reference links:

- [StoreInventoryModels.ServerBuyStoreItemRequestData:127-150](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#serverbuystoreitemrequestdata)

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

_Không khai báo field mới; kế thừa toàn bộ field từ `PresentStoreItemRequestData`._

Reference links:

- [StoreInventoryModels.PresentStoreItemRequestData:163-174](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#presentstoreitemrequestdata)

### AdminPresentStoreItemRequestData

Extends: `ServerPresentStoreItemRequestData`

Defines the request payload for AdminPresentStoreItem.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerPresentStoreItemRequestData`._

Reference links:

- [StoreInventoryModels.ServerPresentStoreItemRequestData:163-186](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#serverpresentstoreitemrequestdata)

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

_Không khai báo field mới; kế thừa toàn bộ field từ `GetStoreLogRequestData`._

Reference links:

- [StoreInventoryModels.GetStoreLogRequestData:199-211](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#getstorelogrequestdata)

### AdminGetStoreLogRequestData

Extends: `ServerGetStoreLogRequestData`

Defines the request payload for AdminGetStoreLog.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStoreLogRequestData`._

Reference links:

- [StoreInventoryModels.ServerGetStoreLogRequestData:199-223](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#servergetstorelogrequestdata)

### GetStoreUsedRequestData

Defines the request payload for GetStoreUsed.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeId` | `string` | yes | _minLength=10, maxLength=32_ |

### ServerGetStoreUsedRequestData

Extends: `GetStoreUsedRequestData`

Defines the request payload for ServerGetStoreUsed.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetStoreUsedRequestData`._

Reference links:

- [StoreInventoryModels.GetStoreUsedRequestData:236-244](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#getstoreusedrequestdata)

### AdminGetStoreUsedRequestData

Extends: `ServerGetStoreUsedRequestData`

Defines the request payload for AdminGetStoreUsed.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStoreUsedRequestData`._

Reference links:

- [StoreInventoryModels.ServerGetStoreUsedRequestData:236-256](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#servergetstoreusedrequestdata)

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

_Không khai báo field mới; kế thừa toàn bộ field từ `RemoveStoreUsedRequestData`._

Reference links:

- [StoreInventoryModels.RemoveStoreUsedRequestData:269-278](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#removestoreusedrequestdata)

### AdminRemoveStoreUsedRequestData

Extends: `ServerRemoveStoreUsedRequestData`

Defines the request payload for AdminRemoveStoreUsed.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemoveStoreUsedRequestData`._

Reference links:

- [StoreInventoryModels.ServerRemoveStoreUsedRequestData:269-290](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#serverremovestoreusedrequestdata)

### GetStoreItemInformationRequestData

Defines the request payload for GetStoreItemInformation.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeId` | `string` | yes | _minLength=10, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional store item fields are included in the response. |

Reference links:

- [StoreInventoryModels.InfoRequestParam:33-51](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#inforequestparam)

### ServerGetStoreItemInformationRequestData

Extends: `GetStoreItemInformationRequestData`

Defines the request payload for ServerGetStoreItemInformation.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetStoreItemInformationRequestData`._

Reference links:

- [StoreInventoryModels.GetStoreItemInformationRequestData:303-316](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#getstoreiteminformationrequestdata)

### AdminGetStoreItemInformationRequestData

Extends: `ServerGetStoreItemInformationRequestData`

Defines the request payload for AdminGetStoreItemInformation.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStoreItemInformationRequestData`._

Reference links:

- [StoreInventoryModels.ServerGetStoreItemInformationRequestData:303-328](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#servergetstoreiteminformationrequestdata)

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

Reference links:

- [StoreInventoryModels.InfoRequestParam:33-51](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#inforequestparam)

### ServerGetStoreItemsWithTagRequestData

Extends: `GetStoreItemsWithTagRequestData`

Defines the request payload for ServerGetStoreItemsWithTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetStoreItemsWithTagRequestData`._

Reference links:

- [StoreInventoryModels.GetStoreItemsWithTagRequestData:341-357](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#getstoreitemswithtagrequestdata)

### AdminGetStoreItemsWithTagRequestData

Extends: `ServerGetStoreItemsWithTagRequestData`

Defines the request payload for AdminGetStoreItemsWithTag.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetStoreItemsWithTagRequestData`._

Reference links:

- [StoreInventoryModels.ServerGetStoreItemsWithTagRequestData:341-369](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#servergetstoreitemswithtagrequestdata)

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

_Không khai báo field mới; kế thừa toàn bộ field từ `CreateStoreItemRequestData`._

Reference links:

- [StoreInventoryModels.CreateStoreItemRequestData:382-391](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#createstoreitemrequestdata)

### AdminCreateStoreItemRequestData

Extends: `ServerCreateStoreItemRequestData`

Defines the request payload for AdminCreateStoreItem.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerCreateStoreItemRequestData`._

Reference links:

- [StoreInventoryModels.ServerCreateStoreItemRequestData:382-403](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#servercreatestoreitemrequestdata)

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

_Không khai báo field mới; kế thừa toàn bộ field từ `SetRemoveStatusRequestData`._

Reference links:

- [StoreInventoryModels.SetRemoveStatusRequestData:416-425](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#setremovestatusrequestdata)

### AdminSetRemoveStatusRequestData

Extends: `ServerSetRemoveStatusRequestData`

Defines the request payload for AdminSetRemoveStatus.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetRemoveStatusRequestData`._

Reference links:

- [StoreInventoryModels.ServerSetRemoveStatusRequestData:416-437](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#serversetremovestatusrequestdata)

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

Reference links:

- [StoreInventoryModels.StoreDataParam:52-61](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#storedataparam)
- [StoreInventoryModels.StoreItemParam:62-72](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#storeitemparam)
- [StoreInventoryModels.CurrencyParam:11-20](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#currencyparam)
- [StoreInventoryModels.InAppPurchaseParam:21-32](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#inapppurchaseparam)
- [StoreInventoryModels.AvatarParam:1-10](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#avatarparam)
- [StoreInventoryModels.TagParam:73-82](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#tagparam)

### ServerSetStoreItemInformationRequestData

Extends: `SetStoreItemInformationRequestData`

Defines the request payload for ServerSetStoreItemInformation.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetStoreItemInformationRequestData`._

Reference links:

- [StoreInventoryModels.SetStoreItemInformationRequestData:450-476](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#setstoreiteminformationrequestdata)

### AdminSetStoreItemInformationRequestData

Extends: `ServerSetStoreItemInformationRequestData`

Defines the request payload for AdminSetStoreItemInformation.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetStoreItemInformationRequestData`._

Reference links:

- [StoreInventoryModels.ServerSetStoreItemInformationRequestData:450-488](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#serversetstoreiteminformationrequestdata)

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

_Không khai báo field mới; kế thừa toàn bộ field từ `ValidateAppleAppStoreReceiptRequestData`._

Reference links:

- [StoreInventoryModels.ValidateAppleAppStoreReceiptRequestData:501-512](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#validateappleappstorereceiptrequestdata)

### AdminValidateAppleAppStoreReceiptRequestData

Extends: `ServerValidateAppleAppStoreReceiptRequestData`

Defines the request payload for AdminValidateAppleAppStoreReceipt.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerValidateAppleAppStoreReceiptRequestData`._

Reference links:

- [StoreInventoryModels.ServerValidateAppleAppStoreReceiptRequestData:501-524](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#servervalidateappleappstorereceiptrequestdata)

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

_Không khai báo field mới; kế thừa toàn bộ field từ `ValidateFacebookStoreReceiptRequestData`._

Reference links:

- [StoreInventoryModels.ValidateFacebookStoreReceiptRequestData:537-548](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#validatefacebookstorereceiptrequestdata)

### AdminValidateFacebookStoreReceiptRequestData

Extends: `ServerValidateFacebookStoreReceiptRequestData`

Defines the request payload for AdminValidateFacebookStoreReceipt.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerValidateFacebookStoreReceiptRequestData`._

Reference links:

- [StoreInventoryModels.ServerValidateFacebookStoreReceiptRequestData:537-560](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#servervalidatefacebookstorereceiptrequestdata)

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

_Không khai báo field mới; kế thừa toàn bộ field từ `ValidateGooglePlayStoreReceiptRequestData`._

Reference links:

- [StoreInventoryModels.ValidateGooglePlayStoreReceiptRequestData:573-584](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#validategoogleplaystorereceiptrequestdata)

### AdminValidateGooglePlayStoreReceiptRequestData

Extends: `ServerValidateGooglePlayStoreReceiptRequestData`

Defines the request payload for AdminValidateGooglePlayStoreReceipt.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerValidateGooglePlayStoreReceiptRequestData`._

Reference links:

- [StoreInventoryModels.ServerValidateGooglePlayStoreReceiptRequestData:573-596](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#servervalidategoogleplaystorereceiptrequestdata)

### GetCreateLeaderboardRequestData

Defines the request payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional store item fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Reference links:

- [StoreInventoryModels.InfoRequestParam:33-51](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#inforequestparam)

### ServerGetCreateLeaderboardRequestData

Extends: `GetCreateLeaderboardRequestData`

Defines the request payload for ServerGetCreateLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetCreateLeaderboardRequestData`._

Reference links:

- [StoreInventoryModels.GetCreateLeaderboardRequestData:609-624](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#getcreateleaderboardrequestdata)

### AdminGetCreateLeaderboardRequestData

Extends: `ServerGetCreateLeaderboardRequestData`

Defines the request payload for AdminGetCreateLeaderboard.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetCreateLeaderboardRequestData`._

Reference links:

- [StoreInventoryModels.ServerGetCreateLeaderboardRequestData:609-636](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#servergetcreateleaderboardrequestdata)

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

Reference links:

- [StoreInventoryModels.StoreInventoryItem:116-126](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#storeinventoryitem)
- [StoreInventoryModels.PriceCurrencyItem:95-104](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#pricecurrencyitem)
- [StoreInventoryModels.InAppPurchaseItem:83-94](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#inapppurchaseitem)
- [Generic.RemoveStatusItem:81-90](/docs/reference/dto/generic/GENERIC_MODELS.md#removestatusitem)
- [Generic.AvatarItem:1-10](/docs/reference/dto/generic/GENERIC_MODELS.md#avataritem)
- [Generic.TagItem:11-20](/docs/reference/dto/generic/GENERIC_MODELS.md#tagitem)
- [Generic.DataItem:31-40](/docs/reference/dto/generic/GENERIC_MODELS.md#dataitem)
- [StoreInventoryModels.InfoRequestParam:33-51](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#inforequestparam)

### StoreInventoryResponseData

Base store-inventory response envelope.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoResponseParameters` | `InfoResponseParameters` | yes | Optional field bag controlled by the corresponding `InfoRequestParam`. |

Reference links:

- [StoreInventoryModels.InfoResponseParameters:649-678](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#inforesponseparameters)
- [StoreInventoryModels.InfoRequestParam:33-51](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#inforequestparam)

### StoreInventoryWithStoreIdResponseData

Extends: `StoreInventoryResponseData`

Defines the response payload for StoreInventoryWithStoreId.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `StoreInventoryResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeId` | `string` | yes | Store item identifier. |

Reference links:

- [StoreInventoryModels.StoreInventoryResponseData:679-692](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#storeinventoryresponsedata)

### StoreInventoryLeaderboardResponseData

Extends: `StoreInventoryWithStoreIdResponseData`

Defines the response payload for StoreInventoryLeaderboard.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `StoreInventoryWithStoreIdResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `position` | `int` | yes | Zero-based leaderboard rank position of this store item. |

Reference links:

- [StoreInventoryModels.StoreInventoryWithStoreIdResponseData:679-709](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#storeinventorywithstoreidresponsedata)

### StoreInventoriesWithStoreIdResponseData

Defines the response payload for StoreInventoriesWithStoreId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<StoreInventoryWithStoreIdResponseData>` | yes | _elementCls=StoreInventoryWithStoreIdResponseData_ |

Reference links:

- [StoreInventoryModels.StoreInventoryWithStoreIdResponseData:679-709](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#storeinventorywithstoreidresponsedata)

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

Reference links:

- [StoreInventoryModels.PriceCurrencyItem:95-104](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#pricecurrencyitem)
- [StoreInventoryModels.OwnerStoreInventoryItem:105-115](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#ownerstoreinventoryitem)

### BuyStoreInventoryResponseData

Describes the result of a store purchase workflow.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeItems` | `List<StoreInventoryItem>?` | no | _elementCls=StoreInventoryItem_ |
| `storeCurrencies` | `List<PriceCurrencyItem>?` | no | _elementCls=PriceCurrencyItem_ |
| `priceCurrencies` | `List<PriceCurrencyItem>?` | no | _elementCls=PriceCurrencyItem_ |
| `infoResponseParameters` | `OwnerInfoResponseParameters?` | no | Post-purchase owner snapshot; present when currencies or inventories changed. |

Reference links:

- [StoreInventoryModels.StoreInventoryItem:116-126](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#storeinventoryitem)
- [StoreInventoryModels.PriceCurrencyItem:95-104](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#pricecurrencyitem)
- [StoreInventoryModels.OwnerInfoResponseParameters:749-763](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#ownerinforesponseparameters)

### PresentStoreInventoryResponseData

Describes the result of a store present workflow.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `storeItems` | `List<StoreInventoryItem>?` | no | Inventory items granted by the present operation. — _elementCls=StoreInventoryItem_ |
| `storeCurrencies` | `List<PriceCurrencyItem>?` | no | In-game currencies granted by the present operation. — _elementCls=PriceCurrencyItem_ |
| `priceCurrencies` | `List<PriceCurrencyItem>?` | no | In-game currencies deducted as payment; typically empty for a present (no payment required). — _elementCls=PriceCurrencyItem_ |
| `infoResponseParameters` | `OwnerInfoResponseParameters?` | no | Post-present owner snapshot; present when currencies or inventories changed. |

Reference links:

- [StoreInventoryModels.StoreInventoryItem:116-126](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#storeinventoryitem)
- [StoreInventoryModels.PriceCurrencyItem:95-104](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#pricecurrencyitem)
- [StoreInventoryModels.OwnerInfoResponseParameters:749-763](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#ownerinforesponseparameters)

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

Reference links:

- [StoreInventoryModels.CurrencyResponseData:800-809](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#currencyresponsedata)
- [StoreInventoryModels.StoreItemResponseData:810-820](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#storeitemresponsedata)

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

Reference links:

- [StoreInventoryModels.StoreInventoryLeaderboardResponseData:679-726](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#storeinventoryleaderboardresponsedata)

### GetStoreLogResponseData

Returns one page of store logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<StoreLogResponseData>` | yes | _elementCls=StoreLogResponseData_ |
| `token` | `string?` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

Reference links:

- [StoreInventoryModels.StoreLogResponseData:821-847](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#storelogresponsedata)

### GetStoreUsedResponseData

Defines the response payload for GetStoreUsed.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<StoreUsedResponseData>` | yes | _elementCls=StoreUsedResponseData_ |

Reference links:

- [StoreInventoryModels.StoreUsedResponseData:848-858](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#storeusedresponsedata)

### EmptyResponseData

Defines an intentionally empty response payload.

_Không có field public (payload rỗng)._
