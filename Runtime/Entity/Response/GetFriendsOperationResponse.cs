namespace XmobiTea.GN.Entity.Response
{
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;

    public class GetFriendsOperationResponse : CustomOperationResponse
    {
        public class FriendItem
        {
            public string friendId { get; internal set; }
            public bool isSocialLoginFriend { get; internal set; }
            public int friendStatus { get; internal set; }
            public long tsLastUpdate { get; internal set; }
        }

        public List<FriendItem> friendLst { get; private set; }

        public override void SetupOperationResponse(OperationResponse operationResponse)
        {
            base.SetupOperationResponse(operationResponse);

            if (!this.HasError())
            {
                if (this.errorCode == FriendErrorCode.Ok)
                {
                    this.friendLst = new List<FriendItem>();

                    var gsFriendLst = this.parameters.GetGNArray(FriendParameterCode.FriendLst);

                    for (var i = 0; i < gsFriendLst.Count(); i++)
                    {
                        var gsFriend = gsFriendLst.GetGNHashtable(i);

                        this.friendLst.Add(new FriendItem()
                        {
                            friendId = gsFriend.GetString(FriendParameterCode.FriendId),
                            isSocialLoginFriend = gsFriend.GetBool(FriendParameterCode.IsSocialLoginFriend),
                            friendStatus = gsFriend.GetInt(FriendParameterCode.FriendStatus),
                            tsLastUpdate = gsFriend.GetLong(FriendParameterCode.TsLastUpdate, GNNetwork.serverTimestamp)
                        });
                    }
                }
            }
        }

    }

}
