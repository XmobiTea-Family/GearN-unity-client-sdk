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

		public class AdminCreateNewFileUploadInfoRequestData : CreateNewFileUploadInfoRequestData
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

		public class AdminGetContentDataRequestData : GetContentDataRequestData
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

		public class AdminGetFileUploadInfoListRequestData : GetFileUploadInfoListRequestData
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

		public class AdminGetFileUploadInfoRequestData : GetFileUploadInfoRequestData
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

		public class AdminRemoveFileUploadInfoRequestData : RemoveFileUploadInfoRequestData
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

		public class AdminRequestDownloadFileUploadInfoRequestData : RequestDownloadFileUploadInfoRequestData
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

		public class AdminSetContentDataRequestData : SetContentDataRequestData
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

		public class ResponseData
		{

		}

	}

}
