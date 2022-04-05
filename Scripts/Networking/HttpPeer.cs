namespace XmobiTea.GN.Networking
{
    using System;

    using System.Collections;

    using UnityEngine;

    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;
    using XmobiTea.GN.Helper;
    using XmobiTea.GN.Common;
    using BestHTTP;

    internal class HttpPeer : PeerBase
    {
        private string httpUrl;

        //class AcceptAllCertificatesSignedWithASpecificKeyPublicKey : CertificateHandler
        //{
        //    protected override bool ValidateCertificate(byte[] certificateData)
        //    {
        //        return true;
        //    }
        //}

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

            StartCoroutine(IESend("/api/" + operationRequest.GetOperationCode(), operationRequest.GetParameters(), HTTPMethods.Post, response =>
            {
                var obj = new GNArray();

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
                    }
                    else
                    {
                        obj.Add((int)ReturnCode.UnknownError);
                        obj.Add(null);
                        obj.Add(operationRequest.GetRequestId());
                    }
                }
                else
                {
                    obj.Add((int)ReturnCode.UnknownError);
                    obj.Add(null);
                    obj.Add(operationRequest.GetRequestId());
                }

                OnResponseHandler(obj);
            }, operationRequest.GetTimeOut()));
        }

        IEnumerator IESend(string uri, GNHashtable param, HTTPMethods methods, Action<HTTPResponse> onResponse, float timeout)
        {
            var authToken = GNNetwork.authToken;

            using (var request = new HTTPRequest(new Uri(httpUrl + uri), methods))
            {
                if (param != null) request.AddField(Commands.Data, Serializer.Serialize(param.ToData()));

                request.Timeout = TimeSpan.FromSeconds(timeout + 5);

                if (!string.IsNullOrEmpty(authToken)) request.SetHeader(Commands.RequestAuthTokenCmd, authToken);

                request.Send();

                yield return new WaitWhile(() => request.State < HTTPRequestStates.Finished);

                onResponse?.Invoke(request.Response);
            }
        }
    
        internal void Send(string uri, Action<HTTPResponse> onResponse)
        {
            StartCoroutine(IESend(uri, null, HTTPMethods.Get, onResponse, 15));
        }
    }
}
