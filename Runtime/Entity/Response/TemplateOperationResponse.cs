namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class TemplateOperationResponse : CustomOperationResponse
    {
        public bool boolean { get; private set; }

        public override void SetupOperationResponse(OperationResponse operationResponse)
        {
            base.SetupOperationResponse(operationResponse);

            if (!this.hasError)
            {
                if (this.errorCode == DebugErrorCode.Ok)
                {
                    this.boolean = this.parameters.GetBool(DebugParameterCode.Boolean);
                }
            }
        }

    }

}
