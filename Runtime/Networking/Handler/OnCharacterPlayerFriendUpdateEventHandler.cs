namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Entity.Models;
    using XmobiTea.GN.Helper;

    public class CharacterPlayerFriendUpdate
    {
        [StringDataMember(code = GNParameterCode.CharacterId)]
        public string characterId;

        [GNArrayDataMember(code = GNParameterCode.PlayerFriends, elementCls = typeof(GenericModels.FriendItem))]
        public List<GenericModels.FriendItem> playerFriends;
    }

    public class OnCharacterPlayerFriendUpdateEventHandler : IServerEventHandler
    {
        public static Action<CharacterPlayerFriendUpdate> onUpdate;

        public int getEventCode() => EventCode.OnCharacterPlayerFriendUpdate;

        public void handle(OperationEvent operationEvent)
        {
            OnCharacterPlayerFriendUpdateEventHandler.onUpdate?.Invoke(ConverterService.deserializeObject<CharacterPlayerFriendUpdate>(operationEvent.getParameters()));
        }

    }

}
