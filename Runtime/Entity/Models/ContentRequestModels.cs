namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    public class ContentRequestModels
    {
        public class CreateNewFileUploadInfoOperationRequest : CustomOperationRequest<ContentModels.CreateNewFileUploadInfoRequestData>
        {
            protected override string operationCode => OperationCode.CreateNewFileUploadInfo;
            protected override RequestType requestType => RequestType.Content;
            protected override RequestRole role => RequestRole.Client;

            public CreateNewFileUploadInfoOperationRequest(ContentModels.CreateNewFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerCreateNewFileUploadInfoOperationRequest : CreateNewFileUploadInfoOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerCreateNewFileUploadInfoOperationRequest(ContentModels.ServerCreateNewFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminCreateNewFileUploadInfoOperationRequest : CreateNewFileUploadInfoOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminCreateNewFileUploadInfoOperationRequest(ContentModels.AdminCreateNewFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetContentDataOperationRequest : CustomOperationRequest<ContentModels.GetContentDataRequestData>
        {
            protected override string operationCode => OperationCode.GetContentData;
            protected override RequestType requestType => RequestType.Content;
            protected override RequestRole role => RequestRole.Client;

            public GetContentDataOperationRequest(ContentModels.GetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetContentDataOperationRequest : GetContentDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetContentDataOperationRequest(ContentModels.ServerGetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetContentDataOperationRequest : GetContentDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetContentDataOperationRequest(ContentModels.AdminGetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetFileUploadInfoListOperationRequest : CustomOperationRequest<ContentModels.GetFileUploadInfoListRequestData>
        {
            protected override string operationCode => OperationCode.GetFileUploadInfoList;
            protected override RequestType requestType => RequestType.Content;
            protected override RequestRole role => RequestRole.Client;

            public GetFileUploadInfoListOperationRequest(ContentModels.GetFileUploadInfoListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetFileUploadInfoListOperationRequest : GetFileUploadInfoListOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetFileUploadInfoListOperationRequest(ContentModels.ServerGetFileUploadInfoListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetFileUploadInfoListOperationRequest : GetFileUploadInfoListOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetFileUploadInfoListOperationRequest(ContentModels.AdminGetFileUploadInfoListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetFileUploadInfoOperationRequest : CustomOperationRequest<ContentModels.GetFileUploadInfoRequestData>
        {
            protected override string operationCode => OperationCode.GetFileUploadInfo;
            protected override RequestType requestType => RequestType.Content;
            protected override RequestRole role => RequestRole.Client;

            public GetFileUploadInfoOperationRequest(ContentModels.GetFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetFileUploadInfoOperationRequest : GetFileUploadInfoOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetFileUploadInfoOperationRequest(ContentModels.ServerGetFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetFileUploadInfoOperationRequest : GetFileUploadInfoOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetFileUploadInfoOperationRequest(ContentModels.AdminGetFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveFileUploadInfoOperationRequest : CustomOperationRequest<ContentModels.RemoveFileUploadInfoRequestData>
        {
            protected override string operationCode => OperationCode.RemoveFileUploadInfo;
            protected override RequestType requestType => RequestType.Content;
            protected override RequestRole role => RequestRole.Client;

            public RemoveFileUploadInfoOperationRequest(ContentModels.RemoveFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveFileUploadInfoOperationRequest : RemoveFileUploadInfoOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerRemoveFileUploadInfoOperationRequest(ContentModels.ServerRemoveFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveFileUploadInfoOperationRequest : RemoveFileUploadInfoOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminRemoveFileUploadInfoOperationRequest(ContentModels.AdminRemoveFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RequestDownloadFileUploadInfoOperationRequest : CustomOperationRequest<ContentModels.RequestDownloadFileUploadInfoRequestData>
        {
            protected override string operationCode => OperationCode.RequestDownloadFileUploadInfo;
            protected override RequestType requestType => RequestType.Content;
            protected override RequestRole role => RequestRole.Client;

            public RequestDownloadFileUploadInfoOperationRequest(ContentModels.RequestDownloadFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRequestDownloadFileUploadInfoOperationRequest : RequestDownloadFileUploadInfoOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerRequestDownloadFileUploadInfoOperationRequest(ContentModels.ServerRequestDownloadFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRequestDownloadFileUploadInfoOperationRequest : RequestDownloadFileUploadInfoOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminRequestDownloadFileUploadInfoOperationRequest(ContentModels.AdminRequestDownloadFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetContentDataOperationRequest : CustomOperationRequest<ContentModels.SetContentDataRequestData>
        {
            protected override string operationCode => OperationCode.SetContentData;
            protected override RequestType requestType => RequestType.Content;
            protected override RequestRole role => RequestRole.Client;

            public SetContentDataOperationRequest(ContentModels.SetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetContentDataOperationRequest : SetContentDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetContentDataOperationRequest(ContentModels.ServerSetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetContentDataOperationRequest : SetContentDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetContentDataOperationRequest(ContentModels.AdminSetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


    }

}
