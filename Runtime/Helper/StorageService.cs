namespace XmobiTea.GearN.Helper
{
    public class StorageService
    {
        public static void setString(string key, string value)
        {
            UnityEngine.PlayerPrefs.SetString(key, value);
        }

        public static string getString(string key, string defaultValue = "")
        {
            return UnityEngine.PlayerPrefs.GetString(key, defaultValue);
        }

    }

}
