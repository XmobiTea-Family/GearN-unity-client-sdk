namespace XmobiTea.GN.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using XmobiTea.GN.Constant;

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

        /// <summary>
        /// Gets the name of a return code.
        /// </summary>
        /// <param name="returnCode">The return code to look up.</param>
        /// <returns>The name of the return code.</returns>
        public static string getReturnCodeName(int returnCode)
        {
            return CodeHelper.returnCodeHelper.getCodeName(returnCode);
        }

        // Static constructor to initialize the helper dictionaries.
        static CodeHelper()
        {
            CodeHelper.setReturnCodeDic();
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
                codeDict[Convert.ToInt32(field.GetValue(null))] = field.Name;
            }

            CodeHelper.returnCodeHelper = new CodeHelperBase(codeDict);
        }
    }
}
