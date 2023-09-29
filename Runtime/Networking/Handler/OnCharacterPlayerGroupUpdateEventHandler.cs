namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Entity.Models;
    using XmobiTea.GN.Helper;

    public class CharacterPlayerGroupUpdate
    {
        [StringDataMember(code = GNParameterCode.CharacterId)]
        public string characterId;

        [GNArrayDataMember(code = GNParameterCode.PlayerGroups, elementCls = typeof(GenericModels.GroupItem))]
        public List<GenericModels.GroupItem> playerGroups;

    }

    public class OnCharacterPlayerGroupUpdateEventHandler : IServerEventHandler
    {
        public static Action<CharacterPlayerGroupUpdate> onUpdate;

        public int getEventCode() => EventCode.OnCharacterPlayerGroupUpdate;

        public void handle(OperationEvent operationEvent)
        {
            OnCharacterPlayerGroupUpdateEventHandler.onUpdate?.Invoke(ConverterService.deserializeObject<CharacterPlayerGroupUpdate>(operationEvent.getParameters()));
        }

    }

}
