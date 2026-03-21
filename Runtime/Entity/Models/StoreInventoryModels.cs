namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Constant;

    /// <summary>
    /// Defines payload models for store inventory operations.
    /// </summary>
    public partial class StoreInventoryModels
    {
        /// <summary>
        /// Represents the request payload for the buy store item operation.
        /// </summary>
        public class BuyStoreItemRequestData
        {
            /// <summary>
            /// Stores the store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

            /// <summary>
            /// Stores the ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Id, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string id;

            /// <summary>
            /// Stores the type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            /// <summary>
            /// Stores the log value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the buy store item operation.
        /// </summary>
        public class ServerBuyStoreItemRequestData : BuyStoreItemRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the buy store item operation.
        /// </summary>
        public class AdminBuyStoreItemRequestData : ServerBuyStoreItemRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the present store item operation.
        /// </summary>
        public class PresentStoreItemRequestData
        {
            /// <summary>
            /// Stores the store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

            /// <summary>
            /// Stores the ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Id, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string id;

            /// <summary>
            /// Stores the type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            /// <summary>
            /// Stores the log value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the present store item operation.
        /// </summary>
        public class ServerPresentStoreItemRequestData : PresentStoreItemRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the present store item operation.
        /// </summary>
        public class AdminPresentStoreItemRequestData : ServerPresentStoreItemRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get store item information operation.
        /// </summary>
        public class GetStoreItemInformationRequestData
        {
            /// <summary>
            /// Stores the store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get store item information operation.
        /// </summary>
        public class ServerGetStoreItemInformationRequestData : GetStoreItemInformationRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get store item information operation.
        /// </summary>
        public class AdminGetStoreItemInformationRequestData : ServerGetStoreItemInformationRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get store log operation.
        /// </summary>
        public class GetStoreLogRequestData
        {
            /// <summary>
            /// Stores the store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? storeId;

            /// <summary>
            /// Stores the store receive types value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StoreReceiveTypes, minLength = 1, maxLength = 10, mustNonNull = true, elementCls = typeof(int))]
            public List<int> storeReceiveTypes;

            /// <summary>
            /// Stores the ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Id, minLength = 10, maxLength = 11, mustNonNull = true, isOptional = true)]
            public string? id;

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
        /// Represents the server-scoped request payload for the get store log operation.
        /// </summary>
        public class ServerGetStoreLogRequestData : GetStoreLogRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get store log operation.
        /// </summary>
        public class AdminGetStoreLogRequestData : ServerGetStoreLogRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get store used operation.
        /// </summary>
        public class GetStoreUsedRequestData
        {
            /// <summary>
            /// Stores the store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get store used operation.
        /// </summary>
        public class ServerGetStoreUsedRequestData : GetStoreUsedRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get store used operation.
        /// </summary>
        public class AdminGetStoreUsedRequestData : ServerGetStoreUsedRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the remove store used operation.
        /// </summary>
        public class RemoveStoreUsedRequestData
        {
            /// <summary>
            /// Stores the store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

            /// <summary>
            /// Stores the owner ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.OwnerIds, isOptional = true, elementCls = typeof(string))]
            public List<string>? ownerIds;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the remove store used operation.
        /// </summary>
        public class ServerRemoveStoreUsedRequestData : RemoveStoreUsedRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the remove store used operation.
        /// </summary>
        public class AdminRemoveStoreUsedRequestData : ServerRemoveStoreUsedRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get store items with tag operation.
        /// </summary>
        public class GetStoreItemsWithTagRequestData
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
        /// Represents the server-scoped request payload for the get store items with tag operation.
        /// </summary>
        public class ServerGetStoreItemsWithTagRequestData : GetStoreItemsWithTagRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get store items with tag operation.
        /// </summary>
        public class AdminGetStoreItemsWithTagRequestData : ServerGetStoreItemsWithTagRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the create store item operation.
        /// </summary>
        public class CreateStoreItemRequestData
        {
            /// <summary>
            /// Stores the store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, isOptional = true)]
            public string? storeId;

            /// <summary>
            /// Stores the display name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.DisplayName, defaultValue = "", isOptional = true)]
            public string? displayName;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the create store item operation.
        /// </summary>
        public class ServerCreateStoreItemRequestData : CreateStoreItemRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the create store item operation.
        /// </summary>
        public class AdminCreateStoreItemRequestData : ServerCreateStoreItemRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set remove status operation.
        /// </summary>
        public class SetRemoveStatusRequestData
        {
            /// <summary>
            /// Stores the store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

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
        /// Represents the request payload for the set store item information operation.
        /// </summary>
        public class SetStoreItemInformationRequestData
        {
            /// <summary>
            /// Stores the store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.StoreId, minLength = 10, maxLength = 32, mustNonNull = true)]
            public string storeId;

            /// <summary>
            /// Stores the store item type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.StoreItemType, minValue = 1, maxValue = 2, mustInt = true, isOptional = true)]
            public int? storeItemType;

            /// <summary>
            /// Stores the store datas value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StoreDatas, minLength = 0, maxLength = 32, mustNonNull = true, isOptional = true, elementCls = typeof(StoreDataParam))]
            public List<StoreDataParam>? storeDatas;

            /// <summary>
            /// Stores the store items value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StoreItems, minLength = 0, maxLength = 32, mustNonNull = true, isOptional = true, elementCls = typeof(StoreItemParam))]
            public List<StoreItemParam>? storeItems;

            /// <summary>
            /// Stores the store currencies value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StoreCurrencies, minLength = 0, maxLength = 32, mustNonNull = true, isOptional = true, elementCls = typeof(CurrencyParam))]
            public List<CurrencyParam>? storeCurrencies;

            /// <summary>
            /// Stores the price currencies value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PriceCurrencies, minLength = 0, maxLength = 32, mustNonNull = true, isOptional = true, elementCls = typeof(CurrencyParam))]
            public List<CurrencyParam>? priceCurrencies;

            /// <summary>
            /// Stores the in app purchase value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InAppPurchase, mustNonNull = true, isOptional = true)]
            public InAppPurchaseParam? inAppPurchase;

            /// <summary>
            /// Stores the display name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.DisplayName, mustNonNull = true, isOptional = true)]
            public string? displayName;

            /// <summary>
            /// Stores the avatar value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Avatar, mustNonNull = true, isOptional = true)]
            public AvatarParam? avatar;

            /// <summary>
            /// Stores the tags value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Tags, minLength = 0, maxLength = 32, mustNonNull = true, isOptional = true, elementCls = typeof(TagParam))]
            public List<TagParam>? tags;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the set store item information operation.
        /// </summary>
        public class ServerSetStoreItemInformationRequestData : SetStoreItemInformationRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set store item information operation.
        /// </summary>
        public class AdminSetStoreItemInformationRequestData : ServerSetStoreItemInformationRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the validate apple app store receipt operation.
        /// </summary>
        public class ValidateAppleAppStoreReceiptRequestData
        {
            /// <summary>
            /// Stores the receipt value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Receipt, minLength = 10, maxLength = 2048, mustNonNull = true)]
            public string receipt;

            /// <summary>
            /// Stores the ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Id, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string id;

            /// <summary>
            /// Stores the type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            /// <summary>
            /// Stores the log value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the validate apple app store receipt operation.
        /// </summary>
        public class ServerValidateAppleAppStoreReceiptRequestData : ValidateAppleAppStoreReceiptRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the validate apple app store receipt operation.
        /// </summary>
        public class AdminValidateAppleAppStoreReceiptRequestData : ServerValidateAppleAppStoreReceiptRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the validate facebook store receipt operation.
        /// </summary>
        public class ValidateFacebookStoreReceiptRequestData
        {
            /// <summary>
            /// Stores the receipt value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Receipt, minLength = 10, maxLength = 2048, mustNonNull = true)]
            public string receipt;

            /// <summary>
            /// Stores the ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Id, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string id;

            /// <summary>
            /// Stores the type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            /// <summary>
            /// Stores the log value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the validate facebook store receipt operation.
        /// </summary>
        public class ServerValidateFacebookStoreReceiptRequestData : ValidateFacebookStoreReceiptRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the validate facebook store receipt operation.
        /// </summary>
        public class AdminValidateFacebookStoreReceiptRequestData : ServerValidateFacebookStoreReceiptRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the validate google play store receipt operation.
        /// </summary>
        public class ValidateGooglePlayStoreReceiptRequestData
        {
            /// <summary>
            /// Stores the receipt value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Receipt, minLength = 10, maxLength = 2048, mustNonNull = true)]
            public string receipt;

            /// <summary>
            /// Stores the ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Id, minLength = 10, maxLength = 11, mustNonNull = true)]
            public string id;

            /// <summary>
            /// Stores the type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            /// <summary>
            /// Stores the log value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the validate google play store receipt operation.
        /// </summary>
        public class ServerValidateGooglePlayStoreReceiptRequestData : ValidateGooglePlayStoreReceiptRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the validate google play store receipt operation.
        /// </summary>
        public class AdminValidateGooglePlayStoreReceiptRequestData : ServerValidateGooglePlayStoreReceiptRequestData
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

    }

    /// <summary>
    /// Defines payload models for store inventory operations.
    /// </summary>
    public partial class StoreInventoryModels
    {
        /// <summary>
        /// Represents the avatar param component.
        /// </summary>
        public class AvatarParam
        {
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
        /// Represents the currency param component.
        /// </summary>
        public class CurrencyParam
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
        /// Represents the in app purchase param component.
        /// </summary>
        public class InAppPurchaseParam
        {
            /// <summary>
            /// Stores the facebook store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FacebookStoreId, minLength = 1, maxLength = 128, mustNonNull = true, isOptional = true)]
            public string? facebookStoreId;

            /// <summary>
            /// Stores the google play store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GooglePlayStoreId, minLength = 1, maxLength = 128, mustNonNull = true, isOptional = true)]
            public string? googlePlayStoreId;

            /// <summary>
            /// Stores the apple app store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.AppleAppStoreId, minLength = 1, maxLength = 128, mustNonNull = true, isOptional = true)]
            public string? appleAppStoreId;

            /// <summary>
            /// Stores the analytics price value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.AnalyticsPrice, isOptional = true)]
            public double? analyticsPrice;

        }

        /// <summary>
        /// Represents the info request param component.
        /// </summary>
        public class InfoRequestParam
        {
            /// <summary>
            /// Stores the store items value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.StoreItems, isOptional = true, defaultValue = false)]
            public bool? storeItems;

            /// <summary>
            /// Stores the store item type value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.StoreItemType, isOptional = true, defaultValue = false)]
            public bool? storeItemType;

            /// <summary>
            /// Stores the store currencies value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.StoreCurrencies, isOptional = true, defaultValue = false)]
            public bool? storeCurrencies;

            /// <summary>
            /// Stores the price currencies value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.PriceCurrencies, isOptional = true, defaultValue = false)]
            public bool? priceCurrencies;

            /// <summary>
            /// Stores the in app purchase value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.InAppPurchase, isOptional = true, defaultValue = false)]
            public bool? inAppPurchase;

            /// <summary>
            /// Stores the remove status value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.RemoveStatus, isOptional = true, defaultValue = false)]
            public bool? removeStatus;

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
            /// Stores the store datas value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.StoreDatas, isOptional = true, defaultValue = false)]
            public bool? storeDatas;

        }

        /// <summary>
        /// Represents the store data param component.
        /// </summary>
        public class StoreDataParam
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
        /// Represents the store item param component.
        /// </summary>
        public class StoreItemParam
        {
            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32)]
            public string catalogId;

            /// <summary>
            /// Stores the class ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ClassId, minLength = 2, maxLength = 32)]
            public string classId;

            /// <summary>
            /// Stores the amount value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Amount)]
            public double amount;

        }

        /// <summary>
        /// Represents the tag param component.
        /// </summary>
        public class TagParam
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

        }

    }

    /// <summary>
    /// Defines payload models for store inventory operations.
    /// </summary>
    public partial class StoreInventoryModels
    {
        /// <summary>
        /// Represents the in app purchase item component.
        /// </summary>
        public class InAppPurchaseItem
        {
            /// <summary>
            /// Stores the facebook store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FacebookStoreId)]
            public string facebookStoreId;

            /// <summary>
            /// Stores the apple app store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.AppleAppStoreId)]
            public string appleAppStoreId;

            /// <summary>
            /// Stores the google play store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GooglePlayStoreId)]
            public string googlePlayStoreId;

            /// <summary>
            /// Stores the analytics price value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.AnalyticsPrice)]
            public double analyticsPrice;

        }

        /// <summary>
        /// Represents the price currency item component.
        /// </summary>
        public class PriceCurrencyItem
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key)]
            public string key;

            /// <summary>
            /// Stores the value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Value)]
            public double value;

        }

        /// <summary>
        /// Represents the owner store inventory item component.
        /// </summary>
        public class OwnerStoreInventoryItem
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId)]
            public string itemId;

            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId)]
            public string catalogId;

            /// <summary>
            /// Stores the class ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ClassId)]
            public string classId;

        }

        /// <summary>
        /// Represents the store inventory item component.
        /// </summary>
        public class StoreInventoryItem
        {
            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId)]
            public string catalogId;

            /// <summary>
            /// Stores the class ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ClassId)]
            public string classId;

            /// <summary>
            /// Stores the amount value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Amount)]
            public int amount;

        }

        /// <summary>
        /// Represents the info response parameters component.
        /// </summary>
        public class InfoResponseParameters
        {
            /// <summary>
            /// Stores the store items value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StoreItems, isOptional = true, elementCls = typeof(StoreInventoryItem))]
            public List<StoreInventoryItem>? storeItems;

            /// <summary>
            /// Stores the store item type value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.StoreItemType, isOptional = true, defaultValue = false)]
            public bool? storeItemType;

            /// <summary>
            /// Stores the store currencies value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StoreCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? storeCurrencies;

            /// <summary>
            /// Stores the price currencies value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PriceCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? priceCurrencies;

            /// <summary>
            /// Stores the in app purchase value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InAppPurchase, isOptional = true)]
            public InAppPurchaseItem? inAppPurchase;

            /// <summary>
            /// Stores the remove status value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveStatus, isOptional = true)]
            public GenericModels.RemoveStatusItem? removeStatus;

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
            /// Stores the store datas value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StoreDatas, isOptional = true, elementCls = typeof(GenericModels.DataItem))]
            public List<GenericModels.DataItem>? storeDatas;

        }

        /// <summary>
        /// Represents the response payload for the store inventory operation.
        /// </summary>
        public class StoreInventoryResponseData
        {
            /// <summary>
            /// Stores the info response parameters value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoResponseParameters)]
            public InfoResponseParameters infoResponseParameters;

        }

        /// <summary>
        /// Represents the response payload for the store inventory with store ID operation.
        /// </summary>
        public class StoreInventoryWithStoreIdResponseData : StoreInventoryResponseData
        {
            /// <summary>
            /// Stores the store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.StoreId)]
            public string storeId;

        }

        /// <summary>
        /// Represents the response payload for the store inventory leaderboard operation.
        /// </summary>
        public class StoreInventoryLeaderboardResponseData : StoreInventoryWithStoreIdResponseData
        {
            /// <summary>
            /// Stores the position value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Position)]
            public int position;

        }

        /// <summary>
        /// Represents the response payload for the store inventories with store ID operation.
        /// </summary>
        public class StoreInventoriesWithStoreIdResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(StoreInventoryWithStoreIdResponseData))]
            public List<StoreInventoryWithStoreIdResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the create store item operation.
        /// </summary>
        public class CreateStoreItemResponseData
        {
            /// <summary>
            /// Stores the store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.StoreId)]
            public string storeId;
        }

        /// <summary>
        /// Represents the owner info response parameters component.
        /// </summary>
        public class OwnerInfoResponseParameters
        {
            /// <summary>
            /// Stores the currencies value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Currencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? currencies;

            /// <summary>
            /// Stores the inventories value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Inventories, isOptional = true, elementCls = typeof(OwnerStoreInventoryItem))]
            public List<OwnerStoreInventoryItem>? inventories;

        }

        /// <summary>
        /// Represents the response payload for the buy store inventory operation.
        /// </summary>
        public class BuyStoreInventoryResponseData
        {
            /// <summary>
            /// Stores the store items value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StoreCurrencies, isOptional = true, elementCls = typeof(StoreInventoryItem))]
            public List<StoreInventoryItem>? storeItems;

            /// <summary>
            /// Stores the store currencies value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StoreCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? storeCurrencies;

            /// <summary>
            /// Stores the price currencies value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PriceCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? priceCurrencies;

            /// <summary>
            /// Stores the info response parameters value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoResponseParameters, isOptional = true)]
            public OwnerInfoResponseParameters? infoResponseParameters;

        }

        /// <summary>
        /// Represents the response payload for the get create leaderboard operation.
        /// </summary>
        public class GetCreateLeaderboardResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(StoreInventoryLeaderboardResponseData))]
            public List<StoreInventoryLeaderboardResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the present store inventory operation.
        /// </summary>
        public class PresentStoreInventoryResponseData
        {
            /// <summary>
            /// Stores the store items value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StoreCurrencies, isOptional = true, elementCls = typeof(StoreInventoryItem))]
            public List<StoreInventoryItem>? storeItems;

            /// <summary>
            /// Stores the store currencies value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StoreCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? storeCurrencies;

            /// <summary>
            /// Stores the price currencies value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PriceCurrencies, isOptional = true, elementCls = typeof(PriceCurrencyItem))]
            public List<PriceCurrencyItem>? priceCurrencies;

            /// <summary>
            /// Stores the info response parameters value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoResponseParameters, isOptional = true)]
            public OwnerInfoResponseParameters? infoResponseParameters;

        }

        /// <summary>
        /// Represents the response payload for the currency operation.
        /// </summary>
        public class CurrencyResponseData
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key)]
            public string key;

            /// <summary>
            /// Stores the value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Value)]
            public double value;

        }

        /// <summary>
        /// Represents the response payload for the store item operation.
        /// </summary>
        public class StoreItemResponseData
        {
            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId)]
            public string catalogId;

            /// <summary>
            /// Stores the class ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ClassId)]
            public string classId;

            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId)]
            public string itemId;

        }

        /// <summary>
        /// Represents the response payload for the store log operation.
        /// </summary>
        public class StoreLogResponseData
        {
            /// <summary>
            /// Stores the store ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.StoreId)]
            public string storeId;

            /// <summary>
            /// Stores the ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.OwnerId)]
            public string id;

            /// <summary>
            /// Stores the type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.OwnerType)]
            public int type;

            /// <summary>
            /// Stores the transaction ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.TransactionId, isOptional = true)]
            public string? transactionId;

            /// <summary>
            /// Stores the store receive type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.StoreReceiveType)]
            public int storeReceiveType;

            /// <summary>
            /// Stores the price currency start values value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PriceCurrencyStartValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> priceCurrencyStartValues;

            /// <summary>
            /// Stores the price currency amount values value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PriceCurrencyAmountValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> priceCurrencyAmountValues;

            /// <summary>
            /// Stores the price currency final values value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PriceCurrencyFinalValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> priceCurrencyFinalValues;

            /// <summary>
            /// Stores the store currency start values value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StoreCurrencyStartValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> storeCurrencyStartValues;

            /// <summary>
            /// Stores the store currency amount values value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StoreCurrencyAmountValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> storeCurrencyAmountValues;

            /// <summary>
            /// Stores the store currency final values value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StoreCurrencyFinalValues, elementCls = typeof(CurrencyResponseData))]
            public List<CurrencyResponseData> storeCurrencyFinalValues;

            /// <summary>
            /// Stores the store item final values value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StoreItemFinalValues, elementCls = typeof(StoreItemResponseData))]
            public List<StoreItemResponseData> storeItemFinalValues;

            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            /// <summary>
            /// Stores the log value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Log)]
            public string log;

        }

        /// <summary>
        /// Represents the response payload for the get store log operation.
        /// </summary>
        public class GetStoreLogResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(StoreLogResponseData))]
            public List<StoreLogResponseData> results;

            /// <summary>
            /// Stores the token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Token, isOptional = true)]
            public string? token;

        }

        /// <summary>
        /// Represents the response payload for the store used operation.
        /// </summary>
        public class StoreUsedResponseData
        {
            /// <summary>
            /// Stores the ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.OwnerId)]
            public string id;

            /// <summary>
            /// Stores the type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.OwnerType)]
            public int type;

            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

        }

        /// <summary>
        /// Represents the response payload for the get store used operation.
        /// </summary>
        public class GetStoreUsedResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(StoreUsedResponseData))]
            public List<StoreUsedResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the empty operation.
        /// </summary>
        public class EmptyResponseData
        {

        }

    }

}