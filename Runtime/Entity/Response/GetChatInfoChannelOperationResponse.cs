namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class GetChatInfoChannelOperationResponse : CustomOperationResponse
    {
        public class AvatarChannel
        {
            public int type { get; internal set; }
            public string value { get; internal set; }
        }

        public class ChannelInfo
        {
            public string name { get; internal set; }
            public AvatarChannel avatarChannel { get; internal set; }
            public long tsCreate { get; internal set; }
            public int channelType { get; internal set; }
            public int userCount { get; internal set; }
        }

        public ChannelInfo channelInfo { get; private set; }

        public override void SetupOperationResponse(OperationResponse operationResponse)
        {
            base.SetupOperationResponse(operationResponse);

            if (!this.HasError())
            {
                if (this.errorCode == ChatErrorCode.Ok)
                {
                    this.channelInfo = new ChannelInfo();

                    var gsChannelInfo = this.parameters.GetGNHashtable(ChatParameterCode.ChannelInfo);

                    this.channelInfo.name = gsChannelInfo.GetString(ChatParameterCode.Name);
                    this.channelInfo.avatarChannel = new AvatarChannel();
                    var gnAvatarChannel = gsChannelInfo.GetGNHashtable(ChatParameterCode.AvatarChannel);
                    this.channelInfo.avatarChannel.type = gnAvatarChannel.GetInt(ChatParameterCode.Type);
                    this.channelInfo.avatarChannel.value = gnAvatarChannel.GetString(ChatParameterCode.Value);

                    this.channelInfo.tsCreate = gsChannelInfo.GetLong(ChatParameterCode.TsCreate);
                    this.channelInfo.channelType = gsChannelInfo.GetInt(ChatParameterCode.ChannelType);
                    this.channelInfo.userCount = gsChannelInfo.GetInt(ChatParameterCode.UserCount);

                }
            }
        }

    }

}
