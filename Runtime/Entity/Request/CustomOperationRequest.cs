namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public abstract class CustomOperationRequest
    {
        protected abstract int operationCode { get; }
        
        protected abstract bool operationEncrypted { get; }

        protected abstract RequestType requestType { get; }

        protected abstract RequestRole requestRole { get; }

        protected int operationTimeout { get; }

        public CustomOperationRequest(int timeout)
        {
            this.operationTimeout = timeout;
        }

        public RequestType GetRequestType()
        {
            return this.requestType;
        }

        public RequestRole GetRequestRole()
        {
            return this.requestRole;
        }

        public OperationRequest Build()
        {
            var request = new OperationRequest(operationCode, operationEncrypted, operationTimeout);

            //if (this.operationParameters != null) request.SetParameters(this.operationParameters);

            return request;
        }
    }

}
