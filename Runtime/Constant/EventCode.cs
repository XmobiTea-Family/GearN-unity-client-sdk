namespace XmobiTea.GN.Constant
{
    /// <summary>
    /// Defines constant event codes for handling various server events.
    /// </summary>
    public partial class EventCode
    {
        /// <summary>
        /// Event code for when a game player's friend list is updated.
        /// </summary>
        public const int OnGamePlayerFriendUpdate = 1;

        /// <summary>
        /// Event code for when a character player's friend list is updated.
        /// </summary>
        public const int OnCharacterPlayerFriendUpdate = 2;

        /// <summary>
        /// Event code for when a game player's group list is updated.
        /// </summary>
        public const int OnGamePlayerGroupUpdate = 3;

        /// <summary>
        /// Event code for when a group member's details are updated.
        /// </summary>
        public const int OnGroupMemberUpdate = 4;

        /// <summary>
        /// Event code for when group messages are updated.
        /// </summary>
        public const int OnGroupMessageUpdate = 5;

        /// <summary>
        /// Event code for when a character player's group list is updated.
        /// </summary>
        public const int OnCharacterPlayerGroupUpdate = 6;

        /// <summary>
        /// Private constructor to prevent instantiation of this utility class.
        /// </summary>
        private EventCode() { }
    }
}
