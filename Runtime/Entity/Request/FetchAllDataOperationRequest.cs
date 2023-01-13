namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class FetchAllDataOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.FetchAllData;

        protected override bool operationEncrypted => true;

        public FetchAllDataOperationRequest(int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {

        }

    }

}
