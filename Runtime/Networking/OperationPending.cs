namespace XmobiTea.GearN.Networking
{
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity;

    /// <summary>
    /// Represents a pending operation request, including metadata and timing information.
    /// </summary>
    public struct OperationPending
    {
        private OperationRequest operationRequest; // The operation request to be processed.
        private RequestType requestType;           // The type of the request.
        private RequestRole role;           // The role associated with the request.
        private string authToken;                  // The authentication token for the request.
        private string secretKey;                  // The secret key for the request, if applicable.
        private string gameId;                     // The game id for the request
        private GNHashtable customTags;            // Custom tags to be sent with the request.
        private Action1<OperationResponse> onOperationResponse; // The callback for handling the operation response.
        private long timeout;                     // The timeout for the operation.

        private long firstSend;                   // The timestamp of the first send attempt.
        private long secondsSend;                 // The timestamp of the response receipt.

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationPending"/> struct.
        /// </summary>
        /// <param name="requestType">The type of the request.</param>
        /// <param name="role">The role associated with the request.</param>
        /// <param name="operationRequest">The operation request data.</param>
        /// <param name="onOperationResponse">The callback for the response.</param>
        /// <param name="authToken">The authentication token.</param>
        /// <param name="secretKey">The secret key, if applicable.</param>
        /// <param name="customTags">Custom tags for the request.</param>
        public OperationPending(RequestType requestType, RequestRole role, OperationRequest operationRequest, Action1<OperationResponse> onOperationResponse, string authToken, string secretKey, GNHashtable customTags, string gameId)
        {
            this.operationRequest = operationRequest;
            this.onOperationResponse = onOperationResponse;
            this.timeout = System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + (int)(OperationRequest.defaultTimeOut * 1000);
            this.firstSend = 0;
            this.secondsSend = 0;

            this.requestType = requestType;
            this.role = role;
            this.authToken = authToken;
            this.secretKey = secretKey;
            this.gameId = gameId;
            this.customTags = customTags;
        }

        /// <summary>
        /// Gets the request type.
        /// </summary>
        /// <returns>The request type.</returns>
        public RequestType getRequestType()
        {
            return this.requestType;
        }

        /// <summary>
        /// Gets the request role.
        /// </summary>
        /// <returns>The request role.</returns>
        public RequestRole getRole()
        {
            return this.role;
        }

        /// <summary>
        /// Gets the authentication token for the request.
        /// </summary>
        /// <returns>The authentication token.</returns>
        public string getAuthToken()
        {
            return this.authToken;
        }

        /// <summary>
        /// Gets the secret key for the request.
        /// </summary>
        /// <returns>The secret key.</returns>
        public string getSecretKey()
        {
            return this.secretKey;
        }

        /// <summary>
        /// Gets the game id with the request.
        /// </summary>
        /// <returns>the game id.</returns>
        public string getGameId()
        {
            return this.gameId;
        }

        /// <summary>
        /// Gets the custom tags associated with the request.
        /// </summary>
        /// <returns>A GNHashtable containing the custom tags.</returns>
        public GNHashtable getCustomTags()
        {
            return this.customTags;
        }

        /// <summary>
        /// Marks the request as sent and updates the timeout.
        /// </summary>
        public void onSend()
        {
            this.firstSend = System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            this.timeout = this.firstSend + (int)(this.operationRequest.getTimeout() * 1000);
        }

        /// <summary>
        /// Marks the request as having received a response.
        /// </summary>
        public void onRecv()
        {
            this.secondsSend = System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        }

        /// <summary>
        /// Gets the execution time of the request in milliseconds.
        /// </summary>
        /// <returns>The execution time in milliseconds.</returns>
        public float getExecuteTimerInMs()
        {
            return this.secondsSend - this.firstSend;
        }

        /// <summary>
        /// Determines whether the operation has timed out.
        /// </summary>
        /// <returns>True if the operation has timed out; otherwise, false.</returns>
        public bool isTimeout()
        {
            return this.timeout < System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        }

        /// <summary>
        /// Gets the operation request associated with this pending operation.
        /// </summary>
        /// <returns>The operation request.</returns>
        public OperationRequest getOperationRequest()
        {
            return this.operationRequest;
        }

        /// <summary>
        /// Gets the callback for handling the operation response.
        /// </summary>
        /// <returns>The response callback action.</returns>
        public Action1<OperationResponse> getCallback()
        {
            return this.onOperationResponse;
        }
    }
}
