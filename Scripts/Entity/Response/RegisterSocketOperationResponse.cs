namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class RegisterSocketOperationResponse : CustomOperationResponse
    {
        public bool Success { get; private set; }

        public int ErrorCode;

        public RegisterSocketOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!HasError)
            {
                Success = true;

                var parameters = operationResponse.GetParameters();

                ErrorCode = parameters.GetInt(ParameterCode.ErrorCode);
            }
        }
    }
}
