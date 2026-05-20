# CloudScriptApi

Tài liệu này là landing page cho AI code assistant khi cần dùng `GNNetwork.cloudScript*`. Đọc file này để chọn đúng namespace, method, DTO nhanh, và chỉ mở đúng row trong [API_CLOUDSCRIPT.md](/docs/reference/API_CLOUDSCRIPT.md) khi cần contract chi tiết.

Nếu mục tiêu là viết source chạy trong CloudScript runtime, đọc thêm [cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md). File này chỉ mô tả public API để publish version, execute function, inspect source, và promote version.

## 1. Scope

- Áp dụng cho `GNNetwork.cloudScript`, `GNNetwork.cloudScript.server`, và `GNNetwork.cloudScript.admin`.
- Tất cả method hiện tại của `CloudScriptApi` đi qua HTTP; không dùng socket.
- `CloudScriptApi` có 3 role thật:
    - `GNNetwork.cloudScript` -> `RequestRole.Client`
    - `GNNetwork.cloudScript.server` -> `RequestRole.Server`
    - `GNNetwork.cloudScript.admin` -> `RequestRole.Admin`
- Public surface hiện chỉ có 5 operation trên mỗi namespace: `addFunctionAsync`, `editFunctionAsync`, `executeFunctionAsync`, `getFunctionAsync`, `getFunctionsAsync`.
- `CloudScriptApi` không có public method `removeFunction` hoặc hard-delete version.
- `DashboardApi.getEventCallbackCloudScriptAsync` và `setEventCallbackCloudScriptAsync` là nhóm khác; không nằm trong `CloudScriptApi`.
- `script` gửi lên không phải file TypeScript hoàn chỉnh; GearN Server inject source vào template và gọi `handlers[functionName]`.
- Source script phải tự đăng ký handler bằng `handlers["functionName"] = async (args, context, log) => { ... }`.
- Rule chọn route/permission canonical: [RULES.md route rules](/docs/RULES.md). Với `CloudScriptApi`, không tự suy diễn route từ ownership.

## 2. Hard Rules

- Ưu tiên `async/await`; mặc định dùng `*Async()`.
- Bắt buộc đã có `Resources/GNServerSettings` trước khi gọi.
- Không dùng socket cho `CloudScriptApi`.
- Chọn namespace theo actor thật đang chạy code: client app, trusted backend, hay admin/backoffice tool.
- Chỉ dùng `.server` khi code chạy trong trusted backend/worker và secret có permission `serverSelfEnable` phù hợp.
- Chỉ dùng `.admin` khi code chạy trong dashboard/backoffice/admin tool và secret có permission `adminSelfEnable` phù hợp.
- Không dùng literal `GNNetwork` trong `AddFunctionRequestData.script`; GearN Server reject script trước compile.
- Không dùng `import`, `export`, `require`, `process`, `fetch`, timer primitive hoặc top-level side effect trong submitted script; xem [cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md).
- `addFunctionAsync` tạo version mới từ `script`; không update tại chỗ một version cũ.
- `editFunctionAsync` chỉ sửa metadata/flag của version hiện có: `canExecute`, `isLive`. Nó không có field `script`.
- Nếu cần đổi source code, phải publish version mới bằng `addFunctionAsync`.
- `ExecuteFunctionRequestData.functionName` là bắt buộc, độ dài `3..30`.
- `GNNetwork.cloudScript.executeFunctionAsync` cho phép `userId` optional; `.server` và `.admin` bắt buộc có `userId`.
- `getFunctionsAsync` không nhận filter, không có pagination; request data là object rỗng.
- `ExecuteFunctionResponseData.status` nên so sánh bằng enum public `ExecuteResponseStatus`, không hardcode số.

## 3. Chọn Namespace

<!-- prettier-ignore -->
| Namespace | Role thật | Dùng khi nào |
| --- | --- | --- |
| `GNNetwork.cloudScript` | `Client` | Player app execute function đã được backend cho phép |
| `GNNetwork.cloudScript.server` | `Server` | Trusted backend, worker, game server execute/publish theo workflow backend |
| `GNNetwork.cloudScript.admin` | `Admin` | Dashboard, backoffice, vận hành version, promote live version |

Rule nhanh:

- Flow execute từ app public: ưu tiên `GNNetwork.cloudScript`.
- Flow execute thay mặt một user từ backend: ưu tiên `GNNetwork.cloudScript.server`.
- Flow publish script, promote live version, audit version: ưu tiên `GNNetwork.cloudScript.admin`.
- Chỉ dùng `overrideSecretKey` khi có chủ đích override secret mặc định theo role cho một request.

## 4. Chọn Method

Đọc bảng này trước. Cột API contract rows trỏ thẳng đến row cần đọc trong `API_CLOUDSCRIPT.md`; không cần mở full file API.

