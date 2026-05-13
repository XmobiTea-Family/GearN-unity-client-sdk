# InventoryApi

Tài liệu này dành cho AI code assistant và AI agent nội bộ. Mục tiêu là chọn đúng namespace `client/server/admin`, phân biệt đúng flow đọc item với flow mutation, và không sinh sai request ở các nhóm `infoRequestParam`, leaderboard, owner transfer và statistics log.

## 1. Scope

- Áp dụng cho:
    - `GNNetwork.inventory`
    - `GNNetwork.inventory.server`
    - `GNNetwork.inventory.admin`
- Toàn bộ method hiện tại của `InventoryApi` đều gửi qua HTTP.
- `InventoryApi` có đủ 3 role thật:
    - `GNNetwork.inventory` -> `RequestRole.Client`
    - `GNNetwork.inventory.server` -> `RequestRole.Server`
    - `GNNetwork.inventory.admin` -> `RequestRole.Admin`
- Nếu không truyền `overrideSecretKey`, SDK sẽ tự lấy secret key theo role tương ứng.
- Chỉ dùng namespace `.server` khi bạn đã cấu hình `secretKey` với `permission rules` `server` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Chỉ dùng namespace `.admin` khi bạn đã cấu hình `secretKey` với `permission rules` `admin` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Rule chuẩn để chọn `client/server/admin` và hiểu `self/other-self` xem [RULES](/docs/RULES.md#3-route--trust-boundary-của-caller). Không tự suy diễn route chỉ từ target ownership.
- Payload shape hiện tại giữa `client`, `server`, `admin` là giống nhau; khác biệt chính là trust boundary và secret key mặc định.
- `InventoryApi` không có flow tạo inventory item mới trong public surface hiện tại. Không được tự suy diễn `createInventoryItem`.

## 2. Hard Rules

- Luôn ưu tiên `async/await`. Mặc định dùng `*Async()`.
- Bắt buộc đã `Resources/GNServerSettings` trước khi gọi.
- Không dùng socket cho `InventoryApi`.
- Chọn namespace theo trust boundary, không theo cảm tính:
    - app/player -> `GNNetwork.inventory`
    - trusted backend/service -> `GNNetwork.inventory.server`
    - dashboard/ops/tooling -> `GNNetwork.inventory.admin`
- `getItemInformationAsync`, `getItemsWithDisplayNameAsync`, `getItemsWithSegmentAsync`, `getItemsWithTagAsync`, `getStatisticsLeaderboardAroundItemAsync`, `getStatisticsLeaderboardAsync` và `getCreateLeaderboardAsync` đều bắt buộc có `infoRequestParam`.
- `getItemStatisticsAsync` dùng `statisticsKeys`, còn `infoRequestParam` dùng `itemStatisticsKeys`. Không được dùng lẫn hai field này.
- `getStatisticsLogAsync` phân trang bằng `token`, không dùng `skip`.
- `setAmountAsync` là set giá trị tuyệt đối. `changeItemStatisticsAsync` là cộng/trừ delta theo từng key.
- `setOwnerAsync` là chuyển owner của item, không phải clone item.
- `setRemoveStatusAsync` là đánh dấu remove với `reason?`; trong `InventoryApi` hiện không có public method riêng để undo thao tác này.
- `removeTagAsync` xóa theo `key`, không theo cặp `key/value`.
- Dùng enum publish khi package đã có:
    - `itemType` -> `ItemType`
    - `owner.type`, `newOwnerType` -> `OwnerType`
- `setAvatarAsync` có field `type: number`, nhưng package hiện không publish enum avatar riêng. Không được tự bịa enum nếu backend spec chưa chốt.

## 3. Chọn Namespace

<!-- prettier-ignore -->
| Namespace | Role thật | Dùng khi nào |
| --- | --- | --- |
| `GNNetwork.inventory` | `Client` | player app thao tác trên item thuộc session hiện tại |
| `GNNetwork.inventory.server` | `Server` | trusted backend, game server, worker xử lý item |
| `GNNetwork.inventory.admin` | `Admin` | GM tool, dashboard, migration, vận hành dữ liệu |

Rule nhanh:

- Nếu logic chạy trong client app: ưu tiên `GNNetwork.inventory`.
- Nếu logic chạy trong backend tin cậy: ưu tiên `GNNetwork.inventory.server`.
- Nếu thao tác quản trị hoặc vận hành dữ liệu: ưu tiên `GNNetwork.inventory.admin`.

## 4. Chọn Method

### Đọc 1 item

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `getAmountAsync` | Cần đọc số lượng item | `itemId` | `InventoryResponseData` | Giá trị nằm trong `infoResponseParameters.amount` | `Ok`, `ItemNotFound` |
| `getAvatarAsync` | Cần đọc avatar item | `itemId` | `InventoryResponseData` | `avatar.type` hiện là số thô | `Ok`, `ItemNotFound` |
| `getCatalogIdAsync` | Cần đọc `catalogId` | `itemId` | `InventoryResponseData` | Kết quả ở `infoResponseParameters.catalogId` | `Ok`, `ItemNotFound` |
| `getClassIdAsync` | Cần đọc `classId` | `itemId` | `InventoryResponseData` | Kết quả ở `infoResponseParameters.classId` | `Ok`, `ItemNotFound` |
| `getCustomDataAsync` | Cần đọc custom data | `itemId`, `customDataKeys?` | `InventoryResponseData` | Có thể filter theo key | `Ok`, `ItemNotFound` |
| `getDisplayNameAsync` | Cần đọc display name | `itemId` | `InventoryResponseData` | Kết quả ở `infoResponseParameters.displayName` | `Ok`, `ItemNotFound` |
| `getItemDataAsync` | Cần đọc item data | `itemId`, `itemDataKeys?` | `InventoryResponseData` | Có thể filter theo key | `Ok`, `ItemNotFound` |
| `getItemInformationAsync` | Cần lấy nhiều field trong một lần gọi | `itemId`, `infoRequestParam` | `InventoryResponseData` | Flow đọc tổng hợp quan trọng nhất | `Ok`, `ItemNotFound` |
| `getItemStatisticsAsync` | Cần đọc statistics theo key | `itemId`, `statisticsKeys?` | `InventoryResponseData` | Không dùng `itemStatisticsKeys` ở đây | `Ok`, `ItemNotFound` |
| `getItemTypeAsync` | Cần đọc loại item | `itemId` | `InventoryResponseData` | Map `itemType` bằng `ItemType` | `Ok`, `ItemNotFound` |
| `getOwnerAsync` | Cần đọc owner hiện tại | `itemId` | `InventoryResponseData` | Map `owner.type` bằng `OwnerType` | `Ok`, `ItemNotFound` |
| `getRemoveStatusAsync` | Cần đọc trạng thái remove | `itemId` | `InventoryResponseData` | Kết quả ở `infoResponseParameters.removeStatus` | `Ok`, `ItemNotFound` |
| `getSegmentAsync` | Cần đọc danh sách segment | `itemId` | `InventoryResponseData` | Kết quả ở `infoResponseParameters.segments` | `Ok`, `ItemNotFound` |
| `getTagAsync` | Cần đọc tag theo danh sách key | `itemId`, `tagKeys` | `InventoryResponseData` | Không query theo value | `Ok`, `ItemNotFound` |
| `getTsCreateAsync` | Cần đọc thời điểm tạo item | `itemId` | `InventoryResponseData` | Kết quả ở `infoResponseParameters.tsCreate` | `Ok`, `ItemNotFound` |

### Query danh sách, leaderboard và log

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `getItemsWithDisplayNameAsync` | Tìm item theo tên hiển thị | `keyword`, `infoRequestParam`, `skip?`, `limit?` | `InventoriesWithItemIdResponseData` | `keyword` tối thiểu 2 ký tự | `Ok` |
| `getItemsWithSegmentAsync` | Tìm item theo segment | `value`, `infoRequestParam`, `skip?`, `limit?` | `InventoriesWithItemIdResponseData` | Query theo exact segment value | `Ok` |
| `getItemsWithTagAsync` | Tìm item theo tag | `key`, `value`, `infoRequestParam`, `skip?`, `limit?` | `InventoriesWithItemIdResponseData` | Query theo cặp `key/value` | `Ok`, `KeyNotFound` |
| `getStatisticsLeaderboardAroundItemAsync` | Cần bảng xếp hạng quanh một item cụ thể | `itemId`, `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `catalogId?` | `GetStatisticsLeaderboardResponseData` | Dùng khi cần vị trí tương đối quanh item đó | `Ok`, `KeyNotFound` |
| `getStatisticsLeaderboardAsync` | Cần bảng xếp hạng statistics toàn cục theo key | `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `version?`, `catalogId?` | `GetStatisticsLeaderboardResponseData` | `version` chỉ có ở method này | `Ok`, `KeyNotFound`, `VersionInvalid` |
| `getCreateLeaderboardAsync` | Cần bảng xếp hạng theo thời điểm tạo item | `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetCreateLeaderboardResponseData` | Không cần statistics key | `Ok` |
| `getStatisticsLogAsync` | Cần audit statistics change log | `keys?`, `itemId?`, `limit?`, `token?` | `GetStatisticsLogResponseData` | Phân trang bằng `token` | `Ok` |

### Mutation

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `addSegmentAsync` | Gắn thêm segment cho item | `itemId`, `value` | `EmptyResponseData` | Thêm một segment value | `Ok`, `ItemNotFound` |
| `removeSegmentAsync` | Gỡ một segment khỏi item | `itemId`, `value` | `EmptyResponseData` | Xóa theo exact value | `Ok`, `ItemNotFound` |
| `setTagAsync` | Set hoặc upsert một tag | `itemId`, `key`, `value` | `EmptyResponseData` | Thao tác theo một cặp key/value | `Ok`, `KeyNotFound`, `ItemNotFound` |
| `removeTagAsync` | Xóa tag theo key | `itemId`, `key` | `EmptyResponseData` | Không truyền `value` | `Ok`, `ItemNotFound` |
| `setAmountAsync` | Set lại amount tuyệt đối | `itemId`, `amount` | `InventoryResponseData` | Không phải delta | `Ok`, `ItemNotFound`, `ItemNotStackable` |
| `setAvatarAsync` | Set avatar của item | `itemId`, `type`, `value` | `EmptyResponseData` | `type` chưa có enum public | `Ok`, `ItemNotFound` |
| `setCustomDataAsync` | Set custom data theo nhiều key | `itemId`, `customDatas[]` | `InventoryResponseData` | Mỗi phần tử là `key/value` | `Ok`, `KeyNotFound`, `ItemNotFound` |
| `setDisplayNameAsync` | Set display name | `itemId`, `displayName` | `EmptyResponseData` | Display name có min length 5 | `Ok`, `ItemNotFound` |
| `setItemDataAsync` | Set item data theo nhiều key | `itemId`, `itemDatas[]` | `InventoryResponseData` | Mỗi phần tử là `key/value` | `Ok`, `KeyNotFound`, `ItemNotFound` |
| `changeItemStatisticsAsync` | Cộng/trừ statistics | `itemId`, `itemStatistics[]`, `log?` | `InventoryResponseData` | Dùng cho delta change | `Ok`, `KeyNotFound`, `ItemNotFound` |
| `setOwnerAsync` | Chuyển owner của item | `itemId`, `newOwnerId`, `newOwnerType` | `EmptyResponseData` | Map `newOwnerType` bằng `OwnerType` | `Ok`, `ItemNotFound`, `OwnerNotFound`, `OwnerTypeNotSupport` |
| `setRemoveStatusAsync` | Đánh dấu item bị remove | `itemId`, `reason?` | `EmptyResponseData` | Không phải hard delete | `Ok`, `ItemNotFound` |

## 5. Enum và Reference

- DTO fields: [reference/dto/INVENTORY.md](/docs/reference/dto/INVENTORY.md). Method table: [reference/API_INVENTORY.md](/docs/reference/API_INVENTORY.md).
- Enums: [ItemType](/docs/reference/ENUMS.md#itemtype), [OwnerType](/docs/reference/ENUMS.md#ownertype).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/Inventory*.cs`, `Runtime/Entity/Models/GenericModels.cs`.
- `InfoResponseParameters.itemType` nên map bằng `ItemType`.
- `InfoResponseParameters.owner.type` và `SetOwnerRequestData.newOwnerType` nên map bằng `OwnerType`.
- `GenericModels.AvatarItem.type` và `SetAvatarRequestData.type` hiện chưa có enum public trong package. Nếu backend có enum riêng, phải dùng spec backend đó.

## 6. InfoRequestParam Rules

`InventoryModels.InfoRequestParam` điều khiển payload trả về trong:

- `getItemInformationAsync`
- `getItemsWithDisplayNameAsync`
- `getItemsWithSegmentAsync`
- `getItemsWithTagAsync`
- `getStatisticsLeaderboardAroundItemAsync`
- `getStatisticsLeaderboardAsync`
- `getCreateLeaderboardAsync`

Rule cứng:

- Không truyền `null`.
- Không bật toàn bộ field một cách mù quáng.
- Chỉ bật field mà màn hình hoặc flow hiện tại thật sự cần.
- Nếu cần filter dữ liệu con, dùng các field key-filter tương ứng:
    - `itemDataKeys`
    - `itemStatisticsKeys`
    - `customDataKeys`
    - `tagKeys`
- Nếu chỉ cần 1 field đơn lẻ như amount hoặc owner, ưu tiên getter chuyên biệt như `getAmountAsync` hoặc `getOwnerAsync` thay vì `getItemInformationAsync`.

Các field thường dùng:

- `catalogId`
- `classId`
- `itemType`
- `amount`
- `owner`
- `removeStatus`
- `segments`
- `customDatas`
- `displayName`
- `avatar`
- `tsCreate`
- `tags`
- `itemStatistics`
- `itemDatas`

## 7. Decision Rules

- Cần đọc đúng 1 field nhỏ của item: ưu tiên getter chuyên biệt.
- Cần lấy nhiều field trong một lần gọi: dùng `getItemInformationAsync`.
- Cần search item theo tên: dùng `getItemsWithDisplayNameAsync`.
- Cần search item theo segment: dùng `getItemsWithSegmentAsync`.
- Cần search item theo tag: dùng `getItemsWithTagAsync`.
- Cần leaderboard theo statistics key: dùng `getStatisticsLeaderboardAsync`.
- Cần leaderboard quanh một item cụ thể: dùng `getStatisticsLeaderboardAroundItemAsync`.
- Cần leaderboard theo thời điểm tạo: dùng `getCreateLeaderboardAsync`.
- Cần cộng/trừ stats: dùng `changeItemStatisticsAsync`.
- Cần set lại amount tuyệt đối: dùng `setAmountAsync`.
- Cần chuyển item sang owner mới: dùng `setOwnerAsync`.
- Cần audit biến động statistics: dùng `getStatisticsLogAsync`.

## 8. Response Rules

Tất cả typed response của `InventoryApi` đều có:

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

- Hầu hết getter đơn lẻ trả `InventoryResponseData` và dữ liệu nằm trong `responseData.infoResponseParameters`.
- Các method list `getItemsWith*Async` trả `responseData.results`, mỗi phần tử có `itemId` và `infoResponseParameters`.
- `getStatisticsLeaderboardAroundItemAsync` và `getStatisticsLeaderboardAsync` trả `responseData.results` có `itemId`, `position`, `backupValue?`, `infoResponseParameters`.
- `getCreateLeaderboardAsync` trả `responseData.results` cùng shape leaderboard item.
- `getStatisticsLogAsync` trả `responseData.results` và có thể có `responseData.token` cho page tiếp.
- `addSegmentAsync`, `removeSegmentAsync`, `removeTagAsync`, `setAvatarAsync`, `setDisplayNameAsync`, `setOwnerAsync`, `setRemoveStatusAsync`, `setTagAsync` trả `EmptyResponseData`.
- `setAmountAsync`, `setCustomDataAsync`, `setItemDataAsync`, `changeItemStatisticsAsync` trả `InventoryResponseData`.

## 9. Cảnh Báo Implementation Hiện Tại

- `SetOwnerRequestData.itemId` hiện được decorate với length `11..11`, trong khi hầu hết request inventory khác dùng `12..12`.
- Đây là điểm không nhất quán trong model hiện tại.
- Nếu bạn tự thêm validation ngoài SDK, không được tự hardcode thêm rule khác trước khi verify backend spec thật.
- `GetItemStatisticsRequestData` dùng `statisticsKeys`, còn `InfoRequestParam` dùng `itemStatisticsKeys`. Đây là hai input khác nhau, đừng trộn lẫn.

## 10. Best Practices

- Dùng getter chuyên biệt khi chỉ cần một field nhỏ.
- Với query lớn, giữ `infoRequestParam` tối giản để giảm payload.
- Với `getStatisticsLogAsync`, nên truyền ít nhất `keys` hoặc `itemId` trong production để tránh query quá rộng.
- Với leaderboard, dùng `loadFromCache` mặc định nếu chấp nhận dữ liệu cache; chỉ đổi khi bạn thật sự hiểu trade-off.
- Với `changeItemStatisticsAsync`, luôn truyền `log` nếu flow cần audit.
- Với `setOwnerAsync`, luôn map `newOwnerType` bằng `OwnerType`, không dùng số thô.
- Với `setAvatarAsync`, giữ `type` theo đúng backend contract vì package chưa có enum public.

## 11. Ví dụ Khuyến Nghị

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

var request = new InventoryModels.GetItemInformationRequestData();
request.itemId = "ABCDEFGHIJKL";
request.infoRequestParam = infoRequestParam;

var response = await GNNetwork.inventory.getItemInformationAsync(request);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

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

var request = new InventoryModels.ChangeItemStatisticsRequestData();
request.itemId = "ABCDEFGHIJKL";
request.itemStatistics = new[] { statisticsParam };
request.log = "award_kill_from_match_end";

var response = await GNNetwork.inventory.changeItemStatisticsAsync(request);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}
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

var request = new InventoryModels.GetStatisticsLeaderboardAroundItemRequestData();
request.itemId = "ABCDEFGHIJKL";
request.key = "killCount";
request.infoRequestParam = infoRequestParam;
request.skip = 0;
request.limit = 20;
request.loadFromCache = true;

var response = await GNNetwork.inventory.getStatisticsLeaderboardAroundItemAsync(request);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

var results = response.responseData.results;
```

### Đọc statistics log với cursor

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var request = new InventoryModels.GetStatisticsLogRequestData();
request.itemId = "ABCDEFGHIJKL";
request.keys = new[] { "killCount" };
request.limit = 20;

var response = await GNNetwork.inventory.getStatisticsLogAsync(request);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

var logs = response.responseData.results;
var nextToken = response.responseData.token;
```

## 12. Anti-Patterns

- Không gọi `getItemInformationAsync` chỉ để đọc một field đơn lẻ nếu getter chuyên biệt đã có.
- Không bỏ `infoRequestParam` ở các method bắt buộc.
- Không dùng `itemStatisticsKeys` thay cho `statisticsKeys` hoặc ngược lại.
- Không dùng `setAmountAsync` khi ý đồ là tăng/giảm delta.
- Không dùng `setOwnerAsync` nếu mục tiêu là duplicate item cho owner mới.
- Không hardcode số cho `ItemType` hoặc `OwnerType`.
- Không tự phát minh enum cho `avatar.type` nếu package chưa export.
- Không phân trang `getStatisticsLogAsync` bằng `skip`.
- Không bỏ qua kiểm tra `hasReturnCodeError()` và `errorCode`.

## 13. AI Checklist

- Đã `Resources/GNServerSettings` chưa.
- Có chọn đúng namespace `inventory` / `inventory.server` / `inventory.admin` chưa.
- Có nhớ rằng `InventoryApi` hiện chỉ đi qua HTTP không.
- Flow hiện tại là getter chuyên biệt, aggregate info, list query, leaderboard hay mutation.
- Nếu đang gọi method có `infoRequestParam`, đã truyền object này chưa.
- Nếu đang đọc statistics theo getter chuyên biệt, có dùng đúng `statisticsKeys` chưa.
- Nếu đang map `itemType` hoặc owner type, có dùng enum publish thay vì số thô không.
- Nếu đang đọc log, có dùng `token` cho page tiếp chưa.
- Có kiểm tra `hasReturnCodeError()` trước `errorCode` chưa.
