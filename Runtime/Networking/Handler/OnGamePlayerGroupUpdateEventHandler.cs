namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Entity.Models;
    using XmobiTea.GN.Helper;

    /// <summary>
    /// Represents the data structure for updating a player's group list in the game.
    /// </summary>
    public class GamePlayerGroupUpdate
    {
        /// <summary>
        /// The character ID (optional).
        /// </summary>
        [StringDataMember(code = ParameterCode.CharacterId, isOptional = true)]
        public string? characterId;

        /// <summary>
        /// A list of player groups associated with the game player.
        /// </summary>
        [GNArrayDataMember(code = ParameterCode.PlayerGroups, elementCls = typeof(GenericModels.GroupItem))]
        public List<GenericModels.GroupItem> playerGroups;
    }

    /// <summary>
    /// Handles the "OnGamePlayerGroupUpdate" event.
    /// </summary>
    public class OnGamePlayerGroupUpdateEventHandler : IServerEventHandler
    {
        /// <summary>
        /// Event triggered when a game player's group list is updated.
        /// </summary>
        public static Action<GamePlayerGroupUpdate> onUpdate;

        /// <summary>
        /// Gets the event code associated with this handler.
        /// </summary>
        /// <returns>The event code for "OnGamePlayerGroupUpdate".</returns>
        public string getEventCode() => EventCode.OnGamePlayerGroupUpdate;

        /// <summary>
        /// Handles the "OnGamePlayerGroupUpdate" operation event.
        /// Deserializes the event parameters and invokes the update action.
        /// </summary>
        /// <param name="operationEvent">The operation event containing the parameters for the group update.</param>
        public void handle(OperationEvent operationEvent)
        {
            OnGamePlayerGroupUpdateEventHandler.onUpdate?.Invoke(ConverterService.deserializeObject<GamePlayerGroupUpdate>(operationEvent.getParameters()));
        }
    }
}
