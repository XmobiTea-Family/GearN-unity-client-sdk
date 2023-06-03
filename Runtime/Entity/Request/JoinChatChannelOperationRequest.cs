namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class JoinChatChannelOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.JoinChatChannel;

        protected override bool operationEncrypted => true;

        public JoinChatChannelOperationRequest(string channel, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(ChatParameterCode.Channel, channel)
                .Build();
        }

    }

}
