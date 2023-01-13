namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class FetchSparkPlayerOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.FetchSparkPlayer;

        protected override bool operationEncrypted => true;

        public FetchSparkPlayerOperationRequest(int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {

        }

    }

}
