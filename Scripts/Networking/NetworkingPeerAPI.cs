namespace XmobiTea.GN.Networking
{
    using System;

    using XmobiTea.GN.Common;
    using XmobiTea.GN.Entity.Request;
    using XmobiTea.GN.Entity.Response;

    public partial class NetworkingPeer
    {
        internal void Debug(bool booleanValue, int numberValue, string stringValue, GNHashtable gnHashtableValue, GNArray gnArrayValue, Action<DebugOperationResponse> onResponse = null)
        {
            var request = new DebugOperationRequest(booleanValue, numberValue, stringValue, gnHashtableValue, gnArrayValue).Builder();

            HttpSend(request, response =>
            {
                var debugOperationResponse = new DebugOperationResponse(response);
                onResponse?.Invoke(debugOperationResponse);
            });
        }

        internal void EnterDisplayName(string displayName, Action<EnterDisplayNameOperationResponse> onResponse = null)
        {
            var request = new EnterDisplayNameOperationRequest(displayName).Builder();

            HttpSend(request, response =>
            {
                var enterDisplayNameOperationResponse = new EnterDisplayNameOperationResponse(response);
                onResponse?.Invoke(enterDisplayNameOperationResponse);
            });
        }

        internal void FetchAllData(Action<FetchAllDataOperationResponse> onResponse = null)
        {
            var request = new FetchAllDataOperationRequest().Builder();

            HttpSend(request, response =>
            {
                var fetchAllDataOperationResponse = new FetchAllDataOperationResponse(response);
                onResponse?.Invoke(fetchAllDataOperationResponse);
            });
        }

        internal void GetAppConfig(GNArray configTypes, Action<GetAppConfigOperationResponse> onResponse = null)
        {
            var request = new GetAppConfigOperationRequest(configTypes).Builder();

            HttpSend(request, response =>
            {
                var getAppConfigOperationResponse = new GetAppConfigOperationResponse(response);
                onResponse?.Invoke(getAppConfigOperationResponse);
            });
        }

        internal void AccountLogin(string username, string password, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new AccountLoginOperationRequest(username, password).Builder();

            HttpSend(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse(response);
                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void DeviceLogin(string deviceInfo, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new DeviceLoginOperationRequest(deviceInfo).Builder();

            SocketSend(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse(response);
                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void FacebookLogin(string facebookToken, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new FacebookLoginOperationRequest(facebookToken).Builder();

            HttpSend(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse(response);
                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void GoogleLogin(string googleToken, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new GoogleLoginOperationRequest(googleToken).Builder();

            HttpSend(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse(response);
                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void AppleLogin(string appleToken, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new AppleLoginOperationRequest(appleToken).Builder();

            HttpSend(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse(response);
                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void UserIdLogin(string userId, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new UserIdLoginOperationRequest(userId).Builder();

            HttpSend(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse(response);
                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void PublicAddressLogin(string signature, string publicAddress, string message, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new PublicAddressLoginOperationRequest(signature, publicAddress, message).Builder();

            HttpSend(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse(response);
                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void PublicAddressGetRandomMessage(Action<PublicAddressGetRandomMessageOperationResponse> onResponse = null)
        {
            var request = new PublicAddressGetRandomMessageOperationRequest().Builder();

            HttpSend(request, response =>
            {
                var publicAddressGetRandomMessageOperationResponse = new PublicAddressGetRandomMessageOperationResponse(response);
                onResponse?.Invoke(publicAddressGetRandomMessageOperationResponse);
            });
        }

        internal void CustomIdLogin(string customId, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new CustomIdLoginOperationRequest(customId).Builder();

            HttpSend(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse(response);
                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void RegisterAccount(string username, string password, Action<RegisterAccountOperationResponse> onResponse = null)
        {
            var request = new RegisterAccountOperationRequest(username, password).Builder();

            HttpSend(request, response =>
            {
                var registerAccountOperationResponse = new RegisterAccountOperationResponse(response);
                onResponse?.Invoke(registerAccountOperationResponse);
            });
        }

        internal void RegisterSocket(string sid, Action<RegisterSocketOperationResponse> onResponse = null)
        {
            var request = new RegisterSocketOperationRequest(sid).Builder();

            HttpSend(request, response =>
            {
                var registerSocketOperationResponse = new RegisterSocketOperationResponse(response);
                onResponse?.Invoke(registerSocketOperationResponse);
            });
        }

        internal void Template(bool booleanValue, Action<TemplateOperationResponse> onResponse = null)
        {
            var request = new TemplateOperationRequest(booleanValue).Builder();

            HttpSend(request, response =>
            {
                var templateOperationResponse = new TemplateOperationResponse(response);
                onResponse?.Invoke(templateOperationResponse);
            });
        }
    }
}
