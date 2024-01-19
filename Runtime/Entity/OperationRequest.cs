namespace XmobiTea.GN.Entity
{
    using System.Text;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Helper;

    /// <summary>
    /// Represents an operation request, encapsulating details such as operation code, parameters, encryption, and timeout.
    /// </summary>
    public class OperationRequest
    {
        /// <summary>
        /// Default timeout for operation requests in seconds.
        /// </summary>
        public const int defaultTimeOut = 15;

        private int operationCode;
        private int requestId;
        private GNHashtable parameters;
        private bool encrypted;
        private int timeout;

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationRequest"/> class.
        /// </summary>
        /// <param name="operationCode">The code representing the operation.</param>
        /// <param name="encrypted">Indicates whether the request is encrypted.</param>
        /// <param name="timeout">Timeout duration for the request.</param>
        public OperationRequest(int operationCode, bool encrypted = true, int timeout = defaultTimeOut)
        {
            this.operationCode = operationCode;
            this.encrypted = encrypted;
            this.timeout = timeout;
        }

        /// <summary>
        /// Gets the operation code of the request.
        /// </summary>
        public int getOperationCode() => this.operationCode;

        /// <summary>
        /// Gets the request ID of the operation.
        /// </summary>
        public int getRequestId() => this.requestId;

        /// <summary>
        /// Gets the parameters associated with the operation.
        /// </summary>
        public GNHashtable getParameters() => this.parameters;

        /// <summary>
        /// Determines whether the request is encrypted.
        /// </summary>
        public bool isEncrypted() => this.encrypted;

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
        /// Sets whether the request is encrypted.
        /// </summary>
        /// <param name="encrypted">True if the request should be encrypted; otherwise false.</param>
        /// <returns>The updated <see cref="OperationRequest"/> instance.</returns>
        public OperationRequest setEncrypted(bool encrypted)
        {
            this.encrypted = encrypted;
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
            stringBuilder.Append("Code: ")
                         .Append(CodeHelper.getOperationCodeName(this.operationCode))
                         .Append(", requestId: ")
                         .Append(this.requestId)
                         .Append(", parameters: ")
                         .Append(this.parameters)
                         .Append(", encrypted: ")
                         .Append(this.encrypted);
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Returns a string that represents the current operation request.
        /// </summary>
        /// <returns>A string representation of the operation request.</returns>
        public override string ToString() => this.toString();
    }
}
