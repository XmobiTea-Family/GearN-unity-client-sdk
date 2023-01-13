namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class EnterDisplayNameOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.EnterDisplayName;

        protected override bool operationEncrypted => true;

        public EnterDisplayNameOperationRequest(string displayName, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(EnterDisplayNameParameterCode.DisplayName, displayName)
                .Build();
        }

    }

}
