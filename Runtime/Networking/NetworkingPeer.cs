namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;

    public partial class NetworkingPeer : UnityEngine.MonoBehaviour
    {
        private IPeer socketPeer;
        private IPeer httpPeer;

        internal string authToken = string.Empty;
        internal string userId = string.Empty;

        internal AuthenticateStatus authenticateStatus = new AuthenticateStatus();

        internal int ping
        {
            get
            {
                var count = 0;
                var totalPing = 0;

                if (this.httpPeer.IsUsing())
                {
                    count++;
                    totalPing += ((PeerBase)this.httpPeer).ping;
                }

                if (this.socketPeer.IsUsing())
                {
                    count++;
                    totalPing += ((PeerBase)this.socketPeer).ping;
                }

                return totalPing / count;
            }
        }

        internal string getClientId() => (this.socketPeer as SocketPeer).getClientId();

        private long lastCurrentServerMilliseconds;
        private float lastGetCurrentMilliseconds;

        internal void SetServerTimeMilliseconds(long currentServerMilliseconds)
        {
            lastCurrentServerMilliseconds = currentServerMilliseconds;
            lastGetCurrentMilliseconds = UnityEngine.Time.realtimeSinceStartup;
        }

        internal long serverTimestamp => lastCurrentServerMilliseconds + (int)((UnityEngine.Time.realtimeSinceStartup - lastGetCurrentMilliseconds) * 1000);

        internal void InitPeer()
        {
            SetServerTimeMilliseconds(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());

            var gnServerSettings = GNNetwork.gnServerSettings;
            if (gnServerSettings == null) throw new NullReferenceException("Null GN Server Settings, please find it now");

            this.httpPeer = this.gameObject.AddComponent<HttpPeer>();
            this.httpPeer.InitPeer();

            this.socketPeer = this.gameObject.AddComponent<SocketPeer>();
            this.socketPeer.InitPeer();
        }

        private void Update()
        {
            this.httpPeer?.Service();
            this.socketPeer?.Service();
        }

        internal void SendViaSocket(RequestType requestType, RequestRole requestRole, OperationRequest request, Action<OperationResponse> onResponse = null, string authToken = null, string secretKey = null, GNHashtable customTags = null)
        {
            this.socketPeer.Enqueue(requestType, requestRole, request, onResponse, authToken, secretKey, customTags);
        }

        internal void SendViaHttp(RequestType requestType, RequestRole requestRole, OperationRequest request, Action<OperationResponse> onResponse = null, string authToken = null, string secretKey = null, GNHashtable customTags = null)
        {
            this.httpPeer.Enqueue(requestType, requestRole, request, onResponse, authToken, secretKey, customTags);
        }

        internal void SendRequestAuthSocket()
        {
            (this.socketPeer as SocketPeer).SendRequestAuthSocket();
        }

        internal void ConnectSocket(Action _onSocketConnect)
        {
            (this.socketPeer as SocketPeer).Connect(_onSocketConnect);
        }

        internal void DisconnectSocket(Action _onSocketDisconnect)
        {
            (this.socketPeer as SocketPeer).Disconnect(_onSocketDisconnect);
        }

        internal void SetOnEventHandler(Action<OperationEvent> _onEventHandler)
        {
            (this.socketPeer as SocketPeer).SetOnEventHandler(_onEventHandler);
        }

        internal void SetOnConnectHandler(Action _onConnectHandler)
        {
            (this.socketPeer as SocketPeer).SetOnConnectHandler(_onConnectHandler);
        }

        internal void SetOnDisconnectHandler(Action _onDisconnectHandler)
        {
            (this.socketPeer as SocketPeer).SetOnDisconnectHandler(_onDisconnectHandler);
        }

        internal void RemoveOnConnectHandler(Action _onConnectHandler)
        {
            (this.socketPeer as SocketPeer).RemoveOnConnectHandler(_onConnectHandler);
        }

        internal void RemoveOnDisconnectHandler(Action _onDisconnectHandler)
        {
            (this.socketPeer as SocketPeer).RemoveOnDisconnectHandler(_onDisconnectHandler);
        }

    }

}
