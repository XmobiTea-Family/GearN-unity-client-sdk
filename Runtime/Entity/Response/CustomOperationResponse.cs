namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Helper;

    public abstract class CustomOperationResponse
    {
        public int operationCode { get; private set; }
        public GNHashtable parameters { get; private set; }
        public int returnCode { get; private set; }
        public string debugMessage { get; private set; }
        public int errorCode { get; private set; }
        public InvalidMember[] invalidMembers { get; private set; }

        public bool hasError()
        {
            return this.returnCode != ReturnCode.Ok;
        }

        public virtual void setupOperationResponse(OperationResponse operationResponse)
        {
            this.operationCode = operationResponse.getOperationCode();
            this.returnCode = operationResponse.getReturnCode();
            this.debugMessage = operationResponse.getDebugMessage();

            this.parameters = operationResponse.getParameters();
            this.invalidMembers = operationResponse.getInvalidMembers();

            if (!hasError())
            {
                this.errorCode = this.parameters.getInt(ParameterCode.ErrorCode);
            }
        }

        public string toString()
        {
            return "ReturnCode: " + this.returnCode + " " + (this.parameters != null ? this.parameters.ToString() : this.debugMessage);
        }

        public override string ToString()
        {
            return this.toString();
        }
    }

    public class CustomOperationResponse<TResponseData> : CustomOperationResponse
    {
        public TResponseData responseData { get; private set; }

        public override void setupOperationResponse(OperationResponse operationResponse)
        {
            base.setupOperationResponse(operationResponse);

            if (!hasError())
            {
                this.responseData = ConverterService.deserializeObject<TResponseData>(this.parameters);
            }
        }

    }

}
