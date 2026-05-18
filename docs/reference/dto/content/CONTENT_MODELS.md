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

_Không khai báo field mới; kế thừa toàn bộ field từ `CreateNewFileUploadInfoRequestData`._

Reference links:

- [ContentModels.CreateNewFileUploadInfoRequestData:11-19](/docs/reference/dto/content/CONTENT_MODELS.md#createnewfileuploadinforequestdata)

### AdminCreateNewFileUploadInfoRequestData

Extends: `ServerCreateNewFileUploadInfoRequestData`

Defines the request payload for AdminCreateNewFileUploadInfo.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerCreateNewFileUploadInfoRequestData`._

Reference links:

- [ContentModels.ServerCreateNewFileUploadInfoRequestData:11-31](/docs/reference/dto/content/CONTENT_MODELS.md#servercreatenewfileuploadinforequestdata)

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

_Không khai báo field mới; kế thừa toàn bộ field từ `GetContentDataRequestData`._

Reference links:

- [ContentModels.GetContentDataRequestData:44-53](/docs/reference/dto/content/CONTENT_MODELS.md#getcontentdatarequestdata)

### AdminGetContentDataRequestData

Extends: `ServerGetContentDataRequestData`

Defines the request payload for AdminGetContentData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetContentDataRequestData`._

Reference links:

- [ContentModels.ServerGetContentDataRequestData:44-65](/docs/reference/dto/content/CONTENT_MODELS.md#servergetcontentdatarequestdata)

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

_Không khai báo field mới; kế thừa toàn bộ field từ `GetFileUploadInfoListRequestData`._

Reference links:

- [ContentModels.GetFileUploadInfoListRequestData:78-87](/docs/reference/dto/content/CONTENT_MODELS.md#getfileuploadinfolistrequestdata)

### AdminGetFileUploadInfoListRequestData

Extends: `ServerGetFileUploadInfoListRequestData`

Defines the request payload for AdminGetFileUploadInfoList.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetFileUploadInfoListRequestData`._

Reference links:

- [ContentModels.ServerGetFileUploadInfoListRequestData:78-99](/docs/reference/dto/content/CONTENT_MODELS.md#servergetfileuploadinfolistrequestdata)

### GetFileUploadInfoRequestData

Defines the request payload for GetFileUploadInfo.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `fileId` | `string` | yes | _minLength=15, maxLength=15_ |

### ServerGetFileUploadInfoRequestData

Extends: `GetFileUploadInfoRequestData`

Defines the request payload for ServerGetFileUploadInfo.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetFileUploadInfoRequestData`._

Reference links:

- [ContentModels.GetFileUploadInfoRequestData:112-120](/docs/reference/dto/content/CONTENT_MODELS.md#getfileuploadinforequestdata)

### AdminGetFileUploadInfoRequestData

Extends: `ServerGetFileUploadInfoRequestData`

Defines the request payload for AdminGetFileUploadInfo.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetFileUploadInfoRequestData`._

Reference links:

- [ContentModels.ServerGetFileUploadInfoRequestData:112-132](/docs/reference/dto/content/CONTENT_MODELS.md#servergetfileuploadinforequestdata)

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

_Không khai báo field mới; kế thừa toàn bộ field từ `RemoveFileUploadInfoRequestData`._

Reference links:

- [ContentModels.RemoveFileUploadInfoRequestData:145-154](/docs/reference/dto/content/CONTENT_MODELS.md#removefileuploadinforequestdata)

### AdminRemoveFileUploadInfoRequestData

Extends: `ServerRemoveFileUploadInfoRequestData`

Defines the request payload for AdminRemoveFileUploadInfo.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRemoveFileUploadInfoRequestData`._

Reference links:

- [ContentModels.ServerRemoveFileUploadInfoRequestData:145-166](/docs/reference/dto/content/CONTENT_MODELS.md#serverremovefileuploadinforequestdata)

### RequestDownloadFileUploadInfoRequestData

Requests a short-lived download token for an existing uploaded file.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `fileId` | `string` | yes | _minLength=15, maxLength=15_ |

### ServerRequestDownloadFileUploadInfoRequestData

Extends: `RequestDownloadFileUploadInfoRequestData`

Defines the request payload for ServerRequestDownloadFileUploadInfo.

_Không khai báo field mới; kế thừa toàn bộ field từ `RequestDownloadFileUploadInfoRequestData`._

Reference links:

- [ContentModels.RequestDownloadFileUploadInfoRequestData:179-187](/docs/reference/dto/content/CONTENT_MODELS.md#requestdownloadfileuploadinforequestdata)

### AdminRequestDownloadFileUploadInfoRequestData

Extends: `ServerRequestDownloadFileUploadInfoRequestData`

Defines the request payload for AdminRequestDownloadFileUploadInfo.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerRequestDownloadFileUploadInfoRequestData`._

Reference links:

- [ContentModels.ServerRequestDownloadFileUploadInfoRequestData:179-199](/docs/reference/dto/content/CONTENT_MODELS.md#serverrequestdownloadfileuploadinforequestdata)

### SetContentDataRequestData

Defines the request payload for SetContentData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `configs` | `List<ContentDataParam>` | yes | _elementCls=ContentDataParam_ |
| `label` | `string?` | no | _minLength=2, maxLength=32_ |

Reference links:

- [ContentModels.ContentDataParam:1-10](/docs/reference/dto/content/CONTENT_MODELS.md#contentdataparam)

### ServerSetContentDataRequestData

Extends: `SetContentDataRequestData`

Defines the request payload for ServerSetContentData.

_Không khai báo field mới; kế thừa toàn bộ field từ `SetContentDataRequestData`._

Reference links:

- [ContentModels.SetContentDataRequestData:212-225](/docs/reference/dto/content/CONTENT_MODELS.md#setcontentdatarequestdata)

### AdminSetContentDataRequestData

Extends: `ServerSetContentDataRequestData`

Defines the request payload for AdminSetContentData.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerSetContentDataRequestData`._

Reference links:

- [ContentModels.ServerSetContentDataRequestData:212-237](/docs/reference/dto/content/CONTENT_MODELS.md#serversetcontentdatarequestdata)

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

Reference links:

- [ContentModels.ContentDataParam:1-10](/docs/reference/dto/content/CONTENT_MODELS.md#contentdataparam)

### GetFileUploadInfoListResponseData

Defines the response payload for GetFileUploadInfoList.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<FileIdUploadResponseData>` | yes | Paginated list of file IDs matching the query. — _elementCls=FileIdUploadResponseData_ |

Reference links:

- [ContentModels.FileIdUploadResponseData:250-258](/docs/reference/dto/content/CONTENT_MODELS.md#fileiduploadresponsedata)

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

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `FileIdUploadResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `fileName` | `string` | yes | Original file name submitted when the upload slot was created. |
| `tsCreate` | `long` | yes | Creation timestamp of the upload slot. |
| `removeStatus` | `GenericModels.RemoveStatusItem` | yes | Soft-remove metadata; present when the file has been marked for removal. |
| `tsUploadExpire` | `long?` | no | Upload-expiration timestamp for unfinished uploads when present. |
| `fileUpload` | `FileUploadItem?` | no | Detailed file metadata; present only after the binary has been successfully uploaded. |

Reference links:

- [ContentModels.FileIdUploadResponseData:250-258](/docs/reference/dto/content/CONTENT_MODELS.md#fileiduploadresponsedata)
- [ContentModels.FileUploadItem:285-295](/docs/reference/dto/content/CONTENT_MODELS.md#fileuploaditem)
- [Generic.RemoveStatusItem:81-90](/docs/reference/dto/generic/GENERIC_MODELS.md#removestatusitem)

### RequestDownloadFileUploadInfoResponseData

Returns the download token consumed by the SDK download helper.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `downloadToken` | `string` | yes | Short-lived token passed to the SDK download helper to fetch the file binary. |

### EmptyResponseData

Defines an intentionally empty response payload.

_Không có field public (payload rỗng)._
