namespace XmobiTea.GN.Entity
{
    using System.Text;

    using XmobiTea.GN.Common;
    using XmobiTea.GN.Helper;

    public class OperationRequest
    {
        public const int defaultTimeOut = 15;

        private int operationCode;
        private int requestId;
        private GNHashtable parameters;
        private bool encrypted;
        private int timeout;

        public OperationRequest(int operationCode, bool encrypted = true, int timeout = defaultTimeOut)
        {
            this.operationCode = operationCode;
            this.encrypted = encrypted;
            this.timeout = timeout;
        }

        public int getOperationCode()
        {
            return this.operationCode;
        }

        public int getRequestId()
        {
            return this.requestId;
        }

        public GNHashtable getParameters()
        {
            return this.parameters;
        }

        public bool isEncrypted()
        {
            return this.encrypted;
        }

        public int getTimeout()
        {
            return this.timeout;
        }

        public OperationRequest setRequestId(int requestId)
        {
            this.requestId = requestId;
            return this;
        }

        public OperationRequest setParameter(string key, object value)
        {
            if (this.parameters == null) this.parameters = new GNHashtable();

            this.parameters.add(key, value);

            return this;
        }

        public OperationRequest setParameters(GNHashtable parameters)
        {
            this.parameters = parameters;
            return this;
        }

        public OperationRequest setEncrypted(bool encrypted)
        {
            this.encrypted = encrypted;
            return this;
        }

        public OperationRequest setTimeout(int timeout)
        {
            this.timeout = timeout;
            return this;
        }

        public string toString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("Code: " + CodeHelper.getOperationCodeName(this.operationCode) + ", requestId: " + this.requestId + ", parameters " + this.parameters + ", encrypted " + this.encrypted);

            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return this.toString();
        }

    }

}
