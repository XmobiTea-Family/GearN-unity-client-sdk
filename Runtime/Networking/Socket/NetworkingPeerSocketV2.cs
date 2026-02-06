namespace XmobiTea.GearN.Networking.Socket
{
#if UNITY_USING_BEST_HTTP

    using BestHTTP.SocketIO;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Config;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Helper;
    using XmobiTea.GearN.Logger;

    /// <summary>
    /// Handles socket networking using BestHTTP Socket.IO v2.
    /// </summary>
    internal class NetworkingPeerSocketV2 : NetworkingSocketPeerBase
    {
        private SocketManager socketManager;
        private bool isConnected;

        /// <summary>
        /// Gets whether the WebSocket connection is open.
        /// </summary>
        internal override bool isWsConnected => this.socketManager != null ? this.socketManager.State == SocketManager.States.Open : false;

        private SupportedSocketIOVersions serverVersion = SupportedSocketIOVersions.v3;

        /// <summary>
        /// Sets the Socket.IO server version.
        /// </summary>
        /// <param name="serverVersion">The server version to use.</param>
        public void setServerVersion(SupportedSocketIOVersions serverVersion)
        {
            this.serverVersion = serverVersion;
        }

        /// <summary>
        /// Sends an authentication request via the socket.
        /// </summary>
        internal override void sendRequestAuthSocket()
        {
            base.sendRequestAuthSocket();

            if (!string.IsNullOrEmpty(this.clientId))
                this.socketManager.Socket.Emit(Commands.RequestAuthTokenCmd, GNNetwork.getAuthenticateStatus().getAuthToken());
        }

        /// <summary>
        /// Reinitializes the socket with a new configuration.
        /// </summary>
        internal override void reInitNewSocket()
        {
            base.reInitNewSocket();

            if (this.socketManager == null)
            {
                var uri = new System.Uri(this.url + "/socket.io/");
                this.socketManager = new SocketManager(uri, new SocketOptions()
                {
                    ServerVersion = this.serverVersion,
                    Reconnection = true,
                    ReconnectionDelay = System.TimeSpan.FromMilliseconds(this.reconnectDelay),
                    Timeout = System.TimeSpan.FromMilliseconds(this.pingTimeout),
                    AutoConnect = false,
                    ConnectWith = BestHTTP.SocketIO.Transports.TransportTypes.WebSocket
                });

                this.socketManager.Socket.On(SocketIOEventTypes.Connect, this.onConnect);
                this.socketManager.Socket.On(SocketIOEventTypes.Disconnect, this.onDisconnect);
                this.socketManager.Socket.On(SocketIOEventTypes.Error, this.onError);

                this.socketManager.Socket.On(Commands.ResponseCmd_MsgPack, this.onResponseMsgPack);
                this.socketManager.Socket.On(Commands.EventCmd_MsgPack, this.onEventMsgPack);

                this.socketManager.Socket.On(Commands.ResponseCmd_Json, this.onResponseJson);
                this.socketManager.Socket.On(Commands.EventCmd_Json, this.onEventJson);
            }
        }

        private void onResponseMsgPack(Socket socket, Packet packet, object[] args)
        {
            lock (this.messageLstLock)
            {
                this.responsePacketLst.Add(new SocketPacket(packet.Attachments[0], true));
            }
        }

        private void onEventMsgPack(Socket socket, Packet packet, object[] args)
        {
            lock (this.messageLstLock)
            {
                this.eventPacketLst.Add(new SocketPacket(packet.Attachments[0], true));
            }
        }

        private void onResponseJson(Socket socket, Packet packet, object[] args)
        {
            lock (this.messageLstLock)
            {
                this.responsePacketLst.Add(new SocketPacket(packet.DecodedArgs[0], false));
            }
        }

        private void onEventJson(Socket socket, Packet packet, object[] args)
        {
            lock (this.messageLstLock)
            {
                this.eventPacketLst.Add(new SocketPacket(packet.DecodedArgs[0], false));
            }
        }

        private void onConnect(Socket socket, Packet packet, object[] args)
        {
            GNDebug.log("[GN Socket RECV] HandleOpen " + socket.Id);

            this.clientId = socket.Id;

            this.onConnectHandler();
        }

        private void onDisconnect(Socket socket, Packet packet, object[] args)
        {
            GNDebug.log("[GN Socket RECV] HandleClose ");

            this.clientId = string.Empty;

            this.onDisconnectHandler();
        }

        private void onError(Socket socket, Packet packet, object[] args)
        {
            GNDebug.logError(string.Format("Error: {0}", args[0].ToString()));
        }

        /// <summary>
        /// Initializes the socket with the given configuration.
        /// </summary>
        /// <param name="url">The server URL.</param>
        /// <param name="reconnectDelay">Delay in milliseconds before attempting to reconnect.</param>
        /// <param name="pingInterval">Ping interval in seconds.</param>
        /// <param name="pingTimeout">Ping timeout in seconds.</param>
        internal override void init(string url, int reconnectDelay, float pingInterval, float pingTimeout)
        {
            base.init(url, reconnectDelay, pingInterval, pingTimeout);
        }

        /// <summary>
        /// Emits a request via the socket.
        /// </summary>
        /// <param name="requestType">The type of request to emit.</param>
        /// <param name="role">The role associated with the request.</param>
        /// <param name="operationRequest">The operation request data.</param>
        /// <param name="authToken">Authentication token, if available.</param>
        /// <param name="secretKey">Secret key, if available.</param>
        /// <param name="customTags">Custom tags for the request.</param>
        protected override void emit(RequestType requestType, RequestRole role, OperationRequest operationRequest, string authToken, string secretKey, GNHashtable customTags, string gameId)
        {
            base.emit(requestType, role, operationRequest, authToken, secretKey, customTags, gameId);

            if (this.socketManager == null || this.socketManager.Socket == null)
            {
                return;
            }

            if (customTags != null) operationRequest.setParameter(ParameterCode.CustomTags, customTags);

            var dataSend = OperationHelper.toSocketData(requestType, role, operationRequest);

            var gnServerSettings = GNNetwork.gnServerSettings;

            if (gnServerSettings.getMessageType() == MessageType.Json)
                this.socketManager.Socket.Emit(Commands.RequestCmd_Json, dataSend);
            else
                this.socketManager.Socket.Emit(Commands.RequestCmd_MsgPack, MessagePackConverterService.serialize(dataSend));
        }

        /// <summary>
        /// Closes the socket connection.
        /// </summary>
        /// <param name="_onSocketDisconnect">Callback for when the socket is disconnected.</param>
        internal override void close(Action0 _onSocketDisconnect)
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

            this.onDisconnectHandler();
        }

        /// <summary>
        /// Opens a socket connection.
        /// </summary>
        /// <param name="_onSocketConnect">Callback for when the socket is connected.</param>
        internal override void connect(Action0 _onSocketConnect)
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

#endif
}
