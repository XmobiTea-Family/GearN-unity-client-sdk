# ContentApi

Tài liệu này dành cho AI code assistant và AI agent nội bộ. Mục tiêu là chọn đúng namespace `client/server/admin`, truyền đúng payload cho `GNNetwork.content*`, và không sinh sai sequence ở flow upload/download file.

## 1. Scope

- Áp dụng cho:
    - `GNNetwork.content`
    - `GNNetwork.content.server`
    - `GNNetwork.content.admin`
- Toàn bộ method hiện tại của `ContentApi` đều gửi qua HTTP.
- `ContentApi` có đủ 3 role thật:
    - `GNNetwork.content` -> `RequestRole.Client`
    - `GNNetwork.content.server` -> `RequestRole.Server`
    - `GNNetwork.content.admin` -> `RequestRole.Admin`
- Nếu không truyền `overrideSecretKey`, SDK sẽ tự lấy secret key theo role tương ứng.
- Chỉ dùng namespace `.server` khi bạn đã cấu hình `secretKey` với `permission rules` `server` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Chỉ dùng namespace `.admin` khi bạn đã cấu hình `secretKey` với `permission rules` `admin` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Rule chuẩn để chọn `client/server/admin` và hiểu semantics permission xem [RULES](/docs/RULES.md#3-route--trust-boundary-của-caller). Với nhóm này, không tự suy diễn route chỉ từ target ownership.
- Payload shape giữa `client`, `server`, `admin` của cùng một operation là giống nhau; khác biệt chính là role.
- `ContentApi` không upload byte trực tiếp. Nó chỉ quản lý metadata và token cho flow file; phần upload byte thật đi qua `GNNetwork.uploadFileAsync(...)`.

## 2. Hard Rules

- Luôn ưu tiên `async/await`. Mặc định dùng `*Async()`.
- Bắt buộc đã `Resources/GNServerSettings` trước khi gọi.
- Không dùng socket cho `ContentApi`.
- Chọn namespace theo đúng role của actor hiện tại. Không gọi nhầm `client` khi bạn đang sinh code cho server job hoặc admin tool.
- Flow upload file đúng là:
    1. `createNewFileUploadInfoAsync(...)`
    2. lấy `fileId` từ response
    3. `GNNetwork.uploadFileAsync(fileId, bytes, filename, mimetype)`
- Flow download file đúng là:
    1. `requestDownloadFileUploadInfoAsync(...)`
    2. lấy `downloadToken` từ response
    3. `GNNetwork.getDownloadFileUrl(downloadToken)`
- `setContentDataAsync(...)` bắt buộc có `configs`.
- `removeFileUploadInfoAsync(...)` là thao tác mutate/xóa metadata file. Chỉ gọi khi có chủ đích rõ ràng.

## 3. Chọn Namespace

<!-- prettier-ignore -->
| Namespace | Role thật | Dùng khi nào |
| --- | --- | --- |
| `GNNetwork.content` | `Client` | flow từ client/player app |
| `GNNetwork.content.server` | `Server` | server worker, backend integration, trusted service |
| `GNNetwork.content.admin` | `Admin` | dashboard, backoffice, tooling quản trị |

Rule nhanh:

- Nếu code chạy trong game client: ưu tiên `GNNetwork.content`.
- Nếu code chạy ở trusted backend hoặc worker: ưu tiên `GNNetwork.content.server`.
- Nếu code chạy ở dashboard/tool vận hành: ưu tiên `GNNetwork.content.admin`.
- Chỉ dùng `overrideSecretKey` khi bạn cố ý override hành vi mặc định theo role.

## 4. Chọn Method

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `getContentDataAsync` | Đọc content config theo key hoặc label | `keys?`, `label?` | `GetContentDataResponseData` | Dùng cho config/content data, không phải file binary | `Ok`, `GameNotFound` |
| `setContentDataAsync` | Tạo hoặc cập nhật content config | `configs`, `label?` | `EmptyResponseData` | Mỗi config cần `key` và `data` | `Ok`, `GameNotFound` |
| `createNewFileUploadInfoAsync` | Xin cấp `fileId` cho một file sẽ upload | `fileName` | `FileIdUploadResponseData` | Không upload byte ở bước này | `Ok` |
| `getFileUploadInfoListAsync` | Liệt kê metadata file upload | `skip?`, `limit?` | `GetFileUploadInfoListResponseData` | Phân trang mềm | `Ok` |
| `getFileUploadInfoAsync` | Xem chi tiết metadata của một file | `fileId` | `GetFileUploadInfoResponseData` | Trả cả `removeStatus`, `tsUploadExpire`, `fileUpload?` | `Ok`, `FileNotFound` |
| `removeFileUploadInfoAsync` | Gỡ metadata hoặc đánh dấu remove cho file | `fileId`, `reason?` | `EmptyResponseData` | Không phải API upload delete byte trực tiếp | `Ok`, `FileNotFound` |
| `requestDownloadFileUploadInfoAsync` | Xin download token cho file | `fileId` | `RequestDownloadFileUploadInfoResponseData` | Dùng tiếp với `GNNetwork.getDownloadFileUrl(...)` | `Ok`, `FileNotFound`, `FileNotUpload` |

## 5. Decision Rules

- Cần config dạng key/value structured: dùng `getContentDataAsync` hoặc `setContentDataAsync`.
- Cần upload file mới: dùng `createNewFileUploadInfoAsync` trước, sau đó `GNNetwork.uploadFileAsync`.
- Cần liệt kê file đã có: dùng `getFileUploadInfoListAsync`.
- Cần inspect một file cụ thể: dùng `getFileUploadInfoAsync`.
- Cần cấp link download: dùng `requestDownloadFileUploadInfoAsync`, không tự ghép URL thủ công từ `fileId`.
- Cần bỏ metadata file: dùng `removeFileUploadInfoAsync`.
- Cần thao tác cùng operation nhưng khác quyền: giữ nguyên tên method, đổi namespace cho đúng role.

## 6. Request Rules và Reference

- DTO fields: [reference/dto/CONTENT.md](/docs/reference/dto/CONTENT.md). Method table: [reference/API_CONTENT.md](/docs/reference/API_CONTENT.md).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/Content*.cs`.
- `GetContentDataRequestData.keys` là optional.
    - Suy luận từ model: nếu bỏ `keys`, backend có thể trả tập content rộng hơn theo `label` hoặc default scope.
    - Nếu backend spec không chốt rõ hành vi này, AI không được tự mặc định lấy toàn bộ content.
- `GetContentDataRequestData.label` là optional và có `defaultValue: ""`.
- `SetContentDataRequestData.configs` là mảng bắt buộc.
- `ContentDataParam.key` là bắt buộc.
- `GetFileUploadInfoListRequestData.limit` mặc định `10`, min `1`, max `100`.
- `GetFileUploadInfoRequestData.fileId`, `RemoveFileUploadInfoRequestData.fileId`, `RequestDownloadFileUploadInfoRequestData.fileId` đều yêu cầu đúng độ dài `15`.
- `CreateNewFileUploadInfoRequestData.fileName` là bắt buộc, min `5`, max `50`.

## 7. Upload và Download Sequence

### Upload

1. Gọi `createNewFileUploadInfoAsync` để xin `fileId`.
2. Gọi `GNNetwork.uploadFileAsync(fileId, bytes, filename, mimetype)` để upload nội dung thật.
3. Nếu cần kiểm tra lại metadata sau upload, gọi `getFileUploadInfoAsync`.

### Download

1. Gọi `requestDownloadFileUploadInfoAsync` với `fileId`.
2. Lấy `downloadToken` từ response.
3. Gọi `GNNetwork.getDownloadFileUrl(downloadToken)` để tạo URL download.

Rule cứng:

- Không gọi `GNNetwork.uploadFileAsync` trước khi có `fileId`.
- Không tự tạo download URL từ `fileId`.
- Không nhầm `getContentDataAsync` với file download; đây là 2 loại dữ liệu khác nhau.

## 8. Response Rules

Tất cả typed response của `ContentApi` đều có:

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

- `createNewFileUploadInfoAsync` trả `responseData.fileId`.
- `getContentDataAsync` trả `responseData.configs`.
- `getFileUploadInfoListAsync` trả `responseData.results`.
- `getFileUploadInfoAsync` trả `fileName`, `tsCreate`, `removeStatus`, `tsUploadExpire?`, `fileUpload?`.
- `requestDownloadFileUploadInfoAsync` trả `responseData.downloadToken`.
- `setContentDataAsync` và `removeFileUploadInfoAsync` trả `EmptyResponseData`.

## 9. Best Practices

- Chọn đúng namespace ngay từ đầu để SDK tự chọn đúng secret key.
- Với `getContentDataAsync`, truyền `keys` cụ thể nếu bạn biết mình cần gì.
- Với `setContentDataAsync`, chỉ gửi những config thật sự muốn cập nhật.
- Sau `createNewFileUploadInfoAsync`, dùng luôn `fileId` vừa nhận để upload; không cache lỏng lẻo qua nhiều bước nếu không cần.
- Với `getFileUploadInfoListAsync`, giữ `limit` nhỏ và phân trang dần.
- Với `removeFileUploadInfoAsync`, truyền `reason` nếu workflow của bạn cần audit rõ lý do.

## 10. Ví dụ Khuyến Nghị

### Client đọc content theo key

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var request = new ContentModels.GetContentDataRequestData();
request.keys = new[] { "homepage", "shop" };
request.label = "public";

var response = await GNNetwork.content.getContentDataAsync(request);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

var configs = response.responseData.configs;
```

### Server set content data

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var config = new ContentModels.ContentDataParam();
config.key = "maintenance";
config.data = XmobiTea.GearN.Common.GNHashtable.builder().add("enabled", true).add("message", "Server maintenance at 22:00").build();

var request = new ContentModels.ServerSetContentDataRequestData();
request.configs = new[] { config };
request.label = "ops";

var response = await GNNetwork.content.server.setContentDataAsync(request);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}
```

### Upload file đúng sequence

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var createRequest = new ContentModels.CreateNewFileUploadInfoRequestData();
createRequest.fileName = "banner.png";

var createResponse = await GNNetwork.content.createNewFileUploadInfoAsync(createRequest);

if (createResponse.hasReturnCodeError()) {
    throw new System.Exception(createResponse.debugMessage);
}

if (createResponse.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + createResponse.errorCode);
}

var fileId = createResponse.responseData.fileId;
var bytes = new byte[] { 1, 2, 3 };

var uploadResponse = await GNNetwork.uploadFileAsync(fileId, bytes, "banner.png", "image/png");

if (!string.IsNullOrEmpty(uploadResponse.error)) {
    throw new System.Exception(uploadResponse.error);
}
```

