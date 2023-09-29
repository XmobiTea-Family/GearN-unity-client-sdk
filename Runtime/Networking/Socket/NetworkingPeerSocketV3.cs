namespace XmobiTea.GN.Networking.Socket
{
    using System;

    using BestHTTP.SocketIO3;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Constant;
    using XmobiTea.MsgPack;
    using XmobiTea.GN.Logger;
    using XmobiTea.GN.Common;

    internal class NetworkingPeerSocketV3 : NetworkingSocketPeerBase
    {
        private SocketManager socketManager;
        private bool isConnected;

        internal override bool isWsConnected => this.socketManager != null ? this.socketManager.State == SocketManager.States.Open : false;

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

        private void onError()
        {
            GNDebug.log("[GN Socket RECV] Handle Error ");
        }

        private void onResponseMsgPack(byte[] responseData)
        {
            lock (this.messageLstLock)
            {
                this.responsePacketLst.Add(new SocketPacket(responseData, true));
            }
        }

        private void onEventMsgPack(byte[] eventData)
        {
            lock (this.messageLstLock)
            {
                this.eventPacketLst.Add(new SocketPacket(eventData, true));
            }
        }

        private void onResponseJson(object[] responseData)
        {
            lock (this.messageLstLock)
            {
                this.responsePacketLst.Add(new SocketPacket(responseData, false));
            }
        }

        private void onEventJson(object[] eventData)
        {
            lock (this.messageLstLock)
            {
                this.eventPacketLst.Add(new SocketPacket(eventData, false));
            }
        }

        private void onDisconnect()
        {
            GNDebug.log("[GN Socket RECV] HandleClose ");

            this.clientId = string.Empty;

            this.onDisconnectHandler();
        }

        private void onConnect()
        {
            GNDebug.log("[GN Socket RECV] HandleOpen " + this.socketManager.Socket.Id);

            this.clientId = this.socketManager.Socket.Id;

            this.onConnectHandler();
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

            GNDebug.log("[GN Socket] Disconnecting via SocketIOv3 BestHTTP 2");

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

            GNDebug.log("[GN Socket] Connecting via SocketIOv3 BestHTTP 2");

            if (this.socketManager != null) this.socketManager.Open();
        }

    }

}
