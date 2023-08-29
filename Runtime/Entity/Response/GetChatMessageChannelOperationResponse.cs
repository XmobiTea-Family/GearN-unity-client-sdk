namespace XmobiTea.GN.Entity.Response
{
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;

    public class GetChatMessageChannelOperationResponse : CustomOperationResponse
    {
        public class EditChatMessage
        {
            public string message { get; internal set; }

            public long tsCreate { get; internal set; }
        }

        public class ChatMessage : EditChatMessage
        {
            public long tsLastUpdate { get; internal set; }
            public List<EditChatMessage> messageEditeds { get; internal set; }
            public string senderId { get; internal set; }
            public bool isDelete { get; internal set; }
        }

        public class ChannelInfo
        {
            public List<ChatMessage> messages { get; internal set; }
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

                    this.channelInfo.messages = new List<ChatMessage>();
                    var gsMessages = gsChannelInfo.GetGNArray(ChatParameterCode.ChatMessageLst);

                    for (var i = 0; i < gsMessages.Count(); i++)
                    {
                        var gsMessage = gsMessages.GetGNHashtable(i);

                        var message = gsMessage.GetString(ChatParameterCode.Message);
                        var tsCreate = gsMessage.GetLong(ChatParameterCode.TsCreate);
                        var userId = gsMessage.GetString(ChatParameterCode.UserId);
                        var tsLastUpdate = gsMessage.GetLong(ChatParameterCode.TsLastUpdate, tsCreate);
                        var isDelete = gsMessage.GetBool(ChatParameterCode.IsDelete);

                        var chatMessage = new ChatMessage()
                        {
                            message = message,
                            tsCreate = tsCreate,
                            tsLastUpdate = tsLastUpdate,
                            senderId = userId,
                            isDelete = isDelete,
                        };

                        chatMessage.messageEditeds = new List<EditChatMessage>();
                        if (gsMessage.ContainsKey(ChatParameterCode.MessageEditeds))
                        {
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

                        this.channelInfo.messages.Add(chatMessage);
                    }
                }
            }
        }

    }

}
