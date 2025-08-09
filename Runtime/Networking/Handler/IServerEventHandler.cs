namespace XmobiTea.GearN.Networking
{
    using XmobiTea.GearN.Entity;

    /// <summary>
    /// Defines an interface for handling server events. 
    /// Classes that implement this interface must define how to handle specific events.
    /// </summary>
    public interface IServerEventHandler
    {
        /// <summary>
        /// Gets the event code associated with the handler. 
        /// The event codes should be defined in the EventCode file.
        /// </summary>
        /// <returns>An integer representing the event code.</returns>
        string getEventCode();

        /// <summary>
        /// Handles the specified operation event.
        /// This method defines how to process the provided event.
        /// </summary>
        /// <param name="operationEvent">The operation event that needs to be handled.</param>
        void handle(OperationEvent operationEvent);
    }
}
