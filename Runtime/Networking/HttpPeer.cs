namespace XmobiTea.GN.Networking
{
    using System;

    using UnityEngine;

    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Helper;
    using XmobiTea.GN.Common;
    using BestHTTP;
    using UnityEngine.Networking;
    using System.Collections;
    using XmobiTea.GN.Config;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;
    using XmobiTea.MsgPack;

    public class HttpAppResponse
    {
        public long statusCode { get; internal set; }
        public string error { get; internal set; }
        public byte[] data { get; internal set; }
        public string text { get; internal set; }

        public bool HasError => !string.IsNullOrEmpty(error);

        public override string ToString()
        {
            var stringBuilder = new System.Text.StringBuilder();

            stringBuilder.Append(" StatusCode: " + statusCode);
            if (!string.IsNullOrEmpty(error)) stringBuilder.Append(", <color=red>Error: " + error + "</color>");
            stringBuilder.Append(", Text: " + text);

            return stringBuilder.ToString();
        }
    }

    internal class HttpPeer : PeerBase
    {
        private const string CONTENT_TYPE = "Content-Type";
        private const string APPLICATION_JSON = "application/json";
        private const string APPLICATION_MSGPACK = "application/msgpack";
        private static string userAgent { get; set; }

        private string httpUrl;
        private HttpRequestType httpRequestType;
        private PostType postType;

        class AcceptAllCertificatesSignedWithASpecificKeyPublicKey : CertificateHandler
        {
            protected override bool ValidateCertificate(byte[] certificateData)
            {
                return true;
            }
        }

        internal override void InitGNSocketObject()
        {
            base.InitGNSocketObject();

            var gnServerSettings = GNNetwork.gnServerSettings;
            if (gnServerSettings == null) throw new NullReferenceException("Where is GN Server Settings");

            httpRequestType = gnServerSettings.httpRequestType;
            postType = gnServerSettings.postType;
            httpUrl = gnServerSettings.HttpUrl;

            userAgent = "GN-unity-" + GNNetwork.platform + "@" + GNNetwork.version;

            if (httpRequestType == HttpRequestType.HTTPRequest)
            {
                HTTPManager.UserAgent = userAgent;
                HTTPManager.KeepAliveDefaultValue = false;
            }
        }

        internal override void Send(OperationPending operationPending)
        {
            base.Send(operationPending);

            Debug.Log("[GN HTTP SEND] " + operationPending.GetOperationRequest().ToString());

            var operationRequest = operationPending.GetOperationRequest();

            var authToken = GNNetwork.authToken;

            if (string.IsNullOrEmpty(authToken))
            {
                if (!GNNetwork.gnServerSettings.codeCanSendNotAuthorized.Contains(operationRequest.GetOperationCode()))
                {
                    var obj = new GNArray();

                    obj.Add((int)ReturnCode.OperationNotAuthorized);
                    obj.Add(null);
                    obj.Add(operationRequest.GetRequestId());

                    OnResponseHandler(obj);

                    return;
                }
            }

            var subUri = (postType == PostType.Json ? NetworkingPeer.API_JSON : NetworkingPeer.API_MSG_PACK) + "/" + operationRequest.GetOperationCode();

            if (httpRequestType == HttpRequestType.HTTPRequest)
            {
                PostRequestViaHTTPRequest(subUri, operationRequest.GetParameters(), postType, httpAppResponse =>
                {
                    OnSendOperationRequestResponse(operationPending, httpAppResponse);
                }, operationRequest.GetTimeOut());
            }
            else if (httpRequestType == HttpRequestType.UnityWebRequest)
            {
                StartCoroutine(IEPostRequestViaUnityWebRequest(subUri, operationRequest.GetParameters(), postType, httpAppResponse =>
                {
                    OnSendOperationRequestResponse(operationPending, httpAppResponse);
                }, operationRequest.GetTimeOut()));
            }
        }

        void OnSendOperationRequestResponse(OperationPending operationPending, HttpAppResponse httpAppResponse)
        {
            var operationRequest = operationPending.GetOperationRequest();
            var obj = new GNArray();

            if (!httpAppResponse.HasError)
            {
                if (httpAppResponse.statusCode == 200)
                {
                    if (postType == PostType.MsgPack)
                    {
                        var iList = MsgPackSerializer.Deserialize<object[]>(httpAppResponse.data);

                        var gnArray = new GNArray.Builder().AddAll(NetworkingPeerBase.fromMsgList(iList)).Build();

                        var returnCode = gnArray.GetInt(0);
                        obj.Add(returnCode);

                        if (returnCode == (int)ReturnCode.Ok)
                        {
                            obj.Add(gnArray.GetGNHashtable(1, new GNHashtable()));
                        }
                        else if (returnCode == ReturnCode.InvalidRequestParameters)
                        {
                            obj.Add(gnArray.GetGNArray(1, new GNArray()));
                        }
                        else
                        {
                            obj.Add(gnArray.GetString(1));
                        }
                    }
                    else if (postType == PostType.Json)
                    {
                        var returnDatas = (System.Collections.IList)Parser.Parse(httpAppResponse.text);
                        var gnArray = new GNArray.Builder()
                            .AddAll(returnDatas)
                            .Build();

                        var returnCode = gnArray.GetInt(0);
                        obj.Add(returnCode);

                        if (returnCode == ReturnCode.Ok)
                        {
                            obj.Add(gnArray.GetGNHashtable(1, new GNHashtable()));
                        }
                        else if (returnCode == ReturnCode.InvalidRequestParameters)
                        {
                            obj.Add(gnArray.GetGNArray(1, new GNArray()));
                        }
                        else
                        {
                            obj.Add(gnArray.GetString(1, string.Empty));
                        }
                    }

                    obj.Add(operationRequest.GetRequestId());

                    OnResponseHandler(obj);
                    return;
                }
            }

            obj.Add((int)ReturnCode.UnknownError);
            obj.Add(httpAppResponse.error);
            obj.Add(operationRequest.GetRequestId());

            OnResponseHandler(obj);
        }

        internal void GetRequest(string subUri, Action<HttpAppResponse> onHttpAppResponse, float timeout = 15)
        {
            if (httpRequestType == HttpRequestType.HTTPRequest)
            {
                GetRequestViaHTTPRequest(subUri, onHttpAppResponse, timeout);
            }
            else if (httpRequestType == HttpRequestType.UnityWebRequest)
            {
                StartCoroutine(IEGetRequestViaUnityWebRequest(subUri, onHttpAppResponse, timeout));
            }
        }

        private void GetRequestViaHTTPRequest(string subUri, Action<HttpAppResponse> onHttpAppResponse, float timeout)
        {
            var request = new HTTPRequest(new Uri(httpUrl + "/" + subUri), HTTPMethods.Get, (httpRequest, httpResponse) =>
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

            var authToken = GNNetwork.authToken;

            if (!string.IsNullOrEmpty(authToken)) request.SetHeader(Commands.RequestAuthTokenCmd, authToken);

            request.Send();
        }

        private IEnumerator IEGetRequestViaUnityWebRequest(string subUri, Action<HttpAppResponse> onHttpAppResponse, float timeout)
        {
            using (var unityWebRequest = UnityWebRequest.Get(new Uri(httpUrl + "/" + subUri)))
            {
                var certificateHandler = new AcceptAllCertificatesSignedWithASpecificKeyPublicKey();
                unityWebRequest.certificateHandler = certificateHandler;

                unityWebRequest.timeout = (int)timeout;

                var authToken = GNNetwork.authToken;

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

        private void PostRequestViaHTTPRequest(string subUri, GNHashtable param, PostType postType, Action<HttpAppResponse> onHttpAppResponse, float timeout)
        {
            var request = new HTTPRequest(new Uri(httpUrl + "/" + subUri), HTTPMethods.Post, (httpRequest, httpResponse) =>
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

            if (postType == PostType.Json)
            {
                request.SetHeader(CONTENT_TYPE, APPLICATION_JSON);

                var content = Encoding.UTF8.GetBytes(Serializer.Serialize(param.ToData()));

                request.UploadStream = new MemoryStream(content);
            }
            else if (postType == PostType.MsgPack)
            {
                request.SetHeader(CONTENT_TYPE, APPLICATION_MSGPACK);

                var dataSend = param.ToData();

                var content = MsgPackSerializer.Serialize(dataSend);

                request.UploadStream = new MemoryStream(content);
            }

            request.Timeout = TimeSpan.FromSeconds(timeout);

            var authToken = GNNetwork.authToken;

            if (!string.IsNullOrEmpty(authToken)) request.SetHeader(Commands.RequestAuthTokenCmd, authToken);

            request.Send();
        }

        private IEnumerator IEPostRequestViaUnityWebRequest(string subUri, GNHashtable param, PostType postType, Action<HttpAppResponse> onHttpAppResponse, float timeout)
        {
            using (var unityWebRequest = new UnityWebRequest(new Uri(httpUrl + "/" + subUri)))
            {
                unityWebRequest.method = UnityWebRequest.kHttpVerbPOST;

                var certificateHandler = new AcceptAllCertificatesSignedWithASpecificKeyPublicKey();
                unityWebRequest.certificateHandler = certificateHandler;

                unityWebRequest.timeout = (int)timeout;

                if (param == null) param = new GNHashtable();

                //unityWebRequest.SetRequestHeader("User-Agent", UserAgent);

                if (postType == PostType.Json)
                {
                    unityWebRequest.SetRequestHeader(CONTENT_TYPE, APPLICATION_JSON);

                    var content = Encoding.UTF8.GetBytes(Serializer.Serialize(param.ToData()));

                    unityWebRequest.uploadHandler = new UploadHandlerRaw(content);
                }
                else if (postType == PostType.MsgPack)
                {
                    unityWebRequest.SetRequestHeader(CONTENT_TYPE, APPLICATION_MSGPACK);

                    var dataSend = param.ToData();

                    var content = MsgPackSerializer.Serialize(dataSend);

                    unityWebRequest.uploadHandler = new UploadHandlerRaw(content);
                }

                unityWebRequest.downloadHandler = new DownloadHandlerBuffer();

                var authToken = GNNetwork.authToken;

                if (!string.IsNullOrEmpty(authToken)) unityWebRequest.SetRequestHeader(Commands.RequestAuthTokenCmd, authToken);

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

        internal void UploadFile(string fileId, byte[] content, string mimetype, Action<HttpAppResponse> onHttpAppResponse, float timeout = 60)
        {
            var authToken = GNNetwork.authToken;

            if (string.IsNullOrEmpty(authToken))
            {
                var httpAppResponse = new HttpAppResponse();
                httpAppResponse.statusCode = 401;
                httpAppResponse.error = "Auth token null";

                onHttpAppResponse?.Invoke(httpAppResponse);

                return;
            }

            var subUri = NetworkingPeer.UPLOAD_FILE + "/" + fileId;

            if (httpRequestType == HttpRequestType.HTTPRequest)
            {
                PostRequestUploadViaHTTPRequest(subUri, content, mimetype, onHttpAppResponse, timeout);
            }
            else if (httpRequestType == HttpRequestType.UnityWebRequest)
            {
                StartCoroutine(IEPostRequestUploadViaUnityWebRequest(subUri, content, mimetype, onHttpAppResponse, timeout));
            }
        }

        private void PostRequestUploadViaHTTPRequest(string subUri, byte[] content, string mimetype, Action<HttpAppResponse> onHttpAppResponse, float timeout)
        {
            var request = new HTTPRequest(new Uri(httpUrl + "/" + subUri), HTTPMethods.Post, (httpRequest, httpResponse) =>
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

            var authToken = GNNetwork.authToken;

            if (!string.IsNullOrEmpty(authToken)) request.SetHeader(Commands.RequestAuthTokenCmd, authToken);

            request.Send();
        }

        private IEnumerator IEPostRequestUploadViaUnityWebRequest(string subUri, byte[] content, string mimetype, Action<HttpAppResponse> onHttpAppResponse, float timeout)
        {
            var form = new WWWForm();
            form.AddBinaryData(Commands.File, content, null, mimetype);

            using (var unityWebRequest = UnityWebRequest.Post(new Uri(httpUrl + "/" + subUri), form))
            {
                var certificateHandler = new AcceptAllCertificatesSignedWithASpecificKeyPublicKey();

                unityWebRequest.certificateHandler = certificateHandler;

                unityWebRequest.timeout = (int)timeout;

                var authToken = GNNetwork.authToken;

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
