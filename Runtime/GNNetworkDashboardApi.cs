namespace XmobiTea.GearN
{
    using System.Threading.Tasks;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Models;

    public class DashboardApi
    {
        public ServerApi server { get; } = new ServerApi();

        public AdminApi admin { get; } = new AdminApi();

        public void changePasswordAdminAccount(DashboardModels.ChangePasswordAdminAccountRequestData requestData, Action1<DashboardResponseModels.ChangePasswordAdminAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.ChangePasswordAdminAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.ChangePasswordAdminAccountOperationResponse> changePasswordAdminAccountAsync(DashboardModels.ChangePasswordAdminAccountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.ChangePasswordAdminAccountOperationRequest, DashboardResponseModels.ChangePasswordAdminAccountOperationResponse>(new DashboardRequestModels.ChangePasswordAdminAccountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getAdminAccountList(DashboardModels.GetAdminAccountListRequestData requestData, Action1<DashboardResponseModels.GetAdminAccountListOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.GetAdminAccountListOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.GetAdminAccountListOperationResponse> getAdminAccountListAsync(DashboardModels.GetAdminAccountListRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.GetAdminAccountListOperationRequest, DashboardResponseModels.GetAdminAccountListOperationResponse>(new DashboardRequestModels.GetAdminAccountListOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getGameInformation(DashboardModels.GetGameInformationRequestData requestData, Action1<DashboardResponseModels.GetGameInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.GetGameInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.GetGameInformationOperationResponse> getGameInformationAsync(DashboardModels.GetGameInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.GetGameInformationOperationRequest, DashboardResponseModels.GetGameInformationOperationResponse>(new DashboardRequestModels.GetGameInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getGameList(DashboardModels.GetGameListRequestData requestData, Action1<DashboardResponseModels.GetGameListOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.GetGameListOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.GetGameListOperationResponse> getGameListAsync(DashboardModels.GetGameListRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.GetGameListOperationRequest, DashboardResponseModels.GetGameListOperationResponse>(new DashboardRequestModels.GetGameListOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getMasterGameSettings(DashboardModels.GetMasterGameSettingsRequestData requestData, Action1<DashboardResponseModels.GetMasterGameSettingsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.GetMasterGameSettingsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.GetMasterGameSettingsOperationResponse> getMasterGameSettingsAsync(DashboardModels.GetMasterGameSettingsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.GetMasterGameSettingsOperationRequest, DashboardResponseModels.GetMasterGameSettingsOperationResponse>(new DashboardRequestModels.GetMasterGameSettingsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getSecretInfoInformation(DashboardModels.GetSecretInfoInformationRequestData requestData, Action1<DashboardResponseModels.GetSecretInfoInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.GetSecretInfoInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.GetSecretInfoInformationOperationResponse> getSecretInfoInformationAsync(DashboardModels.GetSecretInfoInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.GetSecretInfoInformationOperationRequest, DashboardResponseModels.GetSecretInfoInformationOperationResponse>(new DashboardRequestModels.GetSecretInfoInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getSecretInfoList(DashboardModels.GetSecretInfoListRequestData requestData, Action1<DashboardResponseModels.GetSecretInfoListOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.GetSecretInfoListOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.GetSecretInfoListOperationResponse> getSecretInfoListAsync(DashboardModels.GetSecretInfoListRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.GetSecretInfoListOperationRequest, DashboardResponseModels.GetSecretInfoListOperationResponse>(new DashboardRequestModels.GetSecretInfoListOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getServerLog(DashboardModels.GetServerLogRequestData requestData, Action1<DashboardResponseModels.GetServerLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.GetServerLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.GetServerLogOperationResponse> getServerLogAsync(DashboardModels.GetServerLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.GetServerLogOperationRequest, DashboardResponseModels.GetServerLogOperationResponse>(new DashboardRequestModels.GetServerLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void createAdminAccount(DashboardModels.CreateAdminAccountRequestData requestData, Action1<DashboardResponseModels.CreateAdminAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.CreateAdminAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.CreateAdminAccountOperationResponse> createAdminAccountAsync(DashboardModels.CreateAdminAccountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.CreateAdminAccountOperationRequest, DashboardResponseModels.CreateAdminAccountOperationResponse>(new DashboardRequestModels.CreateAdminAccountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void createGame(DashboardModels.CreateGameRequestData requestData, Action1<DashboardResponseModels.CreateGameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.CreateGameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.CreateGameOperationResponse> createGameAsync(DashboardModels.CreateGameRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.CreateGameOperationRequest, DashboardResponseModels.CreateGameOperationResponse>(new DashboardRequestModels.CreateGameOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void createSecretInfo(DashboardModels.CreateSecretInfoRequestData requestData, Action1<DashboardResponseModels.CreateSecretInfoOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.CreateSecretInfoOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.CreateSecretInfoOperationResponse> createSecretInfoAsync(DashboardModels.CreateSecretInfoRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.CreateSecretInfoOperationRequest, DashboardResponseModels.CreateSecretInfoOperationResponse>(new DashboardRequestModels.CreateSecretInfoOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void loginByAdminAccount(DashboardModels.LoginByAdminAccountRequestData requestData, Action1<DashboardResponseModels.LoginByAdminAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.LoginByAdminAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.LoginByAdminAccountOperationResponse> loginByAdminAccountAsync(DashboardModels.LoginByAdminAccountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.LoginByAdminAccountOperationRequest, DashboardResponseModels.LoginByAdminAccountOperationResponse>(new DashboardRequestModels.LoginByAdminAccountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removeAdminAccount(DashboardModels.RemoveAdminAccountRequestData requestData, Action1<DashboardResponseModels.RemoveAdminAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.RemoveAdminAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.RemoveAdminAccountOperationResponse> removeAdminAccountAsync(DashboardModels.RemoveAdminAccountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.RemoveAdminAccountOperationRequest, DashboardResponseModels.RemoveAdminAccountOperationResponse>(new DashboardRequestModels.RemoveAdminAccountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setGameInformation(DashboardModels.SetGameInformationRequestData requestData, Action1<DashboardResponseModels.SetGameInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.SetGameInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.SetGameInformationOperationResponse> setGameInformationAsync(DashboardModels.SetGameInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.SetGameInformationOperationRequest, DashboardResponseModels.SetGameInformationOperationResponse>(new DashboardRequestModels.SetGameInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setMasterGameSettings(DashboardModels.SetMasterGameSettingsRequestData requestData, Action1<DashboardResponseModels.SetMasterGameSettingsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.SetMasterGameSettingsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.SetMasterGameSettingsOperationResponse> setMasterGameSettingsAsync(DashboardModels.SetMasterGameSettingsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.SetMasterGameSettingsOperationRequest, DashboardResponseModels.SetMasterGameSettingsOperationResponse>(new DashboardRequestModels.SetMasterGameSettingsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setPasswordAdminAccount(DashboardModels.SetPasswordAdminAccountRequestData requestData, Action1<DashboardResponseModels.SetPasswordAdminAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.SetPasswordAdminAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.SetPasswordAdminAccountOperationResponse> setPasswordAdminAccountAsync(DashboardModels.SetPasswordAdminAccountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.SetPasswordAdminAccountOperationRequest, DashboardResponseModels.SetPasswordAdminAccountOperationResponse>(new DashboardRequestModels.SetPasswordAdminAccountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setSecretInfoInformation(DashboardModels.SetSecretInfoInformationRequestData requestData, Action1<DashboardResponseModels.SetSecretInfoInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.SetSecretInfoInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.SetSecretInfoInformationOperationResponse> setSecretInfoInformationAsync(DashboardModels.SetSecretInfoInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.SetSecretInfoInformationOperationRequest, DashboardResponseModels.SetSecretInfoInformationOperationResponse>(new DashboardRequestModels.SetSecretInfoInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setSecretKeyAdminAccount(DashboardModels.SetSecretKeyAdminAccountRequestData requestData, Action1<DashboardResponseModels.SetSecretKeyAdminAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.SetSecretKeyAdminAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.SetSecretKeyAdminAccountOperationResponse> setSecretKeyAdminAccountAsync(DashboardModels.SetSecretKeyAdminAccountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.SetSecretKeyAdminAccountOperationRequest, DashboardResponseModels.SetSecretKeyAdminAccountOperationResponse>(new DashboardRequestModels.SetSecretKeyAdminAccountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getUsernameAdminAccount(DashboardModels.GetUsernameAdminAccountRequestData requestData, Action1<DashboardResponseModels.GetUsernameAdminAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.GetUsernameAdminAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.GetUsernameAdminAccountOperationResponse> getUsernameAdminAccountAsync(DashboardModels.GetUsernameAdminAccountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.GetUsernameAdminAccountOperationRequest, DashboardResponseModels.GetUsernameAdminAccountOperationResponse>(new DashboardRequestModels.GetUsernameAdminAccountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getAnalytics(DashboardModels.GetAnalyticsRequestData requestData, Action1<DashboardResponseModels.GetAnalyticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.GetAnalyticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.GetAnalyticsOperationResponse> getAnalyticsAsync(DashboardModels.GetAnalyticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.GetAnalyticsOperationRequest, DashboardResponseModels.GetAnalyticsOperationResponse>(new DashboardRequestModels.GetAnalyticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getEventCallbackCloudScript(DashboardModels.GetEventCallbackCloudScriptRequestData requestData, Action1<DashboardResponseModels.GetEventCallbackCloudScriptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.GetEventCallbackCloudScriptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.GetEventCallbackCloudScriptOperationResponse> getEventCallbackCloudScriptAsync(DashboardModels.GetEventCallbackCloudScriptRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.GetEventCallbackCloudScriptOperationRequest, DashboardResponseModels.GetEventCallbackCloudScriptOperationResponse>(new DashboardRequestModels.GetEventCallbackCloudScriptOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setEventCallbackCloudScript(DashboardModels.SetEventCallbackCloudScriptRequestData requestData, Action1<DashboardResponseModels.SetEventCallbackCloudScriptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.SetEventCallbackCloudScriptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.SetEventCallbackCloudScriptOperationResponse> setEventCallbackCloudScriptAsync(DashboardModels.SetEventCallbackCloudScriptRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.SetEventCallbackCloudScriptOperationRequest, DashboardResponseModels.SetEventCallbackCloudScriptOperationResponse>(new DashboardRequestModels.SetEventCallbackCloudScriptOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void resetStatisticsLeaderboard(DashboardModels.ResetStatisticsLeaderboardRequestData requestData, Action1<DashboardResponseModels.ResetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.ResetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.ResetStatisticsLeaderboardOperationResponse> resetStatisticsLeaderboardAsync(DashboardModels.ResetStatisticsLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.ResetStatisticsLeaderboardOperationRequest, DashboardResponseModels.ResetStatisticsLeaderboardOperationResponse>(new DashboardRequestModels.ResetStatisticsLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getBackupStatisticsLeaderboardVersion(DashboardModels.GetBackupStatisticsLeaderboardVersionRequestData requestData, Action1<DashboardResponseModels.GetBackupStatisticsLeaderboardVersionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.GetBackupStatisticsLeaderboardVersionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.GetBackupStatisticsLeaderboardVersionOperationResponse> getBackupStatisticsLeaderboardVersionAsync(DashboardModels.GetBackupStatisticsLeaderboardVersionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.GetBackupStatisticsLeaderboardVersionOperationRequest, DashboardResponseModels.GetBackupStatisticsLeaderboardVersionOperationResponse>(new DashboardRequestModels.GetBackupStatisticsLeaderboardVersionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getServerGameData(DashboardModels.GetServerGameDataRequestData requestData, Action1<DashboardResponseModels.GetServerGameDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.GetServerGameDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.GetServerGameDataOperationResponse> getServerGameDataAsync(DashboardModels.GetServerGameDataRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.GetServerGameDataOperationRequest, DashboardResponseModels.GetServerGameDataOperationResponse>(new DashboardRequestModels.GetServerGameDataOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void deleteInDatabase(DashboardModels.DeleteInDatabaseRequestData requestData, Action1<DashboardResponseModels.DeleteInDatabaseOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new DashboardRequestModels.DeleteInDatabaseOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<DashboardResponseModels.DeleteInDatabaseOperationResponse> deleteInDatabaseAsync(DashboardModels.DeleteInDatabaseRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<DashboardRequestModels.DeleteInDatabaseOperationRequest, DashboardResponseModels.DeleteInDatabaseOperationResponse>(new DashboardRequestModels.DeleteInDatabaseOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public class ServerApi
        {
        }

        public class AdminApi
        {
        }

    }

    public static partial class GNNetwork
    {

        public static DashboardApi dashboard { get; }
    }

}
