namespace XmobiTea.GearN.Config
{
    using UnityEngine;

    /// <summary>
    /// Enum for specifying the peer socket version.
    /// </summary>
    public enum PeerSocketVersion
    {
        None = 0,
#if UNITY_USING_BEST_HTTP
        /// <summary>
        /// Socket.IO version 2 with protocol v2 from BestHttp2.
        /// </summary>
        V2_v2_BestHttp = 1,

        /// <summary>
        /// Socket.IO version 2 with protocol v3 from BestHttp2.
        /// </summary>
        V2_v3_BestHttp = 2,

        /// <summary>
        /// Socket.IO version 3 from BestHttp2.
        /// </summary>
        V3_BestHttp = 3,
#endif

#if UNITY_USING_SOCKET_IO_UNITY
        /// <summary>
        /// Socket.IO version 4 from SocketIOUnity
        /// </summary>
        V4_SocketIOUnity = 4,
#endif
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
        /// HttpClientRequest for HTTP requests.
        /// </summary>
        HttpClientRequest = 2,
    }

    /// <summary>
    /// Defines the available message serialization formats.
    /// </summary>
    public enum MessageType
    {
        /// <summary>
        /// Represents JSON.
        /// </summary>
        Json = 1,
        /// <summary>
        /// Represents msgpack.
        /// </summary>
        MsgPack = 2,
    }

    /// <summary>
    /// Defines the runtime settings used to configure the GearN Unity client SDK.
    /// </summary>
    //[CreateAssetMenu(fileName = GNServerSettings.ResourcesPath, menuName = "GN/GNServerSettings", order = 1)]
    public class GNServerSettings : ScriptableObject
    {
        /// <summary>
        /// Specifies the Unity Resources path used to load the GearN server settings asset.
        /// </summary>
        public const string ResourcesPath = "GNServerSettings";

        /// <summary>
        /// Stores the server address value.
        /// </summary>
        [SerializeField]
        private string serverAddress = "127.0.0.1";

        /// <summary>
        /// Stores the server port value.
        /// </summary>
        [SerializeField]
        private int serverPort = 2202;

        /// <summary>
        /// Stores the server socket port value.
        /// </summary>
        [SerializeField]
        private int serverSocketPort = 2901;

        /// <summary>
        /// Indicates whether use ssl.
        /// </summary>
        [SerializeField]
        private bool useSsl = false;

        /// <summary>
        /// Indicates whether use socket.
        /// </summary>
        [SerializeField]
        private bool useSocket = true;

        /// <summary>
        /// Indicates whether use HTTP.
        /// </summary>
        [SerializeField]
        private bool useHttp = true;

        /// <summary>
        /// Stores the default timeout in seconds value.
        /// </summary>
        [SerializeField]
        private int defaultTimeoutInSeconds = 20;

        /// <summary>
        /// Stores the message type value.
        /// </summary>
        [SerializeField]
        private MessageType messageType = MessageType.MsgPack;

        /// <summary>
        /// Stores the send rate value.
        /// </summary>
        [SerializeField]
        private int sendRate = 20;

        /// <summary>
        /// Stores the reconnect delay value.
        /// </summary>
        [SerializeField]
        private int reconnectDelay = 5000;

        /// <summary>
        /// Stores the ping interval value.
        /// </summary>
        [SerializeField]
        private float pingInterval = 20000;

        /// <summary>
        /// Stores the ping timeout value.
        /// </summary>
        [SerializeField]
        private float pingTimeout = 20000;

        /// <summary>
        /// Stores the secret key value.
        /// </summary>
        [SerializeField]
        private string secretKey;

        /// <summary>
        /// Stores the peer socket version value.
        /// </summary>
        [SerializeField]
        private PeerSocketVersion peerSocketVersion = PeerSocketVersion.None;

        /// <summary>
        /// Stores the HTTP request type value.
        /// </summary>
        [SerializeField]
        private HttpRequestType httpRequestType = HttpRequestType.UnityWebRequest;

        /// <summary>
        /// Stores the log type value.
        /// </summary>
        [SerializeField]
        private GearN.Logger.LogType logType = GearN.Logger.LogType.All;

        /// <summary>
        /// Gets the server address.
        /// </summary>
        /// <returns>The server address.</returns>
        public string getServerAddress() => this.serverAddress;

