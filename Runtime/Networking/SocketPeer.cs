namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Config;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Logger;

    internal class SocketPeer : PeerBase
    {
        private NetworkingPeerBase networkingPeerBase;

        internal string getClientId() => this.networkingPeerBase?.clientId;

        internal bool isConnected() => this.networkingPeerBase.isWsConnected;

        private Dictionary<int, List<IServerEventHandler>> serverEventHandlersDic;

        private Action<OperationEvent> _onEventHandler;

        internal void sendRequestAuthSocket()
        {
            this.networkingPeerBase.sendRequestAuthSocket();
        }

        void subscriberServerEventHandler()
        {
            if (this.serverEventHandlersDic == null) this.serverEventHandlersDic = new Dictionary<int, List<IServerEventHandler>>();
            else this.serverEventHandlersDic.Clear();

            var type = typeof(IServerEventHandler);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p != type).ToList();

            foreach (var t in types)
            {
                var srvMsg = Activator.CreateInstance(t) as IServerEventHandler;
                if (srvMsg != null)
                {
                    List<IServerEventHandler> serverEventHandlers;

                    if (!this.serverEventHandlersDic.ContainsKey(srvMsg.getEventCode()))
                    {
                        serverEventHandlers = new List<IServerEventHandler>();

                        this.serverEventHandlersDic[srvMsg.getEventCode()] = serverEventHandlers;
                    }
                    else
                    {
                        serverEventHandlers = this.serverEventHandlersDic[srvMsg.getEventCode()];
                    }

                    serverEventHandlers.Add(srvMsg);
                }
            }
        }

        internal override void initGNSocketObject()
        {
            var gnServerSettings = GNNetwork.gnServerSettings;
            if (gnServerSettings == null) throw new NullReferenceException("Where is GN Server Settings");

            this.isUse = gnServerSettings.isUseSocket();

            var peerSocketVersion = gnServerSettings.getPeerSocketVersion();

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

            this.networkingPeerBase.init(gnServerSettings.getSocketUrl(), gnServerSettings.getReconnectDelay(), gnServerSettings.getPingInterval(), gnServerSettings.getPingTimeout());
            this.networkingPeerBase.reInitNewSocket();

            this.networkingPeerBase.setOnEventHandler(this.onEventHandler);
            this.networkingPeerBase.setOnResponseHandler(this.onResponseHandler);

            this.subscriberServerEventHandler();
        }

        internal void setOnConnectHandler(Action _onConnectHandler)
        {
            this.networkingPeerBase.setOnConnectHandler(_onConnectHandler);
        }

        internal void setOnDisconnectHandler(Action _onDisconnectHandler)
        {
            this.networkingPeerBase.setOnDisconnectHandler(_onDisconnectHandler);
        }

        internal void removeOnConnectHandler(Action _onConnectHandler)
        {
            this.networkingPeerBase.removeOnConnectHandler(_onConnectHandler);
        }

        internal void removeOnDisconnectHandler(Action _onDisconnectHandler)
        {
            this.networkingPeerBase.removeOnDisconnectHandler(_onDisconnectHandler);
        }

        internal void connect(Action _onSocketConnect)
        {
            this.networkingPeerBase.connect(_onSocketConnect);
        }

        internal void disconnect(Action _onSocketDisconnect)
        {
            this.networkingPeerBase.close(_onSocketDisconnect);
        }

        internal void setOnEventHandler(Action<OperationEvent> _onEventHandler)
        {
            this._onEventHandler = _onEventHandler;
        }

        internal override void send(OperationPending operationPending)
        {
            base.send(operationPending);

            GNDebug.log("[GN Socket SEND] " + operationPending.getOperationRequest().ToString());

            //var operationRequest = operationPending.getOperationRequest();

            //if (string.IsNullOrEmpty(authToken))
            //{
            //    if (!this.isOperationCanSendWithoutAuthorized(operationRequest.getOperationCode()))
            //    {
            //        var obj = new GNArray();

            //        obj.add((int)ReturnCode.OperationNotAuthorized);
            //        obj.add(null);
            //        obj.add(operationRequest.getRequestId());

            //        onResponseHandler(obj, operationRequest.isEncrypted());

            //        return;
            //    }
            //}

            var authToken = operationPending.getAuthToken();
            var secretKey = operationPending.getSecretKey();
            var customTags = operationPending.getCustomTags();

            this.networkingPeerBase.Send(operationPending.getRequestType(), operationPending.getRequestRole(), operationPending.getOperationRequest(), authToken, secretKey, customTags);
        }

        internal void onEventHandler(GNArray obj, bool isEncrypted)
        {
            var eventCode = obj.getInt(0);

            var operationEvent = new OperationEvent(eventCode, obj.getGNHashtable(1));
            operationEvent.setEncrypted(isEncrypted);

            GNDebug.log("[GN Socket EVENT] " + operationEvent.toString());

            this._onEventHandler?.Invoke(operationEvent);

            if (!this.serverEventHandlersDic.ContainsKey(eventCode))
            {
                return;
            }

            var serverEventHandlers = this.serverEventHandlersDic[eventCode];

            foreach (var serverEventHandler in serverEventHandlers)
                serverEventHandler.handle(operationEvent);
        }

        public override void service()
        {
            base.service();

            this.networkingPeerBase?.service();
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
