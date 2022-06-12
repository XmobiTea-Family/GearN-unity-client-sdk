namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;

    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;

    internal class PeerBase : MonoBehaviour, IPeer
    {
        private Queue<OperationPending> operationPendingQueue;

        private Dictionary<int, OperationPending> operationWaitingResponseDic;

        private static int requestId;

        private float perMsgTimer;
        private float nextSendMsgTimer;
        private float checkTimeoutOperationPending = 0;

        internal int sendRate
        {
            get => (int)(1000 / perMsgTimer);
            set => perMsgTimer = (float)1000 / value / 1000;
        }

        public void InitPeer()
        {
            if (operationWaitingResponseDic == null) operationWaitingResponseDic = new Dictionary<int, OperationPending>();
            if (operationPendingQueue == null) operationPendingQueue = new Queue<OperationPending>();

            InitSendRate();

            InitGNSocketObject();
        }

        private void InitSendRate()
        {
            var gnServerSettings = GNNetwork.gnServerSettings;
            if (gnServerSettings == null) throw new NullReferenceException("Null GN Server Settings, please find it now");

            this.sendRate = gnServerSettings.sendRate;
        }

        internal virtual void InitGNSocketObject()
        {

        }

        void IPeer.Enqueue(OperationRequest operationRequest, Action<OperationResponse> onOperationResponse)
        {
            var operationPending = new OperationPending(operationRequest, onOperationResponse);

            operationPendingQueue.Enqueue(operationPending);
        }

        protected virtual void Update()
        {
            if (checkTimeoutOperationPending < Time.time)
            {
                checkTimeoutOperationPending = Time.time + 0.1f;

                if (operationWaitingResponseDic.Count != 0)
                {
                    var gnArrayLst = new List<GNArray>();

                    foreach (var operationPendingPair in operationWaitingResponseDic)
                    {
                        var operationPending = operationPendingPair.Value;

                        if (operationPending.IsTimeout())
                        {
                            var gnArray = new GNArray();

                            gnArray.Add((int)ReturnCode.OperationTimeout);
                            gnArray.Add(null);
                            gnArray.Add(operationPending.GetOperationRequest().GetRequestId());

                            gnArrayLst.Add(gnArray);
                        }
                    }

                    if (gnArrayLst.Count != 0)
                    {
                        foreach (var gnArray in gnArrayLst)
                        {
                            OnResponseHandler(gnArray);
                        }
                    }
                }
            }

            if (nextSendMsgTimer < Time.time)
            {
                if (operationPendingQueue.Count != 0)
                {
                    nextSendMsgTimer = Time.time + perMsgTimer;

                    var operationPending = operationPendingQueue.Dequeue();

                    Send(operationPending);
                }
            }
        }

        internal void OnResponseHandler(GNArray obj)
        {
            var responseId = obj.GetInt(2);

            if (operationWaitingResponseDic.ContainsKey(responseId))
            {
                var operationPending = operationWaitingResponseDic[responseId];
                operationPending.OnRecv();

                operationWaitingResponseDic.Remove(responseId);

                var returnCode = obj.GetInt(0);

                GNHashtable parameters = null;
                string debugMessage = null;
                GNArray array = null;

                if (returnCode == ReturnCode.Ok) parameters = obj.GetGNHashtable(1);
                else if (returnCode == ReturnCode.InvalidRequestParameters) array = obj.GetGNArray(1);
                else debugMessage = obj.GetString(1);

                var operationRequest = operationPending.GetOperationRequest();
                var operationResponse = new OperationResponse(operationRequest.GetOperationCode(), operationRequest.GetRequestId());

                operationResponse.SetReturnCode(returnCode);
                operationResponse.SetDebugMessage(debugMessage);
                operationResponse.SetParameters(parameters);

                if (array != null)
                {
                    var invalidMembers = new InvalidMember[array.Count()];
                    for (var i = 0; i < array.Count(); i++)
                    {
                        var arrChild = array.GetGNArray(i);

                        invalidMembers[i] = new InvalidMember(arrChild.GetInt(0), (InvalidMemberType)arrChild.GetInt(1));
                    }
                    operationResponse.SetInvalidMembers(invalidMembers);
                }

                Debug.Log("[GN RECV] " + operationResponse.ToString());

                operationPending.GetCallback()?.Invoke(operationResponse);

                if (!operationResponse.HasError)
                {
                    AddPing(operationPending.GetExecuteTimerInMs());

                    if (parameters != null)
                    {
                        if (parameters.ContainsKey(ParameterCode.AuthToken))
                        {
                            var authToken = parameters.GetString(ParameterCode.AuthToken);

                            GNNetwork.authToken = authToken;
                        }

                        if (parameters.ContainsKey(ParameterCode.Ts))
                        {
                            GNNetwork.peer.SetServerTimeMilliseconds(parameters.GetLong(ParameterCode.Ts, DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()));
                        }
                    }
                }
            }
            else
            {
                Debug.LogError("OnResponseHandler " + obj);
            }
        }

        internal virtual void Send(OperationPending operationPending)
        {
            operationPending.OnSend();

            var operationRequest = operationPending.GetOperationRequest();
            if (operationRequest.GetRequestId() != -1)
            {
                operationRequest.SetRequestId(requestId++);

                if (operationPending.GetCallback() != null)
                {
                    operationWaitingResponseDic[operationRequest.GetRequestId()] = operationPending;
                }
            }
        }

        internal int Ping { get; private set; } = -1;
        private Queue<float> pingLst = new Queue<float>();

        private void AddPing(float value)
        {
            if (pingLst.Count > 10) pingLst.Dequeue();
            pingLst.Enqueue(value / 2);
            Ping = (int)(pingLst.Average() * 1000);
        }
    }
}
