namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class FetchAllDataOperationResponse : CustomOperationResponse
    {
        public string userId { get; private set; }
        public int userRole { get; private set; }
        public string displayName { get; private set; }
        public long tsExpire { get; private set; }
        public string reason { get; private set; }

        public FetchAllDataOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!hasError)
            {
                if (errorCode == FetchAllDataErrorCode.Ok)
                {
                    userId = parameters.GetString(FetchAllDataParameterCode.UserId);
                    userRole = parameters.GetInt(FetchAllDataParameterCode.UserRole);
                    displayName = parameters.GetString(FetchAllDataParameterCode.DisplayName);
                }
                else if (errorCode == FetchAllDataErrorCode.UserHadBanned)
                {
                    tsExpire = parameters.GetLong(FetchAllDataParameterCode.TsExpire);
                    reason = parameters.GetString(FetchAllDataParameterCode.Reason);
                }
            }
        }
    }
}
