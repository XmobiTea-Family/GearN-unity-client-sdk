namespace XmobiTea.GN.Entity
{
    using System.Collections.Generic;

    public class ChatChannel
    {
        public string channel;
        public string name;
        public AvatarChannel avatarChannel;
        public int userCount;
        public List<UserChannel> users;
        public long tsCreate;
        public int channelType;
        public List<ChatMessage> messages;
    }

}
