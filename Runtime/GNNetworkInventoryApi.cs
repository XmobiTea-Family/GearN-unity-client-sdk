namespace XmobiTea.GearN
{
    using System.Threading.Tasks;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Models;

    public class InventoryApi
    {
        public ServerApi server { get; } = new ServerApi();

        public AdminApi admin { get; } = new AdminApi();

        public void addSegment(InventoryModels.AddSegmentRequestData requestData, Action1<InventoryResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.AddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.AddSegmentOperationResponse> addSegmentAsync(InventoryModels.AddSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AddSegmentOperationRequest, InventoryResponseModels.AddSegmentOperationResponse>(new InventoryRequestModels.AddSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getAmount(InventoryModels.GetAmountRequestData requestData, Action1<InventoryResponseModels.GetAmountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetAmountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetAmountOperationResponse> getAmountAsync(InventoryModels.GetAmountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetAmountOperationRequest, InventoryResponseModels.GetAmountOperationResponse>(new InventoryRequestModels.GetAmountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getAvatar(InventoryModels.GetAvatarRequestData requestData, Action1<InventoryResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetAvatarOperationResponse> getAvatarAsync(InventoryModels.GetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetAvatarOperationRequest, InventoryResponseModels.GetAvatarOperationResponse>(new InventoryRequestModels.GetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCatalogId(InventoryModels.GetCatalogIdRequestData requestData, Action1<InventoryResponseModels.GetCatalogIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetCatalogIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetCatalogIdOperationResponse> getCatalogIdAsync(InventoryModels.GetCatalogIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetCatalogIdOperationRequest, InventoryResponseModels.GetCatalogIdOperationResponse>(new InventoryRequestModels.GetCatalogIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getClassId(InventoryModels.GetClassIdRequestData requestData, Action1<InventoryResponseModels.GetClassIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetClassIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetClassIdOperationResponse> getClassIdAsync(InventoryModels.GetClassIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetClassIdOperationRequest, InventoryResponseModels.GetClassIdOperationResponse>(new InventoryRequestModels.GetClassIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCustomData(InventoryModels.GetCustomDataRequestData requestData, Action1<InventoryResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetCustomDataOperationResponse> getCustomDataAsync(InventoryModels.GetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetCustomDataOperationRequest, InventoryResponseModels.GetCustomDataOperationResponse>(new InventoryRequestModels.GetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getDisplayName(InventoryModels.GetDisplayNameRequestData requestData, Action1<InventoryResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetDisplayNameOperationResponse> getDisplayNameAsync(InventoryModels.GetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetDisplayNameOperationRequest, InventoryResponseModels.GetDisplayNameOperationResponse>(new InventoryRequestModels.GetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getItemData(InventoryModels.GetItemDataRequestData requestData, Action1<InventoryResponseModels.GetItemDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetItemDataOperationResponse> getItemDataAsync(InventoryModels.GetItemDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetItemDataOperationRequest, InventoryResponseModels.GetItemDataOperationResponse>(new InventoryRequestModels.GetItemDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getItemInformation(InventoryModels.GetItemInformationRequestData requestData, Action1<InventoryResponseModels.GetItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetItemInformationOperationResponse> getItemInformationAsync(InventoryModels.GetItemInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetItemInformationOperationRequest, InventoryResponseModels.GetItemInformationOperationResponse>(new InventoryRequestModels.GetItemInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getItemStatistics(InventoryModels.GetItemStatisticsRequestData requestData, Action1<InventoryResponseModels.GetItemStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetItemStatisticsOperationResponse> getItemStatisticsAsync(InventoryModels.GetItemStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetItemStatisticsOperationRequest, InventoryResponseModels.GetItemStatisticsOperationResponse>(new InventoryRequestModels.GetItemStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getItemsWithDisplayName(InventoryModels.GetItemsWithDisplayNameRequestData requestData, Action1<InventoryResponseModels.GetItemsWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemsWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetItemsWithDisplayNameOperationResponse> getItemsWithDisplayNameAsync(InventoryModels.GetItemsWithDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetItemsWithDisplayNameOperationRequest, InventoryResponseModels.GetItemsWithDisplayNameOperationResponse>(new InventoryRequestModels.GetItemsWithDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getItemsWithSegment(InventoryModels.GetItemsWithSegmentRequestData requestData, Action1<InventoryResponseModels.GetItemsWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemsWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetItemsWithSegmentOperationResponse> getItemsWithSegmentAsync(InventoryModels.GetItemsWithSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetItemsWithSegmentOperationRequest, InventoryResponseModels.GetItemsWithSegmentOperationResponse>(new InventoryRequestModels.GetItemsWithSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getItemsWithTag(InventoryModels.GetItemsWithTagRequestData requestData, Action1<InventoryResponseModels.GetItemsWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemsWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetItemsWithTagOperationResponse> getItemsWithTagAsync(InventoryModels.GetItemsWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetItemsWithTagOperationRequest, InventoryResponseModels.GetItemsWithTagOperationResponse>(new InventoryRequestModels.GetItemsWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getItemType(InventoryModels.GetItemTypeRequestData requestData, Action1<InventoryResponseModels.GetItemTypeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemTypeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetItemTypeOperationResponse> getItemTypeAsync(InventoryModels.GetItemTypeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetItemTypeOperationRequest, InventoryResponseModels.GetItemTypeOperationResponse>(new InventoryRequestModels.GetItemTypeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getOwner(InventoryModels.GetOwnerRequestData requestData, Action1<InventoryResponseModels.GetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetOwnerOperationResponse> getOwnerAsync(InventoryModels.GetOwnerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetOwnerOperationRequest, InventoryResponseModels.GetOwnerOperationResponse>(new InventoryRequestModels.GetOwnerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getRemoveStatus(InventoryModels.GetRemoveStatusRequestData requestData, Action1<InventoryResponseModels.GetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetRemoveStatusOperationResponse> getRemoveStatusAsync(InventoryModels.GetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetRemoveStatusOperationRequest, InventoryResponseModels.GetRemoveStatusOperationResponse>(new InventoryRequestModels.GetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getSegment(InventoryModels.GetSegmentRequestData requestData, Action1<InventoryResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetSegmentOperationResponse> getSegmentAsync(InventoryModels.GetSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetSegmentOperationRequest, InventoryResponseModels.GetSegmentOperationResponse>(new InventoryRequestModels.GetSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStatisticsLeaderboardAroundItem(InventoryModels.GetStatisticsLeaderboardAroundItemRequestData requestData, Action1<InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetStatisticsLeaderboardAroundItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse> getStatisticsLeaderboardAroundItemAsync(InventoryModels.GetStatisticsLeaderboardAroundItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetStatisticsLeaderboardAroundItemOperationRequest, InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse>(new InventoryRequestModels.GetStatisticsLeaderboardAroundItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStatisticsLeaderboard(InventoryModels.GetStatisticsLeaderboardRequestData requestData, Action1<InventoryResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetStatisticsLeaderboardOperationResponse> getStatisticsLeaderboardAsync(InventoryModels.GetStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetStatisticsLeaderboardOperationRequest, InventoryResponseModels.GetStatisticsLeaderboardOperationResponse>(new InventoryRequestModels.GetStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getTag(InventoryModels.GetTagRequestData requestData, Action1<InventoryResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetTagOperationResponse> getTagAsync(InventoryModels.GetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetTagOperationRequest, InventoryResponseModels.GetTagOperationResponse>(new InventoryRequestModels.GetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getTsCreate(InventoryModels.GetTsCreateRequestData requestData, Action1<InventoryResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetTsCreateOperationResponse> getTsCreateAsync(InventoryModels.GetTsCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetTsCreateOperationRequest, InventoryResponseModels.GetTsCreateOperationResponse>(new InventoryRequestModels.GetTsCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removeSegment(InventoryModels.RemoveSegmentRequestData requestData, Action1<InventoryResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.RemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.RemoveSegmentOperationResponse> removeSegmentAsync(InventoryModels.RemoveSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.RemoveSegmentOperationRequest, InventoryResponseModels.RemoveSegmentOperationResponse>(new InventoryRequestModels.RemoveSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removeTag(InventoryModels.RemoveTagRequestData requestData, Action1<InventoryResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.RemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.RemoveTagOperationResponse> removeTagAsync(InventoryModels.RemoveTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.RemoveTagOperationRequest, InventoryResponseModels.RemoveTagOperationResponse>(new InventoryRequestModels.RemoveTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setAmount(InventoryModels.SetAmountRequestData requestData, Action1<InventoryResponseModels.SetAmountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.SetAmountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.SetAmountOperationResponse> setAmountAsync(InventoryModels.SetAmountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.SetAmountOperationRequest, InventoryResponseModels.SetAmountOperationResponse>(new InventoryRequestModels.SetAmountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setAvatar(InventoryModels.SetAvatarRequestData requestData, Action1<InventoryResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.SetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.SetAvatarOperationResponse> setAvatarAsync(InventoryModels.SetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.SetAvatarOperationRequest, InventoryResponseModels.SetAvatarOperationResponse>(new InventoryRequestModels.SetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setCustomData(InventoryModels.SetCustomDataRequestData requestData, Action1<InventoryResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.SetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.SetCustomDataOperationResponse> setCustomDataAsync(InventoryModels.SetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.SetCustomDataOperationRequest, InventoryResponseModels.SetCustomDataOperationResponse>(new InventoryRequestModels.SetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setDisplayName(InventoryModels.SetDisplayNameRequestData requestData, Action1<InventoryResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.SetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.SetDisplayNameOperationResponse> setDisplayNameAsync(InventoryModels.SetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.SetDisplayNameOperationRequest, InventoryResponseModels.SetDisplayNameOperationResponse>(new InventoryRequestModels.SetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setItemData(InventoryModels.SetItemDataRequestData requestData, Action1<InventoryResponseModels.SetItemDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.SetItemDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.SetItemDataOperationResponse> setItemDataAsync(InventoryModels.SetItemDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.SetItemDataOperationRequest, InventoryResponseModels.SetItemDataOperationResponse>(new InventoryRequestModels.SetItemDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void changeItemStatistics(InventoryModels.ChangeItemStatisticsRequestData requestData, Action1<InventoryResponseModels.ChangeItemStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.ChangeItemStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.ChangeItemStatisticsOperationResponse> changeItemStatisticsAsync(InventoryModels.ChangeItemStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ChangeItemStatisticsOperationRequest, InventoryResponseModels.ChangeItemStatisticsOperationResponse>(new InventoryRequestModels.ChangeItemStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setOwner(InventoryModels.SetOwnerRequestData requestData, Action1<InventoryResponseModels.SetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.SetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.SetOwnerOperationResponse> setOwnerAsync(InventoryModels.SetOwnerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.SetOwnerOperationRequest, InventoryResponseModels.SetOwnerOperationResponse>(new InventoryRequestModels.SetOwnerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setRemoveStatus(InventoryModels.SetRemoveStatusRequestData requestData, Action1<InventoryResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.SetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.SetRemoveStatusOperationResponse> setRemoveStatusAsync(InventoryModels.SetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.SetRemoveStatusOperationRequest, InventoryResponseModels.SetRemoveStatusOperationResponse>(new InventoryRequestModels.SetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setTag(InventoryModels.SetTagRequestData requestData, Action1<InventoryResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.SetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.SetTagOperationResponse> setTagAsync(InventoryModels.SetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.SetTagOperationRequest, InventoryResponseModels.SetTagOperationResponse>(new InventoryRequestModels.SetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCreateLeaderboard(InventoryModels.GetCreateLeaderboardRequestData requestData, Action1<InventoryResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(InventoryModels.GetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetCreateLeaderboardOperationRequest, InventoryResponseModels.GetCreateLeaderboardOperationResponse>(new InventoryRequestModels.GetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStatisticsLog(InventoryModels.GetStatisticsLogRequestData requestData, Action1<InventoryResponseModels.GetStatisticsLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new InventoryRequestModels.GetStatisticsLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<InventoryResponseModels.GetStatisticsLogOperationResponse> getStatisticsLogAsync(InventoryModels.GetStatisticsLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<InventoryRequestModels.GetStatisticsLogOperationRequest, InventoryResponseModels.GetStatisticsLogOperationResponse>(new InventoryRequestModels.GetStatisticsLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }


        public class ServerApi
        {
            public void addSegment(InventoryModels.ServerAddSegmentRequestData requestData, Action1<InventoryResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerAddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.AddSegmentOperationResponse> addSegmentAsync(InventoryModels.ServerAddSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerAddSegmentOperationRequest, InventoryResponseModels.AddSegmentOperationResponse>(new InventoryRequestModels.ServerAddSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getAmount(InventoryModels.ServerGetAmountRequestData requestData, Action1<InventoryResponseModels.GetAmountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetAmountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetAmountOperationResponse> getAmountAsync(InventoryModels.ServerGetAmountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetAmountOperationRequest, InventoryResponseModels.GetAmountOperationResponse>(new InventoryRequestModels.ServerGetAmountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getAvatar(InventoryModels.ServerGetAvatarRequestData requestData, Action1<InventoryResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetAvatarOperationResponse> getAvatarAsync(InventoryModels.ServerGetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetAvatarOperationRequest, InventoryResponseModels.GetAvatarOperationResponse>(new InventoryRequestModels.ServerGetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCatalogId(InventoryModels.ServerGetCatalogIdRequestData requestData, Action1<InventoryResponseModels.GetCatalogIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetCatalogIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetCatalogIdOperationResponse> getCatalogIdAsync(InventoryModels.ServerGetCatalogIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetCatalogIdOperationRequest, InventoryResponseModels.GetCatalogIdOperationResponse>(new InventoryRequestModels.ServerGetCatalogIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getClassId(InventoryModels.ServerGetClassIdRequestData requestData, Action1<InventoryResponseModels.GetClassIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetClassIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetClassIdOperationResponse> getClassIdAsync(InventoryModels.ServerGetClassIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetClassIdOperationRequest, InventoryResponseModels.GetClassIdOperationResponse>(new InventoryRequestModels.ServerGetClassIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCustomData(InventoryModels.ServerGetCustomDataRequestData requestData, Action1<InventoryResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetCustomDataOperationResponse> getCustomDataAsync(InventoryModels.ServerGetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetCustomDataOperationRequest, InventoryResponseModels.GetCustomDataOperationResponse>(new InventoryRequestModels.ServerGetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getDisplayName(InventoryModels.ServerGetDisplayNameRequestData requestData, Action1<InventoryResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetDisplayNameOperationResponse> getDisplayNameAsync(InventoryModels.ServerGetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetDisplayNameOperationRequest, InventoryResponseModels.GetDisplayNameOperationResponse>(new InventoryRequestModels.ServerGetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getItemData(InventoryModels.ServerGetItemDataRequestData requestData, Action1<InventoryResponseModels.GetItemDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetItemDataOperationResponse> getItemDataAsync(InventoryModels.ServerGetItemDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetItemDataOperationRequest, InventoryResponseModels.GetItemDataOperationResponse>(new InventoryRequestModels.ServerGetItemDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getItemInformation(InventoryModels.ServerGetItemInformationRequestData requestData, Action1<InventoryResponseModels.GetItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetItemInformationOperationResponse> getItemInformationAsync(InventoryModels.ServerGetItemInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetItemInformationOperationRequest, InventoryResponseModels.GetItemInformationOperationResponse>(new InventoryRequestModels.ServerGetItemInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getItemStatistics(InventoryModels.ServerGetItemStatisticsRequestData requestData, Action1<InventoryResponseModels.GetItemStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetItemStatisticsOperationResponse> getItemStatisticsAsync(InventoryModels.ServerGetItemStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetItemStatisticsOperationRequest, InventoryResponseModels.GetItemStatisticsOperationResponse>(new InventoryRequestModels.ServerGetItemStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getItemsWithDisplayName(InventoryModels.ServerGetItemsWithDisplayNameRequestData requestData, Action1<InventoryResponseModels.GetItemsWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemsWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetItemsWithDisplayNameOperationResponse> getItemsWithDisplayNameAsync(InventoryModels.ServerGetItemsWithDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetItemsWithDisplayNameOperationRequest, InventoryResponseModels.GetItemsWithDisplayNameOperationResponse>(new InventoryRequestModels.ServerGetItemsWithDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getItemsWithSegment(InventoryModels.ServerGetItemsWithSegmentRequestData requestData, Action1<InventoryResponseModels.GetItemsWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemsWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetItemsWithSegmentOperationResponse> getItemsWithSegmentAsync(InventoryModels.ServerGetItemsWithSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetItemsWithSegmentOperationRequest, InventoryResponseModels.GetItemsWithSegmentOperationResponse>(new InventoryRequestModels.ServerGetItemsWithSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getItemsWithTag(InventoryModels.ServerGetItemsWithTagRequestData requestData, Action1<InventoryResponseModels.GetItemsWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemsWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetItemsWithTagOperationResponse> getItemsWithTagAsync(InventoryModels.ServerGetItemsWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetItemsWithTagOperationRequest, InventoryResponseModels.GetItemsWithTagOperationResponse>(new InventoryRequestModels.ServerGetItemsWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getItemType(InventoryModels.ServerGetItemTypeRequestData requestData, Action1<InventoryResponseModels.GetItemTypeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemTypeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetItemTypeOperationResponse> getItemTypeAsync(InventoryModels.ServerGetItemTypeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetItemTypeOperationRequest, InventoryResponseModels.GetItemTypeOperationResponse>(new InventoryRequestModels.ServerGetItemTypeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getOwner(InventoryModels.ServerGetOwnerRequestData requestData, Action1<InventoryResponseModels.GetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetOwnerOperationResponse> getOwnerAsync(InventoryModels.ServerGetOwnerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetOwnerOperationRequest, InventoryResponseModels.GetOwnerOperationResponse>(new InventoryRequestModels.ServerGetOwnerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getRemoveStatus(InventoryModels.ServerGetRemoveStatusRequestData requestData, Action1<InventoryResponseModels.GetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetRemoveStatusOperationResponse> getRemoveStatusAsync(InventoryModels.ServerGetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetRemoveStatusOperationRequest, InventoryResponseModels.GetRemoveStatusOperationResponse>(new InventoryRequestModels.ServerGetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getSegment(InventoryModels.ServerGetSegmentRequestData requestData, Action1<InventoryResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetSegmentOperationResponse> getSegmentAsync(InventoryModels.ServerGetSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetSegmentOperationRequest, InventoryResponseModels.GetSegmentOperationResponse>(new InventoryRequestModels.ServerGetSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboardAroundItem(InventoryModels.ServerGetStatisticsLeaderboardAroundItemRequestData requestData, Action1<InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetStatisticsLeaderboardAroundItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse> getStatisticsLeaderboardAroundItemAsync(InventoryModels.ServerGetStatisticsLeaderboardAroundItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetStatisticsLeaderboardAroundItemOperationRequest, InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse>(new InventoryRequestModels.ServerGetStatisticsLeaderboardAroundItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboard(InventoryModels.ServerGetStatisticsLeaderboardRequestData requestData, Action1<InventoryResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetStatisticsLeaderboardOperationResponse> getStatisticsLeaderboardAsync(InventoryModels.ServerGetStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetStatisticsLeaderboardOperationRequest, InventoryResponseModels.GetStatisticsLeaderboardOperationResponse>(new InventoryRequestModels.ServerGetStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTag(InventoryModels.ServerGetTagRequestData requestData, Action1<InventoryResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetTagOperationResponse> getTagAsync(InventoryModels.ServerGetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetTagOperationRequest, InventoryResponseModels.GetTagOperationResponse>(new InventoryRequestModels.ServerGetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTsCreate(InventoryModels.ServerGetTsCreateRequestData requestData, Action1<InventoryResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetTsCreateOperationResponse> getTsCreateAsync(InventoryModels.ServerGetTsCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetTsCreateOperationRequest, InventoryResponseModels.GetTsCreateOperationResponse>(new InventoryRequestModels.ServerGetTsCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeSegment(InventoryModels.ServerRemoveSegmentRequestData requestData, Action1<InventoryResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerRemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.RemoveSegmentOperationResponse> removeSegmentAsync(InventoryModels.ServerRemoveSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerRemoveSegmentOperationRequest, InventoryResponseModels.RemoveSegmentOperationResponse>(new InventoryRequestModels.ServerRemoveSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeTag(InventoryModels.ServerRemoveTagRequestData requestData, Action1<InventoryResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerRemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.RemoveTagOperationResponse> removeTagAsync(InventoryModels.ServerRemoveTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerRemoveTagOperationRequest, InventoryResponseModels.RemoveTagOperationResponse>(new InventoryRequestModels.ServerRemoveTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setAmount(InventoryModels.ServerSetAmountRequestData requestData, Action1<InventoryResponseModels.SetAmountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetAmountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.SetAmountOperationResponse> setAmountAsync(InventoryModels.ServerSetAmountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerSetAmountOperationRequest, InventoryResponseModels.SetAmountOperationResponse>(new InventoryRequestModels.ServerSetAmountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setAvatar(InventoryModels.ServerSetAvatarRequestData requestData, Action1<InventoryResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.SetAvatarOperationResponse> setAvatarAsync(InventoryModels.ServerSetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerSetAvatarOperationRequest, InventoryResponseModels.SetAvatarOperationResponse>(new InventoryRequestModels.ServerSetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setCustomData(InventoryModels.ServerSetCustomDataRequestData requestData, Action1<InventoryResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.SetCustomDataOperationResponse> setCustomDataAsync(InventoryModels.ServerSetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerSetCustomDataOperationRequest, InventoryResponseModels.SetCustomDataOperationResponse>(new InventoryRequestModels.ServerSetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setDisplayName(InventoryModels.ServerSetDisplayNameRequestData requestData, Action1<InventoryResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.SetDisplayNameOperationResponse> setDisplayNameAsync(InventoryModels.ServerSetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerSetDisplayNameOperationRequest, InventoryResponseModels.SetDisplayNameOperationResponse>(new InventoryRequestModels.ServerSetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setItemData(InventoryModels.ServerSetItemDataRequestData requestData, Action1<InventoryResponseModels.SetItemDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetItemDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.SetItemDataOperationResponse> setItemDataAsync(InventoryModels.ServerSetItemDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerSetItemDataOperationRequest, InventoryResponseModels.SetItemDataOperationResponse>(new InventoryRequestModels.ServerSetItemDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changeItemStatistics(InventoryModels.ServerChangeItemStatisticsRequestData requestData, Action1<InventoryResponseModels.ChangeItemStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerChangeItemStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.ChangeItemStatisticsOperationResponse> changeItemStatisticsAsync(InventoryModels.ServerChangeItemStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerChangeItemStatisticsOperationRequest, InventoryResponseModels.ChangeItemStatisticsOperationResponse>(new InventoryRequestModels.ServerChangeItemStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setOwner(InventoryModels.ServerSetOwnerRequestData requestData, Action1<InventoryResponseModels.SetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.SetOwnerOperationResponse> setOwnerAsync(InventoryModels.ServerSetOwnerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerSetOwnerOperationRequest, InventoryResponseModels.SetOwnerOperationResponse>(new InventoryRequestModels.ServerSetOwnerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setRemoveStatus(InventoryModels.ServerSetRemoveStatusRequestData requestData, Action1<InventoryResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.SetRemoveStatusOperationResponse> setRemoveStatusAsync(InventoryModels.ServerSetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerSetRemoveStatusOperationRequest, InventoryResponseModels.SetRemoveStatusOperationResponse>(new InventoryRequestModels.ServerSetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setTag(InventoryModels.ServerSetTagRequestData requestData, Action1<InventoryResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.SetTagOperationResponse> setTagAsync(InventoryModels.ServerSetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerSetTagOperationRequest, InventoryResponseModels.SetTagOperationResponse>(new InventoryRequestModels.ServerSetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCreateLeaderboard(InventoryModels.ServerGetCreateLeaderboardRequestData requestData, Action1<InventoryResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(InventoryModels.ServerGetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetCreateLeaderboardOperationRequest, InventoryResponseModels.GetCreateLeaderboardOperationResponse>(new InventoryRequestModels.ServerGetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLog(InventoryModels.ServerGetStatisticsLogRequestData requestData, Action1<InventoryResponseModels.GetStatisticsLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetStatisticsLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetStatisticsLogOperationResponse> getStatisticsLogAsync(InventoryModels.ServerGetStatisticsLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.ServerGetStatisticsLogOperationRequest, InventoryResponseModels.GetStatisticsLogOperationResponse>(new InventoryRequestModels.ServerGetStatisticsLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

        public class AdminApi
        {
            public void addSegment(InventoryModels.AdminAddSegmentRequestData requestData, Action1<InventoryResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminAddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.AddSegmentOperationResponse> addSegmentAsync(InventoryModels.AdminAddSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminAddSegmentOperationRequest, InventoryResponseModels.AddSegmentOperationResponse>(new InventoryRequestModels.AdminAddSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getAmount(InventoryModels.AdminGetAmountRequestData requestData, Action1<InventoryResponseModels.GetAmountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetAmountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetAmountOperationResponse> getAmountAsync(InventoryModels.AdminGetAmountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetAmountOperationRequest, InventoryResponseModels.GetAmountOperationResponse>(new InventoryRequestModels.AdminGetAmountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getAvatar(InventoryModels.AdminGetAvatarRequestData requestData, Action1<InventoryResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetAvatarOperationResponse> getAvatarAsync(InventoryModels.AdminGetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetAvatarOperationRequest, InventoryResponseModels.GetAvatarOperationResponse>(new InventoryRequestModels.AdminGetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCatalogId(InventoryModels.AdminGetCatalogIdRequestData requestData, Action1<InventoryResponseModels.GetCatalogIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetCatalogIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetCatalogIdOperationResponse> getCatalogIdAsync(InventoryModels.AdminGetCatalogIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetCatalogIdOperationRequest, InventoryResponseModels.GetCatalogIdOperationResponse>(new InventoryRequestModels.AdminGetCatalogIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getClassId(InventoryModels.AdminGetClassIdRequestData requestData, Action1<InventoryResponseModels.GetClassIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetClassIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetClassIdOperationResponse> getClassIdAsync(InventoryModels.AdminGetClassIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetClassIdOperationRequest, InventoryResponseModels.GetClassIdOperationResponse>(new InventoryRequestModels.AdminGetClassIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCustomData(InventoryModels.AdminGetCustomDataRequestData requestData, Action1<InventoryResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetCustomDataOperationResponse> getCustomDataAsync(InventoryModels.AdminGetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetCustomDataOperationRequest, InventoryResponseModels.GetCustomDataOperationResponse>(new InventoryRequestModels.AdminGetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getDisplayName(InventoryModels.AdminGetDisplayNameRequestData requestData, Action1<InventoryResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetDisplayNameOperationResponse> getDisplayNameAsync(InventoryModels.AdminGetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetDisplayNameOperationRequest, InventoryResponseModels.GetDisplayNameOperationResponse>(new InventoryRequestModels.AdminGetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getItemData(InventoryModels.AdminGetItemDataRequestData requestData, Action1<InventoryResponseModels.GetItemDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetItemDataOperationResponse> getItemDataAsync(InventoryModels.AdminGetItemDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetItemDataOperationRequest, InventoryResponseModels.GetItemDataOperationResponse>(new InventoryRequestModels.AdminGetItemDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getItemInformation(InventoryModels.AdminGetItemInformationRequestData requestData, Action1<InventoryResponseModels.GetItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetItemInformationOperationResponse> getItemInformationAsync(InventoryModels.AdminGetItemInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetItemInformationOperationRequest, InventoryResponseModels.GetItemInformationOperationResponse>(new InventoryRequestModels.AdminGetItemInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getItemStatistics(InventoryModels.AdminGetItemStatisticsRequestData requestData, Action1<InventoryResponseModels.GetItemStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetItemStatisticsOperationResponse> getItemStatisticsAsync(InventoryModels.AdminGetItemStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetItemStatisticsOperationRequest, InventoryResponseModels.GetItemStatisticsOperationResponse>(new InventoryRequestModels.AdminGetItemStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getItemsWithDisplayName(InventoryModels.AdminGetItemsWithDisplayNameRequestData requestData, Action1<InventoryResponseModels.GetItemsWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemsWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetItemsWithDisplayNameOperationResponse> getItemsWithDisplayNameAsync(InventoryModels.AdminGetItemsWithDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetItemsWithDisplayNameOperationRequest, InventoryResponseModels.GetItemsWithDisplayNameOperationResponse>(new InventoryRequestModels.AdminGetItemsWithDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getItemsWithSegment(InventoryModels.AdminGetItemsWithSegmentRequestData requestData, Action1<InventoryResponseModels.GetItemsWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemsWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetItemsWithSegmentOperationResponse> getItemsWithSegmentAsync(InventoryModels.AdminGetItemsWithSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetItemsWithSegmentOperationRequest, InventoryResponseModels.GetItemsWithSegmentOperationResponse>(new InventoryRequestModels.AdminGetItemsWithSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getItemsWithTag(InventoryModels.AdminGetItemsWithTagRequestData requestData, Action1<InventoryResponseModels.GetItemsWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemsWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetItemsWithTagOperationResponse> getItemsWithTagAsync(InventoryModels.AdminGetItemsWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetItemsWithTagOperationRequest, InventoryResponseModels.GetItemsWithTagOperationResponse>(new InventoryRequestModels.AdminGetItemsWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getItemType(InventoryModels.AdminGetItemTypeRequestData requestData, Action1<InventoryResponseModels.GetItemTypeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemTypeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetItemTypeOperationResponse> getItemTypeAsync(InventoryModels.AdminGetItemTypeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetItemTypeOperationRequest, InventoryResponseModels.GetItemTypeOperationResponse>(new InventoryRequestModels.AdminGetItemTypeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getOwner(InventoryModels.AdminGetOwnerRequestData requestData, Action1<InventoryResponseModels.GetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetOwnerOperationResponse> getOwnerAsync(InventoryModels.AdminGetOwnerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetOwnerOperationRequest, InventoryResponseModels.GetOwnerOperationResponse>(new InventoryRequestModels.AdminGetOwnerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getRemoveStatus(InventoryModels.AdminGetRemoveStatusRequestData requestData, Action1<InventoryResponseModels.GetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetRemoveStatusOperationResponse> getRemoveStatusAsync(InventoryModels.AdminGetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetRemoveStatusOperationRequest, InventoryResponseModels.GetRemoveStatusOperationResponse>(new InventoryRequestModels.AdminGetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getSegment(InventoryModels.AdminGetSegmentRequestData requestData, Action1<InventoryResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetSegmentOperationResponse> getSegmentAsync(InventoryModels.AdminGetSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetSegmentOperationRequest, InventoryResponseModels.GetSegmentOperationResponse>(new InventoryRequestModels.AdminGetSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboardAroundItem(InventoryModels.AdminGetStatisticsLeaderboardAroundItemRequestData requestData, Action1<InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetStatisticsLeaderboardAroundItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse> getStatisticsLeaderboardAroundItemAsync(InventoryModels.AdminGetStatisticsLeaderboardAroundItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetStatisticsLeaderboardAroundItemOperationRequest, InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse>(new InventoryRequestModels.AdminGetStatisticsLeaderboardAroundItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboard(InventoryModels.AdminGetStatisticsLeaderboardRequestData requestData, Action1<InventoryResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetStatisticsLeaderboardOperationResponse> getStatisticsLeaderboardAsync(InventoryModels.AdminGetStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetStatisticsLeaderboardOperationRequest, InventoryResponseModels.GetStatisticsLeaderboardOperationResponse>(new InventoryRequestModels.AdminGetStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTag(InventoryModels.AdminGetTagRequestData requestData, Action1<InventoryResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetTagOperationResponse> getTagAsync(InventoryModels.AdminGetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetTagOperationRequest, InventoryResponseModels.GetTagOperationResponse>(new InventoryRequestModels.AdminGetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTsCreate(InventoryModels.AdminGetTsCreateRequestData requestData, Action1<InventoryResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetTsCreateOperationResponse> getTsCreateAsync(InventoryModels.AdminGetTsCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetTsCreateOperationRequest, InventoryResponseModels.GetTsCreateOperationResponse>(new InventoryRequestModels.AdminGetTsCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeSegment(InventoryModels.AdminRemoveSegmentRequestData requestData, Action1<InventoryResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminRemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.RemoveSegmentOperationResponse> removeSegmentAsync(InventoryModels.AdminRemoveSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminRemoveSegmentOperationRequest, InventoryResponseModels.RemoveSegmentOperationResponse>(new InventoryRequestModels.AdminRemoveSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeTag(InventoryModels.AdminRemoveTagRequestData requestData, Action1<InventoryResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminRemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.RemoveTagOperationResponse> removeTagAsync(InventoryModels.AdminRemoveTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminRemoveTagOperationRequest, InventoryResponseModels.RemoveTagOperationResponse>(new InventoryRequestModels.AdminRemoveTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setAmount(InventoryModels.AdminSetAmountRequestData requestData, Action1<InventoryResponseModels.SetAmountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetAmountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.SetAmountOperationResponse> setAmountAsync(InventoryModels.AdminSetAmountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminSetAmountOperationRequest, InventoryResponseModels.SetAmountOperationResponse>(new InventoryRequestModels.AdminSetAmountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setAvatar(InventoryModels.AdminSetAvatarRequestData requestData, Action1<InventoryResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.SetAvatarOperationResponse> setAvatarAsync(InventoryModels.AdminSetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminSetAvatarOperationRequest, InventoryResponseModels.SetAvatarOperationResponse>(new InventoryRequestModels.AdminSetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setCustomData(InventoryModels.AdminSetCustomDataRequestData requestData, Action1<InventoryResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.SetCustomDataOperationResponse> setCustomDataAsync(InventoryModels.AdminSetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminSetCustomDataOperationRequest, InventoryResponseModels.SetCustomDataOperationResponse>(new InventoryRequestModels.AdminSetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setDisplayName(InventoryModels.AdminSetDisplayNameRequestData requestData, Action1<InventoryResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.SetDisplayNameOperationResponse> setDisplayNameAsync(InventoryModels.AdminSetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminSetDisplayNameOperationRequest, InventoryResponseModels.SetDisplayNameOperationResponse>(new InventoryRequestModels.AdminSetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setItemData(InventoryModels.AdminSetItemDataRequestData requestData, Action1<InventoryResponseModels.SetItemDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetItemDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.SetItemDataOperationResponse> setItemDataAsync(InventoryModels.AdminSetItemDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminSetItemDataOperationRequest, InventoryResponseModels.SetItemDataOperationResponse>(new InventoryRequestModels.AdminSetItemDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changeItemStatistics(InventoryModels.AdminChangeItemStatisticsRequestData requestData, Action1<InventoryResponseModels.ChangeItemStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminChangeItemStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.ChangeItemStatisticsOperationResponse> changeItemStatisticsAsync(InventoryModels.AdminChangeItemStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminChangeItemStatisticsOperationRequest, InventoryResponseModels.ChangeItemStatisticsOperationResponse>(new InventoryRequestModels.AdminChangeItemStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setOwner(InventoryModels.AdminSetOwnerRequestData requestData, Action1<InventoryResponseModels.SetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.SetOwnerOperationResponse> setOwnerAsync(InventoryModels.AdminSetOwnerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminSetOwnerOperationRequest, InventoryResponseModels.SetOwnerOperationResponse>(new InventoryRequestModels.AdminSetOwnerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setRemoveStatus(InventoryModels.AdminSetRemoveStatusRequestData requestData, Action1<InventoryResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.SetRemoveStatusOperationResponse> setRemoveStatusAsync(InventoryModels.AdminSetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminSetRemoveStatusOperationRequest, InventoryResponseModels.SetRemoveStatusOperationResponse>(new InventoryRequestModels.AdminSetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setTag(InventoryModels.AdminSetTagRequestData requestData, Action1<InventoryResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.SetTagOperationResponse> setTagAsync(InventoryModels.AdminSetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminSetTagOperationRequest, InventoryResponseModels.SetTagOperationResponse>(new InventoryRequestModels.AdminSetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCreateLeaderboard(InventoryModels.AdminGetCreateLeaderboardRequestData requestData, Action1<InventoryResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(InventoryModels.AdminGetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetCreateLeaderboardOperationRequest, InventoryResponseModels.GetCreateLeaderboardOperationResponse>(new InventoryRequestModels.AdminGetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLog(InventoryModels.AdminGetStatisticsLogRequestData requestData, Action1<InventoryResponseModels.GetStatisticsLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetStatisticsLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<InventoryResponseModels.GetStatisticsLogOperationResponse> getStatisticsLogAsync(InventoryModels.AdminGetStatisticsLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<InventoryRequestModels.AdminGetStatisticsLogOperationRequest, InventoryResponseModels.GetStatisticsLogOperationResponse>(new InventoryRequestModels.AdminGetStatisticsLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

    }

    public static partial class GNNetwork
    {

        public static InventoryApi inventory { get; }
    }

}
