namespace XmobiTea.GearN.Constant
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
        public const string RequestAuthTokenCmd = "Auth-Token";

        /// <summary>
        /// Key for the secret key in requests.
        /// </summary>
        public const string RequestSecretCmd = "Secret-Key";

        /// <summary>
        /// Key for the gameId key in requests.
        /// </summary>
        public const string RequestGameIdCmd = "Game-Id";

        /// <summary>
        /// Key for MsgPack request commands.
        /// </summary>
        public const string RequestCmd_MsgPack = "rMsgPack";

        /// <summary>
        /// Key for MsgPack response commands.
        /// </summary>
        public const string ResponseCmd_MsgPack = "rMsgPack";

        /// <summary>
        /// Key for MsgPack event commands.
        /// </summary>
        public const string EventCmd_MsgPack = "eMsgPack";

        /// <summary>
        /// Key for JSON request commands.
        /// </summary>
        public const string RequestCmd_Json = "rJson";

        /// <summary>
        /// Key for JSON response commands.
        /// </summary>
        public const string ResponseCmd_Json = "rJson";

        /// <summary>
        /// Key for JSON event commands.
        /// </summary>
        public const string EventCmd_Json = "eJson";

        /// <summary>
        /// General key for data fields.
        /// </summary>
        public const string Data = "data";

        /// <summary>
        /// Key for file fields.
        /// </summary>
        public const string File = "file";

        /// <summary>
        /// Private constructor to prevent instantiation of this utility class.
        /// </summary>
        private Commands() { }
    }
}
