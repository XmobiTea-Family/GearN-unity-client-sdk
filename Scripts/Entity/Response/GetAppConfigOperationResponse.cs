namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class GetAppConfigOperationResponse : CustomOperationResponse
    {
        public bool Success { get; private set; }

        public int ErrorCode;

        public string[] ConfigNotUptodateLst;

        public GetAppConfigOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!HasError)
            {
                Success = true;

                var parameters = operationResponse.GetParameters();

                ErrorCode = parameters.GetInt(ParameterCode.ErrorCode);

                if (ErrorCode == GetAppConfigErrorCode.Ok)
                {
                    ConfigNotUptodateLst = parameters.GetArray<string>(GetAppConfigParameterCode.ConfigNotUptodateLst);
                }
            }
        }
    }
}
