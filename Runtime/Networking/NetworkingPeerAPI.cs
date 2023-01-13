namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections;

    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity.Request;
    using XmobiTea.GN.Entity.Response;
    using XmobiTea.GN.Helper;

    public partial class NetworkingPeer
    {
        internal const string SYNC_TS = "ts";
        internal const string UPLOAD_FILE = "upload";
        internal const string DOWNLOAD_FILE = "upload";
        internal const string GET_CONFIG = "getConfig";
        internal const string API_JSON = "api/0";
        internal const string API_MSG_PACK = "api/1";

        internal void SyncTs(Action<long> onResponse = null)
        {
            (this.httpPeer as HttpPeer).GetRequest(SYNC_TS, httpAppResponse =>
            {
                if (!httpAppResponse.hasError)
                {
                    if (httpAppResponse.statusCode == 200)
                    {
                        var returnDatas = (IList)Parser.Parse(httpAppResponse.text);
                        var gnArray = new GNArray.Builder()
                            .AddAll(returnDatas)
                            .Build();

                        var returnCode = gnArray.GetInt(0);
                        if (returnCode == ReturnCode.Ok)
                        {
                            var gnHashtable = gnArray.GetGNHashtable(1);
                            var newServerTimestamp = gnHashtable.GetLong("1", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());

                            SetServerTimeMilliseconds(newServerTimestamp);
                        }
                    }
                }

                onResponse?.Invoke(serverTimestamp);
            });
        }

        internal void GetConfig(string configName, Action<string> onResponse)
        {
            (this.httpPeer as HttpPeer).GetRequest(GET_CONFIG + "/" + configName, httpAppResponse =>
            {
                if (!httpAppResponse.hasError)
                {
                    if (httpAppResponse.statusCode == 200)
                    {
                        var returnDatas = (IList)Parser.Parse(httpAppResponse.text);
                        var gnArray = new GNArray.Builder()
                            .AddAll(returnDatas)
                            .Build();

                        var returnCode = gnArray.GetInt(0);
                        if (returnCode == ReturnCode.Ok)
                        {
                            var gnHashtable = gnArray.GetGNHashtable(1);
                            var configStr = gnHashtable.GetString("1");

                            onResponse?.Invoke(configStr);
                        }
                    }
                }
            });
        }

        internal void DownloadFile(string fileId, Action<HttpAppResponse> onHttpAppResponse)
        {
            (this.httpPeer as HttpPeer).GetRequest(DOWNLOAD_FILE + "/" + fileId, onHttpAppResponse);
        }

        internal void UploadFile(string fileId, byte[] content, string mimeType, Action<HttpAppResponse> onHttpAppResponse)
        {
            (this.httpPeer as HttpPeer).UploadFile(fileId, content, mimeType, onHttpAppResponse);
        }

        internal void Debug(bool booleanValue, int numberValue, string stringValue, GNHashtable gnHashtableValue, GNArray gnArrayValue, Action<DebugOperationResponse> onResponse = null)
        {
            var request = new DebugOperationRequest(booleanValue, numberValue, stringValue, gnHashtableValue, gnArrayValue).Build();

            SendViaHttp(request, response =>
            {
                var debugOperationResponse = new DebugOperationResponse();
                debugOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(debugOperationResponse);
            });
        }

        internal void EnterDisplayName(string displayName, Action<EnterDisplayNameOperationResponse> onResponse = null)
        {
            var request = new EnterDisplayNameOperationRequest(displayName).Build();

            SendViaHttp(request, response =>
            {
                var enterDisplayNameOperationResponse = new EnterDisplayNameOperationResponse();
                enterDisplayNameOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(enterDisplayNameOperationResponse);
            });
        }

        internal void FetchAllData(Action<FetchAllDataOperationResponse> onResponse = null)
        {
            var request = new FetchAllDataOperationRequest().Build();

            SendViaHttp(request, response =>
            {
                var fetchAllDataOperationResponse = new FetchAllDataOperationResponse();
                fetchAllDataOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(fetchAllDataOperationResponse);
            });
        }

        internal void FetchSparkPlayer(Action<FetchSparkPlayerOperationResponse> onResponse = null)
        {
            var request = new FetchSparkPlayerOperationRequest().Build();

            SendViaHttp(request, response =>
            {
                var fetchSparkPlayerOperationResponse = new FetchSparkPlayerOperationResponse();
                fetchSparkPlayerOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(fetchSparkPlayerOperationResponse);
            });
        }

        internal void GetAppConfig(GNArray configTypes, Action<GetAppConfigOperationResponse> onResponse = null)
        {
            var request = new GetAppConfigOperationRequest(configTypes).Build();

            SendViaHttp(request, response =>
            {
                var getAppConfigOperationResponse = new GetAppConfigOperationResponse();
                getAppConfigOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(getAppConfigOperationResponse);
            });
        }

        internal void AccountLogin(string username, string password, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new AccountLoginOperationRequest(username, password).Build();

            SendViaHttp(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse();
                loginOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void DeviceLogin(Action<LoginOperationResponse> onResponse = null)
        {
            var request = new DeviceLoginOperationRequest(GNNetwork.deviceInfo).Build();

            SendViaHttp(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse();
                loginOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void FacebookLogin(string facebookToken, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new FacebookLoginOperationRequest(facebookToken).Build();

            SendViaHttp(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse();
                loginOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void GoogleLogin(string googleToken, int googleLoginType, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new GoogleLoginOperationRequest(googleToken, googleLoginType).Build();

            SendViaHttp(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse();
                loginOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void AppleLogin(string appleToken, string displayName, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new AppleLoginOperationRequest(appleToken, displayName).Build();

            SendViaHttp(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse();
                loginOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void UserIdLogin(string userId, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new UserIdLoginOperationRequest(userId).Build();

            SendViaHttp(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse();
                loginOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void PublicAddressLogin(string signature, string publicAddress, string message, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new PublicAddressLoginOperationRequest(signature, publicAddress, message).Build();

            SendViaHttp(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse();
                loginOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void PublicAddressGetRandomMessage(Action<PublicAddressGetRandomMessageOperationResponse> onResponse = null)
        {
            var request = new PublicAddressGetRandomMessageOperationRequest().Build();

            SendViaHttp(request, response =>
            {
                var publicAddressGetRandomMessageOperationResponse = new PublicAddressGetRandomMessageOperationResponse();
                publicAddressGetRandomMessageOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(publicAddressGetRandomMessageOperationResponse);
            });
        }

        internal void CustomIdLogin(string customId, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new CustomIdLoginOperationRequest(customId).Build();

            SendViaHttp(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse();
                loginOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void RegisterAccount(string username, string password, Action<RegisterAccountOperationResponse> onResponse = null)
        {
            var request = new RegisterAccountOperationRequest(username, password).Build();

            SendViaHttp(request, response =>
            {
                var registerAccountOperationResponse = new RegisterAccountOperationResponse();
                registerAccountOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(registerAccountOperationResponse);
            });
        }

        internal void RegisterSocket(string sid, Action<RegisterSocketOperationResponse> onResponse = null)
        {
            var request = new RegisterSocketOperationRequest(sid).Build();

            SendViaHttp(request, response =>
            {
                var registerSocketOperationResponse = new RegisterSocketOperationResponse();
                registerSocketOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(registerSocketOperationResponse);
            });
        }

        internal void Template(bool booleanValue, Action<TemplateOperationResponse> onResponse = null)
        {
            var request = new TemplateOperationRequest(booleanValue).Build();

            SendViaHttp(request, response =>
            {
                var templateOperationResponse = new TemplateOperationResponse();
                templateOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(templateOperationResponse);
            });
        }

        internal void CreateNewFileUploadInfo(string originFileName, Action<CreateNewFileUploadInfoOperationResponse> onResponse = null)
        {
            var request = new CreateNewFileUploadInfoOperationRequest(originFileName).Build();

            SendViaHttp(request, response =>
            {
                var createNewFileUploadInfoOperationResponse = new CreateNewFileUploadInfoOperationResponse();
                createNewFileUploadInfoOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(createNewFileUploadInfoOperationResponse);
            });
        }

        internal void GetFileUploadInfo(string fileId, Action<GetFileUploadInfoOperationResponse> onResponse = null)
        {
            var request = new GetFileUploadInfoOperationRequest(fileId).Build();

            SendViaHttp(request, response =>
            {
                var getFileUploadInfoOperationResponse = new GetFileUploadInfoOperationResponse();
                getFileUploadInfoOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(getFileUploadInfoOperationResponse);
            });
        }

        internal void Logout(Action<LogoutOperationResponse> onResponse = null)
        {
            var request = new LogoutOperationRequest().Build();

            SendViaHttp(request, response =>
            {
                var logoutOperationResponse = new LogoutOperationResponse();
                logoutOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(logoutOperationResponse);
            });
        }

    }

}
