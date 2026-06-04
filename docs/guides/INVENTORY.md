# InventoryApi

Tài liệu này là landing page cho AI code assistant khi cần dùng `GNNetwork.inventory*`. Đọc file này để chọn đúng namespace, method, DTO nhanh, và chỉ mở đúng row trong [API_INVENTORY.md](/docs/reference/API_INVENTORY.md) khi cần contract chi tiết.

## 1. Scope

- Áp dụng cho `GNNetwork.inventory`, `GNNetwork.inventory.server`, và `GNNetwork.inventory.admin`.
- Tất cả method hiện tại của `InventoryApi` đi qua HTTP; không dùng socket.
- `InventoryApi` có 3 role thật:
    - `GNNetwork.inventory` -> `RequestRole.Client`
    - `GNNetwork.inventory.server` -> `RequestRole.Server`
    - `GNNetwork.inventory.admin` -> `RequestRole.Admin`
- Payload shape giữa `client`, `server`, `admin` của cùng một operation giống nhau theo ý nghĩa nghiệp vụ; khác biệt chính là request DTO variant và role.
- `InventoryApi` quản lý item metadata, owner, amount, custom data, item data, tag, segment, statistics, leaderboard và statistics log.
- `InventoryApi` hiện không có public method tạo inventory item mới. Không tự suy diễn `createInventoryItem`.
- Rule chọn route/permission canonical: [RULES.md route rules](/docs/RULES.md). Với `InventoryApi`, `self/other-self` chỉ áp dụng trên route client và được backend suy từ owner của item.

## 2. Hard Rules

- Ưu tiên `async/await`; mặc định dùng `*Async()`.
- Bắt buộc đã có `Resources/GNServerSettings` trước khi gọi.
- Không dùng socket cho `InventoryApi`.
- Chọn namespace theo actor thật đang chạy code: client app, trusted backend, hay admin/backoffice tool.
- Chỉ dùng `.server` khi code chạy trong trusted backend/worker và secret có permission `serverSelfEnable` phù hợp.
- Chỉ dùng `.admin` khi code chạy trong dashboard/backoffice/admin tool và secret có permission `adminSelfEnable` phù hợp.
- `getItemInformationAsync`, `getItemsWithDisplayNameAsync`, `getItemsWithSegmentAsync`, `getItemsWithTagAsync`, `getStatisticsLeaderboardAroundItemAsync`, `getStatisticsLeaderboardAsync`, và `getCreateLeaderboardAsync` bắt buộc có `infoRequestParam`.
- `getItemStatisticsAsync` dùng `statisticsKeys`; `InfoRequestParam` dùng `itemStatisticsKeys`. Không dùng lẫn hai field này.
- `getStatisticsLogAsync` phân trang bằng `token`, không dùng `skip`.
- `changeAmountAsync` là thay đổi giá trị amount bằng cách cộng/trừ với amount truyền vào request data. `changeItemStatisticsAsync` là cộng/trừ delta theo từng key.
- `setOwnerAsync` chuyển owner của item, không clone item.
- `setRemoveStatusAsync` đánh dấu remove với `reason?`; hiện không có public method riêng để undo thao tác này.
- `removeTagAsync` xóa theo `key`, không theo cặp `key/value`.
- Dùng enum public khi package đã có: `ItemType` cho `itemType`, `OwnerType` cho `owner.type` và `newOwnerType`.
- `setAvatarAsync` có field `type: number`, nhưng package hiện không publish enum avatar riêng. Không tự bịa enum nếu backend spec chưa chốt.

## 3. Chọn Namespace

<!-- prettier-ignore -->
| Namespace | Role thật | Dùng khi nào |
| --- | --- | --- |
| `GNNetwork.inventory` | `Client` | Unity client / player app thao tác item theo session hiện tại |
| `GNNetwork.inventory.server` | `Server` | Game server, CloudScript runtime, worker, trusted backend xử lý item |
| `GNNetwork.inventory.admin` | `Admin` | GM tool, dashboard, migration, vận hành dữ liệu |

Rule nhanh:

- Code chạy trong game client: ưu tiên `GNNetwork.inventory`.
- Code chạy ở trusted backend hoặc worker: ưu tiên `GNNetwork.inventory.server`.
- Code chạy ở dashboard/tool vận hành: ưu tiên `GNNetwork.inventory.admin`.
- Chỉ dùng `overrideSecretKey` khi có chủ đích override secret mặc định theo role cho một request.

