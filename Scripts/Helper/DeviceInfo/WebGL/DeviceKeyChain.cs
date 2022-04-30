#if UNITY_WEBGL

namespace XmobiTea.GN.Helper.DeviceInfo.WebGL
{
    using System;

    using UnityEngine;

    public class DeviceKeyChain
    {
        private const string DEVICE_ID_PLAYER_PREFS_KEY = "[GN] DeviceId";

        public string GetDeviceId()
        {
            var deviceId = PlayerPrefs.GetString(DeviceKeyChain.DEVICE_ID_PLAYER_PREFS_KEY);

            if (string.IsNullOrEmpty(deviceId))
            {
                deviceId = Guid.NewGuid().ToString();
                PlayerPrefs.SetString(DeviceKeyChain.DEVICE_ID_PLAYER_PREFS_KEY, deviceId);
                PlayerPrefs.Save();
            }

            return deviceId;
        }
    }
}

#endif