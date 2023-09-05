namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class LoginOperationResponse : CustomOperationResponse
    {
        public string authToken { get; private set; }

        public long tsExpire { get; private set; }
        public string reason { get; private set; }
        public string userId { get; private set; }

        public override void SetupOperationResponse(OperationResponse operationResponse)
        {
            base.SetupOperationResponse(operationResponse);

            if (!this.HasError())
            {
                //if (this.errorCode == LoginErrorCode.Ok)
                //{
                //    this.authToken = this.parameters.GetString(ParameterCode.AuthToken);
                //    this.userId = this.parameters.GetString(ParameterCode.UserId);
                //}
                //else if (errorCode == LoginErrorCode.UserHadBanned)
                //{
                //    this.tsExpire = this.parameters.GetLong(LoginParameterCode.TsExpire);
                //    this.reason = this.parameters.GetString(LoginParameterCode.Reason);
                //}
            }
        }

    }

}
