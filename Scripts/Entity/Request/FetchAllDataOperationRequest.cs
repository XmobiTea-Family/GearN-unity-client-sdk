namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class FetchAllDataOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.FetchAllData;

        protected override bool reliable => true;

        public FetchAllDataOperationRequest(int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {

        }
    }
}
