namespace XmobiTea.GN
{
	using System;
	using XmobiTea.GN.Common;
	using XmobiTea.GN.Entity;
	using XmobiTea.GN.Entity.Models;

	public static partial class GNNetwork
	{
		public class StoreInventoryApi
		{
			public ServerApi server { get; } = new ServerApi();

			public AdminApi admin { get; } = new AdminApi();

			public void buyStoreItem(StoreInventoryModels.BuyStoreItemRequestData requestData, Action<StoreInventoryResponseModels.BuyStoreItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.BuyStoreItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStoreItemInformation(StoreInventoryModels.GetStoreItemInformationRequestData requestData, Action<StoreInventoryResponseModels.GetStoreItemInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.GetStoreItemInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStoreItemsWithTag(StoreInventoryModels.GetStoreItemsWithTagRequestData requestData, Action<StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.GetStoreItemsWithTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void grantStoreItem(StoreInventoryModels.GrantStoreItemRequestData requestData, Action<StoreInventoryResponseModels.GrantStoreItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.GrantStoreItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setRemoveStatus(StoreInventoryModels.SetRemoveStatusRequestData requestData, Action<StoreInventoryResponseModels.SetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.SetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setStoreItemInformation(StoreInventoryModels.SetStoreItemInformationRequestData requestData, Action<StoreInventoryResponseModels.SetStoreItemInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.SetStoreItemInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void validateAppleAppStoreReceipt(StoreInventoryModels.ValidateAppleAppStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ValidateAppleAppStoreReceiptOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void validateFacebookStoreReceipt(StoreInventoryModels.ValidateFacebookStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ValidateFacebookStoreReceiptOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void validateGooglePlayStoreReceipt(StoreInventoryModels.ValidateGooglePlayStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ValidateGooglePlayStoreReceiptOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}


			public class ServerApi
			{
				public void buyStoreItem(StoreInventoryModels.ServerBuyStoreItemRequestData requestData, Action<StoreInventoryResponseModels.BuyStoreItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerBuyStoreItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getStoreItemInformation(StoreInventoryModels.ServerGetStoreItemInformationRequestData requestData, Action<StoreInventoryResponseModels.GetStoreItemInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerGetStoreItemInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getStoreItemsWithTag(StoreInventoryModels.ServerGetStoreItemsWithTagRequestData requestData, Action<StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerGetStoreItemsWithTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void grantStoreItem(StoreInventoryModels.ServerGrantStoreItemRequestData requestData, Action<StoreInventoryResponseModels.GrantStoreItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerGrantStoreItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setRemoveStatus(StoreInventoryModels.ServerSetRemoveStatusRequestData requestData, Action<StoreInventoryResponseModels.SetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerSetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setStoreItemInformation(StoreInventoryModels.ServerSetStoreItemInformationRequestData requestData, Action<StoreInventoryResponseModels.SetStoreItemInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerSetStoreItemInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void validateAppleAppStoreReceipt(StoreInventoryModels.ServerValidateAppleAppStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerValidateAppleAppStoreReceiptOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void validateFacebookStoreReceipt(StoreInventoryModels.ServerValidateFacebookStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerValidateFacebookStoreReceiptOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void validateGooglePlayStoreReceipt(StoreInventoryModels.ServerValidateGooglePlayStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerValidateGooglePlayStoreReceiptOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

			}

			public class AdminApi
			{
				public void buyStoreItem(StoreInventoryModels.AdminBuyStoreItemRequestData requestData, Action<StoreInventoryResponseModels.BuyStoreItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminBuyStoreItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getStoreItemInformation(StoreInventoryModels.AdminGetStoreItemInformationRequestData requestData, Action<StoreInventoryResponseModels.GetStoreItemInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminGetStoreItemInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getStoreItemsWithTag(StoreInventoryModels.AdminGetStoreItemsWithTagRequestData requestData, Action<StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminGetStoreItemsWithTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void grantStoreItem(StoreInventoryModels.AdminGrantStoreItemRequestData requestData, Action<StoreInventoryResponseModels.GrantStoreItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminGrantStoreItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setRemoveStatus(StoreInventoryModels.AdminSetRemoveStatusRequestData requestData, Action<StoreInventoryResponseModels.SetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminSetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setStoreItemInformation(StoreInventoryModels.AdminSetStoreItemInformationRequestData requestData, Action<StoreInventoryResponseModels.SetStoreItemInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminSetStoreItemInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void validateAppleAppStoreReceipt(StoreInventoryModels.AdminValidateAppleAppStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminValidateAppleAppStoreReceiptOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void validateFacebookStoreReceipt(StoreInventoryModels.AdminValidateFacebookStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminValidateFacebookStoreReceiptOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void validateGooglePlayStoreReceipt(StoreInventoryModels.AdminValidateGooglePlayStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminValidateGooglePlayStoreReceiptOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

			}

		}

		public static StoreInventoryApi storeInventory { get; } = new StoreInventoryApi();
	}

}
