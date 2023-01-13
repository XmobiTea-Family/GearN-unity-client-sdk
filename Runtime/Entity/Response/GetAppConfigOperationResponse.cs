namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class GetAppConfigOperationResponse : CustomOperationResponse
    {
        public string[] configNotUptodateLst { get; private set; }

        public override void SetupOperationResponse(OperationResponse operationResponse)
        {
            base.SetupOperationResponse(operationResponse);

            if (!this.hasError)
            {
                if (this.errorCode == GetAppConfigErrorCode.Ok)
                {
                    this.configNotUptodateLst = this.parameters.GetArray<string>(GetAppConfigParameterCode.ConfigNotUptodateLst);
                }
            }
        }

    }

}
