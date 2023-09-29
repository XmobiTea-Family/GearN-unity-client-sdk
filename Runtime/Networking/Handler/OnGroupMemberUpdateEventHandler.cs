namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Entity.Models;
    using XmobiTea.GN.Helper;

    public class GroupMemberUpdate
    {
        [GNArrayDataMember(code = GNParameterCode.Members, elementCls = typeof(GenericModels.FriendItem))]
        public List<GenericModels.MemberItem> members;
    }

    public class OnGroupMemberUpdateEventHandler : IServerEventHandler
    {
        public static Action<GroupMemberUpdate> onUpdate;

        public int getEventCode() => EventCode.OnGroupMemberUpdate;

        public void handle(OperationEvent operationEvent)
        {
            OnGroupMemberUpdateEventHandler.onUpdate?.Invoke(ConverterService.deserializeObject<GroupMemberUpdate>(operationEvent.getParameters()));
        }

    }

}
