namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    /// <summary>
    /// Defines typed request wrappers for content operations.
    /// </summary>
    public class ContentRequestModels
    {
        /// <summary>
        /// Builds the create new file upload info operation request.
        /// </summary>
        public class CreateNewFileUploadInfoOperationRequest : CustomOperationRequestAbstract<ContentModels.CreateNewFileUploadInfoRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.CreateNewFileUploadInfo;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Content;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the CreateNewFileUploadInfoOperationRequest class.
            /// </summary>
            public CreateNewFileUploadInfoOperationRequest(ContentModels.CreateNewFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped create new file upload info operation request.
        /// </summary>
        public class ServerCreateNewFileUploadInfoOperationRequest : CreateNewFileUploadInfoOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerCreateNewFileUploadInfoOperationRequest class.
            /// </summary>
            public ServerCreateNewFileUploadInfoOperationRequest(ContentModels.ServerCreateNewFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped create new file upload info operation request.
        /// </summary>
        public class AdminCreateNewFileUploadInfoOperationRequest : CreateNewFileUploadInfoOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminCreateNewFileUploadInfoOperationRequest class.
            /// </summary>
            public AdminCreateNewFileUploadInfoOperationRequest(ContentModels.AdminCreateNewFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get content data operation request.
        /// </summary>
        public class GetContentDataOperationRequest : CustomOperationRequestAbstract<ContentModels.GetContentDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetContentData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Content;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetContentDataOperationRequest class.
            /// </summary>
            public GetContentDataOperationRequest(ContentModels.GetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get content data operation request.
        /// </summary>
        public class ServerGetContentDataOperationRequest : GetContentDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetContentDataOperationRequest class.
            /// </summary>
            public ServerGetContentDataOperationRequest(ContentModels.ServerGetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get content data operation request.
        /// </summary>
        public class AdminGetContentDataOperationRequest : GetContentDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetContentDataOperationRequest class.
            /// </summary>
            public AdminGetContentDataOperationRequest(ContentModels.AdminGetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get file upload info list operation request.
        /// </summary>
        public class GetFileUploadInfoListOperationRequest : CustomOperationRequestAbstract<ContentModels.GetFileUploadInfoListRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetFileUploadInfoList;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Content;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetFileUploadInfoListOperationRequest class.
            /// </summary>
            public GetFileUploadInfoListOperationRequest(ContentModels.GetFileUploadInfoListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get file upload info list operation request.
        /// </summary>
        public class ServerGetFileUploadInfoListOperationRequest : GetFileUploadInfoListOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetFileUploadInfoListOperationRequest class.
            /// </summary>
            public ServerGetFileUploadInfoListOperationRequest(ContentModels.ServerGetFileUploadInfoListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get file upload info list operation request.
        /// </summary>
        public class AdminGetFileUploadInfoListOperationRequest : GetFileUploadInfoListOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetFileUploadInfoListOperationRequest class.
            /// </summary>
            public AdminGetFileUploadInfoListOperationRequest(ContentModels.AdminGetFileUploadInfoListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get file upload info operation request.
        /// </summary>
        public class GetFileUploadInfoOperationRequest : CustomOperationRequestAbstract<ContentModels.GetFileUploadInfoRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetFileUploadInfo;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Content;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetFileUploadInfoOperationRequest class.
            /// </summary>
            public GetFileUploadInfoOperationRequest(ContentModels.GetFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get file upload info operation request.
        /// </summary>
        public class ServerGetFileUploadInfoOperationRequest : GetFileUploadInfoOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetFileUploadInfoOperationRequest class.
            /// </summary>
            public ServerGetFileUploadInfoOperationRequest(ContentModels.ServerGetFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get file upload info operation request.
        /// </summary>
        public class AdminGetFileUploadInfoOperationRequest : GetFileUploadInfoOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetFileUploadInfoOperationRequest class.
            /// </summary>
            public AdminGetFileUploadInfoOperationRequest(ContentModels.AdminGetFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove file upload info operation request.
        /// </summary>
        public class RemoveFileUploadInfoOperationRequest : CustomOperationRequestAbstract<ContentModels.RemoveFileUploadInfoRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemoveFileUploadInfo;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Content;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemoveFileUploadInfoOperationRequest class.
            /// </summary>
            public RemoveFileUploadInfoOperationRequest(ContentModels.RemoveFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped remove file upload info operation request.
        /// </summary>
        public class ServerRemoveFileUploadInfoOperationRequest : RemoveFileUploadInfoOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerRemoveFileUploadInfoOperationRequest class.
            /// </summary>
            public ServerRemoveFileUploadInfoOperationRequest(ContentModels.ServerRemoveFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped remove file upload info operation request.
        /// </summary>
        public class AdminRemoveFileUploadInfoOperationRequest : RemoveFileUploadInfoOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminRemoveFileUploadInfoOperationRequest class.
            /// </summary>
            public AdminRemoveFileUploadInfoOperationRequest(ContentModels.AdminRemoveFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the request download file upload info operation request.
        /// </summary>
        public class RequestDownloadFileUploadInfoOperationRequest : CustomOperationRequestAbstract<ContentModels.RequestDownloadFileUploadInfoRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RequestDownloadFileUploadInfo;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Content;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RequestDownloadFileUploadInfoOperationRequest class.
            /// </summary>
            public RequestDownloadFileUploadInfoOperationRequest(ContentModels.RequestDownloadFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped request download file upload info operation request.
        /// </summary>
        public class ServerRequestDownloadFileUploadInfoOperationRequest : RequestDownloadFileUploadInfoOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerRequestDownloadFileUploadInfoOperationRequest class.
            /// </summary>
            public ServerRequestDownloadFileUploadInfoOperationRequest(ContentModels.ServerRequestDownloadFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped request download file upload info operation request.
        /// </summary>
        public class AdminRequestDownloadFileUploadInfoOperationRequest : RequestDownloadFileUploadInfoOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminRequestDownloadFileUploadInfoOperationRequest class.
            /// </summary>
            public AdminRequestDownloadFileUploadInfoOperationRequest(ContentModels.AdminRequestDownloadFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set content data operation request.
        /// </summary>
        public class SetContentDataOperationRequest : CustomOperationRequestAbstract<ContentModels.SetContentDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetContentData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Content;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetContentDataOperationRequest class.
            /// </summary>
            public SetContentDataOperationRequest(ContentModels.SetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set content data operation request.
        /// </summary>
        public class ServerSetContentDataOperationRequest : SetContentDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetContentDataOperationRequest class.
            /// </summary>
            public ServerSetContentDataOperationRequest(ContentModels.ServerSetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set content data operation request.
        /// </summary>
        public class AdminSetContentDataOperationRequest : SetContentDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetContentDataOperationRequest class.
            /// </summary>
            public AdminSetContentDataOperationRequest(ContentModels.AdminSetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


    }

}