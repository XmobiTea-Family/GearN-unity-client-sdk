namespace XmobiTea.GN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;

    public partial class InventoryModels
    {
        public class AddSegmentRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [StringDataMember(code = GNParameterCode.Value, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string value;

        }

        public class ServerAddSegmentRequestData : AddSegmentRequestData
        {
        }

        public class AdminAddSegmentRequestData : ServerAddSegmentRequestData
        {
        }

        public class GetAmountRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        public class ServerGetAmountRequestData : GetAmountRequestData
        {
        }

        public class AdminGetAmountRequestData : ServerGetAmountRequestData
        {
        }

        public class GetAvatarRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        public class ServerGetAvatarRequestData : GetAvatarRequestData
        {
        }

        public class AdminGetAvatarRequestData : ServerGetAvatarRequestData
        {
        }

        public class GetCatalogIdRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        public class ServerGetCatalogIdRequestData : GetCatalogIdRequestData
        {
        }

        public class AdminGetCatalogIdRequestData : ServerGetCatalogIdRequestData
        {
        }

        public class GetClassIdRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        public class ServerGetClassIdRequestData : GetClassIdRequestData
        {
        }

        public class AdminGetClassIdRequestData : ServerGetClassIdRequestData
        {
        }

        public class GetCustomDataRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        public class ServerGetDisplayNameRequestData : GetDisplayNameRequestData
        {
        }

        public class AdminGetDisplayNameRequestData : ServerGetDisplayNameRequestData
        {
        }

        public class GetItemDataRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [GNArrayDataMember(code = GNParameterCode.ItemDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? inventoryDataKeys;

        }

        public class ServerGetItemDataRequestData : GetItemDataRequestData
        {
        }

        public class AdminGetItemDataRequestData : ServerGetItemDataRequestData
        {
        }

        public class GetItemInformationRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class ServerGetItemInformationRequestData : GetItemInformationRequestData
        {
        }

        public class AdminGetItemInformationRequestData : ServerGetItemInformationRequestData
        {
        }

        public class GetItemStatisticsRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [GNArrayDataMember(code = GNParameterCode.StatisticsKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? statisticsKeys;

        }

        public class ServerGetItemStatisticsRequestData : GetItemStatisticsRequestData
        {
        }

        public class AdminGetItemStatisticsRequestData : ServerGetItemStatisticsRequestData
        {
        }

        public class GetItemsWithDisplayNameRequestData
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

        public class ServerGetItemsWithDisplayNameRequestData : GetItemsWithDisplayNameRequestData
        {
        }

        public class AdminGetItemsWithDisplayNameRequestData : ServerGetItemsWithDisplayNameRequestData
        {
        }

        public class GetItemsWithSegmentRequestData
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

        public class ServerGetItemsWithSegmentRequestData : GetItemsWithSegmentRequestData
        {
        }

        public class AdminGetItemsWithSegmentRequestData : ServerGetItemsWithSegmentRequestData
        {
        }

        public class GetItemsWithTagRequestData
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

        public class ServerGetItemsWithTagRequestData : GetItemsWithTagRequestData
        {
        }

        public class AdminGetItemsWithTagRequestData : ServerGetItemsWithTagRequestData
        {
        }

        public class GetItemTypeRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        public class ServerGetItemTypeRequestData : GetItemTypeRequestData
        {
        }

        public class AdminGetItemTypeRequestData : ServerGetItemTypeRequestData
        {
        }

        public class GetOwnerRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        public class ServerGetOwnerRequestData : GetOwnerRequestData
        {
        }

        public class AdminGetOwnerRequestData : ServerGetOwnerRequestData
        {
        }

        public class GetRemoveStatusRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        public class ServerGetRemoveStatusRequestData : GetRemoveStatusRequestData
        {
        }

        public class AdminGetRemoveStatusRequestData : ServerGetRemoveStatusRequestData
        {
        }

        public class GetSegmentRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        public class ServerGetSegmentRequestData : GetSegmentRequestData
        {
        }

        public class AdminGetSegmentRequestData : ServerGetSegmentRequestData
        {
        }

        public class GetStatisticsLeaderboardAroundItemRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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

            [StringDataMember(code = GNParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? catalogId;

        }

        public class ServerGetStatisticsLeaderboardAroundItemRequestData : GetStatisticsLeaderboardAroundItemRequestData
        {
        }

        public class AdminGetStatisticsLeaderboardAroundItemRequestData : ServerGetStatisticsLeaderboardAroundItemRequestData
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

            [StringDataMember(code = GNParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true, isOptional = true)]
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
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

        }

        public class ServerGetTsCreateRequestData : GetTsCreateRequestData
        {
        }

        public class AdminGetTsCreateRequestData : ServerGetTsCreateRequestData
        {
        }

        public class RemoveSegmentRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

        }

        public class ServerRemoveTagRequestData : RemoveTagRequestData
        {
        }

        public class AdminRemoveTagRequestData : ServerRemoveTagRequestData
        {
        }

        public class SetAmountRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [NumberDataMember(code = GNParameterCode.Amount, mustInt = true)]
            public long amount;

        }

        public class ServerSetAmountRequestData : SetAmountRequestData
        {
        }

        public class AdminSetAmountRequestData : ServerSetAmountRequestData
        {
        }

        public class SetAvatarRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [NumberDataMember(code = GNParameterCode.Type, mustInt = true)]
            public int type;

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
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [StringDataMember(code = GNParameterCode.DisplayName, minLength = 5, maxLength = 32, mustNonNull = true)]
            public string displayName;

        }

        public class ServerSetDisplayNameRequestData : SetDisplayNameRequestData
        {
        }

        public class AdminSetDisplayNameRequestData : ServerSetDisplayNameRequestData
        {
        }

        public class SetItemDataRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [GNArrayDataMember(code = GNParameterCode.ItemDatas, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(ItemDataParam))]
            public List<ItemDataParam> inventoryDataParams;

        }

        public class ServerSetItemDataRequestData : SetItemDataRequestData
        {
        }

        public class AdminSetItemDataRequestData : ServerSetItemDataRequestData
        {
        }

        public class SetItemStatisticsRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [GNArrayDataMember(code = GNParameterCode.ItemStatistics, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(ItemStatisticsParam))]
            public List<ItemStatisticsParam> inventoryStatisticsParams;

            [StringDataMember(code = GNParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        public class ServerSetItemStatisticsRequestData : SetItemStatisticsRequestData
        {
        }

        public class AdminSetItemStatisticsRequestData : ServerSetItemStatisticsRequestData
        {
        }

        public class SetOwnerRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 11, maxLength = 11, mustNonNull = true)]
            public string itemId;

            [StringDataMember(code = GNParameterCode.OwnerId, minLength = 10, maxLength = 12, mustNonNull = true)]
            public string newOwnerId;

            [NumberDataMember(code = GNParameterCode.OwnerType, mustInt = true)]
            public int newOwnerType;

        }

        public class ServerSetOwnerRequestData : SetOwnerRequestData
        {
        }

        public class AdminSetOwnerRequestData : ServerSetOwnerRequestData
        {
        }

        public class SetRemoveStatusRequestData
        {
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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

            [StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true, isOptional = true)]
            public string? itemId;

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

    }

    public partial class InventoryModels
    {
        public class CustomDataParam
        {
            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [DataMember(code = GNParameterCode.Value)]
            public object value;

        }

        public class InfoRequestParam
        {
            [BooleanDataMember(code = GNParameterCode.CatalogId, isOptional = true, defaultValue = false)]
            public bool? catalogId;

            [BooleanDataMember(code = GNParameterCode.ClassId, isOptional = true, defaultValue = false)]
            public bool? classId;

            [BooleanDataMember(code = GNParameterCode.ItemType, isOptional = true, defaultValue = false)]
            public bool? itemType;

            [BooleanDataMember(code = GNParameterCode.Amount, isOptional = true, defaultValue = false)]
            public bool? amount;

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

            [BooleanDataMember(code = GNParameterCode.ItemStatistics, isOptional = true, defaultValue = false)]
            public bool? itemStatistics;

            [BooleanDataMember(code = GNParameterCode.ItemDatas, isOptional = true, defaultValue = false)]
            public bool? itemDatas;

            [GNArrayDataMember(code = GNParameterCode.ItemDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? itemDataKeys;

            [GNArrayDataMember(code = GNParameterCode.ItemStatisticsKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? itemStatisticsKeys;

            [GNArrayDataMember(code = GNParameterCode.CustomDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? customDataKeys;

            [GNArrayDataMember(code = GNParameterCode.TagKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? tagKeys;

        }

        public class ItemDataParam
        {
            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [DataMember(code = GNParameterCode.Value)]
            public object value;

        }

        public class ItemStatisticsParam
        {
            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [NumberDataMember(code = GNParameterCode.Value)]
            public double value;

        }

    }

    public partial class InventoryModels
    {
        public class InfoResponseParameters
        {
            [StringDataMember(code = GNParameterCode.CatalogId, isOptional = true)]
            public string? catalogId;

            [StringDataMember(code = GNParameterCode.ClassId, isOptional = true)]
            public string? classId;

            [NumberDataMember(code = GNParameterCode.ItemType, isOptional = true)]
            public int? itemType;

            [NumberDataMember(code = GNParameterCode.Amount, isOptional = true)]
            public int? amount;

            [GNHashtableDataMember(code = GNParameterCode.Owner, isOptional = true)]
            public GenericModels.OwnerItem? owner;

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

            [GNArrayDataMember(code = GNParameterCode.ItemDatas, isOptional = true, elementCls = typeof(GenericModels.DataItem))]
            public List<GenericModels.DataItem>? itemDatas;

            [GNArrayDataMember(code = GNParameterCode.ItemStatistics, isOptional = true, elementCls = typeof(GenericModels.StatisticsItem))]
            public List<GenericModels.StatisticsItem>? itemStatistics;

        }

        public class InventoryResponseData
        {
            [GNHashtableDataMember(code = GNParameterCode.InfoResponseParameters)]
            public InfoResponseParameters infoResponseParameters;

        }

        public class InventoryWithItemIdResponseData : InventoryResponseData
        {
            [StringDataMember(code = GNParameterCode.ItemId)]
            public string itemId;

        }

        public class InventoryLeaderboardResponseData : InventoryWithItemIdResponseData
        {
            [NumberDataMember(code = GNParameterCode.Position)]
            public int position;

            [NumberDataMember(code = GNParameterCode.BackupValue, isOptional = true)]
            public double? backupValue;

        }

        public class InventoryLogResponseData
        {
            [StringDataMember(code = GNParameterCode.ItemId)]
            public string itemId;

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
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(InventoryLeaderboardResponseData))]
            public List<InventoryLeaderboardResponseData> results;

            [NumberDataMember(code = GNParameterCode.TsCreate, isOptional = true)]
            public long? tsCreate;

        }

        public class InventoriesWithItemIdResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(InventoryWithItemIdResponseData))]
            public List<InventoryWithItemIdResponseData> results;

        }

        public class GetCreateLeaderboardResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(InventoryLeaderboardResponseData))]
            public List<InventoryLeaderboardResponseData> results;

        }

        public class GetStatisticsLogResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(InventoryLogResponseData))]
            public List<InventoryLogResponseData> results;

            [StringDataMember(code = GNParameterCode.Token, isOptional = true)]
            public string? token;

        }

        public class GetCurrencyLogResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(InventoryLogResponseData))]
            public List<InventoryLogResponseData> results;

            [StringDataMember(code = GNParameterCode.Token, isOptional = true)]
            public string? token;

        }

        public class EmptyResponseData
        {

        }

    }

}
