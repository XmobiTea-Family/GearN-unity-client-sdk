namespace XmobiTea.GN.Editor
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    using UnityEditor;

    using UnityEngine;
    using XmobiTea.GN.Config;
    using XmobiTea.GN.Constant;
    using Debug = UnityEngine.Debug;

    [CustomEditor(typeof(GNServerSettings))]
    public class GNServerSettingsEditor : Editor
    {
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
        SerializedProperty gnServerSourcePath;
        SerializedProperty httpRequestType;
        SerializedProperty logType;
        SerializedProperty adminSecretKey;
        SerializedProperty serverSecretKey;
        SerializedProperty clientSecretKey;

        private Dictionary<int, string> operationCodeFieldDict;

        Color m_Color = Color.white;

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
            gnServerSourcePath = serializedObject.FindProperty("_gnServerSourcePath");
            httpRequestType = serializedObject.FindProperty("_httpRequestType");
            //postType = serializedObject.FindProperty("_postType");
            logType = serializedObject.FindProperty("_logType");
            adminSecretKey = serializedObject.FindProperty("_adminSecretKey");
            serverSecretKey = serializedObject.FindProperty("_serverSecretKey");
            clientSecretKey = serializedObject.FindProperty("_clientSecretKey");

            var fields = typeof(OperationCode).GetFields();

            if (operationCodeFieldDict == null) operationCodeFieldDict = new Dictionary<int, string>();
            else operationCodeFieldDict.Clear();

            for (var i = 0; i < fields.Length; i++)
            {
                var field = fields[i];

                operationCodeFieldDict[(int)field.GetValue(null)] = field.Name;
            }
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.LabelField($"GN Unity Client SDK Version v{GNNetwork.GetClientSdkVersion()}");
            EditorGUILayout.Space(20);

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
            EditorGUILayout.Space(20);

            EditorGUILayout.BeginVertical();
            EditorGUILayout.LabelField($"Code Can Send Not Authorized size is {codeCanSendNotAuthorized.arraySize}");

            //scrollPosition = GUILayout.BeginScrollView(scrollPosition);


            for (var i = 0; i < codeCanSendNotAuthorized.arraySize; i++)
            {
                var serializedProperty = codeCanSendNotAuthorized.GetArrayElementAtIndex(i);
                
                var operationCodeName = string.Empty;

                if (operationCodeFieldDict.ContainsKey(serializedProperty.intValue)) operationCodeName = $"({serializedProperty.intValue}) {operationCodeFieldDict[serializedProperty.intValue]}";
                else operationCodeName = "Choose an operation code";

                EditorGUILayout.BeginHorizontal();

                if (EditorGUILayout.DropdownButton(new GUIContent(operationCodeName), FocusType.Passive))
                {
                    var operationCodeMenu = new GenericMenu();
                    operationCodeMenu.AddItem(new GUIContent("None"), !operationCodeFieldDict.ContainsKey(serializedProperty.intValue), id =>
                    {
                        serializedProperty.intValue = (int)id;
                        if (serializedObject.hasModifiedProperties) serializedObject.ApplyModifiedProperties();
                    }, int.MinValue);
                    operationCodeMenu.AddSeparator("");

                    foreach (var c in operationCodeFieldDict)
                    {
                        operationCodeMenu.AddItem(new GUIContent($"({c.Key}) {c.Value}"), serializedProperty.intValue == c.Key, id =>
                        {
                            serializedProperty.intValue = (int)id;
                            if (serializedObject.hasModifiedProperties) serializedObject.ApplyModifiedProperties();
                        }, c.Key);
                    }

                    operationCodeMenu.ShowAsContext();
                }

                if (GUILayout.Button("-", GUILayout.MaxWidth(50)))
                {
                    codeCanSendNotAuthorized.DeleteArrayElementAtIndex(i);
                }

                EditorGUILayout.EndHorizontal();
            }

            if (GUILayout.Button("+"))
            {
                codeCanSendNotAuthorized.arraySize += 1;
            }

            EditorGUILayout.EndVertical();
            EditorGUILayout.Space(20);

            EditorGUILayout.PropertyField(gnServerSourcePath);
            EditorGUILayout.PropertyField(httpRequestType);
            //EditorGUILayout.PropertyField(postType);
            EditorGUILayout.PropertyField(logType);

            EditorGUILayout.Space(20);
            EditorGUILayout.PropertyField(adminSecretKey);
            EditorGUILayout.PropertyField(serverSecretKey);
            EditorGUILayout.PropertyField(clientSecretKey);

            if (serializedObject.hasModifiedProperties) serializedObject.ApplyModifiedProperties();
        }

        [MenuItem("XmobiTea GN/Open Settings")]
        private static void OpenGNServerSettings()
        {
            var gnServerSettings = GetSettings();

            Selection.SetActiveObjectWithContext(gnServerSettings, gnServerSettings);
        }

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

        [MenuItem("XmobiTea GN/About GN")]
        private static void AboutGN()
        {
            Application.OpenURL("https://gn.xmobitea.com");
        }

        [MenuItem("XmobiTea GN/Go to GN-server")]
        private static void GotoGNserver()
        {
            Application.OpenURL("https://github.com/XmobiTea-Family/GN-server");
        }

        [MenuItem("XmobiTea GN/Sync Server Folder")]
        private static void SyncServerFolder()
        {
            Debug.Log("Sync Server Folder");

            SyncConstantFolder();
            SyncEnumTypeFolder();
            SyncParameterCodeFolder();
            SyncErrorCodeFolder();

            AssetDatabase.Refresh();
        }

        private static void SyncEnumTypeFolder()
        {
            var gnServerSettings = GetSettings();
            var dir = Application.dataPath + "/../../" + gnServerSettings.gnServerSourcePath + "/src/common/constant/enumType";

            var allPathFiles = Directory.GetFiles(dir, "*.ts");
            for (var i = 0; i < allPathFiles.Length; i++)
            {
                GenerateEnumTypeFile(allPathFiles[i]);
            }
        }

        private static void GenerateEnumTypeFile(string dirPath)
        {
            const string Template = "$name = $code,";

            var fileInfo = new FileInfo(dirPath);
            
            var allLines = File.ReadAllLines(dirPath);

            var fileName = fileInfo.Name.Replace(".ts", string.Empty);

            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("// The file auto generate, please dont change it");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("namespace XmobiTea.GN.Constant");
            stringBuilder.AppendLine("{");
            stringBuilder.AppendLine("    public enum " + fileName);
            stringBuilder.AppendLine("    {");
            // Value0 = 0,
            for (var i = 0; i < allLines.Length; i++)
            {
                var line = allLines[i].Trim();
                if (string.IsNullOrEmpty(line)) continue;
                if (line.Contains("import")) continue;
                if (line.Contains("export class")) continue;
                if (line.Contains("export enum")) continue;
                if (line.Contains("{")) continue;
                if (line.Contains("}")) continue;
                if (line.Contains("//")) continue;

                var lineSpl0s = line.Split(',');
                var lineSpl01s = lineSpl0s[0].Split('=');

                var code = lineSpl01s[1].Trim();
                var name = lineSpl01s[0].Trim();

                stringBuilder.AppendLine("        " + Template.Replace("$name", name).Replace("$code", code));
            }

            stringBuilder.AppendLine("    }");
            stringBuilder.AppendLine("}");

            WriteFile(fileName + ".cs", Application.dataPath + "/XmobiTea-constance/GN/Scripts/Constant/EnumType", stringBuilder);
        }

        private static void SyncParameterCodeFolder()
        {
            var gnServerSettings = GetSettings();
            var dir = Application.dataPath + "/../../" + gnServerSettings.gnServerSourcePath + "/src/common/constant/parameterCode";

            var allPathFiles = Directory.GetFiles(dir, "*.ts");
            for (var i = 0; i < allPathFiles.Length; i++)
            {
                GenerateParameterCodeFile(allPathFiles[i]);
            }
        }

        private static void GenerateParameterCodeFile(string dirPath)
        {
            const string Template = "public const string $name = $code;";

            var fileInfo = new FileInfo(dirPath);

            var allLines = File.ReadAllLines(dirPath);

            var fileName = fileInfo.Name.Replace(".ts", string.Empty);

            if (fileName.Contains(".ext"))
            {
                fileName = fileName.Replace(".ext", string.Empty);
            }

            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("// The file auto generate, please dont change it");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("namespace XmobiTea.GN.Constant");
            stringBuilder.AppendLine("{");
            stringBuilder.AppendLine("    public partial class " + fileName);
            stringBuilder.AppendLine("    {");
            // Value0 = 0,
            for (var i = 0; i < allLines.Length; i++)
            {
                var line = allLines[i].Trim();
                if (string.IsNullOrEmpty(line)) continue;
                if (line.Contains("import")) continue;
                if (line.Contains("export class")) continue;
                if (line.Contains("export enum")) continue;
                if (line.Contains("{")) continue;
                if (line.Contains("}")) continue;
                if (line.Contains("//")) continue;

                var lineSpl0s = line.Split('=');
                var lineSpl01s = lineSpl0s[0].Split(' ');
                var lineSpl013s = lineSpl01s[3].Split(':');

                var code = lineSpl0s[1].Split(';')[0].Trim();
                var name = lineSpl013s[0];

                stringBuilder.AppendLine("        " + Template.Replace("$name", name).Replace("$code", code));
            }

            stringBuilder.AppendLine("    }");
            stringBuilder.AppendLine("}");

            WriteFile(fileName + ".cs", Application.dataPath + "/XmobiTea-constance/GN/Scripts/Constant/ParameterCode", stringBuilder);
        }

        private static void SyncErrorCodeFolder()
        {
            var gnServerSettings = GetSettings();
            var dir = Application.dataPath + "/../../" + gnServerSettings.gnServerSourcePath + "/src/common/constant/errorCode";

            var allPathFiles = Directory.GetFiles(dir, "*.ts");
            for (var i = 0; i < allPathFiles.Length; i++)
            {
                GenerateErrorCodeFile(allPathFiles[i]);
            }
        }

        private static void GenerateErrorCodeFile(string dirPath)
        {
            const string Template = "public const int $name = $code;";

            var fileInfo = new FileInfo(dirPath);

            var allLines = File.ReadAllLines(dirPath);

            var fileName = fileInfo.Name.Replace(".ts", string.Empty);

            if (fileName.Contains(".ext"))
            {
                fileName = fileName.Replace(".ext", string.Empty);
            }

            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("// The file auto generate, please dont change it");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("namespace XmobiTea.GN.Constant");
            stringBuilder.AppendLine("{");
            stringBuilder.AppendLine("    public partial class " + fileName);
            stringBuilder.AppendLine("    {");
            // Value0 = 0,
            for (var i = 0; i < allLines.Length; i++)
            {
                var line = allLines[i].Trim();
                if (string.IsNullOrEmpty(line)) continue;
                if (line.Contains("import")) continue;
                if (line.Contains("export class")) continue;
                if (line.Contains("export enum")) continue;
                if (line.Contains("{")) continue;
                if (line.Contains("}")) continue;
                if (line.Contains("//")) continue;

                var lineSpl0s = line.Split('=');
                var lineSpl01s = lineSpl0s[0].Split(' ');
                var lineSpl013s = lineSpl01s[3].Split(':');

                var code = lineSpl0s[1].Split(';')[0].Trim();
                var name = lineSpl013s[0];

                stringBuilder.AppendLine("        " + Template.Replace("$name", name).Replace("$code", code));
            }

            stringBuilder.AppendLine("    }");
            stringBuilder.AppendLine("}");

            WriteFile(fileName + ".cs", Application.dataPath + "/XmobiTea-constance/GN/Scripts/Constant/ErrorCode", stringBuilder);
        }

        private static void SyncConstantFolder()
        {
            GenerateOperationCode();
            GenerateEventCode();
        }

        private static void GenerateOperationCode()
        {
            const string Template = "public const int $name = $code;";

            var gnServerSettings = GetSettings();
            var dirPath = Application.dataPath + "/../../" + gnServerSettings.gnServerSourcePath + "/src/common/constant/OperationCode.ext.ts";
            var allLines = File.ReadAllLines(dirPath);

            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("// The file auto generate, please dont change it");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("namespace XmobiTea.GN.Constant");
            stringBuilder.AppendLine("{");
            stringBuilder.AppendLine("    public partial class OperationCode");
            stringBuilder.AppendLine("    {");

            for (var i = 0; i < allLines.Length; i++)
            {
                var line = allLines[i].Trim();
                if (string.IsNullOrEmpty(line)) continue;
                if (line.Contains("import")) continue;
                if (line.Contains("export class")) continue;
                if (line.Contains("export enum")) continue;
                if (line.Contains("{")) continue;
                if (line.Contains("}")) continue;
                if (line.Contains("//")) continue;

                var lineSpl0s = line.Split('=');
                var lineSpl01s = lineSpl0s[0].Split(' ');
                var lineSpl013s = lineSpl01s[3].Split(':');

                var code = lineSpl0s[1].Split(';')[0].Trim();
                var name = lineSpl013s[0];

                stringBuilder.AppendLine("        " + Template.Replace("$name", name).Replace("$code", code));
            }

            stringBuilder.AppendLine("    }");
            stringBuilder.AppendLine("}");
            WriteFile("OperationCode.cs", Application.dataPath + "/XmobiTea-constance/GN/Scripts/Constant", stringBuilder);
        }

        private static void GenerateEventCode()
        {
            const string Template = "public const int $name = $code;";

            var gnServerSettings = GetSettings();
            var dirPath = Application.dataPath + "/../../" + gnServerSettings.gnServerSourcePath + "/src/common/constant/EventCode.ext.ts";
            var allLines = File.ReadAllLines(dirPath);

            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("// The file auto generate, please dont change it");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("namespace XmobiTea.GN.Constant");
            stringBuilder.AppendLine("{");
            stringBuilder.AppendLine("    public partial class EventCode");
            stringBuilder.AppendLine("    {");

            for (var i = 0; i < allLines.Length; i++)
            {
                var line = allLines[i].Trim();
                if (string.IsNullOrEmpty(line)) continue;
                if (line.Contains("import")) continue;
                if (line.Contains("export class")) continue;
                if (line.Contains("export enum")) continue;
                if (line.Contains("{")) continue;
                if (line.Contains("}")) continue;
                if (line.Contains("//")) continue;

                var lineSpl0s = line.Split('=');
                var lineSpl01s = lineSpl0s[0].Split(' ');
                var lineSpl013s = lineSpl01s[3].Split(':');

                var code = lineSpl0s[1].Split(';')[0].Trim();
                var name = lineSpl013s[0];

                stringBuilder.AppendLine("        " + Template.Replace("$name", name).Replace("$code", code));
            }

            stringBuilder.AppendLine("    }");
            stringBuilder.AppendLine("}");
            WriteFile("EventCode.cs", Application.dataPath + "/XmobiTea-constance/GN/Scripts/Constant", stringBuilder);
        }

        private static void WriteFile(string fileNameWithExtension, string dirPath, StringBuilder contentBuilder)
        {
            if (!Directory.Exists(dirPath)) Directory.CreateDirectory(dirPath);
            var filePath = Path.Combine(dirPath, fileNameWithExtension);

            if (File.Exists(filePath)) File.Delete(filePath);
            File.WriteAllText(filePath, contentBuilder.ToString());

            Debug.Log("Create file path " + fileNameWithExtension + " at " + filePath + " success.");
        }
    }
}
