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
        public class BuyStoreItemOperationResponse : CustomOperationResponseAbstract<StoreInventoryModels.BuyStoreInventoryResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get store item information operation.
        /// </summary>
        public class GetStoreItemInformationOperationResponse : CustomOperationResponseAbstract<StoreInventoryModels.StoreInventoryResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get store items with tag operation.
        /// </summary>
        public class GetStoreItemsWithTagOperationResponse : CustomOperationResponseAbstract<StoreInventoryModels.StoreInventoriesWithStoreIdResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the create store item operation.
        /// </summary>
        public class CreateStoreItemOperationResponse : CustomOperationResponseAbstract<StoreInventoryModels.CreateStoreItemResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the set remove status operation.
        /// </summary>
        public class SetRemoveStatusOperationResponse : CustomOperationResponseAbstract<StoreInventoryModels.EmptyResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the set store item information operation.
        /// </summary>
        public class SetStoreItemInformationOperationResponse : CustomOperationResponseAbstract<StoreInventoryModels.StoreInventoryResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the validate apple app store receipt operation.
        /// </summary>
        public class ValidateAppleAppStoreReceiptOperationResponse : CustomOperationResponseAbstract<StoreInventoryModels.BuyStoreInventoryResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the validate facebook store receipt operation.
        /// </summary>
        public class ValidateFacebookStoreReceiptOperationResponse : CustomOperationResponseAbstract<StoreInventoryModels.BuyStoreInventoryResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the validate google play store receipt operation.
        /// </summary>
        public class ValidateGooglePlayStoreReceiptOperationResponse : CustomOperationResponseAbstract<StoreInventoryModels.BuyStoreInventoryResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get create leaderboard operation.
        /// </summary>
        public class GetCreateLeaderboardOperationResponse : CustomOperationResponseAbstract<StoreInventoryModels.GetCreateLeaderboardResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the present store item operation.
        /// </summary>
        public class PresentStoreItemOperationResponse : CustomOperationResponseAbstract<StoreInventoryModels.PresentStoreInventoryResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get store log operation.
        /// </summary>
        public class GetStoreLogOperationResponse : CustomOperationResponseAbstract<StoreInventoryModels.GetStoreLogResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get store used operation.
        /// </summary>
        public class GetStoreUsedOperationResponse : CustomOperationResponseAbstract<StoreInventoryModels.GetStoreUsedResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the remove store used operation.
        /// </summary>
        public class RemoveStoreUsedOperationResponse : CustomOperationResponseAbstract<StoreInventoryModels.EmptyResponseData>
        {

        }

    }

}