namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    public class GamePlayerRequestModels
    {
        public class AddPlayerFriendOperationRequest : CustomOperationRequest<GamePlayerModels.AddPlayerFriendRequestData>
        {
            protected override string operationCode => OperationCode.AddPlayerFriend;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public AddPlayerFriendOperationRequest(GamePlayerModels.AddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerAddPlayerFriendOperationRequest : AddPlayerFriendOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerAddPlayerFriendOperationRequest(GamePlayerModels.ServerAddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminAddPlayerFriendOperationRequest : AddPlayerFriendOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminAddPlayerFriendOperationRequest(GamePlayerModels.AdminAddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class AddSegmentOperationRequest : CustomOperationRequest<GamePlayerModels.AddSegmentRequestData>
        {
            protected override string operationCode => OperationCode.AddSegment;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public AddSegmentOperationRequest(GamePlayerModels.AddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerAddSegmentOperationRequest(GamePlayerModels.ServerAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminAddSegmentOperationRequest(GamePlayerModels.AdminAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetAvatarOperationRequest : CustomOperationRequest<GamePlayerModels.GetAvatarRequestData>
        {
            protected override string operationCode => OperationCode.GetAvatar;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetAvatarOperationRequest(GamePlayerModels.GetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetAvatarOperationRequest(GamePlayerModels.ServerGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetAvatarOperationRequest(GamePlayerModels.AdminGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetCountryCodeOperationRequest : CustomOperationRequest<GamePlayerModels.GetCountryCodeRequestData>
        {
            protected override string operationCode => OperationCode.GetCountryCode;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetCountryCodeOperationRequest(GamePlayerModels.GetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCountryCodeOperationRequest : GetCountryCodeOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCountryCodeOperationRequest(GamePlayerModels.ServerGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCountryCodeOperationRequest : GetCountryCodeOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCountryCodeOperationRequest(GamePlayerModels.AdminGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetCustomDataOperationRequest : CustomOperationRequest<GamePlayerModels.GetCustomDataRequestData>
        {
            protected override string operationCode => OperationCode.GetCustomData;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetCustomDataOperationRequest(GamePlayerModels.GetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCustomDataOperationRequest(GamePlayerModels.ServerGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCustomDataOperationRequest(GamePlayerModels.AdminGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetDisplayNameOperationRequest : CustomOperationRequest<GamePlayerModels.GetDisplayNameRequestData>
        {
            protected override string operationCode => OperationCode.GetDisplayName;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetDisplayNameOperationRequest(GamePlayerModels.GetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetDisplayNameOperationRequest(GamePlayerModels.ServerGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetDisplayNameOperationRequest(GamePlayerModels.AdminGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetFriendStatisticsLeaderboardAroundPlayerOperationRequest : CustomOperationRequest<GamePlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData>
        {
            protected override string operationCode => OperationCode.GetFriendStatisticsLeaderboardAroundPlayer;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetFriendStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest : GetFriendStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest : GetFriendStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetFriendStatisticsLeaderboardOperationRequest : CustomOperationRequest<GamePlayerModels.GetFriendStatisticsLeaderboardRequestData>
        {
            protected override string operationCode => OperationCode.GetFriendStatisticsLeaderboard;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetFriendStatisticsLeaderboardOperationRequest(GamePlayerModels.GetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetFriendStatisticsLeaderboardOperationRequest : GetFriendStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetFriendStatisticsLeaderboardOperationRequest(GamePlayerModels.ServerGetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetFriendStatisticsLeaderboardOperationRequest : GetFriendStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetFriendStatisticsLeaderboardOperationRequest(GamePlayerModels.AdminGetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetIpAddressCreateOperationRequest : CustomOperationRequest<GamePlayerModels.GetIpAddressCreateRequestData>
        {
            protected override string operationCode => OperationCode.GetIpAddressCreate;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetIpAddressCreateOperationRequest(GamePlayerModels.GetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetIpAddressCreateOperationRequest : GetIpAddressCreateOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetIpAddressCreateOperationRequest(GamePlayerModels.ServerGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetIpAddressCreateOperationRequest : GetIpAddressCreateOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetIpAddressCreateOperationRequest(GamePlayerModels.AdminGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetOnlineStatusOperationRequest : CustomOperationRequest<GamePlayerModels.GetOnlineStatusRequestData>
        {
            protected override string operationCode => OperationCode.GetOnlineStatus;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetOnlineStatusOperationRequest(GamePlayerModels.GetOnlineStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetOnlineStatusOperationRequest : GetOnlineStatusOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetOnlineStatusOperationRequest(GamePlayerModels.ServerGetOnlineStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetOnlineStatusOperationRequest : GetOnlineStatusOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetOnlineStatusOperationRequest(GamePlayerModels.AdminGetOnlineStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerBanOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerBanRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerBan;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerBanOperationRequest(GamePlayerModels.GetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerBanOperationRequest : GetPlayerBanOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerBanOperationRequest(GamePlayerModels.ServerGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerBanOperationRequest : GetPlayerBanOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerBanOperationRequest(GamePlayerModels.AdminGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerCharacterOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerCharacterRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerCharacter;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerCharacterOperationRequest(GamePlayerModels.GetPlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerCharacterOperationRequest : GetPlayerCharacterOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerCharacterOperationRequest(GamePlayerModels.ServerGetPlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerCharacterOperationRequest : GetPlayerCharacterOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerCharacterOperationRequest(GamePlayerModels.AdminGetPlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerCurrencyOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerCurrencyRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerCurrency;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerCurrencyOperationRequest(GamePlayerModels.GetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerCurrencyOperationRequest : GetPlayerCurrencyOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerCurrencyOperationRequest(GamePlayerModels.ServerGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerCurrencyOperationRequest : GetPlayerCurrencyOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerCurrencyOperationRequest(GamePlayerModels.AdminGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerDataOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerDataRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerData;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerDataOperationRequest(GamePlayerModels.GetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerDataOperationRequest : GetPlayerDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerDataOperationRequest(GamePlayerModels.ServerGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerDataOperationRequest : GetPlayerDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerDataOperationRequest(GamePlayerModels.AdminGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerFriendOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerFriendRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerFriend;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerFriendOperationRequest(GamePlayerModels.GetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerFriendOperationRequest : GetPlayerFriendOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerFriendOperationRequest(GamePlayerModels.ServerGetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerFriendOperationRequest : GetPlayerFriendOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerFriendOperationRequest(GamePlayerModels.AdminGetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerGroupOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerGroupRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerGroup;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerGroupOperationRequest(GamePlayerModels.GetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerGroupOperationRequest : GetPlayerGroupOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerGroupOperationRequest(GamePlayerModels.ServerGetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerGroupOperationRequest : GetPlayerGroupOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerGroupOperationRequest(GamePlayerModels.AdminGetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerInformationOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerInformationRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerInformation;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerInformationOperationRequest(GamePlayerModels.GetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerInformationOperationRequest : GetPlayerInformationOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerInformationOperationRequest(GamePlayerModels.ServerGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerInformationOperationRequest : GetPlayerInformationOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerInformationOperationRequest(GamePlayerModels.AdminGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerInventoryOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerInventoryRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerInventory;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerInventoryOperationRequest(GamePlayerModels.GetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerInventoryOperationRequest : GetPlayerInventoryOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerInventoryOperationRequest(GamePlayerModels.ServerGetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerInventoryOperationRequest : GetPlayerInventoryOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerInventoryOperationRequest(GamePlayerModels.AdminGetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerStatisticsOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerStatisticsRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerStatistics;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerStatisticsOperationRequest(GamePlayerModels.GetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerStatisticsOperationRequest : GetPlayerStatisticsOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerStatisticsOperationRequest(GamePlayerModels.ServerGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerStatisticsOperationRequest : GetPlayerStatisticsOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerStatisticsOperationRequest(GamePlayerModels.AdminGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithDisplayNameOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayersWithDisplayNameRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayersWithDisplayName;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayersWithDisplayNameOperationRequest(GamePlayerModels.GetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithDisplayNameOperationRequest : GetPlayersWithDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayersWithDisplayNameOperationRequest(GamePlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithDisplayNameOperationRequest : GetPlayersWithDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayersWithDisplayNameOperationRequest(GamePlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithSegmentOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayersWithSegmentRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayersWithSegment;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayersWithSegmentOperationRequest(GamePlayerModels.GetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithSegmentOperationRequest : GetPlayersWithSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayersWithSegmentOperationRequest(GamePlayerModels.ServerGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithSegmentOperationRequest : GetPlayersWithSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayersWithSegmentOperationRequest(GamePlayerModels.AdminGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithTagOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayersWithTagRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayersWithTag;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayersWithTagOperationRequest(GamePlayerModels.GetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithTagOperationRequest : GetPlayersWithTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayersWithTagOperationRequest(GamePlayerModels.ServerGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithTagOperationRequest : GetPlayersWithTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayersWithTagOperationRequest(GamePlayerModels.AdminGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetSegmentOperationRequest : CustomOperationRequest<GamePlayerModels.GetSegmentRequestData>
        {
            protected override string operationCode => OperationCode.GetSegment;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetSegmentOperationRequest(GamePlayerModels.GetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetSegmentOperationRequest(GamePlayerModels.ServerGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetSegmentOperationRequest(GamePlayerModels.AdminGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetStatisticsLeaderboardAroundPlayerOperationRequest : CustomOperationRequest<GamePlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData>
        {
            protected override string operationCode => OperationCode.GetStatisticsLeaderboardAroundPlayer;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLeaderboardAroundPlayerOperationRequest : GetStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLeaderboardAroundPlayerOperationRequest : GetStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetStatisticsLeaderboardOperationRequest : CustomOperationRequest<GamePlayerModels.GetStatisticsLeaderboardRequestData>
        {
            protected override string operationCode => OperationCode.GetStatisticsLeaderboard;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetStatisticsLeaderboardOperationRequest(GamePlayerModels.GetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetStatisticsLeaderboardOperationRequest(GamePlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetStatisticsLeaderboardOperationRequest(GamePlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTagOperationRequest : CustomOperationRequest<GamePlayerModels.GetTagRequestData>
        {
            protected override string operationCode => OperationCode.GetTag;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetTagOperationRequest(GamePlayerModels.GetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTagOperationRequest : GetTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetTagOperationRequest(GamePlayerModels.ServerGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTagOperationRequest : GetTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetTagOperationRequest(GamePlayerModels.AdminGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTsCreateOperationRequest : CustomOperationRequest<GamePlayerModels.GetTsCreateRequestData>
        {
            protected override string operationCode => OperationCode.GetTsCreate;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetTsCreateOperationRequest(GamePlayerModels.GetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetTsCreateOperationRequest(GamePlayerModels.ServerGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetTsCreateOperationRequest(GamePlayerModels.AdminGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTsLastLoginOperationRequest : CustomOperationRequest<GamePlayerModels.GetTsLastLoginRequestData>
        {
            protected override string operationCode => OperationCode.GetTsLastLogin;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetTsLastLoginOperationRequest(GamePlayerModels.GetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTsLastLoginOperationRequest : GetTsLastLoginOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetTsLastLoginOperationRequest(GamePlayerModels.ServerGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTsLastLoginOperationRequest : GetTsLastLoginOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetTsLastLoginOperationRequest(GamePlayerModels.AdminGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class CreateGroupOperationRequest : CustomOperationRequest<GamePlayerModels.CreateGroupRequestData>
        {
            protected override string operationCode => OperationCode.CreateGroup;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public CreateGroupOperationRequest(GamePlayerModels.CreateGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerCreateGroupOperationRequest : CreateGroupOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerCreateGroupOperationRequest(GamePlayerModels.ServerCreateGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminCreateGroupOperationRequest : CreateGroupOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminCreateGroupOperationRequest(GamePlayerModels.AdminCreateGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class CreatePlayerCharacterOperationRequest : CustomOperationRequest<GamePlayerModels.CreatePlayerCharacterRequestData>
        {
            protected override string operationCode => OperationCode.CreatePlayerCharacter;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public CreatePlayerCharacterOperationRequest(GamePlayerModels.CreatePlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerCreatePlayerCharacterOperationRequest : CreatePlayerCharacterOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerCreatePlayerCharacterOperationRequest(GamePlayerModels.ServerCreatePlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminCreatePlayerCharacterOperationRequest : CreatePlayerCharacterOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminCreatePlayerCharacterOperationRequest(GamePlayerModels.AdminCreatePlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class CreatePlayerItemOperationRequest : CustomOperationRequest<GamePlayerModels.CreatePlayerItemRequestData>
        {
            protected override string operationCode => OperationCode.CreatePlayerItem;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public CreatePlayerItemOperationRequest(GamePlayerModels.CreatePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerCreatePlayerItemOperationRequest : CreatePlayerItemOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerCreatePlayerItemOperationRequest(GamePlayerModels.ServerCreatePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminCreatePlayerItemOperationRequest : CreatePlayerItemOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminCreatePlayerItemOperationRequest(GamePlayerModels.AdminCreatePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class JoinGroupOperationRequest : CustomOperationRequest<GamePlayerModels.JoinGroupRequestData>
        {
            protected override string operationCode => OperationCode.JoinGroup;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public JoinGroupOperationRequest(GamePlayerModels.JoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerJoinGroupOperationRequest : JoinGroupOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerJoinGroupOperationRequest(GamePlayerModels.ServerJoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminJoinGroupOperationRequest : JoinGroupOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminJoinGroupOperationRequest(GamePlayerModels.AdminJoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LeaveGroupOperationRequest : CustomOperationRequest<GamePlayerModels.LeaveGroupRequestData>
        {
            protected override string operationCode => OperationCode.LeaveGroup;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public LeaveGroupOperationRequest(GamePlayerModels.LeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLeaveGroupOperationRequest : LeaveGroupOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLeaveGroupOperationRequest(GamePlayerModels.ServerLeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLeaveGroupOperationRequest : LeaveGroupOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLeaveGroupOperationRequest(GamePlayerModels.AdminLeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemovePlayerCharacterOperationRequest : CustomOperationRequest<GamePlayerModels.RemovePlayerCharacterRequestData>
        {
            protected override string operationCode => OperationCode.RemovePlayerCharacter;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public RemovePlayerCharacterOperationRequest(GamePlayerModels.RemovePlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemovePlayerCharacterOperationRequest : RemovePlayerCharacterOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerRemovePlayerCharacterOperationRequest(GamePlayerModels.ServerRemovePlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemovePlayerCharacterOperationRequest : RemovePlayerCharacterOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminRemovePlayerCharacterOperationRequest(GamePlayerModels.AdminRemovePlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemovePlayerFriendOperationRequest : CustomOperationRequest<GamePlayerModels.RemovePlayerFriendRequestData>
        {
            protected override string operationCode => OperationCode.RemovePlayerFriend;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public RemovePlayerFriendOperationRequest(GamePlayerModels.RemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemovePlayerFriendOperationRequest : RemovePlayerFriendOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerRemovePlayerFriendOperationRequest(GamePlayerModels.ServerRemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemovePlayerFriendOperationRequest : RemovePlayerFriendOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminRemovePlayerFriendOperationRequest(GamePlayerModels.AdminRemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemovePlayerItemOperationRequest : CustomOperationRequest<GamePlayerModels.RemovePlayerItemRequestData>
        {
            protected override string operationCode => OperationCode.RemovePlayerItem;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public RemovePlayerItemOperationRequest(GamePlayerModels.RemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemovePlayerItemOperationRequest : RemovePlayerItemOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerRemovePlayerItemOperationRequest(GamePlayerModels.ServerRemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemovePlayerItemOperationRequest : RemovePlayerItemOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminRemovePlayerItemOperationRequest(GamePlayerModels.AdminRemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveSegmentOperationRequest : CustomOperationRequest<GamePlayerModels.RemoveSegmentRequestData>
        {
            protected override string operationCode => OperationCode.RemoveSegment;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public RemoveSegmentOperationRequest(GamePlayerModels.RemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerRemoveSegmentOperationRequest(GamePlayerModels.ServerRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminRemoveSegmentOperationRequest(GamePlayerModels.AdminRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveTagOperationRequest : CustomOperationRequest<GamePlayerModels.RemoveTagRequestData>
        {
            protected override string operationCode => OperationCode.RemoveTag;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public RemoveTagOperationRequest(GamePlayerModels.RemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerRemoveTagOperationRequest(GamePlayerModels.ServerRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminRemoveTagOperationRequest(GamePlayerModels.AdminRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetAvatarOperationRequest : CustomOperationRequest<GamePlayerModels.SetAvatarRequestData>
        {
            protected override string operationCode => OperationCode.SetAvatar;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetAvatarOperationRequest(GamePlayerModels.SetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetAvatarOperationRequest(GamePlayerModels.ServerSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetAvatarOperationRequest(GamePlayerModels.AdminSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetCountryCodeOperationRequest : CustomOperationRequest<GamePlayerModels.SetCountryCodeRequestData>
        {
            protected override string operationCode => OperationCode.SetCountryCode;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetCountryCodeOperationRequest(GamePlayerModels.SetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetCountryCodeOperationRequest : SetCountryCodeOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetCountryCodeOperationRequest(GamePlayerModels.ServerSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetCountryCodeOperationRequest : SetCountryCodeOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetCountryCodeOperationRequest(GamePlayerModels.AdminSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetCustomDataOperationRequest : CustomOperationRequest<GamePlayerModels.SetCustomDataRequestData>
        {
            protected override string operationCode => OperationCode.SetCustomData;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetCustomDataOperationRequest(GamePlayerModels.SetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetCustomDataOperationRequest(GamePlayerModels.ServerSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetCustomDataOperationRequest(GamePlayerModels.AdminSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetDisplayNameOperationRequest : CustomOperationRequest<GamePlayerModels.SetDisplayNameRequestData>
        {
            protected override string operationCode => OperationCode.SetDisplayName;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetDisplayNameOperationRequest(GamePlayerModels.SetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetDisplayNameOperationRequest(GamePlayerModels.ServerSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetDisplayNameOperationRequest(GamePlayerModels.AdminSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetPlayerBanOperationRequest : CustomOperationRequest<GamePlayerModels.SetPlayerBanRequestData>
        {
            protected override string operationCode => OperationCode.SetPlayerBan;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetPlayerBanOperationRequest(GamePlayerModels.SetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetPlayerBanOperationRequest : SetPlayerBanOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetPlayerBanOperationRequest(GamePlayerModels.ServerSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetPlayerBanOperationRequest : SetPlayerBanOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetPlayerBanOperationRequest(GamePlayerModels.AdminSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class ChangePlayerCurrencyOperationRequest : CustomOperationRequest<GamePlayerModels.ChangePlayerCurrencyRequestData>
        {
            protected override string operationCode => OperationCode.ChangePlayerCurrency;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public ChangePlayerCurrencyOperationRequest(GamePlayerModels.ChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerChangePlayerCurrencyOperationRequest : ChangePlayerCurrencyOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerChangePlayerCurrencyOperationRequest(GamePlayerModels.ServerChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminChangePlayerCurrencyOperationRequest : ChangePlayerCurrencyOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminChangePlayerCurrencyOperationRequest(GamePlayerModels.AdminChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetPlayerDataOperationRequest : CustomOperationRequest<GamePlayerModels.SetPlayerDataRequestData>
        {
            protected override string operationCode => OperationCode.SetPlayerData;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetPlayerDataOperationRequest(GamePlayerModels.SetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetPlayerDataOperationRequest : SetPlayerDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetPlayerDataOperationRequest(GamePlayerModels.ServerSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetPlayerDataOperationRequest : SetPlayerDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetPlayerDataOperationRequest(GamePlayerModels.AdminSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class ChangePlayerStatisticsOperationRequest : CustomOperationRequest<GamePlayerModels.ChangePlayerStatisticsRequestData>
        {
            protected override string operationCode => OperationCode.ChangePlayerStatistics;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public ChangePlayerStatisticsOperationRequest(GamePlayerModels.ChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerChangePlayerStatisticsOperationRequest : ChangePlayerStatisticsOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerChangePlayerStatisticsOperationRequest(GamePlayerModels.ServerChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminChangePlayerStatisticsOperationRequest : ChangePlayerStatisticsOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminChangePlayerStatisticsOperationRequest(GamePlayerModels.AdminChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetTagOperationRequest : CustomOperationRequest<GamePlayerModels.SetTagRequestData>
        {
            protected override string operationCode => OperationCode.SetTag;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetTagOperationRequest(GamePlayerModels.SetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetTagOperationRequest : SetTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetTagOperationRequest(GamePlayerModels.ServerSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetTagOperationRequest : SetTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetTagOperationRequest(GamePlayerModels.AdminSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCurrencyLeaderboardOperationRequest : CustomOperationRequest<GamePlayerModels.GetCurrencyLeaderboardRequestData>
        {
            protected override string operationCode => OperationCode.GetCurrencyLeaderboard;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetCurrencyLeaderboardOperationRequest(GamePlayerModels.GetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCurrencyLeaderboardOperationRequest(GamePlayerModels.ServerGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCurrencyLeaderboardOperationRequest(GamePlayerModels.AdminGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCreateLeaderboardOperationRequest : CustomOperationRequest<GamePlayerModels.GetCreateLeaderboardRequestData>
        {
            protected override string operationCode => OperationCode.GetCreateLeaderboard;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetCreateLeaderboardOperationRequest(GamePlayerModels.GetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCreateLeaderboardOperationRequest(GamePlayerModels.ServerGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCreateLeaderboardOperationRequest(GamePlayerModels.AdminGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetStatisticsLogOperationRequest : CustomOperationRequest<GamePlayerModels.GetStatisticsLogRequestData>
        {
            protected override string operationCode => OperationCode.GetStatisticsLog;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetStatisticsLogOperationRequest(GamePlayerModels.GetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetStatisticsLogOperationRequest(GamePlayerModels.ServerGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetStatisticsLogOperationRequest(GamePlayerModels.AdminGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCurrencyLogOperationRequest : CustomOperationRequest<GamePlayerModels.GetCurrencyLogRequestData>
        {
            protected override string operationCode => OperationCode.GetCurrencyLog;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetCurrencyLogOperationRequest(GamePlayerModels.GetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCurrencyLogOperationRequest(GamePlayerModels.ServerGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCurrencyLogOperationRequest(GamePlayerModels.AdminGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}
