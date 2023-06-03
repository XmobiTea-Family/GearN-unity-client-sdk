namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class AddFriendOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.AddFriend;

        protected override bool operationEncrypted => true;

        public AddFriendOperationRequest(string friendId, bool? forceAcceptFriend = false, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(FriendParameterCode.FriendId, friendId)
                .Build();

            if (forceAcceptFriend != null) this.operationParameters.Add(FriendParameterCode.ForceAcceptFriend, forceAcceptFriend.GetValueOrDefault());
        }

    }

}
