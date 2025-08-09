namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    public class CharacterPlayerRequestModels
    {
        public class AddPlayerFriendOperationRequest : CustomOperationRequest<CharacterPlayerModels.AddPlayerFriendRequestData>
        {
            protected override string operationCode => OperationCode.AddPlayerFriend;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public AddPlayerFriendOperationRequest(CharacterPlayerModels.AddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerAddPlayerFriendOperationRequest : AddPlayerFriendOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerAddPlayerFriendOperationRequest(CharacterPlayerModels.ServerAddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminAddPlayerFriendOperationRequest : AddPlayerFriendOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminAddPlayerFriendOperationRequest(CharacterPlayerModels.AdminAddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class AddSegmentOperationRequest : CustomOperationRequest<CharacterPlayerModels.AddSegmentRequestData>
        {
            protected override string operationCode => OperationCode.AddSegment;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public AddSegmentOperationRequest(CharacterPlayerModels.AddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerAddSegmentOperationRequest(CharacterPlayerModels.ServerAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminAddSegmentOperationRequest(CharacterPlayerModels.AdminAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetAvatarOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetAvatarRequestData>
        {
            protected override string operationCode => OperationCode.GetAvatar;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetAvatarOperationRequest(CharacterPlayerModels.GetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetAvatarOperationRequest(CharacterPlayerModels.ServerGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetAvatarOperationRequest(CharacterPlayerModels.AdminGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetCatalogIdOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCatalogIdRequestData>
        {
            protected override string operationCode => OperationCode.GetCatalogId;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetCatalogIdOperationRequest(CharacterPlayerModels.GetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCatalogIdOperationRequest : GetCatalogIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCatalogIdOperationRequest(CharacterPlayerModels.ServerGetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCatalogIdOperationRequest : GetCatalogIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCatalogIdOperationRequest(CharacterPlayerModels.AdminGetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetCountryCodeOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCountryCodeRequestData>
        {
            protected override string operationCode => OperationCode.GetCountryCode;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetCountryCodeOperationRequest(CharacterPlayerModels.GetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCountryCodeOperationRequest : GetCountryCodeOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCountryCodeOperationRequest(CharacterPlayerModels.ServerGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCountryCodeOperationRequest : GetCountryCodeOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCountryCodeOperationRequest(CharacterPlayerModels.AdminGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetCustomDataOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCustomDataRequestData>
        {
            protected override string operationCode => OperationCode.GetCustomData;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetCustomDataOperationRequest(CharacterPlayerModels.GetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCustomDataOperationRequest(CharacterPlayerModels.ServerGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCustomDataOperationRequest(CharacterPlayerModels.AdminGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetDisplayNameOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetDisplayNameRequestData>
        {
            protected override string operationCode => OperationCode.GetDisplayName;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetDisplayNameOperationRequest(CharacterPlayerModels.GetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetDisplayNameOperationRequest(CharacterPlayerModels.ServerGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetDisplayNameOperationRequest(CharacterPlayerModels.AdminGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetFriendStatisticsLeaderboardAroundPlayerOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData>
        {
            protected override string operationCode => OperationCode.GetFriendStatisticsLeaderboardAroundPlayer;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetFriendStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest : GetFriendStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest : GetFriendStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetFriendStatisticsLeaderboardOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetFriendStatisticsLeaderboardRequestData>
        {
            protected override string operationCode => OperationCode.GetFriendStatisticsLeaderboard;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetFriendStatisticsLeaderboardOperationRequest(CharacterPlayerModels.GetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetFriendStatisticsLeaderboardOperationRequest : GetFriendStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetFriendStatisticsLeaderboardOperationRequest(CharacterPlayerModels.ServerGetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetFriendStatisticsLeaderboardOperationRequest : GetFriendStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetFriendStatisticsLeaderboardOperationRequest(CharacterPlayerModels.AdminGetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetIpAddressCreateOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetIpAddressCreateRequestData>
        {
            protected override string operationCode => OperationCode.GetIpAddressCreate;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetIpAddressCreateOperationRequest(CharacterPlayerModels.GetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetIpAddressCreateOperationRequest : GetIpAddressCreateOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetIpAddressCreateOperationRequest(CharacterPlayerModels.ServerGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetIpAddressCreateOperationRequest : GetIpAddressCreateOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetIpAddressCreateOperationRequest(CharacterPlayerModels.AdminGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetOwnerOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetOwnerRequestData>
        {
            protected override string operationCode => OperationCode.GetOwner;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetOwnerOperationRequest(CharacterPlayerModels.GetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetOwnerOperationRequest : GetOwnerOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetOwnerOperationRequest(CharacterPlayerModels.ServerGetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetOwnerOperationRequest : GetOwnerOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetOwnerOperationRequest(CharacterPlayerModels.AdminGetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerBanOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerBanRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerBan;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerBanOperationRequest(CharacterPlayerModels.GetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerBanOperationRequest : GetPlayerBanOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerBanOperationRequest(CharacterPlayerModels.ServerGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerBanOperationRequest : GetPlayerBanOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerBanOperationRequest(CharacterPlayerModels.AdminGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerCurrencyOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerCurrencyRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerCurrency;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerCurrencyOperationRequest(CharacterPlayerModels.GetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerCurrencyOperationRequest : GetPlayerCurrencyOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerCurrencyOperationRequest(CharacterPlayerModels.ServerGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerCurrencyOperationRequest : GetPlayerCurrencyOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerCurrencyOperationRequest(CharacterPlayerModels.AdminGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerDataOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerDataRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerData;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerDataOperationRequest(CharacterPlayerModels.GetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerDataOperationRequest : GetPlayerDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerDataOperationRequest(CharacterPlayerModels.ServerGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerDataOperationRequest : GetPlayerDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerDataOperationRequest(CharacterPlayerModels.AdminGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerFriendOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerFriendRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerFriend;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerFriendOperationRequest(CharacterPlayerModels.GetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerFriendOperationRequest : GetPlayerFriendOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerFriendOperationRequest(CharacterPlayerModels.ServerGetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerFriendOperationRequest : GetPlayerFriendOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerFriendOperationRequest(CharacterPlayerModels.AdminGetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerGroupOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerGroupRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerGroup;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerGroupOperationRequest(CharacterPlayerModels.GetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerGroupOperationRequest : GetPlayerGroupOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerGroupOperationRequest(CharacterPlayerModels.ServerGetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerGroupOperationRequest : GetPlayerGroupOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerGroupOperationRequest(CharacterPlayerModels.AdminGetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerInformationOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerInformationRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerInformation;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerInformationOperationRequest(CharacterPlayerModels.GetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerInformationOperationRequest : GetPlayerInformationOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerInformationOperationRequest(CharacterPlayerModels.ServerGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerInformationOperationRequest : GetPlayerInformationOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerInformationOperationRequest(CharacterPlayerModels.AdminGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerInventoryOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerInventoryRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerInventory;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerInventoryOperationRequest(CharacterPlayerModels.GetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerInventoryOperationRequest : GetPlayerInventoryOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerInventoryOperationRequest(CharacterPlayerModels.ServerGetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerInventoryOperationRequest : GetPlayerInventoryOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerInventoryOperationRequest(CharacterPlayerModels.AdminGetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerStatisticsOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerStatisticsRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerStatistics;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerStatisticsOperationRequest(CharacterPlayerModels.GetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerStatisticsOperationRequest : GetPlayerStatisticsOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerStatisticsOperationRequest(CharacterPlayerModels.ServerGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerStatisticsOperationRequest : GetPlayerStatisticsOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerStatisticsOperationRequest(CharacterPlayerModels.AdminGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithDisplayNameOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayersWithDisplayNameRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayersWithDisplayName;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayersWithDisplayNameOperationRequest(CharacterPlayerModels.GetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithDisplayNameOperationRequest : GetPlayersWithDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayersWithDisplayNameOperationRequest(CharacterPlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithDisplayNameOperationRequest : GetPlayersWithDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayersWithDisplayNameOperationRequest(CharacterPlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithSegmentOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayersWithSegmentRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayersWithSegment;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayersWithSegmentOperationRequest(CharacterPlayerModels.GetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithSegmentOperationRequest : GetPlayersWithSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayersWithSegmentOperationRequest(CharacterPlayerModels.ServerGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithSegmentOperationRequest : GetPlayersWithSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayersWithSegmentOperationRequest(CharacterPlayerModels.AdminGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithTagOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayersWithTagRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayersWithTag;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayersWithTagOperationRequest(CharacterPlayerModels.GetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithTagOperationRequest : GetPlayersWithTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayersWithTagOperationRequest(CharacterPlayerModels.ServerGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithTagOperationRequest : GetPlayersWithTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayersWithTagOperationRequest(CharacterPlayerModels.AdminGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetRemoveStatusOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetRemoveStatusRequestData>
        {
            protected override string operationCode => OperationCode.GetRemoveStatus;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetRemoveStatusOperationRequest(CharacterPlayerModels.GetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetRemoveStatusOperationRequest : GetRemoveStatusOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetRemoveStatusOperationRequest(CharacterPlayerModels.ServerGetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetRemoveStatusOperationRequest : GetRemoveStatusOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetRemoveStatusOperationRequest(CharacterPlayerModels.AdminGetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetSegmentOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetSegmentRequestData>
        {
            protected override string operationCode => OperationCode.GetSegment;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetSegmentOperationRequest(CharacterPlayerModels.GetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetSegmentOperationRequest(CharacterPlayerModels.ServerGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetSegmentOperationRequest(CharacterPlayerModels.AdminGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetStatisticsLeaderboardAroundPlayerOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData>
        {
            protected override string operationCode => OperationCode.GetStatisticsLeaderboardAroundPlayer;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLeaderboardAroundPlayerOperationRequest : GetStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLeaderboardAroundPlayerOperationRequest : GetStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetStatisticsLeaderboardOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetStatisticsLeaderboardRequestData>
        {
            protected override string operationCode => OperationCode.GetStatisticsLeaderboard;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetStatisticsLeaderboardOperationRequest(CharacterPlayerModels.GetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetStatisticsLeaderboardOperationRequest(CharacterPlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetStatisticsLeaderboardOperationRequest(CharacterPlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTagOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetTagRequestData>
        {
            protected override string operationCode => OperationCode.GetTag;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetTagOperationRequest(CharacterPlayerModels.GetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTagOperationRequest : GetTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetTagOperationRequest(CharacterPlayerModels.ServerGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTagOperationRequest : GetTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetTagOperationRequest(CharacterPlayerModels.AdminGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTsCreateOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetTsCreateRequestData>
        {
            protected override string operationCode => OperationCode.GetTsCreate;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetTsCreateOperationRequest(CharacterPlayerModels.GetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetTsCreateOperationRequest(CharacterPlayerModels.ServerGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetTsCreateOperationRequest(CharacterPlayerModels.AdminGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTsLastLoginOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetTsLastLoginRequestData>
        {
            protected override string operationCode => OperationCode.GetTsLastLogin;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetTsLastLoginOperationRequest(CharacterPlayerModels.GetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTsLastLoginOperationRequest : GetTsLastLoginOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetTsLastLoginOperationRequest(CharacterPlayerModels.ServerGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTsLastLoginOperationRequest : GetTsLastLoginOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetTsLastLoginOperationRequest(CharacterPlayerModels.AdminGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class CreateGroupOperationRequest : CustomOperationRequest<CharacterPlayerModels.CreateGroupRequestData>
        {
            protected override string operationCode => OperationCode.CreateGroup;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public CreateGroupOperationRequest(CharacterPlayerModels.CreateGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerCreateGroupOperationRequest : CreateGroupOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerCreateGroupOperationRequest(CharacterPlayerModels.ServerCreateGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminCreateGroupOperationRequest : CreateGroupOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminCreateGroupOperationRequest(CharacterPlayerModels.AdminCreateGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class CreatePlayerItemOperationRequest : CustomOperationRequest<CharacterPlayerModels.CreatePlayerItemRequestData>
        {
            protected override string operationCode => OperationCode.CreatePlayerItem;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public CreatePlayerItemOperationRequest(CharacterPlayerModels.CreatePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerCreatePlayerItemOperationRequest : CreatePlayerItemOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerCreatePlayerItemOperationRequest(CharacterPlayerModels.ServerCreatePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminCreatePlayerItemOperationRequest : CreatePlayerItemOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminCreatePlayerItemOperationRequest(CharacterPlayerModels.AdminCreatePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class JoinGroupOperationRequest : CustomOperationRequest<CharacterPlayerModels.JoinGroupRequestData>
        {
            protected override string operationCode => OperationCode.JoinGroup;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public JoinGroupOperationRequest(CharacterPlayerModels.JoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerJoinGroupOperationRequest : JoinGroupOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerJoinGroupOperationRequest(CharacterPlayerModels.ServerJoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminJoinGroupOperationRequest : JoinGroupOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminJoinGroupOperationRequest(CharacterPlayerModels.AdminJoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LeaveGroupOperationRequest : CustomOperationRequest<CharacterPlayerModels.LeaveGroupRequestData>
        {
            protected override string operationCode => OperationCode.LeaveGroup;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public LeaveGroupOperationRequest(CharacterPlayerModels.LeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLeaveGroupOperationRequest : LeaveGroupOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLeaveGroupOperationRequest(CharacterPlayerModels.ServerLeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLeaveGroupOperationRequest : LeaveGroupOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLeaveGroupOperationRequest(CharacterPlayerModels.AdminLeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemovePlayerFriendOperationRequest : CustomOperationRequest<CharacterPlayerModels.RemovePlayerFriendRequestData>
        {
            protected override string operationCode => OperationCode.RemovePlayerFriend;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public RemovePlayerFriendOperationRequest(CharacterPlayerModels.RemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemovePlayerFriendOperationRequest : RemovePlayerFriendOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerRemovePlayerFriendOperationRequest(CharacterPlayerModels.ServerRemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemovePlayerFriendOperationRequest : RemovePlayerFriendOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminRemovePlayerFriendOperationRequest(CharacterPlayerModels.AdminRemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemovePlayerItemOperationRequest : CustomOperationRequest<CharacterPlayerModels.RemovePlayerItemRequestData>
        {
            protected override string operationCode => OperationCode.RemovePlayerItem;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public RemovePlayerItemOperationRequest(CharacterPlayerModels.RemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemovePlayerItemOperationRequest : RemovePlayerItemOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerRemovePlayerItemOperationRequest(CharacterPlayerModels.ServerRemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemovePlayerItemOperationRequest : RemovePlayerItemOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminRemovePlayerItemOperationRequest(CharacterPlayerModels.AdminRemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveSegmentOperationRequest : CustomOperationRequest<CharacterPlayerModels.RemoveSegmentRequestData>
        {
            protected override string operationCode => OperationCode.RemoveSegment;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public RemoveSegmentOperationRequest(CharacterPlayerModels.RemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerRemoveSegmentOperationRequest(CharacterPlayerModels.ServerRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminRemoveSegmentOperationRequest(CharacterPlayerModels.AdminRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveTagOperationRequest : CustomOperationRequest<CharacterPlayerModels.RemoveTagRequestData>
        {
            protected override string operationCode => OperationCode.RemoveTag;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public RemoveTagOperationRequest(CharacterPlayerModels.RemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerRemoveTagOperationRequest(CharacterPlayerModels.ServerRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminRemoveTagOperationRequest(CharacterPlayerModels.AdminRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetAvatarOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetAvatarRequestData>
        {
            protected override string operationCode => OperationCode.SetAvatar;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetAvatarOperationRequest(CharacterPlayerModels.SetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetAvatarOperationRequest(CharacterPlayerModels.ServerSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetAvatarOperationRequest(CharacterPlayerModels.AdminSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetCountryCodeOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetCountryCodeRequestData>
        {
            protected override string operationCode => OperationCode.SetCountryCode;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetCountryCodeOperationRequest(CharacterPlayerModels.SetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetCountryCodeOperationRequest : SetCountryCodeOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetCountryCodeOperationRequest(CharacterPlayerModels.ServerSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetCountryCodeOperationRequest : SetCountryCodeOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetCountryCodeOperationRequest(CharacterPlayerModels.AdminSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetCustomDataOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetCustomDataRequestData>
        {
            protected override string operationCode => OperationCode.SetCustomData;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetCustomDataOperationRequest(CharacterPlayerModels.SetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetCustomDataOperationRequest(CharacterPlayerModels.ServerSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetCustomDataOperationRequest(CharacterPlayerModels.AdminSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetDisplayNameOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetDisplayNameRequestData>
        {
            protected override string operationCode => OperationCode.SetDisplayName;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetDisplayNameOperationRequest(CharacterPlayerModels.SetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetDisplayNameOperationRequest(CharacterPlayerModels.ServerSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetDisplayNameOperationRequest(CharacterPlayerModels.AdminSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetOwnerOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetOwnerRequestData>
        {
            protected override string operationCode => OperationCode.SetOwner;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetOwnerOperationRequest(CharacterPlayerModels.SetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetOwnerOperationRequest : SetOwnerOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetOwnerOperationRequest(CharacterPlayerModels.ServerSetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetOwnerOperationRequest : SetOwnerOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetOwnerOperationRequest(CharacterPlayerModels.AdminSetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetPlayerBanOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetPlayerBanRequestData>
        {
            protected override string operationCode => OperationCode.SetPlayerBan;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetPlayerBanOperationRequest(CharacterPlayerModels.SetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetPlayerBanOperationRequest : SetPlayerBanOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetPlayerBanOperationRequest(CharacterPlayerModels.ServerSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetPlayerBanOperationRequest : SetPlayerBanOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetPlayerBanOperationRequest(CharacterPlayerModels.AdminSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class ChangePlayerCurrencyOperationRequest : CustomOperationRequest<CharacterPlayerModels.ChangePlayerCurrencyRequestData>
        {
            protected override string operationCode => OperationCode.ChangePlayerCurrency;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public ChangePlayerCurrencyOperationRequest(CharacterPlayerModels.ChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerChangePlayerCurrencyOperationRequest : ChangePlayerCurrencyOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerChangePlayerCurrencyOperationRequest(CharacterPlayerModels.ServerChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminChangePlayerCurrencyOperationRequest : ChangePlayerCurrencyOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminChangePlayerCurrencyOperationRequest(CharacterPlayerModels.AdminChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetPlayerDataOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetPlayerDataRequestData>
        {
            protected override string operationCode => OperationCode.SetPlayerData;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetPlayerDataOperationRequest(CharacterPlayerModels.SetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetPlayerDataOperationRequest : SetPlayerDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetPlayerDataOperationRequest(CharacterPlayerModels.ServerSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetPlayerDataOperationRequest : SetPlayerDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetPlayerDataOperationRequest(CharacterPlayerModels.AdminSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class ChangePlayerStatisticsOperationRequest : CustomOperationRequest<CharacterPlayerModels.ChangePlayerStatisticsRequestData>
        {
            protected override string operationCode => OperationCode.ChangePlayerStatistics;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public ChangePlayerStatisticsOperationRequest(CharacterPlayerModels.ChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerChangePlayerStatisticsOperationRequest : ChangePlayerStatisticsOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerChangePlayerStatisticsOperationRequest(CharacterPlayerModels.ServerChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminChangePlayerStatisticsOperationRequest : ChangePlayerStatisticsOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminChangePlayerStatisticsOperationRequest(CharacterPlayerModels.AdminChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetRemoveStatusOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetRemoveStatusRequestData>
        {
            protected override string operationCode => OperationCode.SetRemoveStatus;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetRemoveStatusOperationRequest(CharacterPlayerModels.SetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetRemoveStatusOperationRequest : SetRemoveStatusOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetRemoveStatusOperationRequest(CharacterPlayerModels.ServerSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetRemoveStatusOperationRequest : SetRemoveStatusOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetRemoveStatusOperationRequest(CharacterPlayerModels.AdminSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetTagOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetTagRequestData>
        {
            protected override string operationCode => OperationCode.SetTag;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetTagOperationRequest(CharacterPlayerModels.SetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetTagOperationRequest : SetTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetTagOperationRequest(CharacterPlayerModels.ServerSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetTagOperationRequest : SetTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetTagOperationRequest(CharacterPlayerModels.AdminSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCurrencyLeaderboardOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCurrencyLeaderboardRequestData>
        {
            protected override string operationCode => OperationCode.GetCurrencyLeaderboard;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetCurrencyLeaderboardOperationRequest(CharacterPlayerModels.GetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCurrencyLeaderboardOperationRequest(CharacterPlayerModels.ServerGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCurrencyLeaderboardOperationRequest(CharacterPlayerModels.AdminGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCreateLeaderboardOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCreateLeaderboardRequestData>
        {
            protected override string operationCode => OperationCode.GetCreateLeaderboard;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetCreateLeaderboardOperationRequest(CharacterPlayerModels.GetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCreateLeaderboardOperationRequest(CharacterPlayerModels.ServerGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCreateLeaderboardOperationRequest(CharacterPlayerModels.AdminGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetLastLoginLeaderboardOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetLastLoginLeaderboardRequestData>
        {
            protected override string operationCode => OperationCode.GetLastLoginLeaderboard;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetLastLoginLeaderboardOperationRequest(CharacterPlayerModels.GetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetLastLoginLeaderboardOperationRequest : GetLastLoginLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetLastLoginLeaderboardOperationRequest(CharacterPlayerModels.ServerGetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetLastLoginLeaderboardOperationRequest : GetLastLoginLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetLastLoginLeaderboardOperationRequest(CharacterPlayerModels.AdminGetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetStatisticsLogOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetStatisticsLogRequestData>
        {
            protected override string operationCode => OperationCode.GetStatisticsLog;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetStatisticsLogOperationRequest(CharacterPlayerModels.GetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetStatisticsLogOperationRequest(CharacterPlayerModels.ServerGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetStatisticsLogOperationRequest(CharacterPlayerModels.AdminGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCurrencyLogOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCurrencyLogRequestData>
        {
            protected override string operationCode => OperationCode.GetCurrencyLog;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetCurrencyLogOperationRequest(CharacterPlayerModels.GetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCurrencyLogOperationRequest(CharacterPlayerModels.ServerGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCurrencyLogOperationRequest(CharacterPlayerModels.AdminGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}
