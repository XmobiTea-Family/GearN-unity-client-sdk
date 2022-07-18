namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class FetchSparkPlayerOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.FetchSparkPlayer;

        protected override bool reliable => true;

        public FetchSparkPlayerOperationRequest(int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {

        }
    }
}
