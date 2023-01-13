namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class TemplateOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.Debug;

        protected override bool reliable => true;

        public TemplateOperationRequest(bool booleanValue, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            parameters = new GNHashtable.Builder()
                .Add(DebugParameterCode.Boolean, booleanValue)
                .Build();
        }
    }
}
