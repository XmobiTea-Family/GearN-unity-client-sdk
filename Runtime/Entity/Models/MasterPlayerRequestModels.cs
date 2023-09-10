namespace XmobiTea.GN.Entity.Models
{
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity.Request;

	public class MasterPlayerRequestModels
	{
		public class AddSegmentOperationRequest : CustomOperationRequest<MasterPlayerModels.AddSegmentRequestData>
		{
			protected override int operationCode => OperationCode.AddSegment;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public AddSegmentOperationRequest(MasterPlayerModels.AddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerAddSegmentOperationRequest : AddSegmentOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerAddSegmentOperationRequest(MasterPlayerModels.ServerAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminAddSegmentOperationRequest : AddSegmentOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminAddSegmentOperationRequest(MasterPlayerModels.AdminAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class ChangeAccountPasswordOperationRequest : CustomOperationRequest<MasterPlayerModels.ChangeAccountPasswordRequestData>
		{
			protected override int operationCode => OperationCode.ChangeAccountPassword;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public ChangeAccountPasswordOperationRequest(MasterPlayerModels.ChangeAccountPasswordRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetAvatarOperationRequest : CustomOperationRequest<MasterPlayerModels.GetAvatarRequestData>
		{
			protected override int operationCode => OperationCode.GetAvatar;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetAvatarOperationRequest(MasterPlayerModels.GetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetAvatarOperationRequest : GetAvatarOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetAvatarOperationRequest(MasterPlayerModels.ServerGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetAvatarOperationRequest : GetAvatarOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetAvatarOperationRequest(MasterPlayerModels.AdminGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetCountryCodeOperationRequest : CustomOperationRequest<MasterPlayerModels.GetCountryCodeRequestData>
		{
			protected override int operationCode => OperationCode.GetCountryCode;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetCountryCodeOperationRequest(MasterPlayerModels.GetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetCountryCodeOperationRequest : GetCountryCodeOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetCountryCodeOperationRequest(MasterPlayerModels.ServerGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetCountryCodeOperationRequest : GetCountryCodeOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetCountryCodeOperationRequest(MasterPlayerModels.AdminGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetCustomDataOperationRequest : CustomOperationRequest<MasterPlayerModels.GetCustomDataRequestData>
		{
			protected override int operationCode => OperationCode.GetCustomData;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetCustomDataOperationRequest(MasterPlayerModels.GetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetCustomDataOperationRequest : GetCustomDataOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetCustomDataOperationRequest(MasterPlayerModels.ServerGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetCustomDataOperationRequest : GetCustomDataOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetCustomDataOperationRequest(MasterPlayerModels.AdminGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetDisplayNameOperationRequest : CustomOperationRequest<MasterPlayerModels.GetDisplayNameRequestData>
		{
			protected override int operationCode => OperationCode.GetDisplayName;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetDisplayNameOperationRequest(MasterPlayerModels.GetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetDisplayNameOperationRequest(MasterPlayerModels.ServerGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetDisplayNameOperationRequest(MasterPlayerModels.AdminGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetEmailOperationRequest : CustomOperationRequest<MasterPlayerModels.GetEmailRequestData>
		{
			protected override int operationCode => OperationCode.GetEmail;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetEmailOperationRequest(MasterPlayerModels.GetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetEmailOperationRequest : GetEmailOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetEmailOperationRequest(MasterPlayerModels.ServerGetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetEmailOperationRequest : GetEmailOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetEmailOperationRequest(MasterPlayerModels.AdminGetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetExternalOperationRequest : CustomOperationRequest<MasterPlayerModels.GetExternalRequestData>
		{
			protected override int operationCode => OperationCode.GetExternal;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetExternalOperationRequest(MasterPlayerModels.GetExternalRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetExternalOperationRequest : GetExternalOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetExternalOperationRequest(MasterPlayerModels.ServerGetExternalRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetExternalOperationRequest : GetExternalOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetExternalOperationRequest(MasterPlayerModels.AdminGetExternalRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetIpAddressCreateOperationRequest : CustomOperationRequest<MasterPlayerModels.GetIpAddressCreateRequestData>
		{
			protected override int operationCode => OperationCode.GetIpAddressCreate;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetIpAddressCreateOperationRequest(MasterPlayerModels.GetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetIpAddressCreateOperationRequest : GetIpAddressCreateOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetIpAddressCreateOperationRequest(MasterPlayerModels.ServerGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetIpAddressCreateOperationRequest : GetIpAddressCreateOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetIpAddressCreateOperationRequest(MasterPlayerModels.AdminGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetPlayerBanOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayerBanRequestData>
		{
			protected override int operationCode => OperationCode.GetPlayerBan;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetPlayerBanOperationRequest(MasterPlayerModels.GetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetPlayerBanOperationRequest : GetPlayerBanOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetPlayerBanOperationRequest(MasterPlayerModels.ServerGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetPlayerBanOperationRequest : GetPlayerBanOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetPlayerBanOperationRequest(MasterPlayerModels.AdminGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetPlayerCurrencyOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayerCurrencyRequestData>
		{
			protected override int operationCode => OperationCode.GetPlayerCurrency;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetPlayerCurrencyOperationRequest(MasterPlayerModels.GetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetPlayerCurrencyOperationRequest : GetPlayerCurrencyOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetPlayerCurrencyOperationRequest(MasterPlayerModels.ServerGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetPlayerCurrencyOperationRequest : GetPlayerCurrencyOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetPlayerCurrencyOperationRequest(MasterPlayerModels.AdminGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetPlayerDataOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayerDataRequestData>
		{
			protected override int operationCode => OperationCode.GetPlayerData;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetPlayerDataOperationRequest(MasterPlayerModels.GetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetPlayerDataOperationRequest : GetPlayerDataOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetPlayerDataOperationRequest(MasterPlayerModels.ServerGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetPlayerDataOperationRequest : GetPlayerDataOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetPlayerDataOperationRequest(MasterPlayerModels.AdminGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetPlayerInformationOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayerInformationRequestData>
		{
			protected override int operationCode => OperationCode.GetPlayerInformation;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetPlayerInformationOperationRequest(MasterPlayerModels.GetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetPlayerInformationOperationRequest : GetPlayerInformationOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetPlayerInformationOperationRequest(MasterPlayerModels.ServerGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetPlayerInformationOperationRequest : GetPlayerInformationOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetPlayerInformationOperationRequest(MasterPlayerModels.AdminGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetPlayerStatisticsOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayerStatisticsRequestData>
		{
			protected override int operationCode => OperationCode.GetPlayerStatistics;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetPlayerStatisticsOperationRequest(MasterPlayerModels.GetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetPlayerStatisticsOperationRequest : GetPlayerStatisticsOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetPlayerStatisticsOperationRequest(MasterPlayerModels.ServerGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetPlayerStatisticsOperationRequest : GetPlayerStatisticsOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetPlayerStatisticsOperationRequest(MasterPlayerModels.AdminGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetPlayersWithAppleOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithAppleRequestData>
		{
			protected override int operationCode => OperationCode.GetPlayersWithApple;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetPlayersWithAppleOperationRequest(MasterPlayerModels.GetPlayersWithAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetPlayersWithAppleOperationRequest : GetPlayersWithAppleOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetPlayersWithAppleOperationRequest(MasterPlayerModels.ServerGetPlayersWithAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetPlayersWithAppleOperationRequest : GetPlayersWithAppleOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetPlayersWithAppleOperationRequest(MasterPlayerModels.AdminGetPlayersWithAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetPlayersWithDisplayNameOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithDisplayNameRequestData>
		{
			protected override int operationCode => OperationCode.GetPlayersWithDisplayName;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetPlayersWithDisplayNameOperationRequest(MasterPlayerModels.GetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetPlayersWithDisplayNameOperationRequest : GetPlayersWithDisplayNameOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetPlayersWithDisplayNameOperationRequest(MasterPlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetPlayersWithDisplayNameOperationRequest : GetPlayersWithDisplayNameOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetPlayersWithDisplayNameOperationRequest(MasterPlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetPlayersWithFacebookOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithFacebookRequestData>
		{
			protected override int operationCode => OperationCode.GetPlayersWithFacebook;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetPlayersWithFacebookOperationRequest(MasterPlayerModels.GetPlayersWithFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetPlayersWithFacebookOperationRequest : GetPlayersWithFacebookOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetPlayersWithFacebookOperationRequest(MasterPlayerModels.ServerGetPlayersWithFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetPlayersWithFacebookOperationRequest : GetPlayersWithFacebookOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetPlayersWithFacebookOperationRequest(MasterPlayerModels.AdminGetPlayersWithFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetPlayersWithGenericServiceOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithGenericServiceRequestData>
		{
			protected override int operationCode => OperationCode.GetPlayersWithGenericService;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetPlayersWithGenericServiceOperationRequest(MasterPlayerModels.GetPlayersWithGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetPlayersWithGenericServiceOperationRequest : GetPlayersWithGenericServiceOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetPlayersWithGenericServiceOperationRequest(MasterPlayerModels.ServerGetPlayersWithGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetPlayersWithGenericServiceOperationRequest : GetPlayersWithGenericServiceOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetPlayersWithGenericServiceOperationRequest(MasterPlayerModels.AdminGetPlayersWithGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetPlayersWithGoogleOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithGoogleRequestData>
		{
			protected override int operationCode => OperationCode.GetPlayersWithGoogle;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetPlayersWithGoogleOperationRequest(MasterPlayerModels.GetPlayersWithGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetPlayersWithGoogleOperationRequest : GetPlayersWithGoogleOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetPlayersWithGoogleOperationRequest(MasterPlayerModels.ServerGetPlayersWithGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetPlayersWithGoogleOperationRequest : GetPlayersWithGoogleOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetPlayersWithGoogleOperationRequest(MasterPlayerModels.AdminGetPlayersWithGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetPlayersWithSegmentOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithSegmentRequestData>
		{
			protected override int operationCode => OperationCode.GetPlayersWithSegment;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetPlayersWithSegmentOperationRequest(MasterPlayerModels.GetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetPlayersWithSegmentOperationRequest : GetPlayersWithSegmentOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetPlayersWithSegmentOperationRequest(MasterPlayerModels.ServerGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetPlayersWithSegmentOperationRequest : GetPlayersWithSegmentOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetPlayersWithSegmentOperationRequest(MasterPlayerModels.AdminGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetPlayersWithTagOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithTagRequestData>
		{
			protected override int operationCode => OperationCode.GetPlayersWithTag;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetPlayersWithTagOperationRequest(MasterPlayerModels.GetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetPlayersWithTagOperationRequest : GetPlayersWithTagOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetPlayersWithTagOperationRequest(MasterPlayerModels.ServerGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetPlayersWithTagOperationRequest : GetPlayersWithTagOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetPlayersWithTagOperationRequest(MasterPlayerModels.AdminGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetSegmentOperationRequest : CustomOperationRequest<MasterPlayerModels.GetSegmentRequestData>
		{
			protected override int operationCode => OperationCode.GetSegment;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetSegmentOperationRequest(MasterPlayerModels.GetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetSegmentOperationRequest : GetSegmentOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetSegmentOperationRequest(MasterPlayerModels.ServerGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetSegmentOperationRequest : GetSegmentOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetSegmentOperationRequest(MasterPlayerModels.AdminGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetStatisticsLeaderboardAroundPlayerOperationRequest : CustomOperationRequest<MasterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData>
		{
			protected override int operationCode => OperationCode.GetStatisticsLeaderboardAroundPlayer;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetStatisticsLeaderboardAroundPlayerOperationRequest(MasterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetStatisticsLeaderboardAroundPlayerOperationRequest : GetStatisticsLeaderboardAroundPlayerOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(MasterPlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetStatisticsLeaderboardAroundPlayerOperationRequest : GetStatisticsLeaderboardAroundPlayerOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(MasterPlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetStatisticsLeaderboardOperationRequest : CustomOperationRequest<MasterPlayerModels.GetStatisticsLeaderboardRequestData>
		{
			protected override int operationCode => OperationCode.GetStatisticsLeaderboard;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetStatisticsLeaderboardOperationRequest(MasterPlayerModels.GetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetStatisticsLeaderboardOperationRequest(MasterPlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetStatisticsLeaderboardOperationRequest(MasterPlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetTagOperationRequest : CustomOperationRequest<MasterPlayerModels.GetTagRequestData>
		{
			protected override int operationCode => OperationCode.GetTag;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetTagOperationRequest(MasterPlayerModels.GetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetTagOperationRequest : GetTagOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetTagOperationRequest(MasterPlayerModels.ServerGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetTagOperationRequest : GetTagOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetTagOperationRequest(MasterPlayerModels.AdminGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetTsCreateOperationRequest : CustomOperationRequest<MasterPlayerModels.GetTsCreateRequestData>
		{
			protected override int operationCode => OperationCode.GetTsCreate;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetTsCreateOperationRequest(MasterPlayerModels.GetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetTsCreateOperationRequest : GetTsCreateOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetTsCreateOperationRequest(MasterPlayerModels.ServerGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetTsCreateOperationRequest : GetTsCreateOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetTsCreateOperationRequest(MasterPlayerModels.AdminGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetTsLastLoginOperationRequest : CustomOperationRequest<MasterPlayerModels.GetTsLastLoginRequestData>
		{
			protected override int operationCode => OperationCode.GetTsLastLogin;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetTsLastLoginOperationRequest(MasterPlayerModels.GetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetTsLastLoginOperationRequest : GetTsLastLoginOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetTsLastLoginOperationRequest(MasterPlayerModels.ServerGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetTsLastLoginOperationRequest : GetTsLastLoginOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetTsLastLoginOperationRequest(MasterPlayerModels.AdminGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LinkAccountOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkAccountRequestData>
		{
			protected override int operationCode => OperationCode.LinkAccount;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public LinkAccountOperationRequest(MasterPlayerModels.LinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerLinkAccountOperationRequest : LinkAccountOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerLinkAccountOperationRequest(MasterPlayerModels.ServerLinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminLinkAccountOperationRequest : LinkAccountOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminLinkAccountOperationRequest(MasterPlayerModels.AdminLinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LinkAndroidDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkAndroidDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.LinkAndroidDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public LinkAndroidDeviceIdOperationRequest(MasterPlayerModels.LinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerLinkAndroidDeviceIdOperationRequest : LinkAndroidDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerLinkAndroidDeviceIdOperationRequest(MasterPlayerModels.ServerLinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminLinkAndroidDeviceIdOperationRequest : LinkAndroidDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminLinkAndroidDeviceIdOperationRequest(MasterPlayerModels.AdminLinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LinkAppleOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkAppleRequestData>
		{
			protected override int operationCode => OperationCode.LinkApple;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public LinkAppleOperationRequest(MasterPlayerModels.LinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerLinkAppleOperationRequest : LinkAppleOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerLinkAppleOperationRequest(MasterPlayerModels.ServerLinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminLinkAppleOperationRequest : LinkAppleOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminLinkAppleOperationRequest(MasterPlayerModels.AdminLinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LinkCustomDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkCustomDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.LinkCustomDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public LinkCustomDeviceIdOperationRequest(MasterPlayerModels.LinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerLinkCustomDeviceIdOperationRequest : LinkCustomDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerLinkCustomDeviceIdOperationRequest(MasterPlayerModels.ServerLinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminLinkCustomDeviceIdOperationRequest : LinkCustomDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminLinkCustomDeviceIdOperationRequest(MasterPlayerModels.AdminLinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LinkCustomIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkCustomIdRequestData>
		{
			protected override int operationCode => OperationCode.LinkCustomId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public LinkCustomIdOperationRequest(MasterPlayerModels.LinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerLinkCustomIdOperationRequest : LinkCustomIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerLinkCustomIdOperationRequest(MasterPlayerModels.ServerLinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminLinkCustomIdOperationRequest : LinkCustomIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminLinkCustomIdOperationRequest(MasterPlayerModels.AdminLinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LinkEditorDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkEditorDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.LinkEditorDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public LinkEditorDeviceIdOperationRequest(MasterPlayerModels.LinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerLinkEditorDeviceIdOperationRequest : LinkEditorDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerLinkEditorDeviceIdOperationRequest(MasterPlayerModels.ServerLinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminLinkEditorDeviceIdOperationRequest : LinkEditorDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminLinkEditorDeviceIdOperationRequest(MasterPlayerModels.AdminLinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LinkFacebookOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkFacebookRequestData>
		{
			protected override int operationCode => OperationCode.LinkFacebook;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public LinkFacebookOperationRequest(MasterPlayerModels.LinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerLinkFacebookOperationRequest : LinkFacebookOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerLinkFacebookOperationRequest(MasterPlayerModels.ServerLinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminLinkFacebookOperationRequest : LinkFacebookOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminLinkFacebookOperationRequest(MasterPlayerModels.AdminLinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LinkGenericServiceOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkGenericServiceRequestData>
		{
			protected override int operationCode => OperationCode.LinkGenericService;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public LinkGenericServiceOperationRequest(MasterPlayerModels.LinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerLinkGenericServiceOperationRequest : LinkGenericServiceOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerLinkGenericServiceOperationRequest(MasterPlayerModels.ServerLinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminLinkGenericServiceOperationRequest : LinkGenericServiceOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminLinkGenericServiceOperationRequest(MasterPlayerModels.AdminLinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LinkGoogleOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkGoogleRequestData>
		{
			protected override int operationCode => OperationCode.LinkGoogle;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public LinkGoogleOperationRequest(MasterPlayerModels.LinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerLinkGoogleOperationRequest : LinkGoogleOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerLinkGoogleOperationRequest(MasterPlayerModels.ServerLinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminLinkGoogleOperationRequest : LinkGoogleOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminLinkGoogleOperationRequest(MasterPlayerModels.AdminLinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LinkiOSDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkiOSDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.LinkiOSDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public LinkiOSDeviceIdOperationRequest(MasterPlayerModels.LinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerLinkiOSDeviceIdOperationRequest : LinkiOSDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerLinkiOSDeviceIdOperationRequest(MasterPlayerModels.ServerLinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminLinkiOSDeviceIdOperationRequest : LinkiOSDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminLinkiOSDeviceIdOperationRequest(MasterPlayerModels.AdminLinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LinkLinuxDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkLinuxDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.LinkLinuxDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public LinkLinuxDeviceIdOperationRequest(MasterPlayerModels.LinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerLinkLinuxDeviceIdOperationRequest : LinkLinuxDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerLinkLinuxDeviceIdOperationRequest(MasterPlayerModels.ServerLinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminLinkLinuxDeviceIdOperationRequest : LinkLinuxDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminLinkLinuxDeviceIdOperationRequest(MasterPlayerModels.AdminLinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LinkMacOSDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkMacOSDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.LinkMacOSDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public LinkMacOSDeviceIdOperationRequest(MasterPlayerModels.LinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerLinkMacOSDeviceIdOperationRequest : LinkMacOSDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerLinkMacOSDeviceIdOperationRequest(MasterPlayerModels.ServerLinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminLinkMacOSDeviceIdOperationRequest : LinkMacOSDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminLinkMacOSDeviceIdOperationRequest(MasterPlayerModels.AdminLinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LinkWindowsDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkWindowsDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.LinkWindowsDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public LinkWindowsDeviceIdOperationRequest(MasterPlayerModels.LinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerLinkWindowsDeviceIdOperationRequest : LinkWindowsDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerLinkWindowsDeviceIdOperationRequest(MasterPlayerModels.ServerLinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminLinkWindowsDeviceIdOperationRequest : LinkWindowsDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminLinkWindowsDeviceIdOperationRequest(MasterPlayerModels.AdminLinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LinkWindowsPhoneDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkWindowsPhoneDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.LinkWindowsPhoneDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public LinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.LinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerLinkWindowsPhoneDeviceIdOperationRequest : LinkWindowsPhoneDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerLinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.ServerLinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminLinkWindowsPhoneDeviceIdOperationRequest : LinkWindowsPhoneDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminLinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.AdminLinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class RemoveSegmentOperationRequest : CustomOperationRequest<MasterPlayerModels.RemoveSegmentRequestData>
		{
			protected override int operationCode => OperationCode.RemoveSegment;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public RemoveSegmentOperationRequest(MasterPlayerModels.RemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerRemoveSegmentOperationRequest(MasterPlayerModels.ServerRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminRemoveSegmentOperationRequest(MasterPlayerModels.AdminRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class RemoveTagOperationRequest : CustomOperationRequest<MasterPlayerModels.RemoveTagRequestData>
		{
			protected override int operationCode => OperationCode.RemoveTag;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public RemoveTagOperationRequest(MasterPlayerModels.RemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerRemoveTagOperationRequest : RemoveTagOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerRemoveTagOperationRequest(MasterPlayerModels.ServerRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminRemoveTagOperationRequest : RemoveTagOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminRemoveTagOperationRequest(MasterPlayerModels.AdminRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class ResetAccountPasswordOperationRequest : CustomOperationRequest<MasterPlayerModels.ResetAccountPasswordRequestData>
		{
			protected override int operationCode => OperationCode.ResetAccountPassword;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public ResetAccountPasswordOperationRequest(MasterPlayerModels.ResetAccountPasswordRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerResetAccountPasswordOperationRequest : ResetAccountPasswordOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerResetAccountPasswordOperationRequest(MasterPlayerModels.ServerResetAccountPasswordRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminResetAccountPasswordOperationRequest : ResetAccountPasswordOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminResetAccountPasswordOperationRequest(MasterPlayerModels.AdminResetAccountPasswordRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetAvatarOperationRequest : CustomOperationRequest<MasterPlayerModels.SetAvatarRequestData>
		{
			protected override int operationCode => OperationCode.SetAvatar;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetAvatarOperationRequest(MasterPlayerModels.SetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerSetAvatarOperationRequest : SetAvatarOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerSetAvatarOperationRequest(MasterPlayerModels.ServerSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminSetAvatarOperationRequest : SetAvatarOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminSetAvatarOperationRequest(MasterPlayerModels.AdminSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetCountryCodeOperationRequest : CustomOperationRequest<MasterPlayerModels.SetCountryCodeRequestData>
		{
			protected override int operationCode => OperationCode.SetCountryCode;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetCountryCodeOperationRequest(MasterPlayerModels.SetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerSetCountryCodeOperationRequest : SetCountryCodeOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerSetCountryCodeOperationRequest(MasterPlayerModels.ServerSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminSetCountryCodeOperationRequest : SetCountryCodeOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminSetCountryCodeOperationRequest(MasterPlayerModels.AdminSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetCustomDataOperationRequest : CustomOperationRequest<MasterPlayerModels.SetCustomDataRequestData>
		{
			protected override int operationCode => OperationCode.SetCustomData;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetCustomDataOperationRequest(MasterPlayerModels.SetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerSetCustomDataOperationRequest : SetCustomDataOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerSetCustomDataOperationRequest(MasterPlayerModels.ServerSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminSetCustomDataOperationRequest : SetCustomDataOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminSetCustomDataOperationRequest(MasterPlayerModels.AdminSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetDisplayNameOperationRequest : CustomOperationRequest<MasterPlayerModels.SetDisplayNameRequestData>
		{
			protected override int operationCode => OperationCode.SetDisplayName;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetDisplayNameOperationRequest(MasterPlayerModels.SetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerSetDisplayNameOperationRequest(MasterPlayerModels.ServerSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminSetDisplayNameOperationRequest(MasterPlayerModels.AdminSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetEmailOperationRequest : CustomOperationRequest<MasterPlayerModels.SetEmailRequestData>
		{
			protected override int operationCode => OperationCode.SetEmail;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetEmailOperationRequest(MasterPlayerModels.SetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerSetEmailOperationRequest : SetEmailOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerSetEmailOperationRequest(MasterPlayerModels.ServerSetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminSetEmailOperationRequest : SetEmailOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminSetEmailOperationRequest(MasterPlayerModels.AdminSetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetPlayerBanOperationRequest : CustomOperationRequest<MasterPlayerModels.SetPlayerBanRequestData>
		{
			protected override int operationCode => OperationCode.SetPlayerBan;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetPlayerBanOperationRequest(MasterPlayerModels.SetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerSetPlayerBanOperationRequest : SetPlayerBanOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerSetPlayerBanOperationRequest(MasterPlayerModels.ServerSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminSetPlayerBanOperationRequest : SetPlayerBanOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminSetPlayerBanOperationRequest(MasterPlayerModels.AdminSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetPlayerCurrencyOperationRequest : CustomOperationRequest<MasterPlayerModels.SetPlayerCurrencyRequestData>
		{
			protected override int operationCode => OperationCode.SetPlayerCurrency;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetPlayerCurrencyOperationRequest(MasterPlayerModels.SetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerSetPlayerCurrencyOperationRequest : SetPlayerCurrencyOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerSetPlayerCurrencyOperationRequest(MasterPlayerModels.ServerSetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminSetPlayerCurrencyOperationRequest : SetPlayerCurrencyOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminSetPlayerCurrencyOperationRequest(MasterPlayerModels.AdminSetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetPlayerDataOperationRequest : CustomOperationRequest<MasterPlayerModels.SetPlayerDataRequestData>
		{
			protected override int operationCode => OperationCode.SetPlayerData;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetPlayerDataOperationRequest(MasterPlayerModels.SetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerSetPlayerDataOperationRequest : SetPlayerDataOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerSetPlayerDataOperationRequest(MasterPlayerModels.ServerSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminSetPlayerDataOperationRequest : SetPlayerDataOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminSetPlayerDataOperationRequest(MasterPlayerModels.AdminSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetPlayerStatisticsOperationRequest : CustomOperationRequest<MasterPlayerModels.SetPlayerStatisticsRequestData>
		{
			protected override int operationCode => OperationCode.SetPlayerStatistics;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetPlayerStatisticsOperationRequest(MasterPlayerModels.SetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerSetPlayerStatisticsOperationRequest : SetPlayerStatisticsOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerSetPlayerStatisticsOperationRequest(MasterPlayerModels.ServerSetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminSetPlayerStatisticsOperationRequest : SetPlayerStatisticsOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminSetPlayerStatisticsOperationRequest(MasterPlayerModels.AdminSetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetTagOperationRequest : CustomOperationRequest<MasterPlayerModels.SetTagRequestData>
		{
			protected override int operationCode => OperationCode.SetTag;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetTagOperationRequest(MasterPlayerModels.SetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerSetTagOperationRequest : SetTagOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerSetTagOperationRequest(MasterPlayerModels.ServerSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminSetTagOperationRequest : SetTagOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminSetTagOperationRequest(MasterPlayerModels.AdminSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetTsLastLoginOperationRequest : CustomOperationRequest<MasterPlayerModels.SetTsLastLoginRequestData>
		{
			protected override int operationCode => OperationCode.SetTsLastLogin;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetTsLastLoginOperationRequest(MasterPlayerModels.SetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerSetTsLastLoginOperationRequest : SetTsLastLoginOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerSetTsLastLoginOperationRequest(MasterPlayerModels.ServerSetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminSetTsLastLoginOperationRequest : SetTsLastLoginOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminSetTsLastLoginOperationRequest(MasterPlayerModels.AdminSetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class UnlinkAccountOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkAccountRequestData>
		{
			protected override int operationCode => OperationCode.UnlinkAccount;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public UnlinkAccountOperationRequest(MasterPlayerModels.UnlinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerUnlinkAccountOperationRequest : UnlinkAccountOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerUnlinkAccountOperationRequest(MasterPlayerModels.ServerUnlinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminUnlinkAccountOperationRequest : UnlinkAccountOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminUnlinkAccountOperationRequest(MasterPlayerModels.AdminUnlinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class UnlinkAndroidDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkAndroidDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.UnlinkAndroidDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public UnlinkAndroidDeviceIdOperationRequest(MasterPlayerModels.UnlinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerUnlinkAndroidDeviceIdOperationRequest : UnlinkAndroidDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerUnlinkAndroidDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminUnlinkAndroidDeviceIdOperationRequest : UnlinkAndroidDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminUnlinkAndroidDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class UnlinkAppleOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkAppleRequestData>
		{
			protected override int operationCode => OperationCode.UnlinkApple;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public UnlinkAppleOperationRequest(MasterPlayerModels.UnlinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerUnlinkAppleOperationRequest : UnlinkAppleOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerUnlinkAppleOperationRequest(MasterPlayerModels.ServerUnlinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminUnlinkAppleOperationRequest : UnlinkAppleOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminUnlinkAppleOperationRequest(MasterPlayerModels.AdminUnlinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class UnlinkCustomDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkCustomDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.UnlinkCustomDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public UnlinkCustomDeviceIdOperationRequest(MasterPlayerModels.UnlinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerUnlinkCustomDeviceIdOperationRequest : UnlinkCustomDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerUnlinkCustomDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminUnlinkCustomDeviceIdOperationRequest : UnlinkCustomDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminUnlinkCustomDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class UnlinkCustomIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkCustomIdRequestData>
		{
			protected override int operationCode => OperationCode.UnlinkCustomId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public UnlinkCustomIdOperationRequest(MasterPlayerModels.UnlinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerUnlinkCustomIdOperationRequest : UnlinkCustomIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerUnlinkCustomIdOperationRequest(MasterPlayerModels.ServerUnlinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminUnlinkCustomIdOperationRequest : UnlinkCustomIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminUnlinkCustomIdOperationRequest(MasterPlayerModels.AdminUnlinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class UnlinkEditorDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkEditorDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.UnlinkEditorDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public UnlinkEditorDeviceIdOperationRequest(MasterPlayerModels.UnlinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerUnlinkEditorDeviceIdOperationRequest : UnlinkEditorDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerUnlinkEditorDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminUnlinkEditorDeviceIdOperationRequest : UnlinkEditorDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminUnlinkEditorDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class UnlinkFacebookOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkFacebookRequestData>
		{
			protected override int operationCode => OperationCode.UnlinkFacebook;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public UnlinkFacebookOperationRequest(MasterPlayerModels.UnlinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerUnlinkFacebookOperationRequest : UnlinkFacebookOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerUnlinkFacebookOperationRequest(MasterPlayerModels.ServerUnlinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminUnlinkFacebookOperationRequest : UnlinkFacebookOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminUnlinkFacebookOperationRequest(MasterPlayerModels.AdminUnlinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class UnlinkGenericServiceOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkGenericServiceRequestData>
		{
			protected override int operationCode => OperationCode.UnlinkGenericService;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public UnlinkGenericServiceOperationRequest(MasterPlayerModels.UnlinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerUnlinkGenericServiceOperationRequest : UnlinkGenericServiceOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerUnlinkGenericServiceOperationRequest(MasterPlayerModels.ServerUnlinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminUnlinkGenericServiceOperationRequest : UnlinkGenericServiceOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminUnlinkGenericServiceOperationRequest(MasterPlayerModels.AdminUnlinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class UnlinkGoogleOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkGoogleRequestData>
		{
			protected override int operationCode => OperationCode.UnlinkGoogle;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public UnlinkGoogleOperationRequest(MasterPlayerModels.UnlinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerUnlinkGoogleOperationRequest : UnlinkGoogleOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerUnlinkGoogleOperationRequest(MasterPlayerModels.ServerUnlinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminUnlinkGoogleOperationRequest : UnlinkGoogleOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminUnlinkGoogleOperationRequest(MasterPlayerModels.AdminUnlinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class UnlinkiOSDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkiOSDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.UnlinkiOSDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public UnlinkiOSDeviceIdOperationRequest(MasterPlayerModels.UnlinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerUnlinkiOSDeviceIdOperationRequest : UnlinkiOSDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerUnlinkiOSDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminUnlinkiOSDeviceIdOperationRequest : UnlinkiOSDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminUnlinkiOSDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class UnlinkLinuxDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkLinuxDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.UnlinkLinuxDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public UnlinkLinuxDeviceIdOperationRequest(MasterPlayerModels.UnlinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerUnlinkLinuxDeviceIdOperationRequest : UnlinkLinuxDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerUnlinkLinuxDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminUnlinkLinuxDeviceIdOperationRequest : UnlinkLinuxDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminUnlinkLinuxDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class UnlinkMacOSDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkMacOSDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.UnlinkMacOSDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public UnlinkMacOSDeviceIdOperationRequest(MasterPlayerModels.UnlinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerUnlinkMacOSDeviceIdOperationRequest : UnlinkMacOSDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerUnlinkMacOSDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminUnlinkMacOSDeviceIdOperationRequest : UnlinkMacOSDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminUnlinkMacOSDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class UnlinkWindowsDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkWindowsDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.UnlinkWindowsDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public UnlinkWindowsDeviceIdOperationRequest(MasterPlayerModels.UnlinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerUnlinkWindowsDeviceIdOperationRequest : UnlinkWindowsDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerUnlinkWindowsDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminUnlinkWindowsDeviceIdOperationRequest : UnlinkWindowsDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminUnlinkWindowsDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class UnlinkWindowsPhoneDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkWindowsPhoneDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.UnlinkWindowsPhoneDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.MasterPlayer;
			protected override RequestRole requestRole => RequestRole.Client;

			public UnlinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.UnlinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerUnlinkWindowsPhoneDeviceIdOperationRequest : UnlinkWindowsPhoneDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerUnlinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminUnlinkWindowsPhoneDeviceIdOperationRequest : UnlinkWindowsPhoneDeviceIdOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminUnlinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


	}

}
