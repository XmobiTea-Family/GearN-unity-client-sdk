namespace XmobiTea.GN.Entity.Models
{
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity.Request;

	public class ContentRequestModels
	{
		public class CreateNewFileUploadInfoOperationRequest : CustomOperationRequest<ContentModels.CreateNewFileUploadInfoRequestData>
		{
			protected override int operationCode => OperationCode.CreateNewFileUploadInfo;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Content;
			protected override RequestRole requestRole => RequestRole.Client;

			public CreateNewFileUploadInfoOperationRequest(ContentModels.CreateNewFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerCreateNewFileUploadInfoOperationRequest : CreateNewFileUploadInfoOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerCreateNewFileUploadInfoOperationRequest(ContentModels.ServerCreateNewFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminCreateNewFileUploadInfoOperationRequest : CreateNewFileUploadInfoOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminCreateNewFileUploadInfoOperationRequest(ContentModels.AdminCreateNewFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetContentDataOperationRequest : CustomOperationRequest<ContentModels.GetContentDataRequestData>
		{
			protected override int operationCode => OperationCode.GetContentData;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Content;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetContentDataOperationRequest(ContentModels.GetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetContentDataOperationRequest : GetContentDataOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetContentDataOperationRequest(ContentModels.ServerGetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetContentDataOperationRequest : GetContentDataOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetContentDataOperationRequest(ContentModels.AdminGetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetFileUploadInfoListOperationRequest : CustomOperationRequest<ContentModels.GetFileUploadInfoListRequestData>
		{
			protected override int operationCode => OperationCode.GetFileUploadInfoList;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Content;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetFileUploadInfoListOperationRequest(ContentModels.GetFileUploadInfoListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetFileUploadInfoListOperationRequest : GetFileUploadInfoListOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetFileUploadInfoListOperationRequest(ContentModels.ServerGetFileUploadInfoListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetFileUploadInfoListOperationRequest : GetFileUploadInfoListOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetFileUploadInfoListOperationRequest(ContentModels.AdminGetFileUploadInfoListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetFileUploadInfoOperationRequest : CustomOperationRequest<ContentModels.GetFileUploadInfoRequestData>
		{
			protected override int operationCode => OperationCode.GetFileUploadInfo;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Content;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetFileUploadInfoOperationRequest(ContentModels.GetFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetFileUploadInfoOperationRequest : GetFileUploadInfoOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetFileUploadInfoOperationRequest(ContentModels.ServerGetFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetFileUploadInfoOperationRequest : GetFileUploadInfoOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetFileUploadInfoOperationRequest(ContentModels.AdminGetFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class RemoveFileUploadInfoOperationRequest : CustomOperationRequest<ContentModels.RemoveFileUploadInfoRequestData>
		{
			protected override int operationCode => OperationCode.RemoveFileUploadInfo;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Content;
			protected override RequestRole requestRole => RequestRole.Client;

			public RemoveFileUploadInfoOperationRequest(ContentModels.RemoveFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerRemoveFileUploadInfoOperationRequest : RemoveFileUploadInfoOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerRemoveFileUploadInfoOperationRequest(ContentModels.ServerRemoveFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminRemoveFileUploadInfoOperationRequest : RemoveFileUploadInfoOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminRemoveFileUploadInfoOperationRequest(ContentModels.AdminRemoveFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class RequestDownloadFileUploadInfoOperationRequest : CustomOperationRequest<ContentModels.RequestDownloadFileUploadInfoRequestData>
		{
			protected override int operationCode => OperationCode.RequestDownloadFileUploadInfo;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Content;
			protected override RequestRole requestRole => RequestRole.Client;

			public RequestDownloadFileUploadInfoOperationRequest(ContentModels.RequestDownloadFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerRequestDownloadFileUploadInfoOperationRequest : RequestDownloadFileUploadInfoOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerRequestDownloadFileUploadInfoOperationRequest(ContentModels.ServerRequestDownloadFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminRequestDownloadFileUploadInfoOperationRequest : RequestDownloadFileUploadInfoOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminRequestDownloadFileUploadInfoOperationRequest(ContentModels.AdminRequestDownloadFileUploadInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetContentDataOperationRequest : CustomOperationRequest<ContentModels.SetContentDataRequestData>
		{
			protected override int operationCode => OperationCode.SetContentData;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Content;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetContentDataOperationRequest(ContentModels.SetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerSetContentDataOperationRequest : SetContentDataOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerSetContentDataOperationRequest(ContentModels.ServerSetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminSetContentDataOperationRequest : SetContentDataOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminSetContentDataOperationRequest(ContentModels.AdminSetContentDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


	}

}
