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
        private const string GN_VERSION = "2.0";

        internal const string AUTH_TOKEN_KEY = "[GN]_AUTH_TOKEN_KEY";
        internal const string AUTH_TOKEN_TS_EXPIRE_KEY = "[GN]_AUTH_TOKEN_TS_EXPIRE_KEY";
        internal const string USER_ID_KEY = "[GN]_USER_ID_KEY";

        public static GNServerSettings gnServerSettings { get; private set; }

        internal static NetworkingPeer peer { get; private set; }

        public static int getPing() => GNNetwork.peer != null ? GNNetwork.peer.getPing() : -1;

        public static string getSocketSId() => GNNetwork.peer != null ? GNNetwork.peer.getClientId() : null;

        public static bool isSocketConnected() => !string.IsNullOrEmpty(GNNetwork.getSocketSId());

        public static long getServerTimestamp() => GNNetwork.peer != null ? GNNetwork.peer.getServerTimestamp() : DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        public static AuthenticateStatus getAuthenticateStatus() => GNNetwork.peer.authenticateStatus;

        public static RuntimePlatform getPlatform() => Application.platform;

        static GNNetwork()
        {
            GNNetwork.initServerSettings();
            GNNetwork.initGNDebug();

            if (!Application.isPlaying) return;

            GNDebug.log("GNNetwork init on unity. Version: " + GNNetwork.getClientSdkVersion());

            GNNetwork.initGNSocketObject();

            GNNetwork.peer.authenticateStatus.setAuthToken(PlayerPrefs.GetString(GNNetwork.AUTH_TOKEN_KEY, string.Empty));
            GNNetwork.peer.authenticateStatus.setAuthTokenTsExpire(long.Parse(PlayerPrefs.GetString(GNNetwork.AUTH_TOKEN_TS_EXPIRE_KEY, "-1")));
            GNNetwork.peer.authenticateStatus.setUserId(PlayerPrefs.GetString(GNNetwork.USER_ID_KEY, string.Empty));

            GNNetwork.authenticate = new AuthenticateApi();
            GNNetwork.characterPlayer = new CharacterPlayerApi();
            GNNetwork.content = new ContentApi();
            GNNetwork.dashboard = new DashboardApi();
            GNNetwork.gamePlayer = new GamePlayerApi();
            GNNetwork.group = new GroupApi();
            GNNetwork.inventory = new InventoryApi();
            GNNetwork.masterPlayer = new MasterPlayerApi();
            GNNetwork.storeInventory = new StoreInventoryApi();
        }

        public static string getClientSdkVersion() => GNNetwork.GN_VERSION;

        private static void initServerSettings()
        {
            GNNetwork.gnServerSettings = Resources.Load(GNServerSettings.ResourcesPath) as GNServerSettings;
            if (GNNetwork.gnServerSettings == null)
            {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.ExecuteMenuItem("XmobiTea GN/Open Settings");
                GNNetwork.gnServerSettings = Resources.Load(GNServerSettings.ResourcesPath) as GNServerSettings;
                if (GNNetwork.gnServerSettings == null) throw new NullReferenceException("Null GN Server Settings, please find it now");
#endif
            }
        }

        private static void initGNDebug()
        {
            if (GNNetwork.gnServerSettings == null) throw new NullReferenceException("Null EUN Server Settings, please find it now");

            GNDebug.logType = GNNetwork.gnServerSettings.getLogType();
        }

        private static void initGNSocketObject()
        {
            var peer = new NetworkingPeer();

            peer.initPeer();

            GNNetwork.peer = peer;

            var serviceUpdate = new GameObject("[GN] ServiceUpdate").AddComponent<Unity.ServiceUpdate>();
            GameObject.DontDestroyOnLoad(serviceUpdate.gameObject);

            serviceUpdate.peer = peer;
        }

        public static void sendViaSocket(RequestType requestType, RequestRole requestRole, OperationRequest request, Action<OperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null)
        {
            GNNetwork.peer.sendViaSocket(requestType, requestRole, request, onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public static void sendViaHttp(RequestType requestType, RequestRole requestRole, OperationRequest request, Action<OperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null)
        {
            GNNetwork.peer.sendViaHttp(requestType, requestRole, request, onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public static void sendViaSocket<TRequest, TResponse>(TRequest request, Action<TResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null) where TRequest : CustomOperationRequest where TResponse : CustomOperationResponse, new()
        {
            GNNetwork.sendViaSocket(request.getRequestType(), request.getRequestRole(), request.build(), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public static void sendViaHttp<TRequest, TResponse>(TRequest request, Action<TResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null) where TRequest : CustomOperationRequest where TResponse : CustomOperationResponse, new()
        {
            GNNetwork.sendViaHttp(request.getRequestType(), request.getRequestRole(), request.build(), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public static void sendViaSocket<TResponse>(RequestType requestType, RequestRole requestRole, OperationRequest request, Action<TResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null) where TResponse : CustomOperationResponse, new()
        {
            GNNetwork.sendViaSocket(requestType, requestRole, request, response =>
            {
                if (response == null) return;

                var customOperationResponse = new TResponse() { };
                customOperationResponse.setupOperationResponse(response);

                onResponse?.Invoke(customOperationResponse);
            }, overrideAuthToken, overrideSecretKey, customTags);
        }

        public static void sendViaHttp<TResponse>(RequestType requestType, RequestRole requestRole, OperationRequest request, Action<TResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null) where TResponse : CustomOperationResponse, new()
        {
            GNNetwork.sendViaHttp(requestType, requestRole, request, response =>
            {
                if (response == null) return;

                var customOperationResponse = new TResponse() { };
                customOperationResponse.setupOperationResponse(response);

                onResponse?.Invoke(customOperationResponse);
            }, overrideAuthToken, overrideSecretKey, customTags);
        }

        public static void connectSocket(Action _onSocketConnect = null)
        {
            GNNetwork.peer.connectSocket(_onSocketConnect);
        }

        public static void disconnectSocket(Action _onSocketDisconnect = null)
        {
            GNNetwork.peer.disconnectSocket(_onSocketDisconnect);
        }

        public static void setOnEventHandler(Action<OperationEvent> _onEventHandler)
        {
            GNNetwork.peer.setOnEventHandler(_onEventHandler);
        }

        public static void subscriberOnConnectHandler(Action onConnectHandler)
        {
            GNNetwork.peer.setOnConnectHandler(onConnectHandler);
        }

        public static void subscriberOnDisconnectHandler(Action onDisconnectHandler)
        {
            GNNetwork.peer.setOnDisconnectHandler(onDisconnectHandler);
        }

        public static void unscriberOnConnectHandler(Action onConnectHandler)
        {
            GNNetwork.peer.removeOnConnectHandler(onConnectHandler);
        }

        public static void unsubscriberOnDisconnectHandler(Action onDisconnectHandler)
        {
            GNNetwork.peer.removeOnDisconnectHandler(onDisconnectHandler);
        }

    }

}
