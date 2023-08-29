namespace XmobiTea.GN.Networking
{
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;

    public class OnChannelChatEventHandler : IServerEventHandler
    {
        public int GetEventCode() => EventCode.OnChannelChat;

        public void Handle(OperationEvent operationEvent)
        {
            var parameters = operationEvent.GetParameters();

            var gsChannelInfo = parameters.GetGNHashtable(ChatParameterCode.ChannelInfo);

            var channel = gsChannelInfo.GetString(ChatParameterCode.Channel);

            var chatChannelLst = GNNetwork.GetChatChannelLst();

            var chatChannel = chatChannelLst.Find(x => x.channel.Equals(channel));

            if (chatChannel == null)
            {
                chatChannel = new ChatChannel();
                chatChannel.channel = channel;

                chatChannel.avatarChannel = new AvatarChannel();
                chatChannel.users = new List<UserChannel>();
                chatChannel.messages = new List<ChatMessage>();

                chatChannelLst.Add(chatChannel);
            }

            if (gsChannelInfo.ContainsKey(ChatParameterCode.Name))
                chatChannel.name = gsChannelInfo.GetString(ChatParameterCode.Name);

            if (gsChannelInfo.ContainsKey(ChatParameterCode.AvatarChannel))
            {
                var gsAvatarChannel = gsChannelInfo.GetGNHashtable(ChatParameterCode.AvatarChannel);

                chatChannel.avatarChannel.type = gsAvatarChannel.GetInt(ChatParameterCode.Type);
                chatChannel.avatarChannel.value = gsAvatarChannel.GetString(ChatParameterCode.Value);
            }

            if (gsChannelInfo.ContainsKey(ChatParameterCode.ChannelType))
                chatChannel.channelType = gsChannelInfo.GetInt(ChatParameterCode.ChannelType);

            if (gsChannelInfo.ContainsKey(ChatParameterCode.ChatMessageLst))
            {
                var gsMessages = gsChannelInfo.GetGNArray(ChatParameterCode.ChatMessageLst);

                for (var i = 0; i < gsMessages.Count(); i++)
                {
                    var gsMessage = gsMessages.GetGNHashtable(i);

                    var tsCreate = gsMessage.GetLong(ChatParameterCode.TsCreate);
                    var chatMessage = chatChannel.messages.Find(x => x.tsCreate == tsCreate);

                    if (chatMessage == null)
                    {
                        chatMessage = new ChatMessage();

                        chatMessage.tsCreate = tsCreate;
                        chatMessage.messageEditeds = new List<EditChatMessage>();

                        chatChannel.messages.Add(chatMessage);
                    }

                    if (gsMessage.ContainsKey(ChatParameterCode.Message))
                        chatMessage.message = gsMessage.GetString(ChatParameterCode.Message);

                    if (gsMessage.ContainsKey(ChatParameterCode.UserId))
                        chatMessage.senderId = gsMessage.GetString(ChatParameterCode.UserId);

                    if (gsMessage.ContainsKey(ChatParameterCode.TsLastUpdate))
                        chatMessage.tsLastUpdate = gsMessage.GetLong(ChatParameterCode.TsLastUpdate);

                    if (gsMessage.ContainsKey(ChatParameterCode.IsDelete))
                        chatMessage.isDelete = gsMessage.GetBool(ChatParameterCode.IsDelete);

                    if (gsMessage.ContainsKey(ChatParameterCode.MessageEditeds))
                    {
                        chatMessage.messageEditeds.Clear();

                        var gsMessageEditeds = gsMessage.GetGNArray(ChatParameterCode.MessageEditeds);

                        for (var j = 0; j < gsMessageEditeds.Count(); j++)
                        {
                            var gsMessageEdited = gsMessageEditeds.GetGNHashtable(j);

                            chatMessage.messageEditeds.Add(new EditChatMessage()
                            {
                                message = gsMessageEdited.GetString(ChatParameterCode.Message),
                                tsCreate = gsMessageEdited.GetLong(ChatParameterCode.TsCreate)
                            });
                        }
                    }
                }
            }

            GNNetwork.onChatChannelChange?.Invoke(chatChannel);
        }

    }

}
