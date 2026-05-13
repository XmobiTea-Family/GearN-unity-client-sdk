namespace XmobiTea.GearN
{
    using System.Threading.Tasks;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Models;

    /// <summary>
    /// Provides cloud script operations exposed by the GearN client SDK.
    /// </summary>
    public class CloudScriptApi
    {
        /// <summary>
        /// Gets the server-scoped API entry point.
        /// </summary>
        public ServerApi server { get; } = new ServerApi();

        /// <summary>
        /// Gets the admin-scoped API entry point.
        /// </summary>
        public AdminApi admin { get; } = new AdminApi();

        /// <summary>
        /// Adds function.
        /// </summary>
        public void addFunction(CloudScriptModels.AddFunctionRequestData requestData, Action1<CloudScriptResponseModels.AddFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CloudScriptRequestModels.AddFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Adds function asynchronously.
        /// </summary>
        public Task<CloudScriptResponseModels.AddFunctionOperationResponse> addFunctionAsync(CloudScriptModels.AddFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.AddFunctionOperationRequest, CloudScriptResponseModels.AddFunctionOperationResponse>(new CloudScriptRequestModels.AddFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Executes the edit function operation.
        /// </summary>
        public void editFunction(CloudScriptModels.EditFunctionRequestData requestData, Action1<CloudScriptResponseModels.EditFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CloudScriptRequestModels.EditFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Executes the edit function operation asynchronously.
        /// </summary>
        public Task<CloudScriptResponseModels.EditFunctionOperationResponse> editFunctionAsync(CloudScriptModels.EditFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.EditFunctionOperationRequest, CloudScriptResponseModels.EditFunctionOperationResponse>(new CloudScriptRequestModels.EditFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Executes function.
        /// </summary>
        public void executeFunction(CloudScriptModels.ExecuteFunctionRequestData requestData, Action1<CloudScriptResponseModels.ExecuteFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CloudScriptRequestModels.ExecuteFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Executes function asynchronously.
        /// </summary>
        public Task<CloudScriptResponseModels.ExecuteFunctionOperationResponse> executeFunctionAsync(CloudScriptModels.ExecuteFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.ExecuteFunctionOperationRequest, CloudScriptResponseModels.ExecuteFunctionOperationResponse>(new CloudScriptRequestModels.ExecuteFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Gets function information.
        /// </summary>
        public void getFunction(CloudScriptModels.GetFunctionRequestData requestData, Action1<CloudScriptResponseModels.GetFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CloudScriptRequestModels.GetFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Gets function information asynchronously.
        /// </summary>
        public Task<CloudScriptResponseModels.GetFunctionOperationResponse> getFunctionAsync(CloudScriptModels.GetFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.GetFunctionOperationRequest, CloudScriptResponseModels.GetFunctionOperationResponse>(new CloudScriptRequestModels.GetFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Gets functions.
        /// </summary>
        public void getFunctions(CloudScriptModels.GetFunctionsRequestData requestData, Action1<CloudScriptResponseModels.GetFunctionsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CloudScriptRequestModels.GetFunctionsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Gets functions asynchronously.
        /// </summary>
        public Task<CloudScriptResponseModels.GetFunctionsOperationResponse> getFunctionsAsync(CloudScriptModels.GetFunctionsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.GetFunctionsOperationRequest, CloudScriptResponseModels.GetFunctionsOperationResponse>(new CloudScriptRequestModels.GetFunctionsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Provides server-scoped operations for the parent API.
        /// </summary>
        public class ServerApi
        {
            /// <summary>
            /// Adds function.
            /// </summary>
            public void addFunction(CloudScriptModels.ServerAddFunctionRequestData requestData, Action1<CloudScriptResponseModels.AddFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.ServerAddFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Adds function asynchronously.
            /// </summary>
            public Task<CloudScriptResponseModels.AddFunctionOperationResponse> addFunctionAsync(CloudScriptModels.ServerAddFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.ServerAddFunctionOperationRequest, CloudScriptResponseModels.AddFunctionOperationResponse>(new CloudScriptRequestModels.ServerAddFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Executes the edit function operation.
            /// </summary>
            public void editFunction(CloudScriptModels.ServerEditFunctionRequestData requestData, Action1<CloudScriptResponseModels.EditFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.ServerEditFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Executes the edit function operation asynchronously.
            /// </summary>
            public Task<CloudScriptResponseModels.EditFunctionOperationResponse> editFunctionAsync(CloudScriptModels.ServerEditFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.ServerEditFunctionOperationRequest, CloudScriptResponseModels.EditFunctionOperationResponse>(new CloudScriptRequestModels.ServerEditFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Executes function.
            /// </summary>
            public void executeFunction(CloudScriptModels.ServerExecuteFunctionRequestData requestData, Action1<CloudScriptResponseModels.ExecuteFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.ServerExecuteFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Executes function asynchronously.
            /// </summary>
            public Task<CloudScriptResponseModels.ExecuteFunctionOperationResponse> executeFunctionAsync(CloudScriptModels.ServerExecuteFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.ServerExecuteFunctionOperationRequest, CloudScriptResponseModels.ExecuteFunctionOperationResponse>(new CloudScriptRequestModels.ServerExecuteFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Gets function information.
            /// </summary>
            public void getFunction(CloudScriptModels.ServerGetFunctionRequestData requestData, Action1<CloudScriptResponseModels.GetFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.ServerGetFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Gets function information asynchronously.
            /// </summary>
            public Task<CloudScriptResponseModels.GetFunctionOperationResponse> getFunctionAsync(CloudScriptModels.ServerGetFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.ServerGetFunctionOperationRequest, CloudScriptResponseModels.GetFunctionOperationResponse>(new CloudScriptRequestModels.ServerGetFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Gets functions.
            /// </summary>
            public void getFunctions(CloudScriptModels.ServerGetFunctionsRequestData requestData, Action1<CloudScriptResponseModels.GetFunctionsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.ServerGetFunctionsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Gets functions asynchronously.
            /// </summary>
            public Task<CloudScriptResponseModels.GetFunctionsOperationResponse> getFunctionsAsync(CloudScriptModels.ServerGetFunctionsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.ServerGetFunctionsOperationRequest, CloudScriptResponseModels.GetFunctionsOperationResponse>(new CloudScriptRequestModels.ServerGetFunctionsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

        /// <summary>
        /// Provides admin-scoped operations for the parent API.
        /// </summary>
        public class AdminApi
        {
            /// <summary>
            /// Adds function.
            /// </summary>
            public void addFunction(CloudScriptModels.AdminAddFunctionRequestData requestData, Action1<CloudScriptResponseModels.AddFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.AdminAddFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Adds function asynchronously.
            /// </summary>
            public Task<CloudScriptResponseModels.AddFunctionOperationResponse> addFunctionAsync(CloudScriptModels.AdminAddFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.AdminAddFunctionOperationRequest, CloudScriptResponseModels.AddFunctionOperationResponse>(new CloudScriptRequestModels.AdminAddFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Executes the edit function operation.
            /// </summary>
            public void editFunction(CloudScriptModels.AdminEditFunctionRequestData requestData, Action1<CloudScriptResponseModels.EditFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.AdminEditFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Executes the edit function operation asynchronously.
            /// </summary>
            public Task<CloudScriptResponseModels.EditFunctionOperationResponse> editFunctionAsync(CloudScriptModels.AdminEditFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.AdminEditFunctionOperationRequest, CloudScriptResponseModels.EditFunctionOperationResponse>(new CloudScriptRequestModels.AdminEditFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Executes function.
            /// </summary>
            public void executeFunction(CloudScriptModels.AdminExecuteFunctionRequestData requestData, Action1<CloudScriptResponseModels.ExecuteFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.AdminExecuteFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Executes function asynchronously.
            /// </summary>
            public Task<CloudScriptResponseModels.ExecuteFunctionOperationResponse> executeFunctionAsync(CloudScriptModels.AdminExecuteFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.AdminExecuteFunctionOperationRequest, CloudScriptResponseModels.ExecuteFunctionOperationResponse>(new CloudScriptRequestModels.AdminExecuteFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Gets function information.
            /// </summary>
            public void getFunction(CloudScriptModels.AdminGetFunctionRequestData requestData, Action1<CloudScriptResponseModels.GetFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.AdminGetFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Gets function information asynchronously.
            /// </summary>
            public Task<CloudScriptResponseModels.GetFunctionOperationResponse> getFunctionAsync(CloudScriptModels.AdminGetFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.AdminGetFunctionOperationRequest, CloudScriptResponseModels.GetFunctionOperationResponse>(new CloudScriptRequestModels.AdminGetFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Gets functions.
            /// </summary>
            public void getFunctions(CloudScriptModels.AdminGetFunctionsRequestData requestData, Action1<CloudScriptResponseModels.GetFunctionsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.AdminGetFunctionsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            /// <summary>
            /// Gets functions asynchronously.
            /// </summary>
            public Task<CloudScriptResponseModels.GetFunctionsOperationResponse> getFunctionsAsync(CloudScriptModels.AdminGetFunctionsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.AdminGetFunctionsOperationRequest, CloudScriptResponseModels.GetFunctionsOperationResponse>(new CloudScriptRequestModels.AdminGetFunctionsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

    }

    /// <summary>
    /// Represents the GN network component.
    /// </summary>
    public static partial class GNNetwork
    {

        /// <summary>
        /// Stores the cloud script value.
        /// </summary>
        public static CloudScriptApi cloudScript { get; }
    }

}