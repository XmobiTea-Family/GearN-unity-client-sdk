namespace XmobiTea.GN.Entity
{
    using System.Text;

    using UnityEngine;

    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Common;

    public class OperationResponse
    {
        private int operationCode;
        private int returnCode;
        private string debugMessage;
        private GNHashtable parameters;

        private int responseId;

        public int GetOperationCode()
        {
            return operationCode;
        }

        public ReturnCode GetReturnCode()
        {
            return (ReturnCode)returnCode;
        }

        public GNHashtable GetParameters()
        {
            return parameters;
        }

        public int GetResponseId()
        {
            return responseId;
        }

        public string GetDebugMessage()
        {
            return debugMessage;
        }

        public bool HasError => GetReturnCode() != ReturnCode.Ok;

        public OperationResponse(int operationCode, int responseId)
        {
            this.operationCode = operationCode;
            this.responseId = responseId;
        }

        public OperationResponse SetReturnCode(int returnCode)
        {
            this.returnCode = returnCode;
            return this;
        }

        public OperationResponse SetDebugMessage(string debugMessage)
        {
            this.debugMessage = debugMessage;
            return this;
        }

        public OperationResponse SetParameters(GNHashtable parameters)
        {
            this.parameters = parameters;
            return this;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("Code: " + GetOperationCode() + " ResponseId: " + responseId + " ReturnCode " + GetReturnCode() + " parameters " + parameters);

            return stringBuilder.ToString();
        }
    }
}
