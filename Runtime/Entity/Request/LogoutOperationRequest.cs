namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class LogoutOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.Logout;

        protected override bool operationEncrypted => true;

        public LogoutOperationRequest(int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {

        }

    }

}
