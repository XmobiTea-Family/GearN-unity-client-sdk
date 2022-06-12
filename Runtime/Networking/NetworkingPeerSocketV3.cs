namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;

    using UnityEngine;

    using BestHTTP.SocketIO3;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Common;
    using XmobiTea.MsgPack;

    internal class NetworkingPeerSocketV3 : NetworkingPeerBase
    {
        private SocketManager socketManager;
        private bool isConnected;

        internal override bool isWsConnected => socketManager != null ? socketManager.State == SocketManager.States.Open : false;

        private object messageLstLock;
        private List<byte[]> responsePacketLst;
        private List<byte[]> eventPacketLst;

        protected override void Awake()
        {
            messageLstLock = new object();
            responsePacketLst = new List<byte[]>();
            eventPacketLst = new List<byte[]>();

            base.Awake();
        }

        internal override void SendRequestAuthSocket()
        {
            base.SendRequestAuthSocket();

            if (!string.IsNullOrEmpty(clientId))
                socketManager.Socket.Emit(Commands.RequestAuthTokenCmd, GNNetwork.authToken);
        }

        internal override void ReInitNewSocket()
        {
            base.ReInitNewSocket();

            if (socketManager == null)
            {
                var uri = new Uri(this.url);
                socketManager = new SocketManager(uri, new SocketOptions()
                {
                    Reconnection = true,
                    ReconnectionDelay = new TimeSpan(0, 0, this.reconnectDelay),
                    Timeout = new TimeSpan(0, 0, (int)this.pingTimeout),
                    AutoConnect = false,
                    ConnectWith = BestHTTP.SocketIO3.Transports.TransportTypes.WebSocket
                });

                socketManager.Socket.On(SocketIOEventTypes.Connect, OnConnect);
                socketManager.Socket.On(SocketIOEventTypes.Disconnect, OnDisconnect);
                socketManager.Socket.On(SocketIOEventTypes.Error, OnError);

                socketManager.Socket.On<byte[]>(Commands.ResponseCmd, OnResponse);
                socketManager.Socket.On<byte[]>(Commands.EventCmd, OnEvent);
            }
        }

        private void OnError()
        {
            Debug.Log("[RECV] Handle Error ");
        }

        private void OnResponse(byte[] responseData)
        {
            lock (messageLstLock)
            {
                responsePacketLst.Add(responseData);
            }
        }

        private void OnEvent(byte[] eventData)
        {
            lock (messageLstLock)
            {
                eventPacketLst.Add(eventData);
            }
        }

        private void OnDisconnect()
        {
            Debug.Log("[RECV] HandleClose ");

            clientId = string.Empty;
        }

        private void OnConnect()
        {
            Debug.Log("[RECV] HandleOpen " + socketManager.Socket.Id);

            clientId = socketManager.Socket.Id;

            OnConnectHandler();
        }

        void Update()
        {
            lock (messageLstLock)
            {
                if (responsePacketLst.Count > 0)
                {
                    for (var i = 0; i < responsePacketLst.Count; i++)
                    {
                        var byteArr = responsePacketLst[i];

                        try
                        {
                            var iList = MsgPackSerializer.Deserialize<object[]>(byteArr);

                            var gnArray = new GNArray.Builder().AddAll(NetworkingPeerBase.fromMsgList(iList)).Build();
                            OnResponseHandler(gnArray);
                        }
                        catch (Exception ex)
                        {
                            Debug.LogException(ex);
                        }
                    }

                    responsePacketLst.Clear();
                }

                if (eventPacketLst.Count > 0)
                {
                    for (var i = 0; i < eventPacketLst.Count; i++)
                    {
                        var byteArr = eventPacketLst[i];

                        try
                        {
                            var iList = MsgPackSerializer.Deserialize<object[]>(byteArr);

                            var gnArray = new GNArray.Builder().AddAll(NetworkingPeerBase.fromMsgList(iList)).Build();
                            OnEventHandler(gnArray);
                        }
                        catch (Exception ex)
                        {
                            Debug.LogException(ex);
                        }
                    }

                    eventPacketLst.Clear();
                }
            }
        }

        internal override void Init(string url, int reconnectDelay, float pingInterval, float pingTimeout)
        {
            base.Init(url, reconnectDelay, pingInterval, pingTimeout);
        }

        protected override void Emit(OperationRequest operationRequest)
        {
            base.Emit(operationRequest);

            if (socketManager == null || socketManager.Socket == null)
            {
                // callback here
                return;
            }

            var dataSend = operationRequest.ToData();

            socketManager.Socket.Emit(Commands.RequestCmd, MsgPackSerializer.Serialize(dataSend));
        }

        internal override void Close()
        {
            base.Close();

            if (socketManager != null)
            {
                socketManager.Close();
            }
        }

        internal override void Connect()
        {
            base.Connect();

            if (isConnected)
            {
                Debug.Log("Reconnecting");

                return;
            }

            isConnected = true;

            Debug.Log("Connecting to SocketIOv3 BestHTTP 2");

            if (socketManager != null) socketManager.Open();
        }
    }
}
