namespace XmobiTea.GN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;

	public partial class GroupModels
	{
		public class AddMemberRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string userId;

			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

		}

		public class ServerAddMemberRequestData : AddMemberRequestData
		{
		}

		public class AdminAddMemberRequestData : ServerAddMemberRequestData
		{
		}

		public class AddSegmentRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[StringDataMember(code = GNParameterCode.Value, minLength = 6, maxLength = 32, mustNonNull = true)]
			public string value;

		}

		public class ServerAddSegmentRequestData : AddSegmentRequestData
		{
		}

		public class AdminAddSegmentRequestData : ServerAddSegmentRequestData
		{
		}

		public class GetAvatarRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

		}

		public class ServerGetAvatarRequestData : GetAvatarRequestData
		{
		}

		public class AdminGetAvatarRequestData : ServerGetAvatarRequestData
		{
		}

		public class GetCatalogIdRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

		}

		public class ServerGetCatalogIdRequestData : GetCatalogIdRequestData
		{
		}

		public class AdminGetCatalogIdRequestData : ServerGetCatalogIdRequestData
		{
		}

		public class GetCustomDataRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[GNArrayDataMember(code = GNParameterCode.CustomDataKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? customDataKeys;

		}

		public class ServerGetCustomDataRequestData : GetCustomDataRequestData
		{
		}

		public class AdminGetCustomDataRequestData : ServerGetCustomDataRequestData
		{
		}

		public class GetDisplayNameRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

		}

		public class ServerGetDisplayNameRequestData : GetDisplayNameRequestData
		{
		}

		public class AdminGetDisplayNameRequestData : ServerGetDisplayNameRequestData
		{
		}

		public class GetGroupCurrencyRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[GNArrayDataMember(code = GNParameterCode.GroupCurrencyKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? groupCurrencyKeys;

		}

		public class ServerGetGroupCurrencyRequestData : GetGroupCurrencyRequestData
		{
		}

		public class AdminGetGroupCurrencyRequestData : ServerGetGroupCurrencyRequestData
		{
		}

		public class GetGroupDataRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[GNArrayDataMember(code = GNParameterCode.GroupDataKeys, isOptional = true)]
			public List<string>? groupDataKeys;

		}

		public class ServerGetGroupDataRequestData : GetGroupDataRequestData
		{
		}

		public class AdminGetGroupDataRequestData : ServerGetGroupDataRequestData
		{
		}

		public class GetGroupInformationRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class ServerGetGroupInformationRequestData : GetGroupInformationRequestData
		{
		}

		public class AdminGetGroupInformationRequestData : ServerGetGroupInformationRequestData
		{
		}

		public class GetGroupInventoryRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[GNArrayDataMember(code = GNParameterCode.ItemCatalogIds, isOptional = true, elementCls = typeof(string))]
			public List<string>? itemCatalogIds;

		}

		public class ServerGetGroupInventoryRequestData : GetGroupInventoryRequestData
		{
		}

		public class AdminGetGroupInventoryRequestData : ServerGetGroupInventoryRequestData
		{
		}

		public class GetGroupMessageRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
			public long? skip;

			[NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
			public long? limit;

		}

		public class ServerGetGroupMessageRequestData : GetGroupMessageRequestData
		{
		}

		public class AdminGetGroupMessageRequestData : ServerGetGroupMessageRequestData
		{
		}

		public class GetGroupStatisticsRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[GNArrayDataMember(code = GNParameterCode.StatisticsKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? statisticsKeys;

		}

		public class ServerGetGroupStatisticsRequestData : GetGroupStatisticsRequestData
		{
		}

		public class AdminGetGroupStatisticsRequestData : ServerGetGroupStatisticsRequestData
		{
		}

		public class GetGroupsWithDisplayNameRequestData
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

		public class ServerGetGroupsWithDisplayNameRequestData : GetGroupsWithDisplayNameRequestData
		{
		}

		public class AdminGetGroupsWithDisplayNameRequestData : ServerGetGroupsWithDisplayNameRequestData
		{
		}

		public class GetGroupsWithSegmentRequestData
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

		public class ServerGetGroupsWithSegmentRequestData : GetGroupsWithSegmentRequestData
		{
		}

		public class AdminGetGroupsWithSegmentRequestData : ServerGetGroupsWithSegmentRequestData
		{
		}

		public class GetGroupsWithTagRequestData
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

		public class ServerGetGroupsWithTagRequestData : GetGroupsWithTagRequestData
		{
		}

		public class AdminGetGroupsWithTagRequestData : ServerGetGroupsWithTagRequestData
		{
		}

		public class GetMembersRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

		}

		public class ServerGetMembersRequestData : GetMembersRequestData
		{
		}

		public class AdminGetMembersRequestData : ServerGetMembersRequestData
		{
		}

		public class GetRemoveStatusRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

		}

		public class ServerGetRemoveStatusRequestData : GetRemoveStatusRequestData
		{
		}

		public class AdminGetRemoveStatusRequestData : ServerGetRemoveStatusRequestData
		{
		}

		public class GetSegmentRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

		}

		public class ServerGetSegmentRequestData : GetSegmentRequestData
		{
		}

		public class AdminGetSegmentRequestData : ServerGetSegmentRequestData
		{
		}

		public class GetStatisticsLeaderboardAroundGroupRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

			[NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
			public long? skip;

			[NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
			public long? limit;

		}

		public class ServerGetStatisticsLeaderboardAroundGroupRequestData : GetStatisticsLeaderboardAroundGroupRequestData
		{
		}

		public class AdminGetStatisticsLeaderboardAroundGroupRequestData : ServerGetStatisticsLeaderboardAroundGroupRequestData
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
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[GNArrayDataMember(code = GNParameterCode.TagKeys, elementCls = typeof(string))]
			public List<string> tagKeys;

		}

		public class ServerGetTagRequestData : GetTagRequestData
		{
		}

		public class AdminGetTagRequestData : ServerGetTagRequestData
		{
		}

		public class GetTsCreateRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

		}

		public class ServerGetTsCreateRequestData : GetTsCreateRequestData
		{
		}

		public class AdminGetTsCreateRequestData : ServerGetTsCreateRequestData
		{
		}

		public class GrantGroupItemRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[StringDataMember(code = GNParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string catalogId;

			[StringDataMember(code = GNParameterCode.ClassId, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string classId;

			[StringDataMember(code = GNParameterCode.DisplayName, defaultValue = "", isOptional = true)]
			public string? displayName;

			[NumberDataMember(code = GNParameterCode.Amount, defaultValue = 1, isOptional = true)]
			public double? amount;

		}

		public class ServerGrantGroupItemRequestData : GrantGroupItemRequestData
		{
		}

		public class AdminGrantGroupItemRequestData : ServerGrantGroupItemRequestData
		{
		}

		public class RemoveGroupItemRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
			public string itemId;

		}

		public class ServerRemoveGroupItemRequestData : RemoveGroupItemRequestData
		{
		}

		public class AdminRemoveGroupItemRequestData : ServerRemoveGroupItemRequestData
		{
		}

		public class RemoveMemberRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string userId;

			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

		}

		public class ServerRemoveMemberRequestData : RemoveMemberRequestData
		{
		}

		public class AdminRemoveMemberRequestData : ServerRemoveMemberRequestData
		{
		}

		public class RemoveSegmentRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[StringDataMember(code = GNParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string value;

		}

		public class ServerRemoveSegmentRequestData : RemoveSegmentRequestData
		{
		}

		public class AdminRemoveSegmentRequestData : ServerRemoveSegmentRequestData
		{
		}

		public class RemoveTagRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

		}

		public class ServerRemoveTagRequestData : RemoveTagRequestData
		{
		}

		public class AdminRemoveTagRequestData : ServerRemoveTagRequestData
		{
		}

		public class SendGroupMessageRequestData
		{
			[StringDataMember(code = GNParameterCode.SenderId, minLength = 10, maxLength = 11, mustNonNull = true)]
			public string senderId;

			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[StringDataMember(code = GNParameterCode.Message, minLength = 2, maxLength = 256, mustNonNull = true)]
			public string message;

		}

		public class ServerSendGroupMessageRequestData : SendGroupMessageRequestData
		{
		}

		public class AdminSendGroupMessageRequestData : ServerSendGroupMessageRequestData
		{
		}

		public class SetAvatarRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[NumberDataMember(code = GNParameterCode.Type, mustInt = true)]
			public long type;

			[StringDataMember(code = GNParameterCode.Value, minLength = 1, maxLength = 128, mustNonNull = true)]
			public string value;

		}

		public class ServerSetAvatarRequestData : SetAvatarRequestData
		{
		}

		public class AdminSetAvatarRequestData : ServerSetAvatarRequestData
		{
		}

		public class SetCustomDataRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[GNArrayDataMember(code = GNParameterCode.CustomDatas, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(CustomDataParam))]
			public List<CustomDataParam> customData;

		}

		public class ServerSetCustomDataRequestData : SetCustomDataRequestData
		{
		}

		public class AdminSetCustomDataRequestData : ServerSetCustomDataRequestData
		{
		}

		public class SetDisplayNameRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[StringDataMember(code = GNParameterCode.DisplayName, minLength = 5, maxLength = 32, mustNonNull = true)]
			public string displayName;

		}

		public class ServerSetDisplayNameRequestData : SetDisplayNameRequestData
		{
		}

		public class AdminSetDisplayNameRequestData : ServerSetDisplayNameRequestData
		{
		}

		public class SetGroupCurrencyRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[GNArrayDataMember(code = GNParameterCode.GroupCurrencies, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(GroupCurrencyParam))]
			public List<GroupCurrencyParam> groupCurrencyParams;

		}

		public class ServerSetGroupCurrencyRequestData : SetGroupCurrencyRequestData
		{
		}

		public class AdminSetGroupCurrencyRequestData : ServerSetGroupCurrencyRequestData
		{
		}

		public class SetGroupDataRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[GNArrayDataMember(code = GNParameterCode.GroupDatas, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(GroupDataParam))]
			public List<GroupDataParam> groupDataParams;

		}

		public class ServerSetGroupDataRequestData : SetGroupDataRequestData
		{
		}

		public class AdminSetGroupDataRequestData : ServerSetGroupDataRequestData
		{
		}

		public class SetGroupStatisticsRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[GNArrayDataMember(code = GNParameterCode.GroupStatistics, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(GroupStatisticsParam))]
			public List<GroupStatisticsParam> groupStatisticsParams;

		}

		public class ServerSetGroupStatisticsRequestData : SetGroupStatisticsRequestData
		{
		}

		public class AdminSetGroupStatisticsRequestData : ServerSetGroupStatisticsRequestData
		{
		}

		public class SetRemoveStatusRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[StringDataMember(code = GNParameterCode.Reason, isOptional = true, defaultValue = "")]
			public string? reason;

		}

		public class ServerSetRemoveStatusRequestData : SetRemoveStatusRequestData
		{
		}

		public class AdminSetRemoveStatusRequestData : ServerSetRemoveStatusRequestData
		{
		}

		public class SetTagRequestData
		{
			[StringDataMember(code = GNParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string groupId;

			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[StringDataMember(code = GNParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string value;

		}

		public class ServerSetTagRequestData : SetTagRequestData
		{
		}

		public class AdminSetTagRequestData : ServerSetTagRequestData
		{
		}

	}

	public partial class GroupModels
	{
		public class CustomDataParam
		{
			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[DataMember(code = GNParameterCode.Value)]
			public object value;

		}

		public class GroupCurrencyParam
		{
			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[NumberDataMember(code = GNParameterCode.Amount)]
			public double amount;

		}

		public class GroupDataParam
		{
			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[DataMember(code = GNParameterCode.Value)]
			public object value;

			[NumberDataMember(code = GNParameterCode.Permission, mustInt = true)]
			public long permission;

		}

		public class GroupMemberParam
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string userId;

			[NumberDataMember(code = GNParameterCode.Role, mustInt = true)]
			public long role;

		}

		public class GroupStatisticsParam
		{
			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[NumberDataMember(code = GNParameterCode.Value)]
			public double value;

		}

		public class InfoRequestParam
		{
			[BooleanDataMember(code = GNParameterCode.CatalogId, isOptional = true, defaultValue = false)]
			public bool? catalogId;

			[BooleanDataMember(code = GNParameterCode.Members, isOptional = true, defaultValue = false)]
			public bool? members;

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

			[BooleanDataMember(code = GNParameterCode.GroupCurrencies, isOptional = true, defaultValue = false)]
			public bool? groupCurrencies;

			[BooleanDataMember(code = GNParameterCode.GroupStatistics, isOptional = true, defaultValue = false)]
			public bool? groupStatistics;

			[BooleanDataMember(code = GNParameterCode.GroupDatas, isOptional = true, defaultValue = false)]
			public bool? groupDatas;

			[BooleanDataMember(code = GNParameterCode.GroupInventories, isOptional = true, defaultValue = false)]
			public bool? groupInventories;

			[GNArrayDataMember(code = GNParameterCode.GroupDataKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? groupDataKeys;

			[GNArrayDataMember(code = GNParameterCode.GroupCurrencyKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? groupCurrencyKeys;

			[GNArrayDataMember(code = GNParameterCode.GroupStatisticsKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? groupStatisticsKeys;

			[GNArrayDataMember(code = GNParameterCode.CustomDataKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? customDataKeys;

			[GNArrayDataMember(code = GNParameterCode.TagKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? tagKeys;

			[GNArrayDataMember(code = GNParameterCode.ItemCatalogIds, isOptional = true, elementCls = typeof(string))]
			public List<string>? itemCatalogIds;

		}

	}

	public partial class GroupModels
	{
		public class InfoResponseParameters
		{
			[StringDataMember(code = GNParameterCode.CatalogId, isOptional = true)]
			public string? catalogId;

			[GNArrayDataMember(code = GNParameterCode.Members, isOptional = true, elementCls = typeof(GenericModels.MemberItem))]
			public List<GenericModels.MemberItem>? members;

			[GNHashtableDataMember(code = GNParameterCode.RemoveStatus, isOptional = true)]
			public GenericModels.RemoveStatusItem? removeStatus;

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

			[GNArrayDataMember(code = GNParameterCode.GroupDatas, isOptional = true, elementCls = typeof(GenericModels.DataItem))]
			public List<GenericModels.DataItem>? groupDatas;

			[GNArrayDataMember(code = GNParameterCode.GroupCurrencies, isOptional = true, elementCls = typeof(GenericModels.CurrencyItem))]
			public List<GenericModels.CurrencyItem>? groupCurrencies;

			[GNArrayDataMember(code = GNParameterCode.GroupStatistics, isOptional = true, elementCls = typeof(GenericModels.StatisticsItem))]
			public List<GenericModels.StatisticsItem>? groupStatistics;

			[GNArrayDataMember(code = GNParameterCode.GroupInventories, isOptional = true, elementCls = typeof(GenericModels.InventoryItem))]
			public List<GenericModels.InventoryItem>? groupInventories;

		}

		public class GroupResponseData
		{
			[GNHashtableDataMember(code = GNParameterCode.InfoResponseParameters)]
			public InfoResponseParameters infoResponseParameters;

		}

		public class GroupWithGroupIdResponseData : GroupResponseData
		{
			[StringDataMember(code = GNParameterCode.GroupId)]
			public string groupId;

		}

		public class GroupLeaderboardResponseData : GroupWithGroupIdResponseData
		{
			[NumberDataMember(code = GNParameterCode.Position)]
			public int position;

		}

		public class GetStatisticsLeaderboardResponseData
		{
			[GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(GroupLeaderboardResponseData))]
			public List<GroupLeaderboardResponseData> results;

		}

		public class GroupsWithGroupIdResponseData
		{
			[GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(GroupWithGroupIdResponseData))]
			public List<GroupWithGroupIdResponseData> results;

		}

		public class GroupMessageResponseData
        {
			[StringDataMember(code = GNParameterCode.Message)]
			public string message;

			[StringDataMember(code = GNParameterCode.SenderId)]
			public string senderId;

			[NumberDataMember(code = GNParameterCode.SenderType)]
			public int senderType;

			[NumberDataMember(code = GNParameterCode.TsCreate)]
			public long tsCreate;
		}

		public class GroupMessagesResponseData
        {
			[GNArrayDataMember(code = GNParameterCode.GroupMessages, elementCls = typeof(GroupMessageResponseData))]
			public List<GroupMessageResponseData> groupMessages;
		}

		public class EmptyResponseData
		{

		}

	}

}
