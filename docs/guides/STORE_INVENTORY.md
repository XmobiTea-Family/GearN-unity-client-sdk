# StoreInventoryApi

Tài liệu này là landing page cho AI code assistant khi cần dùng `GNNetwork.storeInventory*`. Đọc file này để chọn đúng namespace, method, DTO nhanh, và chỉ mở đúng row trong [API_STORE_INVENTORY.md](/docs/reference/API_STORE_INVENTORY.md) khi cần contract chi tiết.

## 1. Scope

- Áp dụng cho `GNNetwork.storeInventory`, `GNNetwork.storeInventory.server`, và `GNNetwork.storeInventory.admin`.
- Tất cả method hiện tại của `StoreInventoryApi` đi qua HTTP; không dùng socket.
- `StoreInventoryApi` có 3 role thật:
    - `GNNetwork.storeInventory` -> `RequestRole.Client`
    - `GNNetwork.storeInventory.server` -> `RequestRole.Server`
    - `GNNetwork.storeInventory.admin` -> `RequestRole.Admin`
- Payload shape giữa `client`, `server`, `admin` của cùng một operation giống nhau theo ý nghĩa nghiệp vụ; khác biệt chính là request DTO variant và role.
- Store flow gồm catalog/discovery, buy/present, receipt validation, log audit, và used-state.
- Rule chọn route/permission canonical: [RULES.md route rules](/docs/RULES.md). Với `StoreInventoryApi`, không tự suy diễn route chỉ từ target ownership.

## 2. Hard Rules

- Ưu tiên `async/await`; mặc định dùng `*Async()`.
- Bắt buộc đã có `Resources/GNServerSettings` trước khi gọi.
- Không dùng socket cho `StoreInventoryApi`.
- Chọn namespace theo actor thật đang chạy code: Unity client, trusted backend, hay admin/backoffice tool.
- Chỉ dùng `.server` khi code chạy trong trusted backend/worker và secret có permission `serverSelfEnable` phù hợp.
- Chỉ dùng `.admin` khi code chạy trong dashboard/backoffice/admin tool và secret có permission `adminSelfEnable` phù hợp.
- Không hardcode số cho `storeItemType`, `storeReceiveTypes`, hoặc owner `type`; dùng enum public.
- `getStoreItemInformationAsync`, `getStoreItemsWithTagAsync`, và `getCreateLeaderboardAsync` bắt buộc có `infoRequestParam`.
- `getStoreLogAsync` dùng `token` để phân trang tiếp; không tự đổi sang offset/skip pagination.
- `removeStoreUsedAsync` có `ownerIds` optional; nếu chưa có backend spec rõ ràng, không bỏ trống trường này một cách mù quáng.

## 3. Chọn Namespace

<!-- prettier-ignore -->
| Namespace | Role thật | Dùng khi nào |
| --- | --- | --- |
| `GNNetwork.storeInventory` | `Client` | Flow từ Unity client / player app: đọc catalog, mua item, validate receipt cho session hiện tại |
| `GNNetwork.storeInventory.server` | `Server` | Trusted backend, server worker, purchase fulfillment |
| `GNNetwork.storeInventory.admin` | `Admin` | Dashboard, ops, GM tool, quản trị catalog/log |

Rule nhanh:

- Code chạy trong game client: ưu tiên `GNNetwork.storeInventory`.
- Code chạy ở trusted backend hoặc worker: ưu tiên `GNNetwork.storeInventory.server`.
- Code chạy ở dashboard/tool vận hành: ưu tiên `GNNetwork.storeInventory.admin`.
- Cần thao tác cùng operation nhưng khác quyền: giữ nguyên method, đổi namespace cho đúng role.
- Chỉ dùng `overrideSecretKey` khi có chủ đích override secret mặc định theo role cho một request.

## 4. Chọn Method

Đọc bảng này trước. Cột API contract rows trỏ thẳng đến row cần đọc trong `API_STORE_INVENTORY.md`; không cần mở full file API.

