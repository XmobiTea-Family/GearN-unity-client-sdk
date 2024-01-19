namespace XmobiTea.GN.Entity.Models
{
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity.Request;

    public class GamePlayerRequestModels
    {
        public class AddPlayerFriendOperationRequest : CustomOperationRequest<GamePlayerModels.AddPlayerFriendRequestData>
        {
            protected override int operationCode => OperationCode.AddPlayerFriend;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public AddPlayerFriendOperationRequest(GamePlayerModels.AddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerAddPlayerFriendOperationRequest : AddPlayerFriendOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerAddPlayerFriendOperationRequest(GamePlayerModels.ServerAddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminAddPlayerFriendOperationRequest : AddPlayerFriendOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminAddPlayerFriendOperationRequest(GamePlayerModels.AdminAddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class AddSegmentOperationRequest : CustomOperationRequest<GamePlayerModels.AddSegmentRequestData>
        {
            protected override int operationCode => OperationCode.AddSegment;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public AddSegmentOperationRequest(GamePlayerModels.AddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerAddSegmentOperationRequest(GamePlayerModels.ServerAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminAddSegmentOperationRequest(GamePlayerModels.AdminAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetAvatarOperationRequest : CustomOperationRequest<GamePlayerModels.GetAvatarRequestData>
        {
            protected override int operationCode => OperationCode.GetAvatar;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetAvatarOperationRequest(GamePlayerModels.GetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetAvatarOperationRequest(GamePlayerModels.ServerGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetAvatarOperationRequest(GamePlayerModels.AdminGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetCountryCodeOperationRequest : CustomOperationRequest<GamePlayerModels.GetCountryCodeRequestData>
        {
            protected override int operationCode => OperationCode.GetCountryCode;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetCountryCodeOperationRequest(GamePlayerModels.GetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCountryCodeOperationRequest : GetCountryCodeOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetCountryCodeOperationRequest(GamePlayerModels.ServerGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCountryCodeOperationRequest : GetCountryCodeOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetCountryCodeOperationRequest(GamePlayerModels.AdminGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetCustomDataOperationRequest : CustomOperationRequest<GamePlayerModels.GetCustomDataRequestData>
        {
            protected override int operationCode => OperationCode.GetCustomData;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetCustomDataOperationRequest(GamePlayerModels.GetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetCustomDataOperationRequest(GamePlayerModels.ServerGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetCustomDataOperationRequest(GamePlayerModels.AdminGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetDisplayNameOperationRequest : CustomOperationRequest<GamePlayerModels.GetDisplayNameRequestData>
        {
            protected override int operationCode => OperationCode.GetDisplayName;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetDisplayNameOperationRequest(GamePlayerModels.GetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetDisplayNameOperationRequest(GamePlayerModels.ServerGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetDisplayNameOperationRequest(GamePlayerModels.AdminGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetFriendStatisticsLeaderboardAroundPlayerOperationRequest : CustomOperationRequest<GamePlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData>
        {
            protected override int operationCode => OperationCode.GetFriendStatisticsLeaderboardAroundPlayer;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetFriendStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest : GetFriendStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest : GetFriendStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetFriendStatisticsLeaderboardOperationRequest : CustomOperationRequest<GamePlayerModels.GetFriendStatisticsLeaderboardRequestData>
        {
            protected override int operationCode => OperationCode.GetFriendStatisticsLeaderboard;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetFriendStatisticsLeaderboardOperationRequest(GamePlayerModels.GetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetFriendStatisticsLeaderboardOperationRequest : GetFriendStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetFriendStatisticsLeaderboardOperationRequest(GamePlayerModels.ServerGetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetFriendStatisticsLeaderboardOperationRequest : GetFriendStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetFriendStatisticsLeaderboardOperationRequest(GamePlayerModels.AdminGetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetIpAddressCreateOperationRequest : CustomOperationRequest<GamePlayerModels.GetIpAddressCreateRequestData>
        {
            protected override int operationCode => OperationCode.GetIpAddressCreate;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetIpAddressCreateOperationRequest(GamePlayerModels.GetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetIpAddressCreateOperationRequest : GetIpAddressCreateOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetIpAddressCreateOperationRequest(GamePlayerModels.ServerGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetIpAddressCreateOperationRequest : GetIpAddressCreateOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetIpAddressCreateOperationRequest(GamePlayerModels.AdminGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetOnlineStatusOperationRequest : CustomOperationRequest<GamePlayerModels.GetOnlineStatusRequestData>
        {
            protected override int operationCode => OperationCode.GetOnlineStatus;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetOnlineStatusOperationRequest(GamePlayerModels.GetOnlineStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetOnlineStatusOperationRequest : GetOnlineStatusOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetOnlineStatusOperationRequest(GamePlayerModels.ServerGetOnlineStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetOnlineStatusOperationRequest : GetOnlineStatusOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetOnlineStatusOperationRequest(GamePlayerModels.AdminGetOnlineStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerBanOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerBanRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayerBan;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayerBanOperationRequest(GamePlayerModels.GetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerBanOperationRequest : GetPlayerBanOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayerBanOperationRequest(GamePlayerModels.ServerGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerBanOperationRequest : GetPlayerBanOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayerBanOperationRequest(GamePlayerModels.AdminGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerCharacterOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerCharacterRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayerCharacter;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayerCharacterOperationRequest(GamePlayerModels.GetPlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerCharacterOperationRequest : GetPlayerCharacterOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayerCharacterOperationRequest(GamePlayerModels.ServerGetPlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerCharacterOperationRequest : GetPlayerCharacterOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayerCharacterOperationRequest(GamePlayerModels.AdminGetPlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerCurrencyOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerCurrencyRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayerCurrency;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayerCurrencyOperationRequest(GamePlayerModels.GetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerCurrencyOperationRequest : GetPlayerCurrencyOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayerCurrencyOperationRequest(GamePlayerModels.ServerGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerCurrencyOperationRequest : GetPlayerCurrencyOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayerCurrencyOperationRequest(GamePlayerModels.AdminGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerDataOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerDataRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayerData;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayerDataOperationRequest(GamePlayerModels.GetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerDataOperationRequest : GetPlayerDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayerDataOperationRequest(GamePlayerModels.ServerGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerDataOperationRequest : GetPlayerDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayerDataOperationRequest(GamePlayerModels.AdminGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerFriendOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerFriendRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayerFriend;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayerFriendOperationRequest(GamePlayerModels.GetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerFriendOperationRequest : GetPlayerFriendOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayerFriendOperationRequest(GamePlayerModels.ServerGetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerFriendOperationRequest : GetPlayerFriendOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayerFriendOperationRequest(GamePlayerModels.AdminGetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerGroupOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerGroupRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayerGroup;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayerGroupOperationRequest(GamePlayerModels.GetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerGroupOperationRequest : GetPlayerGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayerGroupOperationRequest(GamePlayerModels.ServerGetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerGroupOperationRequest : GetPlayerGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayerGroupOperationRequest(GamePlayerModels.AdminGetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerInformationOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerInformationRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayerInformation;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayerInformationOperationRequest(GamePlayerModels.GetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerInformationOperationRequest : GetPlayerInformationOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayerInformationOperationRequest(GamePlayerModels.ServerGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerInformationOperationRequest : GetPlayerInformationOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayerInformationOperationRequest(GamePlayerModels.AdminGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerInventoryOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerInventoryRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayerInventory;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayerInventoryOperationRequest(GamePlayerModels.GetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerInventoryOperationRequest : GetPlayerInventoryOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayerInventoryOperationRequest(GamePlayerModels.ServerGetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerInventoryOperationRequest : GetPlayerInventoryOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayerInventoryOperationRequest(GamePlayerModels.AdminGetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerStatisticsOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayerStatisticsRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayerStatistics;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayerStatisticsOperationRequest(GamePlayerModels.GetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerStatisticsOperationRequest : GetPlayerStatisticsOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayerStatisticsOperationRequest(GamePlayerModels.ServerGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerStatisticsOperationRequest : GetPlayerStatisticsOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayerStatisticsOperationRequest(GamePlayerModels.AdminGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithDisplayNameOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayersWithDisplayNameRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayersWithDisplayName;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayersWithDisplayNameOperationRequest(GamePlayerModels.GetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithDisplayNameOperationRequest : GetPlayersWithDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayersWithDisplayNameOperationRequest(GamePlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithDisplayNameOperationRequest : GetPlayersWithDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayersWithDisplayNameOperationRequest(GamePlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithSegmentOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayersWithSegmentRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayersWithSegment;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayersWithSegmentOperationRequest(GamePlayerModels.GetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithSegmentOperationRequest : GetPlayersWithSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayersWithSegmentOperationRequest(GamePlayerModels.ServerGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithSegmentOperationRequest : GetPlayersWithSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayersWithSegmentOperationRequest(GamePlayerModels.AdminGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithTagOperationRequest : CustomOperationRequest<GamePlayerModels.GetPlayersWithTagRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayersWithTag;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayersWithTagOperationRequest(GamePlayerModels.GetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithTagOperationRequest : GetPlayersWithTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayersWithTagOperationRequest(GamePlayerModels.ServerGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithTagOperationRequest : GetPlayersWithTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayersWithTagOperationRequest(GamePlayerModels.AdminGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetSegmentOperationRequest : CustomOperationRequest<GamePlayerModels.GetSegmentRequestData>
        {
            protected override int operationCode => OperationCode.GetSegment;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetSegmentOperationRequest(GamePlayerModels.GetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetSegmentOperationRequest(GamePlayerModels.ServerGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetSegmentOperationRequest(GamePlayerModels.AdminGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetStatisticsLeaderboardAroundPlayerOperationRequest : CustomOperationRequest<GamePlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData>
        {
            protected override int operationCode => OperationCode.GetStatisticsLeaderboardAroundPlayer;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLeaderboardAroundPlayerOperationRequest : GetStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLeaderboardAroundPlayerOperationRequest : GetStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(GamePlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetStatisticsLeaderboardOperationRequest : CustomOperationRequest<GamePlayerModels.GetStatisticsLeaderboardRequestData>
        {
            protected override int operationCode => OperationCode.GetStatisticsLeaderboard;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetStatisticsLeaderboardOperationRequest(GamePlayerModels.GetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetStatisticsLeaderboardOperationRequest(GamePlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetStatisticsLeaderboardOperationRequest(GamePlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTagOperationRequest : CustomOperationRequest<GamePlayerModels.GetTagRequestData>
        {
            protected override int operationCode => OperationCode.GetTag;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetTagOperationRequest(GamePlayerModels.GetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTagOperationRequest : GetTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetTagOperationRequest(GamePlayerModels.ServerGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTagOperationRequest : GetTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetTagOperationRequest(GamePlayerModels.AdminGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTsCreateOperationRequest : CustomOperationRequest<GamePlayerModels.GetTsCreateRequestData>
        {
            protected override int operationCode => OperationCode.GetTsCreate;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetTsCreateOperationRequest(GamePlayerModels.GetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetTsCreateOperationRequest(GamePlayerModels.ServerGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetTsCreateOperationRequest(GamePlayerModels.AdminGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTsLastLoginOperationRequest : CustomOperationRequest<GamePlayerModels.GetTsLastLoginRequestData>
        {
            protected override int operationCode => OperationCode.GetTsLastLogin;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetTsLastLoginOperationRequest(GamePlayerModels.GetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTsLastLoginOperationRequest : GetTsLastLoginOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetTsLastLoginOperationRequest(GamePlayerModels.ServerGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTsLastLoginOperationRequest : GetTsLastLoginOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetTsLastLoginOperationRequest(GamePlayerModels.AdminGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GrantGroupOperationRequest : CustomOperationRequest<GamePlayerModels.GrantGroupRequestData>
        {
            protected override int operationCode => OperationCode.GrantGroup;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GrantGroupOperationRequest(GamePlayerModels.GrantGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGrantGroupOperationRequest : GrantGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGrantGroupOperationRequest(GamePlayerModels.ServerGrantGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGrantGroupOperationRequest : GrantGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGrantGroupOperationRequest(GamePlayerModels.AdminGrantGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GrantPlayerCharacterOperationRequest : CustomOperationRequest<GamePlayerModels.GrantPlayerCharacterRequestData>
        {
            protected override int operationCode => OperationCode.GrantPlayerCharacter;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GrantPlayerCharacterOperationRequest(GamePlayerModels.GrantPlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGrantPlayerCharacterOperationRequest : GrantPlayerCharacterOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGrantPlayerCharacterOperationRequest(GamePlayerModels.ServerGrantPlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGrantPlayerCharacterOperationRequest : GrantPlayerCharacterOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGrantPlayerCharacterOperationRequest(GamePlayerModels.AdminGrantPlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GrantPlayerItemOperationRequest : CustomOperationRequest<GamePlayerModels.GrantPlayerItemRequestData>
        {
            protected override int operationCode => OperationCode.GrantPlayerItem;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GrantPlayerItemOperationRequest(GamePlayerModels.GrantPlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGrantPlayerItemOperationRequest : GrantPlayerItemOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGrantPlayerItemOperationRequest(GamePlayerModels.ServerGrantPlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGrantPlayerItemOperationRequest : GrantPlayerItemOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGrantPlayerItemOperationRequest(GamePlayerModels.AdminGrantPlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class JoinGroupOperationRequest : CustomOperationRequest<GamePlayerModels.JoinGroupRequestData>
        {
            protected override int operationCode => OperationCode.JoinGroup;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public JoinGroupOperationRequest(GamePlayerModels.JoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerJoinGroupOperationRequest : JoinGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerJoinGroupOperationRequest(GamePlayerModels.ServerJoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminJoinGroupOperationRequest : JoinGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminJoinGroupOperationRequest(GamePlayerModels.AdminJoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LeaveGroupOperationRequest : CustomOperationRequest<GamePlayerModels.LeaveGroupRequestData>
        {
            protected override int operationCode => OperationCode.LeaveGroup;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public LeaveGroupOperationRequest(GamePlayerModels.LeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLeaveGroupOperationRequest : LeaveGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerLeaveGroupOperationRequest(GamePlayerModels.ServerLeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLeaveGroupOperationRequest : LeaveGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminLeaveGroupOperationRequest(GamePlayerModels.AdminLeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemovePlayerCharacterOperationRequest : CustomOperationRequest<GamePlayerModels.RemovePlayerCharacterRequestData>
        {
            protected override int operationCode => OperationCode.RemovePlayerCharacter;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public RemovePlayerCharacterOperationRequest(GamePlayerModels.RemovePlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemovePlayerCharacterOperationRequest : RemovePlayerCharacterOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerRemovePlayerCharacterOperationRequest(GamePlayerModels.ServerRemovePlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemovePlayerCharacterOperationRequest : RemovePlayerCharacterOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminRemovePlayerCharacterOperationRequest(GamePlayerModels.AdminRemovePlayerCharacterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemovePlayerFriendOperationRequest : CustomOperationRequest<GamePlayerModels.RemovePlayerFriendRequestData>
        {
            protected override int operationCode => OperationCode.RemovePlayerFriend;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public RemovePlayerFriendOperationRequest(GamePlayerModels.RemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemovePlayerFriendOperationRequest : RemovePlayerFriendOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerRemovePlayerFriendOperationRequest(GamePlayerModels.ServerRemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemovePlayerFriendOperationRequest : RemovePlayerFriendOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminRemovePlayerFriendOperationRequest(GamePlayerModels.AdminRemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemovePlayerItemOperationRequest : CustomOperationRequest<GamePlayerModels.RemovePlayerItemRequestData>
        {
            protected override int operationCode => OperationCode.RemovePlayerItem;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public RemovePlayerItemOperationRequest(GamePlayerModels.RemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemovePlayerItemOperationRequest : RemovePlayerItemOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerRemovePlayerItemOperationRequest(GamePlayerModels.ServerRemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemovePlayerItemOperationRequest : RemovePlayerItemOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminRemovePlayerItemOperationRequest(GamePlayerModels.AdminRemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveSegmentOperationRequest : CustomOperationRequest<GamePlayerModels.RemoveSegmentRequestData>
        {
            protected override int operationCode => OperationCode.RemoveSegment;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public RemoveSegmentOperationRequest(GamePlayerModels.RemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerRemoveSegmentOperationRequest(GamePlayerModels.ServerRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminRemoveSegmentOperationRequest(GamePlayerModels.AdminRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveTagOperationRequest : CustomOperationRequest<GamePlayerModels.RemoveTagRequestData>
        {
            protected override int operationCode => OperationCode.RemoveTag;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public RemoveTagOperationRequest(GamePlayerModels.RemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerRemoveTagOperationRequest(GamePlayerModels.ServerRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminRemoveTagOperationRequest(GamePlayerModels.AdminRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetAvatarOperationRequest : CustomOperationRequest<GamePlayerModels.SetAvatarRequestData>
        {
            protected override int operationCode => OperationCode.SetAvatar;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetAvatarOperationRequest(GamePlayerModels.SetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetAvatarOperationRequest(GamePlayerModels.ServerSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetAvatarOperationRequest(GamePlayerModels.AdminSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetCountryCodeOperationRequest : CustomOperationRequest<GamePlayerModels.SetCountryCodeRequestData>
        {
            protected override int operationCode => OperationCode.SetCountryCode;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetCountryCodeOperationRequest(GamePlayerModels.SetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetCountryCodeOperationRequest : SetCountryCodeOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetCountryCodeOperationRequest(GamePlayerModels.ServerSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetCountryCodeOperationRequest : SetCountryCodeOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetCountryCodeOperationRequest(GamePlayerModels.AdminSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetCustomDataOperationRequest : CustomOperationRequest<GamePlayerModels.SetCustomDataRequestData>
        {
            protected override int operationCode => OperationCode.SetCustomData;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetCustomDataOperationRequest(GamePlayerModels.SetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetCustomDataOperationRequest(GamePlayerModels.ServerSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetCustomDataOperationRequest(GamePlayerModels.AdminSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetDisplayNameOperationRequest : CustomOperationRequest<GamePlayerModels.SetDisplayNameRequestData>
        {
            protected override int operationCode => OperationCode.SetDisplayName;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetDisplayNameOperationRequest(GamePlayerModels.SetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetDisplayNameOperationRequest(GamePlayerModels.ServerSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetDisplayNameOperationRequest(GamePlayerModels.AdminSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetPlayerBanOperationRequest : CustomOperationRequest<GamePlayerModels.SetPlayerBanRequestData>
        {
            protected override int operationCode => OperationCode.SetPlayerBan;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetPlayerBanOperationRequest(GamePlayerModels.SetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetPlayerBanOperationRequest : SetPlayerBanOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetPlayerBanOperationRequest(GamePlayerModels.ServerSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetPlayerBanOperationRequest : SetPlayerBanOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetPlayerBanOperationRequest(GamePlayerModels.AdminSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetPlayerCurrencyOperationRequest : CustomOperationRequest<GamePlayerModels.SetPlayerCurrencyRequestData>
        {
            protected override int operationCode => OperationCode.SetPlayerCurrency;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetPlayerCurrencyOperationRequest(GamePlayerModels.SetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetPlayerCurrencyOperationRequest : SetPlayerCurrencyOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetPlayerCurrencyOperationRequest(GamePlayerModels.ServerSetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetPlayerCurrencyOperationRequest : SetPlayerCurrencyOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetPlayerCurrencyOperationRequest(GamePlayerModels.AdminSetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetPlayerDataOperationRequest : CustomOperationRequest<GamePlayerModels.SetPlayerDataRequestData>
        {
            protected override int operationCode => OperationCode.SetPlayerData;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetPlayerDataOperationRequest(GamePlayerModels.SetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetPlayerDataOperationRequest : SetPlayerDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetPlayerDataOperationRequest(GamePlayerModels.ServerSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetPlayerDataOperationRequest : SetPlayerDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetPlayerDataOperationRequest(GamePlayerModels.AdminSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetPlayerStatisticsOperationRequest : CustomOperationRequest<GamePlayerModels.SetPlayerStatisticsRequestData>
        {
            protected override int operationCode => OperationCode.SetPlayerStatistics;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetPlayerStatisticsOperationRequest(GamePlayerModels.SetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetPlayerStatisticsOperationRequest : SetPlayerStatisticsOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetPlayerStatisticsOperationRequest(GamePlayerModels.ServerSetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetPlayerStatisticsOperationRequest : SetPlayerStatisticsOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetPlayerStatisticsOperationRequest(GamePlayerModels.AdminSetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetTagOperationRequest : CustomOperationRequest<GamePlayerModels.SetTagRequestData>
        {
            protected override int operationCode => OperationCode.SetTag;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetTagOperationRequest(GamePlayerModels.SetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetTagOperationRequest : SetTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetTagOperationRequest(GamePlayerModels.ServerSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetTagOperationRequest : SetTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetTagOperationRequest(GamePlayerModels.AdminSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCurrencyLeaderboardOperationRequest : CustomOperationRequest<GamePlayerModels.GetCurrencyLeaderboardRequestData>
        {
            protected override int operationCode => OperationCode.GetCurrencyLeaderboard;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetCurrencyLeaderboardOperationRequest(GamePlayerModels.GetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetCurrencyLeaderboardOperationRequest(GamePlayerModels.ServerGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetCurrencyLeaderboardOperationRequest(GamePlayerModels.AdminGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCreateLeaderboardOperationRequest : CustomOperationRequest<GamePlayerModels.GetCreateLeaderboardRequestData>
        {
            protected override int operationCode => OperationCode.GetCreateLeaderboard;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetCreateLeaderboardOperationRequest(GamePlayerModels.GetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetCreateLeaderboardOperationRequest(GamePlayerModels.ServerGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetCreateLeaderboardOperationRequest(GamePlayerModels.AdminGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetStatisticsLogOperationRequest : CustomOperationRequest<GamePlayerModels.GetStatisticsLogRequestData>
        {
            protected override int operationCode => OperationCode.GetStatisticsLog;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetStatisticsLogOperationRequest(GamePlayerModels.GetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetStatisticsLogOperationRequest(GamePlayerModels.ServerGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetStatisticsLogOperationRequest(GamePlayerModels.AdminGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCurrencyLogOperationRequest : CustomOperationRequest<GamePlayerModels.GetCurrencyLogRequestData>
        {
            protected override int operationCode => OperationCode.GetCurrencyLog;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.GamePlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetCurrencyLogOperationRequest(GamePlayerModels.GetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetCurrencyLogOperationRequest(GamePlayerModels.ServerGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetCurrencyLogOperationRequest(GamePlayerModels.AdminGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}
