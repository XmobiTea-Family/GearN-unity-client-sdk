namespace XmobiTea.GearN.Entity.Response
{
    public class InstanceResponse
    {
        public string instanceId;
        public bool isPrimary;
        public string currentInstanceIdPrimary;
        public long currentTsPrimary;
        public string currentTsPrimaryToDate;
        public long tsPrimary;
        public string tsPrimaryToDate;
    }

    public class OtherInstanceResponse : InstanceResponse
    {
        public int lostPing;
    }

    public class HealthCheckDataResponse
    {
        public InstanceResponse thisInstance;
        public OtherInstanceResponse[] otherInstances;

    }

    public class HealthCheckResponse
    {
        public string error;
        public HealthCheckDataResponse? data;

    }

}
