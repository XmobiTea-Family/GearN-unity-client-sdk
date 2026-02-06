namespace XmobiTea.GearN.Networking.Http
{
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Helper;

    /// <summary>
    /// Handles HTTP networking using HttpClientRequest or HttpClient.
    /// </summary>
    internal class NetworkingPeerHttpClientRequest : NetworkingHttpPeerBase
    {
        private readonly HttpClient client;

        private readonly float DefaultTimeout = 20;

        /// <summary>
        /// Sends a GET request using HttpClientRequest or HttpClient.
        /// </summary>
        /// <param name="subUri">The sub-URI for the request.</param>
        /// <param name="onHttpAppResponse">Callback to handle the HTTP response.</param>
        /// <param name="timeout">Timeout for the request, in seconds.</param>
        /// <param name="authToken">Optional authentication token.</param>
        /// <param name="secretKey">Optional secret key.</param>
        public override void getRequest(string subUri, Action1<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey, string gameId)
        {
            this.getRequestViaHttpWeb(subUri, onHttpAppResponse, timeout, authToken, secretKey, gameId);
        }

        private async void getRequestViaHttpWeb(string subUri, Action1<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey, string gameId)
        {
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, this.httpUrl + "/" + subUri))
            {
                if (!string.IsNullOrEmpty(authToken)) requestMessage.Headers.Add(Commands.RequestAuthTokenCmd, authToken);
                if (!string.IsNullOrEmpty(secretKey)) requestMessage.Headers.Add(Commands.RequestSecretCmd, secretKey);
                if (!string.IsNullOrEmpty(gameId)) requestMessage.Headers.Add(Commands.RequestGameIdCmd, gameId);

                if (timeout == DefaultTimeout)
                {
                    try
                    {
                        var webResponse = await this.client.SendAsync(requestMessage);

                        var httpAppResponse = new HttpAppResponse
                        {
                            statusCode = (int)webResponse.StatusCode
                        };

                        if (webResponse.StatusCode == HttpStatusCode.OK)
                        {
                            httpAppResponse.data = await webResponse.Content.ReadAsByteArrayAsync();
                            httpAppResponse.text = await webResponse.Content.ReadAsStringAsync();
                        }
                        else
                        {
                            httpAppResponse.error = webResponse.ReasonPhrase;
                        }

                        onHttpAppResponse?.Invoke(httpAppResponse);
                    }
                    catch (System.Exception e)
                    {
                        var httpAppResponse = new HttpAppResponse
                        {
                            statusCode = -1,
                            error = e.Message
                        };

                        onHttpAppResponse?.Invoke(httpAppResponse);
                    }
                }
                else
                {
                    using (var httpClient = new HttpClient())
                    {
                        httpClient.Timeout = System.TimeSpan.FromSeconds(timeout);

                        try
                        {
                            var webResponse = await httpClient.SendAsync(requestMessage);

                            var httpAppResponse = new HttpAppResponse
                            {
                                statusCode = (int)webResponse.StatusCode
                            };

                            if (webResponse.StatusCode == HttpStatusCode.OK)
                            {
                                httpAppResponse.data = await webResponse.Content.ReadAsByteArrayAsync();
                                httpAppResponse.text = await webResponse.Content.ReadAsStringAsync();
                            }
                            else
                            {
                                httpAppResponse.error = webResponse.ReasonPhrase;
                            }

                            onHttpAppResponse?.Invoke(httpAppResponse);
                        }
                        catch (System.Exception e)
                        {
                            var httpAppResponse = new HttpAppResponse
                            {
                                statusCode = -1,
                                error = e.Message
                            };

                            onHttpAppResponse?.Invoke(httpAppResponse);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Sends a POST request using HttpClientRequest or HttpClient.
        /// </summary>
        /// <param name="subUri">The sub-URI for the request.</param>
        /// <param name="param">The parameters to include in the request.</param>
        /// <param name="postType">The type of POST request (e.g., JSON, MsgPack).</param>
        /// <param name="onHttpAppResponse">Callback to handle the HTTP response.</param>
        /// <param name="timeout">Timeout for the request, in seconds.</param>
        /// <param name="authToken">Optional authentication token.</param>
        /// <param name="secretKey">Optional secret key.</param>
        /// <param name="customTags">Optional custom tags.</param>
        public override void postRequest(string subUri, GNHashtable param, PostType postType, Action1<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey, GNHashtable customTags, string gameId)
        {
            this.postRequestViaHttpWeb(subUri, param, postType, onHttpAppResponse, timeout, authToken, secretKey, customTags, gameId);
        }

        private async void postRequestViaHttpWeb(string subUri, GNHashtable param, PostType postType, Action1<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey, GNHashtable customTags, string gameId)
        {
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, this.httpUrl + "/" + subUri))
            {
                if (param == null) param = new GNHashtable();
                if (customTags != null) param.add(ParameterCode.CustomTags, customTags);

                if (postType == PostType.Json)
                {
                    var content = System.Text.Encoding.UTF8.GetBytes(Serializer.Serialize(param.toData()));
                    requestMessage.Content = new ByteArrayContent(content);
                    requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue(Commands.APPLICATION_JSON);
                }
                else if (postType == PostType.MsgPack)
                {
                    var content = MessagePackConverterService.serialize(param.toData());
                    requestMessage.Content = new ByteArrayContent(content);
                    requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue(Commands.APPLICATION_MSGPACK);
                }

                if (!string.IsNullOrEmpty(authToken)) requestMessage.Headers.Add(Commands.RequestAuthTokenCmd, authToken);
                if (!string.IsNullOrEmpty(secretKey)) requestMessage.Headers.Add(Commands.RequestSecretCmd, secretKey);
                if (!string.IsNullOrEmpty(gameId)) requestMessage.Headers.Add(Commands.RequestGameIdCmd, gameId);

                if (timeout == DefaultTimeout)
                {
                    try
                    {
                        var webResponse = await this.client.SendAsync(requestMessage);

                        var httpAppResponse = new HttpAppResponse
                        {
                            statusCode = (int)webResponse.StatusCode
                        };

                        if (webResponse.StatusCode == HttpStatusCode.OK)
                        {
                            httpAppResponse.data = await webResponse.Content.ReadAsByteArrayAsync();
                            httpAppResponse.text = await webResponse.Content.ReadAsStringAsync();
                        }
                        else
                        {
                            httpAppResponse.error = webResponse.ReasonPhrase;
                        }

                        onHttpAppResponse?.Invoke(httpAppResponse);
                    }
                    catch (System.Exception e)
                    {
                        var httpAppResponse = new HttpAppResponse
                        {
                            statusCode = -1,
                            error = e.Message
                        };

                        onHttpAppResponse?.Invoke(httpAppResponse);
                    }
                }
                else
                {
                    using (var httpClient = new HttpClient())
                    {
                        httpClient.Timeout = System.TimeSpan.FromSeconds(timeout);

                        try
                        {
                            var webResponse = await httpClient.SendAsync(requestMessage);

                            var httpAppResponse = new HttpAppResponse
                            {
                                statusCode = (int)webResponse.StatusCode
                            };

                            if (webResponse.StatusCode == HttpStatusCode.OK)
                            {
                                httpAppResponse.data = await webResponse.Content.ReadAsByteArrayAsync();
                                httpAppResponse.text = await webResponse.Content.ReadAsStringAsync();
                            }
                            else
                            {
                                httpAppResponse.error = webResponse.ReasonPhrase;
                            }

                            onHttpAppResponse?.Invoke(httpAppResponse);
                        }
                        catch (System.Exception e)
                        {
                            var httpAppResponse = new HttpAppResponse
                            {
                                statusCode = -1,
                                error = e.Message
                            };

                            onHttpAppResponse?.Invoke(httpAppResponse);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Sends a file upload request using HttpClientRequest or HttpClient.
        /// </summary>
        /// <param name="subUri">The sub-URI for the request.</param>
        /// <param name="content">The file content to upload.</param>
        /// <param name="mimetype">The MIME type of the file.</param>
        /// <param name="onHttpAppResponse">Callback to handle the HTTP response.</param>
        /// <param name="timeout">Timeout for the request, in seconds.</param>
        public override void postRequestUpload(string subUri, byte[] content, string filename, string mimetype, Action1<HttpAppResponse> onHttpAppResponse, float timeout)
        {
            this.postRequestUploadViaHttpWeb(subUri, content, filename, mimetype, onHttpAppResponse, timeout);
        }

        private async void postRequestUploadViaHttpWeb(string subUri, byte[] content, string filename, string mimetype, Action1<HttpAppResponse> onHttpAppResponse, float timeout)
        {
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, this.httpUrl + "/" + subUri))
            {
                var authToken = GNNetwork.getAuthenticateStatus().getAuthToken();
                if (!string.IsNullOrEmpty(authToken)) requestMessage.Headers.Add(Commands.RequestAuthTokenCmd, authToken);

                var multipartContent = new MultipartFormDataContent();

                var byteArrayContent = new ByteArrayContent(content);
                byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue(mimetype);
                multipartContent.Add(byteArrayContent, Commands.File, filename);

                requestMessage.Content = multipartContent;

                using (var httpClient = new HttpClient())
                {
                    httpClient.Timeout = System.TimeSpan.FromSeconds(timeout);

                    try
                    {
                        var webResponse = await httpClient.SendAsync(requestMessage);

                        var httpAppResponse = new HttpAppResponse
                        {
                            statusCode = (int)webResponse.StatusCode
                        };

                        if (webResponse.StatusCode == HttpStatusCode.OK)
                        {
                            httpAppResponse.data = await webResponse.Content.ReadAsByteArrayAsync();
                            httpAppResponse.text = await webResponse.Content.ReadAsStringAsync();
                        }
                        else
                        {
                            httpAppResponse.error = webResponse.ReasonPhrase;
                        }

                        onHttpAppResponse?.Invoke(httpAppResponse);
                    }
                    catch (System.Exception e)
                    {
                        var httpAppResponse = new HttpAppResponse
                        {
                            statusCode = -1,
                            error = e.Message
                        };

                        onHttpAppResponse?.Invoke(httpAppResponse);
                    }
                    finally
                    {
                        multipartContent.Dispose();
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkingPeerHttpClientRequest"/> class.
        /// </summary>
        public NetworkingPeerHttpClientRequest()
        {
            //HTTPManager.KeepAliveDefaultValue = true;

            this.client = new HttpClient();
            this.client.Timeout = System.TimeSpan.FromSeconds(DefaultTimeout);

        }
    }
}
