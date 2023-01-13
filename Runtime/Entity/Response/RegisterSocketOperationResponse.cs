namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class RegisterSocketOperationResponse : CustomOperationResponse
    {

        public override void SetupOperationResponse(OperationResponse operationResponse)
        {
            base.SetupOperationResponse(operationResponse);

            if (!this.hasError)
            {
                if (this.errorCode == RegisterSocketErrorCode.Ok)
                {
                    
                }
            }
        }

    }

}
