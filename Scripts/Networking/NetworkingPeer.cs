namespace XmobiTea.GN.Networking
{
    using System;
    using UnityEngine;
    using XmobiTea.GN.Entity;

    public partial class NetworkingPeer : MonoBehaviour
    {
        private IPeer socketPeer;
        private IPeer httpPeer;

        internal string authToken = string.Empty;

        internal int Ping
        {
            get
            {
                var count = 0;
                var totalPing = 0;

                if (httpPeer != null)
                {
                    count++;
                    totalPing += ((PeerBase)httpPeer).Ping;
                }

                if (socketPeer != null)
                {
                    count++;
                    totalPing += ((PeerBase)socketPeer).Ping;
                }

                return totalPing / count;
            }
        }

        private long lastCurrentServerMilliseconds;
        private float lastGetCurrentMilliseconds;

        internal void SetServerTimeMilliseconds(long currentServerMilliseconds)
        {
            lastCurrentServerMilliseconds = currentServerMilliseconds;
            lastGetCurrentMilliseconds = Time.realtimeSinceStartup;
        }

        internal long serverTimestamp => lastCurrentServerMilliseconds + (int)((Time.realtimeSinceStartup - lastGetCurrentMilliseconds) * 1000);

        internal void InitPeer()
        {
            SetServerTimeMilliseconds(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());

            var gnServerSettings = GNNetwork.gnServerSettings;
            if (gnServerSettings == null) throw new NullReferenceException("Null GN Server Settings, please find it now");

            if (gnServerSettings.useHttp)
            {
                httpPeer = this.gameObject.AddComponent<HttpPeer>();
                httpPeer.InitPeer();
            }

            if (gnServerSettings.useSocket)
            {
                socketPeer = this.gameObject.AddComponent<SocketPeer>();
                socketPeer.InitPeer();
            }
        }

        internal void SocketSend(OperationRequest request, Action<OperationResponse> onResponse = null)
        {
            if (socketPeer != null) socketPeer.Enqueue(request, onResponse);
        }

        internal void HttpSend(OperationRequest request, Action<OperationResponse> onResponse = null)
        {
            if (httpPeer != null) httpPeer.Enqueue(request, onResponse);
        }

        internal void SendRequestAuthSocket()
        {
            if (socketPeer != null) (socketPeer as SocketPeer).SendRequestAuthSocket();
        }
    }
}
