namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    public class MasterPlayerRequestModels
    {
        public class AddSegmentOperationRequest : CustomOperationRequest<MasterPlayerModels.AddSegmentRequestData>
        {
            protected override string operationCode => OperationCode.AddSegment;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public AddSegmentOperationRequest(MasterPlayerModels.AddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerAddSegmentOperationRequest(MasterPlayerModels.ServerAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminAddSegmentOperationRequest(MasterPlayerModels.AdminAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class ChangeAccountPasswordOperationRequest : CustomOperationRequest<MasterPlayerModels.ChangeAccountPasswordRequestData>
        {
            protected override string operationCode => OperationCode.ChangeAccountPassword;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public ChangeAccountPasswordOperationRequest(MasterPlayerModels.ChangeAccountPasswordRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetAvatarOperationRequest : CustomOperationRequest<MasterPlayerModels.GetAvatarRequestData>
        {
            protected override string operationCode => OperationCode.GetAvatar;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetAvatarOperationRequest(MasterPlayerModels.GetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetAvatarOperationRequest(MasterPlayerModels.ServerGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetAvatarOperationRequest(MasterPlayerModels.AdminGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetCountryCodeOperationRequest : CustomOperationRequest<MasterPlayerModels.GetCountryCodeRequestData>
        {
            protected override string operationCode => OperationCode.GetCountryCode;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetCountryCodeOperationRequest(MasterPlayerModels.GetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCountryCodeOperationRequest : GetCountryCodeOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCountryCodeOperationRequest(MasterPlayerModels.ServerGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCountryCodeOperationRequest : GetCountryCodeOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCountryCodeOperationRequest(MasterPlayerModels.AdminGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetCustomDataOperationRequest : CustomOperationRequest<MasterPlayerModels.GetCustomDataRequestData>
        {
            protected override string operationCode => OperationCode.GetCustomData;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetCustomDataOperationRequest(MasterPlayerModels.GetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCustomDataOperationRequest(MasterPlayerModels.ServerGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCustomDataOperationRequest(MasterPlayerModels.AdminGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetDisplayNameOperationRequest : CustomOperationRequest<MasterPlayerModels.GetDisplayNameRequestData>
        {
            protected override string operationCode => OperationCode.GetDisplayName;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetDisplayNameOperationRequest(MasterPlayerModels.GetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetDisplayNameOperationRequest(MasterPlayerModels.ServerGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetDisplayNameOperationRequest(MasterPlayerModels.AdminGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetEmailOperationRequest : CustomOperationRequest<MasterPlayerModels.GetEmailRequestData>
        {
            protected override string operationCode => OperationCode.GetEmail;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetEmailOperationRequest(MasterPlayerModels.GetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetEmailOperationRequest : GetEmailOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetEmailOperationRequest(MasterPlayerModels.ServerGetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetEmailOperationRequest : GetEmailOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetEmailOperationRequest(MasterPlayerModels.AdminGetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetExternalOperationRequest : CustomOperationRequest<MasterPlayerModels.GetExternalRequestData>
        {
            protected override string operationCode => OperationCode.GetExternal;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetExternalOperationRequest(MasterPlayerModels.GetExternalRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetExternalOperationRequest : GetExternalOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetExternalOperationRequest(MasterPlayerModels.ServerGetExternalRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetExternalOperationRequest : GetExternalOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetExternalOperationRequest(MasterPlayerModels.AdminGetExternalRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetIpAddressCreateOperationRequest : CustomOperationRequest<MasterPlayerModels.GetIpAddressCreateRequestData>
        {
            protected override string operationCode => OperationCode.GetIpAddressCreate;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetIpAddressCreateOperationRequest(MasterPlayerModels.GetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetIpAddressCreateOperationRequest : GetIpAddressCreateOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetIpAddressCreateOperationRequest(MasterPlayerModels.ServerGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetIpAddressCreateOperationRequest : GetIpAddressCreateOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetIpAddressCreateOperationRequest(MasterPlayerModels.AdminGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerBanOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayerBanRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerBan;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerBanOperationRequest(MasterPlayerModels.GetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerBanOperationRequest : GetPlayerBanOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerBanOperationRequest(MasterPlayerModels.ServerGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerBanOperationRequest : GetPlayerBanOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerBanOperationRequest(MasterPlayerModels.AdminGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerCurrencyOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayerCurrencyRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerCurrency;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerCurrencyOperationRequest(MasterPlayerModels.GetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerCurrencyOperationRequest : GetPlayerCurrencyOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerCurrencyOperationRequest(MasterPlayerModels.ServerGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerCurrencyOperationRequest : GetPlayerCurrencyOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerCurrencyOperationRequest(MasterPlayerModels.AdminGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerDataOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayerDataRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerData;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerDataOperationRequest(MasterPlayerModels.GetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerDataOperationRequest : GetPlayerDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerDataOperationRequest(MasterPlayerModels.ServerGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerDataOperationRequest : GetPlayerDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerDataOperationRequest(MasterPlayerModels.AdminGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerInformationOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayerInformationRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerInformation;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerInformationOperationRequest(MasterPlayerModels.GetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerInformationOperationRequest : GetPlayerInformationOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerInformationOperationRequest(MasterPlayerModels.ServerGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerInformationOperationRequest : GetPlayerInformationOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerInformationOperationRequest(MasterPlayerModels.AdminGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayerStatisticsOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayerStatisticsRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayerStatistics;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayerStatisticsOperationRequest(MasterPlayerModels.GetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayerStatisticsOperationRequest : GetPlayerStatisticsOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayerStatisticsOperationRequest(MasterPlayerModels.ServerGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayerStatisticsOperationRequest : GetPlayerStatisticsOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayerStatisticsOperationRequest(MasterPlayerModels.AdminGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithAppleOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithAppleRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayersWithApple;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayersWithAppleOperationRequest(MasterPlayerModels.GetPlayersWithAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithAppleOperationRequest : GetPlayersWithAppleOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayersWithAppleOperationRequest(MasterPlayerModels.ServerGetPlayersWithAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithAppleOperationRequest : GetPlayersWithAppleOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayersWithAppleOperationRequest(MasterPlayerModels.AdminGetPlayersWithAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithDisplayNameOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithDisplayNameRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayersWithDisplayName;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayersWithDisplayNameOperationRequest(MasterPlayerModels.GetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithDisplayNameOperationRequest : GetPlayersWithDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayersWithDisplayNameOperationRequest(MasterPlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithDisplayNameOperationRequest : GetPlayersWithDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayersWithDisplayNameOperationRequest(MasterPlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithFacebookOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithFacebookRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayersWithFacebook;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayersWithFacebookOperationRequest(MasterPlayerModels.GetPlayersWithFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithFacebookOperationRequest : GetPlayersWithFacebookOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayersWithFacebookOperationRequest(MasterPlayerModels.ServerGetPlayersWithFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithFacebookOperationRequest : GetPlayersWithFacebookOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayersWithFacebookOperationRequest(MasterPlayerModels.AdminGetPlayersWithFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithGenericServiceOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithGenericServiceRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayersWithGenericService;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayersWithGenericServiceOperationRequest(MasterPlayerModels.GetPlayersWithGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithGenericServiceOperationRequest : GetPlayersWithGenericServiceOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayersWithGenericServiceOperationRequest(MasterPlayerModels.ServerGetPlayersWithGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithGenericServiceOperationRequest : GetPlayersWithGenericServiceOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayersWithGenericServiceOperationRequest(MasterPlayerModels.AdminGetPlayersWithGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithGoogleOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithGoogleRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayersWithGoogle;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayersWithGoogleOperationRequest(MasterPlayerModels.GetPlayersWithGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithGoogleOperationRequest : GetPlayersWithGoogleOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayersWithGoogleOperationRequest(MasterPlayerModels.ServerGetPlayersWithGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithGoogleOperationRequest : GetPlayersWithGoogleOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayersWithGoogleOperationRequest(MasterPlayerModels.AdminGetPlayersWithGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithGooglePlayGameServiceOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithGooglePlayGameServiceRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayersWithGooglePlayGameService;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayersWithGooglePlayGameServiceOperationRequest(MasterPlayerModels.GetPlayersWithGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithGooglePlayGameServiceOperationRequest : GetPlayersWithGooglePlayGameServiceOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayersWithGooglePlayGameServiceOperationRequest(MasterPlayerModels.ServerGetPlayersWithGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithGooglePlayGameServiceOperationRequest : GetPlayersWithGooglePlayGameServiceOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayersWithGooglePlayGameServiceOperationRequest(MasterPlayerModels.AdminGetPlayersWithGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithGameCenterOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithGameCenterRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayersWithGameCenter;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayersWithGameCenterOperationRequest(MasterPlayerModels.GetPlayersWithGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithGameCenterOperationRequest : GetPlayersWithGameCenterOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayersWithGameCenterOperationRequest(MasterPlayerModels.ServerGetPlayersWithGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithGameCenterOperationRequest : GetPlayersWithGameCenterOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayersWithGameCenterOperationRequest(MasterPlayerModels.AdminGetPlayersWithGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithSegmentOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithSegmentRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayersWithSegment;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayersWithSegmentOperationRequest(MasterPlayerModels.GetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithSegmentOperationRequest : GetPlayersWithSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayersWithSegmentOperationRequest(MasterPlayerModels.ServerGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithSegmentOperationRequest : GetPlayersWithSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayersWithSegmentOperationRequest(MasterPlayerModels.AdminGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetPlayersWithTagOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithTagRequestData>
        {
            protected override string operationCode => OperationCode.GetPlayersWithTag;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPlayersWithTagOperationRequest(MasterPlayerModels.GetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPlayersWithTagOperationRequest : GetPlayersWithTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPlayersWithTagOperationRequest(MasterPlayerModels.ServerGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPlayersWithTagOperationRequest : GetPlayersWithTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPlayersWithTagOperationRequest(MasterPlayerModels.AdminGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetSegmentOperationRequest : CustomOperationRequest<MasterPlayerModels.GetSegmentRequestData>
        {
            protected override string operationCode => OperationCode.GetSegment;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetSegmentOperationRequest(MasterPlayerModels.GetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetSegmentOperationRequest(MasterPlayerModels.ServerGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetSegmentOperationRequest(MasterPlayerModels.AdminGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetStatisticsLeaderboardAroundPlayerOperationRequest : CustomOperationRequest<MasterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData>
        {
            protected override string operationCode => OperationCode.GetStatisticsLeaderboardAroundPlayer;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetStatisticsLeaderboardAroundPlayerOperationRequest(MasterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLeaderboardAroundPlayerOperationRequest : GetStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(MasterPlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLeaderboardAroundPlayerOperationRequest : GetStatisticsLeaderboardAroundPlayerOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(MasterPlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetStatisticsLeaderboardOperationRequest : CustomOperationRequest<MasterPlayerModels.GetStatisticsLeaderboardRequestData>
        {
            protected override string operationCode => OperationCode.GetStatisticsLeaderboard;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetStatisticsLeaderboardOperationRequest(MasterPlayerModels.GetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetStatisticsLeaderboardOperationRequest(MasterPlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetStatisticsLeaderboardOperationRequest(MasterPlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTagOperationRequest : CustomOperationRequest<MasterPlayerModels.GetTagRequestData>
        {
            protected override string operationCode => OperationCode.GetTag;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetTagOperationRequest(MasterPlayerModels.GetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTagOperationRequest : GetTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetTagOperationRequest(MasterPlayerModels.ServerGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTagOperationRequest : GetTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetTagOperationRequest(MasterPlayerModels.AdminGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTsCreateOperationRequest : CustomOperationRequest<MasterPlayerModels.GetTsCreateRequestData>
        {
            protected override string operationCode => OperationCode.GetTsCreate;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetTsCreateOperationRequest(MasterPlayerModels.GetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetTsCreateOperationRequest(MasterPlayerModels.ServerGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetTsCreateOperationRequest(MasterPlayerModels.AdminGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTsLastLoginOperationRequest : CustomOperationRequest<MasterPlayerModels.GetTsLastLoginRequestData>
        {
            protected override string operationCode => OperationCode.GetTsLastLogin;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetTsLastLoginOperationRequest(MasterPlayerModels.GetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTsLastLoginOperationRequest : GetTsLastLoginOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetTsLastLoginOperationRequest(MasterPlayerModels.ServerGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTsLastLoginOperationRequest : GetTsLastLoginOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetTsLastLoginOperationRequest(MasterPlayerModels.AdminGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LinkAccountOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkAccountRequestData>
        {
            protected override string operationCode => OperationCode.LinkAccount;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public LinkAccountOperationRequest(MasterPlayerModels.LinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLinkAccountOperationRequest : LinkAccountOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLinkAccountOperationRequest(MasterPlayerModels.ServerLinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLinkAccountOperationRequest : LinkAccountOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLinkAccountOperationRequest(MasterPlayerModels.AdminLinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LinkAndroidDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkAndroidDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.LinkAndroidDeviceId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public LinkAndroidDeviceIdOperationRequest(MasterPlayerModels.LinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLinkAndroidDeviceIdOperationRequest : LinkAndroidDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLinkAndroidDeviceIdOperationRequest(MasterPlayerModels.ServerLinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLinkAndroidDeviceIdOperationRequest : LinkAndroidDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLinkAndroidDeviceIdOperationRequest(MasterPlayerModels.AdminLinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LinkAppleOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkAppleRequestData>
        {
            protected override string operationCode => OperationCode.LinkApple;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public LinkAppleOperationRequest(MasterPlayerModels.LinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLinkAppleOperationRequest : LinkAppleOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLinkAppleOperationRequest(MasterPlayerModels.ServerLinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLinkAppleOperationRequest : LinkAppleOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLinkAppleOperationRequest(MasterPlayerModels.AdminLinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LinkCustomDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkCustomDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.LinkCustomDeviceId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public LinkCustomDeviceIdOperationRequest(MasterPlayerModels.LinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLinkCustomDeviceIdOperationRequest : LinkCustomDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLinkCustomDeviceIdOperationRequest(MasterPlayerModels.ServerLinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLinkCustomDeviceIdOperationRequest : LinkCustomDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLinkCustomDeviceIdOperationRequest(MasterPlayerModels.AdminLinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LinkCustomIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkCustomIdRequestData>
        {
            protected override string operationCode => OperationCode.LinkCustomId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public LinkCustomIdOperationRequest(MasterPlayerModels.LinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLinkCustomIdOperationRequest : LinkCustomIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLinkCustomIdOperationRequest(MasterPlayerModels.ServerLinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLinkCustomIdOperationRequest : LinkCustomIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLinkCustomIdOperationRequest(MasterPlayerModels.AdminLinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LinkEditorDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkEditorDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.LinkEditorDeviceId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public LinkEditorDeviceIdOperationRequest(MasterPlayerModels.LinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLinkEditorDeviceIdOperationRequest : LinkEditorDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLinkEditorDeviceIdOperationRequest(MasterPlayerModels.ServerLinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLinkEditorDeviceIdOperationRequest : LinkEditorDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLinkEditorDeviceIdOperationRequest(MasterPlayerModels.AdminLinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LinkFacebookOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkFacebookRequestData>
        {
            protected override string operationCode => OperationCode.LinkFacebook;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public LinkFacebookOperationRequest(MasterPlayerModels.LinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLinkFacebookOperationRequest : LinkFacebookOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLinkFacebookOperationRequest(MasterPlayerModels.ServerLinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLinkFacebookOperationRequest : LinkFacebookOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLinkFacebookOperationRequest(MasterPlayerModels.AdminLinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LinkGenericServiceOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkGenericServiceRequestData>
        {
            protected override string operationCode => OperationCode.LinkGenericService;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public LinkGenericServiceOperationRequest(MasterPlayerModels.LinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLinkGenericServiceOperationRequest : LinkGenericServiceOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLinkGenericServiceOperationRequest(MasterPlayerModels.ServerLinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLinkGenericServiceOperationRequest : LinkGenericServiceOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLinkGenericServiceOperationRequest(MasterPlayerModels.AdminLinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LinkGoogleOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkGoogleRequestData>
        {
            protected override string operationCode => OperationCode.LinkGoogle;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public LinkGoogleOperationRequest(MasterPlayerModels.LinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLinkGoogleOperationRequest : LinkGoogleOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLinkGoogleOperationRequest(MasterPlayerModels.ServerLinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLinkGoogleOperationRequest : LinkGoogleOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLinkGoogleOperationRequest(MasterPlayerModels.AdminLinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LinkGooglePlayGameServiceOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkGooglePlayGameServiceRequestData>
        {
            protected override string operationCode => OperationCode.LinkGooglePlayGameService;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public LinkGooglePlayGameServiceOperationRequest(MasterPlayerModels.LinkGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLinkGooglePlayGameServiceOperationRequest : LinkGooglePlayGameServiceOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLinkGooglePlayGameServiceOperationRequest(MasterPlayerModels.ServerLinkGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLinkGooglePlayGameServiceOperationRequest : LinkGooglePlayGameServiceOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLinkGooglePlayGameServiceOperationRequest(MasterPlayerModels.AdminLinkGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LinkGameCenterOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkGameCenterRequestData>
        {
            protected override string operationCode => OperationCode.LinkGameCenter;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public LinkGameCenterOperationRequest(MasterPlayerModels.LinkGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLinkGameCenterOperationRequest : LinkGameCenterOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLinkGameCenterOperationRequest(MasterPlayerModels.ServerLinkGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLinkGameCenterOperationRequest : LinkGameCenterOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLinkGameCenterOperationRequest(MasterPlayerModels.AdminLinkGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LinkiOSDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkiOSDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.LinkiOSDeviceId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public LinkiOSDeviceIdOperationRequest(MasterPlayerModels.LinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLinkiOSDeviceIdOperationRequest : LinkiOSDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLinkiOSDeviceIdOperationRequest(MasterPlayerModels.ServerLinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLinkiOSDeviceIdOperationRequest : LinkiOSDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLinkiOSDeviceIdOperationRequest(MasterPlayerModels.AdminLinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LinkLinuxDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkLinuxDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.LinkLinuxDeviceId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public LinkLinuxDeviceIdOperationRequest(MasterPlayerModels.LinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLinkLinuxDeviceIdOperationRequest : LinkLinuxDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLinkLinuxDeviceIdOperationRequest(MasterPlayerModels.ServerLinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLinkLinuxDeviceIdOperationRequest : LinkLinuxDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLinkLinuxDeviceIdOperationRequest(MasterPlayerModels.AdminLinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LinkMacOSDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkMacOSDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.LinkMacOSDeviceId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public LinkMacOSDeviceIdOperationRequest(MasterPlayerModels.LinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLinkMacOSDeviceIdOperationRequest : LinkMacOSDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLinkMacOSDeviceIdOperationRequest(MasterPlayerModels.ServerLinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLinkMacOSDeviceIdOperationRequest : LinkMacOSDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLinkMacOSDeviceIdOperationRequest(MasterPlayerModels.AdminLinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LinkWindowsDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkWindowsDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.LinkWindowsDeviceId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public LinkWindowsDeviceIdOperationRequest(MasterPlayerModels.LinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLinkWindowsDeviceIdOperationRequest : LinkWindowsDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLinkWindowsDeviceIdOperationRequest(MasterPlayerModels.ServerLinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLinkWindowsDeviceIdOperationRequest : LinkWindowsDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLinkWindowsDeviceIdOperationRequest(MasterPlayerModels.AdminLinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LinkWindowsPhoneDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkWindowsPhoneDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.LinkWindowsPhoneDeviceId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public LinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.LinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerLinkWindowsPhoneDeviceIdOperationRequest : LinkWindowsPhoneDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerLinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.ServerLinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminLinkWindowsPhoneDeviceIdOperationRequest : LinkWindowsPhoneDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminLinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.AdminLinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveSegmentOperationRequest : CustomOperationRequest<MasterPlayerModels.RemoveSegmentRequestData>
        {
            protected override string operationCode => OperationCode.RemoveSegment;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public RemoveSegmentOperationRequest(MasterPlayerModels.RemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerRemoveSegmentOperationRequest(MasterPlayerModels.ServerRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminRemoveSegmentOperationRequest(MasterPlayerModels.AdminRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveTagOperationRequest : CustomOperationRequest<MasterPlayerModels.RemoveTagRequestData>
        {
            protected override string operationCode => OperationCode.RemoveTag;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public RemoveTagOperationRequest(MasterPlayerModels.RemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerRemoveTagOperationRequest(MasterPlayerModels.ServerRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminRemoveTagOperationRequest(MasterPlayerModels.AdminRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class ResetAccountPasswordOperationRequest : CustomOperationRequest<MasterPlayerModels.ResetAccountPasswordRequestData>
        {
            protected override string operationCode => OperationCode.ResetAccountPassword;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public ResetAccountPasswordOperationRequest(MasterPlayerModels.ResetAccountPasswordRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerResetAccountPasswordOperationRequest : ResetAccountPasswordOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerResetAccountPasswordOperationRequest(MasterPlayerModels.ServerResetAccountPasswordRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminResetAccountPasswordOperationRequest : ResetAccountPasswordOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminResetAccountPasswordOperationRequest(MasterPlayerModels.AdminResetAccountPasswordRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetAvatarOperationRequest : CustomOperationRequest<MasterPlayerModels.SetAvatarRequestData>
        {
            protected override string operationCode => OperationCode.SetAvatar;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetAvatarOperationRequest(MasterPlayerModels.SetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetAvatarOperationRequest(MasterPlayerModels.ServerSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetAvatarOperationRequest(MasterPlayerModels.AdminSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetCountryCodeOperationRequest : CustomOperationRequest<MasterPlayerModels.SetCountryCodeRequestData>
        {
            protected override string operationCode => OperationCode.SetCountryCode;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetCountryCodeOperationRequest(MasterPlayerModels.SetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetCountryCodeOperationRequest : SetCountryCodeOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetCountryCodeOperationRequest(MasterPlayerModels.ServerSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetCountryCodeOperationRequest : SetCountryCodeOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetCountryCodeOperationRequest(MasterPlayerModels.AdminSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetCustomDataOperationRequest : CustomOperationRequest<MasterPlayerModels.SetCustomDataRequestData>
        {
            protected override string operationCode => OperationCode.SetCustomData;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetCustomDataOperationRequest(MasterPlayerModels.SetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetCustomDataOperationRequest(MasterPlayerModels.ServerSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetCustomDataOperationRequest(MasterPlayerModels.AdminSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetDisplayNameOperationRequest : CustomOperationRequest<MasterPlayerModels.SetDisplayNameRequestData>
        {
            protected override string operationCode => OperationCode.SetDisplayName;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetDisplayNameOperationRequest(MasterPlayerModels.SetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetDisplayNameOperationRequest(MasterPlayerModels.ServerSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetDisplayNameOperationRequest(MasterPlayerModels.AdminSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetEmailOperationRequest : CustomOperationRequest<MasterPlayerModels.SetEmailRequestData>
        {
            protected override string operationCode => OperationCode.SetEmail;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetEmailOperationRequest(MasterPlayerModels.SetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetEmailOperationRequest : SetEmailOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetEmailOperationRequest(MasterPlayerModels.ServerSetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetEmailOperationRequest : SetEmailOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetEmailOperationRequest(MasterPlayerModels.AdminSetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetPlayerBanOperationRequest : CustomOperationRequest<MasterPlayerModels.SetPlayerBanRequestData>
        {
            protected override string operationCode => OperationCode.SetPlayerBan;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetPlayerBanOperationRequest(MasterPlayerModels.SetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetPlayerBanOperationRequest : SetPlayerBanOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetPlayerBanOperationRequest(MasterPlayerModels.ServerSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetPlayerBanOperationRequest : SetPlayerBanOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetPlayerBanOperationRequest(MasterPlayerModels.AdminSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class ChangePlayerCurrencyOperationRequest : CustomOperationRequest<MasterPlayerModels.ChangePlayerCurrencyRequestData>
        {
            protected override string operationCode => OperationCode.ChangePlayerCurrency;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public ChangePlayerCurrencyOperationRequest(MasterPlayerModels.ChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerChangePlayerCurrencyOperationRequest : ChangePlayerCurrencyOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerChangePlayerCurrencyOperationRequest(MasterPlayerModels.ServerChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminChangePlayerCurrencyOperationRequest : ChangePlayerCurrencyOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminChangePlayerCurrencyOperationRequest(MasterPlayerModels.AdminChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetPlayerDataOperationRequest : CustomOperationRequest<MasterPlayerModels.SetPlayerDataRequestData>
        {
            protected override string operationCode => OperationCode.SetPlayerData;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetPlayerDataOperationRequest(MasterPlayerModels.SetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetPlayerDataOperationRequest : SetPlayerDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetPlayerDataOperationRequest(MasterPlayerModels.ServerSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetPlayerDataOperationRequest : SetPlayerDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetPlayerDataOperationRequest(MasterPlayerModels.AdminSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class ChangePlayerStatisticsOperationRequest : CustomOperationRequest<MasterPlayerModels.ChangePlayerStatisticsRequestData>
        {
            protected override string operationCode => OperationCode.ChangePlayerStatistics;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public ChangePlayerStatisticsOperationRequest(MasterPlayerModels.ChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerChangePlayerStatisticsOperationRequest : ChangePlayerStatisticsOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerChangePlayerStatisticsOperationRequest(MasterPlayerModels.ServerChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminChangePlayerStatisticsOperationRequest : ChangePlayerStatisticsOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminChangePlayerStatisticsOperationRequest(MasterPlayerModels.AdminChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetTagOperationRequest : CustomOperationRequest<MasterPlayerModels.SetTagRequestData>
        {
            protected override string operationCode => OperationCode.SetTag;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetTagOperationRequest(MasterPlayerModels.SetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetTagOperationRequest : SetTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetTagOperationRequest(MasterPlayerModels.ServerSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetTagOperationRequest : SetTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetTagOperationRequest(MasterPlayerModels.AdminSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetTsLastLoginOperationRequest : CustomOperationRequest<MasterPlayerModels.SetTsLastLoginRequestData>
        {
            protected override string operationCode => OperationCode.SetTsLastLogin;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SetTsLastLoginOperationRequest(MasterPlayerModels.SetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetTsLastLoginOperationRequest : SetTsLastLoginOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetTsLastLoginOperationRequest(MasterPlayerModels.ServerSetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetTsLastLoginOperationRequest : SetTsLastLoginOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetTsLastLoginOperationRequest(MasterPlayerModels.AdminSetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class UnlinkAccountOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkAccountRequestData>
        {
            protected override string operationCode => OperationCode.UnlinkAccount;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public UnlinkAccountOperationRequest(MasterPlayerModels.UnlinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerUnlinkAccountOperationRequest : UnlinkAccountOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerUnlinkAccountOperationRequest(MasterPlayerModels.ServerUnlinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminUnlinkAccountOperationRequest : UnlinkAccountOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminUnlinkAccountOperationRequest(MasterPlayerModels.AdminUnlinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class UnlinkAndroidDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkAndroidDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.UnlinkAndroidDeviceId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public UnlinkAndroidDeviceIdOperationRequest(MasterPlayerModels.UnlinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerUnlinkAndroidDeviceIdOperationRequest : UnlinkAndroidDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerUnlinkAndroidDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminUnlinkAndroidDeviceIdOperationRequest : UnlinkAndroidDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminUnlinkAndroidDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class UnlinkAppleOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkAppleRequestData>
        {
            protected override string operationCode => OperationCode.UnlinkApple;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public UnlinkAppleOperationRequest(MasterPlayerModels.UnlinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerUnlinkAppleOperationRequest : UnlinkAppleOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerUnlinkAppleOperationRequest(MasterPlayerModels.ServerUnlinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminUnlinkAppleOperationRequest : UnlinkAppleOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminUnlinkAppleOperationRequest(MasterPlayerModels.AdminUnlinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class UnlinkCustomDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkCustomDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.UnlinkCustomDeviceId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public UnlinkCustomDeviceIdOperationRequest(MasterPlayerModels.UnlinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerUnlinkCustomDeviceIdOperationRequest : UnlinkCustomDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerUnlinkCustomDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminUnlinkCustomDeviceIdOperationRequest : UnlinkCustomDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminUnlinkCustomDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class UnlinkCustomIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkCustomIdRequestData>
        {
            protected override string operationCode => OperationCode.UnlinkCustomId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public UnlinkCustomIdOperationRequest(MasterPlayerModels.UnlinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerUnlinkCustomIdOperationRequest : UnlinkCustomIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerUnlinkCustomIdOperationRequest(MasterPlayerModels.ServerUnlinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminUnlinkCustomIdOperationRequest : UnlinkCustomIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminUnlinkCustomIdOperationRequest(MasterPlayerModels.AdminUnlinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class UnlinkEditorDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkEditorDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.UnlinkEditorDeviceId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public UnlinkEditorDeviceIdOperationRequest(MasterPlayerModels.UnlinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerUnlinkEditorDeviceIdOperationRequest : UnlinkEditorDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerUnlinkEditorDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminUnlinkEditorDeviceIdOperationRequest : UnlinkEditorDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminUnlinkEditorDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class UnlinkFacebookOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkFacebookRequestData>
        {
            protected override string operationCode => OperationCode.UnlinkFacebook;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public UnlinkFacebookOperationRequest(MasterPlayerModels.UnlinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerUnlinkFacebookOperationRequest : UnlinkFacebookOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerUnlinkFacebookOperationRequest(MasterPlayerModels.ServerUnlinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminUnlinkFacebookOperationRequest : UnlinkFacebookOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminUnlinkFacebookOperationRequest(MasterPlayerModels.AdminUnlinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class UnlinkGenericServiceOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkGenericServiceRequestData>
        {
            protected override string operationCode => OperationCode.UnlinkGenericService;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public UnlinkGenericServiceOperationRequest(MasterPlayerModels.UnlinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerUnlinkGenericServiceOperationRequest : UnlinkGenericServiceOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerUnlinkGenericServiceOperationRequest(MasterPlayerModels.ServerUnlinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminUnlinkGenericServiceOperationRequest : UnlinkGenericServiceOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminUnlinkGenericServiceOperationRequest(MasterPlayerModels.AdminUnlinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class UnlinkGoogleOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkGoogleRequestData>
        {
            protected override string operationCode => OperationCode.UnlinkGoogle;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public UnlinkGoogleOperationRequest(MasterPlayerModels.UnlinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerUnlinkGoogleOperationRequest : UnlinkGoogleOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerUnlinkGoogleOperationRequest(MasterPlayerModels.ServerUnlinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminUnlinkGoogleOperationRequest : UnlinkGoogleOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminUnlinkGoogleOperationRequest(MasterPlayerModels.AdminUnlinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class UnlinkGooglePlayGameServiceOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkGooglePlayGameServiceRequestData>
        {
            protected override string operationCode => OperationCode.UnlinkGooglePlayGameService;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public UnlinkGooglePlayGameServiceOperationRequest(MasterPlayerModels.UnlinkGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerUnlinkGooglePlayGameServiceOperationRequest : UnlinkGooglePlayGameServiceOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerUnlinkGooglePlayGameServiceOperationRequest(MasterPlayerModels.ServerUnlinkGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminUnlinkGooglePlayGameServiceOperationRequest : UnlinkGooglePlayGameServiceOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminUnlinkGooglePlayGameServiceOperationRequest(MasterPlayerModels.AdminUnlinkGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class UnlinkGameCenterOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkGameCenterRequestData>
        {
            protected override string operationCode => OperationCode.UnlinkGameCenter;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public UnlinkGameCenterOperationRequest(MasterPlayerModels.UnlinkGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerUnlinkGameCenterOperationRequest : UnlinkGameCenterOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerUnlinkGameCenterOperationRequest(MasterPlayerModels.ServerUnlinkGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminUnlinkGameCenterOperationRequest : UnlinkGameCenterOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminUnlinkGameCenterOperationRequest(MasterPlayerModels.AdminUnlinkGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class UnlinkiOSDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkiOSDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.UnlinkiOSDeviceId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public UnlinkiOSDeviceIdOperationRequest(MasterPlayerModels.UnlinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerUnlinkiOSDeviceIdOperationRequest : UnlinkiOSDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerUnlinkiOSDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminUnlinkiOSDeviceIdOperationRequest : UnlinkiOSDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminUnlinkiOSDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class UnlinkLinuxDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkLinuxDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.UnlinkLinuxDeviceId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public UnlinkLinuxDeviceIdOperationRequest(MasterPlayerModels.UnlinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerUnlinkLinuxDeviceIdOperationRequest : UnlinkLinuxDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerUnlinkLinuxDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminUnlinkLinuxDeviceIdOperationRequest : UnlinkLinuxDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminUnlinkLinuxDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class UnlinkMacOSDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkMacOSDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.UnlinkMacOSDeviceId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public UnlinkMacOSDeviceIdOperationRequest(MasterPlayerModels.UnlinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerUnlinkMacOSDeviceIdOperationRequest : UnlinkMacOSDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerUnlinkMacOSDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminUnlinkMacOSDeviceIdOperationRequest : UnlinkMacOSDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminUnlinkMacOSDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class UnlinkWindowsDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkWindowsDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.UnlinkWindowsDeviceId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public UnlinkWindowsDeviceIdOperationRequest(MasterPlayerModels.UnlinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerUnlinkWindowsDeviceIdOperationRequest : UnlinkWindowsDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerUnlinkWindowsDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminUnlinkWindowsDeviceIdOperationRequest : UnlinkWindowsDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminUnlinkWindowsDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class UnlinkWindowsPhoneDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkWindowsPhoneDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.UnlinkWindowsPhoneDeviceId;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public UnlinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.UnlinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerUnlinkWindowsPhoneDeviceIdOperationRequest : UnlinkWindowsPhoneDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerUnlinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminUnlinkWindowsPhoneDeviceIdOperationRequest : UnlinkWindowsPhoneDeviceIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminUnlinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCurrencyLeaderboardOperationRequest : CustomOperationRequest<MasterPlayerModels.GetCurrencyLeaderboardRequestData>
        {
            protected override string operationCode => OperationCode.GetCurrencyLeaderboard;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetCurrencyLeaderboardOperationRequest(MasterPlayerModels.GetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCurrencyLeaderboardOperationRequest(MasterPlayerModels.ServerGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCurrencyLeaderboardOperationRequest(MasterPlayerModels.AdminGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetLastLoginLeaderboardOperationRequest : CustomOperationRequest<MasterPlayerModels.GetLastLoginLeaderboardRequestData>
        {
            protected override string operationCode => OperationCode.GetLastLoginLeaderboard;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetLastLoginLeaderboardOperationRequest(MasterPlayerModels.GetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetLastLoginLeaderboardOperationRequest : GetLastLoginLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetLastLoginLeaderboardOperationRequest(MasterPlayerModels.ServerGetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetLastLoginLeaderboardOperationRequest : GetLastLoginLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetLastLoginLeaderboardOperationRequest(MasterPlayerModels.AdminGetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCreateLeaderboardOperationRequest : CustomOperationRequest<MasterPlayerModels.GetCreateLeaderboardRequestData>
        {
            protected override string operationCode => OperationCode.GetCreateLeaderboard;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetCreateLeaderboardOperationRequest(MasterPlayerModels.GetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCreateLeaderboardOperationRequest(MasterPlayerModels.ServerGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCreateLeaderboardOperationRequest(MasterPlayerModels.AdminGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetStatisticsLogOperationRequest : CustomOperationRequest<MasterPlayerModels.GetStatisticsLogRequestData>
        {
            protected override string operationCode => OperationCode.GetStatisticsLog;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetStatisticsLogOperationRequest(MasterPlayerModels.GetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetStatisticsLogOperationRequest(MasterPlayerModels.ServerGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetStatisticsLogOperationRequest(MasterPlayerModels.AdminGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCurrencyLogOperationRequest : CustomOperationRequest<MasterPlayerModels.GetCurrencyLogRequestData>
        {
            protected override string operationCode => OperationCode.GetCurrencyLog;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetCurrencyLogOperationRequest(MasterPlayerModels.GetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCurrencyLogOperationRequest(MasterPlayerModels.ServerGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCurrencyLogOperationRequest(MasterPlayerModels.AdminGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class SendSocketOperationEventOperationRequest : CustomOperationRequest<MasterPlayerModels.SendSocketOperationEventRequestData>
        {
            protected override string operationCode => OperationCode.SendSocketOperationEvent;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SendSocketOperationEventOperationRequest(MasterPlayerModels.SendSocketOperationEventRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSendSocketOperationEventOperationRequest : SendSocketOperationEventOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSendSocketOperationEventOperationRequest(MasterPlayerModels.ServerSendSocketOperationEventRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSendSocketOperationEventOperationRequest : SendSocketOperationEventOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSendSocketOperationEventOperationRequest(MasterPlayerModels.AdminSendSocketOperationEventRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class SendEmailOperationRequest : CustomOperationRequest<MasterPlayerModels.SendEmailRequestData>
        {
            protected override string operationCode => OperationCode.SendEmail;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SendEmailOperationRequest(MasterPlayerModels.SendEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSendEmailOperationRequest : SendEmailOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSendEmailOperationRequest(MasterPlayerModels.SendEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSendEmailOperationRequest : SendEmailOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSendEmailOperationRequest(MasterPlayerModels.AdminSendEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class RemovePushNotificationOperationRequest : CustomOperationRequest<MasterPlayerModels.RemovePushNotificationRequestData>
        {
            protected override string operationCode => OperationCode.RemovePushNotification;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public RemovePushNotificationOperationRequest(MasterPlayerModels.RemovePushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemovePushNotificationOperationRequest : RemovePushNotificationOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerRemovePushNotificationOperationRequest(MasterPlayerModels.RemovePushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemovePushNotificationOperationRequest : RemovePushNotificationOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminRemovePushNotificationOperationRequest(MasterPlayerModels.AdminRemovePushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AddPushNotificationOperationRequest : CustomOperationRequest<MasterPlayerModels.AddPushNotificationRequestData>
        {
            protected override string operationCode => OperationCode.AddPushNotification;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public AddPushNotificationOperationRequest(MasterPlayerModels.AddPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerAddPushNotificationOperationRequest : AddPushNotificationOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerAddPushNotificationOperationRequest(MasterPlayerModels.AddPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminAddPushNotificationOperationRequest : AddPushNotificationOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminAddPushNotificationOperationRequest(MasterPlayerModels.AdminAddPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetPushNotificationOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPushNotificationRequestData>
        {
            protected override string operationCode => OperationCode.GetPushNotification;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public GetPushNotificationOperationRequest(MasterPlayerModels.GetPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetPushNotificationOperationRequest : GetPushNotificationOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetPushNotificationOperationRequest(MasterPlayerModels.GetPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetPushNotificationOperationRequest : GetPushNotificationOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetPushNotificationOperationRequest(MasterPlayerModels.AdminGetPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class SendPushNotificationOperationRequest : CustomOperationRequest<MasterPlayerModels.SendPushNotificationRequestData>
        {
            protected override string operationCode => OperationCode.SendPushNotification;
            protected override RequestType requestType => RequestType.MasterPlayer;
            protected override RequestRole role => RequestRole.Client;

            public SendPushNotificationOperationRequest(MasterPlayerModels.SendPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSendPushNotificationOperationRequest : SendPushNotificationOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSendPushNotificationOperationRequest(MasterPlayerModels.SendPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSendPushNotificationOperationRequest : SendPushNotificationOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSendPushNotificationOperationRequest(MasterPlayerModels.AdminSendPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}
