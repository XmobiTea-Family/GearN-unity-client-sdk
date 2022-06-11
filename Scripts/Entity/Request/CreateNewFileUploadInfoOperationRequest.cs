namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class CreateNewFileUploadInfoOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.CreateNewFileUploadInfo;

        protected override bool reliable => true;

        public CreateNewFileUploadInfoOperationRequest(string originFileName, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            parameters = new GNHashtable.Builder()
                .Add(FileUploadInfoParameterCode.OriginFileName, originFileName)
                .Build();
        }
    }
}
