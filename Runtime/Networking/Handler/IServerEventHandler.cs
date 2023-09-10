namespace XmobiTea.GN.Networking
{
    using XmobiTea.GN.Entity;

    /// <summary>
    /// The interface, some class want handler event need implement IServerEventHandler
    /// </summary>
    public interface IServerEventHandler
    {
        /// <summary>
        /// Get the event code, the event code should be store in EventCode file
        /// </summary>
        /// <returns></returns>
        int getEventCode();

        /// <summary>
        /// handle function
        /// How to handle this operation
        /// </summary>
        /// <param name="operationEvent">the operation event need handle</param>
        void handle(OperationEvent operationEvent);

    }

}
