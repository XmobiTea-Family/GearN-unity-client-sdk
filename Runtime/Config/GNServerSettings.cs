namespace XmobiTea.GN.Config
{
    using UnityEngine;

    public enum PeerSocketVersion
    {
        V2_v2 = 0,
        V2_v3 = 1,
        V3 = 2,

    }

    public enum HttpRequestType
    {
        UnityWebRequest = 0,
        HTTPRequest = 1,

    }

    //[CreateAssetMenu(fileName = GNServerSettings.ResourcesPath, menuName = "GN/GNServerSettings", order = 1)]
    public class GNServerSettings : ScriptableObject
    {
        public const string ResourcesPath = "GNServerSettings";

        [SerializeField]
        private string serverAddress = "127.0.0.1";

        [SerializeField]
        private int serverPort = 2202;

        [SerializeField]
        private bool useSsl = false;

        [SerializeField]
        private bool useSocket = true;

        [SerializeField]
        private bool useHttp = true;

        [SerializeField]
        private int sendRate = 20;

        [SerializeField]
        private int reconnectDelay = 5000;

        [SerializeField]
        private float pingInterval = 20000;

        [SerializeField]
        private float pingTimeout = 20000;

        [SerializeField]
        private string adminSecretKey;

        [SerializeField]
        private string serverSecretKey;

        [SerializeField]
        private string clientSecretKey;

        [SerializeField]
        private PeerSocketVersion peerSocketVersion = PeerSocketVersion.V3;

        [SerializeField]
        private string gnServerSourcePath = "Template_GN-server";

        [SerializeField]
        private HttpRequestType httpRequestType = HttpRequestType.HTTPRequest;

        [SerializeField]
        private GN.Logger.LogType logType = GN.Logger.LogType.All;

        public string getServerAddress()
        {
            return this.serverAddress;
        }

        public int getServerPort()
        {
            return this.serverPort;
        }

        public bool isUseSsl()
        {
            return this.useSsl;
        }


        public bool isUseSocket()
        {
            return this.useSocket;
        }

        public bool isUseHttp()
        {
            return this.useHttp;
        }

        public int getSendRate()
        {
            return this.sendRate;
        }

        public int getReconnectDelay()
        {
            return this.reconnectDelay;
        }

        public float getPingInterval()
        {
            return this.pingInterval;
        }

        public float getPingTimeout()
        {
            return this.pingTimeout;
        }

        public string getAdminSecretKey()
        {
            return this.adminSecretKey;
        }

        public string getServerSecretKey()
        {
            return this.serverSecretKey;
        }

        public string getClientSecretKey()
        {
            return this.clientSecretKey;
        }

        public PeerSocketVersion getPeerSocketVersion()
        {
            return this.peerSocketVersion;
        }

        public string getGNServerSourcePath()
        {
            return this.gnServerSourcePath;
        }

        public HttpRequestType getHttpRequestType()
        {
            return this.httpRequestType;
        }

        public GN.Logger.LogType getLogType()
        {
            return this.logType;
        }

       
        public string getSocketUrl()
        {
            if (this.serverPort < 0) return string.Format((this.useSsl ? "https" : "http") + "://{0}", this.serverAddress);
            else return string.Format((this.useSsl ? "https" : "http") + "://{0}:{1}", this.serverAddress, this.serverPort);
        }

        public string getHttpUrl()
        {
            if (this.serverPort < 0) return string.Format((this.useSsl ? "https" : "http") + "://{0}", this.serverAddress);
            else return string.Format((this.useSsl ? "https" : "http") + "://{0}:{1}", this.serverAddress, this.serverPort);
        }

    }

}

