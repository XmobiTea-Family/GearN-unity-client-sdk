namespace XmobiTea.GN
{
    using XmobiTea.GN.Networking;
    using XmobiTea.GN.Config;

    using System;

    using UnityEngine;
    using XmobiTea.GN.Entity;
    using XmobiTea.MiniDeviceId;
    using XmobiTea.GN.Logger;
    using XmobiTea.GN.Entity.Request;
    using XmobiTea.GN.Entity.Response;

    public static partial class GNNetwork
    {
        private const string GN_VERSION = "1.0.7";

        private const string AUTH_TOKEN_KEY = "[GN]_AUTH_TOKEN_KEY";
        private const string USER_ID_KEY = "[GN]_USER_ID_KEY";

        public static GNServerSettings gnServerSettings { get; private set; }

        internal static NetworkingPeer peer { get; private set; }

        public static int ping => peer != null ? peer.ping : -1;

        public static string getSocketSId() => peer != null ? peer.clientId : null;

        public static bool isSocketConnected() => !string.IsNullOrEmpty(getSocketSId());

        public static long serverTimestamp => peer != null ? peer.serverTimestamp : DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

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

        public static RuntimePlatform platform { get; private set; }

        public static string deviceId { get; private set; }

        public static string deviceInfo => (int)platform + "_" + deviceId;

        static GNNetwork()
        {
            InitServerSettings();
            InitGNDebug();

            if (!Application.isPlaying) return;

            InitGNSocketObject();

            peer.authToken = PlayerPrefs.GetString(AUTH_TOKEN_KEY, string.Empty);
            peer.userId = PlayerPrefs.GetString(USER_ID_KEY, string.Empty);

            platform = Application.platform;
            deviceId = CXDevice.GetDeviceId();
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

        public static void SendViaSocket(OperationRequest request, Action<OperationResponse> onResponse = null)
        {
            peer.SendViaSocket(request, onResponse);
        }

        public static void SendViaHttp(OperationRequest request, Action<OperationResponse> onResponse = null)
        {
            peer.SendViaHttp(request, onResponse);
        }

        public static void SendViaSocket<TRequest, TResponse>(TRequest request, Action<TResponse> onResponse = null) where TRequest : CustomOperationRequest where TResponse : CustomOperationResponse, new()
        {
            SendViaSocket(request.Build(), onResponse);
        }

        public static void SendViaHttp<TRequest, TResponse>(TRequest request, Action<TResponse> onResponse = null) where TRequest : CustomOperationRequest where TResponse : CustomOperationResponse, new()
        {
            SendViaHttp(request.Build(), onResponse);
        }

        public static void SendViaSocket<TResponse>(OperationRequest request, Action<TResponse> onResponse = null) where TResponse : CustomOperationResponse, new()
        {
            SendViaSocket(request, response =>
            {
                if (response == null) return;

                var customOperationResponse = new TResponse() { };
                customOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(customOperationResponse);
            });
        }

        public static void SendViaHttp<TResponse>(OperationRequest request, Action<TResponse> onResponse = null) where TResponse : CustomOperationResponse, new()
        {
            SendViaHttp(request, response =>
            {
                if (response == null) return;

                var customOperationResponse = new TResponse() { };
                customOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(customOperationResponse);
            });
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
