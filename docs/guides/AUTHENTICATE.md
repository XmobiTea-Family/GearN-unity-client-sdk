# AuthenticateApi

Tài liệu này là landing page cho AI code assistant khi cần dùng `GNNetwork.authenticate`. Đọc file này để chọn đúng method, DTO nhanh, auth/socket flow, và chỉ mở đúng row trong [API_AUTHENTICATE.md](/docs/reference/API_AUTHENTICATE.md) khi cần contract chi tiết.

## 1. Scope

- Áp dụng cho `GNNetwork.authenticate`.
- `AuthenticateApi` hiện chỉ có route client public: `GNNetwork.authenticate` -> `RequestRole.Client`.
- Không áp dụng cho `GNNetwork.authenticate.server` và `GNNetwork.authenticate.admin` vì hiện tại hai namespace này không expose method public.
- Nếu cần login admin dashboard, dùng `GNNetwork.dashboard.loginByAdminAccountAsync`, không dùng `AuthenticateApi`.
- Nếu cần gọi server-side operation sau khi đã có danh tính, dùng API group tương ứng với `.server` và secret có permission rule phù hợp. Không dùng `AuthenticateApi.server`.

## 2. Hard Rules

- Ưu tiên `async/await`; mặc định dùng `GNNetwork.authenticate.*Async()`.
- Các method của `AuthenticateApi` hiện gửi qua HTTP, không login qua socket.
- Trước khi gọi API, phải có asset `Resources/GNServerSettings` và `secretKey` hợp lệ.
- Mọi flow login/register phải truyền instance `infoRequestParam` khác `null`; riêng `refreshAuthTokenAsync` dùng request rỗng.
- Sau khi login hoặc refresh thành công, nếu backend trả `authToken` và `userId`, SDK tự cache vào `GNNetwork.getAuthenticateStatus()` và storage nội bộ.
- Nếu cần realtime sau login, làm theo [socket rule trong RULES](/docs/RULES.md#7-auth--socket-flow): login HTTP thành công, subscribe handler, rồi `GNNetwork.connectSocket()`.
- Luôn check `returnCode` trước `errorCode`; `Ok == 1` ở cả `ReturnCode` và `ErrorCode`.

## 3. Chọn Namespace

<!-- prettier-ignore -->
| Namespace | Role thật | Dùng khi nào |
| --- | --- | --- |
| `GNNetwork.authenticate` | `Client` | Login/register/refresh từ Unity client hoặc code cần authenticate player |

Rule nhanh:

- Code login player luôn dùng `GNNetwork.authenticate`.
- Không dùng `.server` hoặc `.admin` cho authenticate; hai namespace này không có public contract.
- `overrideAuthToken` chỉ có ý nghĩa thực tế với flow cần dùng token khác token đang cache, ví dụ `refreshAuthTokenAsync`.

## 4. Chọn Method

Đọc bảng này trước. Cột API contract rows trỏ thẳng đến row cần đọc trong `API_AUTHENTICATE.md`; không cần mở full file API.

> Khi thấy [client:16-16](/docs/example.md) nghĩa là chỉ cần đọc đúng từ dòng 16 đến 16 (hoặc gọi chính xác là đọc đúng dòng 16) của tài liệu `/docs/example.md`, tương tự với những cái khác, ví dụ [client:12-15] nghĩa là đọc đúng từ dòng 12 đến 15 của tài liệu, nếu có tool đọc từ startLine đến endLine ưu tiên cái này thay vì mở toàn bộ file.

> Thứ tự columns `API contract rows` của `client` là "| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |"

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `loginByAccountAsync` | Đã có username/password | `username`, `password`, `infoRequestParam` | `AuthenticateResponseData` | [client:16-16](/docs/reference/API_AUTHENTICATE.md) |
| `registerAccountAsync` | Tạo username/password mới | `username`, `password`, `infoRequestParam` | `AuthenticateResponseData` | [client:32-32](/docs/reference/API_AUTHENTICATE.md) |
| `refreshAuthTokenAsync` | Gia hạn phiên đã login | request rỗng; token lấy từ SDK cache hoặc `overrideAuthToken` | `RefreshAuthTokenResponseData` | [client:33-33](/docs/reference/API_AUTHENTICATE.md) |
| `loginByCustomDeviceIdAsync` | Guest/anonymous theo device/app install id | `customDeviceId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | [client:19-19](/docs/reference/API_AUTHENTICATE.md) |
| `loginByCustomIdAsync` | App đã có identity riêng | `customId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | [client:20-20](/docs/reference/API_AUTHENTICATE.md) |
| `loginByEditorDeviceIdAsync` | Local/dev trong Unity Editor | `editorDeviceId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | [client:21-21](/docs/reference/API_AUTHENTICATE.md) |
| `loginByAndroidDeviceIdAsync` | Identity thật là Android device id | `androidDeviceId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | [client:17-17](/docs/reference/API_AUTHENTICATE.md) |
| `loginByiOSDeviceIdAsync` | Identity thật là iOS device id | `iOSDeviceId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | [client:27-27](/docs/reference/API_AUTHENTICATE.md) |
| `loginByLinuxDeviceIdAsync` | Identity thật là Linux device id | `linuxDeviceId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | [client:28-28](/docs/reference/API_AUTHENTICATE.md) |
| `loginByMacOSDeviceIdAsync` | Identity thật là macOS device id | `macOSDeviceId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | [client:29-29](/docs/reference/API_AUTHENTICATE.md) |
| `loginByWindowsDeviceIdAsync` | Identity thật là Windows device id | `windowsDeviceId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | [client:30-30](/docs/reference/API_AUTHENTICATE.md) |
| `loginByWindowsPhoneDeviceIdAsync` | Legacy Windows Phone identity | `windowsPhoneDeviceId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | [client:31-31](/docs/reference/API_AUTHENTICATE.md) |
| `loginByGoogleAsync` | Có Google token | `token`, `type`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | [client:24-24](/docs/reference/API_AUTHENTICATE.md) |
| `loginByGooglePlayGameServiceAsync` | Có credential Google Play Games | `token`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | [client:25-25](/docs/reference/API_AUTHENTICATE.md) |
| `loginByFacebookAsync` | Có Facebook token hợp lệ | `token`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | [client:22-22](/docs/reference/API_AUTHENTICATE.md) |
| `loginByAppleAsync` | Có Apple token hợp lệ | `token`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | [client:18-18](/docs/reference/API_AUTHENTICATE.md) |
| `loginByGameCenterAsync` | Có payload xác thực Game Center | `playerId`, `name`, `publicKeyUrl`, `signature`, `salt`, `timestamp`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | [client:26-26](/docs/reference/API_AUTHENTICATE.md) |
| `loginByGenericServiceAsync` | Provider tùy biến do backend hỗ trợ | `serviceName`, `serviceData`, `createPlayerIfNotExists`, `infoRequestParam` | `GenericServiceAuthenticateResponseData` | [client:23-23](/docs/reference/API_AUTHENTICATE.md) |

Decision rules:

- Có username/password đã tồn tại: `loginByAccountAsync`.
- Muốn tạo username/password mới: `registerAccountAsync`.
- Có token đang lưu và muốn gia hạn phiên: `refreshAuthTokenAsync`.
- Có token từ provider ngoài: dùng đúng method theo provider.
- Có identity nội bộ của app: ưu tiên `loginByCustomIdAsync`.
- Có identity gắn với thiết bị hoặc cài đặt app: ưu tiên `loginByCustomDeviceIdAsync`.
- Đang chạy local/test trong editor: dùng `loginByEditorDeviceIdAsync`.
- Provider đặc thù chưa có method riêng nhưng backend hỗ trợ: `loginByGenericServiceAsync`.

## 5. Method Signature

Mỗi method có 2 form: callback và `*Async()` Task. Mặc định sinh code bằng async form.

```csharp
// Callback
GNNetwork.authenticate.<method>(requestData, onResponse, overrideAuthToken, overrideSecretKey, customTags, timeout);

// Async
var response = await GNNetwork.authenticate.<method>Async(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
```

Param chung:

<!-- prettier-ignore -->
| Param | Type | Khi nào cần |
| --- | --- | --- |
| `requestData` | domain-specific DTO | Payload chính; tạo bằng `new AuthenticateModels.<Method>RequestData()` |
| `onResponse` | `Action1<TResponse>` | Chỉ có ở callback form |
| `overrideAuthToken` | `string` | Refresh/impersonate/multi-session khi cần dùng auth token khác token cache |
| `overrideSecretKey` | `string` | Override secret key mặc định cho một request |
| `customTags` | `GNHashtable` | Trace id, build version, A/B bucket; backend có thể log/route |
| `timeout` | `int` | Override timeout theo request, tính bằng giây |

Typed response expose public fields: `returnCode`, `errorCode`, `invalidMembers`, `debugMessage`, `responseData`. Xem [RULES.md response checking](/docs/RULES.md).

## 6. Request Field Rules

- DTO fields: [reference/dto/AUTHENTICATE.md](/docs/reference/dto/AUTHENTICATE.md).
- Contract table: [reference/API_AUTHENTICATE.md](/docs/reference/API_AUTHENTICATE.md).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Enum `GoogleLoginType`: [reference/ENUMS.md](/docs/reference/ENUMS.md#googlelogintype).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/Authenticate*.cs`.

<!-- prettier-ignore -->
| DTO / field | Quick rule | DTO link |
| --- | --- | --- |
| `InfoRequestParam` | required ở login/register; truyền instance kể cả khi không hydrate gì | [AuthenticateModels.InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam) |
| `LoginByAccountRequestData.username` / `password` | required cho account login | [AuthenticateModels.LoginByAccountRequestData:30-44](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbyaccountrequestdata) |
| `RegisterAccountRequestData.username` / `password` | required khi tạo account mới | [AuthenticateModels.RegisterAccountRequestData:277-291](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#registeraccountrequestdata) |
| `createPlayerIfNotExists` | bật khi flow login được phép tự tạo player mới | [device/custom/social request DTOs](/docs/reference/dto/AUTHENTICATE.md) |
| `LoginByGoogleRequestData.type` | field là `int`; lấy từ `GoogleLoginType` rồi cast rõ ràng | [AuthenticateModels.LoginByGoogleRequestData:151-166](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbygooglerequestdata) |
| `LoginByGenericServiceRequestData.serviceData` | payload provider tùy biến; backend phải biết cách verify | [AuthenticateModels.LoginByGenericServiceRequestData:135-150](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbygenericservicerequestdata) |
| `RefreshAuthTokenRequestData` | request rỗng; token hiện tại lấy từ cache hoặc `overrideAuthToken` | [AuthenticateModels.RefreshAuthTokenRequestData:292-297](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#refreshauthtokenrequestdata) |

## 7. Auth Và Socket Flow

Flow chuẩn:

1. Gọi login/register/refresh qua HTTP.
2. Check `returnCode`, rồi `errorCode`.
3. Lấy token/user hiện tại từ `GNNetwork.getAuthenticateStatus()` nếu cần.
4. Nếu app cần realtime, subscribe handler trước.
5. Gọi `GNNetwork.connectSocket()`. SDK auto-auth socket nếu auth token đã có.

Rule cứng:

- Không login qua socket.
- Không gọi `sendRequestAuthSocket()` sau mọi `connectSocket()`; chỉ dùng khi socket đã connect trước khi có token, hoặc token vừa đổi và muốn re-auth ngay.
- Không giả định HTTP login tự bật realtime event; vẫn phải subscribe handler và connect socket.

## 8. Minimal Pattern

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var infoRequestParam = new AuthenticateModels.InfoRequestParam();
infoRequestParam.displayName = true;
infoRequestParam.avatar = true;

var requestData = new AuthenticateModels.LoginByAccountRequestData();
requestData.username = username;
requestData.password = password;
requestData.infoRequestParam = infoRequestParam;

var response = await GNNetwork.authenticate.loginByAccountAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var authToken = response.responseData.authToken;
var userId = response.responseData.userId;
```

Nếu codebase đã có helper riêng như `hasReturnCodeError()` và muốn throw exception thay vì early-return, vẫn phải giữ thứ tự check 2 tầng: `returnCode` trước, `errorCode` sau.

## 9. Ví Dụ Khuyến Nghị

### Guest login bằng custom device id

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var infoRequestParam = new AuthenticateModels.InfoRequestParam();
infoRequestParam.displayName = true;
infoRequestParam.avatar = true;

var requestData = new AuthenticateModels.LoginByCustomDeviceIdRequestData();
requestData.customDeviceId = "device-000001";
requestData.createPlayerIfNotExists = true;
requestData.infoRequestParam = infoRequestParam;

var response = await GNNetwork.authenticate.loginByCustomDeviceIdAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var authToken = GNNetwork.getAuthenticateStatus().getAuthToken();
var userId = GNNetwork.getAuthenticateStatus().getUserId();
```

### Google login

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var infoRequestParam = new AuthenticateModels.InfoRequestParam();
infoRequestParam.displayName = true;

var requestData = new AuthenticateModels.LoginByGoogleRequestData();
requestData.token = googleToken;
requestData.type = (int)GoogleLoginType.IdToken;
requestData.createPlayerIfNotExists = true;
requestData.infoRequestParam = infoRequestParam;

var response = await GNNetwork.authenticate.loginByGoogleAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;
```

### Refresh auth token

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new AuthenticateModels.RefreshAuthTokenRequestData();
var response = await GNNetwork.authenticate.refreshAuthTokenAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var authToken = response.responseData.authToken;
```

### Kết nối socket sau khi đã có token

```csharp
using XmobiTea.GearN;

GNNetwork.subscriberOnConnectHandler(() => {
    UnityEngine.Debug.Log("socket connected: " + GNNetwork.getSocketSId());
});

GNNetwork.connectSocket();
```

## 10. Anti-Patterns

- Không gọi `GNNetwork.authenticate.admin` hoặc `GNNetwork.authenticate.server`.
- Không connect socket trước rồi dùng socket để login.
- Không bỏ qua `infoRequestParam` ở các flow login/register.
- Không bulk-set mọi field trong `infoRequestParam` nếu màn hình không cần.
- Không kiểm tra success bằng `0`; SDK này dùng `ReturnCode.Ok == 1` và `ErrorCode.Ok == 1`.
- Không đọc `errorCode` hoặc `responseData` khi `returnCode != ReturnCode.Ok`.
- Không dùng callback style mặc định khi codebase đã support `async/await`.
- Không ép token provider này vào method provider khác.

## 11. AI Checklist

- Đã tạo/cấu hình `Resources/GNServerSettings`.
- `secretKey` đã hợp lệ.
- Method được chọn đúng với nguồn identity.
- Có `infoRequestParam` cho login/register.
- Có check `returnCode` trước `errorCode`.
- Nếu dùng Google login, `type` đã lấy từ `GoogleLoginType`.
- Nếu cần socket event sau login, đã tuân theo [RULES socket flow](/docs/RULES.md#7-auth--socket-flow).

## Quick Map

Dùng bảng này để đọc đúng dòng mà không load cả file. `offset = startLine - 1`, `limit = endLine - startLine + 1`.

<!-- prettier-ignore -->
| Section | Lines |
| --- | --- |
| §4 Chọn Method (bảng 18 method login/register/refresh) | 36-76 |
| §7 Auth Và Socket Flow | 123-138 |
| §8 Minimal Pattern | 139-165 |
| §9 Ví Dụ Khuyến Nghị (guest, Google, refresh, socket) | 166-241 |
