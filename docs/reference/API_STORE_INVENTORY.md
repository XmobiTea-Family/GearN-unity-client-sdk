# API Reference: StoreInventoryApi

Store catalog, buy/present, receipt validation, store log.

- Domain guide: [guides/STORE_INVENTORY.md](/docs/guides/STORE_INVENTORY.md)
- DTO shapes: [dto/STORE_INVENTORY.md](/docs/reference/dto/STORE_INVENTORY.md)
- Enums: [ENUMS.md](/docs/reference/ENUMS.md)
- Error handling: [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md)
- Permission rules: [PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md)

## Namespaces

- `GNNetwork.storeInventory` — `RequestRole.Client`
- `GNNetwork.storeInventory.server` — `RequestRole.Server`
- `GNNetwork.storeInventory.admin` — `RequestRole.Admin`

## Convention

Mỗi method dưới đây có 2 form — callback và `*Async()` Task. Ưu tiên `*Async()`.

```text
// Callback
GNNetwork.storeInventory.<method>(requestData, onResponse?, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);

// Async
var res = await GNNetwork.storeInventory.<method>Async(requestData, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);
```

Param chung:

<!-- prettier-ignore -->
| Param | Type | Optional | Notes |
| --- | --- | --- | --- |
| `requestData` | domain-specific (xem bảng dưới) | no | Payload chính |
| `onResponse` | `Action1<TResponse>` | yes | Chỉ có ở callback form |
| `overrideAuthToken` | `string` | yes | Override `authToken` cache cho request này |
| `overrideSecretKey` | `string` | yes | Override secret key mặc định của route |
| `customTags` | `GNHashtable` | yes | Tags gắn vào request, backend có thể log/route |
| `timeout` | `int` | yes | Timeout giây; default = `OperationRequest.defaultTimeOut` |

Response class expose field: `returnCode`, `errorCode`, `invalidMembers`, `debugMessage`, `responseData`. Xem [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).

