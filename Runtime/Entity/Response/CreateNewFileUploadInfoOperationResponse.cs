namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class CreateNewFileUploadInfoOperationResponse : CustomOperationResponse
    {
        public string fileId { get; private set; }
        public string originFileName { get; private set; }
        public long tsCreate { get; private set; }
        public long tsUploadExpire { get; private set; }
        public string userId { get; private set; }

        public CreateNewFileUploadInfoOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!hasError)
            {
                if (errorCode == FileUploadInfoErrorCode.Ok)
                {
                    fileId = parameters.GetString(FileUploadInfoParameterCode.FileId);
                    originFileName = parameters.GetString(FileUploadInfoParameterCode.OriginFileName);
                    tsCreate = parameters.GetLong(FileUploadInfoParameterCode.TsCreate);
                    tsUploadExpire = parameters.GetLong(FileUploadInfoParameterCode.TsUploadExpire);
                    userId = parameters.GetString(FileUploadInfoParameterCode.UserId);
                }
            }
        }
    }
}
