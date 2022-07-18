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

        public FetchSparkPlayerOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!hasError)
            {
                if (errorCode == FetchSparkPlayerErrorCode.Ok)
                {
                    userId = parameters.GetString(FetchSparkPlayerParameterCode.UserId);
                    userRole = parameters.GetInt(FetchSparkPlayerParameterCode.UserRole);
                    fullname = parameters.GetString(FetchSparkPlayerParameterCode.Fullname);
                    tsCreate = parameters.GetLong(FetchSparkPlayerParameterCode.TsCreate);

                    var gsUserExternal = parameters.GetGNHashtable(FetchSparkPlayerParameterCode.UserExternal);

                    userExternal = new UserExternal();
                    userExternal.customId = gsUserExternal.GetString(FetchSparkPlayerParameterCode.CustomId);
                    userExternal.facebookId = gsUserExternal.GetString(FetchSparkPlayerParameterCode.FacebookId);
                    userExternal.googleUserId = gsUserExternal.GetString(FetchSparkPlayerParameterCode.GoogleUserId);
                    userExternal.appleUserId = gsUserExternal.GetString(FetchSparkPlayerParameterCode.AppleUserId);
                    userExternal.deviceInfo = gsUserExternal.GetString(FetchSparkPlayerParameterCode.DeviceInfo);
                    userExternal.publicAddress = gsUserExternal.GetString(FetchSparkPlayerParameterCode.PublicAddress);
                }
                else if (errorCode == FetchSparkPlayerErrorCode.UserHadBanned)
                {
                    tsExpire = parameters.GetLong(FetchSparkPlayerParameterCode.TsExpire);
                    reason = parameters.GetString(FetchSparkPlayerParameterCode.Reason);
                }
            }
        }
    }
}
