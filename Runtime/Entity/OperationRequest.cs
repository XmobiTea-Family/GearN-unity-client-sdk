namespace XmobiTea.GearN.Entity
{
    using System.Text;
    using XmobiTea.GearN.Common;

    /// <summary>
    /// Represents an operation request, encapsulating details such as operation code, parameters, encryption, and timeout.
    /// </summary>
    public class OperationRequest
    {
        /// <summary>
        /// Default timeout for operation requests in seconds.
        /// </summary>
        public const int defaultTimeOut = 20;

        private string operationCode;
        private int requestId;
        private GNHashtable parameters;
        private int timeout;

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationRequest"/> class.
        /// </summary>
        /// <param name="operationCode">The code representing the operation.</param>
        /// <param name="timeout">Timeout duration for the request.</param>
        public OperationRequest(string operationCode, int timeout = OperationRequest.defaultTimeOut)
        {
            this.operationCode = operationCode;
            this.timeout = timeout;
        }

        /// <summary>
        /// Gets the operation code of the request.
        /// </summary>
        public string getOperationCode() => this.operationCode;

        /// <summary>
        /// Gets the request ID of the operation.
        /// </summary>
        public int getRequestId() => this.requestId;

        /// <summary>
        /// Gets the parameters associated with the operation.
        /// </summary>
        public GNHashtable getParameters() => this.parameters;

        /// <summary>
        /// Gets the timeout duration for the request.
        /// </summary>
        public int getTimeout() => this.timeout;

        /// <summary>
        /// Sets the request ID for the operation.
        /// </summary>
        /// <param name="requestId">The request ID to set.</param>
        /// <returns>The updated <see cref="OperationRequest"/> instance.</returns>
        public OperationRequest setRequestId(int requestId)
        {
            this.requestId = requestId;
            return this;
        }

        /// <summary>
        /// Adds or updates a parameter for the operation.
        /// </summary>
        /// <param name="key">The parameter key.</param>
        /// <param name="value">The parameter value.</param>
        /// <returns>The updated <see cref="OperationRequest"/> instance.</returns>
        public OperationRequest setParameter(string key, object value)
        {
            if (this.parameters == null) this.parameters = new GNHashtable();
            this.parameters.add(key, value);
            return this;
        }

        /// <summary>
        /// Sets the parameters for the operation.
        /// </summary>
        /// <param name="parameters">The parameters to set.</param>
        /// <returns>The updated <see cref="OperationRequest"/> instance.</returns>
        public OperationRequest setParameters(GNHashtable parameters)
        {
            this.parameters = parameters;
            return this;
        }

        /// <summary>
        /// Sets the timeout duration for the request.
        /// </summary>
        /// <param name="timeout">Timeout duration in seconds.</param>
        /// <returns>The updated <see cref="OperationRequest"/> instance.</returns>
        public OperationRequest setTimeout(int timeout)
        {
            this.timeout = timeout;
            return this;
        }

        /// <summary>
        /// Converts the operation request to a string representation.
        /// </summary>
        /// <returns>A string representation of the operation request.</returns>
        public string toString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("OperationCode: ")
                         .Append(this.operationCode)
                         .Append(", requestId: ")
                         .Append(this.requestId)
                         .Append(", parameters: ")
                         .Append(this.parameters);
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Returns a string that represents the current operation request.
        /// </summary>
        /// <returns>A string representation of the operation request.</returns>
        public override string ToString() => this.toString();
    }
}
