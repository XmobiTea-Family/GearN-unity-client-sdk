namespace XmobiTea.GN.Entity
{
    using System.Collections.Generic;

    public class EditChatMessage
    {
        public string message;
        public long tsCreate;
    }

    public class ChatMessage : EditChatMessage
    {
        public long tsLastUpdate;
        public List<EditChatMessage> messageEditeds;
        public string senderId;
        public bool isDelete;
    }

}
