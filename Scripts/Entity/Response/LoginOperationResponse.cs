namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class LoginOperationResponse : CustomOperationResponse
    {
        public string authToken { get; private set; }

        public long tsExpire { get; private set; }
        public string reason { get; private set; }

        public LoginOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!hasError)
            {
                var parameters = operationResponse.GetParameters();

                if (errorCode == LoginErrorCode.Ok)
                {
                    authToken = parameters.GetString(ParameterCode.AuthToken);
                }
                else if (errorCode == LoginErrorCode.UserHadBanned)
                {
                    tsExpire = parameters.GetLong(LoginParameterCode.TsExpire);
                    reason = parameters.GetString(LoginParameterCode.Reason);
                }
            }
        }
    }
}
