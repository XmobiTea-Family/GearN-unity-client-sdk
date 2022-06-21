namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class LogoutOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.Logout;

        protected override bool reliable => true;

        public LogoutOperationRequest(int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            parameters = new GNHashtable.Builder().Build();
        }
    }
}
