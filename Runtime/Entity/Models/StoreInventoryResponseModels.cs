namespace XmobiTea.GN.Entity.Models
{
    using XmobiTea.GN.Entity.Response;

	public class StoreInventoryResponseModels
	{
		public class BuyStoreItemOperationResponse : CustomOperationResponse<StoreInventoryModels.BuyStoreInventoryResponseData>
		{

		}

		public class GetStoreItemInformationOperationResponse : CustomOperationResponse<StoreInventoryModels.StoreInventoryResponseData>
		{

		}

		public class GetStoreItemsWithTagOperationResponse : CustomOperationResponse<StoreInventoryModels.StoreInventoriesWithStoreIdResponseData>
		{

		}

		public class GrantStoreItemOperationResponse : CustomOperationResponse<StoreInventoryModels.GrantStoreItemResponseData>
		{

		}

		public class SetRemoveStatusOperationResponse : CustomOperationResponse<StoreInventoryModels.EmptyResponseData>
		{

		}

		public class SetStoreItemInformationOperationResponse : CustomOperationResponse<StoreInventoryModels.StoreInventoryResponseData>
		{

		}

		public class ValidateAppleAppStoreReceiptOperationResponse : CustomOperationResponse<StoreInventoryModels.BuyStoreInventoryResponseData>
		{

		}

		public class ValidateFacebookStoreReceiptOperationResponse : CustomOperationResponse<StoreInventoryModels.BuyStoreInventoryResponseData>
		{

		}

		public class ValidateGooglePlayStoreReceiptOperationResponse : CustomOperationResponse<StoreInventoryModels.BuyStoreInventoryResponseData>
		{

		}

	}

}
