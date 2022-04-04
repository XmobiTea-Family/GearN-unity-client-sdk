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

    //[CreateAssetMenu(fileName = GNServerSettings.ResourcesPath, menuName = "GN/GNServerSettings", order = 1)]
    public class GNServerSettings : ScriptableObject
    {
        public const string ResourcesPath = "GNServerSettings";

        [SerializeField]
        private string _serverAddress = "127.0.0.1";
        public string serverAddress => _serverAddress;

        [SerializeField]
        private int _serverPort = 2202;
        public int serverPort => _serverPort;

        [SerializeField]
        private bool _useSsl = false;
        public bool useSsl => _useSsl;

        [SerializeField]
        private bool _useSocket = true;
        public bool useSocket => _useSocket;

        [SerializeField]
        private bool _useHttp = true;
        public bool useHttp => _useHttp;

        [SerializeField]
        private int _sendRate = 20;
        public int sendRate => _sendRate;

        [SerializeField]
        private int _reconnectDelay = 5000;
        public int reconnectDelay => _reconnectDelay;

        [SerializeField]
        private float _pingInterval = 20000;
        public float pingInterval => _pingInterval;

        [SerializeField]
        private float _pingTimeout = 20000;
        public float pingTimeout => _pingTimeout;

        [SerializeField]
        private PeerSocketVersion _peerSocketVersion = PeerSocketVersion.V3;
        public PeerSocketVersion peerSocketVersion => _peerSocketVersion;

        [SerializeField]
        private List<int> _codeCanSendNotAuthorized = new List<int>() { OperationCode.Debug, OperationCode.GetAppConfig, OperationCode.Login, OperationCode.RegisterAccount };
        public List<int> codeCanSendNotAuthorized => _codeCanSendNotAuthorized;

        [SerializeField]
        private string _gnServerSourcePath = "Template_GN-server";
        public string gnServerSourcePath => _gnServerSourcePath;

        public string SocketUrl
        {
            get
            {
                if (_serverPort < 0) return string.Format((_useSsl ? "https" : "http") + "://{0}", _serverAddress);
                else return string.Format((_useSsl ? "https" : "http") + "://{0}:{1}", _serverAddress, _serverPort);
            }
        }
        public string HttpUrl
        {
            get
            {
                if (_serverPort < 0) return string.Format((_useSsl ? "https" : "http") + "://{0}", _serverAddress);
                else return string.Format((_useSsl ? "https" : "http") + "://{0}:{1}", _serverAddress, _serverPort);
            }
        }
    }
}