namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    /// <summary>
    /// Defines typed request wrappers for store inventory operations.
    /// </summary>
    public class StoreInventoryRequestModels
    {
        /// <summary>
        /// Builds the buy store item operation request.
        /// </summary>
        public class BuyStoreItemOperationRequest : CustomOperationRequest<StoreInventoryModels.BuyStoreItemRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.BuyStoreItem;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.StoreInventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the BuyStoreItemOperationRequest class.
            /// </summary>
            public BuyStoreItemOperationRequest(StoreInventoryModels.BuyStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped buy store item operation request.
        /// </summary>
        public class ServerBuyStoreItemOperationRequest : BuyStoreItemOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerBuyStoreItemOperationRequest class.
            /// </summary>
            public ServerBuyStoreItemOperationRequest(StoreInventoryModels.ServerBuyStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped buy store item operation request.
        /// </summary>
        public class AdminBuyStoreItemOperationRequest : BuyStoreItemOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminBuyStoreItemOperationRequest class.
            /// </summary>
            public AdminBuyStoreItemOperationRequest(StoreInventoryModels.AdminBuyStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get store item information operation request.
        /// </summary>
        public class GetStoreItemInformationOperationRequest : CustomOperationRequest<StoreInventoryModels.GetStoreItemInformationRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStoreItemInformation;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.StoreInventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStoreItemInformationOperationRequest class.
            /// </summary>
            public GetStoreItemInformationOperationRequest(StoreInventoryModels.GetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get store item information operation request.
        /// </summary>
        public class ServerGetStoreItemInformationOperationRequest : GetStoreItemInformationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetStoreItemInformationOperationRequest class.
            /// </summary>
            public ServerGetStoreItemInformationOperationRequest(StoreInventoryModels.ServerGetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get store item information operation request.
        /// </summary>
        public class AdminGetStoreItemInformationOperationRequest : GetStoreItemInformationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetStoreItemInformationOperationRequest class.
            /// </summary>
            public AdminGetStoreItemInformationOperationRequest(StoreInventoryModels.AdminGetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get store items with tag operation request.
        /// </summary>
        public class GetStoreItemsWithTagOperationRequest : CustomOperationRequest<StoreInventoryModels.GetStoreItemsWithTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStoreItemsWithTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.StoreInventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStoreItemsWithTagOperationRequest class.
            /// </summary>
            public GetStoreItemsWithTagOperationRequest(StoreInventoryModels.GetStoreItemsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get store items with tag operation request.
        /// </summary>
        public class ServerGetStoreItemsWithTagOperationRequest : GetStoreItemsWithTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetStoreItemsWithTagOperationRequest class.
            /// </summary>
            public ServerGetStoreItemsWithTagOperationRequest(StoreInventoryModels.ServerGetStoreItemsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get store items with tag operation request.
        /// </summary>
        public class AdminGetStoreItemsWithTagOperationRequest : GetStoreItemsWithTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetStoreItemsWithTagOperationRequest class.
            /// </summary>
            public AdminGetStoreItemsWithTagOperationRequest(StoreInventoryModels.AdminGetStoreItemsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the create store item operation request.
        /// </summary>
        public class CreateStoreItemOperationRequest : CustomOperationRequest<StoreInventoryModels.CreateStoreItemRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.CreateStoreItem;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.StoreInventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the CreateStoreItemOperationRequest class.
            /// </summary>
            public CreateStoreItemOperationRequest(StoreInventoryModels.CreateStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped create store item operation request.
        /// </summary>
        public class ServerCreateStoreItemOperationRequest : CreateStoreItemOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerCreateStoreItemOperationRequest class.
            /// </summary>
            public ServerCreateStoreItemOperationRequest(StoreInventoryModels.ServerCreateStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped create store item operation request.
        /// </summary>
        public class AdminCreateStoreItemOperationRequest : CreateStoreItemOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminCreateStoreItemOperationRequest class.
            /// </summary>
            public AdminCreateStoreItemOperationRequest(StoreInventoryModels.AdminCreateStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set remove status operation request.
        /// </summary>
        public class SetRemoveStatusOperationRequest : CustomOperationRequest<StoreInventoryModels.SetRemoveStatusRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetRemoveStatus;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.StoreInventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetRemoveStatusOperationRequest class.
            /// </summary>
            public SetRemoveStatusOperationRequest(StoreInventoryModels.SetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set remove status operation request.
        /// </summary>
        public class ServerSetRemoveStatusOperationRequest : SetRemoveStatusOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetRemoveStatusOperationRequest class.
            /// </summary>
            public ServerSetRemoveStatusOperationRequest(StoreInventoryModels.ServerSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set remove status operation request.
        /// </summary>
        public class AdminSetRemoveStatusOperationRequest : SetRemoveStatusOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetRemoveStatusOperationRequest class.
            /// </summary>
            public AdminSetRemoveStatusOperationRequest(StoreInventoryModels.AdminSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set store item information operation request.
        /// </summary>
        public class SetStoreItemInformationOperationRequest : CustomOperationRequest<StoreInventoryModels.SetStoreItemInformationRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetStoreItemInformation;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.StoreInventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetStoreItemInformationOperationRequest class.
            /// </summary>
            public SetStoreItemInformationOperationRequest(StoreInventoryModels.SetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set store item information operation request.
        /// </summary>
        public class ServerSetStoreItemInformationOperationRequest : SetStoreItemInformationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetStoreItemInformationOperationRequest class.
            /// </summary>
            public ServerSetStoreItemInformationOperationRequest(StoreInventoryModels.ServerSetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set store item information operation request.
        /// </summary>
        public class AdminSetStoreItemInformationOperationRequest : SetStoreItemInformationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetStoreItemInformationOperationRequest class.
            /// </summary>
            public AdminSetStoreItemInformationOperationRequest(StoreInventoryModels.AdminSetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the validate apple app store receipt operation request.
        /// </summary>
        public class ValidateAppleAppStoreReceiptOperationRequest : CustomOperationRequest<StoreInventoryModels.ValidateAppleAppStoreReceiptRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ValidateAppleAppStoreReceipt;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.StoreInventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ValidateAppleAppStoreReceiptOperationRequest class.
            /// </summary>
            public ValidateAppleAppStoreReceiptOperationRequest(StoreInventoryModels.ValidateAppleAppStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped validate apple app store receipt operation request.
        /// </summary>
        public class ServerValidateAppleAppStoreReceiptOperationRequest : ValidateAppleAppStoreReceiptOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerValidateAppleAppStoreReceiptOperationRequest class.
            /// </summary>
            public ServerValidateAppleAppStoreReceiptOperationRequest(StoreInventoryModels.ServerValidateAppleAppStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped validate apple app store receipt operation request.
        /// </summary>
        public class AdminValidateAppleAppStoreReceiptOperationRequest : ValidateAppleAppStoreReceiptOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminValidateAppleAppStoreReceiptOperationRequest class.
            /// </summary>
            public AdminValidateAppleAppStoreReceiptOperationRequest(StoreInventoryModels.AdminValidateAppleAppStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the validate facebook store receipt operation request.
        /// </summary>
        public class ValidateFacebookStoreReceiptOperationRequest : CustomOperationRequest<StoreInventoryModels.ValidateFacebookStoreReceiptRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ValidateFacebookStoreReceipt;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.StoreInventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ValidateFacebookStoreReceiptOperationRequest class.
            /// </summary>
            public ValidateFacebookStoreReceiptOperationRequest(StoreInventoryModels.ValidateFacebookStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped validate facebook store receipt operation request.
        /// </summary>
        public class ServerValidateFacebookStoreReceiptOperationRequest : ValidateFacebookStoreReceiptOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerValidateFacebookStoreReceiptOperationRequest class.
            /// </summary>
            public ServerValidateFacebookStoreReceiptOperationRequest(StoreInventoryModels.ServerValidateFacebookStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped validate facebook store receipt operation request.
        /// </summary>
        public class AdminValidateFacebookStoreReceiptOperationRequest : ValidateFacebookStoreReceiptOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminValidateFacebookStoreReceiptOperationRequest class.
            /// </summary>
            public AdminValidateFacebookStoreReceiptOperationRequest(StoreInventoryModels.AdminValidateFacebookStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the validate google play store receipt operation request.
        /// </summary>
        public class ValidateGooglePlayStoreReceiptOperationRequest : CustomOperationRequest<StoreInventoryModels.ValidateGooglePlayStoreReceiptRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ValidateGooglePlayStoreReceipt;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.StoreInventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ValidateGooglePlayStoreReceiptOperationRequest class.
            /// </summary>
            public ValidateGooglePlayStoreReceiptOperationRequest(StoreInventoryModels.ValidateGooglePlayStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped validate google play store receipt operation request.
        /// </summary>
        public class ServerValidateGooglePlayStoreReceiptOperationRequest : ValidateGooglePlayStoreReceiptOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerValidateGooglePlayStoreReceiptOperationRequest class.
            /// </summary>
            public ServerValidateGooglePlayStoreReceiptOperationRequest(StoreInventoryModels.ServerValidateGooglePlayStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped validate google play store receipt operation request.
        /// </summary>
        public class AdminValidateGooglePlayStoreReceiptOperationRequest : ValidateGooglePlayStoreReceiptOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminValidateGooglePlayStoreReceiptOperationRequest class.
            /// </summary>
            public AdminValidateGooglePlayStoreReceiptOperationRequest(StoreInventoryModels.AdminValidateGooglePlayStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get create leaderboard operation request.
        /// </summary>
        public class GetCreateLeaderboardOperationRequest : CustomOperationRequest<StoreInventoryModels.GetCreateLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCreateLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.StoreInventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCreateLeaderboardOperationRequest class.
            /// </summary>
            public GetCreateLeaderboardOperationRequest(StoreInventoryModels.GetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get create leaderboard operation request.
        /// </summary>
        public class ServerGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetCreateLeaderboardOperationRequest class.
            /// </summary>
            public ServerGetCreateLeaderboardOperationRequest(StoreInventoryModels.ServerGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get create leaderboard operation request.
        /// </summary>
        public class AdminGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetCreateLeaderboardOperationRequest class.
            /// </summary>
            public AdminGetCreateLeaderboardOperationRequest(StoreInventoryModels.AdminGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the present store item operation request.
        /// </summary>
        public class PresentStoreItemOperationRequest : CustomOperationRequest<StoreInventoryModels.PresentStoreItemRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.PresentStoreItem;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.StoreInventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the PresentStoreItemOperationRequest class.
            /// </summary>
            public PresentStoreItemOperationRequest(StoreInventoryModels.PresentStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped present store item operation request.
        /// </summary>
        public class ServerPresentStoreItemOperationRequest : PresentStoreItemOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerPresentStoreItemOperationRequest class.
            /// </summary>
            public ServerPresentStoreItemOperationRequest(StoreInventoryModels.ServerPresentStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped present store item operation request.
        /// </summary>
        public class AdminPresentStoreItemOperationRequest : PresentStoreItemOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminPresentStoreItemOperationRequest class.
            /// </summary>
            public AdminPresentStoreItemOperationRequest(StoreInventoryModels.AdminPresentStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get store log operation request.
        /// </summary>
        public class GetStoreLogOperationRequest : CustomOperationRequest<StoreInventoryModels.GetStoreLogRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStoreLog;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.StoreInventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStoreLogOperationRequest class.
            /// </summary>
            public GetStoreLogOperationRequest(StoreInventoryModels.GetStoreLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get store log operation request.
        /// </summary>
        public class ServerGetStoreLogOperationRequest : GetStoreLogOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetStoreLogOperationRequest class.
            /// </summary>
            public ServerGetStoreLogOperationRequest(StoreInventoryModels.ServerGetStoreLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get store log operation request.
        /// </summary>
        public class AdminGetStoreLogOperationRequest : GetStoreLogOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetStoreLogOperationRequest class.
            /// </summary>
            public AdminGetStoreLogOperationRequest(StoreInventoryModels.AdminGetStoreLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get store used operation request.
        /// </summary>
        public class GetStoreUsedOperationRequest : CustomOperationRequest<StoreInventoryModels.GetStoreUsedRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStoreUsed;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.StoreInventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStoreUsedOperationRequest class.
            /// </summary>
            public GetStoreUsedOperationRequest(StoreInventoryModels.GetStoreUsedRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get store used operation request.
        /// </summary>
        public class ServerGetStoreUsedOperationRequest : GetStoreUsedOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetStoreUsedOperationRequest class.
            /// </summary>
            public ServerGetStoreUsedOperationRequest(StoreInventoryModels.ServerGetStoreUsedRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get store used operation request.
        /// </summary>
        public class AdminGetStoreUsedOperationRequest : GetStoreUsedOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetStoreUsedOperationRequest class.
            /// </summary>
            public AdminGetStoreUsedOperationRequest(StoreInventoryModels.AdminGetStoreUsedRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the remove store used operation request.
        /// </summary>
        public class RemoveStoreUsedOperationRequest : CustomOperationRequest<StoreInventoryModels.RemoveStoreUsedRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemoveStoreUsed;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.StoreInventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemoveStoreUsedOperationRequest class.
            /// </summary>
            public RemoveStoreUsedOperationRequest(StoreInventoryModels.RemoveStoreUsedRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped remove store used operation request.
        /// </summary>
        public class ServerRemoveStoreUsedOperationRequest : RemoveStoreUsedOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerRemoveStoreUsedOperationRequest class.
            /// </summary>
            public ServerRemoveStoreUsedOperationRequest(StoreInventoryModels.ServerRemoveStoreUsedRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped remove store used operation request.
        /// </summary>
        public class AdminRemoveStoreUsedOperationRequest : RemoveStoreUsedOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminRemoveStoreUsedOperationRequest class.
            /// </summary>
            public AdminRemoveStoreUsedOperationRequest(StoreInventoryModels.AdminRemoveStoreUsedRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}