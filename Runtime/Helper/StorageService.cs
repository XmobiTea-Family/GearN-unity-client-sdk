namespace XmobiTea.GearN.Helper
{
    /// <summary>
    /// Provides PlayerPrefs-backed persistence helpers used by the SDK runtime.
    /// </summary>
    public class StorageService
    {
        /// <summary>
        /// Sets string.
        /// </summary>
        public static void setString(string key, string value)
        {
            UnityEngine.PlayerPrefs.SetString(key, value);
        }

        /// <summary>
        /// Gets string.
        /// </summary>
        public static string getString(string key, string defaultValue = "")
        {
            return UnityEngine.PlayerPrefs.GetString(key, defaultValue);
        }

    }

}