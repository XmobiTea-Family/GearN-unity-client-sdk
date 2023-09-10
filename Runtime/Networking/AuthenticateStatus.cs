namespace XmobiTea.GN.Networking
{
    public class AuthenticateStatus
    {
        private string authToken;
        private string userId;
        private long authTokenTsExpire;

        public long getAuthTokenTsExpire()
        {
            return this.authTokenTsExpire;
        }

        internal void setAuthTokenTsExpire(long tsExpire)
        {
            this.authTokenTsExpire = tsExpire;
        }

        public string getAuthToken()
        {
            return this.authToken;
        }

        internal void setAuthToken(string authToken)
        {
            this.authToken = authToken;
        }

        //public bool isLoginAndValid()
        //{
        //    return string.IsNullOrEmpty(this.authToken) && (authTokenTsExpire == -1 || GNNetwork.getServerTimestamp() < authTokenTsExpire);
        //}

        public string getUserId()
        {
            return this.userId;
        }

        internal void setUserId(string userId)
        {
            this.userId = userId;
        }

    }

}
