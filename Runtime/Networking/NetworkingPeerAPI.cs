namespace XmobiTea.GN.Networking
{
    using System;
    using System.Collections;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity.Response;
    using XmobiTea.GN.Helper;

    public partial class NetworkingPeer
    {
        internal const string SYNC_TS = "ts";
        internal const string UPLOAD_FILE = "upload";
        internal const string DOWNLOAD_FILE = "download";
        internal const string API_JSON = "api/" + Commands.RequestCmd_Json;
        internal const string API_MSG_PACK = "api/" + Commands.RequestCmd_MsgPack;

        internal void syncTs(Action<long> onResponse = null)
        {
            (this.httpPeer as Http.HttpPeer).getRequest(NetworkingPeer.SYNC_TS, httpAppResponse =>
            {
                if (!httpAppResponse.hasError())
                {
                    if (httpAppResponse.statusCode == 200)
                    {
                        var returnDatas = (IList)Parser.Parse(httpAppResponse.text);
                        var gnArray = new GNArray.Builder()
                            .addAll(returnDatas)
                            .build();

                        var returnCode = gnArray.getInt(0);
                        if (returnCode == ReturnCode.Ok)
                        {
                            var gnHashtable = gnArray.getGNHashtable(1);
                            var newServerTimestamp = gnHashtable.getLong("1", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());

                            this.setServerTimeMilliseconds(newServerTimestamp);
                        }
                    }
                }

                onResponse?.Invoke(this.getServerTimestamp());
            });
        }

        //internal void accountLogin(string username, string password, Action<LoginOperationResponse> onResponse = null)
        //{
        //    //var request = new AccountLoginOperationRequest(username, password).Build();

        //    //SendViaHttp(request, response =>
        //    //{
        //    //    var loginOperationResponse = new LoginOperationResponse();
        //    //    loginOperationResponse.SetupOperationResponse(response);

        //    //    onResponse?.Invoke(loginOperationResponse);
        //    //});
        //}
    }
}
