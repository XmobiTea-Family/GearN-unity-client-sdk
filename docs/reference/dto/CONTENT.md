# DTO Reference: Content

Content data key-value, file upload info, download token.

Related guide: [CONTENT.md](/docs/guides/CONTENT.md). Related API reference: [API_CONTENT.md](/docs/reference/API_CONTENT.md).

Mỗi section bên dưới là 1 class DTO trong namespace `<Models>`. Field table cho biết: tên field, kiểu C# tương ứng, có `required` hay không (suy từ metadata `DataMember` / nullable / optional), doc comment, và ràng buộc length/range/default nếu có.

> **Cách dùng**: khi gọi `*Async()`, bạn truyền instance DTO (`new ContentModels.<Method>RequestData()`) với các field required (+ optional nếu cần). Response class expose `responseData` là instance của class `*ResponseData` tương ứng. Không dùng object literal cast — xem [RULES § 8.1](/docs/RULES.md#81-build-request-dto-trong-code-copy-paste).

> **Naming pattern**: Mỗi method có 3 variant DTO — `XxxRequestData` (client), `ServerXxxRequestData` (server), `AdminXxxRequestData` (admin). Khi tìm DTO cho một route cụ thể, nhảy thẳng tới section `[Server|Admin]XxxRequestData` tương ứng — không cần đọc cả 3. Lưu ý: `Content` không có ownership rõ ràng nên không áp self/other-self trên route client.

> Nếu cần sử dụng `GNArray` hoặc `GNHashtable` đọc [GNDATA.md](/docs/reference/GNDATA.md)

> **Operation base**: Nếu class `*OperationRequest` extends `CustomOperationRequestAbstract<TRequestData>` hoặc class `*OperationResponse` extends `CustomOperationResponseAbstract<TResponseData>`, xem [OPERATION_BASES.md](/docs/reference/OPERATION_BASES.md) để hiểu `requestData`, `build()`, `setupOperationResponse()`, và `responseData`.

## Danh sách

- **ContentModels** (from `Runtime/Entity/Models/ContentModels.cs`)
  - [ContentModels.ContentDataParam:1-10](/docs/reference/dto/content/CONTENT_MODELS.md#contentdataparam)
  - [ContentModels.CreateNewFileUploadInfoRequestData:11-19](/docs/reference/dto/content/CONTENT_MODELS.md#createnewfileuploadinforequestdata)
  - [ContentModels.ServerCreateNewFileUploadInfoRequestData:11-31](/docs/reference/dto/content/CONTENT_MODELS.md#servercreatenewfileuploadinforequestdata)
  - [ContentModels.AdminCreateNewFileUploadInfoRequestData:11-43](/docs/reference/dto/content/CONTENT_MODELS.md#admincreatenewfileuploadinforequestdata)
  - [ContentModels.GetContentDataRequestData:44-53](/docs/reference/dto/content/CONTENT_MODELS.md#getcontentdatarequestdata)
  - [ContentModels.ServerGetContentDataRequestData:44-65](/docs/reference/dto/content/CONTENT_MODELS.md#servergetcontentdatarequestdata)
  - [ContentModels.AdminGetContentDataRequestData:44-77](/docs/reference/dto/content/CONTENT_MODELS.md#admingetcontentdatarequestdata)
  - [ContentModels.GetFileUploadInfoListRequestData:78-87](/docs/reference/dto/content/CONTENT_MODELS.md#getfileuploadinfolistrequestdata)
  - [ContentModels.ServerGetFileUploadInfoListRequestData:78-99](/docs/reference/dto/content/CONTENT_MODELS.md#servergetfileuploadinfolistrequestdata)
  - [ContentModels.AdminGetFileUploadInfoListRequestData:78-111](/docs/reference/dto/content/CONTENT_MODELS.md#admingetfileuploadinfolistrequestdata)
  - [ContentModels.GetFileUploadInfoRequestData:112-120](/docs/reference/dto/content/CONTENT_MODELS.md#getfileuploadinforequestdata)
  - [ContentModels.ServerGetFileUploadInfoRequestData:112-132](/docs/reference/dto/content/CONTENT_MODELS.md#servergetfileuploadinforequestdata)
  - [ContentModels.AdminGetFileUploadInfoRequestData:112-144](/docs/reference/dto/content/CONTENT_MODELS.md#admingetfileuploadinforequestdata)
  - [ContentModels.RemoveFileUploadInfoRequestData:145-154](/docs/reference/dto/content/CONTENT_MODELS.md#removefileuploadinforequestdata)
  - [ContentModels.ServerRemoveFileUploadInfoRequestData:145-166](/docs/reference/dto/content/CONTENT_MODELS.md#serverremovefileuploadinforequestdata)
  - [ContentModels.AdminRemoveFileUploadInfoRequestData:145-178](/docs/reference/dto/content/CONTENT_MODELS.md#adminremovefileuploadinforequestdata)
  - [ContentModels.RequestDownloadFileUploadInfoRequestData:179-187](/docs/reference/dto/content/CONTENT_MODELS.md#requestdownloadfileuploadinforequestdata)
  - [ContentModels.ServerRequestDownloadFileUploadInfoRequestData:179-199](/docs/reference/dto/content/CONTENT_MODELS.md#serverrequestdownloadfileuploadinforequestdata)
  - [ContentModels.AdminRequestDownloadFileUploadInfoRequestData:179-211](/docs/reference/dto/content/CONTENT_MODELS.md#adminrequestdownloadfileuploadinforequestdata)
  - [ContentModels.SetContentDataRequestData:212-225](/docs/reference/dto/content/CONTENT_MODELS.md#setcontentdatarequestdata)
  - [ContentModels.ServerSetContentDataRequestData:212-237](/docs/reference/dto/content/CONTENT_MODELS.md#serversetcontentdatarequestdata)
  - [ContentModels.AdminSetContentDataRequestData:212-249](/docs/reference/dto/content/CONTENT_MODELS.md#adminsetcontentdatarequestdata)
  - [ContentModels.FileIdUploadResponseData:250-258](/docs/reference/dto/content/CONTENT_MODELS.md#fileiduploadresponsedata)
  - [ContentModels.GetContentDataResponseData:259-271](/docs/reference/dto/content/CONTENT_MODELS.md#getcontentdataresponsedata)
  - [ContentModels.GetFileUploadInfoListResponseData:272-284](/docs/reference/dto/content/CONTENT_MODELS.md#getfileuploadinfolistresponsedata)
  - [ContentModels.FileUploadItem:285-295](/docs/reference/dto/content/CONTENT_MODELS.md#fileuploaditem)
  - [ContentModels.GetFileUploadInfoResponseData:250-318](/docs/reference/dto/content/CONTENT_MODELS.md#getfileuploadinforesponsedata)
  - [ContentModels.RequestDownloadFileUploadInfoResponseData:319-327](/docs/reference/dto/content/CONTENT_MODELS.md#requestdownloadfileuploadinforesponsedata)
  - [ContentModels.EmptyResponseData:328-332](/docs/reference/dto/content/CONTENT_MODELS.md#emptyresponsedata)
- **ContentRequestModels** (from `Runtime/Entity/Models/ContentRequestModels.cs`)
  - [ContentRequestModels.CreateNewFileUploadInfoOperationRequest:1-12](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#createnewfileuploadinfooperationrequest)
  - [ContentRequestModels.ServerCreateNewFileUploadInfoOperationRequest:1-24](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#servercreatenewfileuploadinfooperationrequest)
  - [ContentRequestModels.AdminCreateNewFileUploadInfoOperationRequest:1-36](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#admincreatenewfileuploadinfooperationrequest)
  - [ContentRequestModels.GetContentDataOperationRequest:37-48](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#getcontentdataoperationrequest)
  - [ContentRequestModels.ServerGetContentDataOperationRequest:37-60](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#servergetcontentdataoperationrequest)
  - [ContentRequestModels.AdminGetContentDataOperationRequest:37-72](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#admingetcontentdataoperationrequest)
  - [ContentRequestModels.GetFileUploadInfoListOperationRequest:73-84](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#getfileuploadinfolistoperationrequest)
  - [ContentRequestModels.ServerGetFileUploadInfoListOperationRequest:73-96](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#servergetfileuploadinfolistoperationrequest)
  - [ContentRequestModels.AdminGetFileUploadInfoListOperationRequest:73-108](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#admingetfileuploadinfolistoperationrequest)
  - [ContentRequestModels.GetFileUploadInfoOperationRequest:109-120](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#getfileuploadinfooperationrequest)
  - [ContentRequestModels.ServerGetFileUploadInfoOperationRequest:109-132](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#servergetfileuploadinfooperationrequest)
  - [ContentRequestModels.AdminGetFileUploadInfoOperationRequest:109-144](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#admingetfileuploadinfooperationrequest)
  - [ContentRequestModels.RemoveFileUploadInfoOperationRequest:145-156](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#removefileuploadinfooperationrequest)
  - [ContentRequestModels.ServerRemoveFileUploadInfoOperationRequest:145-168](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#serverremovefileuploadinfooperationrequest)
  - [ContentRequestModels.AdminRemoveFileUploadInfoOperationRequest:145-180](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#adminremovefileuploadinfooperationrequest)
  - [ContentRequestModels.RequestDownloadFileUploadInfoOperationRequest:181-192](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#requestdownloadfileuploadinfooperationrequest)
  - [ContentRequestModels.ServerRequestDownloadFileUploadInfoOperationRequest:181-204](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#serverrequestdownloadfileuploadinfooperationrequest)
  - [ContentRequestModels.AdminRequestDownloadFileUploadInfoOperationRequest:181-216](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#adminrequestdownloadfileuploadinfooperationrequest)
  - [ContentRequestModels.SetContentDataOperationRequest:217-228](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#setcontentdataoperationrequest)
  - [ContentRequestModels.ServerSetContentDataOperationRequest:217-240](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#serversetcontentdataoperationrequest)
  - [ContentRequestModels.AdminSetContentDataOperationRequest:217-251](/docs/reference/dto/content/CONTENT_REQUEST_MODELS.md#adminsetcontentdataoperationrequest)
- **ContentResponseModels** (from `Runtime/Entity/Models/ContentResponseModels.cs`)
  - [ContentResponseModels.CreateNewFileUploadInfoOperationResponse:1-12](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#createnewfileuploadinfooperationresponse)
  - [ContentResponseModels.GetContentDataOperationResponse:13-24](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#getcontentdataoperationresponse)
  - [ContentResponseModels.GetFileUploadInfoListOperationResponse:25-36](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#getfileuploadinfolistoperationresponse)
  - [ContentResponseModels.GetFileUploadInfoOperationResponse:37-48](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#getfileuploadinfooperationresponse)
  - [ContentResponseModels.RemoveFileUploadInfoOperationResponse:49-60](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#removefileuploadinfooperationresponse)
  - [ContentResponseModels.RequestDownloadFileUploadInfoOperationResponse:61-72](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#requestdownloadfileuploadinfooperationresponse)
  - [ContentResponseModels.SetContentDataOperationResponse:73-83](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#setcontentdataoperationresponse)

---
