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

        public int GetEventCode()
        {
            return this.eventCode;
        }

        public GNHashtable GetParameters()
        {
            return this.parameters;
        }

        public bool IsEncrypted()
        {
            return this.encrypted;
        }

        public OperationEvent SetScriptData(string key, object value)
        {
            if (this.parameters == null) this.parameters = new GNHashtable();

            this.parameters.Add(key, value);

            return this;
        }

        public OperationEvent SetParameters(GNHashtable parameters)
        {
            this.parameters = parameters;

            return this;
        }

        public OperationEvent SetEncrypted(bool encrypted)
        {
            this.encrypted = encrypted;
            return this;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("Code: " + CodeHelper.GetEventCodeName(this.eventCode) + ", parameters " + this.parameters);

            return stringBuilder.ToString();
        }

    }

}
