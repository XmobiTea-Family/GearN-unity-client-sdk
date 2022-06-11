namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class GetAppConfigOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.GetAppConfig;

        protected override bool reliable => true;

        public GetAppConfigOperationRequest(GNArray configTypes, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            parameters = new GNHashtable.Builder()
                .Add(GetAppConfigParameterCode.ConfigTypes, configTypes)
                .Build();
        }
    }
}
