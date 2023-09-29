namespace XmobiTea.GN.Networking.Socket
{
    using System;
    using System.Collections.Generic;

    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Logger;
    using XmobiTea.MsgPack;

    public class SocketPacket
    {
        public byte[] byteArr { get; private set; }
        public bool encrypted { get; private set; }
        public object obj { get; private set; }

        public SocketPacket(byte[] byteArr, bool encrypted)
        {
            this.byteArr = byteArr;
            this.encrypted = encrypted;
        }

        public SocketPacket(object obj, bool encrypted)
        {
            this.obj = obj;
            this.encrypted = encrypted;
        }
    }

    public abstract class NetworkingSocketPeerBase
    {
        #region Public Properties

        protected internal int reconnectDelay;
        protected internal float pingInterval;
        protected internal float pingTimeout;

        internal string clientId { get; set; }
        internal virtual bool isWsConnected { get; private set; }

        protected internal object messageLstLock;
        protected internal List<SocketPacket> responsePacketLst;
        protected internal List<SocketPacket> eventPacketLst;

        #endregion

        #region Private Properties

        protected string url;

        private Action<GNArray, bool> _onEventHandler;
        private Action<GNArray, bool> _onResponseHandler;

        private Action _onSocketConnect;
        private Action _onSocketDisconnect;

        private Action _onConnectHandler;
        private Action _onDisconnectHandler;

        #endregion

        internal virtual void init(string url, int reconnectDelay, float pingInterval, float pingTimeout)
        {
            this.url = url;

            this.reconnectDelay = reconnectDelay;
            this.pingInterval = pingInterval;
            this.pingTimeout = pingTimeout;
        }

        public NetworkingSocketPeerBase()
        {
            this.clientId = string.Empty;

            this.messageLstLock = new object();
            this.responsePacketLst = new List<SocketPacket>();
            this.eventPacketLst = new List<SocketPacket>();
        }

        #region Public Interface

        internal virtual void connect(Action _onSocketConnect)
        {
            this._onSocketConnect = _onSocketConnect;
        }

        internal virtual void close(Action _onSocketDisconnect)
        {
            this._onSocketDisconnect = _onSocketDisconnect;
        }

        internal virtual void sendRequestAuthSocket()
        {

        }

        internal void Send(RequestType requestType, RequestRole requestRole, OperationRequest operationRequest, string authToken, string secretKey, GNHashtable customTags)
        {
            this.emit(requestType, requestRole, operationRequest, authToken, secretKey, customTags);
        }

        protected virtual void emit(RequestType requestType, RequestRole requestRole, OperationRequest operationRequest, string authToken, string secretKey, GNHashtable customTags) { }

        #endregion

        #region Private Methods

        internal virtual void reInitNewSocket()
        {

        }

        internal void setOnConnectHandler(Action _onConnectHandler)
        {
            this._onConnectHandler -= _onConnectHandler;
            this._onConnectHandler += _onConnectHandler;
        }

        internal void setOnDisconnectHandler(Action _onDisconnectHandler)
        {
            this._onDisconnectHandler -= _onDisconnectHandler;
            this._onDisconnectHandler += _onDisconnectHandler;
        }

        internal void removeOnConnectHandler(Action _onConnectHandler)
        {
            this._onConnectHandler -= _onConnectHandler;
        }

        internal void removeOnDisconnectHandler(Action _onDisconnectHandler)
        {
            this._onDisconnectHandler -= _onDisconnectHandler;
        }

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

        internal void onDisconnectHandler()
        {
            this._onDisconnectHandler?.Invoke();

            this._onSocketDisconnect?.Invoke();
            this._onSocketDisconnect = null;
        }

        internal void setOnEventHandler(Action<GNArray, bool> _onEventHandler)
        {
            this._onEventHandler = _onEventHandler;
        }

        internal void onEventHandler(GNArray obj, bool isEncrypted)
        {
            this._onEventHandler?.Invoke(obj, isEncrypted);
        }

        internal void setOnResponseHandler(Action<GNArray, bool> _onResponseHandler)
        {
            this._onResponseHandler = _onResponseHandler;
        }

        internal void onResponseHandler(GNArray obj, bool isEncrypted)
        {
            this._onResponseHandler?.Invoke(obj, isEncrypted);
        }

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

        internal static System.Collections.IList fromJsonList(object objects)
        {
            return (System.Collections.IList)objects;
        }

        internal void service()
        {
            lock (this.messageLstLock)
            {
                if (this.responsePacketLst.Count > 0)
                {
                    for (var i = 0; i < this.responsePacketLst.Count; i++)
                    {
                        var responsePacket = this.responsePacketLst[i];

                        if (responsePacket.encrypted)
                        {
                            var byteArr = responsePacket.byteArr;

                            try
                            {
                                var iList = MsgPackSerializer.Deserialize<object[]>(byteArr);

                                var gnArray = new GNArray.Builder()
                                    .addAll(NetworkingSocketPeerBase.fromMsgList(iList))
                                    .build();
                                onResponseHandler(gnArray, responsePacket.encrypted);
                            }
                            catch (Exception ex)
                            {
                                GNDebug.logException(ex);
                            }
                        }
                        else
                        {
                            try
                            {
                                var iList = responsePacket.obj;

                                var gnArray = new GNArray.Builder()
                                    .addAll(NetworkingSocketPeerBase.fromJsonList(iList))
                                    .build();
                                onResponseHandler(gnArray, responsePacket.encrypted);
                            }
                            catch (Exception ex)
                            {
                                GNDebug.logException(ex);
                            }
                        }
                    }

                    this.responsePacketLst.Clear();
                }

                if (this.eventPacketLst.Count > 0)
                {
                    for (var i = 0; i < this.eventPacketLst.Count; i++)
                    {
                        var eventPacket = this.eventPacketLst[i];

                        if (eventPacket.encrypted)
                        {
                            var byteArr = eventPacket.byteArr;

                            try
                            {
                                var iList = MsgPackSerializer.Deserialize<object[]>(byteArr);

                                var gnArray = new GNArray.Builder()
                                    .addAll(NetworkingSocketPeerBase.fromMsgList(iList))
                                    .build();
                                onEventHandler(gnArray, eventPacket.encrypted);
                            }
                            catch (Exception ex)
                            {
                                GNDebug.logException(ex);
                            }
                        }
                        else
                        {
                            try
                            {
                                var iList = eventPacket.obj;

                                var gnArray = new GNArray.Builder()
                                    .addAll(NetworkingSocketPeerBase.fromJsonList(iList))
                                    .build();
                                onEventHandler(gnArray, eventPacket.encrypted);
                            }
                            catch (Exception ex)
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
