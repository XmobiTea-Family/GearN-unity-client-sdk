namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Entity.Request;
    using XmobiTea.GN.Entity.Response;
    using XmobiTea.GN.Helper;

    public partial class NetworkingPeer
    {
        internal const string SYNC_TS = "ts";
        internal const string UPLOAD_FILE = "upload";
        internal const string DOWNLOAD_FILE = "upload";
        internal const string GET_CONFIG = "getConfig";
        internal const string API_JSON = "api/" + Commands.RequestCmd_Json;
        internal const string API_MSG_PACK = "api/" + Commands.RequestCmd_MsgPack;

        internal void SyncTs(Action<long> onResponse = null)
        {
            (this.httpPeer as HttpPeer).GetRequest(SYNC_TS, httpAppResponse =>
            {
                if (!httpAppResponse.hasError)
                {
                    if (httpAppResponse.statusCode == 200)
                    {
                        var returnDatas = (IList)Parser.Parse(httpAppResponse.text);
                        var gnArray = new GNArray.Builder()
                            .AddAll(returnDatas)
                            .Build();

                        var returnCode = gnArray.GetInt(0);
                        if (returnCode == ReturnCode.Ok)
                        {
                            var gnHashtable = gnArray.GetGNHashtable(1);
                            var newServerTimestamp = gnHashtable.GetLong("1", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());

                            SetServerTimeMilliseconds(newServerTimestamp);
                        }
                    }
                }

                onResponse?.Invoke(serverTimestamp);
            });
        }

        internal void AccountLogin(string username, string password, Action<LoginOperationResponse> onResponse = null)
        {
            //var request = new AccountLoginOperationRequest(username, password).Build();

            //SendViaHttp(request, response =>
            //{
            //    var loginOperationResponse = new LoginOperationResponse();
            //    loginOperationResponse.SetupOperationResponse(response);

            //    onResponse?.Invoke(loginOperationResponse);
            //});
        }
    }
}
