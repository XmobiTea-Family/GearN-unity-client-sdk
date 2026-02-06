namespace XmobiTea.GearN.Networking
{
    using System.Collections.Generic;
    using System.Linq;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Helper;
    using XmobiTea.GearN.Logger;

    /// <summary>
    /// Abstract base class for managing common functionalities of network peers.
    /// Implements the <see cref="IPeer"/> interface.
    /// </summary>
    internal abstract class PeerBase : IPeer
    {
        private Queue<OperationPending> operationPendingQueue; // Queue to store pending operations to be sent.
        private Dictionary<int, OperationPending> operationWaitingResponseDict; // Dictionary to track operations awaiting responses.

        private static int requestId; // Static counter for generating unique request IDs.

        private float perMsgTimer; // Interval between sending messages.
        private float nextSendMsgTimer; // Time for the next message to be sent.
        private float checkTimeoutOperationPending = 0; // Timer to check for timed-out operations.

        /// <summary>
        /// Gets the message send rate (messages per second).
        /// </summary>
        /// <returns>The send rate in messages per second.</returns>
        protected int getSendRate()
        {
            return (int)(1000 / this.perMsgTimer);
        }

        /// <summary>
        /// Sets the message send rate (messages per second).
        /// </summary>
        /// <param name="sendRate">The desired send rate in messages per second.</param>
        protected void setSendRate(int sendRate)
        {
            this.perMsgTimer = (float)1000 / sendRate / 1000;
        }

        /// <summary>
        /// Gets or sets the ping value for the connection.
        /// </summary>
        internal int ping { get; set; } = -1;

        private Queue<float> pingLst; // Queue to store recent ping values for averaging.

        /// <summary>
        /// Gets or sets whether this peer is in use.
        /// </summary>
        protected bool isUse { get; set; }

        /// <summary>
        /// Initializes the peer by setting up queues, dictionaries, and network objects.
        /// </summary>
        void IPeer.initPeer()
        {
            if (this.operationWaitingResponseDict == null)
                this.operationWaitingResponseDict = new Dictionary<int, OperationPending>();

            if (this.operationPendingQueue == null)
                this.operationPendingQueue = new Queue<OperationPending>();

            if (this.pingLst == null)
                this.pingLst = new Queue<float>();

            this.initSendRate();
            this.initGNSocketObject();
        }

        /// <summary>
        /// Initializes the message send rate based on the server settings.
        /// </summary>
        /// <exception cref="NullReferenceException">Thrown if server settings are not available.</exception>
        private void initSendRate()
        {
            var gnServerSettings = GNNetwork.gnServerSettings;
            if (gnServerSettings == null)
                throw new System.NullReferenceException("Null GN Server Settings, please find it now");

            this.setSendRate(gnServerSettings.getSendRate());
        }

        /// <summary>
        /// Initializes the GN socket object for derived classes.
        /// This method must be implemented in subclasses.
        /// </summary>
        internal abstract void initGNSocketObject();

        /// <summary>
        /// Enqueues an operation request for processing.
        /// </summary>
        /// <param name="requestType">The type of the request.</param>
        /// <param name="role">The role associated with the request.</param>
        /// <param name="operationRequest">The operation request to be enqueued.</param>
        /// <param name="onOperationResponse">The callback for the response.</param>
        /// <param name="authToken">The authentication token.</param>
        /// <param name="secretKey">The secret key, if applicable.</param>
        /// <param name="customTags">Custom tags for the operation.</param>
        void IPeer.enqueue(RequestType requestType, RequestRole role, OperationRequest operationRequest, Action1<OperationResponse> onOperationResponse, string authToken, string secretKey, GNHashtable customTags, string gameId)
        {
            if (!this.isUse)
            {
                GNDebug.logError("[GN] Server Settings don't setup to use this to send operation request.");
                return;
            }

            if (operationRequest.getRequestId() != -1) operationRequest.setRequestId(PeerBase.requestId++);

            var operationPending = new OperationPending(requestType, role, operationRequest, onOperationResponse, authToken, secretKey, customTags, gameId);
            this.operationPendingQueue.Enqueue(operationPending);

            onEnqueue(operationPending);
        }

        protected abstract void onEnqueue(OperationPending operationPending);

        /// <summary>
        /// Checks if this peer is in use.
        /// </summary>
        /// <returns>True if the peer is in use, otherwise false.</returns>
        bool IPeer.isUsing()
        {
            return this.isUse;
        }

        /// <summary>
        /// Processes pending operations and handles responses and timeouts.
        /// </summary>
        public virtual void service()
        {
            if (!this.isUse) return;

            // Check for timed-out operations.
            if (this.checkTimeoutOperationPending < UnityEngine.Time.time)
            {
                this.checkTimeoutOperationPending = UnityEngine.Time.time + 0.1f;

                if (this.operationWaitingResponseDict.Count != 0)
                {
                    var gnHashtableLst = new List<GNHashtable>();

                    foreach (var operationPendingPair in this.operationWaitingResponseDict)
                    {
                        var operationPending = operationPendingPair.Value;

                        if (operationPending.isTimeout())
                        {
                            var gnHashtable = new GNHashtable();

                            gnHashtable.add(ParameterCode.ReturnCode, ReturnCode.OperationTimeout);
                            gnHashtable.add(ParameterCode.Parameters, null);
                            gnHashtable.add(ParameterCode.ResponseId, operationPending.getOperationRequest().getRequestId());

                            gnHashtableLst.Add(gnHashtable);
                        }
                    }

                    if (gnHashtableLst.Count != 0)
                    {
                        foreach (var gnHashtable in gnHashtableLst)
                        {
                            this.onResponseHandler(gnHashtable);
                        }
                    }
                }
            }

            // Send the next pending message.
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

        /// <summary>
        /// Handles responses from the server.
        /// </summary>
        /// <param name="obj">The response object.</param>
        /// <param name="isEncrypted">Indicates if the response is encrypted.</param>
        internal void onResponseHandler(GNHashtable obj)
        {
            var responseId = obj.getInt(ParameterCode.ResponseId);

            if (this.operationWaitingResponseDict.ContainsKey(responseId))
            {
                var operationPending = this.operationWaitingResponseDict[responseId];
                operationPending.onRecv();

                this.operationWaitingResponseDict.Remove(responseId);

                var returnCode = obj.getInt(ParameterCode.ReturnCode);

                var parameters = obj.getGNHashtable(ParameterCode.Parameters);
                var debugMessage = obj.getString(ParameterCode.DebugMessage);
                var invalidRequestParameterArray = obj.getGNArray(ParameterCode.InvalidRequestParameters);

                var operationRequest = operationPending.getOperationRequest();
                var operationResponse = new OperationResponse(operationRequest.getOperationCode(), operationRequest.getRequestId());

                operationResponse.setReturnCode(returnCode);
                operationResponse.setDebugMessage(debugMessage);
                operationResponse.setParameters(parameters);

                //if (!parameters.containsKey(GNParameterCode.CustomTags)) parameters.add(GNParameterCode.CustomTags, customTags);

                if (invalidRequestParameterArray != null)
                {
                    var invalidMembers = new InvalidMember[invalidRequestParameterArray.count()];
                    for (var i = 0; i < invalidRequestParameterArray.count(); i++)
                    {
                        var arrChild = invalidRequestParameterArray.getGNArray(i);

                        invalidMembers[i] = new InvalidMember(arrChild.getString(0), (InvalidMemberType)arrChild.getInt(1));
                    }
                    operationResponse.setInvalidMembers(invalidMembers);
                }

                if (!operationResponse.hasError())
                {
                    this.addPing(operationPending.getExecuteTimerInMs());

                    if (parameters != null)
                    {
                        if (parameters.containsKey(ParameterCode.AuthToken))
                        {
                            var authToken = parameters.getString(ParameterCode.AuthToken);
                            GNNetwork.getAuthenticateStatus().setAuthToken(authToken);
                            StorageService.setString(GNNetwork.AUTH_TOKEN_KEY, authToken);
                        }

                        if (parameters.containsKey(ParameterCode.UserId))
                        {
                            var userId = parameters.getString(ParameterCode.UserId);
                            GNNetwork.getAuthenticateStatus().setUserId(userId);
                            StorageService.setString(GNNetwork.USER_ID_KEY, userId);
                        }

                        if (parameters.containsKey(ParameterCode.Ts))
                        {
                            GNNetwork.peer.setServerTimeMilliseconds(parameters.getLong(ParameterCode.Ts, System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()));
                        }
                    }
                }

                GNDebug.log("[GN RECV] " + operationResponse.ToString());

                operationPending.getCallback()?.Invoke(operationResponse);
            }
            else
            {
                GNDebug.logError("[GN] OnResponseHandler, unavailable request id " + obj);
            }
        }

        /// <summary>
        /// Sends the given operation request.
        /// </summary>
        /// <param name="operationPending">The operation request to be sent.</param>
        internal virtual void send(OperationPending operationPending)
        {
            operationPending.onSend();

            var operationRequest = operationPending.getOperationRequest();

            if (operationRequest.getRequestId() != -1)
            {
                if (operationPending.getCallback() != null)
                {
                    this.operationWaitingResponseDict[operationRequest.getRequestId()] = operationPending;
                }
            }
        }

        /// <summary>
        /// Adds a ping measurement for the current operation.
        /// </summary>
        /// <param name="value">The ping value in milliseconds.</param>
        private void addPing(float value)
        {
            if (this.pingLst.Count > 10)
                this.pingLst.Dequeue();

            this.pingLst.Enqueue(value / 2);
            this.ping = (int)(this.pingLst.Average() * 1000);
        }

    }

}
