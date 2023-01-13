namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class CreateNewFileUploadInfoOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.CreateNewFileUploadInfo;

        protected override bool operationEncrypted => true;

        public CreateNewFileUploadInfoOperationRequest(string originFileName, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(FileUploadInfoParameterCode.OriginFileName, originFileName)
                .Build();
        }

    }

}
