namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    public class InventoryRequestModels
    {
        public class AddSegmentOperationRequest : CustomOperationRequest<InventoryModels.AddSegmentRequestData>
        {
            protected override string operationCode => OperationCode.AddSegment;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public AddSegmentOperationRequest(InventoryModels.AddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerAddSegmentOperationRequest(InventoryModels.ServerAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminAddSegmentOperationRequest(InventoryModels.AdminAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetAmountOperationRequest : CustomOperationRequest<InventoryModels.GetAmountRequestData>
        {
            protected override string operationCode => OperationCode.GetAmount;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetAmountOperationRequest(InventoryModels.GetAmountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetAmountOperationRequest : GetAmountOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetAmountOperationRequest(InventoryModels.ServerGetAmountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetAmountOperationRequest : GetAmountOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetAmountOperationRequest(InventoryModels.AdminGetAmountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetAvatarOperationRequest : CustomOperationRequest<InventoryModels.GetAvatarRequestData>
        {
            protected override string operationCode => OperationCode.GetAvatar;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetAvatarOperationRequest(InventoryModels.GetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetAvatarOperationRequest(InventoryModels.ServerGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetAvatarOperationRequest(InventoryModels.AdminGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetCatalogIdOperationRequest : CustomOperationRequest<InventoryModels.GetCatalogIdRequestData>
        {
            protected override string operationCode => OperationCode.GetCatalogId;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetCatalogIdOperationRequest(InventoryModels.GetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCatalogIdOperationRequest : GetCatalogIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCatalogIdOperationRequest(InventoryModels.ServerGetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCatalogIdOperationRequest : GetCatalogIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCatalogIdOperationRequest(InventoryModels.AdminGetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetClassIdOperationRequest : CustomOperationRequest<InventoryModels.GetClassIdRequestData>
        {
            protected override string operationCode => OperationCode.GetClassId;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetClassIdOperationRequest(InventoryModels.GetClassIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetClassIdOperationRequest : GetClassIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetClassIdOperationRequest(InventoryModels.ServerGetClassIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetClassIdOperationRequest : GetClassIdOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetClassIdOperationRequest(InventoryModels.AdminGetClassIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetCustomDataOperationRequest : CustomOperationRequest<InventoryModels.GetCustomDataRequestData>
        {
            protected override string operationCode => OperationCode.GetCustomData;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetCustomDataOperationRequest(InventoryModels.GetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCustomDataOperationRequest(InventoryModels.ServerGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCustomDataOperationRequest(InventoryModels.AdminGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetDisplayNameOperationRequest : CustomOperationRequest<InventoryModels.GetDisplayNameRequestData>
        {
            protected override string operationCode => OperationCode.GetDisplayName;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetDisplayNameOperationRequest(InventoryModels.GetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetDisplayNameOperationRequest(InventoryModels.ServerGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetDisplayNameOperationRequest(InventoryModels.AdminGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetItemDataOperationRequest : CustomOperationRequest<InventoryModels.GetItemDataRequestData>
        {
            protected override string operationCode => OperationCode.GetItemData;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetItemDataOperationRequest(InventoryModels.GetItemDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetItemDataOperationRequest : GetItemDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetItemDataOperationRequest(InventoryModels.ServerGetItemDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetItemDataOperationRequest : GetItemDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetItemDataOperationRequest(InventoryModels.AdminGetItemDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetItemInformationOperationRequest : CustomOperationRequest<InventoryModels.GetItemInformationRequestData>
        {
            protected override string operationCode => OperationCode.GetItemInformation;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetItemInformationOperationRequest(InventoryModels.GetItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetItemInformationOperationRequest : GetItemInformationOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetItemInformationOperationRequest(InventoryModels.ServerGetItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetItemInformationOperationRequest : GetItemInformationOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetItemInformationOperationRequest(InventoryModels.AdminGetItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetItemStatisticsOperationRequest : CustomOperationRequest<InventoryModels.GetItemStatisticsRequestData>
        {
            protected override string operationCode => OperationCode.GetItemStatistics;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetItemStatisticsOperationRequest(InventoryModels.GetItemStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetItemStatisticsOperationRequest : GetItemStatisticsOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetItemStatisticsOperationRequest(InventoryModels.ServerGetItemStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetItemStatisticsOperationRequest : GetItemStatisticsOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetItemStatisticsOperationRequest(InventoryModels.AdminGetItemStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetItemsWithDisplayNameOperationRequest : CustomOperationRequest<InventoryModels.GetItemsWithDisplayNameRequestData>
        {
            protected override string operationCode => OperationCode.GetItemsWithDisplayName;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetItemsWithDisplayNameOperationRequest(InventoryModels.GetItemsWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetItemsWithDisplayNameOperationRequest : GetItemsWithDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetItemsWithDisplayNameOperationRequest(InventoryModels.ServerGetItemsWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetItemsWithDisplayNameOperationRequest : GetItemsWithDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetItemsWithDisplayNameOperationRequest(InventoryModels.AdminGetItemsWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetItemsWithSegmentOperationRequest : CustomOperationRequest<InventoryModels.GetItemsWithSegmentRequestData>
        {
            protected override string operationCode => OperationCode.GetItemsWithSegment;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetItemsWithSegmentOperationRequest(InventoryModels.GetItemsWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetItemsWithSegmentOperationRequest : GetItemsWithSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetItemsWithSegmentOperationRequest(InventoryModels.ServerGetItemsWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetItemsWithSegmentOperationRequest : GetItemsWithSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetItemsWithSegmentOperationRequest(InventoryModels.AdminGetItemsWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetItemsWithTagOperationRequest : CustomOperationRequest<InventoryModels.GetItemsWithTagRequestData>
        {
            protected override string operationCode => OperationCode.GetItemsWithTag;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetItemsWithTagOperationRequest(InventoryModels.GetItemsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetItemsWithTagOperationRequest : GetItemsWithTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetItemsWithTagOperationRequest(InventoryModels.ServerGetItemsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetItemsWithTagOperationRequest : GetItemsWithTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetItemsWithTagOperationRequest(InventoryModels.AdminGetItemsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetItemTypeOperationRequest : CustomOperationRequest<InventoryModels.GetItemTypeRequestData>
        {
            protected override string operationCode => OperationCode.GetItemType;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetItemTypeOperationRequest(InventoryModels.GetItemTypeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetItemTypeOperationRequest : GetItemTypeOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetItemTypeOperationRequest(InventoryModels.ServerGetItemTypeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetItemTypeOperationRequest : GetItemTypeOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetItemTypeOperationRequest(InventoryModels.AdminGetItemTypeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetOwnerOperationRequest : CustomOperationRequest<InventoryModels.GetOwnerRequestData>
        {
            protected override string operationCode => OperationCode.GetOwner;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetOwnerOperationRequest(InventoryModels.GetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetOwnerOperationRequest : GetOwnerOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetOwnerOperationRequest(InventoryModels.ServerGetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetOwnerOperationRequest : GetOwnerOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetOwnerOperationRequest(InventoryModels.AdminGetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetRemoveStatusOperationRequest : CustomOperationRequest<InventoryModels.GetRemoveStatusRequestData>
        {
            protected override string operationCode => OperationCode.GetRemoveStatus;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetRemoveStatusOperationRequest(InventoryModels.GetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetRemoveStatusOperationRequest : GetRemoveStatusOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetRemoveStatusOperationRequest(InventoryModels.ServerGetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetRemoveStatusOperationRequest : GetRemoveStatusOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetRemoveStatusOperationRequest(InventoryModels.AdminGetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetSegmentOperationRequest : CustomOperationRequest<InventoryModels.GetSegmentRequestData>
        {
            protected override string operationCode => OperationCode.GetSegment;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetSegmentOperationRequest(InventoryModels.GetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetSegmentOperationRequest(InventoryModels.ServerGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetSegmentOperationRequest(InventoryModels.AdminGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetStatisticsLeaderboardAroundItemOperationRequest : CustomOperationRequest<InventoryModels.GetStatisticsLeaderboardAroundItemRequestData>
        {
            protected override string operationCode => OperationCode.GetStatisticsLeaderboardAroundItem;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetStatisticsLeaderboardAroundItemOperationRequest(InventoryModels.GetStatisticsLeaderboardAroundItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLeaderboardAroundItemOperationRequest : GetStatisticsLeaderboardAroundItemOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetStatisticsLeaderboardAroundItemOperationRequest(InventoryModels.ServerGetStatisticsLeaderboardAroundItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLeaderboardAroundItemOperationRequest : GetStatisticsLeaderboardAroundItemOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetStatisticsLeaderboardAroundItemOperationRequest(InventoryModels.AdminGetStatisticsLeaderboardAroundItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetStatisticsLeaderboardOperationRequest : CustomOperationRequest<InventoryModels.GetStatisticsLeaderboardRequestData>
        {
            protected override string operationCode => OperationCode.GetStatisticsLeaderboard;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetStatisticsLeaderboardOperationRequest(InventoryModels.GetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetStatisticsLeaderboardOperationRequest(InventoryModels.ServerGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetStatisticsLeaderboardOperationRequest(InventoryModels.AdminGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTagOperationRequest : CustomOperationRequest<InventoryModels.GetTagRequestData>
        {
            protected override string operationCode => OperationCode.GetTag;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetTagOperationRequest(InventoryModels.GetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTagOperationRequest : GetTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetTagOperationRequest(InventoryModels.ServerGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTagOperationRequest : GetTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetTagOperationRequest(InventoryModels.AdminGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTsCreateOperationRequest : CustomOperationRequest<InventoryModels.GetTsCreateRequestData>
        {
            protected override string operationCode => OperationCode.GetTsCreate;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetTsCreateOperationRequest(InventoryModels.GetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetTsCreateOperationRequest(InventoryModels.ServerGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetTsCreateOperationRequest(InventoryModels.AdminGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveSegmentOperationRequest : CustomOperationRequest<InventoryModels.RemoveSegmentRequestData>
        {
            protected override string operationCode => OperationCode.RemoveSegment;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public RemoveSegmentOperationRequest(InventoryModels.RemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerRemoveSegmentOperationRequest(InventoryModels.ServerRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminRemoveSegmentOperationRequest(InventoryModels.AdminRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveTagOperationRequest : CustomOperationRequest<InventoryModels.RemoveTagRequestData>
        {
            protected override string operationCode => OperationCode.RemoveTag;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public RemoveTagOperationRequest(InventoryModels.RemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerRemoveTagOperationRequest(InventoryModels.ServerRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminRemoveTagOperationRequest(InventoryModels.AdminRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetAmountOperationRequest : CustomOperationRequest<InventoryModels.SetAmountRequestData>
        {
            protected override string operationCode => OperationCode.SetAmount;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public SetAmountOperationRequest(InventoryModels.SetAmountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetAmountOperationRequest : SetAmountOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetAmountOperationRequest(InventoryModels.ServerSetAmountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetAmountOperationRequest : SetAmountOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetAmountOperationRequest(InventoryModels.AdminSetAmountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetAvatarOperationRequest : CustomOperationRequest<InventoryModels.SetAvatarRequestData>
        {
            protected override string operationCode => OperationCode.SetAvatar;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public SetAvatarOperationRequest(InventoryModels.SetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetAvatarOperationRequest(InventoryModels.ServerSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetAvatarOperationRequest(InventoryModels.AdminSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetCustomDataOperationRequest : CustomOperationRequest<InventoryModels.SetCustomDataRequestData>
        {
            protected override string operationCode => OperationCode.SetCustomData;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public SetCustomDataOperationRequest(InventoryModels.SetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetCustomDataOperationRequest(InventoryModels.ServerSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetCustomDataOperationRequest(InventoryModels.AdminSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetDisplayNameOperationRequest : CustomOperationRequest<InventoryModels.SetDisplayNameRequestData>
        {
            protected override string operationCode => OperationCode.SetDisplayName;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public SetDisplayNameOperationRequest(InventoryModels.SetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetDisplayNameOperationRequest(InventoryModels.ServerSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetDisplayNameOperationRequest(InventoryModels.AdminSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetItemDataOperationRequest : CustomOperationRequest<InventoryModels.SetItemDataRequestData>
        {
            protected override string operationCode => OperationCode.SetItemData;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public SetItemDataOperationRequest(InventoryModels.SetItemDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetItemDataOperationRequest : SetItemDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetItemDataOperationRequest(InventoryModels.ServerSetItemDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetItemDataOperationRequest : SetItemDataOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetItemDataOperationRequest(InventoryModels.AdminSetItemDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class ChangeItemStatisticsOperationRequest : CustomOperationRequest<InventoryModels.ChangeItemStatisticsRequestData>
        {
            protected override string operationCode => OperationCode.ChangeItemStatistics;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public ChangeItemStatisticsOperationRequest(InventoryModels.ChangeItemStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerChangeItemStatisticsOperationRequest : ChangeItemStatisticsOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerChangeItemStatisticsOperationRequest(InventoryModels.ServerChangeItemStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminChangeItemStatisticsOperationRequest : ChangeItemStatisticsOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminChangeItemStatisticsOperationRequest(InventoryModels.AdminChangeItemStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetOwnerOperationRequest : CustomOperationRequest<InventoryModels.SetOwnerRequestData>
        {
            protected override string operationCode => OperationCode.SetOwner;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public SetOwnerOperationRequest(InventoryModels.SetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetOwnerOperationRequest : SetOwnerOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetOwnerOperationRequest(InventoryModels.ServerSetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetOwnerOperationRequest : SetOwnerOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetOwnerOperationRequest(InventoryModels.AdminSetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetRemoveStatusOperationRequest : CustomOperationRequest<InventoryModels.SetRemoveStatusRequestData>
        {
            protected override string operationCode => OperationCode.SetRemoveStatus;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public SetRemoveStatusOperationRequest(InventoryModels.SetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetRemoveStatusOperationRequest : SetRemoveStatusOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetRemoveStatusOperationRequest(InventoryModels.ServerSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetRemoveStatusOperationRequest : SetRemoveStatusOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetRemoveStatusOperationRequest(InventoryModels.AdminSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetTagOperationRequest : CustomOperationRequest<InventoryModels.SetTagRequestData>
        {
            protected override string operationCode => OperationCode.SetTag;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public SetTagOperationRequest(InventoryModels.SetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetTagOperationRequest : SetTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerSetTagOperationRequest(InventoryModels.ServerSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetTagOperationRequest : SetTagOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminSetTagOperationRequest(InventoryModels.AdminSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCreateLeaderboardOperationRequest : CustomOperationRequest<InventoryModels.GetCreateLeaderboardRequestData>
        {
            protected override string operationCode => OperationCode.GetCreateLeaderboard;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetCreateLeaderboardOperationRequest(InventoryModels.GetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetCreateLeaderboardOperationRequest(InventoryModels.ServerGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetCreateLeaderboardOperationRequest(InventoryModels.AdminGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetStatisticsLogOperationRequest : CustomOperationRequest<InventoryModels.GetStatisticsLogRequestData>
        {
            protected override string operationCode => OperationCode.GetStatisticsLog;
            protected override RequestType requestType => RequestType.Inventory;
            protected override RequestRole role => RequestRole.Client;

            public GetStatisticsLogOperationRequest(InventoryModels.GetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            protected override RequestRole role => RequestRole.Server;

            public ServerGetStatisticsLogOperationRequest(InventoryModels.ServerGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            protected override RequestRole role => RequestRole.Admin;

            public AdminGetStatisticsLogOperationRequest(InventoryModels.AdminGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}
