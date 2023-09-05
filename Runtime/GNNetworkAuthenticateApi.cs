using System;
using XmobiTea.GN.Common;
using XmobiTea.GN.Constant;
using XmobiTea.GN.Entity;
using XmobiTea.GN.Entity.Request;
using XmobiTea.GN.Helper;
using XmobiTea.GN.Networking;

namespace XmobiTea.GN
{
    public class AuthenticateModel
    {
        public class LoginByAccountOperationRequest : CustomOperationRequest
        {
            protected override int operationCode => OperationCode.LoginByAccount;

            protected override bool operationEncrypted => true;

            protected override RequestType requestType => RequestType.Authenticate;

            protected override RequestRole requestRole => RequestRole.Client;

            [StringDataMember(code = GNParameterCode.Username, isOptional = true, minLength = 5)]
            public string username;

            public LoginByAccountOperationRequest(int timeout) : base(timeout)
            {
            }
        }

        public class LoginByAccountOperationResponse
        {
           
        }
    }

    public static partial class GNNetwork
    {
        public class AuthenticateApi
        {
            public void LoginByAccount(AuthenticateModel.LoginByAccountOperationRequest request, Action<AuthenticateModel.LoginByAccountOperationResponse> response = null, GNHashtable customTag = null)
            {
                
                //peer.SendViaHttp();
            }
        }

        public static AuthenticateApi authenticate { get; } = new AuthenticateApi();
    }

}
