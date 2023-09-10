namespace XmobiTea.GN
{
    using System;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Entity.Models;

    public static partial class GNNetwork
    {
		public class AuthenticateApi
		{
			public ServerApi server { get; } = new ServerApi();

			public AdminApi admin { get; } = new AdminApi();

			public void loginByAccount(AuthenticateModels.LoginByAccountRequestData requestData, Action<AuthenticateResponseModels.LoginByAccountOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByAccountOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void loginByAndroidDeviceId(AuthenticateModels.LoginByAndroidDeviceIdRequestData requestData, Action<AuthenticateResponseModels.LoginByAndroidDeviceIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByAndroidDeviceIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void loginByApple(AuthenticateModels.LoginByAppleRequestData requestData, Action<AuthenticateResponseModels.LoginByAppleOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByAppleOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void loginByCustomDeviceId(AuthenticateModels.LoginByCustomDeviceIdRequestData requestData, Action<AuthenticateResponseModels.LoginByCustomDeviceIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByCustomDeviceIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void loginByCustomId(AuthenticateModels.LoginByCustomIdRequestData requestData, Action<AuthenticateResponseModels.LoginByCustomIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByCustomIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void loginByEditorDeviceId(AuthenticateModels.LoginByEditorDeviceIdRequestData requestData, Action<AuthenticateResponseModels.LoginByEditorDeviceIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByEditorDeviceIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void loginByFacebook(AuthenticateModels.LoginByFacebookRequestData requestData, Action<AuthenticateResponseModels.LoginByFacebookOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByFacebookOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void loginByGenericService(AuthenticateModels.LoginByGenericServiceRequestData requestData, Action<AuthenticateResponseModels.LoginByGenericServiceOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByGenericServiceOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void loginByGoogle(AuthenticateModels.LoginByGoogleRequestData requestData, Action<AuthenticateResponseModels.LoginByGoogleOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByGoogleOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void loginByiOSDeviceId(AuthenticateModels.LoginByiOSDeviceIdRequestData requestData, Action<AuthenticateResponseModels.LoginByiOSDeviceIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByiOSDeviceIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void loginByLinuxDeviceId(AuthenticateModels.LoginByLinuxDeviceIdRequestData requestData, Action<AuthenticateResponseModels.LoginByLinuxDeviceIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByLinuxDeviceIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void loginByMacOSDeviceId(AuthenticateModels.LoginByMacOSDeviceIdRequestData requestData, Action<AuthenticateResponseModels.LoginByMacOSDeviceIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByMacOSDeviceIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void loginByWindowsDeviceId(AuthenticateModels.LoginByWindowsDeviceIdRequestData requestData, Action<AuthenticateResponseModels.LoginByWindowsDeviceIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByWindowsDeviceIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void loginByWindowsPhoneDeviceId(AuthenticateModels.LoginByWindowsPhoneDeviceIdRequestData requestData, Action<AuthenticateResponseModels.LoginByWindowsPhoneDeviceIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByWindowsPhoneDeviceIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void registerAccount(AuthenticateModels.RegisterAccountRequestData requestData, Action<AuthenticateResponseModels.RegisterAccountOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new AuthenticateRequestModels.RegisterAccountOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}


			public class ServerApi
			{
			}

			public class AdminApi
			{
			}

		}

		public static AuthenticateApi authenticate { get; } = new AuthenticateApi();
    }

}
