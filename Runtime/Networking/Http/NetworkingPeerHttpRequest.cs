namespace XmobiTea.GN.Networking.Http
{
    using BestHTTP;
    using System;
    using System.IO;
    using System.Text;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Helper;
    using XmobiTea.MsgPack;

    internal class NetworkingPeerHttpRequest : NetworkingHttpPeerBase
    {
        public override void getRequest(string subUri, Action<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey)
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

        public override void postRequest(string subUri, GNHashtable param, PostType postType, Action<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey, GNHashtable customTags)
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

        public override void postRequestUpload(string subUri, byte[] content, string mimetype, Action<HttpAppResponse> onHttpAppResponse, float timeout)
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

        //public override void postRequest(string subUri, GNHashtable param, PostType postType, Action<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey, GNHashtable customTags)
        //{
        //    postRequestViaHttpRequest(subUri, param, postType, onHttpAppResponse, timeout, authToken, secretKey, customTags);
        //}

        //public async void postRequestViaHttpRequest(string subUri, GNHashtable param, PostType postType, Action<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey, GNHashtable customTags)
        //{
        //    try
        //    {
        //        var httpRequest = (System.Net.HttpWebRequest)WebRequest.Create(this.httpUrl + "/" + subUri);
        //        httpRequest.UserAgent = this.userAgent;
        //        httpRequest.SendChunked = false;
        //        // Prevents hitting a proxy if no proxy is available. TODO: Add support for proxy's.
        //        httpRequest.Proxy = null;

        //        if (!string.IsNullOrEmpty(authToken)) httpRequest.Headers.Add(Commands.RequestAuthTokenCmd, authToken);
        //        if (!string.IsNullOrEmpty(secretKey)) httpRequest.Headers.Add(Commands.RequestSecretCmd, secretKey);

        //        httpRequest.Method = "POST";
        //        httpRequest.KeepAlive = false;
        //        httpRequest.Timeout = (int)timeout;
        //        httpRequest.AllowWriteStreamBuffering = false;
        //        httpRequest.Proxy = null;
        //        httpRequest.ReadWriteTimeout = (int)timeout;

        //        if (postType == PostType.Json)
        //        {
        //            httpRequest.ContentType = Commands.APPLICATION_JSON;

        //            var dataSend = param.toData();

        //            var content = Encoding.UTF8.GetBytes(Serializer.Serialize(dataSend));

        //            httpRequest.ContentLength = content.LongLength;

        //            using (var stream = httpRequest.GetRequestStream())
        //            {
        //                stream.Write(content, 0, content.Length);
        //            }
        //        }
        //        else if (postType == PostType.MsgPack)
        //        {
        //            httpRequest.ContentType = Commands.APPLICATION_MSGPACK;

        //            var dataSend = param.toData();

        //            var content = MsgPackSerializer.Serialize(dataSend);

        //            httpRequest.ContentLength = content.LongLength;

        //            using (var stream = httpRequest.GetRequestStream())
        //            {
        //                stream.Write(content, 0, content.Length);
        //            }
        //        }

        //        var response = await httpRequest.GetResponseAsync();

        //        response.
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //}


        public override void init(string httpUrl, string userAgent)
        {
            base.init(httpUrl, userAgent);

            HTTPManager.UserAgent = userAgent;
        }

        public NetworkingPeerHttpRequest()
        {
            HTTPManager.KeepAliveDefaultValue = true;
        }
    }

}
