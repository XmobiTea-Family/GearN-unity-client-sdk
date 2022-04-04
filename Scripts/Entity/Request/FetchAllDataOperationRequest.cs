namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class FetchAllDataOperationRequest : CustomOperationRequest
    {
        protected override int Code => OperationCode.FetchAllData;

        protected override bool Reliable => true;

        public FetchAllDataOperationRequest(int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {

        }
    }
}
