# DashboardApi

Tài liệu này là landing page cho AI code assistant khi cần dùng `GNNetwork.dashboard.*`. Đọc file này để chọn đúng method, DTO nhanh, auth flow dashboard, và chỉ mở đúng row trong [API_DASHBOARD.md](/docs/reference/API_DASHBOARD.md) khi cần contract chi tiết.

## 1. Scope

- Chỉ áp dụng cho `GNNetwork.dashboard`.
- Không áp dụng cho `GNNetwork.dashboard.server` và `GNNetwork.dashboard.admin` vì hiện tại 2 namespace này rỗng, không có method public hữu ích.
- Toàn bộ method hiện tại của `DashboardApi` đi qua HTTP, không có flow socket.
- Toàn bộ request wrapper hiện tại dùng `RequestType.Dashboard` với `RequestRole.Client`.
- `DashboardApi` là ngoại lệ của rule route thông thường: public wrapper vẫn đi `RequestRole.Client`, còn admin context được backend resolve từ `authToken` sau `loginByAdminAccountAsync`.
- Đây là nhóm API cho dashboard, backoffice, provisioning, analytics và maintenance. Không dùng thay gameplay API của player.
- Nếu cần login player, dùng `AuthenticateApi`. Nếu cần data/player runtime, dùng group tương ứng khác.

## 2. Hard Rules

- Ưu tiên `async/await`; mặc định dùng `GNNetwork.dashboard.*Async()`.
- Bắt buộc đã có `Resources/GNServerSettings` trước khi gọi.
- Không dùng `GNNetwork.dashboard.server.*` hoặc `GNNetwork.dashboard.admin.*`.
- Gọi `loginByAdminAccountAsync` trước các operation quản trị nếu flow của tool dựa vào admin account/password.
- Sau `loginByAdminAccountAsync` thành công, backend middleware dùng `authToken` để resolve secret context và quyền riêng của admin cho các request dashboard tiếp theo.
- Chỉ truyền `overrideSecretKey` khi cố ý bypass flow auth-token mặc định.
- `loginByAdminAccountAsync` chỉ trả `authToken`; không giả định response có `userId`.
- `deleteInDatabaseAsync` và `resetStatisticsLeaderboardAsync` là operation phá hủy hoặc reset dữ liệu. Chỉ dùng khi operator đã xác nhận chính xác hậu quả.

## 3. Chọn Namespace

<!-- prettier-ignore -->
| Namespace | Role transport | Dùng khi nào |
| --- | --- | --- |
| `GNNetwork.dashboard` | `RequestRole.Client` | Dashboard web/tool, backoffice, provisioning, analytics, maintenance |

Rule nhanh:

- Luôn dùng `GNNetwork.dashboard.*Async()` cho DashboardApi trong Unity SDK.
- Không suy luận có `.server` hoặc `.admin` giống các API group khác.
- Rule route/permission canonical: [RULES.md route rules](/docs/RULES.md). Với `DashboardApi`, đọc thêm ngoại lệ Dashboard trong RULES trước khi viết logic nhạy cảm.

## 4. Chọn Method

Đọc các bảng này trước. Cột API contract rows trỏ thẳng đến row cần đọc trong `API_DASHBOARD.md`; không cần mở full file API.

> Khi thấy [client:16-16](/docs/example.md) nghĩa là chỉ cần đọc đúng từ dòng 16 đến 16 (hoặc gọi chính xác là đọc đúng dòng 16) của tài liệu `/docs/example.md`, tương tự với những cái khác, ví dụ [client:12-15] nghĩa là đọc đúng từ dòng 12 đến 15 của tài liệu, nếu có tool đọc từ startLine đến endLine ưu tiên cái này thay vì mở toàn bộ file.

