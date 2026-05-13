namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    /// <summary>
    /// Defines typed request wrappers for game player operations.
    /// </summary>
    public class GamePlayerRequestModels
    {
        /// <summary>
        /// Builds the add player friend operation request.
        /// </summary>
        public class AddPlayerFriendOperationRequest : CustomOperationRequest<GamePlayerModels.AddPlayerFriendRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.AddPlayerFriend;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the AddPlayerFriendOperationRequest class.
            /// </summary>
            public AddPlayerFriendOperationRequest(GamePlayerModels.AddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped add player friend operation request.
        /// </summary>
        public class ServerAddPlayerFriendOperationRequest : AddPlayerFriendOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerAddPlayerFriendOperationRequest class.
            /// </summary>
            public ServerAddPlayerFriendOperationRequest(GamePlayerModels.ServerAddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped add player friend operation request.
        /// </summary>
        public class AdminAddPlayerFriendOperationRequest : AddPlayerFriendOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminAddPlayerFriendOperationRequest class.
            /// </summary>
            public AdminAddPlayerFriendOperationRequest(GamePlayerModels.AdminAddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the add segment operation request.
        /// </summary>
        public class AddSegmentOperationRequest : CustomOperationRequest<GamePlayerModels.AddSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.AddSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the AddSegmentOperationRequest class.
            /// </summary>
            public AddSegmentOperationRequest(GamePlayerModels.AddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped add segment operation request.
        /// </summary>
        public class ServerAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerAddSegmentOperationRequest class.
            /// </summary>
            public ServerAddSegmentOperationRequest(GamePlayerModels.ServerAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped add segment operation request.
        /// </summary>
        public class AdminAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminAddSegmentOperationRequest class.
            /// </summary>
            public AdminAddSegmentOperationRequest(GamePlayerModels.AdminAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get avatar operation request.
        /// </summary>
        public class GetAvatarOperationRequest : CustomOperationRequest<GamePlayerModels.GetAvatarRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetAvatar;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetAvatarOperationRequest class.
            /// </summary>
            public GetAvatarOperationRequest(GamePlayerModels.GetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get avatar operation request.
        /// </summary>
        public class ServerGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetAvatarOperationRequest class.
            /// </summary>
            public ServerGetAvatarOperationRequest(GamePlayerModels.ServerGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get avatar operation request.
        /// </summary>
        public class AdminGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetAvatarOperationRequest class.
            /// </summary>
            public AdminGetAvatarOperationRequest(GamePlayerModels.AdminGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get country code operation request.
        /// </summary>
        public class GetCountryCodeOperationRequest : CustomOperationRequest<GamePlayerModels.GetCountryCodeRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCountryCode;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCountryCodeOperationRequest class.
            /// </summary>
            public GetCountryCodeOperationRequest(GamePlayerModels.GetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get country code operation request.
        /// </summary>
        public class ServerGetCountryCodeOperationRequest : GetCountryCodeOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetCountryCodeOperationRequest class.
            /// </summary>
            public ServerGetCountryCodeOperationRequest(GamePlayerModels.ServerGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get country code operation request.
        /// </summary>
        public class AdminGetCountryCodeOperationRequest : GetCountryCodeOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetCountryCodeOperationRequest class.
            /// </summary>
            public AdminGetCountryCodeOperationRequest(GamePlayerModels.AdminGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get custom data operation request.
        /// </summary>
        public class GetCustomDataOperationRequest : CustomOperationRequest<GamePlayerModels.GetCustomDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCustomData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCustomDataOperationRequest class.
            /// </summary>
            public GetCustomDataOperationRequest(GamePlayerModels.GetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get custom data operation request.
        /// </summary>
        public class ServerGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetCustomDataOperationRequest class.
            /// </summary>
            public ServerGetCustomDataOperationRequest(GamePlayerModels.ServerGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get custom data operation request.
        /// </summary>
        public class AdminGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetCustomDataOperationRequest class.
            /// </summary>
            public AdminGetCustomDataOperationRequest(GamePlayerModels.AdminGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get display name operation request.
        /// </summary>
        public class GetDisplayNameOperationRequest : CustomOperationRequest<GamePlayerModels.GetDisplayNameRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetDisplayName;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetDisplayNameOperationRequest class.
            /// </summary>
            public GetDisplayNameOperationRequest(GamePlayerModels.GetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get display name operation request.
        /// </summary>
        public class ServerGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetDisplayNameOperationRequest class.
            /// </summary>
            public ServerGetDisplayNameOperationRequest(GamePlayerModels.ServerGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get display name operation request.
        /// </summary>
        public class AdminGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetDisplayNameOperationRequest class.
            /// </summary>
            public AdminGetDisplayNameOperationRequest(GamePlayerModels.AdminGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get friend statistics leaderboard around player operation request.
        /// </summary>
        public class GetFriendStatisticsLeaderboardAroundPlayerOperationRequest : CustomOperationRequest<GamePlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetFriendStatisticsLeaderboardAroundPlayer;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetFriendStatisticsLeaderboardAroundPlayerOperationRequest class.
            /// </summary>
            public GetFriendStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get friend statistics leaderboard around player operation request.
        /// </summary>
        public class ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest : GetFriendStatisticsLeaderboardAroundPlayerOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest class.
            /// </summary>
            public ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get friend statistics leaderboard around player operation request.
        /// </summary>
        public class AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest : GetFriendStatisticsLeaderboardAroundPlayerOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest class.
            /// </summary>
            public AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get friend statistics leaderboard operation request.
        /// </summary>
        public class GetFriendStatisticsLeaderboardOperationRequest : CustomOperationRequest<GamePlayerModels.GetFriendStatisticsLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetFriendStatisticsLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetFriendStatisticsLeaderboardOperationRequest class.
            /// </summary>
            public GetFriendStatisticsLeaderboardOperationRequest(GamePlayerModels.GetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get friend statistics leaderboard operation request.
        /// </summary>
        public class ServerGetFriendStatisticsLeaderboardOperationRequest : GetFriendStatisticsLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetFriendStatisticsLeaderboardOperationRequest class.
            /// </summary>
            public ServerGetFriendStatisticsLeaderboardOperationRequest(GamePlayerModels.ServerGetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get friend statistics leaderboard operation request.
        /// </summary>
        public class AdminGetFriendStatisticsLeaderboardOperationRequest : GetFriendStatisticsLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetFriendStatisticsLeaderboardOperationRequest class.
            /// </summary>
            public AdminGetFriendStatisticsLeaderboardOperationRequest(GamePlayerModels.AdminGetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get IP address create operation request.
        /// </summary>
        public class GetIpAddressCreateOperationRequest : CustomOperationRequest<GamePlayerModels.GetIpAddressCreateRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetIpAddressCreate;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetIpAddressCreateOperationRequest class.
            /// </summary>
            public GetIpAddressCreateOperationRequest(GamePlayerModels.GetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get IP address create operation request.
        /// </summary>
        public class ServerGetIpAddressCreateOperationRequest : GetIpAddressCreateOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetIpAddressCreateOperationRequest class.
            /// </summary>
            public ServerGetIpAddressCreateOperationRequest(GamePlayerModels.ServerGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get IP address create operation request.
        /// </summary>
        public class AdminGetIpAddressCreateOperationRequest : GetIpAddressCreateOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetIpAddressCreateOperationRequest class.
            /// </summary>
            public AdminGetIpAddressCreateOperationRequest(GamePlayerModels.AdminGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get online status operation request.
        /// </summary>
        public class GetOnlineStatusOperationRequest : CustomOperationRequest<GamePlayerModels.GetOnlineStatusRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetOnlineStatus;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetOnlineStatusOperationRequest class.
            /// </summary>
            public GetOnlineStatusOperationRequest(GamePlayerModels.GetOnlineStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get online status operation request.
        /// </summary>
        public class ServerGetOnlineStatusOperationRequest : GetOnlineStatusOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetOnlineStatusOperationRequest class.
            /// </summary>
            public ServerGetOnlineStatusOperationRequest(GamePlayerModels.ServerGetOnlineStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get online status operation request.
        /// </summary>
        public class AdminGetOnlineStatusOperationRequest : GetOnlineStatusOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetOnlineStatusOperationRequest class.
            /// </summary>
            public AdminGetOnlineStatusOperationRequest(GamePlayerModels.AdminGetOnlineStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player ban operation request.
        /// </summary>
        public class GetPlayerBanOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerBanRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerBan;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerBanOperationRequest class.
            /// </summary>
            public GetPlayerBanOperationRequest(GamePlayerModels.GetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get player ban operation request.
        /// </summary>
        public class ServerGetPlayerBanOperationRequest : GetPlayerBanOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayerBanOperationRequest class.
            /// </summary>
            public ServerGetPlayerBanOperationRequest(GamePlayerModels.ServerGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get player ban operation request.
        /// </summary>
        public class AdminGetPlayerBanOperationRequest : GetPlayerBanOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayerBanOperationRequest class.
            /// </summary>
            public AdminGetPlayerBanOperationRequest(GamePlayerModels.AdminGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player character operation request.
        /// </summary>
        public class GetPlayerCharacterOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerCharacterRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerCharacter;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerCharacterOperationRequest class.
            /// </summary>
            public GetPlayerCharacterOperationRequest(GamePlayerModels.GetPlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get player character operation request.
        /// </summary>
        public class ServerGetPlayerCharacterOperationRequest : GetPlayerCharacterOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayerCharacterOperationRequest class.
            /// </summary>
            public ServerGetPlayerCharacterOperationRequest(GamePlayerModels.ServerGetPlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get player character operation request.
        /// </summary>
        public class AdminGetPlayerCharacterOperationRequest : GetPlayerCharacterOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayerCharacterOperationRequest class.
            /// </summary>
            public AdminGetPlayerCharacterOperationRequest(GamePlayerModels.AdminGetPlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player currency operation request.
        /// </summary>
        public class GetPlayerCurrencyOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerCurrencyRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerCurrency;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerCurrencyOperationRequest class.
            /// </summary>
            public GetPlayerCurrencyOperationRequest(GamePlayerModels.GetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get player currency operation request.
        /// </summary>
        public class ServerGetPlayerCurrencyOperationRequest : GetPlayerCurrencyOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayerCurrencyOperationRequest class.
            /// </summary>
            public ServerGetPlayerCurrencyOperationRequest(GamePlayerModels.ServerGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get player currency operation request.
        /// </summary>
        public class AdminGetPlayerCurrencyOperationRequest : GetPlayerCurrencyOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayerCurrencyOperationRequest class.
            /// </summary>
            public AdminGetPlayerCurrencyOperationRequest(GamePlayerModels.AdminGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player data operation request.
        /// </summary>
        public class GetPlayerDataOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerDataOperationRequest class.
            /// </summary>
            public GetPlayerDataOperationRequest(GamePlayerModels.GetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get player data operation request.
        /// </summary>
        public class ServerGetPlayerDataOperationRequest : GetPlayerDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayerDataOperationRequest class.
            /// </summary>
            public ServerGetPlayerDataOperationRequest(GamePlayerModels.ServerGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get player data operation request.
        /// </summary>
        public class AdminGetPlayerDataOperationRequest : GetPlayerDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayerDataOperationRequest class.
            /// </summary>
            public AdminGetPlayerDataOperationRequest(GamePlayerModels.AdminGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player friend operation request.
        /// </summary>
        public class GetPlayerFriendOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerFriendRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerFriend;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerFriendOperationRequest class.
            /// </summary>
            public GetPlayerFriendOperationRequest(GamePlayerModels.GetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get player friend operation request.
        /// </summary>
        public class ServerGetPlayerFriendOperationRequest : GetPlayerFriendOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayerFriendOperationRequest class.
            /// </summary>
            public ServerGetPlayerFriendOperationRequest(GamePlayerModels.ServerGetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get player friend operation request.
        /// </summary>
        public class AdminGetPlayerFriendOperationRequest : GetPlayerFriendOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayerFriendOperationRequest class.
            /// </summary>
            public AdminGetPlayerFriendOperationRequest(GamePlayerModels.AdminGetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player group operation request.
        /// </summary>
        public class GetPlayerGroupOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerGroupRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerGroup;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerGroupOperationRequest class.
            /// </summary>
            public GetPlayerGroupOperationRequest(GamePlayerModels.GetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get player group operation request.
        /// </summary>
        public class ServerGetPlayerGroupOperationRequest : GetPlayerGroupOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayerGroupOperationRequest class.
            /// </summary>
            public ServerGetPlayerGroupOperationRequest(GamePlayerModels.ServerGetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get player group operation request.
        /// </summary>
        public class AdminGetPlayerGroupOperationRequest : GetPlayerGroupOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayerGroupOperationRequest class.
            /// </summary>
            public AdminGetPlayerGroupOperationRequest(GamePlayerModels.AdminGetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player information operation request.
        /// </summary>
        public class GetPlayerInformationOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerInformationRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerInformation;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerInformationOperationRequest class.
            /// </summary>
            public GetPlayerInformationOperationRequest(GamePlayerModels.GetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get player information operation request.
        /// </summary>
        public class ServerGetPlayerInformationOperationRequest : GetPlayerInformationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayerInformationOperationRequest class.
            /// </summary>
            public ServerGetPlayerInformationOperationRequest(GamePlayerModels.ServerGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get player information operation request.
        /// </summary>
        public class AdminGetPlayerInformationOperationRequest : GetPlayerInformationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayerInformationOperationRequest class.
            /// </summary>
            public AdminGetPlayerInformationOperationRequest(GamePlayerModels.AdminGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player inventory operation request.
        /// </summary>
        public class GetPlayerInventoryOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerInventoryRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerInventory;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerInventoryOperationRequest class.
            /// </summary>
            public GetPlayerInventoryOperationRequest(GamePlayerModels.GetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get player inventory operation request.
        /// </summary>
        public class ServerGetPlayerInventoryOperationRequest : GetPlayerInventoryOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayerInventoryOperationRequest class.
            /// </summary>
            public ServerGetPlayerInventoryOperationRequest(GamePlayerModels.ServerGetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get player inventory operation request.
        /// </summary>
        public class AdminGetPlayerInventoryOperationRequest : GetPlayerInventoryOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayerInventoryOperationRequest class.
            /// </summary>
            public AdminGetPlayerInventoryOperationRequest(GamePlayerModels.AdminGetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player statistics operation request.
        /// </summary>
        public class GetPlayerStatisticsOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerStatisticsRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerStatistics;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerStatisticsOperationRequest class.
            /// </summary>
            public GetPlayerStatisticsOperationRequest(GamePlayerModels.GetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get player statistics operation request.
        /// </summary>
        public class ServerGetPlayerStatisticsOperationRequest : GetPlayerStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayerStatisticsOperationRequest class.
            /// </summary>
            public ServerGetPlayerStatisticsOperationRequest(GamePlayerModels.ServerGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get player statistics operation request.
        /// </summary>
        public class AdminGetPlayerStatisticsOperationRequest : GetPlayerStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayerStatisticsOperationRequest class.
            /// </summary>
            public AdminGetPlayerStatisticsOperationRequest(GamePlayerModels.AdminGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get players with display name operation request.
        /// </summary>
        public class GetPlayersWithDisplayNameOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayersWithDisplayNameRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayersWithDisplayName;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayersWithDisplayNameOperationRequest class.
            /// </summary>
            public GetPlayersWithDisplayNameOperationRequest(GamePlayerModels.GetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get players with display name operation request.
        /// </summary>
        public class ServerGetPlayersWithDisplayNameOperationRequest : GetPlayersWithDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayersWithDisplayNameOperationRequest class.
            /// </summary>
            public ServerGetPlayersWithDisplayNameOperationRequest(GamePlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get players with display name operation request.
        /// </summary>
        public class AdminGetPlayersWithDisplayNameOperationRequest : GetPlayersWithDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayersWithDisplayNameOperationRequest class.
            /// </summary>
            public AdminGetPlayersWithDisplayNameOperationRequest(GamePlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get players with segment operation request.
        /// </summary>
        public class GetPlayersWithSegmentOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayersWithSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayersWithSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayersWithSegmentOperationRequest class.
            /// </summary>
            public GetPlayersWithSegmentOperationRequest(GamePlayerModels.GetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get players with segment operation request.
        /// </summary>
        public class ServerGetPlayersWithSegmentOperationRequest : GetPlayersWithSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayersWithSegmentOperationRequest class.
            /// </summary>
            public ServerGetPlayersWithSegmentOperationRequest(GamePlayerModels.ServerGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get players with segment operation request.
        /// </summary>
        public class AdminGetPlayersWithSegmentOperationRequest : GetPlayersWithSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayersWithSegmentOperationRequest class.
            /// </summary>
            public AdminGetPlayersWithSegmentOperationRequest(GamePlayerModels.AdminGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get players with tag operation request.
        /// </summary>
        public class GetPlayersWithTagOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayersWithTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayersWithTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayersWithTagOperationRequest class.
            /// </summary>
            public GetPlayersWithTagOperationRequest(GamePlayerModels.GetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get players with tag operation request.
        /// </summary>
        public class ServerGetPlayersWithTagOperationRequest : GetPlayersWithTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayersWithTagOperationRequest class.
            /// </summary>
            public ServerGetPlayersWithTagOperationRequest(GamePlayerModels.ServerGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get players with tag operation request.
        /// </summary>
        public class AdminGetPlayersWithTagOperationRequest : GetPlayersWithTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayersWithTagOperationRequest class.
            /// </summary>
            public AdminGetPlayersWithTagOperationRequest(GamePlayerModels.AdminGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get segment operation request.
        /// </summary>
        public class GetSegmentOperationRequest : CustomOperationRequest<GamePlayerModels.GetSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetSegmentOperationRequest class.
            /// </summary>
            public GetSegmentOperationRequest(GamePlayerModels.GetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get segment operation request.
        /// </summary>
        public class ServerGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetSegmentOperationRequest class.
            /// </summary>
            public ServerGetSegmentOperationRequest(GamePlayerModels.ServerGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get segment operation request.
        /// </summary>
        public class AdminGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetSegmentOperationRequest class.
            /// </summary>
            public AdminGetSegmentOperationRequest(GamePlayerModels.AdminGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get statistics leaderboard around player operation request.
        /// </summary>
        public class GetStatisticsLeaderboardAroundPlayerOperationRequest : CustomOperationRequest<GamePlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStatisticsLeaderboardAroundPlayer;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStatisticsLeaderboardAroundPlayerOperationRequest class.
            /// </summary>
            public GetStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get statistics leaderboard around player operation request.
        /// </summary>
        public class ServerGetStatisticsLeaderboardAroundPlayerOperationRequest : GetStatisticsLeaderboardAroundPlayerOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetStatisticsLeaderboardAroundPlayerOperationRequest class.
            /// </summary>
            public ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get statistics leaderboard around player operation request.
        /// </summary>
        public class AdminGetStatisticsLeaderboardAroundPlayerOperationRequest : GetStatisticsLeaderboardAroundPlayerOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetStatisticsLeaderboardAroundPlayerOperationRequest class.
            /// </summary>
            public AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get statistics leaderboard operation request.
        /// </summary>
        public class GetStatisticsLeaderboardOperationRequest : CustomOperationRequest<GamePlayerModels.GetStatisticsLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStatisticsLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStatisticsLeaderboardOperationRequest class.
            /// </summary>
            public GetStatisticsLeaderboardOperationRequest(GamePlayerModels.GetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get statistics leaderboard operation request.
        /// </summary>
        public class ServerGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetStatisticsLeaderboardOperationRequest class.
            /// </summary>
            public ServerGetStatisticsLeaderboardOperationRequest(GamePlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get statistics leaderboard operation request.
        /// </summary>
        public class AdminGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetStatisticsLeaderboardOperationRequest class.
            /// </summary>
            public AdminGetStatisticsLeaderboardOperationRequest(GamePlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get tag operation request.
        /// </summary>
        public class GetTagOperationRequest : CustomOperationRequest<GamePlayerModels.GetTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetTagOperationRequest class.
            /// </summary>
            public GetTagOperationRequest(GamePlayerModels.GetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get tag operation request.
        /// </summary>
        public class ServerGetTagOperationRequest : GetTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetTagOperationRequest class.
            /// </summary>
            public ServerGetTagOperationRequest(GamePlayerModels.ServerGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get tag operation request.
        /// </summary>
        public class AdminGetTagOperationRequest : GetTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetTagOperationRequest class.
            /// </summary>
            public AdminGetTagOperationRequest(GamePlayerModels.AdminGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get timestamp create operation request.
        /// </summary>
        public class GetTsCreateOperationRequest : CustomOperationRequest<GamePlayerModels.GetTsCreateRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetTsCreate;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetTsCreateOperationRequest class.
            /// </summary>
            public GetTsCreateOperationRequest(GamePlayerModels.GetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get timestamp create operation request.
        /// </summary>
        public class ServerGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetTsCreateOperationRequest class.
            /// </summary>
            public ServerGetTsCreateOperationRequest(GamePlayerModels.ServerGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get timestamp create operation request.
        /// </summary>
        public class AdminGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetTsCreateOperationRequest class.
            /// </summary>
            public AdminGetTsCreateOperationRequest(GamePlayerModels.AdminGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get timestamp last login operation request.
        /// </summary>
        public class GetTsLastLoginOperationRequest : CustomOperationRequest<GamePlayerModels.GetTsLastLoginRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetTsLastLogin;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetTsLastLoginOperationRequest class.
            /// </summary>
            public GetTsLastLoginOperationRequest(GamePlayerModels.GetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get timestamp last login operation request.
        /// </summary>
        public class ServerGetTsLastLoginOperationRequest : GetTsLastLoginOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetTsLastLoginOperationRequest class.
            /// </summary>
            public ServerGetTsLastLoginOperationRequest(GamePlayerModels.ServerGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get timestamp last login operation request.
        /// </summary>
        public class AdminGetTsLastLoginOperationRequest : GetTsLastLoginOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetTsLastLoginOperationRequest class.
            /// </summary>
            public AdminGetTsLastLoginOperationRequest(GamePlayerModels.AdminGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the create group operation request.
        /// </summary>
        public class CreateGroupOperationRequest : CustomOperationRequest<GamePlayerModels.CreateGroupRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.CreateGroup;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the CreateGroupOperationRequest class.
            /// </summary>
            public CreateGroupOperationRequest(GamePlayerModels.CreateGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped create group operation request.
        /// </summary>
        public class ServerCreateGroupOperationRequest : CreateGroupOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerCreateGroupOperationRequest class.
            /// </summary>
            public ServerCreateGroupOperationRequest(GamePlayerModels.ServerCreateGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped create group operation request.
        /// </summary>
        public class AdminCreateGroupOperationRequest : CreateGroupOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminCreateGroupOperationRequest class.
            /// </summary>
            public AdminCreateGroupOperationRequest(GamePlayerModels.AdminCreateGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the create player character operation request.
        /// </summary>
        public class CreatePlayerCharacterOperationRequest : CustomOperationRequest<GamePlayerModels.CreatePlayerCharacterRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.CreatePlayerCharacter;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the CreatePlayerCharacterOperationRequest class.
            /// </summary>
            public CreatePlayerCharacterOperationRequest(GamePlayerModels.CreatePlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped create player character operation request.
        /// </summary>
        public class ServerCreatePlayerCharacterOperationRequest : CreatePlayerCharacterOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerCreatePlayerCharacterOperationRequest class.
            /// </summary>
            public ServerCreatePlayerCharacterOperationRequest(GamePlayerModels.ServerCreatePlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped create player character operation request.
        /// </summary>
        public class AdminCreatePlayerCharacterOperationRequest : CreatePlayerCharacterOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminCreatePlayerCharacterOperationRequest class.
            /// </summary>
            public AdminCreatePlayerCharacterOperationRequest(GamePlayerModels.AdminCreatePlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the create player item operation request.
        /// </summary>
        public class CreatePlayerItemOperationRequest : CustomOperationRequest<GamePlayerModels.CreatePlayerItemRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.CreatePlayerItem;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the CreatePlayerItemOperationRequest class.
            /// </summary>
            public CreatePlayerItemOperationRequest(GamePlayerModels.CreatePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped create player item operation request.
        /// </summary>
        public class ServerCreatePlayerItemOperationRequest : CreatePlayerItemOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerCreatePlayerItemOperationRequest class.
            /// </summary>
            public ServerCreatePlayerItemOperationRequest(GamePlayerModels.ServerCreatePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped create player item operation request.
        /// </summary>
        public class AdminCreatePlayerItemOperationRequest : CreatePlayerItemOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminCreatePlayerItemOperationRequest class.
            /// </summary>
            public AdminCreatePlayerItemOperationRequest(GamePlayerModels.AdminCreatePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the join group operation request.
        /// </summary>
        public class JoinGroupOperationRequest : CustomOperationRequest<GamePlayerModels.JoinGroupRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.JoinGroup;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the JoinGroupOperationRequest class.
            /// </summary>
            public JoinGroupOperationRequest(GamePlayerModels.JoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped join group operation request.
        /// </summary>
        public class ServerJoinGroupOperationRequest : JoinGroupOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerJoinGroupOperationRequest class.
            /// </summary>
            public ServerJoinGroupOperationRequest(GamePlayerModels.ServerJoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped join group operation request.
        /// </summary>
        public class AdminJoinGroupOperationRequest : JoinGroupOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminJoinGroupOperationRequest class.
            /// </summary>
            public AdminJoinGroupOperationRequest(GamePlayerModels.AdminJoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the leave group operation request.
        /// </summary>
        public class LeaveGroupOperationRequest : CustomOperationRequest<GamePlayerModels.LeaveGroupRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LeaveGroup;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LeaveGroupOperationRequest class.
            /// </summary>
            public LeaveGroupOperationRequest(GamePlayerModels.LeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped leave group operation request.
        /// </summary>
        public class ServerLeaveGroupOperationRequest : LeaveGroupOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerLeaveGroupOperationRequest class.
            /// </summary>
            public ServerLeaveGroupOperationRequest(GamePlayerModels.ServerLeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped leave group operation request.
        /// </summary>
        public class AdminLeaveGroupOperationRequest : LeaveGroupOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminLeaveGroupOperationRequest class.
            /// </summary>
            public AdminLeaveGroupOperationRequest(GamePlayerModels.AdminLeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove player character operation request.
        /// </summary>
        public class RemovePlayerCharacterOperationRequest : CustomOperationRequest<GamePlayerModels.RemovePlayerCharacterRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemovePlayerCharacter;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemovePlayerCharacterOperationRequest class.
            /// </summary>
            public RemovePlayerCharacterOperationRequest(GamePlayerModels.RemovePlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped remove player character operation request.
        /// </summary>
        public class ServerRemovePlayerCharacterOperationRequest : RemovePlayerCharacterOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerRemovePlayerCharacterOperationRequest class.
            /// </summary>
            public ServerRemovePlayerCharacterOperationRequest(GamePlayerModels.ServerRemovePlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped remove player character operation request.
        /// </summary>
        public class AdminRemovePlayerCharacterOperationRequest : RemovePlayerCharacterOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminRemovePlayerCharacterOperationRequest class.
            /// </summary>
            public AdminRemovePlayerCharacterOperationRequest(GamePlayerModels.AdminRemovePlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove player friend operation request.
        /// </summary>
        public class RemovePlayerFriendOperationRequest : CustomOperationRequest<GamePlayerModels.RemovePlayerFriendRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemovePlayerFriend;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemovePlayerFriendOperationRequest class.
            /// </summary>
            public RemovePlayerFriendOperationRequest(GamePlayerModels.RemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped remove player friend operation request.
        /// </summary>
        public class ServerRemovePlayerFriendOperationRequest : RemovePlayerFriendOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerRemovePlayerFriendOperationRequest class.
            /// </summary>
            public ServerRemovePlayerFriendOperationRequest(GamePlayerModels.ServerRemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped remove player friend operation request.
        /// </summary>
        public class AdminRemovePlayerFriendOperationRequest : RemovePlayerFriendOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminRemovePlayerFriendOperationRequest class.
            /// </summary>
            public AdminRemovePlayerFriendOperationRequest(GamePlayerModels.AdminRemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove player item operation request.
        /// </summary>
        public class RemovePlayerItemOperationRequest : CustomOperationRequest<GamePlayerModels.RemovePlayerItemRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemovePlayerItem;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemovePlayerItemOperationRequest class.
            /// </summary>
            public RemovePlayerItemOperationRequest(GamePlayerModels.RemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped remove player item operation request.
        /// </summary>
        public class ServerRemovePlayerItemOperationRequest : RemovePlayerItemOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerRemovePlayerItemOperationRequest class.
            /// </summary>
            public ServerRemovePlayerItemOperationRequest(GamePlayerModels.ServerRemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped remove player item operation request.
        /// </summary>
        public class AdminRemovePlayerItemOperationRequest : RemovePlayerItemOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminRemovePlayerItemOperationRequest class.
            /// </summary>
            public AdminRemovePlayerItemOperationRequest(GamePlayerModels.AdminRemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove segment operation request.
        /// </summary>
        public class RemoveSegmentOperationRequest : CustomOperationRequest<GamePlayerModels.RemoveSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemoveSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemoveSegmentOperationRequest class.
            /// </summary>
            public RemoveSegmentOperationRequest(GamePlayerModels.RemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped remove segment operation request.
        /// </summary>
        public class ServerRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerRemoveSegmentOperationRequest class.
            /// </summary>
            public ServerRemoveSegmentOperationRequest(GamePlayerModels.ServerRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped remove segment operation request.
        /// </summary>
        public class AdminRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminRemoveSegmentOperationRequest class.
            /// </summary>
            public AdminRemoveSegmentOperationRequest(GamePlayerModels.AdminRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove tag operation request.
        /// </summary>
        public class RemoveTagOperationRequest : CustomOperationRequest<GamePlayerModels.RemoveTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemoveTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemoveTagOperationRequest class.
            /// </summary>
            public RemoveTagOperationRequest(GamePlayerModels.RemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped remove tag operation request.
        /// </summary>
        public class ServerRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerRemoveTagOperationRequest class.
            /// </summary>
            public ServerRemoveTagOperationRequest(GamePlayerModels.ServerRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped remove tag operation request.
        /// </summary>
        public class AdminRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminRemoveTagOperationRequest class.
            /// </summary>
            public AdminRemoveTagOperationRequest(GamePlayerModels.AdminRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set avatar operation request.
        /// </summary>
        public class SetAvatarOperationRequest : CustomOperationRequest<GamePlayerModels.SetAvatarRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetAvatar;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetAvatarOperationRequest class.
            /// </summary>
            public SetAvatarOperationRequest(GamePlayerModels.SetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set avatar operation request.
        /// </summary>
        public class ServerSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetAvatarOperationRequest class.
            /// </summary>
            public ServerSetAvatarOperationRequest(GamePlayerModels.ServerSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set avatar operation request.
        /// </summary>
        public class AdminSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetAvatarOperationRequest class.
            /// </summary>
            public AdminSetAvatarOperationRequest(GamePlayerModels.AdminSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set country code operation request.
        /// </summary>
        public class SetCountryCodeOperationRequest : CustomOperationRequest<GamePlayerModels.SetCountryCodeRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetCountryCode;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetCountryCodeOperationRequest class.
            /// </summary>
            public SetCountryCodeOperationRequest(GamePlayerModels.SetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set country code operation request.
        /// </summary>
        public class ServerSetCountryCodeOperationRequest : SetCountryCodeOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetCountryCodeOperationRequest class.
            /// </summary>
            public ServerSetCountryCodeOperationRequest(GamePlayerModels.ServerSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set country code operation request.
        /// </summary>
        public class AdminSetCountryCodeOperationRequest : SetCountryCodeOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetCountryCodeOperationRequest class.
            /// </summary>
            public AdminSetCountryCodeOperationRequest(GamePlayerModels.AdminSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set custom data operation request.
        /// </summary>
        public class SetCustomDataOperationRequest : CustomOperationRequest<GamePlayerModels.SetCustomDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetCustomData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetCustomDataOperationRequest class.
            /// </summary>
            public SetCustomDataOperationRequest(GamePlayerModels.SetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set custom data operation request.
        /// </summary>
        public class ServerSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetCustomDataOperationRequest class.
            /// </summary>
            public ServerSetCustomDataOperationRequest(GamePlayerModels.ServerSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set custom data operation request.
        /// </summary>
        public class AdminSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetCustomDataOperationRequest class.
            /// </summary>
            public AdminSetCustomDataOperationRequest(GamePlayerModels.AdminSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set display name operation request.
        /// </summary>
        public class SetDisplayNameOperationRequest : CustomOperationRequest<GamePlayerModels.SetDisplayNameRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetDisplayName;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetDisplayNameOperationRequest class.
            /// </summary>
            public SetDisplayNameOperationRequest(GamePlayerModels.SetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set display name operation request.
        /// </summary>
        public class ServerSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetDisplayNameOperationRequest class.
            /// </summary>
            public ServerSetDisplayNameOperationRequest(GamePlayerModels.ServerSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set display name operation request.
        /// </summary>
        public class AdminSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetDisplayNameOperationRequest class.
            /// </summary>
            public AdminSetDisplayNameOperationRequest(GamePlayerModels.AdminSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set player ban operation request.
        /// </summary>
        public class SetPlayerBanOperationRequest : CustomOperationRequest<GamePlayerModels.SetPlayerBanRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetPlayerBan;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetPlayerBanOperationRequest class.
            /// </summary>
            public SetPlayerBanOperationRequest(GamePlayerModels.SetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set player ban operation request.
        /// </summary>
        public class ServerSetPlayerBanOperationRequest : SetPlayerBanOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetPlayerBanOperationRequest class.
            /// </summary>
            public ServerSetPlayerBanOperationRequest(GamePlayerModels.ServerSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set player ban operation request.
        /// </summary>
        public class AdminSetPlayerBanOperationRequest : SetPlayerBanOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetPlayerBanOperationRequest class.
            /// </summary>
            public AdminSetPlayerBanOperationRequest(GamePlayerModels.AdminSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the change player currency operation request.
        /// </summary>
        public class ChangePlayerCurrencyOperationRequest : CustomOperationRequest<GamePlayerModels.ChangePlayerCurrencyRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ChangePlayerCurrency;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ChangePlayerCurrencyOperationRequest class.
            /// </summary>
            public ChangePlayerCurrencyOperationRequest(GamePlayerModels.ChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped change player currency operation request.
        /// </summary>
        public class ServerChangePlayerCurrencyOperationRequest : ChangePlayerCurrencyOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerChangePlayerCurrencyOperationRequest class.
            /// </summary>
            public ServerChangePlayerCurrencyOperationRequest(GamePlayerModels.ServerChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped change player currency operation request.
        /// </summary>
        public class AdminChangePlayerCurrencyOperationRequest : ChangePlayerCurrencyOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminChangePlayerCurrencyOperationRequest class.
            /// </summary>
            public AdminChangePlayerCurrencyOperationRequest(GamePlayerModels.AdminChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set player data operation request.
        /// </summary>
        public class SetPlayerDataOperationRequest : CustomOperationRequest<GamePlayerModels.SetPlayerDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetPlayerData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetPlayerDataOperationRequest class.
            /// </summary>
            public SetPlayerDataOperationRequest(GamePlayerModels.SetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set player data operation request.
        /// </summary>
        public class ServerSetPlayerDataOperationRequest : SetPlayerDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetPlayerDataOperationRequest class.
            /// </summary>
            public ServerSetPlayerDataOperationRequest(GamePlayerModels.ServerSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set player data operation request.
        /// </summary>
        public class AdminSetPlayerDataOperationRequest : SetPlayerDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetPlayerDataOperationRequest class.
            /// </summary>
            public AdminSetPlayerDataOperationRequest(GamePlayerModels.AdminSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the change player statistics operation request.
        /// </summary>
        public class ChangePlayerStatisticsOperationRequest : CustomOperationRequest<GamePlayerModels.ChangePlayerStatisticsRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ChangePlayerStatistics;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ChangePlayerStatisticsOperationRequest class.
            /// </summary>
            public ChangePlayerStatisticsOperationRequest(GamePlayerModels.ChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped change player statistics operation request.
        /// </summary>
        public class ServerChangePlayerStatisticsOperationRequest : ChangePlayerStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerChangePlayerStatisticsOperationRequest class.
            /// </summary>
            public ServerChangePlayerStatisticsOperationRequest(GamePlayerModels.ServerChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped change player statistics operation request.
        /// </summary>
        public class AdminChangePlayerStatisticsOperationRequest : ChangePlayerStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminChangePlayerStatisticsOperationRequest class.
            /// </summary>
            public AdminChangePlayerStatisticsOperationRequest(GamePlayerModels.AdminChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set tag operation request.
        /// </summary>
        public class SetTagOperationRequest : CustomOperationRequest<GamePlayerModels.SetTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetTagOperationRequest class.
            /// </summary>
            public SetTagOperationRequest(GamePlayerModels.SetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set tag operation request.
        /// </summary>
        public class ServerSetTagOperationRequest : SetTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetTagOperationRequest class.
            /// </summary>
            public ServerSetTagOperationRequest(GamePlayerModels.ServerSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set tag operation request.
        /// </summary>
        public class AdminSetTagOperationRequest : SetTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetTagOperationRequest class.
            /// </summary>
            public AdminSetTagOperationRequest(GamePlayerModels.AdminSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get currency leaderboard operation request.
        /// </summary>
        public class GetCurrencyLeaderboardOperationRequest : CustomOperationRequest<GamePlayerModels.GetCurrencyLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCurrencyLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCurrencyLeaderboardOperationRequest class.
            /// </summary>
            public GetCurrencyLeaderboardOperationRequest(GamePlayerModels.GetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get currency leaderboard operation request.
        /// </summary>
        public class ServerGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetCurrencyLeaderboardOperationRequest class.
            /// </summary>
            public ServerGetCurrencyLeaderboardOperationRequest(GamePlayerModels.ServerGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get currency leaderboard operation request.
        /// </summary>
        public class AdminGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetCurrencyLeaderboardOperationRequest class.
            /// </summary>
            public AdminGetCurrencyLeaderboardOperationRequest(GamePlayerModels.AdminGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get create leaderboard operation request.
        /// </summary>
        public class GetCreateLeaderboardOperationRequest : CustomOperationRequest<GamePlayerModels.GetCreateLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCreateLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCreateLeaderboardOperationRequest class.
            /// </summary>
            public GetCreateLeaderboardOperationRequest(GamePlayerModels.GetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get create leaderboard operation request.
        /// </summary>
        public class ServerGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetCreateLeaderboardOperationRequest class.
            /// </summary>
            public ServerGetCreateLeaderboardOperationRequest(GamePlayerModels.ServerGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get create leaderboard operation request.
        /// </summary>
        public class AdminGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetCreateLeaderboardOperationRequest class.
            /// </summary>
            public AdminGetCreateLeaderboardOperationRequest(GamePlayerModels.AdminGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get statistics log operation request.
        /// </summary>
        public class GetStatisticsLogOperationRequest : CustomOperationRequest<GamePlayerModels.GetStatisticsLogRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStatisticsLog;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStatisticsLogOperationRequest class.
            /// </summary>
            public GetStatisticsLogOperationRequest(GamePlayerModels.GetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get statistics log operation request.
        /// </summary>
        public class ServerGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetStatisticsLogOperationRequest class.
            /// </summary>
            public ServerGetStatisticsLogOperationRequest(GamePlayerModels.ServerGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get statistics log operation request.
        /// </summary>
        public class AdminGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetStatisticsLogOperationRequest class.
            /// </summary>
            public AdminGetStatisticsLogOperationRequest(GamePlayerModels.AdminGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get currency log operation request.
        /// </summary>
        public class GetCurrencyLogOperationRequest : CustomOperationRequest<GamePlayerModels.GetCurrencyLogRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCurrencyLog;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCurrencyLogOperationRequest class.
            /// </summary>
            public GetCurrencyLogOperationRequest(GamePlayerModels.GetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get currency log operation request.
        /// </summary>
        public class ServerGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetCurrencyLogOperationRequest class.
            /// </summary>
            public ServerGetCurrencyLogOperationRequest(GamePlayerModels.ServerGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get currency log operation request.
        /// </summary>
        public class AdminGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetCurrencyLogOperationRequest class.
            /// </summary>
            public AdminGetCurrencyLogOperationRequest(GamePlayerModels.AdminGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get last login leaderboard operation request.
        /// </summary>
        public class GetLastLoginLeaderboardOperationRequest : CustomOperationRequest<GamePlayerModels.GetLastLoginLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetLastLoginLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.GamePlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetLastLoginLeaderboardOperationRequest class.
            /// </summary>
            public GetLastLoginLeaderboardOperationRequest(GamePlayerModels.GetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get last login leaderboard operation request.
        /// </summary>
        public class ServerGetLastLoginLeaderboardOperationRequest : GetLastLoginLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetLastLoginLeaderboardOperationRequest class.
            /// </summary>
            public ServerGetLastLoginLeaderboardOperationRequest(GamePlayerModels.ServerGetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get last login leaderboard operation request.
        /// </summary>
        public class AdminGetLastLoginLeaderboardOperationRequest : GetLastLoginLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetLastLoginLeaderboardOperationRequest class.
            /// </summary>
            public AdminGetLastLoginLeaderboardOperationRequest(GamePlayerModels.AdminGetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}