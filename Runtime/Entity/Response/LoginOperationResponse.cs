namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class LoginOperationResponse : CustomOperationResponse
    {
        public string authToken { get; private set; }

        public long tsExpire { get; private set; }
        public string reason { get; private set; }
        public string userId { get; private set; }

        public LoginOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!hasError)
            {
                if (errorCode == LoginErrorCode.Ok)
                {
                    authToken = parameters.GetString(ParameterCode.AuthToken);
                    userId = parameters.GetString(ParameterCode.UserId);
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
