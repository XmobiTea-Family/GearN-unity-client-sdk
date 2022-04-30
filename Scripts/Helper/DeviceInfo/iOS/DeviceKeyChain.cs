#if UNITY_IOS

namespace XmobiTea.GN.Helper.DeviceInfo.iOS
{
	using System.Runtime.InteropServices;
	public class DeviceKeyChain
	{
		[DllImport("__Internal")]
		private static extern string getKeyChainUser();

		public static string BindGetKeyChainUser()
		{
			return getKeyChainUser();
		}

		[DllImport("__Internal")]
		private static extern void setKeyChainUser(string userId, string uuid);

		public static void BindSetKeyChainUser(string userId, string uuid)
		{
			setKeyChainUser(userId, uuid);
		}

		[DllImport("__Internal")]
		private static extern void deleteKeyChainUser();

		public static void BindDeleteKeyChainUser()
		{
			deleteKeyChainUser();
		}
	}
}

#endif