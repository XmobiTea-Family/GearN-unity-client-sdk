namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Constant;

    public partial class InventoryModels
    {
        public class AddSegmentRequestData
        {
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [StringDataMember(code = ParameterCode.Value, minLength = 6, maxLength = 32, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [GNArrayDataMember(code = ParameterCode.ItemDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? itemDataKeys;

        }

        public class ServerGetItemDataRequestData : GetItemDataRequestData
        {
        }

        public class AdminGetItemDataRequestData : ServerGetItemDataRequestData
        {
        }

        public class GetItemInformationRequestData
        {
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [GNArrayDataMember(code = ParameterCode.StatisticsKeys, isOptional = true, elementCls = typeof(string))]
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
            [StringDataMember(code = ParameterCode.Keyword, minLength = 2, maxLength = 32)]
            public string keyword;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
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
            [StringDataMember(code = ParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string value;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
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

        public class ServerGetItemsWithTagRequestData : GetItemsWithTagRequestData
        {
        }

        public class AdminGetItemsWithTagRequestData : ServerGetItemsWithTagRequestData
        {
        }

        public class GetItemTypeRequestData
        {
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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

        public class ServerGetStatisticsLeaderboardAroundItemRequestData : GetStatisticsLeaderboardAroundItemRequestData
        {
        }

        public class AdminGetStatisticsLeaderboardAroundItemRequestData : ServerGetStatisticsLeaderboardAroundItemRequestData
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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [NumberDataMember(code = ParameterCode.Amount, mustInt = true)]
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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [StringDataMember(code = ParameterCode.DisplayName, minLength = 5, maxLength = 32, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [GNArrayDataMember(code = ParameterCode.ItemDatas, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(ItemDataParam))]
            public List<ItemDataParam> itemDatas;

        }

        public class ServerSetItemDataRequestData : SetItemDataRequestData
        {
        }

        public class AdminSetItemDataRequestData : ServerSetItemDataRequestData
        {
        }

        public class ChangeItemStatisticsRequestData
        {
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

            [GNArrayDataMember(code = ParameterCode.ItemStatistics, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(ItemStatisticsParam))]
            public List<ItemStatisticsParam> itemStatistics;

            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        public class ServerChangeItemStatisticsRequestData : ChangeItemStatisticsRequestData
        {
        }

        public class AdminChangeItemStatisticsRequestData : ServerChangeItemStatisticsRequestData
        {
        }

        public class SetOwnerRequestData
        {
            [StringDataMember(code = ParameterCode.ItemId, minLength = 11, maxLength = 11, mustNonNull = true)]
            public string itemId;

            [StringDataMember(code = ParameterCode.NewOwnerId, minLength = 10, maxLength = 12, mustNonNull = true)]
            public string newOwnerId;

            [NumberDataMember(code = ParameterCode.NewOwnerType, mustInt = true)]
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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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
            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
            public string itemId;

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

            [StringDataMember(code = ParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true, isOptional = true)]
            public string? itemId;

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

    }

    public partial class InventoryModels
    {
        public class CustomDataParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [DataMember(code = ParameterCode.Value)]
            public object value;

        }

        public class InfoRequestParam
        {
            [BooleanDataMember(code = ParameterCode.CatalogId, isOptional = true, defaultValue = false)]
            public bool? catalogId;

            [BooleanDataMember(code = ParameterCode.ClassId, isOptional = true, defaultValue = false)]
            public bool? classId;

            [BooleanDataMember(code = ParameterCode.ItemType, isOptional = true, defaultValue = false)]
            public bool? itemType;

            [BooleanDataMember(code = ParameterCode.Amount, isOptional = true, defaultValue = false)]
            public bool? amount;

            [BooleanDataMember(code = ParameterCode.Owner, isOptional = true, defaultValue = false)]
            public bool? owner;

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

            [BooleanDataMember(code = ParameterCode.ItemStatistics, isOptional = true, defaultValue = false)]
            public bool? itemStatistics;

            [BooleanDataMember(code = ParameterCode.ItemDatas, isOptional = true, defaultValue = false)]
            public bool? itemDatas;

            [GNArrayDataMember(code = ParameterCode.ItemDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? itemDataKeys;

            [GNArrayDataMember(code = ParameterCode.ItemStatisticsKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? itemStatisticsKeys;

            [GNArrayDataMember(code = ParameterCode.CustomDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? customDataKeys;

            [GNArrayDataMember(code = ParameterCode.TagKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? tagKeys;

        }

        public class ItemDataParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [DataMember(code = ParameterCode.Value)]
            public object value;

        }

        public class ItemStatisticsParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [NumberDataMember(code = ParameterCode.Value)]
            public double value;

        }

    }

    public partial class InventoryModels
    {
        public class InfoResponseParameters
        {
            [StringDataMember(code = ParameterCode.CatalogId, isOptional = true)]
            public string? catalogId;

            [StringDataMember(code = ParameterCode.ClassId, isOptional = true)]
            public string? classId;

            [NumberDataMember(code = ParameterCode.ItemType, isOptional = true)]
            public int? itemType;

            [NumberDataMember(code = ParameterCode.Amount, isOptional = true)]
            public int? amount;

            [GNHashtableDataMember(code = ParameterCode.Owner, isOptional = true)]
            public GenericModels.OwnerItem? owner;

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

            [GNArrayDataMember(code = ParameterCode.ItemDatas, isOptional = true, elementCls = typeof(GenericModels.DataItem))]
            public List<GenericModels.DataItem>? itemDatas;

            [GNArrayDataMember(code = ParameterCode.ItemStatistics, isOptional = true, elementCls = typeof(GenericModels.StatisticsItem))]
            public List<GenericModels.StatisticsItem>? itemStatistics;

        }

        public class InventoryResponseData
        {
            [GNHashtableDataMember(code = ParameterCode.InfoResponseParameters)]
            public InfoResponseParameters infoResponseParameters;

        }

        public class InventoryWithItemIdResponseData : InventoryResponseData
        {
            [StringDataMember(code = ParameterCode.ItemId)]
            public string itemId;

        }

        public class InventoryLeaderboardResponseData : InventoryWithItemIdResponseData
        {
            [NumberDataMember(code = ParameterCode.Position)]
            public int position;

            [NumberDataMember(code = ParameterCode.BackupValue, isOptional = true)]
            public double? backupValue;

        }

        public class InventoryLogResponseData
        {
            [StringDataMember(code = ParameterCode.ItemId)]
            public string itemId;

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
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(InventoryLeaderboardResponseData))]
            public List<InventoryLeaderboardResponseData> results;

            [NumberDataMember(code = ParameterCode.TsCreate, isOptional = true)]
            public long? tsCreate;

        }

        public class InventoriesWithItemIdResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(InventoryWithItemIdResponseData))]
            public List<InventoryWithItemIdResponseData> results;

        }

        public class GetCreateLeaderboardResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(InventoryLeaderboardResponseData))]
            public List<InventoryLeaderboardResponseData> results;

        }

        public class GetStatisticsLogResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(InventoryLogResponseData))]
            public List<InventoryLogResponseData> results;

            [StringDataMember(code = ParameterCode.Token, isOptional = true)]
            public string? token;

        }

        public class GetCurrencyLogResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(InventoryLogResponseData))]
            public List<InventoryLogResponseData> results;

            [StringDataMember(code = ParameterCode.Token, isOptional = true)]
            public string? token;

        }

        public class EmptyResponseData
        {

        }

    }

}
