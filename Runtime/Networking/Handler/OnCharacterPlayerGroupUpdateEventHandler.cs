namespace XmobiTea.GearN.Networking
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Models;
    using XmobiTea.GearN.Helper;

    /// <summary>
    /// Represents the data structure for updating a character's player group list.
    /// </summary>
    public class CharacterPlayerGroupUpdate
    {
        /// <summary>
        /// The character ID.
        /// </summary>
        [StringDataMember(code = ParameterCode.CharacterId)]
        public string characterId;

        /// <summary>
        /// A list of player groups associated with the character.
        /// </summary>
        [GNArrayDataMember(code = ParameterCode.PlayerGroups, elementCls = typeof(GenericModels.GroupItem))]
        public List<GenericModels.GroupItem> playerGroups;
    }

    /// <summary>
    /// Handles the "OnCharacterPlayerGroupUpdate" event.
    /// </summary>
    public class OnCharacterPlayerGroupUpdateEventHandler : IServerEventHandler
    {
        /// <summary>
        /// Event triggered when a character's player group list is updated.
        /// </summary>
        public static Action1<CharacterPlayerGroupUpdate> onUpdate;

        /// <summary>
        /// Gets the event code associated with this handler.
        /// </summary>
        /// <returns>The event code for "OnCharacterPlayerGroupUpdate".</returns>
        public string getEventCode() => EventCode.OnCharacterPlayerGroupUpdate;

        /// <summary>
        /// Handles the "OnCharacterPlayerGroupUpdate" operation event.
        /// Deserializes the event parameters and invokes the update action.
        /// </summary>
        /// <param name="operationEvent">The operation event containing the parameters for the group update.</param>
        public void handle(OperationEvent operationEvent)
        {
            OnCharacterPlayerGroupUpdateEventHandler.onUpdate?.Invoke(ConverterService.deserializeObject<CharacterPlayerGroupUpdate>(operationEvent.getParameters()));
        }
    }
}
