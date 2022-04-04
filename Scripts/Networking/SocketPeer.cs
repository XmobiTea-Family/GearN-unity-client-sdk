namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Config;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;

    internal class SocketPeer : PeerBase
    {
        private const string AuthTokenFormat = "{\"authtoken\":$authtoken}";

        private NetworkingPeerBase networkingPeerBase;

        internal string ClientId => networkingPeerBase?.ClientId;

        internal bool IsConnected => networkingPeerBase.IsWsConnected;

        private Dictionary<int, IServerEventHandler> serverEventHandlerDic;

        internal void SendRequestAuthSocket()
        {
            networkingPeerBase.SendRequestAuthSocket();
        }

        void SubscriberServerEventHandler()
        {
            var type = typeof(IServerEventHandler);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p != type).ToList();

            foreach (var t in types)
            {
                var srvMsg = Activator.CreateInstance(t) as IServerEventHandler;
                if (srvMsg != null) serverEventHandlerDic[srvMsg.GetEventCode()] = srvMsg;
            }
        }

        internal override void InitGNSocketObject()
        {
            base.InitGNSocketObject();

            var gnServerSettings = GNNetwork.gnServerSettings;
            if (gnServerSettings == null) throw new NullReferenceException("Where is GN Server Settings");

            var peerSocketVersion = gnServerSettings.peerSocketVersion;

            if (peerSocketVersion == PeerSocketVersion.V3)
            {
                networkingPeerBase = this.gameObject.AddComponent<NetworkingPeerSocketV3>();
            }
            else
            {
                networkingPeerBase = this.gameObject.AddComponent<NetworkingPeerSocketV2>();

                if (peerSocketVersion == PeerSocketVersion.V2_v2)
                {
                    ((NetworkingPeerSocketV2)networkingPeerBase).SetServerVersion(BestHTTP.SocketIO.SupportedSocketIOVersions.v2);
                }
                else if (peerSocketVersion == PeerSocketVersion.V2_v3)
                {
                    ((NetworkingPeerSocketV2)networkingPeerBase).SetServerVersion(BestHTTP.SocketIO.SupportedSocketIOVersions.v3);
                }
            }

            networkingPeerBase.Init(gnServerSettings.SocketUrl, gnServerSettings.reconnectDelay, gnServerSettings.pingInterval, gnServerSettings.pingTimeout);
            networkingPeerBase.ReInitNewSocket();
            networkingPeerBase.Connect();

            networkingPeerBase.SetOnEventHandler(OnEventHandler);
            networkingPeerBase.SetOnResponseHandler(OnResponseHandler);

            SubscriberServerEventHandler();
        }

        internal override void Send(OperationPending operationPending)
        {
            base.Send(operationPending);

            Debug.Log("[GN SOCKET SEND] " + operationPending.GetOperationRequest().ToString());

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

                    OnResponseHandler(obj);

                    return;
                }
            }

            networkingPeerBase.Send(operationPending.GetOperationRequest());
        }

        internal void OnEventHandler(GNArray obj)
        {
            var eventCode = obj.GetInt(0);
            if (!serverEventHandlerDic.ContainsKey(eventCode))
            {
                return;
            }

            var operationEvent = new OperationEvent(eventCode, obj.GetGNHashtable(1));

            Debug.Log("[GN SOCKET EVENT] " + operationEvent.ToString());

            var serverEventHandler = serverEventHandlerDic[eventCode];
            serverEventHandler.Handle(operationEvent);
        }

        internal static string Auth(BestHTTP.SocketIO3.SocketManager socketManager, BestHTTP.SocketIO3.Socket socket)
        {
            return AuthTokenFormat.Replace("$authtoken", GNNetwork.authToken);
        }

        internal static string Auth(BestHTTP.SocketIO.SocketManager socketManager, BestHTTP.SocketIO.Socket socket)
        {
            return AuthTokenFormat.Replace("$authtoken", GNNetwork.authToken);
        }
    }
}
