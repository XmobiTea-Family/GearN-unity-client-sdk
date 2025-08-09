namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    public class AuthenticateRequestModels
    {
        public class LoginByAccountOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByAccountRequestData>
        {
            protected override string operationCode => OperationCode.LoginByAccount;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public LoginByAccountOperationRequest(AuthenticateModels.LoginByAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LoginByAndroidDeviceIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByAndroidDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.LoginByAndroidDeviceId;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public LoginByAndroidDeviceIdOperationRequest(AuthenticateModels.LoginByAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LoginByAppleOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByAppleRequestData>
        {
            protected override string operationCode => OperationCode.LoginByApple;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public LoginByAppleOperationRequest(AuthenticateModels.LoginByAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LoginByCustomDeviceIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByCustomDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.LoginByCustomDeviceId;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public LoginByCustomDeviceIdOperationRequest(AuthenticateModels.LoginByCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LoginByCustomIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByCustomIdRequestData>
        {
            protected override string operationCode => OperationCode.LoginByCustomId;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public LoginByCustomIdOperationRequest(AuthenticateModels.LoginByCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LoginByEditorDeviceIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByEditorDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.LoginByEditorDeviceId;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public LoginByEditorDeviceIdOperationRequest(AuthenticateModels.LoginByEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LoginByFacebookOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByFacebookRequestData>
        {
            protected override string operationCode => OperationCode.LoginByFacebook;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public LoginByFacebookOperationRequest(AuthenticateModels.LoginByFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LoginByGenericServiceOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByGenericServiceRequestData>
        {
            protected override string operationCode => OperationCode.LoginByGenericService;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public LoginByGenericServiceOperationRequest(AuthenticateModels.LoginByGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LoginByGoogleOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByGoogleRequestData>
        {
            protected override string operationCode => OperationCode.LoginByGoogle;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public LoginByGoogleOperationRequest(AuthenticateModels.LoginByGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LoginByGooglePlayGameServiceOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByGooglePlayGameServiceRequestData>
        {
            protected override string operationCode => OperationCode.LoginByGooglePlayGameService;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public LoginByGooglePlayGameServiceOperationRequest(AuthenticateModels.LoginByGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LoginByGameCenterOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByGameCenterRequestData>
        {
            protected override string operationCode => OperationCode.LoginByGameCenter;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public LoginByGameCenterOperationRequest(AuthenticateModels.LoginByGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LoginByiOSDeviceIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByiOSDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.LoginByiOSDeviceId;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public LoginByiOSDeviceIdOperationRequest(AuthenticateModels.LoginByiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LoginByLinuxDeviceIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByLinuxDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.LoginByLinuxDeviceId;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public LoginByLinuxDeviceIdOperationRequest(AuthenticateModels.LoginByLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LoginByMacOSDeviceIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByMacOSDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.LoginByMacOSDeviceId;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public LoginByMacOSDeviceIdOperationRequest(AuthenticateModels.LoginByMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LoginByWindowsDeviceIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByWindowsDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.LoginByWindowsDeviceId;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public LoginByWindowsDeviceIdOperationRequest(AuthenticateModels.LoginByWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class LoginByWindowsPhoneDeviceIdOperationRequest : CustomOperationRequest<AuthenticateModels.LoginByWindowsPhoneDeviceIdRequestData>
        {
            protected override string operationCode => OperationCode.LoginByWindowsPhoneDeviceId;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public LoginByWindowsPhoneDeviceIdOperationRequest(AuthenticateModels.LoginByWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class RegisterAccountOperationRequest : CustomOperationRequest<AuthenticateModels.RegisterAccountRequestData>
        {
            protected override string operationCode => OperationCode.RegisterAccount;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public RegisterAccountOperationRequest(AuthenticateModels.RegisterAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class RefreshAuthTokenOperationRequest : CustomOperationRequest<AuthenticateModels.RefreshAuthTokenRequestData>
        {
            protected override string operationCode => OperationCode.RefreshAuthToken;
            protected override RequestType requestType => RequestType.Authenticate;
            protected override RequestRole role => RequestRole.Client;

            public RefreshAuthTokenOperationRequest(AuthenticateModels.RefreshAuthTokenRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


    }


}
