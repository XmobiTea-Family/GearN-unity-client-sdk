namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;

    public partial class GamePlayerModels
    {
        public class AddPlayerFriendRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.FriendId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string friendId;

            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string catalogId;

        }

        public class ServerAddPlayerFriendRequestData : AddPlayerFriendRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminAddPlayerFriendRequestData : ServerAddPlayerFriendRequestData
        {
        }

        public class AddSegmentRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.Value, minLength = 6, maxLength = 32, mustNonNull = true)]
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

        public class GetFriendStatisticsLeaderboardAroundPlayerRequestData
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

        public class ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData : GetFriendStatisticsLeaderboardAroundPlayerRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData : ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData
        {
        }

        public class GetFriendStatisticsLeaderboardRequestData
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

        public class ServerGetFriendStatisticsLeaderboardRequestData : GetFriendStatisticsLeaderboardRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetFriendStatisticsLeaderboardRequestData : ServerGetFriendStatisticsLeaderboardRequestData
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

        public class GetOnlineStatusRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

        }

        public class ServerGetOnlineStatusRequestData : GetOnlineStatusRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetOnlineStatusRequestData : ServerGetOnlineStatusRequestData
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

        public class GetPlayerCharacterRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = ParameterCode.CharacterCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? characterCatalogIds;

        }

        public class ServerGetPlayerCharacterRequestData : GetPlayerCharacterRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetPlayerCharacterRequestData : ServerGetPlayerCharacterRequestData
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

        public class GetPlayerFriendRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = ParameterCode.FriendCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? friendCatalogIds;

        }

        public class ServerGetPlayerFriendRequestData : GetPlayerFriendRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetPlayerFriendRequestData : ServerGetPlayerFriendRequestData
        {
        }

        public class GetPlayerGroupRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = ParameterCode.GroupCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? groupCatalogIds;

        }

        public class ServerGetPlayerGroupRequestData : GetPlayerGroupRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetPlayerGroupRequestData : ServerGetPlayerGroupRequestData
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

            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

        }

        public class AdminGetPlayerInformationRequestData : ServerGetPlayerInformationRequestData
        {
        }

        public class GetPlayerInventoryRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = ParameterCode.ItemCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? itemCatalogIds;

        }

        public class ServerGetPlayerInventoryRequestData : GetPlayerInventoryRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetPlayerInventoryRequestData : ServerGetPlayerInventoryRequestData
        {
        }

        public class GetPlayerStatisticsRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [GNArrayDataMember(code = ParameterCode.StatisticsKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? statisticsKeys;

        }

        public class ServerGetPlayerStatisticsRequestData : GetPlayerStatisticsRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminGetPlayerStatisticsRequestData : ServerGetPlayerStatisticsRequestData
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

        public class CreateGroupRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string catalogId;

            [GNArrayDataMember(code = ParameterCode.GroupMembers, isOptional = true, elementCls = typeof(GroupMemberParam))]
            public List<GroupMemberParam>? groupMembers;

            [StringDataMember(code = ParameterCode.DisplayName, defaultValue = "", isOptional = true)]
            public string? displayName;

        }

        public class ServerCreateGroupRequestData : CreateGroupRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminCreateGroupRequestData : ServerCreateGroupRequestData
        {
        }

        public class CreatePlayerCharacterRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string catalogId;

            [StringDataMember(code = ParameterCode.DisplayName, defaultValue = "", isOptional = true, mustNonNull = true)]
            public string? displayName;

        }

        public class ServerCreatePlayerCharacterRequestData : CreatePlayerCharacterRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminCreatePlayerCharacterRequestData : ServerCreatePlayerCharacterRequestData
        {
        }

        public class CreatePlayerItemRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string catalogId;

            [StringDataMember(code = ParameterCode.ClassId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string classId;

            [StringDataMember(code = ParameterCode.DisplayName, defaultValue = "", isOptional = true)]
            public string? displayName;

            [NumberDataMember(code = ParameterCode.Amount, defaultValue = 1, mustInt = true, isOptional = true)]
            public int? amount;

        }

        public class ServerCreatePlayerItemRequestData : CreatePlayerItemRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminCreatePlayerItemRequestData : ServerCreatePlayerItemRequestData
        {
        }

        public class JoinGroupRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

        }

        public class ServerJoinGroupRequestData : JoinGroupRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminJoinGroupRequestData : ServerJoinGroupRequestData
        {
        }

        public class LeaveGroupRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

        }

        public class ServerLeaveGroupRequestData : LeaveGroupRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminLeaveGroupRequestData : ServerLeaveGroupRequestData
        {
        }

        public class RemovePlayerCharacterRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
            public string characterId;

        }

        public class ServerRemovePlayerCharacterRequestData : RemovePlayerCharacterRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminRemovePlayerCharacterRequestData : ServerRemovePlayerCharacterRequestData
        {
        }

        public class RemovePlayerFriendRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.FriendId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string friendId;

        }

        public class ServerRemovePlayerFriendRequestData : RemovePlayerFriendRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminRemovePlayerFriendRequestData : ServerRemovePlayerFriendRequestData
        {
        }

        public class RemovePlayerItemRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        public class ServerRemovePlayerItemRequestData : RemovePlayerItemRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminRemovePlayerItemRequestData : ServerRemovePlayerItemRequestData
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

    }

    public partial class GamePlayerModels
    {
        public class CustomDataParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [DataMember(code = ParameterCode.Value)]
            public object value;

        }

        public class GroupMemberParam
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string userId;

        }

        public class InfoRequestParam
        {
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

            [BooleanDataMember(code = ParameterCode.TsLastLogin, isOptional = true, defaultValue = false)]
            public bool? tsLastLogin;

            [BooleanDataMember(code = ParameterCode.PlayerCharacters, isOptional = true, defaultValue = false)]
            public bool? playerCharacters;

            [BooleanDataMember(code = ParameterCode.PlayerInventories, isOptional = true, defaultValue = false)]
            public bool? playerInventories;

            [BooleanDataMember(code = ParameterCode.PlayerGroups, isOptional = true, defaultValue = false)]
            public bool? playerGroups;

            [BooleanDataMember(code = ParameterCode.PlayerFriends, isOptional = true, defaultValue = false)]
            public bool? playerFriends;

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

            [GNArrayDataMember(code = ParameterCode.CharacterCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? characterCatalogIds;

            [GNArrayDataMember(code = ParameterCode.ItemCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? itemCatalogIds;

            [GNArrayDataMember(code = ParameterCode.GroupCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? groupCatalogIds;

            [GNArrayDataMember(code = ParameterCode.FriendCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? friendCatalogIds;

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

    public partial class GamePlayerModels
    {
        public class InfoResponseParameters
        {
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

            [GNArrayDataMember(code = ParameterCode.PlayerCharacters, isOptional = true, elementCls = typeof(GenericModels.CharacterItem))]
            public List<GenericModels.CharacterItem>? playerCharacters;

            [GNArrayDataMember(code = ParameterCode.PlayerInventories, isOptional = true, elementCls = typeof(GenericModels.InventoryItem))]
            public List<GenericModels.InventoryItem>? playerInventories;

            [GNArrayDataMember(code = ParameterCode.PlayerGroups, isOptional = true, elementCls = typeof(GenericModels.GroupItem))]
            public List<GenericModels.GroupItem>? playerGroups;

            [GNArrayDataMember(code = ParameterCode.PlayerFriends, isOptional = true, elementCls = typeof(GenericModels.FriendItem))]
            public List<GenericModels.FriendItem>? playerFriends;

            [NumberDataMember(code = ParameterCode.TsLastLogin, isOptional = true)]
            public long? tsLastLogin;

            [StringDataMember(code = ParameterCode.IpAddressCreate, isOptional = true)]
            public string? ipAddressCreate;

            [StringDataMember(code = ParameterCode.CountryCode, isOptional = true)]
            public string? countryCode;
        }

        public class GamePlayerResponseData
        {
            [GNHashtableDataMember(code = ParameterCode.InfoResponseParameters)]
            public InfoResponseParameters infoResponseParameters;

        }

        public class GamePlayerWithUserIdResponseData : GamePlayerResponseData
        {
            [StringDataMember(code = ParameterCode.UserId)]
            public string userId;

        }

        public class GamePlayerLeaderboardResponseData : GamePlayerWithUserIdResponseData
        {
            [NumberDataMember(code = ParameterCode.Position)]
            public int position;

            [NumberDataMember(code = ParameterCode.BackupValue, isOptional = true)]
            public double? backupValue;

        }

        public class GamePlayerLogResponseData
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
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GamePlayerLeaderboardResponseData))]
            public List<GamePlayerLeaderboardResponseData> results;

            [NumberDataMember(code = ParameterCode.TsCreate, isOptional = true)]
            public long? tsCreate;

        }

        public class GamePlayersWithUserIdResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GamePlayerWithUserIdResponseData))]
            public List<GamePlayerWithUserIdResponseData> results;

        }

        public class OnlineStatusResponseData
        {
            [NumberDataMember(code = ParameterCode.TsLastLogin)]
            public long tsLastLogin;

            [StringDataMember(code = ParameterCode.SocketId)]
            public string socketId;

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

        public class GetCurrencyLeaderboardResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GamePlayerLeaderboardResponseData))]
            public List<GamePlayerLeaderboardResponseData> results;

        }

        public class GetCreateLeaderboardResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GamePlayerLeaderboardResponseData))]
            public List<GamePlayerLeaderboardResponseData> results;

        }

        public class GetStatisticsLogResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GamePlayerLogResponseData))]
            public List<GamePlayerLogResponseData> results;

            [StringDataMember(code = ParameterCode.Token, isOptional = true)]
            public string? token;

        }

        public class GetCurrencyLogResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GamePlayerLogResponseData))]
            public List<GamePlayerLogResponseData> results;

            [StringDataMember(code = ParameterCode.Token, isOptional = true)]
            public string? token;

        }

        public class EmptyResponseData
        {

        }

    }

}
