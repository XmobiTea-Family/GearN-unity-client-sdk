namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class SendChatToChannelOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.SendChatToChannel;

        protected override bool operationEncrypted => true;

        public SendChatToChannelOperationRequest(string channel, string message, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(ChatParameterCode.Channel, channel)
                .Add(ChatParameterCode.Message, message)
                .Build();
        }

    }

}
