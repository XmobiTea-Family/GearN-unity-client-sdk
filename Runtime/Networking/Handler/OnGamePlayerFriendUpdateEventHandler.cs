namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Entity.Models;
    using XmobiTea.GN.Helper;

    public class GamePlayerFriendUpdate
    {
        [StringDataMember(code = GNParameterCode.CharacterId, isOptional = true)]
        public string? characterId;

        [GNArrayDataMember(code = GNParameterCode.PlayerFriends, elementCls = typeof(GenericModels.FriendItem))]
        public List<GenericModels.FriendItem> playerFriends;
    }

    public class OnGamePlayerFriendUpdateEventHandler : IServerEventHandler
    {
        public static Action<GamePlayerFriendUpdate> onUpdate;

        public int getEventCode() => EventCode.OnGamePlayerFriendUpdate;

        public void handle(OperationEvent operationEvent)
        {
            OnGamePlayerFriendUpdateEventHandler.onUpdate?.Invoke(ConverterService.deserializeObject<GamePlayerFriendUpdate>(operationEvent.getParameters()));
        }

    }

}
