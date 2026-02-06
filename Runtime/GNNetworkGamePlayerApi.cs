namespace XmobiTea.GearN
{
    using System.Threading.Tasks;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Models;

    public class GamePlayerApi
    {
        public ServerApi server { get; } = new ServerApi();

        public AdminApi admin { get; } = new AdminApi();

        public void addPlayerFriend(GamePlayerModels.AddPlayerFriendRequestData requestData, Action1<GamePlayerResponseModels.AddPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.AddPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.AddPlayerFriendOperationResponse> addPlayerFriendAsync(GamePlayerModels.AddPlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AddPlayerFriendOperationRequest, GamePlayerResponseModels.AddPlayerFriendOperationResponse>(new GamePlayerRequestModels.AddPlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void addSegment(GamePlayerModels.AddSegmentRequestData requestData, Action1<GamePlayerResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.AddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.AddSegmentOperationResponse> addSegmentAsync(GamePlayerModels.AddSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AddSegmentOperationRequest, GamePlayerResponseModels.AddSegmentOperationResponse>(new GamePlayerRequestModels.AddSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getAvatar(GamePlayerModels.GetAvatarRequestData requestData, Action1<GamePlayerResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetAvatarOperationResponse> getAvatarAsync(GamePlayerModels.GetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetAvatarOperationRequest, GamePlayerResponseModels.GetAvatarOperationResponse>(new GamePlayerRequestModels.GetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCountryCode(GamePlayerModels.GetCountryCodeRequestData requestData, Action1<GamePlayerResponseModels.GetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetCountryCodeOperationResponse> getCountryCodeAsync(GamePlayerModels.GetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetCountryCodeOperationRequest, GamePlayerResponseModels.GetCountryCodeOperationResponse>(new GamePlayerRequestModels.GetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCustomData(GamePlayerModels.GetCustomDataRequestData requestData, Action1<GamePlayerResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetCustomDataOperationResponse> getCustomDataAsync(GamePlayerModels.GetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetCustomDataOperationRequest, GamePlayerResponseModels.GetCustomDataOperationResponse>(new GamePlayerRequestModels.GetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getDisplayName(GamePlayerModels.GetDisplayNameRequestData requestData, Action1<GamePlayerResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetDisplayNameOperationResponse> getDisplayNameAsync(GamePlayerModels.GetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetDisplayNameOperationRequest, GamePlayerResponseModels.GetDisplayNameOperationResponse>(new GamePlayerRequestModels.GetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getFriendStatisticsLeaderboardAroundPlayer(GamePlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, Action1<GamePlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> getFriendStatisticsLeaderboardAroundPlayerAsync(GamePlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetFriendStatisticsLeaderboardAroundPlayerOperationRequest, GamePlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse>(new GamePlayerRequestModels.GetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getFriendStatisticsLeaderboard(GamePlayerModels.GetFriendStatisticsLeaderboardRequestData requestData, Action1<GamePlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> getFriendStatisticsLeaderboardAsync(GamePlayerModels.GetFriendStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetFriendStatisticsLeaderboardOperationRequest, GamePlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse>(new GamePlayerRequestModels.GetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getIpAddressCreate(GamePlayerModels.GetIpAddressCreateRequestData requestData, Action1<GamePlayerResponseModels.GetIpAddressCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetIpAddressCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetIpAddressCreateOperationResponse> getIpAddressCreateAsync(GamePlayerModels.GetIpAddressCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetIpAddressCreateOperationRequest, GamePlayerResponseModels.GetIpAddressCreateOperationResponse>(new GamePlayerRequestModels.GetIpAddressCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getOnlineStatus(GamePlayerModels.GetOnlineStatusRequestData requestData, Action1<GamePlayerResponseModels.GetOnlineStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetOnlineStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetOnlineStatusOperationResponse> getOnlineStatusAsync(GamePlayerModels.GetOnlineStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetOnlineStatusOperationRequest, GamePlayerResponseModels.GetOnlineStatusOperationResponse>(new GamePlayerRequestModels.GetOnlineStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerBan(GamePlayerModels.GetPlayerBanRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetPlayerBanOperationResponse> getPlayerBanAsync(GamePlayerModels.GetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetPlayerBanOperationRequest, GamePlayerResponseModels.GetPlayerBanOperationResponse>(new GamePlayerRequestModels.GetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerCharacter(GamePlayerModels.GetPlayerCharacterRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetPlayerCharacterOperationResponse> getPlayerCharacterAsync(GamePlayerModels.GetPlayerCharacterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetPlayerCharacterOperationRequest, GamePlayerResponseModels.GetPlayerCharacterOperationResponse>(new GamePlayerRequestModels.GetPlayerCharacterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerCurrency(GamePlayerModels.GetPlayerCurrencyRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetPlayerCurrencyOperationResponse> getPlayerCurrencyAsync(GamePlayerModels.GetPlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetPlayerCurrencyOperationRequest, GamePlayerResponseModels.GetPlayerCurrencyOperationResponse>(new GamePlayerRequestModels.GetPlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerData(GamePlayerModels.GetPlayerDataRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetPlayerDataOperationResponse> getPlayerDataAsync(GamePlayerModels.GetPlayerDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetPlayerDataOperationRequest, GamePlayerResponseModels.GetPlayerDataOperationResponse>(new GamePlayerRequestModels.GetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerFriend(GamePlayerModels.GetPlayerFriendRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetPlayerFriendOperationResponse> getPlayerFriendAsync(GamePlayerModels.GetPlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetPlayerFriendOperationRequest, GamePlayerResponseModels.GetPlayerFriendOperationResponse>(new GamePlayerRequestModels.GetPlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerGroup(GamePlayerModels.GetPlayerGroupRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetPlayerGroupOperationResponse> getPlayerGroupAsync(GamePlayerModels.GetPlayerGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetPlayerGroupOperationRequest, GamePlayerResponseModels.GetPlayerGroupOperationResponse>(new GamePlayerRequestModels.GetPlayerGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerInformation(GamePlayerModels.GetPlayerInformationRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetPlayerInformationOperationResponse> getPlayerInformationAsync(GamePlayerModels.GetPlayerInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetPlayerInformationOperationRequest, GamePlayerResponseModels.GetPlayerInformationOperationResponse>(new GamePlayerRequestModels.GetPlayerInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerInventory(GamePlayerModels.GetPlayerInventoryRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerInventoryOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerInventoryOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetPlayerInventoryOperationResponse> getPlayerInventoryAsync(GamePlayerModels.GetPlayerInventoryRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetPlayerInventoryOperationRequest, GamePlayerResponseModels.GetPlayerInventoryOperationResponse>(new GamePlayerRequestModels.GetPlayerInventoryOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerStatistics(GamePlayerModels.GetPlayerStatisticsRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetPlayerStatisticsOperationResponse> getPlayerStatisticsAsync(GamePlayerModels.GetPlayerStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetPlayerStatisticsOperationRequest, GamePlayerResponseModels.GetPlayerStatisticsOperationResponse>(new GamePlayerRequestModels.GetPlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayersWithDisplayName(GamePlayerModels.GetPlayersWithDisplayNameRequestData requestData, Action1<GamePlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayersWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> getPlayersWithDisplayNameAsync(GamePlayerModels.GetPlayersWithDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetPlayersWithDisplayNameOperationRequest, GamePlayerResponseModels.GetPlayersWithDisplayNameOperationResponse>(new GamePlayerRequestModels.GetPlayersWithDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayersWithSegment(GamePlayerModels.GetPlayersWithSegmentRequestData requestData, Action1<GamePlayerResponseModels.GetPlayersWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayersWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetPlayersWithSegmentOperationResponse> getPlayersWithSegmentAsync(GamePlayerModels.GetPlayersWithSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetPlayersWithSegmentOperationRequest, GamePlayerResponseModels.GetPlayersWithSegmentOperationResponse>(new GamePlayerRequestModels.GetPlayersWithSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayersWithTag(GamePlayerModels.GetPlayersWithTagRequestData requestData, Action1<GamePlayerResponseModels.GetPlayersWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayersWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetPlayersWithTagOperationResponse> getPlayersWithTagAsync(GamePlayerModels.GetPlayersWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetPlayersWithTagOperationRequest, GamePlayerResponseModels.GetPlayersWithTagOperationResponse>(new GamePlayerRequestModels.GetPlayersWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getSegment(GamePlayerModels.GetSegmentRequestData requestData, Action1<GamePlayerResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetSegmentOperationResponse> getSegmentAsync(GamePlayerModels.GetSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetSegmentOperationRequest, GamePlayerResponseModels.GetSegmentOperationResponse>(new GamePlayerRequestModels.GetSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStatisticsLeaderboardAroundPlayer(GamePlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, Action1<GamePlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> getStatisticsLeaderboardAroundPlayerAsync(GamePlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetStatisticsLeaderboardAroundPlayerOperationRequest, GamePlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse>(new GamePlayerRequestModels.GetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStatisticsLeaderboard(GamePlayerModels.GetStatisticsLeaderboardRequestData requestData, Action1<GamePlayerResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetStatisticsLeaderboardOperationResponse> getStatisticsLeaderboardAsync(GamePlayerModels.GetStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetStatisticsLeaderboardOperationRequest, GamePlayerResponseModels.GetStatisticsLeaderboardOperationResponse>(new GamePlayerRequestModels.GetStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getTag(GamePlayerModels.GetTagRequestData requestData, Action1<GamePlayerResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetTagOperationResponse> getTagAsync(GamePlayerModels.GetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetTagOperationRequest, GamePlayerResponseModels.GetTagOperationResponse>(new GamePlayerRequestModels.GetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getTsCreate(GamePlayerModels.GetTsCreateRequestData requestData, Action1<GamePlayerResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetTsCreateOperationResponse> getTsCreateAsync(GamePlayerModels.GetTsCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetTsCreateOperationRequest, GamePlayerResponseModels.GetTsCreateOperationResponse>(new GamePlayerRequestModels.GetTsCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getTsLastLogin(GamePlayerModels.GetTsLastLoginRequestData requestData, Action1<GamePlayerResponseModels.GetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetTsLastLoginOperationResponse> getTsLastLoginAsync(GamePlayerModels.GetTsLastLoginRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetTsLastLoginOperationRequest, GamePlayerResponseModels.GetTsLastLoginOperationResponse>(new GamePlayerRequestModels.GetTsLastLoginOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void createGroup(GamePlayerModels.CreateGroupRequestData requestData, Action1<GamePlayerResponseModels.CreateGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.CreateGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.CreateGroupOperationResponse> createGroupAsync(GamePlayerModels.CreateGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.CreateGroupOperationRequest, GamePlayerResponseModels.CreateGroupOperationResponse>(new GamePlayerRequestModels.CreateGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void createPlayerCharacter(GamePlayerModels.CreatePlayerCharacterRequestData requestData, Action1<GamePlayerResponseModels.CreatePlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.CreatePlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.CreatePlayerCharacterOperationResponse> createPlayerCharacterAsync(GamePlayerModels.CreatePlayerCharacterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.CreatePlayerCharacterOperationRequest, GamePlayerResponseModels.CreatePlayerCharacterOperationResponse>(new GamePlayerRequestModels.CreatePlayerCharacterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void createPlayerItem(GamePlayerModels.CreatePlayerItemRequestData requestData, Action1<GamePlayerResponseModels.CreatePlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.CreatePlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.CreatePlayerItemOperationResponse> createPlayerItemAsync(GamePlayerModels.CreatePlayerItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.CreatePlayerItemOperationRequest, GamePlayerResponseModels.CreatePlayerItemOperationResponse>(new GamePlayerRequestModels.CreatePlayerItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void joinGroup(GamePlayerModels.JoinGroupRequestData requestData, Action1<GamePlayerResponseModels.JoinGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.JoinGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.JoinGroupOperationResponse> joinGroupAsync(GamePlayerModels.JoinGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.JoinGroupOperationRequest, GamePlayerResponseModels.JoinGroupOperationResponse>(new GamePlayerRequestModels.JoinGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void leaveGroup(GamePlayerModels.LeaveGroupRequestData requestData, Action1<GamePlayerResponseModels.LeaveGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.LeaveGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.LeaveGroupOperationResponse> leaveGroupAsync(GamePlayerModels.LeaveGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.LeaveGroupOperationRequest, GamePlayerResponseModels.LeaveGroupOperationResponse>(new GamePlayerRequestModels.LeaveGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removePlayerCharacter(GamePlayerModels.RemovePlayerCharacterRequestData requestData, Action1<GamePlayerResponseModels.RemovePlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.RemovePlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.RemovePlayerCharacterOperationResponse> removePlayerCharacterAsync(GamePlayerModels.RemovePlayerCharacterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.RemovePlayerCharacterOperationRequest, GamePlayerResponseModels.RemovePlayerCharacterOperationResponse>(new GamePlayerRequestModels.RemovePlayerCharacterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removePlayerFriend(GamePlayerModels.RemovePlayerFriendRequestData requestData, Action1<GamePlayerResponseModels.RemovePlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.RemovePlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.RemovePlayerFriendOperationResponse> removePlayerFriendAsync(GamePlayerModels.RemovePlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.RemovePlayerFriendOperationRequest, GamePlayerResponseModels.RemovePlayerFriendOperationResponse>(new GamePlayerRequestModels.RemovePlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removePlayerItem(GamePlayerModels.RemovePlayerItemRequestData requestData, Action1<GamePlayerResponseModels.RemovePlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.RemovePlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.RemovePlayerItemOperationResponse> removePlayerItemAsync(GamePlayerModels.RemovePlayerItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.RemovePlayerItemOperationRequest, GamePlayerResponseModels.RemovePlayerItemOperationResponse>(new GamePlayerRequestModels.RemovePlayerItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removeSegment(GamePlayerModels.RemoveSegmentRequestData requestData, Action1<GamePlayerResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.RemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.RemoveSegmentOperationResponse> removeSegmentAsync(GamePlayerModels.RemoveSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.RemoveSegmentOperationRequest, GamePlayerResponseModels.RemoveSegmentOperationResponse>(new GamePlayerRequestModels.RemoveSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removeTag(GamePlayerModels.RemoveTagRequestData requestData, Action1<GamePlayerResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.RemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.RemoveTagOperationResponse> removeTagAsync(GamePlayerModels.RemoveTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.RemoveTagOperationRequest, GamePlayerResponseModels.RemoveTagOperationResponse>(new GamePlayerRequestModels.RemoveTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setAvatar(GamePlayerModels.SetAvatarRequestData requestData, Action1<GamePlayerResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.SetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.SetAvatarOperationResponse> setAvatarAsync(GamePlayerModels.SetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.SetAvatarOperationRequest, GamePlayerResponseModels.SetAvatarOperationResponse>(new GamePlayerRequestModels.SetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setCountryCode(GamePlayerModels.SetCountryCodeRequestData requestData, Action1<GamePlayerResponseModels.SetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.SetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.SetCountryCodeOperationResponse> setCountryCodeAsync(GamePlayerModels.SetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.SetCountryCodeOperationRequest, GamePlayerResponseModels.SetCountryCodeOperationResponse>(new GamePlayerRequestModels.SetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setCustomData(GamePlayerModels.SetCustomDataRequestData requestData, Action1<GamePlayerResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.SetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.SetCustomDataOperationResponse> setCustomDataAsync(GamePlayerModels.SetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.SetCustomDataOperationRequest, GamePlayerResponseModels.SetCustomDataOperationResponse>(new GamePlayerRequestModels.SetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setDisplayName(GamePlayerModels.SetDisplayNameRequestData requestData, Action1<GamePlayerResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.SetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.SetDisplayNameOperationResponse> setDisplayNameAsync(GamePlayerModels.SetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.SetDisplayNameOperationRequest, GamePlayerResponseModels.SetDisplayNameOperationResponse>(new GamePlayerRequestModels.SetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setPlayerBan(GamePlayerModels.SetPlayerBanRequestData requestData, Action1<GamePlayerResponseModels.SetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.SetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.SetPlayerBanOperationResponse> setPlayerBanAsync(GamePlayerModels.SetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.SetPlayerBanOperationRequest, GamePlayerResponseModels.SetPlayerBanOperationResponse>(new GamePlayerRequestModels.SetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void changePlayerCurrency(GamePlayerModels.ChangePlayerCurrencyRequestData requestData, Action1<GamePlayerResponseModels.ChangePlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.ChangePlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.ChangePlayerCurrencyOperationResponse> changePlayerCurrencyAsync(GamePlayerModels.ChangePlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ChangePlayerCurrencyOperationRequest, GamePlayerResponseModels.ChangePlayerCurrencyOperationResponse>(new GamePlayerRequestModels.ChangePlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setPlayerData(GamePlayerModels.SetPlayerDataRequestData requestData, Action1<GamePlayerResponseModels.SetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.SetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.SetPlayerDataOperationResponse> setPlayerDataAsync(GamePlayerModels.SetPlayerDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.SetPlayerDataOperationRequest, GamePlayerResponseModels.SetPlayerDataOperationResponse>(new GamePlayerRequestModels.SetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void changePlayerStatistics(GamePlayerModels.ChangePlayerStatisticsRequestData requestData, Action1<GamePlayerResponseModels.ChangePlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.ChangePlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.ChangePlayerStatisticsOperationResponse> changePlayerStatisticsAsync(GamePlayerModels.ChangePlayerStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ChangePlayerStatisticsOperationRequest, GamePlayerResponseModels.ChangePlayerStatisticsOperationResponse>(new GamePlayerRequestModels.ChangePlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setTag(GamePlayerModels.SetTagRequestData requestData, Action1<GamePlayerResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.SetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.SetTagOperationResponse> setTagAsync(GamePlayerModels.SetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.SetTagOperationRequest, GamePlayerResponseModels.SetTagOperationResponse>(new GamePlayerRequestModels.SetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCurrencyLeaderboard(GamePlayerModels.GetCurrencyLeaderboardRequestData requestData, Action1<GamePlayerResponseModels.GetCurrencyLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetCurrencyLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetCurrencyLeaderboardOperationResponse> getCurrencyLeaderboardAsync(GamePlayerModels.GetCurrencyLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetCurrencyLeaderboardOperationRequest, GamePlayerResponseModels.GetCurrencyLeaderboardOperationResponse>(new GamePlayerRequestModels.GetCurrencyLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCreateLeaderboard(GamePlayerModels.GetCreateLeaderboardRequestData requestData, Action1<GamePlayerResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(GamePlayerModels.GetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetCreateLeaderboardOperationRequest, GamePlayerResponseModels.GetCreateLeaderboardOperationResponse>(new GamePlayerRequestModels.GetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStatisticsLog(GamePlayerModels.GetStatisticsLogRequestData requestData, Action1<GamePlayerResponseModels.GetStatisticsLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetStatisticsLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetStatisticsLogOperationResponse> getStatisticsLogAsync(GamePlayerModels.GetStatisticsLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetStatisticsLogOperationRequest, GamePlayerResponseModels.GetStatisticsLogOperationResponse>(new GamePlayerRequestModels.GetStatisticsLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCurrencyLog(GamePlayerModels.GetCurrencyLogRequestData requestData, Action1<GamePlayerResponseModels.GetCurrencyLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetCurrencyLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<GamePlayerResponseModels.GetCurrencyLogOperationResponse> getCurrencyLogAsync(GamePlayerModels.GetCurrencyLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.GetCurrencyLogOperationRequest, GamePlayerResponseModels.GetCurrencyLogOperationResponse>(new GamePlayerRequestModels.GetCurrencyLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }


        public class ServerApi
        {
            public void addPlayerFriend(GamePlayerModels.ServerAddPlayerFriendRequestData requestData, Action1<GamePlayerResponseModels.AddPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerAddPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.AddPlayerFriendOperationResponse> addPlayerFriendAsync(GamePlayerModels.ServerAddPlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerAddPlayerFriendOperationRequest, GamePlayerResponseModels.AddPlayerFriendOperationResponse>(new GamePlayerRequestModels.ServerAddPlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void addSegment(GamePlayerModels.ServerAddSegmentRequestData requestData, Action1<GamePlayerResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerAddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.AddSegmentOperationResponse> addSegmentAsync(GamePlayerModels.ServerAddSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerAddSegmentOperationRequest, GamePlayerResponseModels.AddSegmentOperationResponse>(new GamePlayerRequestModels.ServerAddSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getAvatar(GamePlayerModels.ServerGetAvatarRequestData requestData, Action1<GamePlayerResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetAvatarOperationResponse> getAvatarAsync(GamePlayerModels.ServerGetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetAvatarOperationRequest, GamePlayerResponseModels.GetAvatarOperationResponse>(new GamePlayerRequestModels.ServerGetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCountryCode(GamePlayerModels.ServerGetCountryCodeRequestData requestData, Action1<GamePlayerResponseModels.GetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetCountryCodeOperationResponse> getCountryCodeAsync(GamePlayerModels.ServerGetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetCountryCodeOperationRequest, GamePlayerResponseModels.GetCountryCodeOperationResponse>(new GamePlayerRequestModels.ServerGetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCustomData(GamePlayerModels.ServerGetCustomDataRequestData requestData, Action1<GamePlayerResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetCustomDataOperationResponse> getCustomDataAsync(GamePlayerModels.ServerGetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetCustomDataOperationRequest, GamePlayerResponseModels.GetCustomDataOperationResponse>(new GamePlayerRequestModels.ServerGetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getDisplayName(GamePlayerModels.ServerGetDisplayNameRequestData requestData, Action1<GamePlayerResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetDisplayNameOperationResponse> getDisplayNameAsync(GamePlayerModels.ServerGetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetDisplayNameOperationRequest, GamePlayerResponseModels.GetDisplayNameOperationResponse>(new GamePlayerRequestModels.ServerGetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getFriendStatisticsLeaderboardAroundPlayer(GamePlayerModels.ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, Action1<GamePlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> getFriendStatisticsLeaderboardAroundPlayerAsync(GamePlayerModels.ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest, GamePlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse>(new GamePlayerRequestModels.ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getFriendStatisticsLeaderboard(GamePlayerModels.ServerGetFriendStatisticsLeaderboardRequestData requestData, Action1<GamePlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> getFriendStatisticsLeaderboardAsync(GamePlayerModels.ServerGetFriendStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetFriendStatisticsLeaderboardOperationRequest, GamePlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse>(new GamePlayerRequestModels.ServerGetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getIpAddressCreate(GamePlayerModels.ServerGetIpAddressCreateRequestData requestData, Action1<GamePlayerResponseModels.GetIpAddressCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetIpAddressCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetIpAddressCreateOperationResponse> getIpAddressCreateAsync(GamePlayerModels.ServerGetIpAddressCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetIpAddressCreateOperationRequest, GamePlayerResponseModels.GetIpAddressCreateOperationResponse>(new GamePlayerRequestModels.ServerGetIpAddressCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getOnlineStatus(GamePlayerModels.ServerGetOnlineStatusRequestData requestData, Action1<GamePlayerResponseModels.GetOnlineStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetOnlineStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetOnlineStatusOperationResponse> getOnlineStatusAsync(GamePlayerModels.ServerGetOnlineStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetOnlineStatusOperationRequest, GamePlayerResponseModels.GetOnlineStatusOperationResponse>(new GamePlayerRequestModels.ServerGetOnlineStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerBan(GamePlayerModels.ServerGetPlayerBanRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerBanOperationResponse> getPlayerBanAsync(GamePlayerModels.ServerGetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetPlayerBanOperationRequest, GamePlayerResponseModels.GetPlayerBanOperationResponse>(new GamePlayerRequestModels.ServerGetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerCharacter(GamePlayerModels.ServerGetPlayerCharacterRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerCharacterOperationResponse> getPlayerCharacterAsync(GamePlayerModels.ServerGetPlayerCharacterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetPlayerCharacterOperationRequest, GamePlayerResponseModels.GetPlayerCharacterOperationResponse>(new GamePlayerRequestModels.ServerGetPlayerCharacterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerCurrency(GamePlayerModels.ServerGetPlayerCurrencyRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerCurrencyOperationResponse> getPlayerCurrencyAsync(GamePlayerModels.ServerGetPlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetPlayerCurrencyOperationRequest, GamePlayerResponseModels.GetPlayerCurrencyOperationResponse>(new GamePlayerRequestModels.ServerGetPlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerData(GamePlayerModels.ServerGetPlayerDataRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerDataOperationResponse> getPlayerDataAsync(GamePlayerModels.ServerGetPlayerDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetPlayerDataOperationRequest, GamePlayerResponseModels.GetPlayerDataOperationResponse>(new GamePlayerRequestModels.ServerGetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerFriend(GamePlayerModels.ServerGetPlayerFriendRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerFriendOperationResponse> getPlayerFriendAsync(GamePlayerModels.ServerGetPlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetPlayerFriendOperationRequest, GamePlayerResponseModels.GetPlayerFriendOperationResponse>(new GamePlayerRequestModels.ServerGetPlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerGroup(GamePlayerModels.ServerGetPlayerGroupRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerGroupOperationResponse> getPlayerGroupAsync(GamePlayerModels.ServerGetPlayerGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetPlayerGroupOperationRequest, GamePlayerResponseModels.GetPlayerGroupOperationResponse>(new GamePlayerRequestModels.ServerGetPlayerGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerInformation(GamePlayerModels.ServerGetPlayerInformationRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerInformationOperationResponse> getPlayerInformationAsync(GamePlayerModels.ServerGetPlayerInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetPlayerInformationOperationRequest, GamePlayerResponseModels.GetPlayerInformationOperationResponse>(new GamePlayerRequestModels.ServerGetPlayerInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerInventory(GamePlayerModels.ServerGetPlayerInventoryRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerInventoryOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerInventoryOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerInventoryOperationResponse> getPlayerInventoryAsync(GamePlayerModels.ServerGetPlayerInventoryRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetPlayerInventoryOperationRequest, GamePlayerResponseModels.GetPlayerInventoryOperationResponse>(new GamePlayerRequestModels.ServerGetPlayerInventoryOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerStatistics(GamePlayerModels.ServerGetPlayerStatisticsRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerStatisticsOperationResponse> getPlayerStatisticsAsync(GamePlayerModels.ServerGetPlayerStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetPlayerStatisticsOperationRequest, GamePlayerResponseModels.GetPlayerStatisticsOperationResponse>(new GamePlayerRequestModels.ServerGetPlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithDisplayName(GamePlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, Action1<GamePlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayersWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> getPlayersWithDisplayNameAsync(GamePlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetPlayersWithDisplayNameOperationRequest, GamePlayerResponseModels.GetPlayersWithDisplayNameOperationResponse>(new GamePlayerRequestModels.ServerGetPlayersWithDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithSegment(GamePlayerModels.ServerGetPlayersWithSegmentRequestData requestData, Action1<GamePlayerResponseModels.GetPlayersWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayersWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayersWithSegmentOperationResponse> getPlayersWithSegmentAsync(GamePlayerModels.ServerGetPlayersWithSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetPlayersWithSegmentOperationRequest, GamePlayerResponseModels.GetPlayersWithSegmentOperationResponse>(new GamePlayerRequestModels.ServerGetPlayersWithSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithTag(GamePlayerModels.ServerGetPlayersWithTagRequestData requestData, Action1<GamePlayerResponseModels.GetPlayersWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayersWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayersWithTagOperationResponse> getPlayersWithTagAsync(GamePlayerModels.ServerGetPlayersWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetPlayersWithTagOperationRequest, GamePlayerResponseModels.GetPlayersWithTagOperationResponse>(new GamePlayerRequestModels.ServerGetPlayersWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getSegment(GamePlayerModels.ServerGetSegmentRequestData requestData, Action1<GamePlayerResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetSegmentOperationResponse> getSegmentAsync(GamePlayerModels.ServerGetSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetSegmentOperationRequest, GamePlayerResponseModels.GetSegmentOperationResponse>(new GamePlayerRequestModels.ServerGetSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboardAroundPlayer(GamePlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, Action1<GamePlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> getStatisticsLeaderboardAroundPlayerAsync(GamePlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetStatisticsLeaderboardAroundPlayerOperationRequest, GamePlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse>(new GamePlayerRequestModels.ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboard(GamePlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, Action1<GamePlayerResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetStatisticsLeaderboardOperationResponse> getStatisticsLeaderboardAsync(GamePlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetStatisticsLeaderboardOperationRequest, GamePlayerResponseModels.GetStatisticsLeaderboardOperationResponse>(new GamePlayerRequestModels.ServerGetStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTag(GamePlayerModels.ServerGetTagRequestData requestData, Action1<GamePlayerResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetTagOperationResponse> getTagAsync(GamePlayerModels.ServerGetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetTagOperationRequest, GamePlayerResponseModels.GetTagOperationResponse>(new GamePlayerRequestModels.ServerGetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTsCreate(GamePlayerModels.ServerGetTsCreateRequestData requestData, Action1<GamePlayerResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetTsCreateOperationResponse> getTsCreateAsync(GamePlayerModels.ServerGetTsCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetTsCreateOperationRequest, GamePlayerResponseModels.GetTsCreateOperationResponse>(new GamePlayerRequestModels.ServerGetTsCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTsLastLogin(GamePlayerModels.ServerGetTsLastLoginRequestData requestData, Action1<GamePlayerResponseModels.GetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetTsLastLoginOperationResponse> getTsLastLoginAsync(GamePlayerModels.ServerGetTsLastLoginRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetTsLastLoginOperationRequest, GamePlayerResponseModels.GetTsLastLoginOperationResponse>(new GamePlayerRequestModels.ServerGetTsLastLoginOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void createGroup(GamePlayerModels.ServerCreateGroupRequestData requestData, Action1<GamePlayerResponseModels.CreateGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerCreateGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.CreateGroupOperationResponse> createGroupAsync(GamePlayerModels.ServerCreateGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerCreateGroupOperationRequest, GamePlayerResponseModels.CreateGroupOperationResponse>(new GamePlayerRequestModels.ServerCreateGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void createPlayerCharacter(GamePlayerModels.ServerCreatePlayerCharacterRequestData requestData, Action1<GamePlayerResponseModels.CreatePlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerCreatePlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.CreatePlayerCharacterOperationResponse> createPlayerCharacterAsync(GamePlayerModels.ServerCreatePlayerCharacterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerCreatePlayerCharacterOperationRequest, GamePlayerResponseModels.CreatePlayerCharacterOperationResponse>(new GamePlayerRequestModels.ServerCreatePlayerCharacterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void createPlayerItem(GamePlayerModels.ServerCreatePlayerItemRequestData requestData, Action1<GamePlayerResponseModels.CreatePlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerCreatePlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.CreatePlayerItemOperationResponse> createPlayerItemAsync(GamePlayerModels.ServerCreatePlayerItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerCreatePlayerItemOperationRequest, GamePlayerResponseModels.CreatePlayerItemOperationResponse>(new GamePlayerRequestModels.ServerCreatePlayerItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void joinGroup(GamePlayerModels.ServerJoinGroupRequestData requestData, Action1<GamePlayerResponseModels.JoinGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerJoinGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.JoinGroupOperationResponse> joinGroupAsync(GamePlayerModels.ServerJoinGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerJoinGroupOperationRequest, GamePlayerResponseModels.JoinGroupOperationResponse>(new GamePlayerRequestModels.ServerJoinGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void leaveGroup(GamePlayerModels.ServerLeaveGroupRequestData requestData, Action1<GamePlayerResponseModels.LeaveGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerLeaveGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.LeaveGroupOperationResponse> leaveGroupAsync(GamePlayerModels.ServerLeaveGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerLeaveGroupOperationRequest, GamePlayerResponseModels.LeaveGroupOperationResponse>(new GamePlayerRequestModels.ServerLeaveGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removePlayerCharacter(GamePlayerModels.ServerRemovePlayerCharacterRequestData requestData, Action1<GamePlayerResponseModels.RemovePlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerRemovePlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.RemovePlayerCharacterOperationResponse> removePlayerCharacterAsync(GamePlayerModels.ServerRemovePlayerCharacterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerRemovePlayerCharacterOperationRequest, GamePlayerResponseModels.RemovePlayerCharacterOperationResponse>(new GamePlayerRequestModels.ServerRemovePlayerCharacterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removePlayerFriend(GamePlayerModels.ServerRemovePlayerFriendRequestData requestData, Action1<GamePlayerResponseModels.RemovePlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerRemovePlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.RemovePlayerFriendOperationResponse> removePlayerFriendAsync(GamePlayerModels.ServerRemovePlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerRemovePlayerFriendOperationRequest, GamePlayerResponseModels.RemovePlayerFriendOperationResponse>(new GamePlayerRequestModels.ServerRemovePlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removePlayerItem(GamePlayerModels.ServerRemovePlayerItemRequestData requestData, Action1<GamePlayerResponseModels.RemovePlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerRemovePlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.RemovePlayerItemOperationResponse> removePlayerItemAsync(GamePlayerModels.ServerRemovePlayerItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerRemovePlayerItemOperationRequest, GamePlayerResponseModels.RemovePlayerItemOperationResponse>(new GamePlayerRequestModels.ServerRemovePlayerItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeSegment(GamePlayerModels.ServerRemoveSegmentRequestData requestData, Action1<GamePlayerResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerRemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.RemoveSegmentOperationResponse> removeSegmentAsync(GamePlayerModels.ServerRemoveSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerRemoveSegmentOperationRequest, GamePlayerResponseModels.RemoveSegmentOperationResponse>(new GamePlayerRequestModels.ServerRemoveSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeTag(GamePlayerModels.ServerRemoveTagRequestData requestData, Action1<GamePlayerResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerRemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.RemoveTagOperationResponse> removeTagAsync(GamePlayerModels.ServerRemoveTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerRemoveTagOperationRequest, GamePlayerResponseModels.RemoveTagOperationResponse>(new GamePlayerRequestModels.ServerRemoveTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setAvatar(GamePlayerModels.ServerSetAvatarRequestData requestData, Action1<GamePlayerResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerSetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.SetAvatarOperationResponse> setAvatarAsync(GamePlayerModels.ServerSetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerSetAvatarOperationRequest, GamePlayerResponseModels.SetAvatarOperationResponse>(new GamePlayerRequestModels.ServerSetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setCountryCode(GamePlayerModels.ServerSetCountryCodeRequestData requestData, Action1<GamePlayerResponseModels.SetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerSetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.SetCountryCodeOperationResponse> setCountryCodeAsync(GamePlayerModels.ServerSetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerSetCountryCodeOperationRequest, GamePlayerResponseModels.SetCountryCodeOperationResponse>(new GamePlayerRequestModels.ServerSetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setCustomData(GamePlayerModels.ServerSetCustomDataRequestData requestData, Action1<GamePlayerResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerSetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.SetCustomDataOperationResponse> setCustomDataAsync(GamePlayerModels.ServerSetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerSetCustomDataOperationRequest, GamePlayerResponseModels.SetCustomDataOperationResponse>(new GamePlayerRequestModels.ServerSetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setDisplayName(GamePlayerModels.ServerSetDisplayNameRequestData requestData, Action1<GamePlayerResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerSetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.SetDisplayNameOperationResponse> setDisplayNameAsync(GamePlayerModels.ServerSetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerSetDisplayNameOperationRequest, GamePlayerResponseModels.SetDisplayNameOperationResponse>(new GamePlayerRequestModels.ServerSetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setPlayerBan(GamePlayerModels.ServerSetPlayerBanRequestData requestData, Action1<GamePlayerResponseModels.SetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerSetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.SetPlayerBanOperationResponse> setPlayerBanAsync(GamePlayerModels.ServerSetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerSetPlayerBanOperationRequest, GamePlayerResponseModels.SetPlayerBanOperationResponse>(new GamePlayerRequestModels.ServerSetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changePlayerCurrency(GamePlayerModels.ServerChangePlayerCurrencyRequestData requestData, Action1<GamePlayerResponseModels.ChangePlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerChangePlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.ChangePlayerCurrencyOperationResponse> changePlayerCurrencyAsync(GamePlayerModels.ServerChangePlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerChangePlayerCurrencyOperationRequest, GamePlayerResponseModels.ChangePlayerCurrencyOperationResponse>(new GamePlayerRequestModels.ServerChangePlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setPlayerData(GamePlayerModels.ServerSetPlayerDataRequestData requestData, Action1<GamePlayerResponseModels.SetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerSetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.SetPlayerDataOperationResponse> setPlayerDataAsync(GamePlayerModels.ServerSetPlayerDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerSetPlayerDataOperationRequest, GamePlayerResponseModels.SetPlayerDataOperationResponse>(new GamePlayerRequestModels.ServerSetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changePlayerStatistics(GamePlayerModels.ServerChangePlayerStatisticsRequestData requestData, Action1<GamePlayerResponseModels.ChangePlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerChangePlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.ChangePlayerStatisticsOperationResponse> changePlayerStatisticsAsync(GamePlayerModels.ServerChangePlayerStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerChangePlayerStatisticsOperationRequest, GamePlayerResponseModels.ChangePlayerStatisticsOperationResponse>(new GamePlayerRequestModels.ServerChangePlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setTag(GamePlayerModels.ServerSetTagRequestData requestData, Action1<GamePlayerResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerSetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.SetTagOperationResponse> setTagAsync(GamePlayerModels.ServerSetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerSetTagOperationRequest, GamePlayerResponseModels.SetTagOperationResponse>(new GamePlayerRequestModels.ServerSetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCurrencyLeaderboard(GamePlayerModels.ServerGetCurrencyLeaderboardRequestData requestData, Action1<GamePlayerResponseModels.GetCurrencyLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetCurrencyLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetCurrencyLeaderboardOperationResponse> getCurrencyLeaderboardAsync(GamePlayerModels.ServerGetCurrencyLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetCurrencyLeaderboardOperationRequest, GamePlayerResponseModels.GetCurrencyLeaderboardOperationResponse>(new GamePlayerRequestModels.ServerGetCurrencyLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCreateLeaderboard(GamePlayerModels.ServerGetCreateLeaderboardRequestData requestData, Action1<GamePlayerResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(GamePlayerModels.ServerGetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetCreateLeaderboardOperationRequest, GamePlayerResponseModels.GetCreateLeaderboardOperationResponse>(new GamePlayerRequestModels.ServerGetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLog(GamePlayerModels.ServerGetStatisticsLogRequestData requestData, Action1<GamePlayerResponseModels.GetStatisticsLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetStatisticsLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetStatisticsLogOperationResponse> getStatisticsLogAsync(GamePlayerModels.ServerGetStatisticsLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetStatisticsLogOperationRequest, GamePlayerResponseModels.GetStatisticsLogOperationResponse>(new GamePlayerRequestModels.ServerGetStatisticsLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCurrencyLog(GamePlayerModels.ServerGetCurrencyLogRequestData requestData, Action1<GamePlayerResponseModels.GetCurrencyLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetCurrencyLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetCurrencyLogOperationResponse> getCurrencyLogAsync(GamePlayerModels.ServerGetCurrencyLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.ServerGetCurrencyLogOperationRequest, GamePlayerResponseModels.GetCurrencyLogOperationResponse>(new GamePlayerRequestModels.ServerGetCurrencyLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

        public class AdminApi
        {
            public void addPlayerFriend(GamePlayerModels.AdminAddPlayerFriendRequestData requestData, Action1<GamePlayerResponseModels.AddPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminAddPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.AddPlayerFriendOperationResponse> addPlayerFriendAsync(GamePlayerModels.AdminAddPlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminAddPlayerFriendOperationRequest, GamePlayerResponseModels.AddPlayerFriendOperationResponse>(new GamePlayerRequestModels.AdminAddPlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void addSegment(GamePlayerModels.AdminAddSegmentRequestData requestData, Action1<GamePlayerResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminAddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.AddSegmentOperationResponse> addSegmentAsync(GamePlayerModels.AdminAddSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminAddSegmentOperationRequest, GamePlayerResponseModels.AddSegmentOperationResponse>(new GamePlayerRequestModels.AdminAddSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getAvatar(GamePlayerModels.AdminGetAvatarRequestData requestData, Action1<GamePlayerResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetAvatarOperationResponse> getAvatarAsync(GamePlayerModels.AdminGetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetAvatarOperationRequest, GamePlayerResponseModels.GetAvatarOperationResponse>(new GamePlayerRequestModels.AdminGetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCountryCode(GamePlayerModels.AdminGetCountryCodeRequestData requestData, Action1<GamePlayerResponseModels.GetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetCountryCodeOperationResponse> getCountryCodeAsync(GamePlayerModels.AdminGetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetCountryCodeOperationRequest, GamePlayerResponseModels.GetCountryCodeOperationResponse>(new GamePlayerRequestModels.AdminGetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCustomData(GamePlayerModels.AdminGetCustomDataRequestData requestData, Action1<GamePlayerResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetCustomDataOperationResponse> getCustomDataAsync(GamePlayerModels.AdminGetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetCustomDataOperationRequest, GamePlayerResponseModels.GetCustomDataOperationResponse>(new GamePlayerRequestModels.AdminGetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getDisplayName(GamePlayerModels.AdminGetDisplayNameRequestData requestData, Action1<GamePlayerResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetDisplayNameOperationResponse> getDisplayNameAsync(GamePlayerModels.AdminGetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetDisplayNameOperationRequest, GamePlayerResponseModels.GetDisplayNameOperationResponse>(new GamePlayerRequestModels.AdminGetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getFriendStatisticsLeaderboardAroundPlayer(GamePlayerModels.AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, Action1<GamePlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> getFriendStatisticsLeaderboardAroundPlayerAsync(GamePlayerModels.AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest, GamePlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse>(new GamePlayerRequestModels.AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getFriendStatisticsLeaderboard(GamePlayerModels.AdminGetFriendStatisticsLeaderboardRequestData requestData, Action1<GamePlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> getFriendStatisticsLeaderboardAsync(GamePlayerModels.AdminGetFriendStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetFriendStatisticsLeaderboardOperationRequest, GamePlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse>(new GamePlayerRequestModels.AdminGetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getIpAddressCreate(GamePlayerModels.AdminGetIpAddressCreateRequestData requestData, Action1<GamePlayerResponseModels.GetIpAddressCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetIpAddressCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetIpAddressCreateOperationResponse> getIpAddressCreateAsync(GamePlayerModels.AdminGetIpAddressCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetIpAddressCreateOperationRequest, GamePlayerResponseModels.GetIpAddressCreateOperationResponse>(new GamePlayerRequestModels.AdminGetIpAddressCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getOnlineStatus(GamePlayerModels.AdminGetOnlineStatusRequestData requestData, Action1<GamePlayerResponseModels.GetOnlineStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetOnlineStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetOnlineStatusOperationResponse> getOnlineStatusAsync(GamePlayerModels.AdminGetOnlineStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetOnlineStatusOperationRequest, GamePlayerResponseModels.GetOnlineStatusOperationResponse>(new GamePlayerRequestModels.AdminGetOnlineStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerBan(GamePlayerModels.AdminGetPlayerBanRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerBanOperationResponse> getPlayerBanAsync(GamePlayerModels.AdminGetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetPlayerBanOperationRequest, GamePlayerResponseModels.GetPlayerBanOperationResponse>(new GamePlayerRequestModels.AdminGetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerCharacter(GamePlayerModels.AdminGetPlayerCharacterRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerCharacterOperationResponse> getPlayerCharacterAsync(GamePlayerModels.AdminGetPlayerCharacterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetPlayerCharacterOperationRequest, GamePlayerResponseModels.GetPlayerCharacterOperationResponse>(new GamePlayerRequestModels.AdminGetPlayerCharacterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerCurrency(GamePlayerModels.AdminGetPlayerCurrencyRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerCurrencyOperationResponse> getPlayerCurrencyAsync(GamePlayerModels.AdminGetPlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetPlayerCurrencyOperationRequest, GamePlayerResponseModels.GetPlayerCurrencyOperationResponse>(new GamePlayerRequestModels.AdminGetPlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerData(GamePlayerModels.AdminGetPlayerDataRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerDataOperationResponse> getPlayerDataAsync(GamePlayerModels.AdminGetPlayerDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetPlayerDataOperationRequest, GamePlayerResponseModels.GetPlayerDataOperationResponse>(new GamePlayerRequestModels.AdminGetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerFriend(GamePlayerModels.AdminGetPlayerFriendRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerFriendOperationResponse> getPlayerFriendAsync(GamePlayerModels.AdminGetPlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetPlayerFriendOperationRequest, GamePlayerResponseModels.GetPlayerFriendOperationResponse>(new GamePlayerRequestModels.AdminGetPlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerGroup(GamePlayerModels.AdminGetPlayerGroupRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerGroupOperationResponse> getPlayerGroupAsync(GamePlayerModels.AdminGetPlayerGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetPlayerGroupOperationRequest, GamePlayerResponseModels.GetPlayerGroupOperationResponse>(new GamePlayerRequestModels.AdminGetPlayerGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerInformation(GamePlayerModels.AdminGetPlayerInformationRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerInformationOperationResponse> getPlayerInformationAsync(GamePlayerModels.AdminGetPlayerInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetPlayerInformationOperationRequest, GamePlayerResponseModels.GetPlayerInformationOperationResponse>(new GamePlayerRequestModels.AdminGetPlayerInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerInventory(GamePlayerModels.AdminGetPlayerInventoryRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerInventoryOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerInventoryOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerInventoryOperationResponse> getPlayerInventoryAsync(GamePlayerModels.AdminGetPlayerInventoryRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetPlayerInventoryOperationRequest, GamePlayerResponseModels.GetPlayerInventoryOperationResponse>(new GamePlayerRequestModels.AdminGetPlayerInventoryOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerStatistics(GamePlayerModels.AdminGetPlayerStatisticsRequestData requestData, Action1<GamePlayerResponseModels.GetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayerStatisticsOperationResponse> getPlayerStatisticsAsync(GamePlayerModels.AdminGetPlayerStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetPlayerStatisticsOperationRequest, GamePlayerResponseModels.GetPlayerStatisticsOperationResponse>(new GamePlayerRequestModels.AdminGetPlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithDisplayName(GamePlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, Action1<GamePlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayersWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> getPlayersWithDisplayNameAsync(GamePlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetPlayersWithDisplayNameOperationRequest, GamePlayerResponseModels.GetPlayersWithDisplayNameOperationResponse>(new GamePlayerRequestModels.AdminGetPlayersWithDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithSegment(GamePlayerModels.AdminGetPlayersWithSegmentRequestData requestData, Action1<GamePlayerResponseModels.GetPlayersWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayersWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayersWithSegmentOperationResponse> getPlayersWithSegmentAsync(GamePlayerModels.AdminGetPlayersWithSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetPlayersWithSegmentOperationRequest, GamePlayerResponseModels.GetPlayersWithSegmentOperationResponse>(new GamePlayerRequestModels.AdminGetPlayersWithSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithTag(GamePlayerModels.AdminGetPlayersWithTagRequestData requestData, Action1<GamePlayerResponseModels.GetPlayersWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayersWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetPlayersWithTagOperationResponse> getPlayersWithTagAsync(GamePlayerModels.AdminGetPlayersWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetPlayersWithTagOperationRequest, GamePlayerResponseModels.GetPlayersWithTagOperationResponse>(new GamePlayerRequestModels.AdminGetPlayersWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getSegment(GamePlayerModels.AdminGetSegmentRequestData requestData, Action1<GamePlayerResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetSegmentOperationResponse> getSegmentAsync(GamePlayerModels.AdminGetSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetSegmentOperationRequest, GamePlayerResponseModels.GetSegmentOperationResponse>(new GamePlayerRequestModels.AdminGetSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboardAroundPlayer(GamePlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, Action1<GamePlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> getStatisticsLeaderboardAroundPlayerAsync(GamePlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetStatisticsLeaderboardAroundPlayerOperationRequest, GamePlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse>(new GamePlayerRequestModels.AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboard(GamePlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, Action1<GamePlayerResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetStatisticsLeaderboardOperationResponse> getStatisticsLeaderboardAsync(GamePlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetStatisticsLeaderboardOperationRequest, GamePlayerResponseModels.GetStatisticsLeaderboardOperationResponse>(new GamePlayerRequestModels.AdminGetStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTag(GamePlayerModels.AdminGetTagRequestData requestData, Action1<GamePlayerResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetTagOperationResponse> getTagAsync(GamePlayerModels.AdminGetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetTagOperationRequest, GamePlayerResponseModels.GetTagOperationResponse>(new GamePlayerRequestModels.AdminGetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTsCreate(GamePlayerModels.AdminGetTsCreateRequestData requestData, Action1<GamePlayerResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetTsCreateOperationResponse> getTsCreateAsync(GamePlayerModels.AdminGetTsCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetTsCreateOperationRequest, GamePlayerResponseModels.GetTsCreateOperationResponse>(new GamePlayerRequestModels.AdminGetTsCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTsLastLogin(GamePlayerModels.AdminGetTsLastLoginRequestData requestData, Action1<GamePlayerResponseModels.GetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetTsLastLoginOperationResponse> getTsLastLoginAsync(GamePlayerModels.AdminGetTsLastLoginRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetTsLastLoginOperationRequest, GamePlayerResponseModels.GetTsLastLoginOperationResponse>(new GamePlayerRequestModels.AdminGetTsLastLoginOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void createGroup(GamePlayerModels.AdminCreateGroupRequestData requestData, Action1<GamePlayerResponseModels.CreateGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminCreateGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.CreateGroupOperationResponse> createGroupAsync(GamePlayerModels.AdminCreateGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminCreateGroupOperationRequest, GamePlayerResponseModels.CreateGroupOperationResponse>(new GamePlayerRequestModels.AdminCreateGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void createPlayerCharacter(GamePlayerModels.AdminCreatePlayerCharacterRequestData requestData, Action1<GamePlayerResponseModels.CreatePlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminCreatePlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.CreatePlayerCharacterOperationResponse> createPlayerCharacterAsync(GamePlayerModels.AdminCreatePlayerCharacterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminCreatePlayerCharacterOperationRequest, GamePlayerResponseModels.CreatePlayerCharacterOperationResponse>(new GamePlayerRequestModels.AdminCreatePlayerCharacterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void createPlayerItem(GamePlayerModels.AdminCreatePlayerItemRequestData requestData, Action1<GamePlayerResponseModels.CreatePlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminCreatePlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.CreatePlayerItemOperationResponse> createPlayerItemAsync(GamePlayerModels.AdminCreatePlayerItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminCreatePlayerItemOperationRequest, GamePlayerResponseModels.CreatePlayerItemOperationResponse>(new GamePlayerRequestModels.AdminCreatePlayerItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void joinGroup(GamePlayerModels.AdminJoinGroupRequestData requestData, Action1<GamePlayerResponseModels.JoinGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminJoinGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.JoinGroupOperationResponse> joinGroupAsync(GamePlayerModels.AdminJoinGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminJoinGroupOperationRequest, GamePlayerResponseModels.JoinGroupOperationResponse>(new GamePlayerRequestModels.AdminJoinGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void leaveGroup(GamePlayerModels.AdminLeaveGroupRequestData requestData, Action1<GamePlayerResponseModels.LeaveGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminLeaveGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.LeaveGroupOperationResponse> leaveGroupAsync(GamePlayerModels.AdminLeaveGroupRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminLeaveGroupOperationRequest, GamePlayerResponseModels.LeaveGroupOperationResponse>(new GamePlayerRequestModels.AdminLeaveGroupOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removePlayerCharacter(GamePlayerModels.AdminRemovePlayerCharacterRequestData requestData, Action1<GamePlayerResponseModels.RemovePlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminRemovePlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.RemovePlayerCharacterOperationResponse> removePlayerCharacterAsync(GamePlayerModels.AdminRemovePlayerCharacterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminRemovePlayerCharacterOperationRequest, GamePlayerResponseModels.RemovePlayerCharacterOperationResponse>(new GamePlayerRequestModels.AdminRemovePlayerCharacterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removePlayerFriend(GamePlayerModels.AdminRemovePlayerFriendRequestData requestData, Action1<GamePlayerResponseModels.RemovePlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminRemovePlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.RemovePlayerFriendOperationResponse> removePlayerFriendAsync(GamePlayerModels.AdminRemovePlayerFriendRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminRemovePlayerFriendOperationRequest, GamePlayerResponseModels.RemovePlayerFriendOperationResponse>(new GamePlayerRequestModels.AdminRemovePlayerFriendOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removePlayerItem(GamePlayerModels.AdminRemovePlayerItemRequestData requestData, Action1<GamePlayerResponseModels.RemovePlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminRemovePlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.RemovePlayerItemOperationResponse> removePlayerItemAsync(GamePlayerModels.AdminRemovePlayerItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminRemovePlayerItemOperationRequest, GamePlayerResponseModels.RemovePlayerItemOperationResponse>(new GamePlayerRequestModels.AdminRemovePlayerItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeSegment(GamePlayerModels.AdminRemoveSegmentRequestData requestData, Action1<GamePlayerResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminRemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.RemoveSegmentOperationResponse> removeSegmentAsync(GamePlayerModels.AdminRemoveSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminRemoveSegmentOperationRequest, GamePlayerResponseModels.RemoveSegmentOperationResponse>(new GamePlayerRequestModels.AdminRemoveSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeTag(GamePlayerModels.AdminRemoveTagRequestData requestData, Action1<GamePlayerResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminRemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.RemoveTagOperationResponse> removeTagAsync(GamePlayerModels.AdminRemoveTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminRemoveTagOperationRequest, GamePlayerResponseModels.RemoveTagOperationResponse>(new GamePlayerRequestModels.AdminRemoveTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setAvatar(GamePlayerModels.AdminSetAvatarRequestData requestData, Action1<GamePlayerResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminSetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.SetAvatarOperationResponse> setAvatarAsync(GamePlayerModels.AdminSetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminSetAvatarOperationRequest, GamePlayerResponseModels.SetAvatarOperationResponse>(new GamePlayerRequestModels.AdminSetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setCountryCode(GamePlayerModels.AdminSetCountryCodeRequestData requestData, Action1<GamePlayerResponseModels.SetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminSetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.SetCountryCodeOperationResponse> setCountryCodeAsync(GamePlayerModels.AdminSetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminSetCountryCodeOperationRequest, GamePlayerResponseModels.SetCountryCodeOperationResponse>(new GamePlayerRequestModels.AdminSetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setCustomData(GamePlayerModels.AdminSetCustomDataRequestData requestData, Action1<GamePlayerResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminSetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.SetCustomDataOperationResponse> setCustomDataAsync(GamePlayerModels.AdminSetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminSetCustomDataOperationRequest, GamePlayerResponseModels.SetCustomDataOperationResponse>(new GamePlayerRequestModels.AdminSetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setDisplayName(GamePlayerModels.AdminSetDisplayNameRequestData requestData, Action1<GamePlayerResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminSetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.SetDisplayNameOperationResponse> setDisplayNameAsync(GamePlayerModels.AdminSetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminSetDisplayNameOperationRequest, GamePlayerResponseModels.SetDisplayNameOperationResponse>(new GamePlayerRequestModels.AdminSetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setPlayerBan(GamePlayerModels.AdminSetPlayerBanRequestData requestData, Action1<GamePlayerResponseModels.SetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminSetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.SetPlayerBanOperationResponse> setPlayerBanAsync(GamePlayerModels.AdminSetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminSetPlayerBanOperationRequest, GamePlayerResponseModels.SetPlayerBanOperationResponse>(new GamePlayerRequestModels.AdminSetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changePlayerCurrency(GamePlayerModels.AdminChangePlayerCurrencyRequestData requestData, Action1<GamePlayerResponseModels.ChangePlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminChangePlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.ChangePlayerCurrencyOperationResponse> changePlayerCurrencyAsync(GamePlayerModels.AdminChangePlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminChangePlayerCurrencyOperationRequest, GamePlayerResponseModels.ChangePlayerCurrencyOperationResponse>(new GamePlayerRequestModels.AdminChangePlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setPlayerData(GamePlayerModels.AdminSetPlayerDataRequestData requestData, Action1<GamePlayerResponseModels.SetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminSetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.SetPlayerDataOperationResponse> setPlayerDataAsync(GamePlayerModels.AdminSetPlayerDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminSetPlayerDataOperationRequest, GamePlayerResponseModels.SetPlayerDataOperationResponse>(new GamePlayerRequestModels.AdminSetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changePlayerStatistics(GamePlayerModels.AdminChangePlayerStatisticsRequestData requestData, Action1<GamePlayerResponseModels.ChangePlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminChangePlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.ChangePlayerStatisticsOperationResponse> changePlayerStatisticsAsync(GamePlayerModels.AdminChangePlayerStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminChangePlayerStatisticsOperationRequest, GamePlayerResponseModels.ChangePlayerStatisticsOperationResponse>(new GamePlayerRequestModels.AdminChangePlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setTag(GamePlayerModels.AdminSetTagRequestData requestData, Action1<GamePlayerResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminSetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.SetTagOperationResponse> setTagAsync(GamePlayerModels.AdminSetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminSetTagOperationRequest, GamePlayerResponseModels.SetTagOperationResponse>(new GamePlayerRequestModels.AdminSetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCurrencyLeaderboard(GamePlayerModels.AdminGetCurrencyLeaderboardRequestData requestData, Action1<GamePlayerResponseModels.GetCurrencyLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetCurrencyLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetCurrencyLeaderboardOperationResponse> getCurrencyLeaderboardAsync(GamePlayerModels.AdminGetCurrencyLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetCurrencyLeaderboardOperationRequest, GamePlayerResponseModels.GetCurrencyLeaderboardOperationResponse>(new GamePlayerRequestModels.AdminGetCurrencyLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCreateLeaderboard(GamePlayerModels.AdminGetCreateLeaderboardRequestData requestData, Action1<GamePlayerResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(GamePlayerModels.AdminGetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetCreateLeaderboardOperationRequest, GamePlayerResponseModels.GetCreateLeaderboardOperationResponse>(new GamePlayerRequestModels.AdminGetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLog(GamePlayerModels.AdminGetStatisticsLogRequestData requestData, Action1<GamePlayerResponseModels.GetStatisticsLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetStatisticsLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetStatisticsLogOperationResponse> getStatisticsLogAsync(GamePlayerModels.AdminGetStatisticsLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetStatisticsLogOperationRequest, GamePlayerResponseModels.GetStatisticsLogOperationResponse>(new GamePlayerRequestModels.AdminGetStatisticsLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCurrencyLog(GamePlayerModels.AdminGetCurrencyLogRequestData requestData, Action1<GamePlayerResponseModels.GetCurrencyLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetCurrencyLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<GamePlayerResponseModels.GetCurrencyLogOperationResponse> getCurrencyLogAsync(GamePlayerModels.AdminGetCurrencyLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<GamePlayerRequestModels.AdminGetCurrencyLogOperationRequest, GamePlayerResponseModels.GetCurrencyLogOperationResponse>(new GamePlayerRequestModels.AdminGetCurrencyLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

    }

    public static partial class GNNetwork
    {

        public static GamePlayerApi gamePlayer { get; }
    }

}
