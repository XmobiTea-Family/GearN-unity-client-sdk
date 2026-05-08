namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Constant;

    /// <summary>
    /// Defines payload models for inventory operations.
    /// </summary>
    public partial class InventoryModels
    {
        /// <summary>
        /// Represents the request payload for the add segment operation.
        /// </summary>
        public class AddSegmentRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
        /// Represents the request payload for the get amount operation.
        /// </summary>
        public class GetAmountRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get amount operation.
        /// </summary>
        public class ServerGetAmountRequestData : GetAmountRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get amount operation.
        /// </summary>
        public class AdminGetAmountRequestData : ServerGetAmountRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get avatar operation.
        /// </summary>
        public class GetAvatarRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
        /// Represents the request payload for the get class ID operation.
        /// </summary>
        public class GetClassIdRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get class ID operation.
        /// </summary>
        public class ServerGetClassIdRequestData : GetClassIdRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get class ID operation.
        /// </summary>
        public class AdminGetClassIdRequestData : ServerGetClassIdRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get custom data operation.
        /// </summary>
        public class GetCustomDataRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
        /// Represents the request payload for the get item data operation.
        /// </summary>
        public class GetItemDataRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            /// <summary>
            /// Stores the item data key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.ItemDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? itemDataKeys;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get item data operation.
        /// </summary>
        public class ServerGetItemDataRequestData : GetItemDataRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get item data operation.
        /// </summary>
        public class AdminGetItemDataRequestData : ServerGetItemDataRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get item information operation.
        /// </summary>
        public class GetItemInformationRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get item information operation.
        /// </summary>
        public class ServerGetItemInformationRequestData : GetItemInformationRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get item information operation.
        /// </summary>
        public class AdminGetItemInformationRequestData : ServerGetItemInformationRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get item statistics operation.
        /// </summary>
        public class GetItemStatisticsRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            /// <summary>
            /// Stores the statistics key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StatisticsKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? statisticsKeys;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get item statistics operation.
        /// </summary>
        public class ServerGetItemStatisticsRequestData : GetItemStatisticsRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get item statistics operation.
        /// </summary>
        public class AdminGetItemStatisticsRequestData : ServerGetItemStatisticsRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get items with display name operation.
        /// </summary>
        public class GetItemsWithDisplayNameRequestData
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
        /// Represents the server-scoped request payload for the get items with display name operation.
        /// </summary>
        public class ServerGetItemsWithDisplayNameRequestData : GetItemsWithDisplayNameRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get items with display name operation.
        /// </summary>
        public class AdminGetItemsWithDisplayNameRequestData : ServerGetItemsWithDisplayNameRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get items with segment operation.
        /// </summary>
        public class GetItemsWithSegmentRequestData
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
        /// Represents the server-scoped request payload for the get items with segment operation.
        /// </summary>
        public class ServerGetItemsWithSegmentRequestData : GetItemsWithSegmentRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get items with segment operation.
        /// </summary>
        public class AdminGetItemsWithSegmentRequestData : ServerGetItemsWithSegmentRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get items with tag operation.
        /// </summary>
        public class GetItemsWithTagRequestData
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
        /// Represents the server-scoped request payload for the get items with tag operation.
        /// </summary>
        public class ServerGetItemsWithTagRequestData : GetItemsWithTagRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get items with tag operation.
        /// </summary>
        public class AdminGetItemsWithTagRequestData : ServerGetItemsWithTagRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get item type operation.
        /// </summary>
        public class GetItemTypeRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get item type operation.
        /// </summary>
        public class ServerGetItemTypeRequestData : GetItemTypeRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get item type operation.
        /// </summary>
        public class AdminGetItemTypeRequestData : ServerGetItemTypeRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get owner operation.
        /// </summary>
        public class GetOwnerRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get owner operation.
        /// </summary>
        public class ServerGetOwnerRequestData : GetOwnerRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get owner operation.
        /// </summary>
        public class AdminGetOwnerRequestData : ServerGetOwnerRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get remove status operation.
        /// </summary>
        public class GetRemoveStatusRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
        /// Represents the request payload for the get statistics leaderboard around item operation.
        /// </summary>
        public class GetStatisticsLeaderboardAroundItemRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
        /// Represents the server-scoped request payload for the get statistics leaderboard around item operation.
        /// </summary>
        public class ServerGetStatisticsLeaderboardAroundItemRequestData : GetStatisticsLeaderboardAroundItemRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get statistics leaderboard around item operation.
        /// </summary>
        public class AdminGetStatisticsLeaderboardAroundItemRequestData : ServerGetStatisticsLeaderboardAroundItemRequestData
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
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            /// <summary>
            /// Stores the tag key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.TagKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? tagKeys;

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
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
        /// Represents the request payload for the remove segment operation.
        /// </summary>
        public class RemoveSegmentRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
        /// Represents the request payload for the set amount operation.
        /// </summary>
        public class SetAmountRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            /// <summary>
            /// Stores the amount value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Amount, mustInt = true)]
            public long amount;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the set amount operation.
        /// </summary>
        public class ServerSetAmountRequestData : SetAmountRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set amount operation.
        /// </summary>
        public class AdminSetAmountRequestData : ServerSetAmountRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set avatar operation.
        /// </summary>
        public class SetAvatarRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
        /// Represents the request payload for the set item data operation.
        /// </summary>
        public class SetItemDataRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            /// <summary>
            /// Stores the item datas value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.ItemDatas, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(ItemDataParam))]
            public List<ItemDataParam> itemDatas;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the set item data operation.
        /// </summary>
        public class ServerSetItemDataRequestData : SetItemDataRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set item data operation.
        /// </summary>
        public class AdminSetItemDataRequestData : ServerSetItemDataRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the change item statistics operation.
        /// </summary>
        public class ChangeItemStatisticsRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            /// <summary>
            /// Stores the item statistics value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.ItemStatistics, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(ItemStatisticsParam))]
            public List<ItemStatisticsParam> itemStatistics;

            /// <summary>
            /// Stores the log value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the change item statistics operation.
        /// </summary>
        public class ServerChangeItemStatisticsRequestData : ChangeItemStatisticsRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the change item statistics operation.
        /// </summary>
        public class AdminChangeItemStatisticsRequestData : ServerChangeItemStatisticsRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set owner operation.
        /// </summary>
        public class SetOwnerRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 11, maxLength = 11, mustNonNull = true)]
            public string itemId;

            /// <summary>
            /// Stores the new owner ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.NewOwnerId, minLength = 10, maxLength = 12, mustNonNull = true)]
            public string newOwnerId;

            /// <summary>
            /// Stores the new owner type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.NewOwnerType, mustInt = true)]
            public int newOwnerType;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the set owner operation.
        /// </summary>
        public class ServerSetOwnerRequestData : SetOwnerRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set owner operation.
        /// </summary>
        public class AdminSetOwnerRequestData : ServerSetOwnerRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set remove status operation.
        /// </summary>
        public class SetRemoveStatusRequestData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true, isOptional = true)]
            public string? itemId;

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

    }

    /// <summary>
    /// Defines payload models for inventory operations.
    /// </summary>
    public partial class InventoryModels
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
            /// Stores the catalog ID value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CatalogId, isOptional = true, defaultValue = false)]
            public bool? catalogId;

            /// <summary>
            /// Stores the class ID value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ClassId, isOptional = true, defaultValue = false)]
            public bool? classId;

            /// <summary>
            /// Stores the item type value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ItemType, isOptional = true, defaultValue = false)]
            public bool? itemType;

            /// <summary>
            /// Stores the amount value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Amount, isOptional = true, defaultValue = false)]
            public bool? amount;

            /// <summary>
            /// Stores the owner value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Owner, isOptional = true, defaultValue = false)]
            public bool? owner;

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
            /// Stores the item statistics value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ItemStatistics, isOptional = true, defaultValue = false)]
            public bool? itemStatistics;

            /// <summary>
            /// Stores the item datas value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ItemDatas, isOptional = true, defaultValue = false)]
            public bool? itemDatas;

            /// <summary>
            /// Stores the item data key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.ItemDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? itemDataKeys;

            /// <summary>
            /// Stores the item statistics key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.ItemStatisticsKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? itemStatisticsKeys;

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
        /// Represents the item data param component.
        /// </summary>
        public class ItemDataParam
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
        /// Represents the item statistics param component.
        /// </summary>
        public class ItemStatisticsParam
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
    /// Defines payload models for inventory operations.
    /// </summary>
    public partial class InventoryModels
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
            /// Stores the class ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ClassId, isOptional = true)]
            public string? classId;

            /// <summary>
            /// Stores the item type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.ItemType, isOptional = true)]
            public int? itemType;

            /// <summary>
            /// Stores the amount value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Amount, isOptional = true)]
            public int? amount;

            /// <summary>
            /// Stores the owner value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Owner, isOptional = true)]
            public GenericModels.OwnerItem? owner;

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
            /// Stores the item datas value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.ItemDatas, isOptional = true, elementCls = typeof(GenericModels.DataItem))]
            public List<GenericModels.DataItem>? itemDatas;

            /// <summary>
            /// Stores the item statistics value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.ItemStatistics, isOptional = true, elementCls = typeof(GenericModels.StatisticsItem))]
            public List<GenericModels.StatisticsItem>? itemStatistics;

        }

        /// <summary>
        /// Represents the response payload for the inventory operation.
        /// </summary>
        public class InventoryResponseData
        {
            /// <summary>
            /// Stores the info response parameters value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoResponseParameters)]
            public InfoResponseParameters infoResponseParameters;

        }

        /// <summary>
        /// Represents the response payload for the inventory with item ID operation.
        /// </summary>
        public class InventoryWithItemIdResponseData : InventoryResponseData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId)]
            public string itemId;

        }

        /// <summary>
        /// Represents the response payload for the inventory leaderboard operation.
        /// </summary>
        public class InventoryLeaderboardResponseData : InventoryWithItemIdResponseData
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
        /// Represents the response payload for the inventory log operation.
        /// </summary>
        public class InventoryLogResponseData
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId)]
            public string itemId;

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
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(InventoryLeaderboardResponseData))]
            public List<InventoryLeaderboardResponseData> results;

            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsCreate, isOptional = true)]
            public long? tsCreate;

        }

        /// <summary>
        /// Represents the response payload for the inventories with item ID operation.
        /// </summary>
        public class InventoriesWithItemIdResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(InventoryWithItemIdResponseData))]
            public List<InventoryWithItemIdResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the get create leaderboard operation.
        /// </summary>
        public class GetCreateLeaderboardResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(InventoryLeaderboardResponseData))]
            public List<InventoryLeaderboardResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the get statistics log operation.
        /// </summary>
        public class GetStatisticsLogResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(InventoryLogResponseData))]
            public List<InventoryLogResponseData> results;

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
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(InventoryLogResponseData))]
            public List<InventoryLogResponseData> results;

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