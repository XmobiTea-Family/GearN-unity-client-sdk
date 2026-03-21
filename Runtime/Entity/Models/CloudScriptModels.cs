namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Constant;

    /// <summary>
    /// Defines payload models for cloud script operations.
    /// </summary>
    public partial class CloudScriptModels
    {
        /// <summary>
        /// Represents the request payload for the add function operation.
        /// </summary>
        public class AddFunctionRequestData
        {
            /// <summary>
            /// Stores the script value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Script, minLength = 0, maxLength = int.MaxValue, mustNonNull = true)]
            public string script;

            /// <summary>
            /// Indicates whether can execute.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CanExecute)]
            public string canExecute;

            /// <summary>
            /// Indicates whether is live.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.IsLive)]
            public string isLive;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the add function operation.
        /// </summary>
        public class ServerAddFunctionRequestData : AddFunctionRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the add function operation.
        /// </summary>
        public class AdminAddFunctionRequestData : ServerAddFunctionRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the edit function operation.
        /// </summary>
        public class EditFunctionRequestData
        {
            /// <summary>
            /// Stores the version value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Version, minLength = 7, maxLength = 7, mustNonNull = true)]
            public string version;

            /// <summary>
            /// Indicates whether can execute.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CanExecute)]
            public string canExecute;

            /// <summary>
            /// Indicates whether is live.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.IsLive)]
            public string isLive;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the edit function operation.
        /// </summary>
        public class ServerEditFunctionRequestData : EditFunctionRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the edit function operation.
        /// </summary>
        public class AdminEditFunctionRequestData : ServerEditFunctionRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the execute function operation.
        /// </summary>
        public class ExecuteFunctionRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            /// <summary>
            /// Stores the function name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FunctionName, minLength = 3, maxLength = 30, mustNonNull = true)]
            public string functionName;

            /// <summary>
            /// Stores the function parameters value.
            /// </summary>
            [DataMember(code = ParameterCode.FunctionParameters)]
            public object functionParameters;

            /// <summary>
            /// Stores the version value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Version, minLength = 7, maxLength = 7, isOptional = true)]
            public string? version;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the execute function operation.
        /// </summary>
        public class ServerExecuteFunctionRequestData : ExecuteFunctionRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the execute function operation.
        /// </summary>
        public class AdminExecuteFunctionRequestData : ServerExecuteFunctionRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get function operation.
        /// </summary>
        public class GetFunctionRequestData
        {
            /// <summary>
            /// Stores the version value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Version, minLength = 7, maxLength = 7, mustNonNull = true)]
            public string version;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get function operation.
        /// </summary>
        public class ServerGetFunctionRequestData : GetFunctionRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get function operation.
        /// </summary>
        public class AdminGetFunctionRequestData : ServerGetFunctionRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get functions operation.
        /// </summary>
        public class GetFunctionsRequestData
        {

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get functions operation.
        /// </summary>
        public class ServerGetFunctionsRequestData : GetFunctionsRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get functions operation.
        /// </summary>
        public class AdminGetFunctionsRequestData : ServerGetFunctionsRequestData
        {
        }

        /// <summary>
        /// Represents the response payload for the add function operation.
        /// </summary>
        public class AddFunctionResponseData
        {
            /// <summary>
            /// Stores the version value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Version)]
            public string version;

            /// <summary>
            /// Stores the error message value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ErrorMessage)]
            public string errorMessage;

        }

        /// <summary>
        /// Represents the response payload for the edit function operation.
        /// </summary>
        public class EditFunctionResponseData
        {
            /// <summary>
            /// Stores the error message value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ErrorMessage)]
            public string errorMessage;

        }

        /// <summary>
        /// Represents the response payload for the execute function operation.
        /// </summary>
        public class ExecuteFunctionResponseData
        {
            /// <summary>
            /// Stores the status value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Status)]
            public int status;

            /// <summary>
            /// Stores the execution time in ms value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.ExecutionTimeInMs)]
            public float executionTimeInMs;

            /// <summary>
            /// Stores the memory used in bytes value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.MemoryUsedInBytes)]
            public float memoryUsedInBytes;

            /// <summary>
            /// Stores the function result value.
            /// </summary>
            [DataMember(code = ParameterCode.FunctionResult)]
            public object functionResult;

            /// <summary>
            /// Stores the error message value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ErrorMessage)]
            public string errorMessage;

        }

        /// <summary>
        /// Represents the response payload for the get function operation.
        /// </summary>
        public class GetFunctionResponseData
        {
            /// <summary>
            /// Stores the script value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Script)]
            public string script;

            /// <summary>
            /// Indicates whether can execute.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CanExecute)]
            public bool canExecute;

            /// <summary>
            /// Indicates whether is live.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.IsLive)]
            public bool isLive;

            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            /// <summary>
            /// Stores the function logs value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.FunctionLogs, elementCls = typeof(string))]
            public List<string> functionLogs;

        }

        /// <summary>
        /// Represents the response payload for the function operation.
        /// </summary>
        public class FunctionResponseData
        {
            /// <summary>
            /// Stores the version value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Version)]
            public string version;

            /// <summary>
            /// Indicates whether can execute.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CanExecute)]
            public bool canExecute;

        }

        /// <summary>
        /// Represents the response payload for the get functions operation.
        /// </summary>
        public class GetFunctionsResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(FunctionResponseData))]
            public List<FunctionResponseData> results;

            /// <summary>
            /// Stores the latest version value.
            /// </summary>
            [StringDataMember(code = ParameterCode.LatestVersion)]
            public string latestVersion;

            /// <summary>
            /// Stores the live latest version value.
            /// </summary>
            [StringDataMember(code = ParameterCode.LiveLatestVersion)]
            public string liveLatestVersion;

        }

    }

}