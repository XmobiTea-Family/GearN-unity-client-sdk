namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class GetChatMessageUserOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.GetChatMessageUser;

        protected override bool operationEncrypted => true;

        public GetChatMessageUserOperationRequest(string userId, int skip = 0, int limit = 20, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(ChatParameterCode.UserId, userId)
                .Add(ChatParameterCode.Skip, skip)
                .Add(ChatParameterCode.Limit, limit)
                .Build();
        }

    }

}
