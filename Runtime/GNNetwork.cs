namespace XmobiTea.GN
{
    using XmobiTea.GN.Networking;
    using XmobiTea.GN.Config;

    using System;

    using UnityEngine;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Logger;
    using XmobiTea.GN.Entity.Request;
    using XmobiTea.GN.Entity.Response;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Common;

    public static partial class GNNetwork
    {
        private const string GN_VERSION = "0.0.1";

        private const string AUTH_TOKEN_KEY = "[GN]_AUTH_TOKEN_KEY";
        private const string AUTH_TOKEN_TS_EXPIRE_KEY = "[GN]_AUTH_TOKEN_TS_EXPIRE_KEY";
        private const string USER_ID_KEY = "[GN]_USER_ID_KEY";

        public static GNServerSettings gnServerSettings { get; private set; }

        internal static NetworkingPeer peer { get; private set; }

        public static int getPing() => peer != null ? peer.ping : -1;

        public static string getSocketSId() => peer != null ? peer.getClientId() : null;

        public static bool isSocketConnected() => !string.IsNullOrEmpty(getSocketSId());

        public static long getServerTimestamp() => peer != null ? peer.serverTimestamp : DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        public static AuthenticateStatus getAuthenticateStatus() => peer.authenticateStatus;

        public static string authToken
        {
            get { return peer.authToken; }
            set
            {
                peer.authToken = value;

                PlayerPrefs.SetString(GNNetwork.AUTH_TOKEN_KEY, value);

                peer.SendRequestAuthSocket();
            }
        }

        public static string userId
        {
            get { return peer.userId; }
            set
            {
                peer.userId = value;

                PlayerPrefs.SetString(GNNetwork.USER_ID_KEY, value);
            }
        }

        public static RuntimePlatform getPlatform() => Application.platform;

        static GNNetwork()
        {
            InitServerSettings();
            InitGNDebug();

            if (!Application.isPlaying) return;

            InitGNSocketObject();

            peer.authenticateStatus.setAuthToken(PlayerPrefs.GetString(GNNetwork.AUTH_TOKEN_KEY, string.Empty));
            peer.authenticateStatus.setAuthTokenTsExpire(long.Parse(PlayerPrefs.GetString(GNNetwork.AUTH_TOKEN_TS_EXPIRE_KEY, "-1")));
            peer.authenticateStatus.setUserId(PlayerPrefs.GetString(GNNetwork.USER_ID_KEY, string.Empty));
        }

        public static string GetClientSdkVersion()
        {
            return GN_VERSION;
        }

        private static void InitServerSettings()
        {
            gnServerSettings = Resources.Load(GNServerSettings.ResourcesPath) as GNServerSettings;
            if (gnServerSettings == null)
            {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.ExecuteMenuItem("XmobiTea GN/Open Settings");
                gnServerSettings = Resources.Load(GNServerSettings.ResourcesPath) as GNServerSettings;
                if (gnServerSettings == null) throw new NullReferenceException("Null GN Server Settings, please find it now");
#endif
            }
        }

        private static void InitGNDebug()
        {
            if (gnServerSettings == null) throw new NullReferenceException("Null EUN Server Settings, please find it now");

            GNDebug.logType = gnServerSettings.logType;
        }

        private static void InitGNSocketObject()
        {
            peer = new GameObject("GN NetworkingPeer").AddComponent<NetworkingPeer>();
            GameObject.DontDestroyOnLoad(peer.gameObject);

            peer.InitPeer();
        }

        public static void SendViaSocket(RequestType requestType, RequestRole requestRole, OperationRequest request, Action<OperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null)
        {
            peer.SendViaSocket(requestType, requestRole, request, onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public static void SendViaHttp(RequestType requestType, RequestRole requestRole, OperationRequest request, Action<OperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null)
        {
            peer.SendViaHttp(requestType, requestRole, request, onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public static void SendViaSocket<TRequest, TResponse>(TRequest request, Action<TResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null) where TRequest : CustomOperationRequest where TResponse : CustomOperationResponse, new()
        {
            SendViaSocket(request.GetRequestType(), request.GetRequestRole(), request.Build(), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public static void SendViaHttp<TRequest, TResponse>(TRequest request, Action<TResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null) where TRequest : CustomOperationRequest where TResponse : CustomOperationResponse, new()
        {
            SendViaHttp(request.GetRequestType(), request.GetRequestRole(), request.Build(), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public static void SendViaSocket<TResponse>(RequestType requestType, RequestRole requestRole, OperationRequest request, Action<TResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null) where TResponse : CustomOperationResponse, new()
        {
            SendViaSocket(requestType, requestRole, request, response =>
            {
                if (response == null) return;

                var customOperationResponse = new TResponse() { };
                customOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(customOperationResponse);
            }, overrideAuthToken, overrideSecretKey, customTags);
        }

        public static void SendViaHttp<TResponse>(RequestType requestType, RequestRole requestRole, OperationRequest request, Action<TResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null) where TResponse : CustomOperationResponse, new()
        {
            SendViaHttp(requestType, requestRole, request, response =>
            {
                if (response == null) return;

                var customOperationResponse = new TResponse() { };
                customOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(customOperationResponse);
            }, overrideAuthToken, overrideSecretKey, customTags);
        }

        public static void ConnectSocket(Action _onSocketConnect = null)
        {
            peer.ConnectSocket(_onSocketConnect);
        }

        public static void DisconnectSocket(Action _onSocketDisconnect = null)
        {
            peer.DisconnectSocket(_onSocketDisconnect);
        }

        public static void SetOnEventHandler(Action<OperationEvent> _onEventHandler)
        {
            peer.SetOnEventHandler(_onEventHandler);
        }

        public static void SubscriberOnConnectHandler(Action onConnectHandler)
        {
            peer.SetOnConnectHandler(onConnectHandler);
        }

        public static void SubscriberOnDisconnectHandler(Action onDisconnectHandler)
        {
            peer.SetOnDisconnectHandler(onDisconnectHandler);
        }

        public static void UnscriberOnConnectHandler(Action onConnectHandler)
        {
            peer.RemoveOnConnectHandler(onConnectHandler);
        }

        public static void UnsubscriberOnDisconnectHandler(Action onDisconnectHandler)
        {
            peer.RemoveOnDisconnectHandler(onDisconnectHandler);
        }

    }

}
