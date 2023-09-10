namespace XmobiTea.GN.Entity
{
    using System.Text;

    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Helper;

    public class OperationResponse
    {
        private int operationCode;
        private int responseId;
        private int returnCode;
        private string debugMessage;
        private GNHashtable parameters;
        private bool encrypted;

        private InvalidMember[] invalidMembers;

        public OperationResponse(int operationCode, int responseId, bool encrypted = true)
        {
            this.operationCode = operationCode;
            this.responseId = responseId;
            this.encrypted = encrypted;
            this.parameters = new GNHashtable();
            this.debugMessage = null;
        }

        public int getOperationCode()
        {
            return this.operationCode;
        }

        public int getReturnCode()
        {
            return this.returnCode;
        }

        public GNHashtable getParameters()
        {
            return this.parameters;
        }

        public bool isEncrypted()
        {
            return this.encrypted;
        }

        public int getResponseId()
        {
            return this.responseId;
        }

        public string getDebugMessage()
        {
            return this.debugMessage;
        }

        public InvalidMember[] getInvalidMembers()
        {
            return this.invalidMembers;
        }

        public bool hasError() => this.getReturnCode() != ReturnCode.Ok;

        public OperationResponse setReturnCode(int returnCode)
        {
            this.returnCode = returnCode;
            return this;
        }

        public OperationResponse setDebugMessage(string debugMessage)
        {
            this.debugMessage = debugMessage;
            return this;
        }

        public OperationResponse setParameter(string key, object value)
        {
            if (this.parameters == null) this.parameters = new GNHashtable();

            this.parameters.add(key, value);

            return this;
        }

        public OperationResponse setParameters(GNHashtable parameters)
        {
            this.parameters = parameters;
            return this;
        }

        public OperationResponse setEncrypted(bool encrypted)
        {
            this.encrypted = encrypted;
            return this;
        }

        public OperationResponse setInvalidMembers(InvalidMember[] invalidMembers)
        {
            this.invalidMembers = invalidMembers;
            return this;
        }

        public string toString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("Code: " + CodeHelper.getOperationCodeName(this.operationCode) + ", responseId: " + this.responseId + ", returnCode " + CodeHelper.getReturnCodeName(this.returnCode));

            if (this.returnCode == ReturnCode.Ok) stringBuilder.Append(", parameters " + this.parameters);
            else if (this.returnCode == ReturnCode.InvalidRequestParameters)
            {
                if (this.invalidMembers != null)
                {
                    var invalidStr = string.Empty;

                    foreach (var invalidMember in this.invalidMembers)
                    {
                        invalidStr += invalidMember;
                    }

                    stringBuilder.Append(", invalidMembers " + invalidStr);
                }
                else stringBuilder.Append(", invalidMembers " + this.invalidMembers);
            }
            else stringBuilder.Append(", debugMessage " + this.debugMessage);

            stringBuilder.Append(", encrypted " + this.encrypted);

            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return this.toString();
        }

    }

}
