namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class LoginOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.LoginByAccount;

        protected override bool operationEncrypted => true;

        protected override RequestType requestType => RequestType.Authenticate;

        protected override RequestRole requestRole => RequestRole.Client;

        public LoginOperationRequest(int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            
        }

    }

    public class AccountLoginOperationRequest : LoginOperationRequest
    {

        public AccountLoginOperationRequest(string username, string password, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            //this.operationParameters = new GNHashtable.Builder()
            //    .Add(LoginParameterCode.LoginType, (int)LoginType.Account)
            //    .Add(LoginParameterCode.Username, username)
            //    .Add(LoginParameterCode.Password, password)
            //    .Build();
        }

    }

}
