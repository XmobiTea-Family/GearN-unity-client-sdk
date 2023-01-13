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

        public override void SetupOperationResponse(OperationResponse operationResponse)
        {
            base.SetupOperationResponse(operationResponse);

            if (!this.HasError())
            {
                if (this.errorCode == DebugErrorCode.Ok)
                {
                    this.boolean = this.parameters.GetBool(DebugParameterCode.Boolean);
                    this.@string = this.parameters.GetString(DebugParameterCode.String);
                    this.number = this.parameters.GetInt(DebugParameterCode.Number);
                    this.gnHashtable = this.parameters.GetGNHashtable(DebugParameterCode.GNHashtable);
                    this.gnArray = this.parameters.GetGNArray(DebugParameterCode.GNArray);
                }
            }
        }

    }

}
