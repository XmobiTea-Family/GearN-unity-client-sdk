namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class RegisterAccountOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.RegisterAccount;

        protected override bool reliable => true;

        public RegisterAccountOperationRequest(string username, string password, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            parameters = new GNHashtable.Builder()
                .Add(LoginParameterCode.Username, username)
                .Add(LoginParameterCode.Password, password)
                .Build();
        }
    }
}
