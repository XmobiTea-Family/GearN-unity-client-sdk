namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Constant;

    public partial class GroupModels
    {
        public class AddMemberRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string userId;

            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [StringDataMember(code = ParameterCode.Value, minLength = 6, maxLength = 32, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [GNArrayDataMember(code = ParameterCode.CustomDataKeys, isOptional = true, elementCls = typeof(string))]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [GNArrayDataMember(code = ParameterCode.GroupCurrencyKeys, isOptional = true, elementCls = typeof(string))]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [GNArrayDataMember(code = ParameterCode.GroupDataKeys, isOptional = true, elementCls = typeof(string))]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [GNArrayDataMember(code = ParameterCode.ItemCatalogIds, isOptional = true, elementCls = typeof(string))]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

        }

        public class ServerGetGroupMessageRequestData : GetGroupMessageRequestData
        {
        }

        public class AdminGetGroupMessageRequestData : ServerGetGroupMessageRequestData
        {
        }

        public class GetGroupStatisticsRequestData
        {
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [GNArrayDataMember(code = ParameterCode.StatisticsKeys, isOptional = true, elementCls = typeof(string))]
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
            [StringDataMember(code = ParameterCode.Keyword, minLength = 2, maxLength = 32)]
            public string keyword;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

        }

        public class ServerGetGroupsWithDisplayNameRequestData : GetGroupsWithDisplayNameRequestData
        {
        }

        public class AdminGetGroupsWithDisplayNameRequestData : ServerGetGroupsWithDisplayNameRequestData
        {
        }

        public class GetGroupsWithSegmentRequestData
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

        public class ServerGetGroupsWithSegmentRequestData : GetGroupsWithSegmentRequestData
        {
        }

        public class AdminGetGroupsWithSegmentRequestData : ServerGetGroupsWithSegmentRequestData
        {
        }

        public class GetGroupsWithTagRequestData
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

        public class ServerGetGroupsWithTagRequestData : GetGroupsWithTagRequestData
        {
        }

        public class AdminGetGroupsWithTagRequestData : ServerGetGroupsWithTagRequestData
        {
        }

        public class GetMembersRequestData
        {
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

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

            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? catalogId;

        }

        public class ServerGetStatisticsLeaderboardAroundGroupRequestData : GetStatisticsLeaderboardAroundGroupRequestData
        {
        }

        public class AdminGetStatisticsLeaderboardAroundGroupRequestData : ServerGetStatisticsLeaderboardAroundGroupRequestData
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

            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? catalogId;

        }

        public class ServerGetStatisticsLeaderboardRequestData : GetStatisticsLeaderboardRequestData
        {
        }

        public class AdminGetStatisticsLeaderboardRequestData : ServerGetStatisticsLeaderboardRequestData
        {
        }

        public class GetTagRequestData
        {
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [GNArrayDataMember(code = ParameterCode.TagKeys, elementCls = typeof(string))]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

        }

        public class ServerGetTsCreateRequestData : GetTsCreateRequestData
        {
        }

        public class AdminGetTsCreateRequestData : ServerGetTsCreateRequestData
        {
        }

        public class CreateGroupItemRequestData
        {
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string catalogId;

            [StringDataMember(code = ParameterCode.ClassId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string classId;

            [StringDataMember(code = ParameterCode.DisplayName, defaultValue = "", isOptional = true)]
            public string? displayName;

            [NumberDataMember(code = ParameterCode.Amount, defaultValue = 1, mustInt = true, isOptional = true)]
            public int? amount;

        }

        public class ServerCreateGroupItemRequestData : CreateGroupItemRequestData
        {
        }

        public class AdminCreateGroupItemRequestData : ServerCreateGroupItemRequestData
        {
        }

        public class RemoveGroupItemRequestData
        {
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string userId;

            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [StringDataMember(code = ParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.SenderId, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string senderId;

            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [StringDataMember(code = ParameterCode.Message, minLength = 2, maxLength = 256, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            [StringDataMember(code = ParameterCode.Value, minLength = 1, maxLength = 128, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [GNArrayDataMember(code = ParameterCode.CustomDatas, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(CustomDataParam))]
            public List<CustomDataParam> customDatas;

        }

        public class ServerSetCustomDataRequestData : SetCustomDataRequestData
        {
        }

        public class AdminSetCustomDataRequestData : ServerSetCustomDataRequestData
        {
        }

        public class SetDisplayNameRequestData
        {
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [StringDataMember(code = ParameterCode.DisplayName, minLength = 5, maxLength = 32, mustNonNull = true)]
            public string displayName;

        }

        public class ServerSetDisplayNameRequestData : SetDisplayNameRequestData
        {
        }

        public class AdminSetDisplayNameRequestData : ServerSetDisplayNameRequestData
        {
        }

        public class ChangeGroupCurrencyRequestData
        {
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [GNArrayDataMember(code = ParameterCode.GroupCurrencies, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(GroupCurrencyParam))]
            public List<GroupCurrencyParam> groupCurrencies;

            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        public class ServerChangeGroupCurrencyRequestData : ChangeGroupCurrencyRequestData
        {
        }

        public class AdminChangeGroupCurrencyRequestData : ServerChangeGroupCurrencyRequestData
        {
        }

        public class SetGroupDataRequestData
        {
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [GNArrayDataMember(code = ParameterCode.GroupDatas, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(GroupDataParam))]
            public List<GroupDataParam> groupDatas;

        }

        public class ServerSetGroupDataRequestData : SetGroupDataRequestData
        {
        }

        public class AdminSetGroupDataRequestData : ServerSetGroupDataRequestData
        {
        }

        public class ChangeGroupStatisticsRequestData
        {
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [GNArrayDataMember(code = ParameterCode.GroupStatistics, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(GroupStatisticsParam))]
            public List<GroupStatisticsParam> groupStatistics;

            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        public class ServerChangeGroupStatisticsRequestData : ChangeGroupStatisticsRequestData
        {
        }

        public class AdminChangeGroupStatisticsRequestData : ServerChangeGroupStatisticsRequestData
        {
        }

        public class SetRemoveStatusRequestData
        {
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [StringDataMember(code = ParameterCode.Reason, isOptional = true, defaultValue = "")]
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
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [StringDataMember(code = ParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string value;

        }

        public class ServerSetTagRequestData : SetTagRequestData
        {
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

            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true, isOptional = true)]
            public string? groupId;

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

            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true, isOptional = true)]
            public string? groupId;

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

    public partial class GroupModels
    {
        public class CustomDataParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [DataMember(code = ParameterCode.Value)]
            public object value;

        }

        public class GroupCurrencyParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [NumberDataMember(code = ParameterCode.Amount)]
            public double amount;

        }

        public class GroupDataParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [DataMember(code = ParameterCode.Value)]
            public object value;

        }

        public class GroupMemberParam
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string userId;

        }

        public class GroupStatisticsParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [NumberDataMember(code = ParameterCode.Value)]
            public double value;

        }

        public class InfoRequestParam
        {
            [BooleanDataMember(code = ParameterCode.CatalogId, isOptional = true, defaultValue = false)]
            public bool? catalogId;

            [BooleanDataMember(code = ParameterCode.Members, isOptional = true, defaultValue = false)]
            public bool? members;

            [BooleanDataMember(code = ParameterCode.RemoveStatus, isOptional = true, defaultValue = false)]
            public bool? removeStatus;

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

            [BooleanDataMember(code = ParameterCode.GroupCurrencies, isOptional = true, defaultValue = false)]
            public bool? groupCurrencies;

            [BooleanDataMember(code = ParameterCode.GroupStatistics, isOptional = true, defaultValue = false)]
            public bool? groupStatistics;

            [BooleanDataMember(code = ParameterCode.GroupDatas, isOptional = true, defaultValue = false)]
            public bool? groupDatas;

            [BooleanDataMember(code = ParameterCode.GroupInventories, isOptional = true, defaultValue = false)]
            public bool? groupInventories;

            [GNArrayDataMember(code = ParameterCode.GroupDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? groupDataKeys;

            [GNArrayDataMember(code = ParameterCode.GroupCurrencyKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? groupCurrencyKeys;

            [GNArrayDataMember(code = ParameterCode.GroupStatisticsKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? groupStatisticsKeys;

            [GNArrayDataMember(code = ParameterCode.CustomDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? customDataKeys;

            [GNArrayDataMember(code = ParameterCode.TagKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? tagKeys;

            [GNArrayDataMember(code = ParameterCode.ItemCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? itemCatalogIds;

        }

    }

    public partial class GroupModels
    {
        public class InfoResponseParameters
        {
            [StringDataMember(code = ParameterCode.CatalogId, isOptional = true)]
            public string? catalogId;

            [GNArrayDataMember(code = ParameterCode.Members, isOptional = true, elementCls = typeof(GenericModels.MemberItem))]
            public List<GenericModels.MemberItem>? members;

            [GNHashtableDataMember(code = ParameterCode.RemoveStatus, isOptional = true)]
            public GenericModels.RemoveStatusItem? removeStatus;

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

            [GNArrayDataMember(code = ParameterCode.GroupDatas, isOptional = true, elementCls = typeof(GenericModels.DataItem))]
            public List<GenericModels.DataItem>? groupDatas;

            [GNArrayDataMember(code = ParameterCode.GroupCurrencies, isOptional = true, elementCls = typeof(GenericModels.CurrencyItem))]
            public List<GenericModels.CurrencyItem>? groupCurrencies;

            [GNArrayDataMember(code = ParameterCode.GroupStatistics, isOptional = true, elementCls = typeof(GenericModels.StatisticsItem))]
            public List<GenericModels.StatisticsItem>? groupStatistics;

            [GNArrayDataMember(code = ParameterCode.GroupInventories, isOptional = true, elementCls = typeof(GenericModels.InventoryItem))]
            public List<GenericModels.InventoryItem>? groupInventories;

        }

        public class GroupResponseData
        {
            [GNHashtableDataMember(code = ParameterCode.InfoResponseParameters)]
            public InfoResponseParameters infoResponseParameters;

        }

        public class GroupWithGroupIdResponseData : GroupResponseData
        {
            [StringDataMember(code = ParameterCode.GroupId)]
            public string groupId;

        }

        public class GroupLeaderboardResponseData : GroupWithGroupIdResponseData
        {
            [NumberDataMember(code = ParameterCode.Position)]
            public int position;

            [NumberDataMember(code = ParameterCode.BackupValue, isOptional = true)]
            public double? backupValue;

        }

        public class GroupLogResponseData
        {
            [StringDataMember(code = ParameterCode.GroupId)]
            public string groupId;

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
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GroupLeaderboardResponseData))]
            public List<GroupLeaderboardResponseData> results;

            [NumberDataMember(code = ParameterCode.TsCreate, isOptional = true)]
            public long? tsCreate;

        }

        public class GroupsWithGroupIdResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GroupWithGroupIdResponseData))]
            public List<GroupWithGroupIdResponseData> results;

        }

        public class GroupMessageResponseData
        {
            [StringDataMember(code = ParameterCode.Message)]
            public string message;

            [StringDataMember(code = ParameterCode.SenderId)]
            public string senderId;

            [NumberDataMember(code = ParameterCode.SenderType)]
            public int senderType;

            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;
        }

        public class GroupMessagesResponseData
        {
            [GNArrayDataMember(code = ParameterCode.GroupMessages, elementCls = typeof(GroupMessageResponseData))]
            public List<GroupMessageResponseData> groupMessages;
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

            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? catalogId;

        }

        public class ServerGetCurrencyLeaderboardRequestData : GetCurrencyLeaderboardRequestData
        {
        }

        public class AdminGetCurrencyLeaderboardRequestData : ServerGetCurrencyLeaderboardRequestData
        {
        }

        public class GetCurrencyLeaderboardResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GroupLeaderboardResponseData))]
            public List<GroupLeaderboardResponseData> results;

        }

        public class GetCreateLeaderboardResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GroupLeaderboardResponseData))]
            public List<GroupLeaderboardResponseData> results;

        }

        public class GetStatisticsLogResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GroupLogResponseData))]
            public List<GroupLogResponseData> results;

            [StringDataMember(code = ParameterCode.Token, isOptional = true)]
            public string? token;

        }

        public class GetCurrencyLogResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GroupLogResponseData))]
            public List<GroupLogResponseData> results;

            [StringDataMember(code = ParameterCode.Token, isOptional = true)]
            public string? token;

        }

        public class EmptyResponseData
        {

        }

    }

}
