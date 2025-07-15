namespace XmobiTea.GN.Config
{
    using UnityEngine;

    /// <summary>
    /// Enum for specifying the peer socket version.
    /// </summary>
    public enum PeerSocketVersion
    {
        /// <summary>
        /// Socket.IO version 2 with protocol v2.
        /// </summary>
        V2_v2 = 0,

        /// <summary>
        /// Socket.IO version 2 with protocol v3.
        /// </summary>
        V2_v3 = 1,

        /// <summary>
        /// Socket.IO version 3.
        /// </summary>
        V3 = 2,
    }

    /// <summary>
    /// Enum for specifying the HTTP request type.
    /// </summary>
    public enum HttpRequestType
    {
        /// <summary>
        /// UnityWebRequest for HTTP requests.
        /// </summary>
        UnityWebRequest = 0,

#if UNITY_USING_BEST_HTTP
        /// <summary>
        /// BestHTTP library for HTTP requests.
        /// </summary>
        HTTPRequest = 1,
#endif

        /// <summary>
        /// HttpWebRequest for HTTP requests.
        /// </summary>
        HttpWebRequest = 2,
    }

    public enum MessageType
    {
        Json = 1,
        MsgPack = 2,
    }

    /// <summary>
    /// GN Server settings configuration.
    /// </summary>
    //[CreateAssetMenu(fileName = GNServerSettings.ResourcesPath, menuName = "GN/GNServerSettings", order = 1)]
    public class GNServerSettings : ScriptableObject
    {
        public const string ResourcesPath = "GNServerSettings";

        [SerializeField]
        private string serverAddress = "127.0.0.1";

        [SerializeField]
        private int serverPort = 2202;

        [SerializeField]
        private int serverSocketPort = 2901;

        [SerializeField]
        private bool useSsl = false;

        [SerializeField]
        private bool useSocket = true;

        [SerializeField]
        private bool useHttp = true;

        [SerializeField]
        private MessageType messageType = MessageType.MsgPack;

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
        private HttpRequestType httpRequestType = HttpRequestType.UnityWebRequest;

        [SerializeField]
        private GN.Logger.LogType logType = GN.Logger.LogType.All;

        /// <summary>
        /// Gets the server address.
        /// </summary>
        /// <returns>The server address.</returns>
        public string getServerAddress() => this.serverAddress;

        public void setServerAddress(string serverAddress) => this.serverAddress = serverAddress;

        /// <summary>
        /// Gets the server port.
        /// </summary>
        /// <returns>The server port.</returns>
        public int getServerPort() => this.serverPort;

        public void setServerPort(int serverPort) => this.serverPort = serverPort;

        /// <summary>
        /// Gets the server socket port.
        /// </summary>
        /// <returns>The server socket port.</returns>
        public int getServerSocketPort() => this.serverSocketPort;

        public void setServerSocketPort(int serverSocketPort) => this.serverSocketPort = serverSocketPort;

        /// <summary>
        /// Indicates whether SSL is used.
        /// </summary>
        /// <returns>True if SSL is used; otherwise, false.</returns>
        public bool isUseSsl() => this.useSsl;

        public void setUseSsl(bool useSsl) => this.useSsl = useSsl;

        /// <summary>
        /// Indicates whether socket communication is enabled.
        /// </summary>
        /// <returns>True if socket is used; otherwise, false.</returns>
        public bool isUseSocket() => this.useSocket;

        public void setUseSocket(bool useSocket) => this.useSocket = useSocket;

        /// <summary>
        /// Indicates whether HTTP communication is enabled.
        /// </summary>
        /// <returns>True if HTTP is used; otherwise, false.</returns>
        public bool isUseHttp() => this.useHttp;

        public void setUseHttp(bool useHttp) => this.useHttp = useHttp;

        public MessageType getMessageType() => this.messageType;

        public void setMessageType(MessageType messageType) => this.messageType = messageType;

        /// <summary>
        /// Gets the message send rate.
        /// </summary>
        /// <returns>The send rate.</returns>
        public int getSendRate() => this.sendRate;

        public void setSendRate(int sendRate) => this.sendRate = sendRate;

        /// <summary>
        /// Gets the reconnect delay in milliseconds.
        /// </summary>
        /// <returns>The reconnect delay.</returns>
        public int getReconnectDelay() => this.reconnectDelay;

        public void setReconnectDelay(int recoonectDelay) => this.reconnectDelay = reconnectDelay;

        /// <summary>
        /// Gets the ping interval in milliseconds.
        /// </summary>
        /// <returns>The ping interval.</returns>
        public float getPingInterval() => this.pingInterval;

        public void setPingInterval(int pingInterval) => this.pingInterval = pingInterval; 

        /// <summary>
        /// Gets the ping timeout in milliseconds.
        /// </summary>
        /// <returns>The ping timeout.</returns>
        public float getPingTimeout() => this.pingTimeout;

        public void setPingTimeout(float pingTimeout) => this.pingTimeout = pingTimeout;

        /// <summary>
        /// Gets the admin secret key.
        /// </summary>
        /// <returns>The admin secret key.</returns>
        public string getAdminSecretKey() => this.adminSecretKey;

        public void setAdminSecretKey(string adminSecretKey) => this.adminSecretKey = adminSecretKey;

        /// <summary>
        /// Gets the server secret key.
        /// </summary>
        /// <returns>The server secret key.</returns>
        public string getServerSecretKey() => this.serverSecretKey;

        public void setServerSecretKey(string serverSecretKey) => this.serverSecretKey = serverSecretKey;

        /// <summary>
        /// Gets the client secret key.
        /// </summary>
        /// <returns>The client secret key.</returns>
        public string getClientSecretKey() => this.clientSecretKey;

        public void setClientSecretKey(string clientSecretKey) => this.clientSecretKey = clientSecretKey;

        /// <summary>
        /// Gets the peer socket version.
        /// </summary>
        /// <returns>The peer socket version.</returns>
        public PeerSocketVersion getPeerSocketVersion() => this.peerSocketVersion;

        /// <summary>
        /// Gets the HTTP request type.
        /// </summary>
        /// <returns>The HTTP request type.</returns>
        public HttpRequestType getHttpRequestType() => this.httpRequestType;

        /// <summary>
        /// Gets the log type.
        /// </summary>
        /// <returns>The log type.</returns>
        public GN.Logger.LogType getLogType() => this.logType;

        /// <summary>
        /// Constructs the socket URL.
        /// </summary>
        /// <returns>The socket URL.</returns>
        public string getSocketUrl() =>
            this.serverPort < 0
                ? $"{(this.useSsl ? "https" : "http")}://{this.serverAddress}"
                : $"{(this.useSsl ? "https" : "http")}://{this.serverAddress}:{this.serverSocketPort}";

        /// <summary>
        /// Constructs the HTTP URL.
        /// </summary>
        /// <returns>The HTTP URL.</returns>
        public string getHttpUrl() =>
            this.serverPort < 0
                ? $"{(this.useSsl ? "https" : "http")}://{this.serverAddress}"
                : $"{(this.useSsl ? "https" : "http")}://{this.serverAddress}:{this.serverPort}";
    }
}
