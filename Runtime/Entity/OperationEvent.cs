namespace XmobiTea.GN.Entity
{
    using System.Text;

    using XmobiTea.GN.Common;
    using XmobiTea.GN.Helper;

    public class OperationEvent
    {
        private static OperationEvent operationEventConnect = new OperationEvent(0, null);
        public static OperationEvent OperationEventConnect => operationEventConnect;

        private static OperationEvent operationEventDisconnect = new OperationEvent(1, null);
        public static OperationEvent OperationEventDisconnect => operationEventDisconnect;

        private static OperationEvent operationEventOpen = new OperationEvent(2, null);
        public static OperationEvent OperationEventOpen => operationEventOpen;

        private static OperationEvent operationEventClose = new OperationEvent(3, null);
        public static OperationEvent OperationEventClose => operationEventClose;

        private static OperationEvent operationEventError = new OperationEvent(4, null);
        public static OperationEvent OperationEventError => operationEventError;

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
