namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class GetFileUploadInfoOperationRequest : CustomOperationRequest
    {
        protected override int Code => OperationCode.GetFileUploadInfo;

        protected override bool Reliable => true;

        public GetFileUploadInfoOperationRequest(string fileId, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            Parameters = new GNHashtable.Builder()
                .Add(FileUploadInfoParameterCode.FileId, fileId)
                .Build();
        }
    }
}
