# AuthenticateApi

Tài liệu này dành cho AI code assistant và AI agent nội bộ. Mục tiêu là chọn đúng method của `GNNetwork.authenticate`, truyền đúng input, kiểm tra đúng response, và không sinh code sai role.

## 1. Scope

- Áp dụng cho `GNNetwork.authenticate`.
- Không áp dụng cho `GNNetwork.authenticate.server` và `GNNetwork.authenticate.admin` vì hiện tại hai namespace này không expose method public.
- Nếu cần login admin dashboard, dùng `GNNetwork.dashboard.loginByAdminAccountAsync`, không dùng `AuthenticateApi`.
- Nếu cần gọi server-side operation sau khi đã có danh tính, dùng API group tương ứng với `.server` và secret có permission rule phù hợp. Không dùng `AuthenticateApi.server`.

## 2. Rules Bắt Buộc

- Ưu tiên `async/await`; mặc định dùng `GNNetwork.authenticate.*Async()`.
- Các method của `AuthenticateApi` hiện gửi qua HTTP, không login qua socket.
- Trước khi gọi API, phải có asset `Resources/GNServerSettings` và `secretKey` hợp lệ.
- Mọi flow login/register phải truyền instance `infoRequestParam` khác `null`; riêng `refreshAuthTokenAsync` dùng request rỗng.
- Sau khi login hoặc refresh thành công, nếu backend trả `authToken` và `userId`, SDK tự cache vào `GNNetwork.getAuthenticateStatus()` và storage nội bộ.
- Nếu cần realtime sau login, làm theo [socket rule trong RULES](/docs/RULES.md#7-auth--socket-flow): login HTTP thành công, subscribe handler, rồi `GNNetwork.connectSocket()`.

## 3. Chọn Method

<!-- prettier-ignore -->
| Method | Dùng khi nào | Field chính | Response | Ghi chú |
| --- | --- | --- | --- | --- |
| `loginByAccountAsync` | Đã có username/password | `username`, `password`, `infoRequestParam` | `AuthenticateResponseData` | Không dùng để tạo account mới |
| `registerAccountAsync` | Tạo username/password mới | `username`, `password`, `infoRequestParam` | `AuthenticateResponseData` | Không gọi lặp lại mỗi lần mở app |
| `refreshAuthTokenAsync` | Gia hạn phiên đã login | request rỗng | `RefreshAuthTokenResponseData` | Token hiện tại lấy từ SDK cache hoặc `overrideAuthToken` |
| `loginByCustomDeviceIdAsync` | Guest/anonymous theo device/app install id | `customDeviceId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | Phù hợp guest flow |
| `loginByCustomIdAsync` | App đã có identity riêng | `customId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | Không bắt buộc là device id |
| `loginByEditorDeviceIdAsync` | Local/dev trong Unity Editor | `editorDeviceId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | Chỉ nên dùng khi phát triển |
| `loginByAndroidDeviceIdAsync` | Identity thật là Android device id | `androidDeviceId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | Dùng đúng platform source |
| `loginByiOSDeviceIdAsync` | Identity thật là iOS device id | `iOSDeviceId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | Dùng đúng platform source |
| `loginByLinuxDeviceIdAsync` | Identity thật là Linux device id | `linuxDeviceId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | Dùng đúng platform source |
| `loginByMacOSDeviceIdAsync` | Identity thật là macOS device id | `macOSDeviceId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | Dùng đúng platform source |
| `loginByWindowsDeviceIdAsync` | Identity thật là Windows device id | `windowsDeviceId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | Dùng đúng platform source |
| `loginByWindowsPhoneDeviceIdAsync` | Legacy Windows Phone identity | `windowsPhoneDeviceId`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | Legacy flow |
| `loginByGoogleAsync` | Có Google token | `token`, `type`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | `type` lấy từ `GoogleLoginType` |
| `loginByGooglePlayGameServiceAsync` | Có credential Google Play Games | `token`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | Không thay bằng `loginByGoogleAsync` nếu source là GPGS |
| `loginByFacebookAsync` | Có Facebook token hợp lệ | `token`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | Không truyền `facebookId` thô |
| `loginByAppleAsync` | Có Apple token hợp lệ | `token`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | Không truyền `appleId` thô |
| `loginByGameCenterAsync` | Có payload xác thực Game Center | `playerId`, `name`, `publicKeyUrl`, `signature`, `salt`, `timestamp`, `createPlayerIfNotExists`, `infoRequestParam` | `AuthenticateResponseData` | Cần đủ payload xác thực |
| `loginByGenericServiceAsync` | Provider tùy biến do backend hỗ trợ | `serviceName`, `serviceData`, `createPlayerIfNotExists`, `infoRequestParam` | `GenericServiceAuthenticateResponseData` | Dùng khi provider không khớp các method có sẵn |

Quyết định nhanh:

- Có username/password đã tồn tại: `loginByAccountAsync`.
- Muốn tạo username/password mới: `registerAccountAsync`.
- Có token đang lưu và muốn gia hạn phiên: `refreshAuthTokenAsync`.
- Có token từ provider ngoài: dùng đúng method theo provider.
- Có identity nội bộ của app: ưu tiên `loginByCustomIdAsync`.
- Có identity gắn với thiết bị hoặc cài đặt app: ưu tiên `loginByCustomDeviceIdAsync`.
- Đang chạy local/test trong editor: dùng `loginByEditorDeviceIdAsync`.
- Provider đặc thù chưa có method riêng nhưng backend hỗ trợ: `loginByGenericServiceAsync`.

## 4. InfoRequestParam

`infoRequestParam` quyết định backend hydrate phần nào vào `responseData.infoResponseParameters`. Đây là field required cho login/register; nếu chưa cần hydrate field nào, vẫn truyền `new AuthenticateModels.InfoRequestParam()` và không bật flag nào.

- Không truyền `null` cho các flow login/register.
- Chỉ request field thật sự cần.
- Nếu cần dữ liệu theo key, dùng các mảng filter như `playerDataKeys`, `playerCurrencyKeys`, `playerStatisticsKeys`, `customDataKeys`, `tagKeys`.
- Schema đầy đủ: [AUTHENTICATE_MODELS.md](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam).
- Tham khảo thêm: [reference/API_AUTHENTICATE.md](/docs/reference/API_AUTHENTICATE.md), [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md), [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md). Source: [Runtime/GNNetworkAuthenticateApi.cs](/Runtime/GNNetworkAuthenticateApi.cs).

Ví dụ tối thiểu:

```csharp
using XmobiTea.GearN.Entity.Models;

var infoRequestParam = new AuthenticateModels.InfoRequestParam();
infoRequestParam.displayName = true;
infoRequestParam.avatar = true;
```

Ví dụ filter theo key:

```csharp
using XmobiTea.GearN.Entity.Models;

var infoRequestParam = new AuthenticateModels.InfoRequestParam();
infoRequestParam.displayName = true;
infoRequestParam.playerDatas = true;
infoRequestParam.playerStatistics = true;
infoRequestParam.playerDataKeys = new System.Collections.Generic.List<string> { "profile", "settings" };
infoRequestParam.playerStatisticsKeys = new System.Collections.Generic.List<string> { "level", "exp" };
```

## 5. Google Login

`loginByGoogleAsync` bắt buộc có `request.type`. Field DTO là `int`, nên lấy giá trị từ [GoogleLoginType](/docs/reference/ENUMS.md#googlelogintype) rồi cast rõ ràng.

```csharp
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new AuthenticateModels.LoginByGoogleRequestData();
requestData.token = googleToken;
requestData.type = (int)GoogleLoginType.IdToken;
requestData.createPlayerIfNotExists = true;
requestData.infoRequestParam = infoRequestParam;
```

## 6. Response Rules

Tất cả typed response của `AuthenticateApi` có các field low-level giống các nhóm API khác:

- `returnCode`: transport/protocol/permission status.
- `debugMessage`: message low-level để log/debug.
- `invalidMembers`: danh sách field invalid nếu request sai.
- `errorCode`: business error từ backend.
- `responseData`: typed payload đã deserialize.

Luôn check hai tầng theo thứ tự:

```csharp
using XmobiTea.GearN.Constant;

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}
```

Response data theo method:

- Các flow login và `registerAccountAsync` trả `AuthenticateModels.AuthenticateResponseData`.
- `loginByGenericServiceAsync` trả `AuthenticateModels.GenericServiceAuthenticateResponseData`.
- `refreshAuthTokenAsync` trả `AuthenticateModels.RefreshAuthTokenResponseData`.

Field quan trọng trong `AuthenticateResponseData`:

- `userId`
- `authToken`
- `newlyCreated`
- `playerBan`
- `infoResponseParameters`

## 7. Ví Dụ

Login guest bằng custom device id:

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

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

var authToken = GNNetwork.getAuthenticateStatus().getAuthToken();
var userId = GNNetwork.getAuthenticateStatus().getUserId();
```

Refresh auth token:

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new AuthenticateModels.RefreshAuthTokenRequestData();
var response = await GNNetwork.authenticate.refreshAuthTokenAsync(requestData);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}
```

Kết nối socket sau khi đã có token:

```csharp
using XmobiTea.GearN;

GNNetwork.subscriberOnConnectHandler(() => {
    UnityEngine.Debug.Log("socket connected: " + GNNetwork.getSocketSId());
});

GNNetwork.connectSocket();
```

## 8. Anti-Patterns

- Không gọi `GNNetwork.authenticate.admin` hoặc `GNNetwork.authenticate.server`.
- Không connect socket trước rồi dùng socket để login.
- Không bỏ qua `infoRequestParam` ở các flow login/register.
- Không kiểm tra success bằng `0`; SDK này dùng `ReturnCode.Ok == 1` và `ErrorCode.Ok == 1`.
- Không request quá nhiều field trong `infoRequestParam` nếu màn hình không cần.
- Không dùng callback style mặc định khi codebase đã support `async/await`.
- Không ép token provider này vào method provider khác.

## 9. Checklist

- Đã tạo/cấu hình `Resources/GNServerSettings`.
- `secretKey` đã hợp lệ.
- Method được chọn đúng với nguồn identity.
- Có `infoRequestParam` cho login/register.
- Có check `hasReturnCodeError()` trước `errorCode`.
- Nếu cần socket event sau login, đã tuân theo [RULES socket flow](/docs/RULES.md#7-auth--socket-flow).
