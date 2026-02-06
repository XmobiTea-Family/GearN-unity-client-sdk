namespace XmobiTea.GearN.Networking.Http
{
    using XmobiTea.GearN.Common;

    /// <summary>
    /// Abstract base class for HTTP networking operations.
    /// </summary>
    internal abstract class NetworkingHttpPeerBase
    {
        /// <summary>
        /// Gets the HTTP URL used for requests.
        /// </summary>
        protected string httpUrl { get; private set; }

        /// <summary>
        /// Gets the user agent string used for requests.
        /// </summary>
        protected string userAgent { get; private set; }

        /// <summary>
        /// Sends a GET request to the specified URI.
        /// </summary>
        /// <param name="subUri">The sub-URI for the request.</param>
        /// <param name="onHttpAppResponse">Callback to handle the HTTP response.</param>
        /// <param name="timeout">The timeout for the request, in seconds.</param>
        /// <param name="authToken">Optional authentication token.</param>
        /// <param name="secretKey">Optional secret key.</param>
        public abstract void getRequest(string subUri, Action1<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKe, string gameIdy);

        /// <summary>
        /// Sends a POST request to the specified URI.
        /// </summary>
        /// <param name="subUri">The sub-URI for the request.</param>
        /// <param name="param">The parameters to include in the request.</param>
        /// <param name="postType">The type of POST request (e.g., JSON, MsgPack).</param>
        /// <param name="onHttpAppResponse">Callback to handle the HTTP response.</param>
        /// <param name="timeout">The timeout for the request, in seconds.</param>
        /// <param name="authToken">Optional authentication token.</param>
        /// <param name="secretKey">Optional secret key.</param>
        /// <param name="customTags">Optional custom tags to include in the request.</param>
        public abstract void postRequest(string subUri, GNHashtable param, PostType postType, Action1<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey, GNHashtable customTags, string gameId);

        /// <summary>
        /// Sends a file upload request to the specified URI.
        /// </summary>
        /// <param name="subUri">The sub-URI for the request.</param>
        /// <param name="content">The file content to upload.</param>
        /// <param name="mimetype">The MIME type of the file.</param>
        /// <param name="onHttpAppResponse">Callback to handle the HTTP response.</param>
        /// <param name="timeout">The timeout for the request, in seconds.</param>
        public abstract void postRequestUpload(string subUri, byte[] content, string filename, string mimetype, Action1<HttpAppResponse> onHttpAppResponse, float timeout);

        /// <summary>
        /// Initializes the HTTP peer with the specified URL and user agent.
        /// </summary>
        /// <param name="httpUrl">The base URL for the HTTP requests.</param>
        /// <param name="userAgent">The user agent string to include in the requests.</param>
        public virtual void init(string httpUrl, string userAgent)
        {
            this.httpUrl = httpUrl;
            this.userAgent = userAgent;
        }
    }
}
