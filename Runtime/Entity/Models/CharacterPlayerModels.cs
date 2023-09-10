namespace XmobiTea.GN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;

	public partial class CharacterPlayerModels
	{
		public class AddPlayerFriendRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[StringDataMember(code = GNParameterCode.FriendId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string friendId;

			[StringDataMember(code = GNParameterCode.FriendCatalogId, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string friendCatalogId;

		}

		public class ServerAddPlayerFriendRequestData : AddPlayerFriendRequestData
		{
		}

		public class AdminAddPlayerFriendRequestData : AddPlayerFriendRequestData
		{
		}

		public class AddSegmentRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[StringDataMember(code = GNParameterCode.Value, minLength = 6, maxLength = 32, mustNonNull = true)]
			public string value;

		}

		public class ServerAddSegmentRequestData : AddSegmentRequestData
		{
		}

		public class AdminAddSegmentRequestData : AddSegmentRequestData
		{
		}

		public class GetAvatarRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

		}

		public class ServerGetAvatarRequestData : GetAvatarRequestData
		{
		}

		public class AdminGetAvatarRequestData : GetAvatarRequestData
		{
		}

		public class GetCatalogIdRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

		}

		public class ServerGetCatalogIdRequestData : GetCatalogIdRequestData
		{
		}

		public class AdminGetCatalogIdRequestData : GetCatalogIdRequestData
		{
		}

		public class GetCountryCodeRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

		}

		public class ServerGetCountryCodeRequestData : GetCountryCodeRequestData
		{
		}

		public class AdminGetCountryCodeRequestData : GetCountryCodeRequestData
		{
		}

		public class GetCustomDataRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[GNArrayDataMember(code = GNParameterCode.CustomDataKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? customDataKeys;

		}

		public class ServerGetCustomDataRequestData : GetCustomDataRequestData
		{
		}

		public class AdminGetCustomDataRequestData : GetCustomDataRequestData
		{
		}

		public class GetDisplayNameRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

		}

		public class ServerGetDisplayNameRequestData : GetDisplayNameRequestData
		{
		}

		public class AdminGetDisplayNameRequestData : GetDisplayNameRequestData
		{
		}

		public class GetFriendStatisticsLeaderboardAroundPlayerRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

			[NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
			public long? skip;

			[NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
			public long? limit;

		}

		public class ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData : GetFriendStatisticsLeaderboardAroundPlayerRequestData
		{
		}

		public class AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData : GetFriendStatisticsLeaderboardAroundPlayerRequestData
		{
		}

		public class GetFriendStatisticsLeaderboardRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

			[NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
			public long? skip;

			[NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
			public long? limit;

		}

		public class ServerGetFriendStatisticsLeaderboardRequestData : GetFriendStatisticsLeaderboardRequestData
		{
		}

		public class AdminGetFriendStatisticsLeaderboardRequestData : GetFriendStatisticsLeaderboardRequestData
		{
		}

		public class GetIpAddressCreateRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

		}

		public class ServerGetIpAddressCreateRequestData : GetIpAddressCreateRequestData
		{
		}

		public class AdminGetIpAddressCreateRequestData : GetIpAddressCreateRequestData
		{
		}

		public class GetOwnerRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

		}

		public class ServerGetOwnerRequestData : GetOwnerRequestData
		{
		}

		public class AdminGetOwnerRequestData : GetOwnerRequestData
		{
		}

		public class GetPlayerBanRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

		}

		public class ServerGetPlayerBanRequestData : GetPlayerBanRequestData
		{
		}

		public class AdminGetPlayerBanRequestData : GetPlayerBanRequestData
		{
		}

		public class GetPlayerCurrencyRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[GNArrayDataMember(code = GNParameterCode.PlayerCurrencyKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? playerCurrencyKeys;

		}

		public class ServerGetPlayerCurrencyRequestData : GetPlayerCurrencyRequestData
		{
		}

		public class AdminGetPlayerCurrencyRequestData : GetPlayerCurrencyRequestData
		{
		}

		public class GetPlayerDataRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[GNArrayDataMember(code = GNParameterCode.PlayerDataKeys, isOptional = true)]
			public List<string>? playerDataKeys;

		}

		public class ServerGetPlayerDataRequestData : GetPlayerDataRequestData
		{
		}

		public class AdminGetPlayerDataRequestData : GetPlayerDataRequestData
		{
		}

		public class GetPlayerFriendRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[GNArrayDataMember(code = GNParameterCode.FriendCatalogIds, isOptional = true, elementCls = typeof(string))]
			public List<string>? friendCatalogIds;

		}

		public class ServerGetPlayerFriendRequestData : GetPlayerFriendRequestData
		{
		}

		public class AdminGetPlayerFriendRequestData : GetPlayerFriendRequestData
		{
		}

		public class GetPlayerGroupRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[GNArrayDataMember(code = GNParameterCode.GroupCatalogIds, isOptional = true, elementCls = typeof(string))]
			public List<string>? groupCatalogIds;

		}

		public class ServerGetPlayerGroupRequestData : GetPlayerGroupRequestData
		{
		}

		public class AdminGetPlayerGroupRequestData : GetPlayerGroupRequestData
		{
		}

		public class GetPlayerInformationRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class ServerGetPlayerInformationRequestData : GetPlayerInformationRequestData
		{
		}

		public class AdminGetPlayerInformationRequestData : GetPlayerInformationRequestData
		{
		}

		public class GetPlayerInventoryRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[GNArrayDataMember(code = GNParameterCode.ItemCatalogIds, isOptional = true, elementCls = typeof(string))]
			public List<string>? itemCatalogIds;

		}

		public class ServerGetPlayerInventoryRequestData : GetPlayerInventoryRequestData
		{
		}

		public class AdminGetPlayerInventoryRequestData : GetPlayerInventoryRequestData
		{
		}

		public class GetPlayerStatisticsRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[GNArrayDataMember(code = GNParameterCode.StatisticsKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? statisticsKeys;

		}

		public class ServerGetPlayerStatisticsRequestData : GetPlayerStatisticsRequestData
		{
		}

		public class AdminGetPlayerStatisticsRequestData : GetPlayerStatisticsRequestData
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

		public class GetRemoveStatusRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

		}

		public class ServerGetRemoveStatusRequestData : GetRemoveStatusRequestData
		{
		}

		public class AdminGetRemoveStatusRequestData : GetRemoveStatusRequestData
		{
		}

		public class GetSegmentRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

		}

		public class ServerGetSegmentRequestData : GetSegmentRequestData
		{
		}

		public class AdminGetSegmentRequestData : GetSegmentRequestData
		{
		}

		public class GetStatisticsLeaderboardAroundPlayerRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

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
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[GNArrayDataMember(code = GNParameterCode.TagKeys, elementCls = typeof(string))]
			public List<string> tagKeys;

		}

		public class ServerGetTagRequestData : GetTagRequestData
		{
		}

		public class AdminGetTagRequestData : GetTagRequestData
		{
		}

		public class GetTsCreateRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

		}

		public class ServerGetTsCreateRequestData : GetTsCreateRequestData
		{
		}

		public class AdminGetTsCreateRequestData : GetTsCreateRequestData
		{
		}

		public class GetTsLastLoginRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

		}

		public class ServerGetTsLastLoginRequestData : GetTsLastLoginRequestData
		{
		}

		public class AdminGetTsLastLoginRequestData : GetTsLastLoginRequestData
		{
		}

		public class GrantGroupRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[StringDataMember(code = GNParameterCode.GroupCatalogId, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string groupCatalogId;

			[GNArrayDataMember(code = GNParameterCode.GroupMembers, isOptional = true, elementCls = typeof(GroupMemberParam))]
			public List<GroupMemberParam>? groupMembers;

			[StringDataMember(code = GNParameterCode.DisplayName, defaultValue = "", isOptional = true)]
			public string? displayName;

		}

		public class ServerGrantGroupRequestData : GrantGroupRequestData
		{
		}

		public class AdminGrantGroupRequestData : GrantGroupRequestData
		{
		}

		public class GrantPlayerItemRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[StringDataMember(code = GNParameterCode.ItemCatalogId, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string itemCatalogId;

			[StringDataMember(code = GNParameterCode.ItemClassId, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string itemClassId;

			[StringDataMember(code = GNParameterCode.DisplayName, defaultValue = "", isOptional = true)]
			public string? displayName;

			[NumberDataMember(code = GNParameterCode.Amount, defaultValue = 1, isOptional = true)]
			public double? amount;

		}

		public class ServerGrantPlayerItemRequestData : GrantPlayerItemRequestData
		{
		}

		public class AdminGrantPlayerItemRequestData : GrantPlayerItemRequestData
		{
		}

		public class JoinGroupRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string characterId;

			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

		}

		public class ServerJoinGroupRequestData : JoinGroupRequestData
		{
		}

		public class AdminJoinGroupRequestData : JoinGroupRequestData
		{
		}

		public class LeaveGroupRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string characterId;

			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

		}

		public class ServerLeaveGroupRequestData : LeaveGroupRequestData
		{
		}

		public class AdminLeaveGroupRequestData : LeaveGroupRequestData
		{
		}

		public class RemovePlayerFriendRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[StringDataMember(code = GNParameterCode.FriendId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string friendId;

		}

		public class ServerRemovePlayerFriendRequestData : RemovePlayerFriendRequestData
		{
		}

		public class AdminRemovePlayerFriendRequestData : RemovePlayerFriendRequestData
		{
		}

		public class RemovePlayerItemRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
			public string itemId;

		}

		public class ServerRemovePlayerItemRequestData : RemovePlayerItemRequestData
		{
		}

		public class AdminRemovePlayerItemRequestData : RemovePlayerItemRequestData
		{
		}

		public class RemoveSegmentRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[StringDataMember(code = GNParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string value;

		}

		public class ServerRemoveSegmentRequestData : RemoveSegmentRequestData
		{
		}

		public class AdminRemoveSegmentRequestData : RemoveSegmentRequestData
		{
		}

		public class RemoveTagRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[StringDataMember(code = GNParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

		}

		public class ServerRemoveTagRequestData : RemoveTagRequestData
		{
		}

		public class AdminRemoveTagRequestData : RemoveTagRequestData
		{
		}

		public class SetAvatarRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[NumberDataMember(code = GNParameterCode.Type, mustInt = true)]
			public long type;

			[StringDataMember(code = GNParameterCode.Value, minLength = 1, maxLength = 128, mustNonNull = true)]
			public string value;

		}

		public class ServerSetAvatarRequestData : SetAvatarRequestData
		{
		}

		public class AdminSetAvatarRequestData : SetAvatarRequestData
		{
		}

		public class SetCountryCodeRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[StringDataMember(code = GNParameterCode.CountryCode, minLength = 2, maxLength = 32)]
			public string countryCode;

		}

		public class ServerSetCountryCodeRequestData : SetCountryCodeRequestData
		{
		}

		public class AdminSetCountryCodeRequestData : SetCountryCodeRequestData
		{
		}

		public class SetCustomDataRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[GNArrayDataMember(code = GNParameterCode.CustomDatas, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(CustomDataParam))]
			public List<CustomDataParam> customData;

		}

		public class ServerSetCustomDataRequestData : SetCustomDataRequestData
		{
		}

		public class AdminSetCustomDataRequestData : SetCustomDataRequestData
		{
		}

		public class SetDisplayNameRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[StringDataMember(code = GNParameterCode.DisplayName, minLength = 5, maxLength = 32, mustNonNull = true)]
			public string displayName;

		}

		public class ServerSetDisplayNameRequestData : SetDisplayNameRequestData
		{
		}

		public class AdminSetDisplayNameRequestData : SetDisplayNameRequestData
		{
		}

		public class SetOwnerRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[StringDataMember(code = GNParameterCode.OwnerId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string newOwnerId;

		}

		public class ServerSetOwnerRequestData : SetOwnerRequestData
		{
		}

		public class AdminSetOwnerRequestData : SetOwnerRequestData
		{
		}

		public class SetPlayerBanRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[NumberDataMember(code = GNParameterCode.TsExpire)]
			public double tsExpire;

			[StringDataMember(code = GNParameterCode.Reason)]
			public string reason;

		}

		public class ServerSetPlayerBanRequestData : SetPlayerBanRequestData
		{
		}

		public class AdminSetPlayerBanRequestData : SetPlayerBanRequestData
		{
		}

		public class SetPlayerCurrencyRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[GNArrayDataMember(code = GNParameterCode.PlayerCurrencies, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(PlayerCurrencyParam))]
			public List<PlayerCurrencyParam> playerCurrencyParams;

		}

		public class ServerSetPlayerCurrencyRequestData : SetPlayerCurrencyRequestData
		{
		}

		public class AdminSetPlayerCurrencyRequestData : SetPlayerCurrencyRequestData
		{
		}

		public class SetPlayerDataRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[GNArrayDataMember(code = GNParameterCode.PlayerDatas, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(PlayerDataParam))]
			public List<PlayerDataParam> playerDataParams;

		}

		public class ServerSetPlayerDataRequestData : SetPlayerDataRequestData
		{
		}

		public class AdminSetPlayerDataRequestData : SetPlayerDataRequestData
		{
		}

		public class SetPlayerStatisticsRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[GNArrayDataMember(code = GNParameterCode.PlayerStatistics, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(PlayerStatisticsParam))]
			public List<PlayerStatisticsParam> playerStatisticsParams;

		}

		public class ServerSetPlayerStatisticsRequestData : SetPlayerStatisticsRequestData
		{
		}

		public class AdminSetPlayerStatisticsRequestData : SetPlayerStatisticsRequestData
		{
		}

		public class SetRemoveStatusRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[StringDataMember(code = GNParameterCode.Reason, isOptional = true, defaultValue = "")]
			public string? reason;

		}

		public class ServerSetRemoveStatusRequestData : SetRemoveStatusRequestData
		{
		}

		public class AdminSetRemoveStatusRequestData : SetRemoveStatusRequestData
		{
		}

		public class SetTagRequestData
		{
			[StringDataMember(code = GNParameterCode.CharacterId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string characterId;

			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[StringDataMember(code = GNParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string value;

		}

		public class ServerSetTagRequestData : SetTagRequestData
		{
		}

		public class AdminSetTagRequestData : SetTagRequestData
		{
		}

	}

	public partial class CharacterPlayerModels
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

			[NumberDataMember(code = GNParameterCode.Role, mustInt = true)]
			public long role;

		}

		public class InfoRequestParam
		{
			[BooleanDataMember(code = GNParameterCode.CatalogId, isOptional = true, defaultValue = false)]
			public bool? catalogId;

			[BooleanDataMember(code = GNParameterCode.Owner, isOptional = true, defaultValue = false)]
			public bool? owner;

			[BooleanDataMember(code = GNParameterCode.RemoveStatus, isOptional = true, defaultValue = false)]
			public bool? removeStatus;

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

			[NumberDataMember(code = GNParameterCode.Permission, mustInt = true)]
			public long permission;

		}

		public class PlayerStatisticsParam
		{
			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[NumberDataMember(code = GNParameterCode.Value)]
			public double value;

		}

	}

	public partial class CharacterPlayerModels
	{

		public class ResponseData
		{

		}

	}

}
