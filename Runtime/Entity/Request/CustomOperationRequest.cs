namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Helper;

    public abstract class CustomOperationRequest
    {
        protected abstract int operationCode { get; }

        protected abstract bool operationEncrypted { get; }

        protected abstract RequestType requestType { get; }

        protected abstract RequestRole requestRole { get; }

        protected int operationTimeout { get; }

        public RequestType getRequestType()
        {
            return this.requestType;
        }

        public RequestRole getRequestRole()
        {
            return this.requestRole;
        }

        public CustomOperationRequest(int timeout)
        {
            this.operationTimeout = timeout;
        }

        public abstract OperationRequest build();
    }

    public abstract class CustomOperationRequest<TRequestData> : CustomOperationRequest where TRequestData : new()
    {
        public TRequestData requestData { get; }

        public CustomOperationRequest(int timeout) : base(timeout)
        {
            this.requestData = new TRequestData();
        }

        public CustomOperationRequest(TRequestData requestData, int timeout) : base(timeout)
        {
            this.requestData = requestData;
        }

        public override OperationRequest build()
        {
            var request = new OperationRequest(this.operationCode, this.operationEncrypted, this.operationTimeout);

            request.setParameters(ConverterService.serializeObject(this.requestData));

            return request;
        }

    }

}
