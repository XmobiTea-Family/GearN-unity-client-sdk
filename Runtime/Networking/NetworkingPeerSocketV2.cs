namespace XmobiTea.GN.Networking
{
    using System;

    using BestHTTP.SocketIO;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Constant;
    using XmobiTea.MsgPack;
    using XmobiTea.GN.Logger;
    using XmobiTea.GN.Common;

    internal class NetworkingPeerSocketV2 : NetworkingPeerBase
    {
        private SocketManager socketManager;
        private bool isConnected;

        internal override bool isWsConnected => this.socketManager != null ? this.socketManager.State == SocketManager.States.Open : false;

        private SupportedSocketIOVersions serverVersion = SupportedSocketIOVersions.v3;

        public void SetServerVersion(SupportedSocketIOVersions serverVersion)
        {
            this.serverVersion = serverVersion;
        }

        internal override void sendRequestAuthSocket()
        {
            base.sendRequestAuthSocket();

            if (!string.IsNullOrEmpty(this.clientId))
                this.socketManager.Socket.Emit(Commands.RequestAuthTokenCmd, GNNetwork.getAuthenticateStatus().getAuthToken());
        }

        internal override void reInitNewSocket()
        {
            base.reInitNewSocket();

            if (this.socketManager == null)
            {
                var uri = new Uri(this.url + "/socket.io/");
                this.socketManager = new SocketManager(uri, new SocketOptions()
                {
                    ServerVersion = serverVersion,
                    Reconnection = true,
                    ReconnectionDelay = TimeSpan.FromMilliseconds(this.reconnectDelay),
                    Timeout = TimeSpan.FromMilliseconds(this.pingTimeout),
                    AutoConnect = false,
                    ConnectWith = BestHTTP.SocketIO.Transports.TransportTypes.WebSocket
                });

                this.socketManager.Socket.On(SocketIOEventTypes.Connect, OnConnect);
                this.socketManager.Socket.On(SocketIOEventTypes.Disconnect, OnDisconnect);
                this.socketManager.Socket.On(SocketIOEventTypes.Error, OnError);

                this.socketManager.Socket.On(Commands.ResponseCmd_MsgPack, OnResponseMsgPack);
                this.socketManager.Socket.On(Commands.EventCmd_MsgPack, OnEventMsgPack);

                this.socketManager.Socket.On(Commands.ResponseCmd_Json, OnResponseJson);
                this.socketManager.Socket.On(Commands.EventCmd_Json, OnEventJson);
            }
        }

        private void OnResponseMsgPack(Socket socket, Packet packet, object[] args)
        {
            lock (this.messageLstLock)
            {
                this.responsePacketLst.Add(new SocketPacket(packet.Attachments[0], true));
            }
        }

        private void OnEventMsgPack(Socket socket, Packet packet, object[] args)
        {
            lock (this.messageLstLock)
            {
                this.eventPacketLst.Add(new SocketPacket(packet.Attachments[0], true));
            }
        }

        private void OnResponseJson(Socket socket, Packet packet, object[] args)
        {
            lock (this.messageLstLock)
            {
                this.responsePacketLst.Add(new SocketPacket(packet.DecodedArgs[0], false));
            }
        }

        private void OnEventJson(Socket socket, Packet packet, object[] args)
        {
            lock (this.messageLstLock)
            {
                this.eventPacketLst.Add(new SocketPacket(packet.DecodedArgs[0], false));
            }
        }

        private void OnConnect(Socket socket, Packet packet, object[] args)
        {
            GNDebug.log("[GN Socket RECV] HandleOpen " + socket.Id);

            this.clientId = socket.Id;

            this.onConnectHandler();
        }

        private void OnDisconnect(Socket socket, Packet packet, object[] args)
        {
            GNDebug.log("[GN Socket RECV] HandleClose ");

            this.clientId = string.Empty;

            this.onDisconnectHandler();
        }

        private void OnError(Socket socket, Packet packet, object[] args)
        {
            GNDebug.logError(string.Format("Error: {0}", args[0].ToString()));
        }

        internal override void init(string url, int reconnectDelay, float pingInterval, float pingTimeout)
        {
            base.init(url, reconnectDelay, pingInterval, pingTimeout);
        }

        protected override void emit(RequestType requestType, RequestRole requestRole, OperationRequest operationRequest, string authToken, string secretKey, GNHashtable customTags)
        {
            base.emit(requestType, requestRole, operationRequest, authToken, secretKey, customTags);

            if (this.socketManager == null || this.socketManager.Socket == null)
            {
                // callback here
                return;
            }

            if (customTags != null) operationRequest.setParameter(GNParameterCode.CustomTags, customTags);

            var dataSend = OperationHelper.toSocketData(requestType, requestRole, operationRequest);

            if (operationRequest.isEncrypted())
                this.socketManager.Socket.Emit(Commands.RequestCmd_MsgPack, MsgPackSerializer.Serialize(dataSend));
            else
                this.socketManager.Socket.Emit(Commands.RequestCmd_Json, dataSend);
        }

        internal override void close(Action _onSocketDisconnect)
        {
            base.close(_onSocketDisconnect);

            this.isConnected = false;

            if (this.socketManager != null)
            {
                if (this.socketManager.State != SocketManager.States.Closed)
                {
                    this.socketManager.Close();
                    return;
                }
            }

            GNDebug.log("[GN Socket] Disconnecting via SocketIOv2 BestHTTP 2");

            onDisconnectHandler();
        }

        internal override void connect(Action _onSocketConnect)
        {
            base.connect(_onSocketConnect);

            if (this.isConnected)
            {
                GNDebug.log("[GN Socket] Reconnecting");

                return;
            }

            this.isConnected = true;

            GNDebug.log("[GN Socket] Connecting via SocketIOv2 BestHTTP 2");

            if (this.socketManager != null) this.socketManager.Open();
        }

    }

}
