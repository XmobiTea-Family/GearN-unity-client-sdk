namespace XmobiTea.GN.Networking.Http
{
    using System;
    using System.Text;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Config;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Helper;
    using XmobiTea.GN.Logger;

    /// <summary>
    /// Represents the HTTP application response.
    /// </summary>
    public class HttpAppResponse
    {
        /// <summary>Gets or sets the HTTP status code.</summary>
        public int statusCode { get; internal set; }

        /// <summary>Gets or sets the error message, if any.</summary>
        public string error { get; internal set; }

        /// <summary>Gets or sets the response data in byte array format.</summary>
        public byte[] data { get; internal set; }

        /// <summary>Gets or sets the response text as a string.</summary>
        public string text { get; internal set; }

        /// <summary>
        /// Checks if the response contains an error.
        /// </summary>
        /// <returns>True if there is an error; otherwise, false.</returns>
        public bool hasError()
        {
            return this.error != null;
        }

        /// <summary>
        /// Converts the HTTP response to a string for logging purposes.
        /// </summary>
        /// <returns>A string representation of the response.</returns>
        public string toString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(" StatusCode: " + this.statusCode);
            if (!string.IsNullOrEmpty(this.error)) stringBuilder.Append(", <color=red>Error: " + this.error + "</color>");
            stringBuilder.Append(", Text: " + this.text);
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Returns a string representation of the HTTP response.
        /// </summary>
        /// <returns>A string representation of the HTTP response.</returns>
        public override string ToString()
        {
            return this.toString();
        }
    }

    /// <summary>
    /// Enum representing the type of HTTP POST requests.
    /// </summary>
    public enum PostType
    {
        Json = 0,
        MsgPack = 1,
    }

    /// <summary>
    /// Class for managing HTTP peer connections and requests.
    /// </summary>
    internal class HttpPeer : PeerBase
    {
        private NetworkingHttpPeerBase networkingHttpPeerBase;

        private const char JSON_CHAR_KNOWN = '[';

        /// <summary>
        /// Initializes the GN HTTP socket object.
        /// </summary>
        internal override void initGNSocketObject()
        {
            var gnServerSettings = GNNetwork.gnServerSettings;
            if (gnServerSettings == null) throw new NullReferenceException("Where is GN Server Settings");

            this.isUse = gnServerSettings.isUseHttp();
            var httpRequestType = gnServerSettings.getHttpRequestType();

#if UNITY_USING_BEST_HTTP
            if (httpRequestType == HttpRequestType.HTTPRequest) this.networkingHttpPeerBase = new NetworkingPeerHttpRequest();
            else
#endif
            if (httpRequestType == HttpRequestType.UnityWebRequest) this.networkingHttpPeerBase = new NetworkingPeerUnityWebRequest();
            else if (httpRequestType == HttpRequestType.HttpWebRequest) this.networkingHttpPeerBase = new NetworkingPeerHttpWebRequest();

            var httpUrl = gnServerSettings.getHttpUrl();
            var userAgent = "GN-unity-" + GNNetwork.getPlatform() + "@" + GNNetwork.getClientSdkVersion();
            this.networkingHttpPeerBase.init(httpUrl, userAgent);
        }

        /// <summary>
        /// Sends an operation request via HTTP.
        /// </summary>
        /// <param name="operationPending">The operation pending to be sent.</param>
        internal override void send(OperationPending operationPending)
        {
            base.send(operationPending);

            var operationRequest = operationPending.getOperationRequest();
            GNDebug.log("[GN Http SEND] " + operationRequest.ToString());

            var authToken = operationPending.getAuthToken();
            var secretKey = operationPending.getSecretKey();
            var gameId = operationPending.getGameId();
            var customTags = operationPending.getCustomTags();

            var gnServerSettings = GNNetwork.gnServerSettings;
            var postType = gnServerSettings.getMessageType() == MessageType.Json ? PostType.Json : PostType.MsgPack;

            var subUri = (postType == PostType.Json ? NetworkingPeer.API_JSON : NetworkingPeer.API_MSG_PACK) + "/" + operationRequest.getOperationCode() + "/" + (int)operationPending.getRequestType() + "/" + (int)operationPending.getRequestRole();

            this.networkingHttpPeerBase.postRequest(subUri, operationRequest.getParameters(), postType, httpAppResponse =>
            {
                this.onSendOperationRequestResponse(operationPending, httpAppResponse);
            }, operationRequest.getTimeout(), authToken, secretKey, customTags, gameId);
        }

        protected override void onEnqueue(OperationPending operationPending)
        {
            GNDebug.log("[GN Http ENQUEUE] " + operationPending.getOperationRequest().ToString());
        }

        /// <summary>
        /// Handles the response of an operation request.
        /// </summary>
        /// <param name="operationPending">The pending operation.</param>
        /// <param name="httpAppResponse">The HTTP application response received.</param>
        void onSendOperationRequestResponse(OperationPending operationPending, HttpAppResponse httpAppResponse)
        {
            var operationRequest = operationPending.getOperationRequest();
            var obj = new GNArray();

            if (!httpAppResponse.hasError())
            {
                if (httpAppResponse.statusCode == 200)
                {
                    var isEncrypted = false;
                    GNArray gnArray = null;

                    if (!string.IsNullOrEmpty(httpAppResponse.text))
                    {
                        if (httpAppResponse.text[0].Equals(HttpPeer.JSON_CHAR_KNOWN))
                        {
                            var returnDatas = (System.Collections.IList)Parser.Parse(httpAppResponse.text);
                            gnArray = new GNArray.Builder()
                                .addAll(returnDatas)
                                .build();
                        }
                    }

                    if (gnArray == null)
                    {
                        var iList = MessagePackConverterService.deserialize<object[]>(httpAppResponse.data);
                        gnArray = new GNArray.Builder()
                            .addAll(Socket.NetworkingSocketPeerBase.fromMsgList(iList))
                            .build();

                        isEncrypted = true;
                    }

                    if (gnArray != null)
                    {
                        var returnCode = gnArray.getInt(0);
                        obj.add(returnCode);

                        if (returnCode == (int)ReturnCode.Ok) obj.add(gnArray.getGNHashtable(1, new GNHashtable()));
                        else if (returnCode == ReturnCode.InvalidRequestParameters) obj.add(gnArray.getGNArray(1, new GNArray()));
                        else obj.add(gnArray.getString(1));
                        obj.add(operationRequest.getRequestId());

                        this.onResponseHandler(obj, isEncrypted);
                        return;
                    }
                }
            }

            obj.add((int)ReturnCode.UnknownError);
            obj.add(httpAppResponse.error);
            obj.add(operationRequest.getRequestId());

            this.onResponseHandler(obj, operationRequest.isEncrypted());
        }

        /// <summary>
        /// Sends a GET request to the specified URI.
        /// </summary>
        /// <param name="subUri">The sub-URI for the request.</param>
        /// <param name="onHttpAppResponse">Callback to handle the HTTP response.</param>
        /// <param name="timeout">The timeout for the request, in seconds.</param>
        /// <param name="authToken">Optional authentication token.</param>
        /// <param name="secretKey">Optional secret key.</param>
        internal void getRequest(string subUri, Action<HttpAppResponse> onHttpAppResponse, float timeout = 15, string authToken = null, string secretKey = null, string gameId = null)
        {
            this.networkingHttpPeerBase.getRequest(subUri, onHttpAppResponse, timeout, authToken, secretKey, gameId);
        }

        /// <summary>
        /// Uploads a file to the server.
        /// </summary>
        /// <param name="fileId">The ID of the file to upload.</param>
        /// <param name="content">The content of the file as a byte array.</param>
        /// <param name="mimetype">The MIME type of the file.</param>
        /// <param name="onHttpAppResponse">Callback to handle the HTTP response.</param>
        /// <param name="timeout">The timeout for the request, in seconds.</param>
        internal void uploadFile(string fileId, byte[] content, string filename, string mimetype, Action<HttpAppResponse> onHttpAppResponse, float timeout = 6000)
        {
            var authToken = GNNetwork.getAuthenticateStatus().getAuthToken();

            if (string.IsNullOrEmpty(authToken))
            {
                var httpAppResponse = new HttpAppResponse { statusCode = 401, error = "Auth token null" };
                onHttpAppResponse?.Invoke(httpAppResponse);
                return;
            }

            var subUri = NetworkingPeer.UPLOAD_FILE + "/" + fileId;
            this.networkingHttpPeerBase.postRequestUpload(subUri, content, filename, mimetype, onHttpAppResponse, timeout);
        }

    }

}
