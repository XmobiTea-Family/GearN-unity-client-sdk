namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;

    public partial class MasterPlayerModels
    {
        public class AddSegmentRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string value;

        }

        public class ServerAddSegmentRequestData : AddSegmentRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminAddSegmentRequestData : ServerAddSegmentRequestData
        {
        }

        public class ChangeAccountPasswordRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.CurrentPassword, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string currentPassword;

            [StringDataMember(code = ParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

        }

        public class GetAvatarRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        public class ServerGetAvatarRequestData : GetAvatarRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetAvatarRequestData : ServerGetAvatarRequestData
        {
        }

        public class GetCountryCodeRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        public class ServerGetCountryCodeRequestData : GetCountryCodeRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetCountryCodeRequestData : ServerGetCountryCodeRequestData
        {
        }

        public class GetCustomDataRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = ParameterCode.CustomDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? customDataKeys;

        }

        public class ServerGetCustomDataRequestData : GetCustomDataRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetCustomDataRequestData : ServerGetCustomDataRequestData
        {
        }

        public class GetDisplayNameRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        public class ServerGetDisplayNameRequestData : GetDisplayNameRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetDisplayNameRequestData : ServerGetDisplayNameRequestData
        {
        }

        public class GetEmailRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        public class ServerGetEmailRequestData : GetEmailRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetEmailRequestData : ServerGetEmailRequestData
        {
        }

        public class GetExternalRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        public class ServerGetExternalRequestData : GetExternalRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetExternalRequestData : ServerGetExternalRequestData
        {
        }

        public class GetIpAddressCreateRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        public class ServerGetIpAddressCreateRequestData : GetIpAddressCreateRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetIpAddressCreateRequestData : ServerGetIpAddressCreateRequestData
        {
        }

        public class GetPlayerBanRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        public class ServerGetPlayerBanRequestData : GetPlayerBanRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetPlayerBanRequestData : ServerGetPlayerBanRequestData
        {
        }

        public class GetPlayerCurrencyRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = ParameterCode.PlayerCurrencyKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerCurrencyKeys;

        }

        public class ServerGetPlayerCurrencyRequestData : GetPlayerCurrencyRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetPlayerCurrencyRequestData : ServerGetPlayerCurrencyRequestData
        {
        }

        public class GetPlayerDataRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = ParameterCode.PlayerDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerDataKeys;

        }

        public class ServerGetPlayerDataRequestData : GetPlayerDataRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetPlayerDataRequestData : ServerGetPlayerDataRequestData
        {
        }

        public class GetPlayerInformationRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class ServerGetPlayerInformationRequestData : GetPlayerInformationRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetPlayerInformationRequestData : ServerGetPlayerInformationRequestData
        {
        }

        public class GetPlayerStatisticsRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = ParameterCode.PlayerStatisticsKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerStatisticsKeys;

        }

        public class ServerGetPlayerStatisticsRequestData : GetPlayerStatisticsRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetPlayerStatisticsRequestData : ServerGetPlayerStatisticsRequestData
        {
        }

        public class GetPlayersWithAppleRequestData
        {
            [GNArrayDataMember(code = ParameterCode.AppleIds, mustNonNull = true, elementCls = typeof(string))]
            public List<string> appleIds;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.Keyword, minLength = 2, maxLength = 32)]
            public string keyword;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

        }

        public class ServerGetPlayersWithDisplayNameRequestData : GetPlayersWithDisplayNameRequestData
        {
        }

        public class AdminGetPlayersWithDisplayNameRequestData : ServerGetPlayersWithDisplayNameRequestData
        {
        }

        public class GetPlayersWithFacebookRequestData
        {
            [GNArrayDataMember(code = ParameterCode.FacebookIds, mustNonNull = true, elementCls = typeof(string))]
            public List<string> facebookIds;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.ServiceName, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string serviceName;

            [GNArrayDataMember(code = ParameterCode.GenericIds, mustNonNull = true, elementCls = typeof(string))]
            public List<string> genericIds;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
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
            [GNArrayDataMember(code = ParameterCode.GoogleIds, mustNonNull = true, elementCls = typeof(string))]
            public List<string> googleIds;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class ServerGetPlayersWithGoogleRequestData : GetPlayersWithGoogleRequestData
        {
        }

        public class AdminGetPlayersWithGoogleRequestData : ServerGetPlayersWithGoogleRequestData
        {
        }

        public class GetPlayersWithGooglePlayGameServiceRequestData
        {
            [GNArrayDataMember(code = ParameterCode.PlayerIds, mustNonNull = true, elementCls = typeof(string))]
            public List<string> playerIds;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class ServerGetPlayersWithGooglePlayGameServiceRequestData : GetPlayersWithGooglePlayGameServiceRequestData
        {
        }

        public class AdminGetPlayersWithGooglePlayGameServiceRequestData : ServerGetPlayersWithGooglePlayGameServiceRequestData
        {
        }

        public class GetPlayersWithGameCenterRequestData
        {
            [GNArrayDataMember(code = ParameterCode.PlayerIds, mustNonNull = true, elementCls = typeof(string))]
            public List<string> playerIds;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class ServerGetPlayersWithGameCenterRequestData : GetPlayersWithGameCenterRequestData
        {
        }

        public class AdminGetPlayersWithGameCenterRequestData : ServerGetPlayersWithGameCenterRequestData
        {
        }

        public class GetPlayersWithSegmentRequestData
        {
            [StringDataMember(code = ParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string value;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

        }

        public class ServerGetPlayersWithSegmentRequestData : GetPlayersWithSegmentRequestData
        {
        }

        public class AdminGetPlayersWithSegmentRequestData : ServerGetPlayersWithSegmentRequestData
        {
        }

        public class GetPlayersWithTagRequestData
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [StringDataMember(code = ParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string value;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

        }

        public class ServerGetPlayersWithTagRequestData : GetPlayersWithTagRequestData
        {
        }

        public class AdminGetPlayersWithTagRequestData : ServerGetPlayersWithTagRequestData
        {
        }

        public class GetSegmentRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        public class ServerGetSegmentRequestData : GetSegmentRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetSegmentRequestData : ServerGetSegmentRequestData
        {
        }

        public class GetStatisticsLeaderboardAroundPlayerRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            [BooleanDataMember(code = ParameterCode.LoadFromCache, defaultValue = true, isOptional = true)]
            public bool? loadFromCache;

        }

        public class ServerGetStatisticsLeaderboardAroundPlayerRequestData : GetStatisticsLeaderboardAroundPlayerRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetStatisticsLeaderboardAroundPlayerRequestData : ServerGetStatisticsLeaderboardAroundPlayerRequestData
        {
        }

        public class GetStatisticsLeaderboardRequestData
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            [BooleanDataMember(code = ParameterCode.LoadFromCache, defaultValue = true, isOptional = true)]
            public bool? loadFromCache;

            [StringDataMember(code = ParameterCode.Version, minLength = 2, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? version;

        }

        public class ServerGetStatisticsLeaderboardRequestData : GetStatisticsLeaderboardRequestData
        {
        }

        public class AdminGetStatisticsLeaderboardRequestData : ServerGetStatisticsLeaderboardRequestData
        {
        }

        public class GetTagRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = ParameterCode.TagKeys, elementCls = typeof(string))]
            public List<string> tagKeys;

        }

        public class ServerGetTagRequestData : GetTagRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetTagRequestData : ServerGetTagRequestData
        {
        }

        public class GetTsCreateRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        public class ServerGetTsCreateRequestData : GetTsCreateRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetTsCreateRequestData : ServerGetTsCreateRequestData
        {
        }

        public class GetTsLastLoginRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        public class ServerGetTsLastLoginRequestData : GetTsLastLoginRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetTsLastLoginRequestData : ServerGetTsLastLoginRequestData
        {
        }

        public class LinkAccountRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.Username, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string username;

            [StringDataMember(code = ParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        public class ServerLinkAccountRequestData : LinkAccountRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLinkAccountRequestData : ServerLinkAccountRequestData
        {
        }

        public class LinkAndroidDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.AndroidDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string androidDeviceId;

            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        public class ServerLinkAndroidDeviceIdRequestData : LinkAndroidDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLinkAndroidDeviceIdRequestData : ServerLinkAndroidDeviceIdRequestData
        {
        }

        public class LinkAppleRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.Token, minLength = 32, maxLength = 2048, mustNonNull = true)]
            public string token;

            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        public class ServerLinkAppleRequestData : LinkAppleRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLinkAppleRequestData : ServerLinkAppleRequestData
        {
        }

        public class LinkCustomDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.CustomDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string customDeviceId;

            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        public class ServerLinkCustomDeviceIdRequestData : LinkCustomDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLinkCustomDeviceIdRequestData : ServerLinkCustomDeviceIdRequestData
        {
        }

        public class LinkCustomIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.CustomId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string customId;

            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        public class ServerLinkCustomIdRequestData : LinkCustomIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLinkCustomIdRequestData : ServerLinkCustomIdRequestData
        {
        }

        public class LinkEditorDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.EditorDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string editorDeviceId;

            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        public class ServerLinkEditorDeviceIdRequestData : LinkEditorDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLinkEditorDeviceIdRequestData : ServerLinkEditorDeviceIdRequestData
        {
        }

        public class LinkFacebookRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.Token, minLength = 32, maxLength = 2048, mustNonNull = true)]
            public string token;

            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        public class ServerLinkFacebookRequestData : LinkFacebookRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLinkFacebookRequestData : ServerLinkFacebookRequestData
        {
        }

        public class LinkGenericServiceRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.ServiceName, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string serviceName;

            [GNHashtableDataMember(code = ParameterCode.ServiceData, mustNonNull = true)]
            public GNHashtable serviceData;

            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        public class ServerLinkGenericServiceRequestData : LinkGenericServiceRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLinkGenericServiceRequestData : ServerLinkGenericServiceRequestData
        {
        }

        public class LinkGoogleRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.Token, minLength = 32, maxLength = 2048, mustNonNull = true)]
            public string token;

            [NumberDataMember(code = ParameterCode.Type, minValue = 1, maxValue = 2)]
            public int type;

            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        public class ServerLinkGoogleRequestData : LinkGoogleRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLinkGoogleRequestData : ServerLinkGoogleRequestData
        {
        }

        public class LinkGooglePlayGameServiceRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.Token, minLength = 32, maxLength = 2048, mustNonNull = true)]
            public string token;

            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        public class ServerLinkGooglePlayGameServiceRequestData : LinkGooglePlayGameServiceRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLinkGooglePlayGameServiceRequestData : ServerLinkGooglePlayGameServiceRequestData
        {
        }

        public class LinkGameCenterRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.PlayerId, minLength = 2, maxLength = 64, mustNonNull = true)]
            public string playerId;

            [StringDataMember(code = ParameterCode.Name, minLength = 2, maxLength = 128, mustNonNull = true)]
            public string name;

            [StringDataMember(code = ParameterCode.PublicKeyUrl, minLength = 2, maxLength = 2048, mustNonNull = true)]
            public string publicKeyUrl;

            [StringDataMember(code = ParameterCode.Signature, minLength = 2, maxLength = 2048, mustNonNull = true)]
            public string signature;

            [StringDataMember(code = ParameterCode.Salt, minLength = 2, maxLength = 256, mustNonNull = true)]
            public string salt;

            [NumberDataMember(code = ParameterCode.Timestamp)]
            public long timestamp;

            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        public class ServerLinkGameCenterRequestData : LinkGameCenterRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLinkGameCenterRequestData : ServerLinkGameCenterRequestData
        {
        }

        public class LinkiOSDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.iOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string iOSDeviceId;

            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        public class ServerLinkiOSDeviceIdRequestData : LinkiOSDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLinkiOSDeviceIdRequestData : ServerLinkiOSDeviceIdRequestData
        {
        }

        public class LinkLinuxDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.LinuxDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string linuxDeviceId;

            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        public class ServerLinkLinuxDeviceIdRequestData : LinkLinuxDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLinkLinuxDeviceIdRequestData : ServerLinkLinuxDeviceIdRequestData
        {
        }

        public class LinkMacOSDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.MacOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string macOSDeviceId;

            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        public class ServerLinkMacOSDeviceIdRequestData : LinkMacOSDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLinkMacOSDeviceIdRequestData : ServerLinkMacOSDeviceIdRequestData
        {
        }

        public class LinkWindowsDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.WindowsDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string windowsDeviceId;

            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        public class ServerLinkWindowsDeviceIdRequestData : LinkWindowsDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLinkWindowsDeviceIdRequestData : ServerLinkWindowsDeviceIdRequestData
        {
        }

        public class LinkWindowsPhoneDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.WindowsPhoneDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string windowsPhoneDeviceId;

            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        public class ServerLinkWindowsPhoneDeviceIdRequestData : LinkWindowsPhoneDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLinkWindowsPhoneDeviceIdRequestData : ServerLinkWindowsPhoneDeviceIdRequestData
        {
        }

        public class RemoveSegmentRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string value;

        }

        public class ServerRemoveSegmentRequestData : RemoveSegmentRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminRemoveSegmentRequestData : ServerRemoveSegmentRequestData
        {
        }

        public class RemoveTagRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

        }

        public class ServerRemoveTagRequestData : RemoveTagRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminRemoveTagRequestData : ServerRemoveTagRequestData
        {
        }

        public class ResetAccountPasswordRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

        }

        public class ServerResetAccountPasswordRequestData : ResetAccountPasswordRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminResetAccountPasswordRequestData : ServerResetAccountPasswordRequestData
        {
        }

        public class SetAvatarRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            [StringDataMember(code = ParameterCode.Value, minLength = 1, maxLength = 128, mustNonNull = true)]
            public string value;

        }

        public class ServerSetAvatarRequestData : SetAvatarRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminSetAvatarRequestData : ServerSetAvatarRequestData
        {
        }

        public class SetCountryCodeRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.CountryCode, minLength = 2, maxLength = 32)]
            public string countryCode;

        }

        public class ServerSetCountryCodeRequestData : SetCountryCodeRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminSetCountryCodeRequestData : ServerSetCountryCodeRequestData
        {
        }

        public class SetCustomDataRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = ParameterCode.CustomDatas, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(CustomDataParam))]
            public List<CustomDataParam> customDatas;

        }

        public class ServerSetCustomDataRequestData : SetCustomDataRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminSetCustomDataRequestData : ServerSetCustomDataRequestData
        {
        }

        public class SetDisplayNameRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.DisplayName, minLength = 5, maxLength = 32, mustNonNull = true)]
            public string displayName;

            [BooleanDataMember(code = ParameterCode.UniqueDisplayName, defaultValue = false, isOptional = true)]
            public bool? uniqueDisplayName;

        }

        public class ServerSetDisplayNameRequestData : SetDisplayNameRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminSetDisplayNameRequestData : ServerSetDisplayNameRequestData
        {
        }

        public class SetEmailRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.Email, minLength = 5, maxLength = 128, mustNonNull = true)]
            public string email;

        }

        public class ServerSetEmailRequestData : SetEmailRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminSetEmailRequestData : ServerSetEmailRequestData
        {
        }

        public class SetPlayerBanRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [NumberDataMember(code = ParameterCode.TsExpire)]
            public long tsExpire;

            [StringDataMember(code = ParameterCode.Reason)]
            public string reason;

        }

        public class ServerSetPlayerBanRequestData : SetPlayerBanRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminSetPlayerBanRequestData : ServerSetPlayerBanRequestData
        {
        }

        public class ChangePlayerCurrencyRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = ParameterCode.PlayerCurrencies, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(PlayerCurrencyParam))]
            public List<PlayerCurrencyParam> playerCurrencies;

            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        public class ServerChangePlayerCurrencyRequestData : ChangePlayerCurrencyRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminChangePlayerCurrencyRequestData : ServerChangePlayerCurrencyRequestData
        {
        }

        public class SetPlayerDataRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = ParameterCode.PlayerDatas, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(PlayerDataParam))]
            public List<PlayerDataParam> playerDatas;

        }

        public class ServerSetPlayerDataRequestData : SetPlayerDataRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminSetPlayerDataRequestData : ServerSetPlayerDataRequestData
        {
        }

        public class ChangePlayerStatisticsRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = ParameterCode.PlayerStatistics, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(PlayerStatisticsParam))]
            public List<PlayerStatisticsParam> playerStatistics;

            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        public class ServerChangePlayerStatisticsRequestData : ChangePlayerStatisticsRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminChangePlayerStatisticsRequestData : ServerChangePlayerStatisticsRequestData
        {
        }

        public class SetTagRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [StringDataMember(code = ParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string value;

        }

        public class ServerSetTagRequestData : SetTagRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminSetTagRequestData : ServerSetTagRequestData
        {
        }

        public class SetTsLastLoginRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        public class ServerSetTsLastLoginRequestData : SetTsLastLoginRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminSetTsLastLoginRequestData : ServerSetTsLastLoginRequestData
        {
        }

        public class UnlinkAccountRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.Username, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string username;

        }

        public class ServerUnlinkAccountRequestData : UnlinkAccountRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminUnlinkAccountRequestData : ServerUnlinkAccountRequestData
        {
        }

        public class UnlinkAndroidDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.AndroidDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string androidDeviceId;

        }

        public class ServerUnlinkAndroidDeviceIdRequestData : UnlinkAndroidDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminUnlinkAndroidDeviceIdRequestData : ServerUnlinkAndroidDeviceIdRequestData
        {
        }

        public class UnlinkAppleRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.AppleId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string appleId;

        }

        public class ServerUnlinkAppleRequestData : UnlinkAppleRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminUnlinkAppleRequestData : ServerUnlinkAppleRequestData
        {
        }

        public class UnlinkCustomDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.CustomDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string customDeviceId;

        }

        public class ServerUnlinkCustomDeviceIdRequestData : UnlinkCustomDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminUnlinkCustomDeviceIdRequestData : ServerUnlinkCustomDeviceIdRequestData
        {
        }

        public class UnlinkCustomIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.CustomId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string customId;

        }

        public class ServerUnlinkCustomIdRequestData : UnlinkCustomIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminUnlinkCustomIdRequestData : ServerUnlinkCustomIdRequestData
        {
        }

        public class UnlinkEditorDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.EditorDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string editorDeviceId;

        }

        public class ServerUnlinkEditorDeviceIdRequestData : UnlinkEditorDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminUnlinkEditorDeviceIdRequestData : ServerUnlinkEditorDeviceIdRequestData
        {
        }

        public class UnlinkFacebookRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.FacebookId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string facebookId;

        }

        public class ServerUnlinkFacebookRequestData : UnlinkFacebookRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminUnlinkFacebookRequestData : ServerUnlinkFacebookRequestData
        {
        }

        public class UnlinkGenericServiceRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.ServiceName, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string serviceName;

            [StringDataMember(code = ParameterCode.ServiceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string serviceId;

        }

        public class ServerUnlinkGenericServiceRequestData : UnlinkGenericServiceRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminUnlinkGenericServiceRequestData : ServerUnlinkGenericServiceRequestData
        {
        }

        public class UnlinkGoogleRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.GoogleId, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string googleId;

        }

        public class ServerUnlinkGoogleRequestData : UnlinkGoogleRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminUnlinkGoogleRequestData : ServerUnlinkGoogleRequestData
        {
        }

        public class UnlinkGooglePlayGameServiceRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.PlayerId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string playerId;

        }

        public class ServerUnlinkGooglePlayGameServiceRequestData : UnlinkGooglePlayGameServiceRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminUnlinkGooglePlayGameServiceRequestData : ServerUnlinkGooglePlayGameServiceRequestData
        {
        }

        public class UnlinkGameCenterRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.PlayerId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string playerId;

        }

        public class ServerUnlinkGameCenterRequestData : UnlinkGameCenterRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminUnlinkGameCenterRequestData : ServerUnlinkGameCenterRequestData
        {
        }

        public class UnlinkiOSDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.iOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string iOSDeviceId;

        }

        public class ServerUnlinkiOSDeviceIdRequestData : UnlinkiOSDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminUnlinkiOSDeviceIdRequestData : ServerUnlinkiOSDeviceIdRequestData
        {
        }

        public class UnlinkLinuxDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.LinuxDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string linuxDeviceId;

        }

        public class ServerUnlinkLinuxDeviceIdRequestData : UnlinkLinuxDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminUnlinkLinuxDeviceIdRequestData : ServerUnlinkLinuxDeviceIdRequestData
        {
        }

        public class UnlinkMacOSDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.MacOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string macOSDeviceId;

        }

        public class ServerUnlinkMacOSDeviceIdRequestData : UnlinkMacOSDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminUnlinkMacOSDeviceIdRequestData : ServerUnlinkMacOSDeviceIdRequestData
        {
        }

        public class UnlinkWindowsDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.WindowsDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string windowsDeviceId;

        }

        public class ServerUnlinkWindowsDeviceIdRequestData : UnlinkWindowsDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminUnlinkWindowsDeviceIdRequestData : ServerUnlinkWindowsDeviceIdRequestData
        {
        }

        public class UnlinkWindowsPhoneDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.WindowsPhoneDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string windowsPhoneDeviceId;

        }

        public class ServerUnlinkWindowsPhoneDeviceIdRequestData : UnlinkWindowsPhoneDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminUnlinkWindowsPhoneDeviceIdRequestData : ServerUnlinkWindowsPhoneDeviceIdRequestData
        {
        }

        public class GetCurrencyLeaderboardRequestData
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            [BooleanDataMember(code = ParameterCode.LoadFromCache, defaultValue = true, isOptional = true)]
            public bool? loadFromCache;

        }

        public class ServerGetCurrencyLeaderboardRequestData : GetCurrencyLeaderboardRequestData
        {
        }

        public class AdminGetCurrencyLeaderboardRequestData : ServerGetCurrencyLeaderboardRequestData
        {
        }

        public class GetLastLoginLeaderboardRequestData
        {
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            [BooleanDataMember(code = ParameterCode.LoadFromCache, defaultValue = true, isOptional = true)]
            public bool? loadFromCache;

        }

        public class ServerGetLastLoginLeaderboardRequestData : GetLastLoginLeaderboardRequestData
        {
        }

        public class AdminGetLastLoginLeaderboardRequestData : ServerGetLastLoginLeaderboardRequestData
        {
        }

        public class GetCreateLeaderboardRequestData
        {
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            [BooleanDataMember(code = ParameterCode.LoadFromCache, defaultValue = true, isOptional = true)]
            public bool? loadFromCache;

        }

        public class ServerGetCreateLeaderboardRequestData : GetCreateLeaderboardRequestData
        {
        }

        public class AdminGetCreateLeaderboardRequestData : ServerGetCreateLeaderboardRequestData
        {
        }

        public class GetStatisticsLogRequestData
        {
            [GNArrayDataMember(code = ParameterCode.Keys, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(string), isOptional = true)]
            public List<string>? keys;

            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true, isOptional = true)]
            public string? userId;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            [StringDataMember(code = ParameterCode.Token, minLength = 24, maxLength = 24, mustNonNull = true, isOptional = true)]
            public string? token;

        }

        public class ServerGetStatisticsLogRequestData : GetStatisticsLogRequestData
        {
        }

        public class AdminGetStatisticsLogRequestData : ServerGetStatisticsLogRequestData
        {
        }

        public class GetCurrencyLogRequestData
        {
            [GNArrayDataMember(code = ParameterCode.Keys, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(string), isOptional = true)]
            public List<string>? keys;

            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true, isOptional = true)]
            public string? userId;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            [StringDataMember(code = ParameterCode.Token, minLength = 24, maxLength = 24, mustNonNull = true, isOptional = true)]
            public string? token;

        }

        public class ServerGetCurrencyLogRequestData : GetCurrencyLogRequestData
        {
        }

        public class AdminGetCurrencyLogRequestData : ServerGetCurrencyLogRequestData
        {
        }

        public class SendSocketOperationEventRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.EventCode, minLength = 1, maxLength = 64)]
            public string eventCode;

            [GNHashtableDataMember(code = ParameterCode.EventParameters, minLength = 0, maxLength = 128, mustNonNull = true, isOptional = true)]
            public GNHashtable? eventParameters;

        }

        public class ServerSendSocketOperationEventRequestData : SendSocketOperationEventRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminSendSocketOperationEventRequestData : ServerSendSocketOperationEventRequestData
        {
        }

        public class SendEmailRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.Subject, minLength = 2, maxLength = 256, mustNonNull = true)]
            public string subject;

            [StringDataMember(code = ParameterCode.ContentHtml, minLength = 2, maxLength = 8192, mustNonNull = true)]
            public string contentHtml;

        }

        public class ServerSendEmailRequestData : SendEmailRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;
        }

        public class AdminSendEmailRequestData : ServerSendEmailRequestData
        {
        }

        public class AddPushNotificationRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.Token, minLength = 10, maxLength = 256, mustNonNull = true)]
            public string token;

            [NumberDataMember(code = ParameterCode.PlatformType, minValue = 1, mustInt = true)]
            public int platformType;

        }

        public class ServerAddPushNotificationRequestData : AddPushNotificationRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;
        }

        public class AdminAddPushNotificationRequestData : ServerAddPushNotificationRequestData
        {
        }

        public class GetPushNotificationRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        public class ServerGetPushNotificationRequestData : GetPushNotificationRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;
        }

        public class AdminGetPushNotificationRequestData : ServerGetPushNotificationRequestData
        {
        }

        public class RemovePushNotificationRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.PushId, minLength = 8, maxLength = 8, mustNonNull = true)]
            public string pushId;

        }

        public class ServerRemovePushNotificationRequestData : RemovePushNotificationRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;
        }

        public class AdminRemovePushNotificationRequestData : ServerRemovePushNotificationRequestData
        {
        }

        public class SendPushNotificationRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.Title)]
            public string title;

            [StringDataMember(code = ParameterCode.Body)]
            public string body;

            [NumberDataMember(code = ParameterCode.Badge, mustInt = true, isOptional = true)]
            public int? badge;

            [StringDataMember(code = ParameterCode.Sound, isOptional = true)]
            public string? sound;

            [StringDataMember(code = ParameterCode.Icon, isOptional = true)]
            public string? icon;

            [GNHashtableDataMember(code = ParameterCode.Data, isOptional = true)]
            public GNHashtable? data;

        }

        public class ServerSendPushNotificationRequestData : SendPushNotificationRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;
        }

        public class AdminSendPushNotificationRequestData : ServerSendPushNotificationRequestData
        {
        }

    }

    public partial class MasterPlayerModels
    {
        public class CustomDataParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [DataMember(code = ParameterCode.Value)]
            public object value;

        }

        public class InfoRequestParam
        {
            [BooleanDataMember(code = ParameterCode.External, isOptional = true, defaultValue = false)]
            public bool? external;

            [BooleanDataMember(code = ParameterCode.Segments, isOptional = true, defaultValue = false)]
            public bool? segments;

            [BooleanDataMember(code = ParameterCode.CustomDatas, isOptional = true, defaultValue = false)]
            public bool? customDatas;

            [BooleanDataMember(code = ParameterCode.DisplayName, isOptional = true, defaultValue = false)]
            public bool? displayName;

            [BooleanDataMember(code = ParameterCode.Avatar, isOptional = true, defaultValue = false)]
            public bool? avatar;

            [BooleanDataMember(code = ParameterCode.TsCreate, isOptional = true, defaultValue = false)]
            public bool? tsCreate;

            [BooleanDataMember(code = ParameterCode.Tags, isOptional = true, defaultValue = false)]
            public bool? tags;

            [BooleanDataMember(code = ParameterCode.PlayerBan, isOptional = true, defaultValue = false)]
            public bool? playerBan;

            [BooleanDataMember(code = ParameterCode.PlayerCurrencies, isOptional = true, defaultValue = false)]
            public bool? playerCurrencies;

            [BooleanDataMember(code = ParameterCode.PlayerStatistics, isOptional = true, defaultValue = false)]
            public bool? playerStatistics;

            [BooleanDataMember(code = ParameterCode.PlayerDatas, isOptional = true, defaultValue = false)]
            public bool? playerDatas;

            [BooleanDataMember(code = ParameterCode.IpAddressCreate, isOptional = true, defaultValue = false)]
            public bool? ipAddressCreate;

            [BooleanDataMember(code = ParameterCode.CountryCode, isOptional = true, defaultValue = false)]
            public bool? countryCode;

            [BooleanDataMember(code = ParameterCode.Email, isOptional = true, defaultValue = false)]
            public bool? email;

            [BooleanDataMember(code = ParameterCode.TsLastLogin, isOptional = true, defaultValue = false)]
            public bool? tsLastLogin;

            [BooleanDataMember(code = ParameterCode.PushNotifications, isOptional = true, defaultValue = false)]
            public bool? pushNotifications;

            [GNArrayDataMember(code = ParameterCode.PlayerDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerDataKeys;

            [GNArrayDataMember(code = ParameterCode.PlayerCurrencyKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerCurrencyKeys;

            [GNArrayDataMember(code = ParameterCode.PlayerStatisticsKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerStatisticsKeys;

            [GNArrayDataMember(code = ParameterCode.CustomDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? customDataKeys;

            [GNArrayDataMember(code = ParameterCode.TagKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? tagKeys;

        }

        public class PlayerCurrencyParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [NumberDataMember(code = ParameterCode.Amount)]
            public double amount;

        }

        public class PlayerDataParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [DataMember(code = ParameterCode.Value)]
            public object value;

        }

        public class PlayerStatisticsParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [NumberDataMember(code = ParameterCode.Value)]
            public double value;

        }

    }

    public partial class MasterPlayerModels
    {
        public class ExternalItem
        {
            public class Device
            {
                [StringDataMember(code = ParameterCode.CustomDeviceId, isOptional = true)]
                public string? customDeviceId;

                [StringDataMember(code = ParameterCode.AndroidDeviceId, isOptional = true)]
                public string? androidDeviceId;

                [StringDataMember(code = ParameterCode.iOSDeviceId, isOptional = true)]
                public string? iOSDeviceId;

                [StringDataMember(code = ParameterCode.WindowsPhoneDeviceId, isOptional = true)]
                public string? windowsPhoneDeviceId;

                [StringDataMember(code = ParameterCode.WindowsDeviceId, isOptional = true)]
                public string? windowsDeviceId;

                [StringDataMember(code = ParameterCode.LinuxDeviceId, isOptional = true)]
                public string? linuxDeviceId;

                [StringDataMember(code = ParameterCode.MacOSDeviceId, isOptional = true)]
                public string? macOSDeviceId;

                [StringDataMember(code = ParameterCode.EditorDeviceId, isOptional = true)]
                public string? editorDeviceId;

            }

            public class Account
            {
                [StringDataMember(code = ParameterCode.Username, isOptional = true)]
                public string? username;

            }

            public class Custom
            {
                [StringDataMember(code = ParameterCode.CustomId, isOptional = true)]
                public string? customId;

            }

            public class Apple
            {
                [StringDataMember(code = ParameterCode.AppleId)]
                public string appleId;

                [StringDataMember(code = ParameterCode.Email)]
                public string email;

            }

            public class Google
            {
                [StringDataMember(code = ParameterCode.GoogleId)]
                public string googleId;

                [StringDataMember(code = ParameterCode.DisplayName)]
                public string displayName;

                [StringDataMember(code = ParameterCode.Email)]
                public string email;

            }

            public class GooglePlayGameService
            {
                [StringDataMember(code = ParameterCode.PlayerId)]
                public string playerId;

                [StringDataMember(code = ParameterCode.DisplayName)]
                public string displayName;

                [StringDataMember(code = ParameterCode.Email)]
                public string email;

            }

            public class GameCenter
            {
                [StringDataMember(code = ParameterCode.PlayerId)]
                public string playerId;

                [StringDataMember(code = ParameterCode.DisplayName)]
                public string displayName;

                [StringDataMember(code = ParameterCode.Email)]
                public string email;

            }

            public class Facebook
            {
                [StringDataMember(code = ParameterCode.FacebookId)]
                public string facebookId;

                [StringDataMember(code = ParameterCode.DisplayName)]
                public string displayName;

                [StringDataMember(code = ParameterCode.Email)]
                public string email;

            }

            public class GenericService
            {
                [StringDataMember(code = ParameterCode.ServiceName)]
                public string serviceName;

                [StringDataMember(code = ParameterCode.ServiceId)]
                public string serviceId;

            }

            [GNHashtableDataMember(code = ParameterCode.Device, isOptional = true)]
            public Device? device;

            [GNHashtableDataMember(code = ParameterCode.Account, isOptional = true)]
            public Account? account;

            [GNHashtableDataMember(code = ParameterCode.Custom, isOptional = true)]
            public Custom? custom;

            [GNHashtableDataMember(code = ParameterCode.Apple, isOptional = true)]
            public Apple? apple;

            [GNHashtableDataMember(code = ParameterCode.Google, isOptional = true)]
            public Google? google;

            [GNHashtableDataMember(code = ParameterCode.Facebook, isOptional = true)]
            public Facebook? facebook;

            [GNArrayDataMember(code = ParameterCode.GenericService, isOptional = true, elementCls = typeof(GenericService))]
            public List<GenericService> genericServices;

            [GNHashtableDataMember(code = ParameterCode.GooglePlayGameService, isOptional = true)]
            public GooglePlayGameService? googlePlayGameService;

            [GNHashtableDataMember(code = ParameterCode.GameCenter, isOptional = true)]
            public GameCenter? gameCenter;

        }

        public class PushNotificationItem
        {
            [StringDataMember(code = ParameterCode.Token)]
            public string token;

            [StringDataMember(code = ParameterCode.PushId)]
            public string pushId;

            [NumberDataMember(code = ParameterCode.PlatformType)]
            public int platformType;

        }

        public class InfoResponseParameters
        {
            [GNHashtableDataMember(code = ParameterCode.External, isOptional = true)]
            public ExternalItem? external;

            [GNArrayDataMember(code = ParameterCode.Segments, isOptional = true, elementCls = typeof(string))]
            public List<string>? segments;

            [GNArrayDataMember(code = ParameterCode.CustomDatas, isOptional = true, elementCls = typeof(GenericModels.DataItem))]
            public List<GenericModels.DataItem>? customDatas;

            [StringDataMember(code = ParameterCode.DisplayName, isOptional = true)]
            public string? displayName;

            [GNHashtableDataMember(code = ParameterCode.Avatar, isOptional = true)]
            public GenericModels.AvatarItem? avatar;

            [NumberDataMember(code = ParameterCode.TsCreate, isOptional = true)]
            public long? tsCreate;

            [GNArrayDataMember(code = ParameterCode.Tags, isOptional = true, elementCls = typeof(GenericModels.TagItem))]
            public List<GenericModels.TagItem>? tags;

            [GNHashtableDataMember(code = ParameterCode.PlayerBan, isOptional = true)]
            public GenericModels.BanItem? playerBan;

            [GNArrayDataMember(code = ParameterCode.PlayerDatas, isOptional = true, elementCls = typeof(GenericModels.DataItem))]
            public List<GenericModels.DataItem>? playerDatas;

            [GNArrayDataMember(code = ParameterCode.PlayerCurrencies, isOptional = true, elementCls = typeof(GenericModels.CurrencyItem))]
            public List<GenericModels.CurrencyItem>? playerCurrencies;

            [GNArrayDataMember(code = ParameterCode.PlayerStatistics, isOptional = true, elementCls = typeof(GenericModels.StatisticsItem))]
            public List<GenericModels.StatisticsItem>? playerStatistics;

            [NumberDataMember(code = ParameterCode.TsLastLogin, isOptional = true)]
            public long? tsLastLogin;

            [StringDataMember(code = ParameterCode.IpAddressCreate, isOptional = true)]
            public string? ipAddressCreate;

            [StringDataMember(code = ParameterCode.CountryCode, isOptional = true)]
            public string? countryCode;

            [StringDataMember(code = ParameterCode.Email, isOptional = true)]
            public string? email;

            [GNArrayDataMember(code = ParameterCode.PushNotifications, isOptional = true, elementCls = typeof(MasterPlayerModels.PushNotificationItem))]
            public List<MasterPlayerModels.PushNotificationItem>? pushNotifications;

        }

        public class MasterPlayerResponseData
        {
            [GNHashtableDataMember(code = ParameterCode.InfoResponseParameters)]
            public InfoResponseParameters infoResponseParameters;

        }

        public class GenericServiceMasterPlayerResponseData : MasterPlayerResponseData
        {
            [StringDataMember(code = ParameterCode.ErrorMessage, isOptional = true)]
            public string? errorMessage;

        }

        public class MasterPlayerWithUserIdResponseData : MasterPlayerResponseData
        {
            [StringDataMember(code = ParameterCode.UserId)]
            public string userId;

        }

        public class MasterPlayerWithAppleIdResponseData : MasterPlayerWithUserIdResponseData
        {
            [StringDataMember(code = ParameterCode.AppleId)]
            public string appleId;

        }

        public class GetPlayersWithAppleResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerWithAppleIdResponseData))]
            public List<MasterPlayerWithAppleIdResponseData> results;

        }

        public class MasterPlayersWithUserIdResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerWithUserIdResponseData))]
            public List<MasterPlayerWithUserIdResponseData> results;

        }

        public class MasterPlayerWithFacebookIdResponseData : MasterPlayerWithUserIdResponseData
        {
            [StringDataMember(code = ParameterCode.FacebookId)]
            public string facebookId;

        }

        public class GetPlayersWithFacebookResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerWithFacebookIdResponseData))]
            public List<MasterPlayerWithFacebookIdResponseData> results;

        }

        public class MasterPlayerWithGenericServiceIdResponseData : MasterPlayerWithUserIdResponseData
        {
            [StringDataMember(code = ParameterCode.ServiceId)]
            public string serviceId;

        }

        public class GetPlayersWithGenericServiceResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerWithGenericServiceIdResponseData))]
            public List<MasterPlayerWithGenericServiceIdResponseData> results;

        }

        public class MasterPlayerWithGoogleIdResponseData : MasterPlayerWithUserIdResponseData
        {
            [StringDataMember(code = ParameterCode.GoogleId)]
            public string googleId;

        }

        public class GetPlayersWithGoogleResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerWithGoogleIdResponseData))]
            public List<MasterPlayerWithGoogleIdResponseData> results;

        }

        public class MasterPlayerWithPlayerIdResponseData : MasterPlayerWithUserIdResponseData
        {
            [StringDataMember(code = ParameterCode.PlayerId)]
            public string playerId;

        }

        public class GetPlayersWithGooglePlayGameServiceResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerWithPlayerIdResponseData))]
            public List<MasterPlayerWithPlayerIdResponseData> results;

        }

        public class GetPlayersWithGameCenterResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerWithPlayerIdResponseData))]
            public List<MasterPlayerWithPlayerIdResponseData> results;

        }

        public class MasterPlayerLeaderboardResponseData : MasterPlayerWithUserIdResponseData
        {
            [NumberDataMember(code = ParameterCode.Position)]
            public int position;

            [NumberDataMember(code = ParameterCode.BackupValue, isOptional = true)]
            public double? backupValue;

        }

        public class MasterPlayerLogResponseData
        {
            [StringDataMember(code = ParameterCode.UserId)]
            public string userId;

            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            [NumberDataMember(code = ParameterCode.Log)]
            public string log;

            [NumberDataMember(code = ParameterCode.Key)]
            public string key;

            [NumberDataMember(code = ParameterCode.Amount)]
            public double amount;

            [NumberDataMember(code = ParameterCode.StartValue)]
            public double startValue;

            [NumberDataMember(code = ParameterCode.FinalValue)]
            public double finalValue;

        }

        public class GetStatisticsLeaderboardResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerLeaderboardResponseData))]
            public List<MasterPlayerLeaderboardResponseData> results;

            [NumberDataMember(code = ParameterCode.TsCreate, isOptional = true)]
            public long? tsCreate;

        }

        public class GetCurrencyLeaderboardResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerLeaderboardResponseData))]
            public List<MasterPlayerLeaderboardResponseData> results;

        }

        public class GetLastLoginLeaderboardResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerLeaderboardResponseData))]
            public List<MasterPlayerLeaderboardResponseData> results;

        }

        public class GetCreateLeaderboardResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerLeaderboardResponseData))]
            public List<MasterPlayerLeaderboardResponseData> results;

        }

        public class GetStatisticsLogResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerLogResponseData))]
            public List<MasterPlayerLogResponseData> results;

            [StringDataMember(code = ParameterCode.Token, isOptional = true)]
            public string? token;

        }

        public class GetCurrencyLogResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerLogResponseData))]
            public List<MasterPlayerLogResponseData> results;

            [StringDataMember(code = ParameterCode.Token, isOptional = true)]
            public string? token;

        }

        public class AddPushNotificationResponseData
        {
            [StringDataMember(code = ParameterCode.PushId)]
            public string pushId;

        }

        public class SendPushNotificationResponseData
        {
            [StringDataMember(code = ParameterCode.Message)]
            public string message;

        }

        public class EmptyResponseData
        {

        }

    }

}
