namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class FetchAllDataOperationResponse : CustomOperationResponse
    {
        public bool Success { get; private set; }

        public int ErrorCode;

        public string UserId;
        public int UserRole;
        public string DisplayName;

        public long TsExpire;
        public string Reason;

        public FetchAllDataOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!HasError)
            {
                Success = true;

                var parameters = operationResponse.GetParameters();

                ErrorCode = parameters.GetInt(ParameterCode.ErrorCode);

                if (ErrorCode == FetchAllDataErrorCode.Ok)
                {
                    UserId = parameters.GetString(FetchAllDataParameterCode.UserId);
                    UserRole = parameters.GetInt(FetchAllDataParameterCode.UserRole);
                    DisplayName = parameters.GetString(FetchAllDataParameterCode.DisplayName);
                }
                else if (ErrorCode == FetchAllDataErrorCode.UserHadBanned)
                {
                    TsExpire = parameters.GetLong(FetchAllDataParameterCode.TsExpire);
                    Reason = parameters.GetString(FetchAllDataParameterCode.Reason);
                }
            }
        }
    }
}
