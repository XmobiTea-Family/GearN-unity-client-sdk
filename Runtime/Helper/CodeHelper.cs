namespace XmobiTea.GearN.Helper
{
    using System.Collections.Generic;
    using System.Reflection;

    using XmobiTea.GearN.Constant;

    /// <summary>
    /// Base class for managing code-to-name mappings.
    /// </summary>
    internal class CodeHelperBase
    {
        private static string unknownCode = "Unknown";

        // Dictionary to map codes to their names.
        private Dictionary<int, string> codeDict;

        /// <summary>
        /// Retrieves the name associated with a code.
        /// </summary>
        /// <param name="code">The code to look up.</param>
        /// <returns>The name associated with the code or "Unknown" if not found.</returns>
        public string getCodeName(int code)
        {
            return this.codeDict.ContainsKey(code) ? this.codeDict[code] : (CodeHelperBase.unknownCode + " (" + code + ")");
        }

        /// <summary>
        /// Constructor to initialize the code dictionary.
        /// </summary>
        /// <param name="codeDict">The dictionary mapping codes to names.</param>
        public CodeHelperBase(Dictionary<int, string> codeDict)
        {
            this.codeDict = codeDict;
        }
    }

    /// <summary>
    /// Provides utility methods for retrieving names of operation, event, and return codes.
    /// </summary>
    public static class CodeHelper
    {
        private static CodeHelperBase returnCodeHelper;
        private static CodeHelperBase requestTypeHelper;
        private static CodeHelperBase requestRoleHelper;

        /// <summary>
        /// Gets the name of a return code.
        /// </summary>
        /// <param name="returnCode">The return code to look up.</param>
        /// <returns>The name of the return code.</returns>
        public static string getReturnCodeName(int returnCode)
        {
            return CodeHelper.returnCodeHelper.getCodeName(returnCode);
        }

        public static string getRequestTypeName(int requestType)
        {
            return CodeHelper.requestTypeHelper.getCodeName(requestType);
        }

        public static string getRequestRoleName(int requestRole)
        {
            return CodeHelper.requestRoleHelper.getCodeName(requestRole);
        }

        // Static constructor to initialize the helper dictionaries.
        static CodeHelper()
        {
            CodeHelper.setReturnCodeDic();
            CodeHelper.setRequestTypeDic();
            CodeHelper.setRequestRoleDic();
        }

        /// <summary>
        /// Sets up the return code dictionary by reflecting on the ReturnCode class.
        /// </summary>
        private static void setReturnCodeDic()
        {
            var codeDict = new Dictionary<int, string>();

            // Retrieve all public static fields in the ReturnCode class.
            var fields = typeof(ReturnCode).GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (var field in fields)
            {
                codeDict[System.Convert.ToInt32(field.GetValue(null))] = field.Name;
            }

            CodeHelper.returnCodeHelper = new CodeHelperBase(codeDict);
        }

        private static string toLowerCase(string value)
        {
            return value[0].ToString().ToLower() + value.Substring(1);
        }

        private static void setRequestTypeDic()
        {
            var codeDict = new Dictionary<int, string>();

            codeDict[(int)RequestType.Custom] = CodeHelper.toLowerCase(RequestType.Custom.ToString());
            codeDict[(int)RequestType.Authenticate] = CodeHelper.toLowerCase(RequestType.Authenticate.ToString());
            codeDict[(int)RequestType.CharacterPlayer] = CodeHelper.toLowerCase(RequestType.CharacterPlayer.ToString());
            codeDict[(int)RequestType.Content] = CodeHelper.toLowerCase(RequestType.Content.ToString());
            codeDict[(int)RequestType.GamePlayer] = CodeHelper.toLowerCase(RequestType.GamePlayer.ToString());
            codeDict[(int)RequestType.Group] = CodeHelper.toLowerCase(RequestType.Group.ToString());
            codeDict[(int)RequestType.Inventory] = CodeHelper.toLowerCase(RequestType.Inventory.ToString());
            codeDict[(int)RequestType.MasterPlayer] = CodeHelper.toLowerCase(RequestType.MasterPlayer.ToString());
            codeDict[(int)RequestType.StoreInventory] = CodeHelper.toLowerCase(RequestType.StoreInventory.ToString());
            codeDict[(int)RequestType.Multiplayer] = CodeHelper.toLowerCase(RequestType.Multiplayer.ToString());
            codeDict[(int)RequestType.CloudScript] = CodeHelper.toLowerCase(RequestType.CloudScript.ToString());

            CodeHelper.requestTypeHelper = new CodeHelperBase(codeDict);
        }

        private static void setRequestRoleDic()
        {
            var codeDict = new Dictionary<int, string>();

            codeDict[(int)RequestRole.Admin] = CodeHelper.toLowerCase(RequestRole.Admin.ToString());
            codeDict[(int)RequestRole.Server] = CodeHelper.toLowerCase(RequestRole.Server.ToString());
            codeDict[(int)RequestRole.Client] = CodeHelper.toLowerCase(RequestRole.Client.ToString());

            CodeHelper.requestRoleHelper = new CodeHelperBase(codeDict);
        }

    }

}
