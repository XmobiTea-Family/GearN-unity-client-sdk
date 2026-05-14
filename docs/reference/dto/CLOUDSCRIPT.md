# DTO Reference: CloudScript

CloudScript function add/edit/execute + version/listing.

Related API reference: [API_CLOUDSCRIPT.md](/docs/reference/API_CLOUDSCRIPT.md).

Mỗi section bên dưới là 1 class DTO trong namespace `<Models>`. Field table cho biết: tên field, kiểu C# tương ứng, có `required` hay không (suy từ metadata `DataMember` / nullable / optional), doc comment, và ràng buộc length/range/default nếu có.

> **Cách dùng**: khi gọi `*Async()`, bạn truyền instance DTO (`new CloudScriptModels.<Method>RequestData()`) với các field required (+ optional nếu cần). Response class expose `responseData` là instance của class `*ResponseData` tương ứng. Không dùng object literal cast — xem [RULES § 8.1](/docs/RULES.md#81-build-request-dto-trong-code-copy-paste).

> **Naming pattern**: Mỗi method có 3 variant DTO — `XxxRequestData` (client), `ServerXxxRequestData` (server), `AdminXxxRequestData` (admin). Khi tìm DTO cho một route cụ thể, nhảy thẳng tới section `[Server|Admin]XxxRequestData` tương ứng — không cần đọc cả 3.

> **Pitfall**: Muốn đổi source code của function → dùng `addFunctionAsync` tạo version mới, KHÔNG dùng `editFunctionAsync` (chỉ đổi flag/metadata). Xem [RULES § 10 #9](/docs/RULES.md#10-anti-patterns--pitfalls).

## Danh sách

- **CloudScriptModels** (from `Runtime/Entity/Models/CloudScriptModels.cs`)
    - [AddFunctionRequestData](#addfunctionrequestdata)
    - [ServerAddFunctionRequestData](#serveraddfunctionrequestdata)
    - [AdminAddFunctionRequestData](#adminaddfunctionrequestdata)
    - [EditFunctionRequestData](#editfunctionrequestdata)
    - [ServerEditFunctionRequestData](#servereditfunctionrequestdata)
    - [AdminEditFunctionRequestData](#admineditfunctionrequestdata)
    - [ExecuteFunctionRequestData](#executefunctionrequestdata)
    - [ServerExecuteFunctionRequestData](#serverexecutefunctionrequestdata)
    - [AdminExecuteFunctionRequestData](#adminexecutefunctionrequestdata)
    - [GetFunctionRequestData](#getfunctionrequestdata)
    - [ServerGetFunctionRequestData](#servergetfunctionrequestdata)
    - [AdminGetFunctionRequestData](#admingetfunctionrequestdata)
    - [GetFunctionsRequestData](#getfunctionsrequestdata)
    - [ServerGetFunctionsRequestData](#servergetfunctionsrequestdata)
    - [AdminGetFunctionsRequestData](#admingetfunctionsrequestdata)
    - [AddFunctionResponseData](#addfunctionresponsedata)
    - [EditFunctionResponseData](#editfunctionresponsedata)
    - [ExecuteFunctionResponseData](#executefunctionresponsedata)
    - [GetFunctionResponseData](#getfunctionresponsedata)
    - [FunctionResponseData](#functionresponsedata)
    - [GetFunctionsResponseData](#getfunctionsresponsedata)
- **CloudScriptRequestModels** (from `Runtime/Entity/Models/CloudScriptRequestModels.cs`)
    - [AddFunctionOperationRequest](#addfunctionoperationrequest)
    - [ServerAddFunctionOperationRequest](#serveraddfunctionoperationrequest)
    - [AdminAddFunctionOperationRequest](#adminaddfunctionoperationrequest)
    - [EditFunctionOperationRequest](#editfunctionoperationrequest)
    - [ServerEditFunctionOperationRequest](#servereditfunctionoperationrequest)
    - [AdminEditFunctionOperationRequest](#admineditfunctionoperationrequest)
    - [ExecuteFunctionOperationRequest](#executefunctionoperationrequest)
    - [ServerExecuteFunctionOperationRequest](#serverexecutefunctionoperationrequest)
    - [AdminExecuteFunctionOperationRequest](#adminexecutefunctionoperationrequest)
    - [GetFunctionOperationRequest](#getfunctionoperationrequest)
    - [ServerGetFunctionOperationRequest](#servergetfunctionoperationrequest)
    - [AdminGetFunctionOperationRequest](#admingetfunctionoperationrequest)
    - [GetFunctionsOperationRequest](#getfunctionsoperationrequest)
    - [ServerGetFunctionsOperationRequest](#servergetfunctionsoperationrequest)
    - [AdminGetFunctionsOperationRequest](#admingetfunctionsoperationrequest)
- **CloudScriptResponseModels** (from `Runtime/Entity/Models/CloudScriptResponseModels.cs`)
    - [AddFunctionOperationResponse](#addfunctionoperationresponse)
    - [EditFunctionOperationResponse](#editfunctionoperationresponse)
    - [ExecuteFunctionOperationResponse](#executefunctionoperationresponse)
    - [GetFunctionOperationResponse](#getfunctionoperationresponse)
    - [GetFunctionsOperationResponse](#getfunctionsoperationresponse)

---

## Namespace `CloudScriptModels`

### AddFunctionRequestData

Creates a new CloudScript version from raw script source.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `script` | `string` | yes | Submitted CloudScript source. It must register at least one `handlers["functionName"] = ...` handler. |
| `canExecute` | `boolean` | yes | Whether this version may be executed. |
| `isLive` | `boolean` | yes | Whether this version is promoted as live. |

### ServerAddFunctionRequestData

Extends: `AddFunctionRequestData`

Defines the request payload for ServerAddFunction.

Inherits `script`, `canExecute`, and `isLive` from `AddFunctionRequestData`.

### AdminAddFunctionRequestData

Extends: `ServerAddFunctionRequestData`

Defines the request payload for AdminAddFunction.

Inherits `script`, `canExecute`, and `isLive` from `AddFunctionRequestData`.

### EditFunctionRequestData

Updates execution flags for an existing CloudScript version without changing its source code.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `version` | `string` | yes | CloudScript version to edit. — _minLength=7, maxLength=7_ |
| `canExecute` | `boolean` | yes | Whether this version may be executed. |
| `isLive` | `boolean` | yes | Whether this version is promoted as live. |

### ServerEditFunctionRequestData

Extends: `EditFunctionRequestData`

Defines the request payload for ServerEditFunction.

Inherits `version`, `canExecute`, and `isLive` from `EditFunctionRequestData`.

### AdminEditFunctionRequestData

Extends: `ServerEditFunctionRequestData`

Defines the request payload for AdminEditFunction.

Inherits `version`, `canExecute`, and `isLive` from `EditFunctionRequestData`.

### ExecuteFunctionRequestData

Executes one function from the selected CloudScript version.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | no | Optional self-target shortcut on the client route; trusted routes require it through derived classes. — _minLength=10, maxLength=10_ |
| `functionName` | `string` | yes | Function name inside the script version, not the version identifier itself. — _minLength=3, maxLength=30_ |
| `functionParameters` | `any` | no | Arbitrary payload forwarded to the CloudScript function. |
| `version` | `string` | no | Optional version override; when omitted, backend execution rules decide which live version is used. — _minLength=7, maxLength=7_ |

### ServerExecuteFunctionRequestData

Extends: `ExecuteFunctionRequestData`

Defines the request payload for ServerExecuteFunction.

Same fields as `ExecuteFunctionRequestData`, but `userId` is required on the server route.

### AdminExecuteFunctionRequestData

Extends: `ServerExecuteFunctionRequestData`

Defines the request payload for AdminExecuteFunction.

Same fields as `ServerExecuteFunctionRequestData`; `userId` is required on the admin route.

### GetFunctionRequestData

Defines the request payload for GetFunction.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `version` | `string` | yes | CloudScript version to inspect. — _minLength=7, maxLength=7_ |

### ServerGetFunctionRequestData

Extends: `GetFunctionRequestData`

Defines the request payload for ServerGetFunction.

Inherits `version` from `GetFunctionRequestData`.

### AdminGetFunctionRequestData

Extends: `ServerGetFunctionRequestData`

Defines the request payload for AdminGetFunction.

Inherits `version` from `GetFunctionRequestData`.

### GetFunctionsRequestData

Defines the request payload for GetFunctions.

_Không có field public (payload rỗng)._

### ServerGetFunctionsRequestData

Extends: `GetFunctionsRequestData`

Defines the request payload for ServerGetFunctions.

_Không có field public (payload rỗng)._

### AdminGetFunctionsRequestData

Extends: `ServerGetFunctionsRequestData`

Defines the request payload for AdminGetFunctions.

_Không có field public (payload rỗng)._

### AddFunctionResponseData

Returns the created version plus backend validation feedback.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `version` | `string` | yes | Version identifier assigned by the backend for the newly created CloudScript (format: 7 characters). |
| `errorMessage` | `string` | yes | Error message when the script failed validation; empty string on success. |

### EditFunctionResponseData

Returns backend validation feedback for an edit workflow.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `errorMessage` | `string` | yes | Error message when the edit operation failed; empty string on success. |

### ExecuteFunctionResponseData

Returns runtime telemetry and function output for one execution.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `status` | `int` | yes | Raw execution status code returned by the backend. Cast to public enum `ExecuteResponseStatus` before comparing, for example `(ExecuteResponseStatus)exec.status == ExecuteResponseStatus.Ok`. |
| `executionTimeInMs` | `number` | yes | Execution duration in milliseconds. |
| `memoryUsedInBytes` | `number` | yes | Memory consumed during the function execution in bytes. |
| `functionResult` | `any` | yes | Arbitrary function return value as returned by the handler. |
| `errorMessage` | `string` | yes | Error message when the function threw an exception; empty string on success. |
| `functionLogs` | `Array<string>` | yes | Ordered execution logs captured during the function run. — _elementCls=String_ |

### GetFunctionResponseData

Returns one full CloudScript version snapshot.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `script` | `string` | yes | Raw CloudScript source code for this version. |
| `canExecute` | `boolean` | yes | Whether this version is permitted to execute. |
| `isLive` | `boolean` | yes | Whether this version is promoted as the live version. |
| `tsCreate` | `number` | yes | Creation timestamp of this CloudScript version. |

### FunctionResponseData

Describes one lightweight function-version summary.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `version` | `string` | yes | Version identifier of this CloudScript version (7-character string). |
| `canExecute` | `boolean` | yes | Whether this version is permitted to execute. |

### GetFunctionsResponseData

Returns the available function-version list plus latest/live pointers.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `Array<FunctionResponseData>` | yes | List of all CloudScript version summaries for this game. — _elementCls=FunctionResponseData_ |
| `latestVersion` | `string` | yes | Version identifier of the most recently added CloudScript version. |
| `liveLatestVersion` | `string` | yes | Version identifier of the most recently promoted live version. |

## Namespace `CloudScriptRequestModels`

### AddFunctionOperationRequest

Extends: `CustomOperationRequestAbstract<CloudScriptModels.AddFunctionRequestData>`

Maps the AddFunction operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerAddFunctionOperationRequest

Extends: `AddFunctionOperationRequest`

Maps the ServerAddFunction operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminAddFunctionOperationRequest

Extends: `AddFunctionOperationRequest`

Maps the AdminAddFunction operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### EditFunctionOperationRequest

Extends: `CustomOperationRequestAbstract<CloudScriptModels.EditFunctionRequestData>`

Maps the EditFunction operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerEditFunctionOperationRequest

Extends: `EditFunctionOperationRequest`

Maps the ServerEditFunction operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminEditFunctionOperationRequest

Extends: `EditFunctionOperationRequest`

Maps the AdminEditFunction operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ExecuteFunctionOperationRequest

Extends: `CustomOperationRequestAbstract<CloudScriptModels.ExecuteFunctionRequestData>`

Maps the ExecuteFunction operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerExecuteFunctionOperationRequest

Extends: `ExecuteFunctionOperationRequest`

Maps the ServerExecuteFunction operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminExecuteFunctionOperationRequest

Extends: `ExecuteFunctionOperationRequest`

Maps the AdminExecuteFunction operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetFunctionOperationRequest

Extends: `CustomOperationRequestAbstract<CloudScriptModels.GetFunctionRequestData>`

Maps the GetFunction operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetFunctionOperationRequest

Extends: `GetFunctionOperationRequest`

Maps the ServerGetFunction operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetFunctionOperationRequest

Extends: `GetFunctionOperationRequest`

Maps the AdminGetFunction operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetFunctionsOperationRequest

Extends: `CustomOperationRequestAbstract<CloudScriptModels.GetFunctionsRequestData>`

Maps the GetFunctions operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetFunctionsOperationRequest

Extends: `GetFunctionsOperationRequest`

Maps the ServerGetFunctions operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetFunctionsOperationRequest

Extends: `GetFunctionsOperationRequest`

Maps the AdminGetFunctions operation to a typed request wrapper.

_Không có field public (payload rỗng)._

## Namespace `CloudScriptResponseModels`

### AddFunctionOperationResponse

Extends: `CustomOperationResponseAbstract<CloudScriptModels.AddFunctionResponseData>`

Maps the AddFunction operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### EditFunctionOperationResponse

Extends: `CustomOperationResponseAbstract<CloudScriptModels.EditFunctionResponseData>`

Maps the EditFunction operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### ExecuteFunctionOperationResponse

Extends: `CustomOperationResponseAbstract<CloudScriptModels.ExecuteFunctionResponseData>`

Maps the ExecuteFunction operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetFunctionOperationResponse

Extends: `CustomOperationResponseAbstract<CloudScriptModels.GetFunctionResponseData>`

Maps the GetFunction operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetFunctionsOperationResponse

Extends: `CustomOperationResponseAbstract<CloudScriptModels.GetFunctionsResponseData>`

Maps the GetFunctions operation to a typed response wrapper.

_Không có field public (payload rỗng)._
