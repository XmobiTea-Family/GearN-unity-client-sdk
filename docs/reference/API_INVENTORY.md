# API Reference: InventoryApi

Inventory item metadata, ownership, amount, statistics, activity log.

- Domain guide: [guides/INVENTORY.md](/docs/guides/INVENTORY.md)
- DTO shapes: [dto/INVENTORY.md](/docs/reference/dto/INVENTORY.md)
- Enums: [ENUMS.md](/docs/reference/ENUMS.md)
- Error handling: [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md)
- Permission rules: [PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md)

## Namespaces

- `GNNetwork.inventory` — `RequestRole.Client`
- `GNNetwork.inventory.server` — `RequestRole.Server`
- `GNNetwork.inventory.admin` — `RequestRole.Admin`

## Convention

Mỗi method dưới đây có 2 form — callback và `*Async()` Task. Ưu tiên `*Async()`.

```text
// Callback
GNNetwork.inventory.<method>(requestData, onResponse?, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);

// Async
var res = await GNNetwork.inventory.<method>Async(requestData, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);
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

## Client methods (`GNNetwork.inventory.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules | Permission Rules khi truyền `itemId` mà `gamePlayer` đang authenticated hoặc các `characterPlayer` thuộc về `gamePlayer` không phải là owner của `inventory` này |
| --- | --- | --- | --- | --- | --- |
| `addSegment` | `InventoryModels.AddSegmentRequestData` | `addSegmentAsync(...)` | `InventoryResponseModels.AddSegmentOperationResponse` | `inventory.addSegment.selfEnable` | `inventory.addSegment.otherSelfEnable` |
| `getAmount` | `InventoryModels.GetAmountRequestData` | `getAmountAsync(...)` | `InventoryResponseModels.GetAmountOperationResponse` | `inventory.getAmount.selfEnable` | `inventory.getAmount.otherSelfEnable` |
| `getAvatar` | `InventoryModels.GetAvatarRequestData` | `getAvatarAsync(...)` | `InventoryResponseModels.GetAvatarOperationResponse` | `inventory.getAvatar.selfEnable` | `inventory.getAvatar.otherSelfEnable` |
| `getCatalogId` | `InventoryModels.GetCatalogIdRequestData` | `getCatalogIdAsync(...)` | `InventoryResponseModels.GetCatalogIdOperationResponse` | `inventory.getCatalogId.selfEnable` | `inventory.getCatalogId.otherSelfEnable` |
| `getClassId` | `InventoryModels.GetClassIdRequestData` | `getClassIdAsync(...)` | `InventoryResponseModels.GetClassIdOperationResponse` | `inventory.getClassId.selfEnable` | `inventory.getClassId.otherSelfEnable` |
| `getCustomData` | `InventoryModels.GetCustomDataRequestData` | `getCustomDataAsync(...)` | `InventoryResponseModels.GetCustomDataOperationResponse` | `inventory.getCustomData.selfEnable` | `inventory.getCustomData.otherSelfEnable` |
| `getDisplayName` | `InventoryModels.GetDisplayNameRequestData` | `getDisplayNameAsync(...)` | `InventoryResponseModels.GetDisplayNameOperationResponse` | `inventory.getDisplayName.selfEnable` | `inventory.getDisplayName.otherSelfEnable` |
| `getItemData` | `InventoryModels.GetItemDataRequestData` | `getItemDataAsync(...)` | `InventoryResponseModels.GetItemDataOperationResponse` | `inventory.getItemData.selfEnable` | `inventory.getItemData.otherSelfEnable` |
| `getItemInformation` | `InventoryModels.GetItemInformationRequestData` | `getItemInformationAsync(...)` | `InventoryResponseModels.GetItemInformationOperationResponse` | `inventory.getItemInformation.selfEnable` | `inventory.getItemInformation.otherSelfEnable` |
| `getItemStatistics` | `InventoryModels.GetItemStatisticsRequestData` | `getItemStatisticsAsync(...)` | `InventoryResponseModels.GetItemStatisticsOperationResponse` | `inventory.getItemStatistics.selfEnable` | `inventory.getItemStatistics.otherSelfEnable` |
| `getItemsWithDisplayName` | `InventoryModels.GetItemsWithDisplayNameRequestData` | `getItemsWithDisplayNameAsync(...)` | `InventoryResponseModels.GetItemsWithDisplayNameOperationResponse` | `inventory.getItemsWithDisplayName.otherSelfEnable` | |
| `getItemsWithSegment` | `InventoryModels.GetItemsWithSegmentRequestData` | `getItemsWithSegmentAsync(...)` | `InventoryResponseModels.GetItemsWithSegmentOperationResponse` | `inventory.getItemsWithSegment.otherSelfEnable` | |
| `getItemsWithTag` | `InventoryModels.GetItemsWithTagRequestData` | `getItemsWithTagAsync(...)` | `InventoryResponseModels.GetItemsWithTagOperationResponse` | `inventory.getItemsWithTag.otherSelfEnable` | |
| `getItemType` | `InventoryModels.GetItemTypeRequestData` | `getItemTypeAsync(...)` | `InventoryResponseModels.GetItemTypeOperationResponse` | `inventory.getItemType.selfEnable` | `inventory.getItemType.otherSelfEnable` |
| `getOwner` | `InventoryModels.GetOwnerRequestData` | `getOwnerAsync(...)` | `InventoryResponseModels.GetOwnerOperationResponse` | `inventory.getOwner.selfEnable` | `inventory.getOwner.otherSelfEnable` |
| `getRemoveStatus` | `InventoryModels.GetRemoveStatusRequestData` | `getRemoveStatusAsync(...)` | `InventoryResponseModels.GetRemoveStatusOperationResponse` | `inventory.getRemoveStatus.selfEnable` | `inventory.getRemoveStatus.otherSelfEnable` |
| `getSegment` | `InventoryModels.GetSegmentRequestData` | `getSegmentAsync(...)` | `InventoryResponseModels.GetSegmentOperationResponse` | `inventory.getSegment.selfEnable` | `inventory.getSegment.otherSelfEnable` |
| `getStatisticsLeaderboardAroundItem` | `InventoryModels.GetStatisticsLeaderboardAroundItemRequestData` | `getStatisticsLeaderboardAroundItemAsync(...)` | `InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse` | `inventory.getStatisticsLeaderboardAroundItem.selfEnable` | `inventory.getStatisticsLeaderboardAroundItem.otherSelfEnable` |
| `getStatisticsLeaderboard` | `InventoryModels.GetStatisticsLeaderboardRequestData` | `getStatisticsLeaderboardAsync(...)` | `InventoryResponseModels.GetStatisticsLeaderboardOperationResponse` | `inventory.getStatisticsLeaderboard.otherSelfEnable` | |
| `getTag` | `InventoryModels.GetTagRequestData` | `getTagAsync(...)` | `InventoryResponseModels.GetTagOperationResponse` | `inventory.getTag.selfEnable` | `inventory.getTag.otherSelfEnable` |
| `getTsCreate` | `InventoryModels.GetTsCreateRequestData` | `getTsCreateAsync(...)` | `InventoryResponseModels.GetTsCreateOperationResponse` | `inventory.getTsCreate.selfEnable` | `inventory.getTsCreate.otherSelfEnable` |
| `removeSegment` | `InventoryModels.RemoveSegmentRequestData` | `removeSegmentAsync(...)` | `InventoryResponseModels.RemoveSegmentOperationResponse` | `inventory.removeSegment.selfEnable` | `inventory.removeSegment.otherSelfEnable` |
| `removeTag` | `InventoryModels.RemoveTagRequestData` | `removeTagAsync(...)` | `InventoryResponseModels.RemoveTagOperationResponse` | `inventory.removeTag.selfEnable` | `inventory.removeTag.otherSelfEnable` |
| `setAmount` | `InventoryModels.SetAmountRequestData` | `setAmountAsync(...)` | `InventoryResponseModels.SetAmountOperationResponse` | `inventory.setAmount.selfEnable` | `inventory.setAmount.otherSelfEnable` |
| `setAvatar` | `InventoryModels.SetAvatarRequestData` | `setAvatarAsync(...)` | `InventoryResponseModels.SetAvatarOperationResponse` | `inventory.setAvatar.selfEnable` | `inventory.setAvatar.otherSelfEnable` |
| `setCustomData` | `InventoryModels.SetCustomDataRequestData` | `setCustomDataAsync(...)` | `InventoryResponseModels.SetCustomDataOperationResponse` | `inventory.setCustomData.selfEnable` | `inventory.setCustomData.otherSelfEnable` |
| `setDisplayName` | `InventoryModels.SetDisplayNameRequestData` | `setDisplayNameAsync(...)` | `InventoryResponseModels.SetDisplayNameOperationResponse` | `inventory.setDisplayName.selfEnable` | `inventory.setDisplayName.otherSelfEnable` |
| `setItemData` | `InventoryModels.SetItemDataRequestData` | `setItemDataAsync(...)` | `InventoryResponseModels.SetItemDataOperationResponse` | `inventory.setItemData.selfEnable` | `inventory.setItemData.otherSelfEnable` |
| `changeItemStatistics` | `InventoryModels.ChangeItemStatisticsRequestData` | `changeItemStatisticsAsync(...)` | `InventoryResponseModels.ChangeItemStatisticsOperationResponse` | `inventory.changeItemStatistics.selfEnable` | `inventory.changeItemStatistics.otherSelfEnable` |
| `setOwner` | `InventoryModels.SetOwnerRequestData` | `setOwnerAsync(...)` | `InventoryResponseModels.SetOwnerOperationResponse` | `inventory.setOwner.selfEnable` | `inventory.setOwner.otherSelfEnable` |
| `setRemoveStatus` | `InventoryModels.SetRemoveStatusRequestData` | `setRemoveStatusAsync(...)` | `InventoryResponseModels.SetRemoveStatusOperationResponse` | `inventory.setRemoveStatus.selfEnable` | `inventory.setRemoveStatus.otherSelfEnable` |
| `setTag` | `InventoryModels.SetTagRequestData` | `setTagAsync(...)` | `InventoryResponseModels.SetTagOperationResponse` | `inventory.setTag.selfEnable` | `inventory.setTag.otherSelfEnable` |
| `getCreateLeaderboard` | `InventoryModels.GetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `InventoryResponseModels.GetCreateLeaderboardOperationResponse` | `inventory.getCreateLeaderboard.otherSelfEnable` | |
| `getStatisticsLog` | `InventoryModels.GetStatisticsLogRequestData` | `getStatisticsLogAsync(...)` | `InventoryResponseModels.GetStatisticsLogOperationResponse` | `inventory.getStatisticsLog.selfEnable` | `inventory.getStatisticsLog.otherSelfEnable` |

## Server methods (`GNNetwork.inventory.server.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules |
| --- | --- | --- | --- | --- |
| `addSegment` | `InventoryModels.ServerAddSegmentRequestData` | `addSegmentAsync(...)` | `InventoryResponseModels.AddSegmentOperationResponse` | `inventory.addSegment.serverSelfEnable` |
| `getAmount` | `InventoryModels.ServerGetAmountRequestData` | `getAmountAsync(...)` | `InventoryResponseModels.GetAmountOperationResponse` | `inventory.getAmount.serverSelfEnable` |
| `getAvatar` | `InventoryModels.ServerGetAvatarRequestData` | `getAvatarAsync(...)` | `InventoryResponseModels.GetAvatarOperationResponse` | `inventory.getAvatar.serverSelfEnable` |
| `getCatalogId` | `InventoryModels.ServerGetCatalogIdRequestData` | `getCatalogIdAsync(...)` | `InventoryResponseModels.GetCatalogIdOperationResponse` | `inventory.getCatalogId.serverSelfEnable` |
| `getClassId` | `InventoryModels.ServerGetClassIdRequestData` | `getClassIdAsync(...)` | `InventoryResponseModels.GetClassIdOperationResponse` | `inventory.getClassId.serverSelfEnable` |
| `getCustomData` | `InventoryModels.ServerGetCustomDataRequestData` | `getCustomDataAsync(...)` | `InventoryResponseModels.GetCustomDataOperationResponse` | `inventory.getCustomData.serverSelfEnable` |
| `getDisplayName` | `InventoryModels.ServerGetDisplayNameRequestData` | `getDisplayNameAsync(...)` | `InventoryResponseModels.GetDisplayNameOperationResponse` | `inventory.getDisplayName.serverSelfEnable` |
| `getItemData` | `InventoryModels.ServerGetItemDataRequestData` | `getItemDataAsync(...)` | `InventoryResponseModels.GetItemDataOperationResponse` | `inventory.getItemData.serverSelfEnable` |
| `getItemInformation` | `InventoryModels.ServerGetItemInformationRequestData` | `getItemInformationAsync(...)` | `InventoryResponseModels.GetItemInformationOperationResponse` | `inventory.getItemInformation.serverSelfEnable` |
| `getItemStatistics` | `InventoryModels.ServerGetItemStatisticsRequestData` | `getItemStatisticsAsync(...)` | `InventoryResponseModels.GetItemStatisticsOperationResponse` | `inventory.getItemStatistics.serverSelfEnable` |
| `getItemsWithDisplayName` | `InventoryModels.ServerGetItemsWithDisplayNameRequestData` | `getItemsWithDisplayNameAsync(...)` | `InventoryResponseModels.GetItemsWithDisplayNameOperationResponse` | `inventory.getItemsWithDisplayName.serverSelfEnable` |
| `getItemsWithSegment` | `InventoryModels.ServerGetItemsWithSegmentRequestData` | `getItemsWithSegmentAsync(...)` | `InventoryResponseModels.GetItemsWithSegmentOperationResponse` | `inventory.getItemsWithSegment.serverSelfEnable` |
| `getItemsWithTag` | `InventoryModels.ServerGetItemsWithTagRequestData` | `getItemsWithTagAsync(...)` | `InventoryResponseModels.GetItemsWithTagOperationResponse` | `inventory.getItemsWithTag.serverSelfEnable` |
| `getItemType` | `InventoryModels.ServerGetItemTypeRequestData` | `getItemTypeAsync(...)` | `InventoryResponseModels.GetItemTypeOperationResponse` | `inventory.getItemType.serverSelfEnable` |
| `getOwner` | `InventoryModels.ServerGetOwnerRequestData` | `getOwnerAsync(...)` | `InventoryResponseModels.GetOwnerOperationResponse` | `inventory.getOwner.serverSelfEnable` |
| `getRemoveStatus` | `InventoryModels.ServerGetRemoveStatusRequestData` | `getRemoveStatusAsync(...)` | `InventoryResponseModels.GetRemoveStatusOperationResponse` | `inventory.getRemoveStatus.serverSelfEnable` |
| `getSegment` | `InventoryModels.ServerGetSegmentRequestData` | `getSegmentAsync(...)` | `InventoryResponseModels.GetSegmentOperationResponse` | `inventory.getSegment.serverSelfEnable` |
| `getStatisticsLeaderboardAroundItem` | `InventoryModels.ServerGetStatisticsLeaderboardAroundItemRequestData` | `getStatisticsLeaderboardAroundItemAsync(...)` | `InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse` | `inventory.getStatisticsLeaderboardAroundItem.serverSelfEnable` |
| `getStatisticsLeaderboard` | `InventoryModels.ServerGetStatisticsLeaderboardRequestData` | `getStatisticsLeaderboardAsync(...)` | `InventoryResponseModels.GetStatisticsLeaderboardOperationResponse` | `inventory.getStatisticsLeaderboard.serverSelfEnable` |
| `getTag` | `InventoryModels.ServerGetTagRequestData` | `getTagAsync(...)` | `InventoryResponseModels.GetTagOperationResponse` | `inventory.getTag.serverSelfEnable` |
| `getTsCreate` | `InventoryModels.ServerGetTsCreateRequestData` | `getTsCreateAsync(...)` | `InventoryResponseModels.GetTsCreateOperationResponse` | `inventory.getTsCreate.serverSelfEnable` |
| `removeSegment` | `InventoryModels.ServerRemoveSegmentRequestData` | `removeSegmentAsync(...)` | `InventoryResponseModels.RemoveSegmentOperationResponse` | `inventory.removeSegment.serverSelfEnable` |
| `removeTag` | `InventoryModels.ServerRemoveTagRequestData` | `removeTagAsync(...)` | `InventoryResponseModels.RemoveTagOperationResponse` | `inventory.removeTag.serverSelfEnable` |
| `setAmount` | `InventoryModels.ServerSetAmountRequestData` | `setAmountAsync(...)` | `InventoryResponseModels.SetAmountOperationResponse` | `inventory.setAmount.serverSelfEnable` |
| `setAvatar` | `InventoryModels.ServerSetAvatarRequestData` | `setAvatarAsync(...)` | `InventoryResponseModels.SetAvatarOperationResponse` | `inventory.setAvatar.serverSelfEnable` |
| `setCustomData` | `InventoryModels.ServerSetCustomDataRequestData` | `setCustomDataAsync(...)` | `InventoryResponseModels.SetCustomDataOperationResponse` | `inventory.setCustomData.serverSelfEnable` |
| `setDisplayName` | `InventoryModels.ServerSetDisplayNameRequestData` | `setDisplayNameAsync(...)` | `InventoryResponseModels.SetDisplayNameOperationResponse` | `inventory.setDisplayName.serverSelfEnable` |
| `setItemData` | `InventoryModels.ServerSetItemDataRequestData` | `setItemDataAsync(...)` | `InventoryResponseModels.SetItemDataOperationResponse` | `inventory.setItemData.serverSelfEnable` |
| `changeItemStatistics` | `InventoryModels.ServerChangeItemStatisticsRequestData` | `changeItemStatisticsAsync(...)` | `InventoryResponseModels.ChangeItemStatisticsOperationResponse` | `inventory.changeItemStatistics.serverSelfEnable` |
| `setOwner` | `InventoryModels.ServerSetOwnerRequestData` | `setOwnerAsync(...)` | `InventoryResponseModels.SetOwnerOperationResponse` | `inventory.setOwner.serverSelfEnable` |
| `setRemoveStatus` | `InventoryModels.ServerSetRemoveStatusRequestData` | `setRemoveStatusAsync(...)` | `InventoryResponseModels.SetRemoveStatusOperationResponse` | `inventory.setRemoveStatus.serverSelfEnable` |
| `setTag` | `InventoryModels.ServerSetTagRequestData` | `setTagAsync(...)` | `InventoryResponseModels.SetTagOperationResponse` | `inventory.setTag.serverSelfEnable` |
| `getCreateLeaderboard` | `InventoryModels.ServerGetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `InventoryResponseModels.GetCreateLeaderboardOperationResponse` | `inventory.getCreateLeaderboard.serverSelfEnable` |
| `getStatisticsLog` | `InventoryModels.ServerGetStatisticsLogRequestData` | `getStatisticsLogAsync(...)` | `InventoryResponseModels.GetStatisticsLogOperationResponse` | `inventory.getStatisticsLog.serverSelfEnable` |

## Admin methods (`GNNetwork.inventory.admin.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules |
| --- | --- | --- | --- | --- |
| `addSegment` | `InventoryModels.AdminAddSegmentRequestData` | `addSegmentAsync(...)` | `InventoryResponseModels.AddSegmentOperationResponse` | `inventory.addSegment.adminSelfEnable` |
| `getAmount` | `InventoryModels.AdminGetAmountRequestData` | `getAmountAsync(...)` | `InventoryResponseModels.GetAmountOperationResponse` | `inventory.getAmount.adminSelfEnable` |
| `getAvatar` | `InventoryModels.AdminGetAvatarRequestData` | `getAvatarAsync(...)` | `InventoryResponseModels.GetAvatarOperationResponse` | `inventory.getAvatar.adminSelfEnable` |
| `getCatalogId` | `InventoryModels.AdminGetCatalogIdRequestData` | `getCatalogIdAsync(...)` | `InventoryResponseModels.GetCatalogIdOperationResponse` | `inventory.getCatalogId.adminSelfEnable` |
| `getClassId` | `InventoryModels.AdminGetClassIdRequestData` | `getClassIdAsync(...)` | `InventoryResponseModels.GetClassIdOperationResponse` | `inventory.getClassId.adminSelfEnable` |
| `getCustomData` | `InventoryModels.AdminGetCustomDataRequestData` | `getCustomDataAsync(...)` | `InventoryResponseModels.GetCustomDataOperationResponse` | `inventory.getCustomData.adminSelfEnable` |
| `getDisplayName` | `InventoryModels.AdminGetDisplayNameRequestData` | `getDisplayNameAsync(...)` | `InventoryResponseModels.GetDisplayNameOperationResponse` | `inventory.getDisplayName.adminSelfEnable` |
| `getItemData` | `InventoryModels.AdminGetItemDataRequestData` | `getItemDataAsync(...)` | `InventoryResponseModels.GetItemDataOperationResponse` | `inventory.getItemData.adminSelfEnable` |
| `getItemInformation` | `InventoryModels.AdminGetItemInformationRequestData` | `getItemInformationAsync(...)` | `InventoryResponseModels.GetItemInformationOperationResponse` | `inventory.getItemInformation.adminSelfEnable` |
| `getItemStatistics` | `InventoryModels.AdminGetItemStatisticsRequestData` | `getItemStatisticsAsync(...)` | `InventoryResponseModels.GetItemStatisticsOperationResponse` | `inventory.getItemStatistics.adminSelfEnable` |
| `getItemsWithDisplayName` | `InventoryModels.AdminGetItemsWithDisplayNameRequestData` | `getItemsWithDisplayNameAsync(...)` | `InventoryResponseModels.GetItemsWithDisplayNameOperationResponse` | `inventory.getItemsWithDisplayName.adminSelfEnable` |
| `getItemsWithSegment` | `InventoryModels.AdminGetItemsWithSegmentRequestData` | `getItemsWithSegmentAsync(...)` | `InventoryResponseModels.GetItemsWithSegmentOperationResponse` | `inventory.getItemsWithSegment.adminSelfEnable` |
| `getItemsWithTag` | `InventoryModels.AdminGetItemsWithTagRequestData` | `getItemsWithTagAsync(...)` | `InventoryResponseModels.GetItemsWithTagOperationResponse` | `inventory.getItemsWithTag.adminSelfEnable` |
| `getItemType` | `InventoryModels.AdminGetItemTypeRequestData` | `getItemTypeAsync(...)` | `InventoryResponseModels.GetItemTypeOperationResponse` | `inventory.getItemType.adminSelfEnable` |
| `getOwner` | `InventoryModels.AdminGetOwnerRequestData` | `getOwnerAsync(...)` | `InventoryResponseModels.GetOwnerOperationResponse` | `inventory.getOwner.adminSelfEnable` |
| `getRemoveStatus` | `InventoryModels.AdminGetRemoveStatusRequestData` | `getRemoveStatusAsync(...)` | `InventoryResponseModels.GetRemoveStatusOperationResponse` | `inventory.getRemoveStatus.adminSelfEnable` |
| `getSegment` | `InventoryModels.AdminGetSegmentRequestData` | `getSegmentAsync(...)` | `InventoryResponseModels.GetSegmentOperationResponse` | `inventory.getSegment.adminSelfEnable` |
| `getStatisticsLeaderboardAroundItem` | `InventoryModels.AdminGetStatisticsLeaderboardAroundItemRequestData` | `getStatisticsLeaderboardAroundItemAsync(...)` | `InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse` | `inventory.getStatisticsLeaderboardAroundItem.adminSelfEnable` |
| `getStatisticsLeaderboard` | `InventoryModels.AdminGetStatisticsLeaderboardRequestData` | `getStatisticsLeaderboardAsync(...)` | `InventoryResponseModels.GetStatisticsLeaderboardOperationResponse` | `inventory.getStatisticsLeaderboard.adminSelfEnable` |
| `getTag` | `InventoryModels.AdminGetTagRequestData` | `getTagAsync(...)` | `InventoryResponseModels.GetTagOperationResponse` | `inventory.getTag.adminSelfEnable` |
| `getTsCreate` | `InventoryModels.AdminGetTsCreateRequestData` | `getTsCreateAsync(...)` | `InventoryResponseModels.GetTsCreateOperationResponse` | `inventory.getTsCreate.adminSelfEnable` |
| `removeSegment` | `InventoryModels.AdminRemoveSegmentRequestData` | `removeSegmentAsync(...)` | `InventoryResponseModels.RemoveSegmentOperationResponse` | `inventory.removeSegment.adminSelfEnable` |
| `removeTag` | `InventoryModels.AdminRemoveTagRequestData` | `removeTagAsync(...)` | `InventoryResponseModels.RemoveTagOperationResponse` | `inventory.removeTag.adminSelfEnable` |
| `setAmount` | `InventoryModels.AdminSetAmountRequestData` | `setAmountAsync(...)` | `InventoryResponseModels.SetAmountOperationResponse` | `inventory.setAmount.adminSelfEnable` |
| `setAvatar` | `InventoryModels.AdminSetAvatarRequestData` | `setAvatarAsync(...)` | `InventoryResponseModels.SetAvatarOperationResponse` | `inventory.setAvatar.adminSelfEnable` |
| `setCustomData` | `InventoryModels.AdminSetCustomDataRequestData` | `setCustomDataAsync(...)` | `InventoryResponseModels.SetCustomDataOperationResponse` | `inventory.setCustomData.adminSelfEnable` |
| `setDisplayName` | `InventoryModels.AdminSetDisplayNameRequestData` | `setDisplayNameAsync(...)` | `InventoryResponseModels.SetDisplayNameOperationResponse` | `inventory.setDisplayName.adminSelfEnable` |
| `setItemData` | `InventoryModels.AdminSetItemDataRequestData` | `setItemDataAsync(...)` | `InventoryResponseModels.SetItemDataOperationResponse` | `inventory.setItemData.adminSelfEnable` |
| `changeItemStatistics` | `InventoryModels.AdminChangeItemStatisticsRequestData` | `changeItemStatisticsAsync(...)` | `InventoryResponseModels.ChangeItemStatisticsOperationResponse` | `inventory.changeItemStatistics.adminSelfEnable` |
| `setOwner` | `InventoryModels.AdminSetOwnerRequestData` | `setOwnerAsync(...)` | `InventoryResponseModels.SetOwnerOperationResponse` | `inventory.setOwner.adminSelfEnable` |
| `setRemoveStatus` | `InventoryModels.AdminSetRemoveStatusRequestData` | `setRemoveStatusAsync(...)` | `InventoryResponseModels.SetRemoveStatusOperationResponse` | `inventory.setRemoveStatus.adminSelfEnable` |
| `setTag` | `InventoryModels.AdminSetTagRequestData` | `setTagAsync(...)` | `InventoryResponseModels.SetTagOperationResponse` | `inventory.setTag.adminSelfEnable` |
| `getCreateLeaderboard` | `InventoryModels.AdminGetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `InventoryResponseModels.GetCreateLeaderboardOperationResponse` | `inventory.getCreateLeaderboard.adminSelfEnable` |
| `getStatisticsLog` | `InventoryModels.AdminGetStatisticsLogRequestData` | `getStatisticsLogAsync(...)` | `InventoryResponseModels.GetStatisticsLogOperationResponse` | `inventory.getStatisticsLog.adminSelfEnable` |

## Ví dụ tối thiểu

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

// requestData: InventoryModels.AddSegmentRequestData đã build theo dto/INVENTORY.md
var res = await GNNetwork.inventory.addSegmentAsync(requestData);
if (res.returnCode != ReturnCode.Ok) return;
if (res.errorCode != ErrorCode.Ok) return;
// res.responseData có typed payload
```
