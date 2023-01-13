namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class TemplateOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.Debug;

        protected override bool operationEncrypted => true;

        public TemplateOperationRequest(bool booleanValue, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(DebugParameterCode.Boolean, booleanValue)
                .Build();
        }

    }

}
