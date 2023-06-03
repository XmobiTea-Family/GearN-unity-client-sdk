namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class GetFriendsOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.GetFriends;

        protected override bool operationEncrypted => true;

        public GetFriendsOperationRequest(int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Build();
        }

    }

}
