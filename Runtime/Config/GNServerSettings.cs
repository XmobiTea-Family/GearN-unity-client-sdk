namespace XmobiTea.GN.Config
{
    using System.Collections.Generic;

    using UnityEngine;

    using XmobiTea.GN.Constant;

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
        private string _serverAddress = "127.0.0.1";
        public string serverAddress => this._serverAddress;

        [SerializeField]
        private int _serverPort = 2202;
        public int serverPort => this._serverPort;

        [SerializeField]
        private bool _useSsl = false;
        public bool useSsl => this._useSsl;

        [SerializeField]
        private bool _useSocket = true;
        public bool useSocket => this._useSocket;

        [SerializeField]
        private bool _useHttp = true;
        public bool useHttp => this._useHttp;

        [SerializeField]
        private int _sendRate = 20;
        public int sendRate => this._sendRate;

        [SerializeField]
        private int _reconnectDelay = 5000;
        public int reconnectDelay => this._reconnectDelay;

        [SerializeField]
        private float _pingInterval = 20000;
        public float pingInterval => this._pingInterval;

        [SerializeField]
        private float _pingTimeout = 20000;
        public float pingTimeout => this._pingTimeout;

        [SerializeField]
        private string _adminSecretKey;
        public string adminSecretKey => _adminSecretKey;

        [SerializeField]
        private string _serverSecretKey;
        public string serverSecretKey => _serverSecretKey;

        [SerializeField]
        private string _clientSecretKey;
        public string clientSecretKey => _clientSecretKey;

        [SerializeField]
        private PeerSocketVersion _peerSocketVersion = PeerSocketVersion.V3;
        public PeerSocketVersion peerSocketVersion => this._peerSocketVersion;

        [SerializeField]
        private List<int> _codeCanSendNotAuthorized = new List<int>() {  };
        public List<int> codeCanSendNotAuthorized => this._codeCanSendNotAuthorized;

        [SerializeField]
        private string _gnServerSourcePath = "Template_GN-server";
        public string gnServerSourcePath => this._gnServerSourcePath;

        [SerializeField]
        private HttpRequestType _httpRequestType = HttpRequestType.HTTPRequest;
        public HttpRequestType httpRequestType => this._httpRequestType;

        [SerializeField]
        private GN.Logger.LogType _logType = GN.Logger.LogType.All;
        public GN.Logger.LogType logType => this._logType;

        public string SocketUrl
        {
            get
            {
                if (this._serverPort < 0) return string.Format((this._useSsl ? "https" : "http") + "://{0}", this._serverAddress);
                else return string.Format((this._useSsl ? "https" : "http") + "://{0}:{1}", this._serverAddress, this._serverPort);
            }
        }

        public string HttpUrl
        {
            get
            {
                if (this._serverPort < 0) return string.Format((this._useSsl ? "https" : "http") + "://{0}", this._serverAddress);
                else return string.Format((this._useSsl ? "https" : "http") + "://{0}:{1}", this._serverAddress, this._serverPort);
            }
        }

    }

}
