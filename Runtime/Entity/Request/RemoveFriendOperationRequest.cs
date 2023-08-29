namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class RemoveFriendOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.RemoveFriend;

        protected override bool operationEncrypted => true;

        public RemoveFriendOperationRequest(string friendId, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(FriendParameterCode.FriendId, friendId)
                .Build();
        }

    }

}
