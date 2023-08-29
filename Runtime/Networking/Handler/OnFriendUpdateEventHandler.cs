namespace XmobiTea.GN.Networking
{
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;

    public class OnFriendUpdateEventHandler : IServerEventHandler
    {
        public int GetEventCode() => EventCode.OnFriendUpdate;

        public void Handle(OperationEvent operationEvent)
        {
            var friendItemLst = GNNetwork.GetFriendItemLst();

            var paramters = operationEvent.GetParameters();
            var gsFriendLst = paramters.GetGNArray(FriendParameterCode.FriendLst);

            for (var i = 0; i < gsFriendLst.Count(); i++)
            {
                var gsFriend = gsFriendLst.GetGNHashtable(i);

                var friendId = gsFriend.GetString(FriendParameterCode.FriendId);
                var friendStatus = (FriendStatus)gsFriend.GetInt(FriendParameterCode.FriendStatus);
                var tsLastUpdate = gsFriend.GetLong(FriendParameterCode.TsLastUpdate, GNNetwork.serverTimestamp);

                var friendItem = friendItemLst.Find(x => x.friendId.Equals(friendId));
                if (friendItem == null)
                {
                    friendItem = new FriendItem();
                    friendItem.friendId = friendId;
                    friendItem.friendStatus = friendStatus;

                    if (friendStatus != FriendStatus.Unknown)
                    {
                        friendItem.tsLastUpdate = tsLastUpdate;

                        friendItemLst.Add(friendItem);
                    }
                }
                else
                {
                    friendItem.friendStatus = friendStatus;
                    friendItem.tsLastUpdate = tsLastUpdate;

                    if (friendStatus == FriendStatus.Unknown)
                    {
                        friendItemLst.Remove(friendItem);
                    }
                }

                GNNetwork.onFriendItemChange?.Invoke(friendItem);
            }
        }

    }

}