> Khi thấy [client:16-16](/docs/example.md) nghĩa là chỉ cần đọc đúng từ dòng 16 đến 16 (hoặc gọi chính xác là đọc đúng dòng 16) của tài liệu `/docs/example.md`, tương tự với những cái khác, ví dụ [client:12-15] nghĩa là đọc đúng từ dòng 12 đến 15 của tài liệu, nếu có tool đọc từ startLine đến endLine ưu tiên cái này thay vì mở toàn bộ file.

> Thứ tự columns `API contract rows` của `client`, `server` và `admin` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |`.

### Catalog và Discovery

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `createStoreItemAsync` | Tạo store item mới | `storeId?`, `displayName?` | `responseData.storeId` | [client:19-19](/docs/reference/API_STORE_INVENTORY.md) / [server:39-39](/docs/reference/API_STORE_INVENTORY.md) / [admin:59-59](/docs/reference/API_STORE_INVENTORY.md) |
| `setStoreItemInformationAsync` | Cập nhật catalog, giá, IAP mapping, metadata | `storeId` và field cần đổi | `StoreInventoryResponseData` | [client:21-21](/docs/reference/API_STORE_INVENTORY.md) / [server:41-41](/docs/reference/API_STORE_INVENTORY.md) / [admin:61-61](/docs/reference/API_STORE_INVENTORY.md) |
| `setRemoveStatusAsync` | Đánh dấu remove/hide store item | `storeId`, `reason?` | `EmptyResponseData` | [client:20-20](/docs/reference/API_STORE_INVENTORY.md) / [server:40-40](/docs/reference/API_STORE_INVENTORY.md) / [admin:60-60](/docs/reference/API_STORE_INVENTORY.md) |
| `getStoreItemInformationAsync` | Đọc chi tiết một store item | `storeId`, `infoRequestParam` | `responseData.infoResponseParameters` | [client:17-17](/docs/reference/API_STORE_INVENTORY.md) / [server:37-37](/docs/reference/API_STORE_INVENTORY.md) / [admin:57-57](/docs/reference/API_STORE_INVENTORY.md) |
| `getStoreItemsWithTagAsync` | Tìm store item theo tag | `key`, `value`, `infoRequestParam`, `skip?`, `limit?` | `responseData.results` | [client:18-18](/docs/reference/API_STORE_INVENTORY.md) / [server:38-38](/docs/reference/API_STORE_INVENTORY.md) / [admin:58-58](/docs/reference/API_STORE_INVENTORY.md) |
| `getCreateLeaderboardAsync` | Lấy leaderboard create của store item | `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `responseData.results` có `position` | [client:25-25](/docs/reference/API_STORE_INVENTORY.md) / [server:45-45](/docs/reference/API_STORE_INVENTORY.md) / [admin:65-65](/docs/reference/API_STORE_INVENTORY.md) |

### Purchase, Gift và Receipt

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `buyStoreItemAsync` | Mua store item bằng flow nội bộ | `storeId`, `id`, `type`, `log?` | `BuyStoreInventoryResponseData` | [client:16-16](/docs/reference/API_STORE_INVENTORY.md) / [server:36-36](/docs/reference/API_STORE_INVENTORY.md) / [admin:56-56](/docs/reference/API_STORE_INVENTORY.md) |
| `presentStoreItemAsync` | Tặng/phát store item | `storeId`, `id`, `type`, `log?` | `PresentStoreInventoryResponseData` | [client:26-26](/docs/reference/API_STORE_INVENTORY.md) / [server:46-46](/docs/reference/API_STORE_INVENTORY.md) / [admin:66-66](/docs/reference/API_STORE_INVENTORY.md) |
| `validateAppleAppStoreReceiptAsync` | Validate receipt Apple và fulfill purchase | `receipt`, `id`, `type`, `log?` | `BuyStoreInventoryResponseData` | [client:22-22](/docs/reference/API_STORE_INVENTORY.md) / [server:42-42](/docs/reference/API_STORE_INVENTORY.md) / [admin:62-62](/docs/reference/API_STORE_INVENTORY.md) |
| `validateFacebookStoreReceiptAsync` | Validate receipt Facebook và fulfill purchase | `receipt`, `id`, `type`, `log?` | `BuyStoreInventoryResponseData` | [client:23-23](/docs/reference/API_STORE_INVENTORY.md) / [server:43-43](/docs/reference/API_STORE_INVENTORY.md) / [admin:63-63](/docs/reference/API_STORE_INVENTORY.md) |
| `validateGooglePlayStoreReceiptAsync` | Validate receipt Google Play và fulfill purchase | `receipt`, `id`, `type`, `log?` | `BuyStoreInventoryResponseData` | [client:24-24](/docs/reference/API_STORE_INVENTORY.md) / [server:44-44](/docs/reference/API_STORE_INVENTORY.md) / [admin:64-64](/docs/reference/API_STORE_INVENTORY.md) |

