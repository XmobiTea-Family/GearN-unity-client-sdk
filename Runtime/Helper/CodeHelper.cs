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
        /// <summary>
        /// Stores the unknown code value.
        /// </summary>
        private static string unknownCode = "Unknown";

        // Dictionary to map codes to their names.
        /// <summary>
        /// Stores the code dict value.
        /// </summary>
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
    /// Provides utility methods for retrieving display names of return codes,
    /// error codes, request types, request roles, and invalid member types.
    /// </summary>
    public static class CodeHelper
    {
        /// <summary>
        /// Stores the return code helper value.
        /// </summary>
        private static CodeHelperBase returnCodeHelper;
        /// <summary>
        /// Stores the error code helper value.
        /// </summary>
        private static CodeHelperBase errorCodeHelper;
        /// <summary>
        /// Stores the request type helper value.
        /// </summary>
        private static CodeHelperBase requestTypeHelper;
        /// <summary>
        /// Stores the request role helper value.
        /// </summary>
        private static CodeHelperBase requestRoleHelper;
        /// <summary>
        /// Stores the invalid member helper value.
        /// </summary>
        private static CodeHelperBase invalidMemberHelper;

        /// <summary>
        /// Gets the name of a return code.
        /// </summary>
        /// <param name="returnCode">The return code to look up.</param>
        /// <returns>The name of the return code.</returns>
        public static string getReturnCodeName(int returnCode)
        {
            return CodeHelper.returnCodeHelper.getCodeName(returnCode);
        }

        /// <summary>
        /// Gets the name of an error code.
        /// </summary>
        /// <param name="errorCode">The error code to look up.</param>
        /// <returns>The name of the error code.</returns>
        public static string getErrorCodeName(int errorCode)
        {
            return CodeHelper.errorCodeHelper.getCodeName(errorCode);
        }

        /// <summary>
        /// Gets the wire-format name of a request type.
        /// </summary>
        public static string getRequestTypeName(int requestType)
        {
            return CodeHelper.requestTypeHelper.getCodeName(requestType);
        }

        /// <summary>
        /// Gets the wire-format name of a request role.
        /// </summary>
        public static string getRequestRoleName(int requestRole)
        {
            return CodeHelper.requestRoleHelper.getCodeName(requestRole);
        }

        /// <summary>
        /// Gets the name of an invalid member type.
        /// </summary>
        public static string getInvalidMemberName(int invalidMember)
        {
            return CodeHelper.invalidMemberHelper.getCodeName(invalidMember);
        }

        // Static constructor to initialize the helper dictionaries.
        static CodeHelper()
        {
            CodeHelper.setReturnCodeDic();
            CodeHelper.setErrorCodeDic();
            CodeHelper.setRequestTypeDic();
            CodeHelper.setRequestRoleDic();
            CodeHelper.setInvalidMemberDic();
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

        /// <summary>
        /// Sets up the error code dictionary by reflecting on the ErrorCode class.
        /// </summary>
        private static void setErrorCodeDic()
        {
            var codeDict = new Dictionary<int, string>();

            var fields = typeof(ErrorCode).GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (var field in fields)
            {
                codeDict[System.Convert.ToInt32(field.GetValue(null))] = field.Name;
            }

            CodeHelper.errorCodeHelper = new CodeHelperBase(codeDict);
        }

        /// <summary>
        /// Converts the input values to lower case.
        /// </summary>
        private static string toLowerCase(string value)
        {
            return value[0].ToString().ToLower() + value.Substring(1);
        }

        /// <summary>
        /// Sets request type dic.
        /// </summary>
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

        /// <summary>
        /// Sets request role dic.
        /// </summary>
        private static void setRequestRoleDic()
        {
            var codeDict = new Dictionary<int, string>();

            codeDict[(int)RequestRole.Admin] = CodeHelper.toLowerCase(RequestRole.Admin.ToString());
            codeDict[(int)RequestRole.Server] = CodeHelper.toLowerCase(RequestRole.Server.ToString());
            codeDict[(int)RequestRole.Client] = CodeHelper.toLowerCase(RequestRole.Client.ToString());

            CodeHelper.requestRoleHelper = new CodeHelperBase(codeDict);
        }

        /// <summary>
        /// Sets up the invalid member dictionary from the InvalidMemberType enum.
        /// </summary>
        private static void setInvalidMemberDic()
        {
            var codeDict = new Dictionary<int, string>();

            foreach (InvalidMemberType invalidMemberType in System.Enum.GetValues(typeof(InvalidMemberType)))
            {
                codeDict[(int)invalidMemberType] = CodeHelper.toLowerCase(invalidMemberType.ToString());
            }

            CodeHelper.invalidMemberHelper = new CodeHelperBase(codeDict);
        }

    }

}
