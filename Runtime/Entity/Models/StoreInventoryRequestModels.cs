namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    public class StoreInventoryRequestModels
    {
        public class BuyStoreItemOperationRequest : CustomOperationRequest<StoreInventoryModels.BuyStoreItemRequestData>
        {
            protected override string operationCode => OperationCode.BuyStoreItem;
            protected override RequestType requestType => RequestType.StoreInventory;
            protected override RequestRole role => RequestRole.Client;

            public BuyStoreItemOperationRequest(StoreInventoryModels.BuyStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerBuyStoreItemOperationRequest : BuyStoreItemOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerBuyStoreItemOperationRequest(StoreInventoryModels.ServerBuyStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminBuyStoreItemOperationRequest : BuyStoreItemOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminBuyStoreItemOperationRequest(StoreInventoryModels.AdminBuyStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetStoreItemInformationOperationRequest : CustomOperationRequest<StoreInventoryModels.GetStoreItemInformationRequestData>
        {
            protected override string operationCode => OperationCode.GetStoreItemInformation;
            protected override RequestType requestType => RequestType.StoreInventory;
            protected override RequestRole role => RequestRole.Client;

            public GetStoreItemInformationOperationRequest(StoreInventoryModels.GetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStoreItemInformationOperationRequest : GetStoreItemInformationOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetStoreItemInformationOperationRequest(StoreInventoryModels.ServerGetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStoreItemInformationOperationRequest : GetStoreItemInformationOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetStoreItemInformationOperationRequest(StoreInventoryModels.AdminGetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetStoreItemsWithTagOperationRequest : CustomOperationRequest<StoreInventoryModels.GetStoreItemsWithTagRequestData>
        {
            protected override string operationCode => OperationCode.GetStoreItemsWithTag;
            protected override RequestType requestType => RequestType.StoreInventory;
            protected override RequestRole role => RequestRole.Client;

            public GetStoreItemsWithTagOperationRequest(StoreInventoryModels.GetStoreItemsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStoreItemsWithTagOperationRequest : GetStoreItemsWithTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetStoreItemsWithTagOperationRequest(StoreInventoryModels.ServerGetStoreItemsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStoreItemsWithTagOperationRequest : GetStoreItemsWithTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetStoreItemsWithTagOperationRequest(StoreInventoryModels.AdminGetStoreItemsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class CreateStoreItemOperationRequest : CustomOperationRequest<StoreInventoryModels.CreateStoreItemRequestData>
        {
            protected override string operationCode => OperationCode.CreateStoreItem;
            protected override RequestType requestType => RequestType.StoreInventory;
            protected override RequestRole role => RequestRole.Client;

            public CreateStoreItemOperationRequest(StoreInventoryModels.CreateStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerCreateStoreItemOperationRequest : CreateStoreItemOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerCreateStoreItemOperationRequest(StoreInventoryModels.ServerCreateStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminCreateStoreItemOperationRequest : CreateStoreItemOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminCreateStoreItemOperationRequest(StoreInventoryModels.AdminCreateStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetRemoveStatusOperationRequest : CustomOperationRequest<StoreInventoryModels.SetRemoveStatusRequestData>
        {
            protected override string operationCode => OperationCode.SetRemoveStatus;
            protected override RequestType requestType => RequestType.StoreInventory;
            protected override RequestRole role => RequestRole.Client;

            public SetRemoveStatusOperationRequest(StoreInventoryModels.SetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetRemoveStatusOperationRequest : SetRemoveStatusOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetRemoveStatusOperationRequest(StoreInventoryModels.ServerSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetRemoveStatusOperationRequest : SetRemoveStatusOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetRemoveStatusOperationRequest(StoreInventoryModels.AdminSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetStoreItemInformationOperationRequest : CustomOperationRequest<StoreInventoryModels.SetStoreItemInformationRequestData>
        {
            protected override string operationCode => OperationCode.SetStoreItemInformation;
            protected override RequestType requestType => RequestType.StoreInventory;
            protected override RequestRole role => RequestRole.Client;

            public SetStoreItemInformationOperationRequest(StoreInventoryModels.SetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetStoreItemInformationOperationRequest : SetStoreItemInformationOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetStoreItemInformationOperationRequest(StoreInventoryModels.ServerSetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetStoreItemInformationOperationRequest : SetStoreItemInformationOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetStoreItemInformationOperationRequest(StoreInventoryModels.AdminSetStoreItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class ValidateAppleAppStoreReceiptOperationRequest : CustomOperationRequest<StoreInventoryModels.ValidateAppleAppStoreReceiptRequestData>
        {
            protected override string operationCode => OperationCode.ValidateAppleAppStoreReceipt;
            protected override RequestType requestType => RequestType.StoreInventory;
            protected override RequestRole role => RequestRole.Client;

            public ValidateAppleAppStoreReceiptOperationRequest(StoreInventoryModels.ValidateAppleAppStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerValidateAppleAppStoreReceiptOperationRequest : ValidateAppleAppStoreReceiptOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerValidateAppleAppStoreReceiptOperationRequest(StoreInventoryModels.ServerValidateAppleAppStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminValidateAppleAppStoreReceiptOperationRequest : ValidateAppleAppStoreReceiptOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminValidateAppleAppStoreReceiptOperationRequest(StoreInventoryModels.AdminValidateAppleAppStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class ValidateFacebookStoreReceiptOperationRequest : CustomOperationRequest<StoreInventoryModels.ValidateFacebookStoreReceiptRequestData>
        {
            protected override string operationCode => OperationCode.ValidateFacebookStoreReceipt;
            protected override RequestType requestType => RequestType.StoreInventory;
            protected override RequestRole role => RequestRole.Client;

            public ValidateFacebookStoreReceiptOperationRequest(StoreInventoryModels.ValidateFacebookStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerValidateFacebookStoreReceiptOperationRequest : ValidateFacebookStoreReceiptOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerValidateFacebookStoreReceiptOperationRequest(StoreInventoryModels.ServerValidateFacebookStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminValidateFacebookStoreReceiptOperationRequest : ValidateFacebookStoreReceiptOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminValidateFacebookStoreReceiptOperationRequest(StoreInventoryModels.AdminValidateFacebookStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class ValidateGooglePlayStoreReceiptOperationRequest : CustomOperationRequest<StoreInventoryModels.ValidateGooglePlayStoreReceiptRequestData>
        {
            protected override string operationCode => OperationCode.ValidateGooglePlayStoreReceipt;
            protected override RequestType requestType => RequestType.StoreInventory;
            protected override RequestRole role => RequestRole.Client;

            public ValidateGooglePlayStoreReceiptOperationRequest(StoreInventoryModels.ValidateGooglePlayStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerValidateGooglePlayStoreReceiptOperationRequest : ValidateGooglePlayStoreReceiptOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerValidateGooglePlayStoreReceiptOperationRequest(StoreInventoryModels.ServerValidateGooglePlayStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminValidateGooglePlayStoreReceiptOperationRequest : ValidateGooglePlayStoreReceiptOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminValidateGooglePlayStoreReceiptOperationRequest(StoreInventoryModels.AdminValidateGooglePlayStoreReceiptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCreateLeaderboardOperationRequest : CustomOperationRequest<StoreInventoryModels.GetCreateLeaderboardRequestData>
        {
            protected override string operationCode => OperationCode.GetCreateLeaderboard;
            protected override RequestType requestType => RequestType.StoreInventory;
            protected override RequestRole role => RequestRole.Client;

            public GetCreateLeaderboardOperationRequest(StoreInventoryModels.GetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCreateLeaderboardOperationRequest(StoreInventoryModels.ServerGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCreateLeaderboardOperationRequest(StoreInventoryModels.AdminGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class PresentStoreItemOperationRequest : CustomOperationRequest<StoreInventoryModels.PresentStoreItemRequestData>
        {
            protected override string operationCode => OperationCode.PresentStoreItem;
            protected override RequestType requestType => RequestType.StoreInventory;
            protected override RequestRole role => RequestRole.Client;

            public PresentStoreItemOperationRequest(StoreInventoryModels.PresentStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerPresentStoreItemOperationRequest : PresentStoreItemOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerPresentStoreItemOperationRequest(StoreInventoryModels.ServerPresentStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminPresentStoreItemOperationRequest : PresentStoreItemOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminPresentStoreItemOperationRequest(StoreInventoryModels.AdminPresentStoreItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetStoreLogOperationRequest : CustomOperationRequest<StoreInventoryModels.GetStoreLogRequestData>
        {
            protected override string operationCode => OperationCode.GetStoreLog;
            protected override RequestType requestType => RequestType.StoreInventory;
            protected override RequestRole role => RequestRole.Client;

            public GetStoreLogOperationRequest(StoreInventoryModels.GetStoreLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStoreLogOperationRequest : GetStoreLogOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetStoreLogOperationRequest(StoreInventoryModels.ServerGetStoreLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStoreLogOperationRequest : GetStoreLogOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetStoreLogOperationRequest(StoreInventoryModels.AdminGetStoreLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetStoreUsedOperationRequest : CustomOperationRequest<StoreInventoryModels.GetStoreUsedRequestData>
        {
            protected override string operationCode => OperationCode.GetStoreUsed;
            protected override RequestType requestType => RequestType.StoreInventory;
            protected override RequestRole role => RequestRole.Client;

            public GetStoreUsedOperationRequest(StoreInventoryModels.GetStoreUsedRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStoreUsedOperationRequest : GetStoreUsedOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetStoreUsedOperationRequest(StoreInventoryModels.ServerGetStoreUsedRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStoreUsedOperationRequest : GetStoreUsedOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetStoreUsedOperationRequest(StoreInventoryModels.AdminGetStoreUsedRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class RemoveStoreUsedOperationRequest : CustomOperationRequest<StoreInventoryModels.RemoveStoreUsedRequestData>
        {
            protected override string operationCode => OperationCode.RemoveStoreUsed;
            protected override RequestType requestType => RequestType.StoreInventory;
            protected override RequestRole role => RequestRole.Client;

            public RemoveStoreUsedOperationRequest(StoreInventoryModels.RemoveStoreUsedRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveStoreUsedOperationRequest : RemoveStoreUsedOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerRemoveStoreUsedOperationRequest(StoreInventoryModels.ServerRemoveStoreUsedRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveStoreUsedOperationRequest : RemoveStoreUsedOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminRemoveStoreUsedOperationRequest(StoreInventoryModels.AdminRemoveStoreUsedRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}
