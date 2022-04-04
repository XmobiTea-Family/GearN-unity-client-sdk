namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class RegisterAccountOperationRequest : CustomOperationRequest
    {
        protected override int Code => OperationCode.RegisterAccount;

        protected override bool Reliable => true;

        public RegisterAccountOperationRequest(string username, string password, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            Parameters = new GNHashtable.Builder()
                .Add(LoginParameterCode.Username, username)
                .Add(LoginParameterCode.Password, password)
                .Build();
        }
    }
}
