namespace XmobiTea.GN.Networking
{
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;

    public class OnUserChatEventHandler : IServerEventHandler
    {
        public int GetEventCode() => EventCode.OnUserChat;

        public void Handle(OperationEvent operationEvent)
        {
            var parameters = operationEvent.GetParameters();

            var userId = parameters.GetString(ChatParameterCode.UserId);

            var chatUserLst = GNNetwork.GetChatUserLst();

            var chatUser = chatUserLst.Find(x => x.userId.Equals(userId));

            if (chatUser == null)
            {
                chatUser = new ChatUser();
                chatUser.userId = userId;
                chatUser.messages = new List<ChatMessage>();

                chatUserLst.Add(chatUser);
            }

            var gsMessages = parameters.GetGNArray(ChatParameterCode.ChatMessageLst);

            for (var i = 0; i < gsMessages.Count(); i++)
            {
                var gsMessage = gsMessages.GetGNHashtable(i);
                var tsCreate = gsMessage.GetLong(ChatParameterCode.TsCreate);

                var message = chatUser.messages.Find(x => x.tsCreate == tsCreate);
                if (message == null)
                {
                    message = new ChatMessage();
                    message.tsCreate = tsCreate;
                    message.messageEditeds = new List<EditChatMessage>();

                    chatUser.messages.Add(message);
                }

                if (gsMessage.ContainsKey(ChatParameterCode.Message))
                    message.message = gsMessage.GetString(ChatParameterCode.Message);

                if (gsMessage.ContainsKey(ChatParameterCode.UserId))
                    message.senderId = gsMessage.GetString(ChatParameterCode.UserId);

                if (gsMessage.ContainsKey(ChatParameterCode.TsLastUpdate))
                    message.tsLastUpdate = gsMessage.GetLong(ChatParameterCode.TsLastUpdate, tsCreate);

                if (gsMessage.ContainsKey(ChatParameterCode.IsDelete))
                    message.isDelete = gsMessage.GetBool(ChatParameterCode.IsDelete);

                if (gsMessage.ContainsKey(ChatParameterCode.MessageEditeds))
                {
                    message.messageEditeds.Clear();

                    var gsMessageEditeds = gsMessage.GetGNArray(ChatParameterCode.MessageEditeds);

                    for (var j = 0; j < gsMessageEditeds.Count(); j++)
                    {
                        var gsMessageEdited = gsMessageEditeds.GetGNHashtable(j);

                        message.messageEditeds.Add(new EditChatMessage()
                        {
                            message = gsMessageEdited.GetString(ChatParameterCode.Message),
                            tsCreate = gsMessageEdited.GetLong(ChatParameterCode.TsCreate)
                        });
                    }
                }
            }

            GNNetwork.onChatUserChange?.Invoke(chatUser);
        }

    }

}
