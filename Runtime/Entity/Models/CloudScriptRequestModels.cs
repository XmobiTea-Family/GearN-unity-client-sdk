namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    /// <summary>
    /// Defines typed request wrappers for cloud script operations.
    /// </summary>
    public class CloudScriptRequestModels
    {
        /// <summary>
        /// Builds the add function operation request.
        /// </summary>
        public class AddFunctionOperationRequest : CustomOperationRequest<CloudScriptModels.AddFunctionRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.AddFunction;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CloudScript;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the AddFunctionOperationRequest class.
            /// </summary>
            public AddFunctionOperationRequest(CloudScriptModels.AddFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped add function operation request.
        /// </summary>
        public class ServerAddFunctionOperationRequest : AddFunctionOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerAddFunctionOperationRequest class.
            /// </summary>
            public ServerAddFunctionOperationRequest(CloudScriptModels.ServerAddFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped add function operation request.
        /// </summary>
        public class AdminAddFunctionOperationRequest : AddFunctionOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminAddFunctionOperationRequest class.
            /// </summary>
            public AdminAddFunctionOperationRequest(CloudScriptModels.AdminAddFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the edit function operation request.
        /// </summary>
        public class EditFunctionOperationRequest : CustomOperationRequest<CloudScriptModels.EditFunctionRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.EditFunction;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CloudScript;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the EditFunctionOperationRequest class.
            /// </summary>
            public EditFunctionOperationRequest(CloudScriptModels.EditFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped edit function operation request.
        /// </summary>
        public class ServerEditFunctionOperationRequest : EditFunctionOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerEditFunctionOperationRequest class.
            /// </summary>
            public ServerEditFunctionOperationRequest(CloudScriptModels.ServerEditFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped edit function operation request.
        /// </summary>
        public class AdminEditFunctionOperationRequest : EditFunctionOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminEditFunctionOperationRequest class.
            /// </summary>
            public AdminEditFunctionOperationRequest(CloudScriptModels.AdminEditFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the execute function operation request.
        /// </summary>
        public class ExecuteFunctionOperationRequest : CustomOperationRequest<CloudScriptModels.ExecuteFunctionRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ExecuteFunction;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CloudScript;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ExecuteFunctionOperationRequest class.
            /// </summary>
            public ExecuteFunctionOperationRequest(CloudScriptModels.ExecuteFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped execute function operation request.
        /// </summary>
        public class ServerExecuteFunctionOperationRequest : ExecuteFunctionOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerExecuteFunctionOperationRequest class.
            /// </summary>
            public ServerExecuteFunctionOperationRequest(CloudScriptModels.ServerExecuteFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped execute function operation request.
        /// </summary>
        public class AdminExecuteFunctionOperationRequest : ExecuteFunctionOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminExecuteFunctionOperationRequest class.
            /// </summary>
            public AdminExecuteFunctionOperationRequest(CloudScriptModels.AdminExecuteFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get function operation request.
        /// </summary>
        public class GetFunctionOperationRequest : CustomOperationRequest<CloudScriptModels.GetFunctionRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetFunction;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CloudScript;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetFunctionOperationRequest class.
            /// </summary>
            public GetFunctionOperationRequest(CloudScriptModels.GetFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get function operation request.
        /// </summary>
        public class ServerGetFunctionOperationRequest : GetFunctionOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetFunctionOperationRequest class.
            /// </summary>
            public ServerGetFunctionOperationRequest(CloudScriptModels.ServerGetFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get function operation request.
        /// </summary>
        public class AdminGetFunctionOperationRequest : GetFunctionOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetFunctionOperationRequest class.
            /// </summary>
            public AdminGetFunctionOperationRequest(CloudScriptModels.AdminGetFunctionRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get functions operation request.
        /// </summary>
        public class GetFunctionsOperationRequest : CustomOperationRequest<CloudScriptModels.GetFunctionsRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetFunctions;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.CloudScript;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetFunctionsOperationRequest class.
            /// </summary>
            public GetFunctionsOperationRequest(CloudScriptModels.GetFunctionsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get functions operation request.
        /// </summary>
        public class ServerGetFunctionsOperationRequest : GetFunctionsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetFunctionsOperationRequest class.
            /// </summary>
            public ServerGetFunctionsOperationRequest(CloudScriptModels.ServerGetFunctionsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get functions operation request.
        /// </summary>
        public class AdminGetFunctionsOperationRequest : GetFunctionsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetFunctionsOperationRequest class.
            /// </summary>
            public AdminGetFunctionsOperationRequest(CloudScriptModels.AdminGetFunctionsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}