namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class DebugOperationResponse : CustomOperationResponse
    {
        public bool boolean { get; private set; }
        public string @string { get; private set; }
        public int number { get; private set; }
        public GNHashtable gnHashtable { get; private set; }
        public GNArray gnArray { get; private set; }

        public DebugOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!hasError)
            {
                var parameters = operationResponse.GetParameters();

                if (errorCode == DebugErrorCode.Ok)
                {
                    boolean = parameters.GetBool(DebugParameterCode.Boolean);
                    @string = parameters.GetString(DebugParameterCode.String);
                    number = parameters.GetInt(DebugParameterCode.Number);
                    gnHashtable = parameters.GetGNHashtable(DebugParameterCode.GNHashtable);
                    gnArray = parameters.GetGNArray(DebugParameterCode.GNArray);
                }
            }
        }
    }
}
