namespace XmobiTea.GN
{
	using System;
	using XmobiTea.GN.Common;
	using XmobiTea.GN.Entity;
	using XmobiTea.GN.Entity.Models;

	public static partial class GNNetwork
	{
		public class DashboardApi
		{
			public ServerApi server { get; } = new ServerApi();

			public AdminApi admin { get; } = new AdminApi();

			public void changePasswordAdminAccount(DashboardModels.ChangePasswordAdminAccountRequestData requestData, Action<DashboardResponseModels.ChangePasswordAdminAccountOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.ChangePasswordAdminAccountOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getAdminAccountList(DashboardModels.GetAdminAccountListRequestData requestData, Action<DashboardResponseModels.GetAdminAccountListOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.GetAdminAccountListOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getGameInformation(DashboardModels.GetGameInformationRequestData requestData, Action<DashboardResponseModels.GetGameInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.GetGameInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getGameList(DashboardModels.GetGameListRequestData requestData, Action<DashboardResponseModels.GetGameListOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.GetGameListOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getMasterGameSettings(DashboardModels.GetMasterGameSettingsRequestData requestData, Action<DashboardResponseModels.GetMasterGameSettingsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.GetMasterGameSettingsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getSecretInfoInformation(DashboardModels.GetSecretInfoInformationRequestData requestData, Action<DashboardResponseModels.GetSecretInfoInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.GetSecretInfoInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getSecretInfoList(DashboardModels.GetSecretInfoListRequestData requestData, Action<DashboardResponseModels.GetSecretInfoListOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.GetSecretInfoListOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getServerLog(DashboardModels.GetServerLogRequestData requestData, Action<DashboardResponseModels.GetServerLogOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.GetServerLogOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void grantAdminAccount(DashboardModels.GrantAdminAccountRequestData requestData, Action<DashboardResponseModels.GrantAdminAccountOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.GrantAdminAccountOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void grantGame(DashboardModels.GrantGameRequestData requestData, Action<DashboardResponseModels.GrantGameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.GrantGameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void grantSecretInfo(DashboardModels.GrantSecretInfoRequestData requestData, Action<DashboardResponseModels.GrantSecretInfoOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.GrantSecretInfoOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void loginByAdminAccount(DashboardModels.LoginByAdminAccountRequestData requestData, Action<DashboardResponseModels.LoginByAdminAccountOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.LoginByAdminAccountOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeAdminAccount(DashboardModels.RemoveAdminAccountRequestData requestData, Action<DashboardResponseModels.RemoveAdminAccountOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.RemoveAdminAccountOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setGameInformation(DashboardModels.SetGameInformationRequestData requestData, Action<DashboardResponseModels.SetGameInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.SetGameInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setMasterGameSettings(DashboardModels.SetMasterGameSettingsRequestData requestData, Action<DashboardResponseModels.SetMasterGameSettingsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.SetMasterGameSettingsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPasswordAdminAccount(DashboardModels.SetPasswordAdminAccountRequestData requestData, Action<DashboardResponseModels.SetPasswordAdminAccountOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.SetPasswordAdminAccountOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setSecretInfoInformation(DashboardModels.SetSecretInfoInformationRequestData requestData, Action<DashboardResponseModels.SetSecretInfoInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.SetSecretInfoInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setSecretKeyAdminAccount(DashboardModels.SetSecretKeyAdminAccountRequestData requestData, Action<DashboardResponseModels.SetSecretKeyAdminAccountOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new DashboardRequestModels.SetSecretKeyAdminAccountOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}


			public class ServerApi
			{
			}

			public class AdminApi
			{
			}

		}

		public static DashboardApi dashboard { get; } = new DashboardApi();
	}

}
