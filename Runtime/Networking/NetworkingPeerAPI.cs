namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Entity.Request;
    using XmobiTea.GN.Entity.Response;
    using XmobiTea.GN.Helper;

    public partial class NetworkingPeer
    {
        internal const string SYNC_TS = "ts";
        internal const string UPLOAD_FILE = "upload";
        internal const string DOWNLOAD_FILE = "upload";
        internal const string GET_CONFIG = "getConfig";
        internal const string API_JSON = "api/" + Commands.RequestCmd_Json;
        internal const string API_MSG_PACK = "api/" + Commands.RequestCmd_MsgPack;

        internal List<FriendItem> friendItemLst { get; set; }
        internal Action<FriendItem> onFriendItemChange { get; set; }

        internal List<ChatChannel> chatChannelLst { get; set; }
        internal Action<ChatChannel> onChatChannelChange { get; set; }

        internal List<ChatUser> chatUserLst { get; set; }
        internal Action<ChatUser> onChatUserChange { get; set; }

        internal void SyncTs(Action<long> onResponse = null)
        {
            (this.httpPeer as HttpPeer).GetRequest(SYNC_TS, httpAppResponse =>
            {
                if (!httpAppResponse.hasError)
                {
                    if (httpAppResponse.statusCode == 200)
                    {
                        var returnDatas = (IList)Parser.Parse(httpAppResponse.text);
                        var gnArray = new GNArray.Builder()
                            .AddAll(returnDatas)
                            .Build();

                        var returnCode = gnArray.GetInt(0);
                        if (returnCode == ReturnCode.Ok)
                        {
                            var gnHashtable = gnArray.GetGNHashtable(1);
                            var newServerTimestamp = gnHashtable.GetLong("1", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());

                            SetServerTimeMilliseconds(newServerTimestamp);
                        }
                    }
                }

                onResponse?.Invoke(serverTimestamp);
            });
        }

        internal void GetConfig(string configName, Action<string> onResponse)
        {
            (this.httpPeer as HttpPeer).GetRequest(GET_CONFIG + "/" + configName, httpAppResponse =>
            {
                if (!httpAppResponse.hasError)
                {
                    if (httpAppResponse.statusCode == 200)
                    {
                        var returnDatas = (IList)Parser.Parse(httpAppResponse.text);
                        var gnArray = new GNArray.Builder()
                            .AddAll(returnDatas)
                            .Build();

                        var returnCode = gnArray.GetInt(0);
                        if (returnCode == ReturnCode.Ok)
                        {
                            var gnHashtable = gnArray.GetGNHashtable(1);
                            var configStr = gnHashtable.GetString("1");

                            onResponse?.Invoke(configStr);
                        }
                    }
                }
            });
        }

        internal void DownloadFile(string fileId, Action<HttpAppResponse> onHttpAppResponse)
        {
            (this.httpPeer as HttpPeer).GetRequest(DOWNLOAD_FILE + "/" + fileId, onHttpAppResponse);
        }

        internal void UploadFile(string fileId, byte[] content, string mimeType, Action<HttpAppResponse> onHttpAppResponse)
        {
            (this.httpPeer as HttpPeer).UploadFile(fileId, content, mimeType, onHttpAppResponse);
        }

        internal void Debug(bool booleanValue, int numberValue, string stringValue, GNHashtable gnHashtableValue, GNArray gnArrayValue, Action<DebugOperationResponse> onResponse = null)
        {
            var request = new DebugOperationRequest(booleanValue, numberValue, stringValue, gnHashtableValue, gnArrayValue).Build();

            SendViaHttp(request, response =>
            {
                var debugOperationResponse = new DebugOperationResponse();
                debugOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(debugOperationResponse);
            });
        }

        internal void EnterDisplayName(string displayName, Action<EnterDisplayNameOperationResponse> onResponse = null)
        {
            var request = new EnterDisplayNameOperationRequest(displayName).Build();

            SendViaHttp(request, response =>
            {
                var enterDisplayNameOperationResponse = new EnterDisplayNameOperationResponse();
                enterDisplayNameOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(enterDisplayNameOperationResponse);
            });
        }

        internal void FetchAllData(Action<FetchAllDataOperationResponse> onResponse = null)
        {
            var request = new FetchAllDataOperationRequest().Build();

            SendViaHttp(request, response =>
            {
                var fetchAllDataOperationResponse = new FetchAllDataOperationResponse();
                fetchAllDataOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(fetchAllDataOperationResponse);
            });
        }

        internal void FetchSparkPlayer(Action<FetchSparkPlayerOperationResponse> onResponse = null)
        {
            var request = new FetchSparkPlayerOperationRequest().Build();

            SendViaHttp(request, response =>
            {
                var fetchSparkPlayerOperationResponse = new FetchSparkPlayerOperationResponse();
                fetchSparkPlayerOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(fetchSparkPlayerOperationResponse);
            });
        }

        internal void GetAppConfig(GNArray configTypes, Action<GetAppConfigOperationResponse> onResponse = null)
        {
            var request = new GetAppConfigOperationRequest(configTypes).Build();

            SendViaHttp(request, response =>
            {
                var getAppConfigOperationResponse = new GetAppConfigOperationResponse();
                getAppConfigOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(getAppConfigOperationResponse);
            });
        }

        internal void AccountLogin(string username, string password, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new AccountLoginOperationRequest(username, password).Build();

            SendViaHttp(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse();
                loginOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void DeviceLogin(Action<LoginOperationResponse> onResponse = null)
        {
            var request = new DeviceLoginOperationRequest(GNNetwork.deviceInfo).Build();

            SendViaHttp(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse();
                loginOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void FacebookLogin(string facebookToken, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new FacebookLoginOperationRequest(facebookToken).Build();

            SendViaHttp(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse();
                loginOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void GoogleLogin(string googleToken, int googleLoginType, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new GoogleLoginOperationRequest(googleToken, googleLoginType).Build();

            SendViaHttp(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse();
                loginOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void AppleLogin(string appleToken, string displayName, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new AppleLoginOperationRequest(appleToken, displayName).Build();

            SendViaHttp(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse();
                loginOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void UserIdLogin(string userId, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new UserIdLoginOperationRequest(userId).Build();

            SendViaHttp(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse();
                loginOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void PublicAddressLogin(string signature, string publicAddress, string message, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new PublicAddressLoginOperationRequest(signature, publicAddress, message).Build();

            SendViaHttp(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse();
                loginOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void PublicAddressGetRandomMessage(Action<PublicAddressGetRandomMessageOperationResponse> onResponse = null)
        {
            var request = new PublicAddressGetRandomMessageOperationRequest().Build();

            SendViaHttp(request, response =>
            {
                var publicAddressGetRandomMessageOperationResponse = new PublicAddressGetRandomMessageOperationResponse();
                publicAddressGetRandomMessageOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(publicAddressGetRandomMessageOperationResponse);
            });
        }

        internal void CustomIdLogin(string customId, Action<LoginOperationResponse> onResponse = null)
        {
            var request = new CustomIdLoginOperationRequest(customId).Build();

            SendViaHttp(request, response =>
            {
                var loginOperationResponse = new LoginOperationResponse();
                loginOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(loginOperationResponse);
            });
        }

        internal void RegisterAccount(string username, string password, Action<RegisterAccountOperationResponse> onResponse = null)
        {
            var request = new RegisterAccountOperationRequest(username, password).Build();

            SendViaHttp(request, response =>
            {
                var registerAccountOperationResponse = new RegisterAccountOperationResponse();
                registerAccountOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(registerAccountOperationResponse);
            });
        }

        internal void RegisterSocket(string sid, Action<RegisterSocketOperationResponse> onResponse = null)
        {
            var request = new RegisterSocketOperationRequest(sid).Build();

            SendViaHttp(request, response =>
            {
                var registerSocketOperationResponse = new RegisterSocketOperationResponse();
                registerSocketOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(registerSocketOperationResponse);
            });
        }

        internal void Template(bool booleanValue, Action<TemplateOperationResponse> onResponse = null)
        {
            var request = new TemplateOperationRequest(booleanValue).Build();

            SendViaHttp(request, response =>
            {
                var templateOperationResponse = new TemplateOperationResponse();
                templateOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(templateOperationResponse);
            });
        }

        internal void CreateNewFileUploadInfo(string originFileName, Action<CreateNewFileUploadInfoOperationResponse> onResponse = null)
        {
            var request = new CreateNewFileUploadInfoOperationRequest(originFileName).Build();

            SendViaHttp(request, response =>
            {
                var createNewFileUploadInfoOperationResponse = new CreateNewFileUploadInfoOperationResponse();
                createNewFileUploadInfoOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(createNewFileUploadInfoOperationResponse);
            });
        }

        internal void GetFileUploadInfo(string fileId, Action<GetFileUploadInfoOperationResponse> onResponse = null)
        {
            var request = new GetFileUploadInfoOperationRequest(fileId).Build();

            SendViaHttp(request, response =>
            {
                var getFileUploadInfoOperationResponse = new GetFileUploadInfoOperationResponse();
                getFileUploadInfoOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(getFileUploadInfoOperationResponse);
            });
        }

        internal void Logout(Action<LogoutOperationResponse> onResponse = null)
        {
            var request = new LogoutOperationRequest().Build();

            SendViaHttp(request, response =>
            {
                var logoutOperationResponse = new LogoutOperationResponse();
                logoutOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(logoutOperationResponse);
            });
        }

        internal void AddFriend(string friendId, bool? forceAcceptFriend = false, Action<AddFriendOperationResponse> onResponse = null)
        {
            var request = new AddFriendOperationRequest(friendId, forceAcceptFriend).Build();

            SendViaHttp(request, response =>
            {
                var addFriendOperationResponse = new AddFriendOperationResponse();
                addFriendOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(addFriendOperationResponse);
            });
        }

        internal void RemoveFriend(string friendId, Action<RemoveFriendOperationResponse> onResponse = null)
        {
            var request = new RemoveFriendOperationRequest(friendId).Build();

            SendViaHttp(request, response =>
            {
                var removeFriendOperationResponse = new RemoveFriendOperationResponse();
                removeFriendOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(removeFriendOperationResponse);
            });
        }

        internal void GetFriends(Action<GetFriendsOperationResponse> onResponse = null)
        {
            var request = new GetFriendsOperationRequest().Build();

            SendViaHttp(request, response =>
            {
                var getFriendsOperationResponse = new GetFriendsOperationResponse();
                getFriendsOperationResponse.SetupOperationResponse(response);

                this.friendItemLst.Clear();

                if (getFriendsOperationResponse.errorCode == FriendErrorCode.Ok)
                {
                    var friendLst = getFriendsOperationResponse.friendLst;
                    for (var i = 0; i < friendLst.Count; i++)
                    {
                        var friend = friendLst[i];

                        this.friendItemLst.Add(new FriendItem()
                        {
                            friendId = friend.friendId,
                            friendStatus = (FriendStatus)friend.friendStatus,
                            isSocialLoginFriend = friend.isSocialLoginFriend,
                            tsLastUpdate = friend.tsLastUpdate
                        });
                    }
                }

                onResponse?.Invoke(getFriendsOperationResponse);
            });
        }

        internal void FindPlayer(string keyword, int skip = 0, int limit = 20, Action<FindPlayerOperationResponse> onResponse = null)
        {
            var request = new FindPlayerOperationRequest(keyword, skip, limit).Build();

            SendViaHttp(request, response =>
            {
                var findPlayerOperationResponse = new FindPlayerOperationResponse();
                findPlayerOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(findPlayerOperationResponse);
            });
        }

        internal void SendChatToUser(string userId, string message, bool? saveToDatabase = false, Action<SendChatToUserOperationResponse> onResponse = null)
        {
            var request = new SendChatToUserOperationRequest(userId, message, saveToDatabase).Build();

            SendViaHttp(request, response =>
            {
                var sendChatToUserOperationResponse = new SendChatToUserOperationResponse();
                sendChatToUserOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(sendChatToUserOperationResponse);
            });
        }

        internal void GetChatMessageUser(string userId, int skip = 0, int limit = 20, Action<GetChatMessageUserOperationResponse> onResponse = null)
        {
            var request = new GetChatMessageUserOperationRequest(userId, skip, limit).Build();

            SendViaHttp(request, response =>
            {
                var getChatMessageUserOperationResponse = new GetChatMessageUserOperationResponse();
                getChatMessageUserOperationResponse.SetupOperationResponse(response);

                if (getChatMessageUserOperationResponse.errorCode == ChatErrorCode.Ok)
                {
                    var chatUser = this.chatUserLst.Find(x => x.userId.Equals(userId));

                    if (chatUser == null)
                    {
                        chatUser = new ChatUser();
                        chatUser.userId = userId;
                        chatUser.messages = new List<ChatMessage>();

                        this.chatUserLst.Add(chatUser);
                    }

                    for (var i = 0; i < getChatMessageUserOperationResponse.messages.Count; i++)
                    {
                        var responseMessage = getChatMessageUserOperationResponse.messages[i];

                        var message = chatUser.messages.Find(x => x.tsCreate == responseMessage.tsCreate);
                        if (message == null)
                        {
                            message = new ChatMessage();
                            message.tsCreate = responseMessage.tsCreate;
                            message.messageEditeds = new List<EditChatMessage>();

                            chatUser.messages.Add(message);
                        }

                        message.senderId = responseMessage.senderId;
                        message.tsLastUpdate = responseMessage.tsLastUpdate;
                        message.message = responseMessage.message;

                        message.messageEditeds.Clear();

                        for (var j = 0; j < responseMessage.messageEditeds.Count; j++)
                        {
                            var responseMessageEdited = responseMessage.messageEditeds[j];

                            message.messageEditeds.Add(new EditChatMessage()
                            {
                                message = responseMessageEdited.message,
                                tsCreate = responseMessageEdited.tsCreate
                            });
                        }

                        message.isDelete = responseMessage.isDelete;
                    }

                    this.onChatUserChange?.Invoke(chatUser);
                }

                onResponse?.Invoke(getChatMessageUserOperationResponse);
            });
        }

        internal void SendChatToChannel(string channel, string message, Action<SendChatToChannelOperationResponse> onResponse = null)
        {
            var request = new SendChatToChannelOperationRequest(channel, message).Build();

            SendViaHttp(request, response =>
            {
                var sendChatToChannelOperationResponse = new SendChatToChannelOperationResponse();
                sendChatToChannelOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(sendChatToChannelOperationResponse);
            });
        }

        internal void JoinChatChannel(string channel, Action<JoinChatChannelOperationResponse> onResponse = null)
        {
            var request = new JoinChatChannelOperationRequest(channel).Build();

            SendViaHttp(request, response =>
            {
                var joinChatChannelOperationResponse = new JoinChatChannelOperationResponse();
                joinChatChannelOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(joinChatChannelOperationResponse);
            });
        }

        internal void LeaveChatChannel(string channel, Action<LeaveChatChannelOperationResponse> onResponse = null)
        {
            var request = new LeaveChatChannelOperationRequest(channel).Build();

            SendViaHttp(request, response =>
            {
                var leaveChatChannelOperationResponse = new LeaveChatChannelOperationResponse();
                leaveChatChannelOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(leaveChatChannelOperationResponse);
            });
        }

        internal void GetChatInfoChannel(string channel, Action<GetChatInfoChannelOperationResponse> onResponse = null)
        {
            var request = new GetChatInfoChannelOperationRequest(channel).Build();

            SendViaHttp(request, response =>
            {
                var getChatInfoChannelOperationResponse = new GetChatInfoChannelOperationResponse();
                getChatInfoChannelOperationResponse.SetupOperationResponse(response);

                if (getChatInfoChannelOperationResponse.errorCode == ChatErrorCode.Ok)
                {
                    var chatChannel = this.chatChannelLst.Find(x => x.channel.Equals(channel));

                    if (chatChannel == null) {
                        chatChannel = new ChatChannel();
                        chatChannel.channel = channel;

                        chatChannel.avatarChannel = new AvatarChannel();
                        chatChannel.users = new List<UserChannel>();
                        chatChannel.messages = new List<ChatMessage>();

                        this.chatChannelLst.Add(chatChannel);
                    }

                    var channelInfo = getChatInfoChannelOperationResponse.channelInfo;

                    chatChannel.avatarChannel.type = channelInfo.avatarChannel.type;
                    chatChannel.avatarChannel.value = channelInfo.avatarChannel.value;

                    chatChannel.tsCreate = channelInfo.tsCreate;
                    chatChannel.name = channelInfo.name;
                    chatChannel.channelType = channelInfo.channelType;
                    chatChannel.userCount = channelInfo.userCount;

                    this.onChatChannelChange?.Invoke(chatChannel);
                }

                onResponse?.Invoke(getChatInfoChannelOperationResponse);
            });
        }

        internal void GetChatMessageChannel(string channel, int skip = 0, int limit = 20, Action<GetChatMessageChannelOperationResponse> onResponse = null)
        {
            var request = new GetChatMessageChannelOperationRequest(channel, skip, limit).Build();

            SendViaHttp(request, response =>
            {
                var getChatMessageChannelOperationResponse = new GetChatMessageChannelOperationResponse();
                getChatMessageChannelOperationResponse.SetupOperationResponse(response);

                if (getChatMessageChannelOperationResponse.errorCode == ChatErrorCode.Ok)
                {
                    var chatChannel = this.chatChannelLst.Find(x => x.channel.Equals(channel));

                    if (chatChannel == null)
                    {
                        chatChannel = new ChatChannel();
                        chatChannel.channel = channel;

                        chatChannel.avatarChannel = new AvatarChannel();
                        chatChannel.users = new List<UserChannel>();
                        chatChannel.messages = new List<ChatMessage>();

                        this.chatChannelLst.Add(chatChannel);
                    }

                    var channelInfo = getChatMessageChannelOperationResponse.channelInfo;

                    for (var i = 0; i < channelInfo.messages.Count; i++)
                    {
                        var responseMessage = channelInfo.messages[i];

                        var message = chatChannel.messages.Find(x => x.tsCreate == responseMessage.tsCreate);
                        if (message == null)
                        {
                            message = new ChatMessage();
                            message.tsCreate = responseMessage.tsCreate;
                            message.messageEditeds = new List<EditChatMessage>();

                            chatChannel.messages.Add(message);
                        }

                        message.senderId = responseMessage.senderId;
                        message.tsLastUpdate = responseMessage.tsLastUpdate;
                        message.message = responseMessage.message;

                        message.messageEditeds.Clear();

                        for (var j = 0; j < responseMessage.messageEditeds.Count; j++)
                        {
                            var responseMessageEdited = responseMessage.messageEditeds[j];

                            message.messageEditeds.Add(new EditChatMessage()
                            {
                                message = responseMessageEdited.message,
                                tsCreate = responseMessageEdited.tsCreate
                            });
                        }

                        message.isDelete = responseMessage.isDelete;
                    }

                    this.onChatChannelChange?.Invoke(chatChannel);
                }

                onResponse?.Invoke(getChatMessageChannelOperationResponse);
            });
        }

        internal void GetChatMemberChannel(string channel, Action<GetChatMemberChannelOperationResponse> onResponse = null)
        {
            var request = new GetChatMemberChannelOperationRequest(channel).Build();

            SendViaHttp(request, response =>
            {
                var getChatMemberChannelOperationResponse = new GetChatMemberChannelOperationResponse();
                getChatMemberChannelOperationResponse.SetupOperationResponse(response);

                if (getChatMemberChannelOperationResponse.errorCode == ChatErrorCode.Ok)
                {
                    var chatChannel = this.chatChannelLst.Find(x => x.channel.Equals(channel));

                    if (chatChannel == null)
                    {
                        chatChannel = new ChatChannel();
                        chatChannel.channel = channel;

                        chatChannel.avatarChannel = new AvatarChannel();
                        chatChannel.users = new List<UserChannel>();
                        chatChannel.messages = new List<ChatMessage>();

                        this.chatChannelLst.Add(chatChannel);
                    }

                    var channelInfo = getChatMemberChannelOperationResponse.channelInfo;

                    chatChannel.users.Clear();

                    for (var i = 0; i < channelInfo.members.Count; i++)
                    {
                        var member = channelInfo.members[i];

                        chatChannel.users.Add(new UserChannel()
                        {
                            userId = member.userId,
                            tsJoin = member.tsJoin
                        });
                    }

                    chatChannel.userCount = chatChannel.users.Count;

                    this.onChatChannelChange?.Invoke(chatChannel);
                }

                onResponse?.Invoke(getChatMemberChannelOperationResponse);
            });
        }

        internal void EditChatInfoChannel(string channel, string name = null, GNHashtable avatarChannel = null, Action<EditChatInfoChannelOperationResponse> onResponse = null)
        {
            var request = new EditChatInfoChannelOperationRequest(channel, name, avatarChannel).Build();

            SendViaHttp(request, response =>
            {
                var editChatInfoChannelOperationResponse = new EditChatInfoChannelOperationResponse();
                editChatInfoChannelOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(editChatInfoChannelOperationResponse);
            });
        }

        internal void EditChatMessageChannel(long tsCreate, string channel, string message = null, bool? isDelete = null, Action<EditChatMessageChannelOperationResponse> onResponse = null)
        {
            var request = new EditChatMessageChannelOperationRequest(tsCreate, channel, message, isDelete).Build();

            SendViaHttp(request, response =>
            {
                var editChatMessageChannelOperationResponse = new EditChatMessageChannelOperationResponse();
                editChatMessageChannelOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(editChatMessageChannelOperationResponse);
            });
        }

        internal void EditChatMessageUser(long tsCreate, string userId, string message = null, bool? isDelete = null, Action<EditChatMessageUserOperationResponse> onResponse = null)
        {
            var request = new EditChatMessageUserOperationRequest(tsCreate, userId, message, isDelete).Build();

            SendViaHttp(request, response =>
            {
                var editChatMessageChannelOperationResponse = new EditChatMessageUserOperationResponse();
                editChatMessageChannelOperationResponse.SetupOperationResponse(response);

                onResponse?.Invoke(editChatMessageChannelOperationResponse);
            });
        }

    }

}
