namespace XmobiTea.GN.Entity.Models
{
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity.Request;

	public class StoreInventoryRequestModels
	{
		public class BuyStoreItemOperationRequest : CustomOperationRequest<StoreInventoryModels.BuyStoreItemRequestData>
		{
			protected override int operationCode => OperationCode.BuyStoreItem;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.StoreInventory;
			protected override RequestRole requestRole => RequestRole.Client;

			public BuyStoreItemOperationRequest(StoreInventoryModels.BuyStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerBuyStoreItemOperationRequest : BuyStoreItemOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerBuyStoreItemOperationRequest(StoreInventoryModels.ServerBuyStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminBuyStoreItemOperationRequest : BuyStoreItemOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminBuyStoreItemOperationRequest(StoreInventoryModels.AdminBuyStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetStoreItemInformationOperationRequest : CustomOperationRequest<StoreInventoryModels.GetStoreItemInformationRequestData>
		{
			protected override int operationCode => OperationCode.GetStoreItemInformation;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.StoreInventory;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetStoreItemInformationOperationRequest(StoreInventoryModels.GetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetStoreItemInformationOperationRequest : GetStoreItemInformationOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetStoreItemInformationOperationRequest(StoreInventoryModels.ServerGetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetStoreItemInformationOperationRequest : GetStoreItemInformationOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetStoreItemInformationOperationRequest(StoreInventoryModels.AdminGetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetStoreItemsWithTagOperationRequest : CustomOperationRequest<StoreInventoryModels.GetStoreItemsWithTagRequestData>
		{
			protected override int operationCode => OperationCode.GetStoreItemsWithTag;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.StoreInventory;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetStoreItemsWithTagOperationRequest(StoreInventoryModels.GetStoreItemsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGetStoreItemsWithTagOperationRequest : GetStoreItemsWithTagOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGetStoreItemsWithTagOperationRequest(StoreInventoryModels.ServerGetStoreItemsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGetStoreItemsWithTagOperationRequest : GetStoreItemsWithTagOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGetStoreItemsWithTagOperationRequest(StoreInventoryModels.AdminGetStoreItemsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GrantStoreItemOperationRequest : CustomOperationRequest<StoreInventoryModels.GrantStoreItemRequestData>
		{
			protected override int operationCode => OperationCode.GrantStoreItem;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.StoreInventory;
			protected override RequestRole requestRole => RequestRole.Client;

			public GrantStoreItemOperationRequest(StoreInventoryModels.GrantStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerGrantStoreItemOperationRequest : GrantStoreItemOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerGrantStoreItemOperationRequest(StoreInventoryModels.ServerGrantStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminGrantStoreItemOperationRequest : GrantStoreItemOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminGrantStoreItemOperationRequest(StoreInventoryModels.AdminGrantStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetRemoveStatusOperationRequest : CustomOperationRequest<StoreInventoryModels.SetRemoveStatusRequestData>
		{
			protected override int operationCode => OperationCode.SetRemoveStatus;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.StoreInventory;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetRemoveStatusOperationRequest(StoreInventoryModels.SetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerSetRemoveStatusOperationRequest : SetRemoveStatusOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerSetRemoveStatusOperationRequest(StoreInventoryModels.ServerSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminSetRemoveStatusOperationRequest : SetRemoveStatusOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminSetRemoveStatusOperationRequest(StoreInventoryModels.AdminSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetStoreItemInformationOperationRequest : CustomOperationRequest<StoreInventoryModels.SetStoreItemInformationRequestData>
		{
			protected override int operationCode => OperationCode.SetStoreItemInformation;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.StoreInventory;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetStoreItemInformationOperationRequest(StoreInventoryModels.SetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerSetStoreItemInformationOperationRequest : SetStoreItemInformationOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerSetStoreItemInformationOperationRequest(StoreInventoryModels.ServerSetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminSetStoreItemInformationOperationRequest : SetStoreItemInformationOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminSetStoreItemInformationOperationRequest(StoreInventoryModels.AdminSetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class ValidateAppleAppStoreReceiptOperationRequest : CustomOperationRequest<StoreInventoryModels.ValidateAppleAppStoreReceiptRequestData>
		{
			protected override int operationCode => OperationCode.ValidateAppleAppStoreReceipt;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.StoreInventory;
			protected override RequestRole requestRole => RequestRole.Client;

			public ValidateAppleAppStoreReceiptOperationRequest(StoreInventoryModels.ValidateAppleAppStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerValidateAppleAppStoreReceiptOperationRequest : ValidateAppleAppStoreReceiptOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerValidateAppleAppStoreReceiptOperationRequest(StoreInventoryModels.ServerValidateAppleAppStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminValidateAppleAppStoreReceiptOperationRequest : ValidateAppleAppStoreReceiptOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminValidateAppleAppStoreReceiptOperationRequest(StoreInventoryModels.AdminValidateAppleAppStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class ValidateFacebookStoreReceiptOperationRequest : CustomOperationRequest<StoreInventoryModels.ValidateFacebookStoreReceiptRequestData>
		{
			protected override int operationCode => OperationCode.ValidateFacebookStoreReceipt;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.StoreInventory;
			protected override RequestRole requestRole => RequestRole.Client;

			public ValidateFacebookStoreReceiptOperationRequest(StoreInventoryModels.ValidateFacebookStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerValidateFacebookStoreReceiptOperationRequest : ValidateFacebookStoreReceiptOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerValidateFacebookStoreReceiptOperationRequest(StoreInventoryModels.ServerValidateFacebookStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminValidateFacebookStoreReceiptOperationRequest : ValidateFacebookStoreReceiptOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminValidateFacebookStoreReceiptOperationRequest(StoreInventoryModels.AdminValidateFacebookStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class ValidateGooglePlayStoreReceiptOperationRequest : CustomOperationRequest<StoreInventoryModels.ValidateGooglePlayStoreReceiptRequestData>
		{
			protected override int operationCode => OperationCode.ValidateGooglePlayStoreReceipt;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.StoreInventory;
			protected override RequestRole requestRole => RequestRole.Client;

			public ValidateGooglePlayStoreReceiptOperationRequest(StoreInventoryModels.ValidateGooglePlayStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class ServerValidateGooglePlayStoreReceiptOperationRequest : ValidateGooglePlayStoreReceiptOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Server;

			public ServerValidateGooglePlayStoreReceiptOperationRequest(StoreInventoryModels.ServerValidateGooglePlayStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}

		public class AdminValidateGooglePlayStoreReceiptOperationRequest : ValidateGooglePlayStoreReceiptOperationRequest
		{
			protected override RequestRole requestRole => RequestRole.Admin;

			public AdminValidateGooglePlayStoreReceiptOperationRequest(StoreInventoryModels.AdminValidateGooglePlayStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


	}

}
