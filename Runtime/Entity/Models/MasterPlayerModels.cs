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

		public class AdminAddSegmentRequestData : ServerAddSegmentRequestData
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

		public class AdminGetAvatarRequestData : ServerGetAvatarRequestData
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

		public class AdminGetCountryCodeRequestData : ServerGetCountryCodeRequestData
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

		public class AdminGetCustomDataRequestData : ServerGetCustomDataRequestData
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

		public class AdminGetDisplayNameRequestData : ServerGetDisplayNameRequestData
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

		public class AdminGetEmailRequestData : ServerGetEmailRequestData
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

		public class AdminGetExternalRequestData : ServerGetExternalRequestData
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

		public class AdminGetIpAddressCreateRequestData : ServerGetIpAddressCreateRequestData
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

		public class AdminGetPlayerBanRequestData : ServerGetPlayerBanRequestData
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

		public class AdminGetPlayerCurrencyRequestData : ServerGetPlayerCurrencyRequestData
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

		public class AdminGetPlayerDataRequestData : ServerGetPlayerDataRequestData
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

		public class AdminGetPlayerInformationRequestData : ServerGetPlayerInformationRequestData
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

		public class AdminGetPlayerStatisticsRequestData : ServerGetPlayerStatisticsRequestData
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

		public class AdminGetPlayersWithAppleRequestData : ServerGetPlayersWithAppleRequestData
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

		public class AdminGetPlayersWithDisplayNameRequestData : ServerGetPlayersWithDisplayNameRequestData
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

		public class AdminGetPlayersWithFacebookRequestData : ServerGetPlayersWithFacebookRequestData
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

		public class AdminGetPlayersWithGenericServiceRequestData : ServerGetPlayersWithGenericServiceRequestData
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

		public class AdminGetPlayersWithGoogleRequestData : ServerGetPlayersWithGoogleRequestData
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

		public class AdminGetPlayersWithSegmentRequestData : ServerGetPlayersWithSegmentRequestData
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

		public class AdminGetPlayersWithTagRequestData : ServerGetPlayersWithTagRequestData
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

		public class AdminGetSegmentRequestData : ServerGetSegmentRequestData
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

		public class AdminGetStatisticsLeaderboardAroundPlayerRequestData : ServerGetStatisticsLeaderboardAroundPlayerRequestData
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

		public class AdminGetStatisticsLeaderboardRequestData : ServerGetStatisticsLeaderboardRequestData
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

		public class AdminGetTagRequestData : ServerGetTagRequestData
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

		public class AdminGetTsCreateRequestData : ServerGetTsCreateRequestData
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

		public class AdminGetTsLastLoginRequestData : ServerGetTsLastLoginRequestData
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

		public class AdminLinkAccountRequestData : ServerLinkAccountRequestData
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

		public class AdminLinkAndroidDeviceIdRequestData : ServerLinkAndroidDeviceIdRequestData
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

		public class AdminLinkAppleRequestData : ServerLinkAppleRequestData
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

		public class AdminLinkCustomDeviceIdRequestData : ServerLinkCustomDeviceIdRequestData
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

		public class AdminLinkCustomIdRequestData : ServerLinkCustomIdRequestData
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

		public class AdminLinkEditorDeviceIdRequestData : ServerLinkEditorDeviceIdRequestData
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

		public class AdminLinkFacebookRequestData : ServerLinkFacebookRequestData
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

		public class AdminLinkGenericServiceRequestData : ServerLinkGenericServiceRequestData
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

		public class AdminLinkGoogleRequestData : ServerLinkGoogleRequestData
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

		public class AdminLinkiOSDeviceIdRequestData : ServerLinkiOSDeviceIdRequestData
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

		public class AdminLinkLinuxDeviceIdRequestData : ServerLinkLinuxDeviceIdRequestData
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

		public class AdminLinkMacOSDeviceIdRequestData : ServerLinkMacOSDeviceIdRequestData
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

		public class AdminLinkWindowsDeviceIdRequestData : ServerLinkWindowsDeviceIdRequestData
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

		public class AdminLinkWindowsPhoneDeviceIdRequestData : ServerLinkWindowsPhoneDeviceIdRequestData
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

		public class AdminRemoveSegmentRequestData : ServerRemoveSegmentRequestData
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

		public class AdminRemoveTagRequestData : ServerRemoveTagRequestData
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

		public class AdminResetAccountPasswordRequestData : ServerResetAccountPasswordRequestData
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

		public class AdminSetAvatarRequestData : ServerSetAvatarRequestData
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

		public class AdminSetCountryCodeRequestData : ServerSetCountryCodeRequestData
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

		public class AdminSetCustomDataRequestData : ServerSetCustomDataRequestData
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

		public class AdminSetDisplayNameRequestData : ServerSetDisplayNameRequestData
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

		public class AdminSetEmailRequestData : ServerSetEmailRequestData
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

		public class AdminSetPlayerBanRequestData : ServerSetPlayerBanRequestData
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

		public class AdminSetPlayerCurrencyRequestData : ServerSetPlayerCurrencyRequestData
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

		public class AdminSetPlayerDataRequestData : ServerSetPlayerDataRequestData
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

		public class AdminSetPlayerStatisticsRequestData : ServerSetPlayerStatisticsRequestData
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

		public class AdminSetTagRequestData : ServerSetTagRequestData
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

		public class AdminSetTsLastLoginRequestData : ServerSetTsLastLoginRequestData
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

		public class AdminUnlinkAccountRequestData : ServerUnlinkAccountRequestData
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

		public class AdminUnlinkAndroidDeviceIdRequestData : ServerUnlinkAndroidDeviceIdRequestData
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

		public class AdminUnlinkAppleRequestData : ServerUnlinkAppleRequestData
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

		public class AdminUnlinkCustomDeviceIdRequestData : ServerUnlinkCustomDeviceIdRequestData
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

		public class AdminUnlinkCustomIdRequestData : ServerUnlinkCustomIdRequestData
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

		public class AdminUnlinkEditorDeviceIdRequestData : ServerUnlinkEditorDeviceIdRequestData
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

		public class AdminUnlinkFacebookRequestData : ServerUnlinkFacebookRequestData
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

		public class AdminUnlinkGenericServiceRequestData : ServerUnlinkGenericServiceRequestData
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

		public class AdminUnlinkGoogleRequestData : ServerUnlinkGoogleRequestData
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

		public class AdminUnlinkiOSDeviceIdRequestData : ServerUnlinkiOSDeviceIdRequestData
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

		public class AdminUnlinkLinuxDeviceIdRequestData : ServerUnlinkLinuxDeviceIdRequestData
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

		public class AdminUnlinkMacOSDeviceIdRequestData : ServerUnlinkMacOSDeviceIdRequestData
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

		public class AdminUnlinkWindowsDeviceIdRequestData : ServerUnlinkWindowsDeviceIdRequestData
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

		public class AdminUnlinkWindowsPhoneDeviceIdRequestData : ServerUnlinkWindowsPhoneDeviceIdRequestData
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
		public class ExternalItem
		{
			public class Device
			{
				[StringDataMember(code = GNParameterCode.CustomDeviceId, isOptional = true)]
				public string? customDeviceId;

				[StringDataMember(code = GNParameterCode.AndroidDeviceId, isOptional = true)]
				public string? androidDeviceId;

				[StringDataMember(code = GNParameterCode.iOSDeviceId, isOptional = true)]
				public string? iOSDeviceId;

				[StringDataMember(code = GNParameterCode.WindowsPhoneDeviceId, isOptional = true)]
				public string? windowsPhoneDeviceId;

				[StringDataMember(code = GNParameterCode.WindowsDeviceId, isOptional = true)]
				public string? windowsDeviceId;

				[StringDataMember(code = GNParameterCode.LinuxDeviceId, isOptional = true)]
				public string? linuxDeviceId;

				[StringDataMember(code = GNParameterCode.MacOSDeviceId, isOptional = true)]
				public string? macOSDeviceId;

				[StringDataMember(code = GNParameterCode.EditorDeviceId, isOptional = true)]
				public string? editorDeviceId;

			}

			public class Account
			{
				[StringDataMember(code = GNParameterCode.Username, isOptional = true)]
				public string? username;

			}

			public class Custom
			{
				[StringDataMember(code = GNParameterCode.CustomId, isOptional = true)]
				public string? customId;

			}

			public class Apple
			{
				[StringDataMember(code = GNParameterCode.AppleId)]
				public string appleId;

				[StringDataMember(code = GNParameterCode.Email)]
				public string email;

			}

			public class Google
			{
				[StringDataMember(code = GNParameterCode.GoogleId)]
				public string googleId;

				[StringDataMember(code = GNParameterCode.DisplayName)]
				public string displayName;

				[StringDataMember(code = GNParameterCode.Email)]
				public string email;

			}

			public class Facebook
			{
				[StringDataMember(code = GNParameterCode.FacebookId)]
				public string facebookId;

				[StringDataMember(code = GNParameterCode.DisplayName)]
				public string displayName;

				[StringDataMember(code = GNParameterCode.Email)]
				public string email;

			}

			public class GenericService
			{
				[StringDataMember(code = GNParameterCode.ServiceName)]
				public string serviceName;

				[StringDataMember(code = GNParameterCode.ServiceId)]
				public string serviceId;

			}

			[GNHashtableDataMember(code = GNParameterCode.Device, isOptional = true)]
			public Device? device;

			[GNHashtableDataMember(code = GNParameterCode.Account, isOptional = true)]
			public Account? account;

			[GNHashtableDataMember(code = GNParameterCode.Custom, isOptional = true)]
			public Custom? custom;

			[GNHashtableDataMember(code = GNParameterCode.Apple, isOptional = true)]
			public Apple? apple;

			[GNHashtableDataMember(code = GNParameterCode.Google, isOptional = true)]
			public Google? google;

			[GNHashtableDataMember(code = GNParameterCode.Facebook, isOptional = true)]
			public Facebook? facebook;

			[GNArrayDataMember(code = GNParameterCode.GenericService, isOptional = true, elementCls = typeof(GenericService))]
			public List<GenericService> genericServices;

		}

		public class InfoResponseParameters
        {
            [GNHashtableDataMember(code = GNParameterCode.External, isOptional = true)]
			public ExternalItem? external;

			[GNArrayDataMember(code = GNParameterCode.Segments, isOptional = true, elementCls = typeof(string))]
			public List<string>? segments;

			[GNArrayDataMember(code = GNParameterCode.CustomDatas, isOptional = true, elementCls = typeof(GenericModels.DataItem))]
			public List<GenericModels.DataItem>? customDatas;

			[StringDataMember(code = GNParameterCode.DisplayName, isOptional = true)]
			public string? displayName;

			[GNHashtableDataMember(code = GNParameterCode.Avatar, isOptional = true)]
			public GenericModels.AvatarItem? avatar;

			[NumberDataMember(code = GNParameterCode.TsCreate, isOptional = true)]
			public long? tsCreate;

			[GNArrayDataMember(code = GNParameterCode.Tags, isOptional = true, elementCls = typeof(GenericModels.TagItem))]
			public List<GenericModels.TagItem>? tags;

			[GNHashtableDataMember(code = GNParameterCode.PlayerBan, isOptional = true)]
			public GenericModels.BanItem? playerBan;

			[GNArrayDataMember(code = GNParameterCode.PlayerDatas, isOptional = true, elementCls = typeof(GenericModels.DataItem))]
			public List<GenericModels.DataItem>? playerDatas;

			[GNArrayDataMember(code = GNParameterCode.PlayerCurrencies, isOptional = true, elementCls = typeof(GenericModels.CurrencyItem))]
			public List<GenericModels.CurrencyItem>? playerCurrencies;

			[GNArrayDataMember(code = GNParameterCode.PlayerStatistics, isOptional = true, elementCls = typeof(GenericModels.StatisticsItem))]
			public List<GenericModels.StatisticsItem>? playerStatistics;

			[NumberDataMember(code = GNParameterCode.TsLastLogin, isOptional = true)]
			public long? tsLastLogin;

			[StringDataMember(code = GNParameterCode.IpAddressCreate, isOptional = true)]
			public string? ipAddressCreate;

			[StringDataMember(code = GNParameterCode.CountryCode, isOptional = true)]
			public string? countryCode;

			[StringDataMember(code = GNParameterCode.Email, isOptional = true)]
			public string? email;

		}

		public class MasterPlayerResponseData
        {
			[GNHashtableDataMember(code = GNParameterCode.InfoResponseParameters)]
			public InfoResponseParameters infoResponseParameters;

		}

		public class MasterPlayerWithUserIdResponseData : MasterPlayerResponseData
		{
			[StringDataMember(code = GNParameterCode.UserId)]
			public string userId;

		}

		public class MasterPlayerWithAppleIdResponseData : MasterPlayerWithUserIdResponseData
		{
			[StringDataMember(code = GNParameterCode.AppleId)]
			public string appleId;

		}

		public class GetPlayersWithAppleResponseData
        {
			[GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(MasterPlayerWithAppleIdResponseData))]
			public List<MasterPlayerWithAppleIdResponseData> results;

		}

		public class MasterPlayersWithUserIdResponseData
		{
			[GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(MasterPlayerWithUserIdResponseData))]
			public List<MasterPlayerWithUserIdResponseData> results;

		}

		public class MasterPlayerWithFacebookIdResponseData : MasterPlayerWithUserIdResponseData
		{
			[StringDataMember(code = GNParameterCode.FacebookId)]
			public string facebookId;

		}

		public class GetPlayersWithFacebookResponseData
        {
			[GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(MasterPlayerWithFacebookIdResponseData))]
			public List<MasterPlayerWithFacebookIdResponseData> results;

		}

		public class MasterPlayerWithGenericServiceIdResponseData : MasterPlayerWithUserIdResponseData
		{
			[StringDataMember(code = GNParameterCode.ServiceId)]
			public string serviceId;

		}

		public class GetPlayersWithGenericServiceResponseData
		{
			[GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(MasterPlayerWithGenericServiceIdResponseData))]
			public List<MasterPlayerWithGenericServiceIdResponseData> results;

		}

		public class MasterPlayerWithGoogleIdResponseData : MasterPlayerWithUserIdResponseData
		{
			[StringDataMember(code = GNParameterCode.GoogleId)]
			public string googleId;

		}

		public class GetPlayersWithGoogleResponseData
		{
			[GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(MasterPlayerWithGoogleIdResponseData))]
			public List<MasterPlayerWithGoogleIdResponseData> results;

		}

		public class MasterPlayerLeaderboardResponseData : MasterPlayerWithUserIdResponseData
		{
			[NumberDataMember(code = GNParameterCode.Position)]
			public int position;

		}

		public class GetStatisticsLeaderboardResponseData
        {
			[GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(MasterPlayerLeaderboardResponseData))]
			public List<MasterPlayerLeaderboardResponseData> results;

		}

		public class EmptyResponseData
		{

		}

	}

}
