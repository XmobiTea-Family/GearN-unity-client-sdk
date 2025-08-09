namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;

    public partial class ContentModels
    {
        public class CreateNewFileUploadInfoRequestData
        {
            [StringDataMember(code = ParameterCode.FileName, mustNonNull = true, minLength = 5, maxLength = 50)]
            public string fileName;

        }

        public class ServerCreateNewFileUploadInfoRequestData : CreateNewFileUploadInfoRequestData
        {
        }

        public class AdminCreateNewFileUploadInfoRequestData : ServerCreateNewFileUploadInfoRequestData
        {
        }

        public class GetContentDataRequestData
        {
            [GNArrayDataMember(code = ParameterCode.Keys, elementCls = typeof(string), isOptional = true)]
            public List<string>? keys;

            [StringDataMember(code = ParameterCode.Label, minLength = 2, maxLength = 32, isOptional = true, defaultValue = "")]
            public string? label;

        }

        public class ServerGetContentDataRequestData : GetContentDataRequestData
        {
        }

        public class AdminGetContentDataRequestData : ServerGetContentDataRequestData
        {
        }

        public class GetFileUploadInfoListRequestData
        {
            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

        }

        public class ServerGetFileUploadInfoListRequestData : GetFileUploadInfoListRequestData
        {
        }

        public class AdminGetFileUploadInfoListRequestData : ServerGetFileUploadInfoListRequestData
        {
        }

        public class GetFileUploadInfoRequestData
        {
            [StringDataMember(code = ParameterCode.FileId, mustNonNull = true, minLength = 15, maxLength = 15)]
            public string fileId;

        }

        public class ServerGetFileUploadInfoRequestData : GetFileUploadInfoRequestData
        {
        }

        public class AdminGetFileUploadInfoRequestData : ServerGetFileUploadInfoRequestData
        {
        }

        public class RemoveFileUploadInfoRequestData
        {
            [StringDataMember(code = ParameterCode.FileId, mustNonNull = true, minLength = 15, maxLength = 15)]
            public string fileId;

            [StringDataMember(code = ParameterCode.Reason, isOptional = true, defaultValue = "")]
            public string? reason;

        }

        public class ServerRemoveFileUploadInfoRequestData : RemoveFileUploadInfoRequestData
        {
        }

        public class AdminRemoveFileUploadInfoRequestData : ServerRemoveFileUploadInfoRequestData
        {
        }

        public class RequestDownloadFileUploadInfoRequestData
        {
            [StringDataMember(code = ParameterCode.FileId, mustNonNull = true, minLength = 15, maxLength = 15)]
            public string fileId;

        }

        public class ServerRequestDownloadFileUploadInfoRequestData : RequestDownloadFileUploadInfoRequestData
        {
        }

        public class AdminRequestDownloadFileUploadInfoRequestData : ServerRequestDownloadFileUploadInfoRequestData
        {
        }

        public class SetContentDataRequestData
        {
            [GNArrayDataMember(code = ParameterCode.Configs, elementCls = typeof(ContentDataParam), mustNonNull = true)]
            public List<ContentDataParam> configs;

            [StringDataMember(code = ParameterCode.Label, minLength = 2, maxLength = 32, isOptional = true)]
            public string? label;

        }

        public class ServerSetContentDataRequestData : SetContentDataRequestData
        {
        }

        public class AdminSetContentDataRequestData : ServerSetContentDataRequestData
        {
        }

    }

    public partial class ContentModels
    {
        public class ContentDataParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string key;

            [GNHashtableDataMember(code = ParameterCode.Data)]
            public GNHashtable data;

        }

    }

    public partial class ContentModels
    {
        public class FileIdUploadResponseData
        {
            [StringDataMember(code = ParameterCode.FileId)]
            public string fileId;

        }

        public class GetContentDataResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Configs, elementCls = typeof(ContentDataParam), mustNonNull = true)]
            public List<ContentDataParam> configs;

        }

        public class GetFileUploadInfoListResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(FileIdUploadResponseData))]
            public List<FileIdUploadResponseData> results;

        }

        public class FileUploadItem
        {
            [StringDataMember(code = ParameterCode.MimeType)]
            public string mimeType;

            [NumberDataMember(code = ParameterCode.Size)]
            public long size;

            [StringDataMember(code = ParameterCode.FolderFileName)]
            public string folderFileName;

        }

        public class GetFileUploadInfoResponseData : FileIdUploadResponseData
        {
            [StringDataMember(code = ParameterCode.FileName)]
            public string fileName;

            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            [GNHashtableDataMember(code = ParameterCode.RemoveStatus)]
            public GenericModels.RemoveStatusItem removeStatus;

            [NumberDataMember(code = ParameterCode.TsUploadExpire, isOptional = true)]
            public long? tsUploadExpire;

            [GNHashtableDataMember(code = ParameterCode.FileUpload, isOptional = true)]
            public FileUploadItem? fileUpload;

        }

        public class RequestDownloadFileUploadInfoResponseData
        {
            [StringDataMember(code = ParameterCode.DownloadToken)]
            public string downloadToken;
        }

        public class EmptyResponseData
        {

        }

    }

}
