namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;

    /// <summary>
    /// Defines payload models for master player operations.
    /// </summary>
    public partial class MasterPlayerModels
    {
        /// <summary>
        /// Represents the request payload for the add segment operation.
        /// </summary>
        public class AddSegmentRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string value;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the add segment operation.
        /// </summary>
        public class ServerAddSegmentRequestData : AddSegmentRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the add segment operation.
        /// </summary>
        public class AdminAddSegmentRequestData : ServerAddSegmentRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the change account password operation.
        /// </summary>
        public class ChangeAccountPasswordRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the current password value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CurrentPassword, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string currentPassword;

            /// <summary>
            /// Stores the password value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

        }

        /// <summary>
        /// Represents the request payload for the get avatar operation.
        /// </summary>
        public class GetAvatarRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get avatar operation.
        /// </summary>
        public class ServerGetAvatarRequestData : GetAvatarRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get avatar operation.
        /// </summary>
        public class AdminGetAvatarRequestData : ServerGetAvatarRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get country code operation.
        /// </summary>
        public class GetCountryCodeRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get country code operation.
        /// </summary>
        public class ServerGetCountryCodeRequestData : GetCountryCodeRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get country code operation.
        /// </summary>
        public class AdminGetCountryCodeRequestData : ServerGetCountryCodeRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get custom data operation.
        /// </summary>
        public class GetCustomDataRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the custom data key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.CustomDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? customDataKeys;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get custom data operation.
        /// </summary>
        public class ServerGetCustomDataRequestData : GetCustomDataRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get custom data operation.
        /// </summary>
        public class AdminGetCustomDataRequestData : ServerGetCustomDataRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get display name operation.
        /// </summary>
        public class GetDisplayNameRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get display name operation.
        /// </summary>
        public class ServerGetDisplayNameRequestData : GetDisplayNameRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get display name operation.
        /// </summary>
        public class AdminGetDisplayNameRequestData : ServerGetDisplayNameRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get email operation.
        /// </summary>
        public class GetEmailRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get email operation.
        /// </summary>
        public class ServerGetEmailRequestData : GetEmailRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get email operation.
        /// </summary>
        public class AdminGetEmailRequestData : ServerGetEmailRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get external operation.
        /// </summary>
        public class GetExternalRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get external operation.
        /// </summary>
        public class ServerGetExternalRequestData : GetExternalRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get external operation.
        /// </summary>
        public class AdminGetExternalRequestData : ServerGetExternalRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get IP address create operation.
        /// </summary>
        public class GetIpAddressCreateRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get IP address create operation.
        /// </summary>
        public class ServerGetIpAddressCreateRequestData : GetIpAddressCreateRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get IP address create operation.
        /// </summary>
        public class AdminGetIpAddressCreateRequestData : ServerGetIpAddressCreateRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get player ban operation.
        /// </summary>
        public class GetPlayerBanRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get player ban operation.
        /// </summary>
        public class ServerGetPlayerBanRequestData : GetPlayerBanRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get player ban operation.
        /// </summary>
        public class AdminGetPlayerBanRequestData : ServerGetPlayerBanRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get player currency operation.
        /// </summary>
        public class GetPlayerCurrencyRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the player currency key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerCurrencyKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerCurrencyKeys;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get player currency operation.
        /// </summary>
        public class ServerGetPlayerCurrencyRequestData : GetPlayerCurrencyRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get player currency operation.
        /// </summary>
        public class AdminGetPlayerCurrencyRequestData : ServerGetPlayerCurrencyRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get player data operation.
        /// </summary>
        public class GetPlayerDataRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the player data key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerDataKeys;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get player data operation.
        /// </summary>
        public class ServerGetPlayerDataRequestData : GetPlayerDataRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get player data operation.
        /// </summary>
        public class AdminGetPlayerDataRequestData : ServerGetPlayerDataRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get player information operation.
        /// </summary>
        public class GetPlayerInformationRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get player information operation.
        /// </summary>
        public class ServerGetPlayerInformationRequestData : GetPlayerInformationRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get player information operation.
        /// </summary>
        public class AdminGetPlayerInformationRequestData : ServerGetPlayerInformationRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get player statistics operation.
        /// </summary>
        public class GetPlayerStatisticsRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the player statistics key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerStatisticsKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerStatisticsKeys;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get player statistics operation.
        /// </summary>
        public class ServerGetPlayerStatisticsRequestData : GetPlayerStatisticsRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get player statistics operation.
        /// </summary>
        public class AdminGetPlayerStatisticsRequestData : ServerGetPlayerStatisticsRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get players with apple operation.
        /// </summary>
        public class GetPlayersWithAppleRequestData
        {
            /// <summary>
            /// Stores the apple ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.AppleIds, mustNonNull = true, elementCls = typeof(string))]
            public List<string> appleIds;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get players with apple operation.
        /// </summary>
        public class ServerGetPlayersWithAppleRequestData : GetPlayersWithAppleRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get players with apple operation.
        /// </summary>
        public class AdminGetPlayersWithAppleRequestData : ServerGetPlayersWithAppleRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get players with display name operation.
        /// </summary>
        public class GetPlayersWithDisplayNameRequestData
        {
            /// <summary>
            /// Stores the keyword value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Keyword, minLength = 2, maxLength = 32)]
            public string keyword;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            /// <summary>
            /// Stores the skip value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            /// <summary>
            /// Stores the limit value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get players with display name operation.
        /// </summary>
        public class ServerGetPlayersWithDisplayNameRequestData : GetPlayersWithDisplayNameRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get players with display name operation.
        /// </summary>
        public class AdminGetPlayersWithDisplayNameRequestData : ServerGetPlayersWithDisplayNameRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get players with facebook operation.
        /// </summary>
        public class GetPlayersWithFacebookRequestData
        {
            /// <summary>
            /// Stores the facebook ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.FacebookIds, mustNonNull = true, elementCls = typeof(string))]
            public List<string> facebookIds;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get players with facebook operation.
        /// </summary>
        public class ServerGetPlayersWithFacebookRequestData : GetPlayersWithFacebookRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get players with facebook operation.
        /// </summary>
        public class AdminGetPlayersWithFacebookRequestData : ServerGetPlayersWithFacebookRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get players with generic service operation.
        /// </summary>
        public class GetPlayersWithGenericServiceRequestData
        {
            /// <summary>
            /// Stores the service name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ServiceName, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string serviceName;

            /// <summary>
            /// Stores the generic ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GenericIds, mustNonNull = true, elementCls = typeof(string))]
            public List<string> genericIds;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get players with generic service operation.
        /// </summary>
        public class ServerGetPlayersWithGenericServiceRequestData : GetPlayersWithGenericServiceRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get players with generic service operation.
        /// </summary>
        public class AdminGetPlayersWithGenericServiceRequestData : ServerGetPlayersWithGenericServiceRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get players with google operation.
        /// </summary>
        public class GetPlayersWithGoogleRequestData
        {
            /// <summary>
            /// Stores the google ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GoogleIds, mustNonNull = true, elementCls = typeof(string))]
            public List<string> googleIds;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get players with google operation.
        /// </summary>
        public class ServerGetPlayersWithGoogleRequestData : GetPlayersWithGoogleRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get players with google operation.
        /// </summary>
        public class AdminGetPlayersWithGoogleRequestData : ServerGetPlayersWithGoogleRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get players with google play game service operation.
        /// </summary>
        public class GetPlayersWithGooglePlayGameServiceRequestData
        {
            /// <summary>
            /// Stores the player ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerIds, mustNonNull = true, elementCls = typeof(string))]
            public List<string> playerIds;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get players with google play game service operation.
        /// </summary>
        public class ServerGetPlayersWithGooglePlayGameServiceRequestData : GetPlayersWithGooglePlayGameServiceRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get players with google play game service operation.
        /// </summary>
        public class AdminGetPlayersWithGooglePlayGameServiceRequestData : ServerGetPlayersWithGooglePlayGameServiceRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get players with game center operation.
        /// </summary>
        public class GetPlayersWithGameCenterRequestData
        {
            /// <summary>
            /// Stores the player ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerIds, mustNonNull = true, elementCls = typeof(string))]
            public List<string> playerIds;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get players with game center operation.
        /// </summary>
        public class ServerGetPlayersWithGameCenterRequestData : GetPlayersWithGameCenterRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get players with game center operation.
        /// </summary>
        public class AdminGetPlayersWithGameCenterRequestData : ServerGetPlayersWithGameCenterRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get players with segment operation.
        /// </summary>
        public class GetPlayersWithSegmentRequestData
        {
            /// <summary>
            /// Stores the value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string value;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            /// <summary>
            /// Stores the skip value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            /// <summary>
            /// Stores the limit value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get players with segment operation.
        /// </summary>
        public class ServerGetPlayersWithSegmentRequestData : GetPlayersWithSegmentRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get players with segment operation.
        /// </summary>
        public class AdminGetPlayersWithSegmentRequestData : ServerGetPlayersWithSegmentRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get players with tag operation.
        /// </summary>
        public class GetPlayersWithTagRequestData
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            /// <summary>
            /// Stores the value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string value;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            /// <summary>
            /// Stores the skip value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            /// <summary>
            /// Stores the limit value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get players with tag operation.
        /// </summary>
        public class ServerGetPlayersWithTagRequestData : GetPlayersWithTagRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get players with tag operation.
        /// </summary>
        public class AdminGetPlayersWithTagRequestData : ServerGetPlayersWithTagRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get segment operation.
        /// </summary>
        public class GetSegmentRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get segment operation.
        /// </summary>
        public class ServerGetSegmentRequestData : GetSegmentRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get segment operation.
        /// </summary>
        public class AdminGetSegmentRequestData : ServerGetSegmentRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get statistics leaderboard around player operation.
        /// </summary>
        public class GetStatisticsLeaderboardAroundPlayerRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            /// <summary>
            /// Stores the skip value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            /// <summary>
            /// Stores the limit value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            /// <summary>
            /// Stores the load from cache value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.LoadFromCache, defaultValue = true, isOptional = true)]
            public bool? loadFromCache;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get statistics leaderboard around player operation.
        /// </summary>
        public class ServerGetStatisticsLeaderboardAroundPlayerRequestData : GetStatisticsLeaderboardAroundPlayerRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get statistics leaderboard around player operation.
        /// </summary>
        public class AdminGetStatisticsLeaderboardAroundPlayerRequestData : ServerGetStatisticsLeaderboardAroundPlayerRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get statistics leaderboard operation.
        /// </summary>
        public class GetStatisticsLeaderboardRequestData
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            /// <summary>
            /// Stores the skip value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            /// <summary>
            /// Stores the limit value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            /// <summary>
            /// Stores the load from cache value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.LoadFromCache, defaultValue = true, isOptional = true)]
            public bool? loadFromCache;

            /// <summary>
            /// Stores the version value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Version, minLength = 2, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? version;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get statistics leaderboard operation.
        /// </summary>
        public class ServerGetStatisticsLeaderboardRequestData : GetStatisticsLeaderboardRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get statistics leaderboard operation.
        /// </summary>
        public class AdminGetStatisticsLeaderboardRequestData : ServerGetStatisticsLeaderboardRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get tag operation.
        /// </summary>
        public class GetTagRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the tag key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.TagKeys, elementCls = typeof(string))]
            public List<string> tagKeys;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get tag operation.
        /// </summary>
        public class ServerGetTagRequestData : GetTagRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get tag operation.
        /// </summary>
        public class AdminGetTagRequestData : ServerGetTagRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get timestamp create operation.
        /// </summary>
        public class GetTsCreateRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get timestamp create operation.
        /// </summary>
        public class ServerGetTsCreateRequestData : GetTsCreateRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get timestamp create operation.
        /// </summary>
        public class AdminGetTsCreateRequestData : ServerGetTsCreateRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get timestamp last login operation.
        /// </summary>
        public class GetTsLastLoginRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get timestamp last login operation.
        /// </summary>
        public class ServerGetTsLastLoginRequestData : GetTsLastLoginRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get timestamp last login operation.
        /// </summary>
        public class AdminGetTsLastLoginRequestData : ServerGetTsLastLoginRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the link account operation.
        /// </summary>
        public class LinkAccountRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Indicates whether username.
            /// </summary>
            [StringDataMember(code = ParameterCode.Username, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string username;

            /// <summary>
            /// Stores the password value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

            /// <summary>
            /// Stores the force link value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the link account operation.
        /// </summary>
        public class ServerLinkAccountRequestData : LinkAccountRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the link account operation.
        /// </summary>
        public class AdminLinkAccountRequestData : ServerLinkAccountRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the link android device ID operation.
        /// </summary>
        public class LinkAndroidDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the android device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.AndroidDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string androidDeviceId;

            /// <summary>
            /// Stores the force link value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the link android device ID operation.
        /// </summary>
        public class ServerLinkAndroidDeviceIdRequestData : LinkAndroidDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the link android device ID operation.
        /// </summary>
        public class AdminLinkAndroidDeviceIdRequestData : ServerLinkAndroidDeviceIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the link apple operation.
        /// </summary>
        public class LinkAppleRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Token, minLength = 32, maxLength = 2048, mustNonNull = true)]
            public string token;

            /// <summary>
            /// Stores the force link value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the link apple operation.
        /// </summary>
        public class ServerLinkAppleRequestData : LinkAppleRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the link apple operation.
        /// </summary>
        public class AdminLinkAppleRequestData : ServerLinkAppleRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the link custom device ID operation.
        /// </summary>
        public class LinkCustomDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the custom device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CustomDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string customDeviceId;

            /// <summary>
            /// Stores the force link value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the link custom device ID operation.
        /// </summary>
        public class ServerLinkCustomDeviceIdRequestData : LinkCustomDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the link custom device ID operation.
        /// </summary>
        public class AdminLinkCustomDeviceIdRequestData : ServerLinkCustomDeviceIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the link custom ID operation.
        /// </summary>
        public class LinkCustomIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the custom ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CustomId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string customId;

            /// <summary>
            /// Stores the force link value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the link custom ID operation.
        /// </summary>
        public class ServerLinkCustomIdRequestData : LinkCustomIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the link custom ID operation.
        /// </summary>
        public class AdminLinkCustomIdRequestData : ServerLinkCustomIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the link editor device ID operation.
        /// </summary>
        public class LinkEditorDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the editor device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.EditorDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string editorDeviceId;

            /// <summary>
            /// Stores the force link value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the link editor device ID operation.
        /// </summary>
        public class ServerLinkEditorDeviceIdRequestData : LinkEditorDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the link editor device ID operation.
        /// </summary>
        public class AdminLinkEditorDeviceIdRequestData : ServerLinkEditorDeviceIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the link facebook operation.
        /// </summary>
        public class LinkFacebookRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Token, minLength = 32, maxLength = 2048, mustNonNull = true)]
            public string token;

            /// <summary>
            /// Stores the force link value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the link facebook operation.
        /// </summary>
        public class ServerLinkFacebookRequestData : LinkFacebookRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the link facebook operation.
        /// </summary>
        public class AdminLinkFacebookRequestData : ServerLinkFacebookRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the link generic service operation.
        /// </summary>
        public class LinkGenericServiceRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the service name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ServiceName, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string serviceName;

            /// <summary>
            /// Stores the service data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ServiceData, mustNonNull = true)]
            public GNHashtable serviceData;

            /// <summary>
            /// Stores the force link value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the link generic service operation.
        /// </summary>
        public class ServerLinkGenericServiceRequestData : LinkGenericServiceRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the link generic service operation.
        /// </summary>
        public class AdminLinkGenericServiceRequestData : ServerLinkGenericServiceRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the link google operation.
        /// </summary>
        public class LinkGoogleRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Token, minLength = 32, maxLength = 2048, mustNonNull = true)]
            public string token;

            /// <summary>
            /// Stores the type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Type, minValue = 1, maxValue = 2)]
            public int type;

            /// <summary>
            /// Stores the force link value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the link google operation.
        /// </summary>
        public class ServerLinkGoogleRequestData : LinkGoogleRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the link google operation.
        /// </summary>
        public class AdminLinkGoogleRequestData : ServerLinkGoogleRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the link google play game service operation.
        /// </summary>
        public class LinkGooglePlayGameServiceRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Token, minLength = 32, maxLength = 2048, mustNonNull = true)]
            public string token;

            /// <summary>
            /// Stores the force link value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the link google play game service operation.
        /// </summary>
        public class ServerLinkGooglePlayGameServiceRequestData : LinkGooglePlayGameServiceRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the link google play game service operation.
        /// </summary>
        public class AdminLinkGooglePlayGameServiceRequestData : ServerLinkGooglePlayGameServiceRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the link game center operation.
        /// </summary>
        public class LinkGameCenterRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the player ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.PlayerId, minLength = 2, maxLength = 64, mustNonNull = true)]
            public string playerId;

            /// <summary>
            /// Stores the name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Name, minLength = 2, maxLength = 128, mustNonNull = true)]
            public string name;

            /// <summary>
            /// Stores the public key URL value.
            /// </summary>
            [StringDataMember(code = ParameterCode.PublicKeyUrl, minLength = 2, maxLength = 2048, mustNonNull = true)]
            public string publicKeyUrl;

            /// <summary>
            /// Stores the signature value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Signature, minLength = 2, maxLength = 2048, mustNonNull = true)]
            public string signature;

            /// <summary>
            /// Stores the salt value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Salt, minLength = 2, maxLength = 256, mustNonNull = true)]
            public string salt;

            /// <summary>
            /// Stores the timestamp value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Timestamp)]
            public long timestamp;

            /// <summary>
            /// Stores the force link value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the link game center operation.
        /// </summary>
        public class ServerLinkGameCenterRequestData : LinkGameCenterRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the link game center operation.
        /// </summary>
        public class AdminLinkGameCenterRequestData : ServerLinkGameCenterRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the link iOS device ID operation.
        /// </summary>
        public class LinkiOSDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the iOS device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.iOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string iOSDeviceId;

            /// <summary>
            /// Stores the force link value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the link iOS device ID operation.
        /// </summary>
        public class ServerLinkiOSDeviceIdRequestData : LinkiOSDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the link iOS device ID operation.
        /// </summary>
        public class AdminLinkiOSDeviceIdRequestData : ServerLinkiOSDeviceIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the link linux device ID operation.
        /// </summary>
        public class LinkLinuxDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the linux device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.LinuxDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string linuxDeviceId;

            /// <summary>
            /// Stores the force link value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the link linux device ID operation.
        /// </summary>
        public class ServerLinkLinuxDeviceIdRequestData : LinkLinuxDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the link linux device ID operation.
        /// </summary>
        public class AdminLinkLinuxDeviceIdRequestData : ServerLinkLinuxDeviceIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the link macos device ID operation.
        /// </summary>
        public class LinkMacOSDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the mac OS device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.MacOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string macOSDeviceId;

            /// <summary>
            /// Stores the force link value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the link macos device ID operation.
        /// </summary>
        public class ServerLinkMacOSDeviceIdRequestData : LinkMacOSDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the link macos device ID operation.
        /// </summary>
        public class AdminLinkMacOSDeviceIdRequestData : ServerLinkMacOSDeviceIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the link windows device ID operation.
        /// </summary>
        public class LinkWindowsDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the windows device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.WindowsDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string windowsDeviceId;

            /// <summary>
            /// Stores the force link value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the link windows device ID operation.
        /// </summary>
        public class ServerLinkWindowsDeviceIdRequestData : LinkWindowsDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the link windows device ID operation.
        /// </summary>
        public class AdminLinkWindowsDeviceIdRequestData : ServerLinkWindowsDeviceIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the link windows phone device ID operation.
        /// </summary>
        public class LinkWindowsPhoneDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the windows phone device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.WindowsPhoneDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string windowsPhoneDeviceId;

            /// <summary>
            /// Stores the force link value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceLink, isOptional = true, defaultValue = false)]
            public bool? forceLink;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the link windows phone device ID operation.
        /// </summary>
        public class ServerLinkWindowsPhoneDeviceIdRequestData : LinkWindowsPhoneDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the link windows phone device ID operation.
        /// </summary>
        public class AdminLinkWindowsPhoneDeviceIdRequestData : ServerLinkWindowsPhoneDeviceIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the remove segment operation.
        /// </summary>
        public class RemoveSegmentRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string value;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the remove segment operation.
        /// </summary>
        public class ServerRemoveSegmentRequestData : RemoveSegmentRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the remove segment operation.
        /// </summary>
        public class AdminRemoveSegmentRequestData : ServerRemoveSegmentRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the remove tag operation.
        /// </summary>
        public class RemoveTagRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the remove tag operation.
        /// </summary>
        public class ServerRemoveTagRequestData : RemoveTagRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the remove tag operation.
        /// </summary>
        public class AdminRemoveTagRequestData : ServerRemoveTagRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the reset account password operation.
        /// </summary>
        public class ResetAccountPasswordRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the password value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the reset account password operation.
        /// </summary>
        public class ServerResetAccountPasswordRequestData : ResetAccountPasswordRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the reset account password operation.
        /// </summary>
        public class AdminResetAccountPasswordRequestData : ServerResetAccountPasswordRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set avatar operation.
        /// </summary>
        public class SetAvatarRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            /// <summary>
            /// Stores the value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Value, minLength = 1, maxLength = 128, mustNonNull = true)]
            public string value;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the set avatar operation.
        /// </summary>
        public class ServerSetAvatarRequestData : SetAvatarRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set avatar operation.
        /// </summary>
        public class AdminSetAvatarRequestData : ServerSetAvatarRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set country code operation.
        /// </summary>
        public class SetCountryCodeRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the country code value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CountryCode, minLength = 2, maxLength = 32)]
            public string countryCode;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the set country code operation.
        /// </summary>
        public class ServerSetCountryCodeRequestData : SetCountryCodeRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set country code operation.
        /// </summary>
        public class AdminSetCountryCodeRequestData : ServerSetCountryCodeRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set custom data operation.
        /// </summary>
        public class SetCustomDataRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the custom datas value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.CustomDatas, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(CustomDataParam))]
            public List<CustomDataParam> customDatas;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the set custom data operation.
        /// </summary>
        public class ServerSetCustomDataRequestData : SetCustomDataRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set custom data operation.
        /// </summary>
        public class AdminSetCustomDataRequestData : ServerSetCustomDataRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set display name operation.
        /// </summary>
        public class SetDisplayNameRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the display name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.DisplayName, minLength = 5, maxLength = 32, mustNonNull = true)]
            public string displayName;

            /// <summary>
            /// Stores the unique display name value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.UniqueDisplayName, defaultValue = false, isOptional = true)]
            public bool? uniqueDisplayName;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the set display name operation.
        /// </summary>
        public class ServerSetDisplayNameRequestData : SetDisplayNameRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set display name operation.
        /// </summary>
        public class AdminSetDisplayNameRequestData : ServerSetDisplayNameRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set email operation.
        /// </summary>
        public class SetEmailRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the email value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Email, minLength = 5, maxLength = 128, mustNonNull = true)]
            public string email;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the set email operation.
        /// </summary>
        public class ServerSetEmailRequestData : SetEmailRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set email operation.
        /// </summary>
        public class AdminSetEmailRequestData : ServerSetEmailRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set player ban operation.
        /// </summary>
        public class SetPlayerBanRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the timestamp expire value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsExpire)]
            public long tsExpire;

            /// <summary>
            /// Stores the reason value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Reason)]
            public string reason;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the set player ban operation.
        /// </summary>
        public class ServerSetPlayerBanRequestData : SetPlayerBanRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set player ban operation.
        /// </summary>
        public class AdminSetPlayerBanRequestData : ServerSetPlayerBanRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the change player currency operation.
        /// </summary>
        public class ChangePlayerCurrencyRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the player currencies value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerCurrencies, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(PlayerCurrencyParam))]
            public List<PlayerCurrencyParam> playerCurrencies;

            /// <summary>
            /// Stores the log value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the change player currency operation.
        /// </summary>
        public class ServerChangePlayerCurrencyRequestData : ChangePlayerCurrencyRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the change player currency operation.
        /// </summary>
        public class AdminChangePlayerCurrencyRequestData : ServerChangePlayerCurrencyRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set player data operation.
        /// </summary>
        public class SetPlayerDataRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the player datas value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerDatas, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(PlayerDataParam))]
            public List<PlayerDataParam> playerDatas;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the set player data operation.
        /// </summary>
        public class ServerSetPlayerDataRequestData : SetPlayerDataRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set player data operation.
        /// </summary>
        public class AdminSetPlayerDataRequestData : ServerSetPlayerDataRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the change player statistics operation.
        /// </summary>
        public class ChangePlayerStatisticsRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the player statistics value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerStatistics, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(PlayerStatisticsParam))]
            public List<PlayerStatisticsParam> playerStatistics;

            /// <summary>
            /// Stores the log value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the change player statistics operation.
        /// </summary>
        public class ServerChangePlayerStatisticsRequestData : ChangePlayerStatisticsRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the change player statistics operation.
        /// </summary>
        public class AdminChangePlayerStatisticsRequestData : ServerChangePlayerStatisticsRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set tag operation.
        /// </summary>
        public class SetTagRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            /// <summary>
            /// Stores the value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string value;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the set tag operation.
        /// </summary>
        public class ServerSetTagRequestData : SetTagRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set tag operation.
        /// </summary>
        public class AdminSetTagRequestData : ServerSetTagRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set timestamp last login operation.
        /// </summary>
        public class UpdateTsLastLoginRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the set timestamp last login operation.
        /// </summary>
        public class ServerUpdateTsLastLoginRequestData : UpdateTsLastLoginRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set timestamp last login operation.
        /// </summary>
        public class AdminUpdateTsLastLoginRequestData : ServerUpdateTsLastLoginRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the unlink account operation.
        /// </summary>
        public class UnlinkAccountRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Indicates whether username.
            /// </summary>
            [StringDataMember(code = ParameterCode.Username, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string username;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the unlink account operation.
        /// </summary>
        public class ServerUnlinkAccountRequestData : UnlinkAccountRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the unlink account operation.
        /// </summary>
        public class AdminUnlinkAccountRequestData : ServerUnlinkAccountRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the unlink android device ID operation.
        /// </summary>
        public class UnlinkAndroidDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the android device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.AndroidDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string androidDeviceId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the unlink android device ID operation.
        /// </summary>
        public class ServerUnlinkAndroidDeviceIdRequestData : UnlinkAndroidDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the unlink android device ID operation.
        /// </summary>
        public class AdminUnlinkAndroidDeviceIdRequestData : ServerUnlinkAndroidDeviceIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the unlink apple operation.
        /// </summary>
        public class UnlinkAppleRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the apple ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.AppleId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string appleId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the unlink apple operation.
        /// </summary>
        public class ServerUnlinkAppleRequestData : UnlinkAppleRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the unlink apple operation.
        /// </summary>
        public class AdminUnlinkAppleRequestData : ServerUnlinkAppleRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the unlink custom device ID operation.
        /// </summary>
        public class UnlinkCustomDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the custom device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CustomDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string customDeviceId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the unlink custom device ID operation.
        /// </summary>
        public class ServerUnlinkCustomDeviceIdRequestData : UnlinkCustomDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the unlink custom device ID operation.
        /// </summary>
        public class AdminUnlinkCustomDeviceIdRequestData : ServerUnlinkCustomDeviceIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the unlink custom ID operation.
        /// </summary>
        public class UnlinkCustomIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the custom ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CustomId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string customId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the unlink custom ID operation.
        /// </summary>
        public class ServerUnlinkCustomIdRequestData : UnlinkCustomIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the unlink custom ID operation.
        /// </summary>
        public class AdminUnlinkCustomIdRequestData : ServerUnlinkCustomIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the unlink editor device ID operation.
        /// </summary>
        public class UnlinkEditorDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the editor device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.EditorDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string editorDeviceId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the unlink editor device ID operation.
        /// </summary>
        public class ServerUnlinkEditorDeviceIdRequestData : UnlinkEditorDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the unlink editor device ID operation.
        /// </summary>
        public class AdminUnlinkEditorDeviceIdRequestData : ServerUnlinkEditorDeviceIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the unlink facebook operation.
        /// </summary>
        public class UnlinkFacebookRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the facebook ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FacebookId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string facebookId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the unlink facebook operation.
        /// </summary>
        public class ServerUnlinkFacebookRequestData : UnlinkFacebookRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the unlink facebook operation.
        /// </summary>
        public class AdminUnlinkFacebookRequestData : ServerUnlinkFacebookRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the unlink generic service operation.
        /// </summary>
        public class UnlinkGenericServiceRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the service name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ServiceName, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string serviceName;

            /// <summary>
            /// Stores the service ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ServiceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string serviceId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the unlink generic service operation.
        /// </summary>
        public class ServerUnlinkGenericServiceRequestData : UnlinkGenericServiceRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the unlink generic service operation.
        /// </summary>
        public class AdminUnlinkGenericServiceRequestData : ServerUnlinkGenericServiceRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the unlink google operation.
        /// </summary>
        public class UnlinkGoogleRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the google ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GoogleId, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string googleId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the unlink google operation.
        /// </summary>
        public class ServerUnlinkGoogleRequestData : UnlinkGoogleRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the unlink google operation.
        /// </summary>
        public class AdminUnlinkGoogleRequestData : ServerUnlinkGoogleRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the unlink google play game service operation.
        /// </summary>
        public class UnlinkGooglePlayGameServiceRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the player ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.PlayerId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string playerId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the unlink google play game service operation.
        /// </summary>
        public class ServerUnlinkGooglePlayGameServiceRequestData : UnlinkGooglePlayGameServiceRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the unlink google play game service operation.
        /// </summary>
        public class AdminUnlinkGooglePlayGameServiceRequestData : ServerUnlinkGooglePlayGameServiceRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the unlink game center operation.
        /// </summary>
        public class UnlinkGameCenterRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the player ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.PlayerId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string playerId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the unlink game center operation.
        /// </summary>
        public class ServerUnlinkGameCenterRequestData : UnlinkGameCenterRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the unlink game center operation.
        /// </summary>
        public class AdminUnlinkGameCenterRequestData : ServerUnlinkGameCenterRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the unlink iOS device ID operation.
        /// </summary>
        public class UnlinkiOSDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the iOS device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.iOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string iOSDeviceId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the unlink iOS device ID operation.
        /// </summary>
        public class ServerUnlinkiOSDeviceIdRequestData : UnlinkiOSDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the unlink iOS device ID operation.
        /// </summary>
        public class AdminUnlinkiOSDeviceIdRequestData : ServerUnlinkiOSDeviceIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the unlink linux device ID operation.
        /// </summary>
        public class UnlinkLinuxDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the linux device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.LinuxDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string linuxDeviceId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the unlink linux device ID operation.
        /// </summary>
        public class ServerUnlinkLinuxDeviceIdRequestData : UnlinkLinuxDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the unlink linux device ID operation.
        /// </summary>
        public class AdminUnlinkLinuxDeviceIdRequestData : ServerUnlinkLinuxDeviceIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the unlink macos device ID operation.
        /// </summary>
        public class UnlinkMacOSDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the mac OS device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.MacOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string macOSDeviceId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the unlink macos device ID operation.
        /// </summary>
        public class ServerUnlinkMacOSDeviceIdRequestData : UnlinkMacOSDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the unlink macos device ID operation.
        /// </summary>
        public class AdminUnlinkMacOSDeviceIdRequestData : ServerUnlinkMacOSDeviceIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the unlink windows device ID operation.
        /// </summary>
        public class UnlinkWindowsDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the windows device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.WindowsDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string windowsDeviceId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the unlink windows device ID operation.
        /// </summary>
        public class ServerUnlinkWindowsDeviceIdRequestData : UnlinkWindowsDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the unlink windows device ID operation.
        /// </summary>
        public class AdminUnlinkWindowsDeviceIdRequestData : ServerUnlinkWindowsDeviceIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the unlink windows phone device ID operation.
        /// </summary>
        public class UnlinkWindowsPhoneDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the windows phone device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.WindowsPhoneDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string windowsPhoneDeviceId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the unlink windows phone device ID operation.
        /// </summary>
        public class ServerUnlinkWindowsPhoneDeviceIdRequestData : UnlinkWindowsPhoneDeviceIdRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the unlink windows phone device ID operation.
        /// </summary>
        public class AdminUnlinkWindowsPhoneDeviceIdRequestData : ServerUnlinkWindowsPhoneDeviceIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get currency leaderboard operation.
        /// </summary>
        public class GetCurrencyLeaderboardRequestData
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            /// <summary>
            /// Stores the skip value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            /// <summary>
            /// Stores the limit value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            /// <summary>
            /// Stores the load from cache value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.LoadFromCache, defaultValue = true, isOptional = true)]
            public bool? loadFromCache;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get currency leaderboard operation.
        /// </summary>
        public class ServerGetCurrencyLeaderboardRequestData : GetCurrencyLeaderboardRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get currency leaderboard operation.
        /// </summary>
        public class AdminGetCurrencyLeaderboardRequestData : ServerGetCurrencyLeaderboardRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get last login leaderboard operation.
        /// </summary>
        public class GetLastLoginLeaderboardRequestData
        {
            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            /// <summary>
            /// Stores the skip value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            /// <summary>
            /// Stores the limit value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            /// <summary>
            /// Stores the load from cache value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.LoadFromCache, defaultValue = true, isOptional = true)]
            public bool? loadFromCache;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get last login leaderboard operation.
        /// </summary>
        public class ServerGetLastLoginLeaderboardRequestData : GetLastLoginLeaderboardRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get last login leaderboard operation.
        /// </summary>
        public class AdminGetLastLoginLeaderboardRequestData : ServerGetLastLoginLeaderboardRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get create leaderboard operation.
        /// </summary>
        public class GetCreateLeaderboardRequestData
        {
            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            /// <summary>
            /// Stores the skip value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            /// <summary>
            /// Stores the limit value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            /// <summary>
            /// Stores the load from cache value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.LoadFromCache, defaultValue = true, isOptional = true)]
            public bool? loadFromCache;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get create leaderboard operation.
        /// </summary>
        public class ServerGetCreateLeaderboardRequestData : GetCreateLeaderboardRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get create leaderboard operation.
        /// </summary>
        public class AdminGetCreateLeaderboardRequestData : ServerGetCreateLeaderboardRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get statistics log operation.
        /// </summary>
        public class GetStatisticsLogRequestData
        {
            /// <summary>
            /// Stores the keys value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Keys, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(string), isOptional = true)]
            public List<string>? keys;

            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the limit value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            /// <summary>
            /// Stores the token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Token, minLength = 24, maxLength = 24, mustNonNull = true, isOptional = true)]
            public string? token;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get statistics log operation.
        /// </summary>
        public class ServerGetStatisticsLogRequestData : GetStatisticsLogRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get statistics log operation.
        /// </summary>
        public class AdminGetStatisticsLogRequestData : ServerGetStatisticsLogRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get currency log operation.
        /// </summary>
        public class GetCurrencyLogRequestData
        {
            /// <summary>
            /// Stores the keys value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Keys, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(string), isOptional = true)]
            public List<string>? keys;

            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the limit value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            /// <summary>
            /// Stores the token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Token, minLength = 24, maxLength = 24, mustNonNull = true, isOptional = true)]
            public string? token;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get currency log operation.
        /// </summary>
        public class ServerGetCurrencyLogRequestData : GetCurrencyLogRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get currency log operation.
        /// </summary>
        public class AdminGetCurrencyLogRequestData : ServerGetCurrencyLogRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the send socket operation event operation.
        /// </summary>
        public class SendSocketOperationEventRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the event code value.
            /// </summary>
            [StringDataMember(code = ParameterCode.EventCode, minLength = 1, maxLength = 64)]
            public string eventCode;

            /// <summary>
            /// Stores the event parameters value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.EventParameters, minLength = 0, maxLength = 128, mustNonNull = true, isOptional = true)]
            public GNHashtable? eventParameters;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the send socket operation event operation.
        /// </summary>
        public class ServerSendSocketOperationEventRequestData : SendSocketOperationEventRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the send socket operation event operation.
        /// </summary>
        public class AdminSendSocketOperationEventRequestData : ServerSendSocketOperationEventRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the send email operation.
        /// </summary>
        public class SendEmailRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the subject value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Subject, minLength = 2, maxLength = 256, mustNonNull = true)]
            public string subject;

            /// <summary>
            /// Stores the content html value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ContentHtml, minLength = 2, maxLength = 8192, mustNonNull = true)]
            public string contentHtml;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the send email operation.
        /// </summary>
        public class ServerSendEmailRequestData : SendEmailRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the send email operation.
        /// </summary>
        public class AdminSendEmailRequestData : ServerSendEmailRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the add push notification operation.
        /// </summary>
        public class AddPushNotificationRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Token, minLength = 10, maxLength = 256, mustNonNull = true)]
            public string token;

            /// <summary>
            /// Stores the platform type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.PlatformType, minValue = 1, mustInt = true)]
            public int platformType;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the add push notification operation.
        /// </summary>
        public class ServerAddPushNotificationRequestData : AddPushNotificationRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the add push notification operation.
        /// </summary>
        public class AdminAddPushNotificationRequestData : ServerAddPushNotificationRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get push notification operation.
        /// </summary>
        public class GetPushNotificationRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get push notification operation.
        /// </summary>
        public class ServerGetPushNotificationRequestData : GetPushNotificationRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get push notification operation.
        /// </summary>
        public class AdminGetPushNotificationRequestData : ServerGetPushNotificationRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the remove push notification operation.
        /// </summary>
        public class RemovePushNotificationRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the push ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.PushId, minLength = 8, maxLength = 8, mustNonNull = true)]
            public string pushId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the remove push notification operation.
        /// </summary>
        public class ServerRemovePushNotificationRequestData : RemovePushNotificationRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the remove push notification operation.
        /// </summary>
        public class AdminRemovePushNotificationRequestData : ServerRemovePushNotificationRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the send push notification operation.
        /// </summary>
        public class SendPushNotificationRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the title value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Title)]
            public string title;

            /// <summary>
            /// Stores the body value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Body)]
            public string body;

            /// <summary>
            /// Stores the badge value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Badge, mustInt = true, isOptional = true)]
            public int? badge;

            /// <summary>
            /// Stores the sound value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Sound, isOptional = true)]
            public string? sound;

            /// <summary>
            /// Stores the icon value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Icon, isOptional = true)]
            public string? icon;

            /// <summary>
            /// Stores the data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Data, isOptional = true)]
            public GNHashtable? data;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the send push notification operation.
        /// </summary>
        public class ServerSendPushNotificationRequestData : SendPushNotificationRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the send push notification operation.
        /// </summary>
        public class AdminSendPushNotificationRequestData : ServerSendPushNotificationRequestData
        {
        }

    }

    /// <summary>
    /// Defines payload models for master player operations.
    /// </summary>
    public partial class MasterPlayerModels
    {
        /// <summary>
        /// Represents the custom data param component.
        /// </summary>
        public class CustomDataParam
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            /// <summary>
            /// Stores the value.
            /// </summary>
            [DataMember(code = ParameterCode.Value)]
            public object value;

        }

        /// <summary>
        /// Represents the info request param component.
        /// </summary>
        public class InfoRequestParam
        {
            /// <summary>
            /// Stores the external value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.External, isOptional = true, defaultValue = false)]
            public bool? external;

            /// <summary>
            /// Stores the segments value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Segments, isOptional = true, defaultValue = false)]
            public bool? segments;

            /// <summary>
            /// Stores the custom datas value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CustomDatas, isOptional = true, defaultValue = false)]
            public bool? customDatas;

            /// <summary>
            /// Stores the display name value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.DisplayName, isOptional = true, defaultValue = false)]
            public bool? displayName;

            /// <summary>
            /// Stores the avatar value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Avatar, isOptional = true, defaultValue = false)]
            public bool? avatar;

            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.TsCreate, isOptional = true, defaultValue = false)]
            public bool? tsCreate;

            /// <summary>
            /// Stores the tags value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Tags, isOptional = true, defaultValue = false)]
            public bool? tags;

            /// <summary>
            /// Stores the player ban value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.PlayerBan, isOptional = true, defaultValue = false)]
            public bool? playerBan;

            /// <summary>
            /// Stores the player currencies value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.PlayerCurrencies, isOptional = true, defaultValue = false)]
            public bool? playerCurrencies;

            /// <summary>
            /// Stores the player statistics value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.PlayerStatistics, isOptional = true, defaultValue = false)]
            public bool? playerStatistics;

            /// <summary>
            /// Stores the player datas value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.PlayerDatas, isOptional = true, defaultValue = false)]
            public bool? playerDatas;

            /// <summary>
            /// Stores the IP address create value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.IpAddressCreate, isOptional = true, defaultValue = false)]
            public bool? ipAddressCreate;

            /// <summary>
            /// Stores the country code value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CountryCode, isOptional = true, defaultValue = false)]
            public bool? countryCode;

            /// <summary>
            /// Stores the email value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Email, isOptional = true, defaultValue = false)]
            public bool? email;

            /// <summary>
            /// Stores the timestamp last login value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.TsLastLogin, isOptional = true, defaultValue = false)]
            public bool? tsLastLogin;

            /// <summary>
            /// Stores the push notifications value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.PushNotifications, isOptional = true, defaultValue = false)]
            public bool? pushNotifications;

            /// <summary>
            /// Stores the player data key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerDataKeys;

            /// <summary>
            /// Stores the player currency key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerCurrencyKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerCurrencyKeys;

            /// <summary>
            /// Stores the player statistics key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerStatisticsKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerStatisticsKeys;

            /// <summary>
            /// Stores the custom data key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.CustomDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? customDataKeys;

            /// <summary>
            /// Stores the tag key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.TagKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? tagKeys;

        }

        /// <summary>
        /// Represents the player currency param component.
        /// </summary>
        public class PlayerCurrencyParam
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            /// <summary>
            /// Stores the amount value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Amount)]
            public double amount;

        }

        /// <summary>
        /// Represents the player data param component.
        /// </summary>
        public class PlayerDataParam
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            /// <summary>
            /// Stores the value.
            /// </summary>
            [DataMember(code = ParameterCode.Value)]
            public object value;

        }

        /// <summary>
        /// Represents the player statistics param component.
        /// </summary>
        public class PlayerStatisticsParam
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            /// <summary>
            /// Stores the value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Value)]
            public double value;

        }

    }

    /// <summary>
    /// Defines payload models for master player operations.
    /// </summary>
    public partial class MasterPlayerModels
    {
        /// <summary>
        /// Represents the external item component.
        /// </summary>
        public class ExternalItem
        {
            /// <summary>
            /// Represents the device component.
            /// </summary>
            public class Device
            {
                /// <summary>
                /// Stores the custom device ID value.
                /// </summary>
                [StringDataMember(code = ParameterCode.CustomDeviceId, isOptional = true)]
                public string? customDeviceId;

                /// <summary>
                /// Stores the android device ID value.
                /// </summary>
                [StringDataMember(code = ParameterCode.AndroidDeviceId, isOptional = true)]
                public string? androidDeviceId;

                /// <summary>
                /// Stores the iOS device ID value.
                /// </summary>
                [StringDataMember(code = ParameterCode.iOSDeviceId, isOptional = true)]
                public string? iOSDeviceId;

                /// <summary>
                /// Stores the windows phone device ID value.
                /// </summary>
                [StringDataMember(code = ParameterCode.WindowsPhoneDeviceId, isOptional = true)]
                public string? windowsPhoneDeviceId;

                /// <summary>
                /// Stores the windows device ID value.
                /// </summary>
                [StringDataMember(code = ParameterCode.WindowsDeviceId, isOptional = true)]
                public string? windowsDeviceId;

                /// <summary>
                /// Stores the linux device ID value.
                /// </summary>
                [StringDataMember(code = ParameterCode.LinuxDeviceId, isOptional = true)]
                public string? linuxDeviceId;

                /// <summary>
                /// Stores the mac OS device ID value.
                /// </summary>
                [StringDataMember(code = ParameterCode.MacOSDeviceId, isOptional = true)]
                public string? macOSDeviceId;

                /// <summary>
                /// Stores the editor device ID value.
                /// </summary>
                [StringDataMember(code = ParameterCode.EditorDeviceId, isOptional = true)]
                public string? editorDeviceId;

            }

            /// <summary>
            /// Represents the account component.
            /// </summary>
            public class Account
            {
                /// <summary>
                /// Indicates whether username.
                /// </summary>
                [StringDataMember(code = ParameterCode.Username, isOptional = true)]
                public string? username;

            }

            /// <summary>
            /// Represents the custom component.
            /// </summary>
            public class Custom
            {
                /// <summary>
                /// Stores the custom ID value.
                /// </summary>
                [StringDataMember(code = ParameterCode.CustomId, isOptional = true)]
                public string? customId;

            }

            /// <summary>
            /// Represents the apple component.
            /// </summary>
            public class Apple
            {
                /// <summary>
                /// Stores the apple ID value.
                /// </summary>
                [StringDataMember(code = ParameterCode.AppleId)]
                public string appleId;

                /// <summary>
                /// Stores the email value.
                /// </summary>
                [StringDataMember(code = ParameterCode.Email)]
                public string email;

            }

            /// <summary>
            /// Represents the google component.
            /// </summary>
            public class Google
            {
                /// <summary>
                /// Stores the google ID value.
                /// </summary>
                [StringDataMember(code = ParameterCode.GoogleId)]
                public string googleId;

                /// <summary>
                /// Stores the display name value.
                /// </summary>
                [StringDataMember(code = ParameterCode.DisplayName)]
                public string displayName;

                /// <summary>
                /// Stores the email value.
                /// </summary>
                [StringDataMember(code = ParameterCode.Email)]
                public string email;

            }

            /// <summary>
            /// Represents the google play game service component.
            /// </summary>
            public class GooglePlayGameService
            {
                /// <summary>
                /// Stores the player ID value.
                /// </summary>
                [StringDataMember(code = ParameterCode.PlayerId)]
                public string playerId;

                /// <summary>
                /// Stores the display name value.
                /// </summary>
                [StringDataMember(code = ParameterCode.DisplayName)]
                public string displayName;

                /// <summary>
                /// Stores the email value.
                /// </summary>
                [StringDataMember(code = ParameterCode.Email)]
                public string email;

            }

            /// <summary>
            /// Represents the game center component.
            /// </summary>
            public class GameCenter
            {
                /// <summary>
                /// Stores the player ID value.
                /// </summary>
                [StringDataMember(code = ParameterCode.PlayerId)]
                public string playerId;

                /// <summary>
                /// Stores the display name value.
                /// </summary>
                [StringDataMember(code = ParameterCode.DisplayName)]
                public string displayName;

                /// <summary>
                /// Stores the email value.
                /// </summary>
                [StringDataMember(code = ParameterCode.Email)]
                public string email;

            }

            /// <summary>
            /// Represents the facebook component.
            /// </summary>
            public class Facebook
            {
                /// <summary>
                /// Stores the facebook ID value.
                /// </summary>
                [StringDataMember(code = ParameterCode.FacebookId)]
                public string facebookId;

                /// <summary>
                /// Stores the display name value.
                /// </summary>
                [StringDataMember(code = ParameterCode.DisplayName)]
                public string displayName;

                /// <summary>
                /// Stores the email value.
                /// </summary>
                [StringDataMember(code = ParameterCode.Email)]
                public string email;

            }

            /// <summary>
            /// Represents the generic service component.
            /// </summary>
            public class GenericService
            {
                /// <summary>
                /// Stores the service name value.
                /// </summary>
                [StringDataMember(code = ParameterCode.ServiceName)]
                public string serviceName;

                /// <summary>
                /// Stores the service ID value.
                /// </summary>
                [StringDataMember(code = ParameterCode.ServiceId)]
                public string serviceId;

            }

            /// <summary>
            /// Stores the device value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Device, isOptional = true)]
            public Device? device;

            /// <summary>
            /// Stores the account value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Account, isOptional = true)]
            public Account? account;

            /// <summary>
            /// Stores the custom value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Custom, isOptional = true)]
            public Custom? custom;

            /// <summary>
            /// Stores the apple value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Apple, isOptional = true)]
            public Apple? apple;

            /// <summary>
            /// Stores the google value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Google, isOptional = true)]
            public Google? google;

            /// <summary>
            /// Stores the facebook value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Facebook, isOptional = true)]
            public Facebook? facebook;

            /// <summary>
            /// Stores the generic services value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GenericService, isOptional = true, elementCls = typeof(GenericService))]
            public List<GenericService> genericServices;

            /// <summary>
            /// Stores the google play game service value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GooglePlayGameService, isOptional = true)]
            public GooglePlayGameService? googlePlayGameService;

            /// <summary>
            /// Stores the game center value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GameCenter, isOptional = true)]
            public GameCenter? gameCenter;

        }

        /// <summary>
        /// Represents the push notification item component.
        /// </summary>
        public class PushNotificationItem
        {
            /// <summary>
            /// Stores the token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Token)]
            public string token;

            /// <summary>
            /// Stores the push ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.PushId)]
            public string pushId;

            /// <summary>
            /// Stores the platform type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.PlatformType)]
            public int platformType;

        }

        /// <summary>
        /// Represents the info response parameters component.
        /// </summary>
        public class InfoResponseParameters
        {
            /// <summary>
            /// Stores the external value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.External, isOptional = true)]
            public ExternalItem? external;

            /// <summary>
            /// Stores the segments value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Segments, isOptional = true, elementCls = typeof(string))]
            public List<string>? segments;

            /// <summary>
            /// Stores the custom datas value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.CustomDatas, isOptional = true, elementCls = typeof(GenericModels.DataItem))]
            public List<GenericModels.DataItem>? customDatas;

            /// <summary>
            /// Stores the display name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.DisplayName, isOptional = true)]
            public string? displayName;

            /// <summary>
            /// Stores the avatar value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Avatar, isOptional = true)]
            public GenericModels.AvatarItem? avatar;

            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsCreate, isOptional = true)]
            public long? tsCreate;

            /// <summary>
            /// Stores the tags value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Tags, isOptional = true, elementCls = typeof(GenericModels.TagItem))]
            public List<GenericModels.TagItem>? tags;

            /// <summary>
            /// Stores the player ban value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.PlayerBan, isOptional = true)]
            public GenericModels.BanItem? playerBan;

            /// <summary>
            /// Stores the player datas value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerDatas, isOptional = true, elementCls = typeof(GenericModels.DataItem))]
            public List<GenericModels.DataItem>? playerDatas;

            /// <summary>
            /// Stores the player currencies value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerCurrencies, isOptional = true, elementCls = typeof(GenericModels.CurrencyItem))]
            public List<GenericModels.CurrencyItem>? playerCurrencies;

            /// <summary>
            /// Stores the player statistics value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerStatistics, isOptional = true, elementCls = typeof(GenericModels.StatisticsItem))]
            public List<GenericModels.StatisticsItem>? playerStatistics;

            /// <summary>
            /// Stores the timestamp last login value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsLastLogin, isOptional = true)]
            public long? tsLastLogin;

            /// <summary>
            /// Stores the IP address create value.
            /// </summary>
            [StringDataMember(code = ParameterCode.IpAddressCreate, isOptional = true)]
            public string? ipAddressCreate;

            /// <summary>
            /// Stores the country code value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CountryCode, isOptional = true)]
            public string? countryCode;

            /// <summary>
            /// Stores the email value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Email, isOptional = true)]
            public string? email;

            /// <summary>
            /// Stores the push notifications value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PushNotifications, isOptional = true, elementCls = typeof(MasterPlayerModels.PushNotificationItem))]
            public List<MasterPlayerModels.PushNotificationItem>? pushNotifications;

        }

        /// <summary>
        /// Represents the response payload for the master player operation.
        /// </summary>
        public class MasterPlayerResponseData
        {
            /// <summary>
            /// Stores the info response parameters value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoResponseParameters)]
            public InfoResponseParameters infoResponseParameters;

        }

        /// <summary>
        /// Represents the response payload for the generic service master player operation.
        /// </summary>
        public class GenericServiceMasterPlayerResponseData : MasterPlayerResponseData
        {
            /// <summary>
            /// Stores the error message value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ErrorMessage, isOptional = true)]
            public string? errorMessage;

        }

        /// <summary>
        /// Represents the response payload for the master player with user ID operation.
        /// </summary>
        public class MasterPlayerWithUserIdResponseData : MasterPlayerResponseData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId)]
            public string userId;

        }

        /// <summary>
        /// Represents the response payload for the master player with apple ID operation.
        /// </summary>
        public class MasterPlayerWithAppleIdResponseData : MasterPlayerWithUserIdResponseData
        {
            /// <summary>
            /// Stores the apple ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.AppleId)]
            public string appleId;

        }

        /// <summary>
        /// Represents the response payload for the get players with apple operation.
        /// </summary>
        public class GetPlayersWithAppleResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerWithAppleIdResponseData))]
            public List<MasterPlayerWithAppleIdResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the master players with user ID operation.
        /// </summary>
        public class MasterPlayersWithUserIdResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerWithUserIdResponseData))]
            public List<MasterPlayerWithUserIdResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the master player with facebook ID operation.
        /// </summary>
        public class MasterPlayerWithFacebookIdResponseData : MasterPlayerWithUserIdResponseData
        {
            /// <summary>
            /// Stores the facebook ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FacebookId)]
            public string facebookId;

        }

        /// <summary>
        /// Represents the response payload for the get players with facebook operation.
        /// </summary>
        public class GetPlayersWithFacebookResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerWithFacebookIdResponseData))]
            public List<MasterPlayerWithFacebookIdResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the master player with generic service ID operation.
        /// </summary>
        public class MasterPlayerWithGenericServiceIdResponseData : MasterPlayerWithUserIdResponseData
        {
            /// <summary>
            /// Stores the service ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ServiceId)]
            public string serviceId;

        }

        /// <summary>
        /// Represents the response payload for the get players with generic service operation.
        /// </summary>
        public class GetPlayersWithGenericServiceResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerWithGenericServiceIdResponseData))]
            public List<MasterPlayerWithGenericServiceIdResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the master player with google ID operation.
        /// </summary>
        public class MasterPlayerWithGoogleIdResponseData : MasterPlayerWithUserIdResponseData
        {
            /// <summary>
            /// Stores the google ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GoogleId)]
            public string googleId;

        }

        /// <summary>
        /// Represents the response payload for the get players with google operation.
        /// </summary>
        public class GetPlayersWithGoogleResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerWithGoogleIdResponseData))]
            public List<MasterPlayerWithGoogleIdResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the master player with player ID operation.
        /// </summary>
        public class MasterPlayerWithPlayerIdResponseData : MasterPlayerWithUserIdResponseData
        {
            /// <summary>
            /// Stores the player ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.PlayerId)]
            public string playerId;

        }

        /// <summary>
        /// Represents the response payload for the get players with google play game service operation.
        /// </summary>
        public class GetPlayersWithGooglePlayGameServiceResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerWithPlayerIdResponseData))]
            public List<MasterPlayerWithPlayerIdResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the get players with game center operation.
        /// </summary>
        public class GetPlayersWithGameCenterResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerWithPlayerIdResponseData))]
            public List<MasterPlayerWithPlayerIdResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the master player leaderboard operation.
        /// </summary>
        public class MasterPlayerLeaderboardResponseData : MasterPlayerWithUserIdResponseData
        {
            /// <summary>
            /// Stores the position value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Position)]
            public int position;

            /// <summary>
            /// Stores the backup value value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.BackupValue, isOptional = true)]
            public double? backupValue;

        }

        /// <summary>
        /// Represents the response payload for the master player log operation.
        /// </summary>
        public class MasterPlayerLogResponseData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId)]
            public string userId;

            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            /// <summary>
            /// Stores the log value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Log)]
            public string log;

            /// <summary>
            /// Stores the key value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Key)]
            public string key;

            /// <summary>
            /// Stores the amount value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Amount)]
            public double amount;

            /// <summary>
            /// Stores the start value value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.StartValue)]
            public double startValue;

            /// <summary>
            /// Stores the final value value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.FinalValue)]
            public double finalValue;

        }

        /// <summary>
        /// Represents the response payload for the get statistics leaderboard operation.
        /// </summary>
        public class GetStatisticsLeaderboardResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerLeaderboardResponseData))]
            public List<MasterPlayerLeaderboardResponseData> results;

            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsCreate, isOptional = true)]
            public long? tsCreate;

        }

        /// <summary>
        /// Represents the response payload for the get currency leaderboard operation.
        /// </summary>
        public class GetCurrencyLeaderboardResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerLeaderboardResponseData))]
            public List<MasterPlayerLeaderboardResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the get last login leaderboard operation.
        /// </summary>
        public class GetLastLoginLeaderboardResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerLeaderboardResponseData))]
            public List<MasterPlayerLeaderboardResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the get create leaderboard operation.
        /// </summary>
        public class GetCreateLeaderboardResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerLeaderboardResponseData))]
            public List<MasterPlayerLeaderboardResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the get statistics log operation.
        /// </summary>
        public class GetStatisticsLogResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerLogResponseData))]
            public List<MasterPlayerLogResponseData> results;

            /// <summary>
            /// Stores the token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Token, isOptional = true)]
            public string? token;

        }

        /// <summary>
        /// Represents the response payload for the get currency log operation.
        /// </summary>
        public class GetCurrencyLogResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MasterPlayerLogResponseData))]
            public List<MasterPlayerLogResponseData> results;

            /// <summary>
            /// Stores the token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Token, isOptional = true)]
            public string? token;

        }

        /// <summary>
        /// Represents the response payload for the add push notification operation.
        /// </summary>
        public class AddPushNotificationResponseData
        {
            /// <summary>
            /// Stores the push ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.PushId)]
            public string pushId;

        }

        /// <summary>
        /// Represents the response payload for the send push notification operation.
        /// </summary>
        public class SendPushNotificationResponseData
        {
            /// <summary>
            /// Stores the message value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Message)]
            public string message;

        }

        /// <summary>
        /// Represents the response payload for the empty operation.
        /// </summary>
        public class EmptyResponseData
        {

        }

    }

}