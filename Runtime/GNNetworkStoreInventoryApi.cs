namespace XmobiTea.GN
{
	using System;
	using XmobiTea.GN.Common;
	using XmobiTea.GN.Entity;
	using XmobiTea.GN.Entity.Models;

	public class StoreInventoryApi
	{
		public ServerApi server { get; } = new ServerApi();

		public AdminApi admin { get; } = new AdminApi();

		public void buyStoreItem(StoreInventoryModels.BuyStoreItemRequestData requestData, Action<StoreInventoryResponseModels.BuyStoreItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new StoreInventoryRequestModels.BuyStoreItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getStoreItemInformation(StoreInventoryModels.GetStoreItemInformationRequestData requestData, Action<StoreInventoryResponseModels.GetStoreItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new StoreInventoryRequestModels.GetStoreItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getStoreItemsWithTag(StoreInventoryModels.GetStoreItemsWithTagRequestData requestData, Action<StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new StoreInventoryRequestModels.GetStoreItemsWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void grantStoreItem(StoreInventoryModels.GrantStoreItemRequestData requestData, Action<StoreInventoryResponseModels.GrantStoreItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new StoreInventoryRequestModels.GrantStoreItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setRemoveStatus(StoreInventoryModels.SetRemoveStatusRequestData requestData, Action<StoreInventoryResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new StoreInventoryRequestModels.SetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setStoreItemInformation(StoreInventoryModels.SetStoreItemInformationRequestData requestData, Action<StoreInventoryResponseModels.SetStoreItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new StoreInventoryRequestModels.SetStoreItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void validateAppleAppStoreReceipt(StoreInventoryModels.ValidateAppleAppStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ValidateAppleAppStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void validateFacebookStoreReceipt(StoreInventoryModels.ValidateFacebookStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ValidateFacebookStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void validateGooglePlayStoreReceipt(StoreInventoryModels.ValidateGooglePlayStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ValidateGooglePlayStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}


		public class ServerApi
		{
			public void buyStoreItem(StoreInventoryModels.ServerBuyStoreItemRequestData requestData, Action<StoreInventoryResponseModels.BuyStoreItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerBuyStoreItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStoreItemInformation(StoreInventoryModels.ServerGetStoreItemInformationRequestData requestData, Action<StoreInventoryResponseModels.GetStoreItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerGetStoreItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStoreItemsWithTag(StoreInventoryModels.ServerGetStoreItemsWithTagRequestData requestData, Action<StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerGetStoreItemsWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void grantStoreItem(StoreInventoryModels.ServerGrantStoreItemRequestData requestData, Action<StoreInventoryResponseModels.GrantStoreItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerGrantStoreItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setRemoveStatus(StoreInventoryModels.ServerSetRemoveStatusRequestData requestData, Action<StoreInventoryResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerSetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setStoreItemInformation(StoreInventoryModels.ServerSetStoreItemInformationRequestData requestData, Action<StoreInventoryResponseModels.SetStoreItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerSetStoreItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void validateAppleAppStoreReceipt(StoreInventoryModels.ServerValidateAppleAppStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerValidateAppleAppStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void validateFacebookStoreReceipt(StoreInventoryModels.ServerValidateFacebookStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerValidateFacebookStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void validateGooglePlayStoreReceipt(StoreInventoryModels.ServerValidateGooglePlayStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerValidateGooglePlayStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

		}

		public class AdminApi
		{
			public void buyStoreItem(StoreInventoryModels.AdminBuyStoreItemRequestData requestData, Action<StoreInventoryResponseModels.BuyStoreItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminBuyStoreItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStoreItemInformation(StoreInventoryModels.AdminGetStoreItemInformationRequestData requestData, Action<StoreInventoryResponseModels.GetStoreItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminGetStoreItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStoreItemsWithTag(StoreInventoryModels.AdminGetStoreItemsWithTagRequestData requestData, Action<StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminGetStoreItemsWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void grantStoreItem(StoreInventoryModels.AdminGrantStoreItemRequestData requestData, Action<StoreInventoryResponseModels.GrantStoreItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminGrantStoreItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setRemoveStatus(StoreInventoryModels.AdminSetRemoveStatusRequestData requestData, Action<StoreInventoryResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminSetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setStoreItemInformation(StoreInventoryModels.AdminSetStoreItemInformationRequestData requestData, Action<StoreInventoryResponseModels.SetStoreItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminSetStoreItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void validateAppleAppStoreReceipt(StoreInventoryModels.AdminValidateAppleAppStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminValidateAppleAppStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void validateFacebookStoreReceipt(StoreInventoryModels.AdminValidateFacebookStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminValidateFacebookStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void validateGooglePlayStoreReceipt(StoreInventoryModels.AdminValidateGooglePlayStoreReceiptRequestData requestData, Action<StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminValidateGooglePlayStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

		}

	}

	public static partial class GNNetwork
	{
		
		public static StoreInventoryApi storeInventory { get; }
	}

}
