namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class LoginOperationResponse : CustomOperationResponse
    {
        public bool Success { get; private set; }

        public int ErrorCode;

        public string AuthToken;

        public long TsExpire;
        public string Reason;

        public LoginOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!HasError)
            {
                Success = true;

                var parameters = operationResponse.GetParameters();

                ErrorCode = parameters.GetInt(ParameterCode.ErrorCode);

                if (ErrorCode == LoginErrorCode.Ok)
                {
                    AuthToken = parameters.GetString(ParameterCode.AuthToken);
                }
                else if (ErrorCode == LoginErrorCode.UserHadBanned)
                {
                    TsExpire = parameters.GetLong(LoginParameterCode.TsExpire);
                    Reason = parameters.GetString(LoginParameterCode.Reason);
                }
            }
        }
    }
}
