# ContentApi

Tài liệu này là landing page cho AI code assistant khi cần dùng `GNNetwork.content*`. Đọc file này để chọn đúng namespace, method, DTO nhanh, và chỉ mở đúng row trong [API_CONTENT.md](/docs/reference/API_CONTENT.md) khi cần contract chi tiết.

## 1. Scope

- Áp dụng cho `GNNetwork.content`, `GNNetwork.content.server`, và `GNNetwork.content.admin`.
- Tất cả method hiện tại của `ContentApi` đi qua HTTP; không dùng socket.
- `ContentApi` có 3 role thật:
    - `GNNetwork.content` -> `RequestRole.Client`
    - `GNNetwork.content.server` -> `RequestRole.Server`
    - `GNNetwork.content.admin` -> `RequestRole.Admin`
- Payload shape giữa `client`, `server`, `admin` của cùng một operation giống nhau theo ý nghĩa nghiệp vụ; khác biệt chính là request DTO variant và role.
- `ContentApi` không upload byte trực tiếp. Nó chỉ quản lý metadata và token cho flow file; upload byte thật đi qua `GNNetwork.uploadFileAsync(...)`.
- Rule chọn route/permission canonical: [RULES.md route rules](/docs/RULES.md). Với `ContentApi`, không tự suy diễn route từ ownership.

## 2. Hard Rules

- Ưu tiên `async/await`; mặc định dùng `*Async()`.
- Bắt buộc đã có `Resources/GNServerSettings` trước khi gọi.
- Không dùng socket cho `ContentApi`.
- Chọn namespace theo actor thật đang chạy code: client app, trusted backend, hay admin/backoffice tool.
- Chỉ dùng `.server` khi code chạy trong trusted backend/worker và secret có permission `serverSelfEnable` phù hợp.
- Chỉ dùng `.admin` khi code chạy trong dashboard/backoffice/admin tool và secret có permission `adminSelfEnable` phù hợp.
- `setContentDataAsync(...)` bắt buộc có `configs`; mỗi config cần `key` và `data`.
- `removeFileUploadInfoAsync(...)` là thao tác mutate/xóa metadata file. Chỉ gọi khi có chủ đích rõ ràng.

## 3. Chọn Namespace

<!-- prettier-ignore -->
| Namespace | Role thật | Dùng khi nào |
| --- | --- | --- |
| `GNNetwork.content` | `Client` | Flow từ Unity client / player app |
| `GNNetwork.content.server` | `Server` | Server worker, backend integration, trusted service |
| `GNNetwork.content.admin` | `Admin` | Dashboard, backoffice, tooling quản trị |

Rule nhanh:

- Code chạy trong game client: ưu tiên `GNNetwork.content`.
- Code chạy ở trusted backend hoặc worker: ưu tiên `GNNetwork.content.server`.
- Code chạy ở dashboard/tool vận hành: ưu tiên `GNNetwork.content.admin`.
- Chỉ dùng `overrideSecretKey` khi có chủ đích override secret mặc định theo role cho một request.

## 4. Chọn Method

Đọc bảng này trước. Cột API contract rows trỏ thẳng đến row cần đọc trong `API_CONTENT.md`; không cần mở full file API.

> Khi thấy [client:16-16](/docs/example.md) nghĩa là chỉ cần đọc đúng từ dòng 16 đến 16 (hoặc gọi chính xác là đọc đúng dòng 16) của tài liệu `/docs/example.md`, tương tự với những cái khác, ví dụ [client:12-15] nghĩa là đọc đúng từ dòng 12 đến 15 của tài liệu, nếu có tool đọc từ startLine đến endLine ưu tiên cái này thay vì mở toàn bộ file.

