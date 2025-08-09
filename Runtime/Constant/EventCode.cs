namespace XmobiTea.GearN.Constant
{
    /// <summary>
    /// Defines constant event codes for handling various server events.
    /// </summary>
    public partial class EventCode
    {
        /// <summary>
        /// Event code for when a game player's friend list is updated.
        /// </summary>
        public const string OnGamePlayerFriendUpdate = "onGamePlayerFriendUpdate";

        /// <summary>
        /// Event code for when a character player's friend list is updated.
        /// </summary>
        public const string OnCharacterPlayerFriendUpdate = "onCharacterPlayerFriendUpdate";

        /// <summary>
        /// Event code for when a game player's group list is updated.
        /// </summary>
        public const string OnGamePlayerGroupUpdate = "onGamePlayerGroupUpdate";

        /// <summary>
        /// Event code for when a group member's details are updated.
        /// </summary>
        public const string OnGroupMemberUpdate = "onGroupMemberUpdate";

        /// <summary>
        /// Event code for when group messages are updated.
        /// </summary>
        public const string OnGroupMessageUpdate = "onGroupMessageUpdate";

        /// <summary>
        /// Event code for when a character player's group list is updated.
        /// </summary>
        public const string OnCharacterPlayerGroupUpdate = "onCharacterPlayerGroupUpdate";

        /// <summary>
        /// Private constructor to prevent instantiation of this utility class.
        /// </summary>
        private EventCode() { }
    }
}
