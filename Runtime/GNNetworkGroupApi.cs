namespace XmobiTea.GearN
{
    using System.Threading.Tasks;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Models;

    public class GroupApi
    {
        public ServerApi server { get; } = new ServerApi();

        public AdminApi admin { get; } = new AdminApi();

        public void addMember(GroupModels.AddMemberRequestData requestData, Action1<GroupResponseModels.AddMemberOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.AddMemberOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.AddMemberOperationResponse> addMemberAsync(GroupModels.AddMemberRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.AddMemberOperationRequest, GroupResponseModels.AddMemberOperationResponse>(new GroupRequestModels.AddMemberOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void addSegment(GroupModels.AddSegmentRequestData requestData, Action1<GroupResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.AddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.AddSegmentOperationResponse> addSegmentAsync(GroupModels.AddSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.AddSegmentOperationRequest, GroupResponseModels.AddSegmentOperationResponse>(new GroupRequestModels.AddSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getAvatar(GroupModels.GetAvatarRequestData requestData, Action1<GroupResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetAvatarOperationResponse> getAvatarAsync(GroupModels.GetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetAvatarOperationRequest, GroupResponseModels.GetAvatarOperationResponse>(new GroupRequestModels.GetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCatalogId(GroupModels.GetCatalogIdRequestData requestData, Action1<GroupResponseModels.GetCatalogIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetCatalogIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetCatalogIdOperationResponse> getCatalogIdAsync(GroupModels.GetCatalogIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetCatalogIdOperationRequest, GroupResponseModels.GetCatalogIdOperationResponse>(new GroupRequestModels.GetCatalogIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCustomData(GroupModels.GetCustomDataRequestData requestData, Action1<GroupResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetCustomDataOperationResponse> getCustomDataAsync(GroupModels.GetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetCustomDataOperationRequest, GroupResponseModels.GetCustomDataOperationResponse>(new GroupRequestModels.GetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getDisplayName(GroupModels.GetDisplayNameRequestData requestData, Action1<GroupResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetDisplayNameOperationResponse> getDisplayNameAsync(GroupModels.GetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetDisplayNameOperationRequest, GroupResponseModels.GetDisplayNameOperationResponse>(new GroupRequestModels.GetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getGroupCurrency(GroupModels.GetGroupCurrencyRequestData requestData, Action1<GroupResponseModels.GetGroupCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetGroupCurrencyOperationResponse> getGroupCurrencyAsync(GroupModels.GetGroupCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetGroupCurrencyOperationRequest, GroupResponseModels.GetGroupCurrencyOperationResponse>(new GroupRequestModels.GetGroupCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getGroupData(GroupModels.GetGroupDataRequestData requestData, Action1<GroupResponseModels.GetGroupDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetGroupDataOperationResponse> getGroupDataAsync(GroupModels.GetGroupDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetGroupDataOperationRequest, GroupResponseModels.GetGroupDataOperationResponse>(new GroupRequestModels.GetGroupDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getGroupInformation(GroupModels.GetGroupInformationRequestData requestData, Action1<GroupResponseModels.GetGroupInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetGroupInformationOperationResponse> getGroupInformationAsync(GroupModels.GetGroupInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetGroupInformationOperationRequest, GroupResponseModels.GetGroupInformationOperationResponse>(new GroupRequestModels.GetGroupInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getGroupInventory(GroupModels.GetGroupInventoryRequestData requestData, Action1<GroupResponseModels.GetGroupInventoryOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupInventoryOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetGroupInventoryOperationResponse> getGroupInventoryAsync(GroupModels.GetGroupInventoryRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetGroupInventoryOperationRequest, GroupResponseModels.GetGroupInventoryOperationResponse>(new GroupRequestModels.GetGroupInventoryOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getGroupMessage(GroupModels.GetGroupMessageRequestData requestData, Action1<GroupResponseModels.GetGroupMessageOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupMessageOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetGroupMessageOperationResponse> getGroupMessageAsync(GroupModels.GetGroupMessageRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetGroupMessageOperationRequest, GroupResponseModels.GetGroupMessageOperationResponse>(new GroupRequestModels.GetGroupMessageOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getGroupStatistics(GroupModels.GetGroupStatisticsRequestData requestData, Action1<GroupResponseModels.GetGroupStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetGroupStatisticsOperationResponse> getGroupStatisticsAsync(GroupModels.GetGroupStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetGroupStatisticsOperationRequest, GroupResponseModels.GetGroupStatisticsOperationResponse>(new GroupRequestModels.GetGroupStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getGroupsWithDisplayName(GroupModels.GetGroupsWithDisplayNameRequestData requestData, Action1<GroupResponseModels.GetGroupsWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupsWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetGroupsWithDisplayNameOperationResponse> getGroupsWithDisplayNameAsync(GroupModels.GetGroupsWithDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetGroupsWithDisplayNameOperationRequest, GroupResponseModels.GetGroupsWithDisplayNameOperationResponse>(new GroupRequestModels.GetGroupsWithDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getGroupsWithSegment(GroupModels.GetGroupsWithSegmentRequestData requestData, Action1<GroupResponseModels.GetGroupsWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupsWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetGroupsWithSegmentOperationResponse> getGroupsWithSegmentAsync(GroupModels.GetGroupsWithSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetGroupsWithSegmentOperationRequest, GroupResponseModels.GetGroupsWithSegmentOperationResponse>(new GroupRequestModels.GetGroupsWithSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getGroupsWithTag(GroupModels.GetGroupsWithTagRequestData requestData, Action1<GroupResponseModels.GetGroupsWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupsWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetGroupsWithTagOperationResponse> getGroupsWithTagAsync(GroupModels.GetGroupsWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetGroupsWithTagOperationRequest, GroupResponseModels.GetGroupsWithTagOperationResponse>(new GroupRequestModels.GetGroupsWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getMembers(GroupModels.GetMembersRequestData requestData, Action1<GroupResponseModels.GetMembersOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetMembersOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetMembersOperationResponse> getMembersAsync(GroupModels.GetMembersRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetMembersOperationRequest, GroupResponseModels.GetMembersOperationResponse>(new GroupRequestModels.GetMembersOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getRemoveStatus(GroupModels.GetRemoveStatusRequestData requestData, Action1<GroupResponseModels.GetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetRemoveStatusOperationResponse> getRemoveStatusAsync(GroupModels.GetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetRemoveStatusOperationRequest, GroupResponseModels.GetRemoveStatusOperationResponse>(new GroupRequestModels.GetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getSegment(GroupModels.GetSegmentRequestData requestData, Action1<GroupResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetSegmentOperationResponse> getSegmentAsync(GroupModels.GetSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetSegmentOperationRequest, GroupResponseModels.GetSegmentOperationResponse>(new GroupRequestModels.GetSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStatisticsLeaderboardAroundGroup(GroupModels.GetStatisticsLeaderboardAroundGroupRequestData requestData, Action1<GroupResponseModels.GetStatisticsLeaderboardAroundGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetStatisticsLeaderboardAroundGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetStatisticsLeaderboardAroundGroupOperationResponse> getStatisticsLeaderboardAroundGroupAsync(GroupModels.GetStatisticsLeaderboardAroundGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetStatisticsLeaderboardAroundGroupOperationRequest, GroupResponseModels.GetStatisticsLeaderboardAroundGroupOperationResponse>(new GroupRequestModels.GetStatisticsLeaderboardAroundGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStatisticsLeaderboard(GroupModels.GetStatisticsLeaderboardRequestData requestData, Action1<GroupResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetStatisticsLeaderboardOperationResponse> getStatisticsLeaderboardAsync(GroupModels.GetStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetStatisticsLeaderboardOperationRequest, GroupResponseModels.GetStatisticsLeaderboardOperationResponse>(new GroupRequestModels.GetStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getTag(GroupModels.GetTagRequestData requestData, Action1<GroupResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetTagOperationResponse> getTagAsync(GroupModels.GetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetTagOperationRequest, GroupResponseModels.GetTagOperationResponse>(new GroupRequestModels.GetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getTsCreate(GroupModels.GetTsCreateRequestData requestData, Action1<GroupResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetTsCreateOperationResponse> getTsCreateAsync(GroupModels.GetTsCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetTsCreateOperationRequest, GroupResponseModels.GetTsCreateOperationResponse>(new GroupRequestModels.GetTsCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void createGroupItem(GroupModels.CreateGroupItemRequestData requestData, Action1<GroupResponseModels.CreateGroupItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.CreateGroupItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.CreateGroupItemOperationResponse> createGroupItemAsync(GroupModels.CreateGroupItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.CreateGroupItemOperationRequest, GroupResponseModels.CreateGroupItemOperationResponse>(new GroupRequestModels.CreateGroupItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removeGroupItem(GroupModels.RemoveGroupItemRequestData requestData, Action1<GroupResponseModels.RemoveGroupItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.RemoveGroupItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.RemoveGroupItemOperationResponse> removeGroupItemAsync(GroupModels.RemoveGroupItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.RemoveGroupItemOperationRequest, GroupResponseModels.RemoveGroupItemOperationResponse>(new GroupRequestModels.RemoveGroupItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removeMember(GroupModels.RemoveMemberRequestData requestData, Action1<GroupResponseModels.RemoveMemberOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.RemoveMemberOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.RemoveMemberOperationResponse> removeMemberAsync(GroupModels.RemoveMemberRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.RemoveMemberOperationRequest, GroupResponseModels.RemoveMemberOperationResponse>(new GroupRequestModels.RemoveMemberOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removeSegment(GroupModels.RemoveSegmentRequestData requestData, Action1<GroupResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.RemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.RemoveSegmentOperationResponse> removeSegmentAsync(GroupModels.RemoveSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.RemoveSegmentOperationRequest, GroupResponseModels.RemoveSegmentOperationResponse>(new GroupRequestModels.RemoveSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removeTag(GroupModels.RemoveTagRequestData requestData, Action1<GroupResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.RemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.RemoveTagOperationResponse> removeTagAsync(GroupModels.RemoveTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.RemoveTagOperationRequest, GroupResponseModels.RemoveTagOperationResponse>(new GroupRequestModels.RemoveTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void sendGroupMessage(GroupModels.SendGroupMessageRequestData requestData, Action1<GroupResponseModels.SendGroupMessageOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.SendGroupMessageOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.SendGroupMessageOperationResponse> sendGroupMessageAsync(GroupModels.SendGroupMessageRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.SendGroupMessageOperationRequest, GroupResponseModels.SendGroupMessageOperationResponse>(new GroupRequestModels.SendGroupMessageOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setAvatar(GroupModels.SetAvatarRequestData requestData, Action1<GroupResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.SetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.SetAvatarOperationResponse> setAvatarAsync(GroupModels.SetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.SetAvatarOperationRequest, GroupResponseModels.SetAvatarOperationResponse>(new GroupRequestModels.SetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setCustomData(GroupModels.SetCustomDataRequestData requestData, Action1<GroupResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.SetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.SetCustomDataOperationResponse> setCustomDataAsync(GroupModels.SetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.SetCustomDataOperationRequest, GroupResponseModels.SetCustomDataOperationResponse>(new GroupRequestModels.SetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setDisplayName(GroupModels.SetDisplayNameRequestData requestData, Action1<GroupResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.SetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.SetDisplayNameOperationResponse> setDisplayNameAsync(GroupModels.SetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.SetDisplayNameOperationRequest, GroupResponseModels.SetDisplayNameOperationResponse>(new GroupRequestModels.SetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void changeGroupCurrency(GroupModels.ChangeGroupCurrencyRequestData requestData, Action1<GroupResponseModels.ChangeGroupCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.ChangeGroupCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.ChangeGroupCurrencyOperationResponse> changeGroupCurrencyAsync(GroupModels.ChangeGroupCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.ChangeGroupCurrencyOperationRequest, GroupResponseModels.ChangeGroupCurrencyOperationResponse>(new GroupRequestModels.ChangeGroupCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setGroupData(GroupModels.SetGroupDataRequestData requestData, Action1<GroupResponseModels.SetGroupDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.SetGroupDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.SetGroupDataOperationResponse> setGroupDataAsync(GroupModels.SetGroupDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.SetGroupDataOperationRequest, GroupResponseModels.SetGroupDataOperationResponse>(new GroupRequestModels.SetGroupDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void changeGroupStatistics(GroupModels.ChangeGroupStatisticsRequestData requestData, Action1<GroupResponseModels.ChangeGroupStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.ChangeGroupStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.ChangeGroupStatisticsOperationResponse> changeGroupStatisticsAsync(GroupModels.ChangeGroupStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.ChangeGroupStatisticsOperationRequest, GroupResponseModels.ChangeGroupStatisticsOperationResponse>(new GroupRequestModels.ChangeGroupStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setRemoveStatus(GroupModels.SetRemoveStatusRequestData requestData, Action1<GroupResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.SetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.SetRemoveStatusOperationResponse> setRemoveStatusAsync(GroupModels.SetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.SetRemoveStatusOperationRequest, GroupResponseModels.SetRemoveStatusOperationResponse>(new GroupRequestModels.SetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setTag(GroupModels.SetTagRequestData requestData, Action1<GroupResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.SetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.SetTagOperationResponse> setTagAsync(GroupModels.SetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.SetTagOperationRequest, GroupResponseModels.SetTagOperationResponse>(new GroupRequestModels.SetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCurrencyLeaderboard(GroupModels.GetCurrencyLeaderboardRequestData requestData, Action1<GroupResponseModels.GetCurrencyLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetCurrencyLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetCurrencyLeaderboardOperationResponse> getCurrencyLeaderboardAsync(GroupModels.GetCurrencyLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetCurrencyLeaderboardOperationRequest, GroupResponseModels.GetCurrencyLeaderboardOperationResponse>(new GroupRequestModels.GetCurrencyLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCreateLeaderboard(GroupModels.GetCreateLeaderboardRequestData requestData, Action1<GroupResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(GroupModels.GetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetCreateLeaderboardOperationRequest, GroupResponseModels.GetCreateLeaderboardOperationResponse>(new GroupRequestModels.GetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStatisticsLog(GroupModels.GetStatisticsLogRequestData requestData, Action1<GroupResponseModels.GetStatisticsLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetStatisticsLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetStatisticsLogOperationResponse> getStatisticsLogAsync(GroupModels.GetStatisticsLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetStatisticsLogOperationRequest, GroupResponseModels.GetStatisticsLogOperationResponse>(new GroupRequestModels.GetStatisticsLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCurrencyLog(GroupModels.GetCurrencyLogRequestData requestData, Action1<GroupResponseModels.GetCurrencyLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GroupRequestModels.GetCurrencyLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GroupResponseModels.GetCurrencyLogOperationResponse> getCurrencyLogAsync(GroupModels.GetCurrencyLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GroupRequestModels.GetCurrencyLogOperationRequest, GroupResponseModels.GetCurrencyLogOperationResponse>(new GroupRequestModels.GetCurrencyLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }


        public class ServerApi
        {
            public void addMember(GroupModels.ServerAddMemberRequestData requestData, Action1<GroupResponseModels.AddMemberOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerAddMemberOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.AddMemberOperationResponse> addMemberAsync(GroupModels.ServerAddMemberRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerAddMemberOperationRequest, GroupResponseModels.AddMemberOperationResponse>(new GroupRequestModels.ServerAddMemberOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void addSegment(GroupModels.ServerAddSegmentRequestData requestData, Action1<GroupResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerAddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.AddSegmentOperationResponse> addSegmentAsync(GroupModels.ServerAddSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerAddSegmentOperationRequest, GroupResponseModels.AddSegmentOperationResponse>(new GroupRequestModels.ServerAddSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getAvatar(GroupModels.ServerGetAvatarRequestData requestData, Action1<GroupResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetAvatarOperationResponse> getAvatarAsync(GroupModels.ServerGetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetAvatarOperationRequest, GroupResponseModels.GetAvatarOperationResponse>(new GroupRequestModels.ServerGetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCatalogId(GroupModels.ServerGetCatalogIdRequestData requestData, Action1<GroupResponseModels.GetCatalogIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetCatalogIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetCatalogIdOperationResponse> getCatalogIdAsync(GroupModels.ServerGetCatalogIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetCatalogIdOperationRequest, GroupResponseModels.GetCatalogIdOperationResponse>(new GroupRequestModels.ServerGetCatalogIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCustomData(GroupModels.ServerGetCustomDataRequestData requestData, Action1<GroupResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetCustomDataOperationResponse> getCustomDataAsync(GroupModels.ServerGetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetCustomDataOperationRequest, GroupResponseModels.GetCustomDataOperationResponse>(new GroupRequestModels.ServerGetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getDisplayName(GroupModels.ServerGetDisplayNameRequestData requestData, Action1<GroupResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetDisplayNameOperationResponse> getDisplayNameAsync(GroupModels.ServerGetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetDisplayNameOperationRequest, GroupResponseModels.GetDisplayNameOperationResponse>(new GroupRequestModels.ServerGetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupCurrency(GroupModels.ServerGetGroupCurrencyRequestData requestData, Action1<GroupResponseModels.GetGroupCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupCurrencyOperationResponse> getGroupCurrencyAsync(GroupModels.ServerGetGroupCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetGroupCurrencyOperationRequest, GroupResponseModels.GetGroupCurrencyOperationResponse>(new GroupRequestModels.ServerGetGroupCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupData(GroupModels.ServerGetGroupDataRequestData requestData, Action1<GroupResponseModels.GetGroupDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupDataOperationResponse> getGroupDataAsync(GroupModels.ServerGetGroupDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetGroupDataOperationRequest, GroupResponseModels.GetGroupDataOperationResponse>(new GroupRequestModels.ServerGetGroupDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupInformation(GroupModels.ServerGetGroupInformationRequestData requestData, Action1<GroupResponseModels.GetGroupInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupInformationOperationResponse> getGroupInformationAsync(GroupModels.ServerGetGroupInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetGroupInformationOperationRequest, GroupResponseModels.GetGroupInformationOperationResponse>(new GroupRequestModels.ServerGetGroupInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupInventory(GroupModels.ServerGetGroupInventoryRequestData requestData, Action1<GroupResponseModels.GetGroupInventoryOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupInventoryOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupInventoryOperationResponse> getGroupInventoryAsync(GroupModels.ServerGetGroupInventoryRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetGroupInventoryOperationRequest, GroupResponseModels.GetGroupInventoryOperationResponse>(new GroupRequestModels.ServerGetGroupInventoryOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupMessage(GroupModels.ServerGetGroupMessageRequestData requestData, Action1<GroupResponseModels.GetGroupMessageOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupMessageOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupMessageOperationResponse> getGroupMessageAsync(GroupModels.ServerGetGroupMessageRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetGroupMessageOperationRequest, GroupResponseModels.GetGroupMessageOperationResponse>(new GroupRequestModels.ServerGetGroupMessageOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupStatistics(GroupModels.ServerGetGroupStatisticsRequestData requestData, Action1<GroupResponseModels.GetGroupStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupStatisticsOperationResponse> getGroupStatisticsAsync(GroupModels.ServerGetGroupStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetGroupStatisticsOperationRequest, GroupResponseModels.GetGroupStatisticsOperationResponse>(new GroupRequestModels.ServerGetGroupStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupsWithDisplayName(GroupModels.ServerGetGroupsWithDisplayNameRequestData requestData, Action1<GroupResponseModels.GetGroupsWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupsWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupsWithDisplayNameOperationResponse> getGroupsWithDisplayNameAsync(GroupModels.ServerGetGroupsWithDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetGroupsWithDisplayNameOperationRequest, GroupResponseModels.GetGroupsWithDisplayNameOperationResponse>(new GroupRequestModels.ServerGetGroupsWithDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupsWithSegment(GroupModels.ServerGetGroupsWithSegmentRequestData requestData, Action1<GroupResponseModels.GetGroupsWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupsWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupsWithSegmentOperationResponse> getGroupsWithSegmentAsync(GroupModels.ServerGetGroupsWithSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetGroupsWithSegmentOperationRequest, GroupResponseModels.GetGroupsWithSegmentOperationResponse>(new GroupRequestModels.ServerGetGroupsWithSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupsWithTag(GroupModels.ServerGetGroupsWithTagRequestData requestData, Action1<GroupResponseModels.GetGroupsWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupsWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupsWithTagOperationResponse> getGroupsWithTagAsync(GroupModels.ServerGetGroupsWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetGroupsWithTagOperationRequest, GroupResponseModels.GetGroupsWithTagOperationResponse>(new GroupRequestModels.ServerGetGroupsWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getMembers(GroupModels.ServerGetMembersRequestData requestData, Action1<GroupResponseModels.GetMembersOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetMembersOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetMembersOperationResponse> getMembersAsync(GroupModels.ServerGetMembersRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetMembersOperationRequest, GroupResponseModels.GetMembersOperationResponse>(new GroupRequestModels.ServerGetMembersOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getRemoveStatus(GroupModels.ServerGetRemoveStatusRequestData requestData, Action1<GroupResponseModels.GetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetRemoveStatusOperationResponse> getRemoveStatusAsync(GroupModels.ServerGetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetRemoveStatusOperationRequest, GroupResponseModels.GetRemoveStatusOperationResponse>(new GroupRequestModels.ServerGetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getSegment(GroupModels.ServerGetSegmentRequestData requestData, Action1<GroupResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetSegmentOperationResponse> getSegmentAsync(GroupModels.ServerGetSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetSegmentOperationRequest, GroupResponseModels.GetSegmentOperationResponse>(new GroupRequestModels.ServerGetSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboardAroundGroup(GroupModels.ServerGetStatisticsLeaderboardAroundGroupRequestData requestData, Action1<GroupResponseModels.GetStatisticsLeaderboardAroundGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetStatisticsLeaderboardAroundGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetStatisticsLeaderboardAroundGroupOperationResponse> getStatisticsLeaderboardAroundGroupAsync(GroupModels.ServerGetStatisticsLeaderboardAroundGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetStatisticsLeaderboardAroundGroupOperationRequest, GroupResponseModels.GetStatisticsLeaderboardAroundGroupOperationResponse>(new GroupRequestModels.ServerGetStatisticsLeaderboardAroundGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboard(GroupModels.ServerGetStatisticsLeaderboardRequestData requestData, Action1<GroupResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetStatisticsLeaderboardOperationResponse> getStatisticsLeaderboardAsync(GroupModels.ServerGetStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetStatisticsLeaderboardOperationRequest, GroupResponseModels.GetStatisticsLeaderboardOperationResponse>(new GroupRequestModels.ServerGetStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTag(GroupModels.ServerGetTagRequestData requestData, Action1<GroupResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetTagOperationResponse> getTagAsync(GroupModels.ServerGetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetTagOperationRequest, GroupResponseModels.GetTagOperationResponse>(new GroupRequestModels.ServerGetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTsCreate(GroupModels.ServerGetTsCreateRequestData requestData, Action1<GroupResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetTsCreateOperationResponse> getTsCreateAsync(GroupModels.ServerGetTsCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetTsCreateOperationRequest, GroupResponseModels.GetTsCreateOperationResponse>(new GroupRequestModels.ServerGetTsCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void createGroupItem(GroupModels.ServerCreateGroupItemRequestData requestData, Action1<GroupResponseModels.CreateGroupItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerCreateGroupItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.CreateGroupItemOperationResponse> createGroupItemAsync(GroupModels.ServerCreateGroupItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerCreateGroupItemOperationRequest, GroupResponseModels.CreateGroupItemOperationResponse>(new GroupRequestModels.ServerCreateGroupItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeGroupItem(GroupModels.ServerRemoveGroupItemRequestData requestData, Action1<GroupResponseModels.RemoveGroupItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerRemoveGroupItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.RemoveGroupItemOperationResponse> removeGroupItemAsync(GroupModels.ServerRemoveGroupItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerRemoveGroupItemOperationRequest, GroupResponseModels.RemoveGroupItemOperationResponse>(new GroupRequestModels.ServerRemoveGroupItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeMember(GroupModels.ServerRemoveMemberRequestData requestData, Action1<GroupResponseModels.RemoveMemberOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerRemoveMemberOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.RemoveMemberOperationResponse> removeMemberAsync(GroupModels.ServerRemoveMemberRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerRemoveMemberOperationRequest, GroupResponseModels.RemoveMemberOperationResponse>(new GroupRequestModels.ServerRemoveMemberOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeSegment(GroupModels.ServerRemoveSegmentRequestData requestData, Action1<GroupResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerRemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.RemoveSegmentOperationResponse> removeSegmentAsync(GroupModels.ServerRemoveSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerRemoveSegmentOperationRequest, GroupResponseModels.RemoveSegmentOperationResponse>(new GroupRequestModels.ServerRemoveSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeTag(GroupModels.ServerRemoveTagRequestData requestData, Action1<GroupResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerRemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.RemoveTagOperationResponse> removeTagAsync(GroupModels.ServerRemoveTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerRemoveTagOperationRequest, GroupResponseModels.RemoveTagOperationResponse>(new GroupRequestModels.ServerRemoveTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void sendGroupMessage(GroupModels.ServerSendGroupMessageRequestData requestData, Action1<GroupResponseModels.SendGroupMessageOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerSendGroupMessageOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.SendGroupMessageOperationResponse> sendGroupMessageAsync(GroupModels.ServerSendGroupMessageRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerSendGroupMessageOperationRequest, GroupResponseModels.SendGroupMessageOperationResponse>(new GroupRequestModels.ServerSendGroupMessageOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setAvatar(GroupModels.ServerSetAvatarRequestData requestData, Action1<GroupResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerSetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.SetAvatarOperationResponse> setAvatarAsync(GroupModels.ServerSetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerSetAvatarOperationRequest, GroupResponseModels.SetAvatarOperationResponse>(new GroupRequestModels.ServerSetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setCustomData(GroupModels.ServerSetCustomDataRequestData requestData, Action1<GroupResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerSetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.SetCustomDataOperationResponse> setCustomDataAsync(GroupModels.ServerSetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerSetCustomDataOperationRequest, GroupResponseModels.SetCustomDataOperationResponse>(new GroupRequestModels.ServerSetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setDisplayName(GroupModels.ServerSetDisplayNameRequestData requestData, Action1<GroupResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerSetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.SetDisplayNameOperationResponse> setDisplayNameAsync(GroupModels.ServerSetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerSetDisplayNameOperationRequest, GroupResponseModels.SetDisplayNameOperationResponse>(new GroupRequestModels.ServerSetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changeGroupCurrency(GroupModels.ServerChangeGroupCurrencyRequestData requestData, Action1<GroupResponseModels.ChangeGroupCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerChangeGroupCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.ChangeGroupCurrencyOperationResponse> changeGroupCurrencyAsync(GroupModels.ServerChangeGroupCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerChangeGroupCurrencyOperationRequest, GroupResponseModels.ChangeGroupCurrencyOperationResponse>(new GroupRequestModels.ServerChangeGroupCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setGroupData(GroupModels.ServerSetGroupDataRequestData requestData, Action1<GroupResponseModels.SetGroupDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerSetGroupDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.SetGroupDataOperationResponse> setGroupDataAsync(GroupModels.ServerSetGroupDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerSetGroupDataOperationRequest, GroupResponseModels.SetGroupDataOperationResponse>(new GroupRequestModels.ServerSetGroupDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changeGroupStatistics(GroupModels.ServerChangeGroupStatisticsRequestData requestData, Action1<GroupResponseModels.ChangeGroupStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerChangeGroupStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.ChangeGroupStatisticsOperationResponse> changeGroupStatisticsAsync(GroupModels.ServerChangeGroupStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerChangeGroupStatisticsOperationRequest, GroupResponseModels.ChangeGroupStatisticsOperationResponse>(new GroupRequestModels.ServerChangeGroupStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setRemoveStatus(GroupModels.ServerSetRemoveStatusRequestData requestData, Action1<GroupResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerSetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.SetRemoveStatusOperationResponse> setRemoveStatusAsync(GroupModels.ServerSetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerSetRemoveStatusOperationRequest, GroupResponseModels.SetRemoveStatusOperationResponse>(new GroupRequestModels.ServerSetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setTag(GroupModels.ServerSetTagRequestData requestData, Action1<GroupResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerSetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.SetTagOperationResponse> setTagAsync(GroupModels.ServerSetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerSetTagOperationRequest, GroupResponseModels.SetTagOperationResponse>(new GroupRequestModels.ServerSetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCurrencyLeaderboard(GroupModels.ServerGetCurrencyLeaderboardRequestData requestData, Action1<GroupResponseModels.GetCurrencyLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetCurrencyLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetCurrencyLeaderboardOperationResponse> getCurrencyLeaderboardAsync(GroupModels.ServerGetCurrencyLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetCurrencyLeaderboardOperationRequest, GroupResponseModels.GetCurrencyLeaderboardOperationResponse>(new GroupRequestModels.ServerGetCurrencyLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCreateLeaderboard(GroupModels.ServerGetCreateLeaderboardRequestData requestData, Action1<GroupResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(GroupModels.ServerGetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetCreateLeaderboardOperationRequest, GroupResponseModels.GetCreateLeaderboardOperationResponse>(new GroupRequestModels.ServerGetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLog(GroupModels.ServerGetStatisticsLogRequestData requestData, Action1<GroupResponseModels.GetStatisticsLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetStatisticsLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetStatisticsLogOperationResponse> getStatisticsLogAsync(GroupModels.ServerGetStatisticsLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetStatisticsLogOperationRequest, GroupResponseModels.GetStatisticsLogOperationResponse>(new GroupRequestModels.ServerGetStatisticsLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCurrencyLog(GroupModels.ServerGetCurrencyLogRequestData requestData, Action1<GroupResponseModels.GetCurrencyLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetCurrencyLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetCurrencyLogOperationResponse> getCurrencyLogAsync(GroupModels.ServerGetCurrencyLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.ServerGetCurrencyLogOperationRequest, GroupResponseModels.GetCurrencyLogOperationResponse>(new GroupRequestModels.ServerGetCurrencyLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

        public class AdminApi
        {
            public void addMember(GroupModels.AdminAddMemberRequestData requestData, Action1<GroupResponseModels.AddMemberOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminAddMemberOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.AddMemberOperationResponse> addMemberAsync(GroupModels.AdminAddMemberRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminAddMemberOperationRequest, GroupResponseModels.AddMemberOperationResponse>(new GroupRequestModels.AdminAddMemberOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void addSegment(GroupModels.AdminAddSegmentRequestData requestData, Action1<GroupResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminAddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.AddSegmentOperationResponse> addSegmentAsync(GroupModels.AdminAddSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminAddSegmentOperationRequest, GroupResponseModels.AddSegmentOperationResponse>(new GroupRequestModels.AdminAddSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getAvatar(GroupModels.AdminGetAvatarRequestData requestData, Action1<GroupResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetAvatarOperationResponse> getAvatarAsync(GroupModels.AdminGetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetAvatarOperationRequest, GroupResponseModels.GetAvatarOperationResponse>(new GroupRequestModels.AdminGetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCatalogId(GroupModels.AdminGetCatalogIdRequestData requestData, Action1<GroupResponseModels.GetCatalogIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetCatalogIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetCatalogIdOperationResponse> getCatalogIdAsync(GroupModels.AdminGetCatalogIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetCatalogIdOperationRequest, GroupResponseModels.GetCatalogIdOperationResponse>(new GroupRequestModels.AdminGetCatalogIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCustomData(GroupModels.AdminGetCustomDataRequestData requestData, Action1<GroupResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetCustomDataOperationResponse> getCustomDataAsync(GroupModels.AdminGetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetCustomDataOperationRequest, GroupResponseModels.GetCustomDataOperationResponse>(new GroupRequestModels.AdminGetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getDisplayName(GroupModels.AdminGetDisplayNameRequestData requestData, Action1<GroupResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetDisplayNameOperationResponse> getDisplayNameAsync(GroupModels.AdminGetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetDisplayNameOperationRequest, GroupResponseModels.GetDisplayNameOperationResponse>(new GroupRequestModels.AdminGetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupCurrency(GroupModels.AdminGetGroupCurrencyRequestData requestData, Action1<GroupResponseModels.GetGroupCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupCurrencyOperationResponse> getGroupCurrencyAsync(GroupModels.AdminGetGroupCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetGroupCurrencyOperationRequest, GroupResponseModels.GetGroupCurrencyOperationResponse>(new GroupRequestModels.AdminGetGroupCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupData(GroupModels.AdminGetGroupDataRequestData requestData, Action1<GroupResponseModels.GetGroupDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupDataOperationResponse> getGroupDataAsync(GroupModels.AdminGetGroupDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetGroupDataOperationRequest, GroupResponseModels.GetGroupDataOperationResponse>(new GroupRequestModels.AdminGetGroupDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupInformation(GroupModels.AdminGetGroupInformationRequestData requestData, Action1<GroupResponseModels.GetGroupInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupInformationOperationResponse> getGroupInformationAsync(GroupModels.AdminGetGroupInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetGroupInformationOperationRequest, GroupResponseModels.GetGroupInformationOperationResponse>(new GroupRequestModels.AdminGetGroupInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupInventory(GroupModels.AdminGetGroupInventoryRequestData requestData, Action1<GroupResponseModels.GetGroupInventoryOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupInventoryOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupInventoryOperationResponse> getGroupInventoryAsync(GroupModels.AdminGetGroupInventoryRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetGroupInventoryOperationRequest, GroupResponseModels.GetGroupInventoryOperationResponse>(new GroupRequestModels.AdminGetGroupInventoryOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupMessage(GroupModels.AdminGetGroupMessageRequestData requestData, Action1<GroupResponseModels.GetGroupMessageOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupMessageOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupMessageOperationResponse> getGroupMessageAsync(GroupModels.AdminGetGroupMessageRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetGroupMessageOperationRequest, GroupResponseModels.GetGroupMessageOperationResponse>(new GroupRequestModels.AdminGetGroupMessageOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupStatistics(GroupModels.AdminGetGroupStatisticsRequestData requestData, Action1<GroupResponseModels.GetGroupStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupStatisticsOperationResponse> getGroupStatisticsAsync(GroupModels.AdminGetGroupStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetGroupStatisticsOperationRequest, GroupResponseModels.GetGroupStatisticsOperationResponse>(new GroupRequestModels.AdminGetGroupStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupsWithDisplayName(GroupModels.AdminGetGroupsWithDisplayNameRequestData requestData, Action1<GroupResponseModels.GetGroupsWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupsWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupsWithDisplayNameOperationResponse> getGroupsWithDisplayNameAsync(GroupModels.AdminGetGroupsWithDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetGroupsWithDisplayNameOperationRequest, GroupResponseModels.GetGroupsWithDisplayNameOperationResponse>(new GroupRequestModels.AdminGetGroupsWithDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupsWithSegment(GroupModels.AdminGetGroupsWithSegmentRequestData requestData, Action1<GroupResponseModels.GetGroupsWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupsWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupsWithSegmentOperationResponse> getGroupsWithSegmentAsync(GroupModels.AdminGetGroupsWithSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetGroupsWithSegmentOperationRequest, GroupResponseModels.GetGroupsWithSegmentOperationResponse>(new GroupRequestModels.AdminGetGroupsWithSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getGroupsWithTag(GroupModels.AdminGetGroupsWithTagRequestData requestData, Action1<GroupResponseModels.GetGroupsWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupsWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetGroupsWithTagOperationResponse> getGroupsWithTagAsync(GroupModels.AdminGetGroupsWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetGroupsWithTagOperationRequest, GroupResponseModels.GetGroupsWithTagOperationResponse>(new GroupRequestModels.AdminGetGroupsWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getMembers(GroupModels.AdminGetMembersRequestData requestData, Action1<GroupResponseModels.GetMembersOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetMembersOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetMembersOperationResponse> getMembersAsync(GroupModels.AdminGetMembersRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetMembersOperationRequest, GroupResponseModels.GetMembersOperationResponse>(new GroupRequestModels.AdminGetMembersOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getRemoveStatus(GroupModels.AdminGetRemoveStatusRequestData requestData, Action1<GroupResponseModels.GetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetRemoveStatusOperationResponse> getRemoveStatusAsync(GroupModels.AdminGetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetRemoveStatusOperationRequest, GroupResponseModels.GetRemoveStatusOperationResponse>(new GroupRequestModels.AdminGetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getSegment(GroupModels.AdminGetSegmentRequestData requestData, Action1<GroupResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetSegmentOperationResponse> getSegmentAsync(GroupModels.AdminGetSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetSegmentOperationRequest, GroupResponseModels.GetSegmentOperationResponse>(new GroupRequestModels.AdminGetSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboardAroundGroup(GroupModels.AdminGetStatisticsLeaderboardAroundGroupRequestData requestData, Action1<GroupResponseModels.GetStatisticsLeaderboardAroundGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetStatisticsLeaderboardAroundGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetStatisticsLeaderboardAroundGroupOperationResponse> getStatisticsLeaderboardAroundGroupAsync(GroupModels.AdminGetStatisticsLeaderboardAroundGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetStatisticsLeaderboardAroundGroupOperationRequest, GroupResponseModels.GetStatisticsLeaderboardAroundGroupOperationResponse>(new GroupRequestModels.AdminGetStatisticsLeaderboardAroundGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboard(GroupModels.AdminGetStatisticsLeaderboardRequestData requestData, Action1<GroupResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetStatisticsLeaderboardOperationResponse> getStatisticsLeaderboardAsync(GroupModels.AdminGetStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetStatisticsLeaderboardOperationRequest, GroupResponseModels.GetStatisticsLeaderboardOperationResponse>(new GroupRequestModels.AdminGetStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTag(GroupModels.AdminGetTagRequestData requestData, Action1<GroupResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetTagOperationResponse> getTagAsync(GroupModels.AdminGetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetTagOperationRequest, GroupResponseModels.GetTagOperationResponse>(new GroupRequestModels.AdminGetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTsCreate(GroupModels.AdminGetTsCreateRequestData requestData, Action1<GroupResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetTsCreateOperationResponse> getTsCreateAsync(GroupModels.AdminGetTsCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetTsCreateOperationRequest, GroupResponseModels.GetTsCreateOperationResponse>(new GroupRequestModels.AdminGetTsCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void createGroupItem(GroupModels.AdminCreateGroupItemRequestData requestData, Action1<GroupResponseModels.CreateGroupItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminCreateGroupItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.CreateGroupItemOperationResponse> createGroupItemAsync(GroupModels.AdminCreateGroupItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminCreateGroupItemOperationRequest, GroupResponseModels.CreateGroupItemOperationResponse>(new GroupRequestModels.AdminCreateGroupItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeGroupItem(GroupModels.AdminRemoveGroupItemRequestData requestData, Action1<GroupResponseModels.RemoveGroupItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminRemoveGroupItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.RemoveGroupItemOperationResponse> removeGroupItemAsync(GroupModels.AdminRemoveGroupItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminRemoveGroupItemOperationRequest, GroupResponseModels.RemoveGroupItemOperationResponse>(new GroupRequestModels.AdminRemoveGroupItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeMember(GroupModels.AdminRemoveMemberRequestData requestData, Action1<GroupResponseModels.RemoveMemberOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminRemoveMemberOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.RemoveMemberOperationResponse> removeMemberAsync(GroupModels.AdminRemoveMemberRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminRemoveMemberOperationRequest, GroupResponseModels.RemoveMemberOperationResponse>(new GroupRequestModels.AdminRemoveMemberOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeSegment(GroupModels.AdminRemoveSegmentRequestData requestData, Action1<GroupResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminRemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.RemoveSegmentOperationResponse> removeSegmentAsync(GroupModels.AdminRemoveSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminRemoveSegmentOperationRequest, GroupResponseModels.RemoveSegmentOperationResponse>(new GroupRequestModels.AdminRemoveSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeTag(GroupModels.AdminRemoveTagRequestData requestData, Action1<GroupResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminRemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.RemoveTagOperationResponse> removeTagAsync(GroupModels.AdminRemoveTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminRemoveTagOperationRequest, GroupResponseModels.RemoveTagOperationResponse>(new GroupRequestModels.AdminRemoveTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void sendGroupMessage(GroupModels.AdminSendGroupMessageRequestData requestData, Action1<GroupResponseModels.SendGroupMessageOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminSendGroupMessageOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.SendGroupMessageOperationResponse> sendGroupMessageAsync(GroupModels.AdminSendGroupMessageRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminSendGroupMessageOperationRequest, GroupResponseModels.SendGroupMessageOperationResponse>(new GroupRequestModels.AdminSendGroupMessageOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setAvatar(GroupModels.AdminSetAvatarRequestData requestData, Action1<GroupResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminSetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.SetAvatarOperationResponse> setAvatarAsync(GroupModels.AdminSetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminSetAvatarOperationRequest, GroupResponseModels.SetAvatarOperationResponse>(new GroupRequestModels.AdminSetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setCustomData(GroupModels.AdminSetCustomDataRequestData requestData, Action1<GroupResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminSetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.SetCustomDataOperationResponse> setCustomDataAsync(GroupModels.AdminSetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminSetCustomDataOperationRequest, GroupResponseModels.SetCustomDataOperationResponse>(new GroupRequestModels.AdminSetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setDisplayName(GroupModels.AdminSetDisplayNameRequestData requestData, Action1<GroupResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminSetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.SetDisplayNameOperationResponse> setDisplayNameAsync(GroupModels.AdminSetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminSetDisplayNameOperationRequest, GroupResponseModels.SetDisplayNameOperationResponse>(new GroupRequestModels.AdminSetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changeGroupCurrency(GroupModels.AdminChangeGroupCurrencyRequestData requestData, Action1<GroupResponseModels.ChangeGroupCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminChangeGroupCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.ChangeGroupCurrencyOperationResponse> changeGroupCurrencyAsync(GroupModels.AdminChangeGroupCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminChangeGroupCurrencyOperationRequest, GroupResponseModels.ChangeGroupCurrencyOperationResponse>(new GroupRequestModels.AdminChangeGroupCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setGroupData(GroupModels.AdminSetGroupDataRequestData requestData, Action1<GroupResponseModels.SetGroupDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminSetGroupDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.SetGroupDataOperationResponse> setGroupDataAsync(GroupModels.AdminSetGroupDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminSetGroupDataOperationRequest, GroupResponseModels.SetGroupDataOperationResponse>(new GroupRequestModels.AdminSetGroupDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changeGroupStatistics(GroupModels.AdminChangeGroupStatisticsRequestData requestData, Action1<GroupResponseModels.ChangeGroupStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminChangeGroupStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.ChangeGroupStatisticsOperationResponse> changeGroupStatisticsAsync(GroupModels.AdminChangeGroupStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminChangeGroupStatisticsOperationRequest, GroupResponseModels.ChangeGroupStatisticsOperationResponse>(new GroupRequestModels.AdminChangeGroupStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setRemoveStatus(GroupModels.AdminSetRemoveStatusRequestData requestData, Action1<GroupResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminSetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.SetRemoveStatusOperationResponse> setRemoveStatusAsync(GroupModels.AdminSetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminSetRemoveStatusOperationRequest, GroupResponseModels.SetRemoveStatusOperationResponse>(new GroupRequestModels.AdminSetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setTag(GroupModels.AdminSetTagRequestData requestData, Action1<GroupResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminSetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.SetTagOperationResponse> setTagAsync(GroupModels.AdminSetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminSetTagOperationRequest, GroupResponseModels.SetTagOperationResponse>(new GroupRequestModels.AdminSetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCurrencyLeaderboard(GroupModels.AdminGetCurrencyLeaderboardRequestData requestData, Action1<GroupResponseModels.GetCurrencyLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetCurrencyLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetCurrencyLeaderboardOperationResponse> getCurrencyLeaderboardAsync(GroupModels.AdminGetCurrencyLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetCurrencyLeaderboardOperationRequest, GroupResponseModels.GetCurrencyLeaderboardOperationResponse>(new GroupRequestModels.AdminGetCurrencyLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCreateLeaderboard(GroupModels.AdminGetCreateLeaderboardRequestData requestData, Action1<GroupResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(GroupModels.AdminGetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetCreateLeaderboardOperationRequest, GroupResponseModels.GetCreateLeaderboardOperationResponse>(new GroupRequestModels.AdminGetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLog(GroupModels.AdminGetStatisticsLogRequestData requestData, Action1<GroupResponseModels.GetStatisticsLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetStatisticsLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetStatisticsLogOperationResponse> getStatisticsLogAsync(GroupModels.AdminGetStatisticsLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetStatisticsLogOperationRequest, GroupResponseModels.GetStatisticsLogOperationResponse>(new GroupRequestModels.AdminGetStatisticsLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCurrencyLog(GroupModels.AdminGetCurrencyLogRequestData requestData, Action1<GroupResponseModels.GetCurrencyLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetCurrencyLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GroupResponseModels.GetCurrencyLogOperationResponse> getCurrencyLogAsync(GroupModels.AdminGetCurrencyLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GroupRequestModels.AdminGetCurrencyLogOperationRequest, GroupResponseModels.GetCurrencyLogOperationResponse>(new GroupRequestModels.AdminGetCurrencyLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

    }

    public static partial class GNNetwork
    {

        public static GroupApi group { get; }
    }

}
