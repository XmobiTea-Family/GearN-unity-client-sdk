namespace XmobiTea.GN.Networking.Socket
{
#if UNITY_USING_BEST_HTTP

    using BestHTTP.SocketIO3;
    using System;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Config;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Helper;
    using XmobiTea.GN.Logger;

    /// <summary>
    /// Handles socket networking using BestHTTP Socket.IO v3.
    /// </summary>
    internal class NetworkingPeerSocketV3 : NetworkingSocketPeerBase
    {
        private SocketManager socketManager;
        private bool isConnected;

        /// <summary>
        /// Gets whether the WebSocket connection is open.
        /// </summary>
        internal override bool isWsConnected => this.socketManager != null ? this.socketManager.State == SocketManager.States.Open : false;

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
                var uri = new Uri(this.url + "/socket.io/");
                this.socketManager = new SocketManager(uri, new SocketOptions()
                {
                    Reconnection = true,
                    ReconnectionDelay = new TimeSpan(0, 0, this.reconnectDelay),
                    Timeout = new TimeSpan(0, 0, (int)this.pingTimeout),
                    AutoConnect = false,
                    ConnectWith = BestHTTP.SocketIO3.Transports.TransportTypes.WebSocket
                });

                this.socketManager.Socket.On(SocketIOEventTypes.Connect, this.onConnect);
                this.socketManager.Socket.On(SocketIOEventTypes.Disconnect, this.onDisconnect);
                this.socketManager.Socket.On(SocketIOEventTypes.Error, this.onError);

                this.socketManager.Socket.On<byte[]>(Commands.ResponseCmd_MsgPack, this.onResponseMsgPack);
                this.socketManager.Socket.On<byte[]>(Commands.EventCmd_MsgPack, this.onEventMsgPack);

                this.socketManager.Socket.On<object[]>(Commands.ResponseCmd_Json, this.onResponseJson);
                this.socketManager.Socket.On<object[]>(Commands.EventCmd_Json, this.onEventJson);
            }
        }

        /// <summary>
        /// Handles socket error events.
        /// </summary>
        private void onError()
        {
            GNDebug.log("[GN Socket RECV] Handle Error ");
        }

        /// <summary>
        /// Handles MsgPack response messages.
        /// </summary>
        /// <param name="responseData">The response data in byte array format.</param>
        private void onResponseMsgPack(byte[] responseData)
        {
            lock (this.messageLstLock)
            {
                this.responsePacketLst.Add(new SocketPacket(responseData, true));
            }
        }

        /// <summary>
        /// Handles MsgPack event messages.
        /// </summary>
        /// <param name="eventData">The event data in byte array format.</param>
        private void onEventMsgPack(byte[] eventData)
        {
            lock (this.messageLstLock)
            {
                this.eventPacketLst.Add(new SocketPacket(eventData, true));
            }
        }

        /// <summary>
        /// Handles JSON response messages.
        /// </summary>
        /// <param name="responseData">The response data as an object array.</param>
        private void onResponseJson(object[] responseData)
        {
            lock (this.messageLstLock)
            {
                this.responsePacketLst.Add(new SocketPacket(responseData, false));
            }
        }

        /// <summary>
        /// Handles JSON event messages.
        /// </summary>
        /// <param name="eventData">The event data as an object array.</param>
        private void onEventJson(object[] eventData)
        {
            lock (this.messageLstLock)
            {
                this.eventPacketLst.Add(new SocketPacket(eventData, false));
            }
        }

        /// <summary>
        /// Handles socket disconnection events.
        /// </summary>
        private void onDisconnect()
        {
            GNDebug.log("[GN Socket RECV] HandleClose ");

            this.clientId = string.Empty;

            this.onDisconnectHandler();
        }

        /// <summary>
        /// Handles socket connection events.
        /// </summary>
        private void onConnect()
        {
            GNDebug.log("[GN Socket RECV] HandleOpen " + this.socketManager.Socket.Id);

            this.clientId = this.socketManager.Socket.Id;

            this.onConnectHandler();
        }

        /// <summary>
        /// Initializes the socket with the given configuration.
        /// </summary>
        /// <param name="url">The server URL.</param>
        /// <param name="reconnectDelay">Delay in seconds before attempting to reconnect.</param>
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

            GNDebug.log("[GN Socket] Disconnecting via SocketIOv3 BestHTTP 2");

            this.onDisconnectHandler();
        }

        /// <summary>
        /// Opens a socket connection.
        /// </summary>
        /// <param name="_onSocketConnect">Callback for when the socket is connected.</param>
        internal override void connect(Action _onSocketConnect)
        {
            base.connect(_onSocketConnect);

            if (this.isConnected)
            {
                GNDebug.log("[GN Socket] Reconnecting");
                return;
            }

            this.isConnected = true;

            GNDebug.log("[GN Socket] Connecting via SocketIOv3 BestHTTP 2");

            if (this.socketManager != null) this.socketManager.Open();
        }
    }

#endif
}
