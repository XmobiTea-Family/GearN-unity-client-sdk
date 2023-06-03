namespace XmobiTea.GN.Entity.Response
{
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;

    public class GetChatMemberChannelOperationResponse : CustomOperationResponse
    {
        public class UserChannel
        {
            public string userId { get; internal set; }
            public long tsJoin { get; internal set; }
        }

        public class ChannelInfo
        {
            public List<UserChannel> members { get; internal set; }
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

                    this.channelInfo.members = new List<UserChannel>();
                    var gsMembers = gsChannelInfo.GetGNArray(ChatParameterCode.Members);

                    for (var i = 0; i < gsMembers.Count(); i++)
                    {
                        var gsMember = gsMembers.GetGNHashtable(i);

                        this.channelInfo.members.Add(new UserChannel()
                        {
                            userId = gsMember.GetString(ChatParameterCode.UserId),
                            tsJoin = gsMember.GetLong(ChatParameterCode.TsJoin)
                        });
                    }
                }
            }
        }

    }

}