## 4. Chọn Method

Đọc bảng này trước. Cột API contract rows trỏ thẳng đến row cần đọc trong `API_INVENTORY.md`; không cần mở full file API.

> Khi thấy [client:16-16](/docs/example.md) nghĩa là chỉ cần đọc đúng từ dòng 16 đến 16 (hoặc gọi chính xác là đọc đúng dòng 16) của tài liệu `/docs/example.md`, tương tự với những cái khác, ví dụ [client:12-15] nghĩa là đọc đúng từ dòng 12 đến 15 của tài liệu, nếu có tool đọc từ startLine đến endLine ưu tiên cái này thay vì mở toàn bộ file.

> Thứ tự columns `API contract rows` của `client` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Permission Rules khi truyền itemId, nếu gamePlayer đang được authenticated và characterPlayer có owner là gamePlayer, hoặc group có chứa gamePlayer / characterPlayer, nhưng không bên nào là owner của inventory item này | Error Code có thể gặp |`, `server` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |`, `admin` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |`.

### Đọc 1 item

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `getAmountAsync` | Đọc số lượng item | `itemId` | `responseData.infoResponseParameters.amount` | [client:16-16](/docs/reference/API_INVENTORY.md) / [server:56-56](/docs/reference/API_INVENTORY.md) / [admin:96-96](/docs/reference/API_INVENTORY.md) |
| `getAvatarAsync` | Đọc avatar item | `itemId` | `responseData.infoResponseParameters.avatar` | [client:17-17](/docs/reference/API_INVENTORY.md) / [server:57-57](/docs/reference/API_INVENTORY.md) / [admin:97-97](/docs/reference/API_INVENTORY.md) |
| `getCatalogIdAsync` | Đọc `catalogId` | `itemId` | `responseData.infoResponseParameters.catalogId` | [client:18-18](/docs/reference/API_INVENTORY.md) / [server:58-58](/docs/reference/API_INVENTORY.md) / [admin:98-98](/docs/reference/API_INVENTORY.md) |
| `getClassIdAsync` | Đọc `classId` | `itemId` | `responseData.infoResponseParameters.classId` | [client:19-19](/docs/reference/API_INVENTORY.md) / [server:59-59](/docs/reference/API_INVENTORY.md) / [admin:99-99](/docs/reference/API_INVENTORY.md) |
| `getCustomDataAsync` | Đọc custom data | `itemId`, `customDataKeys?` | `responseData.infoResponseParameters.customDatas` | [client:20-20](/docs/reference/API_INVENTORY.md) / [server:60-60](/docs/reference/API_INVENTORY.md) / [admin:100-100](/docs/reference/API_INVENTORY.md) |
| `getDisplayNameAsync` | Đọc display name | `itemId` | `responseData.infoResponseParameters.displayName` | [client:21-21](/docs/reference/API_INVENTORY.md) / [server:61-61](/docs/reference/API_INVENTORY.md) / [admin:101-101](/docs/reference/API_INVENTORY.md) |
| `getItemDataAsync` | Đọc item data | `itemId`, `itemDataKeys?` | `responseData.infoResponseParameters.itemDatas` | [client:22-22](/docs/reference/API_INVENTORY.md) / [server:62-62](/docs/reference/API_INVENTORY.md) / [admin:102-102](/docs/reference/API_INVENTORY.md) |
| `getItemInformationAsync` | Lấy nhiều field trong một lần gọi | `itemId`, `infoRequestParam` | `responseData.infoResponseParameters` | [client:23-23](/docs/reference/API_INVENTORY.md) / [server:63-63](/docs/reference/API_INVENTORY.md) / [admin:103-103](/docs/reference/API_INVENTORY.md) |
| `getItemStatisticsAsync` | Đọc statistics theo key | `itemId`, `statisticsKeys?` | `responseData.infoResponseParameters.itemStatistics` | [client:24-24](/docs/reference/API_INVENTORY.md) / [server:64-64](/docs/reference/API_INVENTORY.md) / [admin:104-104](/docs/reference/API_INVENTORY.md) |
| `getItemTypeAsync` | Đọc loại item | `itemId` | `responseData.infoResponseParameters.itemType` | [client:28-28](/docs/reference/API_INVENTORY.md) / [server:68-68](/docs/reference/API_INVENTORY.md) / [admin:108-108](/docs/reference/API_INVENTORY.md) |
| `getOwnerAsync` | Đọc owner hiện tại | `itemId` | `responseData.infoResponseParameters.owner` | [client:29-29](/docs/reference/API_INVENTORY.md) / [server:69-69](/docs/reference/API_INVENTORY.md) / [admin:109-109](/docs/reference/API_INVENTORY.md) |
| `getRemoveStatusAsync` | Đọc trạng thái remove | `itemId` | `responseData.infoResponseParameters.removeStatus` | [client:30-30](/docs/reference/API_INVENTORY.md) / [server:70-70](/docs/reference/API_INVENTORY.md) / [admin:110-110](/docs/reference/API_INVENTORY.md) |
| `getSegmentAsync` | Đọc danh sách segment | `itemId` | `responseData.infoResponseParameters.segments` | [client:31-31](/docs/reference/API_INVENTORY.md) / [server:71-71](/docs/reference/API_INVENTORY.md) / [admin:111-111](/docs/reference/API_INVENTORY.md) |
| `getTagAsync` | Đọc tag theo danh sách key | `itemId`, `tagKeys` | `responseData.infoResponseParameters.tags` | [client:34-34](/docs/reference/API_INVENTORY.md) / [server:74-74](/docs/reference/API_INVENTORY.md) / [admin:114-114](/docs/reference/API_INVENTORY.md) |
| `getTsCreateAsync` | Đọc thời điểm tạo item | `itemId` | `responseData.infoResponseParameters.tsCreate` | [client:35-35](/docs/reference/API_INVENTORY.md) / [server:75-75](/docs/reference/API_INVENTORY.md) / [admin:115-115](/docs/reference/API_INVENTORY.md) |

### Query danh sách, leaderboard và log

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `getItemsWithDisplayNameAsync` | Tìm item theo tên hiển thị | `keyword`, `infoRequestParam`, `skip?`, `limit?` | `responseData.results` | [client:25-25](/docs/reference/API_INVENTORY.md) / [server:65-65](/docs/reference/API_INVENTORY.md) / [admin:105-105](/docs/reference/API_INVENTORY.md) |
| `getItemsWithSegmentAsync` | Tìm item theo segment | `value`, `infoRequestParam`, `skip?`, `limit?` | `responseData.results` | [client:26-26](/docs/reference/API_INVENTORY.md) / [server:66-66](/docs/reference/API_INVENTORY.md) / [admin:106-106](/docs/reference/API_INVENTORY.md) |
| `getItemsWithTagAsync` | Tìm item theo tag | `key`, `value`, `infoRequestParam`, `skip?`, `limit?` | `responseData.results` | [client:27-27](/docs/reference/API_INVENTORY.md) / [server:67-67](/docs/reference/API_INVENTORY.md) / [admin:107-107](/docs/reference/API_INVENTORY.md) |
| `getStatisticsLeaderboardAroundItemAsync` | Lấy leaderboard quanh một item cụ thể | `itemId`, `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `catalogId?` | `responseData.results` | [client:32-32](/docs/reference/API_INVENTORY.md) / [server:72-72](/docs/reference/API_INVENTORY.md) / [admin:112-112](/docs/reference/API_INVENTORY.md) |
| `getStatisticsLeaderboardAsync` | Lấy leaderboard toàn cục theo statistics key | `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `version?`, `catalogId?` | `responseData.results` | [client:33-33](/docs/reference/API_INVENTORY.md) / [server:73-73](/docs/reference/API_INVENTORY.md) / [admin:113-113](/docs/reference/API_INVENTORY.md) |
| `getCreateLeaderboardAsync` | Lấy leaderboard theo thời điểm tạo item | `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `responseData.results` | [client:47-47](/docs/reference/API_INVENTORY.md) / [server:87-87](/docs/reference/API_INVENTORY.md) / [admin:127-127](/docs/reference/API_INVENTORY.md) |
| `getStatisticsLogAsync` | Đọc audit statistics change log | `keys?`, `itemId?`, `limit?`, `token?` | `responseData.results`, `responseData.token?` | [client:48-48](/docs/reference/API_INVENTORY.md) / [server:88-88](/docs/reference/API_INVENTORY.md) / [admin:128-128](/docs/reference/API_INVENTORY.md) |

