namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class DebugOperationRequest : CustomOperationRequest
    {
        protected override int Code => OperationCode.Debug;

        protected override bool Reliable => true;

        public DebugOperationRequest(bool booleanValue, int numberValue, string stringValue, GNHashtable gnHashtableValue, GNArray gnArrayValue, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            Parameters = new GNHashtable.Builder()
                .Add(DebugParameterCode.Boolean, booleanValue)
                .Add(DebugParameterCode.Number, numberValue)
                .Add(DebugParameterCode.String, stringValue)
                .Add(DebugParameterCode.GNHashtable, gnHashtableValue)
                .Add(DebugParameterCode.GNArray, gnArrayValue)
                .Build();
        }
    }
}
