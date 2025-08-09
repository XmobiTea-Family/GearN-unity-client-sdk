namespace XmobiTea.GearN.Entity.Response
{
    using XmobiTea.GearN.Common;

    public class AuthInfoResponse
    {
        public string gnToken;
        public string userId;
        public bool isRemove;
        public long tsExpire;
        public GNHashtable otherDatas;
        public long tsCreate;
        public string secretKey;

    }

    public class GetAuthInfoResponse
    {
        public string error;
        public AuthInfoResponse? data;

    }

}
