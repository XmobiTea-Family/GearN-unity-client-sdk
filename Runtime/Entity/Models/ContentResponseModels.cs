namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Entity.Response;

    /// <summary>
    /// Defines typed response wrappers for content operations.
    /// </summary>
    public class ContentResponseModels
    {
        /// <summary>
        /// Represents the typed response for the create new file upload info operation.
        /// </summary>
        public class CreateNewFileUploadInfoOperationResponse : CustomOperationResponse<ContentModels.FileIdUploadResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get content data operation.
        /// </summary>
        public class GetContentDataOperationResponse : CustomOperationResponse<ContentModels.GetContentDataResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get file upload info list operation.
        /// </summary>
        public class GetFileUploadInfoListOperationResponse : CustomOperationResponse<ContentModels.GetFileUploadInfoListResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get file upload info operation.
        /// </summary>
        public class GetFileUploadInfoOperationResponse : CustomOperationResponse<ContentModels.GetFileUploadInfoResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the remove file upload info operation.
        /// </summary>
        public class RemoveFileUploadInfoOperationResponse : CustomOperationResponse<ContentModels.EmptyResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the request download file upload info operation.
        /// </summary>
        public class RequestDownloadFileUploadInfoOperationResponse : CustomOperationResponse<ContentModels.RequestDownloadFileUploadInfoResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the set content data operation.
        /// </summary>
        public class SetContentDataOperationResponse : CustomOperationResponse<ContentModels.EmptyResponseData>
        {

        }

    }

}