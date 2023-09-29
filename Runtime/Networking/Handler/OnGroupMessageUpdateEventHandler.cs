namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Entity.Models;
    using XmobiTea.GN.Helper;

    public class GroupMessageUpdate
    {
        [GNArrayDataMember(code = GNParameterCode.GroupMessages, elementCls = typeof(GroupModels.GroupMessageResponseData))]
        public List<GroupModels.GroupMessageResponseData> groupMessages;
    }

    public class OnGroupMessageUpdateEventHandler : IServerEventHandler
    {
        public static Action<GroupMessageUpdate> onUpdate;

        public int getEventCode() => EventCode.OnGroupMessageUpdate;

        public void handle(OperationEvent operationEvent)
        {
            OnGroupMessageUpdateEventHandler.onUpdate?.Invoke(ConverterService.deserializeObject<GroupMessageUpdate>(operationEvent.getParameters()));
        }

    }

}
