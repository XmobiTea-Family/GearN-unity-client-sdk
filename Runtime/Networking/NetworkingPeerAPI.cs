namespace XmobiTea.GearN.Networking
{
    using System.Collections;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Response;
    using XmobiTea.GearN.Helper;

    /// <summary>
    /// Provides additional functionality for managing network peers.
    /// </summary>
    public partial class NetworkingPeer
    {
        internal const string SYNC_TS = "ts"; // API endpoint for synchronizing timestamps.
        internal const string GET_AUTH_INFO = "getAuthInfo"; // API endpoint for validate an GN authToken.
        internal const string HEALTH_CHECK = "healthcheck"; // API endpoint for healthcheck.
        internal const string UPLOAD_FILE = "upload"; // API endpoint for file uploads.
        internal const string DOWNLOAD_FILE = "download"; // API endpoint for file downloads.
        internal const string API_JSON = "api/" + Commands.RequestCmd_Json; // Base path for JSON API requests.
        internal const string API_MSG_PACK = "api/" + Commands.RequestCmd_MsgPack; // Base path for MsgPack API requests.

        /// <summary>
        /// Synchronizes the local time with the server time by retrieving the latest server timestamp.
        /// </summary>
        /// <param name="onResponse">An optional callback to handle the synchronized server timestamp.</param>
        internal void syncTs(Action1<long> onResponse = null)
        {
            // Sends a request to the SYNC_TS endpoint using the HTTP peer.
            (this.httpPeer as Http.HttpPeer).getRequest(NetworkingPeer.SYNC_TS, httpAppResponse =>
            {
                // Processes the response if there is no error.
                if (!httpAppResponse.hasError())
                {
                    if (httpAppResponse.statusCode == 200) // HTTP success status.
                    {
                        // Parses the response text into a list and converts it to a GNArray.
                        var returnDatas = (IDictionary)Parser.Parse(httpAppResponse.text);
                        var gnHashtable = new GNHashtable.Builder()
                            .addAll(returnDatas)
                            .build();

                        var newServerTimestamp = gnHashtable.getLong(ParameterCode.Ts, System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());

                        this.setServerTimeMilliseconds(newServerTimestamp);
                    }
                }

                // Invokes the callback with the current server timestamp.
                onResponse?.Invoke(this.getServerTimestamp());
            });
        }

        /// <summary>
        /// get the auth info
        /// </summary>
        /// <param name="authToken"></param>
        /// <param name="onResponse"></param>
        internal void getAuthInfo(string authToken, Action1<GetAuthInfoResponse> onResponse)
        {
            // Sends a request to the GET_AUTH_INFO endpoint using the HTTP peer.
            (this.httpPeer as Http.HttpPeer).getRequest(NetworkingPeer.GET_AUTH_INFO + "?authToken=" + authToken, httpAppResponse =>
            {
                // Processes the response if there is no error.
                if (!httpAppResponse.hasError())
                {
                    if (httpAppResponse.statusCode == 200) // HTTP success status.
                    {
                        // Parses the response text into a list and converts it to a GNArray.
                        var returnDatas = new GNHashtable.Builder().addAll((IDictionary)Parser.Parse(httpAppResponse.text)).build();
                        if (returnDatas["error"] != null)
                        {
                            onResponse?.Invoke(new GetAuthInfoResponse()
                            {
                                error = (string)returnDatas["error"]
                            });
                        }
                        else
                        {
                            onResponse?.Invoke(new GetAuthInfoResponse()
                            {
                                error = null,
                                data = new AuthInfoResponse()
                                {
                                    gnToken = returnDatas.getString("gnToken"),
                                    userId = returnDatas.getString("userId"),
                                    isRemove = returnDatas.getBool("isRemove"),
                                    tsExpire = returnDatas.getLong("tsExpire"),
                                    otherDatas = returnDatas.getGNHashtable("otherDatas"),
                                    tsCreate = returnDatas.getLong("tsCreate"),
                                    secretKey = returnDatas.getString("secretKey"),
                                }
                            });
                        }
                    }
                    else
                    {
                        onResponse?.Invoke(new GetAuthInfoResponse()
                        {
                            error = "unknown error"
                        });
                    }

                    return;
                }

                // Invokes the callback with the current server timestamp.
                onResponse?.Invoke(new GetAuthInfoResponse()
                {
                    error = httpAppResponse.error
                });
            });
        }

        internal void healthCheck(Action1<HealthCheckResponse> onResponse)
        {
            // Sends a request to the HEALTH_CHECK endpoint using the HTTP peer.
            (this.httpPeer as Http.HttpPeer).getRequest(NetworkingPeer.HEALTH_CHECK, httpAppResponse =>
            {
                // Processes the response if there is no error.
                if (!httpAppResponse.hasError())
                {
                    if (httpAppResponse.statusCode == 200) // HTTP success status.
                    {
                        // Parses the response text into a list and converts it to a GNArray.
                        var returnDatas = new GNHashtable.Builder().addAll((IDictionary)Parser.Parse(httpAppResponse.text)).build();
                        if (returnDatas["error"] != null)
                        {
                            onResponse?.Invoke(new HealthCheckResponse()
                            {
                                error = (string)returnDatas["error"]
                            });
                        }
                        else
                        {
                            var gnThisInstance = returnDatas.getGNHashtable("thisInstance");
                            var gnOtherInstances = returnDatas.getGNArray("otherInstances");

                            var otherInstances = new OtherInstanceResponse[gnOtherInstances.count()];
                            for (var i = 0; i < otherInstances.Length; i++)
                            {
                                var gnOtherInstance = gnOtherInstances.getGNHashtable(i);

                                otherInstances[i] = new OtherInstanceResponse()
                                {
                                    instanceId = gnOtherInstance.getString("instanceId"),
                                    isPrimary = gnOtherInstance.getBool("isPrimary"),
                                    currentInstanceIdPrimary = gnOtherInstance.getString("currentInstanceIdPrimary"),
                                    currentTsPrimary = gnOtherInstance.getLong("currentTsPrimary"),
                                    currentTsPrimaryToDate = gnOtherInstance.getString("currentTsPrimaryToDate"),
                                    tsPrimary = gnOtherInstance.getLong("tsPrimary"),
                                    tsPrimaryToDate = gnOtherInstance.getString("tsPrimaryToDate"),
                                    lostPing = gnOtherInstance.getInt("lostPing"),
                                };
                            }

                            onResponse?.Invoke(new HealthCheckResponse()
                            {
                                error = null,
                                data = new HealthCheckDataResponse()
                                {
                                    thisInstance = new InstanceResponse()
                                    {
                                        instanceId = gnThisInstance.getString("instanceId"),
                                        isPrimary = gnThisInstance.getBool("isPrimary"),
                                        currentInstanceIdPrimary = gnThisInstance.getString("currentInstanceIdPrimary"),
                                        currentTsPrimary = gnThisInstance.getLong("currentTsPrimary"),
                                        currentTsPrimaryToDate = gnThisInstance.getString("currentTsPrimaryToDate"),
                                        tsPrimary = gnThisInstance.getLong("tsPrimary"),
                                        tsPrimaryToDate = gnThisInstance.getString("tsPrimaryToDate"),
                                    },
                                    otherInstances = otherInstances,
                                }
                            });
                        }
                    }
                    else
                    {
                        onResponse?.Invoke(new HealthCheckResponse()
                        {
                            error = "unknown error"
                        });
                    }

                    return;
                }

                // Invokes the callback with the current server timestamp.
                onResponse?.Invoke(new HealthCheckResponse()
                {
                    error = httpAppResponse.error
                });
            });
        }

        /// <summary>
        /// upload the file
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="content"></param>
        /// <param name="filename"></param>
        /// <param name="mimetype"></param>
        /// <param name="onResponse"></param>
        internal void uploadFile(string fileId, byte[] content, string filename, string mimetype, Action1<UploadFileResponse> onResponse)
        {
            (this.httpPeer as Http.HttpPeer).uploadFile(fileId, content, filename, mimetype, httpAppResponse =>
            {
                // Processes the response if there is no error.
                if (!httpAppResponse.hasError())
                {
                    if (httpAppResponse.statusCode == 200) // HTTP success status.
                    {
                        onResponse?.Invoke(new UploadFileResponse()
                        {
                            error = null,
                        });
                    }

                    return;
                }

                // Invokes the callback with the current server timestamp.
                onResponse?.Invoke(new UploadFileResponse()
                {
                    error = httpAppResponse.error ?? "Unknown Error",
                });
            });
        }
    }
}
