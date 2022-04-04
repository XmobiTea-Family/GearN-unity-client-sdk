namespace XmobiTea.GN.Entity
{
    using System.Text;

    using XmobiTea.GN.Common;

    public class OperationRequest
    {
        public const int DefaultTimeOut = 15;

        private int operationCode;
        private int requestId;
        private GNHashtable parameters;
        private bool reliable;
        private int timeOut;

        public int GetOperationCode()
        {
            return operationCode;
        }

        public int GetRequestId()
        {
            return requestId;
        }

        public GNHashtable GetParameters()
        {
            return parameters;
        }

        public bool IsReliable()
        {
            return reliable;
        }

        public int GetTimeOut()
        {
            return timeOut;
        }

        public OperationRequest SetRequestId(int requestId)
        {
            this.requestId = requestId;
            return this;
        }

        public OperationRequest SetScriptData(int key, object value)
        {
            if (parameters == null) parameters = new GNHashtable();

            parameters.Add(key, value);

            return this;
        }

        public OperationRequest SetParameters(GNHashtable parameters)
        {
            this.parameters = parameters;
            return this;
        }

        public OperationRequest SetReliable(bool reliable)
        {
            this.reliable = reliable;
            return this;
        }

        public OperationRequest SetTimeOut(int timeout)
        {
            this.timeOut = timeout;
            return this;
        }

        public OperationRequest(int operationCode, bool reliable = true, int timeout = DefaultTimeOut)
        {
            this.operationCode = operationCode;
            this.reliable = reliable;
            this.timeOut = timeout;
        }

        public object ToData()
        {
            if (requestId == -1) 
                return new object[] {
                    this.operationCode,
                    (parameters == null) ? null : parameters.ToData()
                };
            else
                return new object[] {
                    this.operationCode,
                    (parameters == null) ? null : parameters.ToData(),
                    requestId
                };
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("Code: " + GetOperationCode() + " RequestId: " + requestId + " parameters " + parameters);

            return stringBuilder.ToString();
        }
    }
}
