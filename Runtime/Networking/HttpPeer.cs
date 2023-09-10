namespace XmobiTea.GN.Networking
{
    using System;

    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Helper;
    using XmobiTea.GN.Common;
    using BestHTTP;
    using UnityEngine.Networking;
    using System.Collections;
    using XmobiTea.GN.Config;
    using System.IO;
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
        private static string userAgent { get; set; }

        private string httpUrl;
        private HttpRequestType httpRequestType;

        private const char JSON_CHAR_KNOWN = '[';

        class AcceptAllCertificatesSignedWithASpecificKeyPublicKey : CertificateHandler
        {
            protected override bool ValidateCertificate(byte[] certificateData)
            {
                return true;
            }
        }

        internal override void initGNSocketObject()
        {
            var gnServerSettings = GNNetwork.gnServerSettings;
            if (gnServerSettings == null) throw new NullReferenceException("Where is GN Server Settings");

            this.isUse = gnServerSettings.isUseHttp();

            this.httpRequestType = gnServerSettings.getHttpRequestType();
            this.httpUrl = gnServerSettings.getHttpUrl();

            HttpPeer.userAgent = "GN-unity-" + GNNetwork.getPlatform() + "@" + GNNetwork.getClientSdkVersion();

            if (this.httpRequestType == HttpRequestType.HTTPRequest)
            {
                HTTPManager.UserAgent = userAgent;
                HTTPManager.KeepAliveDefaultValue = false;
            }
        }

        internal override void send(OperationPending operationPending)
        {
            base.send(operationPending);

            GNDebug.log("[GN Http SEND] " + operationPending.getOperationRequest().ToString());

            var operationRequest = operationPending.getOperationRequest();

            //if (string.IsNullOrEmpty(authToken))
            //{
            //    if (!this.isOperationCanSendWithoutAuthorized(operationRequest.getOperationCode()))
            //    {
            //        var obj = new GNArray();

            //        obj.add((int)ReturnCode.OperationNotAuthorized);
            //        obj.add(null);
            //        obj.add(operationRequest.getRequestId());

            //        this.onResponseHandler(obj, operationRequest.isEncrypted());

            //        return;
            //    }
            //}

            var authToken = operationPending.getAuthToken();
            var secretKey = operationPending.getSecretKey();
            var customTags = operationPending.getCustomTags();

            var postType = !operationRequest.isEncrypted() ? PostType.Json : PostType.MsgPack;

            var subUri = (postType == PostType.Json ? NetworkingPeer.API_JSON : NetworkingPeer.API_MSG_PACK) + "/" + operationRequest.getOperationCode() + "/" + (int)operationPending.getRequestType() + "/" + (int)operationPending.getRequestRole();

            if (this.httpRequestType == HttpRequestType.HTTPRequest)
            {
                postRequestViaHTTPRequest(subUri, operationRequest.getParameters(), postType, httpAppResponse =>
                {
                    onSendOperationRequestResponse(operationPending, httpAppResponse);
                }, operationRequest.getTimeout(), authToken, secretKey, customTags);
            }
            else if (this.httpRequestType == HttpRequestType.UnityWebRequest)
            {
                StartCoroutine(iePostRequestViaUnityWebRequest(subUri, operationRequest.getParameters(), postType, httpAppResponse =>
                {
                    onSendOperationRequestResponse(operationPending, httpAppResponse);
                }, operationRequest.getTimeout(), authToken, secretKey, customTags));
            }
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
                            .addAll(NetworkingPeerBase.fromMsgList(iList))
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
            if (this.httpRequestType == HttpRequestType.HTTPRequest)
            {
                getRequestViaHTTPRequest(subUri, onHttpAppResponse, timeout, authToken, secretKey);
            }
            else if (this.httpRequestType == HttpRequestType.UnityWebRequest)
            {
                StartCoroutine(ieGetRequestViaUnityWebRequest(subUri, onHttpAppResponse, timeout, authToken, secretKey));
            }
        }

        private void getRequestViaHTTPRequest(string subUri, Action<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey)
        {
            var request = new HTTPRequest(new Uri(this.httpUrl + "/" + subUri), HTTPMethods.Get, (httpRequest, httpResponse) =>
            {
                var httpAppResponse = new HttpAppResponse();

                if (httpRequest.State == HTTPRequestStates.Finished)
                {
                    httpAppResponse.statusCode = httpResponse.StatusCode;
                    httpAppResponse.data = httpResponse.Data;
                    httpAppResponse.text = httpResponse.DataAsText;
                }
                else
                {
                    httpAppResponse.statusCode = -1;
                    httpAppResponse.error = httpRequest.Exception != null ? httpRequest.Exception.Message : "Unknown Error";
                }

                onHttpAppResponse?.Invoke(httpAppResponse);
            });

            request.Timeout = TimeSpan.FromSeconds(timeout);

            if (!string.IsNullOrEmpty(authToken)) request.SetHeader(Commands.RequestAuthTokenCmd, authToken);
            if (!string.IsNullOrEmpty(secretKey)) request.SetHeader(Commands.RequestSecretCmd, secretKey);

            request.Send();
        }

        private IEnumerator ieGetRequestViaUnityWebRequest(string subUri, Action<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey)
        {
            using (var unityWebRequest = UnityWebRequest.Get(new Uri(this.httpUrl + "/" + subUri)))
            {
                var certificateHandler = new AcceptAllCertificatesSignedWithASpecificKeyPublicKey();
                unityWebRequest.certificateHandler = certificateHandler;

                unityWebRequest.timeout = (int)timeout;

                if (!string.IsNullOrEmpty(authToken)) unityWebRequest.SetRequestHeader(Commands.RequestAuthTokenCmd, authToken);
                if (!string.IsNullOrEmpty(secretKey)) unityWebRequest.SetRequestHeader(Commands.RequestSecretCmd, secretKey);
                //unityWebRequest.SetRequestHeader("User-Agent", UserAgent);

                yield return unityWebRequest.SendWebRequest();

                certificateHandler.Dispose();

                var httpAppResponse = new HttpAppResponse();
                httpAppResponse.statusCode = unityWebRequest.responseCode;

                if (unityWebRequest.result == UnityWebRequest.Result.ConnectionError
                    || unityWebRequest.result == UnityWebRequest.Result.ProtocolError
                    || unityWebRequest.result == UnityWebRequest.Result.DataProcessingError)
                {
                    httpAppResponse.error = unityWebRequest.error;
                }
                else
                {
                    var downloadHandler = unityWebRequest.downloadHandler;
                    httpAppResponse.data = downloadHandler.data;
                    httpAppResponse.text = downloadHandler.text;
                }

                onHttpAppResponse?.Invoke(httpAppResponse);
            }
        }

        private void postRequestViaHTTPRequest(string subUri, GNHashtable param, PostType postType, Action<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey, GNHashtable customTags)
        {
            var request = new HTTPRequest(new Uri(this.httpUrl + "/" + subUri), HTTPMethods.Post, (httpRequest, httpResponse) =>
            {
                var httpAppResponse = new HttpAppResponse();

                if (httpRequest.State == HTTPRequestStates.Finished)
                {
                    httpAppResponse.statusCode = httpResponse.StatusCode;
                    httpAppResponse.data = httpResponse.Data;
                    httpAppResponse.text = httpResponse.DataAsText;
                }
                else
                {
                    httpAppResponse.statusCode = -1;
                    httpAppResponse.error = httpRequest.Exception != null ? httpRequest.Exception.Message : "Unknown Error";
                }

                onHttpAppResponse?.Invoke(httpAppResponse);
            });

            if (param == null) param = new GNHashtable();

            if (customTags != null) param.add(GNParameterCode.CustomTags, customTags);

            if (postType == PostType.Json)
            {
                request.SetHeader(Commands.CONTENT_TYPE, Commands.APPLICATION_JSON);

                var content = Encoding.UTF8.GetBytes(Serializer.Serialize(param.toData()));

                request.UploadStream = new MemoryStream(content);
            }
            else if (postType == PostType.MsgPack)
            {
                request.SetHeader(Commands.CONTENT_TYPE, Commands.APPLICATION_MSGPACK);

                var dataSend = param.toData();

                var content = MsgPackSerializer.Serialize(dataSend);

                request.UploadStream = new MemoryStream(content);
            }

            request.Timeout = TimeSpan.FromSeconds(timeout);

            if (!string.IsNullOrEmpty(authToken)) request.SetHeader(Commands.RequestAuthTokenCmd, authToken);
            if (!string.IsNullOrEmpty(secretKey)) request.SetHeader(Commands.RequestSecretCmd, secretKey);

            request.Send();
        }

        private IEnumerator iePostRequestViaUnityWebRequest(string subUri, GNHashtable param, PostType postType, Action<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey, GNHashtable customTags)
        {
            using (var unityWebRequest = new UnityWebRequest(new Uri(this.httpUrl + "/" + subUri)))
            {
                unityWebRequest.method = UnityWebRequest.kHttpVerbPOST;

                var certificateHandler = new AcceptAllCertificatesSignedWithASpecificKeyPublicKey();
                unityWebRequest.certificateHandler = certificateHandler;

                unityWebRequest.timeout = (int)timeout;

                if (param == null) param = new GNHashtable();
                if (customTags != null) param.add(GNParameterCode.CustomTags, customTags);

                //unityWebRequest.SetRequestHeader("User-Agent", UserAgent);

                if (postType == PostType.Json)
                {
                    unityWebRequest.SetRequestHeader(Commands.CONTENT_TYPE, Commands.APPLICATION_JSON);

                    var content = Encoding.UTF8.GetBytes(Serializer.Serialize(param.toData()));

                    unityWebRequest.uploadHandler = new UploadHandlerRaw(content);
                }
                else if (postType == PostType.MsgPack)
                {
                    unityWebRequest.SetRequestHeader(Commands.CONTENT_TYPE, Commands.APPLICATION_MSGPACK);

                    var dataSend = param.toData();

                    var content = MsgPackSerializer.Serialize(dataSend);

                    unityWebRequest.uploadHandler = new UploadHandlerRaw(content);
                }

                unityWebRequest.downloadHandler = new DownloadHandlerBuffer();

                if (!string.IsNullOrEmpty(authToken)) unityWebRequest.SetRequestHeader(Commands.RequestAuthTokenCmd, authToken);
                if (!string.IsNullOrEmpty(secretKey)) unityWebRequest.SetRequestHeader(Commands.RequestSecretCmd, secretKey);

                yield return unityWebRequest.SendWebRequest();

                certificateHandler.Dispose();

                var httpAppResponse = new HttpAppResponse();
                httpAppResponse.statusCode = unityWebRequest.responseCode;

                if (unityWebRequest.result == UnityWebRequest.Result.ConnectionError
                    || unityWebRequest.result == UnityWebRequest.Result.ProtocolError
                    || unityWebRequest.result == UnityWebRequest.Result.DataProcessingError)
                {
                    httpAppResponse.error = unityWebRequest.error;
                }
                else
                {
                    var downloadHandler = unityWebRequest.downloadHandler;
                    httpAppResponse.data = downloadHandler.data;
                    httpAppResponse.text = downloadHandler.text;
                }

                onHttpAppResponse?.Invoke(httpAppResponse);
            }
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

            if (this.httpRequestType == HttpRequestType.HTTPRequest)
            {
                postRequestUploadViaHTTPRequest(subUri, content, mimetype, onHttpAppResponse, timeout);
            }
            else if (this.httpRequestType == HttpRequestType.UnityWebRequest)
            {
                StartCoroutine(iePostRequestUploadViaUnityWebRequest(subUri, content, mimetype, onHttpAppResponse, timeout));
            }
        }

        private void postRequestUploadViaHTTPRequest(string subUri, byte[] content, string mimetype, Action<HttpAppResponse> onHttpAppResponse, float timeout)
        {
            var request = new HTTPRequest(new Uri(this.httpUrl + "/" + subUri), HTTPMethods.Post, (httpRequest, httpResponse) =>
            {
                var httpAppResponse = new HttpAppResponse();

                if (httpRequest.State == HTTPRequestStates.Finished)
                {
                    httpAppResponse.statusCode = httpResponse.StatusCode;
                    httpAppResponse.data = httpResponse.Data;
                    httpAppResponse.text = httpResponse.DataAsText;
                }
                else
                {
                    httpAppResponse.statusCode = -1;
                    httpAppResponse.error = httpRequest.Exception != null ? httpRequest.Exception.Message : "Unknown Error";
                }

                onHttpAppResponse?.Invoke(httpAppResponse);
            });

            request.Timeout = TimeSpan.FromSeconds(timeout);

            request.AddBinaryData(Commands.File, content, null, mimetype);

            var authToken = GNNetwork.getAuthenticateStatus().getAuthToken();

            if (!string.IsNullOrEmpty(authToken)) request.SetHeader(Commands.RequestAuthTokenCmd, authToken);

            request.Send();
        }

        private IEnumerator iePostRequestUploadViaUnityWebRequest(string subUri, byte[] content, string mimetype, Action<HttpAppResponse> onHttpAppResponse, float timeout)
        {
            var form = new UnityEngine.WWWForm();
            form.AddBinaryData(Commands.File, content, null, mimetype);

            using (var unityWebRequest = UnityWebRequest.Post(new Uri(this.httpUrl + "/" + subUri), form))
            {
                var certificateHandler = new AcceptAllCertificatesSignedWithASpecificKeyPublicKey();

                unityWebRequest.certificateHandler = certificateHandler;

                unityWebRequest.timeout = (int)timeout;

                var authToken = GNNetwork.getAuthenticateStatus().getAuthToken();

                if (!string.IsNullOrEmpty(authToken)) unityWebRequest.SetRequestHeader(Commands.RequestAuthTokenCmd, authToken);

                //unityWebRequest.SetRequestHeader("User-Agent", UserAgent);

                yield return unityWebRequest.SendWebRequest();

                certificateHandler.Dispose();

                var httpAppResponse = new HttpAppResponse();
                httpAppResponse.statusCode = unityWebRequest.responseCode;

                if (unityWebRequest.result == UnityWebRequest.Result.ConnectionError
                    || unityWebRequest.result == UnityWebRequest.Result.ProtocolError
                    || unityWebRequest.result == UnityWebRequest.Result.DataProcessingError)
                {
                    httpAppResponse.error = unityWebRequest.error;
                }
                else
                {
                    var downloadHandler = unityWebRequest.downloadHandler;
                    httpAppResponse.data = downloadHandler.data;
                    httpAppResponse.text = downloadHandler.text;
                }

                onHttpAppResponse?.Invoke(httpAppResponse);
            }
        }

    }

}
