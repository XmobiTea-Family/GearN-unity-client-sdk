namespace XmobiTea.GearN.Networking.Http
{
#if UNITY_USING_BEST_HTTP

    using BestHTTP;
    using System;
    using System.IO;
    using System.Text;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Helper;

    /// <summary>
    /// Handles HTTP requests using BestHTTP library.
    /// </summary>
    internal class NetworkingPeerHttpRequest : NetworkingHttpPeerBase
    {
        /// <summary>
        /// Sends a GET request to the specified URI.
        /// </summary>
        /// <param name="subUri">The sub-URI for the request.</param>
        /// <param name="onHttpAppResponse">Callback to handle the HTTP response.</param>
        /// <param name="timeout">Timeout for the request, in seconds.</param>
        /// <param name="authToken">Optional authentication token.</param>
        /// <param name="secretKey">Optional secret key.</param>
        public override void getRequest(string subUri, Action<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey, string gameId)
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
            if (!string.IsNullOrEmpty(gameId)) request.SetHeader(Commands.RequestGameIdCmd, gameId);

            request.Send();
        }

        /// <summary>
        /// Sends a POST request with specified parameters and content type.
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
            if (customTags != null) param.add(ParameterCode.CustomTags, customTags);

            if (postType == PostType.Json)
            {
                request.SetHeader(Commands.CONTENT_TYPE, Commands.APPLICATION_JSON);
                var content = Encoding.UTF8.GetBytes(Serializer.Serialize(param.toData()));
                request.UploadStream = new MemoryStream(content);
            }
            else if (postType == PostType.MsgPack)
            {
                request.SetHeader(Commands.CONTENT_TYPE, Commands.APPLICATION_MSGPACK);
                var content = MessagePackConverterService.serialize(param.toData());
                request.UploadStream = new MemoryStream(content);
            }

            request.Timeout = TimeSpan.FromSeconds(timeout);

            if (!string.IsNullOrEmpty(authToken)) request.SetHeader(Commands.RequestAuthTokenCmd, authToken);
            if (!string.IsNullOrEmpty(secretKey)) request.SetHeader(Commands.RequestSecretCmd, secretKey);
            if (!string.IsNullOrEmpty(gameId)) request.SetHeader(Commands.RequestGameIdCmd, gameId);

            request.Send();
        }

        /// <summary>
        /// Sends a file upload request to the specified URI.
        /// </summary>
        /// <param name="subUri">The sub-URI for the request.</param>
        /// <param name="content">The file content to upload.</param>
        /// <param name="mimetype">The MIME type of the file.</param>
        /// <param name="onHttpAppResponse">Callback to handle the HTTP response.</param>
        /// <param name="timeout">Timeout for the request, in seconds.</param>
        public override void postRequestUpload(string subUri, byte[] content, string filename, string mimetype, Action<HttpAppResponse> onHttpAppResponse, float timeout)
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
            request.AddBinaryData(Commands.File, content, filename, mimetype);

            var authToken = GNNetwork.getAuthenticateStatus().getAuthToken();
            if (!string.IsNullOrEmpty(authToken)) request.SetHeader(Commands.RequestAuthTokenCmd, authToken);

            request.Send();
        }

        /// <summary>
        /// Initializes the HTTP peer with the specified URL and user agent.
        /// </summary>
        /// <param name="httpUrl">The base URL for the HTTP requests.</param>
        /// <param name="userAgent">The user agent string to include in the requests.</param>
        public override void init(string httpUrl, string userAgent)
        {
            base.init(httpUrl, userAgent);
            HTTPManager.UserAgent = userAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkingPeerHttpRequest"/> class.
        /// </summary>
        public NetworkingPeerHttpRequest()
        {
            HTTPManager.KeepAliveDefaultValue = true;
        }
    }
#endif
}
