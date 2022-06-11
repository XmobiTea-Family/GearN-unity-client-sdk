namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;

    public abstract class CustomOperationRequest
    {
        protected virtual int code { get; }

        protected virtual bool reliable { get; }

        protected int timeout { get; }

        protected GNHashtable parameters { get; set; }

        public CustomOperationRequest(int timeout)
        {
            this.timeout = timeout;
        }

        public OperationRequest Builder()
        {
            var request = new OperationRequest(code, reliable, timeout);

            if (this.parameters != null) request.SetParameters(this.parameters);

            return request;
        }
    }
}
