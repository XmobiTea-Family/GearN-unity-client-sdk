namespace XmobiTea.GN.Networking
{
    using System;

    using BestHTTP.SocketIO3;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Constant;
    using XmobiTea.MsgPack;
    using XmobiTea.GN.Logger;

    internal class NetworkingPeerSocketV3 : NetworkingPeerBase
    {
        private SocketManager socketManager;
        private bool isConnected;

        internal override bool isWsConnected => this.socketManager != null ? this.socketManager.State == SocketManager.States.Open : false;

        internal override void SendRequestAuthSocket()
        {
            base.SendRequestAuthSocket();

            if (!string.IsNullOrEmpty(this.clientId))
                this.socketManager.Socket.Emit(Commands.RequestAuthTokenCmd, GNNetwork.authToken);
        }

        internal override void ReInitNewSocket()
        {
            base.ReInitNewSocket();

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

                this.socketManager.Socket.On(SocketIOEventTypes.Connect, this.OnConnect);
                this.socketManager.Socket.On(SocketIOEventTypes.Disconnect, this.OnDisconnect);
                this.socketManager.Socket.On(SocketIOEventTypes.Error, this.OnError);

                this.socketManager.Socket.On<byte[]>(Commands.ResponseCmd_MsgPack, this.OnResponseMsgPack);
                this.socketManager.Socket.On<byte[]>(Commands.EventCmd_MsgPack, this.OnEventMsgPack);

                this.socketManager.Socket.On<object[]>(Commands.ResponseCmd_Json, this.OnResponseJson);
                this.socketManager.Socket.On<object[]>(Commands.EventCmd_Json, this.OnEventJson);
            }
        }

        private void OnError()
        {
            GNDebug.Log("[GN Socket RECV] Handle Error ");
        }

        private void OnResponseMsgPack(byte[] responseData)
        {
            lock (this.messageLstLock)
            {
                this.responsePacketLst.Add(new SocketPacket(responseData, true));
            }
        }

        private void OnEventMsgPack(byte[] eventData)
        {
            lock (this.messageLstLock)
            {
                this.eventPacketLst.Add(new SocketPacket(eventData, true));
            }
        }

        private void OnResponseJson(object[] responseData)
        {
            lock (this.messageLstLock)
            {
                this.responsePacketLst.Add(new SocketPacket(responseData, false));
            }
        }

        private void OnEventJson(object[] eventData)
        {
            lock (this.messageLstLock)
            {
                this.eventPacketLst.Add(new SocketPacket(eventData, false));
            }
        }

        private void OnDisconnect()
        {
            GNDebug.Log("[GN Socket RECV] HandleClose ");

            this.clientId = string.Empty;

            this.OnDisconnectHandler();
        }

        private void OnConnect()
        {
            GNDebug.Log("[GN Socket RECV] HandleOpen " + this.socketManager.Socket.Id);

            this.clientId = this.socketManager.Socket.Id;

            this.OnConnectHandler();
        }

        internal override void Init(string url, int reconnectDelay, float pingInterval, float pingTimeout)
        {
            base.Init(url, reconnectDelay, pingInterval, pingTimeout);
        }

        protected override void Emit(OperationRequest operationRequest)
        {
            base.Emit(operationRequest);

            if (this.socketManager == null || this.socketManager.Socket == null)
            {
                // callback here
                return;
            }

            var dataSend = OperationHelper.ToSocketData(operationRequest);

            if (operationRequest.IsEncrypted())
                this.socketManager.Socket.Emit(Commands.RequestCmd_MsgPack, MsgPackSerializer.Serialize(dataSend));
            else
                this.socketManager.Socket.Emit(Commands.RequestCmd_Json, dataSend);
        }

        internal override void Close(Action _onSocketDisconnect)
        {
            base.Close(_onSocketDisconnect);

            this.isConnected = false;

            if (this.socketManager != null)
            {
                if (this.socketManager.State != SocketManager.States.Closed)
                {
                    this.socketManager.Close();
                    return;
                }
            }

            GNDebug.Log("[GN Socket] Disconnecting via SocketIOv3 BestHTTP 2");

            OnDisconnectHandler();
        }

        internal override void Connect(Action _onSocketConnect)
        {
            base.Connect(_onSocketConnect);

            if (this.isConnected)
            {
                GNDebug.Log("[GN Socket] Reconnecting");

                return;
            }

            this.isConnected = true;

            GNDebug.Log("[GN Socket] Connecting via SocketIOv3 BestHTTP 2");

            if (this.socketManager != null) this.socketManager.Open();
        }

    }

}
