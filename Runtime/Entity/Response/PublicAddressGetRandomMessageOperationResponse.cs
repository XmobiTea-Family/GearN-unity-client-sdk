namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class PublicAddressGetRandomMessageOperationResponse : CustomOperationResponse
    {
        public string message { get; private set; }

        public override void SetupOperationResponse(OperationResponse operationResponse)
        {
            base.SetupOperationResponse(operationResponse);

            if (!this.HasError())
            {
                if (this.errorCode == LoginErrorCode.Ok)
                {
                    this.message = this.parameters.GetString(LoginParameterCode.Message);
                }
            }
        }

    }

}
