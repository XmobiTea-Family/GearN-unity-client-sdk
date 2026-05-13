# CloudScriptApi

Tài liệu này dành cho AI code assistant và AI agent nội bộ. Mục tiêu là chọn đúng namespace `client/server/admin`, phân biệt đúng publish version với execute function, và không sinh sai request ở các field `version`, `functionName`, `userId`, `script`.

Nếu mục tiêu là viết phần source chạy trong CloudScript runtime, đọc thêm [cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md). File này chỉ mô tả public API để publish, execute, inspect và promote version.

## 1. Scope

- Áp dụng cho:
    - `GNNetwork.cloudScript`
    - `GNNetwork.cloudScript.server`
    - `GNNetwork.cloudScript.admin`
- Toàn bộ method hiện tại của `CloudScriptApi` đều gửi qua HTTP.
- `CloudScriptApi` có đủ 3 role thật:
    - `GNNetwork.cloudScript` -> `RequestRole.Client`
    - `GNNetwork.cloudScript.server` -> `RequestRole.Server`
    - `GNNetwork.cloudScript.admin` -> `RequestRole.Admin`
- Nếu không truyền `overrideSecretKey`, SDK sẽ tự lấy secret key theo role tương ứng.
- Chỉ dùng namespace `.server` khi bạn đã cấu hình `secretKey` với `permission rules` `server` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Chỉ dùng namespace `.admin` khi bạn đã cấu hình `secretKey` với `permission rules` `admin` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Rule chuẩn để chọn `client/server/admin` và hiểu semantics permission xem [RULES](/docs/RULES.md#3-route--trust-boundary-của-caller). Với nhóm này, không tự suy diễn route chỉ từ target ownership.
- Public surface hiện chỉ có 5 operation trên mỗi namespace:
    - `addFunctionAsync`
    - `editFunctionAsync`
    - `executeFunctionAsync`
    - `getFunctionAsync`
    - `getFunctionsAsync`
- `CloudScriptApi` không có public method `removeFunction` hoặc hard-delete version.
- `CloudScriptApi` không có socket transport, không có realtime event handler riêng.
- Từ contract hiện tại, `version` đại diện cho một snapshot script đã publish; `functionName` là tên function sẽ được gọi bên trong snapshot đó.
- `script` gửi lên không phải file TypeScript hoàn chỉnh; runtime GearN Server inject source vào template và gọi `handlers[functionName]`.
- Source script phải tự đăng ký function bằng `handlers["functionName"] = async (args, context, log) => { ... }`; dạng `handlers.functionName = ...` cũng hợp lệ khi tên là identifier, nhưng dạng bracket dễ sinh code an toàn hơn.
- `DashboardApi.getEventCallbackCloudScriptAsync` và `setEventCallbackCloudScriptAsync` là nhóm khác; không nằm trong `CloudScriptApi`.

## 2. Hard Rules

- Luôn ưu tiên `async/await`. Mặc định dùng `*Async()`.
- Bắt buộc đã `Resources/GNServerSettings` trước khi gọi.
- Không dùng socket cho `CloudScriptApi`.
- Không dùng literal `GNNetwork` trong `AddFunctionRequestData.script`; GearN Server reject script trước compile.
- Không dùng `import`, `export`, `require`, `process`, `fetch`, timer primitive hoặc top-level side effect trong submitted script; xem [cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md).
- Chọn namespace theo trust boundary:
    - app/player execute function -> `GNNetwork.cloudScript`
    - trusted backend/service -> `GNNetwork.cloudScript.server`
    - dashboard/ops/tooling -> `GNNetwork.cloudScript.admin`
- Không dùng `GNNetwork.cloudScript` để quản trị version trong production trừ khi backend policy của bạn cho phép rõ ràng.
- `AddFunctionRequestData.script` là bắt buộc và phải là source script hoàn chỉnh cho version mới.
- `addFunctionAsync` tạo version mới từ `script`; không phải update tại chỗ một version cũ.
- `editFunctionAsync` chỉ sửa metadata của version hiện có:
    - `canExecute`
    - `isLive`
- `editFunctionAsync` không có field `script`; AI không được giả định nó sửa source code.
- Nếu cần thay đổi source code, phải publish version mới bằng `addFunctionAsync`.
- `GetFunctionRequestData.version`, `EditFunctionRequestData.version` và `ExecuteFunctionRequestData.version` nếu có đều phải theo đúng version string dài `7` ký tự.
- `ExecuteFunctionRequestData.functionName` là bắt buộc, độ dài `3..30`.
- `ExecuteFunctionRequestData.functionParameters` là `any`, nhưng thực tế nên dùng object/array/primitive JSON-serializable.
- `GNNetwork.cloudScript.executeFunctionAsync` cho phép `userId` optional.
- `GNNetwork.cloudScript.server.executeFunctionAsync` và `GNNetwork.cloudScript.admin.executeFunctionAsync` bắt buộc có `userId`.
- `getFunctionsAsync` không nhận filter, không có pagination; request data là object rỗng.
- `ExecuteFunctionResponseData.status` nên so sánh bằng enum public `ExecuteResponseStatus`, không hardcode số.
- `GetFunctionsResponseData.results[]` chỉ có `version` và `canExecute`.
- `GetFunctionsResponseData.results[]` không có `isLive`; nếu cần biết version live, phải đọc `liveLatestVersion`.
- `GetFunctionResponseData` không trả lại `version`; nếu cần giữ `version`, phải giữ từ request hoặc lấy từ danh sách trước đó.

## 3. Chọn Namespace

<!-- prettier-ignore -->
| Namespace | Role thật | Dùng khi nào |
| --- | --- | --- |
| `GNNetwork.cloudScript` | `Client` | player app chỉ cần execute function đã được backend cho phép |
| `GNNetwork.cloudScript.server` | `Server` | trusted backend, worker, game server execute/publish theo workflow backend |
| `GNNetwork.cloudScript.admin` | `Admin` | dashboard, backoffice, vận hành version, promote live version |

Rule nhanh:

- Flow execute từ app public: ưu tiên `GNNetwork.cloudScript`.
- Flow execute thay mặt một user từ backend: ưu tiên `GNNetwork.cloudScript.server`.
- Flow publish script, promote live version, audit version: ưu tiên `GNNetwork.cloudScript.admin`.
- Không chọn namespace theo cảm tính; request shape gần giống nhau nhưng trust boundary khác nhau.

## 4. Chọn Method

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `addFunctionAsync` | Publish một script version mới | `script`, `canExecute`, `isLive` | `AddFunctionResponseData` | Trả `version` mới và `errorMessage` | `Ok`, `GameNotFound`, `ExecuteError` |
| `editFunctionAsync` | Bật/tắt execute hoặc promote/demote live cho version cũ | `version`, `canExecute`, `isLive` | `EditFunctionResponseData` | Không sửa `script` | `Ok`, `GameNotFound`, `ExecuteError` |
| `executeFunctionAsync` | Chạy một function trong CloudScript | `functionName`, `functionParameters?`, `version?`, `userId?` | `ExecuteFunctionResponseData` | `server/admin` bắt buộc có `userId` | `Ok`, `GameNotFound`, `ExecuteError` |
| `getFunctionAsync` | Đọc chi tiết source và metadata của một version cụ thể | `version` | `GetFunctionResponseData` | Trả `script`, `canExecute`, `isLive`, `tsCreate` | `Ok`, `GameNotFound`, `VersionInvalid` |
| `getFunctionsAsync` | Liệt kê các version hiện có | request object rỗng | `GetFunctionsResponseData` | Trả `results`, `latestVersion`, `liveLatestVersion` | `Ok`, `GameNotFound` |

## 5. Decision Rules

- Cần publish source code mới: dùng `addFunctionAsync`.
- Cần đổi source code của script đang có: không dùng `editFunctionAsync`; phải tạo version mới bằng `addFunctionAsync`.
- Cần bật/tắt quyền execute của một version: dùng `editFunctionAsync`.
- Cần đổi version live: dùng `editFunctionAsync` với đúng `version`.
- Cần chạy một function business: dùng `executeFunctionAsync`.
- Cần inspect source code hoặc metadata của đúng một version: dùng `getFunctionAsync`.
- Cần lấy `latestVersion` hoặc `liveLatestVersion`: dùng `getFunctionsAsync`.
- Cần cấu hình event callback CloudScript ở hệ thống dashboard: không dùng `CloudScriptApi`; dùng `DashboardApi`.

## 6. Request Rules Và Reference

- DTO fields: [reference/dto/CLOUDSCRIPT.md](/docs/reference/dto/CLOUDSCRIPT.md). Method table: [reference/API_CLOUDSCRIPT.md](/docs/reference/API_CLOUDSCRIPT.md).
- Enums: [ExecuteResponseStatus](/docs/reference/ENUMS.md#executeresponsestatus).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/CloudScript*.cs`.
- `AddFunctionRequestData.script` là bắt buộc.
- `AddFunctionRequestData.canExecute` và `AddFunctionRequestData.isLive` nên luôn set explicit, không dựa vào default ngầm.
- `EditFunctionRequestData.version` là bắt buộc, đúng `7` ký tự.
- `EditFunctionRequestData` không có `script`.
- `ExecuteFunctionRequestData.functionName` là bắt buộc.
- `ExecuteFunctionRequestData.version` là optional.
- `ExecuteFunctionRequestData.userId`:
    - optional ở namespace `client`
    - bắt buộc ở namespace `server`
    - bắt buộc ở namespace `admin`
- `GetFunctionRequestData.version` là bắt buộc.
- `GetFunctionsRequestData` hiện không có field nào; không được tự thêm `version`, `skip`, `limit`, `keyword` hoặc filter giả định.

## 7. Response Rules

Tất cả typed response của `CloudScriptApi` đều có:

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

Rule bổ sung theo từng operation:

- `addFunctionAsync`:
    - đọc `responseData.version` để lấy version mới
    - kiểm tra `responseData.errorMessage` trước khi coi publish là thành công hoàn toàn
- `editFunctionAsync`:
    - response chỉ có `errorMessage`
    - không có `version` mới, không có `script`
- `executeFunctionAsync`:
    - đọc `responseData.status`
    - đọc `responseData.functionResult`
    - đọc `responseData.functionLogs`
    - đọc `responseData.errorMessage`
    - đọc `responseData.executionTimeInMs` và `memoryUsedInBytes` nếu cần telemetry
- `getFunctionAsync` (public API typo; DTO/operation still use `GetFunction`):
    - trả `script`, `canExecute`, `isLive`, `tsCreate`
- `getFunctionsAsync`:
    - `results[]` chỉ là summary nhẹ
    - dùng `latestVersion` để biết version mới nhất
    - dùng `liveLatestVersion` để biết version live mới nhất

## 8. Best Practices

- Ưu tiên `client` cho execute, ưu tiên `server/admin` cho publish và quản trị version.
- Khi viết source script, dùng [cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md) làm checklist trước publish.
- Sau `addFunctionAsync`, luôn lưu lại `responseData.version`.
- Nếu cần promote live version, nên `getFunctionsAsync` trước để xác nhận `latestVersion` và `liveLatestVersion`.
- Với `executeFunctionAsync`, giữ `functionParameters` ở dạng JSON đơn giản; tránh class instance, method, circular reference.
- Với `executeFunctionAsync` ở `server/admin`, giữ `userId` ở biến riêng và truyền explicit.
- Với debug hoặc vận hành, log lại `functionLogs`, `executionTimeInMs`, `memoryUsedInBytes`.
- Nếu workflow phụ thuộc source code của một version, lấy lại bằng `getFunctionAsync`; đừng suy diễn từ `getFunctionsAsync`.
- Nếu cần callback CloudScript cho event hệ thống, chuyển sang `DashboardApi`, không nhét logic đó vào `CloudScriptApi`.

## 9. Ví Dụ Khuyến Nghị

### Admin publish version mới rồi lấy `version`

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var request = new CloudScriptModels.AdminAddFunctionRequestData();
request.script = @"
handlers[""pingCloudScript""] = async (args, context, log) => {
    return {
        ok: true,
        userId: context.userId,
        echo: args
    };
};
";
request.canExecute = true;
request.isLive = false;

var response = await GNNetwork.cloudScript.admin.addFunctionAsync(request);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

if (!string.IsNullOrEmpty(response.responseData.errorMessage)) {
    throw new System.Exception(response.responseData.errorMessage);
}

var newVersion = response.responseData.version;
```

### Admin promote một version thành live

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var request = new CloudScriptModels.AdminEditFunctionRequestData();
request.version = "ABC1234";
request.canExecute = true;
request.isLive = true;

var response = await GNNetwork.cloudScript.admin.editFunctionAsync(request);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

if (!string.IsNullOrEmpty(response.responseData.errorMessage)) {
    throw new System.Exception(response.responseData.errorMessage);
}
```

### Server execute function cho một user cụ thể

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var request = new CloudScriptModels.ServerExecuteFunctionRequestData();
request.userId = "USER000001";
request.functionName = "grantDailyReward";
request.version = "ABC1234";
request.functionParameters = {
    rewardId: "daily_01",
    amount: 1,
};

var response = await GNNetwork.cloudScript.server.executeFunctionAsync(request);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

if (!string.IsNullOrEmpty(response.responseData.errorMessage)) {
    throw new System.Exception(response.responseData.errorMessage);
}

var result = response.responseData.functionResult;
var logs = response.responseData.functionLogs;
var executionTimeInMs = response.responseData.executionTimeInMs;
```

### Đọc summary version rồi lấy source của version live

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var listRequest = new CloudScriptModels.GetFunctionsRequestData();
var listResponse = await GNNetwork.cloudScript.getFunctionsAsync(listRequest);

if (listResponse.hasReturnCodeError()) {
    throw new System.Exception(listResponse.debugMessage);
}

if (listResponse.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + listResponse.errorCode);
}

var liveVersion = listResponse.responseData.liveLatestVersion;

var getRequest = new CloudScriptModels.GetFunctionRequestData();
getRequest.version = liveVersion;

var getResponse = await GNNetwork.cloudScript.getFunctionAsync(getRequest);

if (getResponse.hasReturnCodeError()) {
    throw new System.Exception(getResponse.debugMessage);
}

if (getResponse.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + getResponse.errorCode);
}

var script = getResponse.responseData.script;
```

## 10. Anti-Patterns

- Không dùng `editFunctionAsync` để đổi source code.
- Không tự thêm field `script` vào `EditFunctionRequestData`.
- Không quên `userId` khi dùng `cloudScript.server.executeFunctionAsync` hoặc `cloudScript.admin.executeFunctionAsync`.
- Không nhầm `version` với `functionName`.
- Không giả định `getFunctionsAsync` có phân trang hoặc filter.
- Không suy diễn `isLive` từ `results[]`; phải đọc `liveLatestVersion`.
- Không bỏ qua `responseData.errorMessage` ở `addFunctionAsync`, `editFunctionAsync`, `executeFunctionAsync`.
- Không dùng object phức tạp, class instance hoặc circular reference trong `functionParameters`.
- Không dùng `CloudScriptApi` để cấu hình event callback dashboard.
- Không hardcode số cho `ExecuteFunctionResponseData.status`; dùng `ExecuteResponseStatus`.
- Không giả định SDK có public delete version.

## 11. AI Checklist

- Đã `Resources/GNServerSettings` chưa.
- Nếu đang viết source script, đã đọc [cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md) chưa.
- Đã chọn đúng namespace `cloudScript` / `cloudScript.server` / `cloudScript.admin` chưa.
- Nếu đang execute ở `server/admin`, đã truyền `userId` chưa.
- Nếu đang update source code, có đang dùng sai `editFunctionAsync` thay vì `addFunctionAsync` không.
- Nếu đang cần version live, có đang đọc `liveLatestVersion` chưa.
- Nếu đang cần source của một version, có đang dùng `getFunctionAsync` thay vì chỉ nhìn `getFunctionsAsync` không.
- Nếu đang đọc kết quả execute, có kiểm tra cả `errorCode` lẫn `responseData.errorMessage` chưa.
- Nếu đang truyền `functionParameters`, có giữ payload JSON-serializable không.
- Nếu flow là cấu hình event callback CloudScript, có đang dùng nhầm `CloudScriptApi` không.
