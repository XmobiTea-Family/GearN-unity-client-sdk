namespace XmobiTea.GN.Networking.Http
{
    using System;
    using System.Collections;
    using System.Text;
    using UnityEngine;
    using UnityEngine.Networking;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Helper;
    using XmobiTea.MsgPack;

    internal class NetworkingPeerUnityWebRequest : NetworkingHttpPeerBase
    {
        class AcceptAllCertificatesSignedWithASpecificKeyPublicKey : CertificateHandler
        {
            protected override bool ValidateCertificate(byte[] certificateData)
            {
                return true;
            }
        }

        private MonoBehaviour unityMonoBehaviour;

        public override void getRequest(string subUri, Action<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey)
        {
            this.unityMonoBehaviour.StartCoroutine(this.ieGetRequestViaUnityWebRequest(subUri, onHttpAppResponse, timeout, authToken, secretKey));
        }

        public override void postRequest(string subUri, GNHashtable param, PostType postType, Action<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey, GNHashtable customTags)
        {
            this.unityMonoBehaviour.StartCoroutine(this.iePostRequestViaUnityWebRequest(subUri, param, postType, onHttpAppResponse, timeout, authToken, secretKey, customTags));
        }

        public override void postRequestUpload(string subUri, byte[] content, string mimetype, Action<HttpAppResponse> onHttpAppResponse, float timeout)
        {
            this.unityMonoBehaviour.StartCoroutine(this.iePostRequestUploadViaUnityWebRequest(subUri, content, mimetype, onHttpAppResponse, timeout));
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

        public NetworkingPeerUnityWebRequest()
        {
            this.unityMonoBehaviour = new GameObject("[GN] UnityWebRequestSupport").AddComponent<MonoBehaviour>();
        }
    }

}
