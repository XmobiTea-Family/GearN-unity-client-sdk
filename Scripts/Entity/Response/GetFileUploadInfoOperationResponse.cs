namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class GetFileUploadInfoOperationResponse : CustomOperationResponse
    {
        public bool Success { get; private set; }
        public bool FileHasUpload { get; private set; }

        public int ErrorCode;

        public string FileId;
        public string OriginFileName;
        public long TsCreate;
        public string UserId;

        public long TsUploadExpire;

        public long TsUploadFile;
        public string MimeType;
        public long Size;
        public string FolderFileName;

        public GetFileUploadInfoOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!HasError)
            {
                Success = true;

                var parameters = operationResponse.GetParameters();

                ErrorCode = parameters.GetInt(ParameterCode.ErrorCode);

                if (ErrorCode == FileUploadInfoErrorCode.Ok)
                {
                    FileId = parameters.GetString(FileUploadInfoParameterCode.FileId);
                    OriginFileName = parameters.GetString(FileUploadInfoParameterCode.OriginFileName);
                    TsCreate = parameters.GetLong(FileUploadInfoParameterCode.TsCreate);
                    UserId = parameters.GetString(FileUploadInfoParameterCode.UserId);

                    if (parameters.ContainsKey(FileUploadInfoParameterCode.TsUploadExpire))
                    {
                        FileHasUpload = false;

                        TsUploadExpire = parameters.GetLong(FileUploadInfoParameterCode.TsUploadExpire);
                    }
                    else
                    {
                        FileHasUpload = true;

                        TsUploadFile = parameters.GetLong(FileUploadInfoParameterCode.TsUploadFile);
                        MimeType = parameters.GetString(FileUploadInfoParameterCode.MimeType);
                        Size = parameters.GetLong(FileUploadInfoParameterCode.Size);
                        FolderFileName = parameters.GetString(FileUploadInfoParameterCode.FolderFileName);
                    }
                }
            }
        }
    }
}
