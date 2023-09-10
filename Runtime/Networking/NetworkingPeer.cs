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

        internal AuthenticateStatus authenticateStatus;

        internal int getPing()
        {
            var count = 0;
            var totalPing = 0;

            if (this.httpPeer.isUsing())
            {
                count++;
                totalPing += ((PeerBase)this.httpPeer).ping;
            }

            if (this.socketPeer.isUsing())
            {
                count++;
                totalPing += ((PeerBase)this.socketPeer).ping;
            }

            return totalPing / count;
        }

        internal string getClientId() => (this.socketPeer as SocketPeer).getClientId();

        private long lastCurrentServerMilliseconds;
        private float lastGetCurrentMilliseconds;

        internal void setServerTimeMilliseconds(long currentServerMilliseconds)
        {
            this.lastCurrentServerMilliseconds = currentServerMilliseconds;
            this.lastGetCurrentMilliseconds = UnityEngine.Time.realtimeSinceStartup;
        }

        internal long getServerTimestamp()
        {
            return this.lastCurrentServerMilliseconds + (int)((UnityEngine.Time.realtimeSinceStartup - this.lastGetCurrentMilliseconds) * 1000);
        }

        internal void initPeer()
        {
            setServerTimeMilliseconds(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());

            var gnServerSettings = GNNetwork.gnServerSettings;
            if (gnServerSettings == null) throw new NullReferenceException("Null GN Server Settings, please find it now");

            this.authenticateStatus = new AuthenticateStatus();

            this.httpPeer = this.gameObject.AddComponent<HttpPeer>();
            this.httpPeer.initPeer();

            this.socketPeer = this.gameObject.AddComponent<SocketPeer>();
            this.socketPeer.initPeer();
        }

        private void Update()
        {
            this.httpPeer?.service();
            this.socketPeer?.service();
        }

        internal void sendViaSocket(RequestType requestType, RequestRole requestRole, OperationRequest request, Action<OperationResponse> onResponse = null, string authToken = null, string secretKey = null, GNHashtable customTags = null)
        {
            if (authToken == null) authToken = GNNetwork.getAuthenticateStatus().getAuthToken();
            if (secretKey == null)
            {
                if (requestRole == RequestRole.Admin) secretKey = GNNetwork.gnServerSettings.getAdminSecretKey();
                else if (requestRole == RequestRole.Server) secretKey = GNNetwork.gnServerSettings.getServerSecretKey();
                else if (requestRole == RequestRole.Client) secretKey = GNNetwork.gnServerSettings.getClientSecretKey();
            }

            this.socketPeer.enqueue(requestType, requestRole, request, onResponse, authToken, secretKey, customTags);
        }

        internal void sendViaHttp(RequestType requestType, RequestRole requestRole, OperationRequest request, Action<OperationResponse> onResponse = null, string authToken = null, string secretKey = null, GNHashtable customTags = null)
        {
            if (authToken == null) authToken = GNNetwork.getAuthenticateStatus().getAuthToken();
            if (secretKey == null)
            {
                if (requestRole == RequestRole.Admin) secretKey = GNNetwork.gnServerSettings.getAdminSecretKey();
                else if (requestRole == RequestRole.Server) secretKey = GNNetwork.gnServerSettings.getServerSecretKey();
                else if (requestRole == RequestRole.Client) secretKey = GNNetwork.gnServerSettings.getClientSecretKey();
            }

            this.httpPeer.enqueue(requestType, requestRole, request, onResponse, authToken, secretKey, customTags);
        }

        internal void sendRequestAuthSocket()
        {
            (this.socketPeer as SocketPeer).sendRequestAuthSocket();
        }

        internal void connectSocket(Action _onSocketConnect)
        {
            (this.socketPeer as SocketPeer).connect(_onSocketConnect);
        }

        internal void disconnectSocket(Action _onSocketDisconnect)
        {
            (this.socketPeer as SocketPeer).disconnect(_onSocketDisconnect);
        }

        internal void setOnEventHandler(Action<OperationEvent> _onEventHandler)
        {
            (this.socketPeer as SocketPeer).setOnEventHandler(_onEventHandler);
        }

        internal void setOnConnectHandler(Action _onConnectHandler)
        {
            (this.socketPeer as SocketPeer).setOnConnectHandler(_onConnectHandler);
        }

        internal void setOnDisconnectHandler(Action _onDisconnectHandler)
        {
            (this.socketPeer as SocketPeer).setOnDisconnectHandler(_onDisconnectHandler);
        }

        internal void removeOnConnectHandler(Action _onConnectHandler)
        {
            (this.socketPeer as SocketPeer).removeOnConnectHandler(_onConnectHandler);
        }

        internal void removeOnDisconnectHandler(Action _onDisconnectHandler)
        {
            (this.socketPeer as SocketPeer).removeOnDisconnectHandler(_onDisconnectHandler);
        }

    }

}
