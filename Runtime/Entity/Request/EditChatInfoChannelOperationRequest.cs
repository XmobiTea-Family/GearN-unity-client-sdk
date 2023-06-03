namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class EditChatInfoChannelOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.EditChatInfoChannel;

        protected override bool operationEncrypted => true;

        public EditChatInfoChannelOperationRequest(string channel, string name = null, GNHashtable avatarChannel = null, int? channelType = null, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(ChatParameterCode.Channel, channel)
                .Build();

            if (name != null) this.operationParameters.Add(ChatParameterCode.Name, name);
            if (avatarChannel != null) this.operationParameters.Add(ChatParameterCode.Name, avatarChannel);
            if (channelType != null) this.operationParameters.Add(ChatParameterCode.Name, channelType.GetValueOrDefault());
        }

    }

}
