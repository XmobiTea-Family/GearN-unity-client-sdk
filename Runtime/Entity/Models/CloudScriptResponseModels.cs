namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Entity.Response;

    /// <summary>
    /// Defines typed response wrappers for cloud script operations.
    /// </summary>
    public class CloudScriptResponseModels
    {
        /// <summary>
        /// Represents the typed response for the add function operation.
        /// </summary>
        public class AddFunctionOperationResponse : CustomOperationResponse<CloudScriptModels.AddFunctionResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the edit function operation.
        /// </summary>
        public class EditFunctionOperationResponse : CustomOperationResponse<CloudScriptModels.EditFunctionResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the execute function operation.
        /// </summary>
        public class ExecuteFunctionOperationResponse : CustomOperationResponse<CloudScriptModels.ExecuteFunctionResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get function operation.
        /// </summary>
        public class GetFunctionOperationResponse : CustomOperationResponse<CloudScriptModels.GetFunctionResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get functions operation.
        /// </summary>
        public class GetFunctionsOperationResponse : CustomOperationResponse<CloudScriptModels.GetFunctionsResponseData>
        {

        }

    }

}