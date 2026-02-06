namespace XmobiTea.GearN.Networking.Socket
{
    using System.Collections.Generic;

    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Helper;
    using XmobiTea.GearN.Logger;

    /// <summary>
    /// Represents a socket packet containing data and encryption information.
    /// </summary>
    public class SocketPacket
    {
        /// <summary>
        /// Gets the byte array of the packet data.
        /// </summary>
        public byte[] byteArr { get; private set; }

        /// <summary>
        /// Indicates whether the packet is encrypted.
        /// </summary>
        public bool isMsgPack { get; private set; }

        /// <summary>
        /// Gets the object data of the packet.
        /// </summary>
        public object obj { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SocketPacket"/> class with byte array data.
        /// </summary>
        /// <param name="byteArr">The byte array of the packet.</param>
        /// <param name="isMsgPack">Indicates whether the packet is MsgPack.</param>
        public SocketPacket(byte[] byteArr, bool isMsgPack)
        {
            this.byteArr = byteArr;
            this.isMsgPack = isMsgPack;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SocketPacket"/> class with object data.
        /// </summary>
        /// <param name="obj">The object data of the packet.</param>
        /// <param name="isMsgPack">Indicates whether the packet is MsgPack.</param>
        public SocketPacket(object obj, bool isMsgPack)
        {
            this.obj = obj;
            this.isMsgPack = isMsgPack;
        }
    }

    /// <summary>
    /// Base class for managing socket peer connections.
    /// </summary>
    public abstract class NetworkingSocketPeerBase
    {
        #region Public Properties

        /// <summary>
        /// The delay between reconnection attempts, in milliseconds.
        /// </summary>
        protected internal int reconnectDelay;

        /// <summary>
        /// The interval for ping messages, in seconds.
        /// </summary>
        protected internal float pingInterval;

        /// <summary>
        /// The timeout for ping messages, in seconds.
        /// </summary>
        protected internal float pingTimeout;

        /// <summary>
        /// Gets or sets the client ID for the connection.
        /// </summary>
        internal string clientId { get; set; }

        /// <summary>
        /// Gets whether the WebSocket connection is open.
        /// </summary>
        internal virtual bool isWsConnected { get; private set; }

        /// <summary>
        /// Lock object for message lists.
        /// </summary>
        protected internal object messageLstLock;

        /// <summary>
        /// List of response packets.
        /// </summary>
        protected internal List<SocketPacket> responsePacketLst;

        /// <summary>
        /// List of event packets.
        /// </summary>
        protected internal List<SocketPacket> eventPacketLst;

        #endregion

        #region Private Properties

        /// <summary>
        /// The server URL.
        /// </summary>
        protected string url;

        private Action1<GNHashtable> _onEventHandler;
        private Action1<GNHashtable> _onResponseHandler;
        private Action0 _onSocketConnect;
        private Action0 _onSocketDisconnect;
        private Action0 _onConnectHandler;
        private Action0 _onDisconnectHandler;

        #endregion

        /// <summary>
        /// Initializes the socket peer with the specified settings.
        /// </summary>
        /// <param name="url">The server URL.</param>
        /// <param name="reconnectDelay">Delay in milliseconds before reconnect attempts.</param>
        /// <param name="pingInterval">Ping interval in seconds.</param>
        /// <param name="pingTimeout">Ping timeout in seconds.</param>
        internal virtual void init(string url, int reconnectDelay, float pingInterval, float pingTimeout)
        {
            this.url = url;
            this.reconnectDelay = reconnectDelay;
            this.pingInterval = pingInterval;
            this.pingTimeout = pingTimeout;
        }

        /// <summary>
        /// Constructor for initializing the NetworkingSocketPeerBase class.
        /// </summary>
        public NetworkingSocketPeerBase()
        {
            this.clientId = string.Empty;
            this.messageLstLock = new object();
            this.responsePacketLst = new List<SocketPacket>();
            this.eventPacketLst = new List<SocketPacket>();
        }

        #region Public Interface

        /// <summary>
        /// Connects to the socket server.
        /// </summary>
        /// <param name="_onSocketConnect">Callback invoked upon successful connection.</param>
        internal virtual void connect(Action0 _onSocketConnect)
        {
            this._onSocketConnect = _onSocketConnect;
        }

        /// <summary>
        /// Closes the socket connection.
        /// </summary>
        /// <param name="_onSocketDisconnect">Callback invoked upon disconnection.</param>
        internal virtual void close(Action0 _onSocketDisconnect)
        {
            this._onSocketDisconnect = _onSocketDisconnect;
        }

        /// <summary>
        /// Sends an authentication request via the socket.
        /// </summary>
        internal virtual void sendRequestAuthSocket() { }

        /// <summary>
        /// Sends a request via the socket.
        /// </summary>
        /// <param name="requestType">The type of the request.</param>
        /// <param name="role">The role of the request.</param>
        /// <param name="operationRequest">The operation request object.</param>
        /// <param name="authToken">Authentication token, if applicable.</param>
        /// <param name="secretKey">Secret key, if applicable.</param>
        /// <param name="customTags">Custom tags for the request.</param>
        internal void send(RequestType requestType, RequestRole role, OperationRequest operationRequest, string authToken, string secretKey, GNHashtable customTags, string gameId)
        {
            this.emit(requestType, role, operationRequest, authToken, secretKey, customTags, gameId);
        }

        /// <summary>
        /// Emits a request to the socket.
        /// </summary>
        protected virtual void emit(RequestType requestType, RequestRole role, OperationRequest operationRequest, string authToken, string secretKey, GNHashtable customTags, string gameId) { }

        #endregion

        #region Private Methods

        /// <summary>
        /// Reinitializes the socket connection with a new configuration.
        /// </summary>
        internal virtual void reInitNewSocket() { }

        /// <summary>
        /// Sets the callback to be invoked when the socket connects.
        /// </summary>
        /// <param name="_onConnectHandler">The callback action.</param>
        internal void setOnConnectHandler(Action0 _onConnectHandler)
        {
            this._onConnectHandler -= _onConnectHandler;
            this._onConnectHandler += _onConnectHandler;
        }

        /// <summary>
        /// Sets the callback to be invoked when the socket disconnects.
        /// </summary>
        /// <param name="_onDisconnectHandler">The callback action.</param>
        internal void setOnDisconnectHandler(Action0 _onDisconnectHandler)
        {
            this._onDisconnectHandler -= _onDisconnectHandler;
            this._onDisconnectHandler += _onDisconnectHandler;
        }

        /// <summary>
        /// Removes the specified callback for socket connection events.
        /// </summary>
        /// <param name="_onConnectHandler">The callback action to remove.</param>
        internal void removeOnConnectHandler(Action0 _onConnectHandler)
        {
            this._onConnectHandler -= _onConnectHandler;
        }

        /// <summary>
        /// Removes the specified callback for socket disconnection events.
        /// </summary>
        /// <param name="_onDisconnectHandler">The callback action to remove.</param>
        internal void removeOnDisconnectHandler(Action0 _onDisconnectHandler)
        {
            this._onDisconnectHandler -= _onDisconnectHandler;
        }

        /// <summary>
        /// Invokes the connection handler and sends an authentication request if applicable.
        /// </summary>
        internal void onConnectHandler()
        {
            this._onConnectHandler?.Invoke();

            var authToken = GNNetwork.getAuthenticateStatus().getAuthToken();
            if (!string.IsNullOrEmpty(authToken))
            {
                this.sendRequestAuthSocket();
            }

            this._onSocketConnect?.Invoke();
            this._onSocketConnect = null;
        }

        /// <summary>
        /// Invokes the disconnection handler and cleans up associated resources.
        /// </summary>
        internal void onDisconnectHandler()
        {
            this._onDisconnectHandler?.Invoke();
            this._onSocketDisconnect?.Invoke();
            this._onSocketDisconnect = null;
        }

        /// <summary>
        /// Sets the handler for processing socket events.
        /// </summary>
        /// <param name="_onEventHandler">The event handler action.</param>
        internal void setOnEventHandler(Action1<GNHashtable> _onEventHandler)
        {
            this._onEventHandler = _onEventHandler;
        }

        /// <summary>
        /// Invokes the event handler with the specified data and encryption status.
        /// </summary>
        /// <param name="obj">The event data.</param>
        internal void onEventHandler(GNHashtable obj)
        {
            this._onEventHandler?.Invoke(obj);
        }

        /// <summary>
        /// Sets the handler for processing socket responses.
        /// </summary>
        /// <param name="_onResponseHandler">The response handler action.</param>
        internal void setOnResponseHandler(Action1<GNHashtable> _onResponseHandler)
        {
            this._onResponseHandler = _onResponseHandler;
        }

        /// <summary>
        /// Invokes the response handler with the specified data and encryption status.
        /// </summary>
        /// <param name="obj">The response data.</param>
        internal void onResponseHandler(GNHashtable obj)
        {
            this._onResponseHandler?.Invoke(obj);
        }
        /// <summary>
        /// Converts an array of key-value pairs to a dictionary.
        /// </summary>
        /// <param name="keyValuePairs">The array of key-value pairs to convert.</param>
        /// <returns>A dictionary representing the key-value pairs.</returns>
        internal static System.Collections.IDictionary fromMsgKeyValuePairs(KeyValuePair<object, object>[] keyValuePairs)
        {
            var answer = new Dictionary<object, object>();

            for (var i = 0; i < keyValuePairs.Length; i++)
            {
                var keyValuePair = keyValuePairs[i];

                var key = keyValuePair.Key;
                var value = keyValuePair.Value;

                if (value is KeyValuePair<object, object>[] keyValuePairs1)
                {
                    answer[key] = fromMsgKeyValuePairs(keyValuePairs1);
                }
                else if (value is object[] objects1)
                {
                    answer[key] = fromMsgList(objects1);
                }
                else
                {
                    answer[key] = value;
                }
            }

            return answer;
        }

        /// <summary>
        /// Converts an array of objects to a list.
        /// </summary>
        /// <param name="objects">The array of objects to convert.</param>
        /// <returns>A list representing the objects.</returns>
        internal static System.Collections.IList fromMsgList(object[] objects)
        {
            var answer = new List<object>();

            for (var i = 0; i < objects.Length; i++)
            {
                var value = objects[i];

                if (value is KeyValuePair<object, object>[] keyValuePairs1)
                {
                    answer.Add(fromMsgKeyValuePairs(keyValuePairs1));
                }
                else if (value is object[] objects1)
                {
                    answer.Add(fromMsgList(objects1));
                }
                else
                {
                    answer.Add(value);
                }
            }

            return answer;
        }

        //internal static System.Collections.IDictionary fromMsgKeyValuePair(KeyValuePair<object, object> keyValuePair)
        //{
        //    var answer = new Dictionary<object, object>();

        //    var key = keyValuePair.Key;
        //    var value = keyValuePair.Value;

        //    if (value is KeyValuePair<object, object>[] keyValuePairs1)
        //    {
        //        answer.Add(key, fromMsgKeyValuePairs(keyValuePairs1));
        //    }
        //    else if (value is object[] objects1)
        //    {
        //        answer.Add(key, fromMsgList(objects1));
        //    }

        //    return answer;
        //}

        internal static System.Collections.IDictionary fromMsgDict(object objects)
        {
            var answer = new Dictionary<object, object>();

            var value = objects;

            if (value is KeyValuePair<object, object>[] keyValuePairs1)
            {
                var dict = fromMsgKeyValuePairs(keyValuePairs1);

                foreach (var c in dict.Keys)
                {
                    answer.Add(c, dict[c]);
                }
            }
            else if (value is System.Collections.IDictionary iDict)
            {
                var dict = fromMsgDict(iDict);

                foreach (var c in dict.Keys)
                {
                    answer.Add(c, dict[c]);
                }
            }

            return answer;
        }

        /// <summary>
        /// Converts a JSON object to a list.
        /// </summary>
        /// <param name="objects">The JSON object to convert.</param>
        /// <returns>A list representing the JSON object.</returns>
        internal static System.Collections.IList fromJsonList(object objects)
        {
            return (System.Collections.IList)objects;
        }

        internal static System.Collections.IDictionary fromJsonDict(object objects)
        {
            return (System.Collections.IDictionary)objects;
        }

        /// <summary>
        /// Processes incoming response and event packets.
        /// </summary>
        internal void service()
        {
            lock (this.messageLstLock)
            {
                // Process response packets
                if (this.responsePacketLst.Count > 0)
                {
                    for (var i = 0; i < this.responsePacketLst.Count; i++)
                    {
                        var responsePacket = this.responsePacketLst[i];

                        if (responsePacket.isMsgPack)
                        {
                            var byteArr = responsePacket.byteArr;

                            try
                            {
                                var iDict = MessagePackConverterService.deserialize<Dictionary<string, object>>(byteArr);

                                var gnHashtable = new GNHashtable.Builder()
                                    .addAll(NetworkingSocketPeerBase.fromMsgDict(iDict))
                                    .build();
                                this.onResponseHandler(gnHashtable);
                            }
                            catch (System.Exception ex)
                            {
                                GNDebug.logException(ex);
                            }
                        }
                        else
                        {
                            try
                            {
                                var iDict = responsePacket.obj;
                                var gnHashtable = new GNHashtable.Builder()
                                    .addAll(NetworkingSocketPeerBase.fromJsonDict(iDict))
                                    .build();
                                this.onResponseHandler(gnHashtable);
                            }
                            catch (System.Exception ex)
                            {
                                GNDebug.logException(ex);
                            }
                        }
                    }

                    this.responsePacketLst.Clear();
                }

                // Process event packets
                if (this.eventPacketLst.Count > 0)
                {
                    for (var i = 0; i < this.eventPacketLst.Count; i++)
                    {
                        var eventPacket = this.eventPacketLst[i];

                        if (eventPacket.isMsgPack)
                        {
                            var byteArr = eventPacket.byteArr;

                            try
                            {
                                var iDict = MessagePackConverterService.deserialize<Dictionary<string, object>>(byteArr);

                                var gnHashtable = new GNHashtable.Builder()
                                    .addAll(NetworkingSocketPeerBase.fromMsgDict(iDict))
                                    .build();
                                this.onEventHandler(gnHashtable);
                            }
                            catch (System.Exception ex)
                            {
                                GNDebug.logException(ex);
                            }
                        }
                        else
                        {
                            try
                            {
                                var iDict = eventPacket.obj;

                                var gnHashtable = new GNHashtable.Builder()
                                    .addAll(NetworkingSocketPeerBase.fromJsonDict(iDict))
                                    .build();
                                this.onEventHandler(gnHashtable);
                            }
                            catch (System.Exception ex)
                            {
                                GNDebug.logException(ex);
                            }
                        }
                    }

                    this.eventPacketLst.Clear();
                }
            }
        }

        #endregion
    }
}
