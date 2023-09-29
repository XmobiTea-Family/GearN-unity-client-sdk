namespace XmobiTea.GN.Networking.Http
{
    using System;

    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Helper;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Config;
    using System.Text;
    using XmobiTea.MsgPack;
    using XmobiTea.GN.Logger;

    public class HttpAppResponse
    {
        public long statusCode { get; internal set; }
        public string error { get; internal set; }
        public byte[] data { get; internal set; }
        public string text { get; internal set; }

        public bool hasError()
        {
            return this.error != null;
        }

        public string toString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append(" StatusCode: " + this.statusCode);
            if (!string.IsNullOrEmpty(this.error)) stringBuilder.Append(", <color=red>Error: " + this.error + "</color>");
            stringBuilder.Append(", Text: " + this.text);

            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return this.toString();
        }
    }

    public enum PostType
    {
        Json = 0,
        MsgPack = 1,
    }

    internal class HttpPeer : PeerBase
    {
        private NetworkingHttpPeerBase networkingHttpPeerBase;

        private const char JSON_CHAR_KNOWN = '[';

        internal override void initGNSocketObject()
        {
            var gnServerSettings = GNNetwork.gnServerSettings;
            if (gnServerSettings == null) throw new NullReferenceException("Where is GN Server Settings");

            this.isUse = gnServerSettings.isUseHttp();

            var httpRequestType = gnServerSettings.getHttpRequestType();
            if (httpRequestType == HttpRequestType.HTTPRequest) this.networkingHttpPeerBase = new NetworkingPeerHttpRequest();
            else this.networkingHttpPeerBase = new NetworkingPeerUnityWebRequest();

            var httpUrl = gnServerSettings.getHttpUrl();
            var userAgent = "GN-unity-" + GNNetwork.getPlatform() + "@" + GNNetwork.getClientSdkVersion();
            this.networkingHttpPeerBase.init(httpUrl, userAgent);
        }

        internal override void send(OperationPending operationPending)
        {
            base.send(operationPending);

            GNDebug.log("[GN Http SEND] " + operationPending.getOperationRequest().ToString());

            var operationRequest = operationPending.getOperationRequest();

            var authToken = operationPending.getAuthToken();
            var secretKey = operationPending.getSecretKey();
            var customTags = operationPending.getCustomTags();

            var postType = !operationRequest.isEncrypted() ? PostType.Json : PostType.MsgPack;

            var subUri = (postType == PostType.Json ? NetworkingPeer.API_JSON : NetworkingPeer.API_MSG_PACK) + "/" + operationRequest.getOperationCode() + "/" + (int)operationPending.getRequestType() + "/" + (int)operationPending.getRequestRole();

            this.networkingHttpPeerBase.postRequest(subUri, operationRequest.getParameters(), postType, httpAppResponse =>
            {
                this.onSendOperationRequestResponse(operationPending, httpAppResponse);
            }, operationRequest.getTimeout(), authToken, secretKey, customTags);
        }

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
                        var iList = MsgPackSerializer.Deserialize<object[]>(httpAppResponse.data);
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

        internal void getRequest(string subUri, Action<HttpAppResponse> onHttpAppResponse, float timeout = 15, string authToken = null, string secretKey = null)
        {
            this.networkingHttpPeerBase.getRequest(subUri, onHttpAppResponse, timeout, authToken, secretKey);
        }

        internal void uploadFile(string fileId, byte[] content, string mimetype, Action<HttpAppResponse> onHttpAppResponse, float timeout = 60)
        {
            var authToken = GNNetwork.getAuthenticateStatus().getAuthToken();

            if (string.IsNullOrEmpty(authToken))
            {
                var httpAppResponse = new HttpAppResponse();
                httpAppResponse.statusCode = 401;
                httpAppResponse.error = "Auth token null";

                onHttpAppResponse?.Invoke(httpAppResponse);

                return;
            }

            var subUri = NetworkingPeer.UPLOAD_FILE + "/" + fileId;

            this.networkingHttpPeerBase.postRequestUpload(subUri, content, mimetype, onHttpAppResponse, timeout);
        }

    }

}