> Khi thấy [client:16-16](/docs/example.md) nghĩa là chỉ cần đọc đúng từ dòng 16 đến 16 (hoặc gọi chính xác là đọc đúng dòng 16) của tài liệu `/docs/example.md`, tương tự với những cái khác, ví dụ [client:12-15] nghĩa là đọc đúng từ dòng 12 đến 15 của tài liệu, nếu có tool đọc từ startLine đến endLine ưu tiên cái này thay vì mở toàn bộ file.

> Thứ tự columns `API contract rows` của `client` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp | Permission Rules khi truyền userId khác với gamePlayer đang authenticated |`, `server` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |`, `admin` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |`.

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `addFunctionAsync` | Publish một script version mới | `script`, `canExecute`, `isLive` | `responseData.version`, `errorMessage` | [client:15-15](/docs/reference/API_CLOUDSCRIPT.md) / [server:26-26](/docs/reference/API_CLOUDSCRIPT.md) / [admin:37-37](/docs/reference/API_CLOUDSCRIPT.md) |
| `editFunctionAsync` | Bật/tắt execute hoặc promote/demote live cho version cũ | `version`, `canExecute`, `isLive` | `responseData.errorMessage` | [client:16-16](/docs/reference/API_CLOUDSCRIPT.md) / [server:27-27](/docs/reference/API_CLOUDSCRIPT.md) / [admin:38-38](/docs/reference/API_CLOUDSCRIPT.md) |
| `executeFunctionAsync` | Chạy một function trong CloudScript | `functionName`, `functionParameters?`, `version?`, `userId?` | `status`, `functionResult`, `errorMessage`, telemetry | [client:17-17](/docs/reference/API_CLOUDSCRIPT.md) / [server:28-28](/docs/reference/API_CLOUDSCRIPT.md) / [admin:39-39](/docs/reference/API_CLOUDSCRIPT.md) |
| `getFunctionAsync` | Đọc source và metadata của một version cụ thể | `version` | `script`, `canExecute`, `isLive`, `tsCreate`, `functionLogs` | [client:18-18](/docs/reference/API_CLOUDSCRIPT.md) / [server:29-29](/docs/reference/API_CLOUDSCRIPT.md) / [admin:40-40](/docs/reference/API_CLOUDSCRIPT.md) |
| `getFunctionsAsync` | Liệt kê các version hiện có | request object rỗng | `results`, `latestVersion`, `liveLatestVersion` | [client:19-19](/docs/reference/API_CLOUDSCRIPT.md) / [server:30-30](/docs/reference/API_CLOUDSCRIPT.md) / [admin:41-41](/docs/reference/API_CLOUDSCRIPT.md) |

Decision rules:

- Cần publish source code mới: dùng `addFunctionAsync`.
- Cần đổi source code của script đang có: không dùng `editFunctionAsync`; phải tạo version mới bằng `addFunctionAsync`.
- Cần bật/tắt quyền execute hoặc đổi version live: dùng `editFunctionAsync`.
- Cần chạy function business: dùng `executeFunctionAsync`.
- Cần inspect source/metadata của đúng một version: dùng `getFunctionAsync`.
- Cần lấy `latestVersion` hoặc `liveLatestVersion`: dùng `getFunctionsAsync`.
- Cần cấu hình event callback CloudScript ở dashboard: không dùng `CloudScriptApi`; dùng `DashboardApi`.

## 5. Method Signature

Mỗi method có 2 form: callback và `*Async()` Task. Mặc định sinh code bằng async form.

```csharp
// Callback
GNNetwork.cloudScript.<method>(requestData, onResponse, overrideAuthToken, overrideSecretKey, customTags, timeout);
GNNetwork.cloudScript.server.<method>(requestData, onResponse, overrideAuthToken, overrideSecretKey, customTags, timeout);
GNNetwork.cloudScript.admin.<method>(requestData, onResponse, overrideAuthToken, overrideSecretKey, customTags, timeout);