### Mutation

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `addSegmentAsync` | Gắn thêm segment cho item | `itemId`, `value` | `EmptyResponseData` | [client:15-15](/docs/reference/API_INVENTORY.md) / [server:55-55](/docs/reference/API_INVENTORY.md) / [admin:95-95](/docs/reference/API_INVENTORY.md) |
| `removeSegmentAsync` | Gỡ một segment khỏi item | `itemId`, `value` | `EmptyResponseData` | [client:36-36](/docs/reference/API_INVENTORY.md) / [server:76-76](/docs/reference/API_INVENTORY.md) / [admin:116-116](/docs/reference/API_INVENTORY.md) |
| `setTagAsync` | Set hoặc upsert một tag | `itemId`, `key`, `value` | `EmptyResponseData` | [client:46-46](/docs/reference/API_INVENTORY.md) / [server:86-86](/docs/reference/API_INVENTORY.md) / [admin:126-126](/docs/reference/API_INVENTORY.md) |
| `removeTagAsync` | Xóa tag theo key | `itemId`, `key` | `EmptyResponseData` | [client:37-37](/docs/reference/API_INVENTORY.md) / [server:77-77](/docs/reference/API_INVENTORY.md) / [admin:117-117](/docs/reference/API_INVENTORY.md) |
| `changeAmountAsync` | Thay đổi giá trị amount bằng cách cộng/trừ với amount truyền vào request data | `itemId`, `amount` | `InventoryResponseData` | [client:38-38](/docs/reference/API_INVENTORY.md) / [server:78-78](/docs/reference/API_INVENTORY.md) / [admin:118-118](/docs/reference/API_INVENTORY.md) |
| `setAvatarAsync` | Set avatar của item | `itemId`, `type`, `value` | `EmptyResponseData` | [client:39-39](/docs/reference/API_INVENTORY.md) / [server:79-79](/docs/reference/API_INVENTORY.md) / [admin:119-119](/docs/reference/API_INVENTORY.md) |
| `setCustomDataAsync` | Set custom data theo nhiều key | `itemId`, `customDatas[]` | `InventoryResponseData` | [client:40-40](/docs/reference/API_INVENTORY.md) / [server:80-80](/docs/reference/API_INVENTORY.md) / [admin:120-120](/docs/reference/API_INVENTORY.md) |
| `setDisplayNameAsync` | Set display name | `itemId`, `displayName` | `EmptyResponseData` | [client:41-41](/docs/reference/API_INVENTORY.md) / [server:81-81](/docs/reference/API_INVENTORY.md) / [admin:121-121](/docs/reference/API_INVENTORY.md) |
| `setItemDataAsync` | Set item data theo nhiều key | `itemId`, `itemDatas[]` | `InventoryResponseData` | [client:42-42](/docs/reference/API_INVENTORY.md) / [server:82-82](/docs/reference/API_INVENTORY.md) / [admin:122-122](/docs/reference/API_INVENTORY.md) |
| `changeItemStatisticsAsync` | Cộng/trừ statistics | `itemId`, `itemStatistics[]`, `log?` | `InventoryResponseData` | [client:43-43](/docs/reference/API_INVENTORY.md) / [server:83-83](/docs/reference/API_INVENTORY.md) / [admin:123-123](/docs/reference/API_INVENTORY.md) |
| `setOwnerAsync` | Chuyển owner của item | `itemId`, `newOwnerId`, `newOwnerType` | `EmptyResponseData` | [client:44-44](/docs/reference/API_INVENTORY.md) / [server:84-84](/docs/reference/API_INVENTORY.md) / [admin:124-124](/docs/reference/API_INVENTORY.md) |
| `setRemoveStatusAsync` | Đánh dấu item bị remove | `itemId`, `reason?` | `EmptyResponseData` | [client:45-45](/docs/reference/API_INVENTORY.md) / [server:85-85](/docs/reference/API_INVENTORY.md) / [admin:125-125](/docs/reference/API_INVENTORY.md) |

