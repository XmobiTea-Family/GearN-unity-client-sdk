namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;

    public abstract class CustomOperationRequest
    {
        protected virtual int Code { get; }

        protected virtual bool Reliable { get; }

        protected int Timeout { get; }

        protected GNHashtable Parameters { get; set; }

        public CustomOperationRequest(int timeout)
        {
            this.Timeout = timeout;
        }

        public OperationRequest Builder()
        {
            var request = new OperationRequest(Code, Reliable, Timeout);

            if (this.Parameters != null) request.SetParameters(this.Parameters);

            return request;
        }
    }
}