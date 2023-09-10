namespace XmobiTea.GN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;

	public partial class MasterPlayerModels
	{
		public class AddSegmentRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string value;

		}

		public class ServerAddSegmentRequestData : AddSegmentRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminAddSegmentRequestData : AddSegmentRequestData
		{
		}

		public class ChangeAccountPasswordRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.CurrentPassword, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string currentPassword;

			[StringDataMember(code = GNParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string password;

		}

		public class GetAvatarRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

		}

		public class ServerGetAvatarRequestData : GetAvatarRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminGetAvatarRequestData : GetAvatarRequestData
		{
		}

		public class GetCountryCodeRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

		}

		public class ServerGetCountryCodeRequestData : GetCountryCodeRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminGetCountryCodeRequestData : GetCountryCodeRequestData
		{
		}

		public class GetCustomDataRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[GNArrayDataMember(code = GNParameterCode.CustomDataKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? customDataKeys;

		}

		public class ServerGetCustomDataRequestData : GetCustomDataRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminGetCustomDataRequestData : GetCustomDataRequestData
		{
		}

		public class GetDisplayNameRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

		}

		public class ServerGetDisplayNameRequestData : GetDisplayNameRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminGetDisplayNameRequestData : GetDisplayNameRequestData
		{
		}

		public class GetEmailRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

		}

		public class ServerGetEmailRequestData : GetEmailRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminGetEmailRequestData : GetEmailRequestData
		{
		}

		public class GetExternalRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

		}

		public class ServerGetExternalRequestData : GetExternalRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminGetExternalRequestData : GetExternalRequestData
		{
		}

		public class GetIpAddressCreateRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

		}

		public class ServerGetIpAddressCreateRequestData : GetIpAddressCreateRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminGetIpAddressCreateRequestData : GetIpAddressCreateRequestData
		{
		}

		public class GetPlayerBanRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

		}

		public class ServerGetPlayerBanRequestData : GetPlayerBanRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminGetPlayerBanRequestData : GetPlayerBanRequestData
		{
		}

		public class GetPlayerCurrencyRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[GNArrayDataMember(code = GNParameterCode.PlayerCurrencyKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? playerCurrencyKeys;

		}

		public class ServerGetPlayerCurrencyRequestData : GetPlayerCurrencyRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminGetPlayerCurrencyRequestData : GetPlayerCurrencyRequestData
		{
		}

		public class GetPlayerDataRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[GNArrayDataMember(code = GNParameterCode.PlayerDataKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? playerDataKeys;

		}

		public class ServerGetPlayerDataRequestData : GetPlayerDataRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminGetPlayerDataRequestData : GetPlayerDataRequestData
		{
		}

		public class GetPlayerInformationRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class ServerGetPlayerInformationRequestData : GetPlayerInformationRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminGetPlayerInformationRequestData : GetPlayerInformationRequestData
		{
		}

		public class GetPlayerStatisticsRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[GNArrayDataMember(code = GNParameterCode.PlayerStatisticsKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? playerStatisticsKeys;

		}

		public class ServerGetPlayerStatisticsRequestData : GetPlayerStatisticsRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminGetPlayerStatisticsRequestData : GetPlayerStatisticsRequestData
		{
		}

		public class GetPlayersWithAppleRequestData
		{
			[GNArrayDataMember(code = GNParameterCode.AppleIds, mustNonNull = true, elementCls = typeof(string))]
			public List<string> appleIds;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class ServerGetPlayersWithAppleRequestData : GetPlayersWithAppleRequestData
		{
		}

		public class AdminGetPlayersWithAppleRequestData : GetPlayersWithAppleRequestData
		{
		}

		public class GetPlayersWithDisplayNameRequestData
		{
			[StringDataMember(code = GNParameterCode.Keyword, minLength = 2, maxLength = 32)]
			public string keyword;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

			[NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
			public long? skip;

			[NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
			public long? limit;

		}

		public class ServerGetPlayersWithDisplayNameRequestData : GetPlayersWithDisplayNameRequestData
		{
		}

		public class AdminGetPlayersWithDisplayNameRequestData : GetPlayersWithDisplayNameRequestData
		{
		}

		public class GetPlayersWithFacebookRequestData
		{
			[GNArrayDataMember(code = GNParameterCode.FacebookIds, mustNonNull = true, elementCls = typeof(string))]
			public List<string> facebookIds;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class ServerGetPlayersWithFacebookRequestData : GetPlayersWithFacebookRequestData
		{
		}

		public class AdminGetPlayersWithFacebookRequestData : GetPlayersWithFacebookRequestData
		{
		}

		public class GetPlayersWithGenericServiceRequestData
		{
			[StringDataMember(code = GNParameterCode.ServiceName, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string serviceName;

			[GNArrayDataMember(code = GNParameterCode.GenericIds, mustNonNull = true, elementCls = typeof(string))]
			public List<string> genericIds;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class ServerGetPlayersWithGenericServiceRequestData : GetPlayersWithGenericServiceRequestData
		{
		}

		public class AdminGetPlayersWithGenericServiceRequestData : GetPlayersWithGenericServiceRequestData
		{
		}

		public class GetPlayersWithGoogleRequestData
		{
			[GNArrayDataMember(code = GNParameterCode.GoogleIds, mustNonNull = true, elementCls = typeof(string))]
			public List<string> googleIds;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class ServerGetPlayersWithGoogleRequestData : GetPlayersWithGoogleRequestData
		{
		}

		public class AdminGetPlayersWithGoogleRequestData : GetPlayersWithGoogleRequestData
		{
		}

		public class GetPlayersWithSegmentRequestData
		{
			[StringDataMember(code = GNParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string value;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

			[NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
			public long? skip;

			[NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
			public long? limit;

		}

		public class ServerGetPlayersWithSegmentRequestData : GetPlayersWithSegmentRequestData
		{
		}

		public class AdminGetPlayersWithSegmentRequestData : GetPlayersWithSegmentRequestData
		{
		}

		public class GetPlayersWithTagRequestData
		{
			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[StringDataMember(code = GNParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string value;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

			[NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
			public long? skip;

			[NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
			public long? limit;

		}

		public class ServerGetPlayersWithTagRequestData : GetPlayersWithTagRequestData
		{
		}

		public class AdminGetPlayersWithTagRequestData : GetPlayersWithTagRequestData
		{
		}

		public class GetSegmentRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

		}

		public class ServerGetSegmentRequestData : GetSegmentRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminGetSegmentRequestData : GetSegmentRequestData
		{
		}

		public class GetStatisticsLeaderboardAroundPlayerRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

			[NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
			public long? skip;

			[NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
			public long? limit;

		}

		public class ServerGetStatisticsLeaderboardAroundPlayerRequestData : GetStatisticsLeaderboardAroundPlayerRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminGetStatisticsLeaderboardAroundPlayerRequestData : GetStatisticsLeaderboardAroundPlayerRequestData
		{
		}

		public class GetStatisticsLeaderboardRequestData
		{
			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

			[NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
			public long? skip;

			[NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
			public long? limit;

			[BooleanDataMember(code = GNParameterCode.LoadFromCache, defaultValue = true, isOptional = true)]
			public bool? loadFromCache;

		}

		public class ServerGetStatisticsLeaderboardRequestData : GetStatisticsLeaderboardRequestData
		{
		}

		public class AdminGetStatisticsLeaderboardRequestData : GetStatisticsLeaderboardRequestData
		{
		}

		public class GetTagRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[GNArrayDataMember(code = GNParameterCode.TagKeys, elementCls = typeof(string))]
			public List<string> tagKeys;

		}

		public class ServerGetTagRequestData : GetTagRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminGetTagRequestData : GetTagRequestData
		{
		}

		public class GetTsCreateRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

		}

		public class ServerGetTsCreateRequestData : GetTsCreateRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminGetTsCreateRequestData : GetTsCreateRequestData
		{
		}

		public class GetTsLastLoginRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

		}

		public class ServerGetTsLastLoginRequestData : GetTsLastLoginRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminGetTsLastLoginRequestData : GetTsLastLoginRequestData
		{
		}

		public class LinkAccountRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.Username, minLength = 6, maxLength = 32, mustNonNull = true)]
			public string username;

			[StringDataMember(code = GNParameterCode.Username, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string password;

			[BooleanDataMember(code = GNParameterCode.ForceLink, isOptional = true, defaultValue = false)]
			public bool? forceLink;

		}

		public class ServerLinkAccountRequestData : LinkAccountRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminLinkAccountRequestData : LinkAccountRequestData
		{
		}

		public class LinkAndroidDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.AndroidDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string androidDeviceId;

			[BooleanDataMember(code = GNParameterCode.ForceLink, isOptional = true, defaultValue = false)]
			public bool? forceLink;

		}

		public class ServerLinkAndroidDeviceIdRequestData : LinkAndroidDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminLinkAndroidDeviceIdRequestData : LinkAndroidDeviceIdRequestData
		{
		}

		public class LinkAppleRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.Token, minLength = 64, maxLength = 512, mustNonNull = true)]
			public string token;

			[BooleanDataMember(code = GNParameterCode.ForceLink, isOptional = true, defaultValue = false)]
			public bool? forceLink;

		}

		public class ServerLinkAppleRequestData : LinkAppleRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminLinkAppleRequestData : LinkAppleRequestData
		{
		}

		public class LinkCustomDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.CustomDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string customDeviceId;

			[BooleanDataMember(code = GNParameterCode.ForceLink, isOptional = true, defaultValue = false)]
			public bool? forceLink;

		}

		public class ServerLinkCustomDeviceIdRequestData : LinkCustomDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminLinkCustomDeviceIdRequestData : LinkCustomDeviceIdRequestData
		{
		}

		public class LinkCustomIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.CustomId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string customId;

			[BooleanDataMember(code = GNParameterCode.ForceLink, isOptional = true, defaultValue = false)]
			public bool? forceLink;

		}

		public class ServerLinkCustomIdRequestData : LinkCustomIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminLinkCustomIdRequestData : LinkCustomIdRequestData
		{
		}

		public class LinkEditorDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.EditorDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string editorDeviceId;

			[BooleanDataMember(code = GNParameterCode.ForceLink, isOptional = true, defaultValue = false)]
			public bool? forceLink;

		}

		public class ServerLinkEditorDeviceIdRequestData : LinkEditorDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminLinkEditorDeviceIdRequestData : LinkEditorDeviceIdRequestData
		{
		}

		public class LinkFacebookRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.Token, minLength = 64, maxLength = 512, mustNonNull = true)]
			public string token;

			[BooleanDataMember(code = GNParameterCode.ForceLink, isOptional = true, defaultValue = false)]
			public bool? forceLink;

		}

		public class ServerLinkFacebookRequestData : LinkFacebookRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminLinkFacebookRequestData : LinkFacebookRequestData
		{
		}

		public class LinkGenericServiceRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.ServiceName, minLength = 6, maxLength = 32, mustNonNull = true)]
			public string serviceName;

			[StringDataMember(code = GNParameterCode.ServiceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string serviceId;

			[BooleanDataMember(code = GNParameterCode.ForceLink, isOptional = true, defaultValue = false)]
			public bool? forceLink;

		}

		public class ServerLinkGenericServiceRequestData : LinkGenericServiceRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminLinkGenericServiceRequestData : LinkGenericServiceRequestData
		{
		}

		public class LinkGoogleRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.Token, maxLength = 512, minLength = 32, mustNonNull = true)]
			public string token;

			[NumberDataMember(code = GNParameterCode.Type, minValue = 1, maxValue = 2)]
			public double type;

			[BooleanDataMember(code = GNParameterCode.ForceLink, isOptional = true, defaultValue = false)]
			public bool? forceLink;

		}

		public class ServerLinkGoogleRequestData : LinkGoogleRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminLinkGoogleRequestData : LinkGoogleRequestData
		{
		}

		public class LinkiOSDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.iOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string iOSDeviceId;

			[BooleanDataMember(code = GNParameterCode.ForceLink, isOptional = true, defaultValue = false)]
			public bool? forceLink;

		}

		public class ServerLinkiOSDeviceIdRequestData : LinkiOSDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminLinkiOSDeviceIdRequestData : LinkiOSDeviceIdRequestData
		{
		}

		public class LinkLinuxDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.LinuxDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string linuxDeviceId;

			[BooleanDataMember(code = GNParameterCode.ForceLink, isOptional = true, defaultValue = false)]
			public bool? forceLink;

		}

		public class ServerLinkLinuxDeviceIdRequestData : LinkLinuxDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminLinkLinuxDeviceIdRequestData : LinkLinuxDeviceIdRequestData
		{
		}

		public class LinkMacOSDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.MacOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string macOSDeviceId;

			[BooleanDataMember(code = GNParameterCode.ForceLink, isOptional = true, defaultValue = false)]
			public bool? forceLink;

		}

		public class ServerLinkMacOSDeviceIdRequestData : LinkMacOSDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminLinkMacOSDeviceIdRequestData : LinkMacOSDeviceIdRequestData
		{
		}

		public class LinkWindowsDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.WindowsDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string windowsDeviceId;

			[BooleanDataMember(code = GNParameterCode.ForceLink, isOptional = true, defaultValue = false)]
			public bool? forceLink;

		}

		public class ServerLinkWindowsDeviceIdRequestData : LinkWindowsDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminLinkWindowsDeviceIdRequestData : LinkWindowsDeviceIdRequestData
		{
		}

		public class LinkWindowsPhoneDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.WindowsPhoneDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string windowsPhoneDeviceId;

			[BooleanDataMember(code = GNParameterCode.ForceLink, isOptional = true, defaultValue = false)]
			public bool? forceLink;

		}

		public class ServerLinkWindowsPhoneDeviceIdRequestData : LinkWindowsPhoneDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminLinkWindowsPhoneDeviceIdRequestData : LinkWindowsPhoneDeviceIdRequestData
		{
		}

		public class RemoveSegmentRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string value;

		}

		public class ServerRemoveSegmentRequestData : RemoveSegmentRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminRemoveSegmentRequestData : RemoveSegmentRequestData
		{
		}

		public class RemoveTagRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

		}

		public class ServerRemoveTagRequestData : RemoveTagRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminRemoveTagRequestData : RemoveTagRequestData
		{
		}

		public class ResetAccountPasswordRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string userId;

			[StringDataMember(code = GNParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string password;

		}

		public class ServerResetAccountPasswordRequestData : ResetAccountPasswordRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminResetAccountPasswordRequestData : ResetAccountPasswordRequestData
		{
		}

		public class SetAvatarRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string userId;

			[NumberDataMember(code = GNParameterCode.Type, mustInt = true)]
			public long type;

			[StringDataMember(code = GNParameterCode.Value, minLength = 1, maxLength = 128, mustNonNull = true)]
			public string value;

		}

		public class ServerSetAvatarRequestData : SetAvatarRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminSetAvatarRequestData : SetAvatarRequestData
		{
		}

		public class SetCountryCodeRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.CountryCode, minLength = 2, maxLength = 32)]
			public string countryCode;

		}

		public class ServerSetCountryCodeRequestData : SetCountryCodeRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminSetCountryCodeRequestData : SetCountryCodeRequestData
		{
		}

		public class SetCustomDataRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[GNArrayDataMember(code = GNParameterCode.CustomDatas, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(CustomDataParam))]
			public List<CustomDataParam> customData;

		}

		public class ServerSetCustomDataRequestData : SetCustomDataRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminSetCustomDataRequestData : SetCustomDataRequestData
		{
		}

		public class SetDisplayNameRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.DisplayName, minLength = 5, maxLength = 32, mustNonNull = true)]
			public string displayName;

			[BooleanDataMember(code = GNParameterCode.UniqueDisplayName, defaultValue = false, isOptional = true)]
			public bool? uniqueDisplayName;

		}

		public class ServerSetDisplayNameRequestData : SetDisplayNameRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminSetDisplayNameRequestData : SetDisplayNameRequestData
		{
		}

		public class SetEmailRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.Email, minLength = 5, maxLength = 128, mustNonNull = true)]
			public string email;

		}

		public class ServerSetEmailRequestData : SetEmailRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminSetEmailRequestData : SetEmailRequestData
		{
		}

		public class SetPlayerBanRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[NumberDataMember(code = GNParameterCode.TsExpire)]
			public double tsExpire;

			[StringDataMember(code = GNParameterCode.Reason)]
			public string reason;

		}

		public class ServerSetPlayerBanRequestData : SetPlayerBanRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminSetPlayerBanRequestData : SetPlayerBanRequestData
		{
		}

		public class SetPlayerCurrencyRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[GNArrayDataMember(code = GNParameterCode.PlayerCurrencies, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(PlayerCurrencyParam))]
			public List<PlayerCurrencyParam> playerCurrencyParams;

		}

		public class ServerSetPlayerCurrencyRequestData : SetPlayerCurrencyRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminSetPlayerCurrencyRequestData : SetPlayerCurrencyRequestData
		{
		}

		public class SetPlayerDataRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[GNArrayDataMember(code = GNParameterCode.PlayerDatas, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(PlayerDataParam))]
			public List<PlayerDataParam> playerDataParams;

		}

		public class ServerSetPlayerDataRequestData : SetPlayerDataRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminSetPlayerDataRequestData : SetPlayerDataRequestData
		{
		}

		public class SetPlayerStatisticsRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[GNArrayDataMember(code = GNParameterCode.PlayerStatistics, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(PlayerStatisticsParam))]
			public List<PlayerStatisticsParam> playerStatisticsParams;

		}

		public class ServerSetPlayerStatisticsRequestData : SetPlayerStatisticsRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminSetPlayerStatisticsRequestData : SetPlayerStatisticsRequestData
		{
		}

		public class SetTagRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[StringDataMember(code = GNParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string value;

		}

		public class ServerSetTagRequestData : SetTagRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminSetTagRequestData : SetTagRequestData
		{
		}

		public class SetTsLastLoginRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

		}

		public class ServerSetTsLastLoginRequestData : SetTsLastLoginRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminSetTsLastLoginRequestData : SetTsLastLoginRequestData
		{
		}

		public class UnlinkAccountRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.Username, minLength = 6, maxLength = 32, mustNonNull = true)]
			public string username;

		}

		public class ServerUnlinkAccountRequestData : UnlinkAccountRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminUnlinkAccountRequestData : UnlinkAccountRequestData
		{
		}

		public class UnlinkAndroidDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.AndroidDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string androidDeviceId;

		}

		public class ServerUnlinkAndroidDeviceIdRequestData : UnlinkAndroidDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminUnlinkAndroidDeviceIdRequestData : UnlinkAndroidDeviceIdRequestData
		{
		}

		public class UnlinkAppleRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.AppleId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string appleId;

		}

		public class ServerUnlinkAppleRequestData : UnlinkAppleRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminUnlinkAppleRequestData : UnlinkAppleRequestData
		{
		}

		public class UnlinkCustomDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.CustomDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string customDeviceId;

		}

		public class ServerUnlinkCustomDeviceIdRequestData : UnlinkCustomDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminUnlinkCustomDeviceIdRequestData : UnlinkCustomDeviceIdRequestData
		{
		}

		public class UnlinkCustomIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.CustomId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string customId;

		}

		public class ServerUnlinkCustomIdRequestData : UnlinkCustomIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminUnlinkCustomIdRequestData : UnlinkCustomIdRequestData
		{
		}

		public class UnlinkEditorDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.EditorDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string editorDeviceId;

		}

		public class ServerUnlinkEditorDeviceIdRequestData : UnlinkEditorDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminUnlinkEditorDeviceIdRequestData : UnlinkEditorDeviceIdRequestData
		{
		}

		public class UnlinkFacebookRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.FacebookId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string facebookId;

		}

		public class ServerUnlinkFacebookRequestData : UnlinkFacebookRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminUnlinkFacebookRequestData : UnlinkFacebookRequestData
		{
		}

		public class UnlinkGenericServiceRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.ServiceName, minLength = 6, maxLength = 32, mustNonNull = true)]
			public string serviceName;

			[StringDataMember(code = GNParameterCode.ServiceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string serviceId;

		}

		public class ServerUnlinkGenericServiceRequestData : UnlinkGenericServiceRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminUnlinkGenericServiceRequestData : UnlinkGenericServiceRequestData
		{
		}

		public class UnlinkGoogleRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.GoogleId, minLength = 6, maxLength = 32, mustNonNull = true)]
			public string googleId;

		}

		public class ServerUnlinkGoogleRequestData : UnlinkGoogleRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminUnlinkGoogleRequestData : UnlinkGoogleRequestData
		{
		}

		public class UnlinkiOSDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.iOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string iOSDeviceId;

		}

		public class ServerUnlinkiOSDeviceIdRequestData : UnlinkiOSDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminUnlinkiOSDeviceIdRequestData : UnlinkiOSDeviceIdRequestData
		{
		}

		public class UnlinkLinuxDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.LinuxDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string linuxDeviceId;

		}

		public class ServerUnlinkLinuxDeviceIdRequestData : UnlinkLinuxDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminUnlinkLinuxDeviceIdRequestData : UnlinkLinuxDeviceIdRequestData
		{
		}

		public class UnlinkMacOSDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.MacOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string macOSDeviceId;

		}

		public class ServerUnlinkMacOSDeviceIdRequestData : UnlinkMacOSDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminUnlinkMacOSDeviceIdRequestData : UnlinkMacOSDeviceIdRequestData
		{
		}

		public class UnlinkWindowsDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.WindowsDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string windowsDeviceId;

		}

		public class ServerUnlinkWindowsDeviceIdRequestData : UnlinkWindowsDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminUnlinkWindowsDeviceIdRequestData : UnlinkWindowsDeviceIdRequestData
		{
		}

		public class UnlinkWindowsPhoneDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
			public string? userId;

			[StringDataMember(code = GNParameterCode.WindowsPhoneDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string windowsPhoneDeviceId;

		}

		public class ServerUnlinkWindowsPhoneDeviceIdRequestData : UnlinkWindowsPhoneDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public new string userId;

		}

		public class AdminUnlinkWindowsPhoneDeviceIdRequestData : UnlinkWindowsPhoneDeviceIdRequestData
		{
		}

	}

	public partial class MasterPlayerModels
	{
		public class CustomDataParam
		{
			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[DataMember(code = GNParameterCode.Value)]
			public object value;

		}

		public class InfoRequestParam
		{
			[BooleanDataMember(code = GNParameterCode.External, isOptional = true, defaultValue = false)]
			public bool? external;

			[BooleanDataMember(code = GNParameterCode.Segments, isOptional = true, defaultValue = false)]
			public bool? segments;

			[BooleanDataMember(code = GNParameterCode.CustomDatas, isOptional = true, defaultValue = false)]
			public bool? customDatas;

			[BooleanDataMember(code = GNParameterCode.DisplayName, isOptional = true, defaultValue = false)]
			public bool? displayName;

			[BooleanDataMember(code = GNParameterCode.Avatar, isOptional = true, defaultValue = false)]
			public bool? avatar;

			[BooleanDataMember(code = GNParameterCode.TsCreate, isOptional = true, defaultValue = false)]
			public bool? tsCreate;

			[BooleanDataMember(code = GNParameterCode.Tags, isOptional = true, defaultValue = false)]
			public bool? tags;

			[BooleanDataMember(code = GNParameterCode.PlayerBan, isOptional = true, defaultValue = false)]
			public bool? playerBan;

			[BooleanDataMember(code = GNParameterCode.PlayerCurrencies, isOptional = true, defaultValue = false)]
			public bool? playerCurrencies;

			[BooleanDataMember(code = GNParameterCode.PlayerStatistics, isOptional = true, defaultValue = false)]
			public bool? playerStatistics;

			[BooleanDataMember(code = GNParameterCode.PlayerDatas, isOptional = true, defaultValue = false)]
			public bool? playerDatas;

			[BooleanDataMember(code = GNParameterCode.IpAddressCreate, isOptional = true, defaultValue = false)]
			public bool? ipAddressCreate;

			[BooleanDataMember(code = GNParameterCode.CountryCode, isOptional = true, defaultValue = false)]
			public bool? countryCode;

			[BooleanDataMember(code = GNParameterCode.Email, isOptional = true, defaultValue = false)]
			public bool? email;

			[BooleanDataMember(code = GNParameterCode.TsLastLogin, isOptional = true, defaultValue = false)]
			public bool? tsLastLogin;

			[GNArrayDataMember(code = GNParameterCode.PlayerDataKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? playerDataKeys;

			[GNArrayDataMember(code = GNParameterCode.PlayerCurrencyKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? playerCurrencyKeys;

			[GNArrayDataMember(code = GNParameterCode.PlayerStatisticsKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? playerStatisticsKeys;

			[GNArrayDataMember(code = GNParameterCode.CustomDataKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? customDataKeys;

			[GNArrayDataMember(code = GNParameterCode.TagKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? tagKeys;

		}

		public class PlayerCurrencyParam
		{
			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[NumberDataMember(code = GNParameterCode.Amount)]
			public double amount;

		}

		public class PlayerDataParam
		{
			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[DataMember(code = GNParameterCode.Value)]
			public object value;

		}

		public class PlayerStatisticsParam
		{
			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[NumberDataMember(code = GNParameterCode.Value)]
			public double value;

		}

	}

	public partial class MasterPlayerModels
	{

		public class ResponseData
		{

		}

	}

}