Decision rules:

- Cần đọc đúng một field nhỏ của item: ưu tiên getter chuyên biệt.
- Cần nhiều field trong một lần gọi: dùng `getItemInformationAsync`.
- Cần search item theo tên, segment, tag: dùng nhóm `getItemsWith*Async`.
- Cần leaderboard theo statistics key: dùng `getStatisticsLeaderboardAsync`.
- Cần leaderboard quanh một item cụ thể: dùng `getStatisticsLeaderboardAroundItemAsync`.
- Cần leaderboard theo thời điểm tạo: dùng `getCreateLeaderboardAsync`.
- Cần cộng/trừ stats: dùng `changeItemStatisticsAsync`, không dùng `changeAmountAsync`.
- Cần cộng/trừ lại amount: dùng `changeAmountAsync`, không dùng `changeItemStatisticsAsync`.
- Cần audit biến động statistics: dùng `getStatisticsLogAsync`.

## 5. Method Signature

Mỗi method có 2 form: callback và `*Async()` Task. Mặc định sinh code bằng async form.

```csharp
// Callback
GNNetwork.inventory.<method>(requestData, onResponse, overrideAuthToken, overrideSecretKey, customTags, timeout);

// Async
var response = await GNNetwork.inventory.<method>Async(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
```

Param chung:

