namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class DebugOperationResponse : CustomOperationResponse
    {
        public bool Success { get; private set; }

        public int ErrorCode;

        public bool Boolean;
        public string String;
        public int Number;
        public GNHashtable GNHashtable;
        public GNArray GNArray;

        public DebugOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!HasError)
            {
                Success = true;

                var parameters = operationResponse.GetParameters();

                ErrorCode = parameters.GetInt(ParameterCode.ErrorCode);

                if (ErrorCode == DebugErrorCode.Ok)
                {
                    Boolean = parameters.GetBool(DebugParameterCode.Boolean);
                    String = parameters.GetString(DebugParameterCode.String);
                    Number = parameters.GetInt(DebugParameterCode.Number);
                    GNHashtable = parameters.GetGNHashtable(DebugParameterCode.GNHashtable);
                    GNArray = parameters.GetGNArray(DebugParameterCode.GNArray);
                }
            }
        }
    }
}
