namespace XmobiTea.GN.Logger
{
    using System;

    /// <summary>
    /// Enum defining different log levels for GNDebug.
    /// </summary>
    public enum LogType
    {
        /// <summary>
        /// No logging.
        /// </summary>
        Off,

        /// <summary>
        /// Logs exceptions only.
        /// </summary>
        Exception,

        /// <summary>
        /// Logs errors and exceptions.
        /// </summary>
        Error,

        /// <summary>
        /// Logs warnings, errors, and exceptions.
        /// </summary>
        Warning,

        /// <summary>
        /// Logs all messages, including general logs, warnings, errors, and exceptions.
        /// </summary>
        All,
    }

    /// <summary>
    /// Utility class for handling logging in the GN framework.
    /// </summary>
    internal class GNDebug
    {
        private static LogType _logType; // Current log level.

        /// <summary>
        /// Gets or sets the current log level for GNDebug.
        /// </summary>
        public static LogType logType
        {
            get => _logType;
            set => _logType = value;
        }

        /// <summary>
        /// Logs a general message if the log level includes general logs.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public static void log(object message)
        {
            if (_logType >= LogType.All)
                UnityEngine.Debug.Log(message);
        }

        /// <summary>
        /// Logs an exception if the log level includes exceptions.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        public static void logException(Exception exception)
        {
            if (_logType >= LogType.Exception)
                UnityEngine.Debug.LogException(exception);
        }

        /// <summary>
        /// Logs a warning message if the log level includes warnings.
        /// </summary>
        /// <param name="message">The warning message to log.</param>
        public static void logWarning(object message)
        {
            if (_logType >= LogType.Warning)
                UnityEngine.Debug.LogWarning(message);
        }

        /// <summary>
        /// Logs an error message if the log level includes errors.
        /// </summary>
        /// <param name="message">The error message to log.</param>
        public static void logError(object message)
        {
            if (_logType >= LogType.Error)
                UnityEngine.Debug.LogError(message);
        }
    }
}
