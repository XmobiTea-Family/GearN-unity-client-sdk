namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class RegisterSocketOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.RegisterSocket;

        protected override bool operationEncrypted => true;

        public RegisterSocketOperationRequest(string sid, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(RegisterSocketParameterCode.SId, sid)
                .Build();
        }

    }

}
