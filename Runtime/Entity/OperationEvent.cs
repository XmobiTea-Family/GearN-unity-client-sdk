namespace XmobiTea.GN.Entity
{
    using System.Text;

    using XmobiTea.GN.Common;
    using XmobiTea.GN.Helper;

    public class OperationEvent
    {

        private int eventCode;
        private GNHashtable parameters;

        public int GetEventCode()
        {
            return eventCode;
        }

        public GNHashtable GetParameters()
        {
            return parameters;
        }

        public OperationEvent(int eventCode, GNHashtable parameters)
        {
            this.eventCode = eventCode;
            this.parameters = parameters;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("Code: " + CodeHelper.GetEventCodeName(eventCode) + " parameters " + parameters);

            return stringBuilder.ToString();
        }
    }
}
