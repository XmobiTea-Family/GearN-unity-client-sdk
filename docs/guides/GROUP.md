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

Đọc các bảng này trước. Cột API contract rows trỏ thẳng đến row cần đọc trong `API_GROUP.md`; không cần mở full file API.

> Khi thấy [client:16-16](/docs/example.md) nghĩa là chỉ cần đọc đúng từ dòng 16 đến 16 (hoặc gọi chính xác là đọc đúng dòng 16) của tài liệu `/docs/example.md`, tương tự với những cái khác, ví dụ [client:12-15] nghĩa là đọc đúng từ dòng 12 đến 15 của tài liệu, nếu có tool đọc từ startLine đến endLine ưu tiên cái này thay vì mở toàn bộ file.

> Thứ tự columns `API contract rows` của `client` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Permission Rules khi truyền userId khác với gamePlayer đang authenticated | Error Code có thể gặp |`, `server` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |`, `admin` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |`.

### Đọc 1 group hoặc 1 phần dữ liệu group

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `getAvatarAsync` | Cần đọc avatar group; `avatar.type` hiện là số thô | `groupId` | `GroupResponseData` | [client:17-17](/docs/reference/API_GROUP.md) / [server:63-63](/docs/reference/API_GROUP.md) / [admin:109-109](/docs/reference/API_GROUP.md) |
| `getCatalogIdAsync` | Cần đọc `catalogId` | `groupId` | `infoResponseParameters.catalogId` | [client:18-18](/docs/reference/API_GROUP.md) / [server:64-64](/docs/reference/API_GROUP.md) / [admin:110-110](/docs/reference/API_GROUP.md) |
| `getCustomDataAsync` | Cần đọc custom data | `groupId`, `customDataKeys?` | `GroupResponseData` | [client:19-19](/docs/reference/API_GROUP.md) / [server:65-65](/docs/reference/API_GROUP.md) / [admin:111-111](/docs/reference/API_GROUP.md) |
| `getDisplayNameAsync` | Cần đọc display name | `groupId` | `infoResponseParameters.displayName` | [client:20-20](/docs/reference/API_GROUP.md) / [server:66-66](/docs/reference/API_GROUP.md) / [admin:112-112](/docs/reference/API_GROUP.md) |
| `getGroupCurrencyAsync` | Cần đọc group currencies | `groupId`, `groupCurrencyKeys?` | `GroupResponseData` | [client:21-21](/docs/reference/API_GROUP.md) / [server:67-67](/docs/reference/API_GROUP.md) / [admin:113-113](/docs/reference/API_GROUP.md) |
| `getGroupDataAsync` | Cần đọc group data | `groupId`, `groupDataKeys?` | `GroupResponseData` | [client:22-22](/docs/reference/API_GROUP.md) / [server:68-68](/docs/reference/API_GROUP.md) / [admin:114-114](/docs/reference/API_GROUP.md) |
| `getGroupInformationAsync` | Cần lấy nhiều field group trong một lần gọi | `groupId`, `infoRequestParam` | `GroupResponseData` | [client:23-23](/docs/reference/API_GROUP.md) / [server:69-69](/docs/reference/API_GROUP.md) / [admin:115-115](/docs/reference/API_GROUP.md) |
| `getGroupInventoryAsync` | Cần đọc inventory của group | `groupId`, `itemCatalogIds?` | `GroupResponseData` | [client:24-24](/docs/reference/API_GROUP.md) / [server:70-70](/docs/reference/API_GROUP.md) / [admin:116-116](/docs/reference/API_GROUP.md) |
| `getGroupStatisticsAsync` | Cần đọc group statistics theo key | `groupId`, `statisticsKeys?` | `GroupResponseData` | [client:26-26](/docs/reference/API_GROUP.md) / [server:72-72](/docs/reference/API_GROUP.md) / [admin:118-118](/docs/reference/API_GROUP.md) |
| `getMembersAsync` | Cần đọc danh sách member | `groupId` | `infoResponseParameters.members` | [client:30-30](/docs/reference/API_GROUP.md) / [server:76-76](/docs/reference/API_GROUP.md) / [admin:122-122](/docs/reference/API_GROUP.md) |
| `getRemoveStatusAsync` | Cần đọc trạng thái remove | `groupId` | `infoResponseParameters.removeStatus` | [client:31-31](/docs/reference/API_GROUP.md) / [server:77-77](/docs/reference/API_GROUP.md) / [admin:123-123](/docs/reference/API_GROUP.md) |
| `getSegmentAsync` | Cần đọc segment của group | `groupId` | `infoResponseParameters.segments` | [client:32-32](/docs/reference/API_GROUP.md) / [server:78-78](/docs/reference/API_GROUP.md) / [admin:124-124](/docs/reference/API_GROUP.md) |
| `getTagAsync` | Cần đọc tag theo key, không query theo value | `groupId`, `tagKeys` | `GroupResponseData` | [client:35-35](/docs/reference/API_GROUP.md) / [server:81-81](/docs/reference/API_GROUP.md) / [admin:127-127](/docs/reference/API_GROUP.md) |
| `getTsCreateAsync` | Cần đọc thời điểm tạo group | `groupId` | `infoResponseParameters.tsCreate` | [client:36-36](/docs/reference/API_GROUP.md) / [server:82-82](/docs/reference/API_GROUP.md) / [admin:128-128](/docs/reference/API_GROUP.md) |

### Query danh sách, leaderboard, log và message history

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `getGroupsWithDisplayNameAsync` | Tìm group theo tên hiển thị; `keyword` tối thiểu 2 ký tự | `keyword`, `infoRequestParam`, `skip?`, `limit?` | `GroupsWithGroupIdResponseData` | [client:27-27](/docs/reference/API_GROUP.md) / [server:73-73](/docs/reference/API_GROUP.md) / [admin:119-119](/docs/reference/API_GROUP.md) |
| `getGroupsWithSegmentAsync` | Tìm group theo exact segment value | `value`, `infoRequestParam`, `skip?`, `limit?` | `GroupsWithGroupIdResponseData` | [client:28-28](/docs/reference/API_GROUP.md) / [server:74-74](/docs/reference/API_GROUP.md) / [admin:120-120](/docs/reference/API_GROUP.md) |
| `getGroupsWithTagAsync` | Tìm group theo cặp `key/value` | `key`, `value`, `infoRequestParam`, `skip?`, `limit?` | `GroupsWithGroupIdResponseData` | [client:29-29](/docs/reference/API_GROUP.md) / [server:75-75](/docs/reference/API_GROUP.md) / [admin:121-121](/docs/reference/API_GROUP.md) |
| `getStatisticsLeaderboardAroundGroupAsync` | Cần bảng xếp hạng quanh một group cụ thể | `groupId`, `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `catalogId?` | `GetStatisticsLeaderboardResponseData` | [client:33-33](/docs/reference/API_GROUP.md) / [server:79-79](/docs/reference/API_GROUP.md) / [admin:125-125](/docs/reference/API_GROUP.md) |
| `getStatisticsLeaderboardAsync` | Cần bảng xếp hạng statistics toàn cục theo key; chỉ method này có `version` | `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `version?`, `catalogId?` | `GetStatisticsLeaderboardResponseData` | [client:34-34](/docs/reference/API_GROUP.md) / [server:80-80](/docs/reference/API_GROUP.md) / [admin:126-126](/docs/reference/API_GROUP.md) |
| `getCurrencyLeaderboardAsync` | Cần bảng xếp hạng currency theo key; không có `version` | `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `catalogId?` | `GetCurrencyLeaderboardResponseData` | [client:51-51](/docs/reference/API_GROUP.md) / [server:97-97](/docs/reference/API_GROUP.md) / [admin:143-143](/docs/reference/API_GROUP.md) |
| `getCreateLeaderboardAsync` | Cần bảng xếp hạng theo thời điểm tạo group; không cần key | `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetCreateLeaderboardResponseData` | [client:52-52](/docs/reference/API_GROUP.md) / [server:98-98](/docs/reference/API_GROUP.md) / [admin:144-144](/docs/reference/API_GROUP.md) |
| `getStatisticsLogAsync` | Cần audit statistics log; phân trang bằng `token` | `keys?`, `groupId?`, `limit?`, `token?` | `GetStatisticsLogResponseData` | [client:53-53](/docs/reference/API_GROUP.md) / [server:99-99](/docs/reference/API_GROUP.md) / [admin:145-145](/docs/reference/API_GROUP.md) |
| `getCurrencyLogAsync` | Cần audit currency log; phân trang bằng `token` | `keys?`, `groupId?`, `limit?`, `token?` | `GetCurrencyLogResponseData` | [client:54-54](/docs/reference/API_GROUP.md) / [server:100-100](/docs/reference/API_GROUP.md) / [admin:146-146](/docs/reference/API_GROUP.md) |
| `getGroupMessageAsync` | Cần đọc lịch sử message; phân trang bằng `skip/limit` | `groupId`, `skip?`, `limit?` | `GroupMessagesResponseData` | [client:25-25](/docs/reference/API_GROUP.md) / [server:71-71](/docs/reference/API_GROUP.md) / [admin:117-117](/docs/reference/API_GROUP.md) |

