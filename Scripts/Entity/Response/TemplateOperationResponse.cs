namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class TemplateOperationResponse : CustomOperationResponse
    {
        public bool boolean { get; private set; }

        public TemplateOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!hasError)
            {
                var parameters = operationResponse.GetParameters();

                if (errorCode == DebugErrorCode.Ok)
                {
                    boolean = parameters.GetBool(DebugParameterCode.Boolean);
                }
            }
        }
    }
}
