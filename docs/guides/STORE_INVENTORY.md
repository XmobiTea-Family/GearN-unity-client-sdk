# StoreInventoryApi

Tài liệu này dành cho AI code assistant và AI agent nội bộ. Mục tiêu là chọn đúng namespace `client/server/admin`, dùng đúng enum cho store flow, và không sinh sai request ở các nhóm mua/quà/receipt/log.

## 1. Scope

- Áp dụng cho:
    - `GNNetwork.storeInventory`
    - `GNNetwork.storeInventory.server`
    - `GNNetwork.storeInventory.admin`
- Toàn bộ method hiện tại của `StoreInventoryApi` đều gửi qua HTTP.
- `StoreInventoryApi` có đủ 3 role thật:
    - `GNNetwork.storeInventory` -> `RequestRole.Client`
    - `GNNetwork.storeInventory.server` -> `RequestRole.Server`
    - `GNNetwork.storeInventory.admin` -> `RequestRole.Admin`
- Nếu không truyền `overrideSecretKey`, SDK sẽ tự lấy secret key theo role tương ứng.
- Chỉ dùng namespace `.server` khi bạn đã cấu hình `secretKey` với `permission rules` `server` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Chỉ dùng namespace `.admin` khi bạn đã cấu hình `secretKey` với `permission rules` `admin` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Rule chuẩn để chọn `client/server/admin` và hiểu semantics permission xem [RULES](/docs/RULES.md#3-route--trust-boundary-của-caller). Với nhóm này, không tự suy diễn route chỉ từ target ownership.
- Khác với `MultiplayerApi`, namespace `server/admin` ở đây không thêm field `userId`; payload shape giữa 3 role hiện gần như giống nhau.

## 2. Hard Rules

- Luôn ưu tiên `async/await`. Mặc định dùng `*Async()`.
- Bắt buộc đã `Resources/GNServerSettings` trước khi gọi.
- Không dùng socket cho `StoreInventoryApi`.
- Không hardcode số cho `storeItemType`, `storeReceiveTypes` hoặc `type` nếu enum đã có.
- `getStoreItemInformationAsync`, `getStoreItemsWithTagAsync` và `getCreateLeaderboardAsync` đều bắt buộc có `infoRequestParam`.
- `getStoreLogAsync` dùng `token` để phân trang tiếp, không dùng `skip`.
- `createStoreItemAsync` có `storeId` optional; nếu bạn bỏ trống, backend có thể tự sinh `storeId`.
- `removeStoreUsedAsync` có `ownerIds` optional; nếu chưa có backend spec rõ ràng, không được bỏ trống trường này một cách mù quáng.

## 3. Chọn Namespace

<!-- prettier-ignore -->
| Namespace | Role thật | Dùng khi nào |
| --- | --- | --- |
| `GNNetwork.storeInventory` | `Client` | client/player mua item hoặc đọc store catalog cho chính session hiện tại |
| `GNNetwork.storeInventory.server` | `Server` | trusted backend, server worker, purchase fulfillment |
| `GNNetwork.storeInventory.admin` | `Admin` | dashboard, ops, GM tool, quản trị store |

Rule nhanh:

- Nếu flow mua/validate diễn ra từ player app: ưu tiên `GNNetwork.storeInventory`.
- Nếu flow này chạy ở backend tin cậy: ưu tiên `GNNetwork.storeInventory.server`.
- Nếu thao tác vận hành hoặc quản trị catalog/log: ưu tiên `GNNetwork.storeInventory.admin`.

## 4. Chọn Method

### Catalog và discovery

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `createStoreItemAsync` | Tạo store item mới | `storeId?`, `displayName?` | `CreateStoreItemResponseData` | Nếu bỏ `storeId`, backend có thể sinh id | `Ok`, `StoreItemExists` |
| `setStoreItemInformationAsync` | Cập nhật catalog, giá, IAP mapping, metadata | `storeId` và field cần đổi | `StoreInventoryResponseData` | `storeItemType` nên map bằng enum | `Ok`, `StoreItemNotFound`, `StoreInvalid` |
| `setRemoveStatusAsync` | Đánh dấu remove/hide store item | `storeId`, `reason?` | `EmptyResponseData` | Thường dùng để disable item | `Ok`, `StoreItemNotFound` |
| `getStoreItemInformationAsync` | Đọc chi tiết một store item | `storeId`, `infoRequestParam` | `StoreInventoryResponseData` | Chỉ bật field thật sự cần trong `infoRequestParam` | `Ok`, `StoreItemNotFound` |
| `getStoreItemsWithTagAsync` | Tìm store item theo tag | `key`, `value`, `infoRequestParam`, `skip?`, `limit?` | `StoreInventoriesWithStoreIdResponseData` | Hữu ích cho listing/filter | `Ok` |
| `getCreateLeaderboardAsync` | Lấy leaderboard create của store item | `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetCreateLeaderboardResponseData` | Response có `position` | `Ok` |

### Purchase, gift và receipt

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `buyStoreItemAsync` | Mua store item bằng flow nội bộ | `storeId`, `id`, `type`, `log?` | `BuyStoreInventoryResponseData` | `type` nên map bằng `OwnerType` | `Ok`, `NotEnoughCurrency`, `StoreItemNotFound`, `BuyerNotFound`, `CanNotBuyThisStoreItem`, `StoreItemRemoved`, `StoreItemPurchasedAndNonConsumable` |
| `presentStoreItemAsync` | Tặng/phát store item | `storeId`, `id`, `type`, `log?` | `PresentStoreInventoryResponseData` | `type` nên map bằng `OwnerType` | `Ok`, `StoreItemNotFound`, `BuyerNotFound`, `StoreItemRemoved`, `StoreItemPurchasedAndNonConsumable` |
| `validateAppleAppStoreReceiptAsync` | Validate receipt Apple và fulfill purchase | `receipt`, `id`, `type`, `log?` | `BuyStoreInventoryResponseData` | `type` nên map bằng `OwnerType` | `Ok`, `StoreItemNotFound`, `BuyerNotFound`, `ExceptionWhenValidateReceipt`, `StoreInvalid`, `ReceiptInvalid`, `StoreItemRemoved`, `StoreItemPurchasedAndNonConsumable` |
| `validateFacebookStoreReceiptAsync` | Validate receipt Facebook và fulfill purchase | `receipt`, `id`, `type`, `log?` | `BuyStoreInventoryResponseData` | `type` nên map bằng `OwnerType` | `Ok`, `StoreItemNotFound`, `BuyerNotFound`, `ExceptionWhenValidateReceipt`, `StoreInvalid`, `ReceiptInvalid`, `StoreItemRemoved`, `StoreItemPurchasedAndNonConsumable` |
| `validateGooglePlayStoreReceiptAsync` | Validate receipt Google Play và fulfill purchase | `receipt`, `id`, `type`, `log?` | `BuyStoreInventoryResponseData` | `type` nên map bằng `OwnerType` | `Ok`, `StoreItemNotFound`, `BuyerNotFound`, `ExceptionWhenValidateReceipt`, `StoreInvalid`, `ReceiptInvalid`, `StoreItemRemoved`, `StoreItemPurchasedAndNonConsumable` |

### Audit và used state

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `getStoreLogAsync` | Đọc transaction log của store | `storeId?`, `storeReceiveTypes?`, `id?`, `limit?`, `token?` | `GetStoreLogResponseData` | `token` là cursor cho page tiếp | `Ok` |
| `getStoreUsedAsync` | Xem owner nào đã dùng store item | `storeId` | `GetStoreUsedResponseData` | Trả list owner id/type | `Ok` |
| `removeStoreUsedAsync` | Xóa used state của một hoặc nhiều owner | `storeId`, `ownerIds?` | `EmptyResponseData` | Chỉ gọi khi hiểu rõ hậu quả | `Ok` |

## 5. Enum và Reference

- DTO fields: [reference/dto/STORE_INVENTORY.md](/docs/reference/dto/STORE_INVENTORY.md). Method table: [reference/API_STORE_INVENTORY.md](/docs/reference/API_STORE_INVENTORY.md).
- Enums: [StoreItemType](/docs/reference/ENUMS.md#storeitemtype), [StoreReceiveType](/docs/reference/ENUMS.md#storereceivetype), [OwnerType](/docs/reference/ENUMS.md#ownertype).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/StoreInventory*.cs`.
- `SetStoreItemInformationRequestData.storeItemType` có range `1..2`, nên map bằng `StoreItemType`.
- `GetStoreLogRequestData.storeReceiveTypes` nên map bằng `StoreReceiveType`.
- `BuyStoreItemRequestData.type`, `PresentStoreItemRequestData.type` và các request validate receipt, là OwnerType; theo model/response hiện tại map bằng `OwnerType`.

## 6. InfoRequestParam Rules

`StoreInventoryModels.InfoRequestParam` điều khiển payload trả về trong:

- `getStoreItemInformationAsync`
- `getStoreItemsWithTagAsync`
- `getCreateLeaderboardAsync`

Rule cứng:

- Không truyền `null`.
- Không bật toàn bộ field một cách mù quáng.
- Chỉ bật field mà màn hình hoặc flow hiện tại thật sự cần.

Các field thường dùng:

- `storeItems`
- `storeItemType`
- `storeCurrencies`
- `priceCurrencies`
- `inAppPurchase`
- `removeStatus`
- `displayName`
- `avatar`
- `tsCreate`
- `tags`
- `storeDatas`

## 7. Decision Rules

- Cần tạo catalog item mới: dùng `createStoreItemAsync`, rồi nếu cần cấu hình chi tiết thì `setStoreItemInformationAsync`.
- Cần lấy chi tiết một store item: dùng `getStoreItemInformationAsync`.
- Cần listing theo tag: dùng `getStoreItemsWithTagAsync`.
- Cần đánh dấu item bị remove/hide: dùng `setRemoveStatusAsync`.
- Cần mua item theo flow nội bộ: dùng `buyStoreItemAsync`.
- Cần tặng item: dùng `presentStoreItemAsync`.
- Cần xác thực IAP receipt: dùng đúng method theo provider, không dùng chéo provider.
- Cần audit transaction: dùng `getStoreLogAsync`.
- Cần xem trạng thái used hoặc reset used: dùng `getStoreUsedAsync` và `removeStoreUsedAsync`.

## 8. Response Rules

Tất cả typed response của `StoreInventoryApi` đều có:

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

- `createStoreItemAsync` trả `responseData.storeId`.
- `getStoreItemInformationAsync` trả `responseData.infoResponseParameters`.
- `getStoreItemsWithTagAsync` trả `responseData.results`.
- `setStoreItemInformationAsync` trả lại `StoreInventoryResponseData`.
- `buyStoreItemAsync` và các method validate receipt trả `BuyStoreInventoryResponseData`.
- `presentStoreItemAsync` trả `PresentStoreInventoryResponseData`.
- `getCreateLeaderboardAsync` trả `results` có `position` và store info.
- `getStoreLogAsync` trả `results` và có thể có `token` để gọi page tiếp.
- `getStoreUsedAsync` trả `results`.

### Cảnh báo implementation hiện tại

- Trong model hiện tại, `BuyStoreInventoryResponseData.storeItems` và `PresentStoreInventoryResponseData.storeItems` đang được decorate bằng `ParameterCode.StoreCurrencies`.
- Đây có thể là issue mapping của package hiện tại.
- Nếu bạn phụ thuộc mạnh vào field `storeItems`, hãy verify runtime thực tế thay vì giả định deserialize luôn đúng.

## 9. Best Practices

- Dùng enum thay vì số thô cho `StoreItemType`, `StoreReceiveType`, `OwnerType`.
- Với catalog query, giữ `infoRequestParam` tối giản.
- Với receipt validation, luôn gọi đúng provider method theo source receipt.
- Với `getStoreLogAsync`, dùng `token` để page tiếp thay vì tự suy diễn offset.
- Với `removeStoreUsedAsync`, chỉ truyền `ownerIds` đã được xác nhận rõ.
- Với `createStoreItemAsync`, nếu backend đã có convention sinh `storeId`, đừng tự phát minh format id mới trong client nếu không cần.

## 10. Ví dụ Khuyến Nghị

### Đọc store item với infoRequestParam tối giản

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var infoRequestParam = new StoreInventoryModels.InfoRequestParam();
infoRequestParam.displayName = true;
infoRequestParam.priceCurrencies = true;
infoRequestParam.storeItemType = true;

var request = new StoreInventoryModels.GetStoreItemInformationRequestData();
request.storeId = "store-item-001";
request.infoRequestParam = infoRequestParam;

var response = await GNNetwork.storeInventory.getStoreItemInformationAsync(request);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

var storeInfo = response.responseData.infoResponseParameters;
```

### Mua store item

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var request = new StoreInventoryModels.BuyStoreItemRequestData();
request.storeId = "store-item-001";
request.id = "1234567890";
request.type = OwnerType.MasterPlayer;
request.log = "buy from shop popup";

var response = await GNNetwork.storeInventory.buyStoreItemAsync(request);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

var result = response.responseData;
```

### Validate Google Play receipt

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var request = new StoreInventoryModels.ValidateGooglePlayStoreReceiptRequestData();
request.receipt = googleReceiptPayload;
request.id = "1234567890";
request.type = OwnerType.MasterPlayer;
request.log = "google-play-checkout";

var response = await GNNetwork.storeInventory.validateGooglePlayStoreReceiptAsync(request);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}
```

### Đọc store log với filter và cursor

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var request = new StoreInventoryModels.GetStoreLogRequestData();
request.storeId = "store-item-001";
request.storeReceiveTypes = new[] { StoreReceiveType.Buy, StoreReceiveType.GooglePlayStore };
request.limit = 20;

var response = await GNNetwork.storeInventory.getStoreLogAsync(request);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

var logs = response.responseData.results;
var nextToken = response.responseData.token;
```

## 11. Anti-Patterns

- Không hardcode số cho `storeItemType`, `storeReceiveTypes`, `type`.
- Không bỏ `infoRequestParam` ở các method bắt buộc.
- Không dùng receipt của provider này cho method validate của provider khác.
- Không dùng `getStoreLogAsync` như offset pagination khi API đã có `token`.
- Không bỏ trống `ownerIds` trong `removeStoreUsedAsync` nếu chưa hiểu backend sẽ xử lý thế nào.
- Không giả định `storeItems` trong response buy/present luôn deserialize đúng nếu bạn chưa verify runtime.
- Không bỏ qua kiểm tra `returnCode` và `errorCode`.

## 12. AI Checklist

- Đã `Resources/GNServerSettings` chưa.
- Có chọn đúng namespace `storeInventory` / `storeInventory.server` / `storeInventory.admin` chưa.
- Có nhớ rằng `StoreInventoryApi` hiện chỉ đi qua HTTP không.
- Nếu request có numeric enum field, có dùng enum export thay vì số thô không.
- Nếu đang gọi `getStoreItemInformationAsync`, `getStoreItemsWithTagAsync` hoặc `getCreateLeaderboardAsync`, có truyền `infoRequestParam` chưa.
- Nếu đang đọc log, có dùng `token` cho page tiếp chưa.
- Nếu đang validate receipt, method có đúng provider không.
- Có kiểm tra `hasReturnCodeError()` trước `errorCode` chưa.
