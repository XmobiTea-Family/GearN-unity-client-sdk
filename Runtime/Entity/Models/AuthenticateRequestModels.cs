namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    /// <summary>
    /// Defines typed request wrappers for authenticate operations.
    /// </summary>
    public class AuthenticateRequestModels
    {
        /// <summary>
        /// Builds the login by account operation request.
        /// </summary>
        public class LoginByAccountOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.LoginByAccountRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LoginByAccount;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LoginByAccountOperationRequest class.
            /// </summary>
            public LoginByAccountOperationRequest(AuthenticateModels.LoginByAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the login by android device ID operation request.
        /// </summary>
        public class LoginByAndroidDeviceIdOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.LoginByAndroidDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LoginByAndroidDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LoginByAndroidDeviceIdOperationRequest class.
            /// </summary>
            public LoginByAndroidDeviceIdOperationRequest(AuthenticateModels.LoginByAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the login by apple operation request.
        /// </summary>
        public class LoginByAppleOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.LoginByAppleRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LoginByApple;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LoginByAppleOperationRequest class.
            /// </summary>
            public LoginByAppleOperationRequest(AuthenticateModels.LoginByAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the login by custom device ID operation request.
        /// </summary>
        public class LoginByCustomDeviceIdOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.LoginByCustomDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LoginByCustomDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LoginByCustomDeviceIdOperationRequest class.
            /// </summary>
            public LoginByCustomDeviceIdOperationRequest(AuthenticateModels.LoginByCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the login by custom ID operation request.
        /// </summary>
        public class LoginByCustomIdOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.LoginByCustomIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LoginByCustomId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LoginByCustomIdOperationRequest class.
            /// </summary>
            public LoginByCustomIdOperationRequest(AuthenticateModels.LoginByCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the login by editor device ID operation request.
        /// </summary>
        public class LoginByEditorDeviceIdOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.LoginByEditorDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LoginByEditorDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LoginByEditorDeviceIdOperationRequest class.
            /// </summary>
            public LoginByEditorDeviceIdOperationRequest(AuthenticateModels.LoginByEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the login by facebook operation request.
        /// </summary>
        public class LoginByFacebookOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.LoginByFacebookRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LoginByFacebook;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LoginByFacebookOperationRequest class.
            /// </summary>
            public LoginByFacebookOperationRequest(AuthenticateModels.LoginByFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the login by generic service operation request.
        /// </summary>
        public class LoginByGenericServiceOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.LoginByGenericServiceRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LoginByGenericService;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LoginByGenericServiceOperationRequest class.
            /// </summary>
            public LoginByGenericServiceOperationRequest(AuthenticateModels.LoginByGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the login by google operation request.
        /// </summary>
        public class LoginByGoogleOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.LoginByGoogleRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LoginByGoogle;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LoginByGoogleOperationRequest class.
            /// </summary>
            public LoginByGoogleOperationRequest(AuthenticateModels.LoginByGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the login by google play game service operation request.
        /// </summary>
        public class LoginByGooglePlayGameServiceOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.LoginByGooglePlayGameServiceRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LoginByGooglePlayGameService;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LoginByGooglePlayGameServiceOperationRequest class.
            /// </summary>
            public LoginByGooglePlayGameServiceOperationRequest(AuthenticateModels.LoginByGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the login by game center operation request.
        /// </summary>
        public class LoginByGameCenterOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.LoginByGameCenterRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LoginByGameCenter;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LoginByGameCenterOperationRequest class.
            /// </summary>
            public LoginByGameCenterOperationRequest(AuthenticateModels.LoginByGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the login by iOS device ID operation request.
        /// </summary>
        public class LoginByiOSDeviceIdOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.LoginByiOSDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LoginByiOSDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LoginByiOSDeviceIdOperationRequest class.
            /// </summary>
            public LoginByiOSDeviceIdOperationRequest(AuthenticateModels.LoginByiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the login by linux device ID operation request.
        /// </summary>
        public class LoginByLinuxDeviceIdOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.LoginByLinuxDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LoginByLinuxDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LoginByLinuxDeviceIdOperationRequest class.
            /// </summary>
            public LoginByLinuxDeviceIdOperationRequest(AuthenticateModels.LoginByLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the login by macos device ID operation request.
        /// </summary>
        public class LoginByMacOSDeviceIdOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.LoginByMacOSDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LoginByMacOSDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LoginByMacOSDeviceIdOperationRequest class.
            /// </summary>
            public LoginByMacOSDeviceIdOperationRequest(AuthenticateModels.LoginByMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the login by windows device ID operation request.
        /// </summary>
        public class LoginByWindowsDeviceIdOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.LoginByWindowsDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LoginByWindowsDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LoginByWindowsDeviceIdOperationRequest class.
            /// </summary>
            public LoginByWindowsDeviceIdOperationRequest(AuthenticateModels.LoginByWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the login by windows phone device ID operation request.
        /// </summary>
        public class LoginByWindowsPhoneDeviceIdOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.LoginByWindowsPhoneDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LoginByWindowsPhoneDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LoginByWindowsPhoneDeviceIdOperationRequest class.
            /// </summary>
            public LoginByWindowsPhoneDeviceIdOperationRequest(AuthenticateModels.LoginByWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the register account operation request.
        /// </summary>
        public class RegisterAccountOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.RegisterAccountRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RegisterAccount;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RegisterAccountOperationRequest class.
            /// </summary>
            public RegisterAccountOperationRequest(AuthenticateModels.RegisterAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the refresh auth token operation request.
        /// </summary>
        public class RefreshAuthTokenOperationRequest : CustomOperationRequestAbstract<AuthenticateModels.RefreshAuthTokenRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RefreshAuthToken;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Authenticate;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RefreshAuthTokenOperationRequest class.
            /// </summary>
            public RefreshAuthTokenOperationRequest(AuthenticateModels.RefreshAuthTokenRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


    }


}