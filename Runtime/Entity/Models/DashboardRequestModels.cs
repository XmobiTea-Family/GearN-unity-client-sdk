namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    public class DashboardRequestModels
    {
        public class ChangePasswordAdminAccountOperationRequest : CustomOperationRequest<DashboardModels.ChangePasswordAdminAccountRequestData>
        {
            protected override string operationCode => OperationCode.ChangePasswordAdminAccount;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public ChangePasswordAdminAccountOperationRequest(DashboardModels.ChangePasswordAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetAdminAccountListOperationRequest : CustomOperationRequest<DashboardModels.GetAdminAccountListRequestData>
        {
            protected override string operationCode => OperationCode.GetAdminAccountList;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public GetAdminAccountListOperationRequest(DashboardModels.GetAdminAccountListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetGameInformationOperationRequest : CustomOperationRequest<DashboardModels.GetGameInformationRequestData>
        {
            protected override string operationCode => OperationCode.GetGameInformation;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public GetGameInformationOperationRequest(DashboardModels.GetGameInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetGameListOperationRequest : CustomOperationRequest<DashboardModels.GetGameListRequestData>
        {
            protected override string operationCode => OperationCode.GetGameList;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public GetGameListOperationRequest(DashboardModels.GetGameListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetMasterGameSettingsOperationRequest : CustomOperationRequest<DashboardModels.GetMasterGameSettingsRequestData>
        {
            protected override string operationCode => OperationCode.GetMasterGameSettings;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public GetMasterGameSettingsOperationRequest(DashboardModels.GetMasterGameSettingsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetSecretInfoInformationOperationRequest : CustomOperationRequest<DashboardModels.GetSecretInfoInformationRequestData>
        {
            protected override string operationCode => OperationCode.GetSecretInfoInformation;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public GetSecretInfoInformationOperationRequest(DashboardModels.GetSecretInfoInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetSecretInfoListOperationRequest : CustomOperationRequest<DashboardModels.GetSecretInfoListRequestData>
        {
            protected override string operationCode => OperationCode.GetSecretInfoList;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public GetSecretInfoListOperationRequest(DashboardModels.GetSecretInfoListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetServerLogOperationRequest : CustomOperationRequest<DashboardModels.GetServerLogRequestData>
        {
            protected override string operationCode => OperationCode.GetServerLog;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public GetServerLogOperationRequest(DashboardModels.GetServerLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class CreateAdminAccountOperationRequest : CustomOperationRequest<DashboardModels.CreateAdminAccountRequestData>
        {
            protected override string operationCode => OperationCode.CreateAdminAccount;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public CreateAdminAccountOperationRequest(DashboardModels.CreateAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class CreateGameOperationRequest : CustomOperationRequest<DashboardModels.CreateGameRequestData>
        {
            protected override string operationCode => OperationCode.CreateGame;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public CreateGameOperationRequest(DashboardModels.CreateGameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class CreateSecretInfoOperationRequest : CustomOperationRequest<DashboardModels.CreateSecretInfoRequestData>
        {
            protected override string operationCode => OperationCode.CreateSecretInfo;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public CreateSecretInfoOperationRequest(DashboardModels.CreateSecretInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LoginByAdminAccountOperationRequest : CustomOperationRequest<DashboardModels.LoginByAdminAccountRequestData>
        {
            protected override string operationCode => OperationCode.LoginByAdminAccount;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public LoginByAdminAccountOperationRequest(DashboardModels.LoginByAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RemoveAdminAccountOperationRequest : CustomOperationRequest<DashboardModels.RemoveAdminAccountRequestData>
        {
            protected override string operationCode => OperationCode.RemoveAdminAccount;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public RemoveAdminAccountOperationRequest(DashboardModels.RemoveAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetGameInformationOperationRequest : CustomOperationRequest<DashboardModels.SetGameInformationRequestData>
        {
            protected override string operationCode => OperationCode.SetGameInformation;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public SetGameInformationOperationRequest(DashboardModels.SetGameInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetMasterGameSettingsOperationRequest : CustomOperationRequest<DashboardModels.SetMasterGameSettingsRequestData>
        {
            protected override string operationCode => OperationCode.SetMasterGameSettings;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public SetMasterGameSettingsOperationRequest(DashboardModels.SetMasterGameSettingsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetPasswordAdminAccountOperationRequest : CustomOperationRequest<DashboardModels.SetPasswordAdminAccountRequestData>
        {
            protected override string operationCode => OperationCode.SetPasswordAdminAccount;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public SetPasswordAdminAccountOperationRequest(DashboardModels.SetPasswordAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetSecretInfoInformationOperationRequest : CustomOperationRequest<DashboardModels.SetSecretInfoInformationRequestData>
        {
            protected override string operationCode => OperationCode.SetSecretInfoInformation;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public SetSecretInfoInformationOperationRequest(DashboardModels.SetSecretInfoInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetSecretKeyAdminAccountOperationRequest : CustomOperationRequest<DashboardModels.SetSecretKeyAdminAccountRequestData>
        {
            protected override string operationCode => OperationCode.SetSecretKeyAdminAccount;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public SetSecretKeyAdminAccountOperationRequest(DashboardModels.SetSecretKeyAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetUsernameAdminAccountOperationRequest : CustomOperationRequest<DashboardModels.GetUsernameAdminAccountRequestData>
        {
            protected override string operationCode => OperationCode.GetUsernameAdminAccount;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public GetUsernameAdminAccountOperationRequest(DashboardModels.GetUsernameAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetAnalyticsOperationRequest : CustomOperationRequest<DashboardModels.GetAnalyticsRequestData>
        {
            protected override string operationCode => OperationCode.GetAnalytics;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public GetAnalyticsOperationRequest(DashboardModels.GetAnalyticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetEventCallbackCloudScriptOperationRequest : CustomOperationRequest<DashboardModels.GetEventCallbackCloudScriptRequestData>
        {
            protected override string operationCode => OperationCode.GetEventCallbackCloudScript;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public GetEventCallbackCloudScriptOperationRequest(DashboardModels.GetEventCallbackCloudScriptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class SetEventCallbackCloudScriptOperationRequest : CustomOperationRequest<DashboardModels.SetEventCallbackCloudScriptRequestData>
        {
            protected override string operationCode => OperationCode.SetEventCallbackCloudScript;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public SetEventCallbackCloudScriptOperationRequest(DashboardModels.SetEventCallbackCloudScriptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ResetStatisticsLeaderboardOperationRequest : CustomOperationRequest<DashboardModels.ResetStatisticsLeaderboardRequestData>
        {
            protected override string operationCode => OperationCode.ResetStatisticsLeaderboard;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public ResetStatisticsLeaderboardOperationRequest(DashboardModels.ResetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetBackupStatisticsLeaderboardVersionOperationRequest : CustomOperationRequest<DashboardModels.GetBackupStatisticsLeaderboardVersionRequestData>
        {
            protected override string operationCode => OperationCode.GetBackupStatisticsLeaderboardVersion;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public GetBackupStatisticsLeaderboardVersionOperationRequest(DashboardModels.GetBackupStatisticsLeaderboardVersionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class GetServerGameDataOperationRequest : CustomOperationRequest<DashboardModels.GetServerGameDataRequestData>
        {
            protected override string operationCode => OperationCode.GetServerGameData;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public GetServerGameDataOperationRequest(DashboardModels.GetServerGameDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class DeleteInDatabaseOperationRequest : CustomOperationRequest<DashboardModels.DeleteInDatabaseRequestData>
        {
            protected override string operationCode => OperationCode.DeleteInDatabase;
            protected override RequestType requestType => RequestType.Dashboard;
            protected override RequestRole role => RequestRole.Client;

            public DeleteInDatabaseOperationRequest(DashboardModels.DeleteInDatabaseRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}