### Mutation

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `addMemberAsync` | Thêm một user vào group; chỉ thêm 1 member mỗi lần | `userId`, `groupId` | `EmptyResponseData` | [client:15-15](/docs/reference/API_GROUP.md) / [server:61-61](/docs/reference/API_GROUP.md) / [admin:107-107](/docs/reference/API_GROUP.md) |
| `removeMemberAsync` | Gỡ một user khỏi group; không phải bulk remove | `userId`, `groupId` | `EmptyResponseData` | [client:39-39](/docs/reference/API_GROUP.md) / [server:85-85](/docs/reference/API_GROUP.md) / [admin:131-131](/docs/reference/API_GROUP.md) |
| `addSegmentAsync` | Gắn thêm một segment value cho group | `groupId`, `value` | `EmptyResponseData` | [client:16-16](/docs/reference/API_GROUP.md) / [server:62-62](/docs/reference/API_GROUP.md) / [admin:108-108](/docs/reference/API_GROUP.md) |
| `removeSegmentAsync` | Gỡ một segment khỏi group theo exact value | `groupId`, `value` | `EmptyResponseData` | [client:40-40](/docs/reference/API_GROUP.md) / [server:86-86](/docs/reference/API_GROUP.md) / [admin:132-132](/docs/reference/API_GROUP.md) |
| `setTagAsync` | Set hoặc upsert một tag theo một cặp key/value | `groupId`, `key`, `value` | `EmptyResponseData` | [client:50-50](/docs/reference/API_GROUP.md) / [server:96-96](/docs/reference/API_GROUP.md) / [admin:142-142](/docs/reference/API_GROUP.md) |
| `removeTagAsync` | Xóa tag theo key; không truyền `value` | `groupId`, `key` | `EmptyResponseData` | [client:41-41](/docs/reference/API_GROUP.md) / [server:87-87](/docs/reference/API_GROUP.md) / [admin:133-133](/docs/reference/API_GROUP.md) |
| `setAvatarAsync` | Set avatar của group; `type` chưa có enum public | `groupId`, `type`, `value` | `EmptyResponseData` | [client:43-43](/docs/reference/API_GROUP.md) / [server:89-89](/docs/reference/API_GROUP.md) / [admin:135-135](/docs/reference/API_GROUP.md) |
| `setCustomDataAsync` | Set custom data; mỗi phần tử là `key/value` | `groupId`, `customDatas[]` | `GroupResponseData` | [client:44-44](/docs/reference/API_GROUP.md) / [server:90-90](/docs/reference/API_GROUP.md) / [admin:136-136](/docs/reference/API_GROUP.md) |
| `setDisplayNameAsync` | Set display name; min length 5 | `groupId`, `displayName` | `EmptyResponseData` | [client:45-45](/docs/reference/API_GROUP.md) / [server:91-91](/docs/reference/API_GROUP.md) / [admin:137-137](/docs/reference/API_GROUP.md) |
| `setGroupDataAsync` | Set group data; mỗi phần tử là `key/value` | `groupId`, `groupDatas[]` | `GroupResponseData` | [client:47-47](/docs/reference/API_GROUP.md) / [server:93-93](/docs/reference/API_GROUP.md) / [admin:139-139](/docs/reference/API_GROUP.md) |
| `changeGroupCurrencyAsync` | Cộng/trừ currency; đây là delta change | `groupId`, `groupCurrencies[]`, `log?` | `GroupResponseData` | [client:46-46](/docs/reference/API_GROUP.md) / [server:92-92](/docs/reference/API_GROUP.md) / [admin:138-138](/docs/reference/API_GROUP.md) |
| `changeGroupStatisticsAsync` | Cộng/trừ statistics; đây là delta change | `groupId`, `groupStatistics[]`, `log?` | `GroupResponseData` | [client:48-48](/docs/reference/API_GROUP.md) / [server:94-94](/docs/reference/API_GROUP.md) / [admin:140-140](/docs/reference/API_GROUP.md) |
| `setRemoveStatusAsync` | Đánh dấu group bị remove; không phải hard delete | `groupId`, `reason?` | `EmptyResponseData` | [client:49-49](/docs/reference/API_GROUP.md) / [server:95-95](/docs/reference/API_GROUP.md) / [admin:141-141](/docs/reference/API_GROUP.md) |
| `createGroupItemAsync` | Tạo inventory item thuộc group; `amount` mặc định `1` | `groupId`, `catalogId`, `classId`, `displayName?`, `amount?` | `GroupResponseData` | [client:37-37](/docs/reference/API_GROUP.md) / [server:83-83](/docs/reference/API_GROUP.md) / [admin:129-129](/docs/reference/API_GROUP.md) |
| `removeGroupItemAsync` | Xóa item khỏi group theo `itemId` cụ thể | `groupId`, `itemId` | `EmptyResponseData` | [client:38-38](/docs/reference/API_GROUP.md) / [server:84-84](/docs/reference/API_GROUP.md) / [admin:130-130](/docs/reference/API_GROUP.md) |
| `sendGroupMessageAsync` | Gửi message vào group; operation là HTTP, không phải socket send | `senderId`, `groupId`, `message` | `GroupMessagesResponseData` | [client:42-42](/docs/reference/API_GROUP.md) / [server:88-88](/docs/reference/API_GROUP.md) / [admin:134-134](/docs/reference/API_GROUP.md) |

