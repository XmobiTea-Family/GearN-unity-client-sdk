namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;

    using UnityEngine;

    using XmobiTea.GN.Common;
    using XmobiTea.GN.Entity;

    public class NetworkingPeerBase : MonoBehaviour
    {
        #region Public Properties

        protected int reconnectDelay;
        protected float pingInterval;
        protected float pingTimeout;

        internal string clientId { get; set; }
        internal virtual bool isWsConnected { get; private set; }

        #endregion

        #region Private Properties

        protected string url;

        private Action<GNArray> _onEventHandler;
        private Action<GNArray> _onResponseHandler;

        private Action _onRecvSIdHandler;

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
            clientId = string.Empty;

            Debug.Log("NetworkingPeerBase Awake");
        }

        void OnApplicationQuit()
        {
            Close();
        }

        #endregion

        #region Public Interface

        internal virtual void Connect()
        {

        }

        internal virtual void Close()
        {

        }

        internal virtual void SendRequestAuthSocket()
        {

        }

        internal void Send(OperationRequest operationRequest)
        {
            Emit(operationRequest);
        }

        protected virtual void Emit(OperationRequest operationRequest) { }

        #endregion

        #region Private Methods

        internal virtual void ReInitNewSocket()
        {

        }

        internal void SetOnConnectHandler(Action _onRecvSIdHandler)
        {
            this._onRecvSIdHandler = _onRecvSIdHandler;
        }

        internal void OnConnectHandler()
        {
            this._onRecvSIdHandler?.Invoke();

            var authToken = GNNetwork.authToken;
            if (!string.IsNullOrEmpty(authToken))
            {
                SendRequestAuthSocket();
            }
        }

        internal void SetOnEventHandler(Action<GNArray> _onEventHandler)
        {
            this._onEventHandler = _onEventHandler;
        }

        internal void OnEventHandler(GNArray obj)
        {
            _onEventHandler?.Invoke(obj);
        }

        internal void SetOnResponseHandler(Action<GNArray> _onResponseHandler)
        {
            this._onResponseHandler = _onResponseHandler;
        }

        internal void OnResponseHandler(GNArray obj)
        {
            _onResponseHandler?.Invoke(obj);
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

        #endregion
    }
}
