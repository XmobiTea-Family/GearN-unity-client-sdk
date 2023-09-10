namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Logger;

    internal abstract class PeerBase : UnityEngine.MonoBehaviour, IPeer
    {
        private Queue<OperationPending> operationPendingQueue;

        private Dictionary<int, OperationPending> operationWaitingResponseDic;

        private static int requestId;

        private float perMsgTimer;
        private float nextSendMsgTimer;
        private float checkTimeoutOperationPending = 0;

        protected int getSendRate()
        {
            return (int)(1000 / this.perMsgTimer);
        }

        protected void setSendRate(int sendRate)
        {
            this.perMsgTimer = (float)1000 / sendRate / 1000;
        }

        internal int ping { get; set; } = -1;
        private Queue<float> pingLst = new Queue<float>();

        protected bool isUse { get; set; }

        void IPeer.initPeer()
        {
            if (this.operationWaitingResponseDic == null) this.operationWaitingResponseDic = new Dictionary<int, OperationPending>();
            if (this.operationPendingQueue == null) this.operationPendingQueue = new Queue<OperationPending>();

            this.initSendRate();
            this.initGNSocketObject();
        }

        private void initSendRate()
        {
            var gnServerSettings = GNNetwork.gnServerSettings;
            if (gnServerSettings == null) throw new NullReferenceException("Null GN Server Settings, please find it now");

            this.setSendRate(gnServerSettings.getSendRate());
        }

        internal abstract void initGNSocketObject();

        void IPeer.enqueue(RequestType requestType, RequestRole requestRole, OperationRequest operationRequest, Action<OperationResponse> onOperationResponse, string authToken, string secretKey, GNHashtable customTags)
        {
            if (!this.isUse)
            {
                GNDebug.logError("[GN] Server Settings dont setup to use this to send operation request.");
                return;
            }

            var operationPending = new OperationPending(requestType, requestRole, operationRequest, onOperationResponse, authToken, secretKey, customTags);
            this.operationPendingQueue.Enqueue(operationPending);
        }

        bool IPeer.isUsing()
        {
            return this.isUse;
        }

        public virtual void service()
        {
            if (!this.isUse) return;

            if (this.checkTimeoutOperationPending < UnityEngine.Time.time)
            {
                this.checkTimeoutOperationPending = UnityEngine.Time.time + 0.1f;

                if (this.operationWaitingResponseDic.Count != 0)
                {
                    var gnArrayLst = new List<GNArray>();

                    foreach (var operationPendingPair in this.operationWaitingResponseDic)
                    {
                        var operationPending = operationPendingPair.Value;

                        if (operationPending.isTimeout())
                        {
                            var gnArray = new GNArray();

                            gnArray.add((int)ReturnCode.OperationTimeout);
                            gnArray.add(null);
                            gnArray.add(operationPending.getOperationRequest().getRequestId());
                            gnArray.add(operationPending.getOperationRequest().isEncrypted());

                            gnArrayLst.Add(gnArray);
                        }
                    }

                    if (gnArrayLst.Count != 0)
                    {
                        foreach (var gnArray in gnArrayLst)
                        {
                            this.onResponseHandler(gnArray, gnArray.getBool(3));
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

                    this.send(operationPending);
                }
            }
        }

        internal void onResponseHandler(GNArray obj, bool isEncrypted)
        {
            var responseId = obj.getInt(2);

            if (this.operationWaitingResponseDic.ContainsKey(responseId))
            {
                var operationPending = this.operationWaitingResponseDic[responseId];
                operationPending.onRecv();

                this.operationWaitingResponseDic.Remove(responseId);

                var returnCode = obj.getInt(0);

                GNHashtable parameters = null;
                string debugMessage = null;
                GNArray array = null;

                if (returnCode == ReturnCode.Ok) parameters = obj.getGNHashtable(1);
                else if (returnCode == ReturnCode.InvalidRequestParameters) array = obj.getGNArray(1);
                else if (returnCode == ReturnCode.OperationNotAuthorized)
                {

                }
                else debugMessage = obj.getString(1);

                var operationRequest = operationPending.getOperationRequest();
                var operationResponse = new OperationResponse(operationRequest.getOperationCode(), operationRequest.getRequestId(), isEncrypted);

                operationResponse.setReturnCode(returnCode);
                operationResponse.setDebugMessage(debugMessage);
                operationResponse.setParameters(parameters);

                //if (!parameters.containsKey(GNParameterCode.CustomTags)) parameters.add(GNParameterCode.CustomTags, customTags);

                if (array != null)
                {
                    var invalidMembers = new InvalidMember[array.count()];
                    for (var i = 0; i < array.count(); i++)
                    {
                        var arrChild = array.getGNArray(i);

                        invalidMembers[i] = new InvalidMember(arrChild.getInt(0), (InvalidMemberType)arrChild.getInt(1));
                    }
                    operationResponse.setInvalidMembers(invalidMembers);
                }

                if (!operationResponse.hasError())
                {
                    addPing(operationPending.getExecuteTimerInMs());

                    if (parameters != null)
                    {
                        if (parameters.containsKey(ParameterCode.AuthToken))
                        {
                            var authToken = parameters.getString(ParameterCode.AuthToken);

                            GNNetwork.getAuthenticateStatus().setAuthToken(authToken);

                            PlayerPrefs.SetString(GNNetwork.AUTH_TOKEN_KEY, authToken);
                        }

                        if (parameters.containsKey(ParameterCode.UserId))
                        {
                            var userId = parameters.getString(ParameterCode.UserId);

                            GNNetwork.getAuthenticateStatus().setUserId(userId);

                            PlayerPrefs.SetString(GNNetwork.AUTH_TOKEN_KEY, userId);
                        }

                        if (parameters.containsKey(ParameterCode.Ts))
                        {
                            GNNetwork.peer.setServerTimeMilliseconds(parameters.getLong(ParameterCode.Ts, DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()));
                        }
                    }
                }

                GNDebug.log("[GN RECV] " + operationResponse.ToString());

                operationPending.getCallback()?.Invoke(operationResponse);
            }
            else
            {
                GNDebug.logError("[GN] OnResponseHandler, un available request id " + obj);
            }
        }

        internal virtual void send(OperationPending operationPending)
        {
            operationPending.onSend();

            var operationRequest = operationPending.getOperationRequest();

            if (operationRequest.getRequestId() != -1)
            {
                operationRequest.setRequestId(PeerBase.requestId++);

                if (operationPending.getCallback() != null)
                {
                    this.operationWaitingResponseDic[operationRequest.getRequestId()] = operationPending;
                }
            }
        }

        private void addPing(float value)
        {
            if (this.pingLst.Count > 10) this.pingLst.Dequeue();
            this.pingLst.Enqueue(value / 2);
            this.ping = (int)(this.pingLst.Average() * 1000);
        }
    }

}