> Thứ tự columns `API contract rows` của `client`, `server` và `admin` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |`.

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `getContentDataAsync` | Đọc content config theo key hoặc label | `keys?`, `label?` | `responseData.configs` | [client:16-16](/docs/reference/API_CONTENT.md) / [server:29-29](/docs/reference/API_CONTENT.md) / [admin:42-42](/docs/reference/API_CONTENT.md) |
| `setContentDataAsync` | Tạo hoặc cập nhật content config | `configs`, `label?` | `EmptyResponseData` | [client:21-21](/docs/reference/API_CONTENT.md) / [server:34-34](/docs/reference/API_CONTENT.md) / [admin:47-47](/docs/reference/API_CONTENT.md) |
| `createNewFileUploadInfoAsync` | Xin cấp `fileId` cho một file sẽ upload | `fileName` | `responseData.fileId` | [client:15-15](/docs/reference/API_CONTENT.md) / [server:28-28](/docs/reference/API_CONTENT.md) / [admin:41-41](/docs/reference/API_CONTENT.md) |
| `getFileUploadInfoListAsync` | Liệt kê metadata file upload | `skip?`, `limit?` | `responseData.results` | [client:17-17](/docs/reference/API_CONTENT.md) / [server:30-30](/docs/reference/API_CONTENT.md) / [admin:43-43](/docs/reference/API_CONTENT.md) |
| `getFileUploadInfoAsync` | Xem chi tiết metadata của một file | `fileId` | `GetFileUploadInfoResponseData` | [client:18-18](/docs/reference/API_CONTENT.md) / [server:31-31](/docs/reference/API_CONTENT.md) / [admin:44-44](/docs/reference/API_CONTENT.md) |
| `removeFileUploadInfoAsync` | Gỡ metadata hoặc đánh dấu remove cho file | `fileId`, `reason?` | `EmptyResponseData` | [client:19-19](/docs/reference/API_CONTENT.md) / [server:32-32](/docs/reference/API_CONTENT.md) / [admin:45-45](/docs/reference/API_CONTENT.md) |
| `requestDownloadFileUploadInfoAsync` | Xin download token cho file | `fileId` | `responseData.downloadToken` | [client:20-20](/docs/reference/API_CONTENT.md) / [server:33-33](/docs/reference/API_CONTENT.md) / [admin:46-46](/docs/reference/API_CONTENT.md) |

Decision rules:

- Cần config dạng key/value structured: dùng `getContentDataAsync` hoặc `setContentDataAsync`.
- Cần upload file mới: dùng `createNewFileUploadInfoAsync` trước, sau đó `GNNetwork.uploadFileAsync`.
- Cần liệt kê file đã có: dùng `getFileUploadInfoListAsync`.
- Cần inspect một file cụ thể: dùng `getFileUploadInfoAsync`.
- Cần cấp link download: dùng `requestDownloadFileUploadInfoAsync`, không tự ghép URL từ `fileId`.
- Cần bỏ metadata file: dùng `removeFileUploadInfoAsync`.
- Cần thao tác cùng operation nhưng khác quyền: giữ nguyên method, đổi namespace cho đúng role.

## 5. Method Signature

Mỗi method có 2 form: callback và `*Async()` Task. Mặc định sinh code bằng async form.

```csharp
// Callback
GNNetwork.content.<method>(requestData, onResponse, overrideAuthToken, overrideSecretKey, customTags, timeout);

