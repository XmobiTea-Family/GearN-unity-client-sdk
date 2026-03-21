namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Entity.Response;

    /// <summary>
    /// Defines typed response wrappers for store inventory operations.
    /// </summary>
    public class StoreInventoryResponseModels
    {
        /// <summary>
        /// Represents the typed response for the buy store item operation.
        /// </summary>
        public class BuyStoreItemOperationResponse : CustomOperationResponse<StoreInventoryModels.BuyStoreInventoryResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get store item information operation.
        /// </summary>
        public class GetStoreItemInformationOperationResponse : CustomOperationResponse<StoreInventoryModels.StoreInventoryResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get store items with tag operation.
        /// </summary>
        public class GetStoreItemsWithTagOperationResponse : CustomOperationResponse<StoreInventoryModels.StoreInventoriesWithStoreIdResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the create store item operation.
        /// </summary>
        public class CreateStoreItemOperationResponse : CustomOperationResponse<StoreInventoryModels.CreateStoreItemResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the set remove status operation.
        /// </summary>
        public class SetRemoveStatusOperationResponse : CustomOperationResponse<StoreInventoryModels.EmptyResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the set store item information operation.
        /// </summary>
        public class SetStoreItemInformationOperationResponse : CustomOperationResponse<StoreInventoryModels.StoreInventoryResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the validate apple app store receipt operation.
        /// </summary>
        public class ValidateAppleAppStoreReceiptOperationResponse : CustomOperationResponse<StoreInventoryModels.BuyStoreInventoryResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the validate facebook store receipt operation.
        /// </summary>
        public class ValidateFacebookStoreReceiptOperationResponse : CustomOperationResponse<StoreInventoryModels.BuyStoreInventoryResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the validate google play store receipt operation.
        /// </summary>
        public class ValidateGooglePlayStoreReceiptOperationResponse : CustomOperationResponse<StoreInventoryModels.BuyStoreInventoryResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get create leaderboard operation.
        /// </summary>
        public class GetCreateLeaderboardOperationResponse : CustomOperationResponse<StoreInventoryModels.GetCreateLeaderboardResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the present store item operation.
        /// </summary>
        public class PresentStoreItemOperationResponse : CustomOperationResponse<StoreInventoryModels.PresentStoreInventoryResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get store log operation.
        /// </summary>
        public class GetStoreLogOperationResponse : CustomOperationResponse<StoreInventoryModels.GetStoreLogResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get store used operation.
        /// </summary>
        public class GetStoreUsedOperationResponse : CustomOperationResponse<StoreInventoryModels.GetStoreUsedResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the remove store used operation.
        /// </summary>
        public class RemoveStoreUsedOperationResponse : CustomOperationResponse<StoreInventoryModels.EmptyResponseData>
        {

        }

    }

}