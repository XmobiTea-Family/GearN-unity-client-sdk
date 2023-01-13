namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class PublicAddressGetRandomMessageOperationResponse : CustomOperationResponse
    {
        public string message { get; private set; }

        public PublicAddressGetRandomMessageOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!hasError)
            {
                if (errorCode == LoginErrorCode.Ok)
                {
                    message = parameters.GetString(LoginParameterCode.Message);
                }
            }
        }
    }
}
