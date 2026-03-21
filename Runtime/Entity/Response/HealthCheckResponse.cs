namespace XmobiTea.GearN.Entity.Response
{
    /// <summary>
    /// Represents the instance response payload.
    /// </summary>
    public class InstanceResponse
    {
        /// <summary>
        /// Stores the instance ID value.
        /// </summary>
        public string instanceId;
        /// <summary>
        /// Indicates whether is primary.
        /// </summary>
        public bool isPrimary;
        /// <summary>
        /// Stores the current instance ID primary value.
        /// </summary>
        public string currentInstanceIdPrimary;
        /// <summary>
        /// Stores the current timestamp primary value.
        /// </summary>
        public long currentTsPrimary;
        /// <summary>
        /// Stores the current timestamp primary to date value.
        /// </summary>
        public string currentTsPrimaryToDate;
        /// <summary>
        /// Stores the timestamp primary value.
        /// </summary>
        public long tsPrimary;
        /// <summary>
        /// Stores the timestamp primary to date value.
        /// </summary>
        public string tsPrimaryToDate;
    }

    /// <summary>
    /// Represents the other instance response payload.
    /// </summary>
    public class OtherInstanceResponse : InstanceResponse
    {
        /// <summary>
        /// Stores the lost ping value.
        /// </summary>
        public int lostPing;
    }

    /// <summary>
    /// Represents the health check data response payload.
    /// </summary>
    public class HealthCheckDataResponse
    {
        /// <summary>
        /// Stores the this instance value.
        /// </summary>
        public InstanceResponse thisInstance;
        /// <summary>
        /// Stores the other instances value.
        /// </summary>
        public OtherInstanceResponse[] otherInstances;

    }

    /// <summary>
    /// Represents the health check response payload.
    /// </summary>
    public class HealthCheckResponse
    {
        /// <summary>
        /// Stores the error value.
        /// </summary>
        public string error;
        /// <summary>
        /// Stores the data value.
        /// </summary>
        public HealthCheckDataResponse? data;

    }

}