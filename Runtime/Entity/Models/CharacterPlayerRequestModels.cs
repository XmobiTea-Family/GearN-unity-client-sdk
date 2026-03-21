namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    /// <summary>
    /// Defines typed request wrappers for character player operations.
    /// </summary>
    public class CharacterPlayerRequestModels
    {
        /// <summary>
        /// Builds the add player friend operation request.
        /// </summary>
        public class AddPlayerFriendOperationRequest : CustomOperationRequest<CharacterPlayerModels.AddPlayerFriendRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.AddPlayerFriend;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the AddPlayerFriendOperationRequest class.
            /// </summary>
            public AddPlayerFriendOperationRequest(CharacterPlayerModels.AddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerAddPlayerFriendOperationRequest(CharacterPlayerModels.ServerAddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminAddPlayerFriendOperationRequest(CharacterPlayerModels.AdminAddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the add segment operation request.
        /// </summary>
        public class AddSegmentOperationRequest : CustomOperationRequest<CharacterPlayerModels.AddSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.AddSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the AddSegmentOperationRequest class.
            /// </summary>
            public AddSegmentOperationRequest(CharacterPlayerModels.AddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerAddSegmentOperationRequest(CharacterPlayerModels.ServerAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminAddSegmentOperationRequest(CharacterPlayerModels.AdminAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get avatar operation request.
        /// </summary>
        public class GetAvatarOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetAvatarRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetAvatar;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetAvatarOperationRequest class.
            /// </summary>
            public GetAvatarOperationRequest(CharacterPlayerModels.GetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetAvatarOperationRequest(CharacterPlayerModels.ServerGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetAvatarOperationRequest(CharacterPlayerModels.AdminGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get catalog ID operation request.
        /// </summary>
        public class GetCatalogIdOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCatalogIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCatalogId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCatalogIdOperationRequest class.
            /// </summary>
            public GetCatalogIdOperationRequest(CharacterPlayerModels.GetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get catalog ID operation request.
        /// </summary>
        public class ServerGetCatalogIdOperationRequest : GetCatalogIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetCatalogIdOperationRequest class.
            /// </summary>
            public ServerGetCatalogIdOperationRequest(CharacterPlayerModels.ServerGetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get catalog ID operation request.
        /// </summary>
        public class AdminGetCatalogIdOperationRequest : GetCatalogIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetCatalogIdOperationRequest class.
            /// </summary>
            public AdminGetCatalogIdOperationRequest(CharacterPlayerModels.AdminGetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get country code operation request.
        /// </summary>
        public class GetCountryCodeOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCountryCodeRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCountryCode;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCountryCodeOperationRequest class.
            /// </summary>
            public GetCountryCodeOperationRequest(CharacterPlayerModels.GetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetCountryCodeOperationRequest(CharacterPlayerModels.ServerGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetCountryCodeOperationRequest(CharacterPlayerModels.AdminGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get custom data operation request.
        /// </summary>
        public class GetCustomDataOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCustomDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCustomData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCustomDataOperationRequest class.
            /// </summary>
            public GetCustomDataOperationRequest(CharacterPlayerModels.GetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetCustomDataOperationRequest(CharacterPlayerModels.ServerGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetCustomDataOperationRequest(CharacterPlayerModels.AdminGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get display name operation request.
        /// </summary>
        public class GetDisplayNameOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetDisplayNameRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetDisplayName;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetDisplayNameOperationRequest class.
            /// </summary>
            public GetDisplayNameOperationRequest(CharacterPlayerModels.GetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetDisplayNameOperationRequest(CharacterPlayerModels.ServerGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetDisplayNameOperationRequest(CharacterPlayerModels.AdminGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get friend statistics leaderboard around player operation request.
        /// </summary>
        public class GetFriendStatisticsLeaderboardAroundPlayerOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetFriendStatisticsLeaderboardAroundPlayer;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetFriendStatisticsLeaderboardAroundPlayerOperationRequest class.
            /// </summary>
            public GetFriendStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get friend statistics leaderboard operation request.
        /// </summary>
        public class GetFriendStatisticsLeaderboardOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetFriendStatisticsLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetFriendStatisticsLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetFriendStatisticsLeaderboardOperationRequest class.
            /// </summary>
            public GetFriendStatisticsLeaderboardOperationRequest(CharacterPlayerModels.GetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetFriendStatisticsLeaderboardOperationRequest(CharacterPlayerModels.ServerGetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetFriendStatisticsLeaderboardOperationRequest(CharacterPlayerModels.AdminGetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get IP address create operation request.
        /// </summary>
        public class GetIpAddressCreateOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetIpAddressCreateRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetIpAddressCreate;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetIpAddressCreateOperationRequest class.
            /// </summary>
            public GetIpAddressCreateOperationRequest(CharacterPlayerModels.GetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetIpAddressCreateOperationRequest(CharacterPlayerModels.ServerGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetIpAddressCreateOperationRequest(CharacterPlayerModels.AdminGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get owner operation request.
        /// </summary>
        public class GetOwnerOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetOwnerRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetOwner;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetOwnerOperationRequest class.
            /// </summary>
            public GetOwnerOperationRequest(CharacterPlayerModels.GetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get owner operation request.
        /// </summary>
        public class ServerGetOwnerOperationRequest : GetOwnerOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetOwnerOperationRequest class.
            /// </summary>
            public ServerGetOwnerOperationRequest(CharacterPlayerModels.ServerGetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get owner operation request.
        /// </summary>
        public class AdminGetOwnerOperationRequest : GetOwnerOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetOwnerOperationRequest class.
            /// </summary>
            public AdminGetOwnerOperationRequest(CharacterPlayerModels.AdminGetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player ban operation request.
        /// </summary>
        public class GetPlayerBanOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerBanRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerBan;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerBanOperationRequest class.
            /// </summary>
            public GetPlayerBanOperationRequest(CharacterPlayerModels.GetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetPlayerBanOperationRequest(CharacterPlayerModels.ServerGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetPlayerBanOperationRequest(CharacterPlayerModels.AdminGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player currency operation request.
        /// </summary>
        public class GetPlayerCurrencyOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerCurrencyRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerCurrency;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerCurrencyOperationRequest class.
            /// </summary>
            public GetPlayerCurrencyOperationRequest(CharacterPlayerModels.GetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetPlayerCurrencyOperationRequest(CharacterPlayerModels.ServerGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetPlayerCurrencyOperationRequest(CharacterPlayerModels.AdminGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player data operation request.
        /// </summary>
        public class GetPlayerDataOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerDataOperationRequest class.
            /// </summary>
            public GetPlayerDataOperationRequest(CharacterPlayerModels.GetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetPlayerDataOperationRequest(CharacterPlayerModels.ServerGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetPlayerDataOperationRequest(CharacterPlayerModels.AdminGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player friend operation request.
        /// </summary>
        public class GetPlayerFriendOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerFriendRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerFriend;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerFriendOperationRequest class.
            /// </summary>
            public GetPlayerFriendOperationRequest(CharacterPlayerModels.GetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetPlayerFriendOperationRequest(CharacterPlayerModels.ServerGetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetPlayerFriendOperationRequest(CharacterPlayerModels.AdminGetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player group operation request.
        /// </summary>
        public class GetPlayerGroupOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerGroupRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerGroup;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerGroupOperationRequest class.
            /// </summary>
            public GetPlayerGroupOperationRequest(CharacterPlayerModels.GetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetPlayerGroupOperationRequest(CharacterPlayerModels.ServerGetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetPlayerGroupOperationRequest(CharacterPlayerModels.AdminGetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player information operation request.
        /// </summary>
        public class GetPlayerInformationOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerInformationRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerInformation;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerInformationOperationRequest class.
            /// </summary>
            public GetPlayerInformationOperationRequest(CharacterPlayerModels.GetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetPlayerInformationOperationRequest(CharacterPlayerModels.ServerGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetPlayerInformationOperationRequest(CharacterPlayerModels.AdminGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player inventory operation request.
        /// </summary>
        public class GetPlayerInventoryOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerInventoryRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerInventory;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerInventoryOperationRequest class.
            /// </summary>
            public GetPlayerInventoryOperationRequest(CharacterPlayerModels.GetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetPlayerInventoryOperationRequest(CharacterPlayerModels.ServerGetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetPlayerInventoryOperationRequest(CharacterPlayerModels.AdminGetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player statistics operation request.
        /// </summary>
        public class GetPlayerStatisticsOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerStatisticsRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerStatistics;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerStatisticsOperationRequest class.
            /// </summary>
            public GetPlayerStatisticsOperationRequest(CharacterPlayerModels.GetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetPlayerStatisticsOperationRequest(CharacterPlayerModels.ServerGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetPlayerStatisticsOperationRequest(CharacterPlayerModels.AdminGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get players with display name operation request.
        /// </summary>
        public class GetPlayersWithDisplayNameOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayersWithDisplayNameRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayersWithDisplayName;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayersWithDisplayNameOperationRequest class.
            /// </summary>
            public GetPlayersWithDisplayNameOperationRequest(CharacterPlayerModels.GetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetPlayersWithDisplayNameOperationRequest(CharacterPlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetPlayersWithDisplayNameOperationRequest(CharacterPlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get players with segment operation request.
        /// </summary>
        public class GetPlayersWithSegmentOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayersWithSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayersWithSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayersWithSegmentOperationRequest class.
            /// </summary>
            public GetPlayersWithSegmentOperationRequest(CharacterPlayerModels.GetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetPlayersWithSegmentOperationRequest(CharacterPlayerModels.ServerGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetPlayersWithSegmentOperationRequest(CharacterPlayerModels.AdminGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get players with tag operation request.
        /// </summary>
        public class GetPlayersWithTagOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayersWithTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayersWithTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayersWithTagOperationRequest class.
            /// </summary>
            public GetPlayersWithTagOperationRequest(CharacterPlayerModels.GetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetPlayersWithTagOperationRequest(CharacterPlayerModels.ServerGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetPlayersWithTagOperationRequest(CharacterPlayerModels.AdminGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get remove status operation request.
        /// </summary>
        public class GetRemoveStatusOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetRemoveStatusRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetRemoveStatus;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetRemoveStatusOperationRequest class.
            /// </summary>
            public GetRemoveStatusOperationRequest(CharacterPlayerModels.GetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get remove status operation request.
        /// </summary>
        public class ServerGetRemoveStatusOperationRequest : GetRemoveStatusOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetRemoveStatusOperationRequest class.
            /// </summary>
            public ServerGetRemoveStatusOperationRequest(CharacterPlayerModels.ServerGetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get remove status operation request.
        /// </summary>
        public class AdminGetRemoveStatusOperationRequest : GetRemoveStatusOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetRemoveStatusOperationRequest class.
            /// </summary>
            public AdminGetRemoveStatusOperationRequest(CharacterPlayerModels.AdminGetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get segment operation request.
        /// </summary>
        public class GetSegmentOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetSegmentOperationRequest class.
            /// </summary>
            public GetSegmentOperationRequest(CharacterPlayerModels.GetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetSegmentOperationRequest(CharacterPlayerModels.ServerGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetSegmentOperationRequest(CharacterPlayerModels.AdminGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get statistics leaderboard around player operation request.
        /// </summary>
        public class GetStatisticsLeaderboardAroundPlayerOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStatisticsLeaderboardAroundPlayer;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStatisticsLeaderboardAroundPlayerOperationRequest class.
            /// </summary>
            public GetStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get statistics leaderboard operation request.
        /// </summary>
        public class GetStatisticsLeaderboardOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetStatisticsLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStatisticsLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStatisticsLeaderboardOperationRequest class.
            /// </summary>
            public GetStatisticsLeaderboardOperationRequest(CharacterPlayerModels.GetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetStatisticsLeaderboardOperationRequest(CharacterPlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetStatisticsLeaderboardOperationRequest(CharacterPlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get tag operation request.
        /// </summary>
        public class GetTagOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetTagOperationRequest class.
            /// </summary>
            public GetTagOperationRequest(CharacterPlayerModels.GetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetTagOperationRequest(CharacterPlayerModels.ServerGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetTagOperationRequest(CharacterPlayerModels.AdminGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get timestamp create operation request.
        /// </summary>
        public class GetTsCreateOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetTsCreateRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetTsCreate;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetTsCreateOperationRequest class.
            /// </summary>
            public GetTsCreateOperationRequest(CharacterPlayerModels.GetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetTsCreateOperationRequest(CharacterPlayerModels.ServerGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetTsCreateOperationRequest(CharacterPlayerModels.AdminGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get timestamp last login operation request.
        /// </summary>
        public class GetTsLastLoginOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetTsLastLoginRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetTsLastLogin;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetTsLastLoginOperationRequest class.
            /// </summary>
            public GetTsLastLoginOperationRequest(CharacterPlayerModels.GetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetTsLastLoginOperationRequest(CharacterPlayerModels.ServerGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetTsLastLoginOperationRequest(CharacterPlayerModels.AdminGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the create group operation request.
        /// </summary>
        public class CreateGroupOperationRequest : CustomOperationRequest<CharacterPlayerModels.CreateGroupRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.CreateGroup;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the CreateGroupOperationRequest class.
            /// </summary>
            public CreateGroupOperationRequest(CharacterPlayerModels.CreateGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerCreateGroupOperationRequest(CharacterPlayerModels.ServerCreateGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminCreateGroupOperationRequest(CharacterPlayerModels.AdminCreateGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the create player item operation request.
        /// </summary>
        public class CreatePlayerItemOperationRequest : CustomOperationRequest<CharacterPlayerModels.CreatePlayerItemRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.CreatePlayerItem;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the CreatePlayerItemOperationRequest class.
            /// </summary>
            public CreatePlayerItemOperationRequest(CharacterPlayerModels.CreatePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerCreatePlayerItemOperationRequest(CharacterPlayerModels.ServerCreatePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminCreatePlayerItemOperationRequest(CharacterPlayerModels.AdminCreatePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the join group operation request.
        /// </summary>
        public class JoinGroupOperationRequest : CustomOperationRequest<CharacterPlayerModels.JoinGroupRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.JoinGroup;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the JoinGroupOperationRequest class.
            /// </summary>
            public JoinGroupOperationRequest(CharacterPlayerModels.JoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerJoinGroupOperationRequest(CharacterPlayerModels.ServerJoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminJoinGroupOperationRequest(CharacterPlayerModels.AdminJoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the leave group operation request.
        /// </summary>
        public class LeaveGroupOperationRequest : CustomOperationRequest<CharacterPlayerModels.LeaveGroupRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LeaveGroup;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LeaveGroupOperationRequest class.
            /// </summary>
            public LeaveGroupOperationRequest(CharacterPlayerModels.LeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerLeaveGroupOperationRequest(CharacterPlayerModels.ServerLeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminLeaveGroupOperationRequest(CharacterPlayerModels.AdminLeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove player friend operation request.
        /// </summary>
        public class RemovePlayerFriendOperationRequest : CustomOperationRequest<CharacterPlayerModels.RemovePlayerFriendRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemovePlayerFriend;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemovePlayerFriendOperationRequest class.
            /// </summary>
            public RemovePlayerFriendOperationRequest(CharacterPlayerModels.RemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerRemovePlayerFriendOperationRequest(CharacterPlayerModels.ServerRemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminRemovePlayerFriendOperationRequest(CharacterPlayerModels.AdminRemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove player item operation request.
        /// </summary>
        public class RemovePlayerItemOperationRequest : CustomOperationRequest<CharacterPlayerModels.RemovePlayerItemRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemovePlayerItem;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemovePlayerItemOperationRequest class.
            /// </summary>
            public RemovePlayerItemOperationRequest(CharacterPlayerModels.RemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerRemovePlayerItemOperationRequest(CharacterPlayerModels.ServerRemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminRemovePlayerItemOperationRequest(CharacterPlayerModels.AdminRemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove segment operation request.
        /// </summary>
        public class RemoveSegmentOperationRequest : CustomOperationRequest<CharacterPlayerModels.RemoveSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemoveSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemoveSegmentOperationRequest class.
            /// </summary>
            public RemoveSegmentOperationRequest(CharacterPlayerModels.RemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerRemoveSegmentOperationRequest(CharacterPlayerModels.ServerRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminRemoveSegmentOperationRequest(CharacterPlayerModels.AdminRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove tag operation request.
        /// </summary>
        public class RemoveTagOperationRequest : CustomOperationRequest<CharacterPlayerModels.RemoveTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemoveTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemoveTagOperationRequest class.
            /// </summary>
            public RemoveTagOperationRequest(CharacterPlayerModels.RemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerRemoveTagOperationRequest(CharacterPlayerModels.ServerRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminRemoveTagOperationRequest(CharacterPlayerModels.AdminRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set avatar operation request.
        /// </summary>
        public class SetAvatarOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetAvatarRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetAvatar;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetAvatarOperationRequest class.
            /// </summary>
            public SetAvatarOperationRequest(CharacterPlayerModels.SetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerSetAvatarOperationRequest(CharacterPlayerModels.ServerSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminSetAvatarOperationRequest(CharacterPlayerModels.AdminSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set country code operation request.
        /// </summary>
        public class SetCountryCodeOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetCountryCodeRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetCountryCode;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetCountryCodeOperationRequest class.
            /// </summary>
            public SetCountryCodeOperationRequest(CharacterPlayerModels.SetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerSetCountryCodeOperationRequest(CharacterPlayerModels.ServerSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminSetCountryCodeOperationRequest(CharacterPlayerModels.AdminSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set custom data operation request.
        /// </summary>
        public class SetCustomDataOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetCustomDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetCustomData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetCustomDataOperationRequest class.
            /// </summary>
            public SetCustomDataOperationRequest(CharacterPlayerModels.SetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerSetCustomDataOperationRequest(CharacterPlayerModels.ServerSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminSetCustomDataOperationRequest(CharacterPlayerModels.AdminSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set display name operation request.
        /// </summary>
        public class SetDisplayNameOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetDisplayNameRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetDisplayName;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetDisplayNameOperationRequest class.
            /// </summary>
            public SetDisplayNameOperationRequest(CharacterPlayerModels.SetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerSetDisplayNameOperationRequest(CharacterPlayerModels.ServerSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminSetDisplayNameOperationRequest(CharacterPlayerModels.AdminSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set owner operation request.
        /// </summary>
        public class SetOwnerOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetOwnerRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetOwner;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetOwnerOperationRequest class.
            /// </summary>
            public SetOwnerOperationRequest(CharacterPlayerModels.SetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set owner operation request.
        /// </summary>
        public class ServerSetOwnerOperationRequest : SetOwnerOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetOwnerOperationRequest class.
            /// </summary>
            public ServerSetOwnerOperationRequest(CharacterPlayerModels.ServerSetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set owner operation request.
        /// </summary>
        public class AdminSetOwnerOperationRequest : SetOwnerOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetOwnerOperationRequest class.
            /// </summary>
            public AdminSetOwnerOperationRequest(CharacterPlayerModels.AdminSetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set player ban operation request.
        /// </summary>
        public class SetPlayerBanOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetPlayerBanRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetPlayerBan;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetPlayerBanOperationRequest class.
            /// </summary>
            public SetPlayerBanOperationRequest(CharacterPlayerModels.SetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerSetPlayerBanOperationRequest(CharacterPlayerModels.ServerSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminSetPlayerBanOperationRequest(CharacterPlayerModels.AdminSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the change player currency operation request.
        /// </summary>
        public class ChangePlayerCurrencyOperationRequest : CustomOperationRequest<CharacterPlayerModels.ChangePlayerCurrencyRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ChangePlayerCurrency;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ChangePlayerCurrencyOperationRequest class.
            /// </summary>
            public ChangePlayerCurrencyOperationRequest(CharacterPlayerModels.ChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerChangePlayerCurrencyOperationRequest(CharacterPlayerModels.ServerChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminChangePlayerCurrencyOperationRequest(CharacterPlayerModels.AdminChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set player data operation request.
        /// </summary>
        public class SetPlayerDataOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetPlayerDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetPlayerData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetPlayerDataOperationRequest class.
            /// </summary>
            public SetPlayerDataOperationRequest(CharacterPlayerModels.SetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerSetPlayerDataOperationRequest(CharacterPlayerModels.ServerSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminSetPlayerDataOperationRequest(CharacterPlayerModels.AdminSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the change player statistics operation request.
        /// </summary>
        public class ChangePlayerStatisticsOperationRequest : CustomOperationRequest<CharacterPlayerModels.ChangePlayerStatisticsRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ChangePlayerStatistics;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ChangePlayerStatisticsOperationRequest class.
            /// </summary>
            public ChangePlayerStatisticsOperationRequest(CharacterPlayerModels.ChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerChangePlayerStatisticsOperationRequest(CharacterPlayerModels.ServerChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminChangePlayerStatisticsOperationRequest(CharacterPlayerModels.AdminChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set remove status operation request.
        /// </summary>
        public class SetRemoveStatusOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetRemoveStatusRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetRemoveStatus;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetRemoveStatusOperationRequest class.
            /// </summary>
            public SetRemoveStatusOperationRequest(CharacterPlayerModels.SetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set remove status operation request.
        /// </summary>
        public class ServerSetRemoveStatusOperationRequest : SetRemoveStatusOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetRemoveStatusOperationRequest class.
            /// </summary>
            public ServerSetRemoveStatusOperationRequest(CharacterPlayerModels.ServerSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set remove status operation request.
        /// </summary>
        public class AdminSetRemoveStatusOperationRequest : SetRemoveStatusOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetRemoveStatusOperationRequest class.
            /// </summary>
            public AdminSetRemoveStatusOperationRequest(CharacterPlayerModels.AdminSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set tag operation request.
        /// </summary>
        public class SetTagOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetTagOperationRequest class.
            /// </summary>
            public SetTagOperationRequest(CharacterPlayerModels.SetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerSetTagOperationRequest(CharacterPlayerModels.ServerSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminSetTagOperationRequest(CharacterPlayerModels.AdminSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get currency leaderboard operation request.
        /// </summary>
        public class GetCurrencyLeaderboardOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCurrencyLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCurrencyLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCurrencyLeaderboardOperationRequest class.
            /// </summary>
            public GetCurrencyLeaderboardOperationRequest(CharacterPlayerModels.GetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetCurrencyLeaderboardOperationRequest(CharacterPlayerModels.ServerGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetCurrencyLeaderboardOperationRequest(CharacterPlayerModels.AdminGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get create leaderboard operation request.
        /// </summary>
        public class GetCreateLeaderboardOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCreateLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCreateLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCreateLeaderboardOperationRequest class.
            /// </summary>
            public GetCreateLeaderboardOperationRequest(CharacterPlayerModels.GetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetCreateLeaderboardOperationRequest(CharacterPlayerModels.ServerGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetCreateLeaderboardOperationRequest(CharacterPlayerModels.AdminGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get last login leaderboard operation request.
        /// </summary>
        public class GetLastLoginLeaderboardOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetLastLoginLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetLastLoginLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetLastLoginLeaderboardOperationRequest class.
            /// </summary>
            public GetLastLoginLeaderboardOperationRequest(CharacterPlayerModels.GetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetLastLoginLeaderboardOperationRequest(CharacterPlayerModels.ServerGetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetLastLoginLeaderboardOperationRequest(CharacterPlayerModels.AdminGetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get statistics log operation request.
        /// </summary>
        public class GetStatisticsLogOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetStatisticsLogRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStatisticsLog;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStatisticsLogOperationRequest class.
            /// </summary>
            public GetStatisticsLogOperationRequest(CharacterPlayerModels.GetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetStatisticsLogOperationRequest(CharacterPlayerModels.ServerGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetStatisticsLogOperationRequest(CharacterPlayerModels.AdminGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get currency log operation request.
        /// </summary>
        public class GetCurrencyLogOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCurrencyLogRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCurrencyLog;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CharacterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCurrencyLogOperationRequest class.
            /// </summary>
            public GetCurrencyLogOperationRequest(CharacterPlayerModels.GetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetCurrencyLogOperationRequest(CharacterPlayerModels.ServerGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetCurrencyLogOperationRequest(CharacterPlayerModels.AdminGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}