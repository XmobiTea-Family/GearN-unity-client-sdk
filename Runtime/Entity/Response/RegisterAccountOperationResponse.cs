namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class RegisterAccountOperationResponse : LoginOperationResponse
    {

        public override void SetupOperationResponse(OperationResponse operationResponse)
        {
            base.SetupOperationResponse(operationResponse);

            if (!this.hasError)
            {
                if (this.errorCode == LoginErrorCode.Ok)
                {

                }
            }
        }

    }

}
