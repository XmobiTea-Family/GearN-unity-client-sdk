namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Constant;

    /// <summary>
    /// Defines payload models for group operations.
    /// </summary>
    public partial class GroupModels
    {
        /// <summary>
        /// Represents the request payload for the add member operation.
        /// </summary>
        public class AddMemberRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.MemberId, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string memberId;

            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the add member operation.
        /// </summary>
        public class ServerAddMemberRequestData : AddMemberRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the add member operation.
        /// </summary>
        public class AdminAddMemberRequestData : ServerAddMemberRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the add segment operation.
        /// </summary>
        public class AddSegmentRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

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
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get avatar operation.
        /// </summary>
        public class ServerGetAvatarRequestData : GetAvatarRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get avatar operation.
        /// </summary>
        public class AdminGetAvatarRequestData : ServerGetAvatarRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get catalog ID operation.
        /// </summary>
        public class GetCatalogIdRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get catalog ID operation.
        /// </summary>
        public class ServerGetCatalogIdRequestData : GetCatalogIdRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get catalog ID operation.
        /// </summary>
        public class AdminGetCatalogIdRequestData : ServerGetCatalogIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get custom data operation.
        /// </summary>
        public class GetCustomDataRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

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
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get display name operation.
        /// </summary>
        public class ServerGetDisplayNameRequestData : GetDisplayNameRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get display name operation.
        /// </summary>
        public class AdminGetDisplayNameRequestData : ServerGetDisplayNameRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get group currency operation.
        /// </summary>
        public class GetGroupCurrencyRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            /// <summary>
            /// Stores the group currency key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupCurrencyKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? groupCurrencyKeys;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get group currency operation.
        /// </summary>
        public class ServerGetGroupCurrencyRequestData : GetGroupCurrencyRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get group currency operation.
        /// </summary>
        public class AdminGetGroupCurrencyRequestData : ServerGetGroupCurrencyRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get group data operation.
        /// </summary>
        public class GetGroupDataRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            /// <summary>
            /// Stores the group data key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? groupDataKeys;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get group data operation.
        /// </summary>
        public class ServerGetGroupDataRequestData : GetGroupDataRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get group data operation.
        /// </summary>
        public class AdminGetGroupDataRequestData : ServerGetGroupDataRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get group information operation.
        /// </summary>
        public class GetGroupInformationRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get group information operation.
        /// </summary>
        public class ServerGetGroupInformationRequestData : GetGroupInformationRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get group information operation.
        /// </summary>
        public class AdminGetGroupInformationRequestData : ServerGetGroupInformationRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get group inventory operation.
        /// </summary>
        public class GetGroupInventoryRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            /// <summary>
            /// Stores the item catalog ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.ItemCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? itemCatalogIds;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get group inventory operation.
        /// </summary>
        public class ServerGetGroupInventoryRequestData : GetGroupInventoryRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get group inventory operation.
        /// </summary>
        public class AdminGetGroupInventoryRequestData : ServerGetGroupInventoryRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get group message operation.
        /// </summary>
        public class GetGroupMessageRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

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
        /// Represents the server-scoped request payload for the get group message operation.
        /// </summary>
        public class ServerGetGroupMessageRequestData : GetGroupMessageRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get group message operation.
        /// </summary>
        public class AdminGetGroupMessageRequestData : ServerGetGroupMessageRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get group statistics operation.
        /// </summary>
        public class GetGroupStatisticsRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            /// <summary>
            /// Stores the statistics key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StatisticsKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? statisticsKeys;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get group statistics operation.
        /// </summary>
        public class ServerGetGroupStatisticsRequestData : GetGroupStatisticsRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get group statistics operation.
        /// </summary>
        public class AdminGetGroupStatisticsRequestData : ServerGetGroupStatisticsRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get groups with display name operation.
        /// </summary>
        public class GetGroupsWithDisplayNameRequestData
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
        /// Represents the server-scoped request payload for the get groups with display name operation.
        /// </summary>
        public class ServerGetGroupsWithDisplayNameRequestData : GetGroupsWithDisplayNameRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get groups with display name operation.
        /// </summary>
        public class AdminGetGroupsWithDisplayNameRequestData : ServerGetGroupsWithDisplayNameRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get groups with segment operation.
        /// </summary>
        public class GetGroupsWithSegmentRequestData
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
        /// Represents the server-scoped request payload for the get groups with segment operation.
        /// </summary>
        public class ServerGetGroupsWithSegmentRequestData : GetGroupsWithSegmentRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get groups with segment operation.
        /// </summary>
        public class AdminGetGroupsWithSegmentRequestData : ServerGetGroupsWithSegmentRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get groups with tag operation.
        /// </summary>
        public class GetGroupsWithTagRequestData
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
        /// Represents the server-scoped request payload for the get groups with tag operation.
        /// </summary>
        public class ServerGetGroupsWithTagRequestData : GetGroupsWithTagRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get groups with tag operation.
        /// </summary>
        public class AdminGetGroupsWithTagRequestData : ServerGetGroupsWithTagRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get members operation.
        /// </summary>
        public class GetMembersRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get members operation.
        /// </summary>
        public class ServerGetMembersRequestData : GetMembersRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get members operation.
        /// </summary>
        public class AdminGetMembersRequestData : ServerGetMembersRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get remove status operation.
        /// </summary>
        public class GetRemoveStatusRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get remove status operation.
        /// </summary>
        public class ServerGetRemoveStatusRequestData : GetRemoveStatusRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get remove status operation.
        /// </summary>
        public class AdminGetRemoveStatusRequestData : ServerGetRemoveStatusRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get segment operation.
        /// </summary>
        public class GetSegmentRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get segment operation.
        /// </summary>
        public class ServerGetSegmentRequestData : GetSegmentRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get segment operation.
        /// </summary>
        public class AdminGetSegmentRequestData : ServerGetSegmentRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get statistics leaderboard around group operation.
        /// </summary>
        public class GetStatisticsLeaderboardAroundGroupRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

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
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? catalogId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get statistics leaderboard around group operation.
        /// </summary>
        public class ServerGetStatisticsLeaderboardAroundGroupRequestData : GetStatisticsLeaderboardAroundGroupRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get statistics leaderboard around group operation.
        /// </summary>
        public class AdminGetStatisticsLeaderboardAroundGroupRequestData : ServerGetStatisticsLeaderboardAroundGroupRequestData
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

            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? catalogId;

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
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

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
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get timestamp create operation.
        /// </summary>
        public class ServerGetTsCreateRequestData : GetTsCreateRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get timestamp create operation.
        /// </summary>
        public class AdminGetTsCreateRequestData : ServerGetTsCreateRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the create group item operation.
        /// </summary>
        public class CreateGroupItemRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

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
            [NumberDataMember(code = ParameterCode.Amount, defaultValue = 1, mustInt = true, minValue = 1, maxValue = 256, isOptional = true)]
            public int? amount;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the create group item operation.
        /// </summary>
        public class ServerCreateGroupItemRequestData : CreateGroupItemRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the create group item operation.
        /// </summary>
        public class AdminCreateGroupItemRequestData : ServerCreateGroupItemRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the remove group item operation.
        /// </summary>
        public class RemoveGroupItemRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the remove group item operation.
        /// </summary>
        public class ServerRemoveGroupItemRequestData : RemoveGroupItemRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the remove group item operation.
        /// </summary>
        public class AdminRemoveGroupItemRequestData : ServerRemoveGroupItemRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the remove member operation.
        /// </summary>
        public class RemoveMemberRequestData
        {
            /// <summary>
            /// Stores the member ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.MemberId, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string memberId;

            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the remove member operation.
        /// </summary>
        public class ServerRemoveMemberRequestData : RemoveMemberRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the remove member operation.
        /// </summary>
        public class AdminRemoveMemberRequestData : ServerRemoveMemberRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the remove segment operation.
        /// </summary>
        public class RemoveSegmentRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

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
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

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
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the remove tag operation.
        /// </summary>
        public class AdminRemoveTagRequestData : ServerRemoveTagRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the send group message operation.
        /// </summary>
        public class SendGroupMessageRequestData
        {
            /// <summary>
            /// Stores the sender ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.SenderId, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string senderId;

            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            /// <summary>
            /// Stores the message value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Message, minLength = 2, maxLength = 256, mustNonNull = true)]
            public string message;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the send group message operation.
        /// </summary>
        public class ServerSendGroupMessageRequestData : SendGroupMessageRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the send group message operation.
        /// </summary>
        public class AdminSendGroupMessageRequestData : ServerSendGroupMessageRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set avatar operation.
        /// </summary>
        public class SetAvatarRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

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
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set avatar operation.
        /// </summary>
        public class AdminSetAvatarRequestData : ServerSetAvatarRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set custom data operation.
        /// </summary>
        public class SetCustomDataRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

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
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            /// <summary>
            /// Stores the display name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.DisplayName, minLength = 5, maxLength = 32, mustNonNull = true)]
            public string displayName;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the set display name operation.
        /// </summary>
        public class ServerSetDisplayNameRequestData : SetDisplayNameRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set display name operation.
        /// </summary>
        public class AdminSetDisplayNameRequestData : ServerSetDisplayNameRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the change group currency operation.
        /// </summary>
        public class ChangeGroupCurrencyRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            /// <summary>
            /// Stores the group currencies value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupCurrencies, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(GroupCurrencyParam))]
            public List<GroupCurrencyParam> groupCurrencies;

            /// <summary>
            /// Stores the log value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the change group currency operation.
        /// </summary>
        public class ServerChangeGroupCurrencyRequestData : ChangeGroupCurrencyRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the change group currency operation.
        /// </summary>
        public class AdminChangeGroupCurrencyRequestData : ServerChangeGroupCurrencyRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set group data operation.
        /// </summary>
        public class SetGroupDataRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            /// <summary>
            /// Stores the group datas value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupDatas, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(GroupDataParam))]
            public List<GroupDataParam> groupDatas;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the set group data operation.
        /// </summary>
        public class ServerSetGroupDataRequestData : SetGroupDataRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set group data operation.
        /// </summary>
        public class AdminSetGroupDataRequestData : ServerSetGroupDataRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the change group statistics operation.
        /// </summary>
        public class ChangeGroupStatisticsRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            /// <summary>
            /// Stores the group statistics value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupStatistics, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(GroupStatisticsParam))]
            public List<GroupStatisticsParam> groupStatistics;

            /// <summary>
            /// Stores the log value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the change group statistics operation.
        /// </summary>
        public class ServerChangeGroupStatisticsRequestData : ChangeGroupStatisticsRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the change group statistics operation.
        /// </summary>
        public class AdminChangeGroupStatisticsRequestData : ServerChangeGroupStatisticsRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set remove status operation.
        /// </summary>
        public class SetRemoveStatusRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

            /// <summary>
            /// Stores the reason value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Reason, isOptional = true, defaultValue = "")]
            public string? reason;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the set remove status operation.
        /// </summary>
        public class ServerSetRemoveStatusRequestData : SetRemoveStatusRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set remove status operation.
        /// </summary>
        public class AdminSetRemoveStatusRequestData : ServerSetRemoveStatusRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set tag operation.
        /// </summary>
        public class SetTagRequestData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string groupId;

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
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true, isOptional = true)]
            public string? groupId;

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
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId, minLength = 10, maxLength = 10, mustNonNull = true, isOptional = true)]
            public string? groupId;

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
    /// Defines payload models for group operations.
    /// </summary>
    public partial class GroupModels
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
        /// Represents the group currency param component.
        /// </summary>
        public class GroupCurrencyParam
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
        /// Represents the group data param component.
        /// </summary>
        public class GroupDataParam
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
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string userId;

        }

        /// <summary>
        /// Represents the group statistics param component.
        /// </summary>
        public class GroupStatisticsParam
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

        /// <summary>
        /// Represents the info request param component.
        /// </summary>
        public class InfoRequestParam
        {
            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CatalogId, isOptional = true, defaultValue = false)]
            public bool? catalogId;

            /// <summary>
            /// Stores the members value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Members, isOptional = true, defaultValue = false)]
            public bool? members;

            /// <summary>
            /// Stores the remove status value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.RemoveStatus, isOptional = true, defaultValue = false)]
            public bool? removeStatus;

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
            /// Stores the group currencies value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.GroupCurrencies, isOptional = true, defaultValue = false)]
            public bool? groupCurrencies;

            /// <summary>
            /// Stores the group statistics value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.GroupStatistics, isOptional = true, defaultValue = false)]
            public bool? groupStatistics;

            /// <summary>
            /// Stores the group datas value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.GroupDatas, isOptional = true, defaultValue = false)]
            public bool? groupDatas;

            /// <summary>
            /// Stores the group inventories value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.GroupInventories, isOptional = true, defaultValue = false)]
            public bool? groupInventories;

            /// <summary>
            /// Stores the group data key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? groupDataKeys;

            /// <summary>
            /// Stores the group currency key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupCurrencyKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? groupCurrencyKeys;

            /// <summary>
            /// Stores the group statistics key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupStatisticsKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? groupStatisticsKeys;

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
            /// Stores the item catalog ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.ItemCatalogIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? itemCatalogIds;

        }

    }

    /// <summary>
    /// Defines payload models for group operations.
    /// </summary>
    public partial class GroupModels
    {
        /// <summary>
        /// Represents the info response parameters component.
        /// </summary>
        public class InfoResponseParameters
        {
            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId, isOptional = true)]
            public string? catalogId;

            /// <summary>
            /// Stores the members value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Members, isOptional = true, elementCls = typeof(GenericModels.MemberItem))]
            public List<GenericModels.MemberItem>? members;

            /// <summary>
            /// Stores the remove status value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveStatus, isOptional = true)]
            public GenericModels.RemoveStatusItem? removeStatus;

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
            /// Stores the group datas value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupDatas, isOptional = true, elementCls = typeof(GenericModels.DataItem))]
            public List<GenericModels.DataItem>? groupDatas;

            /// <summary>
            /// Stores the group currencies value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupCurrencies, isOptional = true, elementCls = typeof(GenericModels.CurrencyItem))]
            public List<GenericModels.CurrencyItem>? groupCurrencies;

            /// <summary>
            /// Stores the group statistics value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupStatistics, isOptional = true, elementCls = typeof(GenericModels.StatisticsItem))]
            public List<GenericModels.StatisticsItem>? groupStatistics;

            /// <summary>
            /// Stores the group inventories value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupInventories, isOptional = true, elementCls = typeof(GenericModels.InventoryItem))]
            public List<GenericModels.InventoryItem>? groupInventories;

        }

        /// <summary>
        /// Represents the response payload for the group operation.
        /// </summary>
        public class GroupResponseData
        {
            /// <summary>
            /// Stores the info response parameters value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoResponseParameters)]
            public InfoResponseParameters infoResponseParameters;

        }

        /// <summary>
        /// Represents the response payload for the group with group ID operation.
        /// </summary>
        public class GroupWithGroupIdResponseData : GroupResponseData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId)]
            public string groupId;

        }

        /// <summary>
        /// Represents the response payload for the group leaderboard operation.
        /// </summary>
        public class GroupLeaderboardResponseData : GroupWithGroupIdResponseData
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
        /// Represents the response payload for the group log operation.
        /// </summary>
        public class GroupLogResponseData
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId)]
            public string groupId;

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
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GroupLeaderboardResponseData))]
            public List<GroupLeaderboardResponseData> results;

            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsCreate, isOptional = true)]
            public long? tsCreate;

        }

        /// <summary>
        /// Represents the response payload for the groups with group ID operation.
        /// </summary>
        public class GroupsWithGroupIdResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GroupWithGroupIdResponseData))]
            public List<GroupWithGroupIdResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the group message operation.
        /// </summary>
        public class GroupMessageResponseData
        {
            /// <summary>
            /// Stores the message value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Message)]
            public string message;

            /// <summary>
            /// Stores the sender ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.SenderId)]
            public string senderId;

            /// <summary>
            /// Stores the sender type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.SenderType)]
            public int senderType;

            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;
        }

        /// <summary>
        /// Represents the response payload for the group messages operation.
        /// </summary>
        public class GroupMessagesResponseData
        {
            /// <summary>
            /// Stores the group messages value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupMessages, elementCls = typeof(GroupMessageResponseData))]
            public List<GroupMessageResponseData> groupMessages;
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

            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? catalogId;

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
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GroupLeaderboardResponseData))]
            public List<GroupLeaderboardResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the get create leaderboard operation.
        /// </summary>
        public class GetCreateLeaderboardResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GroupLeaderboardResponseData))]
            public List<GroupLeaderboardResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the get statistics log operation.
        /// </summary>
        public class GetStatisticsLogResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GroupLogResponseData))]
            public List<GroupLogResponseData> results;

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
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GroupLogResponseData))]
            public List<GroupLogResponseData> results;

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