        /// <summary>
        /// Sets server address.
        /// </summary>
        public void setServerAddress(string serverAddress) => this.serverAddress = serverAddress;

        /// <summary>
        /// Gets the server port.
        /// </summary>
        /// <returns>The server port.</returns>
        public int getServerPort() => this.serverPort;

        /// <summary>
        /// Sets server port.
        /// </summary>
        public void setServerPort(int serverPort) => this.serverPort = serverPort;

        /// <summary>
        /// Gets the server socket port.
        /// </summary>
        /// <returns>The server socket port.</returns>
        public int getServerSocketPort() => this.serverSocketPort;

        /// <summary>
        /// Sets server socket port.
        /// </summary>
        public void setServerSocketPort(int serverSocketPort) => this.serverSocketPort = serverSocketPort;

        /// <summary>
        /// Indicates whether SSL is used.
        /// </summary>
        /// <returns>True if SSL is used; otherwise, false.</returns>
        public bool isUseSsl() => this.useSsl;

        /// <summary>
        /// Sets use ssl.
        /// </summary>
        public void setUseSsl(bool useSsl) => this.useSsl = useSsl;

        /// <summary>
        /// Indicates whether socket communication is enabled.
        /// </summary>
        /// <returns>True if socket is used; otherwise, false.</returns>
        public bool isUseSocket() => this.useSocket;

        /// <summary>
        /// Sets use socket.
        /// </summary>
        public void setUseSocket(bool useSocket) => this.useSocket = useSocket;

        /// <summary>
        /// Indicates whether HTTP communication is enabled.
        /// </summary>
        /// <returns>True if HTTP is used; otherwise, false.</returns>
        public bool isUseHttp() => this.useHttp;

        /// <summary>
        /// Sets use HTTP.
        /// </summary>
        public void setUseHttp(bool useHttp) => this.useHttp = useHttp;

        /// <summary>
        /// Gets default timeout in seconds.
        /// </summary>
        public int getDefaultTimeoutInSeconds() => this.defaultTimeoutInSeconds;

        /// <summary>
        /// Sets default timeout in seconds.
        /// </summary>
        public void setDefaultTimeoutInSeconds(int defaultTimeoutInSeconds) => this.defaultTimeoutInSeconds = defaultTimeoutInSeconds;

        /// <summary>
        /// Gets message type.
        /// </summary>
        public MessageType getMessageType() => this.messageType;

        /// <summary>
        /// Sets message type.
        /// </summary>
        public void setMessageType(MessageType messageType) => this.messageType = messageType;

        /// <summary>
        /// Gets the message send rate.
        /// </summary>
        /// <returns>The send rate.</returns>
        public int getSendRate() => this.sendRate;

        /// <summary>
        /// Sets send rate.
        /// </summary>
        public void setSendRate(int sendRate) => this.sendRate = sendRate;

        /// <summary>
        /// Gets the reconnect delay in milliseconds.
        /// </summary>
        /// <returns>The reconnect delay.</returns>
        public int getReconnectDelay() => this.reconnectDelay;

        /// <summary>
        /// Sets reconnect delay.
        /// </summary>
        public void setReconnectDelay(int reconnectDelay) => this.reconnectDelay = reconnectDelay;

        /// <summary>
        /// Gets the ping interval in milliseconds.
        /// </summary>
        /// <returns>The ping interval.</returns>
        public float getPingInterval() => this.pingInterval;

        /// <summary>
        /// Sets ping interval.
        /// </summary>
        public void setPingInterval(int pingInterval) => this.pingInterval = pingInterval; 

        /// <summary>
        /// Gets the ping timeout in milliseconds.
        /// </summary>
        /// <returns>The ping timeout.</returns>
        public float getPingTimeout() => this.pingTimeout;

        /// <summary>
        /// Sets ping timeout.
        /// </summary>
        public void setPingTimeout(float pingTimeout) => this.pingTimeout = pingTimeout;

        /// <summary>
        /// Gets the secret key.
        /// </summary>
        /// <returns>The secret key.</returns>
        public string getSecretKey() => this.secretKey;

        /// <summary>
        /// Sets secret key.
        /// </summary>
        public void setSecretKey(string secretKey) => this.secretKey = secretKey;

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
        public GearN.Logger.LogType getLogType() => this.logType;

        /// <summary>
        /// Sets log type.
        /// </summary>
        public void setLogType(GearN.Logger.LogType logType) => this.logType = logType;

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