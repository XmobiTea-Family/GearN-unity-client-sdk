namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class CreateNewFileUploadInfoOperationResponse : CustomOperationResponse
    {
        public bool Success { get; private set; }

        public int ErrorCode;

        public string FileId;
        public string OriginFileName;
        public long TsCreate;
        public long TsUploadExpire;
        public string UserId;

        public CreateNewFileUploadInfoOperationResponse(OperationResponse operationResponse) : base(operationResponse)
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
                    TsUploadExpire = parameters.GetLong(FileUploadInfoParameterCode.TsUploadExpire);
                    UserId = parameters.GetString(FileUploadInfoParameterCode.UserId);
                }
            }
        }
    }
}
