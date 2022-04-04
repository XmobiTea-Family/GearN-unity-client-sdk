namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class PublicAddressGetRandomMessageOperationResponse : CustomOperationResponse
    {
        public bool Success { get; private set; }

        public int ErrorCode;

        public string Message;

        public PublicAddressGetRandomMessageOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!HasError)
            {
                Success = true;

                var parameters = operationResponse.GetParameters();

                ErrorCode = parameters.GetInt(ParameterCode.ErrorCode);

                if (ErrorCode == LoginErrorCode.Ok)
                {
                    Message = parameters.GetString(LoginParameterCode.Message);
                }
            }
        }
    }
}