### Audit và Used State

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `getStoreLogAsync` | Đọc transaction log của store | `storeId?`, `storeReceiveTypes?`, `id?`, `limit?`, `token?` | `responseData.results`, `responseData.token?` | [client:27-27](/docs/reference/API_STORE_INVENTORY.md) / [server:47-47](/docs/reference/API_STORE_INVENTORY.md) / [admin:67-67](/docs/reference/API_STORE_INVENTORY.md) |
| `getStoreUsedAsync` | Xem owner nào đã dùng store item | `storeId` | `responseData.results` | [client:28-28](/docs/reference/API_STORE_INVENTORY.md) / [server:48-48](/docs/reference/API_STORE_INVENTORY.md) / [admin:68-68](/docs/reference/API_STORE_INVENTORY.md) |
| `removeStoreUsedAsync` | Xóa used state của một hoặc nhiều owner | `storeId`, `ownerIds?` | `EmptyResponseData` | [client:29-29](/docs/reference/API_STORE_INVENTORY.md) / [server:49-49](/docs/reference/API_STORE_INVENTORY.md) / [admin:69-69](/docs/reference/API_STORE_INVENTORY.md) |

Decision rules:

- Cần tạo catalog item mới: dùng `createStoreItemAsync`, rồi nếu cần cấu hình chi tiết thì `setStoreItemInformationAsync`.
- Cần lấy chi tiết một store item: dùng `getStoreItemInformationAsync`.
- Cần listing/filter theo tag: dùng `getStoreItemsWithTagAsync`.
- Cần đánh dấu item bị remove/hide: dùng `setRemoveStatusAsync`.
- Cần mua item theo flow nội bộ: dùng `buyStoreItemAsync`.
- Cần tặng item: dùng `presentStoreItemAsync`.
- Cần xác thực IAP receipt: dùng đúng method theo provider, không dùng chéo provider.
- Cần audit transaction: dùng `getStoreLogAsync`.
- Cần xem trạng thái used hoặc reset used: dùng `getStoreUsedAsync` và `removeStoreUsedAsync`.

## 5. Method Signature

Mỗi method có 2 form: callback và `*Async()` Task. Mặc định sinh code bằng async form.

```csharp
// Callback
GNNetwork.storeInventory.<method>(requestData, onResponse, overrideAuthToken, overrideSecretKey, customTags, timeout);

// Async
var response = await GNNetwork.storeInventory.<method>Async(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
```

Param chung:

<!-- prettier-ignore -->
| Param | Type | Khi nào cần |
| --- | --- | --- |
| `requestData` | domain-specific DTO | Payload chính; tạo bằng `new StoreInventoryModels.<Method>RequestData()` |
| `onResponse` | `Action1<TResponse>` | Chỉ có ở callback form |
| `overrideAuthToken` | `string` | Impersonate / multi-session / admin thao tác bằng auth token khác |
| `overrideSecretKey` | `string` | Override secret key mặc định của role cho một request |
| `customTags` | `GNHashtable` | Trace id, build version, A/B bucket; backend có thể log/route |
| `timeout` | `int` | Override timeout theo request, tính bằng giây |

Typed response expose public fields: `returnCode`, `errorCode`, `invalidMembers`, `debugMessage`, `responseData`. Xem [RULES.md response checking](/docs/RULES.md).

## 6. Request Field Rules

