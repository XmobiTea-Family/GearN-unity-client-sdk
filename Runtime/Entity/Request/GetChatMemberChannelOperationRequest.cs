namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class GetChatMemberChannelOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.GetChatMemberChannel;

        protected override bool operationEncrypted => true;

        public GetChatMemberChannelOperationRequest(string channel, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(ChatParameterCode.Channel, channel)
                .Build();
        }

    }

}
