namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    /// <summary>
    /// Defines typed request wrappers for inventory operations.
    /// </summary>
    public class InventoryRequestModels
    {
        /// <summary>
        /// Builds the add segment operation request.
        /// </summary>
        public class AddSegmentOperationRequest : CustomOperationRequestAbstract<InventoryModels.AddSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.AddSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the AddSegmentOperationRequest class.
            /// </summary>
            public AddSegmentOperationRequest(InventoryModels.AddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped add segment operation request.
        /// </summary>
        public class ServerAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerAddSegmentOperationRequest class.
            /// </summary>
            public ServerAddSegmentOperationRequest(InventoryModels.ServerAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped add segment operation request.
        /// </summary>
        public class AdminAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminAddSegmentOperationRequest class.
            /// </summary>
            public AdminAddSegmentOperationRequest(InventoryModels.AdminAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get amount operation request.
        /// </summary>
        public class GetAmountOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetAmountRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetAmount;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetAmountOperationRequest class.
            /// </summary>
            public GetAmountOperationRequest(InventoryModels.GetAmountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get amount operation request.
        /// </summary>
        public class ServerGetAmountOperationRequest : GetAmountOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetAmountOperationRequest class.
            /// </summary>
            public ServerGetAmountOperationRequest(InventoryModels.ServerGetAmountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get amount operation request.
        /// </summary>
        public class AdminGetAmountOperationRequest : GetAmountOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetAmountOperationRequest class.
            /// </summary>
            public AdminGetAmountOperationRequest(InventoryModels.AdminGetAmountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get avatar operation request.
        /// </summary>
        public class GetAvatarOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetAvatarRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetAvatar;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetAvatarOperationRequest class.
            /// </summary>
            public GetAvatarOperationRequest(InventoryModels.GetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get avatar operation request.
        /// </summary>
        public class ServerGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetAvatarOperationRequest class.
            /// </summary>
            public ServerGetAvatarOperationRequest(InventoryModels.ServerGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get avatar operation request.
        /// </summary>
        public class AdminGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetAvatarOperationRequest class.
            /// </summary>
            public AdminGetAvatarOperationRequest(InventoryModels.AdminGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get catalog ID operation request.
        /// </summary>
        public class GetCatalogIdOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetCatalogIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCatalogId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCatalogIdOperationRequest class.
            /// </summary>
            public GetCatalogIdOperationRequest(InventoryModels.GetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get catalog ID operation request.
        /// </summary>
        public class ServerGetCatalogIdOperationRequest : GetCatalogIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetCatalogIdOperationRequest class.
            /// </summary>
            public ServerGetCatalogIdOperationRequest(InventoryModels.ServerGetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get catalog ID operation request.
        /// </summary>
        public class AdminGetCatalogIdOperationRequest : GetCatalogIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetCatalogIdOperationRequest class.
            /// </summary>
            public AdminGetCatalogIdOperationRequest(InventoryModels.AdminGetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get class ID operation request.
        /// </summary>
        public class GetClassIdOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetClassIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetClassId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetClassIdOperationRequest class.
            /// </summary>
            public GetClassIdOperationRequest(InventoryModels.GetClassIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get class ID operation request.
        /// </summary>
        public class ServerGetClassIdOperationRequest : GetClassIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetClassIdOperationRequest class.
            /// </summary>
            public ServerGetClassIdOperationRequest(InventoryModels.ServerGetClassIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get class ID operation request.
        /// </summary>
        public class AdminGetClassIdOperationRequest : GetClassIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetClassIdOperationRequest class.
            /// </summary>
            public AdminGetClassIdOperationRequest(InventoryModels.AdminGetClassIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get custom data operation request.
        /// </summary>
        public class GetCustomDataOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetCustomDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCustomData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCustomDataOperationRequest class.
            /// </summary>
            public GetCustomDataOperationRequest(InventoryModels.GetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get custom data operation request.
        /// </summary>
        public class ServerGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetCustomDataOperationRequest class.
            /// </summary>
            public ServerGetCustomDataOperationRequest(InventoryModels.ServerGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get custom data operation request.
        /// </summary>
        public class AdminGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetCustomDataOperationRequest class.
            /// </summary>
            public AdminGetCustomDataOperationRequest(InventoryModels.AdminGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get display name operation request.
        /// </summary>
        public class GetDisplayNameOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetDisplayNameRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetDisplayName;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetDisplayNameOperationRequest class.
            /// </summary>
            public GetDisplayNameOperationRequest(InventoryModels.GetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get display name operation request.
        /// </summary>
        public class ServerGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetDisplayNameOperationRequest class.
            /// </summary>
            public ServerGetDisplayNameOperationRequest(InventoryModels.ServerGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get display name operation request.
        /// </summary>
        public class AdminGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetDisplayNameOperationRequest class.
            /// </summary>
            public AdminGetDisplayNameOperationRequest(InventoryModels.AdminGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get item data operation request.
        /// </summary>
        public class GetItemDataOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetItemDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetItemData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetItemDataOperationRequest class.
            /// </summary>
            public GetItemDataOperationRequest(InventoryModels.GetItemDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get item data operation request.
        /// </summary>
        public class ServerGetItemDataOperationRequest : GetItemDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetItemDataOperationRequest class.
            /// </summary>
            public ServerGetItemDataOperationRequest(InventoryModels.ServerGetItemDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get item data operation request.
        /// </summary>
        public class AdminGetItemDataOperationRequest : GetItemDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetItemDataOperationRequest class.
            /// </summary>
            public AdminGetItemDataOperationRequest(InventoryModels.AdminGetItemDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get item information operation request.
        /// </summary>
        public class GetItemInformationOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetItemInformationRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetItemInformation;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetItemInformationOperationRequest class.
            /// </summary>
            public GetItemInformationOperationRequest(InventoryModels.GetItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get item information operation request.
        /// </summary>
        public class ServerGetItemInformationOperationRequest : GetItemInformationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetItemInformationOperationRequest class.
            /// </summary>
            public ServerGetItemInformationOperationRequest(InventoryModels.ServerGetItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get item information operation request.
        /// </summary>
        public class AdminGetItemInformationOperationRequest : GetItemInformationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetItemInformationOperationRequest class.
            /// </summary>
            public AdminGetItemInformationOperationRequest(InventoryModels.AdminGetItemInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get item statistics operation request.
        /// </summary>
        public class GetItemStatisticsOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetItemStatisticsRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetItemStatistics;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetItemStatisticsOperationRequest class.
            /// </summary>
            public GetItemStatisticsOperationRequest(InventoryModels.GetItemStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get item statistics operation request.
        /// </summary>
        public class ServerGetItemStatisticsOperationRequest : GetItemStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetItemStatisticsOperationRequest class.
            /// </summary>
            public ServerGetItemStatisticsOperationRequest(InventoryModels.ServerGetItemStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get item statistics operation request.
        /// </summary>
        public class AdminGetItemStatisticsOperationRequest : GetItemStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetItemStatisticsOperationRequest class.
            /// </summary>
            public AdminGetItemStatisticsOperationRequest(InventoryModels.AdminGetItemStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get items with display name operation request.
        /// </summary>
        public class GetItemsWithDisplayNameOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetItemsWithDisplayNameRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetItemsWithDisplayName;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetItemsWithDisplayNameOperationRequest class.
            /// </summary>
            public GetItemsWithDisplayNameOperationRequest(InventoryModels.GetItemsWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get items with display name operation request.
        /// </summary>
        public class ServerGetItemsWithDisplayNameOperationRequest : GetItemsWithDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetItemsWithDisplayNameOperationRequest class.
            /// </summary>
            public ServerGetItemsWithDisplayNameOperationRequest(InventoryModels.ServerGetItemsWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get items with display name operation request.
        /// </summary>
        public class AdminGetItemsWithDisplayNameOperationRequest : GetItemsWithDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetItemsWithDisplayNameOperationRequest class.
            /// </summary>
            public AdminGetItemsWithDisplayNameOperationRequest(InventoryModels.AdminGetItemsWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get items with segment operation request.
        /// </summary>
        public class GetItemsWithSegmentOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetItemsWithSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetItemsWithSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetItemsWithSegmentOperationRequest class.
            /// </summary>
            public GetItemsWithSegmentOperationRequest(InventoryModels.GetItemsWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get items with segment operation request.
        /// </summary>
        public class ServerGetItemsWithSegmentOperationRequest : GetItemsWithSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetItemsWithSegmentOperationRequest class.
            /// </summary>
            public ServerGetItemsWithSegmentOperationRequest(InventoryModels.ServerGetItemsWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get items with segment operation request.
        /// </summary>
        public class AdminGetItemsWithSegmentOperationRequest : GetItemsWithSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetItemsWithSegmentOperationRequest class.
            /// </summary>
            public AdminGetItemsWithSegmentOperationRequest(InventoryModels.AdminGetItemsWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get items with tag operation request.
        /// </summary>
        public class GetItemsWithTagOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetItemsWithTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetItemsWithTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetItemsWithTagOperationRequest class.
            /// </summary>
            public GetItemsWithTagOperationRequest(InventoryModels.GetItemsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get items with tag operation request.
        /// </summary>
        public class ServerGetItemsWithTagOperationRequest : GetItemsWithTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetItemsWithTagOperationRequest class.
            /// </summary>
            public ServerGetItemsWithTagOperationRequest(InventoryModels.ServerGetItemsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get items with tag operation request.
        /// </summary>
        public class AdminGetItemsWithTagOperationRequest : GetItemsWithTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetItemsWithTagOperationRequest class.
            /// </summary>
            public AdminGetItemsWithTagOperationRequest(InventoryModels.AdminGetItemsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get item type operation request.
        /// </summary>
        public class GetItemTypeOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetItemTypeRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetItemType;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetItemTypeOperationRequest class.
            /// </summary>
            public GetItemTypeOperationRequest(InventoryModels.GetItemTypeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get item type operation request.
        /// </summary>
        public class ServerGetItemTypeOperationRequest : GetItemTypeOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetItemTypeOperationRequest class.
            /// </summary>
            public ServerGetItemTypeOperationRequest(InventoryModels.ServerGetItemTypeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get item type operation request.
        /// </summary>
        public class AdminGetItemTypeOperationRequest : GetItemTypeOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetItemTypeOperationRequest class.
            /// </summary>
            public AdminGetItemTypeOperationRequest(InventoryModels.AdminGetItemTypeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get owner operation request.
        /// </summary>
        public class GetOwnerOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetOwnerRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetOwner;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetOwnerOperationRequest class.
            /// </summary>
            public GetOwnerOperationRequest(InventoryModels.GetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get owner operation request.
        /// </summary>
        public class ServerGetOwnerOperationRequest : GetOwnerOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetOwnerOperationRequest class.
            /// </summary>
            public ServerGetOwnerOperationRequest(InventoryModels.ServerGetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get owner operation request.
        /// </summary>
        public class AdminGetOwnerOperationRequest : GetOwnerOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetOwnerOperationRequest class.
            /// </summary>
            public AdminGetOwnerOperationRequest(InventoryModels.AdminGetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get remove status operation request.
        /// </summary>
        public class GetRemoveStatusOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetRemoveStatusRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetRemoveStatus;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetRemoveStatusOperationRequest class.
            /// </summary>
            public GetRemoveStatusOperationRequest(InventoryModels.GetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get remove status operation request.
        /// </summary>
        public class ServerGetRemoveStatusOperationRequest : GetRemoveStatusOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetRemoveStatusOperationRequest class.
            /// </summary>
            public ServerGetRemoveStatusOperationRequest(InventoryModels.ServerGetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get remove status operation request.
        /// </summary>
        public class AdminGetRemoveStatusOperationRequest : GetRemoveStatusOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetRemoveStatusOperationRequest class.
            /// </summary>
            public AdminGetRemoveStatusOperationRequest(InventoryModels.AdminGetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get segment operation request.
        /// </summary>
        public class GetSegmentOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetSegmentOperationRequest class.
            /// </summary>
            public GetSegmentOperationRequest(InventoryModels.GetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get segment operation request.
        /// </summary>
        public class ServerGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetSegmentOperationRequest class.
            /// </summary>
            public ServerGetSegmentOperationRequest(InventoryModels.ServerGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get segment operation request.
        /// </summary>
        public class AdminGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetSegmentOperationRequest class.
            /// </summary>
            public AdminGetSegmentOperationRequest(InventoryModels.AdminGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get statistics leaderboard around item operation request.
        /// </summary>
        public class GetStatisticsLeaderboardAroundItemOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetStatisticsLeaderboardAroundItemRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStatisticsLeaderboardAroundItem;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStatisticsLeaderboardAroundItemOperationRequest class.
            /// </summary>
            public GetStatisticsLeaderboardAroundItemOperationRequest(InventoryModels.GetStatisticsLeaderboardAroundItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get statistics leaderboard around item operation request.
        /// </summary>
        public class ServerGetStatisticsLeaderboardAroundItemOperationRequest : GetStatisticsLeaderboardAroundItemOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetStatisticsLeaderboardAroundItemOperationRequest class.
            /// </summary>
            public ServerGetStatisticsLeaderboardAroundItemOperationRequest(InventoryModels.ServerGetStatisticsLeaderboardAroundItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get statistics leaderboard around item operation request.
        /// </summary>
        public class AdminGetStatisticsLeaderboardAroundItemOperationRequest : GetStatisticsLeaderboardAroundItemOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetStatisticsLeaderboardAroundItemOperationRequest class.
            /// </summary>
            public AdminGetStatisticsLeaderboardAroundItemOperationRequest(InventoryModels.AdminGetStatisticsLeaderboardAroundItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get statistics leaderboard operation request.
        /// </summary>
        public class GetStatisticsLeaderboardOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetStatisticsLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStatisticsLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStatisticsLeaderboardOperationRequest class.
            /// </summary>
            public GetStatisticsLeaderboardOperationRequest(InventoryModels.GetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get statistics leaderboard operation request.
        /// </summary>
        public class ServerGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetStatisticsLeaderboardOperationRequest class.
            /// </summary>
            public ServerGetStatisticsLeaderboardOperationRequest(InventoryModels.ServerGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get statistics leaderboard operation request.
        /// </summary>
        public class AdminGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetStatisticsLeaderboardOperationRequest class.
            /// </summary>
            public AdminGetStatisticsLeaderboardOperationRequest(InventoryModels.AdminGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get tag operation request.
        /// </summary>
        public class GetTagOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetTagOperationRequest class.
            /// </summary>
            public GetTagOperationRequest(InventoryModels.GetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get tag operation request.
        /// </summary>
        public class ServerGetTagOperationRequest : GetTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetTagOperationRequest class.
            /// </summary>
            public ServerGetTagOperationRequest(InventoryModels.ServerGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get tag operation request.
        /// </summary>
        public class AdminGetTagOperationRequest : GetTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetTagOperationRequest class.
            /// </summary>
            public AdminGetTagOperationRequest(InventoryModels.AdminGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get timestamp create operation request.
        /// </summary>
        public class GetTsCreateOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetTsCreateRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetTsCreate;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetTsCreateOperationRequest class.
            /// </summary>
            public GetTsCreateOperationRequest(InventoryModels.GetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get timestamp create operation request.
        /// </summary>
        public class ServerGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetTsCreateOperationRequest class.
            /// </summary>
            public ServerGetTsCreateOperationRequest(InventoryModels.ServerGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get timestamp create operation request.
        /// </summary>
        public class AdminGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetTsCreateOperationRequest class.
            /// </summary>
            public AdminGetTsCreateOperationRequest(InventoryModels.AdminGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove segment operation request.
        /// </summary>
        public class RemoveSegmentOperationRequest : CustomOperationRequestAbstract<InventoryModels.RemoveSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemoveSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemoveSegmentOperationRequest class.
            /// </summary>
            public RemoveSegmentOperationRequest(InventoryModels.RemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped remove segment operation request.
        /// </summary>
        public class ServerRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerRemoveSegmentOperationRequest class.
            /// </summary>
            public ServerRemoveSegmentOperationRequest(InventoryModels.ServerRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped remove segment operation request.
        /// </summary>
        public class AdminRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminRemoveSegmentOperationRequest class.
            /// </summary>
            public AdminRemoveSegmentOperationRequest(InventoryModels.AdminRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove tag operation request.
        /// </summary>
        public class RemoveTagOperationRequest : CustomOperationRequestAbstract<InventoryModels.RemoveTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemoveTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemoveTagOperationRequest class.
            /// </summary>
            public RemoveTagOperationRequest(InventoryModels.RemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped remove tag operation request.
        /// </summary>
        public class ServerRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerRemoveTagOperationRequest class.
            /// </summary>
            public ServerRemoveTagOperationRequest(InventoryModels.ServerRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped remove tag operation request.
        /// </summary>
        public class AdminRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminRemoveTagOperationRequest class.
            /// </summary>
            public AdminRemoveTagOperationRequest(InventoryModels.AdminRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set amount operation request.
        /// </summary>
        public class SetAmountOperationRequest : CustomOperationRequestAbstract<InventoryModels.SetAmountRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetAmount;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetAmountOperationRequest class.
            /// </summary>
            public SetAmountOperationRequest(InventoryModels.SetAmountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set amount operation request.
        /// </summary>
        public class ServerSetAmountOperationRequest : SetAmountOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetAmountOperationRequest class.
            /// </summary>
            public ServerSetAmountOperationRequest(InventoryModels.ServerSetAmountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set amount operation request.
        /// </summary>
        public class AdminSetAmountOperationRequest : SetAmountOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetAmountOperationRequest class.
            /// </summary>
            public AdminSetAmountOperationRequest(InventoryModels.AdminSetAmountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set avatar operation request.
        /// </summary>
        public class SetAvatarOperationRequest : CustomOperationRequestAbstract<InventoryModels.SetAvatarRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetAvatar;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetAvatarOperationRequest class.
            /// </summary>
            public SetAvatarOperationRequest(InventoryModels.SetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set avatar operation request.
        /// </summary>
        public class ServerSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetAvatarOperationRequest class.
            /// </summary>
            public ServerSetAvatarOperationRequest(InventoryModels.ServerSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set avatar operation request.
        /// </summary>
        public class AdminSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetAvatarOperationRequest class.
            /// </summary>
            public AdminSetAvatarOperationRequest(InventoryModels.AdminSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set custom data operation request.
        /// </summary>
        public class SetCustomDataOperationRequest : CustomOperationRequestAbstract<InventoryModels.SetCustomDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetCustomData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetCustomDataOperationRequest class.
            /// </summary>
            public SetCustomDataOperationRequest(InventoryModels.SetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set custom data operation request.
        /// </summary>
        public class ServerSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetCustomDataOperationRequest class.
            /// </summary>
            public ServerSetCustomDataOperationRequest(InventoryModels.ServerSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set custom data operation request.
        /// </summary>
        public class AdminSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetCustomDataOperationRequest class.
            /// </summary>
            public AdminSetCustomDataOperationRequest(InventoryModels.AdminSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set display name operation request.
        /// </summary>
        public class SetDisplayNameOperationRequest : CustomOperationRequestAbstract<InventoryModels.SetDisplayNameRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetDisplayName;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetDisplayNameOperationRequest class.
            /// </summary>
            public SetDisplayNameOperationRequest(InventoryModels.SetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set display name operation request.
        /// </summary>
        public class ServerSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetDisplayNameOperationRequest class.
            /// </summary>
            public ServerSetDisplayNameOperationRequest(InventoryModels.ServerSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set display name operation request.
        /// </summary>
        public class AdminSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetDisplayNameOperationRequest class.
            /// </summary>
            public AdminSetDisplayNameOperationRequest(InventoryModels.AdminSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set item data operation request.
        /// </summary>
        public class SetItemDataOperationRequest : CustomOperationRequestAbstract<InventoryModels.SetItemDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetItemData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetItemDataOperationRequest class.
            /// </summary>
            public SetItemDataOperationRequest(InventoryModels.SetItemDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set item data operation request.
        /// </summary>
        public class ServerSetItemDataOperationRequest : SetItemDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetItemDataOperationRequest class.
            /// </summary>
            public ServerSetItemDataOperationRequest(InventoryModels.ServerSetItemDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set item data operation request.
        /// </summary>
        public class AdminSetItemDataOperationRequest : SetItemDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetItemDataOperationRequest class.
            /// </summary>
            public AdminSetItemDataOperationRequest(InventoryModels.AdminSetItemDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the change item statistics operation request.
        /// </summary>
        public class ChangeItemStatisticsOperationRequest : CustomOperationRequestAbstract<InventoryModels.ChangeItemStatisticsRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ChangeItemStatistics;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ChangeItemStatisticsOperationRequest class.
            /// </summary>
            public ChangeItemStatisticsOperationRequest(InventoryModels.ChangeItemStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped change item statistics operation request.
        /// </summary>
        public class ServerChangeItemStatisticsOperationRequest : ChangeItemStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerChangeItemStatisticsOperationRequest class.
            /// </summary>
            public ServerChangeItemStatisticsOperationRequest(InventoryModels.ServerChangeItemStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped change item statistics operation request.
        /// </summary>
        public class AdminChangeItemStatisticsOperationRequest : ChangeItemStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminChangeItemStatisticsOperationRequest class.
            /// </summary>
            public AdminChangeItemStatisticsOperationRequest(InventoryModels.AdminChangeItemStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set owner operation request.
        /// </summary>
        public class SetOwnerOperationRequest : CustomOperationRequestAbstract<InventoryModels.SetOwnerRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetOwner;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetOwnerOperationRequest class.
            /// </summary>
            public SetOwnerOperationRequest(InventoryModels.SetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set owner operation request.
        /// </summary>
        public class ServerSetOwnerOperationRequest : SetOwnerOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetOwnerOperationRequest class.
            /// </summary>
            public ServerSetOwnerOperationRequest(InventoryModels.ServerSetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set owner operation request.
        /// </summary>
        public class AdminSetOwnerOperationRequest : SetOwnerOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetOwnerOperationRequest class.
            /// </summary>
            public AdminSetOwnerOperationRequest(InventoryModels.AdminSetOwnerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set remove status operation request.
        /// </summary>
        public class SetRemoveStatusOperationRequest : CustomOperationRequestAbstract<InventoryModels.SetRemoveStatusRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetRemoveStatus;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetRemoveStatusOperationRequest class.
            /// </summary>
            public SetRemoveStatusOperationRequest(InventoryModels.SetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerSetRemoveStatusOperationRequest(InventoryModels.ServerSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminSetRemoveStatusOperationRequest(InventoryModels.AdminSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set tag operation request.
        /// </summary>
        public class SetTagOperationRequest : CustomOperationRequestAbstract<InventoryModels.SetTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetTagOperationRequest class.
            /// </summary>
            public SetTagOperationRequest(InventoryModels.SetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set tag operation request.
        /// </summary>
        public class ServerSetTagOperationRequest : SetTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetTagOperationRequest class.
            /// </summary>
            public ServerSetTagOperationRequest(InventoryModels.ServerSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set tag operation request.
        /// </summary>
        public class AdminSetTagOperationRequest : SetTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetTagOperationRequest class.
            /// </summary>
            public AdminSetTagOperationRequest(InventoryModels.AdminSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get create leaderboard operation request.
        /// </summary>
        public class GetCreateLeaderboardOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetCreateLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCreateLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCreateLeaderboardOperationRequest class.
            /// </summary>
            public GetCreateLeaderboardOperationRequest(InventoryModels.GetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetCreateLeaderboardOperationRequest(InventoryModels.ServerGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetCreateLeaderboardOperationRequest(InventoryModels.AdminGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get statistics log operation request.
        /// </summary>
        public class GetStatisticsLogOperationRequest : CustomOperationRequestAbstract<InventoryModels.GetStatisticsLogRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStatisticsLog;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Inventory;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStatisticsLogOperationRequest class.
            /// </summary>
            public GetStatisticsLogOperationRequest(InventoryModels.GetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get statistics log operation request.
        /// </summary>
        public class ServerGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetStatisticsLogOperationRequest class.
            /// </summary>
            public ServerGetStatisticsLogOperationRequest(InventoryModels.ServerGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get statistics log operation request.
        /// </summary>
        public class AdminGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetStatisticsLogOperationRequest class.
            /// </summary>
            public AdminGetStatisticsLogOperationRequest(InventoryModels.AdminGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}