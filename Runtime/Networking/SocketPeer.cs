namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Config;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Logger;

    internal class SocketPeer : PeerBase
    {
        //private const string authTokenFormat = "{\"authtoken\":$authtoken}";

        private NetworkingPeerBase networkingPeerBase;

        internal string clientId => this.networkingPeerBase?.clientId;

        internal bool isConnected => this.networkingPeerBase.isWsConnected;

        private Dictionary<int, IServerEventHandler> serverEventHandlerDic;

        private Action<OperationEvent> _onEventHandler;

        internal void SendRequestAuthSocket()
        {
            this.networkingPeerBase.SendRequestAuthSocket();
        }

        void SubscriberServerEventHandler()
        {
            if (this.serverEventHandlerDic == null) this.serverEventHandlerDic = new Dictionary<int, IServerEventHandler>();
            else this.serverEventHandlerDic.Clear();

            var type = typeof(IServerEventHandler);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p != type).ToList();

            foreach (var t in types)
            {
                var srvMsg = Activator.CreateInstance(t) as IServerEventHandler;
                if (srvMsg != null) this.serverEventHandlerDic[srvMsg.GetEventCode()] = srvMsg;
            }
        }

        internal override void InitGNSocketObject()
        {
            base.InitGNSocketObject();

            var gnServerSettings = GNNetwork.gnServerSettings;
            if (gnServerSettings == null) throw new NullReferenceException("Where is GN Server Settings");

            this.isUsing = gnServerSettings.useSocket;

            var peerSocketVersion = gnServerSettings.peerSocketVersion;

            if (peerSocketVersion == PeerSocketVersion.V3)
            {
                this.networkingPeerBase = this.gameObject.AddComponent<NetworkingPeerSocketV3>();
            }
            else
            {
                this.networkingPeerBase = this.gameObject.AddComponent<NetworkingPeerSocketV2>();

                if (peerSocketVersion == PeerSocketVersion.V2_v2)
                {
                    ((NetworkingPeerSocketV2)this.networkingPeerBase).SetServerVersion(BestHTTP.SocketIO.SupportedSocketIOVersions.v2);
                }
                else if (peerSocketVersion == PeerSocketVersion.V2_v3)
                {
                    ((NetworkingPeerSocketV2)this.networkingPeerBase).SetServerVersion(BestHTTP.SocketIO.SupportedSocketIOVersions.v3);
                }
            }

            this.networkingPeerBase.Init(gnServerSettings.SocketUrl, gnServerSettings.reconnectDelay, gnServerSettings.pingInterval, gnServerSettings.pingTimeout);
            this.networkingPeerBase.ReInitNewSocket();

            this.networkingPeerBase.SetOnEventHandler(OnEventHandler);
            this.networkingPeerBase.SetOnResponseHandler(OnResponseHandler);

            SubscriberServerEventHandler();
        }

        internal void SetOnConnectHandler(Action _onConnectHandler)
        {
            this.networkingPeerBase.SetOnConnectHandler(_onConnectHandler);
        }

        internal void SetOnDisconnectHandler(Action _onDisconnectHandler)
        {
            this.networkingPeerBase.SetOnDisconnectHandler(_onDisconnectHandler);
        }

        internal void RemoveOnConnectHandler(Action _onConnectHandler)
        {
            this.networkingPeerBase.RemoveOnConnectHandler(_onConnectHandler);
        }

        internal void RemoveOnDisconnectHandler(Action _onDisconnectHandler)
        {
            this.networkingPeerBase.RemoveOnDisconnectHandler(_onDisconnectHandler);
        }

        internal void Connect(Action _onSocketConnect)
        {
            this.networkingPeerBase.Connect(_onSocketConnect);
        }

        internal void Disconnect(Action _onSocketDisconnect)
        {
            this.networkingPeerBase.Close(_onSocketDisconnect);
        }

        internal void SetOnEventHandler(Action<OperationEvent> _onEventHandler)
        {
            this._onEventHandler = _onEventHandler;
        }

        internal override void Send(OperationPending operationPending)
        {
            base.Send(operationPending);

            GNDebug.Log("[GN Socket SEND] " + operationPending.GetOperationRequest().ToString());

            var operationRequest = operationPending.GetOperationRequest();

            var authToken = GNNetwork.authToken;

            if (string.IsNullOrEmpty(authToken))
            {
                if (!GNNetwork.gnServerSettings.codeCanSendNotAuthorized.Contains(operationRequest.GetOperationCode()))
                {
                    var obj = new GNArray();

                    obj.Add((int)ReturnCode.OperationNotAuthorized);
                    obj.Add(null);
                    obj.Add(operationRequest.GetRequestId());

                    OnResponseHandler(obj, operationRequest.IsEncrypted());

                    return;
                }
            }

            this.networkingPeerBase.Send(operationPending.GetOperationRequest());
        }

        internal void OnEventHandler(GNArray obj, bool isEncrypted)
        {
            var eventCode = obj.GetInt(0);

            var operationEvent = new OperationEvent(eventCode, obj.GetGNHashtable(1));
            operationEvent.SetEncrypted(isEncrypted);

            GNDebug.Log("[GN Socket EVENT] " + operationEvent.ToString());

            _onEventHandler?.Invoke(operationEvent);

            if (!this.serverEventHandlerDic.ContainsKey(eventCode))
            {
                return;
            }

            var serverEventHandler = this.serverEventHandlerDic[eventCode];
            serverEventHandler.Handle(operationEvent);
        }

        public override void Service()
        {
            base.Service();

            networkingPeerBase?.Service();
        }

        //internal static string Auth(BestHTTP.SocketIO3.SocketManager socketManager, BestHTTP.SocketIO3.Socket socket)
        //{
        //    return authTokenFormat.Replace("$authtoken", GNNetwork.authToken);
        //}

        //internal static string Auth(BestHTTP.SocketIO.SocketManager socketManager, BestHTTP.SocketIO.Socket socket)
        //{
        //    return authTokenFormat.Replace("$authtoken", GNNetwork.authToken);
        //}

    }

}
