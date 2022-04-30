namespace XmobiTea.GN.Helper
{
    using UnityEngine;

#if !UNITY_EDITOR
#if UNITY_IOS
    using XmobiTea.GN.Helper.DeviceInfo.iOS;
#elif UNITY_WEBGL
    using XmobiTea.GN.Helper.DeviceInfo.WebGL;
#endif
#endif

    public class DeviceInfoHelper
    {
#if UNITY_IOS
        private const string UUID_KEY = "uuid";
        private const string USERID_KEY = "0";
#endif

        public static RuntimePlatform Platform => Application.platform;

        public static string DeviceId
        {
            get
            {
#if !UNITY_EDITOR
#if UNITY_IOS
                var deviceId = string.Empty;

                var dictionary = (System.Collections.IDictionary)Parser.Parse(DeviceKeyChain.BindGetKeyChainUser());

                if (dictionary.Contains(DeviceInfoHelper.UUID_KEY)) deviceId = dictionary[DeviceInfoHelper.UUID_KEY] as string;

                if (string.IsNullOrEmpty(deviceId))
                {
                    deviceId = SystemInfo.deviceUniqueIdentifier;
                    DeviceKeyChain.BindSetKeyChainUser(DeviceInfoHelper.USERID_KEY, deviceId);
                    Debug.Log("===SavedUUID on empty: [" + deviceId + "]");
                }

                return deviceId;
#elif UNITY_WEBGL
                return DeviceKeyChain.GetDeviceId();
#endif
#endif

                return SystemInfo.deviceUniqueIdentifier;
            }
        }
    }
}
