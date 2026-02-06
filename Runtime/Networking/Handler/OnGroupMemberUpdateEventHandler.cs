namespace XmobiTea.GearN.Networking
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Models;
    using XmobiTea.GearN.Helper;

    /// <summary>
    /// Represents the data structure for updating group members.
    /// </summary>
    public class GroupMemberUpdate
    {
        /// <summary>
        /// A list of members associated with the group.
        /// </summary>
        [GNArrayDataMember(code = ParameterCode.Members, elementCls = typeof(GenericModels.FriendItem))]
        public List<GenericModels.MemberItem> members;
    }

    /// <summary>
    /// Handles the "OnGroupMemberUpdate" event.
    /// </summary>
    public class OnGroupMemberUpdateEventHandler : IServerEventHandler
    {
        /// <summary>
        /// Event triggered when group members are updated.
        /// </summary>
        public static Action1<GroupMemberUpdate> onUpdate;

        /// <summary>
        /// Gets the event code associated with this handler.
        /// </summary>
        /// <returns>The event code for "OnGroupMemberUpdate".</returns>
        public string getEventCode() => EventCode.OnGroupMemberUpdate;

        /// <summary>
        /// Handles the "OnGroupMemberUpdate" operation event.
        /// Deserializes the event parameters and invokes the update action.
        /// </summary>
        /// <param name="operationEvent">The operation event containing the parameters for the group member update.</param>
        public void handle(OperationEvent operationEvent)
        {
            OnGroupMemberUpdateEventHandler.onUpdate?.Invoke(ConverterService.deserializeObject<GroupMemberUpdate>(operationEvent.getParameters()));
        }
    }
}
