namespace XmobiTea.GN
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Networking;
    using XmobiTea.GN.Config;

    using System;

    using UnityEngine;
    using XmobiTea.GN.Entity;

    public static partial class GNNetwork
    {
        public const string Version = "1.0.1";

        public static GNServerSettings gnServerSettings { get; private set; }

        internal static NetworkingPeer peer { get; private set; }

        public static int ping => peer != null ? peer.Ping : -1;

        public static long serverTimestamp => peer != null ? peer.serverTimestamp : DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        public static string authToken
        {
            get { return peer.authToken; }
            set
            {
                peer.authToken = value;

                peer.SendRequestAuthSocket();
            }
        }

        static GNNetwork()
        {
            InitServerSettings();

            if (!Application.isPlaying) return;

            InitGNSocketObject();
        }

        private static void InitServerSettings()
        {
            gnServerSettings = Resources.Load(GNServerSettings.ResourcesPath) as GNServerSettings;
            if (gnServerSettings == null)
            {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.ExecuteMenuItem("GN/GN Settings");
                gnServerSettings = Resources.Load(GNServerSettings.ResourcesPath) as GNServerSettings;
                if (gnServerSettings == null) throw new NullReferenceException("Null GN Server Settings, please find it now");
#endif
            }
        }

        private static void InitGNSocketObject()
        {
            peer = new GameObject("GN NetworkingPeer").AddComponent<NetworkingPeer>();
            GameObject.DontDestroyOnLoad(peer.gameObject);

            peer.InitPeer();
        }

        public static void SocketSend(OperationRequest request, Action<OperationResponse> onResponse = null)
        {
            peer.SocketSend(request, onResponse);
        }

        public static void HttpSend(OperationRequest request, Action<OperationResponse> onResponse = null)
        {
            peer.HttpSend(request, onResponse);
        }
    }
}