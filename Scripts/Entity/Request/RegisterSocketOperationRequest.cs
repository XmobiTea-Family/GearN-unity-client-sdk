namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class RegisterSocketOperationRequest : CustomOperationRequest
    {
        protected override int Code => OperationCode.RegisterSocket;

        protected override bool Reliable => true;

        public RegisterSocketOperationRequest(string sid, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            Parameters = new GNHashtable.Builder()
                .Add(RegisterSocketParameterCode.SId, sid)
                .Build();
        }
    }
}
