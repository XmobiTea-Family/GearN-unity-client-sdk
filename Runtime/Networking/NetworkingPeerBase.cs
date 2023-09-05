namespace XmobiTea.GN.Networking
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

    public class NetworkingPeerBase : UnityEngine.MonoBehaviour
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

        internal virtual void Init(string url, int reconnectDelay, float pingInterval, float pingTimeout)
        {
            this.url = url;

            this.reconnectDelay = reconnectDelay;
            this.pingInterval = pingInterval;
            this.pingTimeout = pingTimeout;
        }

        #region Unity interface

        protected virtual void Awake()
        {
            this.clientId = string.Empty;

            this.messageLstLock = new object();
            this.responsePacketLst = new List<SocketPacket>();
            this.eventPacketLst = new List<SocketPacket>();
        }

        void OnApplicationQuit()
        {
            Close(null);
        }

        #endregion

        #region Public Interface

        internal virtual void Connect(Action _onSocketConnect)
        {
            this._onSocketConnect = _onSocketConnect;
        }

        internal virtual void Close(Action _onSocketDisconnect)
        {
            this._onSocketDisconnect = _onSocketDisconnect;
        }

        internal virtual void SendRequestAuthSocket()
        {

        }

        internal void Send(RequestType requestType, RequestRole requestRole, OperationRequest operationRequest, string authToken, string secretKey, GNHashtable customTags)
        {
            Emit(requestType, requestRole, operationRequest, authToken, secretKey, customTags);
        }

        protected virtual void Emit(RequestType requestType, RequestRole requestRole, OperationRequest operationRequest, string authToken, string secretKey, GNHashtable customTags) { }

        #endregion

        #region Private Methods

        internal virtual void ReInitNewSocket()
        {

        }

        internal void SetOnConnectHandler(Action _onConnectHandler)
        {
            this._onConnectHandler -= _onConnectHandler;
            this._onConnectHandler += _onConnectHandler;
        }

        internal void SetOnDisconnectHandler(Action _onDisconnectHandler)
        {
            this._onDisconnectHandler -= _onDisconnectHandler;
            this._onDisconnectHandler += _onDisconnectHandler;
        }

        internal void RemoveOnConnectHandler(Action _onConnectHandler)
        {
            this._onConnectHandler -= _onConnectHandler;
        }

        internal void RemoveOnDisconnectHandler(Action _onDisconnectHandler)
        {
            this._onDisconnectHandler -= _onDisconnectHandler;
        }

        internal void OnConnectHandler()
        {
            this._onConnectHandler?.Invoke();

            var authToken = GNNetwork.authToken;
            if (!string.IsNullOrEmpty(authToken))
            {
                SendRequestAuthSocket();
            }

            this._onSocketConnect?.Invoke();
            this._onSocketConnect = null;
        }

        internal void OnDisconnectHandler()
        {
            this._onDisconnectHandler?.Invoke();

            this._onSocketDisconnect?.Invoke();
            this._onSocketDisconnect = null;
        }

        internal void SetOnEventHandler(Action<GNArray, bool> _onEventHandler)
        {
            this._onEventHandler = _onEventHandler;
        }

        internal void OnEventHandler(GNArray obj, bool isEncrypted)
        {
            this._onEventHandler?.Invoke(obj, isEncrypted);
        }

        internal void SetOnResponseHandler(Action<GNArray, bool> _onResponseHandler)
        {
            this._onResponseHandler = _onResponseHandler;
        }

        internal void OnResponseHandler(GNArray obj, bool isEncrypted)
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

        internal void Service()
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
                                    .AddAll(NetworkingPeerBase.fromMsgList(iList))
                                    .Build();
                                OnResponseHandler(gnArray, responsePacket.encrypted);
                            }
                            catch (Exception ex)
                            {
                                GNDebug.LogException(ex);
                            }
                        }
                        else
                        {
                            try
                            {
                                var iList = responsePacket.obj;

                                var gnArray = new GNArray.Builder()
                                    .AddAll(NetworkingPeerBase.fromJsonList(iList))
                                    .Build();
                                OnResponseHandler(gnArray, responsePacket.encrypted);
                            }
                            catch (Exception ex)
                            {
                                GNDebug.LogException(ex);
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
                                    .AddAll(NetworkingPeerBase.fromMsgList(iList))
                                    .Build();
                                OnEventHandler(gnArray, eventPacket.encrypted);
                            }
                            catch (Exception ex)
                            {
                                GNDebug.LogException(ex);
                            }
                        }
                        else
                        {
                            try
                            {
                                var iList = eventPacket.obj;

                                var gnArray = new GNArray.Builder()
                                    .AddAll(NetworkingPeerBase.fromJsonList(iList))
                                    .Build();
                                OnEventHandler(gnArray, eventPacket.encrypted);
                            }
                            catch (Exception ex)
                            {
                                GNDebug.LogException(ex);
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
