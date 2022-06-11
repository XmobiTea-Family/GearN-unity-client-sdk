namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class GetFileUploadInfoOperationRequest : CustomOperationRequest
    {
        protected override int code => OperationCode.GetFileUploadInfo;

        protected override bool reliable => true;

        public GetFileUploadInfoOperationRequest(string fileId, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            parameters = new GNHashtable.Builder()
                .Add(FileUploadInfoParameterCode.FileId, fileId)
                .Build();
        }
    }
}
