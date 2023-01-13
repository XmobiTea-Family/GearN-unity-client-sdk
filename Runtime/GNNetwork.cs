namespace XmobiTea.GN
{
    using XmobiTea.GN.Networking;
    using XmobiTea.GN.Config;

    using System;

    using UnityEngine;
    using XmobiTea.GN.Entity;
    using XmobiTea.MiniDeviceId;
    using XmobiTea.GN.Logger;

    public static partial class GNNetwork
    {
        public const string version = "1.0.0";

        internal const string AUTH_TOKEN_KEY = "AUTH_TOKEN_KEY";

        public static GNServerSettings gnServerSettings { get; private set; }

        internal static NetworkingPeer peer { get; private set; }

        public static int ping => peer != null ? peer.ping : -1;

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

        public static RuntimePlatform platform { get; private set; }

        public static string deviceId { get; private set; }

        public static string deviceInfo => (int)platform + "_" + deviceId;

        static GNNetwork()
        {
            InitServerSettings();
            InitEUNDebug();

            if (!Application.isPlaying) return;

            InitGNSocketObject();

            peer.authToken = PlayerPrefs.GetString(AUTH_TOKEN_KEY, string.Empty);

            platform = Application.platform;
            deviceId = CXDevice.GetDeviceId();
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

        private static void InitEUNDebug()
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

        public static void ConnectSocket()
        {
            peer.ConnectSocket();
        }

        public static void DisconnectSocket()
        {
            peer.DisconnectSocket();
        }
    }
}
