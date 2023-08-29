namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class GetChatInfoChannelOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.GetChatInfoChannel;

        protected override bool operationEncrypted => true;

        public GetChatInfoChannelOperationRequest(string channel, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(ChatParameterCode.Channel, channel)
                .Build();
        }

    }

}
