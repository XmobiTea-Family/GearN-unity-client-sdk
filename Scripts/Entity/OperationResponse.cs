namespace XmobiTea.GN.Entity
{
    using System.Text;

    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Helper;

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

        public int GetReturnCode()
        {
            return returnCode;
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

            stringBuilder.Append("Code: " + CodeHelper.GetOperationCodeName(operationCode) + " ResponseId: " + responseId + " ReturnCode " + CodeHelper.GetReturnCodeName(returnCode));

            if (returnCode == ReturnCode.Ok) stringBuilder.Append(" Parameters " + parameters);
            else stringBuilder.Append(" DebugMessage " + debugMessage);

            return stringBuilder.ToString();
        }
    }
}
