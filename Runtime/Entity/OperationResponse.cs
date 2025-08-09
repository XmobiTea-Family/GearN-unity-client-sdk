namespace XmobiTea.GearN.Entity
{
    using System.Text;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Helper;

    /// <summary>
    /// Represents an operation response, encapsulating details such as operation code, return code, debug messages, and parameters.
    /// </summary>
    public class OperationResponse
    {
        private string operationCode;
        private int responseId;
        private int returnCode;
        private string debugMessage;
        private GNHashtable parameters;

        private InvalidMember[] invalidMembers;

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationResponse"/> class.
        /// </summary>
        /// <param name="operationCode">The operation code associated with the response.</param>
        /// <param name="responseId">The response ID.</param>
        /// <param name="encrypted">Indicates whether the response is encrypted.</param>
        public OperationResponse(string operationCode, int responseId)
        {
            this.operationCode = operationCode;
            this.responseId = responseId;
            this.parameters = new GNHashtable();
            this.debugMessage = null;
        }

        /// <summary>
        /// Gets the operation code of the response.
        /// </summary>
        public string getOperationCode() => this.operationCode;

        /// <summary>
        /// Gets the return code of the response.
        /// </summary>
        public int getReturnCode() => this.returnCode;

        /// <summary>
        /// Gets the parameters associated with the response.
        /// </summary>
        public GNHashtable getParameters() => this.parameters;

        /// <summary>
        /// Gets the response ID of the operation.
        /// </summary>
        public int getResponseId() => this.responseId;

        /// <summary>
        /// Gets the debug message, if any.
        /// </summary>
        public string getDebugMessage() => this.debugMessage;

        /// <summary>
        /// Gets the invalid members, if any, associated with the response.
        /// </summary>
        public InvalidMember[] getInvalidMembers() => this.invalidMembers;

        /// <summary>
        /// Determines whether the response has an error based on the return code.
        /// </summary>
        public bool hasError() => this.getReturnCode() != ReturnCode.Ok;

        /// <summary>
        /// Sets the return code for the response.
        /// </summary>
        /// <param name="returnCode">The return code to set.</param>
        /// <returns>The updated <see cref="OperationResponse"/> instance.</returns>
        public OperationResponse setReturnCode(int returnCode)
        {
            this.returnCode = returnCode;
            return this;
        }

        /// <summary>
        /// Sets the debug message for the response.
        /// </summary>
        /// <param name="debugMessage">The debug message to set.</param>
        /// <returns>The updated <see cref="OperationResponse"/> instance.</returns>
        public OperationResponse setDebugMessage(string debugMessage)
        {
            this.debugMessage = debugMessage;
            return this;
        }

        /// <summary>
        /// Adds or updates a parameter for the response.
        /// </summary>
        /// <param name="key">The parameter key.</param>
        /// <param name="value">The parameter value.</param>
        /// <returns>The updated <see cref="OperationResponse"/> instance.</returns>
        public OperationResponse setParameter(string key, object value)
        {
            if (this.parameters == null) this.parameters = new GNHashtable();
            this.parameters.add(key, value);
            return this;
        }

        /// <summary>
        /// Sets the parameters for the response.
        /// </summary>
        /// <param name="parameters">The parameters to set.</param>
        /// <returns>The updated <see cref="OperationResponse"/> instance.</returns>
        public OperationResponse setParameters(GNHashtable parameters)
        {
            this.parameters = parameters;
            return this;
        }

        /// <summary>
        /// Sets the invalid members for the response.
        /// </summary>
        /// <param name="invalidMembers">The invalid members to set.</param>
        /// <returns>The updated <see cref="OperationResponse"/> instance.</returns>
        public OperationResponse setInvalidMembers(InvalidMember[] invalidMembers)
        {
            this.invalidMembers = invalidMembers;
            return this;
        }

        /// <summary>
        /// Converts the operation response to a string representation.
        /// </summary>
        /// <returns>A string representation of the operation response.</returns>
        public string toString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("OperationCode: ")
                         .Append(this.operationCode)
                         .Append(", responseId: ")
                         .Append(this.responseId)
                         .Append(", returnCode: ")
                         .Append(CodeHelper.getReturnCodeName(this.returnCode));

            if (this.returnCode == ReturnCode.Ok)
            {
                stringBuilder.Append(", parameters: ").Append(this.parameters);
            }
            else if (this.returnCode == ReturnCode.InvalidRequestParameters)
            {
                if (this.invalidMembers != null)
                {
                    var invalidStr = string.Join(", ", this.invalidMembers);
                    stringBuilder.Append(", invalidMembers: ").Append(invalidStr);
                }
                else
                {
                    stringBuilder.Append(", invalidMembers: null");
                }
            }
            else
            {
                stringBuilder.Append(", debugMessage: ").Append(this.debugMessage);
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Returns a string that represents the current operation response.
        /// </summary>
        /// <returns>A string representation of the operation response.</returns>
        public override string ToString() => this.toString();
    }
}
