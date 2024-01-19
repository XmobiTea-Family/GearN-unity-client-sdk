namespace XmobiTea.GN.Entity.Models
{
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity.Request;

    public class GroupRequestModels
    {
        public class AddMemberOperationRequest : CustomOperationRequest<GroupModels.AddMemberRequestData>
        {
            protected override int operationCode => OperationCode.AddMember;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public AddMemberOperationRequest(GroupModels.AddMemberRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerAddMemberOperationRequest : AddMemberOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerAddMemberOperationRequest(GroupModels.ServerAddMemberRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminAddMemberOperationRequest : AddMemberOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminAddMemberOperationRequest(GroupModels.AdminAddMemberRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class AddSegmentOperationRequest : CustomOperationRequest<GroupModels.AddSegmentRequestData>
        {
            protected override int operationCode => OperationCode.AddSegment;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public AddSegmentOperationRequest(GroupModels.AddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerAddSegmentOperationRequest(GroupModels.ServerAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminAddSegmentOperationRequest(GroupModels.AdminAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetAvatarOperationRequest : CustomOperationRequest<GroupModels.GetAvatarRequestData>
        {
            protected override int operationCode => OperationCode.GetAvatar;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetAvatarOperationRequest(GroupModels.GetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetAvatarOperationRequest(GroupModels.ServerGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetAvatarOperationRequest(GroupModels.AdminGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetCatalogIdOperationRequest : CustomOperationRequest<GroupModels.GetCatalogIdRequestData>
        {
            protected override int operationCode => OperationCode.GetCatalogId;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetCatalogIdOperationRequest(GroupModels.GetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCatalogIdOperationRequest : GetCatalogIdOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetCatalogIdOperationRequest(GroupModels.ServerGetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCatalogIdOperationRequest : GetCatalogIdOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetCatalogIdOperationRequest(GroupModels.AdminGetCatalogIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetCustomDataOperationRequest : CustomOperationRequest<GroupModels.GetCustomDataRequestData>
        {
            protected override int operationCode => OperationCode.GetCustomData;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetCustomDataOperationRequest(GroupModels.GetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetCustomDataOperationRequest(GroupModels.ServerGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetCustomDataOperationRequest(GroupModels.AdminGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetDisplayNameOperationRequest : CustomOperationRequest<GroupModels.GetDisplayNameRequestData>
        {
            protected override int operationCode => OperationCode.GetDisplayName;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetDisplayNameOperationRequest(GroupModels.GetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetDisplayNameOperationRequest(GroupModels.ServerGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetDisplayNameOperationRequest(GroupModels.AdminGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetGroupCurrencyOperationRequest : CustomOperationRequest<GroupModels.GetGroupCurrencyRequestData>
        {
            protected override int operationCode => OperationCode.GetGroupCurrency;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetGroupCurrencyOperationRequest(GroupModels.GetGroupCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetGroupCurrencyOperationRequest : GetGroupCurrencyOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetGroupCurrencyOperationRequest(GroupModels.ServerGetGroupCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetGroupCurrencyOperationRequest : GetGroupCurrencyOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetGroupCurrencyOperationRequest(GroupModels.AdminGetGroupCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetGroupDataOperationRequest : CustomOperationRequest<GroupModels.GetGroupDataRequestData>
        {
            protected override int operationCode => OperationCode.GetGroupData;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetGroupDataOperationRequest(GroupModels.GetGroupDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetGroupDataOperationRequest : GetGroupDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetGroupDataOperationRequest(GroupModels.ServerGetGroupDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetGroupDataOperationRequest : GetGroupDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetGroupDataOperationRequest(GroupModels.AdminGetGroupDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetGroupInformationOperationRequest : CustomOperationRequest<GroupModels.GetGroupInformationRequestData>
        {
            protected override int operationCode => OperationCode.GetGroupInformation;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetGroupInformationOperationRequest(GroupModels.GetGroupInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetGroupInformationOperationRequest : GetGroupInformationOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetGroupInformationOperationRequest(GroupModels.ServerGetGroupInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetGroupInformationOperationRequest : GetGroupInformationOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetGroupInformationOperationRequest(GroupModels.AdminGetGroupInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetGroupInventoryOperationRequest : CustomOperationRequest<GroupModels.GetGroupInventoryRequestData>
        {
            protected override int operationCode => OperationCode.GetGroupInventory;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetGroupInventoryOperationRequest(GroupModels.GetGroupInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetGroupInventoryOperationRequest : GetGroupInventoryOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetGroupInventoryOperationRequest(GroupModels.ServerGetGroupInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetGroupInventoryOperationRequest : GetGroupInventoryOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetGroupInventoryOperationRequest(GroupModels.AdminGetGroupInventoryRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetGroupMessageOperationRequest : CustomOperationRequest<GroupModels.GetGroupMessageRequestData>
        {
            protected override int operationCode => OperationCode.GetGroupMessage;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetGroupMessageOperationRequest(GroupModels.GetGroupMessageRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetGroupMessageOperationRequest : GetGroupMessageOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetGroupMessageOperationRequest(GroupModels.ServerGetGroupMessageRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetGroupMessageOperationRequest : GetGroupMessageOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetGroupMessageOperationRequest(GroupModels.AdminGetGroupMessageRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetGroupStatisticsOperationRequest : CustomOperationRequest<GroupModels.GetGroupStatisticsRequestData>
        {
            protected override int operationCode => OperationCode.GetGroupStatistics;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetGroupStatisticsOperationRequest(GroupModels.GetGroupStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetGroupStatisticsOperationRequest : GetGroupStatisticsOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetGroupStatisticsOperationRequest(GroupModels.ServerGetGroupStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetGroupStatisticsOperationRequest : GetGroupStatisticsOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetGroupStatisticsOperationRequest(GroupModels.AdminGetGroupStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetGroupsWithDisplayNameOperationRequest : CustomOperationRequest<GroupModels.GetGroupsWithDisplayNameRequestData>
        {
            protected override int operationCode => OperationCode.GetGroupsWithDisplayName;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetGroupsWithDisplayNameOperationRequest(GroupModels.GetGroupsWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetGroupsWithDisplayNameOperationRequest : GetGroupsWithDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetGroupsWithDisplayNameOperationRequest(GroupModels.ServerGetGroupsWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetGroupsWithDisplayNameOperationRequest : GetGroupsWithDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetGroupsWithDisplayNameOperationRequest(GroupModels.AdminGetGroupsWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetGroupsWithSegmentOperationRequest : CustomOperationRequest<GroupModels.GetGroupsWithSegmentRequestData>
        {
            protected override int operationCode => OperationCode.GetGroupsWithSegment;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetGroupsWithSegmentOperationRequest(GroupModels.GetGroupsWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetGroupsWithSegmentOperationRequest : GetGroupsWithSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetGroupsWithSegmentOperationRequest(GroupModels.ServerGetGroupsWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetGroupsWithSegmentOperationRequest : GetGroupsWithSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetGroupsWithSegmentOperationRequest(GroupModels.AdminGetGroupsWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetGroupsWithTagOperationRequest : CustomOperationRequest<GroupModels.GetGroupsWithTagRequestData>
        {
            protected override int operationCode => OperationCode.GetGroupsWithTag;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetGroupsWithTagOperationRequest(GroupModels.GetGroupsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetGroupsWithTagOperationRequest : GetGroupsWithTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetGroupsWithTagOperationRequest(GroupModels.ServerGetGroupsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetGroupsWithTagOperationRequest : GetGroupsWithTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetGroupsWithTagOperationRequest(GroupModels.AdminGetGroupsWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetMembersOperationRequest : CustomOperationRequest<GroupModels.GetMembersRequestData>
        {
            protected override int operationCode => OperationCode.GetMembers;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetMembersOperationRequest(GroupModels.GetMembersRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetMembersOperationRequest : GetMembersOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetMembersOperationRequest(GroupModels.ServerGetMembersRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetMembersOperationRequest : GetMembersOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetMembersOperationRequest(GroupModels.AdminGetMembersRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetRemoveStatusOperationRequest : CustomOperationRequest<GroupModels.GetRemoveStatusRequestData>
        {
            protected override int operationCode => OperationCode.GetRemoveStatus;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetRemoveStatusOperationRequest(GroupModels.GetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetRemoveStatusOperationRequest : GetRemoveStatusOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetRemoveStatusOperationRequest(GroupModels.ServerGetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetRemoveStatusOperationRequest : GetRemoveStatusOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetRemoveStatusOperationRequest(GroupModels.AdminGetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetSegmentOperationRequest : CustomOperationRequest<GroupModels.GetSegmentRequestData>
        {
            protected override int operationCode => OperationCode.GetSegment;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetSegmentOperationRequest(GroupModels.GetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetSegmentOperationRequest(GroupModels.ServerGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetSegmentOperationRequest(GroupModels.AdminGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetStatisticsLeaderboardAroundGroupOperationRequest : CustomOperationRequest<GroupModels.GetStatisticsLeaderboardAroundGroupRequestData>
        {
            protected override int operationCode => OperationCode.GetStatisticsLeaderboardAroundGroup;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetStatisticsLeaderboardAroundGroupOperationRequest(GroupModels.GetStatisticsLeaderboardAroundGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLeaderboardAroundGroupOperationRequest : GetStatisticsLeaderboardAroundGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetStatisticsLeaderboardAroundGroupOperationRequest(GroupModels.ServerGetStatisticsLeaderboardAroundGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLeaderboardAroundGroupOperationRequest : GetStatisticsLeaderboardAroundGroupOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetStatisticsLeaderboardAroundGroupOperationRequest(GroupModels.AdminGetStatisticsLeaderboardAroundGroupRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetStatisticsLeaderboardOperationRequest : CustomOperationRequest<GroupModels.GetStatisticsLeaderboardRequestData>
        {
            protected override int operationCode => OperationCode.GetStatisticsLeaderboard;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetStatisticsLeaderboardOperationRequest(GroupModels.GetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetStatisticsLeaderboardOperationRequest(GroupModels.ServerGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetStatisticsLeaderboardOperationRequest(GroupModels.AdminGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTagOperationRequest : CustomOperationRequest<GroupModels.GetTagRequestData>
        {
            protected override int operationCode => OperationCode.GetTag;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetTagOperationRequest(GroupModels.GetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTagOperationRequest : GetTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetTagOperationRequest(GroupModels.ServerGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTagOperationRequest : GetTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetTagOperationRequest(GroupModels.AdminGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetTsCreateOperationRequest : CustomOperationRequest<GroupModels.GetTsCreateRequestData>
        {
            protected override int operationCode => OperationCode.GetTsCreate;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetTsCreateOperationRequest(GroupModels.GetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetTsCreateOperationRequest(GroupModels.ServerGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetTsCreateOperationRequest(GroupModels.AdminGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GrantGroupItemOperationRequest : CustomOperationRequest<GroupModels.GrantGroupItemRequestData>
        {
            protected override int operationCode => OperationCode.GrantGroupItem;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GrantGroupItemOperationRequest(GroupModels.GrantGroupItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGrantGroupItemOperationRequest : GrantGroupItemOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGrantGroupItemOperationRequest(GroupModels.ServerGrantGroupItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGrantGroupItemOperationRequest : GrantGroupItemOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGrantGroupItemOperationRequest(GroupModels.AdminGrantGroupItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveGroupItemOperationRequest : CustomOperationRequest<GroupModels.RemoveGroupItemRequestData>
        {
            protected override int operationCode => OperationCode.RemoveGroupItem;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public RemoveGroupItemOperationRequest(GroupModels.RemoveGroupItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveGroupItemOperationRequest : RemoveGroupItemOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerRemoveGroupItemOperationRequest(GroupModels.ServerRemoveGroupItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveGroupItemOperationRequest : RemoveGroupItemOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminRemoveGroupItemOperationRequest(GroupModels.AdminRemoveGroupItemRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveMemberOperationRequest : CustomOperationRequest<GroupModels.RemoveMemberRequestData>
        {
            protected override int operationCode => OperationCode.RemoveMember;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public RemoveMemberOperationRequest(GroupModels.RemoveMemberRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveMemberOperationRequest : RemoveMemberOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerRemoveMemberOperationRequest(GroupModels.ServerRemoveMemberRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveMemberOperationRequest : RemoveMemberOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminRemoveMemberOperationRequest(GroupModels.AdminRemoveMemberRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveSegmentOperationRequest : CustomOperationRequest<GroupModels.RemoveSegmentRequestData>
        {
            protected override int operationCode => OperationCode.RemoveSegment;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public RemoveSegmentOperationRequest(GroupModels.RemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerRemoveSegmentOperationRequest(GroupModels.ServerRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminRemoveSegmentOperationRequest(GroupModels.AdminRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveTagOperationRequest : CustomOperationRequest<GroupModels.RemoveTagRequestData>
        {
            protected override int operationCode => OperationCode.RemoveTag;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public RemoveTagOperationRequest(GroupModels.RemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerRemoveTagOperationRequest(GroupModels.ServerRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminRemoveTagOperationRequest(GroupModels.AdminRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SendGroupMessageOperationRequest : CustomOperationRequest<GroupModels.SendGroupMessageRequestData>
        {
            protected override int operationCode => OperationCode.SendGroupMessage;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public SendGroupMessageOperationRequest(GroupModels.SendGroupMessageRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSendGroupMessageOperationRequest : SendGroupMessageOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSendGroupMessageOperationRequest(GroupModels.ServerSendGroupMessageRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSendGroupMessageOperationRequest : SendGroupMessageOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSendGroupMessageOperationRequest(GroupModels.AdminSendGroupMessageRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetAvatarOperationRequest : CustomOperationRequest<GroupModels.SetAvatarRequestData>
        {
            protected override int operationCode => OperationCode.SetAvatar;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetAvatarOperationRequest(GroupModels.SetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetAvatarOperationRequest(GroupModels.ServerSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetAvatarOperationRequest(GroupModels.AdminSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetCustomDataOperationRequest : CustomOperationRequest<GroupModels.SetCustomDataRequestData>
        {
            protected override int operationCode => OperationCode.SetCustomData;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetCustomDataOperationRequest(GroupModels.SetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetCustomDataOperationRequest(GroupModels.ServerSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetCustomDataOperationRequest(GroupModels.AdminSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetDisplayNameOperationRequest : CustomOperationRequest<GroupModels.SetDisplayNameRequestData>
        {
            protected override int operationCode => OperationCode.SetDisplayName;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetDisplayNameOperationRequest(GroupModels.SetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetDisplayNameOperationRequest(GroupModels.ServerSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetDisplayNameOperationRequest(GroupModels.AdminSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetGroupCurrencyOperationRequest : CustomOperationRequest<GroupModels.SetGroupCurrencyRequestData>
        {
            protected override int operationCode => OperationCode.SetGroupCurrency;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetGroupCurrencyOperationRequest(GroupModels.SetGroupCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetGroupCurrencyOperationRequest : SetGroupCurrencyOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetGroupCurrencyOperationRequest(GroupModels.ServerSetGroupCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetGroupCurrencyOperationRequest : SetGroupCurrencyOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetGroupCurrencyOperationRequest(GroupModels.AdminSetGroupCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetGroupDataOperationRequest : CustomOperationRequest<GroupModels.SetGroupDataRequestData>
        {
            protected override int operationCode => OperationCode.SetGroupData;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetGroupDataOperationRequest(GroupModels.SetGroupDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetGroupDataOperationRequest : SetGroupDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetGroupDataOperationRequest(GroupModels.ServerSetGroupDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetGroupDataOperationRequest : SetGroupDataOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetGroupDataOperationRequest(GroupModels.AdminSetGroupDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetGroupStatisticsOperationRequest : CustomOperationRequest<GroupModels.SetGroupStatisticsRequestData>
        {
            protected override int operationCode => OperationCode.SetGroupStatistics;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetGroupStatisticsOperationRequest(GroupModels.SetGroupStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetGroupStatisticsOperationRequest : SetGroupStatisticsOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetGroupStatisticsOperationRequest(GroupModels.ServerSetGroupStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetGroupStatisticsOperationRequest : SetGroupStatisticsOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetGroupStatisticsOperationRequest(GroupModels.AdminSetGroupStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetRemoveStatusOperationRequest : CustomOperationRequest<GroupModels.SetRemoveStatusRequestData>
        {
            protected override int operationCode => OperationCode.SetRemoveStatus;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetRemoveStatusOperationRequest(GroupModels.SetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetRemoveStatusOperationRequest : SetRemoveStatusOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetRemoveStatusOperationRequest(GroupModels.ServerSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetRemoveStatusOperationRequest : SetRemoveStatusOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetRemoveStatusOperationRequest(GroupModels.AdminSetRemoveStatusRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetTagOperationRequest : CustomOperationRequest<GroupModels.SetTagRequestData>
        {
            protected override int operationCode => OperationCode.SetTag;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public SetTagOperationRequest(GroupModels.SetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerSetTagOperationRequest : SetTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerSetTagOperationRequest(GroupModels.ServerSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminSetTagOperationRequest : SetTagOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminSetTagOperationRequest(GroupModels.AdminSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCurrencyLeaderboardOperationRequest : CustomOperationRequest<GroupModels.GetCurrencyLeaderboardRequestData>
        {
            protected override int operationCode => OperationCode.GetCurrencyLeaderboard;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetCurrencyLeaderboardOperationRequest(GroupModels.GetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetCurrencyLeaderboardOperationRequest(GroupModels.ServerGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetCurrencyLeaderboardOperationRequest(GroupModels.AdminGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCreateLeaderboardOperationRequest : CustomOperationRequest<GroupModels.GetCreateLeaderboardRequestData>
        {
            protected override int operationCode => OperationCode.GetCreateLeaderboard;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetCreateLeaderboardOperationRequest(GroupModels.GetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetCreateLeaderboardOperationRequest(GroupModels.ServerGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetCreateLeaderboardOperationRequest(GroupModels.AdminGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetStatisticsLogOperationRequest : CustomOperationRequest<GroupModels.GetStatisticsLogRequestData>
        {
            protected override int operationCode => OperationCode.GetStatisticsLog;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetStatisticsLogOperationRequest(GroupModels.GetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetStatisticsLogOperationRequest(GroupModels.ServerGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetStatisticsLogOperationRequest(GroupModels.AdminGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetCurrencyLogOperationRequest : CustomOperationRequest<GroupModels.GetCurrencyLogRequestData>
        {
            protected override int operationCode => OperationCode.GetCurrencyLog;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Group;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetCurrencyLogOperationRequest(GroupModels.GetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetCurrencyLogOperationRequest(GroupModels.ServerGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetCurrencyLogOperationRequest(GroupModels.AdminGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}
