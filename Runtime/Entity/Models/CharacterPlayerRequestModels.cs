namespace XmobiTea.GN.Entity.Models
{
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity.Request;

    public class CharacterPlayerRequestModels
    {
        public class AddPlayerFriendOperationRequest : CustomOperationRequest<CharacterPlayerModels.AddPlayerFriendRequestData>
        {
            protected override int operationCode => OperationCode.AddPlayerFriend;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public AddPlayerFriendOperationRequest(CharacterPlayerModels.AddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerAddPlayerFriendOperationRequest : AddPlayerFriendOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerAddPlayerFriendOperationRequest(CharacterPlayerModels.ServerAddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminAddPlayerFriendOperationRequest : AddPlayerFriendOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminAddPlayerFriendOperationRequest(CharacterPlayerModels.AdminAddPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class AddSegmentOperationRequest : CustomOperationRequest<CharacterPlayerModels.AddSegmentRequestData>
        {
            protected override int operationCode => OperationCode.AddSegment;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public AddSegmentOperationRequest(CharacterPlayerModels.AddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerAddSegmentOperationRequest(CharacterPlayerModels.ServerAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminAddSegmentOperationRequest(CharacterPlayerModels.AdminAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetAvatarOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetAvatarRequestData>
        {
            protected override int operationCode => OperationCode.GetAvatar;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetAvatarOperationRequest(CharacterPlayerModels.GetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetAvatarOperationRequest(CharacterPlayerModels.ServerGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetAvatarOperationRequest(CharacterPlayerModels.AdminGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetCatalogIdOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCatalogIdRequestData>
        {
            protected override int operationCode => OperationCode.GetCatalogId;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetCatalogIdOperationRequest(CharacterPlayerModels.GetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCatalogIdOperationRequest : GetCatalogIdOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetCatalogIdOperationRequest(CharacterPlayerModels.ServerGetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCatalogIdOperationRequest : GetCatalogIdOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetCatalogIdOperationRequest(CharacterPlayerModels.AdminGetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetCountryCodeOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCountryCodeRequestData>
        {
            protected override int operationCode => OperationCode.GetCountryCode;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetCountryCodeOperationRequest(CharacterPlayerModels.GetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCountryCodeOperationRequest : GetCountryCodeOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetCountryCodeOperationRequest(CharacterPlayerModels.ServerGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCountryCodeOperationRequest : GetCountryCodeOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetCountryCodeOperationRequest(CharacterPlayerModels.AdminGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetCustomDataOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCustomDataRequestData>
        {
            protected override int operationCode => OperationCode.GetCustomData;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetCustomDataOperationRequest(CharacterPlayerModels.GetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetCustomDataOperationRequest(CharacterPlayerModels.ServerGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetCustomDataOperationRequest(CharacterPlayerModels.AdminGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetDisplayNameOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetDisplayNameRequestData>
        {
            protected override int operationCode => OperationCode.GetDisplayName;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetDisplayNameOperationRequest(CharacterPlayerModels.GetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetDisplayNameOperationRequest(CharacterPlayerModels.ServerGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetDisplayNameOperationRequest(CharacterPlayerModels.AdminGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetFriendStatisticsLeaderboardAroundPlayerOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData>
        {
            protected override int operationCode => OperationCode.GetFriendStatisticsLeaderboardAroundPlayer;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetFriendStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest : GetFriendStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest : GetFriendStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetFriendStatisticsLeaderboardOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetFriendStatisticsLeaderboardRequestData>
        {
            protected override int operationCode => OperationCode.GetFriendStatisticsLeaderboard;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetFriendStatisticsLeaderboardOperationRequest(CharacterPlayerModels.GetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetFriendStatisticsLeaderboardOperationRequest : GetFriendStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetFriendStatisticsLeaderboardOperationRequest(CharacterPlayerModels.ServerGetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetFriendStatisticsLeaderboardOperationRequest : GetFriendStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetFriendStatisticsLeaderboardOperationRequest(CharacterPlayerModels.AdminGetFriendStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetIpAddressCreateOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetIpAddressCreateRequestData>
        {
            protected override int operationCode => OperationCode.GetIpAddressCreate;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetIpAddressCreateOperationRequest(CharacterPlayerModels.GetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetIpAddressCreateOperationRequest : GetIpAddressCreateOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetIpAddressCreateOperationRequest(CharacterPlayerModels.ServerGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetIpAddressCreateOperationRequest : GetIpAddressCreateOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetIpAddressCreateOperationRequest(CharacterPlayerModels.AdminGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetOwnerOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetOwnerRequestData>
        {
            protected override int operationCode => OperationCode.GetOwner;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetOwnerOperationRequest(CharacterPlayerModels.GetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetOwnerOperationRequest : GetOwnerOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetOwnerOperationRequest(CharacterPlayerModels.ServerGetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetOwnerOperationRequest : GetOwnerOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetOwnerOperationRequest(CharacterPlayerModels.AdminGetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerBanOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerBanRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayerBan;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayerBanOperationRequest(CharacterPlayerModels.GetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerBanOperationRequest : GetPlayerBanOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayerBanOperationRequest(CharacterPlayerModels.ServerGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerBanOperationRequest : GetPlayerBanOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayerBanOperationRequest(CharacterPlayerModels.AdminGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerCurrencyOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerCurrencyRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayerCurrency;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayerCurrencyOperationRequest(CharacterPlayerModels.GetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerCurrencyOperationRequest : GetPlayerCurrencyOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayerCurrencyOperationRequest(CharacterPlayerModels.ServerGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerCurrencyOperationRequest : GetPlayerCurrencyOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayerCurrencyOperationRequest(CharacterPlayerModels.AdminGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerDataOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerDataRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayerData;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayerDataOperationRequest(CharacterPlayerModels.GetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerDataOperationRequest : GetPlayerDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayerDataOperationRequest(CharacterPlayerModels.ServerGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerDataOperationRequest : GetPlayerDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayerDataOperationRequest(CharacterPlayerModels.AdminGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerFriendOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerFriendRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayerFriend;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayerFriendOperationRequest(CharacterPlayerModels.GetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerFriendOperationRequest : GetPlayerFriendOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayerFriendOperationRequest(CharacterPlayerModels.ServerGetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerFriendOperationRequest : GetPlayerFriendOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayerFriendOperationRequest(CharacterPlayerModels.AdminGetPlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerGroupOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerGroupRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayerGroup;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayerGroupOperationRequest(CharacterPlayerModels.GetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerGroupOperationRequest : GetPlayerGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayerGroupOperationRequest(CharacterPlayerModels.ServerGetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerGroupOperationRequest : GetPlayerGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayerGroupOperationRequest(CharacterPlayerModels.AdminGetPlayerGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerInformationOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerInformationRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayerInformation;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayerInformationOperationRequest(CharacterPlayerModels.GetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerInformationOperationRequest : GetPlayerInformationOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayerInformationOperationRequest(CharacterPlayerModels.ServerGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerInformationOperationRequest : GetPlayerInformationOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayerInformationOperationRequest(CharacterPlayerModels.AdminGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerInventoryOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerInventoryRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayerInventory;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayerInventoryOperationRequest(CharacterPlayerModels.GetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerInventoryOperationRequest : GetPlayerInventoryOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayerInventoryOperationRequest(CharacterPlayerModels.ServerGetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerInventoryOperationRequest : GetPlayerInventoryOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayerInventoryOperationRequest(CharacterPlayerModels.AdminGetPlayerInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerStatisticsOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayerStatisticsRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayerStatistics;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayerStatisticsOperationRequest(CharacterPlayerModels.GetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerStatisticsOperationRequest : GetPlayerStatisticsOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayerStatisticsOperationRequest(CharacterPlayerModels.ServerGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerStatisticsOperationRequest : GetPlayerStatisticsOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayerStatisticsOperationRequest(CharacterPlayerModels.AdminGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithDisplayNameOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayersWithDisplayNameRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayersWithDisplayName;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayersWithDisplayNameOperationRequest(CharacterPlayerModels.GetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithDisplayNameOperationRequest : GetPlayersWithDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayersWithDisplayNameOperationRequest(CharacterPlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithDisplayNameOperationRequest : GetPlayersWithDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayersWithDisplayNameOperationRequest(CharacterPlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithSegmentOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayersWithSegmentRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayersWithSegment;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayersWithSegmentOperationRequest(CharacterPlayerModels.GetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithSegmentOperationRequest : GetPlayersWithSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayersWithSegmentOperationRequest(CharacterPlayerModels.ServerGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithSegmentOperationRequest : GetPlayersWithSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayersWithSegmentOperationRequest(CharacterPlayerModels.AdminGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithTagOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetPlayersWithTagRequestData>
        {
            protected override int operationCode => OperationCode.GetPlayersWithTag;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetPlayersWithTagOperationRequest(CharacterPlayerModels.GetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithTagOperationRequest : GetPlayersWithTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetPlayersWithTagOperationRequest(CharacterPlayerModels.ServerGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithTagOperationRequest : GetPlayersWithTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetPlayersWithTagOperationRequest(CharacterPlayerModels.AdminGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetRemoveStatusOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetRemoveStatusRequestData>
        {
            protected override int operationCode => OperationCode.GetRemoveStatus;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetRemoveStatusOperationRequest(CharacterPlayerModels.GetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetRemoveStatusOperationRequest : GetRemoveStatusOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetRemoveStatusOperationRequest(CharacterPlayerModels.ServerGetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetRemoveStatusOperationRequest : GetRemoveStatusOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetRemoveStatusOperationRequest(CharacterPlayerModels.AdminGetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetSegmentOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetSegmentRequestData>
        {
            protected override int operationCode => OperationCode.GetSegment;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetSegmentOperationRequest(CharacterPlayerModels.GetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetSegmentOperationRequest(CharacterPlayerModels.ServerGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetSegmentOperationRequest(CharacterPlayerModels.AdminGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetStatisticsLeaderboardAroundPlayerOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData>
        {
            protected override int operationCode => OperationCode.GetStatisticsLeaderboardAroundPlayer;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLeaderboardAroundPlayerOperationRequest : GetStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLeaderboardAroundPlayerOperationRequest : GetStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(CharacterPlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetStatisticsLeaderboardOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetStatisticsLeaderboardRequestData>
        {
            protected override int operationCode => OperationCode.GetStatisticsLeaderboard;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetStatisticsLeaderboardOperationRequest(CharacterPlayerModels.GetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetStatisticsLeaderboardOperationRequest(CharacterPlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetStatisticsLeaderboardOperationRequest(CharacterPlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTagOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetTagRequestData>
        {
            protected override int operationCode => OperationCode.GetTag;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetTagOperationRequest(CharacterPlayerModels.GetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTagOperationRequest : GetTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetTagOperationRequest(CharacterPlayerModels.ServerGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTagOperationRequest : GetTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetTagOperationRequest(CharacterPlayerModels.AdminGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTsCreateOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetTsCreateRequestData>
        {
            protected override int operationCode => OperationCode.GetTsCreate;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetTsCreateOperationRequest(CharacterPlayerModels.GetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetTsCreateOperationRequest(CharacterPlayerModels.ServerGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetTsCreateOperationRequest(CharacterPlayerModels.AdminGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTsLastLoginOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetTsLastLoginRequestData>
        {
            protected override int operationCode => OperationCode.GetTsLastLogin;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetTsLastLoginOperationRequest(CharacterPlayerModels.GetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTsLastLoginOperationRequest : GetTsLastLoginOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetTsLastLoginOperationRequest(CharacterPlayerModels.ServerGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTsLastLoginOperationRequest : GetTsLastLoginOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetTsLastLoginOperationRequest(CharacterPlayerModels.AdminGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GrantGroupOperationRequest : CustomOperationRequest<CharacterPlayerModels.GrantGroupRequestData>
        {
            protected override int operationCode => OperationCode.GrantGroup;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GrantGroupOperationRequest(CharacterPlayerModels.GrantGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGrantGroupOperationRequest : GrantGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGrantGroupOperationRequest(CharacterPlayerModels.ServerGrantGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGrantGroupOperationRequest : GrantGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGrantGroupOperationRequest(CharacterPlayerModels.AdminGrantGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GrantPlayerItemOperationRequest : CustomOperationRequest<CharacterPlayerModels.GrantPlayerItemRequestData>
        {
            protected override int operationCode => OperationCode.GrantPlayerItem;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GrantPlayerItemOperationRequest(CharacterPlayerModels.GrantPlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGrantPlayerItemOperationRequest : GrantPlayerItemOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGrantPlayerItemOperationRequest(CharacterPlayerModels.ServerGrantPlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGrantPlayerItemOperationRequest : GrantPlayerItemOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGrantPlayerItemOperationRequest(CharacterPlayerModels.AdminGrantPlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class JoinGroupOperationRequest : CustomOperationRequest<CharacterPlayerModels.JoinGroupRequestData>
        {
            protected override int operationCode => OperationCode.JoinGroup;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public JoinGroupOperationRequest(CharacterPlayerModels.JoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerJoinGroupOperationRequest : JoinGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerJoinGroupOperationRequest(CharacterPlayerModels.ServerJoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminJoinGroupOperationRequest : JoinGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminJoinGroupOperationRequest(CharacterPlayerModels.AdminJoinGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LeaveGroupOperationRequest : CustomOperationRequest<CharacterPlayerModels.LeaveGroupRequestData>
        {
            protected override int operationCode => OperationCode.LeaveGroup;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public LeaveGroupOperationRequest(CharacterPlayerModels.LeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLeaveGroupOperationRequest : LeaveGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerLeaveGroupOperationRequest(CharacterPlayerModels.ServerLeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLeaveGroupOperationRequest : LeaveGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminLeaveGroupOperationRequest(CharacterPlayerModels.AdminLeaveGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemovePlayerFriendOperationRequest : CustomOperationRequest<CharacterPlayerModels.RemovePlayerFriendRequestData>
        {
            protected override int operationCode => OperationCode.RemovePlayerFriend;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public RemovePlayerFriendOperationRequest(CharacterPlayerModels.RemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemovePlayerFriendOperationRequest : RemovePlayerFriendOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerRemovePlayerFriendOperationRequest(CharacterPlayerModels.ServerRemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemovePlayerFriendOperationRequest : RemovePlayerFriendOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminRemovePlayerFriendOperationRequest(CharacterPlayerModels.AdminRemovePlayerFriendRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemovePlayerItemOperationRequest : CustomOperationRequest<CharacterPlayerModels.RemovePlayerItemRequestData>
        {
            protected override int operationCode => OperationCode.RemovePlayerItem;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public RemovePlayerItemOperationRequest(CharacterPlayerModels.RemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemovePlayerItemOperationRequest : RemovePlayerItemOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerRemovePlayerItemOperationRequest(CharacterPlayerModels.ServerRemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemovePlayerItemOperationRequest : RemovePlayerItemOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminRemovePlayerItemOperationRequest(CharacterPlayerModels.AdminRemovePlayerItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveSegmentOperationRequest : CustomOperationRequest<CharacterPlayerModels.RemoveSegmentRequestData>
        {
            protected override int operationCode => OperationCode.RemoveSegment;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public RemoveSegmentOperationRequest(CharacterPlayerModels.RemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerRemoveSegmentOperationRequest(CharacterPlayerModels.ServerRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminRemoveSegmentOperationRequest(CharacterPlayerModels.AdminRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveTagOperationRequest : CustomOperationRequest<CharacterPlayerModels.RemoveTagRequestData>
        {
            protected override int operationCode => OperationCode.RemoveTag;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public RemoveTagOperationRequest(CharacterPlayerModels.RemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerRemoveTagOperationRequest(CharacterPlayerModels.ServerRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminRemoveTagOperationRequest(CharacterPlayerModels.AdminRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetAvatarOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetAvatarRequestData>
        {
            protected override int operationCode => OperationCode.SetAvatar;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetAvatarOperationRequest(CharacterPlayerModels.SetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetAvatarOperationRequest(CharacterPlayerModels.ServerSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetAvatarOperationRequest(CharacterPlayerModels.AdminSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetCountryCodeOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetCountryCodeRequestData>
        {
            protected override int operationCode => OperationCode.SetCountryCode;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetCountryCodeOperationRequest(CharacterPlayerModels.SetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetCountryCodeOperationRequest : SetCountryCodeOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetCountryCodeOperationRequest(CharacterPlayerModels.ServerSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetCountryCodeOperationRequest : SetCountryCodeOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetCountryCodeOperationRequest(CharacterPlayerModels.AdminSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetCustomDataOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetCustomDataRequestData>
        {
            protected override int operationCode => OperationCode.SetCustomData;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetCustomDataOperationRequest(CharacterPlayerModels.SetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetCustomDataOperationRequest(CharacterPlayerModels.ServerSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetCustomDataOperationRequest(CharacterPlayerModels.AdminSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetDisplayNameOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetDisplayNameRequestData>
        {
            protected override int operationCode => OperationCode.SetDisplayName;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetDisplayNameOperationRequest(CharacterPlayerModels.SetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetDisplayNameOperationRequest(CharacterPlayerModels.ServerSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetDisplayNameOperationRequest(CharacterPlayerModels.AdminSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetOwnerOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetOwnerRequestData>
        {
            protected override int operationCode => OperationCode.SetOwner;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetOwnerOperationRequest(CharacterPlayerModels.SetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetOwnerOperationRequest : SetOwnerOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetOwnerOperationRequest(CharacterPlayerModels.ServerSetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetOwnerOperationRequest : SetOwnerOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetOwnerOperationRequest(CharacterPlayerModels.AdminSetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetPlayerBanOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetPlayerBanRequestData>
        {
            protected override int operationCode => OperationCode.SetPlayerBan;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetPlayerBanOperationRequest(CharacterPlayerModels.SetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetPlayerBanOperationRequest : SetPlayerBanOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetPlayerBanOperationRequest(CharacterPlayerModels.ServerSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetPlayerBanOperationRequest : SetPlayerBanOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetPlayerBanOperationRequest(CharacterPlayerModels.AdminSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetPlayerCurrencyOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetPlayerCurrencyRequestData>
        {
            protected override int operationCode => OperationCode.SetPlayerCurrency;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetPlayerCurrencyOperationRequest(CharacterPlayerModels.SetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetPlayerCurrencyOperationRequest : SetPlayerCurrencyOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetPlayerCurrencyOperationRequest(CharacterPlayerModels.ServerSetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetPlayerCurrencyOperationRequest : SetPlayerCurrencyOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetPlayerCurrencyOperationRequest(CharacterPlayerModels.AdminSetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetPlayerDataOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetPlayerDataRequestData>
        {
            protected override int operationCode => OperationCode.SetPlayerData;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetPlayerDataOperationRequest(CharacterPlayerModels.SetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetPlayerDataOperationRequest : SetPlayerDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetPlayerDataOperationRequest(CharacterPlayerModels.ServerSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetPlayerDataOperationRequest : SetPlayerDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetPlayerDataOperationRequest(CharacterPlayerModels.AdminSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetPlayerStatisticsOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetPlayerStatisticsRequestData>
        {
            protected override int operationCode => OperationCode.SetPlayerStatistics;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetPlayerStatisticsOperationRequest(CharacterPlayerModels.SetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetPlayerStatisticsOperationRequest : SetPlayerStatisticsOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetPlayerStatisticsOperationRequest(CharacterPlayerModels.ServerSetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetPlayerStatisticsOperationRequest : SetPlayerStatisticsOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetPlayerStatisticsOperationRequest(CharacterPlayerModels.AdminSetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetRemoveStatusOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetRemoveStatusRequestData>
        {
            protected override int operationCode => OperationCode.SetRemoveStatus;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetRemoveStatusOperationRequest(CharacterPlayerModels.SetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetRemoveStatusOperationRequest : SetRemoveStatusOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetRemoveStatusOperationRequest(CharacterPlayerModels.ServerSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetRemoveStatusOperationRequest : SetRemoveStatusOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetRemoveStatusOperationRequest(CharacterPlayerModels.AdminSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetTagOperationRequest : CustomOperationRequest<CharacterPlayerModels.SetTagRequestData>
        {
            protected override int operationCode => OperationCode.SetTag;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetTagOperationRequest(CharacterPlayerModels.SetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetTagOperationRequest : SetTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetTagOperationRequest(CharacterPlayerModels.ServerSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetTagOperationRequest : SetTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetTagOperationRequest(CharacterPlayerModels.AdminSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCurrencyLeaderboardOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCurrencyLeaderboardRequestData>
        {
            protected override int operationCode => OperationCode.GetCurrencyLeaderboard;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetCurrencyLeaderboardOperationRequest(CharacterPlayerModels.GetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetCurrencyLeaderboardOperationRequest(CharacterPlayerModels.ServerGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetCurrencyLeaderboardOperationRequest(CharacterPlayerModels.AdminGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCreateLeaderboardOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCreateLeaderboardRequestData>
        {
            protected override int operationCode => OperationCode.GetCreateLeaderboard;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetCreateLeaderboardOperationRequest(CharacterPlayerModels.GetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetCreateLeaderboardOperationRequest(CharacterPlayerModels.ServerGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetCreateLeaderboardOperationRequest(CharacterPlayerModels.AdminGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetLastLoginLeaderboardOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetLastLoginLeaderboardRequestData>
        {
            protected override int operationCode => OperationCode.GetLastLoginLeaderboard;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetLastLoginLeaderboardOperationRequest(CharacterPlayerModels.GetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetLastLoginLeaderboardOperationRequest : GetLastLoginLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetLastLoginLeaderboardOperationRequest(CharacterPlayerModels.ServerGetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetLastLoginLeaderboardOperationRequest : GetLastLoginLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetLastLoginLeaderboardOperationRequest(CharacterPlayerModels.AdminGetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetStatisticsLogOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetStatisticsLogRequestData>
        {
            protected override int operationCode => OperationCode.GetStatisticsLog;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetStatisticsLogOperationRequest(CharacterPlayerModels.GetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetStatisticsLogOperationRequest(CharacterPlayerModels.ServerGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetStatisticsLogOperationRequest(CharacterPlayerModels.AdminGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCurrencyLogOperationRequest : CustomOperationRequest<CharacterPlayerModels.GetCurrencyLogRequestData>
        {
            protected override int operationCode => OperationCode.GetCurrencyLog;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CharacterPlayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetCurrencyLogOperationRequest(CharacterPlayerModels.GetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetCurrencyLogOperationRequest(CharacterPlayerModels.ServerGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetCurrencyLogOperationRequest(CharacterPlayerModels.AdminGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}
