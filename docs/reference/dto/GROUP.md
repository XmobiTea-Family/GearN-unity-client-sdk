# DTO Reference: Group

Group metadata, member roster, message stream, group-level currency/inventory/statistics.

Related API reference: [API_GROUP.md](/docs/reference/API_GROUP.md).

Mỗi section bên dưới là 1 class DTO trong namespace `<Models>`. Field table cho biết: tên field, kiểu C# tương ứng, có `required` hay không (suy từ metadata `DataMember` / nullable / optional), doc comment, và ràng buộc length/range/default nếu có.

> **Cách dùng**: khi gọi `*Async()`, bạn truyền instance DTO (`new GroupModels.<Method>RequestData()`) với các field required (+ optional nếu cần). Response class expose `responseData` là instance của class `*ResponseData` tương ứng. Không dùng object literal cast — xem [RULES § 8.1](/docs/RULES.md#81-build-request-dto-trong-code-copy-paste).

> **Naming pattern**: Mỗi method có 3 variant DTO — `XxxRequestData` (client), `ServerXxxRequestData` (server), `AdminXxxRequestData` (admin). Variant `Server`/`Admin` thường thêm field bắt buộc như `userId`/`groupId`. Khi tìm DTO cho một route cụ thể, nhảy thẳng tới section `[Server|Admin]XxxRequestData` tương ứng — không cần đọc cả 3.

## Danh sách

- **GroupModels** (from `Runtime/Entity/Models/GroupModels.cs`)
    - [InfoRequestParam](#inforequestparam)
    - [CustomDataParam](#customdataparam)
    - [GroupCurrencyParam](#groupcurrencyparam)
    - [GroupDataParam](#groupdataparam)
    - [GroupMemberParam](#groupmemberparam)
    - [GroupStatisticsParam](#groupstatisticsparam)
    - [AddMemberRequestData](#addmemberrequestdata)
    - [ServerAddMemberRequestData](#serveraddmemberrequestdata)
    - [AdminAddMemberRequestData](#adminaddmemberrequestdata)
    - [AddSegmentRequestData](#addsegmentrequestdata)
    - [ServerAddSegmentRequestData](#serveraddsegmentrequestdata)
    - [AdminAddSegmentRequestData](#adminaddsegmentrequestdata)
    - [GetAvatarRequestData](#getavatarrequestdata)
    - [ServerGetAvatarRequestData](#servergetavatarrequestdata)
    - [AdminGetAvatarRequestData](#admingetavatarrequestdata)
    - [GetCatalogIdRequestData](#getcatalogidrequestdata)
    - [ServerGetCatalogIdRequestData](#servergetcatalogidrequestdata)
    - [AdminGetCatalogIdRequestData](#admingetcatalogidrequestdata)
    - [GetCustomDataRequestData](#getcustomdatarequestdata)
    - [ServerGetCustomDataRequestData](#servergetcustomdatarequestdata)
    - [AdminGetCustomDataRequestData](#admingetcustomdatarequestdata)
    - [GetDisplayNameRequestData](#getdisplaynamerequestdata)
    - [ServerGetDisplayNameRequestData](#servergetdisplaynamerequestdata)
    - [AdminGetDisplayNameRequestData](#admingetdisplaynamerequestdata)
    - [GetGroupCurrencyRequestData](#getgroupcurrencyrequestdata)
    - [ServerGetGroupCurrencyRequestData](#servergetgroupcurrencyrequestdata)
    - [AdminGetGroupCurrencyRequestData](#admingetgroupcurrencyrequestdata)
    - [GetGroupDataRequestData](#getgroupdatarequestdata)
    - [ServerGetGroupDataRequestData](#servergetgroupdatarequestdata)
    - [AdminGetGroupDataRequestData](#admingetgroupdatarequestdata)
    - [GetGroupInformationRequestData](#getgroupinformationrequestdata)
    - [ServerGetGroupInformationRequestData](#servergetgroupinformationrequestdata)
    - [AdminGetGroupInformationRequestData](#admingetgroupinformationrequestdata)
    - [GetGroupInventoryRequestData](#getgroupinventoryrequestdata)
    - [ServerGetGroupInventoryRequestData](#servergetgroupinventoryrequestdata)
    - [AdminGetGroupInventoryRequestData](#admingetgroupinventoryrequestdata)
    - [GetGroupMessageRequestData](#getgroupmessagerequestdata)
    - [ServerGetGroupMessageRequestData](#servergetgroupmessagerequestdata)
    - [AdminGetGroupMessageRequestData](#admingetgroupmessagerequestdata)
    - [GetGroupStatisticsRequestData](#getgroupstatisticsrequestdata)
    - [ServerGetGroupStatisticsRequestData](#servergetgroupstatisticsrequestdata)
    - [AdminGetGroupStatisticsRequestData](#admingetgroupstatisticsrequestdata)
    - [GetGroupsWithDisplayNameRequestData](#getgroupswithdisplaynamerequestdata)
    - [ServerGetGroupsWithDisplayNameRequestData](#servergetgroupswithdisplaynamerequestdata)
    - [AdminGetGroupsWithDisplayNameRequestData](#admingetgroupswithdisplaynamerequestdata)
    - [GetGroupsWithSegmentRequestData](#getgroupswithsegmentrequestdata)
    - [ServerGetGroupsWithSegmentRequestData](#servergetgroupswithsegmentrequestdata)
    - [AdminGetGroupsWithSegmentRequestData](#admingetgroupswithsegmentrequestdata)
    - [GetGroupsWithTagRequestData](#getgroupswithtagrequestdata)
    - [ServerGetGroupsWithTagRequestData](#servergetgroupswithtagrequestdata)
    - [AdminGetGroupsWithTagRequestData](#admingetgroupswithtagrequestdata)
    - [GetMembersRequestData](#getmembersrequestdata)
    - [ServerGetMembersRequestData](#servergetmembersrequestdata)
    - [AdminGetMembersRequestData](#admingetmembersrequestdata)
    - [GetRemoveStatusRequestData](#getremovestatusrequestdata)
    - [ServerGetRemoveStatusRequestData](#servergetremovestatusrequestdata)
    - [AdminGetRemoveStatusRequestData](#admingetremovestatusrequestdata)
    - [GetSegmentRequestData](#getsegmentrequestdata)
    - [ServerGetSegmentRequestData](#servergetsegmentrequestdata)
    - [AdminGetSegmentRequestData](#admingetsegmentrequestdata)
    - [GetStatisticsLeaderboardAroundGroupRequestData](#getstatisticsleaderboardaroundgrouprequestdata)
    - [ServerGetStatisticsLeaderboardAroundGroupRequestData](#servergetstatisticsleaderboardaroundgrouprequestdata)
    - [AdminGetStatisticsLeaderboardAroundGroupRequestData](#admingetstatisticsleaderboardaroundgrouprequestdata)
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
    - [CreateGroupItemRequestData](#creategroupitemrequestdata)
    - [ServerCreateGroupItemRequestData](#servercreategroupitemrequestdata)
    - [AdminCreateGroupItemRequestData](#admincreategroupitemrequestdata)
    - [RemoveGroupItemRequestData](#removegroupitemrequestdata)
    - [ServerRemoveGroupItemRequestData](#serverremovegroupitemrequestdata)
    - [AdminRemoveGroupItemRequestData](#adminremovegroupitemrequestdata)
    - [RemoveMemberRequestData](#removememberrequestdata)
    - [ServerRemoveMemberRequestData](#serverremovememberrequestdata)
    - [AdminRemoveMemberRequestData](#adminremovememberrequestdata)
    - [RemoveSegmentRequestData](#removesegmentrequestdata)
    - [ServerRemoveSegmentRequestData](#serverremovesegmentrequestdata)
    - [AdminRemoveSegmentRequestData](#adminremovesegmentrequestdata)
    - [RemoveTagRequestData](#removetagrequestdata)
    - [ServerRemoveTagRequestData](#serverremovetagrequestdata)
    - [AdminRemoveTagRequestData](#adminremovetagrequestdata)
    - [SendGroupMessageRequestData](#sendgroupmessagerequestdata)
    - [ServerSendGroupMessageRequestData](#serversendgroupmessagerequestdata)
    - [AdminSendGroupMessageRequestData](#adminsendgroupmessagerequestdata)
    - [SetAvatarRequestData](#setavatarrequestdata)
    - [ServerSetAvatarRequestData](#serversetavatarrequestdata)
    - [AdminSetAvatarRequestData](#adminsetavatarrequestdata)
    - [SetCustomDataRequestData](#setcustomdatarequestdata)
    - [ServerSetCustomDataRequestData](#serversetcustomdatarequestdata)
    - [AdminSetCustomDataRequestData](#adminsetcustomdatarequestdata)
    - [SetDisplayNameRequestData](#setdisplaynamerequestdata)
    - [ServerSetDisplayNameRequestData](#serversetdisplaynamerequestdata)
    - [AdminSetDisplayNameRequestData](#adminsetdisplaynamerequestdata)
    - [ChangeGroupCurrencyRequestData](#changegroupcurrencyrequestdata)
    - [ServerChangeGroupCurrencyRequestData](#serverchangegroupcurrencyrequestdata)
    - [AdminChangeGroupCurrencyRequestData](#adminchangegroupcurrencyrequestdata)
    - [SetGroupDataRequestData](#setgroupdatarequestdata)
    - [ServerSetGroupDataRequestData](#serversetgroupdatarequestdata)
    - [AdminSetGroupDataRequestData](#adminsetgroupdatarequestdata)
    - [ChangeGroupStatisticsRequestData](#changegroupstatisticsrequestdata)
    - [ServerChangeGroupStatisticsRequestData](#serverchangegroupstatisticsrequestdata)
    - [AdminChangeGroupStatisticsRequestData](#adminchangegroupstatisticsrequestdata)
    - [SetRemoveStatusRequestData](#setremovestatusrequestdata)
    - [ServerSetRemoveStatusRequestData](#serversetremovestatusrequestdata)
    - [AdminSetRemoveStatusRequestData](#adminsetremovestatusrequestdata)
    - [SetTagRequestData](#settagrequestdata)
    - [ServerSetTagRequestData](#serversettagrequestdata)
    - [AdminSetTagRequestData](#adminsettagrequestdata)
    - [GetCurrencyLogRequestData](#getcurrencylogrequestdata)
    - [ServerGetCurrencyLogRequestData](#servergetcurrencylogrequestdata)
    - [AdminGetCurrencyLogRequestData](#admingetcurrencylogrequestdata)
    - [GetStatisticsLogRequestData](#getstatisticslogrequestdata)
    - [ServerGetStatisticsLogRequestData](#servergetstatisticslogrequestdata)
    - [AdminGetStatisticsLogRequestData](#admingetstatisticslogrequestdata)
    - [InfoResponseParameters](#inforesponseparameters)
    - [GroupResponseData](#groupresponsedata)
    - [GroupWithGroupIdResponseData](#groupwithgroupidresponsedata)
    - [GroupLeaderboardResponseData](#groupleaderboardresponsedata)
    - [GroupLogResponseData](#grouplogresponsedata)
    - [GetStatisticsLeaderboardResponseData](#getstatisticsleaderboardresponsedata)
    - [GroupsWithGroupIdResponseData](#groupswithgroupidresponsedata)
    - [GroupMessageResponseData](#groupmessageresponsedata)
    - [GroupMessagesResponseData](#groupmessagesresponsedata)
    - [GetCurrencyLeaderboardRequestData](#getcurrencyleaderboardrequestdata)
    - [ServerGetCurrencyLeaderboardRequestData](#servergetcurrencyleaderboardrequestdata)
    - [AdminGetCurrencyLeaderboardRequestData](#admingetcurrencyleaderboardrequestdata)
    - [GetCurrencyLeaderboardResponseData](#getcurrencyleaderboardresponsedata)
    - [GetCreateLeaderboardResponseData](#getcreateleaderboardresponsedata)
    - [GetStatisticsLogResponseData](#getstatisticslogresponsedata)
    - [GetCurrencyLogResponseData](#getcurrencylogresponsedata)
    - [EmptyResponseData](#emptyresponsedata)
- **GroupRequestModels** (from `Runtime/Entity/Models/GroupRequestModels.cs`)
    - [AddMemberOperationRequest](#addmemberoperationrequest)
    - [ServerAddMemberOperationRequest](#serveraddmemberoperationrequest)
    - [AdminAddMemberOperationRequest](#adminaddmemberoperationrequest)
    - [AddSegmentOperationRequest](#addsegmentoperationrequest)
    - [ServerAddSegmentOperationRequest](#serveraddsegmentoperationrequest)
    - [AdminAddSegmentOperationRequest](#adminaddsegmentoperationrequest)
    - [GetAvatarOperationRequest](#getavataroperationrequest)
    - [ServerGetAvatarOperationRequest](#servergetavataroperationrequest)
    - [AdminGetAvatarOperationRequest](#admingetavataroperationrequest)
    - [GetCatalogIdOperationRequest](#getcatalogidoperationrequest)
    - [ServerGetCatalogIdOperationRequest](#servergetcatalogidoperationrequest)
    - [AdminGetCatalogIdOperationRequest](#admingetcatalogidoperationrequest)
    - [GetCustomDataOperationRequest](#getcustomdataoperationrequest)
    - [ServerGetCustomDataOperationRequest](#servergetcustomdataoperationrequest)
    - [AdminGetCustomDataOperationRequest](#admingetcustomdataoperationrequest)
    - [GetDisplayNameOperationRequest](#getdisplaynameoperationrequest)
    - [ServerGetDisplayNameOperationRequest](#servergetdisplaynameoperationrequest)
    - [AdminGetDisplayNameOperationRequest](#admingetdisplaynameoperationrequest)
    - [GetGroupCurrencyOperationRequest](#getgroupcurrencyoperationrequest)
    - [ServerGetGroupCurrencyOperationRequest](#servergetgroupcurrencyoperationrequest)
    - [AdminGetGroupCurrencyOperationRequest](#admingetgroupcurrencyoperationrequest)
    - [GetGroupDataOperationRequest](#getgroupdataoperationrequest)
    - [ServerGetGroupDataOperationRequest](#servergetgroupdataoperationrequest)
    - [AdminGetGroupDataOperationRequest](#admingetgroupdataoperationrequest)
    - [GetGroupInformationOperationRequest](#getgroupinformationoperationrequest)
    - [ServerGetGroupInformationOperationRequest](#servergetgroupinformationoperationrequest)
    - [AdminGetGroupInformationOperationRequest](#admingetgroupinformationoperationrequest)
    - [GetGroupInventoryOperationRequest](#getgroupinventoryoperationrequest)
    - [ServerGetGroupInventoryOperationRequest](#servergetgroupinventoryoperationrequest)
    - [AdminGetGroupInventoryOperationRequest](#admingetgroupinventoryoperationrequest)
    - [GetGroupMessageOperationRequest](#getgroupmessageoperationrequest)
    - [ServerGetGroupMessageOperationRequest](#servergetgroupmessageoperationrequest)
    - [AdminGetGroupMessageOperationRequest](#admingetgroupmessageoperationrequest)
    - [GetGroupStatisticsOperationRequest](#getgroupstatisticsoperationrequest)
    - [ServerGetGroupStatisticsOperationRequest](#servergetgroupstatisticsoperationrequest)
    - [AdminGetGroupStatisticsOperationRequest](#admingetgroupstatisticsoperationrequest)
    - [GetGroupsWithDisplayNameOperationRequest](#getgroupswithdisplaynameoperationrequest)
    - [ServerGetGroupsWithDisplayNameOperationRequest](#servergetgroupswithdisplaynameoperationrequest)
    - [AdminGetGroupsWithDisplayNameOperationRequest](#admingetgroupswithdisplaynameoperationrequest)
    - [GetGroupsWithSegmentOperationRequest](#getgroupswithsegmentoperationrequest)
    - [ServerGetGroupsWithSegmentOperationRequest](#servergetgroupswithsegmentoperationrequest)
    - [AdminGetGroupsWithSegmentOperationRequest](#admingetgroupswithsegmentoperationrequest)
    - [GetGroupsWithTagOperationRequest](#getgroupswithtagoperationrequest)
    - [ServerGetGroupsWithTagOperationRequest](#servergetgroupswithtagoperationrequest)
    - [AdminGetGroupsWithTagOperationRequest](#admingetgroupswithtagoperationrequest)
    - [GetMembersOperationRequest](#getmembersoperationrequest)
    - [ServerGetMembersOperationRequest](#servergetmembersoperationrequest)
    - [AdminGetMembersOperationRequest](#admingetmembersoperationrequest)
    - [GetRemoveStatusOperationRequest](#getremovestatusoperationrequest)
    - [ServerGetRemoveStatusOperationRequest](#servergetremovestatusoperationrequest)
    - [AdminGetRemoveStatusOperationRequest](#admingetremovestatusoperationrequest)
    - [GetSegmentOperationRequest](#getsegmentoperationrequest)
    - [ServerGetSegmentOperationRequest](#servergetsegmentoperationrequest)
    - [AdminGetSegmentOperationRequest](#admingetsegmentoperationrequest)
    - [GetStatisticsLeaderboardAroundGroupOperationRequest](#getstatisticsleaderboardaroundgroupoperationrequest)
    - [ServerGetStatisticsLeaderboardAroundGroupOperationRequest](#servergetstatisticsleaderboardaroundgroupoperationrequest)
    - [AdminGetStatisticsLeaderboardAroundGroupOperationRequest](#admingetstatisticsleaderboardaroundgroupoperationrequest)
    - [GetStatisticsLeaderboardOperationRequest](#getstatisticsleaderboardoperationrequest)
    - [ServerGetStatisticsLeaderboardOperationRequest](#servergetstatisticsleaderboardoperationrequest)
    - [AdminGetStatisticsLeaderboardOperationRequest](#admingetstatisticsleaderboardoperationrequest)
    - [GetTagOperationRequest](#gettagoperationrequest)
    - [ServerGetTagOperationRequest](#servergettagoperationrequest)
    - [AdminGetTagOperationRequest](#admingettagoperationrequest)
    - [GetTsCreateOperationRequest](#gettscreateoperationrequest)
    - [ServerGetTsCreateOperationRequest](#servergettscreateoperationrequest)
    - [AdminGetTsCreateOperationRequest](#admingettscreateoperationrequest)
    - [CreateGroupItemOperationRequest](#creategroupitemoperationrequest)
    - [ServerCreateGroupItemOperationRequest](#servercreategroupitemoperationrequest)
    - [AdminCreateGroupItemOperationRequest](#admincreategroupitemoperationrequest)
    - [RemoveGroupItemOperationRequest](#removegroupitemoperationrequest)
    - [ServerRemoveGroupItemOperationRequest](#serverremovegroupitemoperationrequest)
    - [AdminRemoveGroupItemOperationRequest](#adminremovegroupitemoperationrequest)
    - [RemoveMemberOperationRequest](#removememberoperationrequest)
    - [ServerRemoveMemberOperationRequest](#serverremovememberoperationrequest)
    - [AdminRemoveMemberOperationRequest](#adminremovememberoperationrequest)
    - [RemoveSegmentOperationRequest](#removesegmentoperationrequest)
    - [ServerRemoveSegmentOperationRequest](#serverremovesegmentoperationrequest)
    - [AdminRemoveSegmentOperationRequest](#adminremovesegmentoperationrequest)
    - [RemoveTagOperationRequest](#removetagoperationrequest)
    - [ServerRemoveTagOperationRequest](#serverremovetagoperationrequest)
    - [AdminRemoveTagOperationRequest](#adminremovetagoperationrequest)
    - [SendGroupMessageOperationRequest](#sendgroupmessageoperationrequest)
    - [ServerSendGroupMessageOperationRequest](#serversendgroupmessageoperationrequest)
    - [AdminSendGroupMessageOperationRequest](#adminsendgroupmessageoperationrequest)
    - [SetAvatarOperationRequest](#setavataroperationrequest)
    - [ServerSetAvatarOperationRequest](#serversetavataroperationrequest)
    - [AdminSetAvatarOperationRequest](#adminsetavataroperationrequest)
    - [SetCustomDataOperationRequest](#setcustomdataoperationrequest)
    - [ServerSetCustomDataOperationRequest](#serversetcustomdataoperationrequest)
    - [AdminSetCustomDataOperationRequest](#adminsetcustomdataoperationrequest)
    - [SetDisplayNameOperationRequest](#setdisplaynameoperationrequest)
    - [ServerSetDisplayNameOperationRequest](#serversetdisplaynameoperationrequest)
    - [AdminSetDisplayNameOperationRequest](#adminsetdisplaynameoperationrequest)
    - [ChangeGroupCurrencyOperationRequest](#changegroupcurrencyoperationrequest)
    - [ServerChangeGroupCurrencyOperationRequest](#serverchangegroupcurrencyoperationrequest)
    - [AdminChangeGroupCurrencyOperationRequest](#adminchangegroupcurrencyoperationrequest)
    - [SetGroupDataOperationRequest](#setgroupdataoperationrequest)
    - [ServerSetGroupDataOperationRequest](#serversetgroupdataoperationrequest)
    - [AdminSetGroupDataOperationRequest](#adminsetgroupdataoperationrequest)
    - [ChangeGroupStatisticsOperationRequest](#changegroupstatisticsoperationrequest)
    - [ServerChangeGroupStatisticsOperationRequest](#serverchangegroupstatisticsoperationrequest)
    - [AdminChangeGroupStatisticsOperationRequest](#adminchangegroupstatisticsoperationrequest)
    - [SetRemoveStatusOperationRequest](#setremovestatusoperationrequest)
    - [ServerSetRemoveStatusOperationRequest](#serversetremovestatusoperationrequest)
    - [AdminSetRemoveStatusOperationRequest](#adminsetremovestatusoperationrequest)
    - [SetTagOperationRequest](#settagoperationrequest)
    - [ServerSetTagOperationRequest](#serversettagoperationrequest)
    - [AdminSetTagOperationRequest](#adminsettagoperationrequest)
    - [GetCurrencyLeaderboardOperationRequest](#getcurrencyleaderboardoperationrequest)
    - [ServerGetCurrencyLeaderboardOperationRequest](#servergetcurrencyleaderboardoperationrequest)
    - [AdminGetCurrencyLeaderboardOperationRequest](#admingetcurrencyleaderboardoperationrequest)
    - [GetCreateLeaderboardOperationRequest](#getcreateleaderboardoperationrequest)
    - [ServerGetCreateLeaderboardOperationRequest](#servergetcreateleaderboardoperationrequest)
    - [AdminGetCreateLeaderboardOperationRequest](#admingetcreateleaderboardoperationrequest)
    - [GetStatisticsLogOperationRequest](#getstatisticslogoperationrequest)
    - [ServerGetStatisticsLogOperationRequest](#servergetstatisticslogoperationrequest)
    - [AdminGetStatisticsLogOperationRequest](#admingetstatisticslogoperationrequest)
    - [GetCurrencyLogOperationRequest](#getcurrencylogoperationrequest)
    - [ServerGetCurrencyLogOperationRequest](#servergetcurrencylogoperationrequest)
    - [AdminGetCurrencyLogOperationRequest](#admingetcurrencylogoperationrequest)
- **GroupResponseModels** (from `Runtime/Entity/Models/GroupResponseModels.cs`)
    - [AddMemberOperationResponse](#addmemberoperationresponse)
    - [AddSegmentOperationResponse](#addsegmentoperationresponse)
    - [GetAvatarOperationResponse](#getavataroperationresponse)
    - [GetCatalogIdOperationResponse](#getcatalogidoperationresponse)
    - [GetCustomDataOperationResponse](#getcustomdataoperationresponse)
    - [GetDisplayNameOperationResponse](#getdisplaynameoperationresponse)
    - [GetGroupCurrencyOperationResponse](#getgroupcurrencyoperationresponse)
    - [GetGroupDataOperationResponse](#getgroupdataoperationresponse)
    - [GetGroupInformationOperationResponse](#getgroupinformationoperationresponse)
    - [GetGroupInventoryOperationResponse](#getgroupinventoryoperationresponse)
    - [GetGroupMessageOperationResponse](#getgroupmessageoperationresponse)
    - [GetGroupStatisticsOperationResponse](#getgroupstatisticsoperationresponse)
    - [GetGroupsWithDisplayNameOperationResponse](#getgroupswithdisplaynameoperationresponse)
    - [GetGroupsWithSegmentOperationResponse](#getgroupswithsegmentoperationresponse)
    - [GetGroupsWithTagOperationResponse](#getgroupswithtagoperationresponse)
    - [GetMembersOperationResponse](#getmembersoperationresponse)
    - [GetRemoveStatusOperationResponse](#getremovestatusoperationresponse)
    - [GetSegmentOperationResponse](#getsegmentoperationresponse)
    - [GetStatisticsLeaderboardAroundGroupOperationResponse](#getstatisticsleaderboardaroundgroupoperationresponse)
    - [GetStatisticsLeaderboardOperationResponse](#getstatisticsleaderboardoperationresponse)
    - [GetTagOperationResponse](#gettagoperationresponse)
    - [GetTsCreateOperationResponse](#gettscreateoperationresponse)
    - [CreateGroupItemOperationResponse](#creategroupitemoperationresponse)
    - [RemoveGroupItemOperationResponse](#removegroupitemoperationresponse)
    - [RemoveMemberOperationResponse](#removememberoperationresponse)
    - [RemoveSegmentOperationResponse](#removesegmentoperationresponse)
    - [RemoveTagOperationResponse](#removetagoperationresponse)
    - [SendGroupMessageOperationResponse](#sendgroupmessageoperationresponse)
    - [SetAvatarOperationResponse](#setavataroperationresponse)
    - [SetCustomDataOperationResponse](#setcustomdataoperationresponse)
    - [SetDisplayNameOperationResponse](#setdisplaynameoperationresponse)
    - [ChangeGroupCurrencyOperationResponse](#changegroupcurrencyoperationresponse)
    - [SetGroupDataOperationResponse](#setgroupdataoperationresponse)
    - [ChangeGroupStatisticsOperationResponse](#changegroupstatisticsoperationresponse)
    - [SetRemoveStatusOperationResponse](#setremovestatusoperationresponse)
    - [SetTagOperationResponse](#settagoperationresponse)
    - [GetCurrencyLeaderboardOperationResponse](#getcurrencyleaderboardoperationresponse)
    - [GetCreateLeaderboardOperationResponse](#getcreateleaderboardoperationresponse)
    - [GetStatisticsLogOperationResponse](#getstatisticslogoperationresponse)
    - [GetCurrencyLogOperationResponse](#getcurrencylogoperationresponse)

---

## Namespace `GroupModels`

### InfoRequestParam

Selects which optional group fields and lightweight relations should be returned. Boolean flags default to `false`; key arrays narrow list-style fields to specific keys only.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `catalogId` | `boolean` | no | Includes the group catalog ID. — _default=false_ |
| `members` | `boolean` | no | Includes lightweight member items for the group. — _default=false_ |
| `removeStatus` | `boolean` | no | _default=false_ |
| `segments` | `boolean` | no | _default=false_ |
| `customDatas` | `boolean` | no | _default=false_ |
| `displayName` | `boolean` | no | _default=false_ |
| `avatar` | `boolean` | no | _default=false_ |
| `tsCreate` | `boolean` | no | _default=false_ |
| `tags` | `boolean` | no | _default=false_ |
| `groupCurrencies` | `boolean` | no | _default=false_ |
| `groupStatistics` | `boolean` | no | _default=false_ |
| `groupDatas` | `boolean` | no | _default=false_ |
| `groupInventories` | `boolean` | no | Includes lightweight inventory relation items for the group, optionally filtered by `itemCatalogIds`. — _default=false_ |
| `groupDataKeys` | `Array<string>` | no | _elementCls=String_ |
| `groupCurrencyKeys` | `Array<string>` | no | _elementCls=String_ |
| `groupStatisticsKeys` | `Array<string>` | no | _elementCls=String_ |
| `customDataKeys` | `Array<string>` | no | _elementCls=String_ |
| `tagKeys` | `Array<string>` | no | _elementCls=String_ |
| `itemCatalogIds` | `Array<string>` | no | Restricts `groupInventories` to relation items whose catalog IDs match this list. — _elementCls=String_ |

### CustomDataParam

Defines the reusable parameter block CustomDataParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `any` | yes | Arbitrary value to store for this custom data key. May be a primitive, `GNHashtable`, or `GNArray`. |

### GroupCurrencyParam

Defines the reusable parameter block GroupCurrencyParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `amount` | `number` | yes | Currency amount delta to apply (positive to add, negative to subtract). |

### GroupDataParam

Defines the reusable parameter block GroupDataParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `any` | yes | Arbitrary value to store for this group data key. May be a primitive, `GNHashtable`, or `GNArray`. |

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
| `value` | `number` | yes | Statistic value to apply; interpretation depends on the configured aggregation method. |

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

_Không có field public (payload rỗng)._

### AdminAddMemberRequestData

Extends: `ServerAddMemberRequestData`

Defines the request payload for AdminAddMember.

_Không có field public (payload rỗng)._

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

_Không có field public (payload rỗng)._

### AdminAddSegmentRequestData

Extends: `ServerAddSegmentRequestData`

Defines the request payload for AdminAddSegment.

_Không có field public (payload rỗng)._

### GetAvatarRequestData

Defines the request payload for GetAvatar.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

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
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerGetCatalogIdRequestData

Extends: `GetCatalogIdRequestData`

Defines the request payload for ServerGetCatalogId.

_Không có field public (payload rỗng)._

### AdminGetCatalogIdRequestData

Extends: `ServerGetCatalogIdRequestData`

Defines the request payload for AdminGetCatalogId.

_Không có field public (payload rỗng)._

### GetCustomDataRequestData

Defines the request payload for GetCustomData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `customDataKeys` | `Array<string>` | no | _elementCls=String_ |

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
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerGetDisplayNameRequestData

Extends: `GetDisplayNameRequestData`

Defines the request payload for ServerGetDisplayName.

_Không có field public (payload rỗng)._

### AdminGetDisplayNameRequestData

Extends: `ServerGetDisplayNameRequestData`

Defines the request payload for AdminGetDisplayName.

_Không có field public (payload rỗng)._

### GetGroupCurrencyRequestData

Defines the request payload for GetGroupCurrency.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `groupCurrencyKeys` | `Array<string>` | no | _elementCls=String_ |

### ServerGetGroupCurrencyRequestData

Extends: `GetGroupCurrencyRequestData`

Defines the request payload for ServerGetGroupCurrency.

_Không có field public (payload rỗng)._

### AdminGetGroupCurrencyRequestData

Extends: `ServerGetGroupCurrencyRequestData`

Defines the request payload for AdminGetGroupCurrency.

_Không có field public (payload rỗng)._

### GetGroupDataRequestData

Defines the request payload for GetGroupData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `groupDataKeys` | `Array<string>` | no | _elementCls=String_ |

### ServerGetGroupDataRequestData

Extends: `GetGroupDataRequestData`

Defines the request payload for ServerGetGroupData.

_Không có field public (payload rỗng)._

### AdminGetGroupDataRequestData

Extends: `ServerGetGroupDataRequestData`

Defines the request payload for AdminGetGroupData.

_Không có field public (payload rỗng)._

### GetGroupInformationRequestData

Defines the request payload for GetGroupInformation.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional group fields are included in the response. |

### ServerGetGroupInformationRequestData

Extends: `GetGroupInformationRequestData`

Defines the request payload for ServerGetGroupInformation.

_Không có field public (payload rỗng)._

### AdminGetGroupInformationRequestData

Extends: `ServerGetGroupInformationRequestData`

Defines the request payload for AdminGetGroupInformation.

_Không có field public (payload rỗng)._

### GetGroupInventoryRequestData

Defines the request payload for GetGroupInventory.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `itemCatalogIds` | `Array<string>` | no | _elementCls=String_ |

### ServerGetGroupInventoryRequestData

Extends: `GetGroupInventoryRequestData`

Defines the request payload for ServerGetGroupInventory.

_Không có field public (payload rỗng)._

### AdminGetGroupInventoryRequestData

Extends: `ServerGetGroupInventoryRequestData`

Defines the request payload for AdminGetGroupInventory.

_Không có field public (payload rỗng)._

### GetGroupMessageRequestData

Reads persisted group messages using skip/limit pagination.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `skip` | `number` | no | _min=0, default=0_ |
| `limit` | `number` | no | _min=1, max=100, default=10_ |

### ServerGetGroupMessageRequestData

Extends: `GetGroupMessageRequestData`

Defines the request payload for ServerGetGroupMessage.

_Không có field public (payload rỗng)._

### AdminGetGroupMessageRequestData

Extends: `ServerGetGroupMessageRequestData`

Defines the request payload for AdminGetGroupMessage.

_Không có field public (payload rỗng)._

### GetGroupStatisticsRequestData

Defines the request payload for GetGroupStatistics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `statisticsKeys` | `Array<string>` | no | _elementCls=String_ |

### ServerGetGroupStatisticsRequestData

Extends: `GetGroupStatisticsRequestData`

Defines the request payload for ServerGetGroupStatistics.

_Không có field public (payload rỗng)._

### AdminGetGroupStatisticsRequestData

Extends: `ServerGetGroupStatisticsRequestData`

Defines the request payload for AdminGetGroupStatistics.

_Không có field public (payload rỗng)._

### GetGroupsWithDisplayNameRequestData

Defines the request payload for GetGroupsWithDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keyword` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional group fields are included in the response. |
| `skip` | `number` | no | _min=0, default=0_ |
| `limit` | `number` | no | _min=1, max=100, default=10_ |

### ServerGetGroupsWithDisplayNameRequestData

Extends: `GetGroupsWithDisplayNameRequestData`

Defines the request payload for ServerGetGroupsWithDisplayName.

_Không có field public (payload rỗng)._

### AdminGetGroupsWithDisplayNameRequestData

Extends: `ServerGetGroupsWithDisplayNameRequestData`

Defines the request payload for AdminGetGroupsWithDisplayName.

_Không có field public (payload rỗng)._

### GetGroupsWithSegmentRequestData

Defines the request payload for GetGroupsWithSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional group fields are included in the response. |
| `skip` | `number` | no | _min=0, default=0_ |
| `limit` | `number` | no | _min=1, max=100, default=10_ |

### ServerGetGroupsWithSegmentRequestData

Extends: `GetGroupsWithSegmentRequestData`

Defines the request payload for ServerGetGroupsWithSegment.

_Không có field public (payload rỗng)._

### AdminGetGroupsWithSegmentRequestData

Extends: `ServerGetGroupsWithSegmentRequestData`

Defines the request payload for AdminGetGroupsWithSegment.

_Không có field public (payload rỗng)._

### GetGroupsWithTagRequestData

Defines the request payload for GetGroupsWithTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional group fields are included in the response. |
| `skip` | `number` | no | _min=0, default=0_ |
| `limit` | `number` | no | _min=1, max=100, default=10_ |

### ServerGetGroupsWithTagRequestData

Extends: `GetGroupsWithTagRequestData`

Defines the request payload for ServerGetGroupsWithTag.

_Không có field public (payload rỗng)._

### AdminGetGroupsWithTagRequestData

Extends: `ServerGetGroupsWithTagRequestData`

Defines the request payload for AdminGetGroupsWithTag.

_Không có field public (payload rỗng)._

### GetMembersRequestData

Defines the request payload for GetMembers.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerGetMembersRequestData

Extends: `GetMembersRequestData`

Defines the request payload for ServerGetMembers.

_Không có field public (payload rỗng)._

### AdminGetMembersRequestData

Extends: `ServerGetMembersRequestData`

Defines the request payload for AdminGetMembers.

_Không có field public (payload rỗng)._

### GetRemoveStatusRequestData

Defines the request payload for GetRemoveStatus.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

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
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerGetSegmentRequestData

Extends: `GetSegmentRequestData`

Defines the request payload for ServerGetSegment.

_Không có field public (payload rỗng)._

### AdminGetSegmentRequestData

Extends: `ServerGetSegmentRequestData`

Defines the request payload for AdminGetSegment.

_Không có field public (payload rỗng)._

### GetStatisticsLeaderboardAroundGroupRequestData

Defines the request payload for GetStatisticsLeaderboardAroundGroup.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional group fields are included in the response. |
| `skip` | `number` | no | _min=0, default=0_ |
| `limit` | `number` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `boolean` | no | _default=true_ |
| `catalogId` | `string` | no | _minLength=2, maxLength=32_ |

### ServerGetStatisticsLeaderboardAroundGroupRequestData

Extends: `GetStatisticsLeaderboardAroundGroupRequestData`

Defines the request payload for ServerGetStatisticsLeaderboardAroundGroup.

_Không có field public (payload rỗng)._

### AdminGetStatisticsLeaderboardAroundGroupRequestData

Extends: `ServerGetStatisticsLeaderboardAroundGroupRequestData`

Defines the request payload for AdminGetStatisticsLeaderboardAroundGroup.

_Không có field public (payload rỗng)._

### GetStatisticsLeaderboardRequestData

Defines the request payload for GetStatisticsLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional group fields are included in the response. |
| `skip` | `number` | no | _min=0, default=0_ |
| `limit` | `number` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `boolean` | no | _default=true_ |
| `version` | `string` | no | _minLength=2, maxLength=32_ |
| `catalogId` | `string` | no | _minLength=2, maxLength=32_ |

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
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional group fields are included in the response. |
| `skip` | `number` | no | _min=0, default=0_ |
| `limit` | `number` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `boolean` | no | _default=true_ |

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
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `tagKeys` | `Array<string>` | no | _elementCls=String_ |

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
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerGetTsCreateRequestData

Extends: `GetTsCreateRequestData`

Defines the request payload for ServerGetTsCreate.

_Không có field public (payload rỗng)._

### AdminGetTsCreateRequestData

Extends: `ServerGetTsCreateRequestData`

Defines the request payload for AdminGetTsCreate.

_Không có field public (payload rỗng)._

### CreateGroupItemRequestData

Defines the request payload for CreateGroupItem.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `catalogId` | `string` | yes | _minLength=2, maxLength=32_ |
| `classId` | `string` | yes | _minLength=2, maxLength=32_ |
| `displayName` | `string` | no | _default=""_ |
| `amount` | `number` | no | _default=1_ |

### ServerCreateGroupItemRequestData

Extends: `CreateGroupItemRequestData`

Defines the request payload for ServerCreateGroupItem.

_Không có field public (payload rỗng)._

### AdminCreateGroupItemRequestData

Extends: `ServerCreateGroupItemRequestData`

Defines the request payload for AdminCreateGroupItem.

_Không có field public (payload rỗng)._

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

_Không có field public (payload rỗng)._

### AdminRemoveGroupItemRequestData

Extends: `ServerRemoveGroupItemRequestData`

Defines the request payload for AdminRemoveGroupItem.

_Không có field public (payload rỗng)._

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

_Không có field public (payload rỗng)._

### AdminRemoveMemberRequestData

Extends: `ServerRemoveMemberRequestData`

Defines the request payload for AdminRemoveMember.

_Không có field public (payload rỗng)._

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
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerRemoveTagRequestData

Extends: `RemoveTagRequestData`

Defines the request payload for ServerRemoveTag.

_Không có field public (payload rỗng)._

### AdminRemoveTagRequestData

Extends: `ServerRemoveTagRequestData`

Defines the request payload for AdminRemoveTag.

_Không có field public (payload rỗng)._

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

_Không có field public (payload rỗng)._

### AdminSendGroupMessageRequestData

Extends: `ServerSendGroupMessageRequestData`

Defines the request payload for AdminSendGroupMessage.

_Không có field public (payload rỗng)._

### SetAvatarRequestData

Defines the request payload for SetAvatar.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `type` | `number` | yes | Avatar type identifier. Map with the public avatar type enum. |
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
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `customDatas` | `Array<CustomDataParam>` | yes | _minLength=1, maxLength=32, elementCls=CustomDataParam_ |

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
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `displayName` | `string` | yes | _minLength=5, maxLength=32_ |

### ServerSetDisplayNameRequestData

Extends: `SetDisplayNameRequestData`

Defines the request payload for ServerSetDisplayName.

_Không có field public (payload rỗng)._

### AdminSetDisplayNameRequestData

Extends: `ServerSetDisplayNameRequestData`

Defines the request payload for AdminSetDisplayName.

_Không có field public (payload rỗng)._

### ChangeGroupCurrencyRequestData

Defines the request payload for ChangeGroupCurrency.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `groupCurrencies` | `Array<GroupCurrencyParam>` | yes | _minLength=1, maxLength=32, elementCls=GroupCurrencyParam_ |
| `log` | `string` | no | _minLength=1, maxLength=256_ |

### ServerChangeGroupCurrencyRequestData

Extends: `ChangeGroupCurrencyRequestData`

Defines the request payload for ServerChangeGroupCurrency.

_Không có field public (payload rỗng)._

### AdminChangeGroupCurrencyRequestData

Extends: `ServerChangeGroupCurrencyRequestData`

Defines the request payload for AdminChangeGroupCurrency.

_Không có field public (payload rỗng)._

### SetGroupDataRequestData

Defines the request payload for SetGroupData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `groupDatas` | `Array<GroupDataParam>` | yes | _minLength=1, maxLength=32, elementCls=GroupDataParam_ |

### ServerSetGroupDataRequestData

Extends: `SetGroupDataRequestData`

Defines the request payload for ServerSetGroupData.

_Không có field public (payload rỗng)._

### AdminSetGroupDataRequestData

Extends: `ServerSetGroupDataRequestData`

Defines the request payload for AdminSetGroupData.

_Không có field public (payload rỗng)._

### ChangeGroupStatisticsRequestData

Defines the request payload for ChangeGroupStatistics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `groupStatistics` | `Array<GroupStatisticsParam>` | yes | _minLength=1, maxLength=32, elementCls=GroupStatisticsParam_ |
| `log` | `string` | no | _minLength=1, maxLength=256_ |

### ServerChangeGroupStatisticsRequestData

Extends: `ChangeGroupStatisticsRequestData`

Defines the request payload for ServerChangeGroupStatistics.

_Không có field public (payload rỗng)._

### AdminChangeGroupStatisticsRequestData

Extends: `ServerChangeGroupStatisticsRequestData`

Defines the request payload for AdminChangeGroupStatistics.

_Không có field public (payload rỗng)._

### SetRemoveStatusRequestData

Defines the request payload for SetRemoveStatus.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `reason` | `string` | no | _default=""_ |

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
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
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

### GetCurrencyLogRequestData

Reads currency change logs for one group. Pagination is token-based rather than skip-based.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keys` | `Array<string>` | yes | _minLength=1, maxLength=32, elementCls=String_ |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `limit` | `number` | no | _min=1, max=100, default=10_ |
| `token` | `string` | yes | Continuation token returned by the previous page. — _minLength=24, maxLength=24_ |

### ServerGetCurrencyLogRequestData

Extends: `GetCurrencyLogRequestData`

Defines the request payload for ServerGetCurrencyLog.

_Không có field public (payload rỗng)._

### AdminGetCurrencyLogRequestData

Extends: `ServerGetCurrencyLogRequestData`

Defines the request payload for AdminGetCurrencyLog.

_Không có field public (payload rỗng)._

### GetStatisticsLogRequestData

Reads statistic change logs for one group. Pagination is token-based rather than skip-based.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keys` | `Array<string>` | yes | _minLength=1, maxLength=32, elementCls=String_ |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |
| `limit` | `number` | no | _min=1, max=100, default=10_ |
| `token` | `string` | yes | Continuation token returned by the previous page. — _minLength=24, maxLength=24_ |

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
| `catalogId` | `string` | no | Catalog ID the group belongs to; present when requested. |
| `members` | `Array<GenericModels.MemberItem>` | no | Lightweight member items for the group, not full player snapshots. — _elementCls=GenericModels.MemberItem_ |
| `removeStatus` | `GenericModels.RemoveStatusItem` | no | Soft-remove metadata; present when the group has been marked for removal. |
| `segments` | `Array<string>` | no | Segment names currently assigned to the group. — _elementCls=String_ |
| `customDatas` | `Array<GenericModels.DataItem>` | no | Custom data entries; present when `customDatas` is enabled in `InfoRequestParam`. — _elementCls=GenericModels.DataItem_ |
| `displayName` | `string` | no | Display name of the group; present when requested. |
| `avatar` | `GenericModels.AvatarItem` | no | Avatar descriptor of the group; present when requested. |
| `tsCreate` | `number` | no | Creation timestamp of the group; present when requested. |
| `tags` | `Array<GenericModels.TagItem>` | no | Tag entries assigned to the group. — _elementCls=GenericModels.TagItem_ |
| `groupDatas` | `Array<GenericModels.DataItem>` | no | Group data entries; present when `groupDatas` is enabled. — _elementCls=GenericModels.DataItem_ |
| `groupCurrencies` | `Array<GenericModels.CurrencyItem>` | no | Currency balances of the group; present when `groupCurrencies` is enabled. — _elementCls=GenericModels.CurrencyItem_ |
| `groupStatistics` | `Array<GenericModels.StatisticsItem>` | no | Statistics values of the group; present when `groupStatistics` is enabled. — _elementCls=GenericModels.StatisticsItem_ |
| `groupInventories` | `Array<GenericModels.InventoryItem>` | no | Lightweight inventory relation items owned by the group. — _elementCls=GenericModels.InventoryItem_ |

### GroupResponseData

Base group response envelope.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoResponseParameters` | `InfoResponseParameters` | yes | Optional field bag controlled by the corresponding `InfoRequestParam`. |

### GroupWithGroupIdResponseData

Extends: `GroupResponseData`

Group envelope that also exposes the resolved group ID.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | Group identifier. |

### GroupLeaderboardResponseData

Extends: `GroupWithGroupIdResponseData`

Defines the response payload for GroupLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `position` | `number` | yes | Zero-based leaderboard rank position of this group. |
| `backupValue` | `number` | no | Backup statistic or currency value used as a tiebreaker when present. |

### GroupLogResponseData

Describes one group statistics or currency change log entry.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | Group identifier this log entry belongs to. |
| `tsCreate` | `number` | yes | Timestamp when this log entry was recorded. |
| `log` | `string` | yes | Human-readable log message describing the change. |
| `key` | `string` | yes | Currency or statistics key that was changed. |
| `amount` | `number` | yes | Delta amount applied in this change. |
| `startValue` | `number` | yes | Value before the change was applied. |
| `finalValue` | `number` | yes | Value after the change was applied. |

### GetStatisticsLeaderboardResponseData

Defines the response payload for GetStatisticsLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `Array<GroupLeaderboardResponseData>` | yes | Ordered list of group leaderboard entries. — _elementCls=GroupLeaderboardResponseData_ |
| `tsCreate` | `number` | no | Timestamp when this leaderboard snapshot was last generated; present when available. |

### GroupsWithGroupIdResponseData

Defines the response payload for GroupsWithGroupId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `Array<GroupWithGroupIdResponseData>` | yes | _elementCls=GroupWithGroupIdResponseData_ |

### GroupMessageResponseData

Describes one persisted group-message entry.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `message` | `string` | yes | Message content text. |
| `senderId` | `string` | yes | User or system ID of the sender. |
| `senderType` | `number` | yes | Sender type value defined by backend message semantics. |
| `tsCreate` | `number` | yes | Timestamp when the message was sent. |

### GroupMessagesResponseData

Returns one page of persisted group messages.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupMessages` | `Array<GroupMessageResponseData>` | yes | _elementCls=GroupMessageResponseData_ |

### GetCurrencyLeaderboardRequestData

Defines the request payload for GetCurrencyLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional group fields are included in the response. |
| `skip` | `number` | no | _min=0, default=0_ |
| `limit` | `number` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `boolean` | no | _default=true_ |
| `catalogId` | `string` | no | _minLength=2, maxLength=32_ |

### ServerGetCurrencyLeaderboardRequestData

Extends: `GetCurrencyLeaderboardRequestData`

Defines the request payload for ServerGetCurrencyLeaderboard.

_Không có field public (payload rỗng)._

### AdminGetCurrencyLeaderboardRequestData

Extends: `ServerGetCurrencyLeaderboardRequestData`

Defines the request payload for AdminGetCurrencyLeaderboard.

_Không có field public (payload rỗng)._

### GetCurrencyLeaderboardResponseData

Defines the response payload for GetCurrencyLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `Array<GroupLeaderboardResponseData>` | yes | _elementCls=GroupLeaderboardResponseData_ |

### GetCreateLeaderboardResponseData

Defines the response payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `Array<GroupLeaderboardResponseData>` | yes | _elementCls=GroupLeaderboardResponseData_ |

### GetStatisticsLogResponseData

Returns one page of statistics logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `Array<GroupLogResponseData>` | yes | _elementCls=GroupLogResponseData_ |
| `token` | `string` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

### GetCurrencyLogResponseData

Returns one page of currency logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `Array<GroupLogResponseData>` | yes | _elementCls=GroupLogResponseData_ |
| `token` | `string` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

### EmptyResponseData

Defines an intentionally empty response payload.

_Không có field public (payload rỗng)._

## Namespace `GroupRequestModels`

### AddMemberOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.AddMemberRequestData>`

Maps the AddMember operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerAddMemberOperationRequest

Extends: `AddMemberOperationRequest`

Maps the ServerAddMember operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminAddMemberOperationRequest

Extends: `AddMemberOperationRequest`

Maps the AdminAddMember operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AddSegmentOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.AddSegmentRequestData>`

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

### GetAvatarOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetAvatarRequestData>`

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

Extends: `CustomOperationRequestAbstract<GroupModels.GetCatalogIdRequestData>`

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

### GetCustomDataOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetCustomDataRequestData>`

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

Extends: `CustomOperationRequestAbstract<GroupModels.GetDisplayNameRequestData>`

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

### GetGroupCurrencyOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetGroupCurrencyRequestData>`

Maps the GetGroupCurrency operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetGroupCurrencyOperationRequest

Extends: `GetGroupCurrencyOperationRequest`

Maps the ServerGetGroupCurrency operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetGroupCurrencyOperationRequest

Extends: `GetGroupCurrencyOperationRequest`

Maps the AdminGetGroupCurrency operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetGroupDataOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetGroupDataRequestData>`

Maps the GetGroupData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetGroupDataOperationRequest

Extends: `GetGroupDataOperationRequest`

Maps the ServerGetGroupData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetGroupDataOperationRequest

Extends: `GetGroupDataOperationRequest`

Maps the AdminGetGroupData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetGroupInformationOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetGroupInformationRequestData>`

Maps the GetGroupInformation operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetGroupInformationOperationRequest

Extends: `GetGroupInformationOperationRequest`

Maps the ServerGetGroupInformation operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetGroupInformationOperationRequest

Extends: `GetGroupInformationOperationRequest`

Maps the AdminGetGroupInformation operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetGroupInventoryOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetGroupInventoryRequestData>`

Maps the GetGroupInventory operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetGroupInventoryOperationRequest

Extends: `GetGroupInventoryOperationRequest`

Maps the ServerGetGroupInventory operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetGroupInventoryOperationRequest

Extends: `GetGroupInventoryOperationRequest`

Maps the AdminGetGroupInventory operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetGroupMessageOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetGroupMessageRequestData>`

Maps the GetGroupMessage operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetGroupMessageOperationRequest

Extends: `GetGroupMessageOperationRequest`

Maps the ServerGetGroupMessage operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetGroupMessageOperationRequest

Extends: `GetGroupMessageOperationRequest`

Maps the AdminGetGroupMessage operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetGroupStatisticsOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetGroupStatisticsRequestData>`

Maps the GetGroupStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetGroupStatisticsOperationRequest

Extends: `GetGroupStatisticsOperationRequest`

Maps the ServerGetGroupStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetGroupStatisticsOperationRequest

Extends: `GetGroupStatisticsOperationRequest`

Maps the AdminGetGroupStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetGroupsWithDisplayNameOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetGroupsWithDisplayNameRequestData>`

Maps the GetGroupsWithDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetGroupsWithDisplayNameOperationRequest

Extends: `GetGroupsWithDisplayNameOperationRequest`

Maps the ServerGetGroupsWithDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetGroupsWithDisplayNameOperationRequest

Extends: `GetGroupsWithDisplayNameOperationRequest`

Maps the AdminGetGroupsWithDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetGroupsWithSegmentOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetGroupsWithSegmentRequestData>`

Maps the GetGroupsWithSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetGroupsWithSegmentOperationRequest

Extends: `GetGroupsWithSegmentOperationRequest`

Maps the ServerGetGroupsWithSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetGroupsWithSegmentOperationRequest

Extends: `GetGroupsWithSegmentOperationRequest`

Maps the AdminGetGroupsWithSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetGroupsWithTagOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetGroupsWithTagRequestData>`

Maps the GetGroupsWithTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetGroupsWithTagOperationRequest

Extends: `GetGroupsWithTagOperationRequest`

Maps the ServerGetGroupsWithTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetGroupsWithTagOperationRequest

Extends: `GetGroupsWithTagOperationRequest`

Maps the AdminGetGroupsWithTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetMembersOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetMembersRequestData>`

Maps the GetMembers operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetMembersOperationRequest

Extends: `GetMembersOperationRequest`

Maps the ServerGetMembers operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetMembersOperationRequest

Extends: `GetMembersOperationRequest`

Maps the AdminGetMembers operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetRemoveStatusOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetRemoveStatusRequestData>`

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

Extends: `CustomOperationRequestAbstract<GroupModels.GetSegmentRequestData>`

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

### GetStatisticsLeaderboardAroundGroupOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetStatisticsLeaderboardAroundGroupRequestData>`

Maps the GetStatisticsLeaderboardAroundGroup operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetStatisticsLeaderboardAroundGroupOperationRequest

Extends: `GetStatisticsLeaderboardAroundGroupOperationRequest`

Maps the ServerGetStatisticsLeaderboardAroundGroup operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetStatisticsLeaderboardAroundGroupOperationRequest

Extends: `GetStatisticsLeaderboardAroundGroupOperationRequest`

Maps the AdminGetStatisticsLeaderboardAroundGroup operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLeaderboardOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetStatisticsLeaderboardRequestData>`

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

Extends: `CustomOperationRequestAbstract<GroupModels.GetTagRequestData>`

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

Extends: `CustomOperationRequestAbstract<GroupModels.GetTsCreateRequestData>`

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

### CreateGroupItemOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.CreateGroupItemRequestData>`

Maps the CreateGroupItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerCreateGroupItemOperationRequest

Extends: `CreateGroupItemOperationRequest`

Maps the ServerCreateGroupItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminCreateGroupItemOperationRequest

Extends: `CreateGroupItemOperationRequest`

Maps the AdminCreateGroupItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### RemoveGroupItemOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.RemoveGroupItemRequestData>`

Maps the RemoveGroupItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerRemoveGroupItemOperationRequest

Extends: `RemoveGroupItemOperationRequest`

Maps the ServerRemoveGroupItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminRemoveGroupItemOperationRequest

Extends: `RemoveGroupItemOperationRequest`

Maps the AdminRemoveGroupItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### RemoveMemberOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.RemoveMemberRequestData>`

Maps the RemoveMember operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerRemoveMemberOperationRequest

Extends: `RemoveMemberOperationRequest`

Maps the ServerRemoveMember operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminRemoveMemberOperationRequest

Extends: `RemoveMemberOperationRequest`

Maps the AdminRemoveMember operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### RemoveSegmentOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.RemoveSegmentRequestData>`

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

Extends: `CustomOperationRequestAbstract<GroupModels.RemoveTagRequestData>`

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

### SendGroupMessageOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.SendGroupMessageRequestData>`

Maps the SendGroupMessage operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSendGroupMessageOperationRequest

Extends: `SendGroupMessageOperationRequest`

Maps the ServerSendGroupMessage operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSendGroupMessageOperationRequest

Extends: `SendGroupMessageOperationRequest`

Maps the AdminSendGroupMessage operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetAvatarOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.SetAvatarRequestData>`

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

Extends: `CustomOperationRequestAbstract<GroupModels.SetCustomDataRequestData>`

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

Extends: `CustomOperationRequestAbstract<GroupModels.SetDisplayNameRequestData>`

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

### ChangeGroupCurrencyOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.ChangeGroupCurrencyRequestData>`

Maps the ChangeGroupCurrency operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerChangeGroupCurrencyOperationRequest

Extends: `ChangeGroupCurrencyOperationRequest`

Maps the ServerChangeGroupCurrency operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminChangeGroupCurrencyOperationRequest

Extends: `ChangeGroupCurrencyOperationRequest`

Maps the AdminChangeGroupCurrency operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetGroupDataOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.SetGroupDataRequestData>`

Maps the SetGroupData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetGroupDataOperationRequest

Extends: `SetGroupDataOperationRequest`

Maps the ServerSetGroupData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetGroupDataOperationRequest

Extends: `SetGroupDataOperationRequest`

Maps the AdminSetGroupData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ChangeGroupStatisticsOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.ChangeGroupStatisticsRequestData>`

Maps the ChangeGroupStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerChangeGroupStatisticsOperationRequest

Extends: `ChangeGroupStatisticsOperationRequest`

Maps the ServerChangeGroupStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminChangeGroupStatisticsOperationRequest

Extends: `ChangeGroupStatisticsOperationRequest`

Maps the AdminChangeGroupStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetRemoveStatusOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.SetRemoveStatusRequestData>`

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

Extends: `CustomOperationRequestAbstract<GroupModels.SetTagRequestData>`

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

### GetCurrencyLeaderboardOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetCurrencyLeaderboardRequestData>`

Maps the GetCurrencyLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetCurrencyLeaderboardOperationRequest

Extends: `GetCurrencyLeaderboardOperationRequest`

Maps the ServerGetCurrencyLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetCurrencyLeaderboardOperationRequest

Extends: `GetCurrencyLeaderboardOperationRequest`

Maps the AdminGetCurrencyLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetCreateLeaderboardOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetCreateLeaderboardRequestData>`

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

Extends: `CustomOperationRequestAbstract<GroupModels.GetStatisticsLogRequestData>`

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

### GetCurrencyLogOperationRequest

Extends: `CustomOperationRequestAbstract<GroupModels.GetCurrencyLogRequestData>`

Maps the GetCurrencyLog operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetCurrencyLogOperationRequest

Extends: `GetCurrencyLogOperationRequest`

Maps the ServerGetCurrencyLog operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetCurrencyLogOperationRequest

Extends: `GetCurrencyLogOperationRequest`

Maps the AdminGetCurrencyLog operation to a typed request wrapper.

_Không có field public (payload rỗng)._

## Namespace `GroupResponseModels`

### AddMemberOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.EmptyResponseData>`

Maps the AddMember operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### AddSegmentOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.EmptyResponseData>`

Maps the AddSegment operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetAvatarOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the GetAvatar operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCatalogIdOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the GetCatalogId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCustomDataOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the GetCustomData operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetDisplayNameOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the GetDisplayName operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetGroupCurrencyOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the GetGroupCurrency operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetGroupDataOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the GetGroupData operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetGroupInformationOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the GetGroupInformation operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetGroupInventoryOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the GetGroupInventory operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetGroupMessageOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupMessagesResponseData>`

Maps the GetGroupMessage operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetGroupStatisticsOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the GetGroupStatistics operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetGroupsWithDisplayNameOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupsWithGroupIdResponseData>`

Maps the GetGroupsWithDisplayName operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetGroupsWithSegmentOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupsWithGroupIdResponseData>`

Maps the GetGroupsWithSegment operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetGroupsWithTagOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupsWithGroupIdResponseData>`

Maps the GetGroupsWithTag operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetMembersOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the GetMembers operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetRemoveStatusOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the GetRemoveStatus operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetSegmentOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the GetSegment operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLeaderboardAroundGroupOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GetStatisticsLeaderboardResponseData>`

Maps the GetStatisticsLeaderboardAroundGroup operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLeaderboardOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GetStatisticsLeaderboardResponseData>`

Maps the GetStatisticsLeaderboard operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetTagOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the GetTag operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetTsCreateOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the GetTsCreate operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### CreateGroupItemOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the CreateGroupItem operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RemoveGroupItemOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.EmptyResponseData>`

Maps the RemoveGroupItem operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RemoveMemberOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.EmptyResponseData>`

Maps the RemoveMember operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RemoveSegmentOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.EmptyResponseData>`

Maps the RemoveSegment operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RemoveTagOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.EmptyResponseData>`

Maps the RemoveTag operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SendGroupMessageOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupMessagesResponseData>`

Maps the SendGroupMessage operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetAvatarOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.EmptyResponseData>`

Maps the SetAvatar operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetCustomDataOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the SetCustomData operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetDisplayNameOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.EmptyResponseData>`

Maps the SetDisplayName operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### ChangeGroupCurrencyOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the ChangeGroupCurrency operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetGroupDataOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the SetGroupData operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### ChangeGroupStatisticsOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GroupResponseData>`

Maps the ChangeGroupStatistics operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetRemoveStatusOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.EmptyResponseData>`

Maps the SetRemoveStatus operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetTagOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.EmptyResponseData>`

Maps the SetTag operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCurrencyLeaderboardOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GetCurrencyLeaderboardResponseData>`

Maps the GetCurrencyLeaderboard operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCreateLeaderboardOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GetCreateLeaderboardResponseData>`

Maps the GetCreateLeaderboard operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLogOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GetStatisticsLogResponseData>`

Maps the GetStatisticsLog operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCurrencyLogOperationResponse

Extends: `CustomOperationResponseAbstract<GroupModels.GetCurrencyLogResponseData>`

Maps the GetCurrencyLog operation to a typed response wrapper.

_Không có field public (payload rỗng)._
