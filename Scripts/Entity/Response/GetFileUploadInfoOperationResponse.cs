namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class GetFileUploadInfoOperationResponse : CustomOperationResponse
    {
        public bool fileHasUpload { get; private set; }

        public string fileId { get; private set; }
        public string originFileName { get; private set; }
        public long tsCreate { get; private set; }
        public string userId { get; private set; }

        public long tsUploadExpire { get; private set; }

        public long tsUploadFile { get; private set; }
        public string mimeType { get; private set; }
        public long size { get; private set; }
        public string folderFileName { get; private set; }

        public GetFileUploadInfoOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!hasError)
            {
                var parameters = operationResponse.GetParameters();

                if (errorCode == FileUploadInfoErrorCode.Ok)
                {
                    fileId = parameters.GetString(FileUploadInfoParameterCode.FileId);
                    originFileName = parameters.GetString(FileUploadInfoParameterCode.OriginFileName);
                    tsCreate = parameters.GetLong(FileUploadInfoParameterCode.TsCreate);
                    userId = parameters.GetString(FileUploadInfoParameterCode.UserId);

                    if (parameters.ContainsKey(FileUploadInfoParameterCode.TsUploadExpire))
                    {
                        fileHasUpload = false;

                        tsUploadExpire = parameters.GetLong(FileUploadInfoParameterCode.TsUploadExpire);
                    }
                    else
                    {
                        fileHasUpload = true;

                        tsUploadFile = parameters.GetLong(FileUploadInfoParameterCode.TsUploadFile);
                        mimeType = parameters.GetString(FileUploadInfoParameterCode.MimeType);
                        size = parameters.GetLong(FileUploadInfoParameterCode.Size);
                        folderFileName = parameters.GetString(FileUploadInfoParameterCode.FolderFileName);
                    }
                }
            }
        }
    }
}
