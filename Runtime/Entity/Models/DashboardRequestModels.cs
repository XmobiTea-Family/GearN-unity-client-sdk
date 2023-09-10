namespace XmobiTea.GN.Entity.Models
{
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity.Request;

	public class DashboardRequestModels
	{
		public class ChangePasswordAdminAccountOperationRequest : CustomOperationRequest<DashboardModels.ChangePasswordAdminAccountRequestData>
		{
			protected override int operationCode => OperationCode.ChangePasswordAdminAccount;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public ChangePasswordAdminAccountOperationRequest(DashboardModels.ChangePasswordAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetAdminAccountListOperationRequest : CustomOperationRequest<DashboardModels.GetAdminAccountListRequestData>
		{
			protected override int operationCode => OperationCode.GetAdminAccountList;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetAdminAccountListOperationRequest(DashboardModels.GetAdminAccountListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetGameInformationOperationRequest : CustomOperationRequest<DashboardModels.GetGameInformationRequestData>
		{
			protected override int operationCode => OperationCode.GetGameInformation;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetGameInformationOperationRequest(DashboardModels.GetGameInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetGameListOperationRequest : CustomOperationRequest<DashboardModels.GetGameListRequestData>
		{
			protected override int operationCode => OperationCode.GetGameList;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetGameListOperationRequest(DashboardModels.GetGameListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetMasterGameSettingsOperationRequest : CustomOperationRequest<DashboardModels.GetMasterGameSettingsRequestData>
		{
			protected override int operationCode => OperationCode.GetMasterGameSettings;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetMasterGameSettingsOperationRequest(DashboardModels.GetMasterGameSettingsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetSecretInfoInformationOperationRequest : CustomOperationRequest<DashboardModels.GetSecretInfoInformationRequestData>
		{
			protected override int operationCode => OperationCode.GetSecretInfoInformation;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetSecretInfoInformationOperationRequest(DashboardModels.GetSecretInfoInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetSecretInfoListOperationRequest : CustomOperationRequest<DashboardModels.GetSecretInfoListRequestData>
		{
			protected override int operationCode => OperationCode.GetSecretInfoList;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetSecretInfoListOperationRequest(DashboardModels.GetSecretInfoListRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GetServerLogOperationRequest : CustomOperationRequest<DashboardModels.GetServerLogRequestData>
		{
			protected override int operationCode => OperationCode.GetServerLog;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public GetServerLogOperationRequest(DashboardModels.GetServerLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GrantAdminAccountOperationRequest : CustomOperationRequest<DashboardModels.GrantAdminAccountRequestData>
		{
			protected override int operationCode => OperationCode.GrantAdminAccount;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public GrantAdminAccountOperationRequest(DashboardModels.GrantAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GrantGameOperationRequest : CustomOperationRequest<DashboardModels.GrantGameRequestData>
		{
			protected override int operationCode => OperationCode.GrantGame;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public GrantGameOperationRequest(DashboardModels.GrantGameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class GrantSecretInfoOperationRequest : CustomOperationRequest<DashboardModels.GrantSecretInfoRequestData>
		{
			protected override int operationCode => OperationCode.GrantSecretInfo;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public GrantSecretInfoOperationRequest(DashboardModels.GrantSecretInfoRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LoginByAdminAccountOperationRequest : CustomOperationRequest<DashboardModels.LoginByAdminAccountRequestData>
		{
			protected override int operationCode => OperationCode.LoginByAdminAccount;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public LoginByAdminAccountOperationRequest(DashboardModels.LoginByAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class RemoveAdminAccountOperationRequest : CustomOperationRequest<DashboardModels.RemoveAdminAccountRequestData>
		{
			protected override int operationCode => OperationCode.RemoveAdminAccount;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public RemoveAdminAccountOperationRequest(DashboardModels.RemoveAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetGameInformationOperationRequest : CustomOperationRequest<DashboardModels.SetGameInformationRequestData>
		{
			protected override int operationCode => OperationCode.SetGameInformation;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetGameInformationOperationRequest(DashboardModels.SetGameInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetMasterGameSettingsOperationRequest : CustomOperationRequest<DashboardModels.SetMasterGameSettingsRequestData>
		{
			protected override int operationCode => OperationCode.SetMasterGameSettings;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetMasterGameSettingsOperationRequest(DashboardModels.SetMasterGameSettingsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetPasswordAdminAccountOperationRequest : CustomOperationRequest<DashboardModels.SetPasswordAdminAccountRequestData>
		{
			protected override int operationCode => OperationCode.SetPasswordAdminAccount;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetPasswordAdminAccountOperationRequest(DashboardModels.SetPasswordAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetSecretInfoInformationOperationRequest : CustomOperationRequest<DashboardModels.SetSecretInfoInformationRequestData>
		{
			protected override int operationCode => OperationCode.SetSecretInfoInformation;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetSecretInfoInformationOperationRequest(DashboardModels.SetSecretInfoInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class SetSecretKeyAdminAccountOperationRequest : CustomOperationRequest<DashboardModels.SetSecretKeyAdminAccountRequestData>
		{
			protected override int operationCode => OperationCode.SetSecretKeyAdminAccount;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Dashboard;
			protected override RequestRole requestRole => RequestRole.Client;

			public SetSecretKeyAdminAccountOperationRequest(DashboardModels.SetSecretKeyAdminAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


	}

}
