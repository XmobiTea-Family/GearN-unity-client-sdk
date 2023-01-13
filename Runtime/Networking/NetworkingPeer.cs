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

        internal int ping
        {
            get
            {
                var count = 0;
                var totalPing = 0;

                if (httpPeer.IsUsing())
                {
                    count++;
                    totalPing += ((PeerBase)httpPeer).ping;
                }

                if (socketPeer.IsUsing())
                {
                    count++;
                    totalPing += ((PeerBase)socketPeer).ping;
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

            httpPeer = this.gameObject.AddComponent<HttpPeer>();
            httpPeer.InitPeer();

            socketPeer = this.gameObject.AddComponent<SocketPeer>();
            socketPeer.InitPeer();
        }

        internal void SendViaSocket(OperationRequest request, Action<OperationResponse> onResponse = null)
        {
            socketPeer.Enqueue(request, onResponse);
        }

        internal void SendViaHttp(OperationRequest request, Action<OperationResponse> onResponse = null)
        {
            httpPeer.Enqueue(request, onResponse);
        }

        internal void SendRequestAuthSocket()
        {
            (socketPeer as SocketPeer).SendRequestAuthSocket();
        }

        internal void ConnectSocket()
        {
            (socketPeer as SocketPeer).Connect();
        }

        internal void DisconnectSocket()
        {
            (socketPeer as SocketPeer).Disconnect();
        }
    }
}
