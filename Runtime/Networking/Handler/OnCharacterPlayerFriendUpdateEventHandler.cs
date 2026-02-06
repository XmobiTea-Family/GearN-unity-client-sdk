namespace XmobiTea.GearN.Networking
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Models;
    using XmobiTea.GearN.Helper;

    /// <summary>
    /// Represents the data structure for updating a character's player friend list.
    /// </summary>
    public class CharacterPlayerFriendUpdate
    {
        /// <summary>
        /// The character ID.
        /// </summary>
        [StringDataMember(code = ParameterCode.CharacterId)]
        public string characterId;

        /// <summary>
        /// A list of player friends associated with the character.
        /// </summary>
        [GNArrayDataMember(code = ParameterCode.PlayerFriends, elementCls = typeof(GenericModels.FriendItem))]
        public List<GenericModels.FriendItem> playerFriends;
    }

    /// <summary>
    /// Handles the "OnCharacterPlayerFriendUpdate" event.
    /// This handler processes the event and triggers the corresponding update logic.
    /// </summary>
    public class OnCharacterPlayerFriendUpdateEventHandler : IServerEventHandler
    {
        /// <summary>
        /// Event triggered when a character's player friend list is updated.
        /// Subscribing to this action allows handling the update logic.
        /// </summary>
        public static Action1<CharacterPlayerFriendUpdate> onUpdate;

        /// <summary>
        /// Gets the event code associated with this handler.
        /// </summary>
        /// <returns>
        /// The event code for "OnCharacterPlayerFriendUpdate".
        /// </returns>
        public string getEventCode() => EventCode.OnCharacterPlayerFriendUpdate;

        /// <summary>
        /// Handles the "OnCharacterPlayerFriendUpdate" operation event.
        /// This method deserializes the event parameters and invokes the update action.
        /// </summary>
        /// <param name="operationEvent">
        /// The operation event containing the parameters for the character player friend update.
        /// </param>
        public void handle(OperationEvent operationEvent)
        {
            // Deserialize the event parameters and invoke the onUpdate action.
            OnCharacterPlayerFriendUpdateEventHandler.onUpdate?.Invoke(ConverterService.deserializeObject<CharacterPlayerFriendUpdate>(operationEvent.getParameters()));
        }
    }
}
