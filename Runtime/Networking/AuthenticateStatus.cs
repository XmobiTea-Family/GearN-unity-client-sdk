namespace XmobiTea.GN.Networking
{
    public class AuthenticateStatus
    {
        private string authToken;
        private string userId;
        private long authTokenTsExpire;

        public long getAuthTokenTsExpire() => this.authTokenTsExpire;

        internal void setAuthTokenTsExpire(long tsExpire) => this.authTokenTsExpire = tsExpire;

        public string getAuthToken() => this.authToken;

        internal void setAuthToken(string authToken) => this.authToken = authToken;

        public bool isLoginAndValid() => !string.IsNullOrEmpty(this.authToken) && (authTokenTsExpire == -1 || GNNetwork.getServerTimestamp() < authTokenTsExpire);

        public string getUserId() => this.userId;

        internal void setUserId(string userId) => this.userId = userId;
    }
}
