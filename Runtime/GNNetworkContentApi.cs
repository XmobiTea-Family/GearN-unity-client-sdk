namespace XmobiTea.GN
{
	using System;
	using XmobiTea.GN.Common;
	using XmobiTea.GN.Entity;
	using XmobiTea.GN.Entity.Models;

	public static partial class GNNetwork
	{
		public class ContentApi
		{
			public ServerApi server { get; } = new ServerApi();

			public AdminApi admin { get; } = new AdminApi();

			public void createNewFileUploadInfo(ContentModels.CreateNewFileUploadInfoRequestData requestData, Action<ContentResponseModels.CreateNewFileUploadInfoOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new ContentRequestModels.CreateNewFileUploadInfoOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getContentData(ContentModels.GetContentDataRequestData requestData, Action<ContentResponseModels.GetContentDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new ContentRequestModels.GetContentDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getFileUploadInfoList(ContentModels.GetFileUploadInfoListRequestData requestData, Action<ContentResponseModels.GetFileUploadInfoListOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new ContentRequestModels.GetFileUploadInfoListOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getFileUploadInfo(ContentModels.GetFileUploadInfoRequestData requestData, Action<ContentResponseModels.GetFileUploadInfoOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new ContentRequestModels.GetFileUploadInfoOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeFileUploadInfo(ContentModels.RemoveFileUploadInfoRequestData requestData, Action<ContentResponseModels.RemoveFileUploadInfoOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new ContentRequestModels.RemoveFileUploadInfoOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void requestDownloadFileUploadInfo(ContentModels.RequestDownloadFileUploadInfoRequestData requestData, Action<ContentResponseModels.RequestDownloadFileUploadInfoOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new ContentRequestModels.RequestDownloadFileUploadInfoOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setContentData(ContentModels.SetContentDataRequestData requestData, Action<ContentResponseModels.SetContentDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new ContentRequestModels.SetContentDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}


			public class ServerApi
			{
				public void createNewFileUploadInfo(ContentModels.ServerCreateNewFileUploadInfoRequestData requestData, Action<ContentResponseModels.CreateNewFileUploadInfoOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new ContentRequestModels.ServerCreateNewFileUploadInfoOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getContentData(ContentModels.ServerGetContentDataRequestData requestData, Action<ContentResponseModels.GetContentDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new ContentRequestModels.ServerGetContentDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getFileUploadInfoList(ContentModels.ServerGetFileUploadInfoListRequestData requestData, Action<ContentResponseModels.GetFileUploadInfoListOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new ContentRequestModels.ServerGetFileUploadInfoListOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getFileUploadInfo(ContentModels.ServerGetFileUploadInfoRequestData requestData, Action<ContentResponseModels.GetFileUploadInfoOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new ContentRequestModels.ServerGetFileUploadInfoOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeFileUploadInfo(ContentModels.ServerRemoveFileUploadInfoRequestData requestData, Action<ContentResponseModels.RemoveFileUploadInfoOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new ContentRequestModels.ServerRemoveFileUploadInfoOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void requestDownloadFileUploadInfo(ContentModels.ServerRequestDownloadFileUploadInfoRequestData requestData, Action<ContentResponseModels.RequestDownloadFileUploadInfoOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new ContentRequestModels.ServerRequestDownloadFileUploadInfoOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setContentData(ContentModels.ServerSetContentDataRequestData requestData, Action<ContentResponseModels.SetContentDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new ContentRequestModels.ServerSetContentDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

			}

			public class AdminApi
			{
				public void createNewFileUploadInfo(ContentModels.AdminCreateNewFileUploadInfoRequestData requestData, Action<ContentResponseModels.CreateNewFileUploadInfoOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new ContentRequestModels.AdminCreateNewFileUploadInfoOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getContentData(ContentModels.AdminGetContentDataRequestData requestData, Action<ContentResponseModels.GetContentDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new ContentRequestModels.AdminGetContentDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getFileUploadInfoList(ContentModels.AdminGetFileUploadInfoListRequestData requestData, Action<ContentResponseModels.GetFileUploadInfoListOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new ContentRequestModels.AdminGetFileUploadInfoListOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getFileUploadInfo(ContentModels.AdminGetFileUploadInfoRequestData requestData, Action<ContentResponseModels.GetFileUploadInfoOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new ContentRequestModels.AdminGetFileUploadInfoOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeFileUploadInfo(ContentModels.AdminRemoveFileUploadInfoRequestData requestData, Action<ContentResponseModels.RemoveFileUploadInfoOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new ContentRequestModels.AdminRemoveFileUploadInfoOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void requestDownloadFileUploadInfo(ContentModels.AdminRequestDownloadFileUploadInfoRequestData requestData, Action<ContentResponseModels.RequestDownloadFileUploadInfoOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new ContentRequestModels.AdminRequestDownloadFileUploadInfoOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setContentData(ContentModels.AdminSetContentDataRequestData requestData, Action<ContentResponseModels.SetContentDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new ContentRequestModels.AdminSetContentDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

			}

		}

		public static ContentApi content { get; } = new ContentApi();
	}

}