- DTO fields: [reference/dto/STORE_INVENTORY.md](/docs/reference/dto/STORE_INVENTORY.md).
- Contract table: [reference/API_STORE_INVENTORY.md](/docs/reference/API_STORE_INVENTORY.md).
- Enums: [StoreItemType](/docs/reference/ENUMS.md#storeitemtype), [StoreReceiveType](/docs/reference/ENUMS.md#storereceivetype), [OwnerType](/docs/reference/ENUMS.md#ownertype).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/StoreInventory*.cs`.

<!-- prettier-ignore -->
| DTO / field | Quick rule | DTO link |
| --- | --- | --- |
| `CreateStoreItemRequestData.storeId` | optional; nếu bỏ trống, backend có thể tự sinh `storeId` | [StoreInventoryModels.CreateStoreItemRequestData:382-391](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#createstoreitemrequestdata) |
| `SetStoreItemInformationRequestData.storeItemType` | range `1..2`; map bằng `StoreItemType`, không hardcode số | [StoreInventoryModels.SetStoreItemInformationRequestData:450-476](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#setstoreiteminformationrequestdata) |
| `InfoRequestParam` | required cho `getStoreItemInformation`, `getStoreItemsWithTag`, `getCreateLeaderboard`; chỉ bật field cần render | [StoreInventoryModels.InfoRequestParam:649-678](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#inforequestparam) |
| owner `id` + `type` | `type` là `OwnerType`; dùng đúng owner id tương ứng với `MasterPlayer`, `GamePlayer`, `CharacterPlayer`, hoặc `Group` | [StoreInventoryModels.BuyStoreItemRequestData:127-138](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#buystoreitemrequestdata) |
| receipt `receipt` | dùng đúng provider method theo source receipt: Apple, Facebook, hoặc Google Play | [google:573-584](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#validategoogleplaystorereceiptrequestdata) |
| `GetStoreLogRequestData.storeReceiveTypes` | map bằng `StoreReceiveType`; `token` là cursor cho page tiếp | [StoreInventoryModels.GetStoreLogRequestData:199-211](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#getstorelogrequestdata) |
| `RemoveStoreUsedRequestData.ownerIds` | optional nhưng nguy hiểm nếu bỏ trống khi chưa rõ semantics backend | [StoreInventoryModels.RemoveStoreUsedRequestData:269-278](/docs/reference/dto/store-inventory/STORE_INVENTORY_MODELS.md#removestoreusedrequestdata) |

## 7. Store Flow

### Catalog

1. Tạo item bằng `createStoreItemAsync` nếu catalog chưa có.
2. Cấu hình chi tiết bằng `setStoreItemInformationAsync`: type, price, currency, IAP mapping, metadata, tag.
3. Client đọc catalog bằng `getStoreItemInformationAsync` hoặc `getStoreItemsWithTagAsync` với `infoRequestParam` tối giản.
4. Disable/hide item bằng `setRemoveStatusAsync` thay vì để client tự lọc theo convention riêng.

### Purchase và Receipt

1. Với flow tiền tệ nội bộ, gọi `buyStoreItemAsync`.
2. Với tặng/phát item, gọi `presentStoreItemAsync`.
3. Với IAP, gọi đúng method validate theo provider receipt.
4. Sau response thành công, đọc `responseData` theo response DTO; không đọc `responseData` khi `returnCode != Ok`.

### Audit và Used State

1. Dùng `getStoreLogAsync` để đọc transaction log; truyền `token` từ response trước để lấy page tiếp.
2. Dùng `getStoreUsedAsync` để xem owner đã dùng item.
3. Chỉ dùng `removeStoreUsedAsync` khi đã xác định rõ `ownerIds` cần reset.

## 8. Minimal Pattern

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new StoreInventoryModels.GetStoreItemInformationRequestData();
requestData.storeId = "store-item-001";
requestData.infoRequestParam = new StoreInventoryModels.InfoRequestParam {
    displayName = true,
    priceCurrencies = true,
    storeItemType = true
};

var response = await GNNetwork.storeInventory.getStoreItemInformationAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var storeInfo = response.responseData.infoResponseParameters;
```

Nếu codebase đã có helper riêng như `hasReturnCodeError()` và muốn throw exception thay vì early-return, vẫn phải giữ thứ tự check 2 tầng: `returnCode` trước, `errorCode` sau.

## 9. Ví dụ Khuyến Nghị

### Client đọc store item với infoRequestParam tối giản

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var infoRequestParam = new StoreInventoryModels.InfoRequestParam();
infoRequestParam.displayName = true;
infoRequestParam.priceCurrencies = true;
infoRequestParam.storeItemType = true;

var requestData = new StoreInventoryModels.GetStoreItemInformationRequestData();
requestData.storeId = "store-item-001";
requestData.infoRequestParam = infoRequestParam;

var response = await GNNetwork.storeInventory.getStoreItemInformationAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var storeInfo = response.responseData.infoResponseParameters;
```

### Client mua store item

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new StoreInventoryModels.BuyStoreItemRequestData();
requestData.storeId = "store-item-001";
requestData.id = "1234567890";
requestData.type = OwnerType.MasterPlayer;
requestData.log = "buy from shop popup";

var response = await GNNetwork.storeInventory.buyStoreItemAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var result = response.responseData;
```

### Server validate Google Play receipt

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new StoreInventoryModels.ServerValidateGooglePlayStoreReceiptRequestData();
requestData.receipt = googleReceiptPayload;
requestData.id = "1234567890";
requestData.type = OwnerType.MasterPlayer;
requestData.log = "google-play-checkout";

var response = await GNNetwork.storeInventory.server.validateGooglePlayStoreReceiptAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var result = response.responseData;
```

### Đọc store log với filter và cursor

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new StoreInventoryModels.GetStoreLogRequestData();
requestData.storeId = "store-item-001";
requestData.storeReceiveTypes = new[] { StoreReceiveType.Buy, StoreReceiveType.GooglePlayStore };
requestData.limit = 20;

var response = await GNNetwork.storeInventory.getStoreLogAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var logs = response.responseData.results;
var nextToken = response.responseData.token;
```

## 10. Anti-Patterns

- Không hardcode số cho `storeItemType`, `storeReceiveTypes`, `type`.
- Không bỏ `infoRequestParam` ở các method bắt buộc.
- Không bật toàn bộ field trong `infoRequestParam` nếu màn hình chỉ cần vài field.
- Không dùng receipt của provider này cho method validate của provider khác.
- Không dùng `getStoreLogAsync` như offset pagination khi API đã có `token`.
- Không bỏ trống `ownerIds` trong `removeStoreUsedAsync` nếu chưa hiểu backend sẽ xử lý thế nào.
- Không giả định `storeItems` trong response buy/present luôn deserialize đúng nếu bạn chưa verify runtime.
- Không bỏ qua check `returnCode` trước `errorCode`.
- Không dùng callback style mặc định khi codebase đã support `async/await`.

## 11. AI Checklist

- Đã có `Resources/GNServerSettings` chưa.
- Đã chọn đúng namespace `storeInventory` / `storeInventory.server` / `storeInventory.admin` chưa.
- Có nhớ `StoreInventoryApi` chỉ đi qua HTTP không.
- Nếu request có numeric enum field, có dùng enum public thay vì số thô không.
- Nếu đang gọi `getStoreItemInformationAsync`, `getStoreItemsWithTagAsync`, hoặc `getCreateLeaderboardAsync`, có truyền `infoRequestParam` chưa.
- Nếu đang đọc log, có dùng `token` cho page tiếp chưa.
- Nếu đang validate receipt, method có đúng provider không.
- Có check `returnCode` trước `errorCode` chưa.

## Quick Map

Dùng bảng này để đọc đúng dòng mà không load cả file. `offset = startLine - 1`, `limit = endLine - startLine + 1`.

<!-- prettier-ignore -->
| Section | Lines |
| --- | --- |
| §3 Chọn Namespace | 30-45 |
| §4 Chọn Method — Catalog và Discovery | 55-65 |
| §4 Chọn Method — Purchase, Gift và Receipt | 67-76 |
| §4 Chọn Method — Audit và Used State | 78-97 |
| §8 Minimal Pattern | 167-188 |
| §9 Ví Dụ Khuyến Nghị | 192-279 |