## 6. Method Signature

Mỗi method có 2 form: callback và `*Async()` Task. Mặc định sinh code bằng async form.

```csharp
// Callback
GNNetwork.group.<method>(requestData, onResponse, overrideAuthToken, overrideSecretKey, customTags, timeout);

// Async
var response = await GNNetwork.group.<method>Async(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
```

Param chung:

<!-- prettier-ignore -->
| Param | Type | Khi nào cần |
| --- | --- | --- |
| `requestData` | domain-specific DTO | Payload chính; tạo bằng `new GroupModels.<Method>RequestData()` hoặc role variant tương ứng |
| `onResponse` | `Action1<TResponse>` | Chỉ có ở callback form |
| `overrideAuthToken` | `string` | Impersonate / multi-session / admin thao tác bằng auth token khác |
| `overrideSecretKey` | `string` | Override secret key mặc định của role cho một request |
| `customTags` | `GNHashtable` | Trace id, build version, A/B bucket; backend có thể log/route |
| `timeout` | `int` | Override timeout theo request, tính bằng giây |

Typed response expose public fields: `returnCode`, `errorCode`, `invalidMembers`, `debugMessage`, `responseData`. Xem [RULES.md response checking](/docs/RULES.md).

## 7. Request Field Rules

- DTO fields: [reference/dto/GROUP.md](/docs/reference/dto/GROUP.md). Method table: [reference/API_GROUP.md](/docs/reference/API_GROUP.md).
- Events: [reference/EVENTS.md](/docs/reference/EVENTS.md#ongroupmemberupdateeventhandler).
- Enums: [GroupStatus](/docs/reference/ENUMS.md#groupstatus).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/Group*.cs`, `Runtime/Entity/Models/GenericModels.cs`.
- Lưu ý:
    - `GroupStatus` là enum publish có thật, nhưng `MemberItem.status` trong `GroupApi` không được ràng buộc bằng enum public riêng.
    - `senderType`, `avatar.type` và `MemberItem.status` hiện vẫn là số thô trong public surface.

## 8. InfoRequestParam Rules

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

## 9. Decision Rules

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

## 10. Response Rules

Tất cả typed response của `GroupApi` đều có:

- `returnCode`
- `debugMessage`
- `invalidMembers`
- `errorCode`
- `responseData`

Rule kiểm tra response:

```csharp
if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;
```

Nếu codebase đã có helper riêng như `hasReturnCodeError()` và muốn throw exception thay vì early-return, vẫn phải giữ thứ tự check 2 tầng: `returnCode` trước, `errorCode` sau.

Những response chính AI cần nhớ:

- Hầu hết getter đơn lẻ trả `GroupResponseData` và dữ liệu nằm trong `responseData.infoResponseParameters`.
- Các method list `getGroupsWith*Async` trả `responseData.results`, mỗi phần tử có `groupId` và `infoResponseParameters`.
- `getStatisticsLeaderboardAroundGroupAsync` và `getStatisticsLeaderboardAsync` trả `responseData.results` có `groupId`, `position`, `backupValue?`, `infoResponseParameters`.
- `getCurrencyLeaderboardAsync` và `getCreateLeaderboardAsync` trả `responseData.results`.
- `getCurrencyLogAsync` và `getStatisticsLogAsync` trả `responseData.results` và có thể có `responseData.token`.
- `getGroupMessageAsync` và `sendGroupMessageAsync` trả `responseData.groupMessages`, không phải `results`.
- `addMemberAsync`, `addSegmentAsync`, `removeMemberAsync`, `removeSegmentAsync`, `removeTagAsync`, `setAvatarAsync`, `setDisplayNameAsync`, `setRemoveStatusAsync`, `setTagAsync`, `removeGroupItemAsync` trả `EmptyResponseData`.
- `setCustomDataAsync`, `setGroupDataAsync`, `changeGroupCurrencyAsync`, `changeGroupStatisticsAsync`, `createGroupItemAsync` trả `GroupResponseData`.

## 11. Cảnh Báo Implementation Hiện Tại

- `AddSegmentRequestData.value` đang có `minLength: 6`, trong khi `RemoveSegmentRequestData.value` chỉ có `minLength: 2`.
- Đây là validation không nhất quán trong model hiện tại.
- `createGroupItemAsync` hiện trả `GroupResponseData`, không có contract public rõ ràng cho `itemId` mới tạo.
- Nếu flow sau đó cần `itemId`, bạn phải đọc lại inventory hoặc xác minh backend contract riêng.
- `OnGroupMemberUpdateEventHandler` theo public d.ts chỉ trả `members`, không có `groupId`.
- Nếu UI của bạn đang theo dõi nhiều group cùng lúc, không được giả định event này tự cho biết group nào thay đổi.

## 12. Best Practices

- Dùng getter chuyên biệt khi chỉ cần một phần dữ liệu group.
- Với query lớn, giữ `infoRequestParam` tối giản để giảm payload.
- Với `getCurrencyLogAsync` và `getStatisticsLogAsync`, nên truyền ít nhất `keys` hoặc `groupId` trong production để tránh query quá rộng.
- Với leaderboard, giữ `loadFromCache` mặc định nếu chấp nhận dữ liệu cache.
- Với `changeGroupCurrencyAsync` và `changeGroupStatisticsAsync`, luôn truyền `log` nếu flow cần audit.
- Với chat UI, dùng `getGroupMessageAsync` cho history và `OnGroupMessageUpdateEventHandler` cho push update.
- Với member UI, dùng `getMembersAsync` cho initial state và `OnGroupMemberUpdateEventHandler` cho realtime update nếu có socket.
- Với `sendGroupMessageAsync`, luôn truyền `senderId` đúng theo actor hiện tại; đừng giả định SDK tự nhét vào.

## 13. Minimal Pattern

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new GroupModels.GetMembersRequestData();
requestData.groupId = "GROUP00001";

var response = await GNNetwork.group.getMembersAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var members = response.responseData.infoResponseParameters.members;
```

## 14. Ví dụ Khuyến Nghị

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

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

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

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

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

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

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

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var logs = response.responseData.results;
var nextToken = response.responseData.token;
```

## 15. Anti-Patterns

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
- Không bỏ qua kiểm tra `returnCode` trước rồi mới tới `errorCode`.

## 16. AI Checklist

- Đã `Resources/GNServerSettings` chưa.
- Có chọn đúng namespace `group` / `group.server` / `group.admin` chưa.
- Có nhớ rằng operation của `GroupApi` hiện đi qua HTTP không.
- Nếu flow cần realtime, đã tuân theo [rule socket chuẩn trong RULES](/docs/RULES.md#7-auth--socket-flow) chưa.
- Nếu đang gọi method có `infoRequestParam`, đã truyền object này chưa.
- Nếu đang đọc statistics bằng getter chuyên biệt, có dùng đúng `statisticsKeys` chưa.
- Nếu đang đọc history message, có dùng `skip/limit` chưa.
- Nếu đang đọc currency/statistics log, có dùng `token` cho page tiếp chưa.
- Nếu đang gửi message, có truyền `senderId` chưa.
- Có kiểm tra `returnCode` trước `errorCode` chưa.

## Quick Map

Dùng bảng này để đọc đúng dòng mà không load cả file. `offset = startLine - 1`, `limit = endLine - startLine + 1`.

<!-- prettier-ignore -->
| Section | Lines |
| --- | --- |
| §3 HTTP Và Socket | 43-63 |
| §4 Chọn Namespace | 64-78 |
| §5 Chọn Method — Đọc 1 group | 87-106 |
| §5 Chọn Method — Query danh sách, leaderboard, log, message | 107-122 |
| §5 Chọn Method — Mutation | 123-144 |
| §8 InfoRequestParam Rules | 183-225 |
| §13 Minimal Pattern | 292-309 |
| §14 Ví Dụ Khuyến Nghị | 310-409 |
