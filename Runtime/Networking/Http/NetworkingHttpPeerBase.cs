namespace XmobiTea.GN.Networking.Http
{
    using System;
    using XmobiTea.GN.Common;

    internal abstract class NetworkingHttpPeerBase
    {
        protected string httpUrl { get; private set; }
        protected string userAgent { get; private set; }

        public abstract void getRequest(string subUri, Action<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey);

        public abstract void postRequest(string subUri, GNHashtable param, PostType postType, Action<HttpAppResponse> onHttpAppResponse, float timeout, string authToken, string secretKey, GNHashtable customTags);

        public abstract void postRequestUpload(string subUri, byte[] content, string mimetype, Action<HttpAppResponse> onHttpAppResponse, float timeout);

        public virtual void init(string httpUrl, string userAgent)
        {
            this.httpUrl = httpUrl;
            this.userAgent = userAgent;
        }

    }

}
