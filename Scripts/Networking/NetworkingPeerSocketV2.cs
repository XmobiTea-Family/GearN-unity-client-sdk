namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;

    using UnityEngine;

    using BestHTTP.SocketIO;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Common;
    using System.IO;
    using XmobiTea.GN.Helper;

    internal class NetworkingPeerSocketV2 : NetworkingPeerBase
    {
        private SocketManager socketManager;
        private bool isConnected;

        internal override bool IsWsConnected => socketManager != null ? socketManager.State == SocketManager.States.Open : false;

        private object messageLstLock;
        private List<byte[]> responsePacketLst;
        private List<byte[]> eventPacketLst;

        [SerializeField]
        private SupportedSocketIOVersions serverVersion = SupportedSocketIOVersions.v3;

        public void SetServerVersion(SupportedSocketIOVersions serverVersion)
        {
            this.serverVersion = serverVersion;
        }

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

            socketManager.Socket.Emit(Commands.RequestAuthTokenCmd, GNNetwork.authToken);
        }

        internal override void ReInitNewSocket()
        {
            base.ReInitNewSocket();

            if (socketManager == null)
            {
                var uri = new Uri(this.url + "/socket.io/");
                socketManager = new SocketManager(uri, new SocketOptions()
                {
                    ServerVersion = serverVersion,
                    Reconnection = true,
                    ReconnectionDelay = new TimeSpan(0, 0, this.reconnectDelay),
                    Timeout = new TimeSpan(0, 0, (int)this.pingTimeout),
                    AutoConnect = false,
                });

                socketManager.Socket.On(SocketIOEventTypes.Connect, OnConnect);
                socketManager.Socket.On(SocketIOEventTypes.Disconnect, OnDisconnect);
                socketManager.Socket.On(SocketIOEventTypes.Error, OnError);

                socketManager.Socket.On(Commands.ResponseCmd, OnResponse);
                socketManager.Socket.On(Commands.EventCmd, OnEvent);
            }
        }

        private void OnResponse(Socket socket, Packet packet, object[] args)
        {
            lock (messageLstLock)
            {
                responsePacketLst.Add(packet.Attachments[0]);
            }
        }

        private void OnEvent(Socket socket, Packet packet, object[] args)
        {
            lock (messageLstLock)
            {
                eventPacketLst.Add(packet.Attachments[0]);
            }
        }

        private void OnConnect(Socket socket, Packet packet, object[] args)
        {
            Debug.Log("[RECV] HandleOpen " + socket.Id);

            ClientId = socket.Id;

            OnConnectHandler();
        }

        private void OnDisconnect(Socket socket, Packet packet, object[] args)
        {
            Debug.Log("[RECV] HandleClose ");

            ClientId = string.Empty;
        }

        private void OnError(Socket socket, Packet packet, object[] args)
        {
            Debug.LogError(string.Format("Error: {0}", args[0].ToString()));
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
                            var iList = LsMsgPack.MsgPackSerializer.Deserialize<object[]>(byteArr);

                            var gnArray = new GNArray();

                            var returnCode = Convert.ToInt32(iList[0]);
                            gnArray.Add(returnCode);

                            if (returnCode == (int)ReturnCode.Ok)
                            {
                                var keyValuePairs = (KeyValuePair<object, object>[])iList[1];
                                gnArray.Add(new Common.GNHashtable.Builder().AddAll(fromMsgKeyValuePairs(keyValuePairs)).Build());
                            }
                            else
                            {
                                gnArray.Add(iList[1] as string);
                            }

                            gnArray.Add(Convert.ToInt32(iList[2]));

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
                            var iList = LsMsgPack.MsgPackSerializer.Deserialize<object[]>(byteArr);

                            var gnArray = new GNArray.Builder().AddAll(fromMsgList(iList)).Build();
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

            socketManager.Socket.Emit(Commands.RequestCmd, LsMsgPack.MsgPackSerializer.Serialize(dataSend));

            Debug.LogError(Serializer.Serialize(dataSend));
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

            Debug.Log("Connecting to SocketIOv2 BestHTTP 2");

            if (socketManager != null) socketManager.Open();
        }
    }
}