// Async
var response = await GNNetwork.content.<method>Async(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
```

Param chung:

<!-- prettier-ignore -->
| Param | Type | Khi nào cần |
| --- | --- | --- |
| `requestData` | domain-specific DTO | Payload chính; tạo bằng `new ContentModels.<Method>RequestData()` |
| `onResponse` | `Action1<TResponse>` | Chỉ có ở callback form |
| `overrideAuthToken` | `string` | Impersonate / multi-session / admin thao tác bằng auth token khác |
| `overrideSecretKey` | `string` | Override secret key mặc định của role cho một request |
| `customTags` | `GNHashtable` | Trace id, build version, A/B bucket; backend có thể log/route |
| `timeout` | `int` | Override timeout theo request, tính bằng giây |

Typed response expose public fields: `returnCode`, `errorCode`, `invalidMembers`, `debugMessage`, `responseData`. Xem [RULES.md response checking](/docs/RULES.md).

## 6. Request Field Rules

- DTO fields: [reference/dto/CONTENT.md](/docs/reference/dto/CONTENT.md).
- Contract table: [reference/API_CONTENT.md](/docs/reference/API_CONTENT.md).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/Content*.cs`.

<!-- prettier-ignore -->
| DTO / field | Quick rule | DTO link |
| --- | --- | --- |
| `GetContentDataRequestData.keys` | optional; nếu bỏ `keys`, không tự mặc định là backend sẽ trả toàn bộ content nếu spec chưa nói rõ | [ContentModels.GetContentDataRequestData:44-53](/docs/reference/dto/content/CONTENT_MODELS.md#getcontentdatarequestdata) |
| `GetContentDataRequestData.label` | optional, default `""` | [ContentModels.GetContentDataRequestData:44-53](/docs/reference/dto/content/CONTENT_MODELS.md#getcontentdatarequestdata) |
| `SetContentDataRequestData.configs` | required array | [ContentModels.SetContentDataRequestData:212-225](/docs/reference/dto/content/CONTENT_MODELS.md#setcontentdatarequestdata) |
| `ContentDataParam.key` | required | [ContentModels.ContentDataParam:1-10](/docs/reference/dto/content/CONTENT_MODELS.md#contentdataparam) |
| `GetFileUploadInfoListRequestData.limit` | default `10`, min `1`, max `100` | [ContentModels.GetFileUploadInfoListRequestData:78-87](/docs/reference/dto/content/CONTENT_MODELS.md#getfileuploadinfolistrequestdata) |
| file `fileId` fields | `GetFileUploadInfoRequestData.fileId`, `RemoveFileUploadInfoRequestData.fileId`, `RequestDownloadFileUploadInfoRequestData.fileId` đều yêu cầu length `15` | [get:112-120](/docs/reference/dto/content/CONTENT_MODELS.md#getfileuploadinforequestdata) / [remove:145-154](/docs/reference/dto/content/CONTENT_MODELS.md#removefileuploadinforequestdata) / [download:179-187](/docs/reference/dto/content/CONTENT_MODELS.md#requestdownloadfileuploadinforequestdata) |
| `CreateNewFileUploadInfoRequestData.fileName` | required, min `5`, max `50` | [ContentModels.CreateNewFileUploadInfoRequestData:11-19](/docs/reference/dto/content/CONTENT_MODELS.md#createnewfileuploadinforequestdata) |

## 7. Upload và Download Sequence

### Upload

1. Gọi `createNewFileUploadInfoAsync` để xin `fileId`.
2. Lấy `fileId` từ `createResponse.responseData.fileId`.
3. Gọi `GNNetwork.uploadFileAsync(fileId, bytes, filename, mimetype)` để upload nội dung thật.
4. Nếu cần kiểm tra metadata sau upload, gọi `getFileUploadInfoAsync`.

### Download

1. Gọi `requestDownloadFileUploadInfoAsync` với `fileId`.
2. Lấy `downloadToken` từ `response.responseData.downloadToken`.
3. Gọi `GNNetwork.getDownloadFileUrl(downloadToken)` để tạo URL download.

Rule cứng:

- Không gọi `GNNetwork.uploadFileAsync` trước khi có `fileId`.
- Không tự tạo download URL từ `fileId`.
- Không nhầm `getContentDataAsync` với file download; content config và file binary là 2 loại dữ liệu khác nhau.

## 8. Minimal Pattern

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new ContentModels.CreateNewFileUploadInfoRequestData();
requestData.fileName = "banner.png";

var response = await GNNetwork.content.createNewFileUploadInfoAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var fileId = response.responseData.fileId;
```

Nếu codebase đã có helper riêng như `hasReturnCodeError()` và muốn throw exception thay vì early-return, vẫn phải giữ thứ tự check 2 tầng: `returnCode` trước, `errorCode` sau.

## 9. Ví dụ Khuyến Nghị

### Client đọc content theo key

```csharp
using System.Collections.Generic;
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new ContentModels.GetContentDataRequestData();
requestData.keys = new List<string> { "homepage", "shop" };
requestData.label = "public";

var response = await GNNetwork.content.getContentDataAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var configs = response.responseData.configs;
```

### Server set content data

```csharp
using System.Collections.Generic;
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var config = new ContentModels.ContentDataParam();
config.key = "maintenance";
config.data = XmobiTea.GearN.Common.GNHashtable.builder().add("enabled", true).add("message", "Server maintenance at 22:00").build();

var requestData = new ContentModels.ServerSetContentDataRequestData();
requestData.configs = new List<ContentModels.ContentDataParam> { config };
requestData.label = "ops";

var response = await GNNetwork.content.server.setContentDataAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;
```

### Upload file đúng sequence

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var createRequestData = new ContentModels.CreateNewFileUploadInfoRequestData();
createRequestData.fileName = "banner.png";

var createResponse = await GNNetwork.content.createNewFileUploadInfoAsync(createRequestData);

if (createResponse.returnCode != ReturnCode.Ok) return;
if (createResponse.errorCode != ErrorCode.Ok) return;

var fileId = createResponse.responseData.fileId;
var bytes = new byte[] { 1, 2, 3 };

var uploadResponse = await GNNetwork.uploadFileAsync(fileId, bytes, "banner.png", "image/png");

if (!string.IsNullOrEmpty(uploadResponse.error)) return;
```

### Xin download URL từ fileId

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new ContentModels.RequestDownloadFileUploadInfoRequestData();
requestData.fileId = "123456789012345";

var response = await GNNetwork.content.requestDownloadFileUploadInfoAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var url = GNNetwork.getDownloadFileUrl(response.responseData.downloadToken);
```

## 10. Anti-Patterns

- Không gọi `GNNetwork.uploadFileAsync` trước khi có `fileId`.
- Không dùng `getContentDataAsync` để đọc file binary.
- Không tự ghép URL download từ `fileId`.
- Không gọi nhầm namespace role.
- Không request `getContentDataAsync` không giới hạn nếu chưa chắc backend sẽ trả bao nhiêu dữ liệu.
- Không bỏ qua check `returnCode` và `errorCode`.
- Không dùng callback style mặc định khi codebase đã support `async/await`.

## 11. AI Checklist

- Đã có `Resources/GNServerSettings` chưa.
- Đã chọn đúng namespace `content` / `content.server` / `content.admin` chưa.
- Có nhớ `ContentApi` chỉ đi qua HTTP không.
- Nếu đang upload file, đã gọi `createNewFileUploadInfoAsync` trước chưa.
- Nếu đang download file, có dùng `requestDownloadFileUploadInfoAsync` rồi `getDownloadFileUrl(...)` chưa.
- Nếu đang set content, `configs` đã có đủ `key` và `data` chưa.
- Có check `returnCode` trước `errorCode` chưa.

## Quick Map

Dùng bảng này để đọc đúng dòng mà không load cả file. `offset = startLine - 1`, `limit = endLine - startLine + 1`.

<!-- prettier-ignore -->
| Section | Lines |
| --- | --- |
| §3 Chọn Namespace | 28-43 |
| §4 Chọn Method (bảng 7 method + decision rules) | 44-71 |
| §7 Upload và Download Sequence | 118-137 |
| §8 Minimal Pattern | 139-157 |
| §9 Ví Dụ Khuyến Nghị | 159-243 |
