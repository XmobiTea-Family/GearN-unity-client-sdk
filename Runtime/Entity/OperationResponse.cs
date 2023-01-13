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

        public int GetOperationCode()
        {
            return this.operationCode;
        }

        public int GetReturnCode()
        {
            return this.returnCode;
        }

        public GNHashtable GetParameters()
        {
            return this.parameters;
        }

        public bool IsEncrypted()
        {
            return this.encrypted;
        }

        public int GetResponseId()
        {
            return this.responseId;
        }

        public string GetDebugMessage()
        {
            return this.debugMessage;
        }

        public InvalidMember[] GetInvalidMembers()
        {
            return this.invalidMembers;
        }

        public bool HasError() => this.GetReturnCode() != ReturnCode.Ok;

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

        public OperationResponse SetScriptData(string key, object value)
        {
            if (this.parameters == null) this.parameters = new GNHashtable();

            this.parameters.Add(key, value);

            return this;
        }

        public OperationResponse SetParameters(GNHashtable parameters)
        {
            this.parameters = parameters;
            return this;
        }

        public OperationResponse SetEncrypted(bool encrypted)
        {
            this.encrypted = encrypted;
            return this;
        }

        public OperationResponse SetInvalidMembers(InvalidMember[] invalidMembers)
        {
            this.invalidMembers = invalidMembers;
            return this;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("Code: " + CodeHelper.GetOperationCodeName(this.operationCode) + ", responseId: " + this.responseId + ", returnCode " + CodeHelper.GetReturnCodeName(this.returnCode));

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

            return stringBuilder.ToString();
        }

    }

}
