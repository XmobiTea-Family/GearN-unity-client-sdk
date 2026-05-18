namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    /// <summary>
    /// Defines typed request wrappers for group operations.
    /// </summary>
    public class GroupRequestModels
    {
        /// <summary>
        /// Builds the add member operation request.
        /// </summary>
        public class AddMemberOperationRequest : CustomOperationRequestAbstract<GroupModels.AddMemberRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.AddMember;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the AddMemberOperationRequest class.
            /// </summary>
            public AddMemberOperationRequest(GroupModels.AddMemberRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped add member operation request.
        /// </summary>
        public class ServerAddMemberOperationRequest : AddMemberOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerAddMemberOperationRequest class.
            /// </summary>
            public ServerAddMemberOperationRequest(GroupModels.ServerAddMemberRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped add member operation request.
        /// </summary>
        public class AdminAddMemberOperationRequest : AddMemberOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminAddMemberOperationRequest class.
            /// </summary>
            public AdminAddMemberOperationRequest(GroupModels.AdminAddMemberRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the add segment operation request.
        /// </summary>
        public class AddSegmentOperationRequest : CustomOperationRequestAbstract<GroupModels.AddSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.AddSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the AddSegmentOperationRequest class.
            /// </summary>
            public AddSegmentOperationRequest(GroupModels.AddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerAddSegmentOperationRequest(GroupModels.ServerAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminAddSegmentOperationRequest(GroupModels.AdminAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get avatar operation request.
        /// </summary>
        public class GetAvatarOperationRequest : CustomOperationRequestAbstract<GroupModels.GetAvatarRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetAvatar;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetAvatarOperationRequest class.
            /// </summary>
            public GetAvatarOperationRequest(GroupModels.GetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetAvatarOperationRequest(GroupModels.ServerGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetAvatarOperationRequest(GroupModels.AdminGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get catalog ID operation request.
        /// </summary>
        public class GetCatalogIdOperationRequest : CustomOperationRequestAbstract<GroupModels.GetCatalogIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCatalogId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCatalogIdOperationRequest class.
            /// </summary>
            public GetCatalogIdOperationRequest(GroupModels.GetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetCatalogIdOperationRequest(GroupModels.ServerGetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetCatalogIdOperationRequest(GroupModels.AdminGetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get custom data operation request.
        /// </summary>
        public class GetCustomDataOperationRequest : CustomOperationRequestAbstract<GroupModels.GetCustomDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCustomData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCustomDataOperationRequest class.
            /// </summary>
            public GetCustomDataOperationRequest(GroupModels.GetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetCustomDataOperationRequest(GroupModels.ServerGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetCustomDataOperationRequest(GroupModels.AdminGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get display name operation request.
        /// </summary>
        public class GetDisplayNameOperationRequest : CustomOperationRequestAbstract<GroupModels.GetDisplayNameRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetDisplayName;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetDisplayNameOperationRequest class.
            /// </summary>
            public GetDisplayNameOperationRequest(GroupModels.GetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetDisplayNameOperationRequest(GroupModels.ServerGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetDisplayNameOperationRequest(GroupModels.AdminGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get group currency operation request.
        /// </summary>
        public class GetGroupCurrencyOperationRequest : CustomOperationRequestAbstract<GroupModels.GetGroupCurrencyRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetGroupCurrency;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetGroupCurrencyOperationRequest class.
            /// </summary>
            public GetGroupCurrencyOperationRequest(GroupModels.GetGroupCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get group currency operation request.
        /// </summary>
        public class ServerGetGroupCurrencyOperationRequest : GetGroupCurrencyOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetGroupCurrencyOperationRequest class.
            /// </summary>
            public ServerGetGroupCurrencyOperationRequest(GroupModels.ServerGetGroupCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get group currency operation request.
        /// </summary>
        public class AdminGetGroupCurrencyOperationRequest : GetGroupCurrencyOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetGroupCurrencyOperationRequest class.
            /// </summary>
            public AdminGetGroupCurrencyOperationRequest(GroupModels.AdminGetGroupCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get group data operation request.
        /// </summary>
        public class GetGroupDataOperationRequest : CustomOperationRequestAbstract<GroupModels.GetGroupDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetGroupData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetGroupDataOperationRequest class.
            /// </summary>
            public GetGroupDataOperationRequest(GroupModels.GetGroupDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get group data operation request.
        /// </summary>
        public class ServerGetGroupDataOperationRequest : GetGroupDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetGroupDataOperationRequest class.
            /// </summary>
            public ServerGetGroupDataOperationRequest(GroupModels.ServerGetGroupDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get group data operation request.
        /// </summary>
        public class AdminGetGroupDataOperationRequest : GetGroupDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetGroupDataOperationRequest class.
            /// </summary>
            public AdminGetGroupDataOperationRequest(GroupModels.AdminGetGroupDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get group information operation request.
        /// </summary>
        public class GetGroupInformationOperationRequest : CustomOperationRequestAbstract<GroupModels.GetGroupInformationRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetGroupInformation;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetGroupInformationOperationRequest class.
            /// </summary>
            public GetGroupInformationOperationRequest(GroupModels.GetGroupInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get group information operation request.
        /// </summary>
        public class ServerGetGroupInformationOperationRequest : GetGroupInformationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetGroupInformationOperationRequest class.
            /// </summary>
            public ServerGetGroupInformationOperationRequest(GroupModels.ServerGetGroupInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get group information operation request.
        /// </summary>
        public class AdminGetGroupInformationOperationRequest : GetGroupInformationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetGroupInformationOperationRequest class.
            /// </summary>
            public AdminGetGroupInformationOperationRequest(GroupModels.AdminGetGroupInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get group inventory operation request.
        /// </summary>
        public class GetGroupInventoryOperationRequest : CustomOperationRequestAbstract<GroupModels.GetGroupInventoryRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetGroupInventory;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetGroupInventoryOperationRequest class.
            /// </summary>
            public GetGroupInventoryOperationRequest(GroupModels.GetGroupInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get group inventory operation request.
        /// </summary>
        public class ServerGetGroupInventoryOperationRequest : GetGroupInventoryOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetGroupInventoryOperationRequest class.
            /// </summary>
            public ServerGetGroupInventoryOperationRequest(GroupModels.ServerGetGroupInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get group inventory operation request.
        /// </summary>
        public class AdminGetGroupInventoryOperationRequest : GetGroupInventoryOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetGroupInventoryOperationRequest class.
            /// </summary>
            public AdminGetGroupInventoryOperationRequest(GroupModels.AdminGetGroupInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get group message operation request.
        /// </summary>
        public class GetGroupMessageOperationRequest : CustomOperationRequestAbstract<GroupModels.GetGroupMessageRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetGroupMessage;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetGroupMessageOperationRequest class.
            /// </summary>
            public GetGroupMessageOperationRequest(GroupModels.GetGroupMessageRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get group message operation request.
        /// </summary>
        public class ServerGetGroupMessageOperationRequest : GetGroupMessageOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetGroupMessageOperationRequest class.
            /// </summary>
            public ServerGetGroupMessageOperationRequest(GroupModels.ServerGetGroupMessageRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get group message operation request.
        /// </summary>
        public class AdminGetGroupMessageOperationRequest : GetGroupMessageOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetGroupMessageOperationRequest class.
            /// </summary>
            public AdminGetGroupMessageOperationRequest(GroupModels.AdminGetGroupMessageRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get group statistics operation request.
        /// </summary>
        public class GetGroupStatisticsOperationRequest : CustomOperationRequestAbstract<GroupModels.GetGroupStatisticsRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetGroupStatistics;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetGroupStatisticsOperationRequest class.
            /// </summary>
            public GetGroupStatisticsOperationRequest(GroupModels.GetGroupStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get group statistics operation request.
        /// </summary>
        public class ServerGetGroupStatisticsOperationRequest : GetGroupStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetGroupStatisticsOperationRequest class.
            /// </summary>
            public ServerGetGroupStatisticsOperationRequest(GroupModels.ServerGetGroupStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get group statistics operation request.
        /// </summary>
        public class AdminGetGroupStatisticsOperationRequest : GetGroupStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetGroupStatisticsOperationRequest class.
            /// </summary>
            public AdminGetGroupStatisticsOperationRequest(GroupModels.AdminGetGroupStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get groups with display name operation request.
        /// </summary>
        public class GetGroupsWithDisplayNameOperationRequest : CustomOperationRequestAbstract<GroupModels.GetGroupsWithDisplayNameRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetGroupsWithDisplayName;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetGroupsWithDisplayNameOperationRequest class.
            /// </summary>
            public GetGroupsWithDisplayNameOperationRequest(GroupModels.GetGroupsWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get groups with display name operation request.
        /// </summary>
        public class ServerGetGroupsWithDisplayNameOperationRequest : GetGroupsWithDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetGroupsWithDisplayNameOperationRequest class.
            /// </summary>
            public ServerGetGroupsWithDisplayNameOperationRequest(GroupModels.ServerGetGroupsWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get groups with display name operation request.
        /// </summary>
        public class AdminGetGroupsWithDisplayNameOperationRequest : GetGroupsWithDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetGroupsWithDisplayNameOperationRequest class.
            /// </summary>
            public AdminGetGroupsWithDisplayNameOperationRequest(GroupModels.AdminGetGroupsWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get groups with segment operation request.
        /// </summary>
        public class GetGroupsWithSegmentOperationRequest : CustomOperationRequestAbstract<GroupModels.GetGroupsWithSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetGroupsWithSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetGroupsWithSegmentOperationRequest class.
            /// </summary>
            public GetGroupsWithSegmentOperationRequest(GroupModels.GetGroupsWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get groups with segment operation request.
        /// </summary>
        public class ServerGetGroupsWithSegmentOperationRequest : GetGroupsWithSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetGroupsWithSegmentOperationRequest class.
            /// </summary>
            public ServerGetGroupsWithSegmentOperationRequest(GroupModels.ServerGetGroupsWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get groups with segment operation request.
        /// </summary>
        public class AdminGetGroupsWithSegmentOperationRequest : GetGroupsWithSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetGroupsWithSegmentOperationRequest class.
            /// </summary>
            public AdminGetGroupsWithSegmentOperationRequest(GroupModels.AdminGetGroupsWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get groups with tag operation request.
        /// </summary>
        public class GetGroupsWithTagOperationRequest : CustomOperationRequestAbstract<GroupModels.GetGroupsWithTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetGroupsWithTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetGroupsWithTagOperationRequest class.
            /// </summary>
            public GetGroupsWithTagOperationRequest(GroupModels.GetGroupsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get groups with tag operation request.
        /// </summary>
        public class ServerGetGroupsWithTagOperationRequest : GetGroupsWithTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetGroupsWithTagOperationRequest class.
            /// </summary>
            public ServerGetGroupsWithTagOperationRequest(GroupModels.ServerGetGroupsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get groups with tag operation request.
        /// </summary>
        public class AdminGetGroupsWithTagOperationRequest : GetGroupsWithTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetGroupsWithTagOperationRequest class.
            /// </summary>
            public AdminGetGroupsWithTagOperationRequest(GroupModels.AdminGetGroupsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get members operation request.
        /// </summary>
        public class GetMembersOperationRequest : CustomOperationRequestAbstract<GroupModels.GetMembersRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetMembers;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetMembersOperationRequest class.
            /// </summary>
            public GetMembersOperationRequest(GroupModels.GetMembersRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get members operation request.
        /// </summary>
        public class ServerGetMembersOperationRequest : GetMembersOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetMembersOperationRequest class.
            /// </summary>
            public ServerGetMembersOperationRequest(GroupModels.ServerGetMembersRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get members operation request.
        /// </summary>
        public class AdminGetMembersOperationRequest : GetMembersOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetMembersOperationRequest class.
            /// </summary>
            public AdminGetMembersOperationRequest(GroupModels.AdminGetMembersRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get remove status operation request.
        /// </summary>
        public class GetRemoveStatusOperationRequest : CustomOperationRequestAbstract<GroupModels.GetRemoveStatusRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetRemoveStatus;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetRemoveStatusOperationRequest class.
            /// </summary>
            public GetRemoveStatusOperationRequest(GroupModels.GetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetRemoveStatusOperationRequest(GroupModels.ServerGetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetRemoveStatusOperationRequest(GroupModels.AdminGetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get segment operation request.
        /// </summary>
        public class GetSegmentOperationRequest : CustomOperationRequestAbstract<GroupModels.GetSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetSegmentOperationRequest class.
            /// </summary>
            public GetSegmentOperationRequest(GroupModels.GetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetSegmentOperationRequest(GroupModels.ServerGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetSegmentOperationRequest(GroupModels.AdminGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get statistics leaderboard around group operation request.
        /// </summary>
        public class GetStatisticsLeaderboardAroundGroupOperationRequest : CustomOperationRequestAbstract<GroupModels.GetStatisticsLeaderboardAroundGroupRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStatisticsLeaderboardAroundGroup;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStatisticsLeaderboardAroundGroupOperationRequest class.
            /// </summary>
            public GetStatisticsLeaderboardAroundGroupOperationRequest(GroupModels.GetStatisticsLeaderboardAroundGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get statistics leaderboard around group operation request.
        /// </summary>
        public class ServerGetStatisticsLeaderboardAroundGroupOperationRequest : GetStatisticsLeaderboardAroundGroupOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetStatisticsLeaderboardAroundGroupOperationRequest class.
            /// </summary>
            public ServerGetStatisticsLeaderboardAroundGroupOperationRequest(GroupModels.ServerGetStatisticsLeaderboardAroundGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get statistics leaderboard around group operation request.
        /// </summary>
        public class AdminGetStatisticsLeaderboardAroundGroupOperationRequest : GetStatisticsLeaderboardAroundGroupOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetStatisticsLeaderboardAroundGroupOperationRequest class.
            /// </summary>
            public AdminGetStatisticsLeaderboardAroundGroupOperationRequest(GroupModels.AdminGetStatisticsLeaderboardAroundGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get statistics leaderboard operation request.
        /// </summary>
        public class GetStatisticsLeaderboardOperationRequest : CustomOperationRequestAbstract<GroupModels.GetStatisticsLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStatisticsLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStatisticsLeaderboardOperationRequest class.
            /// </summary>
            public GetStatisticsLeaderboardOperationRequest(GroupModels.GetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetStatisticsLeaderboardOperationRequest(GroupModels.ServerGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetStatisticsLeaderboardOperationRequest(GroupModels.AdminGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get tag operation request.
        /// </summary>
        public class GetTagOperationRequest : CustomOperationRequestAbstract<GroupModels.GetTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetTagOperationRequest class.
            /// </summary>
            public GetTagOperationRequest(GroupModels.GetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetTagOperationRequest(GroupModels.ServerGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetTagOperationRequest(GroupModels.AdminGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get timestamp create operation request.
        /// </summary>
        public class GetTsCreateOperationRequest : CustomOperationRequestAbstract<GroupModels.GetTsCreateRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetTsCreate;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetTsCreateOperationRequest class.
            /// </summary>
            public GetTsCreateOperationRequest(GroupModels.GetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetTsCreateOperationRequest(GroupModels.ServerGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetTsCreateOperationRequest(GroupModels.AdminGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the create group item operation request.
        /// </summary>
        public class CreateGroupItemOperationRequest : CustomOperationRequestAbstract<GroupModels.CreateGroupItemRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.CreateGroupItem;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the CreateGroupItemOperationRequest class.
            /// </summary>
            public CreateGroupItemOperationRequest(GroupModels.CreateGroupItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped create group item operation request.
        /// </summary>
        public class ServerCreateGroupItemOperationRequest : CreateGroupItemOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerCreateGroupItemOperationRequest class.
            /// </summary>
            public ServerCreateGroupItemOperationRequest(GroupModels.ServerCreateGroupItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped create group item operation request.
        /// </summary>
        public class AdminCreateGroupItemOperationRequest : CreateGroupItemOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminCreateGroupItemOperationRequest class.
            /// </summary>
            public AdminCreateGroupItemOperationRequest(GroupModels.AdminCreateGroupItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove group item operation request.
        /// </summary>
        public class RemoveGroupItemOperationRequest : CustomOperationRequestAbstract<GroupModels.RemoveGroupItemRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemoveGroupItem;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemoveGroupItemOperationRequest class.
            /// </summary>
            public RemoveGroupItemOperationRequest(GroupModels.RemoveGroupItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped remove group item operation request.
        /// </summary>
        public class ServerRemoveGroupItemOperationRequest : RemoveGroupItemOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerRemoveGroupItemOperationRequest class.
            /// </summary>
            public ServerRemoveGroupItemOperationRequest(GroupModels.ServerRemoveGroupItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped remove group item operation request.
        /// </summary>
        public class AdminRemoveGroupItemOperationRequest : RemoveGroupItemOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminRemoveGroupItemOperationRequest class.
            /// </summary>
            public AdminRemoveGroupItemOperationRequest(GroupModels.AdminRemoveGroupItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove member operation request.
        /// </summary>
        public class RemoveMemberOperationRequest : CustomOperationRequestAbstract<GroupModels.RemoveMemberRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemoveMember;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemoveMemberOperationRequest class.
            /// </summary>
            public RemoveMemberOperationRequest(GroupModels.RemoveMemberRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped remove member operation request.
        /// </summary>
        public class ServerRemoveMemberOperationRequest : RemoveMemberOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerRemoveMemberOperationRequest class.
            /// </summary>
            public ServerRemoveMemberOperationRequest(GroupModels.ServerRemoveMemberRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped remove member operation request.
        /// </summary>
        public class AdminRemoveMemberOperationRequest : RemoveMemberOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminRemoveMemberOperationRequest class.
            /// </summary>
            public AdminRemoveMemberOperationRequest(GroupModels.AdminRemoveMemberRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove segment operation request.
        /// </summary>
        public class RemoveSegmentOperationRequest : CustomOperationRequestAbstract<GroupModels.RemoveSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemoveSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemoveSegmentOperationRequest class.
            /// </summary>
            public RemoveSegmentOperationRequest(GroupModels.RemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerRemoveSegmentOperationRequest(GroupModels.ServerRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminRemoveSegmentOperationRequest(GroupModels.AdminRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove tag operation request.
        /// </summary>
        public class RemoveTagOperationRequest : CustomOperationRequestAbstract<GroupModels.RemoveTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemoveTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemoveTagOperationRequest class.
            /// </summary>
            public RemoveTagOperationRequest(GroupModels.RemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerRemoveTagOperationRequest(GroupModels.ServerRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminRemoveTagOperationRequest(GroupModels.AdminRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the send group message operation request.
        /// </summary>
        public class SendGroupMessageOperationRequest : CustomOperationRequestAbstract<GroupModels.SendGroupMessageRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SendGroupMessage;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SendGroupMessageOperationRequest class.
            /// </summary>
            public SendGroupMessageOperationRequest(GroupModels.SendGroupMessageRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped send group message operation request.
        /// </summary>
        public class ServerSendGroupMessageOperationRequest : SendGroupMessageOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSendGroupMessageOperationRequest class.
            /// </summary>
            public ServerSendGroupMessageOperationRequest(GroupModels.ServerSendGroupMessageRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped send group message operation request.
        /// </summary>
        public class AdminSendGroupMessageOperationRequest : SendGroupMessageOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSendGroupMessageOperationRequest class.
            /// </summary>
            public AdminSendGroupMessageOperationRequest(GroupModels.AdminSendGroupMessageRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set avatar operation request.
        /// </summary>
        public class SetAvatarOperationRequest : CustomOperationRequestAbstract<GroupModels.SetAvatarRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetAvatar;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetAvatarOperationRequest class.
            /// </summary>
            public SetAvatarOperationRequest(GroupModels.SetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerSetAvatarOperationRequest(GroupModels.ServerSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminSetAvatarOperationRequest(GroupModels.AdminSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set custom data operation request.
        /// </summary>
        public class SetCustomDataOperationRequest : CustomOperationRequestAbstract<GroupModels.SetCustomDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetCustomData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetCustomDataOperationRequest class.
            /// </summary>
            public SetCustomDataOperationRequest(GroupModels.SetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerSetCustomDataOperationRequest(GroupModels.ServerSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminSetCustomDataOperationRequest(GroupModels.AdminSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set display name operation request.
        /// </summary>
        public class SetDisplayNameOperationRequest : CustomOperationRequestAbstract<GroupModels.SetDisplayNameRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetDisplayName;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetDisplayNameOperationRequest class.
            /// </summary>
            public SetDisplayNameOperationRequest(GroupModels.SetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerSetDisplayNameOperationRequest(GroupModels.ServerSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminSetDisplayNameOperationRequest(GroupModels.AdminSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the change group currency operation request.
        /// </summary>
        public class ChangeGroupCurrencyOperationRequest : CustomOperationRequestAbstract<GroupModels.ChangeGroupCurrencyRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ChangeGroupCurrency;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ChangeGroupCurrencyOperationRequest class.
            /// </summary>
            public ChangeGroupCurrencyOperationRequest(GroupModels.ChangeGroupCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped change group currency operation request.
        /// </summary>
        public class ServerChangeGroupCurrencyOperationRequest : ChangeGroupCurrencyOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerChangeGroupCurrencyOperationRequest class.
            /// </summary>
            public ServerChangeGroupCurrencyOperationRequest(GroupModels.ServerChangeGroupCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped change group currency operation request.
        /// </summary>
        public class AdminChangeGroupCurrencyOperationRequest : ChangeGroupCurrencyOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminChangeGroupCurrencyOperationRequest class.
            /// </summary>
            public AdminChangeGroupCurrencyOperationRequest(GroupModels.AdminChangeGroupCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set group data operation request.
        /// </summary>
        public class SetGroupDataOperationRequest : CustomOperationRequestAbstract<GroupModels.SetGroupDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetGroupData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetGroupDataOperationRequest class.
            /// </summary>
            public SetGroupDataOperationRequest(GroupModels.SetGroupDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set group data operation request.
        /// </summary>
        public class ServerSetGroupDataOperationRequest : SetGroupDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetGroupDataOperationRequest class.
            /// </summary>
            public ServerSetGroupDataOperationRequest(GroupModels.ServerSetGroupDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set group data operation request.
        /// </summary>
        public class AdminSetGroupDataOperationRequest : SetGroupDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetGroupDataOperationRequest class.
            /// </summary>
            public AdminSetGroupDataOperationRequest(GroupModels.AdminSetGroupDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the change group statistics operation request.
        /// </summary>
        public class ChangeGroupStatisticsOperationRequest : CustomOperationRequestAbstract<GroupModels.ChangeGroupStatisticsRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ChangeGroupStatistics;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ChangeGroupStatisticsOperationRequest class.
            /// </summary>
            public ChangeGroupStatisticsOperationRequest(GroupModels.ChangeGroupStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped change group statistics operation request.
        /// </summary>
        public class ServerChangeGroupStatisticsOperationRequest : ChangeGroupStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerChangeGroupStatisticsOperationRequest class.
            /// </summary>
            public ServerChangeGroupStatisticsOperationRequest(GroupModels.ServerChangeGroupStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped change group statistics operation request.
        /// </summary>
        public class AdminChangeGroupStatisticsOperationRequest : ChangeGroupStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminChangeGroupStatisticsOperationRequest class.
            /// </summary>
            public AdminChangeGroupStatisticsOperationRequest(GroupModels.AdminChangeGroupStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set remove status operation request.
        /// </summary>
        public class SetRemoveStatusOperationRequest : CustomOperationRequestAbstract<GroupModels.SetRemoveStatusRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetRemoveStatus;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetRemoveStatusOperationRequest class.
            /// </summary>
            public SetRemoveStatusOperationRequest(GroupModels.SetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerSetRemoveStatusOperationRequest(GroupModels.ServerSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminSetRemoveStatusOperationRequest(GroupModels.AdminSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set tag operation request.
        /// </summary>
        public class SetTagOperationRequest : CustomOperationRequestAbstract<GroupModels.SetTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetTagOperationRequest class.
            /// </summary>
            public SetTagOperationRequest(GroupModels.SetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerSetTagOperationRequest(GroupModels.ServerSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminSetTagOperationRequest(GroupModels.AdminSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get currency leaderboard operation request.
        /// </summary>
        public class GetCurrencyLeaderboardOperationRequest : CustomOperationRequestAbstract<GroupModels.GetCurrencyLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCurrencyLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCurrencyLeaderboardOperationRequest class.
            /// </summary>
            public GetCurrencyLeaderboardOperationRequest(GroupModels.GetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get currency leaderboard operation request.
        /// </summary>
        public class ServerGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetCurrencyLeaderboardOperationRequest class.
            /// </summary>
            public ServerGetCurrencyLeaderboardOperationRequest(GroupModels.ServerGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get currency leaderboard operation request.
        /// </summary>
        public class AdminGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetCurrencyLeaderboardOperationRequest class.
            /// </summary>
            public AdminGetCurrencyLeaderboardOperationRequest(GroupModels.AdminGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get create leaderboard operation request.
        /// </summary>
        public class GetCreateLeaderboardOperationRequest : CustomOperationRequestAbstract<GroupModels.GetCreateLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCreateLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCreateLeaderboardOperationRequest class.
            /// </summary>
            public GetCreateLeaderboardOperationRequest(GroupModels.GetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetCreateLeaderboardOperationRequest(GroupModels.ServerGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetCreateLeaderboardOperationRequest(GroupModels.AdminGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get statistics log operation request.
        /// </summary>
        public class GetStatisticsLogOperationRequest : CustomOperationRequestAbstract<GroupModels.GetStatisticsLogRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStatisticsLog;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStatisticsLogOperationRequest class.
            /// </summary>
            public GetStatisticsLogOperationRequest(GroupModels.GetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public ServerGetStatisticsLogOperationRequest(GroupModels.ServerGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
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
            public AdminGetStatisticsLogOperationRequest(GroupModels.AdminGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get currency log operation request.
        /// </summary>
        public class GetCurrencyLogOperationRequest : CustomOperationRequestAbstract<GroupModels.GetCurrencyLogRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCurrencyLog;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Group;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCurrencyLogOperationRequest class.
            /// </summary>
            public GetCurrencyLogOperationRequest(GroupModels.GetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get currency log operation request.
        /// </summary>
        public class ServerGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetCurrencyLogOperationRequest class.
            /// </summary>
            public ServerGetCurrencyLogOperationRequest(GroupModels.ServerGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get currency log operation request.
        /// </summary>
        public class AdminGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetCurrencyLogOperationRequest class.
            /// </summary>
            public AdminGetCurrencyLogOperationRequest(GroupModels.AdminGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}