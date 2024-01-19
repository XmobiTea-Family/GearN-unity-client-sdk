namespace XmobiTea.GN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;

    public partial class StoreInventoryModels
    {
        public class BuyStoreItemRequestData
        {
            [StringDataMember(code = GNParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

            [StringDataMember(code = GNParameterCode.OwnerId, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string id;

            [NumberDataMember(code = GNParameterCode.OwnerType, mustInt = true)]
            public int type;

            [StringDataMember(code = GNParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
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
            [StringDataMember(code = GNParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

            [StringDataMember(code = GNParameterCode.OwnerId, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string id;

            [NumberDataMember(code = GNParameterCode.OwnerType, mustInt = true)]
            public int type;

            [StringDataMember(code = GNParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
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
            [StringDataMember(code = GNParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

            [GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
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
            [StringDataMember(code = GNParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? storeId;

            [GNArrayDataMember(code = GNParameterCode.StoreReceiveTypes, minLength = 1, maxLength = 10, mustNonNull = true, elementCls = typeof(int))]
            public List<int> storeReceiveTypes;

            [StringDataMember(code = GNParameterCode.OwnerId, minLength = 10, maxLength = 11, mustNonNull = true, isOptional = true)]
            public string? id;

            [NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

            [StringDataMember(code = GNParameterCode.Token, minLength = 24, maxLength = 24, mustNonNull = true, isOptional = true)]
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
            [StringDataMember(code = GNParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
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
            [StringDataMember(code = GNParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

            [GNArrayDataMember(code = GNParameterCode.OwnerIds, isOptional = true, elementCls = typeof(string))]
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

        public class ServerGetStoreItemsWithTagRequestData : GetStoreItemsWithTagRequestData
        {
        }

        public class AdminGetStoreItemsWithTagRequestData : ServerGetStoreItemsWithTagRequestData
        {
        }

        public class GrantStoreItemRequestData
        {
            [StringDataMember(code = GNParameterCode.StoreId, minLength = 10, maxLength = 32, isOptional = true)]
            public string? storeId;

            [StringDataMember(code = GNParameterCode.DisplayName, defaultValue = "", isOptional = true)]
            public string? displayName;

        }

        public class ServerGrantStoreItemRequestData : GrantStoreItemRequestData
        {
        }

        public class AdminGrantStoreItemRequestData : ServerGrantStoreItemRequestData
        {
        }

        public class SetRemoveStatusRequestData
        {
            [StringDataMember(code = GNParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

            [StringDataMember(code = GNParameterCode.Reason, isOptional = true, defaultValue = "")]
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
            [StringDataMember(code = GNParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

            [NumberDataMember(code = GNParameterCode.StoreItemType, minValue = 1, maxValue = 2, mustInt = true, isOptional = true)]
            public int? storeItemType;

            [GNArrayDataMember(code = GNParameterCode.StoreDatas, minLength = 0, maxLength = 32, mustNonNull = true, isOptional = true, elementCls = typeof(StoreDataParam))]
            public List<StoreDataParam>? storeDataParams;

            [GNArrayDataMember(code = GNParameterCode.StoreItems, minLength = 0, maxLength = 32, mustNonNull = true, isOptional = true, elementCls = typeof(StoreItemParam))]
            public List<StoreItemParam>? storeItemParams;

            [GNArrayDataMember(code = GNParameterCode.StoreCurrencies, minLength = 0, maxLength = 32, mustNonNull = true, isOptional = true, elementCls = typeof(CurrencyParam))]
            public List<CurrencyParam>? storeCurrencyParams;

            [GNArrayDataMember(code = GNParameterCode.PriceCurrencies, minLength = 0, maxLength = 32, mustNonNull = true, isOptional = true, elementCls = typeof(CurrencyParam))]
            public List<CurrencyParam>? priceCurrencyParams;

            [GNHashtableDataMember(code = GNParameterCode.InAppPurchase, mustNonNull = true, isOptional = true)]
            public InAppPurchaseParam? inAppPurchaseParam;

            [StringDataMember(code = GNParameterCode.DisplayName, mustNonNull = true, isOptional = true)]
            public string? displayName;

            [GNHashtableDataMember(code = GNParameterCode.Avatar, mustNonNull = true, isOptional = true)]
            public AvatarParam? avatarParam;

            [GNArrayDataMember(code = GNParameterCode.Tags, minLength = 0, maxLength = 32, mustNonNull = true, isOptional = true, elementCls = typeof(TagParam))]
            public List<TagParam>? tagParams;

        }

        public class ServerSetStoreItemInformationRequestData : SetStoreItemInformationRequestData
        {
        }

        public class AdminSetStoreItemInformationRequestData : ServerSetStoreItemInformationRequestData
        {
        }

        public class ValidateAppleAppStoreReceiptRequestData
        {
            [StringDataMember(code = GNParameterCode.Receipt, minLength = 10, maxLength = 2048, mustNonNull = true)]
            public string receipt;

            [StringDataMember(code = GNParameterCode.OwnerId, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string id;

            [NumberDataMember(code = GNParameterCode.OwnerType, mustInt = true)]
            public int type;

            [StringDataMember(code = GNParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
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
            [StringDataMember(code = GNParameterCode.Receipt, minLength = 10, maxLength = 2048, mustNonNull = true)]
            public string receipt;

            [StringDataMember(code = GNParameterCode.OwnerId, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string id;

            [NumberDataMember(code = GNParameterCode.OwnerType, mustInt = true)]
            public int type;

            [StringDataMember(code = GNParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
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
            [StringDataMember(code = GNParameterCode.Receipt, minLength = 10, maxLength = 2048, mustNonNull = true)]
            public string receipt;

            [StringDataMember(code = GNParameterCode.OwnerId, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string id;

            [NumberDataMember(code = GNParameterCode.OwnerType, mustInt = true)]
            public int type;

            [StringDataMember(code = GNParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
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

    }

    public partial class StoreInventoryModels
    {
        public class AvatarParam
        {
            [NumberDataMember(code = GNParameterCode.Type, mustInt = true)]
            public int type;

            [StringDataMember(code = GNParameterCode.Value, minLength = 1, maxLength = 128, mustNonNull = true)]
            public string value;

        }

        public class CurrencyParam
        {
            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [NumberDataMember(code = GNParameterCode.Value)]
            public double value;

        }

        public class InAppPurchaseParam
        {
            [StringDataMember(code = GNParameterCode.FacebookStoreId, minLength = 1, maxLength = 128, mustNonNull = true, isOptional = true)]
            public string? facebookStoreId;

            [StringDataMember(code = GNParameterCode.GooglePlayStoreId, minLength = 1, maxLength = 128, mustNonNull = true, isOptional = true)]
            public string? googlePlayStoreId;

            [StringDataMember(code = GNParameterCode.AppleAppStoreId, minLength = 1, maxLength = 128, mustNonNull = true, isOptional = true)]
            public string? appleAppStoreId;

            [NumberDataMember(code = GNParameterCode.AnalyticsPrice, isOptional = true)]
            public double? analyticsPrice;

        }

        public class InfoRequestParam
        {
            [BooleanDataMember(code = GNParameterCode.StoreItems, isOptional = true, defaultValue = false)]
            public bool? storeItems;

            [BooleanDataMember(code = GNParameterCode.StoreItemType, isOptional = true, defaultValue = false)]
            public bool? storeItemType;

            [BooleanDataMember(code = GNParameterCode.StoreCurrencies, isOptional = true, defaultValue = false)]
            public bool? storeCurrencies;

            [BooleanDataMember(code = GNParameterCode.PriceCurrencies, isOptional = true, defaultValue = false)]
            public bool? priceCurrencies;

            [BooleanDataMember(code = GNParameterCode.InAppPurchase, isOptional = true, defaultValue = false)]
            public bool? inAppPurchase;

            [BooleanDataMember(code = GNParameterCode.RemoveStatus, isOptional = true, defaultValue = false)]
            public bool? removeStatus;

            [BooleanDataMember(code = GNParameterCode.DisplayName, isOptional = true, defaultValue = false)]
            public bool? displayName;

            [BooleanDataMember(code = GNParameterCode.Avatar, isOptional = true, defaultValue = false)]
            public bool? avatar;

            [BooleanDataMember(code = GNParameterCode.TsCreate, isOptional = true, defaultValue = false)]
            public bool? tsCreate;

            [BooleanDataMember(code = GNParameterCode.Tags, isOptional = true, defaultValue = false)]
            public bool? tags;

            [BooleanDataMember(code = GNParameterCode.StoreDatas, isOptional = true, defaultValue = false)]
            public bool? storeDatas;

        }

        public class StoreDataParam
        {
            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [DataMember(code = GNParameterCode.Value)]
            public object value;

        }

        public class StoreItemParam
        {
            [StringDataMember(code = GNParameterCode.CatalogId, minLength = 2, maxLength = 32)]
            public string catalogId;

            [StringDataMember(code = GNParameterCode.ClassId, minLength = 2, maxLength = 32)]
            public string classId;

            [NumberDataMember(code = GNParameterCode.Amount)]
            public double amount;

        }

        public class TagParam
        {
            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [StringDataMember(code = GNParameterCode.Value, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string value;

        }

    }

    public partial class StoreInventoryModels
    {
        public class InAppPurchaseItem
        {
            [StringDataMember(code = GNParameterCode.FacebookStoreId)]
            public string facebookStoreId;

            [StringDataMember(code = GNParameterCode.AppleAppStoreId)]
            public string appleAppStoreId;

            [StringDataMember(code = GNParameterCode.GooglePlayStoreId)]
            public string googlePlayStoreId;

            [NumberDataMember(code = GNParameterCode.AnalyticsPrice)]
            public double analyticsPrice;

        }

        public class PriceCurrencyItem
        {
            [StringDataMember(code = GNParameterCode.Key)]
            public string key;

            [NumberDataMember(code = GNParameterCode.Value)]
            public double value;

        }

        public class OwnerStoreInventoryItem
        {
            [StringDataMember(code = GNParameterCode.ItemId)]
            public string itemId;

            [StringDataMember(code = GNParameterCode.CatalogId)]
            public string catalogId;

            [StringDataMember(code = GNParameterCode.ClassId)]
            public string classId;

        }

        public class StoreInventoryItem
        {
            [StringDataMember(code = GNParameterCode.CatalogId)]
            public string catalogId;

            [StringDataMember(code = GNParameterCode.ClassId)]
            public string classId;

            [NumberDataMember(code = GNParameterCode.Amount)]
            public int amount;

        }

        public class InfoResponseParameters
        {
            [GNArrayDataMember(code = GNParameterCode.StoreItems, isOptional = true, elementCls = typeof(StoreInventoryItem))]
            public List<StoreInventoryItem>? storeItems;

            [BooleanDataMember(code = GNParameterCode.StoreItemType, isOptional = true, defaultValue = false)]
            public bool? storeItemType;

            [GNArrayDataMember(code = GNParameterCode.StoreCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? storeCurrencies;

            [GNArrayDataMember(code = GNParameterCode.PriceCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? priceCurrencies;

            [GNHashtableDataMember(code = GNParameterCode.InAppPurchase, isOptional = true)]
            public InAppPurchaseItem? inAppPurchase;

            [GNHashtableDataMember(code = GNParameterCode.RemoveStatus, isOptional = true)]
            public GenericModels.RemoveStatusItem? removeStatus;

            [StringDataMember(code = GNParameterCode.DisplayName, isOptional = true)]
            public string? displayName;

            [GNHashtableDataMember(code = GNParameterCode.Avatar, isOptional = true)]
            public GenericModels.AvatarItem? avatar;

            [NumberDataMember(code = GNParameterCode.TsCreate, isOptional = true)]
            public long? tsCreate;

            [GNArrayDataMember(code = GNParameterCode.Tags, isOptional = true, elementCls = typeof(GenericModels.TagItem))]
            public List<GenericModels.TagItem>? tags;

            [GNArrayDataMember(code = GNParameterCode.StoreDatas, isOptional = true, elementCls = typeof(GenericModels.DataItem))]
            public List<GenericModels.DataItem>? storeDatas;

        }

        public class StoreInventoryResponseData
        {
            [GNHashtableDataMember(code = GNParameterCode.InfoResponseParameters)]
            public InfoResponseParameters infoResponseParameters;

        }

        public class StoreInventoryWithStoreIdResponseData : StoreInventoryResponseData
        {
            [StringDataMember(code = GNParameterCode.StoreId)]
            public string storeId;

        }

        public class StoreInventoryLeaderboardResponseData : StoreInventoryWithStoreIdResponseData
        {
            [NumberDataMember(code = GNParameterCode.Position)]
            public int position;

        }

        public class StoreInventoriesWithStoreIdResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(StoreInventoryWithStoreIdResponseData))]
            public List<StoreInventoryWithStoreIdResponseData> results;

        }

        public class GrantStoreItemResponseData
        {
            [StringDataMember(code = GNParameterCode.StoreId)]
            public string storeId;
        }

        public class OwnerInfoResponseParameters
        {
            [GNArrayDataMember(code = GNParameterCode.Currencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? currencies;

            [GNArrayDataMember(code = GNParameterCode.Inventories, isOptional = true, elementCls = typeof(OwnerStoreInventoryItem))]
            public List<OwnerStoreInventoryItem>? inventories;

        }

        public class BuyStoreInventoryResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.StoreCurrencies, isOptional = true, elementCls = typeof(StoreInventoryItem))]
            public List<StoreInventoryItem>? storeItems;

            [GNArrayDataMember(code = GNParameterCode.StoreCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? storeCurrencies;

            [GNArrayDataMember(code = GNParameterCode.PriceCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? priceCurrencies;

            [GNHashtableDataMember(code = GNParameterCode.InfoResponseParameters, isOptional = true)]
            public OwnerInfoResponseParameters? infoResponseParameters;

        }

        public class GetCreateLeaderboardResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(StoreInventoryLeaderboardResponseData))]
            public List<StoreInventoryLeaderboardResponseData> results;

        }

        public class PresentStoreInventoryResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.StoreCurrencies, isOptional = true, elementCls = typeof(StoreInventoryItem))]
            public List<StoreInventoryItem>? storeItems;

            [GNArrayDataMember(code = GNParameterCode.StoreCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? storeCurrencies;

            [GNArrayDataMember(code = GNParameterCode.PriceCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? priceCurrencies;

            [GNHashtableDataMember(code = GNParameterCode.InfoResponseParameters, isOptional = true)]
            public OwnerInfoResponseParameters? infoResponseParameters;

        }

        public class CurrencyResponseData
        {
            [StringDataMember(code = GNParameterCode.Key)]
            public string key;

            [NumberDataMember(code = GNParameterCode.Value)]
            public double value;

        }

        public class StoreItemResponseData
        {
            [StringDataMember(code = GNParameterCode.CatalogId)]
            public string catalogId;

            [StringDataMember(code = GNParameterCode.ClassId)]
            public string classId;

            [StringDataMember(code = GNParameterCode.ItemId)]
            public string itemId;

        }

        public class StoreLogResponseData
        {
            [StringDataMember(code = GNParameterCode.StoreId)]
            public string storeId;

            [StringDataMember(code = GNParameterCode.OwnerId)]
            public string id;

            [NumberDataMember(code = GNParameterCode.OwnerType)]
            public int type;

            [StringDataMember(code = GNParameterCode.TransactionId, isOptional = true)]
            public string? transactionId;

            [NumberDataMember(code = GNParameterCode.StoreReceiveType)]
            public int storeReceiveType;

            [GNArrayDataMember(code = GNParameterCode.PriceCurrencyStartValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> priceCurrencyStartValues;

            [GNArrayDataMember(code = GNParameterCode.PriceCurrencyAmountValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> priceCurrencyAmountValues;

            [GNArrayDataMember(code = GNParameterCode.PriceCurrencyFinalValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> priceCurrencyFinalValues;

            [GNArrayDataMember(code = GNParameterCode.StoreCurrencyStartValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> storeCurrencyStartValues;

            [GNArrayDataMember(code = GNParameterCode.StoreCurrencyAmountValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> storeCurrencyAmountValues;

            [GNArrayDataMember(code = GNParameterCode.StoreCurrencyFinalValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> storeCurrencyFinalValues;

            [GNArrayDataMember(code = GNParameterCode.StoreItemFinalValues, elementCls = typeof(StoreItemResponseData))]
            public List<StoreItemResponseData> storeItemFinalValues;

            [NumberDataMember(code = GNParameterCode.TsCreate)]
            public long tsCreate;

            [StringDataMember(code = GNParameterCode.Log)]
            public string log;

        }

        public class GetStoreLogResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(StoreLogResponseData))]
            public List<StoreLogResponseData> results;

            [StringDataMember(code = GNParameterCode.Token, isOptional = true)]
            public string? token;

        }

        public class StoreUsedResponseData
        {
            [StringDataMember(code = GNParameterCode.OwnerId)]
            public string id;

            [NumberDataMember(code = GNParameterCode.OwnerType)]
            public int type;

            [NumberDataMember(code = GNParameterCode.TsCreate)]
            public long tsCreate;

        }

        public class GetStoreUsedResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(StoreUsedResponseData))]
            public List<StoreUsedResponseData> results;

        }

        public class EmptyResponseData
        {

        }

    }

}
