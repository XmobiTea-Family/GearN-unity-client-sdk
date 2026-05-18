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
        public class CreateNewFileUploadInfoOperationResponse : CustomOperationResponseAbstract<ContentModels.FileIdUploadResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get content data operation.
        /// </summary>
        public class GetContentDataOperationResponse : CustomOperationResponseAbstract<ContentModels.GetContentDataResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get file upload info list operation.
        /// </summary>
        public class GetFileUploadInfoListOperationResponse : CustomOperationResponseAbstract<ContentModels.GetFileUploadInfoListResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get file upload info operation.
        /// </summary>
        public class GetFileUploadInfoOperationResponse : CustomOperationResponseAbstract<ContentModels.GetFileUploadInfoResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the remove file upload info operation.
        /// </summary>
        public class RemoveFileUploadInfoOperationResponse : CustomOperationResponseAbstract<ContentModels.EmptyResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the request download file upload info operation.
        /// </summary>
        public class RequestDownloadFileUploadInfoOperationResponse : CustomOperationResponseAbstract<ContentModels.RequestDownloadFileUploadInfoResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the set content data operation.
        /// </summary>
        public class SetContentDataOperationResponse : CustomOperationResponseAbstract<ContentModels.EmptyResponseData>
        {

        }

    }

}