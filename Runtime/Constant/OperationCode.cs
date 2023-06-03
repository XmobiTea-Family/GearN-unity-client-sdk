namespace XmobiTea.GN.Constant
{
    public partial class OperationCode
    {
        public const int Logout = -10;
        public const int Debug = -1;
        public const int GetAppConfig = 1;
        public const int Login = 2;
        public const int RegisterAccount = 3;
        public const int EnterDisplayName = 4;
        public const int RegisterSocket = 5;
        public const int FetchAllData = 6;
        public const int CreateNewFileUploadInfo = 7;
        public const int GetFileUploadInfo = 8;
        public const int FetchSparkPlayer = 9;
        public const int AddFriend = 10;
        public const int RemoveFriend = 11;
        public const int GetFriends = 12;
        public const int FindPlayer = 13;
        public const int SendChatToUser = 14;
        public const int GetChatMessageUser = 15;
        public const int SendChatToChannel = 16;
        public const int JoinChatChannel = 17;
        public const int LeaveChatChannel = 18;
        public const int GetChatInfoChannel = 19;
        public const int GetChatMessageChannel = 20;
        public const int GetChatMemberChannel = 21;
        public const int EditChatInfoChannel = 22;
        public const int EditChatMessageChannel = 23;
        public const int EditChatMessageUser = 24;

        private OperationCode() { }
    }
}
