namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    /// <summary>
    /// Defines typed request wrappers for dashboard operations.
    /// </summary>
    public class DashboardRequestModels
    {
        /// <summary>
        /// Builds the change password admin account operation request.
        /// </summary>
        public class ChangePasswordAdminAccountOperationRequest : CustomOperationRequestAbstract<DashboardModels.ChangePasswordAdminAccountRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ChangePasswordAdminAccount;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ChangePasswordAdminAccountOperationRequest class.
            /// </summary>
            public ChangePasswordAdminAccountOperationRequest(DashboardModels.ChangePasswordAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get admin account list operation request.
        /// </summary>
        public class GetAdminAccountListOperationRequest : CustomOperationRequestAbstract<DashboardModels.GetAdminAccountListRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetAdminAccountList;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetAdminAccountListOperationRequest class.
            /// </summary>
            public GetAdminAccountListOperationRequest(DashboardModels.GetAdminAccountListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get game information operation request.
        /// </summary>
        public class GetGameInformationOperationRequest : CustomOperationRequestAbstract<DashboardModels.GetGameInformationRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetGameInformation;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetGameInformationOperationRequest class.
            /// </summary>
            public GetGameInformationOperationRequest(DashboardModels.GetGameInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get game list operation request.
        /// </summary>
        public class GetGameListOperationRequest : CustomOperationRequestAbstract<DashboardModels.GetGameListRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetGameList;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetGameListOperationRequest class.
            /// </summary>
            public GetGameListOperationRequest(DashboardModels.GetGameListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get master game settings operation request.
        /// </summary>
        public class GetMasterGameSettingsOperationRequest : CustomOperationRequestAbstract<DashboardModels.GetMasterGameSettingsRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetMasterGameSettings;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetMasterGameSettingsOperationRequest class.
            /// </summary>
            public GetMasterGameSettingsOperationRequest(DashboardModels.GetMasterGameSettingsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get secret info information operation request.
        /// </summary>
        public class GetSecretInfoInformationOperationRequest : CustomOperationRequestAbstract<DashboardModels.GetSecretInfoInformationRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetSecretInfoInformation;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetSecretInfoInformationOperationRequest class.
            /// </summary>
            public GetSecretInfoInformationOperationRequest(DashboardModels.GetSecretInfoInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get secret info list operation request.
        /// </summary>
        public class GetSecretInfoListOperationRequest : CustomOperationRequestAbstract<DashboardModels.GetSecretInfoListRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetSecretInfoList;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetSecretInfoListOperationRequest class.
            /// </summary>
            public GetSecretInfoListOperationRequest(DashboardModels.GetSecretInfoListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get server log operation request.
        /// </summary>
        public class GetServerLogOperationRequest : CustomOperationRequestAbstract<DashboardModels.GetServerLogRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetServerLog;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetServerLogOperationRequest class.
            /// </summary>
            public GetServerLogOperationRequest(DashboardModels.GetServerLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the create admin account operation request.
        /// </summary>
        public class CreateAdminAccountOperationRequest : CustomOperationRequestAbstract<DashboardModels.CreateAdminAccountRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.CreateAdminAccount;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the CreateAdminAccountOperationRequest class.
            /// </summary>
            public CreateAdminAccountOperationRequest(DashboardModels.CreateAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the create game operation request.
        /// </summary>
        public class CreateGameOperationRequest : CustomOperationRequestAbstract<DashboardModels.CreateGameRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.CreateGame;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the CreateGameOperationRequest class.
            /// </summary>
            public CreateGameOperationRequest(DashboardModels.CreateGameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the create secret info operation request.
        /// </summary>
        public class CreateSecretInfoOperationRequest : CustomOperationRequestAbstract<DashboardModels.CreateSecretInfoRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.CreateSecretInfo;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the CreateSecretInfoOperationRequest class.
            /// </summary>
            public CreateSecretInfoOperationRequest(DashboardModels.CreateSecretInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the login by admin account operation request.
        /// </summary>
        public class LoginByAdminAccountOperationRequest : CustomOperationRequestAbstract<DashboardModels.LoginByAdminAccountRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LoginByAdminAccount;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LoginByAdminAccountOperationRequest class.
            /// </summary>
            public LoginByAdminAccountOperationRequest(DashboardModels.LoginByAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove admin account operation request.
        /// </summary>
        public class RemoveAdminAccountOperationRequest : CustomOperationRequestAbstract<DashboardModels.RemoveAdminAccountRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemoveAdminAccount;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemoveAdminAccountOperationRequest class.
            /// </summary>
            public RemoveAdminAccountOperationRequest(DashboardModels.RemoveAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set game information operation request.
        /// </summary>
        public class SetGameInformationOperationRequest : CustomOperationRequestAbstract<DashboardModels.SetGameInformationRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetGameInformation;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetGameInformationOperationRequest class.
            /// </summary>
            public SetGameInformationOperationRequest(DashboardModels.SetGameInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set master game settings operation request.
        /// </summary>
        public class SetMasterGameSettingsOperationRequest : CustomOperationRequestAbstract<DashboardModels.SetMasterGameSettingsRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetMasterGameSettings;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetMasterGameSettingsOperationRequest class.
            /// </summary>
            public SetMasterGameSettingsOperationRequest(DashboardModels.SetMasterGameSettingsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set password admin account operation request.
        /// </summary>
        public class SetPasswordAdminAccountOperationRequest : CustomOperationRequestAbstract<DashboardModels.SetPasswordAdminAccountRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetPasswordAdminAccount;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetPasswordAdminAccountOperationRequest class.
            /// </summary>
            public SetPasswordAdminAccountOperationRequest(DashboardModels.SetPasswordAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set secret info information operation request.
        /// </summary>
        public class SetSecretInfoInformationOperationRequest : CustomOperationRequestAbstract<DashboardModels.SetSecretInfoInformationRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetSecretInfoInformation;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetSecretInfoInformationOperationRequest class.
            /// </summary>
            public SetSecretInfoInformationOperationRequest(DashboardModels.SetSecretInfoInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set secret key admin account operation request.
        /// </summary>
        public class SetSecretKeyAdminAccountOperationRequest : CustomOperationRequestAbstract<DashboardModels.SetSecretKeyAdminAccountRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetSecretKeyAdminAccount;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetSecretKeyAdminAccountOperationRequest class.
            /// </summary>
            public SetSecretKeyAdminAccountOperationRequest(DashboardModels.SetSecretKeyAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get username admin account operation request.
        /// </summary>
        public class GetUsernameAdminAccountOperationRequest : CustomOperationRequestAbstract<DashboardModels.GetUsernameAdminAccountRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetUsernameAdminAccount;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetUsernameAdminAccountOperationRequest class.
            /// </summary>
            public GetUsernameAdminAccountOperationRequest(DashboardModels.GetUsernameAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get analytics operation request.
        /// </summary>
        public class GetAnalyticsOperationRequest : CustomOperationRequestAbstract<DashboardModels.GetAnalyticsRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetAnalytics;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetAnalyticsOperationRequest class.
            /// </summary>
            public GetAnalyticsOperationRequest(DashboardModels.GetAnalyticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get event callback cloud script operation request.
        /// </summary>
        public class GetEventCallbackCloudScriptOperationRequest : CustomOperationRequestAbstract<DashboardModels.GetEventCallbackCloudScriptRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetEventCallbackCloudScript;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetEventCallbackCloudScriptOperationRequest class.
            /// </summary>
            public GetEventCallbackCloudScriptOperationRequest(DashboardModels.GetEventCallbackCloudScriptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set event callback cloud script operation request.
        /// </summary>
        public class SetEventCallbackCloudScriptOperationRequest : CustomOperationRequestAbstract<DashboardModels.SetEventCallbackCloudScriptRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetEventCallbackCloudScript;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetEventCallbackCloudScriptOperationRequest class.
            /// </summary>
            public SetEventCallbackCloudScriptOperationRequest(DashboardModels.SetEventCallbackCloudScriptRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the reset statistics leaderboard operation request.
        /// </summary>
        public class ResetStatisticsLeaderboardOperationRequest : CustomOperationRequestAbstract<DashboardModels.ResetStatisticsLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ResetStatisticsLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ResetStatisticsLeaderboardOperationRequest class.
            /// </summary>
            public ResetStatisticsLeaderboardOperationRequest(DashboardModels.ResetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get backup statistics leaderboard version operation request.
        /// </summary>
        public class GetBackupStatisticsLeaderboardVersionOperationRequest : CustomOperationRequestAbstract<DashboardModels.GetBackupStatisticsLeaderboardVersionRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetBackupStatisticsLeaderboardVersion;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetBackupStatisticsLeaderboardVersionOperationRequest class.
            /// </summary>
            public GetBackupStatisticsLeaderboardVersionOperationRequest(DashboardModels.GetBackupStatisticsLeaderboardVersionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get server game data operation request.
        /// </summary>
        public class GetServerGameDataOperationRequest : CustomOperationRequestAbstract<DashboardModels.GetServerGameDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetServerGameData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetServerGameDataOperationRequest class.
            /// </summary>
            public GetServerGameDataOperationRequest(DashboardModels.GetServerGameDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the delete in database operation request.
        /// </summary>
        public class DeleteInDatabaseOperationRequest : CustomOperationRequestAbstract<DashboardModels.DeleteInDatabaseRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.DeleteInDatabase;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Dashboard;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the DeleteInDatabaseOperationRequest class.
            /// </summary>
            public DeleteInDatabaseOperationRequest(DashboardModels.DeleteInDatabaseRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}