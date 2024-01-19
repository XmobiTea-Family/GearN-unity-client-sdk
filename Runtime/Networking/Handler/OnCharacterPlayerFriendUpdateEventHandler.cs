namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Entity.Models;
    using XmobiTea.GN.Helper;

    /// <summary>
    /// Represents the data structure for updating a character's player friend list.
    /// </summary>
    public class CharacterPlayerFriendUpdate
    {
        /// <summary>
        /// The character ID.
        /// </summary>
        [StringDataMember(code = GNParameterCode.CharacterId)]
        public string characterId;

        /// <summary>
        /// A list of player friends associated with the character.
        /// </summary>
        [GNArrayDataMember(code = GNParameterCode.PlayerFriends, elementCls = typeof(GenericModels.FriendItem))]
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
        public static Action<CharacterPlayerFriendUpdate> onUpdate;

        /// <summary>
        /// Gets the event code associated with this handler.
        /// </summary>
        /// <returns>
        /// The event code for "OnCharacterPlayerFriendUpdate".
        /// </returns>
        public int getEventCode() => EventCode.OnCharacterPlayerFriendUpdate;

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
