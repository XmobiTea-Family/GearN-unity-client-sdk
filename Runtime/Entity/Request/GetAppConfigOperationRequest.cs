namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class GetAppConfigOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.GetAppConfig;

        protected override bool operationEncrypted => true;

        public GetAppConfigOperationRequest(GNArray configTypes, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(GetAppConfigParameterCode.ConfigTypes, configTypes)
                .Build();
        }

    }

}
