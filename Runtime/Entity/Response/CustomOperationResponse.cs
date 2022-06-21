namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public abstract class CustomOperationResponse
    {
        public GNHashtable parameters { get; private set; }
        public int returnCode { get; private set; }
        public string debugMessage { get; private set; }
        public int errorCode { get; private set; }
        public bool hasError => returnCode != ReturnCode.Ok;

        public CustomOperationResponse(OperationResponse operationResponse)
        {
            returnCode = operationResponse.GetReturnCode();
            debugMessage = operationResponse.GetDebugMessage();

            parameters = operationResponse.GetParameters();

            if (!hasError)
            {
                var parameters = operationResponse.GetParameters();
                errorCode = parameters.GetInt(ParameterCode.ErrorCode);
            }
        }

        public override string ToString()
        {
            return "ReturnCode: " + returnCode + " " + (parameters != null ? parameters.ToString() : debugMessage);
        }
    }
}
