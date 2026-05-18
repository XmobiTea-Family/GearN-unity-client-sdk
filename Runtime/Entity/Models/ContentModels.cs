namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;

    /// <summary>
    /// Defines payload models for content operations.
    /// </summary>
    public partial class ContentModels
    {
        /// <summary>
        /// Represents the request payload for the create new file upload info operation.
        /// </summary>
        public class CreateNewFileUploadInfoRequestData
        {
            /// <summary>
            /// Stores the file name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FileName, mustNonNull = true, minLength = 5, maxLength = 50)]
            public string fileName;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the create new file upload info operation.
        /// </summary>
        public class ServerCreateNewFileUploadInfoRequestData : CreateNewFileUploadInfoRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the create new file upload info operation.
        /// </summary>
        public class AdminCreateNewFileUploadInfoRequestData : ServerCreateNewFileUploadInfoRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get content data operation.
        /// </summary>
        public class GetContentDataRequestData
        {
            /// <summary>
            /// Stores the keys value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Keys, elementCls = typeof(string), isOptional = true)]
            public List<string>? keys;

            /// <summary>
            /// Stores the label value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Label, minLength = 2, maxLength = 32, isOptional = true, defaultValue = "")]
            public string? label;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get content data operation.
        /// </summary>
        public class ServerGetContentDataRequestData : GetContentDataRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get content data operation.
        /// </summary>
        public class AdminGetContentDataRequestData : ServerGetContentDataRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get file upload info list operation.
        /// </summary>
        public class GetFileUploadInfoListRequestData
        {
            /// <summary>
            /// Stores the skip value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            /// <summary>
            /// Stores the limit value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 1, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get file upload info list operation.
        /// </summary>
        public class ServerGetFileUploadInfoListRequestData : GetFileUploadInfoListRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get file upload info list operation.
        /// </summary>
        public class AdminGetFileUploadInfoListRequestData : ServerGetFileUploadInfoListRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get file upload info operation.
        /// </summary>
        public class GetFileUploadInfoRequestData
        {
            /// <summary>
            /// Stores the file ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FileId, mustNonNull = true, minLength = 15, maxLength = 15)]
            public string fileId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get file upload info operation.
        /// </summary>
        public class ServerGetFileUploadInfoRequestData : GetFileUploadInfoRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get file upload info operation.
        /// </summary>
        public class AdminGetFileUploadInfoRequestData : ServerGetFileUploadInfoRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the remove file upload info operation.
        /// </summary>
        public class RemoveFileUploadInfoRequestData
        {
            /// <summary>
            /// Stores the file ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FileId, mustNonNull = true, minLength = 15, maxLength = 15)]
            public string fileId;

            /// <summary>
            /// Stores the reason value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Reason, isOptional = true, defaultValue = "")]
            public string? reason;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the remove file upload info operation.
        /// </summary>
        public class ServerRemoveFileUploadInfoRequestData : RemoveFileUploadInfoRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the remove file upload info operation.
        /// </summary>
        public class AdminRemoveFileUploadInfoRequestData : ServerRemoveFileUploadInfoRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the request download file upload info operation.
        /// </summary>
        public class RequestDownloadFileUploadInfoRequestData
        {
            /// <summary>
            /// Stores the file ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FileId, mustNonNull = true, minLength = 15, maxLength = 15)]
            public string fileId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the request download file upload info operation.
        /// </summary>
        public class ServerRequestDownloadFileUploadInfoRequestData : RequestDownloadFileUploadInfoRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the request download file upload info operation.
        /// </summary>
        public class AdminRequestDownloadFileUploadInfoRequestData : ServerRequestDownloadFileUploadInfoRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set content data operation.
        /// </summary>
        public class SetContentDataRequestData
        {
            /// <summary>
            /// Stores the configs value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Configs, elementCls = typeof(ContentDataParam), mustNonNull = true)]
            public List<ContentDataParam> configs;

            /// <summary>
            /// Stores the label value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Label, minLength = 2, maxLength = 32, isOptional = true)]
            public string? label;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the set content data operation.
        /// </summary>
        public class ServerSetContentDataRequestData : SetContentDataRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the set content data operation.
        /// </summary>
        public class AdminSetContentDataRequestData : ServerSetContentDataRequestData
        {
        }

    }

    /// <summary>
    /// Defines payload models for content operations.
    /// </summary>
    public partial class ContentModels
    {
        /// <summary>
        /// Represents the content data param component.
        /// </summary>
        public class ContentDataParam
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            /// <summary>
            /// Stores the data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Data)]
            public GNHashtable data;

        }

    }

    /// <summary>
    /// Defines payload models for content operations.
    /// </summary>
    public partial class ContentModels
    {
        /// <summary>
        /// Represents the response payload for the file ID upload operation.
        /// </summary>
        public class FileIdUploadResponseData
        {
            /// <summary>
            /// Stores the file ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FileId)]
            public string fileId;

        }

        /// <summary>
        /// Represents the response payload for the get content data operation.
        /// </summary>
        public class GetContentDataResponseData
        {
            /// <summary>
            /// Stores the configs value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Configs, elementCls = typeof(ContentDataParam), mustNonNull = true)]
            public List<ContentDataParam> configs;

        }

        /// <summary>
        /// Represents the response payload for the get file upload info list operation.
        /// </summary>
        public class GetFileUploadInfoListResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(FileIdUploadResponseData))]
            public List<FileIdUploadResponseData> results;

        }

        /// <summary>
        /// Represents the file upload item component.
        /// </summary>
        public class FileUploadItem
        {
            /// <summary>
            /// Stores the mime type value.
            /// </summary>
            [StringDataMember(code = ParameterCode.MimeType)]
            public string mimeType;

            /// <summary>
            /// Stores the size value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Size)]
            public long size;

            /// <summary>
            /// Stores the folder file name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FolderFileName)]
            public string folderFileName;

        }

        /// <summary>
        /// Represents the response payload for the get file upload info operation.
        /// </summary>
        public class GetFileUploadInfoResponseData : FileIdUploadResponseData
        {
            /// <summary>
            /// Stores the file name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FileName)]
            public string fileName;

            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            /// <summary>
            /// Stores the remove status value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveStatus)]
            public GenericModels.RemoveStatusItem removeStatus;

            /// <summary>
            /// Stores the timestamp upload expire value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsUploadExpire, isOptional = true)]
            public long? tsUploadExpire;

            /// <summary>
            /// Stores the file upload value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.FileUpload, isOptional = true)]
            public FileUploadItem? fileUpload;

        }

        /// <summary>
        /// Represents the response payload for the request download file upload info operation.
        /// </summary>
        public class RequestDownloadFileUploadInfoResponseData
        {
            /// <summary>
            /// Stores the download token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.DownloadToken)]
            public string downloadToken;
        }

        /// <summary>
        /// Represents the response payload for the empty operation.
        /// </summary>
        public class EmptyResponseData
        {

        }

    }

}