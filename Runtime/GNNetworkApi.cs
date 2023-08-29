namespace XmobiTea.GN
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Entity.Response;

    using System;
    using XmobiTea.GN.Networking;
    using XmobiTea.GN.Constant;
    using System.Collections.Generic;
    using XmobiTea.GN.Entity;

    public static partial class GNNetwork
    {
        public static List<FriendItem> GetFriendItemLst()
        {
            return peer.friendItemLst;
        }
        internal static Action<FriendItem> onFriendItemChange => peer.onFriendItemChange;
        public static void SubscriberOnFriendItemChange(Action<FriendItem> onHandler)
        {
            peer.onFriendItemChange += onHandler;
        }

        public static List<ChatChannel> GetChatChannelLst()
        {
            return peer.chatChannelLst;
        }
        internal static Action<ChatChannel> onChatChannelChange => peer.onChatChannelChange;
        public static void SubscriberOnChatChannelChange(Action<ChatChannel> onHandler)
        {
            peer.onChatChannelChange += onHandler;
        }

        public static List<ChatUser> GetChatUserLst()
        {
            return peer.chatUserLst;
        }
        internal static Action<ChatUser> onChatUserChange => peer.onChatUserChange;
        public static void SubscriberOnChatUserChange(Action<ChatUser> onHandler)
        {
            peer.onChatUserChange += onHandler;
        }

        public static void SyncTs(Action<long> onResponse = null)
        {
            peer.SyncTs(onResponse);
        }

        public static void GetConfig(string configName, Action<string> onResponse)
        {
            peer.GetConfig(configName, onResponse);
        }

        public static void DownloadFile(string fileId, Action<HttpAppResponse> onHttpAppResponse)
        {
            peer.DownloadFile(fileId, onHttpAppResponse);
        }

        public static void UploadFile(string fileId, byte[] content, string mimeType, Action<HttpAppResponse> onHttpAppResponse)
        {
            peer.UploadFile(fileId, content, mimeType, onHttpAppResponse);
        }

        public static void Debug(bool booleanValue, int numberValue, string stringValue, GNHashtable gnHashtableValue, GNArray gnArrayValue, Action<DebugOperationResponse> onResponse = null)
        {
            peer.Debug(booleanValue, numberValue, stringValue, gnHashtableValue, gnArrayValue, onResponse);
        }

        public static void EnterDisplayName(string displayName, Action<EnterDisplayNameOperationResponse> onResponse = null)
        {
            peer.EnterDisplayName(displayName, onResponse);
        }

        public static void FetchAllData(Action<FetchAllDataOperationResponse> onResponse = null)
        {
            peer.FetchAllData(onResponse);
        }

        public static void FetchSparkPlayer(Action<FetchSparkPlayerOperationResponse> onResponse = null)
        {
            peer.FetchSparkPlayer(onResponse);
        }

        public static void GetAppConfig(GNArray configTypes, Action<GetAppConfigOperationResponse> onResponse = null)
        {
            peer.GetAppConfig(configTypes, onResponse);
        }

        public static void AccountLogin(string username, string password, Action<LoginOperationResponse> onResponse = null)
        {
            peer.AccountLogin(username, password, onResponse);
        }

        public static void DeviceLogin(Action<LoginOperationResponse> onResponse = null)
        {
            peer.DeviceLogin(onResponse);
        }

        public static void FacebookLogin(string facebookToken, Action<LoginOperationResponse> onResponse = null)
        {
            peer.FacebookLogin(facebookToken, onResponse);
        }

        public static void GoogleLogin(string googleToken, GoogleLoginType googleLoginType, Action<LoginOperationResponse> onResponse = null)
        {
            peer.GoogleLogin(googleToken, (int)googleLoginType, onResponse);
        }

        public static void AppleLogin(string appleToken, string displayName = null, Action<LoginOperationResponse> onResponse = null)
        {
            peer.AppleLogin(appleToken, displayName, onResponse);
        }

        public static void UserIdLogin(string userId, Action<LoginOperationResponse> onResponse = null)
        {
            peer.UserIdLogin(userId, onResponse);
        }

        public static void PublicAddressLogin(string signature, string publicAddress, string message, Action<LoginOperationResponse> onResponse = null)
        {
            peer.PublicAddressLogin(signature, publicAddress, message, onResponse);
        }

        public static void PublicAddressGetRandomMessage(Action<PublicAddressGetRandomMessageOperationResponse> onResponse = null)
        {
            peer.PublicAddressGetRandomMessage(onResponse);
        }

        public static void CustomIdLogin(string customId, Action<LoginOperationResponse> onResponse = null)
        {
            peer.CustomIdLogin(customId, onResponse);
        }

        public static void RegisterAccount(string username, string password, Action<RegisterAccountOperationResponse> onResponse = null)
        {
            peer.RegisterAccount(username, password, onResponse);
        }

        public static void RegisterSocket(string sid, Action<RegisterSocketOperationResponse> onResponse = null)
        {
            peer.RegisterSocket(sid, onResponse);
        }

        public static void Template(bool booleanValue, Action<TemplateOperationResponse> onResponse = null)
        {
            peer.Template(booleanValue, onResponse);
        }

        public static void CreateNewFileUploadInfo(string originFileName, Action<CreateNewFileUploadInfoOperationResponse> onResponse = null)
        {
            peer.CreateNewFileUploadInfo(originFileName, onResponse);
        }

        public static void GetFileUploadInfo(string fileId, Action<GetFileUploadInfoOperationResponse> onResponse = null)
        {
            peer.GetFileUploadInfo(fileId, onResponse);
        }

        public static void Logout(Action<LogoutOperationResponse> onResponse = null)
        {
            peer.Logout(onResponse);
        }

        public static void AddFriend(string friendId, bool? forceAcceptFriend = false, Action<AddFriendOperationResponse> onResponse = null)
        {
            peer.AddFriend(friendId, forceAcceptFriend, onResponse);
        }

        public static void RemoveFriend(string friendId, Action<RemoveFriendOperationResponse> onResponse = null)
        {
            peer.RemoveFriend(friendId, onResponse);
        }

        public static void GetFriends(Action<GetFriendsOperationResponse> onResponse = null)
        {
            peer.GetFriends(onResponse);
        }

        public static void FindPlayer(string keyword, int skip = 0, int limit = 20, Action<FindPlayerOperationResponse> onResponse = null)
        {
            peer.FindPlayer(keyword, skip, limit, onResponse);
        }

        public static void SendChatToUser(string userId, string message, bool? saveToDatabase = false, Action<SendChatToUserOperationResponse> onResponse = null)
        {
            peer.SendChatToUser(userId, message, saveToDatabase, onResponse);
        }

        public static void GetChatMessageUser(string userId, int skip = 0, int limit = 20, Action<GetChatMessageUserOperationResponse> onResponse = null)
        {
            peer.GetChatMessageUser(userId, skip, limit, onResponse);
        }

        public static void SendChatToChannel(string channel, string message, Action<SendChatToChannelOperationResponse> onResponse = null)
        {
            peer.SendChatToChannel(channel, message, onResponse);
        }

        public static void JoinChatChannel(string channel, Action<JoinChatChannelOperationResponse> onResponse = null)
        {
            peer.JoinChatChannel(channel, onResponse);
        }

        public static void LeaveChatChannel(string channel, Action<LeaveChatChannelOperationResponse> onResponse = null)
        {
            peer.LeaveChatChannel(channel, onResponse);
        }

        public static void GetChatInfoChannel(string channel, Action<GetChatInfoChannelOperationResponse> onResponse = null)
        {
            peer.GetChatInfoChannel(channel, onResponse);
        }

        public static void GetChatMessageChannel(string channel, int skip = 0, int limit = 20, Action<GetChatMessageChannelOperationResponse> onResponse = null)
        {
            peer.GetChatMessageChannel(channel, skip, limit, onResponse);
        }

        public static void GetChatMemberChannel(string channel, Action<GetChatMemberChannelOperationResponse> onResponse = null)
        {
            peer.GetChatMemberChannel(channel, onResponse);
        }

        public static void EditChatInfoChannel(string channel, string name = null, GNHashtable avatarChannel = null, Action<EditChatInfoChannelOperationResponse> onResponse = null)
        {
            peer.EditChatInfoChannel(channel, name, avatarChannel, onResponse);
        }

        public static void EditChatMessageChannel(long tsCreate, string channel, string message = null, bool? isDelete = null, Action<EditChatMessageChannelOperationResponse> onResponse = null)
        {
            peer.EditChatMessageChannel(tsCreate, channel, message, isDelete, onResponse);
        }

        public static void EditChatMessageUser(long tsCreate, string userId, string message = null, bool? isDelete = null, Action<EditChatMessageUserOperationResponse> onResponse = null)
        {
            peer.EditChatMessageUser(tsCreate, userId, message, isDelete, onResponse);
        }

    }

}
