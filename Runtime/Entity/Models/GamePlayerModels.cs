namespace XmobiTea.GN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public partial class GamePlayerModels
    {
        public class AddPlayerFriendRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = GNParameterCode.FriendId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string friendId;

            [StringDataMember(code = GNParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string catalogId;

        }

        public class ServerAddPlayerFriendRequestData : AddPlayerFriendRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminAddPlayerFriendRequestData : ServerAddPlayerFriendRequestData
        {
        }

        public class AddSegmentRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = GNParameterCode.Value, minLength = 6, maxLength = 32, mustNonNull = true)]
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

        public class GetFriendStatisticsLeaderboardAroundPlayerRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            [BooleanDataMember(code = GNParameterCode.LoadFromCache, defaultValue = true, isOptional = true)]
            public bool? loadFromCache;

        }

        public class ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData : GetFriendStatisticsLeaderboardAroundPlayerRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData : ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData
        {
        }

        public class GetFriendStatisticsLeaderboardRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            [BooleanDataMember(code = GNParameterCode.LoadFromCache, defaultValue = true, isOptional = true)]
            public bool? loadFromCache;

        }

        public class ServerGetFriendStatisticsLeaderboardRequestData : GetFriendStatisticsLeaderboardRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetFriendStatisticsLeaderboardRequestData : ServerGetFriendStatisticsLeaderboardRequestData
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

        public class GetOnlineStatusRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        public class ServerGetOnlineStatusRequestData : GetOnlineStatusRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetOnlineStatusRequestData : ServerGetOnlineStatusRequestData
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

        public class GetPlayerCharacterRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = GNParameterCode.CharacterCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? characterCatalogIds;

        }

        public class ServerGetPlayerCharacterRequestData : GetPlayerCharacterRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetPlayerCharacterRequestData : ServerGetPlayerCharacterRequestData
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

        public class GetPlayerFriendRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = GNParameterCode.FriendCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? friendCatalogIds;

        }

        public class ServerGetPlayerFriendRequestData : GetPlayerFriendRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetPlayerFriendRequestData : ServerGetPlayerFriendRequestData
        {
        }

        public class GetPlayerGroupRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = GNParameterCode.GroupCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? groupCatalogIds;

        }

        public class ServerGetPlayerGroupRequestData : GetPlayerGroupRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetPlayerGroupRequestData : ServerGetPlayerGroupRequestData
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

            [BooleanDataMember(code = GNParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

        }

        public class AdminGetPlayerInformationRequestData : ServerGetPlayerInformationRequestData
        {
        }

        public class GetPlayerInventoryRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = GNParameterCode.ItemCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? itemCatalogIds;

        }

        public class ServerGetPlayerInventoryRequestData : GetPlayerInventoryRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetPlayerInventoryRequestData : ServerGetPlayerInventoryRequestData
        {
        }

        public class GetPlayerStatisticsRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = GNParameterCode.StatisticsKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? statisticsKeys;

        }

        public class ServerGetPlayerStatisticsRequestData : GetPlayerStatisticsRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetPlayerStatisticsRequestData : ServerGetPlayerStatisticsRequestData
        {
        }

        public class GetPlayersWithDisplayNameRequestData
        {
            [StringDataMember(code = GNParameterCode.Keyword, minLength = 2, maxLength = 32)]
            public string keyword;

            [GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

        }

        public class ServerGetPlayersWithDisplayNameRequestData : GetPlayersWithDisplayNameRequestData
        {
        }

        public class AdminGetPlayersWithDisplayNameRequestData : ServerGetPlayersWithDisplayNameRequestData
        {
        }

        public class GetPlayersWithSegmentRequestData
        {
            [StringDataMember(code = GNParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string value;

            [GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
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
            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [StringDataMember(code = GNParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string value;

            [GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
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
            public int? skip;

            [NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            [BooleanDataMember(code = GNParameterCode.LoadFromCache, defaultValue = true, isOptional = true)]
            public bool? loadFromCache;

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
            public int? skip;

            [NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            [BooleanDataMember(code = GNParameterCode.LoadFromCache, defaultValue = true, isOptional = true)]
            public bool? loadFromCache;

            [StringDataMember(code = GNParameterCode.Version, minLength = 2, maxLength = 32, mustNonNull = true, isOptional = true)]
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

        public class GrantGroupRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = GNParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string catalogId;

            [GNArrayDataMember(code = GNParameterCode.GroupMembers, isOptional = true, elementCls = typeof(GroupMemberParam))]
            public List<GroupMemberParam>? groupMembers;

            [StringDataMember(code = GNParameterCode.DisplayName, defaultValue = "", isOptional = true)]
            public string? displayName;

        }

        public class ServerGrantGroupRequestData : GrantGroupRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGrantGroupRequestData : ServerGrantGroupRequestData
        {
        }

        public class GrantPlayerCharacterRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = GNParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string catalogId;

            [StringDataMember(code = GNParameterCode.DisplayName, defaultValue = "", isOptional = true, mustNonNull = true)]
            public string? displayName;

        }

        public class ServerGrantPlayerCharacterRequestData : GrantPlayerCharacterRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGrantPlayerCharacterRequestData : ServerGrantPlayerCharacterRequestData
        {
        }

        public class GrantPlayerItemRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = GNParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string catalogId;

            [StringDataMember(code = GNParameterCode.ClassId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string classId;

            [StringDataMember(code = GNParameterCode.DisplayName, defaultValue = "", isOptional = true)]
            public string? displayName;

            [NumberDataMember(code = GNParameterCode.Amount, defaultValue = 1, mustInt = true, isOptional = true)]
            public int? amount;

        }

        public class ServerGrantPlayerItemRequestData : GrantPlayerItemRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGrantPlayerItemRequestData : ServerGrantPlayerItemRequestData
        {
        }

        public class JoinGroupRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

        }

        public class ServerJoinGroupRequestData : JoinGroupRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminJoinGroupRequestData : ServerJoinGroupRequestData
        {
        }

        public class LeaveGroupRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

        }

        public class ServerLeaveGroupRequestData : LeaveGroupRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLeaveGroupRequestData : ServerLeaveGroupRequestData
        {
        }

        public class RemovePlayerCharacterRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
            public string characterId;

        }

        public class ServerRemovePlayerCharacterRequestData : RemovePlayerCharacterRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminRemovePlayerCharacterRequestData : ServerRemovePlayerCharacterRequestData
        {
        }

        public class RemovePlayerFriendRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = GNParameterCode.FriendId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string friendId;

        }

        public class ServerRemovePlayerFriendRequestData : RemovePlayerFriendRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminRemovePlayerFriendRequestData : ServerRemovePlayerFriendRequestData
        {
        }

        public class RemovePlayerItemRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        public class ServerRemovePlayerItemRequestData : RemovePlayerItemRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminRemovePlayerItemRequestData : ServerRemovePlayerItemRequestData
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

        public class SetAvatarRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [NumberDataMember(code = GNParameterCode.Type, mustInt = true)]
            public int type;

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

        public class SetPlayerBanRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [NumberDataMember(code = GNParameterCode.TsExpire)]
            public long tsExpire;

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

            [StringDataMember(code = GNParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

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

            [StringDataMember(code = GNParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

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

        public class GetCreateLeaderboardRequestData
        {
            [GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            [BooleanDataMember(code = GNParameterCode.LoadFromCache, defaultValue = true, isOptional = true)]
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
            [GNArrayDataMember(code = GNParameterCode.Keys, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(string), isOptional = true)]
            public List<string>? keys;

            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true, isOptional = true)]
            public string? userId;

            [NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            [StringDataMember(code = GNParameterCode.Token, minLength = 24, maxLength = 24, mustNonNull = true, isOptional = true)]
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
            [GNArrayDataMember(code = GNParameterCode.Keys, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(string), isOptional = true)]
            public List<string>? keys;

            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true, isOptional = true)]
            public string? userId;

            [NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            [StringDataMember(code = GNParameterCode.Token, minLength = 24, maxLength = 24, mustNonNull = true, isOptional = true)]
            public string? token;

        }

        public class ServerGetCurrencyLogRequestData : GetCurrencyLogRequestData
        {
        }

        public class AdminGetCurrencyLogRequestData : ServerGetCurrencyLogRequestData
        {
        }

    }

    public partial class GamePlayerModels
    {
        public class CustomDataParam
        {
            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [DataMember(code = GNParameterCode.Value)]
            public object value;

        }

        public class GroupMemberParam
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string userId;

        }

        public class InfoRequestParam
        {
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

            [BooleanDataMember(code = GNParameterCode.TsLastLogin, isOptional = true, defaultValue = false)]
            public bool? tsLastLogin;

            [BooleanDataMember(code = GNParameterCode.PlayerCharacters, isOptional = true, defaultValue = false)]
            public bool? playerCharacters;

            [BooleanDataMember(code = GNParameterCode.PlayerInventories, isOptional = true, defaultValue = false)]
            public bool? playerInventories;

            [BooleanDataMember(code = GNParameterCode.PlayerGroups, isOptional = true, defaultValue = false)]
            public bool? playerGroups;

            [BooleanDataMember(code = GNParameterCode.PlayerFriends, isOptional = true, defaultValue = false)]
            public bool? playerFriends;

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

            [GNArrayDataMember(code = GNParameterCode.CharacterCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? characterCatalogIds;

            [GNArrayDataMember(code = GNParameterCode.ItemCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? itemCatalogIds;

            [GNArrayDataMember(code = GNParameterCode.GroupCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? groupCatalogIds;

            [GNArrayDataMember(code = GNParameterCode.FriendCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? friendCatalogIds;

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

    public partial class GamePlayerModels
    {
        public class InfoResponseParameters
        {
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

            [GNArrayDataMember(code = GNParameterCode.PlayerCharacters, isOptional = true, elementCls = typeof(GenericModels.CharacterItem))]
            public List<GenericModels.CharacterItem>? playerCharacters;

            [GNArrayDataMember(code = GNParameterCode.PlayerInventories, isOptional = true, elementCls = typeof(GenericModels.InventoryItem))]
            public List<GenericModels.InventoryItem>? playerInventories;

            [GNArrayDataMember(code = GNParameterCode.PlayerGroups, isOptional = true, elementCls = typeof(GenericModels.GroupItem))]
            public List<GenericModels.GroupItem>? playerGroups;

            [GNArrayDataMember(code = GNParameterCode.PlayerFriends, isOptional = true, elementCls = typeof(GenericModels.FriendItem))]
            public List<GenericModels.FriendItem>? playerFriends;

            [NumberDataMember(code = GNParameterCode.TsLastLogin, isOptional = true)]
            public long? tsLastLogin;

            [StringDataMember(code = GNParameterCode.IpAddressCreate, isOptional = true)]
            public string? ipAddressCreate;

            [StringDataMember(code = GNParameterCode.CountryCode, isOptional = true)]
            public string? countryCode;
        }

        public class GamePlayerResponseData
        {
            [GNHashtableDataMember(code = GNParameterCode.InfoResponseParameters)]
            public InfoResponseParameters infoResponseParameters;

        }

        public class GamePlayerWithUserIdResponseData : GamePlayerResponseData
        {
            [StringDataMember(code = GNParameterCode.UserId)]
            public string userId;

        }

        public class GamePlayerLeaderboardResponseData : GamePlayerWithUserIdResponseData
        {
            [NumberDataMember(code = GNParameterCode.Position)]
            public int position;

            [NumberDataMember(code = GNParameterCode.BackupValue, isOptional = true)]
            public double? backupValue;

        }

        public class GamePlayerLogResponseData
        {
            [StringDataMember(code = GNParameterCode.UserId)]
            public string userId;

            [NumberDataMember(code = GNParameterCode.TsCreate)]
            public long tsCreate;

            [NumberDataMember(code = GNParameterCode.Log)]
            public string log;

            [NumberDataMember(code = GNParameterCode.Key)]
            public string key;

            [NumberDataMember(code = GNParameterCode.Amount)]
            public double amount;

            [NumberDataMember(code = GNParameterCode.StartValue)]
            public double startValue;

            [NumberDataMember(code = GNParameterCode.FinalValue)]
            public double finalValue;

        }

        public class GetStatisticsLeaderboardResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(GamePlayerLeaderboardResponseData))]
            public List<GamePlayerLeaderboardResponseData> results;

            [NumberDataMember(code = GNParameterCode.TsCreate, isOptional = true)]
            public long? tsCreate;

        }

        public class GamePlayersWithUserIdResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(GamePlayerWithUserIdResponseData))]
            public List<GamePlayerWithUserIdResponseData> results;

        }

        public class OnlineStatusResponseData
        {
            [NumberDataMember(code = GNParameterCode.TsLastLogin)]
            public long tsLastLogin;

            [StringDataMember(code = GNParameterCode.SocketId)]
            public string socketId;

        }

        public class GetCurrencyLeaderboardRequestData
        {
            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            [BooleanDataMember(code = GNParameterCode.LoadFromCache, defaultValue = true, isOptional = true)]
            public bool? loadFromCache;

        }

        public class ServerGetCurrencyLeaderboardRequestData : GetCurrencyLeaderboardRequestData
        {
        }

        public class AdminGetCurrencyLeaderboardRequestData : ServerGetCurrencyLeaderboardRequestData
        {
        }

        public class GetCurrencyLeaderboardResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(GamePlayerLeaderboardResponseData))]
            public List<GamePlayerLeaderboardResponseData> results;

        }

        public class GetCreateLeaderboardResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(GamePlayerLeaderboardResponseData))]
            public List<GamePlayerLeaderboardResponseData> results;

        }

        public class GetStatisticsLogResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(GamePlayerLogResponseData))]
            public List<GamePlayerLogResponseData> results;

            [StringDataMember(code = GNParameterCode.Token, isOptional = true)]
            public string? token;

        }

        public class GetCurrencyLogResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(GamePlayerLogResponseData))]
            public List<GamePlayerLogResponseData> results;

            [StringDataMember(code = GNParameterCode.Token, isOptional = true)]
            public string? token;

        }

        public class EmptyResponseData
        {

        }

    }

}
