namespace XmobiTea.GearN.Entity.Response
{
    using XmobiTea.GearN.Common;

    /// <summary>
    /// Represents the auth info response payload.
    /// </summary>
    public class AuthInfoResponse
    {
        /// <summary>
        /// Stores the GN token value.
        /// </summary>
        public string gnToken;
        /// <summary>
        /// Stores the user ID value.
        /// </summary>
        public string userId;
        /// <summary>
        /// Indicates whether is remove.
        /// </summary>
        public bool isRemove;
        /// <summary>
        /// Stores the timestamp expire value.
        /// </summary>
        public long tsExpire;
        /// <summary>
        /// Stores the other datas value.
        /// </summary>
        public GNHashtable otherDatas;
        /// <summary>
        /// Stores the timestamp create value.
        /// </summary>
        public long tsCreate;
        /// <summary>
        /// Stores the secret key value.
        /// </summary>
        public string secretKey;

    }

    /// <summary>
    /// Represents the get auth info response payload.
    /// </summary>
    public class GetAuthInfoResponse
    {
        /// <summary>
        /// Stores the error value.
        /// </summary>
        public string error;
        /// <summary>
        /// Stores the data value.
        /// </summary>
        public AuthInfoResponse? data;

    }

}