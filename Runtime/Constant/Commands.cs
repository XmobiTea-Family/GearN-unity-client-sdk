namespace XmobiTea.GN.Constant
{
	public class Commands
	{
		public const string USER_AGENT = "User-Agent";

		public const string CONTENT_TYPE = "Content-Type";
		public const string CONTENT_LENGTH = "Content-Length";
		public const string APPLICATION_JSON = "application/json";
		public const string APPLICATION_MSGPACK = "application/msgpack";

		public const string RequestAuthTokenCmd = "a";

		public const string RequestCmd_MsgPack = "r";
		public const string ResponseCmd_MsgPack = "r";
		public const string EventCmd_MsgPack = "e";

		public const string RequestCmd_Json = "t";
		public const string ResponseCmd_Json = "t";
		public const string EventCmd_Json = "y";

		public const string Data = "d";
		public const string File = "f";

		private Commands() { }
	}
}
