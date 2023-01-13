namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class EnterDisplayNameOperationResponse : CustomOperationResponse
    {
        public int userRole { get; private set; }
        public string displayName { get; private set; }

        public override void SetupOperationResponse(OperationResponse operationResponse)
        {
            base.SetupOperationResponse(operationResponse);

            if (!this.hasError)
            {
                if (this.errorCode == EnterDisplayNameErrorCode.Ok)
                {
                    this.userRole = this.parameters.GetInt(EnterDisplayNameParameterCode.UserRole);
                    this.displayName = this.parameters.GetString(EnterDisplayNameParameterCode.DisplayName);
                }
            }
        }

    }

}
