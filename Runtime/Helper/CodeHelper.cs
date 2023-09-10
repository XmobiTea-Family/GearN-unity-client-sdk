namespace XmobiTea.GN.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using XmobiTea.GN.Constant;

    public class CodeHelper
    {
        private static string unknownCode = "Unknown";

        private static Dictionary<int, string> operationCodeDic;
        private static Dictionary<int, string> eventCodeDic;
        private static Dictionary<int, string> returnCodeDic;

        public static string getOperationCodeName(int operationCode)
        {
            return CodeHelper.operationCodeDic.ContainsKey(operationCode) ? CodeHelper.operationCodeDic[operationCode] : CodeHelper.unknownCode;
        }

        public static string getEventCodeName(int eventCode)
        {
            return CodeHelper.eventCodeDic.ContainsKey(eventCode) ? CodeHelper.eventCodeDic[eventCode] : CodeHelper.unknownCode;
        }

        public static string getReturnCodeName(int returnCode)
        {
            return CodeHelper.returnCodeDic.ContainsKey(returnCode) ? CodeHelper.returnCodeDic[returnCode] : CodeHelper.unknownCode;
        }

        static CodeHelper()
        {
            setOperationCodeDic();
            setEventCodeDic();
            setReturnCodeDic();
        }

        private static void setOperationCodeDic()
        {
            CodeHelper.operationCodeDic = new Dictionary<int, string>();

            var fields = typeof(OperationCode).GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (var field in fields)
            {
                CodeHelper.operationCodeDic[Convert.ToInt32(field.GetValue(null))] = field.Name;
            }
        }

        private static void setEventCodeDic()
        {
            CodeHelper.eventCodeDic = new Dictionary<int, string>();

            var fields = typeof(EventCode).GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (var field in fields)
            {
                CodeHelper.eventCodeDic[Convert.ToInt32(field.GetValue(null))] = field.Name;
            }
        }

        private static void setReturnCodeDic()
        {
            CodeHelper.returnCodeDic = new Dictionary<int, string>();

            var fields = typeof(ReturnCode).GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (var field in fields)
            {
                CodeHelper.returnCodeDic[Convert.ToInt32(field.GetValue(null))] = field.Name;
            }
        }

    }

}