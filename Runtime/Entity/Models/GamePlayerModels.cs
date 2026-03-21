namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;

    /// <summary>
    /// Defines payload models for game player operations.
    /// </summary>
    public partial class GamePlayerModels
    {
        /// <summary>
        /// Represents the request payload for the add player friend operation.
        /// </summary>
        public class AddPlayerFriendRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the friend ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FriendId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string friendId;

            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string catalogId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the add player friend operation.
        /// </summary>
        public class ServerAddPlayerFriendRequestData : AddPlayerFriendRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the add player friend operation.
        /// </summary>
        public class AdminAddPlayerFriendRequestData : ServerAddPlayerFriendRequestData
        {
        }

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
            [StringDataMember(code = ParameterCode.Value, minLength = 6, maxLength = 32, mustNonNull = true)]
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
        /// Represents the request payload for the get friend statistics leaderboard around player operation.
        /// </summary>
        public class GetFriendStatisticsLeaderboardAroundPlayerRequestData
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
        /// Represents the server-scoped request payload for the get friend statistics leaderboard around player operation.
        /// </summary>
        public class ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData : GetFriendStatisticsLeaderboardAroundPlayerRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get friend statistics leaderboard around player operation.
        /// </summary>
        public class AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData : ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get friend statistics leaderboard operation.
        /// </summary>
        public class GetFriendStatisticsLeaderboardRequestData
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
        /// Represents the server-scoped request payload for the get friend statistics leaderboard operation.
        /// </summary>
        public class ServerGetFriendStatisticsLeaderboardRequestData : GetFriendStatisticsLeaderboardRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get friend statistics leaderboard operation.
        /// </summary>
        public class AdminGetFriendStatisticsLeaderboardRequestData : ServerGetFriendStatisticsLeaderboardRequestData
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
        /// Represents the request payload for the get online status operation.
        /// </summary>
        public class GetOnlineStatusRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get online status operation.
        /// </summary>
        public class ServerGetOnlineStatusRequestData : GetOnlineStatusRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get online status operation.
        /// </summary>
        public class AdminGetOnlineStatusRequestData : ServerGetOnlineStatusRequestData
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
        /// Represents the request payload for the get player character operation.
        /// </summary>
        public class GetPlayerCharacterRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the character catalog ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.CharacterCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? characterCatalogIds;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get player character operation.
        /// </summary>
        public class ServerGetPlayerCharacterRequestData : GetPlayerCharacterRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get player character operation.
        /// </summary>
        public class AdminGetPlayerCharacterRequestData : ServerGetPlayerCharacterRequestData
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
        /// Represents the request payload for the get player friend operation.
        /// </summary>
        public class GetPlayerFriendRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the friend catalog ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.FriendCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? friendCatalogIds;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get player friend operation.
        /// </summary>
        public class ServerGetPlayerFriendRequestData : GetPlayerFriendRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get player friend operation.
        /// </summary>
        public class AdminGetPlayerFriendRequestData : ServerGetPlayerFriendRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get player group operation.
        /// </summary>
        public class GetPlayerGroupRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the group catalog ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? groupCatalogIds;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get player group operation.
        /// </summary>
        public class ServerGetPlayerGroupRequestData : GetPlayerGroupRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get player group operation.
        /// </summary>
        public class AdminGetPlayerGroupRequestData : ServerGetPlayerGroupRequestData
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

            /// <summary>
            /// Stores the create player if not exists value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get player information operation.
        /// </summary>
        public class AdminGetPlayerInformationRequestData : ServerGetPlayerInformationRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get player inventory operation.
        /// </summary>
        public class GetPlayerInventoryRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the item catalog ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.ItemCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? itemCatalogIds;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get player inventory operation.
        /// </summary>
        public class ServerGetPlayerInventoryRequestData : GetPlayerInventoryRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get player inventory operation.
        /// </summary>
        public class AdminGetPlayerInventoryRequestData : ServerGetPlayerInventoryRequestData
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
            /// Stores the statistics key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StatisticsKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? statisticsKeys;

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
        /// Represents the request payload for the create group operation.
        /// </summary>
        public class CreateGroupRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string catalogId;

            /// <summary>
            /// Stores the group members value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupMembers, isOptional = true, elementCls = typeof(GroupMemberParam))]
            public List<GroupMemberParam>? groupMembers;

            /// <summary>
            /// Stores the display name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.DisplayName, defaultValue = "", isOptional = true)]
            public string? displayName;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the create group operation.
        /// </summary>
        public class ServerCreateGroupRequestData : CreateGroupRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the create group operation.
        /// </summary>
        public class AdminCreateGroupRequestData : ServerCreateGroupRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the create player character operation.
        /// </summary>
        public class CreatePlayerCharacterRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string catalogId;

            /// <summary>
            /// Stores the display name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.DisplayName, defaultValue = "", isOptional = true, mustNonNull = true)]
            public string? displayName;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the create player character operation.
        /// </summary>
        public class ServerCreatePlayerCharacterRequestData : CreatePlayerCharacterRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the create player character operation.
        /// </summary>
        public class AdminCreatePlayerCharacterRequestData : ServerCreatePlayerCharacterRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the create player item operation.
        /// </summary>
        public class CreatePlayerItemRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string catalogId;

            /// <summary>
            /// Stores the class ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ClassId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string classId;

            /// <summary>
            /// Stores the display name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.DisplayName, defaultValue = "", isOptional = true)]
            public string? displayName;

            /// <summary>
            /// Stores the amount value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Amount, defaultValue = 1, mustInt = true, isOptional = true)]
            public int? amount;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the create player item operation.
        /// </summary>
        public class ServerCreatePlayerItemRequestData : CreatePlayerItemRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the create player item operation.
        /// </summary>
        public class AdminCreatePlayerItemRequestData : ServerCreatePlayerItemRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the join group operation.
        /// </summary>
        public class JoinGroupRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the join group operation.
        /// </summary>
        public class ServerJoinGroupRequestData : JoinGroupRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the join group operation.
        /// </summary>
        public class AdminJoinGroupRequestData : ServerJoinGroupRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the leave group operation.
        /// </summary>
        public class LeaveGroupRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the leave group operation.
        /// </summary>
        public class ServerLeaveGroupRequestData : LeaveGroupRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the leave group operation.
        /// </summary>
        public class AdminLeaveGroupRequestData : ServerLeaveGroupRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the remove player character operation.
        /// </summary>
        public class RemovePlayerCharacterRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the character ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
            public string characterId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the remove player character operation.
        /// </summary>
        public class ServerRemovePlayerCharacterRequestData : RemovePlayerCharacterRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the remove player character operation.
        /// </summary>
        public class AdminRemovePlayerCharacterRequestData : ServerRemovePlayerCharacterRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the remove player friend operation.
        /// </summary>
        public class RemovePlayerFriendRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the friend ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FriendId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string friendId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the remove player friend operation.
        /// </summary>
        public class ServerRemovePlayerFriendRequestData : RemovePlayerFriendRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the remove player friend operation.
        /// </summary>
        public class AdminRemovePlayerFriendRequestData : ServerRemovePlayerFriendRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the remove player item operation.
        /// </summary>
        public class RemovePlayerItemRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the remove player item operation.
        /// </summary>
        public class ServerRemovePlayerItemRequestData : RemovePlayerItemRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the remove player item operation.
        /// </summary>
        public class AdminRemovePlayerItemRequestData : ServerRemovePlayerItemRequestData
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

    }

    /// <summary>
    /// Defines payload models for game player operations.
    /// </summary>
    public partial class GamePlayerModels
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
        /// Represents the group member param component.
        /// </summary>
        public class GroupMemberParam
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string userId;

        }

        /// <summary>
        /// Represents the info request param component.
        /// </summary>
        public class InfoRequestParam
        {
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
            /// Stores the timestamp last login value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.TsLastLogin, isOptional = true, defaultValue = false)]
            public bool? tsLastLogin;

            /// <summary>
            /// Stores the player characters value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.PlayerCharacters, isOptional = true, defaultValue = false)]
            public bool? playerCharacters;

            /// <summary>
            /// Stores the player inventories value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.PlayerInventories, isOptional = true, defaultValue = false)]
            public bool? playerInventories;

            /// <summary>
            /// Stores the player groups value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.PlayerGroups, isOptional = true, defaultValue = false)]
            public bool? playerGroups;

            /// <summary>
            /// Stores the player friends value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.PlayerFriends, isOptional = true, defaultValue = false)]
            public bool? playerFriends;

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

            /// <summary>
            /// Stores the character catalog ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.CharacterCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? characterCatalogIds;

            /// <summary>
            /// Stores the item catalog ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.ItemCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? itemCatalogIds;

            /// <summary>
            /// Stores the group catalog ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? groupCatalogIds;

            /// <summary>
            /// Stores the friend catalog ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.FriendCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? friendCatalogIds;

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
    /// Defines payload models for game player operations.
    /// </summary>
    public partial class GamePlayerModels
    {
        /// <summary>
        /// Represents the info response parameters component.
        /// </summary>
        public class InfoResponseParameters
        {
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
            /// Stores the player characters value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerCharacters, isOptional = true, elementCls = typeof(GenericModels.CharacterItem))]
            public List<GenericModels.CharacterItem>? playerCharacters;

            /// <summary>
            /// Stores the player inventories value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerInventories, isOptional = true, elementCls = typeof(GenericModels.InventoryItem))]
            public List<GenericModels.InventoryItem>? playerInventories;

            /// <summary>
            /// Stores the player groups value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerGroups, isOptional = true, elementCls = typeof(GenericModels.GroupItem))]
            public List<GenericModels.GroupItem>? playerGroups;

            /// <summary>
            /// Stores the player friends value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerFriends, isOptional = true, elementCls = typeof(GenericModels.FriendItem))]
            public List<GenericModels.FriendItem>? playerFriends;

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
        }

        /// <summary>
        /// Represents the response payload for the game player operation.
        /// </summary>
        public class GamePlayerResponseData
        {
            /// <summary>
            /// Stores the info response parameters value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoResponseParameters)]
            public InfoResponseParameters infoResponseParameters;

        }

        /// <summary>
        /// Represents the response payload for the game player with user ID operation.
        /// </summary>
        public class GamePlayerWithUserIdResponseData : GamePlayerResponseData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId)]
            public string userId;

        }

        /// <summary>
        /// Represents the response payload for the game player leaderboard operation.
        /// </summary>
        public class GamePlayerLeaderboardResponseData : GamePlayerWithUserIdResponseData
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
        /// Represents the response payload for the game player log operation.
        /// </summary>
        public class GamePlayerLogResponseData
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
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GamePlayerLeaderboardResponseData))]
            public List<GamePlayerLeaderboardResponseData> results;

            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsCreate, isOptional = true)]
            public long? tsCreate;

        }

        /// <summary>
        /// Represents the response payload for the game players with user ID operation.
        /// </summary>
        public class GamePlayersWithUserIdResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GamePlayerWithUserIdResponseData))]
            public List<GamePlayerWithUserIdResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the online status operation.
        /// </summary>
        public class OnlineStatusResponseData
        {
            /// <summary>
            /// Stores the timestamp last login value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsLastLogin)]
            public long tsLastLogin;

            /// <summary>
            /// Stores the socket ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.SocketId)]
            public string socketId;

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
        /// Represents the response payload for the get currency leaderboard operation.
        /// </summary>
        public class GetCurrencyLeaderboardResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GamePlayerLeaderboardResponseData))]
            public List<GamePlayerLeaderboardResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the get create leaderboard operation.
        /// </summary>
        public class GetCreateLeaderboardResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GamePlayerLeaderboardResponseData))]
            public List<GamePlayerLeaderboardResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the get statistics log operation.
        /// </summary>
        public class GetStatisticsLogResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GamePlayerLogResponseData))]
            public List<GamePlayerLogResponseData> results;

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
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GamePlayerLogResponseData))]
            public List<GamePlayerLogResponseData> results;

            /// <summary>
            /// Stores the token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Token, isOptional = true)]
            public string? token;

        }

        /// <summary>
        /// Represents the response payload for the empty operation.
        /// </summary>
        public class EmptyResponseData
        {

        }

    }

}