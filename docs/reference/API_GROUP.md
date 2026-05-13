# API Reference: GroupApi

Group metadata, member roster, message stream, group-level currency/inventory/statistics.

- Domain guide: [guides/GROUP.md](/docs/guides/GROUP.md)
- DTO shapes: [dto/GROUP.md](/docs/reference/dto/GROUP.md)
- Enums: [ENUMS.md](/docs/reference/ENUMS.md)
- Error handling: [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md)
- Permission rules: [PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md)

## Namespaces

- `GNNetwork.group` — `RequestRole.Client`
- `GNNetwork.group.server` — `RequestRole.Server`
- `GNNetwork.group.admin` — `RequestRole.Admin`

## Convention

Mỗi method dưới đây có 2 form — callback và `*Async()` Task. Ưu tiên `*Async()`.

```text
// Callback
GNNetwork.group.<method>(requestData, onResponse?, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);

// Async
var res = await GNNetwork.group.<method>Async(requestData, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);
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

## Client methods (`GNNetwork.group.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules | Permission Rules khi truyền `groupId` mà `gamePlayer` đang authenticated và những `characterPlayer` có owner của `gamePlayer` đều không phải là member của `group` này |
| --- | --- | --- | --- | --- | --- |
| `addMember` | `GroupModels.AddMemberRequestData` | `addMemberAsync(...)` | `GroupResponseModels.AddMemberOperationResponse` | `group.addMember.selfEnable` | `group.addMember.otherSelfEnable` |
| `addSegment` | `GroupModels.AddSegmentRequestData` | `addSegmentAsync(...)` | `GroupResponseModels.AddSegmentOperationResponse` | `group.addSegment.selfEnable` | `group.addSegment.otherSelfEnable` |
| `getAvatar` | `GroupModels.GetAvatarRequestData` | `getAvatarAsync(...)` | `GroupResponseModels.GetAvatarOperationResponse` | `group.getAvatar.selfEnable` | `group.getAvatar.otherSelfEnable` |
| `getCatalogId` | `GroupModels.GetCatalogIdRequestData` | `getCatalogIdAsync(...)` | `GroupResponseModels.GetCatalogIdOperationResponse` | `group.getCatalogId.selfEnable` | `group.getCatalogId.otherSelfEnable` |
| `getCustomData` | `GroupModels.GetCustomDataRequestData` | `getCustomDataAsync(...)` | `GroupResponseModels.GetCustomDataOperationResponse` | `group.getCustomData.selfEnable` | `group.getCustomData.otherSelfEnable` |
| `getDisplayName` | `GroupModels.GetDisplayNameRequestData` | `getDisplayNameAsync(...)` | `GroupResponseModels.GetDisplayNameOperationResponse` | `group.getDisplayName.selfEnable` | `group.getDisplayName.otherSelfEnable` |
| `getGroupCurrency` | `GroupModels.GetGroupCurrencyRequestData` | `getGroupCurrencyAsync(...)` | `GroupResponseModels.GetGroupCurrencyOperationResponse` | `group.getGroupCurrency.selfEnable` | `group.getGroupCurrency.otherSelfEnable` |
| `getGroupData` | `GroupModels.GetGroupDataRequestData` | `getGroupDataAsync(...)` | `GroupResponseModels.GetGroupDataOperationResponse` | `group.getGroupData.selfEnable` | `group.getGroupData.otherSelfEnable` |
| `getGroupInformation` | `GroupModels.GetGroupInformationRequestData` | `getGroupInformationAsync(...)` | `GroupResponseModels.GetGroupInformationOperationResponse` | `group.getGroupInformation.selfEnable` | `group.getGroupInformation.otherSelfEnable` |
| `getGroupInventory` | `GroupModels.GetGroupInventoryRequestData` | `getGroupInventoryAsync(...)` | `GroupResponseModels.GetGroupInventoryOperationResponse` | `group.getGroupInventory.selfEnable` | `group.getGroupInventory.otherSelfEnable` |
| `getGroupMessage` | `GroupModels.GetGroupMessageRequestData` | `getGroupMessageAsync(...)` | `GroupResponseModels.GetGroupMessageOperationResponse` | `group.getGroupMessage.selfEnable` | `group.getGroupMessage.otherSelfEnable` |
| `getGroupStatistics` | `GroupModels.GetGroupStatisticsRequestData` | `getGroupStatisticsAsync(...)` | `GroupResponseModels.GetGroupStatisticsOperationResponse` | `group.getGroupStatistics.selfEnable` | `group.getGroupStatistics.otherSelfEnable` |
| `getGroupsWithDisplayName` | `GroupModels.GetGroupsWithDisplayNameRequestData` | `getGroupsWithDisplayNameAsync(...)` | `GroupResponseModels.GetGroupsWithDisplayNameOperationResponse` | `group.getGroupsWithDisplayName.otherSelfEnable` | |
| `getGroupsWithSegment` | `GroupModels.GetGroupsWithSegmentRequestData` | `getGroupsWithSegmentAsync(...)` | `GroupResponseModels.GetGroupsWithSegmentOperationResponse` | `group.getGroupsWithSegment.otherSelfEnable` | |
| `getGroupsWithTag` | `GroupModels.GetGroupsWithTagRequestData` | `getGroupsWithTagAsync(...)` | `GroupResponseModels.GetGroupsWithTagOperationResponse` | `group.getGroupsWithTag.otherSelfEnable` | |
| `getMembers` | `GroupModels.GetMembersRequestData` | `getMembersAsync(...)` | `GroupResponseModels.GetMembersOperationResponse` | `group.getMembers.selfEnable` | `group.getMembers.otherSelfEnable` |
| `getRemoveStatus` | `GroupModels.GetRemoveStatusRequestData` | `getRemoveStatusAsync(...)` | `GroupResponseModels.GetRemoveStatusOperationResponse` | `group.getRemoveStatus.selfEnable` | `group.getRemoveStatus.otherSelfEnable` |
| `getSegment` | `GroupModels.GetSegmentRequestData` | `getSegmentAsync(...)` | `GroupResponseModels.GetSegmentOperationResponse` | `group.getSegment.selfEnable` | `group.getSegment.otherSelfEnable` |
| `getStatisticsLeaderboardAroundGroup` | `GroupModels.GetStatisticsLeaderboardAroundGroupRequestData` | `getStatisticsLeaderboardAroundGroupAsync(...)` | `GroupResponseModels.GetStatisticsLeaderboardAroundGroupOperationResponse` | `group.getStatisticsLeaderboardAroundGroup.selfEnable` | `group.getStatisticsLeaderboardAroundGroup.otherSelfEnable` |
| `getStatisticsLeaderboard` | `GroupModels.GetStatisticsLeaderboardRequestData` | `getStatisticsLeaderboardAsync(...)` | `GroupResponseModels.GetStatisticsLeaderboardOperationResponse` | `group.getStatisticsLeaderboard.otherSelfEnable` | |
| `getTag` | `GroupModels.GetTagRequestData` | `getTagAsync(...)` | `GroupResponseModels.GetTagOperationResponse` | `group.getTag.selfEnable` | `group.getTag.otherSelfEnable` |
| `getTsCreate` | `GroupModels.GetTsCreateRequestData` | `getTsCreateAsync(...)` | `GroupResponseModels.GetTsCreateOperationResponse` | `group.getTsCreate.selfEnable` | `group.getTsCreate.otherSelfEnable` |
| `createGroupItem` | `GroupModels.CreateGroupItemRequestData` | `createGroupItemAsync(...)` | `GroupResponseModels.CreateGroupItemOperationResponse` | `group.createGroupItem.selfEnable` | `group.createGroupItem.otherSelfEnable` |
| `removeGroupItem` | `GroupModels.RemoveGroupItemRequestData` | `removeGroupItemAsync(...)` | `GroupResponseModels.RemoveGroupItemOperationResponse` | `group.removeGroupItem.selfEnable` | `group.removeGroupItem.otherSelfEnable` |
| `removeMember` | `GroupModels.RemoveMemberRequestData` | `removeMemberAsync(...)` | `GroupResponseModels.RemoveMemberOperationResponse` | `group.removeMember.selfEnable` | `group.removeMember.otherSelfEnable` |
| `removeSegment` | `GroupModels.RemoveSegmentRequestData` | `removeSegmentAsync(...)` | `GroupResponseModels.RemoveSegmentOperationResponse` | `group.removeSegment.selfEnable` | `group.removeSegment.otherSelfEnable` |
| `removeTag` | `GroupModels.RemoveTagRequestData` | `removeTagAsync(...)` | `GroupResponseModels.RemoveTagOperationResponse` | `group.removeTag.selfEnable` | `group.removeTag.otherSelfEnable` |
| `sendGroupMessage` | `GroupModels.SendGroupMessageRequestData` | `sendGroupMessageAsync(...)` | `GroupResponseModels.SendGroupMessageOperationResponse` | `group.sendGroupMessage.selfEnable` | `group.sendGroupMessage.otherSelfEnable` |
| `setAvatar` | `GroupModels.SetAvatarRequestData` | `setAvatarAsync(...)` | `GroupResponseModels.SetAvatarOperationResponse` | `group.setAvatar.selfEnable` | `group.setAvatar.otherSelfEnable` |
| `setCustomData` | `GroupModels.SetCustomDataRequestData` | `setCustomDataAsync(...)` | `GroupResponseModels.SetCustomDataOperationResponse` | `group.setCustomData.selfEnable` | `group.setCustomData.otherSelfEnable` |
| `setDisplayName` | `GroupModels.SetDisplayNameRequestData` | `setDisplayNameAsync(...)` | `GroupResponseModels.SetDisplayNameOperationResponse` | `group.setDisplayName.selfEnable` | `group.setDisplayName.otherSelfEnable` |
| `changeGroupCurrency` | `GroupModels.ChangeGroupCurrencyRequestData` | `changeGroupCurrencyAsync(...)` | `GroupResponseModels.ChangeGroupCurrencyOperationResponse` | `group.changeGroupCurrency.selfEnable` | `group.changeGroupCurrency.otherSelfEnable` |
| `setGroupData` | `GroupModels.SetGroupDataRequestData` | `setGroupDataAsync(...)` | `GroupResponseModels.SetGroupDataOperationResponse` | `group.setGroupData.selfEnable` | `group.setGroupData.otherSelfEnable` |
| `changeGroupStatistics` | `GroupModels.ChangeGroupStatisticsRequestData` | `changeGroupStatisticsAsync(...)` | `GroupResponseModels.ChangeGroupStatisticsOperationResponse` | `group.changeGroupStatistics.selfEnable` | `group.changeGroupStatistics.otherSelfEnable` |
| `setRemoveStatus` | `GroupModels.SetRemoveStatusRequestData` | `setRemoveStatusAsync(...)` | `GroupResponseModels.SetRemoveStatusOperationResponse` | `group.setRemoveStatus.selfEnable` | `group.setRemoveStatus.otherSelfEnable` |
| `setTag` | `GroupModels.SetTagRequestData` | `setTagAsync(...)` | `GroupResponseModels.SetTagOperationResponse` | `group.setTag.selfEnable` | `group.setTag.otherSelfEnable` |
| `getCurrencyLeaderboard` | `GroupModels.GetCurrencyLeaderboardRequestData` | `getCurrencyLeaderboardAsync(...)` | `GroupResponseModels.GetCurrencyLeaderboardOperationResponse` | `group.getCurrencyLeaderboard.otherSelfEnable` | |
| `getCreateLeaderboard` | `GroupModels.GetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `GroupResponseModels.GetCreateLeaderboardOperationResponse` | `group.getCreateLeaderboard.otherSelfEnable` | |
| `getStatisticsLog` | `GroupModels.GetStatisticsLogRequestData` | `getStatisticsLogAsync(...)` | `GroupResponseModels.GetStatisticsLogOperationResponse` | `group.getStatisticsLog.selfEnable` | `group.getStatisticsLog.otherSelfEnable` |
| `getCurrencyLog` | `GroupModels.GetCurrencyLogRequestData` | `getCurrencyLogAsync(...)` | `GroupResponseModels.GetCurrencyLogOperationResponse` | `group.getCurrencyLog.selfEnable` | `group.getCurrencyLog.otherSelfEnable` |

## Server methods (`GNNetwork.group.server.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules |
| --- | --- | --- | --- | --- |
| `addMember` | `GroupModels.ServerAddMemberRequestData` | `addMemberAsync(...)` | `GroupResponseModels.AddMemberOperationResponse` | `group.addMember.serverSelfEnable` |
| `addSegment` | `GroupModels.ServerAddSegmentRequestData` | `addSegmentAsync(...)` | `GroupResponseModels.AddSegmentOperationResponse` | `group.addSegment.serverSelfEnable` |
| `getAvatar` | `GroupModels.ServerGetAvatarRequestData` | `getAvatarAsync(...)` | `GroupResponseModels.GetAvatarOperationResponse` | `group.getAvatar.serverSelfEnable` |
| `getCatalogId` | `GroupModels.ServerGetCatalogIdRequestData` | `getCatalogIdAsync(...)` | `GroupResponseModels.GetCatalogIdOperationResponse` | `group.getCatalogId.serverSelfEnable` |
| `getCustomData` | `GroupModels.ServerGetCustomDataRequestData` | `getCustomDataAsync(...)` | `GroupResponseModels.GetCustomDataOperationResponse` | `group.getCustomData.serverSelfEnable` |
| `getDisplayName` | `GroupModels.ServerGetDisplayNameRequestData` | `getDisplayNameAsync(...)` | `GroupResponseModels.GetDisplayNameOperationResponse` | `group.getDisplayName.serverSelfEnable` |
| `getGroupCurrency` | `GroupModels.ServerGetGroupCurrencyRequestData` | `getGroupCurrencyAsync(...)` | `GroupResponseModels.GetGroupCurrencyOperationResponse` | `group.getGroupCurrency.serverSelfEnable` |
| `getGroupData` | `GroupModels.ServerGetGroupDataRequestData` | `getGroupDataAsync(...)` | `GroupResponseModels.GetGroupDataOperationResponse` | `group.getGroupData.serverSelfEnable` |
| `getGroupInformation` | `GroupModels.ServerGetGroupInformationRequestData` | `getGroupInformationAsync(...)` | `GroupResponseModels.GetGroupInformationOperationResponse` | `group.getGroupInformation.serverSelfEnable` |
| `getGroupInventory` | `GroupModels.ServerGetGroupInventoryRequestData` | `getGroupInventoryAsync(...)` | `GroupResponseModels.GetGroupInventoryOperationResponse` | `group.getGroupInventory.serverSelfEnable` |
| `getGroupMessage` | `GroupModels.ServerGetGroupMessageRequestData` | `getGroupMessageAsync(...)` | `GroupResponseModels.GetGroupMessageOperationResponse` | `group.getGroupMessage.serverSelfEnable` |
| `getGroupStatistics` | `GroupModels.ServerGetGroupStatisticsRequestData` | `getGroupStatisticsAsync(...)` | `GroupResponseModels.GetGroupStatisticsOperationResponse` | `group.getGroupStatistics.serverSelfEnable` |
| `getGroupsWithDisplayName` | `GroupModels.ServerGetGroupsWithDisplayNameRequestData` | `getGroupsWithDisplayNameAsync(...)` | `GroupResponseModels.GetGroupsWithDisplayNameOperationResponse` | `group.getGroupsWithDisplayName.serverSelfEnable` |
| `getGroupsWithSegment` | `GroupModels.ServerGetGroupsWithSegmentRequestData` | `getGroupsWithSegmentAsync(...)` | `GroupResponseModels.GetGroupsWithSegmentOperationResponse` | `group.getGroupsWithSegment.serverSelfEnable` |
| `getGroupsWithTag` | `GroupModels.ServerGetGroupsWithTagRequestData` | `getGroupsWithTagAsync(...)` | `GroupResponseModels.GetGroupsWithTagOperationResponse` | `group.getGroupsWithTag.serverSelfEnable` |
| `getMembers` | `GroupModels.ServerGetMembersRequestData` | `getMembersAsync(...)` | `GroupResponseModels.GetMembersOperationResponse` | `group.getMembers.serverSelfEnable` |
| `getRemoveStatus` | `GroupModels.ServerGetRemoveStatusRequestData` | `getRemoveStatusAsync(...)` | `GroupResponseModels.GetRemoveStatusOperationResponse` | `group.getRemoveStatus.serverSelfEnable` |
| `getSegment` | `GroupModels.ServerGetSegmentRequestData` | `getSegmentAsync(...)` | `GroupResponseModels.GetSegmentOperationResponse` | `group.getSegment.serverSelfEnable` |
| `getStatisticsLeaderboardAroundGroup` | `GroupModels.ServerGetStatisticsLeaderboardAroundGroupRequestData` | `getStatisticsLeaderboardAroundGroupAsync(...)` | `GroupResponseModels.GetStatisticsLeaderboardAroundGroupOperationResponse` | `group.getStatisticsLeaderboardAroundGroup.serverSelfEnable` |
| `getStatisticsLeaderboard` | `GroupModels.ServerGetStatisticsLeaderboardRequestData` | `getStatisticsLeaderboardAsync(...)` | `GroupResponseModels.GetStatisticsLeaderboardOperationResponse` | `group.getStatisticsLeaderboard.serverSelfEnable` |
| `getTag` | `GroupModels.ServerGetTagRequestData` | `getTagAsync(...)` | `GroupResponseModels.GetTagOperationResponse` | `group.getTag.serverSelfEnable` |
| `getTsCreate` | `GroupModels.ServerGetTsCreateRequestData` | `getTsCreateAsync(...)` | `GroupResponseModels.GetTsCreateOperationResponse` | `group.getTsCreate.serverSelfEnable` |
| `createGroupItem` | `GroupModels.ServerCreateGroupItemRequestData` | `createGroupItemAsync(...)` | `GroupResponseModels.CreateGroupItemOperationResponse` | `group.createGroupItem.serverSelfEnable` |
| `removeGroupItem` | `GroupModels.ServerRemoveGroupItemRequestData` | `removeGroupItemAsync(...)` | `GroupResponseModels.RemoveGroupItemOperationResponse` | `group.removeGroupItem.serverSelfEnable` |
| `removeMember` | `GroupModels.ServerRemoveMemberRequestData` | `removeMemberAsync(...)` | `GroupResponseModels.RemoveMemberOperationResponse` | `group.removeMember.serverSelfEnable` |
| `removeSegment` | `GroupModels.ServerRemoveSegmentRequestData` | `removeSegmentAsync(...)` | `GroupResponseModels.RemoveSegmentOperationResponse` | `group.removeSegment.serverSelfEnable` |
| `removeTag` | `GroupModels.ServerRemoveTagRequestData` | `removeTagAsync(...)` | `GroupResponseModels.RemoveTagOperationResponse` | `group.removeTag.serverSelfEnable` |
| `sendGroupMessage` | `GroupModels.ServerSendGroupMessageRequestData` | `sendGroupMessageAsync(...)` | `GroupResponseModels.SendGroupMessageOperationResponse` | `group.sendGroupMessage.serverSelfEnable` |
| `setAvatar` | `GroupModels.ServerSetAvatarRequestData` | `setAvatarAsync(...)` | `GroupResponseModels.SetAvatarOperationResponse` | `group.setAvatar.serverSelfEnable` |
| `setCustomData` | `GroupModels.ServerSetCustomDataRequestData` | `setCustomDataAsync(...)` | `GroupResponseModels.SetCustomDataOperationResponse` | `group.setCustomData.serverSelfEnable` |
| `setDisplayName` | `GroupModels.ServerSetDisplayNameRequestData` | `setDisplayNameAsync(...)` | `GroupResponseModels.SetDisplayNameOperationResponse` | `group.setDisplayName.serverSelfEnable` |
| `changeGroupCurrency` | `GroupModels.ServerChangeGroupCurrencyRequestData` | `changeGroupCurrencyAsync(...)` | `GroupResponseModels.ChangeGroupCurrencyOperationResponse` | `group.changeGroupCurrency.serverSelfEnable` |
| `setGroupData` | `GroupModels.ServerSetGroupDataRequestData` | `setGroupDataAsync(...)` | `GroupResponseModels.SetGroupDataOperationResponse` | `group.setGroupData.serverSelfEnable` |
| `changeGroupStatistics` | `GroupModels.ServerChangeGroupStatisticsRequestData` | `changeGroupStatisticsAsync(...)` | `GroupResponseModels.ChangeGroupStatisticsOperationResponse` | `group.changeGroupStatistics.serverSelfEnable` |
| `setRemoveStatus` | `GroupModels.ServerSetRemoveStatusRequestData` | `setRemoveStatusAsync(...)` | `GroupResponseModels.SetRemoveStatusOperationResponse` | `group.setRemoveStatus.serverSelfEnable` |
| `setTag` | `GroupModels.ServerSetTagRequestData` | `setTagAsync(...)` | `GroupResponseModels.SetTagOperationResponse` | `group.setTag.serverSelfEnable` |
| `getCurrencyLeaderboard` | `GroupModels.ServerGetCurrencyLeaderboardRequestData` | `getCurrencyLeaderboardAsync(...)` | `GroupResponseModels.GetCurrencyLeaderboardOperationResponse` | `group.getCurrencyLeaderboard.serverSelfEnable` |
| `getCreateLeaderboard` | `GroupModels.ServerGetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `GroupResponseModels.GetCreateLeaderboardOperationResponse` | `group.getCreateLeaderboard.serverSelfEnable` |
| `getStatisticsLog` | `GroupModels.ServerGetStatisticsLogRequestData` | `getStatisticsLogAsync(...)` | `GroupResponseModels.GetStatisticsLogOperationResponse` | `group.getStatisticsLog.serverSelfEnable` |
| `getCurrencyLog` | `GroupModels.ServerGetCurrencyLogRequestData` | `getCurrencyLogAsync(...)` | `GroupResponseModels.GetCurrencyLogOperationResponse` | `group.getCurrencyLog.serverSelfEnable` |

## Admin methods (`GNNetwork.group.admin.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules |
| --- | --- | --- | --- | --- |
| `addMember` | `GroupModels.AdminAddMemberRequestData` | `addMemberAsync(...)` | `GroupResponseModels.AddMemberOperationResponse` | `group.addMember.adminSelfEnable` |
| `addSegment` | `GroupModels.AdminAddSegmentRequestData` | `addSegmentAsync(...)` | `GroupResponseModels.AddSegmentOperationResponse` | `group.addSegment.adminSelfEnable` |
| `getAvatar` | `GroupModels.AdminGetAvatarRequestData` | `getAvatarAsync(...)` | `GroupResponseModels.GetAvatarOperationResponse` | `group.getAvatar.adminSelfEnable` |
| `getCatalogId` | `GroupModels.AdminGetCatalogIdRequestData` | `getCatalogIdAsync(...)` | `GroupResponseModels.GetCatalogIdOperationResponse` | `group.getCatalogId.adminSelfEnable` |
| `getCustomData` | `GroupModels.AdminGetCustomDataRequestData` | `getCustomDataAsync(...)` | `GroupResponseModels.GetCustomDataOperationResponse` | `group.getCustomData.adminSelfEnable` |
| `getDisplayName` | `GroupModels.AdminGetDisplayNameRequestData` | `getDisplayNameAsync(...)` | `GroupResponseModels.GetDisplayNameOperationResponse` | `group.getDisplayName.adminSelfEnable` |
| `getGroupCurrency` | `GroupModels.AdminGetGroupCurrencyRequestData` | `getGroupCurrencyAsync(...)` | `GroupResponseModels.GetGroupCurrencyOperationResponse` | `group.getGroupCurrency.adminSelfEnable` |
| `getGroupData` | `GroupModels.AdminGetGroupDataRequestData` | `getGroupDataAsync(...)` | `GroupResponseModels.GetGroupDataOperationResponse` | `group.getGroupData.adminSelfEnable` |
| `getGroupInformation` | `GroupModels.AdminGetGroupInformationRequestData` | `getGroupInformationAsync(...)` | `GroupResponseModels.GetGroupInformationOperationResponse` | `group.getGroupInformation.adminSelfEnable` |
| `getGroupInventory` | `GroupModels.AdminGetGroupInventoryRequestData` | `getGroupInventoryAsync(...)` | `GroupResponseModels.GetGroupInventoryOperationResponse` | `group.getGroupInventory.adminSelfEnable` |
| `getGroupMessage` | `GroupModels.AdminGetGroupMessageRequestData` | `getGroupMessageAsync(...)` | `GroupResponseModels.GetGroupMessageOperationResponse` | `group.getGroupMessage.adminSelfEnable` |
| `getGroupStatistics` | `GroupModels.AdminGetGroupStatisticsRequestData` | `getGroupStatisticsAsync(...)` | `GroupResponseModels.GetGroupStatisticsOperationResponse` | `group.getGroupStatistics.adminSelfEnable` |
| `getGroupsWithDisplayName` | `GroupModels.AdminGetGroupsWithDisplayNameRequestData` | `getGroupsWithDisplayNameAsync(...)` | `GroupResponseModels.GetGroupsWithDisplayNameOperationResponse` | `group.getGroupsWithDisplayName.adminSelfEnable` |
| `getGroupsWithSegment` | `GroupModels.AdminGetGroupsWithSegmentRequestData` | `getGroupsWithSegmentAsync(...)` | `GroupResponseModels.GetGroupsWithSegmentOperationResponse` | `group.getGroupsWithSegment.adminSelfEnable` |
| `getGroupsWithTag` | `GroupModels.AdminGetGroupsWithTagRequestData` | `getGroupsWithTagAsync(...)` | `GroupResponseModels.GetGroupsWithTagOperationResponse` | `group.getGroupsWithTag.adminSelfEnable` |
| `getMembers` | `GroupModels.AdminGetMembersRequestData` | `getMembersAsync(...)` | `GroupResponseModels.GetMembersOperationResponse` | `group.getMembers.adminSelfEnable` |
| `getRemoveStatus` | `GroupModels.AdminGetRemoveStatusRequestData` | `getRemoveStatusAsync(...)` | `GroupResponseModels.GetRemoveStatusOperationResponse` | `group.getRemoveStatus.adminSelfEnable` |
| `getSegment` | `GroupModels.AdminGetSegmentRequestData` | `getSegmentAsync(...)` | `GroupResponseModels.GetSegmentOperationResponse` | `group.getSegment.adminSelfEnable` |
| `getStatisticsLeaderboardAroundGroup` | `GroupModels.AdminGetStatisticsLeaderboardAroundGroupRequestData` | `getStatisticsLeaderboardAroundGroupAsync(...)` | `GroupResponseModels.GetStatisticsLeaderboardAroundGroupOperationResponse` | `group.getStatisticsLeaderboardAroundGroup.adminSelfEnable` |
| `getStatisticsLeaderboard` | `GroupModels.AdminGetStatisticsLeaderboardRequestData` | `getStatisticsLeaderboardAsync(...)` | `GroupResponseModels.GetStatisticsLeaderboardOperationResponse` | `group.getStatisticsLeaderboard.adminSelfEnable` |
| `getTag` | `GroupModels.AdminGetTagRequestData` | `getTagAsync(...)` | `GroupResponseModels.GetTagOperationResponse` | `group.getTag.adminSelfEnable` |
| `getTsCreate` | `GroupModels.AdminGetTsCreateRequestData` | `getTsCreateAsync(...)` | `GroupResponseModels.GetTsCreateOperationResponse` | `group.getTsCreate.adminSelfEnable` |
| `createGroupItem` | `GroupModels.AdminCreateGroupItemRequestData` | `createGroupItemAsync(...)` | `GroupResponseModels.CreateGroupItemOperationResponse` | `group.createGroupItem.adminSelfEnable` |
| `removeGroupItem` | `GroupModels.AdminRemoveGroupItemRequestData` | `removeGroupItemAsync(...)` | `GroupResponseModels.RemoveGroupItemOperationResponse` | `group.removeGroupItem.adminSelfEnable` |
| `removeMember` | `GroupModels.AdminRemoveMemberRequestData` | `removeMemberAsync(...)` | `GroupResponseModels.RemoveMemberOperationResponse` | `group.removeMember.adminSelfEnable` |
| `removeSegment` | `GroupModels.AdminRemoveSegmentRequestData` | `removeSegmentAsync(...)` | `GroupResponseModels.RemoveSegmentOperationResponse` | `group.removeSegment.adminSelfEnable` |
| `removeTag` | `GroupModels.AdminRemoveTagRequestData` | `removeTagAsync(...)` | `GroupResponseModels.RemoveTagOperationResponse` | `group.removeTag.adminSelfEnable` |
| `sendGroupMessage` | `GroupModels.AdminSendGroupMessageRequestData` | `sendGroupMessageAsync(...)` | `GroupResponseModels.SendGroupMessageOperationResponse` | `group.sendGroupMessage.adminSelfEnable` |
| `setAvatar` | `GroupModels.AdminSetAvatarRequestData` | `setAvatarAsync(...)` | `GroupResponseModels.SetAvatarOperationResponse` | `group.setAvatar.adminSelfEnable` |
| `setCustomData` | `GroupModels.AdminSetCustomDataRequestData` | `setCustomDataAsync(...)` | `GroupResponseModels.SetCustomDataOperationResponse` | `group.setCustomData.adminSelfEnable` |
| `setDisplayName` | `GroupModels.AdminSetDisplayNameRequestData` | `setDisplayNameAsync(...)` | `GroupResponseModels.SetDisplayNameOperationResponse` | `group.setDisplayName.adminSelfEnable` |
| `changeGroupCurrency` | `GroupModels.AdminChangeGroupCurrencyRequestData` | `changeGroupCurrencyAsync(...)` | `GroupResponseModels.ChangeGroupCurrencyOperationResponse` | `group.changeGroupCurrency.adminSelfEnable` |
| `setGroupData` | `GroupModels.AdminSetGroupDataRequestData` | `setGroupDataAsync(...)` | `GroupResponseModels.SetGroupDataOperationResponse` | `group.setGroupData.adminSelfEnable` |
| `changeGroupStatistics` | `GroupModels.AdminChangeGroupStatisticsRequestData` | `changeGroupStatisticsAsync(...)` | `GroupResponseModels.ChangeGroupStatisticsOperationResponse` | `group.changeGroupStatistics.adminSelfEnable` |
| `setRemoveStatus` | `GroupModels.AdminSetRemoveStatusRequestData` | `setRemoveStatusAsync(...)` | `GroupResponseModels.SetRemoveStatusOperationResponse` | `group.setRemoveStatus.adminSelfEnable` |
| `setTag` | `GroupModels.AdminSetTagRequestData` | `setTagAsync(...)` | `GroupResponseModels.SetTagOperationResponse` | `group.setTag.adminSelfEnable` |
| `getCurrencyLeaderboard` | `GroupModels.AdminGetCurrencyLeaderboardRequestData` | `getCurrencyLeaderboardAsync(...)` | `GroupResponseModels.GetCurrencyLeaderboardOperationResponse` | `group.getCurrencyLeaderboard.adminSelfEnable` |
| `getCreateLeaderboard` | `GroupModels.AdminGetCreateLeaderboardRequestData` | `getCreateLeaderboardAsync(...)` | `GroupResponseModels.GetCreateLeaderboardOperationResponse` | `group.getCreateLeaderboard.adminSelfEnable` |
| `getStatisticsLog` | `GroupModels.AdminGetStatisticsLogRequestData` | `getStatisticsLogAsync(...)` | `GroupResponseModels.GetStatisticsLogOperationResponse` | `group.getStatisticsLog.adminSelfEnable` |
| `getCurrencyLog` | `GroupModels.AdminGetCurrencyLogRequestData` | `getCurrencyLogAsync(...)` | `GroupResponseModels.GetCurrencyLogOperationResponse` | `group.getCurrencyLog.adminSelfEnable` |

## Ví dụ tối thiểu

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

// requestData: GroupModels.AddMemberRequestData đã build theo dto/GROUP.md
var res = await GNNetwork.group.addMemberAsync(requestData);
if (res.returnCode != ReturnCode.Ok) return;
if (res.errorCode != ErrorCode.Ok) return;
// res.responseData có typed payload
```
