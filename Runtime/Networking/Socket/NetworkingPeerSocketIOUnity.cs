namespace XmobiTea.GN.Networking.Socket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.Json;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Helper;
    using XmobiTea.GN.Logger;

    /// <summary>
    /// Handles socket networking using Socket.IO v4 DogHappy.
    /// </summary>
    internal class NetworkingPeerSocketV4 : NetworkingSocketPeerBase
    {
        private SocketIOClient.SocketIO socketManager;
        private bool isConnected;

        /// <summary>
        /// Gets whether the WebSocket connection is open.
        /// </summary>
        internal override bool isWsConnected => this.socketManager != null ? this.socketManager.Connected : false;

        /// <summary>
        /// Sends an authentication request via the socket.
        /// </summary>
        internal override void sendRequestAuthSocket()
        {
            base.sendRequestAuthSocket();

            if (!string.IsNullOrEmpty(this.clientId))
                this.socketManager.EmitAsync(Commands.RequestAuthTokenCmd, GNNetwork.getAuthenticateStatus().getAuthToken());
        }

        /// <summary>
        /// Reinitializes the socket with a new configuration.
        /// </summary>
        internal override void reInitNewSocket()
        {
            base.reInitNewSocket();

            if (this.socketManager == null)
            {
                this.socketManager = new SocketIOClient.SocketIO(this.url, new SocketIOClient.SocketIOOptions()
                {
                    Path = "/socket.io",
                    EIO = SocketIOClient.EngineIO.V4,
                    Reconnection = true,
                    ReconnectionDelay = this.reconnectDelay,
                    ConnectionTimeout = new TimeSpan(0, 0, (int)this.pingTimeout),
                    //AutoConnect = false,
                    Transport = SocketIOClient.Transport.TransportProtocol.WebSocket,
                });

                this.socketManager.OnConnected += this.onConnect;
                this.socketManager.OnDisconnected += this.onDisconnect;
                this.socketManager.OnError += this.onError;

                this.socketManager.On(Commands.ResponseCmd_MsgPack, this.onResponseMsgPack);
                this.socketManager.On(Commands.EventCmd_MsgPack, this.onEventMsgPack);

                this.socketManager.On(Commands.ResponseCmd_Json, this.onResponseJson);
                this.socketManager.On(Commands.EventCmd_Json, this.onEventJson);
            }
        }

        /// <summary>
        /// Handles socket error events.
        /// </summary>
        private void onError(object sender, string reason)
        {
            GNDebug.log("[GN Socket RECV] Handle Error ");
        }

        /// <summary>
        /// Handles MsgPack response messages.
        /// </summary>
        /// <param name="responseData">The response data in byte array format.</param>
        private void onResponseMsgPack(SocketIOClient.SocketIOResponse response)
        {
            var responseData = response.GetValue<byte[]>(0);

            lock (this.messageLstLock)
            {
                this.responsePacketLst.Add(new SocketPacket(responseData, true));
            }
        }

        /// <summary>
        /// Handles MsgPack event messages.
        /// </summary>
        /// <param name="eventData">The event data in byte array format.</param>
        private void onEventMsgPack(SocketIOClient.SocketIOResponse response)
        {
            var eventData = response.GetValue<byte[]>(0);

            lock (this.messageLstLock)
            {
                this.eventPacketLst.Add(new SocketPacket(eventData, true));
            }
        }

        /// <summary>
        /// Handles JSON response messages.
        /// </summary>
        /// <param name="responseData">The response data as an object array.</param>
        private void onResponseJson(SocketIOClient.SocketIOResponse response)
        {
            var originData = response.GetValue<JsonElement>(0);
            var responseData = this.getValue(originData);

            lock (this.messageLstLock)
            {
                this.responsePacketLst.Add(new SocketPacket(responseData, false));
            }
        }

        /// <summary>
        /// Handles JSON event messages.
        /// </summary>
        /// <param name="eventData">The event data as an object array.</param>
        private void onEventJson(SocketIOClient.SocketIOResponse response)
        {
            var originData = response.GetValue<JsonElement>(0);
            var eventData = this.getValue(originData);

            //var eventData = originData.GetArrayLength() > 1 ? new object[] { originData[0].GetInt32(), this.jsonElementToDictionary(originData[1]) } : new object[] { originData[0].GetInt32() };

            lock (this.messageLstLock)
            {
                this.eventPacketLst.Add(new SocketPacket(eventData, false));
            }
        }

        private IDictionary<string, object> jsonElementToDictionary(JsonElement element)
        {
            var dict = new Dictionary<string, object>();

            foreach (var property in element.EnumerateObject())
            {
                dict[property.Name] = this.getValue(property.Value);
            }

            return dict;
        }

        private object getValue(JsonElement element)
        {
            return element.ValueKind switch
            {
                JsonValueKind.String => element.GetString(),
                JsonValueKind.Number => element.TryGetInt64(out long l) ? l : element.GetDouble(),
                JsonValueKind.True => true,
                JsonValueKind.False => false,
                JsonValueKind.Object => this.jsonElementToDictionary(element),
                JsonValueKind.Array => element.EnumerateArray().Select(this.getValue).ToList(),
                _ => null
            };
        }

        /// <summary>
        /// Handles socket disconnection events.
        /// </summary>
        private void onDisconnect(object sender, string reason)
        {
            GNDebug.log("[GN Socket RECV] HandleClose ");

            this.clientId = string.Empty;

            this.onDisconnectHandler();
        }

        /// <summary>
        /// Handles socket connection events.
        /// </summary>
        private void onConnect(object sender, EventArgs eventArgs)
        {
            GNDebug.log("[GN Socket RECV] HandleOpen " + this.socketManager.Id);

            this.clientId = this.socketManager.Id;

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

            if (this.socketManager == null)
            {
                return;
            }

            if (customTags != null) operationRequest.setParameter(ParameterCode.CustomTags, customTags);

            var dataSend = OperationHelper.toSocketData(requestType, role, operationRequest);

            var gnServerSettings = GNNetwork.gnServerSettings;

            if (gnServerSettings.getMessageType() == Config.MessageType.Json)
                this.socketManager.EmitAsync(Commands.RequestCmd_Json, dataSend);
            else
                this.socketManager.EmitAsync(Commands.RequestCmd_MsgPack, MessagePackConverterService.serialize(dataSend));
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
                if (!this.socketManager.Connected)
                {
                    this.socketManager.DisconnectAsync();
                    return;
                }
            }

            GNDebug.log("[GN Socket] Disconnecting via SocketIOv4 DogHappy");

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

            GNDebug.log("[GN Socket] Connecting via SocketIOv4 DogHappy");

            if (this.socketManager != null) this.socketManager.ConnectAsync();
        }
    }

}
