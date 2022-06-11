namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class GetAppConfigOperationResponse : CustomOperationResponse
    {
        public string[] configNotUptodateLst { get; private set; }

        public GetAppConfigOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!hasError)
            {
                if (errorCode == GetAppConfigErrorCode.Ok)
                {
                    configNotUptodateLst = parameters.GetArray<string>(GetAppConfigParameterCode.ConfigNotUptodateLst);
                }
            }
        }
    }
}