> Thứ tự columns `API contract rows` của `client` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |`.

### Auth và quản trị admin account

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `loginByAdminAccountAsync` | Login dashboard/admin tool | `username`, `password` | `responseData.authToken` | [client:27-27](/docs/reference/API_DASHBOARD.md) |
| `changePasswordAdminAccountAsync` | Admin hiện tại tự đổi mật khẩu của chính mình | `currentPassword`, `password` | `EmptyResponseData` | [client:16-16](/docs/reference/API_DASHBOARD.md) |
| `getAdminAccountListAsync` | Liệt kê admin account | request rỗng | `responseData.results` | [client:17-17](/docs/reference/API_DASHBOARD.md) |
| `createAdminAccountAsync` | Tạo admin account mới | `username`, `password`, `secretKey` | `responseData.results` | [client:24-24](/docs/reference/API_DASHBOARD.md) |
| `getUsernameAdminAccountAsync` | Tìm username từ `userId` admin | `userId` | `responseData.username` | [client:35-35](/docs/reference/API_DASHBOARD.md) |
| `setPasswordAdminAccountAsync` | Đặt lại mật khẩu cho admin khác | `userId`, `password` | `EmptyResponseData` | [client:31-31](/docs/reference/API_DASHBOARD.md) |
| `setSecretKeyAdminAccountAsync` | Gán hoặc đổi secret key của admin account | `userId`, `secretKey` | `EmptyResponseData` | [client:33-33](/docs/reference/API_DASHBOARD.md) |
| `removeAdminAccountAsync` | Xóa admin account | `userId` | `EmptyResponseData` | [client:28-28](/docs/reference/API_DASHBOARD.md) |

### Quản lý game và cấu hình

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `getGameListAsync` | Liệt kê game id hiện có | request rỗng | `responseData.results` | [client:19-19](/docs/reference/API_DASHBOARD.md) |
| `createGameAsync` | Tạo game mới | `gameId` | `responseData.gameId` | [client:25-25](/docs/reference/API_DASHBOARD.md) |
| `getGameInformationAsync` | Đọc metadata và settings của một game | `gameId` | `GetGameInformationResponseData` | [client:18-18](/docs/reference/API_DASHBOARD.md) |
| `setGameInformationAsync` | Cập nhật metadata/settings của game | `gameId` và field cần đổi | `EmptyResponseData` | [client:29-29](/docs/reference/API_DASHBOARD.md) |
| `getMasterGameSettingsAsync` | Đọc global settings của server/game platform | request rỗng | `GetMasterGameSettingsResponseData` | [client:20-20](/docs/reference/API_DASHBOARD.md) |
| `setMasterGameSettingsAsync` | Cập nhật global settings | hashtable settings cần đổi | `EmptyResponseData` | [client:30-30](/docs/reference/API_DASHBOARD.md) |
| `getServerGameDataAsync` | Lấy snapshot số lượng entity và version của một game | `gameId` và boolean flag cần lấy | `GetServerGameDataResponseData` | [client:40-40](/docs/reference/API_DASHBOARD.md) |

### Secret key và permission

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `getSecretInfoListAsync` | Liệt kê secret key theo role | request rỗng | `responseData.secretKeys` | [client:22-22](/docs/reference/API_DASHBOARD.md) |
| `getSecretInfoInformationAsync` | Xem chi tiết một secret key | `secretKey` | `GetSecretInfoInformationResponseData` | [client:21-21](/docs/reference/API_DASHBOARD.md) |
| `createSecretInfoAsync` | Tạo secret key mới | `secretKey?`, `gameId?`, `permissionParam?` | `responseData.secretKey` | [client:26-26](/docs/reference/API_DASHBOARD.md) |
| `setSecretInfoInformationAsync` | Cập nhật expire, description, permission hoặc remove flag của secret key | `secretKey` và field cần đổi | `EmptyResponseData` | [client:32-32](/docs/reference/API_DASHBOARD.md) |

### Analytics, logs và callback

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `getAnalyticsAsync` | Lấy analytics tổng hợp | boolean flag cần lấy, `timestamp?` | `GetAnalyticsResponseData` | [client:34-34](/docs/reference/API_DASHBOARD.md) |
| `getServerLogAsync` | Lấy log server dạng phân trang | `skip?`, `limit?` | `GetServerLogResponseData` | [client:23-23](/docs/reference/API_DASHBOARD.md) |
| `getEventCallbackCloudScriptAsync` | Liệt kê callback CloudScript theo event | request rỗng | `GetEventCallbackCloudScriptResponseData` | [client:36-36](/docs/reference/API_DASHBOARD.md) |
| `setEventCallbackCloudScriptAsync` | Tạo hoặc sửa callback CloudScript theo event | `eventName`, `script` | `responseData.errorMessage` | [client:37-37](/docs/reference/API_DASHBOARD.md) |
| `getBackupStatisticsLeaderboardVersionAsync` | Liệt kê version backup của leaderboard | `gameId`, `type`, `key` | `GetBackupStatisticsLeaderboardVersionResponseData` | [client:39-39](/docs/reference/API_DASHBOARD.md) |

### Maintenance và thao tác phá hủy

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `resetStatisticsLeaderboardAsync` | Reset một version leaderboard | `type`, `key`, `version`, `gameId`, `log?`, `catalogId?` | `EmptyResponseData` | [client:38-38](/docs/reference/API_DASHBOARD.md) |
| `deleteInDatabaseAsync` | Xóa dữ liệu trực tiếp theo loại và id | `type`, `id`, `gameId`, `log?` | `EmptyResponseData` | [client:41-41](/docs/reference/API_DASHBOARD.md) |

Decision rules:

- Cần login admin: dùng `loginByAdminAccountAsync` trước.
- Cần đổi mật khẩu của chính admin hiện tại: dùng `changePasswordAdminAccountAsync`.
- Cần quản lý admin account khác: dùng bộ `getAdminAccountListAsync`, `createAdminAccountAsync`, `getUsernameAdminAccountAsync`, `setPasswordAdminAccountAsync`, `setSecretKeyAdminAccountAsync`, `removeAdminAccountAsync`.
- Cần tạo game mới: dùng `createGameAsync`, sau đó `setGameInformationAsync` nếu cần metadata/settings.
- Cần đọc hoặc cập nhật cấu hình global: dùng `getMasterGameSettingsAsync` hoặc `setMasterGameSettingsAsync`.
- Cần quản lý secret key: inspect bằng `getSecretInfoListAsync` hoặc `getSecretInfoInformationAsync`, sau đó mới `createSecretInfoAsync` hoặc `setSecretInfoInformationAsync`.
- Cần analytics hoặc log: dùng `getAnalyticsAsync`, `getServerLogAsync`, `getServerGameDataAsync` với payload tối giản.
- Cần callback CloudScript theo event: dùng `getEventCallbackCloudScriptAsync` để inspect trước, rồi `setEventCallbackCloudScriptAsync`.
- Cần reset leaderboard hoặc xóa dữ liệu: chỉ dùng khi operator đã xác nhận chính xác `type`, `key`, `version`, `id`, `gameId` và hậu quả.

## 5. Method Signature

Mỗi method có 2 form: callback và `*Async()` Task. Mặc định sinh code bằng async form.

```csharp
// Callback
GNNetwork.dashboard.<method>(requestData, onResponse, overrideAuthToken, overrideSecretKey, customTags, timeout);

