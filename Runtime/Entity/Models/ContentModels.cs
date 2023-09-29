namespace XmobiTea.GN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

	public partial class ContentModels
	{
		public class CreateNewFileUploadInfoRequestData
		{
			[StringDataMember(code = GNParameterCode.FileName, mustNonNull = true, minLength = 5, maxLength = 50)]
			public string fileName;

		}

		public class ServerCreateNewFileUploadInfoRequestData : CreateNewFileUploadInfoRequestData
		{
			[StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
			public string userId;

		}

		public class AdminCreateNewFileUploadInfoRequestData : ServerCreateNewFileUploadInfoRequestData
		{
		}

		public class GetContentDataRequestData
		{
			[GNArrayDataMember(code = GNParameterCode.Keys, elementCls = typeof(string), mustNonNull = true)]
			public List<string> keys;

			[StringDataMember(code = GNParameterCode.Label, minLength = 2, maxLength = 32, isOptional = true, defaultValue = "")]
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
			[StringDataMember(code = GNParameterCode.FileId, mustNonNull = true, minLength = 15, maxLength = 15)]
			public string fileId;

			[NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
			public long? skip;

			[NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
			public long? limit;

		}

		public class ServerGetFileUploadInfoListRequestData : GetFileUploadInfoListRequestData
		{
		}

		public class AdminGetFileUploadInfoListRequestData : ServerGetFileUploadInfoListRequestData
		{
		}

		public class GetFileUploadInfoRequestData
		{
			[StringDataMember(code = GNParameterCode.FileId, mustNonNull = true, minLength = 15, maxLength = 15)]
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
			[StringDataMember(code = GNParameterCode.FileId, mustNonNull = true, minLength = 15, maxLength = 15)]
			public string fileId;

			[StringDataMember(code = GNParameterCode.Reason, isOptional = true, defaultValue = "")]
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
			[StringDataMember(code = GNParameterCode.FileId, mustNonNull = true, minLength = 15, maxLength = 15)]
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
			[GNArrayDataMember(code = GNParameterCode.Configs, elementCls = typeof(ContentDataParam), mustNonNull = true)]
			public List<ContentDataParam> configs;

			[StringDataMember(code = GNParameterCode.Label, minLength = 2, maxLength = 32, isOptional = true)]
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
			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string key;

			[GNHashtableDataMember(code = GNParameterCode.Data)]
			public GNHashtable data;

		}

	}

	public partial class ContentModels
	{
		public class FileIdUploadResponseData
		{
			[StringDataMember(code = GNParameterCode.FileId)]
			public string fileId;

		}

		public class GetContentDataResponseData
		{
			[GNArrayDataMember(code = GNParameterCode.Configs, elementCls = typeof(ContentDataParam), mustNonNull = true)]
			public List<ContentDataParam> configs;

		}

		public class GetFileUploadInfoListResponseData
        {
			[GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(FileIdUploadResponseData))]
			public List<FileIdUploadResponseData> results;

		}

		public class FileUploadItem
        {
			[StringDataMember(code = GNParameterCode.MimeType)]
			public string mimeType;

			[NumberDataMember(code = GNParameterCode.Size)]
			public long size;

			[StringDataMember(code = GNParameterCode.FolderFileName)]
			public string folderFileName;

		}

		public class GetFileUploadInfoResponseData : FileIdUploadResponseData
		{
			//operationResponse.setParameter(GNParameterCode.FileName, uploadFileInfo.getFileName());
			//     operationResponse.setParameter(GNParameterCode.TsCreate, uploadFileInfo.getTsCreate());
			//     operationResponse.setParameter(GNParameterCode.UserId, uploadFileInfo.getUserId());

			[StringDataMember(code = GNParameterCode.FileName)]
			public string fileName;

			[NumberDataMember(code = GNParameterCode.TsCreate)]
			public long tsCreate;

			[StringDataMember(code = GNParameterCode.UserId)]
			public string userId;

			[GNHashtableDataMember(code = GNParameterCode.RemoveStatus)]
			public GenericModels.RemoveStatusItem removeStatus;

			[NumberDataMember(code = GNParameterCode.TsUploadExpire, isOptional = true)]
			public long? tsUploadExpire;

			[GNHashtableDataMember(code = GNParameterCode.FileUpload, isOptional = true)]
			public FileUploadItem? fileUpload;

		}

		public class RequestDownloadFileUploadInfoResponseData
        {
			[StringDataMember(code = GNParameterCode.DownloadToken)]
			public string downloadToken;
		}

		public class EmptyResponseData
		{

		}

	}

}
