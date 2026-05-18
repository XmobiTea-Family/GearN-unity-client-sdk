### AddFunctionRequestData

Creates a new CloudScript version from raw script source.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `script` | `string` | yes | Submitted CloudScript source. It must register at least one `handlers["functionName"] = ...` handler. |
| `canExecute` | `bool` | yes | Whether this version may be executed. |
| `isLive` | `bool` | yes | Whether this version is promoted as live. |

### ServerAddFunctionRequestData

Extends: `AddFunctionRequestData`

Defines the request payload for ServerAddFunction.

Inherits `script`, `canExecute`, and `isLive` from `AddFunctionRequestData`.

Reference links:

- [CloudScriptModels.AddFunctionRequestData:1-11](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#addfunctionrequestdata)

### AdminAddFunctionRequestData

Extends: `ServerAddFunctionRequestData`

Defines the request payload for AdminAddFunction.

Inherits `script`, `canExecute`, and `isLive` from `AddFunctionRequestData`.

Reference links:

- [CloudScriptModels.ServerAddFunctionRequestData:1-23](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#serveraddfunctionrequestdata)

### EditFunctionRequestData

Updates execution flags for an existing CloudScript version without changing its source code.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `version` | `string` | yes | CloudScript version to edit. — _minLength=7, maxLength=7_ |
| `canExecute` | `string` | yes | Whether this version may be executed. |
| `isLive` | `string` | yes | Whether this version is promoted as live. |

### ServerEditFunctionRequestData

Extends: `EditFunctionRequestData`

Defines the request payload for ServerEditFunction.

Inherits `version`, `canExecute`, and `isLive` from `EditFunctionRequestData`.

Reference links:

- [CloudScriptModels.EditFunctionRequestData:36-46](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#editfunctionrequestdata)

### AdminEditFunctionRequestData

Extends: `ServerEditFunctionRequestData`

Defines the request payload for AdminEditFunction.

Inherits `version`, `canExecute`, and `isLive` from `EditFunctionRequestData`.

Reference links:

- [CloudScriptModels.ServerEditFunctionRequestData:36-58](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#servereditfunctionrequestdata)

### ExecuteFunctionRequestData

Executes one function from the selected CloudScript version.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | Optional self-target shortcut on the client route; trusted routes require it through derived classes. — _minLength=10, maxLength=10_ |
| `functionName` | `string` | yes | Function name inside the script version, not the version identifier itself. — _minLength=3, maxLength=30_ |
| `functionParameters` | `object` | yes (nullable) | Arbitrary payload forwarded to the CloudScript function. The field is part of the request contract, but its value may be `null` when the handler does not need arguments. |
| `version` | `string?` | no | Optional version override; when omitted, backend execution rules decide which live version is used. — _minLength=7, maxLength=7_ |

### ServerExecuteFunctionRequestData

Extends: `ExecuteFunctionRequestData`

Defines the request payload for ServerExecuteFunction.

Same fields as `ExecuteFunctionRequestData`, but `userId` is required on the server route.

Reference links:

- [CloudScriptModels.ExecuteFunctionRequestData:71-82](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#executefunctionrequestdata)

### AdminExecuteFunctionRequestData

Extends: `ServerExecuteFunctionRequestData`

Defines the request payload for AdminExecuteFunction.

Same fields as `ServerExecuteFunctionRequestData`; `userId` is required on the admin route.

Reference links:

- [CloudScriptModels.ServerExecuteFunctionRequestData:71-94](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#serverexecutefunctionrequestdata)

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

Reference links:

- [CloudScriptModels.GetFunctionRequestData:107-115](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#getfunctionrequestdata)

### AdminGetFunctionRequestData

Extends: `ServerGetFunctionRequestData`

Defines the request payload for AdminGetFunction.

Inherits `version` from `GetFunctionRequestData`.

Reference links:

- [CloudScriptModels.ServerGetFunctionRequestData:107-127](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#servergetfunctionrequestdata)

### GetFunctionsRequestData

Defines the request payload for GetFunctions.

_Không có field public (payload rỗng)._

### ServerGetFunctionsRequestData

Extends: `GetFunctionsRequestData`

Defines the request payload for ServerGetFunctions.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetFunctionsRequestData`._

Reference links:

- [CloudScriptModels.GetFunctionsRequestData:140-145](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#getfunctionsrequestdata)

### AdminGetFunctionsRequestData

Extends: `ServerGetFunctionsRequestData`

Defines the request payload for AdminGetFunctions.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetFunctionsRequestData`._

Reference links:

- [CloudScriptModels.ServerGetFunctionsRequestData:140-157](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#servergetfunctionsrequestdata)

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
| `executionTimeInMs` | `float` | yes | Execution duration in milliseconds. |
| `memoryUsedInBytes` | `float` | yes | Memory consumed during the function execution in bytes. |
| `functionResult` | `object` | yes | Arbitrary function return value as returned by the handler. |
| `errorMessage` | `string` | yes | Error message when the function threw an exception; empty string on success. |

### GetFunctionResponseData

Returns one full CloudScript version snapshot.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `script` | `string` | yes | Raw CloudScript source code for this version. |
| `canExecute` | `bool` | yes | Whether this version is permitted to execute. |
| `isLive` | `bool` | yes | Whether this version is promoted as the live version. |
| `tsCreate` | `long` | yes | Creation timestamp of this CloudScript version. |
| `functionLogs` | `List<string>` | yes | Ordered execution logs captured for this CloudScript version. — _elementCls=String_ |

### FunctionResponseData

Describes one lightweight function-version summary.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `version` | `string` | yes | Version identifier of this CloudScript version (7-character string). |
| `canExecute` | `bool` | yes | Whether this version is permitted to execute. |

### GetFunctionsResponseData

Returns the available function-version list plus latest/live pointers.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<FunctionResponseData>` | yes | List of all CloudScript version summaries for this game. — _elementCls=FunctionResponseData_ |
| `latestVersion` | `string` | yes | Version identifier of the most recently added CloudScript version. |
| `liveLatestVersion` | `string` | yes | Version identifier of the most recently promoted live version. |

Reference links:

- [CloudScriptModels.FunctionResponseData:215-224](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#functionresponsedata)
