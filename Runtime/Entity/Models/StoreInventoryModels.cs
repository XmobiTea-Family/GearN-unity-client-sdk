namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Constant;

    public partial class StoreInventoryModels
    {
        public class BuyStoreItemRequestData
        {
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

            [StringDataMember(code = ParameterCode.Id, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string id;

            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        public class ServerBuyStoreItemRequestData : BuyStoreItemRequestData
        {
        }

        public class AdminBuyStoreItemRequestData : ServerBuyStoreItemRequestData
        {
        }

        public class PresentStoreItemRequestData
        {
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

            [StringDataMember(code = ParameterCode.Id, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string id;

            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        public class ServerPresentStoreItemRequestData : PresentStoreItemRequestData
        {
        }

        public class AdminPresentStoreItemRequestData : ServerPresentStoreItemRequestData
        {
        }

        public class GetStoreItemInformationRequestData
        {
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class ServerGetStoreItemInformationRequestData : GetStoreItemInformationRequestData
        {
        }

        public class AdminGetStoreItemInformationRequestData : ServerGetStoreItemInformationRequestData
        {
        }

        public class GetStoreLogRequestData
        {
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? storeId;

            [GNArrayDataMember(code = ParameterCode.StoreReceiveTypes, minLength = 1, maxLength = 10, mustNonNull = true, elementCls = typeof(int))]
            public List<int> storeReceiveTypes;

            [StringDataMember(code = ParameterCode.Id, minLength = 10, maxLength = 11, mustNonNull = true, isOptional = true)]
            public string? id;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            [StringDataMember(code = ParameterCode.Token, minLength = 24, maxLength = 24, mustNonNull = true, isOptional = true)]
            public string? token;

        }

        public class ServerGetStoreLogRequestData : GetStoreLogRequestData
        {
        }

        public class AdminGetStoreLogRequestData : ServerGetStoreLogRequestData
        {
        }

        public class GetStoreUsedRequestData
        {
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

        }

        public class ServerGetStoreUsedRequestData : GetStoreUsedRequestData
        {
        }

        public class AdminGetStoreUsedRequestData : ServerGetStoreUsedRequestData
        {
        }

        public class RemoveStoreUsedRequestData
        {
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

            [GNArrayDataMember(code = ParameterCode.OwnerIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? ownerIds;

        }

        public class ServerRemoveStoreUsedRequestData : RemoveStoreUsedRequestData
        {
        }

        public class AdminRemoveStoreUsedRequestData : ServerRemoveStoreUsedRequestData
        {
        }

        public class GetStoreItemsWithTagRequestData
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

        public class ServerGetStoreItemsWithTagRequestData : GetStoreItemsWithTagRequestData
        {
        }

        public class AdminGetStoreItemsWithTagRequestData : ServerGetStoreItemsWithTagRequestData
        {
        }

        public class CreateStoreItemRequestData
        {
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, isOptional = true)]
            public string? storeId;

            [StringDataMember(code = ParameterCode.DisplayName, defaultValue = "", isOptional = true)]
            public string? displayName;

        }

        public class ServerCreateStoreItemRequestData : CreateStoreItemRequestData
        {
        }

        public class AdminCreateStoreItemRequestData : ServerCreateStoreItemRequestData
        {
        }

        public class SetRemoveStatusRequestData
        {
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

            [StringDataMember(code = ParameterCode.Reason, isOptional = true, defaultValue = "")]
            public string? reason;

        }

        public class ServerSetRemoveStatusRequestData : SetRemoveStatusRequestData
        {
        }

        public class AdminSetRemoveStatusRequestData : ServerSetRemoveStatusRequestData
        {
        }

        public class SetStoreItemInformationRequestData
        {
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

            [NumberDataMember(code = ParameterCode.StoreItemType, minValue = 1, maxValue = 2, mustInt = true, isOptional = true)]
            public int? storeItemType;

            [GNArrayDataMember(code = ParameterCode.StoreDatas, minLength = 0, maxLength = 32, mustNonNull = true, isOptional = true, elementCls = typeof(StoreDataParam))]
            public List<StoreDataParam>? storeDatas;

            [GNArrayDataMember(code = ParameterCode.StoreItems, minLength = 0, maxLength = 32, mustNonNull = true, isOptional = true, elementCls = typeof(StoreItemParam))]
            public List<StoreItemParam>? storeItems;

            [GNArrayDataMember(code = ParameterCode.StoreCurrencies, minLength = 0, maxLength = 32, mustNonNull = true, isOptional = true, elementCls = typeof(CurrencyParam))]
            public List<CurrencyParam>? storeCurrencies;

            [GNArrayDataMember(code = ParameterCode.PriceCurrencies, minLength = 0, maxLength = 32, mustNonNull = true, isOptional = true, elementCls = typeof(CurrencyParam))]
            public List<CurrencyParam>? priceCurrencies;

            [GNHashtableDataMember(code = ParameterCode.InAppPurchase, mustNonNull = true, isOptional = true)]
            public InAppPurchaseParam? inAppPurchase;

            [StringDataMember(code = ParameterCode.DisplayName, mustNonNull = true, isOptional = true)]
            public string? displayName;

            [GNHashtableDataMember(code = ParameterCode.Avatar, mustNonNull = true, isOptional = true)]
            public AvatarParam? avatar;

            [GNArrayDataMember(code = ParameterCode.Tags, minLength = 0, maxLength = 32, mustNonNull = true, isOptional = true, elementCls = typeof(TagParam))]
            public List<TagParam>? tags;

        }

        public class ServerSetStoreItemInformationRequestData : SetStoreItemInformationRequestData
        {
        }

        public class AdminSetStoreItemInformationRequestData : ServerSetStoreItemInformationRequestData
        {
        }

        public class ValidateAppleAppStoreReceiptRequestData
        {
            [StringDataMember(code = ParameterCode.Receipt, minLength = 10, maxLength = 2048, mustNonNull = true)]
            public string receipt;

            [StringDataMember(code = ParameterCode.Id, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string id;

            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        public class ServerValidateAppleAppStoreReceiptRequestData : ValidateAppleAppStoreReceiptRequestData
        {
        }

        public class AdminValidateAppleAppStoreReceiptRequestData : ServerValidateAppleAppStoreReceiptRequestData
        {
        }

        public class ValidateFacebookStoreReceiptRequestData
        {
            [StringDataMember(code = ParameterCode.Receipt, minLength = 10, maxLength = 2048, mustNonNull = true)]
            public string receipt;

            [StringDataMember(code = ParameterCode.Id, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string id;

            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        public class ServerValidateFacebookStoreReceiptRequestData : ValidateFacebookStoreReceiptRequestData
        {
        }

        public class AdminValidateFacebookStoreReceiptRequestData : ServerValidateFacebookStoreReceiptRequestData
        {
        }

        public class ValidateGooglePlayStoreReceiptRequestData
        {
            [StringDataMember(code = ParameterCode.Receipt, minLength = 10, maxLength = 2048, mustNonNull = true)]
            public string receipt;

            [StringDataMember(code = ParameterCode.Id, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string id;

            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        public class ServerValidateGooglePlayStoreReceiptRequestData : ValidateGooglePlayStoreReceiptRequestData
        {
        }

        public class AdminValidateGooglePlayStoreReceiptRequestData : ServerValidateGooglePlayStoreReceiptRequestData
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

    }

    public partial class StoreInventoryModels
    {
        public class AvatarParam
        {
            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            [StringDataMember(code = ParameterCode.Value, minLength = 1, maxLength = 128, mustNonNull = true)]
            public string value;

        }

        public class CurrencyParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [NumberDataMember(code = ParameterCode.Value)]
            public double value;

        }

        public class InAppPurchaseParam
        {
            [StringDataMember(code = ParameterCode.FacebookStoreId, minLength = 1, maxLength = 128, mustNonNull = true, isOptional = true)]
            public string? facebookStoreId;

            [StringDataMember(code = ParameterCode.GooglePlayStoreId, minLength = 1, maxLength = 128, mustNonNull = true, isOptional = true)]
            public string? googlePlayStoreId;

            [StringDataMember(code = ParameterCode.AppleAppStoreId, minLength = 1, maxLength = 128, mustNonNull = true, isOptional = true)]
            public string? appleAppStoreId;

            [NumberDataMember(code = ParameterCode.AnalyticsPrice, isOptional = true)]
            public double? analyticsPrice;

        }

        public class InfoRequestParam
        {
            [BooleanDataMember(code = ParameterCode.StoreItems, isOptional = true, defaultValue = false)]
            public bool? storeItems;

            [BooleanDataMember(code = ParameterCode.StoreItemType, isOptional = true, defaultValue = false)]
            public bool? storeItemType;

            [BooleanDataMember(code = ParameterCode.StoreCurrencies, isOptional = true, defaultValue = false)]
            public bool? storeCurrencies;

            [BooleanDataMember(code = ParameterCode.PriceCurrencies, isOptional = true, defaultValue = false)]
            public bool? priceCurrencies;

            [BooleanDataMember(code = ParameterCode.InAppPurchase, isOptional = true, defaultValue = false)]
            public bool? inAppPurchase;

            [BooleanDataMember(code = ParameterCode.RemoveStatus, isOptional = true, defaultValue = false)]
            public bool? removeStatus;

            [BooleanDataMember(code = ParameterCode.DisplayName, isOptional = true, defaultValue = false)]
            public bool? displayName;

            [BooleanDataMember(code = ParameterCode.Avatar, isOptional = true, defaultValue = false)]
            public bool? avatar;

            [BooleanDataMember(code = ParameterCode.TsCreate, isOptional = true, defaultValue = false)]
            public bool? tsCreate;

            [BooleanDataMember(code = ParameterCode.Tags, isOptional = true, defaultValue = false)]
            public bool? tags;

            [BooleanDataMember(code = ParameterCode.StoreDatas, isOptional = true, defaultValue = false)]
            public bool? storeDatas;

        }

        public class StoreDataParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [DataMember(code = ParameterCode.Value)]
            public object value;

        }

        public class StoreItemParam
        {
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32)]
            public string catalogId;

            [StringDataMember(code = ParameterCode.ClassId, minLength = 2, maxLength = 32)]
            public string classId;

            [NumberDataMember(code = ParameterCode.Amount)]
            public double amount;

        }

        public class TagParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [StringDataMember(code = ParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string value;

        }

    }

    public partial class StoreInventoryModels
    {
        public class InAppPurchaseItem
        {
            [StringDataMember(code = ParameterCode.FacebookStoreId)]
            public string facebookStoreId;

            [StringDataMember(code = ParameterCode.AppleAppStoreId)]
            public string appleAppStoreId;

            [StringDataMember(code = ParameterCode.GooglePlayStoreId)]
            public string googlePlayStoreId;

            [NumberDataMember(code = ParameterCode.AnalyticsPrice)]
            public double analyticsPrice;

        }

        public class PriceCurrencyItem
        {
            [StringDataMember(code = ParameterCode.Key)]
            public string key;

            [NumberDataMember(code = ParameterCode.Value)]
            public double value;

        }

        public class OwnerStoreInventoryItem
        {
            [StringDataMember(code = ParameterCode.ItemId)]
            public string itemId;

            [StringDataMember(code = ParameterCode.CatalogId)]
            public string catalogId;

            [StringDataMember(code = ParameterCode.ClassId)]
            public string classId;

        }

        public class StoreInventoryItem
        {
            [StringDataMember(code = ParameterCode.CatalogId)]
            public string catalogId;

            [StringDataMember(code = ParameterCode.ClassId)]
            public string classId;

            [NumberDataMember(code = ParameterCode.Amount)]
            public int amount;

        }

        public class InfoResponseParameters
        {
            [GNArrayDataMember(code = ParameterCode.StoreItems, isOptional = true, elementCls = typeof(StoreInventoryItem))]
            public List<StoreInventoryItem>? storeItems;

            [BooleanDataMember(code = ParameterCode.StoreItemType, isOptional = true, defaultValue = false)]
            public bool? storeItemType;

            [GNArrayDataMember(code = ParameterCode.StoreCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? storeCurrencies;

            [GNArrayDataMember(code = ParameterCode.PriceCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? priceCurrencies;

            [GNHashtableDataMember(code = ParameterCode.InAppPurchase, isOptional = true)]
            public InAppPurchaseItem? inAppPurchase;

            [GNHashtableDataMember(code = ParameterCode.RemoveStatus, isOptional = true)]
            public GenericModels.RemoveStatusItem? removeStatus;

            [StringDataMember(code = ParameterCode.DisplayName, isOptional = true)]
            public string? displayName;

            [GNHashtableDataMember(code = ParameterCode.Avatar, isOptional = true)]
            public GenericModels.AvatarItem? avatar;

            [NumberDataMember(code = ParameterCode.TsCreate, isOptional = true)]
            public long? tsCreate;

            [GNArrayDataMember(code = ParameterCode.Tags, isOptional = true, elementCls = typeof(GenericModels.TagItem))]
            public List<GenericModels.TagItem>? tags;

            [GNArrayDataMember(code = ParameterCode.StoreDatas, isOptional = true, elementCls = typeof(GenericModels.DataItem))]
            public List<GenericModels.DataItem>? storeDatas;

        }

        public class StoreInventoryResponseData
        {
            [GNHashtableDataMember(code = ParameterCode.InfoResponseParameters)]
            public InfoResponseParameters infoResponseParameters;

        }

        public class StoreInventoryWithStoreIdResponseData : StoreInventoryResponseData
        {
            [StringDataMember(code = ParameterCode.StoreId)]
            public string storeId;

        }

        public class StoreInventoryLeaderboardResponseData : StoreInventoryWithStoreIdResponseData
        {
            [NumberDataMember(code = ParameterCode.Position)]
            public int position;

        }

        public class StoreInventoriesWithStoreIdResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(StoreInventoryWithStoreIdResponseData))]
            public List<StoreInventoryWithStoreIdResponseData> results;

        }

        public class CreateStoreItemResponseData
        {
            [StringDataMember(code = ParameterCode.StoreId)]
            public string storeId;
        }

        public class OwnerInfoResponseParameters
        {
            [GNArrayDataMember(code = ParameterCode.Currencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? currencies;

            [GNArrayDataMember(code = ParameterCode.Inventories, isOptional = true, elementCls = typeof(OwnerStoreInventoryItem))]
            public List<OwnerStoreInventoryItem>? inventories;

        }

        public class BuyStoreInventoryResponseData
        {
            [GNArrayDataMember(code = ParameterCode.StoreCurrencies, isOptional = true, elementCls = typeof(StoreInventoryItem))]
            public List<StoreInventoryItem>? storeItems;

            [GNArrayDataMember(code = ParameterCode.StoreCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? storeCurrencies;

            [GNArrayDataMember(code = ParameterCode.PriceCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? priceCurrencies;

            [GNHashtableDataMember(code = ParameterCode.InfoResponseParameters, isOptional = true)]
            public OwnerInfoResponseParameters? infoResponseParameters;

        }

        public class GetCreateLeaderboardResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(StoreInventoryLeaderboardResponseData))]
            public List<StoreInventoryLeaderboardResponseData> results;

        }

        public class PresentStoreInventoryResponseData
        {
            [GNArrayDataMember(code = ParameterCode.StoreCurrencies, isOptional = true, elementCls = typeof(StoreInventoryItem))]
            public List<StoreInventoryItem>? storeItems;

            [GNArrayDataMember(code = ParameterCode.StoreCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? storeCurrencies;

            [GNArrayDataMember(code = ParameterCode.PriceCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? priceCurrencies;

            [GNHashtableDataMember(code = ParameterCode.InfoResponseParameters, isOptional = true)]
            public OwnerInfoResponseParameters? infoResponseParameters;

        }

        public class CurrencyResponseData
        {
            [StringDataMember(code = ParameterCode.Key)]
            public string key;

            [NumberDataMember(code = ParameterCode.Value)]
            public double value;

        }

        public class StoreItemResponseData
        {
            [StringDataMember(code = ParameterCode.CatalogId)]
            public string catalogId;

            [StringDataMember(code = ParameterCode.ClassId)]
            public string classId;

            [StringDataMember(code = ParameterCode.ItemId)]
            public string itemId;

        }

        public class StoreLogResponseData
        {
            [StringDataMember(code = ParameterCode.StoreId)]
            public string storeId;

            [StringDataMember(code = ParameterCode.OwnerId)]
            public string id;

            [NumberDataMember(code = ParameterCode.OwnerType)]
            public int type;

            [StringDataMember(code = ParameterCode.TransactionId, isOptional = true)]
            public string? transactionId;

            [NumberDataMember(code = ParameterCode.StoreReceiveType)]
            public int storeReceiveType;

            [GNArrayDataMember(code = ParameterCode.PriceCurrencyStartValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> priceCurrencyStartValues;

            [GNArrayDataMember(code = ParameterCode.PriceCurrencyAmountValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> priceCurrencyAmountValues;

            [GNArrayDataMember(code = ParameterCode.PriceCurrencyFinalValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> priceCurrencyFinalValues;

            [GNArrayDataMember(code = ParameterCode.StoreCurrencyStartValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> storeCurrencyStartValues;

            [GNArrayDataMember(code = ParameterCode.StoreCurrencyAmountValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> storeCurrencyAmountValues;

            [GNArrayDataMember(code = ParameterCode.StoreCurrencyFinalValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> storeCurrencyFinalValues;

            [GNArrayDataMember(code = ParameterCode.StoreItemFinalValues, elementCls = typeof(StoreItemResponseData))]
            public List<StoreItemResponseData> storeItemFinalValues;

            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            [StringDataMember(code = ParameterCode.Log)]
            public string log;

        }

        public class GetStoreLogResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(StoreLogResponseData))]
            public List<StoreLogResponseData> results;

            [StringDataMember(code = ParameterCode.Token, isOptional = true)]
            public string? token;

        }

        public class StoreUsedResponseData
        {
            [StringDataMember(code = ParameterCode.OwnerId)]
            public string id;

            [NumberDataMember(code = ParameterCode.OwnerType)]
            public int type;

            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

        }

        public class GetStoreUsedResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(StoreUsedResponseData))]
            public List<StoreUsedResponseData> results;

        }

        public class EmptyResponseData
        {

        }

    }

}
