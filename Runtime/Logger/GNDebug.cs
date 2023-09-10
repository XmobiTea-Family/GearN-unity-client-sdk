namespace XmobiTea.GN.Logger
{
    using System;

    public enum LogType
    {
        Off,
        Exception,
        Error,
        Warning,
        All,
    }

    internal class GNDebug
    {
        private static LogType _logType;
        public static LogType logType
        {
            get => _logType;
            set => _logType = value;
        }

        public static void log(object message)
        {
            if (_logType >= LogType.All)
                UnityEngine.Debug.Log(message);
        }

        public static void logException(Exception exception)
        {
            if (_logType >= LogType.Exception)
                UnityEngine.Debug.LogException(exception);
        }

        public static void logWarning(object message)
        {
            if (_logType >= LogType.Warning)
                UnityEngine.Debug.LogWarning(message);
        }

        public static void logError(object message)
        {
            if (_logType >= LogType.Error)
                UnityEngine.Debug.LogError(message);
        }

    }

}
