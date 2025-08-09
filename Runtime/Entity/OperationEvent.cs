namespace XmobiTea.GearN.Entity
{
    using System.Text;
    using XmobiTea.GearN.Common;

    /// <summary>
    /// Represents an operation event with a code, parameters, and encryption status.
    /// </summary>
    public class OperationEvent
    {
        private string eventCode;
        private GNHashtable parameters;

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationEvent"/> class.
        /// </summary>
        /// <param name="eventCode">The event code.</param>
        /// <param name="parameters">Optional parameters associated with the event.</param>
        public OperationEvent(string eventCode, GNHashtable parameters = null)
        {
            this.eventCode = eventCode;
            this.parameters = parameters;
        }

        /// <summary>
        /// Gets the event code.
        /// </summary>
        public string getEventCode()
        {
            return this.eventCode;
        }

        /// <summary>
        /// Gets the parameters associated with the event.
        /// </summary>
        public GNHashtable getParameters()
        {
            return this.parameters;
        }

        /// <summary>
        /// Sets a parameter for the event.
        /// </summary>
        /// <param name="key">The parameter key.</param>
        /// <param name="value">The parameter value.</param>
        /// <returns>The updated <see cref="OperationEvent"/>.</returns>
        public OperationEvent setParameter(string key, object value)
        {
            if (this.parameters == null) this.parameters = new GNHashtable();

            this.parameters.add(key, value);

            return this;
        }

        /// <summary>
        /// Sets the parameters for the event.
        /// </summary>
        /// <param name="parameters">The parameters to set.</param>
        /// <returns>The updated <see cref="OperationEvent"/>.</returns>
        public OperationEvent setParameters(GNHashtable parameters)
        {
            this.parameters = parameters;

            return this;
        }

        /// <summary>
        /// Converts the operation event to a string representation.
        /// </summary>
        /// <returns>A string describing the operation event.</returns>
        public string toString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("EventCode: " + this.eventCode + ", parameters: " + this.parameters);
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Overrides the default ToString method.
        /// </summary>
        /// <returns>A string describing the operation event.</returns>
        public override string ToString()
        {
            return this.toString();
        }
    }
}
