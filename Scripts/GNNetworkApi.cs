namespace XmobiTea.GN
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Entity.Response;

    using System;

    public static partial class GNNetwork
    {
        public static void Debug(bool booleanValue, int numberValue, string stringValue, GNHashtable gnHashtableValue, GNArray gnArrayValue, Action<DebugOperationResponse> onResponse = null)
        {
            peer.Debug(booleanValue, numberValue, stringValue, gnHashtableValue, gnArrayValue, onResponse);
        }

        public static void EnterDisplayName(string displayName, Action<EnterDisplayNameOperationResponse> onResponse = null)
        {
            peer.EnterDisplayName(displayName, onResponse);
        }

        public static void FetchAllData(Action<FetchAllDataOperationResponse> onResponse = null)
        {
            peer.FetchAllData(onResponse);
        }

        public static void GetAppConfig(GNArray configTypes, Action<GetAppConfigOperationResponse> onResponse = null)
        {
            peer.GetAppConfig(configTypes, onResponse);
        }

        public static void AccountLogin(string username, string password, Action<LoginOperationResponse> onResponse = null)
        {
            peer.AccountLogin(username, password, onResponse);
        }

        public static void DeviceLogin(string deviceInfo, Action<LoginOperationResponse> onResponse = null)
        {
            peer.DeviceLogin(deviceInfo, onResponse);
        }

        public static void FacebookLogin(string facebookToken, Action<LoginOperationResponse> onResponse = null)
        {
            peer.FacebookLogin(facebookToken, onResponse);
        }

        public static void GoogleLogin(string googleToken, Action<LoginOperationResponse> onResponse = null)
        {
            peer.GoogleLogin(googleToken, onResponse);
        }

        public static void AppleLogin(string appleToken, Action<LoginOperationResponse> onResponse = null)
        {
            peer.GoogleLogin(appleToken, onResponse);
        }

        public static void UserIdLogin(string userId, Action<LoginOperationResponse> onResponse = null)
        {
            peer.UserIdLogin(userId, onResponse);
        }

        public static void PublicAddressLogin(string signature, string publicAddress, string message, Action<LoginOperationResponse> onResponse = null)
        {
            peer.PublicAddressLogin(signature, publicAddress, message, onResponse);
        }

        public static void PublicAddressGetRandomMessage(Action<PublicAddressGetRandomMessageOperationResponse> onResponse = null)
        {
            peer.PublicAddressGetRandomMessage(onResponse);
        }

        public static void CustomIdLogin(string customId, Action<LoginOperationResponse> onResponse = null)
        {
            peer.CustomIdLogin(customId, onResponse);
        }

        public static void RegisterAccount(string username, string password, Action<RegisterAccountOperationResponse> onResponse = null)
        {
            peer.RegisterAccount(username, password, onResponse);
        }

        public static void RegisterSocket(string sid, Action<RegisterSocketOperationResponse> onResponse = null)
        {
            peer.RegisterSocket(sid, onResponse);
        }

        public static void Template(bool booleanValue, Action<TemplateOperationResponse> onResponse = null)
        {
            peer.Template(booleanValue, onResponse);
        }
    }
}
