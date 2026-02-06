namespace XmobiTea.GearN.Networking
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Models;
    using XmobiTea.GearN.Helper;

    /// <summary>
    /// Represents the data structure for updating a player's friend list in the game.
    /// </summary>
    public class GamePlayerFriendUpdate
    {
        /// <summary>
        /// The character ID (optional).
        /// </summary>
        [StringDataMember(code = ParameterCode.CharacterId, isOptional = true)]
        public string? characterId;

        /// <summary>
        /// A list of player friends associated with the game player.
        /// </summary>
        [GNArrayDataMember(code = ParameterCode.PlayerFriends, elementCls = typeof(GenericModels.FriendItem))]
        public List<GenericModels.FriendItem> playerFriends;
    }

    /// <summary>
    /// Handles the "OnGamePlayerFriendUpdate" event.
    /// </summary>
    public class OnGamePlayerFriendUpdateEventHandler : IServerEventHandler
    {
        /// <summary>
        /// Event triggered when a game player's friend list is updated.
        /// </summary>
        public static Action1<GamePlayerFriendUpdate> onUpdate;

        /// <summary>
        /// Gets the event code associated with this handler.
        /// </summary>
        /// <returns>The event code for "OnGamePlayerFriendUpdate".</returns>
        public string getEventCode() => EventCode.OnGamePlayerFriendUpdate;

        /// <summary>
        /// Handles the "OnGamePlayerFriendUpdate" operation event.
        /// Deserializes the event parameters and invokes the update action.
        /// </summary>
        /// <param name="operationEvent">The operation event containing the parameters for the friend update.</param>
        public void handle(OperationEvent operationEvent)
        {
            OnGamePlayerFriendUpdateEventHandler.onUpdate?.Invoke(ConverterService.deserializeObject<GamePlayerFriendUpdate>(operationEvent.getParameters()));
        }
    }
}
