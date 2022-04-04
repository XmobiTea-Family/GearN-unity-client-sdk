#if UNITY_EDITOR
namespace XmobiTea.GN.Config.Editor
{
    using UnityEditor;
    using UnityEditor.Callbacks;

    using UnityEngine;

    using Debug = UnityEngine.Debug;

    [CustomEditor(typeof(GNServerSettings))]
    public class GNServerSettingsEditor : Editor
    {
        private const string GNServerSettings_Path = "Assets/GN-unity-client-custom/Resources";

        SerializedProperty serverAddress;
        SerializedProperty serverPort;
        SerializedProperty useSsl;
        SerializedProperty useSocket;
        SerializedProperty useHttp;
        SerializedProperty sendRate;
        SerializedProperty reconnectDelay;
        SerializedProperty pingInterval;
        SerializedProperty pingTimout;
        SerializedProperty peerSocketVersion;
        SerializedProperty codeCanSendNotAuthorized;
        
        private void OnEnable()
        {
            serverAddress = serializedObject.FindProperty("_serverAddress");
            serverPort = serializedObject.FindProperty("_serverPort");
            useSsl = serializedObject.FindProperty("_useSsl");
            useSocket = serializedObject.FindProperty("_useSocket");
            useHttp = serializedObject.FindProperty("_useHttp");
            sendRate = serializedObject.FindProperty("_sendRate");
            reconnectDelay = serializedObject.FindProperty("_reconnectDelay");
            pingInterval = serializedObject.FindProperty("_pingInterval");
            pingTimout = serializedObject.FindProperty("_pingTimeout");
            peerSocketVersion = serializedObject.FindProperty("_peerSocketVersion");
            codeCanSendNotAuthorized = serializedObject.FindProperty("_codeCanSendNotAuthorized");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(serverAddress);
            EditorGUILayout.PropertyField(serverPort);
            EditorGUILayout.PropertyField(useSsl);
            EditorGUILayout.PropertyField(useSocket);
            EditorGUILayout.PropertyField(useHttp);
            EditorGUILayout.PropertyField(sendRate);
            EditorGUILayout.PropertyField(reconnectDelay);
            EditorGUILayout.PropertyField(pingInterval);
            EditorGUILayout.PropertyField(pingTimout);
            EditorGUILayout.PropertyField(peerSocketVersion);
            EditorGUILayout.PropertyField(codeCanSendNotAuthorized);

            serializedObject.ApplyModifiedProperties();
        }

        [MenuItem("GN/GN Settings")]
        private static void OpenGNServerSettings()
        {
            var gnServerSettings = Resources.Load(GNServerSettings.ResourcesPath) as GNServerSettings;
            if (gnServerSettings == null)
            {
                if (!System.IO.Directory.Exists(GNServerSettings_Path))
                    System.IO.Directory.CreateDirectory(GNServerSettings_Path);

                gnServerSettings = ScriptableObject.CreateInstance<GNServerSettings>();
                var path = GNServerSettings_Path + "/" + GNServerSettings.ResourcesPath + ".asset";
                AssetDatabase.CreateAsset(gnServerSettings, path);

                Debug.Log(gnServerSettings + " GNServerSettings create success at path " + path);
            }

            Selection.SetActiveObjectWithContext(gnServerSettings, gnServerSettings);
        }

        [MenuItem("GN/About GN")]
        private static void AboutEUNfox()
        {
            Application.OpenURL("https://youngmonkeys.org/ezyfox-sever/");
        }

        [MenuItem("GN/Go to GN-server")]
        private static void GotoGNserver()
        {
            Application.OpenURL("https://github.com/XmobiTea-Family/GN-server");
        }

        //[MenuItem("GN/About")]
        //private static void OpenAbout()
        //{
        //    EditorWindow.GetWindow(typeof(AboutEUNEditorWindow));
        //}

        [DidReloadScripts]
        public static void OnCompileScripts()
        {
            UpdateGN();
        }

        private static void UpdateGN()
        {
            //var assemblie = typeof(GNServerSettings).Assembly;

            //var types = assemblie.GetTypes();

            //var methodNameLst = new List<string>();

            //var dic = new Dictionary<int, string>();

            //foreach (var type in types)
            //{
            //    var methodInfos = type.GetMethods(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public).Where(x => x.GetCustomAttributes(typeof(EUNRPCAttribute), false).Length > 0);

            //    foreach (var methodInfo in methodInfos)
            //    {
            //        if (!methodNameLst.Contains(methodInfo.Name)) methodNameLst.Add(methodInfo.Name);
            //    }
            //}

            //var needModifier = false;

            //var eunRPCCommandValues = Enum.GetValues(typeof(EUNRPCCommand));

            //foreach (EUNRPCCommand eunRPCCommandValue in eunRPCCommandValues)
            //{
            //    if (methodNameLst.Contains(eunRPCCommandValue.ToString())) dic.Add((int)eunRPCCommandValue, eunRPCCommandValue.ToString());
            //    else if (!needModifier) needModifier = true;
            //}

            //foreach (var methodName in methodNameLst)
            //{
            //    var dicValues = dic.Values.ToList();

            //    if (!dicValues.Contains(methodName))
            //    {
            //        var dicKeys = dic.Keys.ToList();

            //        var key = dicKeys.Max() + 1;

            //        dic.Add(key, methodName);

            //        if (!needModifier) needModifier = true;
            //    }
            //}

            //if (needModifier)
            //{
            //    var enableStringBuilder = new StringBuilder();
            //    var disableStringBuilder = new StringBuilder();

            //    enableStringBuilder.AppendLine("#if EUN");
            //    disableStringBuilder.AppendLine("#if !EUN");

            //    enableStringBuilder.AppendLine("// dont modifier this, this file will auto generate by EUN");
            //    disableStringBuilder.AppendLine("// dont modifier this, this file will auto generate by EUN");

            //    enableStringBuilder.AppendLine("public enum EUNRPCCommand");
            //    disableStringBuilder.AppendLine("public enum EUNRPCCommand");

            //    enableStringBuilder.AppendLine("{");
            //    disableStringBuilder.AppendLine("{");

            //    foreach (var c in dic)
            //    {
            //        enableStringBuilder.AppendLine("    " + c.Value + " = " + c.Key + ",");
            //        disableStringBuilder.AppendLine("    " + c.Value + " = " + c.Key + ",");

            //        Debug.Log("EUNRPCCommand add " + c.Value + " = " + c.Key);
            //    }

            //    enableStringBuilder.AppendLine("}");
            //    disableStringBuilder.AppendLine("}");

            //    enableStringBuilder.AppendLine("#endif");
            //    disableStringBuilder.AppendLine("#endif");

            //    var dirPath = Application.dataPath + EUNRPC_Parent_Path;
            //    if (!System.IO.Directory.Exists(dirPath)) System.IO.Directory.CreateDirectory(dirPath);

            //    // generate this file
            //    var enableFilePath = Application.dataPath + EUNRPC_Path;
            //    var disableFilePath = Application.dataPath + EUNRPC_Disable_Path;

            //    if (System.IO.File.Exists(enableFilePath)) System.IO.File.Delete(enableFilePath);

            //    System.IO.File.WriteAllText(enableFilePath, enableStringBuilder.ToString());
            //    System.IO.File.WriteAllText(disableFilePath, disableStringBuilder.ToString());

            //    UnityEditor.AssetDatabase.Refresh();
            //}
        }
    }
}
#endif