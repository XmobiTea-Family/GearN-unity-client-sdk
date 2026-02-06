namespace XmobiTea.GearN
{
    using System.Threading.Tasks;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Models;

    public class CloudScriptApi
    {
        public ServerApi server { get; } = new ServerApi();

        public AdminApi admin { get; } = new AdminApi();

        public void addFunction(CloudScriptModels.AddFunctionRequestData requestData, Action1<CloudScriptResponseModels.AddFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CloudScriptRequestModels.AddFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CloudScriptResponseModels.AddFunctionOperationResponse> addFunctionAsync(CloudScriptModels.AddFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.AddFunctionOperationRequest, CloudScriptResponseModels.AddFunctionOperationResponse>(new CloudScriptRequestModels.AddFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void editFunction(CloudScriptModels.EditFunctionRequestData requestData, Action1<CloudScriptResponseModels.EditFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CloudScriptRequestModels.EditFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CloudScriptResponseModels.EditFunctionOperationResponse> editFunctionAsync(CloudScriptModels.EditFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.EditFunctionOperationRequest, CloudScriptResponseModels.EditFunctionOperationResponse>(new CloudScriptRequestModels.EditFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void executeFunction(CloudScriptModels.ExecuteFunctionRequestData requestData, Action1<CloudScriptResponseModels.ExecuteFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CloudScriptRequestModels.ExecuteFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CloudScriptResponseModels.ExecuteFunctionOperationResponse> executeFunctionAsync(CloudScriptModels.ExecuteFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.ExecuteFunctionOperationRequest, CloudScriptResponseModels.ExecuteFunctionOperationResponse>(new CloudScriptRequestModels.ExecuteFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getFuntionId(CloudScriptModels.GetFunctionRequestData requestData, Action1<CloudScriptResponseModels.GetFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CloudScriptRequestModels.GetFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CloudScriptResponseModels.GetFunctionOperationResponse> getFuntionAsync(CloudScriptModels.GetFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.GetFunctionOperationRequest, CloudScriptResponseModels.GetFunctionOperationResponse>(new CloudScriptRequestModels.GetFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getFunctions(CloudScriptModels.GetFunctionsRequestData requestData, Action1<CloudScriptResponseModels.GetFunctionsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new CloudScriptRequestModels.GetFunctionsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<CloudScriptResponseModels.GetFunctionsOperationResponse> getFunctionsAsync(CloudScriptModels.GetFunctionsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.GetFunctionsOperationRequest, CloudScriptResponseModels.GetFunctionsOperationResponse>(new CloudScriptRequestModels.GetFunctionsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public class ServerApi
        {
            public void addFunction(CloudScriptModels.ServerAddFunctionRequestData requestData, Action1<CloudScriptResponseModels.AddFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.ServerAddFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CloudScriptResponseModels.AddFunctionOperationResponse> addFunctionAsync(CloudScriptModels.ServerAddFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.ServerAddFunctionOperationRequest, CloudScriptResponseModels.AddFunctionOperationResponse>(new CloudScriptRequestModels.ServerAddFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void editFunction(CloudScriptModels.ServerEditFunctionRequestData requestData, Action1<CloudScriptResponseModels.EditFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.ServerEditFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CloudScriptResponseModels.EditFunctionOperationResponse> editFunctionAsync(CloudScriptModels.ServerEditFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.ServerEditFunctionOperationRequest, CloudScriptResponseModels.EditFunctionOperationResponse>(new CloudScriptRequestModels.ServerEditFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void executeFunction(CloudScriptModels.ServerExecuteFunctionRequestData requestData, Action1<CloudScriptResponseModels.ExecuteFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.ServerExecuteFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CloudScriptResponseModels.ExecuteFunctionOperationResponse> executeFunctionAsync(CloudScriptModels.ServerExecuteFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.ServerExecuteFunctionOperationRequest, CloudScriptResponseModels.ExecuteFunctionOperationResponse>(new CloudScriptRequestModels.ServerExecuteFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getFuntionId(CloudScriptModels.ServerGetFunctionRequestData requestData, Action1<CloudScriptResponseModels.GetFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.ServerGetFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CloudScriptResponseModels.GetFunctionOperationResponse> getFuntionAsync(CloudScriptModels.ServerGetFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.ServerGetFunctionOperationRequest, CloudScriptResponseModels.GetFunctionOperationResponse>(new CloudScriptRequestModels.ServerGetFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getFunctions(CloudScriptModels.ServerGetFunctionsRequestData requestData, Action1<CloudScriptResponseModels.GetFunctionsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.ServerGetFunctionsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CloudScriptResponseModels.GetFunctionsOperationResponse> getFunctionsAsync(CloudScriptModels.ServerGetFunctionsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.ServerGetFunctionsOperationRequest, CloudScriptResponseModels.GetFunctionsOperationResponse>(new CloudScriptRequestModels.ServerGetFunctionsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

        public class AdminApi
        {
            public void addFunction(CloudScriptModels.AdminAddFunctionRequestData requestData, Action1<CloudScriptResponseModels.AddFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.AdminAddFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CloudScriptResponseModels.AddFunctionOperationResponse> addFunctionAsync(CloudScriptModels.AdminAddFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.AdminAddFunctionOperationRequest, CloudScriptResponseModels.AddFunctionOperationResponse>(new CloudScriptRequestModels.AdminAddFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void editFunction(CloudScriptModels.AdminEditFunctionRequestData requestData, Action1<CloudScriptResponseModels.EditFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.AdminEditFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CloudScriptResponseModels.EditFunctionOperationResponse> editFunctionAsync(CloudScriptModels.AdminEditFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.AdminEditFunctionOperationRequest, CloudScriptResponseModels.EditFunctionOperationResponse>(new CloudScriptRequestModels.AdminEditFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void executeFunction(CloudScriptModels.AdminExecuteFunctionRequestData requestData, Action1<CloudScriptResponseModels.ExecuteFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.AdminExecuteFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CloudScriptResponseModels.ExecuteFunctionOperationResponse> executeFunctionAsync(CloudScriptModels.AdminExecuteFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.AdminExecuteFunctionOperationRequest, CloudScriptResponseModels.ExecuteFunctionOperationResponse>(new CloudScriptRequestModels.AdminExecuteFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getFuntionId(CloudScriptModels.AdminGetFunctionRequestData requestData, Action1<CloudScriptResponseModels.GetFunctionOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.AdminGetFunctionOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CloudScriptResponseModels.GetFunctionOperationResponse> getFuntionAsync(CloudScriptModels.AdminGetFunctionRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.AdminGetFunctionOperationRequest, CloudScriptResponseModels.GetFunctionOperationResponse>(new CloudScriptRequestModels.AdminGetFunctionOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getFunctions(CloudScriptModels.AdminGetFunctionsRequestData requestData, Action1<CloudScriptResponseModels.GetFunctionsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new CloudScriptRequestModels.AdminGetFunctionsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<CloudScriptResponseModels.GetFunctionsOperationResponse> getFunctionsAsync(CloudScriptModels.AdminGetFunctionsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<CloudScriptRequestModels.AdminGetFunctionsOperationRequest, CloudScriptResponseModels.GetFunctionsOperationResponse>(new CloudScriptRequestModels.AdminGetFunctionsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

    }

    public static partial class GNNetwork
    {

        public static CloudScriptApi cloudScript { get; }
    }

}
