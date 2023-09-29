namespace XmobiTea.GN
{
    using System;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Entity.Models;

	public class AuthenticateApi
	{
		public ServerApi server { get; } = new ServerApi();

		public AdminApi admin { get; } = new AdminApi();

		public void loginByAccount(AuthenticateModels.LoginByAccountRequestData requestData, Action<AuthenticateResponseModels.LoginByAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void loginByAndroidDeviceId(AuthenticateModels.LoginByAndroidDeviceIdRequestData requestData, Action<AuthenticateResponseModels.LoginByAndroidDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByAndroidDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void loginByApple(AuthenticateModels.LoginByAppleRequestData requestData, Action<AuthenticateResponseModels.LoginByAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void loginByCustomDeviceId(AuthenticateModels.LoginByCustomDeviceIdRequestData requestData, Action<AuthenticateResponseModels.LoginByCustomDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByCustomDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void loginByCustomId(AuthenticateModels.LoginByCustomIdRequestData requestData, Action<AuthenticateResponseModels.LoginByCustomIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByCustomIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void loginByEditorDeviceId(AuthenticateModels.LoginByEditorDeviceIdRequestData requestData, Action<AuthenticateResponseModels.LoginByEditorDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByEditorDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void loginByFacebook(AuthenticateModels.LoginByFacebookRequestData requestData, Action<AuthenticateResponseModels.LoginByFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void loginByGenericService(AuthenticateModels.LoginByGenericServiceRequestData requestData, Action<AuthenticateResponseModels.LoginByGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void loginByGoogle(AuthenticateModels.LoginByGoogleRequestData requestData, Action<AuthenticateResponseModels.LoginByGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void loginByiOSDeviceId(AuthenticateModels.LoginByiOSDeviceIdRequestData requestData, Action<AuthenticateResponseModels.LoginByiOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByiOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void loginByLinuxDeviceId(AuthenticateModels.LoginByLinuxDeviceIdRequestData requestData, Action<AuthenticateResponseModels.LoginByLinuxDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByLinuxDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void loginByMacOSDeviceId(AuthenticateModels.LoginByMacOSDeviceIdRequestData requestData, Action<AuthenticateResponseModels.LoginByMacOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByMacOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void loginByWindowsDeviceId(AuthenticateModels.LoginByWindowsDeviceIdRequestData requestData, Action<AuthenticateResponseModels.LoginByWindowsDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByWindowsDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void loginByWindowsPhoneDeviceId(AuthenticateModels.LoginByWindowsPhoneDeviceIdRequestData requestData, Action<AuthenticateResponseModels.LoginByWindowsPhoneDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByWindowsPhoneDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void registerAccount(AuthenticateModels.RegisterAccountRequestData requestData, Action<AuthenticateResponseModels.RegisterAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new AuthenticateRequestModels.RegisterAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}


		public class ServerApi
		{
		}

		public class AdminApi
		{
		}

	}

	public static partial class GNNetwork
    {

		public static AuthenticateApi authenticate { get; }
    }

}
