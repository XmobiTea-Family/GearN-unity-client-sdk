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
                    this.tsUploadExpire = this.parameters.GetLong(FileUploadInfoParameterCode.TsUploadExpire);
                    this.userId = this.parameters.GetString(FileUploadInfoParameterCode.UserId);
                }
            }
        }

    }

}
