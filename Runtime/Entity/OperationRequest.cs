namespace XmobiTea.GN.Entity
{
    using System.Text;

    using XmobiTea.GN.Common;
    using XmobiTea.GN.Helper;

    public class OperationRequest
    {
        public const int DefaultTimeOut = 15;

        private int operationCode;
        private int requestId;
        private GNHashtable parameters;
        private bool encrypted;
        private int timeout;

        public bool IsValidRequest()
        {
            return true;
        }

        public OperationRequest(int operationCode, bool encrypted = true, int timeout = DefaultTimeOut)
        {
            this.operationCode = operationCode;
            this.encrypted = encrypted;
            this.timeout = timeout;
        }

        public int GetOperationCode()
        {
            return this.operationCode;
        }

        public int GetRequestId()
        {
            return this.requestId;
        }

        public GNHashtable GetParameters()
        {
            return this.parameters;
        }

        public bool IsEncrypted()
        {
            return this.encrypted;
        }

        public int GetTimeout()
        {
            return this.timeout;
        }

        public OperationRequest SetRequestId(int requestId)
        {
            this.requestId = requestId;
            return this;
        }

        public OperationRequest SetParameter(string key, object value)
        {
            if (this.parameters == null) this.parameters = new GNHashtable();

            this.parameters.Add(key, value);

            return this;
        }

        public OperationRequest SetParameters(GNHashtable parameters)
        {
            this.parameters = parameters;
            return this;
        }

        public OperationRequest SetEncrypted(bool encrypted)
        {
            this.encrypted = encrypted;
            return this;
        }

        public OperationRequest SetTimeout(int timeout)
        {
            this.timeout = timeout;
            return this;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("Code: " + CodeHelper.GetOperationCodeName(this.operationCode) + ", requestId: " + this.requestId + ", parameters " + this.parameters + ", encrypted " + this.encrypted);

            return stringBuilder.ToString();
        }

    }

}