// Async
var response = await GNNetwork.cloudScript.<method>Async(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
var serverResponse = await GNNetwork.cloudScript.server.<method>Async(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
var adminResponse = await GNNetwork.cloudScript.admin.<method>Async(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
```

Param chung:

<!-- prettier-ignore -->
| Param | Type | Khi nào cần |
| --- | --- | --- |
| `requestData` | domain-specific DTO | Payload chính; tạo bằng `new CloudScriptModels.<Method>RequestData()` hoặc variant `Server*` / `Admin*` |
| `onResponse` | `Action1<TResponse>` | Chỉ có ở callback form |
| `overrideAuthToken` | `string` | Impersonate / multi-session / admin thao tác bằng auth token khác |
| `overrideSecretKey` | `string` | Override secret key mặc định của role cho một request |
| `customTags` | `GNHashtable` | Trace id, build version, A/B bucket; backend có thể log/route |
| `timeout` | `int` | Override timeout theo request, tính bằng giây |

Typed response expose public fields: `returnCode`, `errorCode`, `invalidMembers`, `debugMessage`, `responseData`. Xem [RULES.md response checking](/docs/RULES.md).

## 6. Request Field Rules

- DTO fields: [reference/dto/CLOUDSCRIPT.md](/docs/reference/dto/CLOUDSCRIPT.md).
- Contract table: [reference/API_CLOUDSCRIPT.md](/docs/reference/API_CLOUDSCRIPT.md).
- Enums: [ExecuteResponseStatus](/docs/reference/ENUMS.md#executeresponsestatus).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/CloudScript*.cs`.

<!-- prettier-ignore -->
| DTO / field | Quick rule | DTO link |
| --- | --- | --- |
| `AddFunctionRequestData.script` | required; source phải đăng ký `handlers["functionName"]` | [CloudScriptModels.AddFunctionRequestData:1-11](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#addfunctionrequestdata) |
| `AddFunctionRequestData.canExecute` / `isLive` | public C# type là `bool`; nên set explicit | [CloudScriptModels.AddFunctionRequestData:1-11](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#addfunctionrequestdata) |
| `EditFunctionRequestData.version` | required; đúng `7` ký tự | [CloudScriptModels.EditFunctionRequestData:36-46](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#editfunctionrequestdata) |
| `EditFunctionRequestData.canExecute` / `isLive` | public C# type hiện là `string`; dùng `"true"` / `"false"` theo DTO, không gán bool literal | [CloudScriptModels.EditFunctionRequestData:36-46](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#editfunctionrequestdata) |
| `ExecuteFunctionRequestData.functionName` | required; độ dài `3..30`; phải khớp key trong `handlers[...]` | [CloudScriptModels.ExecuteFunctionRequestData:71-82](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#executefunctionrequestdata) |
| `ExecuteFunctionRequestData.functionParameters` | optional object; nên dùng primitive, array, hoặc `GNHashtable` JSON-serializable | [CloudScriptModels.ExecuteFunctionRequestData:71-82](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#executefunctionrequestdata) |
| `ExecuteFunctionRequestData.userId` | optional ở client, required ở server/admin | [client:71-82](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#executefunctionrequestdata) / [server:83-94](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#serverexecutefunctionrequestdata) / [admin:95-106](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#adminexecutefunctionrequestdata) |
| `ExecuteFunctionRequestData.version` | optional; nếu truyền thì đúng `7` ký tự | [CloudScriptModels.ExecuteFunctionRequestData:71-82](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#executefunctionrequestdata) |
| `GetFunctionRequestData.version` | required; đúng `7` ký tự | [CloudScriptModels.GetFunctionRequestData:107-115](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#getfunctionrequestdata) |
| `GetFunctionsRequestData` | object rỗng; không tự thêm `version`, `skip`, `limit`, `keyword` hoặc filter giả định | [CloudScriptModels.GetFunctionsRequestData:140-145](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#getfunctionsrequestdata) |

## 7. Publish Và Execute Flow

### Publish version mới

1. Build script source có đăng ký handler: `handlers["name"] = async (...) => { ... }`.
2. Gọi `addFunctionAsync` bằng namespace đúng trust boundary, thường là `.admin` hoặc `.server`.
3. Check `returnCode`, rồi `errorCode`, rồi `responseData.errorMessage`.
4. Lưu `responseData.version`.
5. Nếu muốn version đó live, gọi `editFunctionAsync` với đúng `version`, `canExecute`, `isLive`.

### Execute function

1. Chọn namespace theo caller thật.
2. Build request có `functionName`; truyền `version` nếu muốn pin version cụ thể.
3. Với `.server` / `.admin`, luôn truyền `userId`.
4. Check `returnCode`, rồi `errorCode`, rồi `responseData.errorMessage`.
5. Cast `responseData.status` sang `ExecuteResponseStatus` trước khi so sánh.
6. Chỉ đọc `functionResult` khi status là `ExecuteResponseStatus.Ok`.

Rule cứng:

- `functionName` là key handler trong script, không phải `version`.
- `editFunctionAsync` không đổi source; source mới luôn đi qua `addFunctionAsync`.
- `getFunctionsAsync().responseData.results[]` chỉ có `version` và `canExecute`; muốn biết live version thì đọc `liveLatestVersion`.
- `GetFunctionResponseData` không trả lại `version`; nếu cần giữ version, lấy từ request hoặc từ list trước đó.

## 8. Minimal Pattern

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new CloudScriptModels.ExecuteFunctionRequestData();
requestData.functionName = "pingCloudScript";
requestData.functionParameters = null;

var response = await GNNetwork.cloudScript.executeFunctionAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(response.responseData.errorMessage)) return;

var status = (ExecuteResponseStatus)response.responseData.status;
if (status != ExecuteResponseStatus.Ok) return;

var result = response.responseData.functionResult;
```

Nếu codebase đã có helper riêng như `hasReturnCodeError()` và muốn throw exception thay vì early-return, vẫn phải giữ thứ tự check 2 tầng: `returnCode` trước, `errorCode` sau.

## 9. Ví Dụ Khuyến Nghị

### Admin publish version mới rồi lấy `version`

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new CloudScriptModels.AdminAddFunctionRequestData();
requestData.script = @"
handlers[""pingCloudScript""] = async (args, context, log) => {
    return {
        ok: true,
        userId: context.userId,
        echo: args
    };
};
";
requestData.canExecute = true;
requestData.isLive = false;

var response = await GNNetwork.cloudScript.admin.addFunctionAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(response.responseData.errorMessage)) return;

var newVersion = response.responseData.version;
```

### Admin promote một version thành live

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new CloudScriptModels.AdminEditFunctionRequestData();
requestData.version = "ABC1234";
requestData.canExecute = "true";
requestData.isLive = "true";

var response = await GNNetwork.cloudScript.admin.editFunctionAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(response.responseData.errorMessage)) return;
```

### Server execute function cho một user cụ thể

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Common;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new CloudScriptModels.ServerExecuteFunctionRequestData();
requestData.userId = "USER000001";
requestData.functionName = "grantDailyReward";
requestData.version = "ABC1234";
requestData.functionParameters = GNHashtable.builder()
    .add("rewardId", "daily_01")
    .add("amount", 1)
    .build();

var response = await GNNetwork.cloudScript.server.executeFunctionAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(response.responseData.errorMessage)) return;

var status = (ExecuteResponseStatus)response.responseData.status;
if (status != ExecuteResponseStatus.Ok) return;

var result = response.responseData.functionResult;
var executionTimeInMs = response.responseData.executionTimeInMs;
```

### Đọc summary version rồi lấy source của version live

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var listRequestData = new CloudScriptModels.GetFunctionsRequestData();
var listResponse = await GNNetwork.cloudScript.getFunctionsAsync(listRequestData);

if (listResponse.returnCode != ReturnCode.Ok) return;
if (listResponse.errorCode != ErrorCode.Ok) return;

var liveVersion = listResponse.responseData.liveLatestVersion;

var getRequestData = new CloudScriptModels.GetFunctionRequestData();
getRequestData.version = liveVersion;

var getResponse = await GNNetwork.cloudScript.getFunctionAsync(getRequestData);

if (getResponse.returnCode != ReturnCode.Ok) return;
if (getResponse.errorCode != ErrorCode.Ok) return;

var script = getResponse.responseData.script;
```

## 10. Anti-Patterns

- Không dùng `editFunctionAsync` để đổi source code.
- Không tự thêm field `script` vào `EditFunctionRequestData`.
- Không gán bool literal cho `EditFunctionRequestData.canExecute` / `isLive` khi public C# type hiện là `string`.
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

- Đã có `Resources/GNServerSettings` chưa.
- Nếu đang viết source script, đã đọc [cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md) chưa.
- Đã chọn đúng namespace `cloudScript` / `cloudScript.server` / `cloudScript.admin` chưa.
- Nếu đang execute ở `server/admin`, đã truyền `userId` chưa.
- Nếu đang update source code, có đang dùng sai `editFunctionAsync` thay vì `addFunctionAsync` không.
- Nếu đang cần version live, có đang đọc `liveLatestVersion` chưa.
- Nếu đang cần source của một version, có đang dùng `getFunctionAsync` thay vì chỉ nhìn `getFunctionsAsync` không.
- Nếu đang đọc kết quả execute, có check `returnCode`, `errorCode`, `responseData.errorMessage`, và `ExecuteResponseStatus` chưa.
- Nếu đang truyền `functionParameters`, có giữ payload JSON-serializable không.
- Nếu flow là cấu hình event callback CloudScript, có đang dùng nhầm `CloudScriptApi` không.

## Quick Map

Dùng bảng này để đọc đúng dòng mà không load cả file. `offset = startLine - 1`, `limit = endLine - startLine + 1`.

<!-- prettier-ignore -->
| Section | Lines |
| --- | --- |
| §3 Chọn Namespace | 40-54 |
| §4 Chọn Method (bảng 5 method + decision rules) | 56-81 |
| §7 Publish Và Execute Flow | 136-160 |
| §8 Minimal Pattern | 162-185 |
| §9 Ví Dụ Khuyến Nghị | 187-291 |
