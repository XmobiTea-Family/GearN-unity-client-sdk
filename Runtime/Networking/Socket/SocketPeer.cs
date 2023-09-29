namespace XmobiTea.GN.Networking.Socket
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
        private NetworkingSocketPeerBase networkingSocketPeerBase;


        private Dictionary<int, List<IServerEventHandler>> serverEventHandlersDict;

        private Action<OperationEvent> _onEventHandler;

        internal string getClientId()
        {
            return this.networkingSocketPeerBase?.clientId;
        }

        internal bool isConnected()
        {
            return this.networkingSocketPeerBase.isWsConnected;
        }

        internal void sendRequestAuthSocket()
        {
            this.networkingSocketPeerBase.sendRequestAuthSocket();
        }

        void subscriberServerEventHandler()
        {
            if (this.serverEventHandlersDict == null) this.serverEventHandlersDict = new Dictionary<int, List<IServerEventHandler>>();
            else this.serverEventHandlersDict.Clear();

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

                    if (!this.serverEventHandlersDict.ContainsKey(srvMsg.getEventCode()))
                    {
                        serverEventHandlers = new List<IServerEventHandler>();

                        this.serverEventHandlersDict[srvMsg.getEventCode()] = serverEventHandlers;
                    }
                    else
                    {
                        serverEventHandlers = this.serverEventHandlersDict[srvMsg.getEventCode()];
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
                this.networkingSocketPeerBase = new NetworkingPeerSocketV3();
            }
            else
            {
                this.networkingSocketPeerBase = new NetworkingPeerSocketV2();

                if (peerSocketVersion == PeerSocketVersion.V2_v2)
                {
                    ((NetworkingPeerSocketV2)this.networkingSocketPeerBase).setServerVersion(BestHTTP.SocketIO.SupportedSocketIOVersions.v2);
                }
                else if (peerSocketVersion == PeerSocketVersion.V2_v3)
                {
                    ((NetworkingPeerSocketV2)this.networkingSocketPeerBase).setServerVersion(BestHTTP.SocketIO.SupportedSocketIOVersions.v3);
                }
            }

            this.networkingSocketPeerBase.init(gnServerSettings.getSocketUrl(), gnServerSettings.getReconnectDelay(), gnServerSettings.getPingInterval(), gnServerSettings.getPingTimeout());
            this.networkingSocketPeerBase.reInitNewSocket();

            this.networkingSocketPeerBase.setOnEventHandler(this.onEventHandler);
            this.networkingSocketPeerBase.setOnResponseHandler(this.onResponseHandler);

            this.subscriberServerEventHandler();
        }

        internal void setOnConnectHandler(Action _onConnectHandler)
        {
            this.networkingSocketPeerBase.setOnConnectHandler(_onConnectHandler);
        }

        internal void setOnDisconnectHandler(Action _onDisconnectHandler)
        {
            this.networkingSocketPeerBase.setOnDisconnectHandler(_onDisconnectHandler);
        }

        internal void removeOnConnectHandler(Action _onConnectHandler)
        {
            this.networkingSocketPeerBase.removeOnConnectHandler(_onConnectHandler);
        }

        internal void removeOnDisconnectHandler(Action _onDisconnectHandler)
        {
            this.networkingSocketPeerBase.removeOnDisconnectHandler(_onDisconnectHandler);
        }

        internal void connect(Action _onSocketConnect)
        {
            this.networkingSocketPeerBase.connect(_onSocketConnect);
        }

        internal void disconnect(Action _onSocketDisconnect)
        {
            this.networkingSocketPeerBase.close(_onSocketDisconnect);
        }

        internal void setOnEventHandler(Action<OperationEvent> _onEventHandler)
        {
            this._onEventHandler = _onEventHandler;
        }

        internal override void send(OperationPending operationPending)
        {
            base.send(operationPending);

            GNDebug.log("[GN Socket SEND] " + operationPending.getOperationRequest().ToString());

            var authToken = operationPending.getAuthToken();
            var secretKey = operationPending.getSecretKey();
            var customTags = operationPending.getCustomTags();

            this.networkingSocketPeerBase.Send(operationPending.getRequestType(), operationPending.getRequestRole(), operationPending.getOperationRequest(), authToken, secretKey, customTags);
        }

        internal void onEventHandler(GNArray obj, bool isEncrypted)
        {
            var eventCode = obj.getInt(0);

            var operationEvent = new OperationEvent(eventCode, obj.getGNHashtable(1));
            operationEvent.setEncrypted(isEncrypted);

            GNDebug.log("[GN Socket EVENT] " + operationEvent.toString());

            this._onEventHandler?.Invoke(operationEvent);

            if (!this.serverEventHandlersDict.ContainsKey(eventCode))
            {
                return;
            }

            var serverEventHandlers = this.serverEventHandlersDict[eventCode];

            foreach (var serverEventHandler in serverEventHandlers)
                serverEventHandler.handle(operationEvent);
        }

        public override void service()
        {
            base.service();

            this.networkingSocketPeerBase?.service();
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
