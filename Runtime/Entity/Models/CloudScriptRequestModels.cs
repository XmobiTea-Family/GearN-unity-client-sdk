namespace XmobiTea.GN.Entity.Models
{
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity.Request;

    public class CloudScriptRequestModels
    {
        public class AddFunctionOperationRequest : CustomOperationRequest<CloudScriptModels.AddFunctionRequestData>
        {
            protected override int operationCode => OperationCode.AddFunction;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CloudScript;
            protected override RequestRole requestRole => RequestRole.Client;

            public AddFunctionOperationRequest(CloudScriptModels.AddFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerAddFunctionOperationRequest : AddFunctionOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerAddFunctionOperationRequest(CloudScriptModels.ServerAddFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminAddFunctionOperationRequest : AddFunctionOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminAddFunctionOperationRequest(CloudScriptModels.AdminAddFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class EditFunctionOperationRequest : CustomOperationRequest<CloudScriptModels.EditFunctionRequestData>
        {
            protected override int operationCode => OperationCode.EditFunction;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CloudScript;
            protected override RequestRole requestRole => RequestRole.Client;

            public EditFunctionOperationRequest(CloudScriptModels.EditFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerEditFunctionOperationRequest : EditFunctionOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerEditFunctionOperationRequest(CloudScriptModels.ServerEditFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminEditFunctionOperationRequest : EditFunctionOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminEditFunctionOperationRequest(CloudScriptModels.AdminEditFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class ExecuteFunctionOperationRequest : CustomOperationRequest<CloudScriptModels.ExecuteFunctionRequestData>
        {
            protected override int operationCode => OperationCode.ExecuteFunction;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CloudScript;
            protected override RequestRole requestRole => RequestRole.Client;

            public ExecuteFunctionOperationRequest(CloudScriptModels.ExecuteFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerExecuteFunctionOperationRequest : ExecuteFunctionOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerExecuteFunctionOperationRequest(CloudScriptModels.ServerExecuteFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminExecuteFunctionOperationRequest : ExecuteFunctionOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminExecuteFunctionOperationRequest(CloudScriptModels.AdminExecuteFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetFunctionOperationRequest : CustomOperationRequest<CloudScriptModels.GetFunctionRequestData>
        {
            protected override int operationCode => OperationCode.GetFunction;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CloudScript;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetFunctionOperationRequest(CloudScriptModels.GetFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetFunctionOperationRequest : GetFunctionOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetFunctionOperationRequest(CloudScriptModels.ServerGetFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetFunctionOperationRequest : GetFunctionOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetFunctionOperationRequest(CloudScriptModels.AdminGetFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetFunctionsOperationRequest : CustomOperationRequest<CloudScriptModels.GetFunctionsRequestData>
        {
            protected override int operationCode => OperationCode.GetFunctions;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.CloudScript;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetFunctionsOperationRequest(CloudScriptModels.GetFunctionsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetFunctionsOperationRequest : GetFunctionsOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetFunctionsOperationRequest(CloudScriptModels.ServerGetFunctionsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetFunctionsOperationRequest : GetFunctionsOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetFunctionsOperationRequest(CloudScriptModels.AdminGetFunctionsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}
