namespace XmobiTea.GN.Networking
{
    using System;

    using System.Collections;

    using UnityEngine;

    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Helper;
    using XmobiTea.GN.Common;
    using BestHTTP;

    internal class HttpPeer : PeerBase
    {
        private string httpUrl;

        internal override void InitGNSocketObject()
        {
            base.InitGNSocketObject();

            var gnServerSettings = GNNetwork.gnServerSettings;
            if (gnServerSettings == null) throw new NullReferenceException("Where is GN Server Settings");

            httpUrl = gnServerSettings.HttpUrl;
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

            Send("/api/" + operationRequest.GetOperationCode(), operationRequest.GetParameters(), HTTPMethods.Post, response =>
            {
                var obj = new GNArray();

                if (response != null)
                {
                    if (response.IsSuccess)
                    {
                        if (response.StatusCode == 200)
                        {
                            var returnDatas = (IList)Parser.Parse(response.DataAsText);
                            var gnArray = new GNArray.Builder()
                                .AddAll(returnDatas)
                                .Build();

                            var returnCode = gnArray.GetInt(0);
                            obj.Add(returnCode);

                            if (returnCode == (int)ReturnCode.Ok)
                            {
                                if (gnArray.Count() > 1) obj.Add(gnArray.GetGNHashtable(1));
                                else obj.Add(new GNHashtable());
                            }
                            else
                            {
                                if (gnArray.Count() > 1) obj.Add(gnArray.GetString(1));
                                else obj.Add(null);
                            }

                            obj.Add(operationRequest.GetRequestId());

                            OnResponseHandler(obj);
                            return;
                        }
                    }
                }

                obj.Add((int)ReturnCode.UnknownError);
                obj.Add(null);
                obj.Add(operationRequest.GetRequestId());

                OnResponseHandler(obj);
            }, operationRequest.GetTimeOut());
        }

        void Send(string subUri, GNHashtable param, HTTPMethods methods, Action<HTTPResponse> onResponse, float timeout)
        {
            using (var request = new HTTPRequest(new Uri(httpUrl + subUri), methods, (httpRequest, httpResponse) =>
            {
                onResponse?.Invoke(httpResponse);
            }))
            {
                if (param != null) request.AddField(Commands.Data, Serializer.Serialize(param.ToData()));

                request.Timeout = TimeSpan.FromSeconds(timeout + 5);

                var authToken = GNNetwork.authToken;

                if (!string.IsNullOrEmpty(authToken)) request.SetHeader(Commands.RequestAuthTokenCmd, authToken);

                request.Send();
            }
        }
    
        internal void Send(string uri, Action<HTTPResponse> onResponse)
        {
            Send(uri, null, HTTPMethods.Get, onResponse, 15);
        }
    }
}
