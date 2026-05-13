# API Reference: CloudScriptApi

CloudScript function add/edit/execute + version/listing.

- Domain guide: [guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md)
- DTO shapes: [dto/CLOUDSCRIPT.md](/docs/reference/dto/CLOUDSCRIPT.md)
- Enums: [ENUMS.md](/docs/reference/ENUMS.md)
- Error handling: [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md)
- Permission rules: [PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md)

## Namespaces

- `GNNetwork.cloudScript` — `RequestRole.Client`
- `GNNetwork.cloudScript.server` — `RequestRole.Server`
- `GNNetwork.cloudScript.admin` — `RequestRole.Admin`

## Convention

Mỗi method dưới đây có 2 form — callback và `*Async()` Task. Ưu tiên `*Async()`.

```text
// Callback
GNNetwork.cloudScript.<method>(requestData, onResponse?, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);

// Async
var res = await GNNetwork.cloudScript.<method>Async(requestData, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);
```

Param chung:

<!-- prettier-ignore -->
| Param | Type | Optional | Notes |
| --- | --- | --- | --- |
| `requestData` | domain-specific (xem bảng dưới) | no | Payload chính |
| `onResponse` | `Action1<TResponse>` | yes | Chỉ có ở callback form |
| `overrideAuthToken` | `string` | yes | Override `authToken` cache cho request này |
| `overrideSecretKey` | `string` | yes | Override secret key mặc định của route |
| `customTags` | `GNHashtable` | yes | Tags gắn vào request, backend có thể log/route |
| `timeout` | `int` | yes | Timeout giây; default = `OperationRequest.defaultTimeOut` |

Response class expose field: `returnCode`, `errorCode`, `invalidMembers`, `debugMessage`, `responseData`. Xem [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).

## Client methods (`GNNetwork.cloudScript.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules | Permission Rules khi truyền `userId` khác với `masterPlayer` đang authenticated |
| --- | --- | --- | --- | --- | --- |
| `addFunction` | `CloudScriptModels.AddFunctionRequestData` | `addFunctionAsync(...)` | `CloudScriptResponseModels.AddFunctionOperationResponse` | `cloudScript.addFunction.otherSelfEnable` | |
| `editFunction` | `CloudScriptModels.EditFunctionRequestData` | `editFunctionAsync(...)` | `CloudScriptResponseModels.EditFunctionOperationResponse` | `cloudScript.editFunction.otherSelfEnable` | |
| `executeFunction` | `CloudScriptModels.ExecuteFunctionRequestData` | `executeFunctionAsync(...)` | `CloudScriptResponseModels.ExecuteFunctionOperationResponse` | `cloudScript.executeFunction.selfEnable` | `cloudScript.executeFunction.otherSelfEnable` |
| `getFunction` | `CloudScriptModels.GetFunctionRequestData` | `getFunctionAsync(...)` | `CloudScriptResponseModels.GetFunctionOperationResponse` | `cloudScript.getFunction.otherSelfEnable` | |
| `getFunctions` | `CloudScriptModels.GetFunctionsRequestData` | `getFunctionsAsync(...)` | `CloudScriptResponseModels.GetFunctionsOperationResponse` | `cloudScript.getFunctions.otherSelfEnable` | |

## Server methods (`GNNetwork.cloudScript.server.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules |
| --- | --- | --- | --- | --- |
| `addFunction` | `CloudScriptModels.ServerAddFunctionRequestData` | `addFunctionAsync(...)` | `CloudScriptResponseModels.AddFunctionOperationResponse` | `cloudScript.addFunction.serverSelfEnable` |
| `editFunction` | `CloudScriptModels.ServerEditFunctionRequestData` | `editFunctionAsync(...)` | `CloudScriptResponseModels.EditFunctionOperationResponse` | `cloudScript.editFunction.serverSelfEnable` |
| `executeFunction` | `CloudScriptModels.ServerExecuteFunctionRequestData` | `executeFunctionAsync(...)` | `CloudScriptResponseModels.ExecuteFunctionOperationResponse` | `cloudScript.executeFunction.serverSelfEnable` |
| `getFunction` | `CloudScriptModels.ServerGetFunctionRequestData` | `getFunctionAsync(...)` | `CloudScriptResponseModels.GetFunctionOperationResponse` | `cloudScript.getFunction.serverSelfEnable` |
| `getFunctions` | `CloudScriptModels.ServerGetFunctionsRequestData` | `getFunctionsAsync(...)` | `CloudScriptResponseModels.GetFunctionsOperationResponse` | `cloudScript.getFunctions.serverSelfEnable` |

## Admin methods (`GNNetwork.cloudScript.admin.*`)

<!-- prettier-ignore -->
| Method | Request DTO | Async form | Response class | Default Permission Rules |
| --- | --- | --- | --- | --- |
| `addFunction` | `CloudScriptModels.AdminAddFunctionRequestData` | `addFunctionAsync(...)` | `CloudScriptResponseModels.AddFunctionOperationResponse` | `cloudScript.addFunction.adminSelfEnable` |
| `editFunction` | `CloudScriptModels.AdminEditFunctionRequestData` | `editFunctionAsync(...)` | `CloudScriptResponseModels.EditFunctionOperationResponse` | `cloudScript.editFunction.adminSelfEnable` |
| `executeFunction` | `CloudScriptModels.AdminExecuteFunctionRequestData` | `executeFunctionAsync(...)` | `CloudScriptResponseModels.ExecuteFunctionOperationResponse` | `cloudScript.executeFunction.adminSelfEnable` |
| `getFunction` | `CloudScriptModels.AdminGetFunctionRequestData` | `getFunctionAsync(...)` | `CloudScriptResponseModels.GetFunctionOperationResponse` | `cloudScript.getFunction.adminSelfEnable` |
| `getFunctions` | `CloudScriptModels.AdminGetFunctionsRequestData` | `getFunctionsAsync(...)` | `CloudScriptResponseModels.GetFunctionsOperationResponse` | `cloudScript.getFunctions.adminSelfEnable` |

## Ví dụ tối thiểu

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

// requestData: CloudScriptModels.AddFunctionRequestData đã build theo dto/CLOUDSCRIPT.md
var res = await GNNetwork.cloudScript.addFunctionAsync(requestData);
if (res.returnCode != ReturnCode.Ok) return;
if (res.errorCode != ErrorCode.Ok) return;
// res.responseData có typed payload
```
