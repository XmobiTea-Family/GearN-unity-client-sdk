namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Entity.Models;
    using XmobiTea.GN.Helper;

    public class GamePlayerGroupUpdate
    {
        [StringDataMember(code = GNParameterCode.CharacterId, isOptional = true)]
        public string? characterId;

        [GNArrayDataMember(code = GNParameterCode.PlayerGroups, elementCls = typeof(GenericModels.GroupItem))]
        public List<GenericModels.GroupItem> playerGroups;
    }

    public class OnGamePlayerGroupUpdateEventHandler : IServerEventHandler
    {
        public static Action<GamePlayerGroupUpdate> onUpdate;

        public int getEventCode() => EventCode.OnGamePlayerGroupUpdate;

        public void handle(OperationEvent operationEvent)
        {
            OnGamePlayerGroupUpdateEventHandler.onUpdate?.Invoke(ConverterService.deserializeObject<GamePlayerGroupUpdate>(operationEvent.getParameters()));
        }

    }

}
