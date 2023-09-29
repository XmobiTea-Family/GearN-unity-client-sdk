namespace XmobiTea.GN.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using XmobiTea.GN.Constant;

    internal class CodeHelperBase
    {
        private static string unknownCode = "Unknown";

        private Dictionary<int, string> codeDict;

        public string getCodeName(int code)
        {
            return this.codeDict.ContainsKey(code) ? this.codeDict[code] : CodeHelperBase.unknownCode;
        }

        public CodeHelperBase(Dictionary<int, string> codeDict)
        {
            this.codeDict = codeDict;
        }
    }

    public class CodeHelper
    {
        private static CodeHelperBase operationCodeHelper;
        private static CodeHelperBase eventCodeHelper;
        private static CodeHelperBase returnCodeHelper;

        public static string getOperationCodeName(int operationCode)
        {
            return CodeHelper.operationCodeHelper.getCodeName(operationCode);
        }

        public static string getEventCodeName(int eventCode)
        {
            return CodeHelper.eventCodeHelper.getCodeName(eventCode);
        }

        public static string getReturnCodeName(int returnCode)
        {
            return CodeHelper.returnCodeHelper.getCodeName(returnCode);
        }

        static CodeHelper()
        {
            CodeHelper.setOperationCodeDic();
            CodeHelper.setEventCodeDic();
            CodeHelper.setReturnCodeDic();
        }

        private static void setOperationCodeDic()
        {
            var codeDict = new Dictionary<int, string>();

            var fields = typeof(OperationCode).GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (var field in fields)
            {
                codeDict[Convert.ToInt32(field.GetValue(null))] = field.Name;
            }

            CodeHelper.operationCodeHelper = new CodeHelperBase(codeDict);
        }

        private static void setEventCodeDic()
        {
            var codeDict = new Dictionary<int, string>();

            var fields = typeof(EventCode).GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (var field in fields)
            {
                codeDict[Convert.ToInt32(field.GetValue(null))] = field.Name;
            }

            CodeHelper.eventCodeHelper = new CodeHelperBase(codeDict);
        }

        private static void setReturnCodeDic()
        {
            var codeDict = new Dictionary<int, string>();

            var fields = typeof(ReturnCode).GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (var field in fields)
            {
                codeDict[Convert.ToInt32(field.GetValue(null))] = field.Name;
            }

            CodeHelper.returnCodeHelper = new CodeHelperBase(codeDict);
        }

    }

}