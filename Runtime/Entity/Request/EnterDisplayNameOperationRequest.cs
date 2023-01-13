namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class EnterDisplayNameOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.EnterDisplayName;

        protected override bool reliable => true;

        public EnterDisplayNameOperationRequest(string displayName, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            parameters = new GNHashtable.Builder()
                .Add(EnterDisplayNameParameterCode.DisplayName, displayName)
                .Build();
        }
    }
}
