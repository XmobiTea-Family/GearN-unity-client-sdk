namespace XmobiTea.GN.Constant
{
    /// <summary>
    /// Holds constant values used throughout the GN networking system.
    /// </summary>
    public class Commands
    {
        /// <summary>
        /// HTTP header key for specifying the user agent.
        /// </summary>
        public const string USER_AGENT = "User-Agent";

        /// <summary>
        /// HTTP header key for specifying the content type.
        /// </summary>
        public const string CONTENT_TYPE = "Content-Type";

        /// <summary>
        /// HTTP header key for specifying the content length.
        /// </summary>
        public const string CONTENT_LENGTH = "Content-Length";

        /// <summary>
        /// MIME type for JSON content.
        /// </summary>
        public const string APPLICATION_JSON = "application/json";

        /// <summary>
        /// MIME type for MsgPack content.
        /// </summary>
        public const string APPLICATION_MSGPACK = "application/msgpack";

        /// <summary>
        /// Key for the authentication token in requests.
        /// </summary>
        public const string RequestAuthTokenCmd = "a";

        /// <summary>
        /// Key for the secret key in requests.
        /// </summary>
        public const string RequestSecretCmd = "s";

        /// <summary>
        /// Key for the gameId key in requests.
        /// </summary>
        public const string RequestGameIdCmd = "g";

        /// <summary>
        /// Key for MsgPack request commands.
        /// </summary>
        public const string RequestCmd_MsgPack = "r";

        /// <summary>
        /// Key for MsgPack response commands.
        /// </summary>
        public const string ResponseCmd_MsgPack = "r";

        /// <summary>
        /// Key for MsgPack event commands.
        /// </summary>
        public const string EventCmd_MsgPack = "e";

        /// <summary>
        /// Key for JSON request commands.
        /// </summary>
        public const string RequestCmd_Json = "t";

        /// <summary>
        /// Key for JSON response commands.
        /// </summary>
        public const string ResponseCmd_Json = "t";

        /// <summary>
        /// Key for JSON event commands.
        /// </summary>
        public const string EventCmd_Json = "y";

        /// <summary>
        /// General key for data fields.
        /// </summary>
        public const string Data = "d";

        /// <summary>
        /// Key for file fields.
        /// </summary>
        public const string File = "f";

        /// <summary>
        /// Private constructor to prevent instantiation of this utility class.
        /// </summary>
        private Commands() { }
    }
}
