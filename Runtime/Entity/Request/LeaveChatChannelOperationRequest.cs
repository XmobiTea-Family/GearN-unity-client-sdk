namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class LeaveChatChannelOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.LeaveChatChannel;

        protected override bool operationEncrypted => true;

        public LeaveChatChannelOperationRequest(string channel, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(ChatParameterCode.Channel, channel)
                .Build();
        }

    }

}
