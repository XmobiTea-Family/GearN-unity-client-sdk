# CLOUDSCRIPT ADMIN CONTENT

## 1. Mục đích

File này chỉ tập trung vào `admin.content` trong cloud script.

Mapping chính:

- `admin.content` → `GNNetwork.content.admin`

## 2. Ví dụ sử dụng

```ts
const requireString = (value: unknown, fieldName: string): string => {
    if (typeof value !== "string" || value.trim().length === 0) throw new Error(fieldName + " is required");
    return value.trim();
};

const assertResponseOk = (response: CustomOperationResponse, actionName: string): void => {
    if (response.hasReturnCodeError()) throw new Error(actionName + " return-code error: " + (response.debugMessage ?? response.toString()));
    if (response.errorCode !== ErrorCode.Ok) throw new Error(actionName + " business error: " + response.errorCode);
};

// Đọc content data theo key
handlers["getContentByKey"] = async (args: any, context, log) => {
    const key = requireString(args?.key, "key");

    const requestData = new ContentModels.AdminGetContentDataRequestData();
    requestData.contentDataKeys = [key];

    const response = await admin.content.getContentDataAsync(requestData);
    assertResponseOk(response, "getContentDataAsync");

    return response.responseData;
};
```

## 3. Các hàm

<!-- prettier-ignore -->
| Hàm gốc | Code trong cloudScript như thế nào | Request Data DTO | Response DTO |
| --- | --- | --- | --- |
| `createNewFileUploadInfo(requestData: ContentModels.AdminCreateNewFileUploadInfoRequestData, onResponse?: Action1<ContentResponseModels.CreateNewFileUploadInfoOperationResponse>, overrideAuthToken?: string, overrideSecretKey?: string, customTags?: GNHashtable, timeout?: number): void` | `admin.content.createNewFileUploadInfo(requestData, onResponse?, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?)` | [ContentModels.AdminCreateNewFileUploadInfoRequestData:11-43](/docs/reference/dto/content/CONTENT_MODELS.md#admincreatenewfileuploadinforequestdata) | [ContentResponseModels.CreateNewFileUploadInfoOperationResponse:1-12](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#createnewfileuploadinfooperationresponse) |
| `createNewFileUploadInfoAsync(requestData: ContentModels.AdminCreateNewFileUploadInfoRequestData, overrideAuthToken?: string, overrideSecretKey?: string, customTags?: GNHashtable, timeout?: number): Promise<ContentResponseModels.CreateNewFileUploadInfoOperationResponse>` | `admin.content.createNewFileUploadInfoAsync(requestData, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?)` | [ContentModels.AdminCreateNewFileUploadInfoRequestData:11-43](/docs/reference/dto/content/CONTENT_MODELS.md#admincreatenewfileuploadinforequestdata) | [ContentResponseModels.CreateNewFileUploadInfoOperationResponse:1-12](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#createnewfileuploadinfooperationresponse) |
| `getContentData(requestData: ContentModels.AdminGetContentDataRequestData, onResponse?: Action1<ContentResponseModels.GetContentDataOperationResponse>, overrideAuthToken?: string, overrideSecretKey?: string, customTags?: GNHashtable, timeout?: number): void` | `admin.content.getContentData(requestData, onResponse?, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?)` | [ContentModels.AdminGetContentDataRequestData:44-77](/docs/reference/dto/content/CONTENT_MODELS.md#admingetcontentdatarequestdata) | [ContentResponseModels.GetContentDataOperationResponse:13-24](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#getcontentdataoperationresponse) |
| `getContentDataAsync(requestData: ContentModels.AdminGetContentDataRequestData, overrideAuthToken?: string, overrideSecretKey?: string, customTags?: GNHashtable, timeout?: number): Promise<ContentResponseModels.GetContentDataOperationResponse>` | `admin.content.getContentDataAsync(requestData, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?)` | [ContentModels.AdminGetContentDataRequestData:44-77](/docs/reference/dto/content/CONTENT_MODELS.md#admingetcontentdatarequestdata) | [ContentResponseModels.GetContentDataOperationResponse:13-24](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#getcontentdataoperationresponse) |
| `getFileUploadInfoList(requestData: ContentModels.AdminGetFileUploadInfoListRequestData, onResponse?: Action1<ContentResponseModels.GetFileUploadInfoListOperationResponse>, overrideAuthToken?: string, overrideSecretKey?: string, customTags?: GNHashtable, timeout?: number): void` | `admin.content.getFileUploadInfoList(requestData, onResponse?, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?)` | [ContentModels.AdminGetFileUploadInfoListRequestData:78-111](/docs/reference/dto/content/CONTENT_MODELS.md#admingetfileuploadinfolistrequestdata) | [ContentResponseModels.GetFileUploadInfoListOperationResponse:25-36](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#getfileuploadinfolistoperationresponse) |
| `getFileUploadInfoListAsync(requestData: ContentModels.AdminGetFileUploadInfoListRequestData, overrideAuthToken?: string, overrideSecretKey?: string, customTags?: GNHashtable, timeout?: number): Promise<ContentResponseModels.GetFileUploadInfoListOperationResponse>` | `admin.content.getFileUploadInfoListAsync(requestData, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?)` | [ContentModels.AdminGetFileUploadInfoListRequestData:78-111](/docs/reference/dto/content/CONTENT_MODELS.md#admingetfileuploadinfolistrequestdata) | [ContentResponseModels.GetFileUploadInfoListOperationResponse:25-36](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#getfileuploadinfolistoperationresponse) |
| `getFileUploadInfo(requestData: ContentModels.AdminGetFileUploadInfoRequestData, onResponse?: Action1<ContentResponseModels.GetFileUploadInfoOperationResponse>, overrideAuthToken?: string, overrideSecretKey?: string, customTags?: GNHashtable, timeout?: number): void` | `admin.content.getFileUploadInfo(requestData, onResponse?, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?)` | [ContentModels.AdminGetFileUploadInfoRequestData:112-144](/docs/reference/dto/content/CONTENT_MODELS.md#admingetfileuploadinforequestdata) | [ContentResponseModels.GetFileUploadInfoOperationResponse:37-48](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#getfileuploadinfooperationresponse) |
| `getFileUploadInfoAsync(requestData: ContentModels.AdminGetFileUploadInfoRequestData, overrideAuthToken?: string, overrideSecretKey?: string, customTags?: GNHashtable, timeout?: number): Promise<ContentResponseModels.GetFileUploadInfoOperationResponse>` | `admin.content.getFileUploadInfoAsync(requestData, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?)` | [ContentModels.AdminGetFileUploadInfoRequestData:112-144](/docs/reference/dto/content/CONTENT_MODELS.md#admingetfileuploadinforequestdata) | [ContentResponseModels.GetFileUploadInfoOperationResponse:37-48](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#getfileuploadinfooperationresponse) |
| `removeFileUploadInfo(requestData: ContentModels.AdminRemoveFileUploadInfoRequestData, onResponse?: Action1<ContentResponseModels.RemoveFileUploadInfoOperationResponse>, overrideAuthToken?: string, overrideSecretKey?: string, customTags?: GNHashtable, timeout?: number): void` | `admin.content.removeFileUploadInfo(requestData, onResponse?, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?)` | [ContentModels.AdminRemoveFileUploadInfoRequestData:145-178](/docs/reference/dto/content/CONTENT_MODELS.md#adminremovefileuploadinforequestdata) | [ContentResponseModels.RemoveFileUploadInfoOperationResponse:49-60](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#removefileuploadinfooperationresponse) |
| `removeFileUploadInfoAsync(requestData: ContentModels.AdminRemoveFileUploadInfoRequestData, overrideAuthToken?: string, overrideSecretKey?: string, customTags?: GNHashtable, timeout?: number): Promise<ContentResponseModels.RemoveFileUploadInfoOperationResponse>` | `admin.content.removeFileUploadInfoAsync(requestData, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?)` | [ContentModels.AdminRemoveFileUploadInfoRequestData:145-178](/docs/reference/dto/content/CONTENT_MODELS.md#adminremovefileuploadinforequestdata) | [ContentResponseModels.RemoveFileUploadInfoOperationResponse:49-60](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#removefileuploadinfooperationresponse) |
| `requestDownloadFileUploadInfo(requestData: ContentModels.AdminRequestDownloadFileUploadInfoRequestData, onResponse?: Action1<ContentResponseModels.RequestDownloadFileUploadInfoOperationResponse>, overrideAuthToken?: string, overrideSecretKey?: string, customTags?: GNHashtable, timeout?: number): void` | `admin.content.requestDownloadFileUploadInfo(requestData, onResponse?, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?)` | [ContentModels.AdminRequestDownloadFileUploadInfoRequestData:179-211](/docs/reference/dto/content/CONTENT_MODELS.md#adminrequestdownloadfileuploadinforequestdata) | [ContentResponseModels.RequestDownloadFileUploadInfoOperationResponse:61-72](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#requestdownloadfileuploadinfooperationresponse) |
| `requestDownloadFileUploadInfoAsync(requestData: ContentModels.AdminRequestDownloadFileUploadInfoRequestData, overrideAuthToken?: string, overrideSecretKey?: string, customTags?: GNHashtable, timeout?: number): Promise<ContentResponseModels.RequestDownloadFileUploadInfoOperationResponse>` | `admin.content.requestDownloadFileUploadInfoAsync(requestData, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?)` | [ContentModels.AdminRequestDownloadFileUploadInfoRequestData:179-211](/docs/reference/dto/content/CONTENT_MODELS.md#adminrequestdownloadfileuploadinforequestdata) | [ContentResponseModels.RequestDownloadFileUploadInfoOperationResponse:61-72](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#requestdownloadfileuploadinfooperationresponse) |
| `setContentData(requestData: ContentModels.AdminSetContentDataRequestData, onResponse?: Action1<ContentResponseModels.SetContentDataOperationResponse>, overrideAuthToken?: string, overrideSecretKey?: string, customTags?: GNHashtable, timeout?: number): void` | `admin.content.setContentData(requestData, onResponse?, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?)` | [ContentModels.AdminSetContentDataRequestData:212-249](/docs/reference/dto/content/CONTENT_MODELS.md#adminsetcontentdatarequestdata) | [ContentResponseModels.SetContentDataOperationResponse:73-83](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#setcontentdataoperationresponse) |
| `setContentDataAsync(requestData: ContentModels.AdminSetContentDataRequestData, overrideAuthToken?: string, overrideSecretKey?: string, customTags?: GNHashtable, timeout?: number): Promise<ContentResponseModels.SetContentDataOperationResponse>` | `admin.content.setContentDataAsync(requestData, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?)` | [ContentModels.AdminSetContentDataRequestData:212-249](/docs/reference/dto/content/CONTENT_MODELS.md#adminsetcontentdatarequestdata) | [ContentResponseModels.SetContentDataOperationResponse:73-83](/docs/reference/dto/content/CONTENT_RESPONSE_MODELS.md#setcontentdataoperationresponse) |




