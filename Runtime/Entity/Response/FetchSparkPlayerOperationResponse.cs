namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class FetchSparkPlayerOperationResponse : CustomOperationResponse
    {
        public class UserExternal
        {
            public string customId { get; internal set; }
            public string facebookId { get; internal set; }
            public string googleUserId { get; internal set; }
            public string appleUserId { get; internal set; }
            public string deviceInfo { get; internal set; }
            public string publicAddress { get; internal set; }
        }

        public string userId { get; private set; }
        public int userRole { get; private set; }
        public string fullname { get; private set; }
        public long tsCreate { get; private set; }
        public UserExternal userExternal { get; private set; }

        public long tsExpire { get; private set; }
        public string reason { get; private set; }

        public override void SetupOperationResponse(OperationResponse operationResponse)
        {
            base.SetupOperationResponse(operationResponse);

            if (!this.hasError)
            {
                if (this.errorCode == FetchSparkPlayerErrorCode.Ok)
                {
                    this.userId = this.parameters.GetString(FetchSparkPlayerParameterCode.UserId);
                    this.userRole = this.parameters.GetInt(FetchSparkPlayerParameterCode.UserRole);
                    this.fullname = this.parameters.GetString(FetchSparkPlayerParameterCode.Fullname);
                    this.tsCreate = this.parameters.GetLong(FetchSparkPlayerParameterCode.TsCreate);

                    var gsUserExternal = this.parameters.GetGNHashtable(FetchSparkPlayerParameterCode.UserExternal);

                    this.userExternal = new UserExternal();
                    this.userExternal.customId = gsUserExternal.GetString(FetchSparkPlayerParameterCode.CustomId);
                    this.userExternal.facebookId = gsUserExternal.GetString(FetchSparkPlayerParameterCode.FacebookId);
                    this.userExternal.googleUserId = gsUserExternal.GetString(FetchSparkPlayerParameterCode.GoogleUserId);
                    this.userExternal.appleUserId = gsUserExternal.GetString(FetchSparkPlayerParameterCode.AppleUserId);
                    this.userExternal.deviceInfo = gsUserExternal.GetString(FetchSparkPlayerParameterCode.DeviceInfo);
                    this.userExternal.publicAddress = gsUserExternal.GetString(FetchSparkPlayerParameterCode.PublicAddress);
                }
                else if (this.errorCode == FetchSparkPlayerErrorCode.UserHadBanned)
                {
                    this.tsExpire = this.parameters.GetLong(FetchSparkPlayerParameterCode.TsExpire);
                    this.reason = this.parameters.GetString(FetchSparkPlayerParameterCode.Reason);
                }
            }
        }

    }

}
