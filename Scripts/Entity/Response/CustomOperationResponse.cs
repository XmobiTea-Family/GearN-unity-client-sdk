namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public abstract class CustomOperationResponse
    {
        private GNHashtable Parameters { get; set; }
        public ReturnCode ReturnCode { get; private set; }
        public string DebugMessage { get; private set; }

        public bool HasError => ReturnCode != ReturnCode.Ok;

        public CustomOperationResponse(OperationResponse operationResponse)
        {
            ReturnCode = operationResponse.GetReturnCode();
            DebugMessage = operationResponse.GetDebugMessage();

            Parameters = operationResponse.GetParameters();
        }

        public override string ToString()
        {
            return "ReturnCode: " + ReturnCode + " " + (Parameters != null ? Parameters.ToString() : DebugMessage);
        }
    }
}