### Xin download URL từ fileId

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var request = new ContentModels.RequestDownloadFileUploadInfoRequestData();
request.fileId = "123456789012345";

var response = await GNNetwork.content.requestDownloadFileUploadInfoAsync(request);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

var url = GNNetwork.getDownloadFileUrl(response.responseData.downloadToken);
```

## 11. Anti-Patterns

- Không gọi `GNNetwork.uploadFileAsync` trước khi có `fileId`.
- Không dùng `getContentDataAsync` để đọc file binary.
- Không tự ghép URL download từ `fileId`.
- Không gọi nhầm namespace role.
- Không request `getContentDataAsync` không giới hạn nếu bạn chưa chắc backend sẽ trả bao nhiêu dữ liệu.
- Không bỏ qua kiểm tra `returnCode` và `errorCode`.
- Không dùng callback style mặc định khi codebase đã support `async/await`.

## 12. AI Checklist

- Đã `Resources/GNServerSettings` chưa.
- Có chọn đúng namespace `content` / `content.server` / `content.admin` chưa.
- Có nhớ rằng `ContentApi` chỉ đi qua HTTP không.
- Nếu đang upload file, đã gọi `createNewFileUploadInfoAsync` trước chưa.
- Nếu đang download file, có dùng `requestDownloadFileUploadInfoAsync` rồi `getDownloadFileUrl(...)` chưa.
- Nếu đang set content, `configs` đã có đầy đủ `key` và `data` chưa.
- Có kiểm tra `hasReturnCodeError()` trước `errorCode` chưa.
