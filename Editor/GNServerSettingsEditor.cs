namespace XmobiTea.GearN.Editor
{
    using System.IO;

    using UnityEditor;

    using UnityEngine;
    using XmobiTea.GearN.Config;
    using Debug = UnityEngine.Debug;

    /// <summary>
    /// Renders the custom inspector and menu entries for the GearN server settings asset.
    /// </summary>
    [CustomEditor(typeof(GNServerSettings))]
    public class GNServerSettingsEditor : Editor
    {
        SerializedProperty serverAddress;
        SerializedProperty serverPort;
        SerializedProperty serverSocketPort;
        SerializedProperty useSsl;
        SerializedProperty useSocket;
        SerializedProperty useHttp;
        SerializedProperty defaultTimeoutInSeconds;
        SerializedProperty messageType;
        SerializedProperty sendRate;
        SerializedProperty reconnectDelay;
        SerializedProperty pingInterval;
        SerializedProperty pingTimout;
        SerializedProperty peerSocketVersion;
        SerializedProperty httpRequestType;
        SerializedProperty logType;
        SerializedProperty adminSecretKey;
        SerializedProperty serverSecretKey;
        SerializedProperty clientSecretKey;

        Color m_Color = Color.white;

        /// <summary>
        /// Caches the serialized settings properties used by the custom inspector.
        /// </summary>
        private void OnEnable()
        {
            this.serverAddress = this.serializedObject.FindProperty("serverAddress");
            this.serverPort = this.serializedObject.FindProperty("serverPort");
            this.serverSocketPort = this.serializedObject.FindProperty("serverSocketPort");
            this.useSsl = this.serializedObject.FindProperty("useSsl");
            this.useSocket = this.serializedObject.FindProperty("useSocket");
            this.useHttp = this.serializedObject.FindProperty("useHttp");
            this.defaultTimeoutInSeconds = this.serializedObject.FindProperty("defaultTimeoutInSeconds");
            this.messageType = this.serializedObject.FindProperty("messageType");
            this.sendRate = this.serializedObject.FindProperty("sendRate");
            this.reconnectDelay = this.serializedObject.FindProperty("reconnectDelay");
            this.pingInterval = this.serializedObject.FindProperty("pingInterval");
            this.pingTimout = this.serializedObject.FindProperty("pingTimeout");
            this.peerSocketVersion = this.serializedObject.FindProperty("peerSocketVersion");
            this.httpRequestType = this.serializedObject.FindProperty("httpRequestType");
            this.logType = this.serializedObject.FindProperty("logType");
            this.adminSecretKey = this.serializedObject.FindProperty("adminSecretKey");
            this.serverSecretKey = this.serializedObject.FindProperty("serverSecretKey");
            this.clientSecretKey = this.serializedObject.FindProperty("clientSecretKey");
        }

        /// <summary>
        /// Draws the custom inspector for the GearN server settings asset.
        /// </summary>
        public override void OnInspectorGUI()
        {
            this.serializedObject.Update();

            EditorGUILayout.LabelField($"GearN Unity Client SDK Version v{GNNetwork.getClientSdkVersion()}");
            EditorGUILayout.Space(20);

            EditorGUILayout.PropertyField(this.serverAddress);
            EditorGUILayout.PropertyField(this.serverPort);
            EditorGUILayout.Space(5);
            EditorGUILayout.PropertyField(this.useSsl);
            EditorGUILayout.PropertyField(this.sendRate);
            EditorGUILayout.PropertyField(this.defaultTimeoutInSeconds);
            EditorGUILayout.PropertyField(this.messageType);
            EditorGUILayout.Space(10);

            EditorGUILayout.PropertyField(this.useHttp);
            if (this.useHttp.boolValue)
            {
                EditorGUILayout.PropertyField(this.httpRequestType);
            }

            EditorGUILayout.Space(10);

            EditorGUILayout.PropertyField(this.useSocket);

            if (this.useSocket.boolValue)
            {
                EditorGUILayout.PropertyField(this.serverSocketPort);
                EditorGUILayout.Space(5);

#if UNITY_USING_BEST_HTTP
                EditorGUILayout.PropertyField(this.reconnectDelay);
                EditorGUILayout.PropertyField(this.pingInterval);
                EditorGUILayout.PropertyField(this.pingTimout);
                EditorGUILayout.PropertyField(this.peerSocketVersion);
#else
                EditorGUILayout.LabelField("GearN Unity Client current only support BEST_HTTP/2 or SocketIOUnity to handle socket");
                EditorGUILayout.LabelField("You must import BEST_HTTP/2 or SocketIOUnity package");
                EditorGUILayout.LabelField("\tand define UNITY_USING_BEST_HTTP if using BEST_HTTP/2 (or define UNITY_USING_SOCKET_IO_UNITY if using SocketIOUnity) on Project Settings/Player");
                EditorGUILayout.LabelField("\t\t-> Scripting Define Symbols");
#endif
            }

            EditorGUILayout.Space(20);

            EditorGUILayout.PropertyField(this.logType);

            EditorGUILayout.Space(20);
            EditorGUILayout.PropertyField(this.adminSecretKey);
            EditorGUILayout.PropertyField(this.serverSecretKey);
            EditorGUILayout.PropertyField(this.clientSecretKey);

            if (this.serializedObject.hasModifiedProperties) this.serializedObject.ApplyModifiedProperties();
        }

        /// <summary>
        /// Opens the GearN server settings asset in the Unity editor.
        /// </summary>
        [MenuItem("XmobiTea GearN/Open Settings")]
        private static void OpenGNServerSettings()
        {
            var gnServerSettings = GetSettings();

            Selection.SetActiveObjectWithContext(gnServerSettings, gnServerSettings);
        }

        /// <summary>
        /// Loads or creates the GearN server settings asset used by the SDK.
        /// </summary>
        public static GNServerSettings GetSettings()
        {
            var gnServerSettings = Resources.Load<GNServerSettings>(GNServerSettings.ResourcesPath);
            if (gnServerSettings == null)
            {
                gnServerSettings = ScriptableObject.CreateInstance<GNServerSettings>();

                var dirPath = Application.dataPath + "/Resources";
                if (!Directory.Exists(dirPath)) Directory.CreateDirectory(dirPath);

                var path = "Assets/Resources/" + GNServerSettings.ResourcesPath + ".asset";
                AssetDatabase.CreateAsset(gnServerSettings, path);

                Debug.Log("[GN] Build Settings create success at path " + path);
            }

            return gnServerSettings;
        }

        /// <summary>
        /// Opens the GearN website.
        /// </summary>
        [MenuItem("XmobiTea GearN/About")]
        private static void AboutGN()
        {
            Application.OpenURL("https://gearn.net");
        }

        /// <summary>
        /// Opens the GearN documentation website.
        /// </summary>
        [MenuItem("XmobiTea GearN/Documentation")]
        private static void DocsGearN()
        {
            Application.OpenURL("https://docs.gearn.net");
        }

        /// <summary>
        /// Opens the GearN server repository page.
        /// </summary>
        [MenuItem("XmobiTea GearN/Go to github")]
        private static void GotoGNserver()
        {
            Application.OpenURL("https://github.com/XmobiTea-Family/GearN-server");
        }
    }
}