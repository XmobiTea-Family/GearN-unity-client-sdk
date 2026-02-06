namespace XmobiTea.GearN
{
    using System.Threading.Tasks;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Entity.Response;
    using XmobiTea.GearN.Networking;

    public static partial class GNNetwork
    {
        /// <summary>
        /// Synchronizes the timestamp by calling a peer method and invokes the callback with the result.
        /// </summary>
        /// <param name="onResponse">An optional callback that receives the synchronized timestamp.</param>
        public static void syncTs(Action1<long> onResponse = null)
        {
            // Delegate the synchronization to the peer's syncTs method.
            GNNetwork.peer.syncTs(onResponse);
        }

        /// <summary>
        /// Asynchronously synchronizes the timestamp and returns the result as a Task.
        /// </summary>
        /// <returns>A Task that resolves to the synchronized timestamp.</returns>
        public static Task<long> syncTsAsync()
        {
            // Create a TaskCompletionSource to manage the asynchronous operation.
            var taskCompletionSource = new TaskCompletionSource<long>();

            // Call the syncTs method and use the callback to set the Task result.
            GNNetwork.syncTs(response =>
            {
                // Set the result of the Task once the callback is invoked.
                taskCompletionSource.SetResult(response);
            });

            // Return the Task to the caller, allowing them to await the result.
            return taskCompletionSource.Task;
        }

        /// <summary>
        /// Validate a GN authToken
        /// </summary>
        /// <param name="authToken"></param>
        /// <param name="onResponse"></param>
        public static void getAuthInfo(string authToken, Action1<GetAuthInfoResponse> onResponse = null)
        {
            GNNetwork.peer.getAuthInfo(authToken, onResponse);
        }

        /// <summary>
        /// Asynchronously validate a GN authToken
        /// </summary>
        /// <param name="authToken"></param>
        /// <returns></returns>
        public static Task<GetAuthInfoResponse> getAuthInfoAsync(string authToken)
        {
            // Create a TaskCompletionSource to manage the asynchronous operation.
            var taskCompletionSource = new TaskCompletionSource<GetAuthInfoResponse>();

            // Call the syncTs method and use the callback to set the Task result.
            GNNetwork.getAuthInfo(authToken, response =>
            {
                // Set the result of the Task once the callback is invoked.
                taskCompletionSource.SetResult(response);
            });

            // Return the Task to the caller, allowing them to await the result.
            return taskCompletionSource.Task;
        }

        public static void healthCheck(Action1<HealthCheckResponse> onResponse = null)
        {
            GNNetwork.peer.healthCheck(onResponse);
        }

        public static Task<HealthCheckResponse> healthCheckAsync()
        {
            // Create a TaskCompletionSource to manage the asynchronous operation.
            var taskCompletionSource = new TaskCompletionSource<HealthCheckResponse>();

            // Call the syncTs method and use the callback to set the Task result.
            GNNetwork.healthCheck(response =>
            {
                // Set the result of the Task once the callback is invoked.
                taskCompletionSource.SetResult(response);
            });

            // Return the Task to the caller, allowing them to await the result.
            return taskCompletionSource.Task;
        }

        /// <summary>
        /// Upload file to server
        /// </summary>
        /// <param name="fileId">the file id</param>
        /// <param name="content">content byte of this file</param>
        /// <param name="filename">the full file name</param>
        /// <param name="mimetype">the mimetype of file</param>
        /// <param name="onResponse">response</param>
        public static void uploadFile(string fileId, byte[] content, string filename, string mimetype, Action1<UploadFileResponse> onResponse)
        {
            GNNetwork.peer.uploadFile(fileId, content, filename, mimetype, onResponse);
        }

        public static Task<UploadFileResponse> uploadFileAsync(string fileId, byte[] content, string filename, string mimetype)
        {
            // Create a TaskCompletionSource to manage the asynchronous operation.
            var taskCompletionSource = new TaskCompletionSource<UploadFileResponse>();

            // Call the syncTs method and use the callback to set the Task result.
            GNNetwork.uploadFile(fileId, content, filename, mimetype, response =>
            {
                // Set the result of the Task once the callback is invoked.
                taskCompletionSource.SetResult(response);
            });

            // Return the Task to the caller, allowing them to await the result.
            return taskCompletionSource.Task;
        }

        public static string getDownloadFileUrl(string downloadToken)
        {
            return GNNetwork.gnServerSettings.getHttpUrl() + "/" + NetworkingPeer.DOWNLOAD_FILE + "/" + downloadToken;
        }

    }
}
