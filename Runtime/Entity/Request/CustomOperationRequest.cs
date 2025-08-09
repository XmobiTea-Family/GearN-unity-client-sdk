namespace XmobiTea.GearN.Entity.Request
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Helper;

    /// <summary>
    /// Base class for creating custom operation requests.
    /// </summary>
    public abstract class CustomOperationRequest
    {
        /// <summary>
        /// The operation code for the request.
        /// </summary>
        protected abstract string operationCode { get; }

        /// <summary>
        /// The type of request (e.g., Socket, HTTP).
        /// </summary>
        protected abstract RequestType requestType { get; }

        /// <summary>
        /// The role of the request (e.g., Client, Admin, Server).
        /// </summary>
        protected abstract RequestRole role { get; }

        /// <summary>
        /// Timeout value for the operation request.
        /// </summary>
        protected int operationTimeout { get; }

        /// <summary>
        /// Gets the request type for the operation.
        /// </summary>
        public RequestType getRequestType()
        {
            return this.requestType;
        }

        /// <summary>
        /// Gets the request role for the operation.
        /// </summary>
        public RequestRole getRole()
        {
            return this.role;
        }

        /// <summary>
        /// Constructor to initialize the operation timeout.
        /// </summary>
        /// <param name="timeout">Timeout in seconds for the operation.</param>
        public CustomOperationRequest(int timeout)
        {
            this.operationTimeout = timeout;
        }

        /// <summary>
        /// Builds the operation request with the provided data and settings.
        /// </summary>
        /// <returns>An `OperationRequest` object.</returns>
        public abstract OperationRequest build();
    }

    /// <summary>
    /// Generic base class for creating custom operation requests with strongly-typed request data.
    /// </summary>
    /// <typeparam name="TRequestData">The type of the request data.</typeparam>
    public abstract class CustomOperationRequest<TRequestData> : CustomOperationRequest where TRequestData : new()
    {
        /// <summary>
        /// Data associated with the request.
        /// </summary>
        public TRequestData requestData { get; }

        /// <summary>
        /// Constructor to initialize with a new instance of request data and a timeout.
        /// </summary>
        /// <param name="timeout">Timeout in seconds for the operation.</param>
        public CustomOperationRequest(int timeout) : base(timeout)
        {
            this.requestData = new TRequestData();
        }

        /// <summary>
        /// Constructor to initialize with an existing request data object and a timeout.
        /// </summary>
        /// <param name="requestData">The existing request data object.</param>
        /// <param name="timeout">Timeout in seconds for the operation.</param>
        public CustomOperationRequest(TRequestData requestData, int timeout) : base(timeout)
        {
            this.requestData = requestData;
        }

        /// <summary>
        /// Builds the operation request with serialized data and configured settings.
        /// </summary>
        /// <returns>An `OperationRequest` object with serialized request data.</returns>
        public override OperationRequest build()
        {
            var request = new OperationRequest(this.operationCode, this.operationTimeout);

            // Serialize the requestData into the parameters of the request.
            request.setParameters(ConverterService.serializeObject(this.requestData));

            return request;
        }
    }
}
