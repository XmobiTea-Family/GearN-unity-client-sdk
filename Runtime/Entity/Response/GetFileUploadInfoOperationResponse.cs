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

        public override void SetupOperationResponse(OperationResponse operationResponse)
        {
            base.SetupOperationResponse(operationResponse);

            if (!this.HasError())
            {
                if (this.errorCode == FileUploadInfoErrorCode.Ok)
                {
                    this.fileId = this.parameters.GetString(FileUploadInfoParameterCode.FileId);
                    this.originFileName = this.parameters.GetString(FileUploadInfoParameterCode.OriginFileName);
                    this.tsCreate = this.parameters.GetLong(FileUploadInfoParameterCode.TsCreate);
                    this.userId = this.parameters.GetString(FileUploadInfoParameterCode.UserId);

                    if (this.parameters.ContainsKey(FileUploadInfoParameterCode.TsUploadExpire))
                    {
                        this.fileHasUpload = false;

                        this.tsUploadExpire = this.parameters.GetLong(FileUploadInfoParameterCode.TsUploadExpire);
                    }
                    else
                    {
                        this.fileHasUpload = true;

                        this.tsUploadFile = this.parameters.GetLong(FileUploadInfoParameterCode.TsUploadFile);
                        this.mimeType = this.parameters.GetString(FileUploadInfoParameterCode.MimeType);
                        this.size = this.parameters.GetLong(FileUploadInfoParameterCode.Size);
                        this.folderFileName = this.parameters.GetString(FileUploadInfoParameterCode.FolderFileName);
                    }
                }
            }
        }

    }

}
