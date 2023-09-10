namespace XmobiTea.GN.Entity
{
    using System.Text;

    using XmobiTea.GN.Common;
    using XmobiTea.GN.Helper;

    public class OperationEvent
    {

        private int eventCode;
        private GNHashtable parameters;
        private bool encrypted;

        public OperationEvent(int eventCode, GNHashtable parameters = null, bool encrypted = true)
        {
            this.eventCode = eventCode;
            this.parameters = parameters;
            this.encrypted = encrypted;
        }

        public int getEventCode()
        {
            return this.eventCode;
        }

        public GNHashtable getParameters()
        {
            return this.parameters;
        }

        public bool isEncrypted()
        {
            return this.encrypted;
        }

        public OperationEvent setParameter(string key, object value)
        {
            if (this.parameters == null) this.parameters = new GNHashtable();

            this.parameters.add(key, value);

            return this;
        }

        public OperationEvent setParameters(GNHashtable parameters)
        {
            this.parameters = parameters;

            return this;
        }

        public OperationEvent setEncrypted(bool encrypted)
        {
            this.encrypted = encrypted;
            return this;
        }

        public string toString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("Code: " + CodeHelper.getEventCodeName(this.eventCode) + ", parameters " + this.parameters + ", encrypted " + this.encrypted);

            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return this.toString();
        }

    }

}
