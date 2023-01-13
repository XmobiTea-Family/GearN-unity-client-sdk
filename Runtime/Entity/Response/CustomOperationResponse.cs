namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public abstract class CustomOperationResponse
    {
        public int operationCode { get; private set; }
        public GNHashtable parameters { get; private set; }
        public int returnCode { get; private set; }
        public string debugMessage { get; private set; }
        public int errorCode { get; private set; }
        public InvalidMember[] invalidMembers { get; private set; }

        public bool HasError() => this.returnCode != ReturnCode.Ok;


        public virtual void SetupOperationResponse(OperationResponse operationResponse)
        {
            this.operationCode = operationResponse.GetOperationCode();
            this.returnCode = operationResponse.GetReturnCode();
            this.debugMessage = operationResponse.GetDebugMessage();

            this.parameters = operationResponse.GetParameters();
            this.invalidMembers = operationResponse.GetInvalidMembers();

            if (!HasError())
            {
                this.errorCode = this.parameters.GetInt(ParameterCode.ErrorCode);
            }
        }

        public override string ToString()
        {
            return "ReturnCode: " + this.returnCode + " " + (this.parameters != null ? this.parameters.ToString() : this.debugMessage);
        }

    }

}
