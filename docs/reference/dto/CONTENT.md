# DTO Reference: Content

Content data key-value, file upload info, download token.

Related API reference: [API_CONTENT.md](/docs/reference/API_CONTENT.md).

Mỗi section bên dưới là 1 class DTO trong namespace `<Models>`. Field table cho biết: tên field, kiểu C# tương ứng, có `required` hay không (suy từ metadata `DataMember` / nullable / optional), doc comment, và ràng buộc length/range/default nếu có.

> **Cách dùng**: khi gọi `*Async()`, bạn truyền instance DTO (`new ContentModels.<Method>RequestData()`) với các field required (+ optional nếu cần). Response class expose `responseData` là instance của class `*ResponseData` tương ứng. Không dùng object literal cast — xem [RULES § 8.1](/docs/RULES.md#81-build-request-dto-trong-code-copy-paste).

> **Naming pattern**: Mỗi method có 3 variant DTO — `XxxRequestData` (client), `ServerXxxRequestData` (server), `AdminXxxRequestData` (admin). Khi tìm DTO cho một route cụ thể, nhảy thẳng tới section `[Server|Admin]XxxRequestData` tương ứng — không cần đọc cả 3. Lưu ý: `Content` không có ownership rõ ràng nên không áp self/other-self trên route client.

> Nếu cần sử dụng `GNArray` hoặc `GNHashtable` đọc [GNDATA.md](/docs/reference/GNDATA.md)

## Danh sách

- **ContentModels** (from `Runtime/Entity/Models/ContentModels.cs`)
    - [ContentDataParam](#contentdataparam)
    - [CreateNewFileUploadInfoRequestData](#createnewfileuploadinforequestdata)
    - [ServerCreateNewFileUploadInfoRequestData](#servercreatenewfileuploadinforequestdata)
    - [AdminCreateNewFileUploadInfoRequestData](#admincreatenewfileuploadinforequestdata)
    - [GetContentDataRequestData](#getcontentdatarequestdata)
    - [ServerGetContentDataRequestData](#servergetcontentdatarequestdata)
    - [AdminGetContentDataRequestData](#admingetcontentdatarequestdata)
    - [GetFileUploadInfoListRequestData](#getfileuploadinfolistrequestdata)
    - [ServerGetFileUploadInfoListRequestData](#servergetfileuploadinfolistrequestdata)
    - [AdminGetFileUploadInfoListRequestData](#admingetfileuploadinfolistrequestdata)
    - [GetFileUploadInfoRequestData](#getfileuploadinforequestdata)
    - [ServerGetFileUploadInfoRequestData](#servergetfileuploadinforequestdata)
    - [AdminGetFileUploadInfoRequestData](#admingetfileuploadinforequestdata)
    - [RemoveFileUploadInfoRequestData](#removefileuploadinforequestdata)
    - [ServerRemoveFileUploadInfoRequestData](#serverremovefileuploadinforequestdata)
    - [AdminRemoveFileUploadInfoRequestData](#adminremovefileuploadinforequestdata)
    - [RequestDownloadFileUploadInfoRequestData](#requestdownloadfileuploadinforequestdata)
    - [ServerRequestDownloadFileUploadInfoRequestData](#serverrequestdownloadfileuploadinforequestdata)
    - [AdminRequestDownloadFileUploadInfoRequestData](#adminrequestdownloadfileuploadinforequestdata)
    - [SetContentDataRequestData](#setcontentdatarequestdata)
    - [ServerSetContentDataRequestData](#serversetcontentdatarequestdata)
    - [AdminSetContentDataRequestData](#adminsetcontentdatarequestdata)
    - [FileIdUploadResponseData](#fileiduploadresponsedata)
    - [GetContentDataResponseData](#getcontentdataresponsedata)
    - [GetFileUploadInfoListResponseData](#getfileuploadinfolistresponsedata)
    - [FileUploadItem](#fileuploaditem)
    - [GetFileUploadInfoResponseData](#getfileuploadinforesponsedata)
    - [RequestDownloadFileUploadInfoResponseData](#requestdownloadfileuploadinforesponsedata)
    - [EmptyResponseData](#emptyresponsedata)
- **ContentRequestModels** (from `Runtime/Entity/Models/ContentRequestModels.cs`)
    - [CreateNewFileUploadInfoOperationRequest](#createnewfileuploadinfooperationrequest)
    - [ServerCreateNewFileUploadInfoOperationRequest](#servercreatenewfileuploadinfooperationrequest)
    - [AdminCreateNewFileUploadInfoOperationRequest](#admincreatenewfileuploadinfooperationrequest)
    - [GetContentDataOperationRequest](#getcontentdataoperationrequest)
    - [ServerGetContentDataOperationRequest](#servergetcontentdataoperationrequest)
    - [AdminGetContentDataOperationRequest](#admingetcontentdataoperationrequest)
    - [GetFileUploadInfoListOperationRequest](#getfileuploadinfolistoperationrequest)
    - [ServerGetFileUploadInfoListOperationRequest](#servergetfileuploadinfolistoperationrequest)
    - [AdminGetFileUploadInfoListOperationRequest](#admingetfileuploadinfolistoperationrequest)
    - [GetFileUploadInfoOperationRequest](#getfileuploadinfooperationrequest)
    - [ServerGetFileUploadInfoOperationRequest](#servergetfileuploadinfooperationrequest)
    - [AdminGetFileUploadInfoOperationRequest](#admingetfileuploadinfooperationrequest)
    - [RemoveFileUploadInfoOperationRequest](#removefileuploadinfooperationrequest)
    - [ServerRemoveFileUploadInfoOperationRequest](#serverremovefileuploadinfooperationrequest)
    - [AdminRemoveFileUploadInfoOperationRequest](#adminremovefileuploadinfooperationrequest)
    - [RequestDownloadFileUploadInfoOperationRequest](#requestdownloadfileuploadinfooperationrequest)
    - [ServerRequestDownloadFileUploadInfoOperationRequest](#serverrequestdownloadfileuploadinfooperationrequest)
    - [AdminRequestDownloadFileUploadInfoOperationRequest](#adminrequestdownloadfileuploadinfooperationrequest)
    - [SetContentDataOperationRequest](#setcontentdataoperationrequest)
    - [ServerSetContentDataOperationRequest](#serversetcontentdataoperationrequest)
    - [AdminSetContentDataOperationRequest](#adminsetcontentdataoperationrequest)
- **ContentResponseModels** (from `Runtime/Entity/Models/ContentResponseModels.cs`)
    - [CreateNewFileUploadInfoOperationResponse](#createnewfileuploadinfooperationresponse)
    - [GetContentDataOperationResponse](#getcontentdataoperationresponse)
    - [GetFileUploadInfoListOperationResponse](#getfileuploadinfolistoperationresponse)
    - [GetFileUploadInfoOperationResponse](#getfileuploadinfooperationresponse)
    - [RemoveFileUploadInfoOperationResponse](#removefileuploadinfooperationresponse)
    - [RequestDownloadFileUploadInfoOperationResponse](#requestdownloadfileuploadinfooperationresponse)
    - [SetContentDataOperationResponse](#setcontentdataoperationresponse)

---

## Namespace `ContentModels`

### ContentDataParam

Defines the reusable parameter block ContentDataParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | Content data key identifier. — _minLength=2, maxLength=32_ |
| `data` | `GNHashtable` | yes | Arbitrary data blob associated with `key`; use `GNHashtable` to encode the content payload. |

### CreateNewFileUploadInfoRequestData

Allocates a new upload slot before the binary payload is uploaded through the separate upload helper.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `fileName` | `string` | yes | _minLength=5, maxLength=50_ |

### ServerCreateNewFileUploadInfoRequestData

Extends: `CreateNewFileUploadInfoRequestData`

Defines the request payload for ServerCreateNewFileUploadInfo.

_Không có field public (payload rỗng)._

### AdminCreateNewFileUploadInfoRequestData

Extends: `ServerCreateNewFileUploadInfoRequestData`

Defines the request payload for AdminCreateNewFileUploadInfo.

_Không có field public (payload rỗng)._

### GetContentDataRequestData

Reads content configuration blobs, optionally filtered by key list and label.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keys` | `List<string>?` | no | _elementCls=String_ |
| `label` | `string?` | no | _minLength=2, maxLength=32, default=""_ |

### ServerGetContentDataRequestData

Extends: `GetContentDataRequestData`

Defines the request payload for ServerGetContentData.

_Không có field public (payload rỗng)._

### AdminGetContentDataRequestData

Extends: `ServerGetContentDataRequestData`

Defines the request payload for AdminGetContentData.

_Không có field public (payload rỗng)._

### GetFileUploadInfoListRequestData

Defines the request payload for GetFileUploadInfoList.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

### ServerGetFileUploadInfoListRequestData

Extends: `GetFileUploadInfoListRequestData`

Defines the request payload for ServerGetFileUploadInfoList.

_Không có field public (payload rỗng)._

### AdminGetFileUploadInfoListRequestData

Extends: `ServerGetFileUploadInfoListRequestData`

Defines the request payload for AdminGetFileUploadInfoList.

_Không có field public (payload rỗng)._

### GetFileUploadInfoRequestData

Defines the request payload for GetFileUploadInfo.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `fileId` | `string` | yes | _minLength=15, maxLength=15_ |

### ServerGetFileUploadInfoRequestData

Extends: `GetFileUploadInfoRequestData`

Defines the request payload for ServerGetFileUploadInfo.

_Không có field public (payload rỗng)._

### AdminGetFileUploadInfoRequestData

Extends: `ServerGetFileUploadInfoRequestData`

Defines the request payload for AdminGetFileUploadInfo.

_Không có field public (payload rỗng)._

### RemoveFileUploadInfoRequestData

Defines the request payload for RemoveFileUploadInfo.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `fileId` | `string` | yes | _minLength=15, maxLength=15_ |
| `reason` | `string?` | no | _default=""_ |

### ServerRemoveFileUploadInfoRequestData

Extends: `RemoveFileUploadInfoRequestData`

Defines the request payload for ServerRemoveFileUploadInfo.

_Không có field public (payload rỗng)._

### AdminRemoveFileUploadInfoRequestData

Extends: `ServerRemoveFileUploadInfoRequestData`

Defines the request payload for AdminRemoveFileUploadInfo.

_Không có field public (payload rỗng)._

### RequestDownloadFileUploadInfoRequestData

Requests a short-lived download token for an existing uploaded file.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `fileId` | `string` | yes | _minLength=15, maxLength=15_ |

### ServerRequestDownloadFileUploadInfoRequestData

Extends: `RequestDownloadFileUploadInfoRequestData`

Defines the request payload for ServerRequestDownloadFileUploadInfo.

_Không có field public (payload rỗng)._

### AdminRequestDownloadFileUploadInfoRequestData

Extends: `ServerRequestDownloadFileUploadInfoRequestData`

Defines the request payload for AdminRequestDownloadFileUploadInfo.

_Không có field public (payload rỗng)._

### SetContentDataRequestData

Defines the request payload for SetContentData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `configs` | `List<ContentDataParam>` | yes | _elementCls=ContentDataParam_ |
| `label` | `string?` | no | _minLength=2, maxLength=32_ |

### ServerSetContentDataRequestData

Extends: `SetContentDataRequestData`

Defines the request payload for ServerSetContentData.

_Không có field public (payload rỗng)._

### AdminSetContentDataRequestData

Extends: `ServerSetContentDataRequestData`

Defines the request payload for AdminSetContentData.

_Không có field public (payload rỗng)._

### FileIdUploadResponseData

Returns the backend-generated file ID for follow-up upload or download workflows.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `fileId` | `string` | yes | Backend-assigned file identifier used in follow-up get/download/remove calls. |

### GetContentDataResponseData

Defines the response payload for GetContentData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `configs` | `List<ContentDataParam>` | yes | List of content data entries matching the request filters. — _elementCls=ContentDataParam_ |

### GetFileUploadInfoListResponseData

Defines the response payload for GetFileUploadInfoList.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<FileIdUploadResponseData>` | yes | Paginated list of file IDs matching the query. — _elementCls=FileIdUploadResponseData_ |

### FileUploadItem

Describes upload metadata stored for one file entry.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `mimeType` | `string` | yes | MIME type of the uploaded file (e.g. `image/png`, `application/json`). |
| `size` | `long` | yes | File size in bytes. |
| `folderFileName` | `string` | yes | Backend-stored path and file name for the uploaded binary. |

### GetFileUploadInfoResponseData

Extends: `FileIdUploadResponseData`

Returns metadata for one uploaded file entry.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `fileName` | `string` | yes | Original file name submitted when the upload slot was created. |
| `tsCreate` | `long` | yes | Creation timestamp of the upload slot. |
| `removeStatus` | `GenericModels.RemoveStatusItem` | yes | Soft-remove metadata; present when the file has been marked for removal. |
| `tsUploadExpire` | `long?` | no | Upload-expiration timestamp for unfinished uploads when present. |
| `fileUpload` | `FileUploadItem?` | no | Detailed file metadata; present only after the binary has been successfully uploaded. |

### RequestDownloadFileUploadInfoResponseData

Returns the download token consumed by the SDK download helper.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `downloadToken` | `string` | yes | Short-lived token passed to the SDK download helper to fetch the file binary. |

### EmptyResponseData

Defines an intentionally empty response payload.

_Không có field public (payload rỗng)._

## Namespace `ContentRequestModels`

### CreateNewFileUploadInfoOperationRequest

Extends: `CustomOperationRequestAbstract<ContentModels.CreateNewFileUploadInfoRequestData>`

Maps the CreateNewFileUploadInfo operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerCreateNewFileUploadInfoOperationRequest

Extends: `CreateNewFileUploadInfoOperationRequest`

Maps the ServerCreateNewFileUploadInfo operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminCreateNewFileUploadInfoOperationRequest

Extends: `CreateNewFileUploadInfoOperationRequest`

Maps the AdminCreateNewFileUploadInfo operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetContentDataOperationRequest

Extends: `CustomOperationRequestAbstract<ContentModels.GetContentDataRequestData>`

Maps the GetContentData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetContentDataOperationRequest

Extends: `GetContentDataOperationRequest`

Maps the ServerGetContentData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetContentDataOperationRequest

Extends: `GetContentDataOperationRequest`

Maps the AdminGetContentData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetFileUploadInfoListOperationRequest

Extends: `CustomOperationRequestAbstract<ContentModels.GetFileUploadInfoListRequestData>`

Maps the GetFileUploadInfoList operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetFileUploadInfoListOperationRequest

Extends: `GetFileUploadInfoListOperationRequest`

Maps the ServerGetFileUploadInfoList operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetFileUploadInfoListOperationRequest

Extends: `GetFileUploadInfoListOperationRequest`

Maps the AdminGetFileUploadInfoList operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetFileUploadInfoOperationRequest

Extends: `CustomOperationRequestAbstract<ContentModels.GetFileUploadInfoRequestData>`

Maps the GetFileUploadInfo operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetFileUploadInfoOperationRequest

Extends: `GetFileUploadInfoOperationRequest`

Maps the ServerGetFileUploadInfo operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetFileUploadInfoOperationRequest

Extends: `GetFileUploadInfoOperationRequest`

Maps the AdminGetFileUploadInfo operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### RemoveFileUploadInfoOperationRequest

Extends: `CustomOperationRequestAbstract<ContentModels.RemoveFileUploadInfoRequestData>`

Maps the RemoveFileUploadInfo operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerRemoveFileUploadInfoOperationRequest

Extends: `RemoveFileUploadInfoOperationRequest`

Maps the ServerRemoveFileUploadInfo operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminRemoveFileUploadInfoOperationRequest

Extends: `RemoveFileUploadInfoOperationRequest`

Maps the AdminRemoveFileUploadInfo operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### RequestDownloadFileUploadInfoOperationRequest

Extends: `CustomOperationRequestAbstract<ContentModels.RequestDownloadFileUploadInfoRequestData>`

Maps the RequestDownloadFileUploadInfo operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerRequestDownloadFileUploadInfoOperationRequest

Extends: `RequestDownloadFileUploadInfoOperationRequest`

Maps the ServerRequestDownloadFileUploadInfo operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminRequestDownloadFileUploadInfoOperationRequest

Extends: `RequestDownloadFileUploadInfoOperationRequest`

Maps the AdminRequestDownloadFileUploadInfo operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetContentDataOperationRequest

Extends: `CustomOperationRequestAbstract<ContentModels.SetContentDataRequestData>`

Maps the SetContentData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetContentDataOperationRequest

Extends: `SetContentDataOperationRequest`

Maps the ServerSetContentData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetContentDataOperationRequest

Extends: `SetContentDataOperationRequest`

Maps the AdminSetContentData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

## Namespace `ContentResponseModels`

### CreateNewFileUploadInfoOperationResponse

Extends: `CustomOperationResponseAbstract<ContentModels.FileIdUploadResponseData>`

Maps the CreateNewFileUploadInfo operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetContentDataOperationResponse

Extends: `CustomOperationResponseAbstract<ContentModels.GetContentDataResponseData>`

Maps the GetContentData operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetFileUploadInfoListOperationResponse

Extends: `CustomOperationResponseAbstract<ContentModels.GetFileUploadInfoListResponseData>`

Maps the GetFileUploadInfoList operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetFileUploadInfoOperationResponse

Extends: `CustomOperationResponseAbstract<ContentModels.GetFileUploadInfoResponseData>`

Maps the GetFileUploadInfo operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RemoveFileUploadInfoOperationResponse

Extends: `CustomOperationResponseAbstract<ContentModels.EmptyResponseData>`

Maps the RemoveFileUploadInfo operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RequestDownloadFileUploadInfoOperationResponse

Extends: `CustomOperationResponseAbstract<ContentModels.RequestDownloadFileUploadInfoResponseData>`

Maps the RequestDownloadFileUploadInfo operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetContentDataOperationResponse

Extends: `CustomOperationResponseAbstract<ContentModels.EmptyResponseData>`

Maps the SetContentData operation to a typed response wrapper.

_Không có field public (payload rỗng)._
