# API Reference: ContentApi

Bảng contract cho `ContentApi`. Bắt đầu từ [guides/CONTENT.md](/docs/guides/CONTENT.md) để chọn namespace, method, và file flow trước khi đọc các row này.

- Domain guide: [guides/CONTENT.md](/docs/guides/CONTENT.md)
- DTO shapes: [dto/CONTENT.md](/docs/reference/dto/CONTENT.md)
- Error handling: [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md)
- Permission rules: [PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md)

## Client methods (`GNNetwork.content.*`)

<!-- prettier-ignore -->
| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |
| --- | --- | --- | --- | --- |
| `createNewFileUploadInfo` | [ContentModels.CreateNewFileUploadInfoRequestData:11-19](/docs/reference/dto/content/CONTENT_MODELS.md#createnewfileuploadinforequestdata) | [ContentModels.FileIdUploadResponseData:250-258](/docs/reference/dto/content/CONTENT_MODELS.md#fileiduploadresponsedata) | `content.createNewFileUploadInfo.otherSelfEnable` | `Ok` |
| `getContentData` | [ContentModels.GetContentDataRequestData:44-53](/docs/reference/dto/content/CONTENT_MODELS.md#getcontentdatarequestdata) | [ContentModels.GetContentDataResponseData:259-271](/docs/reference/dto/content/CONTENT_MODELS.md#getcontentdataresponsedata) | `content.getContentData.otherSelfEnable` | `Ok`, `GameNotFound` |
| `getFileUploadInfoList` | [ContentModels.GetFileUploadInfoListRequestData:78-87](/docs/reference/dto/content/CONTENT_MODELS.md#getfileuploadinfolistrequestdata) | [ContentModels.GetFileUploadInfoListResponseData:272-284](/docs/reference/dto/content/CONTENT_MODELS.md#getfileuploadinfolistresponsedata) | `content.getFileUploadInfoList.otherSelfEnable` | `Ok` |
| `getFileUploadInfo` | [ContentModels.GetFileUploadInfoRequestData:112-120](/docs/reference/dto/content/CONTENT_MODELS.md#getfileuploadinforequestdata) | [ContentModels.GetFileUploadInfoResponseData:296-318](/docs/reference/dto/content/CONTENT_MODELS.md#getfileuploadinforesponsedata) | `content.getFileUploadInfo.otherSelfEnable` | `Ok`, `FileNotFound` |
| `removeFileUploadInfo` | [ContentModels.RemoveFileUploadInfoRequestData:145-154](/docs/reference/dto/content/CONTENT_MODELS.md#removefileuploadinforequestdata) | [ContentModels.EmptyResponseData:328-332](/docs/reference/dto/content/CONTENT_MODELS.md#emptyresponsedata) | `content.removeFileUploadInfo.otherSelfEnable` | `Ok`, `FileNotFound` |
| `requestDownloadFileUploadInfo` | [ContentModels.RequestDownloadFileUploadInfoRequestData:179-187](/docs/reference/dto/content/CONTENT_MODELS.md#requestdownloadfileuploadinforequestdata) | [ContentModels.RequestDownloadFileUploadInfoResponseData:319-327](/docs/reference/dto/content/CONTENT_MODELS.md#requestdownloadfileuploadinforesponsedata) | `content.requestDownloadFileUploadInfo.otherSelfEnable` | `Ok`, `FileNotFound`, `FileNotUpload` |
| `setContentData` | [ContentModels.SetContentDataRequestData:212-225](/docs/reference/dto/content/CONTENT_MODELS.md#setcontentdatarequestdata) | [ContentModels.EmptyResponseData:328-332](/docs/reference/dto/content/CONTENT_MODELS.md#emptyresponsedata) | `content.setContentData.otherSelfEnable` | `Ok`, `GameNotFound` |

## Server methods (`GNNetwork.content.server.*`)

<!-- prettier-ignore -->
| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |
| --- | --- | --- | --- | --- |
| `createNewFileUploadInfo` | [ContentModels.ServerCreateNewFileUploadInfoRequestData:20-31](/docs/reference/dto/content/CONTENT_MODELS.md#servercreatenewfileuploadinforequestdata) | [ContentModels.FileIdUploadResponseData:250-258](/docs/reference/dto/content/CONTENT_MODELS.md#fileiduploadresponsedata) | `content.createNewFileUploadInfo.serverSelfEnable` | `Ok` |
| `getContentData` | [ContentModels.ServerGetContentDataRequestData:54-65](/docs/reference/dto/content/CONTENT_MODELS.md#servergetcontentdatarequestdata) | [ContentModels.GetContentDataResponseData:259-271](/docs/reference/dto/content/CONTENT_MODELS.md#getcontentdataresponsedata) | `content.getContentData.serverSelfEnable` | `Ok`, `GameNotFound` |
| `getFileUploadInfoList` | [ContentModels.ServerGetFileUploadInfoListRequestData:88-99](/docs/reference/dto/content/CONTENT_MODELS.md#servergetfileuploadinfolistrequestdata) | [ContentModels.GetFileUploadInfoListResponseData:272-284](/docs/reference/dto/content/CONTENT_MODELS.md#getfileuploadinfolistresponsedata) | `content.getFileUploadInfoList.serverSelfEnable` | `Ok` |
| `getFileUploadInfo` | [ContentModels.ServerGetFileUploadInfoRequestData:121-132](/docs/reference/dto/content/CONTENT_MODELS.md#servergetfileuploadinforequestdata) | [ContentModels.GetFileUploadInfoResponseData:296-318](/docs/reference/dto/content/CONTENT_MODELS.md#getfileuploadinforesponsedata) | `content.getFileUploadInfo.serverSelfEnable` | `Ok`, `FileNotFound` |
| `removeFileUploadInfo` | [ContentModels.ServerRemoveFileUploadInfoRequestData:155-166](/docs/reference/dto/content/CONTENT_MODELS.md#serverremovefileuploadinforequestdata) | [ContentModels.EmptyResponseData:328-332](/docs/reference/dto/content/CONTENT_MODELS.md#emptyresponsedata) | `content.removeFileUploadInfo.serverSelfEnable` | `Ok`, `FileNotFound` |
| `requestDownloadFileUploadInfo` | [ContentModels.ServerRequestDownloadFileUploadInfoRequestData:188-199](/docs/reference/dto/content/CONTENT_MODELS.md#serverrequestdownloadfileuploadinforequestdata) | [ContentModels.RequestDownloadFileUploadInfoResponseData:319-327](/docs/reference/dto/content/CONTENT_MODELS.md#requestdownloadfileuploadinforesponsedata) | `content.requestDownloadFileUploadInfo.serverSelfEnable` | `Ok`, `FileNotFound`, `FileNotUpload` |
| `setContentData` | [ContentModels.ServerSetContentDataRequestData:226-237](/docs/reference/dto/content/CONTENT_MODELS.md#serversetcontentdatarequestdata) | [ContentModels.EmptyResponseData:328-332](/docs/reference/dto/content/CONTENT_MODELS.md#emptyresponsedata) | `content.setContentData.serverSelfEnable` | `Ok`, `GameNotFound` |

## Admin methods (`GNNetwork.content.admin.*`)

<!-- prettier-ignore -->
| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |
| --- | --- | --- | --- | --- |
| `createNewFileUploadInfo` | [ContentModels.AdminCreateNewFileUploadInfoRequestData:32-43](/docs/reference/dto/content/CONTENT_MODELS.md#admincreatenewfileuploadinforequestdata) | [ContentModels.FileIdUploadResponseData:250-258](/docs/reference/dto/content/CONTENT_MODELS.md#fileiduploadresponsedata) | `content.createNewFileUploadInfo.adminSelfEnable` | `Ok` |
| `getContentData` | [ContentModels.AdminGetContentDataRequestData:66-77](/docs/reference/dto/content/CONTENT_MODELS.md#admingetcontentdatarequestdata) | [ContentModels.GetContentDataResponseData:259-271](/docs/reference/dto/content/CONTENT_MODELS.md#getcontentdataresponsedata) | `content.getContentData.adminSelfEnable` | `Ok`, `GameNotFound` |
| `getFileUploadInfoList` | [ContentModels.AdminGetFileUploadInfoListRequestData:100-111](/docs/reference/dto/content/CONTENT_MODELS.md#admingetfileuploadinfolistrequestdata) | [ContentModels.GetFileUploadInfoListResponseData:272-284](/docs/reference/dto/content/CONTENT_MODELS.md#getfileuploadinfolistresponsedata) | `content.getFileUploadInfoList.adminSelfEnable` | `Ok` |
| `getFileUploadInfo` | [ContentModels.AdminGetFileUploadInfoRequestData:133-144](/docs/reference/dto/content/CONTENT_MODELS.md#admingetfileuploadinforequestdata) | [ContentModels.GetFileUploadInfoResponseData:296-318](/docs/reference/dto/content/CONTENT_MODELS.md#getfileuploadinforesponsedata) | `content.getFileUploadInfo.adminSelfEnable` | `Ok`, `FileNotFound` |
| `removeFileUploadInfo` | [ContentModels.AdminRemoveFileUploadInfoRequestData:167-178](/docs/reference/dto/content/CONTENT_MODELS.md#adminremovefileuploadinforequestdata) | [ContentModels.EmptyResponseData:328-332](/docs/reference/dto/content/CONTENT_MODELS.md#emptyresponsedata) | `content.removeFileUploadInfo.adminSelfEnable` | `Ok`, `FileNotFound` |
| `requestDownloadFileUploadInfo` | [ContentModels.AdminRequestDownloadFileUploadInfoRequestData:200-211](/docs/reference/dto/content/CONTENT_MODELS.md#adminrequestdownloadfileuploadinforequestdata) | [ContentModels.RequestDownloadFileUploadInfoResponseData:319-327](/docs/reference/dto/content/CONTENT_MODELS.md#requestdownloadfileuploadinforesponsedata) | `content.requestDownloadFileUploadInfo.adminSelfEnable` | `Ok`, `FileNotFound`, `FileNotUpload` |
| `setContentData` | [ContentModels.AdminSetContentDataRequestData:238-249](/docs/reference/dto/content/CONTENT_MODELS.md#adminsetcontentdatarequestdata) | [ContentModels.EmptyResponseData:328-332](/docs/reference/dto/content/CONTENT_MODELS.md#emptyresponsedata) | `content.setContentData.adminSelfEnable` | `Ok`, `GameNotFound` |
