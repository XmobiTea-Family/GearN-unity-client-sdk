namespace XmobiTea.GearN.Networking
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Models;
    using XmobiTea.GearN.Helper;

    /// <summary>
    /// Represents an update for group messages.
    /// </summary>
    public class GroupMessageUpdate
    {
        /// <summary>
        /// A list of updated group messages.
        /// </summary>
        [GNArrayDataMember(code = ParameterCode.GroupMessages, elementCls = typeof(GroupModels.GroupMessageResponseData))]
        public List<GroupModels.GroupMessageResponseData> groupMessages;
    }

    /// <summary>
    /// Event handler for handling updates to group messages.
    /// </summary>
    public class OnGroupMessageUpdateEventHandler : IServerEventHandler
    {
        /// <summary>
        /// An action to be invoked when a group message update occurs.
        /// </summary>
        public static Action1<GroupMessageUpdate> onUpdate;

        /// <summary>
        /// Gets the event code associated with the group message update.
        /// </summary>
        /// <returns>The event code for group message updates.</returns>
        public string getEventCode() => EventCode.OnGroupMessageUpdate;

        /// <summary>
        /// Handles the group message update event.
        /// </summary>
        /// <param name="operationEvent">The operation event containing the update data.</param>
        public void handle(OperationEvent operationEvent)
        {
            OnGroupMessageUpdateEventHandler.onUpdate?.Invoke(ConverterService.deserializeObject<GroupMessageUpdate>(operationEvent.getParameters()));
        }
    }
}
