namespace XmobiTea.GearN
{
    using System.Threading.Tasks;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Models;

    public class MasterPlayerApi
    {
        public ServerApi server { get; } = new ServerApi();

        public AdminApi admin { get; } = new AdminApi();

        public void addSegment(MasterPlayerModels.AddSegmentRequestData requestData, Action1<MasterPlayerResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.AddSegmentOperationResponse> addSegmentAsync(MasterPlayerModels.AddSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AddSegmentOperationRequest, MasterPlayerResponseModels.AddSegmentOperationResponse>(new MasterPlayerRequestModels.AddSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void changeAccountPassword(MasterPlayerModels.ChangeAccountPasswordRequestData requestData, Action1<MasterPlayerResponseModels.ChangeAccountPasswordOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ChangeAccountPasswordOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.ChangeAccountPasswordOperationResponse> changeAccountPasswordAsync(MasterPlayerModels.ChangeAccountPasswordRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ChangeAccountPasswordOperationRequest, MasterPlayerResponseModels.ChangeAccountPasswordOperationResponse>(new MasterPlayerRequestModels.ChangeAccountPasswordOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getAvatar(MasterPlayerModels.GetAvatarRequestData requestData, Action1<MasterPlayerResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetAvatarOperationResponse> getAvatarAsync(MasterPlayerModels.GetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetAvatarOperationRequest, MasterPlayerResponseModels.GetAvatarOperationResponse>(new MasterPlayerRequestModels.GetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCountryCode(MasterPlayerModels.GetCountryCodeRequestData requestData, Action1<MasterPlayerResponseModels.GetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetCountryCodeOperationResponse> getCountryCodeAsync(MasterPlayerModels.GetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetCountryCodeOperationRequest, MasterPlayerResponseModels.GetCountryCodeOperationResponse>(new MasterPlayerRequestModels.GetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCustomData(MasterPlayerModels.GetCustomDataRequestData requestData, Action1<MasterPlayerResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetCustomDataOperationResponse> getCustomDataAsync(MasterPlayerModels.GetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetCustomDataOperationRequest, MasterPlayerResponseModels.GetCustomDataOperationResponse>(new MasterPlayerRequestModels.GetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getDisplayName(MasterPlayerModels.GetDisplayNameRequestData requestData, Action1<MasterPlayerResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetDisplayNameOperationResponse> getDisplayNameAsync(MasterPlayerModels.GetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetDisplayNameOperationRequest, MasterPlayerResponseModels.GetDisplayNameOperationResponse>(new MasterPlayerRequestModels.GetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getEmail(MasterPlayerModels.GetEmailRequestData requestData, Action1<MasterPlayerResponseModels.GetEmailOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetEmailOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetEmailOperationResponse> getEmailAsync(MasterPlayerModels.GetEmailRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetEmailOperationRequest, MasterPlayerResponseModels.GetEmailOperationResponse>(new MasterPlayerRequestModels.GetEmailOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getExternal(MasterPlayerModels.GetExternalRequestData requestData, Action1<MasterPlayerResponseModels.GetExternalOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetExternalOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetExternalOperationResponse> getExternalAsync(MasterPlayerModels.GetExternalRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetExternalOperationRequest, MasterPlayerResponseModels.GetExternalOperationResponse>(new MasterPlayerRequestModels.GetExternalOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getIpAddressCreate(MasterPlayerModels.GetIpAddressCreateRequestData requestData, Action1<MasterPlayerResponseModels.GetIpAddressCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetIpAddressCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetIpAddressCreateOperationResponse> getIpAddressCreateAsync(MasterPlayerModels.GetIpAddressCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetIpAddressCreateOperationRequest, MasterPlayerResponseModels.GetIpAddressCreateOperationResponse>(new MasterPlayerRequestModels.GetIpAddressCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerBan(MasterPlayerModels.GetPlayerBanRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetPlayerBanOperationResponse> getPlayerBanAsync(MasterPlayerModels.GetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetPlayerBanOperationRequest, MasterPlayerResponseModels.GetPlayerBanOperationResponse>(new MasterPlayerRequestModels.GetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerCurrency(MasterPlayerModels.GetPlayerCurrencyRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetPlayerCurrencyOperationResponse> getPlayerCurrencyAsync(MasterPlayerModels.GetPlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetPlayerCurrencyOperationRequest, MasterPlayerResponseModels.GetPlayerCurrencyOperationResponse>(new MasterPlayerRequestModels.GetPlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerData(MasterPlayerModels.GetPlayerDataRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetPlayerDataOperationResponse> getPlayerDataAsync(MasterPlayerModels.GetPlayerDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetPlayerDataOperationRequest, MasterPlayerResponseModels.GetPlayerDataOperationResponse>(new MasterPlayerRequestModels.GetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerInformation(MasterPlayerModels.GetPlayerInformationRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayerInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayerInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetPlayerInformationOperationResponse> getPlayerInformationAsync(MasterPlayerModels.GetPlayerInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetPlayerInformationOperationRequest, MasterPlayerResponseModels.GetPlayerInformationOperationResponse>(new MasterPlayerRequestModels.GetPlayerInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayerStatistics(MasterPlayerModels.GetPlayerStatisticsRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetPlayerStatisticsOperationResponse> getPlayerStatisticsAsync(MasterPlayerModels.GetPlayerStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetPlayerStatisticsOperationRequest, MasterPlayerResponseModels.GetPlayerStatisticsOperationResponse>(new MasterPlayerRequestModels.GetPlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayersWithApple(MasterPlayerModels.GetPlayersWithAppleRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayersWithAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetPlayersWithAppleOperationResponse> getPlayersWithAppleAsync(MasterPlayerModels.GetPlayersWithAppleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetPlayersWithAppleOperationRequest, MasterPlayerResponseModels.GetPlayersWithAppleOperationResponse>(new MasterPlayerRequestModels.GetPlayersWithAppleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayersWithDisplayName(MasterPlayerModels.GetPlayersWithDisplayNameRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayersWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> getPlayersWithDisplayNameAsync(MasterPlayerModels.GetPlayersWithDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetPlayersWithDisplayNameOperationRequest, MasterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse>(new MasterPlayerRequestModels.GetPlayersWithDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayersWithFacebook(MasterPlayerModels.GetPlayersWithFacebookRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayersWithFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetPlayersWithFacebookOperationResponse> getPlayersWithFacebookAsync(MasterPlayerModels.GetPlayersWithFacebookRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetPlayersWithFacebookOperationRequest, MasterPlayerResponseModels.GetPlayersWithFacebookOperationResponse>(new MasterPlayerRequestModels.GetPlayersWithFacebookOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayersWithGenericService(MasterPlayerModels.GetPlayersWithGenericServiceRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayersWithGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetPlayersWithGenericServiceOperationResponse> getPlayersWithGenericServiceAsync(MasterPlayerModels.GetPlayersWithGenericServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetPlayersWithGenericServiceOperationRequest, MasterPlayerResponseModels.GetPlayersWithGenericServiceOperationResponse>(new MasterPlayerRequestModels.GetPlayersWithGenericServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayersWithGoogle(MasterPlayerModels.GetPlayersWithGoogleRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayersWithGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetPlayersWithGoogleOperationResponse> getPlayersWithGoogleAsync(MasterPlayerModels.GetPlayersWithGoogleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetPlayersWithGoogleOperationRequest, MasterPlayerResponseModels.GetPlayersWithGoogleOperationResponse>(new MasterPlayerRequestModels.GetPlayersWithGoogleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayersWithGooglePlayGameService(MasterPlayerModels.GetPlayersWithGooglePlayGameServiceRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithGooglePlayGameServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayersWithGooglePlayGameServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetPlayersWithGooglePlayGameServiceOperationResponse> getPlayersWithGooglePlayGameServiceAsync(MasterPlayerModels.GetPlayersWithGooglePlayGameServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetPlayersWithGooglePlayGameServiceOperationRequest, MasterPlayerResponseModels.GetPlayersWithGooglePlayGameServiceOperationResponse>(new MasterPlayerRequestModels.GetPlayersWithGooglePlayGameServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayersWithGameCenter(MasterPlayerModels.GetPlayersWithGameCenterRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithGameCenterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayersWithGameCenterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetPlayersWithGameCenterOperationResponse> getPlayersWithGameCenterAsync(MasterPlayerModels.GetPlayersWithGameCenterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetPlayersWithGameCenterOperationRequest, MasterPlayerResponseModels.GetPlayersWithGameCenterOperationResponse>(new MasterPlayerRequestModels.GetPlayersWithGameCenterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayersWithSegment(MasterPlayerModels.GetPlayersWithSegmentRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayersWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> getPlayersWithSegmentAsync(MasterPlayerModels.GetPlayersWithSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetPlayersWithSegmentOperationRequest, MasterPlayerResponseModels.GetPlayersWithSegmentOperationResponse>(new MasterPlayerRequestModels.GetPlayersWithSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPlayersWithTag(MasterPlayerModels.GetPlayersWithTagRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayersWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetPlayersWithTagOperationResponse> getPlayersWithTagAsync(MasterPlayerModels.GetPlayersWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetPlayersWithTagOperationRequest, MasterPlayerResponseModels.GetPlayersWithTagOperationResponse>(new MasterPlayerRequestModels.GetPlayersWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getSegment(MasterPlayerModels.GetSegmentRequestData requestData, Action1<MasterPlayerResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetSegmentOperationResponse> getSegmentAsync(MasterPlayerModels.GetSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetSegmentOperationRequest, MasterPlayerResponseModels.GetSegmentOperationResponse>(new MasterPlayerRequestModels.GetSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStatisticsLeaderboardAroundPlayer(MasterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, Action1<MasterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> getStatisticsLeaderboardAroundPlayerAsync(MasterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetStatisticsLeaderboardAroundPlayerOperationRequest, MasterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse>(new MasterPlayerRequestModels.GetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStatisticsLeaderboard(MasterPlayerModels.GetStatisticsLeaderboardRequestData requestData, Action1<MasterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> getStatisticsLeaderboardAsync(MasterPlayerModels.GetStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetStatisticsLeaderboardOperationRequest, MasterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse>(new MasterPlayerRequestModels.GetStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getTag(MasterPlayerModels.GetTagRequestData requestData, Action1<MasterPlayerResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetTagOperationResponse> getTagAsync(MasterPlayerModels.GetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetTagOperationRequest, MasterPlayerResponseModels.GetTagOperationResponse>(new MasterPlayerRequestModels.GetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getTsCreate(MasterPlayerModels.GetTsCreateRequestData requestData, Action1<MasterPlayerResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetTsCreateOperationResponse> getTsCreateAsync(MasterPlayerModels.GetTsCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetTsCreateOperationRequest, MasterPlayerResponseModels.GetTsCreateOperationResponse>(new MasterPlayerRequestModels.GetTsCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getTsLastLogin(MasterPlayerModels.GetTsLastLoginRequestData requestData, Action1<MasterPlayerResponseModels.GetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetTsLastLoginOperationResponse> getTsLastLoginAsync(MasterPlayerModels.GetTsLastLoginRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetTsLastLoginOperationRequest, MasterPlayerResponseModels.GetTsLastLoginOperationResponse>(new MasterPlayerRequestModels.GetTsLastLoginOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void linkAccount(MasterPlayerModels.LinkAccountRequestData requestData, Action1<MasterPlayerResponseModels.LinkAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.LinkAccountOperationResponse> linkAccountAsync(MasterPlayerModels.LinkAccountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.LinkAccountOperationRequest, MasterPlayerResponseModels.LinkAccountOperationResponse>(new MasterPlayerRequestModels.LinkAccountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void linkAndroidDeviceId(MasterPlayerModels.LinkAndroidDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkAndroidDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkAndroidDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.LinkAndroidDeviceIdOperationResponse> linkAndroidDeviceIdAsync(MasterPlayerModels.LinkAndroidDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.LinkAndroidDeviceIdOperationRequest, MasterPlayerResponseModels.LinkAndroidDeviceIdOperationResponse>(new MasterPlayerRequestModels.LinkAndroidDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void linkApple(MasterPlayerModels.LinkAppleRequestData requestData, Action1<MasterPlayerResponseModels.LinkAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.LinkAppleOperationResponse> linkAppleAsync(MasterPlayerModels.LinkAppleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.LinkAppleOperationRequest, MasterPlayerResponseModels.LinkAppleOperationResponse>(new MasterPlayerRequestModels.LinkAppleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void linkCustomDeviceId(MasterPlayerModels.LinkCustomDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkCustomDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkCustomDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.LinkCustomDeviceIdOperationResponse> linkCustomDeviceIdAsync(MasterPlayerModels.LinkCustomDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.LinkCustomDeviceIdOperationRequest, MasterPlayerResponseModels.LinkCustomDeviceIdOperationResponse>(new MasterPlayerRequestModels.LinkCustomDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void linkCustomId(MasterPlayerModels.LinkCustomIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkCustomIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkCustomIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.LinkCustomIdOperationResponse> linkCustomIdAsync(MasterPlayerModels.LinkCustomIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.LinkCustomIdOperationRequest, MasterPlayerResponseModels.LinkCustomIdOperationResponse>(new MasterPlayerRequestModels.LinkCustomIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void linkEditorDeviceId(MasterPlayerModels.LinkEditorDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkEditorDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkEditorDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.LinkEditorDeviceIdOperationResponse> linkEditorDeviceIdAsync(MasterPlayerModels.LinkEditorDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.LinkEditorDeviceIdOperationRequest, MasterPlayerResponseModels.LinkEditorDeviceIdOperationResponse>(new MasterPlayerRequestModels.LinkEditorDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void linkFacebook(MasterPlayerModels.LinkFacebookRequestData requestData, Action1<MasterPlayerResponseModels.LinkFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.LinkFacebookOperationResponse> linkFacebookAsync(MasterPlayerModels.LinkFacebookRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.LinkFacebookOperationRequest, MasterPlayerResponseModels.LinkFacebookOperationResponse>(new MasterPlayerRequestModels.LinkFacebookOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void linkGenericService(MasterPlayerModels.LinkGenericServiceRequestData requestData, Action1<MasterPlayerResponseModels.LinkGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.LinkGenericServiceOperationResponse> linkGenericServiceAsync(MasterPlayerModels.LinkGenericServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.LinkGenericServiceOperationRequest, MasterPlayerResponseModels.LinkGenericServiceOperationResponse>(new MasterPlayerRequestModels.LinkGenericServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void linkGoogle(MasterPlayerModels.LinkGoogleRequestData requestData, Action1<MasterPlayerResponseModels.LinkGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.LinkGoogleOperationResponse> linkGoogleAsync(MasterPlayerModels.LinkGoogleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.LinkGoogleOperationRequest, MasterPlayerResponseModels.LinkGoogleOperationResponse>(new MasterPlayerRequestModels.LinkGoogleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void linkGooglePlayGameService(MasterPlayerModels.LinkGooglePlayGameServiceRequestData requestData, Action1<MasterPlayerResponseModels.LinkGooglePlayGameServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkGooglePlayGameServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.LinkGooglePlayGameServiceOperationResponse> linkGooglePlayGameServiceAsync(MasterPlayerModels.LinkGooglePlayGameServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.LinkGooglePlayGameServiceOperationRequest, MasterPlayerResponseModels.LinkGooglePlayGameServiceOperationResponse>(new MasterPlayerRequestModels.LinkGooglePlayGameServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void linkGameCenter(MasterPlayerModels.LinkGameCenterRequestData requestData, Action1<MasterPlayerResponseModels.LinkGameCenterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkGameCenterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.LinkGameCenterOperationResponse> linkGameCenterAsync(MasterPlayerModels.LinkGameCenterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.LinkGameCenterOperationRequest, MasterPlayerResponseModels.LinkGameCenterOperationResponse>(new MasterPlayerRequestModels.LinkGameCenterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void linkiOSDeviceId(MasterPlayerModels.LinkiOSDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkiOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkiOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.LinkiOSDeviceIdOperationResponse> linkiOSDeviceIdAsync(MasterPlayerModels.LinkiOSDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.LinkiOSDeviceIdOperationRequest, MasterPlayerResponseModels.LinkiOSDeviceIdOperationResponse>(new MasterPlayerRequestModels.LinkiOSDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void linkLinuxDeviceId(MasterPlayerModels.LinkLinuxDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkLinuxDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkLinuxDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.LinkLinuxDeviceIdOperationResponse> linkLinuxDeviceIdAsync(MasterPlayerModels.LinkLinuxDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.LinkLinuxDeviceIdOperationRequest, MasterPlayerResponseModels.LinkLinuxDeviceIdOperationResponse>(new MasterPlayerRequestModels.LinkLinuxDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void linkMacOSDeviceId(MasterPlayerModels.LinkMacOSDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkMacOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkMacOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.LinkMacOSDeviceIdOperationResponse> linkMacOSDeviceIdAsync(MasterPlayerModels.LinkMacOSDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.LinkMacOSDeviceIdOperationRequest, MasterPlayerResponseModels.LinkMacOSDeviceIdOperationResponse>(new MasterPlayerRequestModels.LinkMacOSDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void linkWindowsDeviceId(MasterPlayerModels.LinkWindowsDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkWindowsDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkWindowsDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.LinkWindowsDeviceIdOperationResponse> linkWindowsDeviceIdAsync(MasterPlayerModels.LinkWindowsDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.LinkWindowsDeviceIdOperationRequest, MasterPlayerResponseModels.LinkWindowsDeviceIdOperationResponse>(new MasterPlayerRequestModels.LinkWindowsDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void linkWindowsPhoneDeviceId(MasterPlayerModels.LinkWindowsPhoneDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkWindowsPhoneDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.LinkWindowsPhoneDeviceIdOperationResponse> linkWindowsPhoneDeviceIdAsync(MasterPlayerModels.LinkWindowsPhoneDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.LinkWindowsPhoneDeviceIdOperationRequest, MasterPlayerResponseModels.LinkWindowsPhoneDeviceIdOperationResponse>(new MasterPlayerRequestModels.LinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removeSegment(MasterPlayerModels.RemoveSegmentRequestData requestData, Action1<MasterPlayerResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.RemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.RemoveSegmentOperationResponse> removeSegmentAsync(MasterPlayerModels.RemoveSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.RemoveSegmentOperationRequest, MasterPlayerResponseModels.RemoveSegmentOperationResponse>(new MasterPlayerRequestModels.RemoveSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removeTag(MasterPlayerModels.RemoveTagRequestData requestData, Action1<MasterPlayerResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.RemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.RemoveTagOperationResponse> removeTagAsync(MasterPlayerModels.RemoveTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.RemoveTagOperationRequest, MasterPlayerResponseModels.RemoveTagOperationResponse>(new MasterPlayerRequestModels.RemoveTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void resetAccountPassword(MasterPlayerModels.ResetAccountPasswordRequestData requestData, Action1<MasterPlayerResponseModels.ResetAccountPasswordOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ResetAccountPasswordOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.ResetAccountPasswordOperationResponse> resetAccountPasswordAsync(MasterPlayerModels.ResetAccountPasswordRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ResetAccountPasswordOperationRequest, MasterPlayerResponseModels.ResetAccountPasswordOperationResponse>(new MasterPlayerRequestModels.ResetAccountPasswordOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setAvatar(MasterPlayerModels.SetAvatarRequestData requestData, Action1<MasterPlayerResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.SetAvatarOperationResponse> setAvatarAsync(MasterPlayerModels.SetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.SetAvatarOperationRequest, MasterPlayerResponseModels.SetAvatarOperationResponse>(new MasterPlayerRequestModels.SetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setCountryCode(MasterPlayerModels.SetCountryCodeRequestData requestData, Action1<MasterPlayerResponseModels.SetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.SetCountryCodeOperationResponse> setCountryCodeAsync(MasterPlayerModels.SetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.SetCountryCodeOperationRequest, MasterPlayerResponseModels.SetCountryCodeOperationResponse>(new MasterPlayerRequestModels.SetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setCustomData(MasterPlayerModels.SetCustomDataRequestData requestData, Action1<MasterPlayerResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.SetCustomDataOperationResponse> setCustomDataAsync(MasterPlayerModels.SetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.SetCustomDataOperationRequest, MasterPlayerResponseModels.SetCustomDataOperationResponse>(new MasterPlayerRequestModels.SetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setDisplayName(MasterPlayerModels.SetDisplayNameRequestData requestData, Action1<MasterPlayerResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.SetDisplayNameOperationResponse> setDisplayNameAsync(MasterPlayerModels.SetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.SetDisplayNameOperationRequest, MasterPlayerResponseModels.SetDisplayNameOperationResponse>(new MasterPlayerRequestModels.SetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setEmail(MasterPlayerModels.SetEmailRequestData requestData, Action1<MasterPlayerResponseModels.SetEmailOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetEmailOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.SetEmailOperationResponse> setEmailAsync(MasterPlayerModels.SetEmailRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.SetEmailOperationRequest, MasterPlayerResponseModels.SetEmailOperationResponse>(new MasterPlayerRequestModels.SetEmailOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setPlayerBan(MasterPlayerModels.SetPlayerBanRequestData requestData, Action1<MasterPlayerResponseModels.SetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.SetPlayerBanOperationResponse> setPlayerBanAsync(MasterPlayerModels.SetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.SetPlayerBanOperationRequest, MasterPlayerResponseModels.SetPlayerBanOperationResponse>(new MasterPlayerRequestModels.SetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void changePlayerCurrency(MasterPlayerModels.ChangePlayerCurrencyRequestData requestData, Action1<MasterPlayerResponseModels.ChangePlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ChangePlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.ChangePlayerCurrencyOperationResponse> changePlayerCurrencyAsync(MasterPlayerModels.ChangePlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ChangePlayerCurrencyOperationRequest, MasterPlayerResponseModels.ChangePlayerCurrencyOperationResponse>(new MasterPlayerRequestModels.ChangePlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setPlayerData(MasterPlayerModels.SetPlayerDataRequestData requestData, Action1<MasterPlayerResponseModels.SetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.SetPlayerDataOperationResponse> setPlayerDataAsync(MasterPlayerModels.SetPlayerDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.SetPlayerDataOperationRequest, MasterPlayerResponseModels.SetPlayerDataOperationResponse>(new MasterPlayerRequestModels.SetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void changePlayerStatistics(MasterPlayerModels.ChangePlayerStatisticsRequestData requestData, Action1<MasterPlayerResponseModels.ChangePlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ChangePlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.ChangePlayerStatisticsOperationResponse> changePlayerStatisticsAsync(MasterPlayerModels.ChangePlayerStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ChangePlayerStatisticsOperationRequest, MasterPlayerResponseModels.ChangePlayerStatisticsOperationResponse>(new MasterPlayerRequestModels.ChangePlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setTag(MasterPlayerModels.SetTagRequestData requestData, Action1<MasterPlayerResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.SetTagOperationResponse> setTagAsync(MasterPlayerModels.SetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.SetTagOperationRequest, MasterPlayerResponseModels.SetTagOperationResponse>(new MasterPlayerRequestModels.SetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setTsLastLogin(MasterPlayerModels.SetTsLastLoginRequestData requestData, Action1<MasterPlayerResponseModels.SetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.SetTsLastLoginOperationResponse> setTsLastLoginAsync(MasterPlayerModels.SetTsLastLoginRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.SetTsLastLoginOperationRequest, MasterPlayerResponseModels.SetTsLastLoginOperationResponse>(new MasterPlayerRequestModels.SetTsLastLoginOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void unlinkAccount(MasterPlayerModels.UnlinkAccountRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.UnlinkAccountOperationResponse> unlinkAccountAsync(MasterPlayerModels.UnlinkAccountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.UnlinkAccountOperationRequest, MasterPlayerResponseModels.UnlinkAccountOperationResponse>(new MasterPlayerRequestModels.UnlinkAccountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void unlinkAndroidDeviceId(MasterPlayerModels.UnlinkAndroidDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkAndroidDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkAndroidDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.UnlinkAndroidDeviceIdOperationResponse> unlinkAndroidDeviceIdAsync(MasterPlayerModels.UnlinkAndroidDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.UnlinkAndroidDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkAndroidDeviceIdOperationResponse>(new MasterPlayerRequestModels.UnlinkAndroidDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void unlinkApple(MasterPlayerModels.UnlinkAppleRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.UnlinkAppleOperationResponse> unlinkAppleAsync(MasterPlayerModels.UnlinkAppleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.UnlinkAppleOperationRequest, MasterPlayerResponseModels.UnlinkAppleOperationResponse>(new MasterPlayerRequestModels.UnlinkAppleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void unlinkCustomDeviceId(MasterPlayerModels.UnlinkCustomDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkCustomDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkCustomDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.UnlinkCustomDeviceIdOperationResponse> unlinkCustomDeviceIdAsync(MasterPlayerModels.UnlinkCustomDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.UnlinkCustomDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkCustomDeviceIdOperationResponse>(new MasterPlayerRequestModels.UnlinkCustomDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void unlinkCustomId(MasterPlayerModels.UnlinkCustomIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkCustomIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkCustomIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.UnlinkCustomIdOperationResponse> unlinkCustomIdAsync(MasterPlayerModels.UnlinkCustomIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.UnlinkCustomIdOperationRequest, MasterPlayerResponseModels.UnlinkCustomIdOperationResponse>(new MasterPlayerRequestModels.UnlinkCustomIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void unlinkEditorDeviceId(MasterPlayerModels.UnlinkEditorDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkEditorDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkEditorDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.UnlinkEditorDeviceIdOperationResponse> unlinkEditorDeviceIdAsync(MasterPlayerModels.UnlinkEditorDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.UnlinkEditorDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkEditorDeviceIdOperationResponse>(new MasterPlayerRequestModels.UnlinkEditorDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void unlinkFacebook(MasterPlayerModels.UnlinkFacebookRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.UnlinkFacebookOperationResponse> unlinkFacebookAsync(MasterPlayerModels.UnlinkFacebookRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.UnlinkFacebookOperationRequest, MasterPlayerResponseModels.UnlinkFacebookOperationResponse>(new MasterPlayerRequestModels.UnlinkFacebookOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void unlinkGenericService(MasterPlayerModels.UnlinkGenericServiceRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.UnlinkGenericServiceOperationResponse> unlinkGenericServiceAsync(MasterPlayerModels.UnlinkGenericServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.UnlinkGenericServiceOperationRequest, MasterPlayerResponseModels.UnlinkGenericServiceOperationResponse>(new MasterPlayerRequestModels.UnlinkGenericServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void unlinkGoogle(MasterPlayerModels.UnlinkGoogleRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.UnlinkGoogleOperationResponse> unlinkGoogleAsync(MasterPlayerModels.UnlinkGoogleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.UnlinkGoogleOperationRequest, MasterPlayerResponseModels.UnlinkGoogleOperationResponse>(new MasterPlayerRequestModels.UnlinkGoogleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void unlinkGooglePlayGameService(MasterPlayerModels.UnlinkGooglePlayGameServiceRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkGooglePlayGameServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkGooglePlayGameServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.UnlinkGooglePlayGameServiceOperationResponse> unlinkGooglePlayGameServiceAsync(MasterPlayerModels.UnlinkGooglePlayGameServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.UnlinkGooglePlayGameServiceOperationRequest, MasterPlayerResponseModels.UnlinkGooglePlayGameServiceOperationResponse>(new MasterPlayerRequestModels.UnlinkGooglePlayGameServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void unlinkGameCenter(MasterPlayerModels.UnlinkGameCenterRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkGameCenterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkGameCenterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.UnlinkGameCenterOperationResponse> unlinkGameCenterAsync(MasterPlayerModels.UnlinkGameCenterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.UnlinkGameCenterOperationRequest, MasterPlayerResponseModels.UnlinkGameCenterOperationResponse>(new MasterPlayerRequestModels.UnlinkGameCenterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void unlinkiOSDeviceId(MasterPlayerModels.UnlinkiOSDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkiOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkiOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.UnlinkiOSDeviceIdOperationResponse> unlinkiOSDeviceIdAsync(MasterPlayerModels.UnlinkiOSDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.UnlinkiOSDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkiOSDeviceIdOperationResponse>(new MasterPlayerRequestModels.UnlinkiOSDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void unlinkLinuxDeviceId(MasterPlayerModels.UnlinkLinuxDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkLinuxDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkLinuxDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.UnlinkLinuxDeviceIdOperationResponse> unlinkLinuxDeviceIdAsync(MasterPlayerModels.UnlinkLinuxDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.UnlinkLinuxDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkLinuxDeviceIdOperationResponse>(new MasterPlayerRequestModels.UnlinkLinuxDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void unlinkMacOSDeviceId(MasterPlayerModels.UnlinkMacOSDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkMacOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkMacOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.UnlinkMacOSDeviceIdOperationResponse> unlinkMacOSDeviceIdAsync(MasterPlayerModels.UnlinkMacOSDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.UnlinkMacOSDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkMacOSDeviceIdOperationResponse>(new MasterPlayerRequestModels.UnlinkMacOSDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void unlinkWindowsDeviceId(MasterPlayerModels.UnlinkWindowsDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkWindowsDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkWindowsDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.UnlinkWindowsDeviceIdOperationResponse> unlinkWindowsDeviceIdAsync(MasterPlayerModels.UnlinkWindowsDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.UnlinkWindowsDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkWindowsDeviceIdOperationResponse>(new MasterPlayerRequestModels.UnlinkWindowsDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void unlinkWindowsPhoneDeviceId(MasterPlayerModels.UnlinkWindowsPhoneDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkWindowsPhoneDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.UnlinkWindowsPhoneDeviceIdOperationResponse> unlinkWindowsPhoneDeviceIdAsync(MasterPlayerModels.UnlinkWindowsPhoneDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.UnlinkWindowsPhoneDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkWindowsPhoneDeviceIdOperationResponse>(new MasterPlayerRequestModels.UnlinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCurrencyLeaderboard(MasterPlayerModels.GetCurrencyLeaderboardRequestData requestData, Action1<MasterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetCurrencyLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse> getCurrencyLeaderboardAsync(MasterPlayerModels.GetCurrencyLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetCurrencyLeaderboardOperationRequest, MasterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse>(new MasterPlayerRequestModels.GetCurrencyLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getLastLoginLeaderboard(MasterPlayerModels.GetLastLoginLeaderboardRequestData requestData, Action1<MasterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetLastLoginLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse> getLastLoginLeaderboardAsync(MasterPlayerModels.GetLastLoginLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetLastLoginLeaderboardOperationRequest, MasterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse>(new MasterPlayerRequestModels.GetLastLoginLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCreateLeaderboard(MasterPlayerModels.GetCreateLeaderboardRequestData requestData, Action1<MasterPlayerResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(MasterPlayerModels.GetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetCreateLeaderboardOperationRequest, MasterPlayerResponseModels.GetCreateLeaderboardOperationResponse>(new MasterPlayerRequestModels.GetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStatisticsLog(MasterPlayerModels.GetStatisticsLogRequestData requestData, Action1<MasterPlayerResponseModels.GetStatisticsLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetStatisticsLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetStatisticsLogOperationResponse> getStatisticsLogAsync(MasterPlayerModels.GetStatisticsLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetStatisticsLogOperationRequest, MasterPlayerResponseModels.GetStatisticsLogOperationResponse>(new MasterPlayerRequestModels.GetStatisticsLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCurrencyLog(MasterPlayerModels.GetCurrencyLogRequestData requestData, Action1<MasterPlayerResponseModels.GetCurrencyLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetCurrencyLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetCurrencyLogOperationResponse> getCurrencyLogAsync(MasterPlayerModels.GetCurrencyLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetCurrencyLogOperationRequest, MasterPlayerResponseModels.GetCurrencyLogOperationResponse>(new MasterPlayerRequestModels.GetCurrencyLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void sendSocketOperationEvent(MasterPlayerModels.SendSocketOperationEventRequestData requestData, Action1<MasterPlayerResponseModels.SendSocketOperationEventOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SendSocketOperationEventOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.SendSocketOperationEventOperationResponse> sendSocketOperationEventAsync(MasterPlayerModels.SendSocketOperationEventRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.SendSocketOperationEventOperationRequest, MasterPlayerResponseModels.SendSocketOperationEventOperationResponse>(new MasterPlayerRequestModels.SendSocketOperationEventOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void sendEmail(MasterPlayerModels.SendEmailRequestData requestData, Action1<MasterPlayerResponseModels.SendEmailOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SendEmailOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.SendEmailOperationResponse> sendEmailAsync(MasterPlayerModels.SendEmailRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.SendEmailOperationRequest, MasterPlayerResponseModels.SendEmailOperationResponse>(new MasterPlayerRequestModels.SendEmailOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void addPushNotification(MasterPlayerModels.AddPushNotificationRequestData requestData, Action1<MasterPlayerResponseModels.AddPushNotificationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AddPushNotificationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.AddPushNotificationOperationResponse> addPushNotificationAsync(MasterPlayerModels.AddPushNotificationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AddPushNotificationOperationRequest, MasterPlayerResponseModels.AddPushNotificationOperationResponse>(new MasterPlayerRequestModels.AddPushNotificationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removePushNotification(MasterPlayerModels.RemovePushNotificationRequestData requestData, Action1<MasterPlayerResponseModels.RemovePushNotificationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.RemovePushNotificationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.RemovePushNotificationOperationResponse> removePushNotificationAsync(MasterPlayerModels.RemovePushNotificationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.RemovePushNotificationOperationRequest, MasterPlayerResponseModels.RemovePushNotificationOperationResponse>(new MasterPlayerRequestModels.RemovePushNotificationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getPushNotification(MasterPlayerModels.GetPushNotificationRequestData requestData, Action1<MasterPlayerResponseModels.GetPushNotificationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPushNotificationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.GetPushNotificationOperationResponse> getPushNotificationAsync(MasterPlayerModels.GetPushNotificationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.GetPushNotificationOperationRequest, MasterPlayerResponseModels.GetPushNotificationOperationResponse>(new MasterPlayerRequestModels.GetPushNotificationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void sendPushNotification(MasterPlayerModels.SendPushNotificationRequestData requestData, Action1<MasterPlayerResponseModels.SendPushNotificationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SendPushNotificationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MasterPlayerResponseModels.SendPushNotificationOperationResponse> sendPushNotificationAsync(MasterPlayerModels.SendPushNotificationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.SendPushNotificationOperationRequest, MasterPlayerResponseModels.SendPushNotificationOperationResponse>(new MasterPlayerRequestModels.SendPushNotificationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public class ServerApi
        {
            public void addSegment(MasterPlayerModels.ServerAddSegmentRequestData requestData, Action1<MasterPlayerResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerAddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.AddSegmentOperationResponse> addSegmentAsync(MasterPlayerModels.ServerAddSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerAddSegmentOperationRequest, MasterPlayerResponseModels.AddSegmentOperationResponse>(new MasterPlayerRequestModels.ServerAddSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getAvatar(MasterPlayerModels.ServerGetAvatarRequestData requestData, Action1<MasterPlayerResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetAvatarOperationResponse> getAvatarAsync(MasterPlayerModels.ServerGetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetAvatarOperationRequest, MasterPlayerResponseModels.GetAvatarOperationResponse>(new MasterPlayerRequestModels.ServerGetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCountryCode(MasterPlayerModels.ServerGetCountryCodeRequestData requestData, Action1<MasterPlayerResponseModels.GetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetCountryCodeOperationResponse> getCountryCodeAsync(MasterPlayerModels.ServerGetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetCountryCodeOperationRequest, MasterPlayerResponseModels.GetCountryCodeOperationResponse>(new MasterPlayerRequestModels.ServerGetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCustomData(MasterPlayerModels.ServerGetCustomDataRequestData requestData, Action1<MasterPlayerResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetCustomDataOperationResponse> getCustomDataAsync(MasterPlayerModels.ServerGetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetCustomDataOperationRequest, MasterPlayerResponseModels.GetCustomDataOperationResponse>(new MasterPlayerRequestModels.ServerGetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getDisplayName(MasterPlayerModels.ServerGetDisplayNameRequestData requestData, Action1<MasterPlayerResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetDisplayNameOperationResponse> getDisplayNameAsync(MasterPlayerModels.ServerGetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetDisplayNameOperationRequest, MasterPlayerResponseModels.GetDisplayNameOperationResponse>(new MasterPlayerRequestModels.ServerGetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getEmail(MasterPlayerModels.ServerGetEmailRequestData requestData, Action1<MasterPlayerResponseModels.GetEmailOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetEmailOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetEmailOperationResponse> getEmailAsync(MasterPlayerModels.ServerGetEmailRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetEmailOperationRequest, MasterPlayerResponseModels.GetEmailOperationResponse>(new MasterPlayerRequestModels.ServerGetEmailOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getExternal(MasterPlayerModels.ServerGetExternalRequestData requestData, Action1<MasterPlayerResponseModels.GetExternalOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetExternalOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetExternalOperationResponse> getExternalAsync(MasterPlayerModels.ServerGetExternalRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetExternalOperationRequest, MasterPlayerResponseModels.GetExternalOperationResponse>(new MasterPlayerRequestModels.ServerGetExternalOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getIpAddressCreate(MasterPlayerModels.ServerGetIpAddressCreateRequestData requestData, Action1<MasterPlayerResponseModels.GetIpAddressCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetIpAddressCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetIpAddressCreateOperationResponse> getIpAddressCreateAsync(MasterPlayerModels.ServerGetIpAddressCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetIpAddressCreateOperationRequest, MasterPlayerResponseModels.GetIpAddressCreateOperationResponse>(new MasterPlayerRequestModels.ServerGetIpAddressCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerBan(MasterPlayerModels.ServerGetPlayerBanRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayerBanOperationResponse> getPlayerBanAsync(MasterPlayerModels.ServerGetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetPlayerBanOperationRequest, MasterPlayerResponseModels.GetPlayerBanOperationResponse>(new MasterPlayerRequestModels.ServerGetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerCurrency(MasterPlayerModels.ServerGetPlayerCurrencyRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayerCurrencyOperationResponse> getPlayerCurrencyAsync(MasterPlayerModels.ServerGetPlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetPlayerCurrencyOperationRequest, MasterPlayerResponseModels.GetPlayerCurrencyOperationResponse>(new MasterPlayerRequestModels.ServerGetPlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerData(MasterPlayerModels.ServerGetPlayerDataRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayerDataOperationResponse> getPlayerDataAsync(MasterPlayerModels.ServerGetPlayerDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetPlayerDataOperationRequest, MasterPlayerResponseModels.GetPlayerDataOperationResponse>(new MasterPlayerRequestModels.ServerGetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerInformation(MasterPlayerModels.ServerGetPlayerInformationRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayerInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayerInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayerInformationOperationResponse> getPlayerInformationAsync(MasterPlayerModels.ServerGetPlayerInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetPlayerInformationOperationRequest, MasterPlayerResponseModels.GetPlayerInformationOperationResponse>(new MasterPlayerRequestModels.ServerGetPlayerInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerStatistics(MasterPlayerModels.ServerGetPlayerStatisticsRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayerStatisticsOperationResponse> getPlayerStatisticsAsync(MasterPlayerModels.ServerGetPlayerStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetPlayerStatisticsOperationRequest, MasterPlayerResponseModels.GetPlayerStatisticsOperationResponse>(new MasterPlayerRequestModels.ServerGetPlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithApple(MasterPlayerModels.ServerGetPlayersWithAppleRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayersWithAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithAppleOperationResponse> getPlayersWithAppleAsync(MasterPlayerModels.ServerGetPlayersWithAppleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetPlayersWithAppleOperationRequest, MasterPlayerResponseModels.GetPlayersWithAppleOperationResponse>(new MasterPlayerRequestModels.ServerGetPlayersWithAppleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithDisplayName(MasterPlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayersWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> getPlayersWithDisplayNameAsync(MasterPlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetPlayersWithDisplayNameOperationRequest, MasterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse>(new MasterPlayerRequestModels.ServerGetPlayersWithDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithFacebook(MasterPlayerModels.ServerGetPlayersWithFacebookRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayersWithFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithFacebookOperationResponse> getPlayersWithFacebookAsync(MasterPlayerModels.ServerGetPlayersWithFacebookRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetPlayersWithFacebookOperationRequest, MasterPlayerResponseModels.GetPlayersWithFacebookOperationResponse>(new MasterPlayerRequestModels.ServerGetPlayersWithFacebookOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithGenericService(MasterPlayerModels.ServerGetPlayersWithGenericServiceRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayersWithGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithGenericServiceOperationResponse> getPlayersWithGenericServiceAsync(MasterPlayerModels.ServerGetPlayersWithGenericServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetPlayersWithGenericServiceOperationRequest, MasterPlayerResponseModels.GetPlayersWithGenericServiceOperationResponse>(new MasterPlayerRequestModels.ServerGetPlayersWithGenericServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithGoogle(MasterPlayerModels.ServerGetPlayersWithGoogleRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayersWithGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithGoogleOperationResponse> getPlayersWithGoogleAsync(MasterPlayerModels.ServerGetPlayersWithGoogleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetPlayersWithGoogleOperationRequest, MasterPlayerResponseModels.GetPlayersWithGoogleOperationResponse>(new MasterPlayerRequestModels.ServerGetPlayersWithGoogleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithGooglePlayGameService(MasterPlayerModels.ServerGetPlayersWithGooglePlayGameServiceRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithGooglePlayGameServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayersWithGooglePlayGameServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithGooglePlayGameServiceOperationResponse> getPlayersWithGooglePlayGameServiceAsync(MasterPlayerModels.ServerGetPlayersWithGooglePlayGameServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetPlayersWithGooglePlayGameServiceOperationRequest, MasterPlayerResponseModels.GetPlayersWithGooglePlayGameServiceOperationResponse>(new MasterPlayerRequestModels.ServerGetPlayersWithGooglePlayGameServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithGameCenter(MasterPlayerModels.ServerGetPlayersWithGameCenterRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithGameCenterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayersWithGameCenterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithGameCenterOperationResponse> getPlayersWithGameCenterAsync(MasterPlayerModels.ServerGetPlayersWithGameCenterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetPlayersWithGameCenterOperationRequest, MasterPlayerResponseModels.GetPlayersWithGameCenterOperationResponse>(new MasterPlayerRequestModels.ServerGetPlayersWithGameCenterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithSegment(MasterPlayerModels.ServerGetPlayersWithSegmentRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayersWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> getPlayersWithSegmentAsync(MasterPlayerModels.ServerGetPlayersWithSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetPlayersWithSegmentOperationRequest, MasterPlayerResponseModels.GetPlayersWithSegmentOperationResponse>(new MasterPlayerRequestModels.ServerGetPlayersWithSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithTag(MasterPlayerModels.ServerGetPlayersWithTagRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayersWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithTagOperationResponse> getPlayersWithTagAsync(MasterPlayerModels.ServerGetPlayersWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetPlayersWithTagOperationRequest, MasterPlayerResponseModels.GetPlayersWithTagOperationResponse>(new MasterPlayerRequestModels.ServerGetPlayersWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getSegment(MasterPlayerModels.ServerGetSegmentRequestData requestData, Action1<MasterPlayerResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetSegmentOperationResponse> getSegmentAsync(MasterPlayerModels.ServerGetSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetSegmentOperationRequest, MasterPlayerResponseModels.GetSegmentOperationResponse>(new MasterPlayerRequestModels.ServerGetSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboardAroundPlayer(MasterPlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, Action1<MasterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> getStatisticsLeaderboardAroundPlayerAsync(MasterPlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetStatisticsLeaderboardAroundPlayerOperationRequest, MasterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse>(new MasterPlayerRequestModels.ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboard(MasterPlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, Action1<MasterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> getStatisticsLeaderboardAsync(MasterPlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetStatisticsLeaderboardOperationRequest, MasterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse>(new MasterPlayerRequestModels.ServerGetStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTag(MasterPlayerModels.ServerGetTagRequestData requestData, Action1<MasterPlayerResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetTagOperationResponse> getTagAsync(MasterPlayerModels.ServerGetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetTagOperationRequest, MasterPlayerResponseModels.GetTagOperationResponse>(new MasterPlayerRequestModels.ServerGetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTsCreate(MasterPlayerModels.ServerGetTsCreateRequestData requestData, Action1<MasterPlayerResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetTsCreateOperationResponse> getTsCreateAsync(MasterPlayerModels.ServerGetTsCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetTsCreateOperationRequest, MasterPlayerResponseModels.GetTsCreateOperationResponse>(new MasterPlayerRequestModels.ServerGetTsCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTsLastLogin(MasterPlayerModels.ServerGetTsLastLoginRequestData requestData, Action1<MasterPlayerResponseModels.GetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetTsLastLoginOperationResponse> getTsLastLoginAsync(MasterPlayerModels.ServerGetTsLastLoginRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetTsLastLoginOperationRequest, MasterPlayerResponseModels.GetTsLastLoginOperationResponse>(new MasterPlayerRequestModels.ServerGetTsLastLoginOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkAccount(MasterPlayerModels.ServerLinkAccountRequestData requestData, Action1<MasterPlayerResponseModels.LinkAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkAccountOperationResponse> linkAccountAsync(MasterPlayerModels.ServerLinkAccountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerLinkAccountOperationRequest, MasterPlayerResponseModels.LinkAccountOperationResponse>(new MasterPlayerRequestModels.ServerLinkAccountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkAndroidDeviceId(MasterPlayerModels.ServerLinkAndroidDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkAndroidDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkAndroidDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkAndroidDeviceIdOperationResponse> linkAndroidDeviceIdAsync(MasterPlayerModels.ServerLinkAndroidDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerLinkAndroidDeviceIdOperationRequest, MasterPlayerResponseModels.LinkAndroidDeviceIdOperationResponse>(new MasterPlayerRequestModels.ServerLinkAndroidDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkApple(MasterPlayerModels.ServerLinkAppleRequestData requestData, Action1<MasterPlayerResponseModels.LinkAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkAppleOperationResponse> linkAppleAsync(MasterPlayerModels.ServerLinkAppleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerLinkAppleOperationRequest, MasterPlayerResponseModels.LinkAppleOperationResponse>(new MasterPlayerRequestModels.ServerLinkAppleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkCustomDeviceId(MasterPlayerModels.ServerLinkCustomDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkCustomDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkCustomDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkCustomDeviceIdOperationResponse> linkCustomDeviceIdAsync(MasterPlayerModels.ServerLinkCustomDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerLinkCustomDeviceIdOperationRequest, MasterPlayerResponseModels.LinkCustomDeviceIdOperationResponse>(new MasterPlayerRequestModels.ServerLinkCustomDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkCustomId(MasterPlayerModels.ServerLinkCustomIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkCustomIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkCustomIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkCustomIdOperationResponse> linkCustomIdAsync(MasterPlayerModels.ServerLinkCustomIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerLinkCustomIdOperationRequest, MasterPlayerResponseModels.LinkCustomIdOperationResponse>(new MasterPlayerRequestModels.ServerLinkCustomIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkEditorDeviceId(MasterPlayerModels.ServerLinkEditorDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkEditorDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkEditorDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkEditorDeviceIdOperationResponse> linkEditorDeviceIdAsync(MasterPlayerModels.ServerLinkEditorDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerLinkEditorDeviceIdOperationRequest, MasterPlayerResponseModels.LinkEditorDeviceIdOperationResponse>(new MasterPlayerRequestModels.ServerLinkEditorDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkFacebook(MasterPlayerModels.ServerLinkFacebookRequestData requestData, Action1<MasterPlayerResponseModels.LinkFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkFacebookOperationResponse> linkFacebookAsync(MasterPlayerModels.ServerLinkFacebookRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerLinkFacebookOperationRequest, MasterPlayerResponseModels.LinkFacebookOperationResponse>(new MasterPlayerRequestModels.ServerLinkFacebookOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkGenericService(MasterPlayerModels.ServerLinkGenericServiceRequestData requestData, Action1<MasterPlayerResponseModels.LinkGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkGenericServiceOperationResponse> linkGenericServiceAsync(MasterPlayerModels.ServerLinkGenericServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerLinkGenericServiceOperationRequest, MasterPlayerResponseModels.LinkGenericServiceOperationResponse>(new MasterPlayerRequestModels.ServerLinkGenericServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkGoogle(MasterPlayerModels.ServerLinkGoogleRequestData requestData, Action1<MasterPlayerResponseModels.LinkGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkGoogleOperationResponse> linkGoogleAsync(MasterPlayerModels.ServerLinkGoogleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerLinkGoogleOperationRequest, MasterPlayerResponseModels.LinkGoogleOperationResponse>(new MasterPlayerRequestModels.ServerLinkGoogleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkGooglePlayGameService(MasterPlayerModels.ServerLinkGooglePlayGameServiceRequestData requestData, Action1<MasterPlayerResponseModels.LinkGooglePlayGameServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkGooglePlayGameServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkGooglePlayGameServiceOperationResponse> linkGooglePlayGameServiceAsync(MasterPlayerModels.ServerLinkGooglePlayGameServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerLinkGooglePlayGameServiceOperationRequest, MasterPlayerResponseModels.LinkGooglePlayGameServiceOperationResponse>(new MasterPlayerRequestModels.ServerLinkGooglePlayGameServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkGameCenter(MasterPlayerModels.ServerLinkGameCenterRequestData requestData, Action1<MasterPlayerResponseModels.LinkGameCenterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkGameCenterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkGameCenterOperationResponse> linkGameCenterAsync(MasterPlayerModels.ServerLinkGameCenterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerLinkGameCenterOperationRequest, MasterPlayerResponseModels.LinkGameCenterOperationResponse>(new MasterPlayerRequestModels.ServerLinkGameCenterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkiOSDeviceId(MasterPlayerModels.ServerLinkiOSDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkiOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkiOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkiOSDeviceIdOperationResponse> linkiOSDeviceIdAsync(MasterPlayerModels.ServerLinkiOSDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerLinkiOSDeviceIdOperationRequest, MasterPlayerResponseModels.LinkiOSDeviceIdOperationResponse>(new MasterPlayerRequestModels.ServerLinkiOSDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkLinuxDeviceId(MasterPlayerModels.ServerLinkLinuxDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkLinuxDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkLinuxDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkLinuxDeviceIdOperationResponse> linkLinuxDeviceIdAsync(MasterPlayerModels.ServerLinkLinuxDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerLinkLinuxDeviceIdOperationRequest, MasterPlayerResponseModels.LinkLinuxDeviceIdOperationResponse>(new MasterPlayerRequestModels.ServerLinkLinuxDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkMacOSDeviceId(MasterPlayerModels.ServerLinkMacOSDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkMacOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkMacOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkMacOSDeviceIdOperationResponse> linkMacOSDeviceIdAsync(MasterPlayerModels.ServerLinkMacOSDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerLinkMacOSDeviceIdOperationRequest, MasterPlayerResponseModels.LinkMacOSDeviceIdOperationResponse>(new MasterPlayerRequestModels.ServerLinkMacOSDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkWindowsDeviceId(MasterPlayerModels.ServerLinkWindowsDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkWindowsDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkWindowsDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkWindowsDeviceIdOperationResponse> linkWindowsDeviceIdAsync(MasterPlayerModels.ServerLinkWindowsDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerLinkWindowsDeviceIdOperationRequest, MasterPlayerResponseModels.LinkWindowsDeviceIdOperationResponse>(new MasterPlayerRequestModels.ServerLinkWindowsDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkWindowsPhoneDeviceId(MasterPlayerModels.ServerLinkWindowsPhoneDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkWindowsPhoneDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkWindowsPhoneDeviceIdOperationResponse> linkWindowsPhoneDeviceIdAsync(MasterPlayerModels.ServerLinkWindowsPhoneDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerLinkWindowsPhoneDeviceIdOperationRequest, MasterPlayerResponseModels.LinkWindowsPhoneDeviceIdOperationResponse>(new MasterPlayerRequestModels.ServerLinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeSegment(MasterPlayerModels.ServerRemoveSegmentRequestData requestData, Action1<MasterPlayerResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerRemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.RemoveSegmentOperationResponse> removeSegmentAsync(MasterPlayerModels.ServerRemoveSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerRemoveSegmentOperationRequest, MasterPlayerResponseModels.RemoveSegmentOperationResponse>(new MasterPlayerRequestModels.ServerRemoveSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeTag(MasterPlayerModels.ServerRemoveTagRequestData requestData, Action1<MasterPlayerResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerRemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.RemoveTagOperationResponse> removeTagAsync(MasterPlayerModels.ServerRemoveTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerRemoveTagOperationRequest, MasterPlayerResponseModels.RemoveTagOperationResponse>(new MasterPlayerRequestModels.ServerRemoveTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void resetAccountPassword(MasterPlayerModels.ServerResetAccountPasswordRequestData requestData, Action1<MasterPlayerResponseModels.ResetAccountPasswordOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerResetAccountPasswordOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.ResetAccountPasswordOperationResponse> resetAccountPasswordAsync(MasterPlayerModels.ServerResetAccountPasswordRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerResetAccountPasswordOperationRequest, MasterPlayerResponseModels.ResetAccountPasswordOperationResponse>(new MasterPlayerRequestModels.ServerResetAccountPasswordOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setAvatar(MasterPlayerModels.ServerSetAvatarRequestData requestData, Action1<MasterPlayerResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetAvatarOperationResponse> setAvatarAsync(MasterPlayerModels.ServerSetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerSetAvatarOperationRequest, MasterPlayerResponseModels.SetAvatarOperationResponse>(new MasterPlayerRequestModels.ServerSetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setCountryCode(MasterPlayerModels.ServerSetCountryCodeRequestData requestData, Action1<MasterPlayerResponseModels.SetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetCountryCodeOperationResponse> setCountryCodeAsync(MasterPlayerModels.ServerSetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerSetCountryCodeOperationRequest, MasterPlayerResponseModels.SetCountryCodeOperationResponse>(new MasterPlayerRequestModels.ServerSetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setCustomData(MasterPlayerModels.ServerSetCustomDataRequestData requestData, Action1<MasterPlayerResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetCustomDataOperationResponse> setCustomDataAsync(MasterPlayerModels.ServerSetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerSetCustomDataOperationRequest, MasterPlayerResponseModels.SetCustomDataOperationResponse>(new MasterPlayerRequestModels.ServerSetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setDisplayName(MasterPlayerModels.ServerSetDisplayNameRequestData requestData, Action1<MasterPlayerResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetDisplayNameOperationResponse> setDisplayNameAsync(MasterPlayerModels.ServerSetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerSetDisplayNameOperationRequest, MasterPlayerResponseModels.SetDisplayNameOperationResponse>(new MasterPlayerRequestModels.ServerSetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setEmail(MasterPlayerModels.ServerSetEmailRequestData requestData, Action1<MasterPlayerResponseModels.SetEmailOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetEmailOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetEmailOperationResponse> setEmailAsync(MasterPlayerModels.ServerSetEmailRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerSetEmailOperationRequest, MasterPlayerResponseModels.SetEmailOperationResponse>(new MasterPlayerRequestModels.ServerSetEmailOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setPlayerBan(MasterPlayerModels.ServerSetPlayerBanRequestData requestData, Action1<MasterPlayerResponseModels.SetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetPlayerBanOperationResponse> setPlayerBanAsync(MasterPlayerModels.ServerSetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerSetPlayerBanOperationRequest, MasterPlayerResponseModels.SetPlayerBanOperationResponse>(new MasterPlayerRequestModels.ServerSetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changePlayerCurrency(MasterPlayerModels.ServerChangePlayerCurrencyRequestData requestData, Action1<MasterPlayerResponseModels.ChangePlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerChangePlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.ChangePlayerCurrencyOperationResponse> changePlayerCurrencyAsync(MasterPlayerModels.ServerChangePlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerChangePlayerCurrencyOperationRequest, MasterPlayerResponseModels.ChangePlayerCurrencyOperationResponse>(new MasterPlayerRequestModels.ServerChangePlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setPlayerData(MasterPlayerModels.ServerSetPlayerDataRequestData requestData, Action1<MasterPlayerResponseModels.SetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetPlayerDataOperationResponse> setPlayerDataAsync(MasterPlayerModels.ServerSetPlayerDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerSetPlayerDataOperationRequest, MasterPlayerResponseModels.SetPlayerDataOperationResponse>(new MasterPlayerRequestModels.ServerSetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changePlayerStatistics(MasterPlayerModels.ServerChangePlayerStatisticsRequestData requestData, Action1<MasterPlayerResponseModels.ChangePlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerChangePlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.ChangePlayerStatisticsOperationResponse> changePlayerStatisticsAsync(MasterPlayerModels.ServerChangePlayerStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerChangePlayerStatisticsOperationRequest, MasterPlayerResponseModels.ChangePlayerStatisticsOperationResponse>(new MasterPlayerRequestModels.ServerChangePlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setTag(MasterPlayerModels.ServerSetTagRequestData requestData, Action1<MasterPlayerResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetTagOperationResponse> setTagAsync(MasterPlayerModels.ServerSetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerSetTagOperationRequest, MasterPlayerResponseModels.SetTagOperationResponse>(new MasterPlayerRequestModels.ServerSetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setTsLastLogin(MasterPlayerModels.ServerSetTsLastLoginRequestData requestData, Action1<MasterPlayerResponseModels.SetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetTsLastLoginOperationResponse> setTsLastLoginAsync(MasterPlayerModels.ServerSetTsLastLoginRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerSetTsLastLoginOperationRequest, MasterPlayerResponseModels.SetTsLastLoginOperationResponse>(new MasterPlayerRequestModels.ServerSetTsLastLoginOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkAccount(MasterPlayerModels.ServerUnlinkAccountRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkAccountOperationResponse> unlinkAccountAsync(MasterPlayerModels.ServerUnlinkAccountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerUnlinkAccountOperationRequest, MasterPlayerResponseModels.UnlinkAccountOperationResponse>(new MasterPlayerRequestModels.ServerUnlinkAccountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkAndroidDeviceId(MasterPlayerModels.ServerUnlinkAndroidDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkAndroidDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkAndroidDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkAndroidDeviceIdOperationResponse> unlinkAndroidDeviceIdAsync(MasterPlayerModels.ServerUnlinkAndroidDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerUnlinkAndroidDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkAndroidDeviceIdOperationResponse>(new MasterPlayerRequestModels.ServerUnlinkAndroidDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkApple(MasterPlayerModels.ServerUnlinkAppleRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkAppleOperationResponse> unlinkAppleAsync(MasterPlayerModels.ServerUnlinkAppleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerUnlinkAppleOperationRequest, MasterPlayerResponseModels.UnlinkAppleOperationResponse>(new MasterPlayerRequestModels.ServerUnlinkAppleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkCustomDeviceId(MasterPlayerModels.ServerUnlinkCustomDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkCustomDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkCustomDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkCustomDeviceIdOperationResponse> unlinkCustomDeviceIdAsync(MasterPlayerModels.ServerUnlinkCustomDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerUnlinkCustomDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkCustomDeviceIdOperationResponse>(new MasterPlayerRequestModels.ServerUnlinkCustomDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkCustomId(MasterPlayerModels.ServerUnlinkCustomIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkCustomIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkCustomIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkCustomIdOperationResponse> unlinkCustomIdAsync(MasterPlayerModels.ServerUnlinkCustomIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerUnlinkCustomIdOperationRequest, MasterPlayerResponseModels.UnlinkCustomIdOperationResponse>(new MasterPlayerRequestModels.ServerUnlinkCustomIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkEditorDeviceId(MasterPlayerModels.ServerUnlinkEditorDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkEditorDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkEditorDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkEditorDeviceIdOperationResponse> unlinkEditorDeviceIdAsync(MasterPlayerModels.ServerUnlinkEditorDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerUnlinkEditorDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkEditorDeviceIdOperationResponse>(new MasterPlayerRequestModels.ServerUnlinkEditorDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkFacebook(MasterPlayerModels.ServerUnlinkFacebookRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkFacebookOperationResponse> unlinkFacebookAsync(MasterPlayerModels.ServerUnlinkFacebookRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerUnlinkFacebookOperationRequest, MasterPlayerResponseModels.UnlinkFacebookOperationResponse>(new MasterPlayerRequestModels.ServerUnlinkFacebookOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkGenericService(MasterPlayerModels.ServerUnlinkGenericServiceRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkGenericServiceOperationResponse> unlinkGenericServiceAsync(MasterPlayerModels.ServerUnlinkGenericServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerUnlinkGenericServiceOperationRequest, MasterPlayerResponseModels.UnlinkGenericServiceOperationResponse>(new MasterPlayerRequestModels.ServerUnlinkGenericServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkGoogle(MasterPlayerModels.ServerUnlinkGoogleRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkGoogleOperationResponse> unlinkGoogleAsync(MasterPlayerModels.ServerUnlinkGoogleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerUnlinkGoogleOperationRequest, MasterPlayerResponseModels.UnlinkGoogleOperationResponse>(new MasterPlayerRequestModels.ServerUnlinkGoogleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkGooglePlayGameService(MasterPlayerModels.ServerUnlinkGooglePlayGameServiceRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkGooglePlayGameServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkGooglePlayGameServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkGooglePlayGameServiceOperationResponse> unlinkGooglePlayGameServiceAsync(MasterPlayerModels.ServerUnlinkGooglePlayGameServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerUnlinkGooglePlayGameServiceOperationRequest, MasterPlayerResponseModels.UnlinkGooglePlayGameServiceOperationResponse>(new MasterPlayerRequestModels.ServerUnlinkGooglePlayGameServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkGameCenter(MasterPlayerModels.ServerUnlinkGameCenterRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkGameCenterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkGameCenterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkGameCenterOperationResponse> unlinkGameCenterAsync(MasterPlayerModels.ServerUnlinkGameCenterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerUnlinkGameCenterOperationRequest, MasterPlayerResponseModels.UnlinkGameCenterOperationResponse>(new MasterPlayerRequestModels.ServerUnlinkGameCenterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkiOSDeviceId(MasterPlayerModels.ServerUnlinkiOSDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkiOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkiOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkiOSDeviceIdOperationResponse> unlinkiOSDeviceIdAsync(MasterPlayerModels.ServerUnlinkiOSDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerUnlinkiOSDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkiOSDeviceIdOperationResponse>(new MasterPlayerRequestModels.ServerUnlinkiOSDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkLinuxDeviceId(MasterPlayerModels.ServerUnlinkLinuxDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkLinuxDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkLinuxDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkLinuxDeviceIdOperationResponse> unlinkLinuxDeviceIdAsync(MasterPlayerModels.ServerUnlinkLinuxDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerUnlinkLinuxDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkLinuxDeviceIdOperationResponse>(new MasterPlayerRequestModels.ServerUnlinkLinuxDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkMacOSDeviceId(MasterPlayerModels.ServerUnlinkMacOSDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkMacOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkMacOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkMacOSDeviceIdOperationResponse> unlinkMacOSDeviceIdAsync(MasterPlayerModels.ServerUnlinkMacOSDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerUnlinkMacOSDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkMacOSDeviceIdOperationResponse>(new MasterPlayerRequestModels.ServerUnlinkMacOSDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkWindowsDeviceId(MasterPlayerModels.ServerUnlinkWindowsDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkWindowsDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkWindowsDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkWindowsDeviceIdOperationResponse> unlinkWindowsDeviceIdAsync(MasterPlayerModels.ServerUnlinkWindowsDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerUnlinkWindowsDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkWindowsDeviceIdOperationResponse>(new MasterPlayerRequestModels.ServerUnlinkWindowsDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkWindowsPhoneDeviceId(MasterPlayerModels.ServerUnlinkWindowsPhoneDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkWindowsPhoneDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkWindowsPhoneDeviceIdOperationResponse> unlinkWindowsPhoneDeviceIdAsync(MasterPlayerModels.ServerUnlinkWindowsPhoneDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerUnlinkWindowsPhoneDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkWindowsPhoneDeviceIdOperationResponse>(new MasterPlayerRequestModels.ServerUnlinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCurrencyLeaderboard(MasterPlayerModels.ServerGetCurrencyLeaderboardRequestData requestData, Action1<MasterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetCurrencyLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse> getCurrencyLeaderboardAsync(MasterPlayerModels.ServerGetCurrencyLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetCurrencyLeaderboardOperationRequest, MasterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse>(new MasterPlayerRequestModels.ServerGetCurrencyLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }
            public void getLastLoginLeaderboard(MasterPlayerModels.ServerGetLastLoginLeaderboardRequestData requestData, Action1<MasterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetLastLoginLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse> getLastLoginLeaderboardAsync(MasterPlayerModels.ServerGetLastLoginLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetLastLoginLeaderboardOperationRequest, MasterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse>(new MasterPlayerRequestModels.ServerGetLastLoginLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCreateLeaderboard(MasterPlayerModels.ServerGetCreateLeaderboardRequestData requestData, Action1<MasterPlayerResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(MasterPlayerModels.ServerGetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetCreateLeaderboardOperationRequest, MasterPlayerResponseModels.GetCreateLeaderboardOperationResponse>(new MasterPlayerRequestModels.ServerGetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLog(MasterPlayerModels.ServerGetStatisticsLogRequestData requestData, Action1<MasterPlayerResponseModels.GetStatisticsLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetStatisticsLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetStatisticsLogOperationResponse> getStatisticsLogAsync(MasterPlayerModels.ServerGetStatisticsLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetStatisticsLogOperationRequest, MasterPlayerResponseModels.GetStatisticsLogOperationResponse>(new MasterPlayerRequestModels.ServerGetStatisticsLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCurrencyLog(MasterPlayerModels.ServerGetCurrencyLogRequestData requestData, Action1<MasterPlayerResponseModels.GetCurrencyLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetCurrencyLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetCurrencyLogOperationResponse> getCurrencyLogAsync(MasterPlayerModels.ServerGetCurrencyLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetCurrencyLogOperationRequest, MasterPlayerResponseModels.GetCurrencyLogOperationResponse>(new MasterPlayerRequestModels.ServerGetCurrencyLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void sendSocketOperationEvent(MasterPlayerModels.ServerSendSocketOperationEventRequestData requestData, Action1<MasterPlayerResponseModels.SendSocketOperationEventOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSendSocketOperationEventOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SendSocketOperationEventOperationResponse> sendSocketOperationEventAsync(MasterPlayerModels.ServerSendSocketOperationEventRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerSendSocketOperationEventOperationRequest, MasterPlayerResponseModels.SendSocketOperationEventOperationResponse>(new MasterPlayerRequestModels.ServerSendSocketOperationEventOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void sendEmail(MasterPlayerModels.ServerSendEmailRequestData requestData, Action1<MasterPlayerResponseModels.SendEmailOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSendEmailOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SendEmailOperationResponse> sendEmailAsync(MasterPlayerModels.ServerSendEmailRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerSendEmailOperationRequest, MasterPlayerResponseModels.SendEmailOperationResponse>(new MasterPlayerRequestModels.ServerSendEmailOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void addPushNotification(MasterPlayerModels.ServerAddPushNotificationRequestData requestData, Action1<MasterPlayerResponseModels.AddPushNotificationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerAddPushNotificationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.AddPushNotificationOperationResponse> addPushNotificationAsync(MasterPlayerModels.ServerAddPushNotificationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerAddPushNotificationOperationRequest, MasterPlayerResponseModels.AddPushNotificationOperationResponse>(new MasterPlayerRequestModels.ServerAddPushNotificationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removePushNotification(MasterPlayerModels.ServerRemovePushNotificationRequestData requestData, Action1<MasterPlayerResponseModels.RemovePushNotificationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerRemovePushNotificationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.RemovePushNotificationOperationResponse> removePushNotificationAsync(MasterPlayerModels.ServerRemovePushNotificationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerRemovePushNotificationOperationRequest, MasterPlayerResponseModels.RemovePushNotificationOperationResponse>(new MasterPlayerRequestModels.ServerRemovePushNotificationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPushNotification(MasterPlayerModels.ServerGetPushNotificationRequestData requestData, Action1<MasterPlayerResponseModels.GetPushNotificationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPushNotificationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPushNotificationOperationResponse> getPushNotificationAsync(MasterPlayerModels.ServerGetPushNotificationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerGetPushNotificationOperationRequest, MasterPlayerResponseModels.GetPushNotificationOperationResponse>(new MasterPlayerRequestModels.ServerGetPushNotificationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void sendPushNotification(MasterPlayerModels.ServerSendPushNotificationRequestData requestData, Action1<MasterPlayerResponseModels.SendPushNotificationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSendPushNotificationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SendPushNotificationOperationResponse> sendPushNotificationAsync(MasterPlayerModels.ServerSendPushNotificationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.ServerSendPushNotificationOperationRequest, MasterPlayerResponseModels.SendPushNotificationOperationResponse>(new MasterPlayerRequestModels.ServerSendPushNotificationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

        public class AdminApi
        {
            public void addSegment(MasterPlayerModels.AdminAddSegmentRequestData requestData, Action1<MasterPlayerResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminAddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.AddSegmentOperationResponse> addSegmentAsync(MasterPlayerModels.AdminAddSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminAddSegmentOperationRequest, MasterPlayerResponseModels.AddSegmentOperationResponse>(new MasterPlayerRequestModels.AdminAddSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getAvatar(MasterPlayerModels.AdminGetAvatarRequestData requestData, Action1<MasterPlayerResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetAvatarOperationResponse> getAvatarAsync(MasterPlayerModels.AdminGetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetAvatarOperationRequest, MasterPlayerResponseModels.GetAvatarOperationResponse>(new MasterPlayerRequestModels.AdminGetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCountryCode(MasterPlayerModels.AdminGetCountryCodeRequestData requestData, Action1<MasterPlayerResponseModels.GetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetCountryCodeOperationResponse> getCountryCodeAsync(MasterPlayerModels.AdminGetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetCountryCodeOperationRequest, MasterPlayerResponseModels.GetCountryCodeOperationResponse>(new MasterPlayerRequestModels.AdminGetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCustomData(MasterPlayerModels.AdminGetCustomDataRequestData requestData, Action1<MasterPlayerResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetCustomDataOperationResponse> getCustomDataAsync(MasterPlayerModels.AdminGetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetCustomDataOperationRequest, MasterPlayerResponseModels.GetCustomDataOperationResponse>(new MasterPlayerRequestModels.AdminGetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getDisplayName(MasterPlayerModels.AdminGetDisplayNameRequestData requestData, Action1<MasterPlayerResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetDisplayNameOperationResponse> getDisplayNameAsync(MasterPlayerModels.AdminGetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetDisplayNameOperationRequest, MasterPlayerResponseModels.GetDisplayNameOperationResponse>(new MasterPlayerRequestModels.AdminGetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getEmail(MasterPlayerModels.AdminGetEmailRequestData requestData, Action1<MasterPlayerResponseModels.GetEmailOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetEmailOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetEmailOperationResponse> getEmailAsync(MasterPlayerModels.AdminGetEmailRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetEmailOperationRequest, MasterPlayerResponseModels.GetEmailOperationResponse>(new MasterPlayerRequestModels.AdminGetEmailOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getExternal(MasterPlayerModels.AdminGetExternalRequestData requestData, Action1<MasterPlayerResponseModels.GetExternalOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetExternalOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetExternalOperationResponse> getExternalAsync(MasterPlayerModels.AdminGetExternalRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetExternalOperationRequest, MasterPlayerResponseModels.GetExternalOperationResponse>(new MasterPlayerRequestModels.AdminGetExternalOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getIpAddressCreate(MasterPlayerModels.AdminGetIpAddressCreateRequestData requestData, Action1<MasterPlayerResponseModels.GetIpAddressCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetIpAddressCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetIpAddressCreateOperationResponse> getIpAddressCreateAsync(MasterPlayerModels.AdminGetIpAddressCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetIpAddressCreateOperationRequest, MasterPlayerResponseModels.GetIpAddressCreateOperationResponse>(new MasterPlayerRequestModels.AdminGetIpAddressCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerBan(MasterPlayerModels.AdminGetPlayerBanRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayerBanOperationResponse> getPlayerBanAsync(MasterPlayerModels.AdminGetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetPlayerBanOperationRequest, MasterPlayerResponseModels.GetPlayerBanOperationResponse>(new MasterPlayerRequestModels.AdminGetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerCurrency(MasterPlayerModels.AdminGetPlayerCurrencyRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayerCurrencyOperationResponse> getPlayerCurrencyAsync(MasterPlayerModels.AdminGetPlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetPlayerCurrencyOperationRequest, MasterPlayerResponseModels.GetPlayerCurrencyOperationResponse>(new MasterPlayerRequestModels.AdminGetPlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerData(MasterPlayerModels.AdminGetPlayerDataRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayerDataOperationResponse> getPlayerDataAsync(MasterPlayerModels.AdminGetPlayerDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetPlayerDataOperationRequest, MasterPlayerResponseModels.GetPlayerDataOperationResponse>(new MasterPlayerRequestModels.AdminGetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerInformation(MasterPlayerModels.AdminGetPlayerInformationRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayerInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayerInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayerInformationOperationResponse> getPlayerInformationAsync(MasterPlayerModels.AdminGetPlayerInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetPlayerInformationOperationRequest, MasterPlayerResponseModels.GetPlayerInformationOperationResponse>(new MasterPlayerRequestModels.AdminGetPlayerInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayerStatistics(MasterPlayerModels.AdminGetPlayerStatisticsRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayerStatisticsOperationResponse> getPlayerStatisticsAsync(MasterPlayerModels.AdminGetPlayerStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetPlayerStatisticsOperationRequest, MasterPlayerResponseModels.GetPlayerStatisticsOperationResponse>(new MasterPlayerRequestModels.AdminGetPlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithApple(MasterPlayerModels.AdminGetPlayersWithAppleRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayersWithAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithAppleOperationResponse> getPlayersWithAppleAsync(MasterPlayerModels.AdminGetPlayersWithAppleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetPlayersWithAppleOperationRequest, MasterPlayerResponseModels.GetPlayersWithAppleOperationResponse>(new MasterPlayerRequestModels.AdminGetPlayersWithAppleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithDisplayName(MasterPlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayersWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> getPlayersWithDisplayNameAsync(MasterPlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetPlayersWithDisplayNameOperationRequest, MasterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse>(new MasterPlayerRequestModels.AdminGetPlayersWithDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithFacebook(MasterPlayerModels.AdminGetPlayersWithFacebookRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayersWithFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithFacebookOperationResponse> getPlayersWithFacebookAsync(MasterPlayerModels.AdminGetPlayersWithFacebookRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetPlayersWithFacebookOperationRequest, MasterPlayerResponseModels.GetPlayersWithFacebookOperationResponse>(new MasterPlayerRequestModels.AdminGetPlayersWithFacebookOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithGenericService(MasterPlayerModels.AdminGetPlayersWithGenericServiceRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayersWithGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithGenericServiceOperationResponse> getPlayersWithGenericServiceAsync(MasterPlayerModels.AdminGetPlayersWithGenericServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetPlayersWithGenericServiceOperationRequest, MasterPlayerResponseModels.GetPlayersWithGenericServiceOperationResponse>(new MasterPlayerRequestModels.AdminGetPlayersWithGenericServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithGoogle(MasterPlayerModels.AdminGetPlayersWithGoogleRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayersWithGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithGoogleOperationResponse> getPlayersWithGoogleAsync(MasterPlayerModels.AdminGetPlayersWithGoogleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetPlayersWithGoogleOperationRequest, MasterPlayerResponseModels.GetPlayersWithGoogleOperationResponse>(new MasterPlayerRequestModels.AdminGetPlayersWithGoogleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithGooglePlayGameService(MasterPlayerModels.AdminGetPlayersWithGooglePlayGameServiceRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithGooglePlayGameServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayersWithGooglePlayGameServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithGooglePlayGameServiceOperationResponse> getPlayersWithGooglePlayGameServiceAsync(MasterPlayerModels.AdminGetPlayersWithGooglePlayGameServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetPlayersWithGooglePlayGameServiceOperationRequest, MasterPlayerResponseModels.GetPlayersWithGooglePlayGameServiceOperationResponse>(new MasterPlayerRequestModels.AdminGetPlayersWithGooglePlayGameServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithGameCenter(MasterPlayerModels.AdminGetPlayersWithGameCenterRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithGameCenterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayersWithGameCenterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithGameCenterOperationResponse> getPlayersWithGameCenterAsync(MasterPlayerModels.AdminGetPlayersWithGameCenterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetPlayersWithGameCenterOperationRequest, MasterPlayerResponseModels.GetPlayersWithGameCenterOperationResponse>(new MasterPlayerRequestModels.AdminGetPlayersWithGameCenterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithSegment(MasterPlayerModels.AdminGetPlayersWithSegmentRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayersWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> getPlayersWithSegmentAsync(MasterPlayerModels.AdminGetPlayersWithSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetPlayersWithSegmentOperationRequest, MasterPlayerResponseModels.GetPlayersWithSegmentOperationResponse>(new MasterPlayerRequestModels.AdminGetPlayersWithSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPlayersWithTag(MasterPlayerModels.AdminGetPlayersWithTagRequestData requestData, Action1<MasterPlayerResponseModels.GetPlayersWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayersWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPlayersWithTagOperationResponse> getPlayersWithTagAsync(MasterPlayerModels.AdminGetPlayersWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetPlayersWithTagOperationRequest, MasterPlayerResponseModels.GetPlayersWithTagOperationResponse>(new MasterPlayerRequestModels.AdminGetPlayersWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getSegment(MasterPlayerModels.AdminGetSegmentRequestData requestData, Action1<MasterPlayerResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetSegmentOperationResponse> getSegmentAsync(MasterPlayerModels.AdminGetSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetSegmentOperationRequest, MasterPlayerResponseModels.GetSegmentOperationResponse>(new MasterPlayerRequestModels.AdminGetSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboardAroundPlayer(MasterPlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, Action1<MasterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> getStatisticsLeaderboardAroundPlayerAsync(MasterPlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetStatisticsLeaderboardAroundPlayerOperationRequest, MasterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse>(new MasterPlayerRequestModels.AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLeaderboard(MasterPlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, Action1<MasterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> getStatisticsLeaderboardAsync(MasterPlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetStatisticsLeaderboardOperationRequest, MasterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse>(new MasterPlayerRequestModels.AdminGetStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTag(MasterPlayerModels.AdminGetTagRequestData requestData, Action1<MasterPlayerResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetTagOperationResponse> getTagAsync(MasterPlayerModels.AdminGetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetTagOperationRequest, MasterPlayerResponseModels.GetTagOperationResponse>(new MasterPlayerRequestModels.AdminGetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTsCreate(MasterPlayerModels.AdminGetTsCreateRequestData requestData, Action1<MasterPlayerResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetTsCreateOperationResponse> getTsCreateAsync(MasterPlayerModels.AdminGetTsCreateRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetTsCreateOperationRequest, MasterPlayerResponseModels.GetTsCreateOperationResponse>(new MasterPlayerRequestModels.AdminGetTsCreateOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getTsLastLogin(MasterPlayerModels.AdminGetTsLastLoginRequestData requestData, Action1<MasterPlayerResponseModels.GetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetTsLastLoginOperationResponse> getTsLastLoginAsync(MasterPlayerModels.AdminGetTsLastLoginRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetTsLastLoginOperationRequest, MasterPlayerResponseModels.GetTsLastLoginOperationResponse>(new MasterPlayerRequestModels.AdminGetTsLastLoginOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkAccount(MasterPlayerModels.AdminLinkAccountRequestData requestData, Action1<MasterPlayerResponseModels.LinkAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkAccountOperationResponse> linkAccountAsync(MasterPlayerModels.AdminLinkAccountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminLinkAccountOperationRequest, MasterPlayerResponseModels.LinkAccountOperationResponse>(new MasterPlayerRequestModels.AdminLinkAccountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkAndroidDeviceId(MasterPlayerModels.AdminLinkAndroidDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkAndroidDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkAndroidDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkAndroidDeviceIdOperationResponse> linkAndroidDeviceIdAsync(MasterPlayerModels.AdminLinkAndroidDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminLinkAndroidDeviceIdOperationRequest, MasterPlayerResponseModels.LinkAndroidDeviceIdOperationResponse>(new MasterPlayerRequestModels.AdminLinkAndroidDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkApple(MasterPlayerModels.AdminLinkAppleRequestData requestData, Action1<MasterPlayerResponseModels.LinkAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkAppleOperationResponse> linkAppleAsync(MasterPlayerModels.AdminLinkAppleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminLinkAppleOperationRequest, MasterPlayerResponseModels.LinkAppleOperationResponse>(new MasterPlayerRequestModels.AdminLinkAppleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkCustomDeviceId(MasterPlayerModels.AdminLinkCustomDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkCustomDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkCustomDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkCustomDeviceIdOperationResponse> linkCustomDeviceIdAsync(MasterPlayerModels.AdminLinkCustomDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminLinkCustomDeviceIdOperationRequest, MasterPlayerResponseModels.LinkCustomDeviceIdOperationResponse>(new MasterPlayerRequestModels.AdminLinkCustomDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkCustomId(MasterPlayerModels.AdminLinkCustomIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkCustomIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkCustomIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkCustomIdOperationResponse> linkCustomIdAsync(MasterPlayerModels.AdminLinkCustomIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminLinkCustomIdOperationRequest, MasterPlayerResponseModels.LinkCustomIdOperationResponse>(new MasterPlayerRequestModels.AdminLinkCustomIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkEditorDeviceId(MasterPlayerModels.AdminLinkEditorDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkEditorDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkEditorDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkEditorDeviceIdOperationResponse> linkEditorDeviceIdAsync(MasterPlayerModels.AdminLinkEditorDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminLinkEditorDeviceIdOperationRequest, MasterPlayerResponseModels.LinkEditorDeviceIdOperationResponse>(new MasterPlayerRequestModels.AdminLinkEditorDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkFacebook(MasterPlayerModels.AdminLinkFacebookRequestData requestData, Action1<MasterPlayerResponseModels.LinkFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkFacebookOperationResponse> linkFacebookAsync(MasterPlayerModels.AdminLinkFacebookRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminLinkFacebookOperationRequest, MasterPlayerResponseModels.LinkFacebookOperationResponse>(new MasterPlayerRequestModels.AdminLinkFacebookOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkGenericService(MasterPlayerModels.AdminLinkGenericServiceRequestData requestData, Action1<MasterPlayerResponseModels.LinkGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkGenericServiceOperationResponse> linkGenericServiceAsync(MasterPlayerModels.AdminLinkGenericServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminLinkGenericServiceOperationRequest, MasterPlayerResponseModels.LinkGenericServiceOperationResponse>(new MasterPlayerRequestModels.AdminLinkGenericServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkGoogle(MasterPlayerModels.AdminLinkGoogleRequestData requestData, Action1<MasterPlayerResponseModels.LinkGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkGoogleOperationResponse> linkGoogleAsync(MasterPlayerModels.AdminLinkGoogleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminLinkGoogleOperationRequest, MasterPlayerResponseModels.LinkGoogleOperationResponse>(new MasterPlayerRequestModels.AdminLinkGoogleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkGooglePlayGameService(MasterPlayerModels.AdminLinkGooglePlayGameServiceRequestData requestData, Action1<MasterPlayerResponseModels.LinkGooglePlayGameServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkGooglePlayGameServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkGooglePlayGameServiceOperationResponse> linkGooglePlayGameServiceAsync(MasterPlayerModels.AdminLinkGooglePlayGameServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminLinkGooglePlayGameServiceOperationRequest, MasterPlayerResponseModels.LinkGooglePlayGameServiceOperationResponse>(new MasterPlayerRequestModels.AdminLinkGooglePlayGameServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkGameCenter(MasterPlayerModels.AdminLinkGameCenterRequestData requestData, Action1<MasterPlayerResponseModels.LinkGameCenterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkGameCenterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkGameCenterOperationResponse> linkGameCenterAsync(MasterPlayerModels.AdminLinkGameCenterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminLinkGameCenterOperationRequest, MasterPlayerResponseModels.LinkGameCenterOperationResponse>(new MasterPlayerRequestModels.AdminLinkGameCenterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkiOSDeviceId(MasterPlayerModels.AdminLinkiOSDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkiOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkiOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkiOSDeviceIdOperationResponse> linkiOSDeviceIdAsync(MasterPlayerModels.AdminLinkiOSDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminLinkiOSDeviceIdOperationRequest, MasterPlayerResponseModels.LinkiOSDeviceIdOperationResponse>(new MasterPlayerRequestModels.AdminLinkiOSDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkLinuxDeviceId(MasterPlayerModels.AdminLinkLinuxDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkLinuxDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkLinuxDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkLinuxDeviceIdOperationResponse> linkLinuxDeviceIdAsync(MasterPlayerModels.AdminLinkLinuxDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminLinkLinuxDeviceIdOperationRequest, MasterPlayerResponseModels.LinkLinuxDeviceIdOperationResponse>(new MasterPlayerRequestModels.AdminLinkLinuxDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkMacOSDeviceId(MasterPlayerModels.AdminLinkMacOSDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkMacOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkMacOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkMacOSDeviceIdOperationResponse> linkMacOSDeviceIdAsync(MasterPlayerModels.AdminLinkMacOSDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminLinkMacOSDeviceIdOperationRequest, MasterPlayerResponseModels.LinkMacOSDeviceIdOperationResponse>(new MasterPlayerRequestModels.AdminLinkMacOSDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkWindowsDeviceId(MasterPlayerModels.AdminLinkWindowsDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkWindowsDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkWindowsDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkWindowsDeviceIdOperationResponse> linkWindowsDeviceIdAsync(MasterPlayerModels.AdminLinkWindowsDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminLinkWindowsDeviceIdOperationRequest, MasterPlayerResponseModels.LinkWindowsDeviceIdOperationResponse>(new MasterPlayerRequestModels.AdminLinkWindowsDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void linkWindowsPhoneDeviceId(MasterPlayerModels.AdminLinkWindowsPhoneDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.LinkWindowsPhoneDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.LinkWindowsPhoneDeviceIdOperationResponse> linkWindowsPhoneDeviceIdAsync(MasterPlayerModels.AdminLinkWindowsPhoneDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminLinkWindowsPhoneDeviceIdOperationRequest, MasterPlayerResponseModels.LinkWindowsPhoneDeviceIdOperationResponse>(new MasterPlayerRequestModels.AdminLinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeSegment(MasterPlayerModels.AdminRemoveSegmentRequestData requestData, Action1<MasterPlayerResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminRemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.RemoveSegmentOperationResponse> removeSegmentAsync(MasterPlayerModels.AdminRemoveSegmentRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminRemoveSegmentOperationRequest, MasterPlayerResponseModels.RemoveSegmentOperationResponse>(new MasterPlayerRequestModels.AdminRemoveSegmentOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeTag(MasterPlayerModels.AdminRemoveTagRequestData requestData, Action1<MasterPlayerResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminRemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.RemoveTagOperationResponse> removeTagAsync(MasterPlayerModels.AdminRemoveTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminRemoveTagOperationRequest, MasterPlayerResponseModels.RemoveTagOperationResponse>(new MasterPlayerRequestModels.AdminRemoveTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void resetAccountPassword(MasterPlayerModels.AdminResetAccountPasswordRequestData requestData, Action1<MasterPlayerResponseModels.ResetAccountPasswordOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminResetAccountPasswordOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.ResetAccountPasswordOperationResponse> resetAccountPasswordAsync(MasterPlayerModels.AdminResetAccountPasswordRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminResetAccountPasswordOperationRequest, MasterPlayerResponseModels.ResetAccountPasswordOperationResponse>(new MasterPlayerRequestModels.AdminResetAccountPasswordOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setAvatar(MasterPlayerModels.AdminSetAvatarRequestData requestData, Action1<MasterPlayerResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetAvatarOperationResponse> setAvatarAsync(MasterPlayerModels.AdminSetAvatarRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminSetAvatarOperationRequest, MasterPlayerResponseModels.SetAvatarOperationResponse>(new MasterPlayerRequestModels.AdminSetAvatarOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setCountryCode(MasterPlayerModels.AdminSetCountryCodeRequestData requestData, Action1<MasterPlayerResponseModels.SetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetCountryCodeOperationResponse> setCountryCodeAsync(MasterPlayerModels.AdminSetCountryCodeRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminSetCountryCodeOperationRequest, MasterPlayerResponseModels.SetCountryCodeOperationResponse>(new MasterPlayerRequestModels.AdminSetCountryCodeOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setCustomData(MasterPlayerModels.AdminSetCustomDataRequestData requestData, Action1<MasterPlayerResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetCustomDataOperationResponse> setCustomDataAsync(MasterPlayerModels.AdminSetCustomDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminSetCustomDataOperationRequest, MasterPlayerResponseModels.SetCustomDataOperationResponse>(new MasterPlayerRequestModels.AdminSetCustomDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setDisplayName(MasterPlayerModels.AdminSetDisplayNameRequestData requestData, Action1<MasterPlayerResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetDisplayNameOperationResponse> setDisplayNameAsync(MasterPlayerModels.AdminSetDisplayNameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminSetDisplayNameOperationRequest, MasterPlayerResponseModels.SetDisplayNameOperationResponse>(new MasterPlayerRequestModels.AdminSetDisplayNameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setEmail(MasterPlayerModels.AdminSetEmailRequestData requestData, Action1<MasterPlayerResponseModels.SetEmailOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetEmailOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetEmailOperationResponse> setEmailAsync(MasterPlayerModels.AdminSetEmailRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminSetEmailOperationRequest, MasterPlayerResponseModels.SetEmailOperationResponse>(new MasterPlayerRequestModels.AdminSetEmailOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setPlayerBan(MasterPlayerModels.AdminSetPlayerBanRequestData requestData, Action1<MasterPlayerResponseModels.SetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetPlayerBanOperationResponse> setPlayerBanAsync(MasterPlayerModels.AdminSetPlayerBanRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminSetPlayerBanOperationRequest, MasterPlayerResponseModels.SetPlayerBanOperationResponse>(new MasterPlayerRequestModels.AdminSetPlayerBanOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changePlayerCurrency(MasterPlayerModels.AdminChangePlayerCurrencyRequestData requestData, Action1<MasterPlayerResponseModels.ChangePlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminChangePlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.ChangePlayerCurrencyOperationResponse> changePlayerCurrencyAsync(MasterPlayerModels.AdminChangePlayerCurrencyRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminChangePlayerCurrencyOperationRequest, MasterPlayerResponseModels.ChangePlayerCurrencyOperationResponse>(new MasterPlayerRequestModels.AdminChangePlayerCurrencyOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setPlayerData(MasterPlayerModels.AdminSetPlayerDataRequestData requestData, Action1<MasterPlayerResponseModels.SetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetPlayerDataOperationResponse> setPlayerDataAsync(MasterPlayerModels.AdminSetPlayerDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminSetPlayerDataOperationRequest, MasterPlayerResponseModels.SetPlayerDataOperationResponse>(new MasterPlayerRequestModels.AdminSetPlayerDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void changePlayerStatistics(MasterPlayerModels.AdminChangePlayerStatisticsRequestData requestData, Action1<MasterPlayerResponseModels.ChangePlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminChangePlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.ChangePlayerStatisticsOperationResponse> changePlayerStatisticsAsync(MasterPlayerModels.AdminChangePlayerStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminChangePlayerStatisticsOperationRequest, MasterPlayerResponseModels.ChangePlayerStatisticsOperationResponse>(new MasterPlayerRequestModels.AdminChangePlayerStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setTag(MasterPlayerModels.AdminSetTagRequestData requestData, Action1<MasterPlayerResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetTagOperationResponse> setTagAsync(MasterPlayerModels.AdminSetTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminSetTagOperationRequest, MasterPlayerResponseModels.SetTagOperationResponse>(new MasterPlayerRequestModels.AdminSetTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setTsLastLogin(MasterPlayerModels.AdminSetTsLastLoginRequestData requestData, Action1<MasterPlayerResponseModels.SetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SetTsLastLoginOperationResponse> setTsLastLoginAsync(MasterPlayerModels.AdminSetTsLastLoginRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminSetTsLastLoginOperationRequest, MasterPlayerResponseModels.SetTsLastLoginOperationResponse>(new MasterPlayerRequestModels.AdminSetTsLastLoginOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkAccount(MasterPlayerModels.AdminUnlinkAccountRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkAccountOperationResponse> unlinkAccountAsync(MasterPlayerModels.AdminUnlinkAccountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminUnlinkAccountOperationRequest, MasterPlayerResponseModels.UnlinkAccountOperationResponse>(new MasterPlayerRequestModels.AdminUnlinkAccountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkAndroidDeviceId(MasterPlayerModels.AdminUnlinkAndroidDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkAndroidDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkAndroidDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkAndroidDeviceIdOperationResponse> unlinkAndroidDeviceIdAsync(MasterPlayerModels.AdminUnlinkAndroidDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminUnlinkAndroidDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkAndroidDeviceIdOperationResponse>(new MasterPlayerRequestModels.AdminUnlinkAndroidDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkApple(MasterPlayerModels.AdminUnlinkAppleRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkAppleOperationResponse> unlinkAppleAsync(MasterPlayerModels.AdminUnlinkAppleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminUnlinkAppleOperationRequest, MasterPlayerResponseModels.UnlinkAppleOperationResponse>(new MasterPlayerRequestModels.AdminUnlinkAppleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkCustomDeviceId(MasterPlayerModels.AdminUnlinkCustomDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkCustomDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkCustomDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkCustomDeviceIdOperationResponse> unlinkCustomDeviceIdAsync(MasterPlayerModels.AdminUnlinkCustomDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminUnlinkCustomDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkCustomDeviceIdOperationResponse>(new MasterPlayerRequestModels.AdminUnlinkCustomDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkCustomId(MasterPlayerModels.AdminUnlinkCustomIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkCustomIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkCustomIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkCustomIdOperationResponse> unlinkCustomIdAsync(MasterPlayerModels.AdminUnlinkCustomIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminUnlinkCustomIdOperationRequest, MasterPlayerResponseModels.UnlinkCustomIdOperationResponse>(new MasterPlayerRequestModels.AdminUnlinkCustomIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkEditorDeviceId(MasterPlayerModels.AdminUnlinkEditorDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkEditorDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkEditorDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkEditorDeviceIdOperationResponse> unlinkEditorDeviceIdAsync(MasterPlayerModels.AdminUnlinkEditorDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminUnlinkEditorDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkEditorDeviceIdOperationResponse>(new MasterPlayerRequestModels.AdminUnlinkEditorDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkFacebook(MasterPlayerModels.AdminUnlinkFacebookRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkFacebookOperationResponse> unlinkFacebookAsync(MasterPlayerModels.AdminUnlinkFacebookRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminUnlinkFacebookOperationRequest, MasterPlayerResponseModels.UnlinkFacebookOperationResponse>(new MasterPlayerRequestModels.AdminUnlinkFacebookOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkGenericService(MasterPlayerModels.AdminUnlinkGenericServiceRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkGenericServiceOperationResponse> unlinkGenericServiceAsync(MasterPlayerModels.AdminUnlinkGenericServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminUnlinkGenericServiceOperationRequest, MasterPlayerResponseModels.UnlinkGenericServiceOperationResponse>(new MasterPlayerRequestModels.AdminUnlinkGenericServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkGoogle(MasterPlayerModels.AdminUnlinkGoogleRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkGoogleOperationResponse> unlinkGoogleAsync(MasterPlayerModels.AdminUnlinkGoogleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminUnlinkGoogleOperationRequest, MasterPlayerResponseModels.UnlinkGoogleOperationResponse>(new MasterPlayerRequestModels.AdminUnlinkGoogleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkGooglePlayGameService(MasterPlayerModels.AdminUnlinkGooglePlayGameServiceRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkGooglePlayGameServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkGooglePlayGameServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkGooglePlayGameServiceOperationResponse> unlinkGooglePlayGameServiceAsync(MasterPlayerModels.AdminUnlinkGooglePlayGameServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminUnlinkGooglePlayGameServiceOperationRequest, MasterPlayerResponseModels.UnlinkGooglePlayGameServiceOperationResponse>(new MasterPlayerRequestModels.AdminUnlinkGooglePlayGameServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkGameCenter(MasterPlayerModels.AdminUnlinkGameCenterRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkGameCenterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkGameCenterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkGameCenterOperationResponse> unlinkGameCenterAsync(MasterPlayerModels.AdminUnlinkGameCenterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminUnlinkGameCenterOperationRequest, MasterPlayerResponseModels.UnlinkGameCenterOperationResponse>(new MasterPlayerRequestModels.AdminUnlinkGameCenterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkiOSDeviceId(MasterPlayerModels.AdminUnlinkiOSDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkiOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkiOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkiOSDeviceIdOperationResponse> unlinkiOSDeviceIdAsync(MasterPlayerModels.AdminUnlinkiOSDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminUnlinkiOSDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkiOSDeviceIdOperationResponse>(new MasterPlayerRequestModels.AdminUnlinkiOSDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkLinuxDeviceId(MasterPlayerModels.AdminUnlinkLinuxDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkLinuxDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkLinuxDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkLinuxDeviceIdOperationResponse> unlinkLinuxDeviceIdAsync(MasterPlayerModels.AdminUnlinkLinuxDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminUnlinkLinuxDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkLinuxDeviceIdOperationResponse>(new MasterPlayerRequestModels.AdminUnlinkLinuxDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkMacOSDeviceId(MasterPlayerModels.AdminUnlinkMacOSDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkMacOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkMacOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkMacOSDeviceIdOperationResponse> unlinkMacOSDeviceIdAsync(MasterPlayerModels.AdminUnlinkMacOSDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminUnlinkMacOSDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkMacOSDeviceIdOperationResponse>(new MasterPlayerRequestModels.AdminUnlinkMacOSDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkWindowsDeviceId(MasterPlayerModels.AdminUnlinkWindowsDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkWindowsDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkWindowsDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkWindowsDeviceIdOperationResponse> unlinkWindowsDeviceIdAsync(MasterPlayerModels.AdminUnlinkWindowsDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminUnlinkWindowsDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkWindowsDeviceIdOperationResponse>(new MasterPlayerRequestModels.AdminUnlinkWindowsDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void unlinkWindowsPhoneDeviceId(MasterPlayerModels.AdminUnlinkWindowsPhoneDeviceIdRequestData requestData, Action1<MasterPlayerResponseModels.UnlinkWindowsPhoneDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.UnlinkWindowsPhoneDeviceIdOperationResponse> unlinkWindowsPhoneDeviceIdAsync(MasterPlayerModels.AdminUnlinkWindowsPhoneDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminUnlinkWindowsPhoneDeviceIdOperationRequest, MasterPlayerResponseModels.UnlinkWindowsPhoneDeviceIdOperationResponse>(new MasterPlayerRequestModels.AdminUnlinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCurrencyLeaderboard(MasterPlayerModels.AdminGetCurrencyLeaderboardRequestData requestData, Action1<MasterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetCurrencyLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse> getCurrencyLeaderboardAsync(MasterPlayerModels.AdminGetCurrencyLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetCurrencyLeaderboardOperationRequest, MasterPlayerResponseModels.GetCurrencyLeaderboardOperationResponse>(new MasterPlayerRequestModels.AdminGetCurrencyLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getLastLoginLeaderboard(MasterPlayerModels.AdminGetLastLoginLeaderboardRequestData requestData, Action1<MasterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetLastLoginLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse> getLastLoginLeaderboardAsync(MasterPlayerModels.AdminGetLastLoginLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetLastLoginLeaderboardOperationRequest, MasterPlayerResponseModels.GetLastLoginLeaderboardOperationResponse>(new MasterPlayerRequestModels.AdminGetLastLoginLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCreateLeaderboard(MasterPlayerModels.AdminGetCreateLeaderboardRequestData requestData, Action1<MasterPlayerResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(MasterPlayerModels.AdminGetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetCreateLeaderboardOperationRequest, MasterPlayerResponseModels.GetCreateLeaderboardOperationResponse>(new MasterPlayerRequestModels.AdminGetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStatisticsLog(MasterPlayerModels.AdminGetStatisticsLogRequestData requestData, Action1<MasterPlayerResponseModels.GetStatisticsLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetStatisticsLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetStatisticsLogOperationResponse> getStatisticsLogAsync(MasterPlayerModels.AdminGetStatisticsLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetStatisticsLogOperationRequest, MasterPlayerResponseModels.GetStatisticsLogOperationResponse>(new MasterPlayerRequestModels.AdminGetStatisticsLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCurrencyLog(MasterPlayerModels.AdminGetCurrencyLogRequestData requestData, Action1<MasterPlayerResponseModels.GetCurrencyLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetCurrencyLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetCurrencyLogOperationResponse> getCurrencyLogAsync(MasterPlayerModels.AdminGetCurrencyLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetCurrencyLogOperationRequest, MasterPlayerResponseModels.GetCurrencyLogOperationResponse>(new MasterPlayerRequestModels.AdminGetCurrencyLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void sendSocketOperationEvent(MasterPlayerModels.AdminSendSocketOperationEventRequestData requestData, Action1<MasterPlayerResponseModels.SendSocketOperationEventOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSendSocketOperationEventOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SendSocketOperationEventOperationResponse> sendSocketOperationEventAsync(MasterPlayerModels.AdminSendSocketOperationEventRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminSendSocketOperationEventOperationRequest, MasterPlayerResponseModels.SendSocketOperationEventOperationResponse>(new MasterPlayerRequestModels.AdminSendSocketOperationEventOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void sendEmail(MasterPlayerModels.AdminSendEmailRequestData requestData, Action1<MasterPlayerResponseModels.SendEmailOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSendEmailOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SendEmailOperationResponse> sendEmailAsync(MasterPlayerModels.AdminSendEmailRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminSendEmailOperationRequest, MasterPlayerResponseModels.SendEmailOperationResponse>(new MasterPlayerRequestModels.AdminSendEmailOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void addPushNotification(MasterPlayerModels.AdminAddPushNotificationRequestData requestData, Action1<MasterPlayerResponseModels.AddPushNotificationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminAddPushNotificationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.AddPushNotificationOperationResponse> addPushNotificationAsync(MasterPlayerModels.AdminAddPushNotificationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminAddPushNotificationOperationRequest, MasterPlayerResponseModels.AddPushNotificationOperationResponse>(new MasterPlayerRequestModels.AdminAddPushNotificationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removePushNotification(MasterPlayerModels.AdminRemovePushNotificationRequestData requestData, Action1<MasterPlayerResponseModels.RemovePushNotificationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminRemovePushNotificationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.RemovePushNotificationOperationResponse> removePushNotificationAsync(MasterPlayerModels.AdminRemovePushNotificationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminRemovePushNotificationOperationRequest, MasterPlayerResponseModels.RemovePushNotificationOperationResponse>(new MasterPlayerRequestModels.AdminRemovePushNotificationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getPushNotification(MasterPlayerModels.AdminGetPushNotificationRequestData requestData, Action1<MasterPlayerResponseModels.GetPushNotificationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPushNotificationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.GetPushNotificationOperationResponse> getPushNotificationAsync(MasterPlayerModels.AdminGetPushNotificationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminGetPushNotificationOperationRequest, MasterPlayerResponseModels.GetPushNotificationOperationResponse>(new MasterPlayerRequestModels.AdminGetPushNotificationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void sendPushNotification(MasterPlayerModels.AdminSendPushNotificationRequestData requestData, Action1<MasterPlayerResponseModels.SendPushNotificationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSendPushNotificationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MasterPlayerResponseModels.SendPushNotificationOperationResponse> sendPushNotificationAsync(MasterPlayerModels.AdminSendPushNotificationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MasterPlayerRequestModels.AdminSendPushNotificationOperationRequest, MasterPlayerResponseModels.SendPushNotificationOperationResponse>(new MasterPlayerRequestModels.AdminSendPushNotificationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

    }

    public static partial class GNNetwork
    {

        public static MasterPlayerApi masterPlayer { get; }
    }

}
