namespace XmobiTea.GN.Entity
{
    using System.Text;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Helper;

    /// <summary>
    /// Represents an operation event with a code, parameters, and encryption status.
    /// </summary>
    public class OperationEvent
    {
        private int eventCode;
        private GNHashtable parameters;
        private bool encrypted;

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationEvent"/> class.
        /// </summary>
        /// <param name="eventCode">The event code.</param>
        /// <param name="parameters">Optional parameters associated with the event.</param>
        /// <param name="encrypted">Whether the event is encrypted.</param>
        public OperationEvent(int eventCode, GNHashtable parameters = null, bool encrypted = true)
        {
            this.eventCode = eventCode;
            this.parameters = parameters;
            this.encrypted = encrypted;
        }

        /// <summary>
        /// Gets the event code.
        /// </summary>
        public int getEventCode()
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
        /// Determines if the event is encrypted.
        /// </summary>
        public bool isEncrypted()
        {
            return this.encrypted;
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
        /// Sets the encryption status of the event.
        /// </summary>
        /// <param name="encrypted">Whether the event is encrypted.</param>
        /// <returns>The updated <see cref="OperationEvent"/>.</returns>
        public OperationEvent setEncrypted(bool encrypted)
        {
            this.encrypted = encrypted;
            return this;
        }

        /// <summary>
        /// Converts the operation event to a string representation.
        /// </summary>
        /// <returns>A string describing the operation event.</returns>
        public string toString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("Code: " + CodeHelper.getEventCodeName(this.eventCode) + ", parameters: " + this.parameters + ", encrypted: " + this.encrypted);
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
