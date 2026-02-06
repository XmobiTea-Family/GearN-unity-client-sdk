namespace XmobiTea.GearN.Networking
{
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity;

    /// <summary>
    /// Defines the interface for managing peer communication.
    /// </summary>
    internal interface IPeer
    {
        /// <summary>
        /// Initializes the peer connection.
        /// </summary>
        void initPeer();

        /// <summary>
        /// Enqueues a request to be sent to the server.
        /// </summary>
        /// <param name="requestType">The type of request to send.</param>
        /// <param name="role">The role associated with the request.</param>
        /// <param name="operationRequest">The operation request object containing the request data.</param>
        /// <param name="onOperationResponse">The callback invoked upon receiving a response.</param>
        /// <param name="authToken">The authentication token to include with the request.</param>
        /// <param name="secretKey">The secret key to include with the request, if applicable.</param>
        /// <param name="customTags">Custom tags to be attached to the request.</param>
        void enqueue(RequestType requestType, RequestRole role, OperationRequest operationRequest, Action1<OperationResponse> onOperationResponse, string authToken, string secretKey, GNHashtable customTags, string gameId);

        /// <summary>
        /// Checks whether the peer is currently in use.
        /// </summary>
        /// <returns>True if the peer is in use, otherwise false.</returns>
        bool isUsing();

        /// <summary>
        /// Processes any pending requests or responses.
        /// </summary>
        void service();
    }
}
