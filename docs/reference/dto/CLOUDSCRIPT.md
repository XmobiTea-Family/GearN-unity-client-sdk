# DTO Reference: CloudScript

CloudScript function add/edit/execute + version/listing.

Related guide: [CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md). Related API reference: [API_CLOUDSCRIPT.md](/docs/reference/API_CLOUDSCRIPT.md).

Mỗi section bên dưới là 1 class DTO trong namespace `<Models>`. Field table cho biết: tên field, kiểu C# tương ứng, có `required` hay không (suy từ metadata `DataMember` / nullable / optional), doc comment, và ràng buộc length/range/default nếu có.

> **Cách dùng**: khi gọi `*Async()`, bạn truyền instance DTO (`new CloudScriptModels.<Method>RequestData()`) với các field required (+ optional nếu cần). Response class expose `responseData` là instance của class `*ResponseData` tương ứng. Không dùng object literal cast — xem [RULES § 8.1](/docs/RULES.md#81-build-request-dto-trong-code-copy-paste).

> **Naming pattern**: Mỗi method có 3 variant DTO — `XxxRequestData` (client), `ServerXxxRequestData` (server), `AdminXxxRequestData` (admin). Khi tìm DTO cho một route cụ thể, nhảy thẳng tới section `[Server|Admin]XxxRequestData` tương ứng — không cần đọc cả 3.

> **Pitfall**: Muốn đổi source code của function → dùng `addFunctionAsync` tạo version mới, KHÔNG dùng `editFunctionAsync` (chỉ đổi flag/metadata). Xem [RULES § 10 #9](/docs/RULES.md#10-anti-patterns--pitfalls).

> Nếu cần sử dụng `GNArray` hoặc `GNHashtable` đọc [GNDATA.md](/docs/reference/GNDATA.md)

> **Operation base**: Nếu class `*OperationRequest` extends `CustomOperationRequestAbstract<TRequestData>` hoặc class `*OperationResponse` extends `CustomOperationResponseAbstract<TResponseData>`, xem [OPERATION_BASES.md](/docs/reference/OPERATION_BASES.md) để hiểu `requestData`, `build()`, `setupOperationResponse()`, và `responseData`.

## Danh sách

- **CloudScriptModels** (from `Runtime/Entity/Models/CloudScriptModels.cs`)
  - [CloudScriptModels.AddFunctionRequestData:1-11](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#addfunctionrequestdata)
  - [CloudScriptModels.ServerAddFunctionRequestData:1-23](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#serveraddfunctionrequestdata)
  - [CloudScriptModels.AdminAddFunctionRequestData:1-35](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#adminaddfunctionrequestdata)
  - [CloudScriptModels.EditFunctionRequestData:36-46](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#editfunctionrequestdata)
  - [CloudScriptModels.ServerEditFunctionRequestData:36-58](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#servereditfunctionrequestdata)
  - [CloudScriptModels.AdminEditFunctionRequestData:36-70](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#admineditfunctionrequestdata)
  - [CloudScriptModels.ExecuteFunctionRequestData:71-82](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#executefunctionrequestdata)
  - [CloudScriptModels.ServerExecuteFunctionRequestData:71-94](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#serverexecutefunctionrequestdata)
  - [CloudScriptModels.AdminExecuteFunctionRequestData:71-106](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#adminexecutefunctionrequestdata)
  - [CloudScriptModels.GetFunctionRequestData:107-115](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#getfunctionrequestdata)
  - [CloudScriptModels.ServerGetFunctionRequestData:107-127](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#servergetfunctionrequestdata)
  - [CloudScriptModels.AdminGetFunctionRequestData:107-139](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#admingetfunctionrequestdata)
  - [CloudScriptModels.GetFunctionsRequestData:140-145](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#getfunctionsrequestdata)
  - [CloudScriptModels.ServerGetFunctionsRequestData:140-157](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#servergetfunctionsrequestdata)
  - [CloudScriptModels.AdminGetFunctionsRequestData:140-169](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#admingetfunctionsrequestdata)
  - [CloudScriptModels.AddFunctionResponseData:170-179](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#addfunctionresponsedata)
  - [CloudScriptModels.EditFunctionResponseData:180-188](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#editfunctionresponsedata)
  - [CloudScriptModels.ExecuteFunctionResponseData:189-201](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#executefunctionresponsedata)
  - [CloudScriptModels.GetFunctionResponseData:202-214](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#getfunctionresponsedata)
  - [CloudScriptModels.FunctionResponseData:215-224](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#functionresponsedata)
  - [CloudScriptModels.GetFunctionsResponseData:225-238](/docs/reference/dto/cloudscript/CLOUDSCRIPT_MODELS.md#getfunctionsresponsedata)
- **CloudScriptRequestModels** (from `Runtime/Entity/Models/CloudScriptRequestModels.cs`)
  - [CloudScriptRequestModels.AddFunctionOperationRequest:1-12](/docs/reference/dto/cloudscript/CLOUDSCRIPT_REQUEST_MODELS.md#addfunctionoperationrequest)
  - [CloudScriptRequestModels.ServerAddFunctionOperationRequest:1-24](/docs/reference/dto/cloudscript/CLOUDSCRIPT_REQUEST_MODELS.md#serveraddfunctionoperationrequest)
  - [CloudScriptRequestModels.AdminAddFunctionOperationRequest:1-36](/docs/reference/dto/cloudscript/CLOUDSCRIPT_REQUEST_MODELS.md#adminaddfunctionoperationrequest)
  - [CloudScriptRequestModels.EditFunctionOperationRequest:37-48](/docs/reference/dto/cloudscript/CLOUDSCRIPT_REQUEST_MODELS.md#editfunctionoperationrequest)
  - [CloudScriptRequestModels.ServerEditFunctionOperationRequest:37-60](/docs/reference/dto/cloudscript/CLOUDSCRIPT_REQUEST_MODELS.md#servereditfunctionoperationrequest)
  - [CloudScriptRequestModels.AdminEditFunctionOperationRequest:37-72](/docs/reference/dto/cloudscript/CLOUDSCRIPT_REQUEST_MODELS.md#admineditfunctionoperationrequest)
  - [CloudScriptRequestModels.ExecuteFunctionOperationRequest:73-84](/docs/reference/dto/cloudscript/CLOUDSCRIPT_REQUEST_MODELS.md#executefunctionoperationrequest)
  - [CloudScriptRequestModels.ServerExecuteFunctionOperationRequest:73-96](/docs/reference/dto/cloudscript/CLOUDSCRIPT_REQUEST_MODELS.md#serverexecutefunctionoperationrequest)
  - [CloudScriptRequestModels.AdminExecuteFunctionOperationRequest:73-108](/docs/reference/dto/cloudscript/CLOUDSCRIPT_REQUEST_MODELS.md#adminexecutefunctionoperationrequest)
  - [CloudScriptRequestModels.GetFunctionOperationRequest:109-120](/docs/reference/dto/cloudscript/CLOUDSCRIPT_REQUEST_MODELS.md#getfunctionoperationrequest)
  - [CloudScriptRequestModels.ServerGetFunctionOperationRequest:109-132](/docs/reference/dto/cloudscript/CLOUDSCRIPT_REQUEST_MODELS.md#servergetfunctionoperationrequest)
  - [CloudScriptRequestModels.AdminGetFunctionOperationRequest:109-144](/docs/reference/dto/cloudscript/CLOUDSCRIPT_REQUEST_MODELS.md#admingetfunctionoperationrequest)
  - [CloudScriptRequestModels.GetFunctionsOperationRequest:145-156](/docs/reference/dto/cloudscript/CLOUDSCRIPT_REQUEST_MODELS.md#getfunctionsoperationrequest)
  - [CloudScriptRequestModels.ServerGetFunctionsOperationRequest:145-168](/docs/reference/dto/cloudscript/CLOUDSCRIPT_REQUEST_MODELS.md#servergetfunctionsoperationrequest)
  - [CloudScriptRequestModels.AdminGetFunctionsOperationRequest:145-179](/docs/reference/dto/cloudscript/CLOUDSCRIPT_REQUEST_MODELS.md#admingetfunctionsoperationrequest)
- **CloudScriptResponseModels** (from `Runtime/Entity/Models/CloudScriptResponseModels.cs`)
  - [CloudScriptResponseModels.AddFunctionOperationResponse:1-12](/docs/reference/dto/cloudscript/CLOUDSCRIPT_RESPONSE_MODELS.md#addfunctionoperationresponse)
  - [CloudScriptResponseModels.EditFunctionOperationResponse:13-24](/docs/reference/dto/cloudscript/CLOUDSCRIPT_RESPONSE_MODELS.md#editfunctionoperationresponse)
  - [CloudScriptResponseModels.ExecuteFunctionOperationResponse:25-36](/docs/reference/dto/cloudscript/CLOUDSCRIPT_RESPONSE_MODELS.md#executefunctionoperationresponse)
  - [CloudScriptResponseModels.GetFunctionOperationResponse:37-48](/docs/reference/dto/cloudscript/CLOUDSCRIPT_RESPONSE_MODELS.md#getfunctionoperationresponse)
  - [CloudScriptResponseModels.GetFunctionsOperationResponse:49-59](/docs/reference/dto/cloudscript/CLOUDSCRIPT_RESPONSE_MODELS.md#getfunctionsoperationresponse)

---
