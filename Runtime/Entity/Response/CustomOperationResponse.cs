namespace XmobiTea.GearN.Entity.Response
{
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Helper;

    /// <summary>
    /// Base class for handling custom operation responses.
    /// </summary>
    public abstract class CustomOperationResponse
    {
        public string operationCode { get; private set; }
        public GNHashtable parameters { get; private set; }
        public int returnCode { get; private set; }
        public string debugMessage { get; private set; }
        public int errorCode { get; private set; }
        public InvalidMember[] invalidMembers { get; private set; }

        /// <summary>
        /// Checks if the response contains a return code indicating an error.
        /// </summary>
        public bool hasReturnCodeError()
        {
            return this.returnCode != ReturnCode.Ok;
        }

        /// <summary>
        /// Configures the operation response using the provided `OperationResponse` object.
        /// </summary>
        /// <param name="operationResponse">The response from the operation to process.</param>
        public virtual void setupOperationResponse(OperationResponse operationResponse)
        {
            this.operationCode = operationResponse.getOperationCode();
            this.returnCode = operationResponse.getReturnCode();
            this.debugMessage = operationResponse.getDebugMessage();
            this.parameters = operationResponse.getParameters();
            this.invalidMembers = operationResponse.getInvalidMembers();

            // Extract error code if the return code does not indicate an error.
            if (!this.hasReturnCodeError())
            {
                this.errorCode = this.parameters.getInt(ParameterCode.ErrorCode);
            }
        }

        /// <summary>
        /// Returns a string representation of the response.
        /// </summary>
        public string toString()
        {
            return "ReturnCode: " + this.returnCode + " " + (this.parameters != null ? this.parameters.ToString() : this.debugMessage);
        }

        public override string ToString()
        {
            return this.toString();
        }
    }

    /// <summary>
    /// A generic variant of `CustomOperationResponse` that includes typed response data.
    /// </summary>
    /// <typeparam name="TResponseData">The type of the response data.</typeparam>
    public class CustomOperationResponse<TResponseData> : CustomOperationResponse
    {
        public TResponseData responseData { get; private set; }

        /// <summary>
        /// Configures the operation response and deserializes typed data if no errors are present.
        /// </summary>
        /// <param name="operationResponse">The response from the operation to process.</param>
        public override void setupOperationResponse(OperationResponse operationResponse)
        {
            base.setupOperationResponse(operationResponse);

            if (!this.hasReturnCodeError())
            {
                // Deserialize the parameters into the specified response data type.
                this.responseData = ConverterService.deserializeObject<TResponseData>(this.parameters);
            }
        }
    }
}
