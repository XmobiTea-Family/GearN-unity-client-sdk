namespace XmobiTea.GearN
{
    using System.Threading.Tasks;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Models;

    public class ContentApi
    {
        public ServerApi server { get; } = new ServerApi();

        public AdminApi admin { get; } = new AdminApi();

        public void createNewFileUploadInfo(ContentModels.CreateNewFileUploadInfoRequestData requestData, Action1<ContentResponseModels.CreateNewFileUploadInfoOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new ContentRequestModels.CreateNewFileUploadInfoOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<ContentResponseModels.CreateNewFileUploadInfoOperationResponse> createNewFileUploadInfoAsync(ContentModels.CreateNewFileUploadInfoRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<ContentRequestModels.CreateNewFileUploadInfoOperationRequest, ContentResponseModels.CreateNewFileUploadInfoOperationResponse>(new ContentRequestModels.CreateNewFileUploadInfoOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getContentData(ContentModels.GetContentDataRequestData requestData, Action1<ContentResponseModels.GetContentDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new ContentRequestModels.GetContentDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<ContentResponseModels.GetContentDataOperationResponse> getContentDataAsync(ContentModels.GetContentDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<ContentRequestModels.GetContentDataOperationRequest, ContentResponseModels.GetContentDataOperationResponse>(new ContentRequestModels.GetContentDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getFileUploadInfoList(ContentModels.GetFileUploadInfoListRequestData requestData, Action1<ContentResponseModels.GetFileUploadInfoListOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new ContentRequestModels.GetFileUploadInfoListOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<ContentResponseModels.GetFileUploadInfoListOperationResponse> getFileUploadInfoListAsync(ContentModels.GetFileUploadInfoListRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<ContentRequestModels.GetFileUploadInfoListOperationRequest, ContentResponseModels.GetFileUploadInfoListOperationResponse>(new ContentRequestModels.GetFileUploadInfoListOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getFileUploadInfo(ContentModels.GetFileUploadInfoRequestData requestData, Action1<ContentResponseModels.GetFileUploadInfoOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new ContentRequestModels.GetFileUploadInfoOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<ContentResponseModels.GetFileUploadInfoOperationResponse> getFileUploadInfoAsync(ContentModels.GetFileUploadInfoRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<ContentRequestModels.GetFileUploadInfoOperationRequest, ContentResponseModels.GetFileUploadInfoOperationResponse>(new ContentRequestModels.GetFileUploadInfoOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removeFileUploadInfo(ContentModels.RemoveFileUploadInfoRequestData requestData, Action1<ContentResponseModels.RemoveFileUploadInfoOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new ContentRequestModels.RemoveFileUploadInfoOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<ContentResponseModels.RemoveFileUploadInfoOperationResponse> removeFileUploadInfoAsync(ContentModels.RemoveFileUploadInfoRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<ContentRequestModels.RemoveFileUploadInfoOperationRequest, ContentResponseModels.RemoveFileUploadInfoOperationResponse>(new ContentRequestModels.RemoveFileUploadInfoOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void requestDownloadFileUploadInfo(ContentModels.RequestDownloadFileUploadInfoRequestData requestData, Action1<ContentResponseModels.RequestDownloadFileUploadInfoOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new ContentRequestModels.RequestDownloadFileUploadInfoOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<ContentResponseModels.RequestDownloadFileUploadInfoOperationResponse> requestDownloadFileUploadInfoAsync(ContentModels.RequestDownloadFileUploadInfoRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<ContentRequestModels.RequestDownloadFileUploadInfoOperationRequest, ContentResponseModels.RequestDownloadFileUploadInfoOperationResponse>(new ContentRequestModels.RequestDownloadFileUploadInfoOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setContentData(ContentModels.SetContentDataRequestData requestData, Action1<ContentResponseModels.SetContentDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new ContentRequestModels.SetContentDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<ContentResponseModels.SetContentDataOperationResponse> setContentDataAsync(ContentModels.SetContentDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<ContentRequestModels.SetContentDataOperationRequest, ContentResponseModels.SetContentDataOperationResponse>(new ContentRequestModels.SetContentDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }


        public class ServerApi
        {
            public void createNewFileUploadInfo(ContentModels.ServerCreateNewFileUploadInfoRequestData requestData, Action1<ContentResponseModels.CreateNewFileUploadInfoOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new ContentRequestModels.ServerCreateNewFileUploadInfoOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<ContentResponseModels.CreateNewFileUploadInfoOperationResponse> createNewFileUploadInfoAsync(ContentModels.ServerCreateNewFileUploadInfoRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<ContentRequestModels.ServerCreateNewFileUploadInfoOperationRequest, ContentResponseModels.CreateNewFileUploadInfoOperationResponse>(new ContentRequestModels.ServerCreateNewFileUploadInfoOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getContentData(ContentModels.ServerGetContentDataRequestData requestData, Action1<ContentResponseModels.GetContentDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new ContentRequestModels.ServerGetContentDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<ContentResponseModels.GetContentDataOperationResponse> getContentDataAsync(ContentModels.ServerGetContentDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<ContentRequestModels.ServerGetContentDataOperationRequest, ContentResponseModels.GetContentDataOperationResponse>(new ContentRequestModels.ServerGetContentDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getFileUploadInfoList(ContentModels.ServerGetFileUploadInfoListRequestData requestData, Action1<ContentResponseModels.GetFileUploadInfoListOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new ContentRequestModels.ServerGetFileUploadInfoListOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<ContentResponseModels.GetFileUploadInfoListOperationResponse> getFileUploadInfoListAsync(ContentModels.ServerGetFileUploadInfoListRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<ContentRequestModels.ServerGetFileUploadInfoListOperationRequest, ContentResponseModels.GetFileUploadInfoListOperationResponse>(new ContentRequestModels.ServerGetFileUploadInfoListOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getFileUploadInfo(ContentModels.ServerGetFileUploadInfoRequestData requestData, Action1<ContentResponseModels.GetFileUploadInfoOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new ContentRequestModels.ServerGetFileUploadInfoOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<ContentResponseModels.GetFileUploadInfoOperationResponse> getFileUploadInfoAsync(ContentModels.ServerGetFileUploadInfoRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<ContentRequestModels.ServerGetFileUploadInfoOperationRequest, ContentResponseModels.GetFileUploadInfoOperationResponse>(new ContentRequestModels.ServerGetFileUploadInfoOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeFileUploadInfo(ContentModels.ServerRemoveFileUploadInfoRequestData requestData, Action1<ContentResponseModels.RemoveFileUploadInfoOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new ContentRequestModels.ServerRemoveFileUploadInfoOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<ContentResponseModels.RemoveFileUploadInfoOperationResponse> removeFileUploadInfoAsync(ContentModels.ServerRemoveFileUploadInfoRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<ContentRequestModels.ServerRemoveFileUploadInfoOperationRequest, ContentResponseModels.RemoveFileUploadInfoOperationResponse>(new ContentRequestModels.ServerRemoveFileUploadInfoOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void requestDownloadFileUploadInfo(ContentModels.ServerRequestDownloadFileUploadInfoRequestData requestData, Action1<ContentResponseModels.RequestDownloadFileUploadInfoOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new ContentRequestModels.ServerRequestDownloadFileUploadInfoOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<ContentResponseModels.RequestDownloadFileUploadInfoOperationResponse> requestDownloadFileUploadInfoAsync(ContentModels.ServerRequestDownloadFileUploadInfoRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<ContentRequestModels.ServerRequestDownloadFileUploadInfoOperationRequest, ContentResponseModels.RequestDownloadFileUploadInfoOperationResponse>(new ContentRequestModels.ServerRequestDownloadFileUploadInfoOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setContentData(ContentModels.ServerSetContentDataRequestData requestData, Action1<ContentResponseModels.SetContentDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new ContentRequestModels.ServerSetContentDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<ContentResponseModels.SetContentDataOperationResponse> setContentDataAsync(ContentModels.ServerSetContentDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<ContentRequestModels.ServerSetContentDataOperationRequest, ContentResponseModels.SetContentDataOperationResponse>(new ContentRequestModels.ServerSetContentDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

        public class AdminApi
        {
            public void createNewFileUploadInfo(ContentModels.AdminCreateNewFileUploadInfoRequestData requestData, Action1<ContentResponseModels.CreateNewFileUploadInfoOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new ContentRequestModels.AdminCreateNewFileUploadInfoOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<ContentResponseModels.CreateNewFileUploadInfoOperationResponse> createNewFileUploadInfoAsync(ContentModels.AdminCreateNewFileUploadInfoRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<ContentRequestModels.AdminCreateNewFileUploadInfoOperationRequest, ContentResponseModels.CreateNewFileUploadInfoOperationResponse>(new ContentRequestModels.AdminCreateNewFileUploadInfoOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getContentData(ContentModels.AdminGetContentDataRequestData requestData, Action1<ContentResponseModels.GetContentDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new ContentRequestModels.AdminGetContentDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<ContentResponseModels.GetContentDataOperationResponse> getContentDataAsync(ContentModels.AdminGetContentDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<ContentRequestModels.AdminGetContentDataOperationRequest, ContentResponseModels.GetContentDataOperationResponse>(new ContentRequestModels.AdminGetContentDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getFileUploadInfoList(ContentModels.AdminGetFileUploadInfoListRequestData requestData, Action1<ContentResponseModels.GetFileUploadInfoListOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new ContentRequestModels.AdminGetFileUploadInfoListOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<ContentResponseModels.GetFileUploadInfoListOperationResponse> getFileUploadInfoListAsync(ContentModels.AdminGetFileUploadInfoListRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<ContentRequestModels.AdminGetFileUploadInfoListOperationRequest, ContentResponseModels.GetFileUploadInfoListOperationResponse>(new ContentRequestModels.AdminGetFileUploadInfoListOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getFileUploadInfo(ContentModels.AdminGetFileUploadInfoRequestData requestData, Action1<ContentResponseModels.GetFileUploadInfoOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new ContentRequestModels.AdminGetFileUploadInfoOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<ContentResponseModels.GetFileUploadInfoOperationResponse> getFileUploadInfoAsync(ContentModels.AdminGetFileUploadInfoRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<ContentRequestModels.AdminGetFileUploadInfoOperationRequest, ContentResponseModels.GetFileUploadInfoOperationResponse>(new ContentRequestModels.AdminGetFileUploadInfoOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeFileUploadInfo(ContentModels.AdminRemoveFileUploadInfoRequestData requestData, Action1<ContentResponseModels.RemoveFileUploadInfoOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new ContentRequestModels.AdminRemoveFileUploadInfoOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<ContentResponseModels.RemoveFileUploadInfoOperationResponse> removeFileUploadInfoAsync(ContentModels.AdminRemoveFileUploadInfoRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<ContentRequestModels.AdminRemoveFileUploadInfoOperationRequest, ContentResponseModels.RemoveFileUploadInfoOperationResponse>(new ContentRequestModels.AdminRemoveFileUploadInfoOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void requestDownloadFileUploadInfo(ContentModels.AdminRequestDownloadFileUploadInfoRequestData requestData, Action1<ContentResponseModels.RequestDownloadFileUploadInfoOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new ContentRequestModels.AdminRequestDownloadFileUploadInfoOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<ContentResponseModels.RequestDownloadFileUploadInfoOperationResponse> requestDownloadFileUploadInfoAsync(ContentModels.AdminRequestDownloadFileUploadInfoRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<ContentRequestModels.AdminRequestDownloadFileUploadInfoOperationRequest, ContentResponseModels.RequestDownloadFileUploadInfoOperationResponse>(new ContentRequestModels.AdminRequestDownloadFileUploadInfoOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setContentData(ContentModels.AdminSetContentDataRequestData requestData, Action1<ContentResponseModels.SetContentDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new ContentRequestModels.AdminSetContentDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<ContentResponseModels.SetContentDataOperationResponse> setContentDataAsync(ContentModels.AdminSetContentDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<ContentRequestModels.AdminSetContentDataOperationRequest, ContentResponseModels.SetContentDataOperationResponse>(new ContentRequestModels.AdminSetContentDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

    }

    public static partial class GNNetwork
    {

        public static ContentApi content { get; }
    }

}
