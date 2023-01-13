namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;

    public abstract class CustomOperationRequest
    {
        protected virtual int operationCode { get; }

        protected virtual bool operationEncrypted { get; }

        protected int operationTimeout { get; }

        protected GNHashtable operationParameters { get; set; }

        public CustomOperationRequest(int timeout)
        {
            this.operationTimeout = timeout;
        }

        public OperationRequest Build()
        {
            var request = new OperationRequest(operationCode, operationEncrypted, operationTimeout);

            if (this.operationParameters != null) request.SetParameters(this.operationParameters);

            return request;
        }

    }

}
