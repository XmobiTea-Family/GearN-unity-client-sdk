namespace XmobiTea.GN
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Entity.Response;

    using System;
    using XmobiTea.GN.Networking;
    using XmobiTea.GN.Constant;

    public static partial class GNNetwork
    {
        public static void SyncTs(Action<long> onResponse = null)
        {
            peer.SyncTs(onResponse);
        }

        public static void GetConfig(string configName, Action<string> onResponse)
        {
            peer.GetConfig(configName, onResponse);
        }

        public static void DownloadFile(string fileId, Action<HttpAppResponse> onHttpAppResponse)
        {
            peer.DownloadFile(fileId, onHttpAppResponse);
        }

        public static void UploadFile(string fileId, byte[] content, string mimeType, Action<HttpAppResponse> onHttpAppResponse)
        {
            peer.UploadFile(fileId, content, mimeType, onHttpAppResponse);
        }

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

        public static void DeviceLogin(Action<LoginOperationResponse> onResponse = null)
        {
            peer.DeviceLogin(onResponse);
        }

        public static void FacebookLogin(string facebookToken, Action<LoginOperationResponse> onResponse = null)
        {
            peer.FacebookLogin(facebookToken, onResponse);
        }

        public static void GoogleLogin(string googleToken, GoogleLoginType googleLoginType, Action<LoginOperationResponse> onResponse = null)
        {
            peer.GoogleLogin(googleToken, (int)googleLoginType, onResponse);
        }

        public static void AppleLogin(string appleToken, string displayName = null, Action<LoginOperationResponse> onResponse = null)
        {
            peer.AppleLogin(appleToken, displayName, onResponse);
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

        public static void CreateNewFileUploadInfo(string originFileName, Action<CreateNewFileUploadInfoOperationResponse> onResponse = null)
        {
            peer.CreateNewFileUploadInfo(originFileName, onResponse);
        }

        public static void GetFileUploadInfo(string fileId, Action<GetFileUploadInfoOperationResponse> onResponse = null)
        {
            peer.GetFileUploadInfo(fileId, onResponse);
        }

        public static void Logout(Action<LogoutOperationResponse> onResponse = null)
        {
            peer.Logout(onResponse);
        }
    }
}
