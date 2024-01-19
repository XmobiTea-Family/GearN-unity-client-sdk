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
        private static CodeHelperBase operationCodeHelper;
        private static CodeHelperBase eventCodeHelper;
        private static CodeHelperBase returnCodeHelper;

        /// <summary>
        /// Gets the name of an operation code.
        /// </summary>
        /// <param name="operationCode">The operation code to look up.</param>
        /// <returns>The name of the operation code.</returns>
        public static string getOperationCodeName(int operationCode)
        {
            return CodeHelper.operationCodeHelper.getCodeName(operationCode);
        }

        /// <summary>
        /// Gets the name of an event code.
        /// </summary>
        /// <param name="eventCode">The event code to look up.</param>
        /// <returns>The name of the event code.</returns>
        public static string getEventCodeName(int eventCode)
        {
            return CodeHelper.eventCodeHelper.getCodeName(eventCode);
        }

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
            CodeHelper.setOperationCodeDic();
            CodeHelper.setEventCodeDic();
            CodeHelper.setReturnCodeDic();
        }

        /// <summary>
        /// Sets up the operation code dictionary by reflecting on the OperationCode class.
        /// </summary>
        private static void setOperationCodeDic()
        {
            var codeDict = new Dictionary<int, string>();

            // Retrieve all public static fields in the OperationCode class.
            var fields = typeof(OperationCode).GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (var field in fields)
            {
                codeDict[Convert.ToInt32(field.GetValue(null))] = field.Name;
            }

            CodeHelper.operationCodeHelper = new CodeHelperBase(codeDict);
        }

        /// <summary>
        /// Sets up the event code dictionary by reflecting on the EventCode class.
        /// </summary>
        private static void setEventCodeDic()
        {
            var codeDict = new Dictionary<int, string>();

            // Retrieve all public static fields in the EventCode class.
            var fields = typeof(EventCode).GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (var field in fields)
            {
                codeDict[Convert.ToInt32(field.GetValue(null))] = field.Name;
            }

            CodeHelper.eventCodeHelper = new CodeHelperBase(codeDict);
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
