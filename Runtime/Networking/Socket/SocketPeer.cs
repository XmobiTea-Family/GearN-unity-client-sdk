namespace XmobiTea.GearN.Networking.Socket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Config;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Logger;

    /// <summary>
    /// Manages socket communication for the application.
    /// </summary>
    internal class SocketPeer : PeerBase
    {
        private NetworkingSocketPeerBase networkingSocketPeerBase;
        private Dictionary<string, List<IServerEventHandler>> serverEventHandlersDict;
        private Action<OperationEvent> _onEventHandler;

        /// <summary>
        /// Gets the client ID of the socket connection.
        /// </summary>
        /// <returns>The client ID as a string.</returns>
        internal string getClientId()
        {
            return this.networkingSocketPeerBase?.clientId;
        }

        /// <summary>
        /// Checks if the socket connection is established.
        /// </summary>
        /// <returns>True if connected, otherwise false.</returns>
        internal bool isConnected()
        {
            return this.networkingSocketPeerBase.isWsConnected;
        }

        /// <summary>
        /// Sends an authentication request via the socket.
        /// </summary>
        internal void sendRequestAuthSocket()
        {
            this.networkingSocketPeerBase.sendRequestAuthSocket();
        }

        /// <summary>
        /// Subscribes server event handlers by scanning the current assembly.
        /// </summary>
        void subscriberServerEventHandler()
        {
            if (this.serverEventHandlersDict == null)
                this.serverEventHandlersDict = new Dictionary<string, List<IServerEventHandler>>();
            else
                this.serverEventHandlersDict.Clear();

            var type = typeof(IServerEventHandler);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p != type).ToList();

            foreach (var t in types)
            {
                var srvMsg = Activator.CreateInstance(t) as IServerEventHandler;
                if (srvMsg != null)
                {
                    if (!this.serverEventHandlersDict.TryGetValue(srvMsg.getEventCode(), out var serverEventHandlers))
                    {
                        serverEventHandlers = new List<IServerEventHandler>();

                        this.serverEventHandlersDict[srvMsg.getEventCode()] = serverEventHandlers;
                    }

                    serverEventHandlers.Add(srvMsg);
                }
            }
        }

        internal void subscriberAServerEventHandler(IServerEventHandler serverEventHandler)
        {
            if (!this.serverEventHandlersDict.TryGetValue(serverEventHandler.getEventCode(), out var serverEventHandlers))
            {
                serverEventHandlers = new List<IServerEventHandler>();

                this.serverEventHandlersDict[serverEventHandler.getEventCode()] = serverEventHandlers;
            }

            serverEventHandlers.Add(serverEventHandler);
        }

        /// <summary>
        /// Initializes the socket object with server settings.
        /// </summary>
        internal override void initGNSocketObject()
        {
            var gnServerSettings = GNNetwork.gnServerSettings;
            if (gnServerSettings == null) throw new NullReferenceException("Where is GN Server Settings");

            this.isUse = gnServerSettings.isUseSocket();

            if (!this.isUse) return;

            var peerSocketVersion = gnServerSettings.getPeerSocketVersion();

            if (peerSocketVersion == PeerSocketVersion.V3)
            {
#if UNITY_USING_BEST_HTTP
                this.networkingSocketPeerBase = new NetworkingPeerSocketV3();
#endif
            }
            else
            {
#if UNITY_USING_BEST_HTTP
                this.networkingSocketPeerBase = new NetworkingPeerSocketV2();

                if (peerSocketVersion == PeerSocketVersion.V2_v2)
                {
                    ((NetworkingPeerSocketV2)this.networkingSocketPeerBase).setServerVersion(BestHTTP.SocketIO.SupportedSocketIOVersions.v2);
                }
                else if (peerSocketVersion == PeerSocketVersion.V2_v3)
                {
                    ((NetworkingPeerSocketV2)this.networkingSocketPeerBase).setServerVersion(BestHTTP.SocketIO.SupportedSocketIOVersions.v3);
                }
#endif
            }

            if (this.networkingSocketPeerBase == null) throw new NullReferenceException("this.networkingSocketPeerBase null");

            this.networkingSocketPeerBase.init(gnServerSettings.getSocketUrl(), gnServerSettings.getReconnectDelay(), gnServerSettings.getPingInterval(), gnServerSettings.getPingTimeout());
            this.networkingSocketPeerBase.reInitNewSocket();

            this.networkingSocketPeerBase.setOnEventHandler(this.onEventHandler);
            this.networkingSocketPeerBase.setOnResponseHandler(this.onResponseHandler);

            this.subscriberServerEventHandler();
        }

        /// <summary>
        /// Sets a callback for when the socket connects.
        /// </summary>
        internal void setOnConnectHandler(Action _onConnectHandler)
        {
            this.networkingSocketPeerBase.setOnConnectHandler(_onConnectHandler);
        }

        /// <summary>
        /// Sets a callback for when the socket disconnects.
        /// </summary>
        internal void setOnDisconnectHandler(Action _onDisconnectHandler)
        {
            this.networkingSocketPeerBase.setOnDisconnectHandler(_onDisconnectHandler);
        }

        /// <summary>
        /// Removes the connection callback.
        /// </summary>
        internal void removeOnConnectHandler(Action _onConnectHandler)
        {
            this.networkingSocketPeerBase.removeOnConnectHandler(_onConnectHandler);
        }

        /// <summary>
        /// Removes the disconnection callback.
        /// </summary>
        internal void removeOnDisconnectHandler(Action _onDisconnectHandler)
        {
            this.networkingSocketPeerBase.removeOnDisconnectHandler(_onDisconnectHandler);
        }

        /// <summary>
        /// Connects the socket with a specified callback.
        /// </summary>
        internal void connect(Action _onSocketConnect)
        {
            this.networkingSocketPeerBase.connect(_onSocketConnect);
        }

        /// <summary>
        /// Disconnects the socket with a specified callback.
        /// </summary>
        internal void disconnect(Action _onSocketDisconnect)
        {
            this.networkingSocketPeerBase.close(_onSocketDisconnect);
        }

        /// <summary>
        /// Sets the event handler for incoming socket events.
        /// </summary>
        internal void setOnEventHandler(Action<OperationEvent> _onEventHandler)
        {
            this._onEventHandler = _onEventHandler;
        }

        /// <summary>
        /// Sends an operation request via the socket.
        /// </summary>
        internal override void send(OperationPending operationPending)
        {
            var gnServerSettings = GNNetwork.gnServerSettings;
            var operationRequest = operationPending.getOperationRequest();

            if (operationRequest.getTimeout() == OperationRequest.defaultTimeOut) operationRequest.setTimeout(gnServerSettings.getDefaultTimeoutInSeconds());

            base.send(operationPending);

            GNDebug.log("[GN Socket SEND] " + operationPending.getOperationRequest().ToString());

            var authToken = operationPending.getAuthToken();
            var secretKey = operationPending.getSecretKey();
            var gameId = operationPending.getGameId();
            var customTags = operationPending.getCustomTags();

            this.networkingSocketPeerBase.send(operationPending.getRequestType(), operationPending.getRole(), operationPending.getOperationRequest(), authToken, secretKey, customTags, gameId);
        }

        protected override void onEnqueue(OperationPending operationPending)
        {
            GNDebug.log("[GN Socket ENQUEUE] " + operationPending.getOperationRequest().ToString());
        }

        /// <summary>
        /// Handles incoming socket events and invokes appropriate handlers.
        /// </summary>
        internal void onEventHandler(GNHashtable obj)
        {
            var eventCode = obj.getString(ParameterCode.EventCode);

            var operationEvent = new OperationEvent(eventCode, obj.getGNHashtable(ParameterCode.Parameters));

            GNDebug.log("[GN Socket EVENT] " + operationEvent.toString());

            this._onEventHandler?.Invoke(operationEvent);

            if (!this.serverEventHandlersDict.ContainsKey(eventCode)) return;

            var serverEventHandlers = this.serverEventHandlersDict[eventCode];

            foreach (var serverEventHandler in serverEventHandlers)
                serverEventHandler.handle(operationEvent);
        }

        /// <summary>
        /// Processes socket service operations.
        /// </summary>
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