// Async
var response = await GNNetwork.dashboard.<method>Async(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
```

Param chung:

<!-- prettier-ignore -->
| Param | Type | Khi nào cần |
| --- | --- | --- |
| `requestData` | domain-specific DTO | Payload chính; tạo bằng `new DashboardModels.<Method>RequestData()` |
| `onResponse` | `Action1<TResponse>` | Chỉ có ở callback form |
| `overrideAuthToken` | `string` | Override admin auth token cache cho request này |
| `overrideSecretKey` | `string` | Bypass flow token mặc định bằng secret key cụ thể |
| `customTags` | `GNHashtable` | Trace id, build version, dashboard session id; backend có thể log/route |
| `timeout` | `int` | Override timeout theo request, tính bằng giây |

Typed response expose public fields: `returnCode`, `errorCode`, `invalidMembers`, `debugMessage`, `responseData`. Xem [RULES.md response checking](/docs/RULES.md).

## 6. Request Field Rules

- DTO fields: [reference/dto/DASHBOARD.md](/docs/reference/dto/DASHBOARD.md).
- Contract table: [reference/API_DASHBOARD.md](/docs/reference/API_DASHBOARD.md).
- Enums: [OwnerType](/docs/reference/ENUMS.md#ownertype).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules cho secret key: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/Dashboard*.cs`.

<!-- prettier-ignore -->
| DTO / field | Quick rule | DTO link |
| --- | --- | --- |
| `LoginByAdminAccountRequestData.username/password` | required cho dashboard login | [DashboardModels.LoginByAdminAccountRequestData:1085-1094](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#loginbyadminaccountrequestdata) |
| `CreateAdminAccountRequestData.secretKey` | secret key gán cho admin account mới; không tự bịa key | [DashboardModels.CreateAdminAccountRequestData:1050-1060](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#createadminaccountrequestdata) |
| `CreateSecretInfoRequestData.secretKey` | optional trong model; nếu bỏ qua, chỉ đọc `responseData.secretKey` sau khi backend trả về | [DashboardModels.CreateSecretInfoRequestData:1070-1084](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#createsecretinforequestdata) |
| `GetServerLogRequestData.skip/limit` | dùng phân trang; không request log vô hạn | [DashboardModels.GetServerLogRequestData:1040-1049](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#getserverlogrequestdata) |
| `GetAnalyticsRequestData` flags | chỉ bật metric thật sự cần để giảm payload | [DashboardModels.GetAnalyticsRequestData:1179-1195](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#getanalyticsrequestdata) |
| `GetServerGameDataRequestData` flags | chỉ bật snapshot thật sự cần | [DashboardModels.GetServerGameDataRequestData:1258-1274](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#getservergamedatarequestdata) |
| `resetStatisticsLeaderboard/deleteInDatabase.type` | phải lấy từ `OwnerType`; không tự bịa numeric value | [reset:1221-1234](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#resetstatisticsleaderboardrequestdata) / [delete:1235-1246](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#deleteindatabaserequestdata) |

## 7. Admin Login Flow

1. Build `DashboardModels.LoginByAdminAccountRequestData` với `username` và `password`.
2. Gọi `GNNetwork.dashboard.loginByAdminAccountAsync(requestData)`.
3. Check `returnCode` trước, `errorCode` sau.
4. Lấy `authToken` từ `response.responseData.authToken` hoặc authenticate status cache nếu codebase đang dùng cache.
5. Gọi các dashboard operation tiếp theo bằng token đã cache; chỉ dùng `overrideAuthToken` khi cần token cụ thể cho request đó.

Rule cứng:

- Không giả định `loginByAdminAccountAsync` trả `userId`.
- Không gọi socket cho dashboard.
- Không dùng player login token thay cho admin login token trong dashboard tool.

## 8. Minimal Pattern

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new DashboardModels.LoginByAdminAccountRequestData();
requestData.username = "gnadmin";
requestData.password = "123456";

var response = await GNNetwork.dashboard.loginByAdminAccountAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var adminAuthToken = response.responseData.authToken;
```

Nếu codebase đã có helper riêng như `hasReturnCodeError()` và muốn throw exception thay vì early-return, vẫn phải giữ thứ tự check 2 tầng: `returnCode` trước, `errorCode` sau.

## 9. Ví dụ Khuyến Nghị

### Login admin rồi lấy game list

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var loginRequestData = new DashboardModels.LoginByAdminAccountRequestData();
loginRequestData.username = "gnadmin";
loginRequestData.password = "123456";

var loginResponse = await GNNetwork.dashboard.loginByAdminAccountAsync(loginRequestData);

if (loginResponse.returnCode != ReturnCode.Ok) return;
if (loginResponse.errorCode != ErrorCode.Ok) return;

var gameListResponse = await GNNetwork.dashboard.getGameListAsync(new DashboardModels.GetGameListRequestData());

if (gameListResponse.returnCode != ReturnCode.Ok) return;
if (gameListResponse.errorCode != ErrorCode.Ok) return;

var games = gameListResponse.responseData.results;
```

### Tạo game rồi cập nhật metadata

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var createRequestData = new DashboardModels.CreateGameRequestData();
createRequestData.gameId = "demo-game";

var createResponse = await GNNetwork.dashboard.createGameAsync(createRequestData);

if (createResponse.returnCode != ReturnCode.Ok) return;
if (createResponse.errorCode != ErrorCode.Ok) return;

var updateRequestData = new DashboardModels.SetGameInformationRequestData();
updateRequestData.gameId = "demo-game";
updateRequestData.gameName = "Demo Game";
updateRequestData.gameDescription = "Internal demo project";

var updateResponse = await GNNetwork.dashboard.setGameInformationAsync(updateRequestData);

if (updateResponse.returnCode != ReturnCode.Ok) return;
if (updateResponse.errorCode != ErrorCode.Ok) return;
```

### Tạo secret key cho server role

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new DashboardModels.CreateSecretInfoRequestData();
requestData.gameId = "demo-game";

var response = await GNNetwork.dashboard.createSecretInfoAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var generatedSecretKey = response.responseData.secretKey;
```

## 10. Anti-Patterns

- Không gọi `GNNetwork.dashboard.server` hoặc `GNNetwork.dashboard.admin`.
- Không bỏ qua `loginByAdminAccountAsync` rồi vẫn mong backend tự hiểu request dashboard là admin request.
- Không dùng `DashboardApi` như gameplay API cho client/player thường.
- Không gọi `deleteInDatabaseAsync` hoặc `resetStatisticsLeaderboardAsync` nếu chưa có xác nhận vận hành rõ ràng.
- Không request full analytics/full snapshot nếu chỉ cần một vài metric.
- Không giả định `loginByAdminAccountAsync` trả `userId`.
- Không tự bịa `OwnerType` numeric value cho maintenance operation.
- Không bỏ qua check `returnCode` và `errorCode`.
- Không dùng callback style mặc định khi codebase đã support `async/await`.

## 11. AI Checklist

- Đã có `Resources/GNServerSettings` chưa.
- Có đang dùng đúng `GNNetwork.dashboard.*Async()` không.
- Có nhớ toàn bộ `DashboardApi` hiện dùng `RequestRole.Client` và HTTP không.
- Có cần login admin trước khi gọi operation hiện tại không.
- Nếu operation là destructive, đã có xác nhận rõ về hậu quả chưa.
- Nếu dùng `type`, đã lấy từ `OwnerType` chưa.
- Có check `returnCode` trước `errorCode` chưa.

## Quick Map

Dùng bảng này để đọc đúng dòng mà không load cả file. `offset = startLine - 1`, `limit = endLine - startLine + 1`.

<!-- prettier-ignore -->
| Section | Lines |
| --- | --- |
| §3 Chọn Namespace | 27-37 |
| §4 Chọn Method — Auth và quản trị admin account | 47-60 |
| §4 Chọn Method — Quản lý game và cấu hình | 61-72 |
| §4 Chọn Method — Secret key và permission | 74-83 |
| §4 Chọn Method — Analytics, logs và callback | 84-93 |
| §4 Chọn Method — Maintenance và thao tác phá hủy | 95-113 |
| §7 Admin Login Flow | 161-173 |
| §8 Minimal Pattern | 175-194 |
| §9 Ví Dụ Khuyến Nghị | 196-265 |
