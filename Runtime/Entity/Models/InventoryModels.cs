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

		public class AdminAddSegmentRequestData : AddSegmentRequestData
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

		public class AdminGetAmountRequestData : GetAmountRequestData
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

		public class AdminGetAvatarRequestData : GetAvatarRequestData
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

		public class AdminGetCatalogIdRequestData : GetCatalogIdRequestData
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

		public class AdminGetClassIdRequestData : GetClassIdRequestData
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

		public class AdminGetCustomDataRequestData : GetCustomDataRequestData
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

		public class AdminGetDisplayNameRequestData : GetDisplayNameRequestData
		{
		}

		public class GetItemDataRequestData
		{
			[StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
			public string itemId;

			[GNArrayDataMember(code = GNParameterCode.ItemDataKeys, isOptional = true)]
			public List<string>? inventoryDataKeys;

		}

		public class ServerGetItemDataRequestData : GetItemDataRequestData
		{
		}

		public class AdminGetItemDataRequestData : GetItemDataRequestData
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

		public class AdminGetItemInformationRequestData : GetItemInformationRequestData
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

		public class AdminGetItemStatisticsRequestData : GetItemStatisticsRequestData
		{
		}

		public class GetItemsWithDisplayNameRequestData
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

		public class ServerGetItemsWithDisplayNameRequestData : GetItemsWithDisplayNameRequestData
		{
		}

		public class AdminGetItemsWithDisplayNameRequestData : GetItemsWithDisplayNameRequestData
		{
		}

		public class GetItemsWithSegmentRequestData
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

		public class ServerGetItemsWithSegmentRequestData : GetItemsWithSegmentRequestData
		{
		}

		public class AdminGetItemsWithSegmentRequestData : GetItemsWithSegmentRequestData
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
			public long? skip;

			[NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
			public long? limit;

		}

		public class ServerGetItemsWithTagRequestData : GetItemsWithTagRequestData
		{
		}

		public class AdminGetItemsWithTagRequestData : GetItemsWithTagRequestData
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

		public class AdminGetItemTypeRequestData : GetItemTypeRequestData
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

		public class AdminGetOwnerRequestData : GetOwnerRequestData
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

		public class AdminGetRemoveStatusRequestData : GetRemoveStatusRequestData
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

		public class AdminGetSegmentRequestData : GetSegmentRequestData
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
			public long? skip;

			[NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
			public long? limit;

		}

		public class ServerGetStatisticsLeaderboardAroundItemRequestData : GetStatisticsLeaderboardAroundItemRequestData
		{
		}

		public class AdminGetStatisticsLeaderboardAroundItemRequestData : GetStatisticsLeaderboardAroundItemRequestData
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
			[StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
			public string itemId;

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
			[StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
			public string itemId;

		}

		public class ServerGetTsCreateRequestData : GetTsCreateRequestData
		{
		}

		public class AdminGetTsCreateRequestData : GetTsCreateRequestData
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

		public class AdminRemoveSegmentRequestData : RemoveSegmentRequestData
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

		public class AdminRemoveTagRequestData : RemoveTagRequestData
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

		public class AdminSetAmountRequestData : SetAmountRequestData
		{
		}

		public class SetAvatarRequestData
		{
			[StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
			public string itemId;

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

		public class AdminSetCustomDataRequestData : SetCustomDataRequestData
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

		public class AdminSetDisplayNameRequestData : SetDisplayNameRequestData
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

		public class AdminSetItemDataRequestData : SetItemDataRequestData
		{
		}

		public class SetItemStatisticsRequestData
		{
			[StringDataMember(code = GNParameterCode.ItemId, minLength = 12, maxLength = 12, mustNonNull = true)]
			public string itemId;

			[GNArrayDataMember(code = GNParameterCode.ItemStatistics, minLength = 1, maxLength = 32, mustNonNull = true, elementCls = typeof(ItemStatisticsParam))]
			public List<ItemStatisticsParam> inventoryStatisticsParams;

		}

		public class ServerSetItemStatisticsRequestData : SetItemStatisticsRequestData
		{
		}

		public class AdminSetItemStatisticsRequestData : SetItemStatisticsRequestData
		{
		}

		public class SetOwnerRequestData
		{
			[StringDataMember(code = GNParameterCode.ItemId, minLength = 11, maxLength = 11, mustNonNull = true)]
			public string itemId;

			[StringDataMember(code = GNParameterCode.OwnerId, minLength = 10, maxLength = 12, mustNonNull = true)]
			public string newOwnerId;

			[NumberDataMember(code = GNParameterCode.OwnerType, mustInt = true)]
			public long newOwnerType;

		}

		public class ServerSetOwnerRequestData : SetOwnerRequestData
		{
		}

		public class AdminSetOwnerRequestData : SetOwnerRequestData
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

		public class AdminSetRemoveStatusRequestData : SetRemoveStatusRequestData
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

		public class AdminSetTagRequestData : SetTagRequestData
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

			[NumberDataMember(code = GNParameterCode.Permission, mustInt = true)]
			public long permission;

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

		public class ResponseData
		{

		}

	}

}