## Client methods (`GNNetwork.storeInventory.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules | Permission Rules khi truyền `id` khác với những `entity` liên quan mà `gamePlayer` đang được authenticated không phải owner nếu `type` là `OwnerType.CharacterPlayer` hoặc không phải member nếu là `type` `OwnerType.Group` |
| --- | --- | --- | --- | --- | --- |
| `buyStoreItem` | `StoreInventoryModels.BuyStoreItemRequestData` | `buyStoreItemAsync(...)` | `StoreInventoryResponseModels.BuyStoreItemOperationResponse` | `storeInventory.buyStoreItem.selfEnable` | `storeInventory.buyStoreItem.otherSelfEnable` |
| `getStoreItemInformation` | `StoreInventoryModels.GetStoreItemInformationRequestData` | `getStoreItemInformationAsync(...)` | `StoreInventoryResponseModels.GetStoreItemInformationOperationResponse` | `storeInventory.getStoreItemInformation.otherSelfEnable` | |
| `getStoreItemsWithTag` | `StoreInventoryModels.GetStoreItemsWithTagRequestData` | `getStoreItemsWithTagAsync(...)` | `StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse` | `storeInventory.getStoreItemsWithTag.otherSelfEnable` | |
| `createStoreItem` | `StoreInventoryModels.CreateStoreItemRequestData` | `createStoreItemAsync(...)` | `StoreInventoryResponseModels.CreateStoreItemOperationResponse` | `storeInventory.createStoreItem.otherSelfEnable` | |
| `setRemoveStatus` | `StoreInventoryModels.SetRemoveStatusRequestData` | `setRemoveStatusAsync(...)` | `StoreInventoryResponseModels.SetRemoveStatusOperationResponse` | `storeInventory.setRemoveStatus.otherSelfEnable` | |
| `setStoreItemInformation` | `StoreInventoryModels.SetStoreItemInformationRequestData` | `setStoreItemInformationAsync(...)` | `StoreInventoryResponseModels.SetStoreItemInformationOperationResponse` | `storeInventory.setStoreItemInformation.otherSelfEnable` | |
| `validateAppleAppStoreReceipt` | `StoreInventoryModels.ValidateAppleAppStoreReceiptRequestData` | `validateAppleAppStoreReceiptAsync(...)` | `StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse` | `storeInventory.validateAppleAppStoreReceipt.selfEnable` | `storeInventory.validateAppleAppStoreReceipt.otherSelfEnable` |
| `validateFacebookStoreReceipt` | `StoreInventoryModels.ValidateFacebookStoreReceiptRequestData` | `validateFacebookStoreReceiptAsync(...)` | `StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse` | `storeInventory.validateFacebookStoreReceipt.selfEnable` | `storeInventory.validateFacebookStoreReceipt.otherSelfEnable` |
| `validateGooglePlayStoreReceipt` | `StoreInventoryModels.ValidateGooglePlayStoreReceiptRequestData` | `validateGooglePlayStoreReceiptAsync(...)` | `StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse` | `storeInventory.validateGooglePlayStoreReceipt.selfEnable` | `storeInventory.validateGooglePlayStoreReceipt.otherSelfEnable` |
| `getCreateLeaderboard` | `StoreInventoryModels.GetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `StoreInventoryResponseModels.GetCreateLeaderboardOperationResponse` | `storeInventory.getCreateLeaderboard.otherSelfEnable` | |
| `presentStoreItem` | `StoreInventoryModels.PresentStoreItemRequestData` | `presentStoreItemAsync(...)` | `StoreInventoryResponseModels.PresentStoreItemOperationResponse` | `storeInventory.presentStoreItem.selfEnable` | `storeInventory.presentStoreItem.otherSelfEnable` |
| `getStoreLog` | `StoreInventoryModels.GetStoreLogRequestData` | `getStoreLogAsync(...)` | `StoreInventoryResponseModels.GetStoreLogOperationResponse` | `storeInventory.getStoreLog.otherSelfEnable` | |
| `getStoreUsed` | `StoreInventoryModels.GetStoreUsedRequestData` | `getStoreUsedAsync(...)` | `StoreInventoryResponseModels.GetStoreUsedOperationResponse` | `storeInventory.getStoreUsed.otherSelfEnable` | |
| `removeStoreUsed` | `StoreInventoryModels.RemoveStoreUsedRequestData` | `removeStoreUsedAsync(...)` | `StoreInventoryResponseModels.RemoveStoreUsedOperationResponse` | `storeInventory.removeStoreUsed.otherSelfEnable` | |

## Server methods (`GNNetwork.storeInventory.server.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules |
| --- | --- | --- | --- | --- |
| `buyStoreItem` | `StoreInventoryModels.ServerBuyStoreItemRequestData` | `buyStoreItemAsync(...)` | `StoreInventoryResponseModels.BuyStoreItemOperationResponse` | `storeInventory.buyStoreItem.serverSelfEnable` |
| `getStoreItemInformation` | `StoreInventoryModels.ServerGetStoreItemInformationRequestData` | `getStoreItemInformationAsync(...)` | `StoreInventoryResponseModels.GetStoreItemInformationOperationResponse` | `storeInventory.getStoreItemInformation.serverSelfEnable` |
| `getStoreItemsWithTag` | `StoreInventoryModels.ServerGetStoreItemsWithTagRequestData` | `getStoreItemsWithTagAsync(...)` | `StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse` | `storeInventory.getStoreItemsWithTag.serverSelfEnable` |
| `createStoreItem` | `StoreInventoryModels.ServerCreateStoreItemRequestData` | `createStoreItemAsync(...)` | `StoreInventoryResponseModels.CreateStoreItemOperationResponse` | `storeInventory.createStoreItem.serverSelfEnable` |
| `setRemoveStatus` | `StoreInventoryModels.ServerSetRemoveStatusRequestData` | `setRemoveStatusAsync(...)` | `StoreInventoryResponseModels.SetRemoveStatusOperationResponse` | `storeInventory.setRemoveStatus.serverSelfEnable` |
| `setStoreItemInformation` | `StoreInventoryModels.ServerSetStoreItemInformationRequestData` | `setStoreItemInformationAsync(...)` | `StoreInventoryResponseModels.SetStoreItemInformationOperationResponse` | `storeInventory.setStoreItemInformation.serverSelfEnable` |
| `validateAppleAppStoreReceipt` | `StoreInventoryModels.ServerValidateAppleAppStoreReceiptRequestData` | `validateAppleAppStoreReceiptAsync(...)` | `StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse` | `storeInventory.validateAppleAppStoreReceipt.serverSelfEnable` |
| `validateFacebookStoreReceipt` | `StoreInventoryModels.ServerValidateFacebookStoreReceiptRequestData` | `validateFacebookStoreReceiptAsync(...)` | `StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse` | `storeInventory.validateFacebookStoreReceipt.serverSelfEnable` |
| `validateGooglePlayStoreReceipt` | `StoreInventoryModels.ServerValidateGooglePlayStoreReceiptRequestData` | `validateGooglePlayStoreReceiptAsync(...)` | `StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse` | `storeInventory.validateGooglePlayStoreReceipt.serverSelfEnable` |
| `getCreateLeaderboard` | `StoreInventoryModels.ServerGetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `StoreInventoryResponseModels.GetCreateLeaderboardOperationResponse` | `storeInventory.getCreateLeaderboard.serverSelfEnable` |
| `presentStoreItem` | `StoreInventoryModels.ServerPresentStoreItemRequestData` | `presentStoreItemAsync(...)` | `StoreInventoryResponseModels.PresentStoreItemOperationResponse` | `storeInventory.presentStoreItem.serverSelfEnable` |
| `getStoreLog` | `StoreInventoryModels.ServerGetStoreLogRequestData` | `getStoreLogAsync(...)` | `StoreInventoryResponseModels.GetStoreLogOperationResponse` | `storeInventory.getStoreLog.serverSelfEnable` |
| `getStoreUsed` | `StoreInventoryModels.ServerGetStoreUsedRequestData` | `getStoreUsedAsync(...)` | `StoreInventoryResponseModels.GetStoreUsedOperationResponse` | `storeInventory.getStoreUsed.serverSelfEnable` |
| `removeStoreUsed` | `StoreInventoryModels.ServerRemoveStoreUsedRequestData` | `removeStoreUsedAsync(...)` | `StoreInventoryResponseModels.RemoveStoreUsedOperationResponse` | `storeInventory.removeStoreUsed.serverSelfEnable` |

## Admin methods (`GNNetwork.storeInventory.admin.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules |
| --- | --- | --- | --- | --- |
| `buyStoreItem` | `StoreInventoryModels.AdminBuyStoreItemRequestData` | `buyStoreItemAsync(...)` | `StoreInventoryResponseModels.BuyStoreItemOperationResponse` | `storeInventory.buyStoreItem.adminSelfEnable` |
| `getStoreItemInformation` | `StoreInventoryModels.AdminGetStoreItemInformationRequestData` | `getStoreItemInformationAsync(...)` | `StoreInventoryResponseModels.GetStoreItemInformationOperationResponse` | `storeInventory.getStoreItemInformation.adminSelfEnable` |
| `getStoreItemsWithTag` | `StoreInventoryModels.AdminGetStoreItemsWithTagRequestData` | `getStoreItemsWithTagAsync(...)` | `StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse` | `storeInventory.getStoreItemsWithTag.adminSelfEnable` |
| `createStoreItem` | `StoreInventoryModels.AdminCreateStoreItemRequestData` | `createStoreItemAsync(...)` | `StoreInventoryResponseModels.CreateStoreItemOperationResponse` | `storeInventory.createStoreItem.adminSelfEnable` |
| `setRemoveStatus` | `StoreInventoryModels.AdminSetRemoveStatusRequestData` | `setRemoveStatusAsync(...)` | `StoreInventoryResponseModels.SetRemoveStatusOperationResponse` | `storeInventory.setRemoveStatus.adminSelfEnable` |
| `setStoreItemInformation` | `StoreInventoryModels.AdminSetStoreItemInformationRequestData` | `setStoreItemInformationAsync(...)` | `StoreInventoryResponseModels.SetStoreItemInformationOperationResponse` | `storeInventory.setStoreItemInformation.adminSelfEnable` |
| `validateAppleAppStoreReceipt` | `StoreInventoryModels.AdminValidateAppleAppStoreReceiptRequestData` | `validateAppleAppStoreReceiptAsync(...)` | `StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse` | `storeInventory.validateAppleAppStoreReceipt.adminSelfEnable` |
| `validateFacebookStoreReceipt` | `StoreInventoryModels.AdminValidateFacebookStoreReceiptRequestData` | `validateFacebookStoreReceiptAsync(...)` | `StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse` | `storeInventory.validateFacebookStoreReceipt.adminSelfEnable` |
| `validateGooglePlayStoreReceipt` | `StoreInventoryModels.AdminValidateGooglePlayStoreReceiptRequestData` | `validateGooglePlayStoreReceiptAsync(...)` | `StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse` | `storeInventory.validateGooglePlayStoreReceipt.adminSelfEnable` |
| `getCreateLeaderboard` | `StoreInventoryModels.AdminGetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `StoreInventoryResponseModels.GetCreateLeaderboardOperationResponse` | `storeInventory.getCreateLeaderboard.adminSelfEnable` |
| `presentStoreItem` | `StoreInventoryModels.AdminPresentStoreItemRequestData` | `presentStoreItemAsync(...)` | `StoreInventoryResponseModels.PresentStoreItemOperationResponse` | `storeInventory.presentStoreItem.adminSelfEnable` |
| `getStoreLog` | `StoreInventoryModels.AdminGetStoreLogRequestData` | `getStoreLogAsync(...)` | `StoreInventoryResponseModels.GetStoreLogOperationResponse` | `storeInventory.getStoreLog.adminSelfEnable` |
| `getStoreUsed` | `StoreInventoryModels.AdminGetStoreUsedRequestData` | `getStoreUsedAsync(...)` | `StoreInventoryResponseModels.GetStoreUsedOperationResponse` | `storeInventory.getStoreUsed.adminSelfEnable` |
| `removeStoreUsed` | `StoreInventoryModels.AdminRemoveStoreUsedRequestData` | `removeStoreUsedAsync(...)` | `StoreInventoryResponseModels.RemoveStoreUsedOperationResponse` | `storeInventory.removeStoreUsed.adminSelfEnable` |

## Ví dụ tối thiểu

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

// requestData: StoreInventoryModels.BuyStoreItemRequestData đã build theo dto/STORE_INVENTORY.md
var res = await GNNetwork.storeInventory.buyStoreItemAsync(requestData);
if (res.returnCode != ReturnCode.Ok) return;
if (res.errorCode != ErrorCode.Ok) return;
// res.responseData có typed payload
```
