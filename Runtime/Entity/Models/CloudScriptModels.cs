namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Constant;

    public partial class CloudScriptModels
    {
        public class AddFunctionRequestData
        {
            [StringDataMember(code = ParameterCode.Script, minLength = 0, maxLength = int.MaxValue, mustNonNull = true)]
            public string script;

            [BooleanDataMember(code = ParameterCode.CanExecute)]
            public string canExecute;

            [BooleanDataMember(code = ParameterCode.IsLive)]
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
            [StringDataMember(code = ParameterCode.Version, minLength = 7, maxLength = 7, mustNonNull = true)]
            public string version;

            [BooleanDataMember(code = ParameterCode.CanExecute)]
            public string canExecute;

            [BooleanDataMember(code = ParameterCode.IsLive)]
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
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, isOptional = true)]
            public string? userId;

            [StringDataMember(code = ParameterCode.FunctionName, minLength = 3, maxLength = 30, mustNonNull = true)]
            public string functionName;

            [DataMember(code = ParameterCode.FunctionParameters)]
            public object functionParameters;

            [StringDataMember(code = ParameterCode.Version, minLength = 7, maxLength = 7, isOptional = true)]
            public string? version;

        }

        public class ServerExecuteFunctionRequestData : ExecuteFunctionRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public new string userId;

        }

        public class AdminExecuteFunctionRequestData : ServerExecuteFunctionRequestData
        {
        }

        public class GetFunctionRequestData
        {
            [StringDataMember(code = ParameterCode.Version, minLength = 7, maxLength = 7, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.Version)]
            public string version;

            [StringDataMember(code = ParameterCode.ErrorMessage)]
            public string errorMessage;

        }

        public class EditFunctionResponseData
        {
            [StringDataMember(code = ParameterCode.ErrorMessage)]
            public string errorMessage;

        }

        public class ExecuteFunctionResponseData
        {
            [NumberDataMember(code = ParameterCode.Status)]
            public int status;

            [NumberDataMember(code = ParameterCode.ExecutionTimeInMs)]
            public float executionTimeInMs;

            [NumberDataMember(code = ParameterCode.MemoryUsedInBytes)]
            public float memoryUsedInBytes;

            [DataMember(code = ParameterCode.FunctionResult)]
            public object functionResult;

            [StringDataMember(code = ParameterCode.ErrorMessage)]
            public string errorMessage;

        }

        public class GetFunctionResponseData
        {
            [StringDataMember(code = ParameterCode.Script)]
            public string script;

            [BooleanDataMember(code = ParameterCode.CanExecute)]
            public bool canExecute;

            [BooleanDataMember(code = ParameterCode.IsLive)]
            public bool isLive;

            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            [GNArrayDataMember(code = ParameterCode.FunctionLogs, elementCls = typeof(string))]
            public List<string> functionLogs;

        }

        public class FunctionResponseData
        {
            [StringDataMember(code = ParameterCode.Version)]
            public string version;

            [BooleanDataMember(code = ParameterCode.CanExecute)]
            public bool canExecute;

        }

        public class GetFunctionsResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(FunctionResponseData))]
            public List<FunctionResponseData> results;

            [StringDataMember(code = ParameterCode.LatestVersion)]
            public string latestVersion;

            [StringDataMember(code = ParameterCode.LiveLatestVersion)]
            public string liveLatestVersion;

        }

    }

}
