# GroupApi

Tài liệu này dành cho AI code assistant và AI agent nội bộ. Mục tiêu là chọn đúng namespace `client/server/admin`, phân biệt đúng operation HTTP với event socket, và không sinh sai flow ở các nhóm member, message, currency, statistics, inventory và `infoRequestParam`.

## 1. Scope

- Áp dụng cho:
    - `GNNetwork.group`
    - `GNNetwork.group.server`
    - `GNNetwork.group.admin`
- Toàn bộ method hiện tại của `GroupApi` đều gửi qua HTTP.
- `GroupApi` có đủ 3 role thật:
    - `GNNetwork.group` -> `RequestRole.Client`
    - `GNNetwork.group.server` -> `RequestRole.Server`
    - `GNNetwork.group.admin` -> `RequestRole.Admin`
- Nếu không truyền `overrideSecretKey`, SDK sẽ tự lấy secret key theo role tương ứng.
- Chỉ dùng namespace `.server` khi bạn đã cấu hình `secretKey` với `permission rules` `server` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Chỉ dùng namespace `.admin` khi bạn đã cấu hình `secretKey` với `permission rules` `admin` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Rule chuẩn để chọn `client/server/admin` và hiểu `self/other-self` xem [RULES](/docs/RULES.md#3-route--trust-boundary-của-caller). Không tự suy diễn route chỉ từ target ownership.
- `GroupApi` thao tác trên group đã tồn tại. Không có public operation `createGroup`, `joinGroup`, `leaveGroup`, `removeGroup` trong nhóm này.
- Realtime update của group là luồng riêng qua socket event, không phải transport của các method `GroupApi`.

## 2. Hard Rules

- Luôn ưu tiên `async/await`. Mặc định dùng `*Async()`.
- Bắt buộc đã `Resources/GNServerSettings` trước khi gọi.
- Chọn namespace theo trust boundary:
    - app/player -> `GNNetwork.group`
    - trusted backend/service -> `GNNetwork.group.server`
    - dashboard/ops/tooling -> `GNNetwork.group.admin`
- Không được gọi `GroupApi` để tạo group hoặc join/leave group. Các flow đó nằm ở API player khác.
- Toàn bộ operation trong `GroupApi` hiện đi qua HTTP, kể cả `sendGroupMessageAsync`.
- Realtime update group tuân theo [rule socket chuẩn trong RULES](/docs/RULES.md#7-auth--socket-flow).
- `getGroupInformationAsync`, `getGroupsWithDisplayNameAsync`, `getGroupsWithSegmentAsync`, `getGroupsWithTagAsync`, `getStatisticsLeaderboardAroundGroupAsync`, `getStatisticsLeaderboardAsync`, `getCurrencyLeaderboardAsync` và `getCreateLeaderboardAsync` đều bắt buộc có `infoRequestParam`.
- `getGroupStatisticsAsync` dùng `statisticsKeys`, còn `infoRequestParam` dùng `groupStatisticsKeys`. Không được dùng lẫn hai field này.
- `getGroupDataAsync` dùng `groupDataKeys`, `getGroupCurrencyAsync` dùng `groupCurrencyKeys`, `getGroupInventoryAsync` dùng `itemCatalogIds`.
- `getGroupMessageAsync` dùng `skip/limit`. `getCurrencyLogAsync` và `getStatisticsLogAsync` dùng `token`.
- `sendGroupMessageAsync` bắt buộc có `senderId`. SDK không tự suy ra field này từ auth state.
- `changeGroupCurrencyAsync` và `changeGroupStatisticsAsync` là delta change theo key, không phải set tuyệt đối.
- `createGroupItemAsync` tạo item thuộc group, nhưng response hiện không expose `itemId` mới tạo.
- `setAvatarAsync`, `GroupMessageResponseData.senderType` và `MemberItem.status` hiện là số thô; package không export enum public tương ứng để map an toàn.

## 3. HTTP Và Socket

Rule cứng:

- Nếu cần đọc/ghi dữ liệu group: dùng `GNNetwork.group*` qua HTTP.
- Nếu cần realtime member/message update: dùng event handler qua socket.
- Không được giả định gọi `sendGroupMessageAsync` là đủ để nhận push message realtime.
- Không được giả định socket event có đầy đủ dữ liệu như HTTP response.

Event handler public: xem [reference/EVENTS.md](/docs/reference/EVENTS.md#ongroupmessageupdateeventhandler) và [reference/EVENTS.md](/docs/reference/EVENTS.md#ongroupmemberupdateeventhandler).

Realtime rule:

- `OnGroupMessageUpdateEventHandler.onUpdate`:
    - payload có `groupId`
    - có `groupMessages`
    - có thể có `characterId` nếu người gửi là CharacterPlayer
- `OnGroupMemberUpdateEventHandler.onUpdate`:
    - payload có `groupId`
    - payload có `members`

## 4. Chọn Namespace

<!-- prettier-ignore -->
| Namespace | Role thật | Dùng khi nào |
| --- | --- | --- |
| `GNNetwork.group` | `Client` | player app thao tác với group thuộc session hiện tại |
| `GNNetwork.group.server` | `Server` | trusted backend, game server, worker xử lý group |
| `GNNetwork.group.admin` | `Admin` | GM tool, dashboard, migration, vận hành dữ liệu group |

Rule nhanh:

- Nếu logic chạy trong client app: ưu tiên `GNNetwork.group`.
- Nếu logic chạy trong backend tin cậy: ưu tiên `GNNetwork.group.server`.
- Nếu thao tác quản trị hoặc vận hành dữ liệu: ưu tiên `GNNetwork.group.admin`.

## 5. Chọn Method

### Đọc 1 group hoặc 1 phần dữ liệu group

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `getAvatarAsync` | Cần đọc avatar group | `groupId` | `GroupResponseData` | `avatar.type` hiện là số thô | `Ok`, `GroupNotFound` |
| `getCatalogIdAsync` | Cần đọc `catalogId` | `groupId` | `GroupResponseData` | Kết quả ở `infoResponseParameters.catalogId` | `Ok`, `GroupNotFound` |
| `getCustomDataAsync` | Cần đọc custom data | `groupId`, `customDataKeys?` | `GroupResponseData` | Có thể filter theo key | `Ok`, `GroupNotFound` |
| `getDisplayNameAsync` | Cần đọc display name | `groupId` | `GroupResponseData` | Kết quả ở `infoResponseParameters.displayName` | `Ok`, `GroupNotFound` |
| `getGroupCurrencyAsync` | Cần đọc group currencies | `groupId`, `groupCurrencyKeys?` | `GroupResponseData` | Có thể filter theo key | `Ok`, `GroupNotFound` |
| `getGroupDataAsync` | Cần đọc group data | `groupId`, `groupDataKeys?` | `GroupResponseData` | Có thể filter theo key | `Ok`, `GroupNotFound` |
| `getGroupInformationAsync` | Cần lấy nhiều field group trong một lần gọi | `groupId`, `infoRequestParam` | `GroupResponseData` | Flow đọc tổng hợp quan trọng nhất | `Ok`, `GroupNotFound` |
| `getGroupInventoryAsync` | Cần đọc inventory của group | `groupId`, `itemCatalogIds?` | `GroupResponseData` | Không dùng `infoRequestParam` | `Ok`, `GroupNotFound` |
| `getGroupStatisticsAsync` | Cần đọc group statistics theo key | `groupId`, `statisticsKeys?` | `GroupResponseData` | Không dùng `groupStatisticsKeys` ở đây | `Ok`, `GroupNotFound` |
| `getMembersAsync` | Cần đọc danh sách member | `groupId` | `GroupResponseData` | Kết quả ở `infoResponseParameters.members` | `Ok`, `GroupNotFound` |
| `getRemoveStatusAsync` | Cần đọc trạng thái remove | `groupId` | `GroupResponseData` | Kết quả ở `infoResponseParameters.removeStatus` | `Ok`, `GroupNotFound` |
| `getSegmentAsync` | Cần đọc segment của group | `groupId` | `GroupResponseData` | Kết quả ở `infoResponseParameters.segments` | `Ok`, `GroupNotFound` |
| `getTagAsync` | Cần đọc tag theo key | `groupId`, `tagKeys` | `GroupResponseData` | Không query theo value | `Ok`, `GroupNotFound` |
| `getTsCreateAsync` | Cần đọc thời điểm tạo group | `groupId` | `GroupResponseData` | Kết quả ở `infoResponseParameters.tsCreate` | `Ok`, `GroupNotFound` |

### Query danh sách, leaderboard, log và message history

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `getGroupsWithDisplayNameAsync` | Tìm group theo tên hiển thị | `keyword`, `infoRequestParam`, `skip?`, `limit?` | `GroupsWithGroupIdResponseData` | `keyword` tối thiểu 2 ký tự | `Ok` |
| `getGroupsWithSegmentAsync` | Tìm group theo segment | `value`, `infoRequestParam`, `skip?`, `limit?` | `GroupsWithGroupIdResponseData` | Query theo exact segment value | `Ok` |
| `getGroupsWithTagAsync` | Tìm group theo tag | `key`, `value`, `infoRequestParam`, `skip?`, `limit?` | `GroupsWithGroupIdResponseData` | Query theo cặp `key/value` | `Ok`, `KeyNotFound` |
| `getStatisticsLeaderboardAroundGroupAsync` | Cần bảng xếp hạng quanh một group cụ thể | `groupId`, `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `catalogId?` | `GetStatisticsLeaderboardResponseData` | Leaderboard theo statistics key | `Ok`, `KeyNotFound` |
| `getStatisticsLeaderboardAsync` | Cần bảng xếp hạng statistics toàn cục theo key | `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `version?`, `catalogId?` | `GetStatisticsLeaderboardResponseData` | `version` chỉ có ở method này | `Ok`, `KeyNotFound`, `VersionInvalid` |
| `getCurrencyLeaderboardAsync` | Cần bảng xếp hạng currency theo key | `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `catalogId?` | `GetCurrencyLeaderboardResponseData` | Không có `version` | `Ok`, `KeyNotFound` |
| `getCreateLeaderboardAsync` | Cần bảng xếp hạng theo thời điểm tạo group | `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetCreateLeaderboardResponseData` | Không cần key | `Ok` |
| `getStatisticsLogAsync` | Cần audit statistics log | `keys?`, `groupId?`, `limit?`, `token?` | `GetStatisticsLogResponseData` | Phân trang bằng `token` | `Ok` |
| `getCurrencyLogAsync` | Cần audit currency log | `keys?`, `groupId?`, `limit?`, `token?` | `GetCurrencyLogResponseData` | Phân trang bằng `token` | `Ok` |
| `getGroupMessageAsync` | Cần đọc lịch sử message | `groupId`, `skip?`, `limit?` | `GroupMessagesResponseData` | Phân trang bằng `skip/limit`, không phải `token` | `Ok`, `GroupNotFound`, `PlayerNotMember` |

### Mutation

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `addMemberAsync` | Thêm một user vào group | `userId`, `groupId` | `EmptyResponseData` | Chỉ thêm 1 member mỗi lần | `Ok`, `GroupNotFound`, `MemberNotFound` |
| `removeMemberAsync` | Gỡ một user khỏi group | `userId`, `groupId` | `EmptyResponseData` | Không phải bulk remove | `Ok`, `GroupNotFound`, `MemberNotFound` |
| `addSegmentAsync` | Gắn thêm segment cho group | `groupId`, `value` | `EmptyResponseData` | Thêm một segment value | `Ok`, `GroupNotFound` |
| `removeSegmentAsync` | Gỡ một segment khỏi group | `groupId`, `value` | `EmptyResponseData` | Xóa theo exact value | `Ok`, `GroupNotFound` |
| `setTagAsync` | Set hoặc upsert một tag | `groupId`, `key`, `value` | `EmptyResponseData` | Thao tác theo một cặp key/value | `Ok`, `KeyNotFound`, `GroupNotFound` |
| `removeTagAsync` | Xóa tag theo key | `groupId`, `key` | `EmptyResponseData` | Không truyền `value` | `Ok`, `GroupNotFound` |
| `setAvatarAsync` | Set avatar của group | `groupId`, `type`, `value` | `EmptyResponseData` | `type` chưa có enum public | `Ok`, `GroupNotFound` |
| `setCustomDataAsync` | Set custom data của group | `groupId`, `customDatas[]` | `GroupResponseData` | Mỗi phần tử là `key/value` | `Ok`, `KeyNotFound`, `GroupNotFound` |
| `setDisplayNameAsync` | Set display name | `groupId`, `displayName` | `EmptyResponseData` | Display name có min length 5 | `Ok`, `GroupNotFound` |
| `setGroupDataAsync` | Set group data của group | `groupId`, `groupDatas[]` | `GroupResponseData` | Mỗi phần tử là `key/value` | `Ok`, `KeyNotFound`, `GroupNotFound` |
| `changeGroupCurrencyAsync` | Cộng/trừ currency | `groupId`, `groupCurrencies[]`, `log?` | `GroupResponseData` | Đây là delta change | `Ok`, `NotEnoughCurrency`, `KeyNotFound`, `GroupNotFound` |
| `changeGroupStatisticsAsync` | Cộng/trừ statistics | `groupId`, `groupStatistics[]`, `log?` | `GroupResponseData` | Đây là delta change | `Ok`, `KeyNotFound`, `GroupNotFound` |
| `setRemoveStatusAsync` | Đánh dấu group bị remove | `groupId`, `reason?` | `EmptyResponseData` | Không phải hard delete | `Ok`, `GroupNotFound` |
| `createGroupItemAsync` | Tạo inventory item thuộc group | `groupId`, `catalogId`, `classId`, `displayName?`, `amount?` | `GroupResponseData` | `amount` mặc định `1` | `Ok`, `CatalogIdNotFound`, `GroupNotFound`, `ClassIdNotFound` |
| `removeGroupItemAsync` | Xóa item khỏi group theo `itemId` | `groupId`, `itemId` | `EmptyResponseData` | Dùng khi đã có `itemId` cụ thể | `Ok`, `ItemNotFound`, `GroupNotFound` |
| `sendGroupMessageAsync` | Gửi message vào group | `senderId`, `groupId`, `message` | `GroupMessagesResponseData` | Operation là HTTP, không phải socket send | `Ok`, `GroupNotFound`, `PlayerNotMember` |

## 6. Reference

- DTO fields: [reference/dto/GROUP.md](/docs/reference/dto/GROUP.md). Method table: [reference/API_GROUP.md](/docs/reference/API_GROUP.md).
- Events: [reference/EVENTS.md](/docs/reference/EVENTS.md#ongroupmemberupdateeventhandler).
- Enums: [GroupStatus](/docs/reference/ENUMS.md#groupstatus).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/Group*.cs`, `Runtime/Entity/Models/GenericModels.cs`.
- Lưu ý:
    - `GroupStatus` là enum publish có thật, nhưng `MemberItem.status` trong `GroupApi` không được ràng buộc bằng enum public riêng.
    - `senderType`, `avatar.type` và `MemberItem.status` hiện vẫn là số thô trong public surface.

## 7. InfoRequestParam Rules

`GroupModels.InfoRequestParam` điều khiển payload trả về trong:

- `getGroupInformationAsync`
- `getGroupsWithDisplayNameAsync`
- `getGroupsWithSegmentAsync`
- `getGroupsWithTagAsync`
- `getStatisticsLeaderboardAroundGroupAsync`
- `getStatisticsLeaderboardAsync`
- `getCurrencyLeaderboardAsync`
- `getCreateLeaderboardAsync`

Rule cứng:

- Không truyền `null`.
- Không bật toàn bộ field một cách mù quáng.
- Chỉ bật field mà flow hiện tại thật sự cần.
- Nếu cần filter dữ liệu con, dùng đúng field filter:
    - `groupDataKeys`
    - `groupCurrencyKeys`
    - `groupStatisticsKeys`
    - `customDataKeys`
    - `tagKeys`
    - `itemCatalogIds`
- Nếu chỉ cần một mảng con riêng lẻ như members, group data, group currency, group statistics hoặc group inventory, ưu tiên getter chuyên biệt thay vì `getGroupInformationAsync`.

Các field thường dùng:

- `catalogId`
- `members`
- `removeStatus`
- `segments`
- `customDatas`
- `displayName`
- `avatar`
- `tsCreate`
- `tags`
- `groupCurrencies`
- `groupStatistics`
- `groupDatas`
- `groupInventories`

## 8. Decision Rules

- Cần đọc đúng một field nhỏ của group: ưu tiên getter chuyên biệt.
- Cần lấy nhiều field group trong một lần gọi: dùng `getGroupInformationAsync`.
- Cần search group theo tên: dùng `getGroupsWithDisplayNameAsync`.
- Cần search group theo segment: dùng `getGroupsWithSegmentAsync`.
- Cần search group theo tag: dùng `getGroupsWithTagAsync`.
- Cần đọc member list: dùng `getMembersAsync`.
- Cần đọc history message: dùng `getGroupMessageAsync`.
- Cần gửi message: dùng `sendGroupMessageAsync`.
- Cần realtime chat/member update: dùng socket event handler, không dùng polling giả làm realtime.
- Cần cộng/trừ currency: dùng `changeGroupCurrencyAsync`.
- Cần cộng/trừ statistics: dùng `changeGroupStatisticsAsync`.
- Cần tạo item thuộc group: dùng `createGroupItemAsync`.
- Cần audit currency/statistics: dùng `getCurrencyLogAsync` hoặc `getStatisticsLogAsync`.

## 9. Response Rules

Tất cả typed response của `GroupApi` đều có:

- `returnCode`
- `debugMessage`
- `invalidMembers`
- `errorCode`
- `responseData`

Rule kiểm tra response:

```csharp
if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}
```

Những response chính AI cần nhớ:

- Hầu hết getter đơn lẻ trả `GroupResponseData` và dữ liệu nằm trong `responseData.infoResponseParameters`.
- Các method list `getGroupsWith*Async` trả `responseData.results`, mỗi phần tử có `groupId` và `infoResponseParameters`.
- `getStatisticsLeaderboardAroundGroupAsync` và `getStatisticsLeaderboardAsync` trả `responseData.results` có `groupId`, `position`, `backupValue?`, `infoResponseParameters`.
- `getCurrencyLeaderboardAsync` và `getCreateLeaderboardAsync` trả `responseData.results`.
- `getCurrencyLogAsync` và `getStatisticsLogAsync` trả `responseData.results` và có thể có `responseData.token`.
- `getGroupMessageAsync` và `sendGroupMessageAsync` trả `responseData.groupMessages`, không phải `results`.
- `addMemberAsync`, `addSegmentAsync`, `removeMemberAsync`, `removeSegmentAsync`, `removeTagAsync`, `setAvatarAsync`, `setDisplayNameAsync`, `setRemoveStatusAsync`, `setTagAsync`, `removeGroupItemAsync` trả `EmptyResponseData`.
- `setCustomDataAsync`, `setGroupDataAsync`, `changeGroupCurrencyAsync`, `changeGroupStatisticsAsync`, `createGroupItemAsync` trả `GroupResponseData`.

## 10. Cảnh Báo Implementation Hiện Tại

- `AddSegmentRequestData.value` đang có `minLength: 6`, trong khi `RemoveSegmentRequestData.value` chỉ có `minLength: 2`.
- Đây là validation không nhất quán trong model hiện tại.
- `createGroupItemAsync` hiện trả `GroupResponseData`, không có contract public rõ ràng cho `itemId` mới tạo.
- Nếu flow sau đó cần `itemId`, bạn phải đọc lại inventory hoặc xác minh backend contract riêng.
- `OnGroupMemberUpdateEventHandler` theo public d.ts chỉ trả `members`, không có `groupId`.
- Nếu UI của bạn đang theo dõi nhiều group cùng lúc, không được giả định event này tự cho biết group nào thay đổi.

## 11. Best Practices

- Dùng getter chuyên biệt khi chỉ cần một phần dữ liệu group.
- Với query lớn, giữ `infoRequestParam` tối giản để giảm payload.
- Với `getCurrencyLogAsync` và `getStatisticsLogAsync`, nên truyền ít nhất `keys` hoặc `groupId` trong production để tránh query quá rộng.
- Với leaderboard, giữ `loadFromCache` mặc định nếu chấp nhận dữ liệu cache.
- Với `changeGroupCurrencyAsync` và `changeGroupStatisticsAsync`, luôn truyền `log` nếu flow cần audit.
- Với chat UI, dùng `getGroupMessageAsync` cho history và `OnGroupMessageUpdateEventHandler` cho push update.
- Với member UI, dùng `getMembersAsync` cho initial state và `OnGroupMemberUpdateEventHandler` cho realtime update nếu có socket.
- Với `sendGroupMessageAsync`, luôn truyền `senderId` đúng theo actor hiện tại; đừng giả định SDK tự nhét vào.

## 12. Ví dụ Khuyến Nghị

### Đọc group information với `infoRequestParam` tối giản

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var infoRequestParam = new GroupModels.InfoRequestParam();
infoRequestParam.displayName = true;
infoRequestParam.members = true;
infoRequestParam.groupCurrencies = true;
infoRequestParam.groupCurrencyKeys = new[] { "gold" };

var requestData = new GroupModels.GetGroupInformationRequestData();
requestData.groupId = "GROUP00001";
requestData.infoRequestParam = infoRequestParam;

var response = await GNNetwork.group.getGroupInformationAsync(requestData);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

var groupInfo = response.responseData.infoResponseParameters;
```

### Gửi message và nhận realtime update

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

OnGroupMessageUpdateEventHandler.onUpdate = (update) => {
    if (update.groupId != "GROUP00001") {
        return;
    }

    var pushedMessages = update.groupMessages;
    UnityEngine.Debug.Log(pushedMessages);
};

GNNetwork.connectSocket(); // Follow README socket rule before expecting realtime updates.

var requestData = new GroupModels.SendGroupMessageRequestData();
requestData.senderId = "1234567890";
requestData.groupId = "GROUP00001";
requestData.message = "hello team";

var response = await GNNetwork.group.sendGroupMessageAsync(requestData);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

var sentMessages = response.responseData.groupMessages;
```

### Tạo item cho group

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new GroupModels.CreateGroupItemRequestData();
requestData.groupId = "GROUP00001";
requestData.catalogId = "weapon";
requestData.classId = "sword";
requestData.displayName = "Guild Sword";
requestData.amount = 1;

var response = await GNNetwork.group.createGroupItemAsync(requestData);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

var groupInfo = response.responseData.infoResponseParameters;
```

### Đọc currency log với cursor

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new GroupModels.GetCurrencyLogRequestData();
requestData.groupId = "GROUP00001";
requestData.keys = new[] { "gold" };
requestData.limit = 20;

var response = await GNNetwork.group.getCurrencyLogAsync(requestData);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

var logs = response.responseData.results;
var nextToken = response.responseData.token;
```

## 13. Anti-Patterns

- Không dùng `GroupApi` để create/join/leave/remove group nếu method đó không nằm trong public surface hiện tại.
- Không dùng `getGroupInformationAsync` chỉ để đọc một field nhỏ nếu getter chuyên biệt đã có.
- Không bỏ `infoRequestParam` ở các method bắt buộc.
- Không dùng `groupStatisticsKeys` thay cho `statisticsKeys` hoặc ngược lại.
- Không dùng `skip` để phân trang log.
- Không dùng `token` để phân trang history message.
- Không giả định `sendGroupMessageAsync` là socket operation.
- Không giả định `sendGroupMessageAsync` tự lấy `senderId` từ auth state.
- Không hardcode enum cho `senderType`, `member.status` hoặc `avatar.type` khi package chưa export enum public tương ứng.
- Không giả định `createGroupItemAsync` trả `itemId` mới tạo.
- Không bỏ qua kiểm tra `hasReturnCodeError()` và `errorCode`.

## 14. AI Checklist

- Đã `Resources/GNServerSettings` chưa.
- Có chọn đúng namespace `group` / `group.server` / `group.admin` chưa.
- Có nhớ rằng operation của `GroupApi` hiện đi qua HTTP không.
- Nếu flow cần realtime, đã tuân theo [rule socket chuẩn trong RULES](/docs/RULES.md#7-auth--socket-flow) chưa.
- Nếu đang gọi method có `infoRequestParam`, đã truyền object này chưa.
- Nếu đang đọc statistics bằng getter chuyên biệt, có dùng đúng `statisticsKeys` chưa.
- Nếu đang đọc history message, có dùng `skip/limit` chưa.
- Nếu đang đọc currency/statistics log, có dùng `token` cho page tiếp chưa.
- Nếu đang gửi message, có truyền `senderId` chưa.
- Có kiểm tra `hasReturnCodeError()` trước `errorCode` chưa.
