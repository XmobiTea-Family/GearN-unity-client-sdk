namespace XmobiTea.GearN.Networking
{
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity;

    /// <summary>
    /// Manages networking peers for HTTP and socket communication.
    /// </summary>
    public partial class NetworkingPeer
    {
        private IPeer socketPeer; // Socket peer instance.
        private IPeer httpPeer;   // HTTP peer instance.

        internal AuthenticateStatus authenticateStatus; // Stores authentication status.
        internal string gameId;

        /// <summary>
        /// Calculates and returns the average ping between HTTP and socket peers.
        /// </summary>
        /// <returns>The average ping in milliseconds.</returns>
        internal int getPing()
        {
            var count = 0;
            var totalPing = 0;

            if (this.httpPeer.isUsing())
            {
                count++;
                totalPing += ((PeerBase)this.httpPeer).ping;
            }

            if (this.socketPeer.isUsing())
            {
                count++;
                totalPing += ((PeerBase)this.socketPeer).ping;
            }

            return count > 0 ? totalPing / count : -1;
        }

        /// <summary>
        /// Gets the client ID of the socket connection.
        /// </summary>
        /// <returns>The client ID as a string.</returns>
        internal string getClientId()
        {
            return (this.socketPeer as Socket.SocketPeer).getClientId();
        }

        private long lastCurrentServerMilliseconds; // The last known server time in milliseconds.
        private float lastGetCurrentMilliseconds;  // The local time in seconds when the server time was last updated.

        /// <summary>
        /// Sets the current server time in milliseconds.
        /// </summary>
        /// <param name="currentServerMilliseconds">The server time in milliseconds.</param>
        internal void setServerTimeMilliseconds(long currentServerMilliseconds)
        {
            this.lastCurrentServerMilliseconds = currentServerMilliseconds;
            this.lastGetCurrentMilliseconds = System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        }

        /// <summary>
        /// Gets the current server timestamp in milliseconds.
        /// </summary>
        /// <returns>The current server timestamp.</returns>
        internal long getServerTimestamp()
        {
            return this.lastCurrentServerMilliseconds + (int)(System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - this.lastGetCurrentMilliseconds);
        }

        /// <summary>
        /// Initializes the HTTP and socket peers.
        /// </summary>
        internal void initPeer()
        {
            this.setServerTimeMilliseconds(System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());

            var gnServerSettings = GNNetwork.gnServerSettings;
            if (gnServerSettings == null) throw new System.NullReferenceException("Null GN Server Settings, please find it now");

            this.authenticateStatus = new AuthenticateStatus();

            this.httpPeer = new Http.HttpPeer();
            this.httpPeer.initPeer();

            this.socketPeer = new Socket.SocketPeer();
            this.socketPeer.initPeer();
        }

        /// <summary>
        /// Processes pending operations for both HTTP and socket peers.
        /// </summary>
        internal void service()
        {
            this.httpPeer?.service();
            this.socketPeer?.service();
        }

        /// <summary>
        /// Sends a request via socket peer.
        /// </summary>
        internal void sendViaSocket(RequestType requestType, RequestRole role, OperationRequest request, Action1<OperationResponse> onResponse = null, string authToken = null, string secretKey = null, GNHashtable customTags = null)
        {
            if (authToken == null) authToken = GNNetwork.getAuthenticateStatus().getAuthToken();
            if (secretKey == null)
            {
                if (role == RequestRole.Admin) secretKey = GNNetwork.gnServerSettings.getAdminSecretKey();
                else if (role == RequestRole.Server) secretKey = GNNetwork.gnServerSettings.getServerSecretKey();
                else if (role == RequestRole.Client) secretKey = GNNetwork.gnServerSettings.getClientSecretKey();
            }

            this.socketPeer.enqueue(requestType, role, request, onResponse, authToken, secretKey, customTags, this.gameId);
        }

        /// <summary>
        /// Sends a request via HTTP peer.
        /// </summary>
        internal void sendViaHttp(RequestType requestType, RequestRole role, OperationRequest request, Action1<OperationResponse> onResponse = null, string authToken = null, string secretKey = null, GNHashtable customTags = null)
        {
            if (authToken == null) authToken = this.authenticateStatus.getAuthToken();
            if (secretKey == null)
            {
                if (role == RequestRole.Admin) secretKey = GNNetwork.gnServerSettings.getAdminSecretKey();
                else if (role == RequestRole.Server) secretKey = GNNetwork.gnServerSettings.getServerSecretKey();
                else if (role == RequestRole.Client) secretKey = GNNetwork.gnServerSettings.getClientSecretKey();
            }

            this.httpPeer.enqueue(requestType, role, request, onResponse, authToken, secretKey, customTags, this.gameId);
        }

        /// <summary>
        /// Sends an authentication request via socket.
        /// </summary>
        internal void sendRequestAuthSocket()
        {
            (this.socketPeer as Socket.SocketPeer).sendRequestAuthSocket();
        }

        /// <summary>
        /// Connects to the socket with a specified callback.
        /// </summary>
        internal void connectSocket(Action0 _onSocketConnect)
        {
            (this.socketPeer as Socket.SocketPeer).connect(_onSocketConnect);
        }

        /// <summary>
        /// Disconnects the socket with a specified callback.
        /// </summary>
        internal void disconnectSocket(Action0 _onSocketDisconnect)
        {
            (this.socketPeer as Socket.SocketPeer).disconnect(_onSocketDisconnect);
        }

        /// <summary>
        /// Sets the handler for processing socket events.
        /// </summary>
        internal void setOnEventHandler(Action1<OperationEvent> _onEventHandler)
        {
            (this.socketPeer as Socket.SocketPeer).setOnEventHandler(_onEventHandler);
        }

        /// <summary>
        /// Sets a handler for socket connection events.
        /// </summary>
        internal void setOnConnectHandler(Action0 _onConnectHandler)
        {
            (this.socketPeer as Socket.SocketPeer).setOnConnectHandler(_onConnectHandler);
        }

        /// <summary>
        /// Sets a handler for socket disconnection events.
        /// </summary>
        internal void setOnDisconnectHandler(Action0 _onDisconnectHandler)
        {
            (this.socketPeer as Socket.SocketPeer).setOnDisconnectHandler(_onDisconnectHandler);
        }

        /// <summary>
        /// Removes the handler for socket connection events.
        /// </summary>
        internal void removeOnConnectHandler(Action0 _onConnectHandler)
        {
            (this.socketPeer as Socket.SocketPeer).removeOnConnectHandler(_onConnectHandler);
        }

        /// <summary>
        /// Removes the handler for socket disconnection events.
        /// </summary>
        internal void removeOnDisconnectHandler(Action0 _onDisconnectHandler)
        {
            (this.socketPeer as Socket.SocketPeer).removeOnDisconnectHandler(_onDisconnectHandler);
        }

        internal void subscriberServerEventHandler(IServerEventHandler serverEventHandler)
        {
            (this.socketPeer as Socket.SocketPeer).subscriberAServerEventHandler(serverEventHandler);
        }

    }

}
