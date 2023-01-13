namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Logger;

    internal class PeerBase : UnityEngine.MonoBehaviour, IPeer
    {
        private Queue<OperationPending> operationPendingQueue;

        private Dictionary<int, OperationPending> operationWaitingResponseDic;

        private static int requestId;

        private float perMsgTimer;
        private float nextSendMsgTimer;
        private float checkTimeoutOperationPending = 0;

        internal int sendRate
        {
            get => (int)(1000 / this.perMsgTimer);
            set => this.perMsgTimer = (float)1000 / value / 1000;
        }

        internal int ping { get; private set; } = -1;
        private Queue<float> pingLst = new Queue<float>();

        protected internal bool isUsing { get; protected set; }

        public void InitPeer()
        {
            if (this.operationWaitingResponseDic == null) this.operationWaitingResponseDic = new Dictionary<int, OperationPending>();
            if (this.operationPendingQueue == null) this.operationPendingQueue = new Queue<OperationPending>();

            this.InitSendRate();

            this.InitGNSocketObject();
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
            if (!this.isUsing)
            {
                GNDebug.LogError("[GN] Server Settings dont setup to use this to send operation request.");
                return;
            }

            var operationPending = new OperationPending(operationRequest, onOperationResponse);

            this.operationPendingQueue.Enqueue(operationPending);
        }

        bool IPeer.IsUsing()
        {
            return this.isUsing;
        }

        public virtual void Service()
        {
            if (!this.isUsing) return;

            if (this.checkTimeoutOperationPending < UnityEngine.Time.time)
            {
                this.checkTimeoutOperationPending = UnityEngine.Time.time + 0.1f;

                if (this.operationWaitingResponseDic.Count != 0)
                {
                    var gnArrayLst = new List<GNArray>();

                    foreach (var operationPendingPair in this.operationWaitingResponseDic)
                    {
                        var operationPending = operationPendingPair.Value;

                        if (operationPending.IsTimeout())
                        {
                            var gnArray = new GNArray();

                            gnArray.Add((int)ReturnCode.OperationTimeout);
                            gnArray.Add(null);
                            gnArray.Add(operationPending.GetOperationRequest().GetRequestId());
                            gnArray.Add(operationPending.GetOperationRequest().IsEncrypted());

                            gnArrayLst.Add(gnArray);
                        }
                    }

                    if (gnArrayLst.Count != 0)
                    {
                        foreach (var gnArray in gnArrayLst)
                        {
                            this.OnResponseHandler(gnArray, gnArray.GetBool(3));
                        }
                    }
                }
            }

            if (this.nextSendMsgTimer < UnityEngine.Time.time)
            {
                if (this.operationPendingQueue.Count != 0)
                {
                    this.nextSendMsgTimer = UnityEngine.Time.time + this.perMsgTimer;

                    var operationPending = this.operationPendingQueue.Dequeue();

                    this.Send(operationPending);
                }
            }
        }

        internal void OnResponseHandler(GNArray obj, bool isEncrypted)
        {
            var responseId = obj.GetInt(2);

            if (this.operationWaitingResponseDic.ContainsKey(responseId))
            {
                var operationPending = this.operationWaitingResponseDic[responseId];
                operationPending.OnRecv();

                this.operationWaitingResponseDic.Remove(responseId);

                var returnCode = obj.GetInt(0);

                GNHashtable parameters = null;
                string debugMessage = null;
                GNArray array = null;

                if (returnCode == ReturnCode.Ok) parameters = obj.GetGNHashtable(1);
                else if (returnCode == ReturnCode.InvalidRequestParameters) array = obj.GetGNArray(1);
                else if (returnCode == ReturnCode.OperationNotAuthorized)
                {
                    if (!string.IsNullOrEmpty(GNNetwork.authToken))
                    {
                        GNNetwork.authToken = string.Empty;
                        GNNetwork.userId = string.Empty;
                    }
                }
                else debugMessage = obj.GetString(1);

                var operationRequest = operationPending.GetOperationRequest();
                var operationResponse = new OperationResponse(operationRequest.GetOperationCode(), operationRequest.GetRequestId(), isEncrypted);

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

                GNDebug.Log("[GN RECV] " + operationResponse.ToString());

                operationPending.GetCallback()?.Invoke(operationResponse);

                if (!operationResponse.HasError())
                {
                    AddPing(operationPending.GetExecuteTimerInMs());

                    if (parameters != null)
                    {
                        if (parameters.ContainsKey(ParameterCode.AuthToken))
                        {
                            var authToken = parameters.GetString(ParameterCode.AuthToken);

                            GNNetwork.authToken = authToken;
                        }

                        if (parameters.ContainsKey(ParameterCode.UserId))
                        {
                            var userId = parameters.GetString(ParameterCode.UserId);

                            GNNetwork.userId = userId;
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
                GNDebug.LogError("[GN] OnResponseHandler, un available request id " + obj);
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
                    this.operationWaitingResponseDic[operationRequest.GetRequestId()] = operationPending;
                }
            }
        }

        private void AddPing(float value)
        {
            if (this.pingLst.Count > 10) this.pingLst.Dequeue();
            this.pingLst.Enqueue(value / 2);
            this.ping = (int)(this.pingLst.Average() * 1000);
        }

    }

}