<!-- prettier-ignore -->
| Param | Type | Khi nào cần |
| --- | --- | --- |
| `requestData` | domain-specific DTO | Payload chính; tạo bằng `new InventoryModels.<Method>RequestData()` hoặc role variant tương ứng |
| `onResponse` | `Action1<TResponse>` | Chỉ có ở callback form |
| `overrideAuthToken` | `string` | Impersonate / multi-session / admin thao tác bằng auth token khác |
| `overrideSecretKey` | `string` | Override secret key mặc định của role cho một request |
| `customTags` | `GNHashtable` | Trace id, build version, A/B bucket; backend có thể log/route |
| `timeout` | `int` | Override timeout theo request, tính bằng giây |

Typed response expose public fields: `returnCode`, `errorCode`, `invalidMembers`, `debugMessage`, `responseData`. Xem [RULES.md response checking](/docs/RULES.md).

## 6. Request Field Rules

- DTO fields: [reference/dto/INVENTORY.md](/docs/reference/dto/INVENTORY.md).
- Contract table: [reference/API_INVENTORY.md](/docs/reference/API_INVENTORY.md).
- Enums: [ItemType](/docs/reference/ENUMS.md#itemtype), [OwnerType](/docs/reference/ENUMS.md#ownertype).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/Inventory*.cs`, `Runtime/Entity/Models/GenericModels.cs`.

<!-- prettier-ignore -->
| DTO / field | Quick rule | DTO link |
| --- | --- | --- |
| `InfoRequestParam` | Bắt buộc ở aggregate info, list query, leaderboard; chỉ bật field thật sự cần render | [InventoryModels.InfoRequestParam:1272-1303](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inforequestparam) |
| `InfoRequestParam.itemStatisticsKeys` | Dùng để filter item statistics khi response được hydrate qua `infoRequestParam` | [InventoryModels.InfoRequestParam:1272-1303](/docs/reference/dto/inventory/INVENTORY_MODELS.md#inforequestparam) |
| `GetItemStatisticsRequestData.statisticsKeys` | Dùng riêng cho `getItemStatisticsAsync`; không đổi thành `itemStatisticsKeys` | [InventoryModels.GetItemStatisticsRequestData:362-375](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getitemstatisticsrequestdata) |
| `GetStatisticsLogRequestData.token` | Cursor page kế tiếp; không dùng `skip` | [InventoryModels.GetStatisticsLogRequestData:1236-1247](/docs/reference/dto/inventory/INVENTORY_MODELS.md#getstatisticslogrequestdata) |
| `ChangeAmountRequestData.amount` | Giá trị cần cộng/trừ cho stack amount | [InventoryModels.ChangeAmountRequestData:914-923](/docs/reference/dto/inventory/INVENTORY_MODELS.md#changeamountrequestdata) |
| `ChangeItemStatisticsRequestData.itemStatistics` | Delta theo key; truyền `log` nếu flow cần audit | [InventoryModels.ChangeItemStatisticsRequestData:1093-1107](/docs/reference/dto/inventory/INVENTORY_MODELS.md#changeitemstatisticsrequestdata) |
| `SetOwnerRequestData.newOwnerType` | Map bằng `OwnerType`, không hardcode số | [InventoryModels.SetOwnerRequestData:1132-1142](/docs/reference/dto/inventory/INVENTORY_MODELS.md#setownerrequestdata) |
| `SetAvatarRequestData.type` | Number theo backend contract; package chưa có enum public riêng | [InventoryModels.SetAvatarRequestData:948-958](/docs/reference/dto/inventory/INVENTORY_MODELS.md#setavatarrequestdata) |

## 7. Inventory Flow Rules

### InfoRequestParam

`InventoryModels.InfoRequestParam` điều khiển payload trả về trong `getItemInformationAsync`, `getItemsWithDisplayNameAsync`, `getItemsWithSegmentAsync`, `getItemsWithTagAsync`, `getStatisticsLeaderboardAroundItemAsync`, `getStatisticsLeaderboardAsync`, và `getCreateLeaderboardAsync`.

Rule cứng:

- Không truyền `null`.
- Không bật toàn bộ field một cách mù quáng.
- Chỉ bật field mà màn hình hoặc flow hiện tại thật sự cần.
- Nếu cần filter dữ liệu con, dùng `itemDataKeys`, `itemStatisticsKeys`, `customDataKeys`, hoặc `tagKeys`.
- Nếu chỉ cần một field đơn lẻ như amount hoặc owner, ưu tiên getter chuyên biệt như `getAmountAsync` hoặc `getOwnerAsync`.

### Response shape

- Hầu hết getter đơn lẻ trả `InventoryResponseData`; dữ liệu nằm trong `responseData.infoResponseParameters`.
- Nhóm `getItemsWith*Async` trả `responseData.results`; mỗi phần tử có `itemId` và `infoResponseParameters`.
- `getStatisticsLeaderboardAroundItemAsync` và `getStatisticsLeaderboardAsync` trả `responseData.results` có `itemId`, `position`, `backupValue?`, `infoResponseParameters`.
- `getCreateLeaderboardAsync` trả `responseData.results` cùng shape leaderboard item.
- `getStatisticsLogAsync` trả `responseData.results` và có thể có `responseData.token` cho page tiếp.
- `addSegmentAsync`, `removeSegmentAsync`, `removeTagAsync`, `setAvatarAsync`, `setDisplayNameAsync`, `setOwnerAsync`, `setRemoveStatusAsync`, `setTagAsync` trả `EmptyResponseData`.
- `changeAmountAsync`, `setCustomDataAsync`, `setItemDataAsync`, `changeItemStatisticsAsync` trả `InventoryResponseData`.

### Implementation note

- `SetOwnerRequestData.itemId` hiện được decorate với length `11..11`, trong khi hầu hết request inventory khác dùng `12..12`.
- Nếu tự thêm validation ngoài SDK, không tự hardcode rule khác trước khi verify backend spec thật.
- `GenericModels.AvatarItem.type` và `SetAvatarRequestData.type` hiện chưa có enum public trong package. Nếu backend có enum riêng, phải dùng spec backend đó.

## 8. Minimal Pattern

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new InventoryModels.GetAmountRequestData();
requestData.itemId = "ABCDEFGHIJKL";

var response = await GNNetwork.inventory.getAmountAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var amount = response.responseData.infoResponseParameters.amount;
```

Nếu codebase đã có helper riêng như `hasReturnCodeError()` và muốn throw exception thay vì early-return, vẫn phải giữ thứ tự check 2 tầng: `returnCode` trước, `errorCode` sau.

## 9. Ví dụ Khuyến Nghị

### Đọc item information với `infoRequestParam` tối giản

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var infoRequestParam = new InventoryModels.InfoRequestParam();
infoRequestParam.itemType = true;
infoRequestParam.amount = true;
infoRequestParam.owner = true;
infoRequestParam.displayName = true;

var requestData = new InventoryModels.GetItemInformationRequestData();
requestData.itemId = "ABCDEFGHIJKL";
requestData.infoRequestParam = infoRequestParam;

var response = await GNNetwork.inventory.getItemInformationAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var itemInfo = response.responseData.infoResponseParameters;
var itemType = itemInfo.itemType.HasValue ? (ItemType?)itemInfo.itemType.Value : null;
var ownerType = itemInfo.owner != null ? (OwnerType?)itemInfo.owner.type : null;
```

### Cộng statistics có audit log

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var statisticsParam = new InventoryModels.ItemStatisticsParam();
statisticsParam.key = "killCount";
statisticsParam.value = 1;

var requestData = new InventoryModels.ChangeItemStatisticsRequestData();
requestData.itemId = "ABCDEFGHIJKL";
requestData.itemStatistics = new[] { statisticsParam };
requestData.log = "award_kill_from_match_end";

var response = await GNNetwork.inventory.changeItemStatisticsAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;
```

### Đọc leaderboard quanh một item

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var infoRequestParam = new InventoryModels.InfoRequestParam();
infoRequestParam.displayName = true;
infoRequestParam.itemStatistics = true;
infoRequestParam.itemStatisticsKeys = new[] { "killCount" };

var requestData = new InventoryModels.GetStatisticsLeaderboardAroundItemRequestData();
requestData.itemId = "ABCDEFGHIJKL";
requestData.key = "killCount";
requestData.infoRequestParam = infoRequestParam;
requestData.skip = 0;
requestData.limit = 20;
requestData.loadFromCache = true;

var response = await GNNetwork.inventory.getStatisticsLeaderboardAroundItemAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var results = response.responseData.results;
```

### Đọc statistics log với cursor

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new InventoryModels.GetStatisticsLogRequestData();
requestData.itemId = "ABCDEFGHIJKL";
requestData.keys = new[] { "killCount" };
requestData.limit = 20;

var response = await GNNetwork.inventory.getStatisticsLogAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var logs = response.responseData.results;
var nextToken = response.responseData.token;
```

## 10. Anti-Patterns

- Không gọi `getItemInformationAsync` chỉ để đọc một field đơn lẻ nếu getter chuyên biệt đã có.
- Không bỏ `infoRequestParam` ở các method bắt buộc.
- Không dùng `itemStatisticsKeys` thay cho `statisticsKeys` hoặc ngược lại.
- Không dùng `changeAmountAsync` khi ý đồ là tăng/giảm delta.
- Không dùng `setOwnerAsync` nếu mục tiêu là duplicate item cho owner mới.
- Không hardcode số cho `ItemType` hoặc `OwnerType`.
- Không tự phát minh enum cho `avatar.type` nếu package chưa export.
- Không phân trang `getStatisticsLogAsync` bằng `skip`.
- Không gọi nhầm namespace role để vượt permission.
- Không bỏ qua check `returnCode` và `errorCode`.
- Không dùng callback style mặc định khi codebase đã support `async/await`.

## 11. AI Checklist

- Đã có `Resources/GNServerSettings` chưa.
- Đã chọn đúng namespace `inventory` / `inventory.server` / `inventory.admin` chưa.
- Có nhớ `InventoryApi` chỉ đi qua HTTP không.
- Flow hiện tại là getter chuyên biệt, aggregate info, list query, leaderboard, statistics log hay mutation.
- Nếu method cần `infoRequestParam`, đã truyền object này và chỉ bật field cần thiết chưa.
- Nếu đang đọc statistics qua getter chuyên biệt, có dùng đúng `statisticsKeys` chưa.
- Nếu đang hydrate statistics qua `infoRequestParam`, có dùng đúng `itemStatisticsKeys` chưa.
- Nếu đang map `itemType` hoặc owner type, có dùng enum public thay vì số thô không.
- Nếu đang đọc log, có dùng `token` cho page tiếp chưa.
- Có check `returnCode` trước `errorCode` chưa.

## Quick Map

Dùng bảng này để đọc đúng dòng mà không load cả file. `offset = startLine - 1`, `limit = endLine - startLine + 1`.

<!-- prettier-ignore -->
| Section | Lines |
| --- | --- |
| §3 Chọn Namespace | 36-51 |
| §4 Chọn Method — Đọc 1 item | 60-80 |
| §4 Chọn Method — Query danh sách, leaderboard và log | 81-93 |
| §4 Chọn Method — Mutation | 94-111 |
| §8 Minimal Pattern | 201-219 |
| §9 Ví Dụ Khuyến Nghị | 221-320 |
