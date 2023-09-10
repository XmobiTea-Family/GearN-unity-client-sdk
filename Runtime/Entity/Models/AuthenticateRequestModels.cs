namespace XmobiTea.GN.Entity.Models
{
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity.Request;

	public class AuthenticateRequestModels
	{
		public class LoginByAccountOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByAccountRequestData>
		{
			protected override int operationCode => OperationCode.LoginByAccount;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Authenticate;
			protected override RequestRole requestRole => RequestRole.Client;

			public LoginByAccountOperationRequest(AuthenticateModels.LoginByAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LoginByAndroidDeviceIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByAndroidDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.LoginByAndroidDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Authenticate;
			protected override RequestRole requestRole => RequestRole.Client;

			public LoginByAndroidDeviceIdOperationRequest(AuthenticateModels.LoginByAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LoginByAppleOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByAppleRequestData>
		{
			protected override int operationCode => OperationCode.LoginByApple;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Authenticate;
			protected override RequestRole requestRole => RequestRole.Client;

			public LoginByAppleOperationRequest(AuthenticateModels.LoginByAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LoginByCustomDeviceIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByCustomDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.LoginByCustomDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Authenticate;
			protected override RequestRole requestRole => RequestRole.Client;

			public LoginByCustomDeviceIdOperationRequest(AuthenticateModels.LoginByCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LoginByCustomIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByCustomIdRequestData>
		{
			protected override int operationCode => OperationCode.LoginByCustomId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Authenticate;
			protected override RequestRole requestRole => RequestRole.Client;

			public LoginByCustomIdOperationRequest(AuthenticateModels.LoginByCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LoginByEditorDeviceIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByEditorDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.LoginByEditorDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Authenticate;
			protected override RequestRole requestRole => RequestRole.Client;

			public LoginByEditorDeviceIdOperationRequest(AuthenticateModels.LoginByEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LoginByFacebookOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByFacebookRequestData>
		{
			protected override int operationCode => OperationCode.LoginByFacebook;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Authenticate;
			protected override RequestRole requestRole => RequestRole.Client;

			public LoginByFacebookOperationRequest(AuthenticateModels.LoginByFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LoginByGenericServiceOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByGenericServiceRequestData>
		{
			protected override int operationCode => OperationCode.LoginByGenericService;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Authenticate;
			protected override RequestRole requestRole => RequestRole.Client;

			public LoginByGenericServiceOperationRequest(AuthenticateModels.LoginByGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LoginByGoogleOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByGoogleRequestData>
		{
			protected override int operationCode => OperationCode.LoginByGoogle;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Authenticate;
			protected override RequestRole requestRole => RequestRole.Client;

			public LoginByGoogleOperationRequest(AuthenticateModels.LoginByGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LoginByiOSDeviceIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByiOSDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.LoginByiOSDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Authenticate;
			protected override RequestRole requestRole => RequestRole.Client;

			public LoginByiOSDeviceIdOperationRequest(AuthenticateModels.LoginByiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LoginByLinuxDeviceIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByLinuxDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.LoginByLinuxDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Authenticate;
			protected override RequestRole requestRole => RequestRole.Client;

			public LoginByLinuxDeviceIdOperationRequest(AuthenticateModels.LoginByLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LoginByMacOSDeviceIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByMacOSDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.LoginByMacOSDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Authenticate;
			protected override RequestRole requestRole => RequestRole.Client;

			public LoginByMacOSDeviceIdOperationRequest(AuthenticateModels.LoginByMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LoginByWindowsDeviceIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByWindowsDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.LoginByWindowsDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Authenticate;
			protected override RequestRole requestRole => RequestRole.Client;

			public LoginByWindowsDeviceIdOperationRequest(AuthenticateModels.LoginByWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class LoginByWindowsPhoneDeviceIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByWindowsPhoneDeviceIdRequestData>
		{
			protected override int operationCode => OperationCode.LoginByWindowsPhoneDeviceId;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Authenticate;
			protected override RequestRole requestRole => RequestRole.Client;

			public LoginByWindowsPhoneDeviceIdOperationRequest(AuthenticateModels.LoginByWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


		public class RegisterAccountOperationRequest : CustomOperationRequest<AuthenticateModels.RegisterAccountRequestData>
		{
			protected override int operationCode => OperationCode.RegisterAccount;
			protected override bool operationEncrypted => true;
			protected override RequestType requestType => RequestType.Authenticate;
			protected override RequestRole requestRole => RequestRole.Client;

			public RegisterAccountOperationRequest(AuthenticateModels.RegisterAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
		}


	}


}
