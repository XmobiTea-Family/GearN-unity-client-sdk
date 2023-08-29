namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class FindPlayerOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.FindPlayer;

        protected override bool operationEncrypted => true;

        public FindPlayerOperationRequest(string keyword, int skip = 0, int limit = 20, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(FriendParameterCode.Keyword, keyword)
                .Add(FriendParameterCode.Skip, skip)
                .Add(FriendParameterCode.Limit, limit)
                .Build();
        }

    }

}
