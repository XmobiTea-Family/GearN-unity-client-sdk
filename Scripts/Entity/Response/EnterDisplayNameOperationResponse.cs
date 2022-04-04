namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class EnterDisplayNameOperationResponse : CustomOperationResponse
    {
        public bool Success { get; private set; }

        public int ErrorCode;

        public int UserRole;
        public string DisplayName;

        public EnterDisplayNameOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!HasError)
            {
                Success = true;

                var parameters = operationResponse.GetParameters();

                ErrorCode = parameters.GetInt(ParameterCode.ErrorCode);

                if (ErrorCode == EnterDisplayNameErrorCode.Ok)
                {
                    UserRole = parameters.GetInt(EnterDisplayNameParameterCode.UserRole);
                    DisplayName = parameters.GetString(EnterDisplayNameParameterCode.DisplayName);
                }
            }
        }
    }
}
