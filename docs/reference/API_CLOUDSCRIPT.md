# API Reference: CloudScriptApi

Bảng contract cho `CloudScriptApi`. Bắt đầu từ [guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md) để chọn namespace, method, và publish/execute flow trước khi đọc các row này.

- Domain guide: [guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md)
- DTO shapes: [dto/CLOUDSCRIPT.md](/docs/reference/dto/CLOUDSCRIPT.md)
- Error handling: [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md)
- Permission rules: [PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md)

## Client methods (`GNNetwork.cloudScript.*`)

<!-- prettier-ignore -->
| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp | Permission Rules khi truyền `userId` khác với `gamePlayer` đang authenticated |
| --- | --- | --- | --- | --- | --- |
| `addFunction` | [CloudScriptModels.AddFunctionRequestData:1-11](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#addfunctionrequestdata) | [CloudScriptModels.AddFunctionResponseData:170-179](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#addfunctionresponsedata) | `cloudScript.addFunction.otherSelfEnable` | `Ok`, `GameNotFound`, `ExecuteError` | |
| `editFunction` | [CloudScriptModels.EditFunctionRequestData:36-46](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#editfunctionrequestdata) | [CloudScriptModels.EditFunctionResponseData:180-188](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#editfunctionresponsedata) | `cloudScript.editFunction.otherSelfEnable` | `Ok`, `GameNotFound`, `ExecuteError` | |
| `executeFunction` | [CloudScriptModels.ExecuteFunctionRequestData:71-82](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#executefunctionrequestdata) | [CloudScriptModels.ExecuteFunctionResponseData:189-201](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#executefunctionresponsedata) | `cloudScript.executeFunction.selfEnable` | `Ok`, `GameNotFound`, `ExecuteError` | `cloudScript.executeFunction.otherSelfEnable` |
| `getFunction` | [CloudScriptModels.GetFunctionRequestData:107-115](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#getfunctionrequestdata) | [CloudScriptModels.GetFunctionResponseData:202-214](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#getfunctionresponsedata) | `cloudScript.getFunction.otherSelfEnable` | `Ok`, `GameNotFound`, `VersionInvalid` | |
| `getFunctions` | [CloudScriptModels.GetFunctionsRequestData:140-145](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#getfunctionsrequestdata) | [CloudScriptModels.GetFunctionsResponseData:225-238](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#getfunctionsresponsedata) | `cloudScript.getFunctions.otherSelfEnable` | `Ok`, `GameNotFound` | |

## Server methods (`GNNetwork.cloudScript.server.*`)

<!-- prettier-ignore -->
| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |
| --- | --- | --- | --- | --- |
| `addFunction` | [CloudScriptModels.ServerAddFunctionRequestData:12-23](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#serveraddfunctionrequestdata) | [CloudScriptModels.AddFunctionResponseData:170-179](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#addfunctionresponsedata) | `cloudScript.addFunction.serverSelfEnable` | `Ok`, `GameNotFound`, `ExecuteError` |
| `editFunction` | [CloudScriptModels.ServerEditFunctionRequestData:47-58](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#servereditfunctionrequestdata) | [CloudScriptModels.EditFunctionResponseData:180-188](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#editfunctionresponsedata) | `cloudScript.editFunction.serverSelfEnable` | `Ok`, `GameNotFound`, `ExecuteError` |
| `executeFunction` | [CloudScriptModels.ServerExecuteFunctionRequestData:83-94](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#serverexecutefunctionrequestdata) | [CloudScriptModels.ExecuteFunctionResponseData:189-201](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#executefunctionresponsedata) | `cloudScript.executeFunction.serverSelfEnable` | `Ok`, `GameNotFound`, `ExecuteError` |
| `getFunction` | [CloudScriptModels.ServerGetFunctionRequestData:116-127](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#servergetfunctionrequestdata) | [CloudScriptModels.GetFunctionResponseData:202-214](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#getfunctionresponsedata) | `cloudScript.getFunction.serverSelfEnable` | `Ok`, `GameNotFound`, `VersionInvalid` |
| `getFunctions` | [CloudScriptModels.ServerGetFunctionsRequestData:146-157](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#servergetfunctionsrequestdata) | [CloudScriptModels.GetFunctionsResponseData:225-238](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#getfunctionsresponsedata) | `cloudScript.getFunctions.serverSelfEnable` | `Ok`, `GameNotFound` |

## Admin methods (`GNNetwork.cloudScript.admin.*`)

<!-- prettier-ignore -->
| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |
| --- | --- | --- | --- | --- |
| `addFunction` | [CloudScriptModels.AdminAddFunctionRequestData:24-35](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#adminaddfunctionrequestdata) | [CloudScriptModels.AddFunctionResponseData:170-179](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#addfunctionresponsedata) | `cloudScript.addFunction.adminSelfEnable` | `Ok`, `GameNotFound`, `ExecuteError` |
| `editFunction` | [CloudScriptModels.AdminEditFunctionRequestData:59-70](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#admineditfunctionrequestdata) | [CloudScriptModels.EditFunctionResponseData:180-188](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#editfunctionresponsedata) | `cloudScript.editFunction.adminSelfEnable` | `Ok`, `GameNotFound`, `ExecuteError` |
| `executeFunction` | [CloudScriptModels.AdminExecuteFunctionRequestData:95-106](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#adminexecutefunctionrequestdata) | [CloudScriptModels.ExecuteFunctionResponseData:189-201](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#executefunctionresponsedata) | `cloudScript.executeFunction.adminSelfEnable` | `Ok`, `GameNotFound`, `ExecuteError` |
| `getFunction` | [CloudScriptModels.AdminGetFunctionRequestData:128-139](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#admingetfunctionrequestdata) | [CloudScriptModels.GetFunctionResponseData:202-214](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#getfunctionresponsedata) | `cloudScript.getFunction.adminSelfEnable` | `Ok`, `GameNotFound`, `VersionInvalid` |
| `getFunctions` | [CloudScriptModels.AdminGetFunctionsRequestData:158-168](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#admingetfunctionsrequestdata) | [CloudScriptModels.GetFunctionsResponseData:225-238](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#getfunctionsresponsedata) | `cloudScript.getFunctions.adminSelfEnable` | `Ok`, `GameNotFound` |
