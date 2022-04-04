namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class GetAppConfigOperationRequest : CustomOperationRequest
    {
        protected override int Code => OperationCode.GetAppConfig;

        protected override bool Reliable => true;

        public GetAppConfigOperationRequest(GNArray configTypes, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            Parameters = new GNHashtable.Builder()
                .Add(GetAppConfigParameterCode.ConfigTypes, configTypes)
                .Build();
        }
    }
}
