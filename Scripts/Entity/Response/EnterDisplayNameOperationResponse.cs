namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class EnterDisplayNameOperationResponse : CustomOperationResponse
    {
        public int userRole { get; private set; }
        public string displayName { get; private set; }

        public EnterDisplayNameOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!hasError)
            {
                var parameters = operationResponse.GetParameters();

                if (errorCode == EnterDisplayNameErrorCode.Ok)
                {
                    userRole = parameters.GetInt(EnterDisplayNameParameterCode.UserRole);
                    displayName = parameters.GetString(EnterDisplayNameParameterCode.DisplayName);
                }
            }
        }
    }
}
