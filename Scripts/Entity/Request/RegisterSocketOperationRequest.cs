namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class RegisterSocketOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.RegisterSocket;

        protected override bool reliable => true;

        public RegisterSocketOperationRequest(string sid, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            parameters = new GNHashtable.Builder()
                .Add(RegisterSocketParameterCode.SId, sid)
                .Build();
        }
    }
}
