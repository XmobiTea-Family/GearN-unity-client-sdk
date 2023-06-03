namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class GetChatMessageChannelOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.GetChatMessageChannel;

        protected override bool operationEncrypted => true;

        public GetChatMessageChannelOperationRequest(string channel, int skip = 0, int limit = 20, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(ChatParameterCode.Channel, channel)
                .Add(ChatParameterCode.Skip, skip)
                .Add(ChatParameterCode.Limit, limit)
                .Build();
        }

    }

}
