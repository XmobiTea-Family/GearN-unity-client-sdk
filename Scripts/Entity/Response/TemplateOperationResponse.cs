namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class TemplateOperationResponse : CustomOperationResponse
    {
        public bool Success { get; private set; }

        public int ErrorCode;

        public bool Boolean;

        public TemplateOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!HasError)
            {
                Success = true;

                var parameters = operationResponse.GetParameters();

                ErrorCode = parameters.GetInt(ParameterCode.ErrorCode);

                if (ErrorCode == DebugErrorCode.Ok)
                {
                    Boolean = parameters.GetBool(DebugParameterCode.Boolean);
                }
            }
        }
    }
}
