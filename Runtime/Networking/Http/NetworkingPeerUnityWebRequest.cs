namespace XmobiTea.GearN.Networking.Http
{
    using System;
    using System.Collections;
    using System.Text;
    using UnityEngine.Networking;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Helper;
    using XmobiTea.GearN.Unity;

    /// <summary>
    /// Handles HTTP networking using UnityWebRequest.
    /// </summary>
    internal class NetworkingPeerUnityWebRequest : NetworkingHttpPeerBase
    {
        /// <summary>
        /// A certificate handler to accept all certificates. 
        /// Used for environments where certificates cannot be validated.
        /// </summary>
        class AcceptAllCertificatesSignedWithASpecificKeyPublicKey : CertificateHandler
        {
            protected override bool ValidateCertificate(byte[] certificateData)
            {
                return true;
            }
        }

        private UnityEngine.MonoBehaviour unityMonoBehaviour;

        /// <summary>
        /// Sends a GET request using UnityWebRequest.
        /// </summary>
        /// <param name="subUri">The sub-URI for the request.</param>
        /// <param name="onHttpAppResponse">Callback to handle the HTTP response.</param>
        /// <param name="timeout">Timeout for the request, in seconds.</param>
        /// <param name="authToken">Optional authentication token.</param>
        /// <param name="secretKey">Optional secret key.</param>
        public override void getRequest(string subUri, Action<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey, string gameId)
        {
            this.unityMonoBehaviour.StartCoroutine(this.ieGetRequestViaUnityWebRequest(subUri, onHttpAppResponse, timeout, authToken, secretKey, gameId));
        }

        /// <summary>
        /// Sends a POST request with specified parameters and content type using UnityWebRequest.
        /// </summary>
        /// <param name="subUri">The sub-URI for the request.</param>
        /// <param name="param">The parameters to include in the request.</param>
        /// <param name="postType">The type of POST request (e.g., JSON, MsgPack).</param>
        /// <param name="onHttpAppResponse">Callback to handle the HTTP response.</param>
        /// <param name="timeout">Timeout for the request, in seconds.</param>
        /// <param name="authToken">Optional authentication token.</param>
        /// <param name="secretKey">Optional secret key.</param>
        /// <param name="customTags">Optional custom tags.</param>
        public override void postRequest(string subUri, GNHashtable param, PostType postType, Action<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey, GNHashtable customTags, string gameId)
        {
            this.unityMonoBehaviour.StartCoroutine(this.iePostRequestViaUnityWebRequest(subUri, param, postType, onHttpAppResponse, timeout, authToken, secretKey, customTags, gameId));
        }

        /// <summary>
        /// Sends a file upload request using UnityWebRequest.
        /// </summary>
        /// <param name="subUri">The sub-URI for the request.</param>
        /// <param name="content">The file content to upload.</param>
        /// <param name="mimetype">The MIME type of the file.</param>
        /// <param name="onHttpAppResponse">Callback to handle the HTTP response.</param>
        /// <param name="timeout">Timeout for the request, in seconds.</param>
        public override void postRequestUpload(string subUri, byte[] content, string filename, string mimetype, Action<HttpAppResponse> onHttpAppResponse, float timeout)
        {
            this.unityMonoBehaviour.StartCoroutine(this.iePostRequestUploadViaUnityWebRequest(subUri, content, filename, mimetype, onHttpAppResponse, timeout));
        }

        private IEnumerator ieGetRequestViaUnityWebRequest(string subUri, Action<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey, string gameId)
        {
            using (var unityWebRequest = UnityWebRequest.Get(new Uri(this.httpUrl + "/" + subUri)))
            {
                var certificateHandler = new AcceptAllCertificatesSignedWithASpecificKeyPublicKey();
                unityWebRequest.certificateHandler = certificateHandler;

                unityWebRequest.timeout = (int)timeout;

                if (!string.IsNullOrEmpty(authToken)) unityWebRequest.SetRequestHeader(Commands.RequestAuthTokenCmd, authToken);
                if (!string.IsNullOrEmpty(secretKey)) unityWebRequest.SetRequestHeader(Commands.RequestSecretCmd, secretKey);
                if (!string.IsNullOrEmpty(gameId)) unityWebRequest.SetRequestHeader(Commands.RequestGameIdCmd, gameId);

                yield return unityWebRequest.SendWebRequest();

                certificateHandler.Dispose();

                var httpAppResponse = new HttpAppResponse
                {
                    statusCode = (int)unityWebRequest.responseCode
                };

                if (unityWebRequest.result == UnityWebRequest.Result.ConnectionError ||
                    unityWebRequest.result == UnityWebRequest.Result.ProtocolError ||
                    unityWebRequest.result == UnityWebRequest.Result.DataProcessingError)
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

        private IEnumerator iePostRequestViaUnityWebRequest(string subUri, GNHashtable param, PostType postType, Action<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey, GNHashtable customTags, string gameId)
        {
            using (var unityWebRequest = new UnityWebRequest(new Uri(this.httpUrl + "/" + subUri)))
            {
                unityWebRequest.method = UnityWebRequest.kHttpVerbPOST;

                var certificateHandler = new AcceptAllCertificatesSignedWithASpecificKeyPublicKey();
                unityWebRequest.certificateHandler = certificateHandler;

                unityWebRequest.timeout = (int)timeout;

                if (param == null) param = new GNHashtable();
                if (customTags != null) param.add(ParameterCode.CustomTags, customTags);

                if (postType == PostType.Json)
                {
                    unityWebRequest.SetRequestHeader(Commands.CONTENT_TYPE, Commands.APPLICATION_JSON);
                    var content = Encoding.UTF8.GetBytes(Serializer.Serialize(param.toData()));
                    unityWebRequest.uploadHandler = new UploadHandlerRaw(content);
                }
                else if (postType == PostType.MsgPack)
                {
                    unityWebRequest.SetRequestHeader(Commands.CONTENT_TYPE, Commands.APPLICATION_MSGPACK);
                    var content = MessagePackConverterService.serialize(param.toData());
                    unityWebRequest.uploadHandler = new UploadHandlerRaw(content);
                }

                unityWebRequest.downloadHandler = new DownloadHandlerBuffer();

                if (!string.IsNullOrEmpty(authToken)) unityWebRequest.SetRequestHeader(Commands.RequestAuthTokenCmd, authToken);
                if (!string.IsNullOrEmpty(secretKey)) unityWebRequest.SetRequestHeader(Commands.RequestSecretCmd, secretKey);
                if (!string.IsNullOrEmpty(gameId)) unityWebRequest.SetRequestHeader(Commands.RequestGameIdCmd, gameId);

                yield return unityWebRequest.SendWebRequest();

                certificateHandler.Dispose();

                var httpAppResponse = new HttpAppResponse
                {
                    statusCode = (int)unityWebRequest.responseCode
                };

                if (unityWebRequest.result == UnityWebRequest.Result.ConnectionError ||
                    unityWebRequest.result == UnityWebRequest.Result.ProtocolError ||
                    unityWebRequest.result == UnityWebRequest.Result.DataProcessingError)
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

        private IEnumerator iePostRequestUploadViaUnityWebRequest(string subUri, byte[] content, string filename, string mimetype, Action<HttpAppResponse> onHttpAppResponse, float timeout)
        {
            var form = new UnityEngine.WWWForm();
            form.AddBinaryData(Commands.File, content, filename, mimetype);

            using (var unityWebRequest = UnityWebRequest.Post(new Uri(this.httpUrl + "/" + subUri), form))
            {
                var certificateHandler = new AcceptAllCertificatesSignedWithASpecificKeyPublicKey();

                unityWebRequest.certificateHandler = certificateHandler;

                unityWebRequest.timeout = (int)timeout;

                var authToken = GNNetwork.getAuthenticateStatus().getAuthToken();

                if (!string.IsNullOrEmpty(authToken)) unityWebRequest.SetRequestHeader(Commands.RequestAuthTokenCmd, authToken);

                yield return unityWebRequest.SendWebRequest();

                certificateHandler.Dispose();

                var httpAppResponse = new HttpAppResponse
                {
                    statusCode = (int)unityWebRequest.responseCode
                };

                if (unityWebRequest.result == UnityWebRequest.Result.ConnectionError ||
                    unityWebRequest.result == UnityWebRequest.Result.ProtocolError ||
                    unityWebRequest.result == UnityWebRequest.Result.DataProcessingError)
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

        /// <summary>
        /// Constructor initializes Unity MonoBehaviour for coroutines.
        /// </summary>
        public NetworkingPeerUnityWebRequest()
        {
            this.unityMonoBehaviour = new UnityEngine.GameObject("[GN] UnityWebRequestSupport").AddComponent<ServiceCoroutine>();

            UnityEngine.GameObject.DontDestroyOnLoad(this.unityMonoBehaviour.gameObject);
        }
    }
}
