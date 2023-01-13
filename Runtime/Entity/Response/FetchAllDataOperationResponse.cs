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

        public override void SetupOperationResponse(OperationResponse operationResponse)
        {
            base.SetupOperationResponse(operationResponse);

            if (!this.HasError())
            {
                if (this.errorCode == FetchAllDataErrorCode.Ok)
                {
                    this.userId = this.parameters.GetString(FetchAllDataParameterCode.UserId);
                    this.userRole = this.parameters.GetInt(FetchAllDataParameterCode.UserRole);
                    this.displayName = this.parameters.GetString(FetchAllDataParameterCode.DisplayName);
                }
                else if (errorCode == FetchAllDataErrorCode.UserHadBanned)
                {
                    this.tsExpire = this.parameters.GetLong(FetchAllDataParameterCode.TsExpire);
                    this.reason = this.parameters.GetString(FetchAllDataParameterCode.Reason);
                }
            }
        }

    }

}
