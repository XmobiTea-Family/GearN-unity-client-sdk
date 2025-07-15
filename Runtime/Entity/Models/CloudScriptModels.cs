namespace XmobiTea.GN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;

    public partial class CloudScriptModels
    {
        public class AddFunctionRequestData
        {
            [StringDataMember(code = GNParameterCode.Script, minLength = 0, maxLength = int.MaxValue, mustNonNull = true)]
            public string script;

            [BooleanDataMember(code = GNParameterCode.CanExecute)]
            public string canExecute;

            [BooleanDataMember(code = GNParameterCode.IsLive)]
            public string isLive;

        }

        public class ServerAddFunctionRequestData : AddFunctionRequestData
        {
        }

        public class AdminAddFunctionRequestData : ServerAddFunctionRequestData
        {
        }

        public class EditFunctionRequestData
        {
            [StringDataMember(code = GNParameterCode.Version, minLength = 7, maxLength = 7, mustNonNull = true)]
            public string version;

            [BooleanDataMember(code = GNParameterCode.CanExecute)]
            public string canExecute;

            [BooleanDataMember(code = GNParameterCode.IsLive)]
            public string isLive;

        }

        public class ServerEditFunctionRequestData : EditFunctionRequestData
        {
        }

        public class AdminEditFunctionRequestData : ServerEditFunctionRequestData
        {
        }

        public class ExecuteFunctionRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = GNParameterCode.FunctionName, minLength = 3, maxLength = 30, mustNonNull = true)]
            public string functionName;

            [DataMember(code = GNParameterCode.FunctionParameters)]
            public object functionParameters;

            [StringDataMember(code = GNParameterCode.Version, minLength = 7, maxLength = 7, isOptional = true)]
            public string? version;

        }

        public class ServerExecuteFunctionRequestData : ExecuteFunctionRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminExecuteFunctionRequestData : ServerExecuteFunctionRequestData
        {
        }

        public class GetFunctionRequestData
        {
            [StringDataMember(code = GNParameterCode.Version, minLength = 7, maxLength = 7, mustNonNull = true)]
            public string version;

        }

        public class ServerGetFunctionRequestData : GetFunctionRequestData
        {
        }

        public class AdminGetFunctionRequestData : ServerGetFunctionRequestData
        {
        }

        public class GetFunctionsRequestData
        {

        }

        public class ServerGetFunctionsRequestData : GetFunctionsRequestData
        {
        }

        public class AdminGetFunctionsRequestData : ServerGetFunctionsRequestData
        {
        }

        public class AddFunctionResponseData
        {
            [StringDataMember(code = GNParameterCode.Version)]
            public string version;

            [StringDataMember(code = GNParameterCode.Message)]
            public string errorMessage;

        }

        public class EditFunctionResponseData
        {
            [StringDataMember(code = GNParameterCode.Message)]
            public string errorMessage;

        }

        public class ExecuteFunctionResponseData
        {
            [NumberDataMember(code = GNParameterCode.Status)]
            public int status;

            [NumberDataMember(code = GNParameterCode.ExecutionTimeInMs)]
            public float executionTimeInMs;

            [NumberDataMember(code = GNParameterCode.MemoryUsedInBytes)]
            public float memoryUsedInBytes;

            [DataMember(code = GNParameterCode.FunctionResult)]
            public object functionResult;

            [StringDataMember(code = GNParameterCode.Message)]
            public string errorMessage;

        }

        public class GetFunctionResponseData
        {
            [StringDataMember(code = GNParameterCode.Script)]
            public string script;

            [BooleanDataMember(code = GNParameterCode.CanExecute)]
            public bool canExecute;

            [BooleanDataMember(code = GNParameterCode.IsLive)]
            public bool isLive;

            [NumberDataMember(code = GNParameterCode.TsCreate)]
            public long tsCreate;

            [GNArrayDataMember(code = GNParameterCode.FunctionLogs, elementCls = typeof(string))]
            public List<string> functionLogs;

        }

        public class FunctionResponseData
        {
            [StringDataMember(code = GNParameterCode.Version)]
            public string version;

            [BooleanDataMember(code = GNParameterCode.CanExecute)]
            public bool canExecute;

        }

        public class GetFunctionsResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(FunctionResponseData))]
            public List<FunctionResponseData> results;

            [StringDataMember(code = GNParameterCode.LatestVersion)]
            public string latestVersion;

            [StringDataMember(code = GNParameterCode.LiveLatestVersion)]
            public string liveLatestVersion;

        }

    }

}
