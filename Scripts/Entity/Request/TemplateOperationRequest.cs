namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class TemplateOperationRequest : CustomOperationRequest
    {
        protected override int Code => OperationCode.Debug;

        protected override bool Reliable => true;

        public TemplateOperationRequest(bool booleanValue, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            Parameters = new GNHashtable.Builder()
                .Add(DebugParameterCode.Boolean, booleanValue)
                .Build();
        }
    }
}
