namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class EnterDisplayNameOperationRequest : CustomOperationRequest
    {
        protected override int Code => OperationCode.EnterDisplayName;

        protected override bool Reliable => true;

        public EnterDisplayNameOperationRequest(string displayName, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            Parameters = new GNHashtable.Builder()
                .Add(EnterDisplayNameParameterCode.DisplayName, displayName)
                .Build();
        }
    }
}
