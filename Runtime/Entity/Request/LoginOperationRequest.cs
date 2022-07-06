namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class AccountLoginOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.Login;

        protected override bool reliable => true;

        public AccountLoginOperationRequest(string username, string password, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            parameters = new GNHashtable.Builder()
                .Add(LoginParameterCode.LoginType, (int)LoginType.Account)
                .Add(LoginParameterCode.Username, username)
                .Add(LoginParameterCode.Password, password)
                .Build();
        }
    }

    public class DeviceLoginOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.Login;

        protected override bool reliable => true;

        public DeviceLoginOperationRequest(string deviceInfo, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            parameters = new GNHashtable.Builder()
                .Add(LoginParameterCode.LoginType, (int)LoginType.Device)
                .Add(LoginParameterCode.DeviceInfo, deviceInfo)
                .Build();
        }
    }

    public class FacebookLoginOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.Login;

        protected override bool reliable => true;

        public FacebookLoginOperationRequest(string facebookToken, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            parameters = new GNHashtable.Builder()
                .Add(LoginParameterCode.LoginType, (int)LoginType.Facebook)
                .Add(LoginParameterCode.FacebookToken, facebookToken)
                .Build();
        }
    }

    public class GoogleLoginOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.Login;

        protected override bool reliable => true;

        public GoogleLoginOperationRequest(string googleToken, int googleLoginType, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            parameters = new GNHashtable.Builder()
                .Add(LoginParameterCode.LoginType, (int)LoginType.Google)
                .Add(LoginParameterCode.GoogleToken, googleToken)
                .Add(LoginParameterCode.GoogleLoginType, googleLoginType)
                .Build();
        }
    }

    public class AppleLoginOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.Login;

        protected override bool reliable => true;

        public AppleLoginOperationRequest(string appleToken, string displayName, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            parameters = new GNHashtable.Builder()
                .Add(LoginParameterCode.LoginType, (int)LoginType.Apple)
                .Add(LoginParameterCode.AppleToken, appleToken)
                .Add(LoginParameterCode.DisplayName, displayName)
                .Build();
        }
    }

    public class UserIdLoginOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.Login;

        protected override bool reliable => true;

        public UserIdLoginOperationRequest(string userId, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            parameters = new GNHashtable.Builder()
                .Add(LoginParameterCode.LoginType, (int)LoginType.UserId)
                .Add(LoginParameterCode.UserId, userId)
                .Build();
        }
    }

    public class PublicAddressLoginOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.Login;

        protected override bool reliable => true;

        public PublicAddressLoginOperationRequest(string signature, string publicAddress, string message, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            parameters = new GNHashtable.Builder()
                .Add(LoginParameterCode.LoginType, (int)LoginType.PublicAddress)
                .Add(LoginParameterCode.Signature, signature)
                .Add(LoginParameterCode.PublicAddress, publicAddress)
                .Add(LoginParameterCode.Message, message)
                .Build();
        }
    }

    public class PublicAddressGetRandomMessageOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.Login;

        protected override bool reliable => true;

        public PublicAddressGetRandomMessageOperationRequest(int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            parameters = new GNHashtable.Builder()
                .Add(LoginParameterCode.LoginType, (int)LoginType.PublicAddress)
                .Build();
        }
    }

    public class CustomIdLoginOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.Login;

        protected override bool reliable => true;

        public CustomIdLoginOperationRequest(string customId, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            parameters = new GNHashtable.Builder()
                .Add(LoginParameterCode.LoginType, (int)LoginType.CustomId)
                .Add(LoginParameterCode.CustomId, customId)
                .Build();
        }
    }
}
