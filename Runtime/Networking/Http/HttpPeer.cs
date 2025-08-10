namespace XmobiTea.GearN.Networking.Http
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Config;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Helper;
    using XmobiTea.GearN.Logger;

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

        private const char JSON_CHAR_KNOWN = '{';

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
            var gnServerSettings = GNNetwork.gnServerSettings;
            var operationRequest = operationPending.getOperationRequest();

            if (operationRequest.getTimeout() == OperationRequest.defaultTimeOut) operationRequest.setTimeout(gnServerSettings.getDefaultTimeoutInSeconds());

            base.send(operationPending);

            GNDebug.log("[GN Http SEND] " + operationRequest.ToString());

            var authToken = operationPending.getAuthToken();
            var secretKey = operationPending.getSecretKey();
            var gameId = operationPending.getGameId();
            var customTags = operationPending.getCustomTags();

            var postType = gnServerSettings.getMessageType() == MessageType.Json ? PostType.Json : PostType.MsgPack;

            var subUri = (postType == PostType.Json ? NetworkingPeer.API_JSON : NetworkingPeer.API_MSG_PACK) + "/" + CodeHelper.getRequestTypeName((int)operationPending.getRequestType()) + "/" + CodeHelper.getRequestRoleName((int)operationPending.getRole()) + "/" + operationRequest.getOperationCode();

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
            var obj = new GNHashtable();

            if (!httpAppResponse.hasError())
            {
                if (httpAppResponse.statusCode == 200)
                {
                    GNHashtable gnHashtable = null;

                    if (!string.IsNullOrEmpty(httpAppResponse.text))
                    {
                        if (httpAppResponse.text[0].Equals(HttpPeer.JSON_CHAR_KNOWN))
                        {
                            var returnDatas = (System.Collections.IDictionary)Parser.Parse(httpAppResponse.text);
                            gnHashtable = new GNHashtable.Builder()
                                .addAll(returnDatas)
                                .build();
                        }
                    }

                    if (gnHashtable == null)
                    {
                        var iDict = MessagePackConverterService.deserialize<Dictionary<string, object>>(httpAppResponse.data);
                        gnHashtable = new GNHashtable.Builder()
                            .addAll(Socket.NetworkingSocketPeerBase.fromMsgDict(iDict))
                            .build();
                    }

                    if (gnHashtable != null)
                    {
                        obj.add(ParameterCode.ReturnCode, gnHashtable.getInt(ParameterCode.ReturnCode));
                        obj.add(ParameterCode.Parameters, gnHashtable.getGNHashtable(ParameterCode.Parameters, new GNHashtable()));
                        obj.add(ParameterCode.InvalidRequestParameters, gnHashtable.getGNArray(ParameterCode.InvalidRequestParameters, new GNArray()));
                        obj.add(ParameterCode.DebugMessage, gnHashtable.getString(ParameterCode.DebugMessage));
                        obj.add(ParameterCode.ResponseId, operationRequest.getRequestId());

                        this.onResponseHandler(obj);
                        return;
                    }
                }
            }

            obj.add(ParameterCode.ReturnCode, ReturnCode.UnknownError);
            obj.add(ParameterCode.DebugMessage, httpAppResponse.error);
            obj.add(ParameterCode.ResponseId, operationRequest.getRequestId());

            this.onResponseHandler(obj);
        }

        /// <summary>
        /// Sends a GET request to the specified URI.
        /// </summary>
        /// <param name="subUri">The sub-URI for the request.</param>
        /// <param name="onHttpAppResponse">Callback to handle the HTTP response.</param>
        /// <param name="timeout">The timeout for the request, in seconds.</param>
        /// <param name="authToken">Optional authentication token.</param>
        /// <param name="secretKey">Optional secret key.</param>
        internal void getRequest(string subUri, Action<HttpAppResponse> onHttpAppResponse, float timeout = OperationRequest.defaultTimeOut, string authToken = null, string secretKey = null, string gameId = null)
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
