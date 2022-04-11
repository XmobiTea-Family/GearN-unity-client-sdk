namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class CreateNewFileUploadInfoOperationRequest : CustomOperationRequest
    {
        protected override int Code => OperationCode.CreateNewFileUploadInfo;

        protected override bool Reliable => true;

        public CreateNewFileUploadInfoOperationRequest(string originFileName, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            Parameters = new GNHashtable.Builder()
                .Add(FileUploadInfoParameterCode.OriginFileName, originFileName)
                .Build();
        }
    }
}
