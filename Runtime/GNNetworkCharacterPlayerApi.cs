namespace XmobiTea.GearN
{
    using System.Threading.Tasks;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Models;

    public class CharacterPlayerApi
    {
        public ServerApi server { get; } = new ServerApi();

        public AdminApi admin { get; } = new AdminApi();

        public void addPlayerFriend(CharacterPlayerModels.AddPlayerFriendRequestData requestData, Action1<CharacterPlayerResponseModels.AddPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AddPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.AddPlayerFriendOperationResponse> addPlayerFriendAsync(CharacterPlayerModels.AddPlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AddPlayerFriendOperationRequest, CharacterPlayerResponseModels.AddPlayerFriendOperationResponse>(new CharacterPlayerRequestModels.AddPlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void addSegment(CharacterPlayerModels.AddSegmentRequestData requestData, Action1<CharacterPlayerResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.AddSegmentOperationResponse> addSegmentAsync(CharacterPlayerModels.AddSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AddSegmentOperationRequest, CharacterPlayerResponseModels.AddSegmentOperationResponse>(new CharacterPlayerRequestModels.AddSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getAvatar(CharacterPlayerModels.GetAvatarRequestData requestData, Action1<CharacterPlayerResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetAvatarOperationResponse> getAvatarAsync(CharacterPlayerModels.GetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetAvatarOperationRequest, CharacterPlayerResponseModels.GetAvatarOperationResponse>(new CharacterPlayerRequestModels.GetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCatalogId(CharacterPlayerModels.GetCatalogIdRequestData requestData, Action1<CharacterPlayerResponseModels.GetCatalogIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetCatalogIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetCatalogIdOperationResponse> getCatalogIdAsync(CharacterPlayerModels.GetCatalogIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetCatalogIdOperationRequest, CharacterPlayerResponseModels.GetCatalogIdOperationResponse>(new CharacterPlayerRequestModels.GetCatalogIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCountryCode(CharacterPlayerModels.GetCountryCodeRequestData requestData, Action1<CharacterPlayerResponseModels.GetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetCountryCodeOperationResponse> getCountryCodeAsync(CharacterPlayerModels.GetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetCountryCodeOperationRequest, CharacterPlayerResponseModels.GetCountryCodeOperationResponse>(new CharacterPlayerRequestModels.GetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCustomData(CharacterPlayerModels.GetCustomDataRequestData requestData, Action1<CharacterPlayerResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetCustomDataOperationResponse> getCustomDataAsync(CharacterPlayerModels.GetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetCustomDataOperationRequest, CharacterPlayerResponseModels.GetCustomDataOperationResponse>(new CharacterPlayerRequestModels.GetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getDisplayName(CharacterPlayerModels.GetDisplayNameRequestData requestData, Action1<CharacterPlayerResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetDisplayNameOperationResponse> getDisplayNameAsync(CharacterPlayerModels.GetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetDisplayNameOperationRequest, CharacterPlayerResponseModels.GetDisplayNameOperationResponse>(new CharacterPlayerRequestModels.GetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getFriendStatisticsLeaderboardAroundPlayer(CharacterPlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, Action1<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> getFriendStatisticsLeaderboardAroundPlayerAsync(CharacterPlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetFriendStatisticsLeaderboardAroundPlayerOperationRequest, CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse>(new CharacterPlayerRequestModels.GetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getFriendStatisticsLeaderboard(CharacterPlayerModels.GetFriendStatisticsLeaderboardRequestData requestData, Action1<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> getFriendStatisticsLeaderboardAsync(CharacterPlayerModels.GetFriendStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetFriendStatisticsLeaderboardOperationRequest, CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse>(new CharacterPlayerRequestModels.GetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getIpAddressCreate(CharacterPlayerModels.GetIpAddressCreateRequestData requestData, Action1<CharacterPlayerResponseModels.GetIpAddressCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetIpAddressCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetIpAddressCreateOperationResponse> getIpAddressCreateAsync(CharacterPlayerModels.GetIpAddressCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetIpAddressCreateOperationRequest, CharacterPlayerResponseModels.GetIpAddressCreateOperationResponse>(new CharacterPlayerRequestModels.GetIpAddressCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getOwner(CharacterPlayerModels.GetOwnerRequestData requestData, Action1<CharacterPlayerResponseModels.GetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetOwnerOperationResponse> getOwnerAsync(CharacterPlayerModels.GetOwnerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetOwnerOperationRequest, CharacterPlayerResponseModels.GetOwnerOperationResponse>(new CharacterPlayerRequestModels.GetOwnerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerBan(CharacterPlayerModels.GetPlayerBanRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetPlayerBanOperationResponse> getPlayerBanAsync(CharacterPlayerModels.GetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetPlayerBanOperationRequest, CharacterPlayerResponseModels.GetPlayerBanOperationResponse>(new CharacterPlayerRequestModels.GetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerCurrency(CharacterPlayerModels.GetPlayerCurrencyRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetPlayerCurrencyOperationResponse> getPlayerCurrencyAsync(CharacterPlayerModels.GetPlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetPlayerCurrencyOperationRequest, CharacterPlayerResponseModels.GetPlayerCurrencyOperationResponse>(new CharacterPlayerRequestModels.GetPlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerData(CharacterPlayerModels.GetPlayerDataRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetPlayerDataOperationResponse> getPlayerDataAsync(CharacterPlayerModels.GetPlayerDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetPlayerDataOperationRequest, CharacterPlayerResponseModels.GetPlayerDataOperationResponse>(new CharacterPlayerRequestModels.GetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerFriend(CharacterPlayerModels.GetPlayerFriendRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetPlayerFriendOperationResponse> getPlayerFriendAsync(CharacterPlayerModels.GetPlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetPlayerFriendOperationRequest, CharacterPlayerResponseModels.GetPlayerFriendOperationResponse>(new CharacterPlayerRequestModels.GetPlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerGroup(CharacterPlayerModels.GetPlayerGroupRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayerGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetPlayerGroupOperationResponse> getPlayerGroupAsync(CharacterPlayerModels.GetPlayerGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetPlayerGroupOperationRequest, CharacterPlayerResponseModels.GetPlayerGroupOperationResponse>(new CharacterPlayerRequestModels.GetPlayerGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerInformation(CharacterPlayerModels.GetPlayerInformationRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayerInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetPlayerInformationOperationResponse> getPlayerInformationAsync(CharacterPlayerModels.GetPlayerInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetPlayerInformationOperationRequest, CharacterPlayerResponseModels.GetPlayerInformationOperationResponse>(new CharacterPlayerRequestModels.GetPlayerInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerInventory(CharacterPlayerModels.GetPlayerInventoryRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerInventoryOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayerInventoryOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetPlayerInventoryOperationResponse> getPlayerInventoryAsync(CharacterPlayerModels.GetPlayerInventoryRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetPlayerInventoryOperationRequest, CharacterPlayerResponseModels.GetPlayerInventoryOperationResponse>(new CharacterPlayerRequestModels.GetPlayerInventoryOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerStatistics(CharacterPlayerModels.GetPlayerStatisticsRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetPlayerStatisticsOperationResponse> getPlayerStatisticsAsync(CharacterPlayerModels.GetPlayerStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetPlayerStatisticsOperationRequest, CharacterPlayerResponseModels.GetPlayerStatisticsOperationResponse>(new CharacterPlayerRequestModels.GetPlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayersWithDisplayName(CharacterPlayerModels.GetPlayersWithDisplayNameRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayersWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> getPlayersWithDisplayNameAsync(CharacterPlayerModels.GetPlayersWithDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetPlayersWithDisplayNameOperationRequest, CharacterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse>(new CharacterPlayerRequestModels.GetPlayersWithDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayersWithSegment(CharacterPlayerModels.GetPlayersWithSegmentRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayersWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> getPlayersWithSegmentAsync(CharacterPlayerModels.GetPlayersWithSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetPlayersWithSegmentOperationRequest, CharacterPlayerResponseModels.GetPlayersWithSegmentOperationResponse>(new CharacterPlayerRequestModels.GetPlayersWithSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayersWithTag(CharacterPlayerModels.GetPlayersWithTagRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayersWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayersWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetPlayersWithTagOperationResponse> getPlayersWithTagAsync(CharacterPlayerModels.GetPlayersWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetPlayersWithTagOperationRequest, CharacterPlayerResponseModels.GetPlayersWithTagOperationResponse>(new CharacterPlayerRequestModels.GetPlayersWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getRemoveStatus(CharacterPlayerModels.GetRemoveStatusRequestData requestData, Action1<CharacterPlayerResponseModels.GetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetRemoveStatusOperationResponse> getRemoveStatusAsync(CharacterPlayerModels.GetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetRemoveStatusOperationRequest, CharacterPlayerResponseModels.GetRemoveStatusOperationResponse>(new CharacterPlayerRequestModels.GetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getSegment(CharacterPlayerModels.GetSegmentRequestData requestData, Action1<CharacterPlayerResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetSegmentOperationResponse> getSegmentAsync(CharacterPlayerModels.GetSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetSegmentOperationRequest, CharacterPlayerResponseModels.GetSegmentOperationResponse>(new CharacterPlayerRequestModels.GetSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStatisticsLeaderboardAroundPlayer(CharacterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, Action1<CharacterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> getStatisticsLeaderboardAroundPlayerAsync(CharacterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetStatisticsLeaderboardAroundPlayerOperationRequest, CharacterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse>(new CharacterPlayerRequestModels.GetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStatisticsLeaderboard(CharacterPlayerModels.GetStatisticsLeaderboardRequestData requestData, Action1<CharacterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> getStatisticsLeaderboardAsync(CharacterPlayerModels.GetStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetStatisticsLeaderboardOperationRequest, CharacterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse>(new CharacterPlayerRequestModels.GetStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getTag(CharacterPlayerModels.GetTagRequestData requestData, Action1<CharacterPlayerResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetTagOperationResponse> getTagAsync(CharacterPlayerModels.GetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetTagOperationRequest, CharacterPlayerResponseModels.GetTagOperationResponse>(new CharacterPlayerRequestModels.GetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getTsCreate(CharacterPlayerModels.GetTsCreateRequestData requestData, Action1<CharacterPlayerResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetTsCreateOperationResponse> getTsCreateAsync(CharacterPlayerModels.GetTsCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetTsCreateOperationRequest, CharacterPlayerResponseModels.GetTsCreateOperationResponse>(new CharacterPlayerRequestModels.GetTsCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getTsLastLogin(CharacterPlayerModels.GetTsLastLoginRequestData requestData, Action1<CharacterPlayerResponseModels.GetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetTsLastLoginOperationResponse> getTsLastLoginAsync(CharacterPlayerModels.GetTsLastLoginRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetTsLastLoginOperationRequest, CharacterPlayerResponseModels.GetTsLastLoginOperationResponse>(new CharacterPlayerRequestModels.GetTsLastLoginOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void createGroup(CharacterPlayerModels.CreateGroupRequestData requestData, Action1<CharacterPlayerResponseModels.CreateGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.CreateGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.CreateGroupOperationResponse> createGroupAsync(CharacterPlayerModels.CreateGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.CreateGroupOperationRequest, CharacterPlayerResponseModels.CreateGroupOperationResponse>(new CharacterPlayerRequestModels.CreateGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void createPlayerItem(CharacterPlayerModels.CreatePlayerItemRequestData requestData, Action1<CharacterPlayerResponseModels.CreatePlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.CreatePlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.CreatePlayerItemOperationResponse> createPlayerItemAsync(CharacterPlayerModels.CreatePlayerItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.CreatePlayerItemOperationRequest, CharacterPlayerResponseModels.CreatePlayerItemOperationResponse>(new CharacterPlayerRequestModels.CreatePlayerItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void joinGroup(CharacterPlayerModels.JoinGroupRequestData requestData, Action1<CharacterPlayerResponseModels.JoinGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.JoinGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.JoinGroupOperationResponse> joinGroupAsync(CharacterPlayerModels.JoinGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.JoinGroupOperationRequest, CharacterPlayerResponseModels.JoinGroupOperationResponse>(new CharacterPlayerRequestModels.JoinGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void leaveGroup(CharacterPlayerModels.LeaveGroupRequestData requestData, Action1<CharacterPlayerResponseModels.LeaveGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.LeaveGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.LeaveGroupOperationResponse> leaveGroupAsync(CharacterPlayerModels.LeaveGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.LeaveGroupOperationRequest, CharacterPlayerResponseModels.LeaveGroupOperationResponse>(new CharacterPlayerRequestModels.LeaveGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removePlayerFriend(CharacterPlayerModels.RemovePlayerFriendRequestData requestData, Action1<CharacterPlayerResponseModels.RemovePlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.RemovePlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.RemovePlayerFriendOperationResponse> removePlayerFriendAsync(CharacterPlayerModels.RemovePlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.RemovePlayerFriendOperationRequest, CharacterPlayerResponseModels.RemovePlayerFriendOperationResponse>(new CharacterPlayerRequestModels.RemovePlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removePlayerItem(CharacterPlayerModels.RemovePlayerItemRequestData requestData, Action1<CharacterPlayerResponseModels.RemovePlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.RemovePlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.RemovePlayerItemOperationResponse> removePlayerItemAsync(CharacterPlayerModels.RemovePlayerItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.RemovePlayerItemOperationRequest, CharacterPlayerResponseModels.RemovePlayerItemOperationResponse>(new CharacterPlayerRequestModels.RemovePlayerItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removeSegment(CharacterPlayerModels.RemoveSegmentRequestData requestData, Action1<CharacterPlayerResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.RemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.RemoveSegmentOperationResponse> removeSegmentAsync(CharacterPlayerModels.RemoveSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.RemoveSegmentOperationRequest, CharacterPlayerResponseModels.RemoveSegmentOperationResponse>(new CharacterPlayerRequestModels.RemoveSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removeTag(CharacterPlayerModels.RemoveTagRequestData requestData, Action1<CharacterPlayerResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.RemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.RemoveTagOperationResponse> removeTagAsync(CharacterPlayerModels.RemoveTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.RemoveTagOperationRequest, CharacterPlayerResponseModels.RemoveTagOperationResponse>(new CharacterPlayerRequestModels.RemoveTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setAvatar(CharacterPlayerModels.SetAvatarRequestData requestData, Action1<CharacterPlayerResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.SetAvatarOperationResponse> setAvatarAsync(CharacterPlayerModels.SetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.SetAvatarOperationRequest, CharacterPlayerResponseModels.SetAvatarOperationResponse>(new CharacterPlayerRequestModels.SetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setCountryCode(CharacterPlayerModels.SetCountryCodeRequestData requestData, Action1<CharacterPlayerResponseModels.SetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.SetCountryCodeOperationResponse> setCountryCodeAsync(CharacterPlayerModels.SetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.SetCountryCodeOperationRequest, CharacterPlayerResponseModels.SetCountryCodeOperationResponse>(new CharacterPlayerRequestModels.SetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setCustomData(CharacterPlayerModels.SetCustomDataRequestData requestData, Action1<CharacterPlayerResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.SetCustomDataOperationResponse> setCustomDataAsync(CharacterPlayerModels.SetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.SetCustomDataOperationRequest, CharacterPlayerResponseModels.SetCustomDataOperationResponse>(new CharacterPlayerRequestModels.SetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setDisplayName(CharacterPlayerModels.SetDisplayNameRequestData requestData, Action1<CharacterPlayerResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.SetDisplayNameOperationResponse> setDisplayNameAsync(CharacterPlayerModels.SetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.SetDisplayNameOperationRequest, CharacterPlayerResponseModels.SetDisplayNameOperationResponse>(new CharacterPlayerRequestModels.SetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setOwner(CharacterPlayerModels.SetOwnerRequestData requestData, Action1<CharacterPlayerResponseModels.SetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.SetOwnerOperationResponse> setOwnerAsync(CharacterPlayerModels.SetOwnerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.SetOwnerOperationRequest, CharacterPlayerResponseModels.SetOwnerOperationResponse>(new CharacterPlayerRequestModels.SetOwnerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setPlayerBan(CharacterPlayerModels.SetPlayerBanRequestData requestData, Action1<CharacterPlayerResponseModels.SetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.SetPlayerBanOperationResponse> setPlayerBanAsync(CharacterPlayerModels.SetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.SetPlayerBanOperationRequest, CharacterPlayerResponseModels.SetPlayerBanOperationResponse>(new CharacterPlayerRequestModels.SetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void changePlayerCurrency(CharacterPlayerModels.ChangePlayerCurrencyRequestData requestData, Action1<CharacterPlayerResponseModels.ChangePlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ChangePlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.ChangePlayerCurrencyOperationResponse> changePlayerCurrencyAsync(CharacterPlayerModels.ChangePlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ChangePlayerCurrencyOperationRequest, CharacterPlayerResponseModels.ChangePlayerCurrencyOperationResponse>(new CharacterPlayerRequestModels.ChangePlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setPlayerData(CharacterPlayerModels.SetPlayerDataRequestData requestData, Action1<CharacterPlayerResponseModels.SetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.SetPlayerDataOperationResponse> setPlayerDataAsync(CharacterPlayerModels.SetPlayerDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.SetPlayerDataOperationRequest, CharacterPlayerResponseModels.SetPlayerDataOperationResponse>(new CharacterPlayerRequestModels.SetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void changePlayerStatistics(CharacterPlayerModels.ChangePlayerStatisticsRequestData requestData, Action1<CharacterPlayerResponseModels.ChangePlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ChangePlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.ChangePlayerStatisticsOperationResponse> changePlayerStatisticsAsync(CharacterPlayerModels.ChangePlayerStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ChangePlayerStatisticsOperationRequest, CharacterPlayerResponseModels.ChangePlayerStatisticsOperationResponse>(new CharacterPlayerRequestModels.ChangePlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setRemoveStatus(CharacterPlayerModels.SetRemoveStatusRequestData requestData, Action1<CharacterPlayerResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.SetRemoveStatusOperationResponse> setRemoveStatusAsync(CharacterPlayerModels.SetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.SetRemoveStatusOperationRequest, CharacterPlayerResponseModels.SetRemoveStatusOperationResponse>(new CharacterPlayerRequestModels.SetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setTag(CharacterPlayerModels.SetTagRequestData requestData, Action1<CharacterPlayerResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.SetTagOperationResponse> setTagAsync(CharacterPlayerModels.SetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.SetTagOperationRequest, CharacterPlayerResponseModels.SetTagOperationResponse>(new CharacterPlayerRequestModels.SetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCurrencyLeaderboard(CharacterPlayerModels.GetCurrencyLeaderboardRequestData requestData, Action1<CharacterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetCurrencyLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse> getCurrencyLeaderboardAsync(CharacterPlayerModels.GetCurrencyLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetCurrencyLeaderboardOperationRequest, CharacterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse>(new CharacterPlayerRequestModels.GetCurrencyLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCreateLeaderboard(CharacterPlayerModels.GetCreateLeaderboardRequestData requestData, Action1<CharacterPlayerResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(CharacterPlayerModels.GetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetCreateLeaderboardOperationRequest, CharacterPlayerResponseModels.GetCreateLeaderboardOperationResponse>(new CharacterPlayerRequestModels.GetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getLastLoginLeaderboard(CharacterPlayerModels.GetLastLoginLeaderboardRequestData requestData, Action1<CharacterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetLastLoginLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse> getLastLoginLeaderboardAsync(CharacterPlayerModels.GetLastLoginLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetLastLoginLeaderboardOperationRequest, CharacterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse>(new CharacterPlayerRequestModels.GetLastLoginLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStatisticsLog(CharacterPlayerModels.GetStatisticsLogRequestData requestData, Action1<CharacterPlayerResponseModels.GetStatisticsLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetStatisticsLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetStatisticsLogOperationResponse> getStatisticsLogAsync(CharacterPlayerModels.GetStatisticsLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetStatisticsLogOperationRequest, CharacterPlayerResponseModels.GetStatisticsLogOperationResponse>(new CharacterPlayerRequestModels.GetStatisticsLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCurrencyLog(CharacterPlayerModels.GetCurrencyLogRequestData requestData, Action1<CharacterPlayerResponseModels.GetCurrencyLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetCurrencyLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CharacterPlayerResponseModels.GetCurrencyLogOperationResponse> getCurrencyLogAsync(CharacterPlayerModels.GetCurrencyLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.GetCurrencyLogOperationRequest, CharacterPlayerResponseModels.GetCurrencyLogOperationResponse>(new CharacterPlayerRequestModels.GetCurrencyLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }


        public class ServerApi
        {
            public void addPlayerFriend(CharacterPlayerModels.ServerAddPlayerFriendRequestData requestData, Action1<CharacterPlayerResponseModels.AddPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerAddPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.AddPlayerFriendOperationResponse> addPlayerFriendAsync(CharacterPlayerModels.ServerAddPlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerAddPlayerFriendOperationRequest, CharacterPlayerResponseModels.AddPlayerFriendOperationResponse>(new CharacterPlayerRequestModels.ServerAddPlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void addSegment(CharacterPlayerModels.ServerAddSegmentRequestData requestData, Action1<CharacterPlayerResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerAddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.AddSegmentOperationResponse> addSegmentAsync(CharacterPlayerModels.ServerAddSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerAddSegmentOperationRequest, CharacterPlayerResponseModels.AddSegmentOperationResponse>(new CharacterPlayerRequestModels.ServerAddSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getAvatar(CharacterPlayerModels.ServerGetAvatarRequestData requestData, Action1<CharacterPlayerResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetAvatarOperationResponse> getAvatarAsync(CharacterPlayerModels.ServerGetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetAvatarOperationRequest, CharacterPlayerResponseModels.GetAvatarOperationResponse>(new CharacterPlayerRequestModels.ServerGetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCatalogId(CharacterPlayerModels.ServerGetCatalogIdRequestData requestData, Action1<CharacterPlayerResponseModels.GetCatalogIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetCatalogIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetCatalogIdOperationResponse> getCatalogIdAsync(CharacterPlayerModels.ServerGetCatalogIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetCatalogIdOperationRequest, CharacterPlayerResponseModels.GetCatalogIdOperationResponse>(new CharacterPlayerRequestModels.ServerGetCatalogIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCountryCode(CharacterPlayerModels.ServerGetCountryCodeRequestData requestData, Action1<CharacterPlayerResponseModels.GetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetCountryCodeOperationResponse> getCountryCodeAsync(CharacterPlayerModels.ServerGetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetCountryCodeOperationRequest, CharacterPlayerResponseModels.GetCountryCodeOperationResponse>(new CharacterPlayerRequestModels.ServerGetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCustomData(CharacterPlayerModels.ServerGetCustomDataRequestData requestData, Action1<CharacterPlayerResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetCustomDataOperationResponse> getCustomDataAsync(CharacterPlayerModels.ServerGetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetCustomDataOperationRequest, CharacterPlayerResponseModels.GetCustomDataOperationResponse>(new CharacterPlayerRequestModels.ServerGetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getDisplayName(CharacterPlayerModels.ServerGetDisplayNameRequestData requestData, Action1<CharacterPlayerResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetDisplayNameOperationResponse> getDisplayNameAsync(CharacterPlayerModels.ServerGetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetDisplayNameOperationRequest, CharacterPlayerResponseModels.GetDisplayNameOperationResponse>(new CharacterPlayerRequestModels.ServerGetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getFriendStatisticsLeaderboardAroundPlayer(CharacterPlayerModels.ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, Action1<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> getFriendStatisticsLeaderboardAroundPlayerAsync(CharacterPlayerModels.ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest, CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse>(new CharacterPlayerRequestModels.ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getFriendStatisticsLeaderboard(CharacterPlayerModels.ServerGetFriendStatisticsLeaderboardRequestData requestData, Action1<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> getFriendStatisticsLeaderboardAsync(CharacterPlayerModels.ServerGetFriendStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetFriendStatisticsLeaderboardOperationRequest, CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse>(new CharacterPlayerRequestModels.ServerGetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getIpAddressCreate(CharacterPlayerModels.ServerGetIpAddressCreateRequestData requestData, Action1<CharacterPlayerResponseModels.GetIpAddressCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetIpAddressCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetIpAddressCreateOperationResponse> getIpAddressCreateAsync(CharacterPlayerModels.ServerGetIpAddressCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetIpAddressCreateOperationRequest, CharacterPlayerResponseModels.GetIpAddressCreateOperationResponse>(new CharacterPlayerRequestModels.ServerGetIpAddressCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getOwner(CharacterPlayerModels.ServerGetOwnerRequestData requestData, Action1<CharacterPlayerResponseModels.GetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetOwnerOperationResponse> getOwnerAsync(CharacterPlayerModels.ServerGetOwnerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetOwnerOperationRequest, CharacterPlayerResponseModels.GetOwnerOperationResponse>(new CharacterPlayerRequestModels.ServerGetOwnerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerBan(CharacterPlayerModels.ServerGetPlayerBanRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayerBanOperationResponse> getPlayerBanAsync(CharacterPlayerModels.ServerGetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetPlayerBanOperationRequest, CharacterPlayerResponseModels.GetPlayerBanOperationResponse>(new CharacterPlayerRequestModels.ServerGetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerCurrency(CharacterPlayerModels.ServerGetPlayerCurrencyRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayerCurrencyOperationResponse> getPlayerCurrencyAsync(CharacterPlayerModels.ServerGetPlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetPlayerCurrencyOperationRequest, CharacterPlayerResponseModels.GetPlayerCurrencyOperationResponse>(new CharacterPlayerRequestModels.ServerGetPlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerData(CharacterPlayerModels.ServerGetPlayerDataRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayerDataOperationResponse> getPlayerDataAsync(CharacterPlayerModels.ServerGetPlayerDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetPlayerDataOperationRequest, CharacterPlayerResponseModels.GetPlayerDataOperationResponse>(new CharacterPlayerRequestModels.ServerGetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerFriend(CharacterPlayerModels.ServerGetPlayerFriendRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayerFriendOperationResponse> getPlayerFriendAsync(CharacterPlayerModels.ServerGetPlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetPlayerFriendOperationRequest, CharacterPlayerResponseModels.GetPlayerFriendOperationResponse>(new CharacterPlayerRequestModels.ServerGetPlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerGroup(CharacterPlayerModels.ServerGetPlayerGroupRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayerGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayerGroupOperationResponse> getPlayerGroupAsync(CharacterPlayerModels.ServerGetPlayerGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetPlayerGroupOperationRequest, CharacterPlayerResponseModels.GetPlayerGroupOperationResponse>(new CharacterPlayerRequestModels.ServerGetPlayerGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerInformation(CharacterPlayerModels.ServerGetPlayerInformationRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayerInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayerInformationOperationResponse> getPlayerInformationAsync(CharacterPlayerModels.ServerGetPlayerInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetPlayerInformationOperationRequest, CharacterPlayerResponseModels.GetPlayerInformationOperationResponse>(new CharacterPlayerRequestModels.ServerGetPlayerInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerInventory(CharacterPlayerModels.ServerGetPlayerInventoryRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerInventoryOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayerInventoryOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayerInventoryOperationResponse> getPlayerInventoryAsync(CharacterPlayerModels.ServerGetPlayerInventoryRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetPlayerInventoryOperationRequest, CharacterPlayerResponseModels.GetPlayerInventoryOperationResponse>(new CharacterPlayerRequestModels.ServerGetPlayerInventoryOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerStatistics(CharacterPlayerModels.ServerGetPlayerStatisticsRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayerStatisticsOperationResponse> getPlayerStatisticsAsync(CharacterPlayerModels.ServerGetPlayerStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetPlayerStatisticsOperationRequest, CharacterPlayerResponseModels.GetPlayerStatisticsOperationResponse>(new CharacterPlayerRequestModels.ServerGetPlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithDisplayName(CharacterPlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayersWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> getPlayersWithDisplayNameAsync(CharacterPlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetPlayersWithDisplayNameOperationRequest, CharacterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse>(new CharacterPlayerRequestModels.ServerGetPlayersWithDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithSegment(CharacterPlayerModels.ServerGetPlayersWithSegmentRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayersWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> getPlayersWithSegmentAsync(CharacterPlayerModels.ServerGetPlayersWithSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetPlayersWithSegmentOperationRequest, CharacterPlayerResponseModels.GetPlayersWithSegmentOperationResponse>(new CharacterPlayerRequestModels.ServerGetPlayersWithSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithTag(CharacterPlayerModels.ServerGetPlayersWithTagRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayersWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayersWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayersWithTagOperationResponse> getPlayersWithTagAsync(CharacterPlayerModels.ServerGetPlayersWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetPlayersWithTagOperationRequest, CharacterPlayerResponseModels.GetPlayersWithTagOperationResponse>(new CharacterPlayerRequestModels.ServerGetPlayersWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getRemoveStatus(CharacterPlayerModels.ServerGetRemoveStatusRequestData requestData, Action1<CharacterPlayerResponseModels.GetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetRemoveStatusOperationResponse> getRemoveStatusAsync(CharacterPlayerModels.ServerGetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetRemoveStatusOperationRequest, CharacterPlayerResponseModels.GetRemoveStatusOperationResponse>(new CharacterPlayerRequestModels.ServerGetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getSegment(CharacterPlayerModels.ServerGetSegmentRequestData requestData, Action1<CharacterPlayerResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetSegmentOperationResponse> getSegmentAsync(CharacterPlayerModels.ServerGetSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetSegmentOperationRequest, CharacterPlayerResponseModels.GetSegmentOperationResponse>(new CharacterPlayerRequestModels.ServerGetSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboardAroundPlayer(CharacterPlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, Action1<CharacterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> getStatisticsLeaderboardAroundPlayerAsync(CharacterPlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetStatisticsLeaderboardAroundPlayerOperationRequest, CharacterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse>(new CharacterPlayerRequestModels.ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboard(CharacterPlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, Action1<CharacterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> getStatisticsLeaderboardAsync(CharacterPlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetStatisticsLeaderboardOperationRequest, CharacterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse>(new CharacterPlayerRequestModels.ServerGetStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTag(CharacterPlayerModels.ServerGetTagRequestData requestData, Action1<CharacterPlayerResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetTagOperationResponse> getTagAsync(CharacterPlayerModels.ServerGetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetTagOperationRequest, CharacterPlayerResponseModels.GetTagOperationResponse>(new CharacterPlayerRequestModels.ServerGetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTsCreate(CharacterPlayerModels.ServerGetTsCreateRequestData requestData, Action1<CharacterPlayerResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetTsCreateOperationResponse> getTsCreateAsync(CharacterPlayerModels.ServerGetTsCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetTsCreateOperationRequest, CharacterPlayerResponseModels.GetTsCreateOperationResponse>(new CharacterPlayerRequestModels.ServerGetTsCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTsLastLogin(CharacterPlayerModels.ServerGetTsLastLoginRequestData requestData, Action1<CharacterPlayerResponseModels.GetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetTsLastLoginOperationResponse> getTsLastLoginAsync(CharacterPlayerModels.ServerGetTsLastLoginRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetTsLastLoginOperationRequest, CharacterPlayerResponseModels.GetTsLastLoginOperationResponse>(new CharacterPlayerRequestModels.ServerGetTsLastLoginOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void createGroup(CharacterPlayerModels.ServerCreateGroupRequestData requestData, Action1<CharacterPlayerResponseModels.CreateGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerCreateGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.CreateGroupOperationResponse> createGroupAsync(CharacterPlayerModels.ServerCreateGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerCreateGroupOperationRequest, CharacterPlayerResponseModels.CreateGroupOperationResponse>(new CharacterPlayerRequestModels.ServerCreateGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void createPlayerItem(CharacterPlayerModels.ServerCreatePlayerItemRequestData requestData, Action1<CharacterPlayerResponseModels.CreatePlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerCreatePlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.CreatePlayerItemOperationResponse> createPlayerItemAsync(CharacterPlayerModels.ServerCreatePlayerItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerCreatePlayerItemOperationRequest, CharacterPlayerResponseModels.CreatePlayerItemOperationResponse>(new CharacterPlayerRequestModels.ServerCreatePlayerItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void joinGroup(CharacterPlayerModels.ServerJoinGroupRequestData requestData, Action1<CharacterPlayerResponseModels.JoinGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerJoinGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.JoinGroupOperationResponse> joinGroupAsync(CharacterPlayerModels.ServerJoinGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerJoinGroupOperationRequest, CharacterPlayerResponseModels.JoinGroupOperationResponse>(new CharacterPlayerRequestModels.ServerJoinGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void leaveGroup(CharacterPlayerModels.ServerLeaveGroupRequestData requestData, Action1<CharacterPlayerResponseModels.LeaveGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerLeaveGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.LeaveGroupOperationResponse> leaveGroupAsync(CharacterPlayerModels.ServerLeaveGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerLeaveGroupOperationRequest, CharacterPlayerResponseModels.LeaveGroupOperationResponse>(new CharacterPlayerRequestModels.ServerLeaveGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removePlayerFriend(CharacterPlayerModels.ServerRemovePlayerFriendRequestData requestData, Action1<CharacterPlayerResponseModels.RemovePlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerRemovePlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.RemovePlayerFriendOperationResponse> removePlayerFriendAsync(CharacterPlayerModels.ServerRemovePlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerRemovePlayerFriendOperationRequest, CharacterPlayerResponseModels.RemovePlayerFriendOperationResponse>(new CharacterPlayerRequestModels.ServerRemovePlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removePlayerItem(CharacterPlayerModels.ServerRemovePlayerItemRequestData requestData, Action1<CharacterPlayerResponseModels.RemovePlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerRemovePlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.RemovePlayerItemOperationResponse> removePlayerItemAsync(CharacterPlayerModels.ServerRemovePlayerItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerRemovePlayerItemOperationRequest, CharacterPlayerResponseModels.RemovePlayerItemOperationResponse>(new CharacterPlayerRequestModels.ServerRemovePlayerItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeSegment(CharacterPlayerModels.ServerRemoveSegmentRequestData requestData, Action1<CharacterPlayerResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerRemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.RemoveSegmentOperationResponse> removeSegmentAsync(CharacterPlayerModels.ServerRemoveSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerRemoveSegmentOperationRequest, CharacterPlayerResponseModels.RemoveSegmentOperationResponse>(new CharacterPlayerRequestModels.ServerRemoveSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeTag(CharacterPlayerModels.ServerRemoveTagRequestData requestData, Action1<CharacterPlayerResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerRemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.RemoveTagOperationResponse> removeTagAsync(CharacterPlayerModels.ServerRemoveTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerRemoveTagOperationRequest, CharacterPlayerResponseModels.RemoveTagOperationResponse>(new CharacterPlayerRequestModels.ServerRemoveTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setAvatar(CharacterPlayerModels.ServerSetAvatarRequestData requestData, Action1<CharacterPlayerResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.SetAvatarOperationResponse> setAvatarAsync(CharacterPlayerModels.ServerSetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerSetAvatarOperationRequest, CharacterPlayerResponseModels.SetAvatarOperationResponse>(new CharacterPlayerRequestModels.ServerSetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setCountryCode(CharacterPlayerModels.ServerSetCountryCodeRequestData requestData, Action1<CharacterPlayerResponseModels.SetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.SetCountryCodeOperationResponse> setCountryCodeAsync(CharacterPlayerModels.ServerSetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerSetCountryCodeOperationRequest, CharacterPlayerResponseModels.SetCountryCodeOperationResponse>(new CharacterPlayerRequestModels.ServerSetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setCustomData(CharacterPlayerModels.ServerSetCustomDataRequestData requestData, Action1<CharacterPlayerResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.SetCustomDataOperationResponse> setCustomDataAsync(CharacterPlayerModels.ServerSetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerSetCustomDataOperationRequest, CharacterPlayerResponseModels.SetCustomDataOperationResponse>(new CharacterPlayerRequestModels.ServerSetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setDisplayName(CharacterPlayerModels.ServerSetDisplayNameRequestData requestData, Action1<CharacterPlayerResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.SetDisplayNameOperationResponse> setDisplayNameAsync(CharacterPlayerModels.ServerSetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerSetDisplayNameOperationRequest, CharacterPlayerResponseModels.SetDisplayNameOperationResponse>(new CharacterPlayerRequestModels.ServerSetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setOwner(CharacterPlayerModels.ServerSetOwnerRequestData requestData, Action1<CharacterPlayerResponseModels.SetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.SetOwnerOperationResponse> setOwnerAsync(CharacterPlayerModels.ServerSetOwnerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerSetOwnerOperationRequest, CharacterPlayerResponseModels.SetOwnerOperationResponse>(new CharacterPlayerRequestModels.ServerSetOwnerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setPlayerBan(CharacterPlayerModels.ServerSetPlayerBanRequestData requestData, Action1<CharacterPlayerResponseModels.SetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.SetPlayerBanOperationResponse> setPlayerBanAsync(CharacterPlayerModels.ServerSetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerSetPlayerBanOperationRequest, CharacterPlayerResponseModels.SetPlayerBanOperationResponse>(new CharacterPlayerRequestModels.ServerSetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changePlayerCurrency(CharacterPlayerModels.ServerChangePlayerCurrencyRequestData requestData, Action1<CharacterPlayerResponseModels.ChangePlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerChangePlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.ChangePlayerCurrencyOperationResponse> changePlayerCurrencyAsync(CharacterPlayerModels.ServerChangePlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerChangePlayerCurrencyOperationRequest, CharacterPlayerResponseModels.ChangePlayerCurrencyOperationResponse>(new CharacterPlayerRequestModels.ServerChangePlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }
            public void setPlayerData(CharacterPlayerModels.ServerSetPlayerDataRequestData requestData, Action1<CharacterPlayerResponseModels.SetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.SetPlayerDataOperationResponse> setPlayerDataAsync(CharacterPlayerModels.ServerSetPlayerDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerSetPlayerDataOperationRequest, CharacterPlayerResponseModels.SetPlayerDataOperationResponse>(new CharacterPlayerRequestModels.ServerSetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changePlayerStatistics(CharacterPlayerModels.ServerChangePlayerStatisticsRequestData requestData, Action1<CharacterPlayerResponseModels.ChangePlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerChangePlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.ChangePlayerStatisticsOperationResponse> changePlayerStatisticsAsync(CharacterPlayerModels.ServerChangePlayerStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerChangePlayerStatisticsOperationRequest, CharacterPlayerResponseModels.ChangePlayerStatisticsOperationResponse>(new CharacterPlayerRequestModels.ServerChangePlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setRemoveStatus(CharacterPlayerModels.ServerSetRemoveStatusRequestData requestData, Action1<CharacterPlayerResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.SetRemoveStatusOperationResponse> setRemoveStatusAsync(CharacterPlayerModels.ServerSetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerSetRemoveStatusOperationRequest, CharacterPlayerResponseModels.SetRemoveStatusOperationResponse>(new CharacterPlayerRequestModels.ServerSetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setTag(CharacterPlayerModels.ServerSetTagRequestData requestData, Action1<CharacterPlayerResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.SetTagOperationResponse> setTagAsync(CharacterPlayerModels.ServerSetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerSetTagOperationRequest, CharacterPlayerResponseModels.SetTagOperationResponse>(new CharacterPlayerRequestModels.ServerSetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCurrencyLeaderboard(CharacterPlayerModels.ServerGetCurrencyLeaderboardRequestData requestData, Action1<CharacterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetCurrencyLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse> getCurrencyLeaderboardAsync(CharacterPlayerModels.ServerGetCurrencyLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetCurrencyLeaderboardOperationRequest, CharacterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse>(new CharacterPlayerRequestModels.ServerGetCurrencyLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCreateLeaderboard(CharacterPlayerModels.ServerGetCreateLeaderboardRequestData requestData, Action1<CharacterPlayerResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(CharacterPlayerModels.ServerGetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetCreateLeaderboardOperationRequest, CharacterPlayerResponseModels.GetCreateLeaderboardOperationResponse>(new CharacterPlayerRequestModels.ServerGetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getLastLoginLeaderboard(CharacterPlayerModels.ServerGetLastLoginLeaderboardRequestData requestData, Action1<CharacterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetLastLoginLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse> getLastLoginLeaderboardAsync(CharacterPlayerModels.ServerGetLastLoginLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetLastLoginLeaderboardOperationRequest, CharacterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse>(new CharacterPlayerRequestModels.ServerGetLastLoginLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLog(CharacterPlayerModels.ServerGetStatisticsLogRequestData requestData, Action1<CharacterPlayerResponseModels.GetStatisticsLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetStatisticsLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetStatisticsLogOperationResponse> getStatisticsLogAsync(CharacterPlayerModels.ServerGetStatisticsLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetStatisticsLogOperationRequest, CharacterPlayerResponseModels.GetStatisticsLogOperationResponse>(new CharacterPlayerRequestModels.ServerGetStatisticsLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCurrencyLog(CharacterPlayerModels.ServerGetCurrencyLogRequestData requestData, Action1<CharacterPlayerResponseModels.GetCurrencyLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetCurrencyLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetCurrencyLogOperationResponse> getCurrencyLogAsync(CharacterPlayerModels.ServerGetCurrencyLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.ServerGetCurrencyLogOperationRequest, CharacterPlayerResponseModels.GetCurrencyLogOperationResponse>(new CharacterPlayerRequestModels.ServerGetCurrencyLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

        public class AdminApi
        {
            public void addPlayerFriend(CharacterPlayerModels.AdminAddPlayerFriendRequestData requestData, Action1<CharacterPlayerResponseModels.AddPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminAddPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.AddPlayerFriendOperationResponse> addPlayerFriendAsync(CharacterPlayerModels.AdminAddPlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminAddPlayerFriendOperationRequest, CharacterPlayerResponseModels.AddPlayerFriendOperationResponse>(new CharacterPlayerRequestModels.AdminAddPlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void addSegment(CharacterPlayerModels.AdminAddSegmentRequestData requestData, Action1<CharacterPlayerResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminAddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.AddSegmentOperationResponse> addSegmentAsync(CharacterPlayerModels.AdminAddSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminAddSegmentOperationRequest, CharacterPlayerResponseModels.AddSegmentOperationResponse>(new CharacterPlayerRequestModels.AdminAddSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getAvatar(CharacterPlayerModels.AdminGetAvatarRequestData requestData, Action1<CharacterPlayerResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetAvatarOperationResponse> getAvatarAsync(CharacterPlayerModels.AdminGetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetAvatarOperationRequest, CharacterPlayerResponseModels.GetAvatarOperationResponse>(new CharacterPlayerRequestModels.AdminGetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCatalogId(CharacterPlayerModels.AdminGetCatalogIdRequestData requestData, Action1<CharacterPlayerResponseModels.GetCatalogIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetCatalogIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetCatalogIdOperationResponse> getCatalogIdAsync(CharacterPlayerModels.AdminGetCatalogIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetCatalogIdOperationRequest, CharacterPlayerResponseModels.GetCatalogIdOperationResponse>(new CharacterPlayerRequestModels.AdminGetCatalogIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCountryCode(CharacterPlayerModels.AdminGetCountryCodeRequestData requestData, Action1<CharacterPlayerResponseModels.GetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetCountryCodeOperationResponse> getCountryCodeAsync(CharacterPlayerModels.AdminGetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetCountryCodeOperationRequest, CharacterPlayerResponseModels.GetCountryCodeOperationResponse>(new CharacterPlayerRequestModels.AdminGetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCustomData(CharacterPlayerModels.AdminGetCustomDataRequestData requestData, Action1<CharacterPlayerResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetCustomDataOperationResponse> getCustomDataAsync(CharacterPlayerModels.AdminGetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetCustomDataOperationRequest, CharacterPlayerResponseModels.GetCustomDataOperationResponse>(new CharacterPlayerRequestModels.AdminGetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getDisplayName(CharacterPlayerModels.AdminGetDisplayNameRequestData requestData, Action1<CharacterPlayerResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetDisplayNameOperationResponse> getDisplayNameAsync(CharacterPlayerModels.AdminGetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetDisplayNameOperationRequest, CharacterPlayerResponseModels.GetDisplayNameOperationResponse>(new CharacterPlayerRequestModels.AdminGetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getFriendStatisticsLeaderboardAroundPlayer(CharacterPlayerModels.AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, Action1<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> getFriendStatisticsLeaderboardAroundPlayerAsync(CharacterPlayerModels.AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest, CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse>(new CharacterPlayerRequestModels.AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getFriendStatisticsLeaderboard(CharacterPlayerModels.AdminGetFriendStatisticsLeaderboardRequestData requestData, Action1<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> getFriendStatisticsLeaderboardAsync(CharacterPlayerModels.AdminGetFriendStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetFriendStatisticsLeaderboardOperationRequest, CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse>(new CharacterPlayerRequestModels.AdminGetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getIpAddressCreate(CharacterPlayerModels.AdminGetIpAddressCreateRequestData requestData, Action1<CharacterPlayerResponseModels.GetIpAddressCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetIpAddressCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetIpAddressCreateOperationResponse> getIpAddressCreateAsync(CharacterPlayerModels.AdminGetIpAddressCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetIpAddressCreateOperationRequest, CharacterPlayerResponseModels.GetIpAddressCreateOperationResponse>(new CharacterPlayerRequestModels.AdminGetIpAddressCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getOwner(CharacterPlayerModels.AdminGetOwnerRequestData requestData, Action1<CharacterPlayerResponseModels.GetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetOwnerOperationResponse> getOwnerAsync(CharacterPlayerModels.AdminGetOwnerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetOwnerOperationRequest, CharacterPlayerResponseModels.GetOwnerOperationResponse>(new CharacterPlayerRequestModels.AdminGetOwnerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerBan(CharacterPlayerModels.AdminGetPlayerBanRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayerBanOperationResponse> getPlayerBanAsync(CharacterPlayerModels.AdminGetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetPlayerBanOperationRequest, CharacterPlayerResponseModels.GetPlayerBanOperationResponse>(new CharacterPlayerRequestModels.AdminGetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerCurrency(CharacterPlayerModels.AdminGetPlayerCurrencyRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayerCurrencyOperationResponse> getPlayerCurrencyAsync(CharacterPlayerModels.AdminGetPlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetPlayerCurrencyOperationRequest, CharacterPlayerResponseModels.GetPlayerCurrencyOperationResponse>(new CharacterPlayerRequestModels.AdminGetPlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerData(CharacterPlayerModels.AdminGetPlayerDataRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayerDataOperationResponse> getPlayerDataAsync(CharacterPlayerModels.AdminGetPlayerDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetPlayerDataOperationRequest, CharacterPlayerResponseModels.GetPlayerDataOperationResponse>(new CharacterPlayerRequestModels.AdminGetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerFriend(CharacterPlayerModels.AdminGetPlayerFriendRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayerFriendOperationResponse> getPlayerFriendAsync(CharacterPlayerModels.AdminGetPlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetPlayerFriendOperationRequest, CharacterPlayerResponseModels.GetPlayerFriendOperationResponse>(new CharacterPlayerRequestModels.AdminGetPlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerGroup(CharacterPlayerModels.AdminGetPlayerGroupRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayerGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayerGroupOperationResponse> getPlayerGroupAsync(CharacterPlayerModels.AdminGetPlayerGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetPlayerGroupOperationRequest, CharacterPlayerResponseModels.GetPlayerGroupOperationResponse>(new CharacterPlayerRequestModels.AdminGetPlayerGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerInformation(CharacterPlayerModels.AdminGetPlayerInformationRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayerInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayerInformationOperationResponse> getPlayerInformationAsync(CharacterPlayerModels.AdminGetPlayerInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetPlayerInformationOperationRequest, CharacterPlayerResponseModels.GetPlayerInformationOperationResponse>(new CharacterPlayerRequestModels.AdminGetPlayerInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerInventory(CharacterPlayerModels.AdminGetPlayerInventoryRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerInventoryOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayerInventoryOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayerInventoryOperationResponse> getPlayerInventoryAsync(CharacterPlayerModels.AdminGetPlayerInventoryRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetPlayerInventoryOperationRequest, CharacterPlayerResponseModels.GetPlayerInventoryOperationResponse>(new CharacterPlayerRequestModels.AdminGetPlayerInventoryOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerStatistics(CharacterPlayerModels.AdminGetPlayerStatisticsRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayerStatisticsOperationResponse> getPlayerStatisticsAsync(CharacterPlayerModels.AdminGetPlayerStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetPlayerStatisticsOperationRequest, CharacterPlayerResponseModels.GetPlayerStatisticsOperationResponse>(new CharacterPlayerRequestModels.AdminGetPlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithDisplayName(CharacterPlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayersWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> getPlayersWithDisplayNameAsync(CharacterPlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetPlayersWithDisplayNameOperationRequest, CharacterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse>(new CharacterPlayerRequestModels.AdminGetPlayersWithDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithSegment(CharacterPlayerModels.AdminGetPlayersWithSegmentRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayersWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> getPlayersWithSegmentAsync(CharacterPlayerModels.AdminGetPlayersWithSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetPlayersWithSegmentOperationRequest, CharacterPlayerResponseModels.GetPlayersWithSegmentOperationResponse>(new CharacterPlayerRequestModels.AdminGetPlayersWithSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithTag(CharacterPlayerModels.AdminGetPlayersWithTagRequestData requestData, Action1<CharacterPlayerResponseModels.GetPlayersWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayersWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetPlayersWithTagOperationResponse> getPlayersWithTagAsync(CharacterPlayerModels.AdminGetPlayersWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetPlayersWithTagOperationRequest, CharacterPlayerResponseModels.GetPlayersWithTagOperationResponse>(new CharacterPlayerRequestModels.AdminGetPlayersWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getRemoveStatus(CharacterPlayerModels.AdminGetRemoveStatusRequestData requestData, Action1<CharacterPlayerResponseModels.GetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetRemoveStatusOperationResponse> getRemoveStatusAsync(CharacterPlayerModels.AdminGetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetRemoveStatusOperationRequest, CharacterPlayerResponseModels.GetRemoveStatusOperationResponse>(new CharacterPlayerRequestModels.AdminGetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getSegment(CharacterPlayerModels.AdminGetSegmentRequestData requestData, Action1<CharacterPlayerResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetSegmentOperationResponse> getSegmentAsync(CharacterPlayerModels.AdminGetSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetSegmentOperationRequest, CharacterPlayerResponseModels.GetSegmentOperationResponse>(new CharacterPlayerRequestModels.AdminGetSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboardAroundPlayer(CharacterPlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, Action1<CharacterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> getStatisticsLeaderboardAroundPlayerAsync(CharacterPlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetStatisticsLeaderboardAroundPlayerOperationRequest, CharacterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse>(new CharacterPlayerRequestModels.AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboard(CharacterPlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, Action1<CharacterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> getStatisticsLeaderboardAsync(CharacterPlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetStatisticsLeaderboardOperationRequest, CharacterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse>(new CharacterPlayerRequestModels.AdminGetStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTag(CharacterPlayerModels.AdminGetTagRequestData requestData, Action1<CharacterPlayerResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetTagOperationResponse> getTagAsync(CharacterPlayerModels.AdminGetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetTagOperationRequest, CharacterPlayerResponseModels.GetTagOperationResponse>(new CharacterPlayerRequestModels.AdminGetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTsCreate(CharacterPlayerModels.AdminGetTsCreateRequestData requestData, Action1<CharacterPlayerResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetTsCreateOperationResponse> getTsCreateAsync(CharacterPlayerModels.AdminGetTsCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetTsCreateOperationRequest, CharacterPlayerResponseModels.GetTsCreateOperationResponse>(new CharacterPlayerRequestModels.AdminGetTsCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTsLastLogin(CharacterPlayerModels.AdminGetTsLastLoginRequestData requestData, Action1<CharacterPlayerResponseModels.GetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetTsLastLoginOperationResponse> getTsLastLoginAsync(CharacterPlayerModels.AdminGetTsLastLoginRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetTsLastLoginOperationRequest, CharacterPlayerResponseModels.GetTsLastLoginOperationResponse>(new CharacterPlayerRequestModels.AdminGetTsLastLoginOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void createGroup(CharacterPlayerModels.AdminCreateGroupRequestData requestData, Action1<CharacterPlayerResponseModels.CreateGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminCreateGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.CreateGroupOperationResponse> createGroupAsync(CharacterPlayerModels.AdminCreateGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminCreateGroupOperationRequest, CharacterPlayerResponseModels.CreateGroupOperationResponse>(new CharacterPlayerRequestModels.AdminCreateGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void createPlayerItem(CharacterPlayerModels.AdminCreatePlayerItemRequestData requestData, Action1<CharacterPlayerResponseModels.CreatePlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminCreatePlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.CreatePlayerItemOperationResponse> createPlayerItemAsync(CharacterPlayerModels.AdminCreatePlayerItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminCreatePlayerItemOperationRequest, CharacterPlayerResponseModels.CreatePlayerItemOperationResponse>(new CharacterPlayerRequestModels.AdminCreatePlayerItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void joinGroup(CharacterPlayerModels.AdminJoinGroupRequestData requestData, Action1<CharacterPlayerResponseModels.JoinGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminJoinGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.JoinGroupOperationResponse> joinGroupAsync(CharacterPlayerModels.AdminJoinGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminJoinGroupOperationRequest, CharacterPlayerResponseModels.JoinGroupOperationResponse>(new CharacterPlayerRequestModels.AdminJoinGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void leaveGroup(CharacterPlayerModels.AdminLeaveGroupRequestData requestData, Action1<CharacterPlayerResponseModels.LeaveGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminLeaveGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.LeaveGroupOperationResponse> leaveGroupAsync(CharacterPlayerModels.AdminLeaveGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminLeaveGroupOperationRequest, CharacterPlayerResponseModels.LeaveGroupOperationResponse>(new CharacterPlayerRequestModels.AdminLeaveGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removePlayerFriend(CharacterPlayerModels.AdminRemovePlayerFriendRequestData requestData, Action1<CharacterPlayerResponseModels.RemovePlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminRemovePlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.RemovePlayerFriendOperationResponse> removePlayerFriendAsync(CharacterPlayerModels.AdminRemovePlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminRemovePlayerFriendOperationRequest, CharacterPlayerResponseModels.RemovePlayerFriendOperationResponse>(new CharacterPlayerRequestModels.AdminRemovePlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removePlayerItem(CharacterPlayerModels.AdminRemovePlayerItemRequestData requestData, Action1<CharacterPlayerResponseModels.RemovePlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminRemovePlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.RemovePlayerItemOperationResponse> removePlayerItemAsync(CharacterPlayerModels.AdminRemovePlayerItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminRemovePlayerItemOperationRequest, CharacterPlayerResponseModels.RemovePlayerItemOperationResponse>(new CharacterPlayerRequestModels.AdminRemovePlayerItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeSegment(CharacterPlayerModels.AdminRemoveSegmentRequestData requestData, Action1<CharacterPlayerResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminRemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.RemoveSegmentOperationResponse> removeSegmentAsync(CharacterPlayerModels.AdminRemoveSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminRemoveSegmentOperationRequest, CharacterPlayerResponseModels.RemoveSegmentOperationResponse>(new CharacterPlayerRequestModels.AdminRemoveSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeTag(CharacterPlayerModels.AdminRemoveTagRequestData requestData, Action1<CharacterPlayerResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminRemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.RemoveTagOperationResponse> removeTagAsync(CharacterPlayerModels.AdminRemoveTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminRemoveTagOperationRequest, CharacterPlayerResponseModels.RemoveTagOperationResponse>(new CharacterPlayerRequestModels.AdminRemoveTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setAvatar(CharacterPlayerModels.AdminSetAvatarRequestData requestData, Action1<CharacterPlayerResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.SetAvatarOperationResponse> setAvatarAsync(CharacterPlayerModels.AdminSetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminSetAvatarOperationRequest, CharacterPlayerResponseModels.SetAvatarOperationResponse>(new CharacterPlayerRequestModels.AdminSetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setCountryCode(CharacterPlayerModels.AdminSetCountryCodeRequestData requestData, Action1<CharacterPlayerResponseModels.SetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.SetCountryCodeOperationResponse> setCountryCodeAsync(CharacterPlayerModels.AdminSetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminSetCountryCodeOperationRequest, CharacterPlayerResponseModels.SetCountryCodeOperationResponse>(new CharacterPlayerRequestModels.AdminSetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setCustomData(CharacterPlayerModels.AdminSetCustomDataRequestData requestData, Action1<CharacterPlayerResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.SetCustomDataOperationResponse> setCustomDataAsync(CharacterPlayerModels.AdminSetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminSetCustomDataOperationRequest, CharacterPlayerResponseModels.SetCustomDataOperationResponse>(new CharacterPlayerRequestModels.AdminSetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setDisplayName(CharacterPlayerModels.AdminSetDisplayNameRequestData requestData, Action1<CharacterPlayerResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.SetDisplayNameOperationResponse> setDisplayNameAsync(CharacterPlayerModels.AdminSetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminSetDisplayNameOperationRequest, CharacterPlayerResponseModels.SetDisplayNameOperationResponse>(new CharacterPlayerRequestModels.AdminSetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setOwner(CharacterPlayerModels.AdminSetOwnerRequestData requestData, Action1<CharacterPlayerResponseModels.SetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.SetOwnerOperationResponse> setOwnerAsync(CharacterPlayerModels.AdminSetOwnerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminSetOwnerOperationRequest, CharacterPlayerResponseModels.SetOwnerOperationResponse>(new CharacterPlayerRequestModels.AdminSetOwnerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setPlayerBan(CharacterPlayerModels.AdminSetPlayerBanRequestData requestData, Action1<CharacterPlayerResponseModels.SetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.SetPlayerBanOperationResponse> setPlayerBanAsync(CharacterPlayerModels.AdminSetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminSetPlayerBanOperationRequest, CharacterPlayerResponseModels.SetPlayerBanOperationResponse>(new CharacterPlayerRequestModels.AdminSetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changePlayerCurrency(CharacterPlayerModels.AdminChangePlayerCurrencyRequestData requestData, Action1<CharacterPlayerResponseModels.ChangePlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminChangePlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.ChangePlayerCurrencyOperationResponse> changePlayerCurrencyAsync(CharacterPlayerModels.AdminChangePlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminChangePlayerCurrencyOperationRequest, CharacterPlayerResponseModels.ChangePlayerCurrencyOperationResponse>(new CharacterPlayerRequestModels.AdminChangePlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setPlayerData(CharacterPlayerModels.AdminSetPlayerDataRequestData requestData, Action1<CharacterPlayerResponseModels.SetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task setPlayerDataAsync(CharacterPlayerModels.AdminSetPlayerDataRequestData requestData, Action1<CharacterPlayerResponseModels.SetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminSetPlayerDataOperationRequest, CharacterPlayerResponseModels.SetPlayerDataOperationResponse>(new CharacterPlayerRequestModels.AdminSetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changePlayerStatistics(CharacterPlayerModels.AdminChangePlayerStatisticsRequestData requestData, Action1<CharacterPlayerResponseModels.ChangePlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminChangePlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task changePlayerStatisticsAsync(CharacterPlayerModels.AdminChangePlayerStatisticsRequestData requestData, Action1<CharacterPlayerResponseModels.ChangePlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminChangePlayerStatisticsOperationRequest, CharacterPlayerResponseModels.ChangePlayerStatisticsOperationResponse>(new CharacterPlayerRequestModels.AdminChangePlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setRemoveStatus(CharacterPlayerModels.AdminSetRemoveStatusRequestData requestData, Action1<CharacterPlayerResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task setRemoveStatusAsync(CharacterPlayerModels.AdminSetRemoveStatusRequestData requestData, Action1<CharacterPlayerResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminSetRemoveStatusOperationRequest, CharacterPlayerResponseModels.SetRemoveStatusOperationResponse>(new CharacterPlayerRequestModels.AdminSetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setTag(CharacterPlayerModels.AdminSetTagRequestData requestData, Action1<CharacterPlayerResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task setTagAsync(CharacterPlayerModels.AdminSetTagRequestData requestData, Action1<CharacterPlayerResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminSetTagOperationRequest, CharacterPlayerResponseModels.SetTagOperationResponse>(new CharacterPlayerRequestModels.AdminSetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCurrencyLeaderboard(CharacterPlayerModels.AdminGetCurrencyLeaderboardRequestData requestData, Action1<CharacterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetCurrencyLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task getCurrencyLeaderboardAsync(CharacterPlayerModels.AdminGetCurrencyLeaderboardRequestData requestData, Action1<CharacterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetCurrencyLeaderboardOperationRequest, CharacterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse>(new CharacterPlayerRequestModels.AdminGetCurrencyLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCreateLeaderboard(CharacterPlayerModels.AdminGetCreateLeaderboardRequestData requestData, Action1<CharacterPlayerResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(CharacterPlayerModels.AdminGetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetCreateLeaderboardOperationRequest, CharacterPlayerResponseModels.GetCreateLeaderboardOperationResponse>(new CharacterPlayerRequestModels.AdminGetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getLastLoginLeaderboard(CharacterPlayerModels.AdminGetLastLoginLeaderboardRequestData requestData, Action1<CharacterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetLastLoginLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse> getLastLoginLeaderboardAsync(CharacterPlayerModels.AdminGetLastLoginLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetLastLoginLeaderboardOperationRequest, CharacterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse>(new CharacterPlayerRequestModels.AdminGetLastLoginLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLog(CharacterPlayerModels.AdminGetStatisticsLogRequestData requestData, Action1<CharacterPlayerResponseModels.GetStatisticsLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetStatisticsLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetStatisticsLogOperationResponse> getStatisticsLogAsync(CharacterPlayerModels.AdminGetStatisticsLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetStatisticsLogOperationRequest, CharacterPlayerResponseModels.GetStatisticsLogOperationResponse>(new CharacterPlayerRequestModels.AdminGetStatisticsLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCurrencyLog(CharacterPlayerModels.AdminGetCurrencyLogRequestData requestData, Action1<CharacterPlayerResponseModels.GetCurrencyLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetCurrencyLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CharacterPlayerResponseModels.GetCurrencyLogOperationResponse> getCurrencyLogAsync(CharacterPlayerModels.AdminGetCurrencyLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CharacterPlayerRequestModels.AdminGetCurrencyLogOperationRequest, CharacterPlayerResponseModels.GetCurrencyLogOperationResponse>(new CharacterPlayerRequestModels.AdminGetCurrencyLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

    }

    public static partial class GNNetwork
    {

        public static CharacterPlayerApi characterPlayer { get; }
    }

}
