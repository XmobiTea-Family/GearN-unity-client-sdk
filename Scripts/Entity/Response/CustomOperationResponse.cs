namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Common;

    public abstract class CustomOperationResponse
    {
        private GNHashtable Parameters { get; set; }
        public int ReturnCode { get; private set; }
        public string DebugMessage { get; private set; }

        public bool HasError => ReturnCode != XmobiTea.GN.Constant.ReturnCode.Ok;

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
