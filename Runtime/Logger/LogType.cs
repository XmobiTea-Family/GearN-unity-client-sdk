namespace XmobiTea.GearN.Logger
{
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

}
