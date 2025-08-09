namespace XmobiTea.GearN
{
    using System;
    using System.Threading.Tasks;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Config;
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Request;
    using XmobiTea.GearN.Entity.Response;
    using XmobiTea.GearN.Logger;
    using XmobiTea.GearN.Networking;

    /// <summary>
    /// Static class GNNetwork handles all the networking logic, including socket and HTTP communication.
    /// </summary>
    public static partial class GNNetwork
    {
        /// <summary>
        /// Current SDK version.
        /// </summary>
        private const string GN_VERSION = "2.5";

        /// <summary>
        /// Key for storing authentication token in PlayerPrefs.
        /// </summary>
        internal const string AUTH_TOKEN_KEY = "[GN]_AUTH_TOKEN_KEY";

        /// <summary>
        /// Key for storing user ID in PlayerPrefs.
        /// </summary>
        internal const string USER_ID_KEY = "[GN]_USER_ID_KEY";

        /// <summary>
        /// Key for storing game ID in PlayerPrefs.
        /// </summary>
        internal const string GAME_ID_KEY = "[GN]_GAME_ID_KEY";

        /// <summary>
        /// Holds GN server settings loaded from resources.
        /// </summary>
        public static GNServerSettings gnServerSettings { get; private set; }

        /// <summary>
        /// Instance of the NetworkingPeer for handling socket connections.
        /// </summary>
        internal static NetworkingPeer peer { get; private set; }

        /// <summary>
        /// Gets the current ping in milliseconds.
        /// </summary>
        /// <returns>The current ping value, or -1 if no peer exists.</returns>
        public static int getPing() => GNNetwork.peer != null ? GNNetwork.peer.getPing() : -1;

        /// <summary>
        /// Gets the current socket session ID.
        /// </summary>
        /// <returns>The socket session ID, or null if not connected.</returns>
        public static string getSocketSId() => GNNetwork.peer != null ? GNNetwork.peer.getClientId() : null;

        /// <summary>
        /// Send Request auth socket to use socket
        /// </summary>
        public static void sendRequestAuthSocket() => GNNetwork.peer.sendRequestAuthSocket();

        /// <summary>
        /// Checks if the socket connection is active.
        /// </summary>
        /// <returns>True if the socket is connected; otherwise, false.</returns>
        public static bool isSocketConnected() => !string.IsNullOrEmpty(GNNetwork.getSocketSId());

        /// <summary>
        /// Gets the server's current timestamp in milliseconds.
        /// </summary>
        /// <returns>The server's current timestamp, or the local UTC timestamp if no peer exists.</returns>
        public static long getServerTimestamp() => GNNetwork.peer != null ? GNNetwork.peer.getServerTimestamp() : DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        /// <summary>
        /// Gets the current authentication status of the connection.
        /// </summary>
        /// <returns>The current <see cref="AuthenticateStatus"/> of the peer.</returns>
        public static AuthenticateStatus getAuthenticateStatus() => GNNetwork.peer.authenticateStatus;

        /// <summary>
        /// Gets the current override gameId
        /// </summary>
        /// <returns></returns>
        public static string getGameId() => GNNetwork.peer.gameId;

        /// <summary>
        /// Gets the current platform of the application.
        /// </summary>
        /// <returns>The current runtime platform.</returns>
        public static UnityEngine.RuntimePlatform getPlatform() => UnityEngine.Application.platform;

        /// <summary>
        /// Static constructor initializes the GNNetwork class.
        /// </summary>
        static GNNetwork()
        {
            GNNetwork.initServerSettings();
            GNNetwork.initGNDebug();

            if (!UnityEngine.Application.isPlaying) return;

            GNDebug.log("GNNetwork init on Unity. Version: " + GNNetwork.getClientSdkVersion());

            GNNetwork.initGNSocketObject();

            GNNetwork.peer.authenticateStatus.setAuthToken(UnityEngine.PlayerPrefs.GetString(GNNetwork.AUTH_TOKEN_KEY, string.Empty));
            GNNetwork.peer.authenticateStatus.setUserId(UnityEngine.PlayerPrefs.GetString(GNNetwork.USER_ID_KEY, string.Empty));
            GNNetwork.peer.gameId = UnityEngine.PlayerPrefs.GetString(GNNetwork.GAME_ID_KEY, string.Empty);

            GNNetwork.authenticate = new AuthenticateApi();
            GNNetwork.characterPlayer = new CharacterPlayerApi();
            GNNetwork.content = new ContentApi();
            GNNetwork.dashboard = new DashboardApi();
            GNNetwork.gamePlayer = new GamePlayerApi();
            GNNetwork.group = new GroupApi();
            GNNetwork.inventory = new InventoryApi();
            GNNetwork.masterPlayer = new MasterPlayerApi();
            GNNetwork.storeInventory = new StoreInventoryApi();
            GNNetwork.multiplayer = new MultiplayerApi();
            GNNetwork.cloudScript = new CloudScriptApi();
        }

        /// <summary>
        /// Gets the current SDK version.
        /// </summary>
        /// <returns>The current SDK version as a string.</returns>
        public static string getClientSdkVersion() => GNNetwork.GN_VERSION;

        /// <summary>
        /// Initializes server settings from resources.
        /// </summary>
        private static void initServerSettings()
        {
            var gnServerSettings = UnityEngine.Resources.Load(GNServerSettings.ResourcesPath) as GNServerSettings;

            if (gnServerSettings == null)
            {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.ExecuteMenuItem("XmobiTea GN/Open Settings");
                gnServerSettings = UnityEngine.Resources.Load(GNServerSettings.ResourcesPath) as GNServerSettings;
                if (gnServerSettings == null) throw new NullReferenceException("Null GN Server Settings, please find it now");
#endif
            }

            GNNetwork.gnServerSettings = UnityEngine.Object.Instantiate(gnServerSettings);
        }

        /// <summary>
        /// Initializes GN Debug settings based on the loaded server settings.
        /// </summary>
        private static void initGNDebug()
        {
            if (GNNetwork.gnServerSettings == null) throw new NullReferenceException("Null GN Server Settings, please find it now");

            GNDebug.logType = GNNetwork.gnServerSettings.getLogType();
        }

        /// <summary>
        /// Initializes the socket connection object and its corresponding service update GameObject.
        /// </summary>
        private static void initGNSocketObject()
        {
            var peer = new NetworkingPeer();

            peer.initPeer();

            GNNetwork.peer = peer;

            var serviceUpdate = new UnityEngine.GameObject("[GN] ServiceUpdate").AddComponent<Unity.ServiceUpdate>();
            UnityEngine.GameObject.DontDestroyOnLoad(serviceUpdate.gameObject);

            serviceUpdate.peer = peer;
        }

        public static void setNewAuthenticateStatus(AuthenticateStatus authenticateStatus)
        {
            UnityEngine.PlayerPrefs.SetString(GNNetwork.AUTH_TOKEN_KEY, authenticateStatus.getAuthToken());
            UnityEngine.PlayerPrefs.SetString(GNNetwork.USER_ID_KEY, authenticateStatus.getUserId());

            GNNetwork.peer.authenticateStatus.setAuthToken(authenticateStatus.getAuthToken());
            GNNetwork.peer.authenticateStatus.setUserId(authenticateStatus.getUserId());
        }

        public static void setGameId(string gameId)
        {
            UnityEngine.PlayerPrefs.SetString(GNNetwork.GAME_ID_KEY, gameId);

            GNNetwork.peer.gameId = gameId;
        }

        /// <summary>
        /// Sends a request via socket.
        /// </summary>
        /// <param name="requestType">The type of the request.</param>
        /// <param name="role">The role of the request.</param>
        /// <param name="request">The request data to send.</param>
        /// <param name="onResponse">Optional callback for handling the response.</param>
        /// <param name="overrideAuthToken">Optional token override for the request.</param>
        /// <param name="overrideSecretKey">Optional secret key override for the request.</param>
        /// <param name="customTags">Optional custom tags for the request.</param>
        public static void sendViaSocket(RequestType requestType, RequestRole role, OperationRequest request, Action<OperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null)
        {
            GNNetwork.peer.sendViaSocket(requestType, role, request, onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Sends a request via socket asynchronously and returns the response.
        /// </summary>
        /// <param name="requestType">The type of the request.</param>
        /// <param name="role">The role of the request.</param>
        /// <param name="request">The request data.</param>
        /// <param name="overrideAuthToken">Optional token to override the default authentication token.</param>
        /// <param name="overrideSecretKey">Optional secret key to override the default key.</param>
        /// <param name="customTags">Optional custom tags for the request.</param>
        /// <returns>A Task that resolves with the operation response.</returns>
        public static Task<OperationResponse> sendViaSocketAsync(RequestType requestType, RequestRole role, OperationRequest request, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null)
        {
            var taskCompletionSource = new TaskCompletionSource<OperationResponse>();

            GNNetwork.sendViaSocket(requestType, role, request, response =>
            {
                taskCompletionSource.SetResult(response);
            }, overrideAuthToken, overrideSecretKey, customTags);

            return taskCompletionSource.Task;
        }

        /// <summary>
        /// Sends a request via HTTP.
        /// </summary>
        /// <param name="requestType">The type of the request.</param>
        /// <param name="role">The role of the request.</param>
        /// <param name="request">The request data.</param>
        /// <param name="onResponse">Optional callback to handle the response.</param>
        /// <param name="overrideAuthToken">Optional token to override the default authentication token.</param>
        /// <param name="overrideSecretKey">Optional secret key to override the default key.</param>
        /// <param name="customTags">Optional custom tags for the request.</param>
        public static void sendViaHttp(RequestType requestType, RequestRole role, OperationRequest request, Action<OperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null)
        {
            GNNetwork.peer.sendViaHttp(requestType, role, request, onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Sends a request via HTTP asynchronously and returns the response.
        /// </summary>
        /// <param name="requestType">The type of the request.</param>
        /// <param name="role">The role of the request.</param>
        /// <param name="request">The request data.</param>
        /// <param name="overrideAuthToken">Optional token to override the default authentication token.</param>
        /// <param name="overrideSecretKey">Optional secret key to override the default key.</param>
        /// <param name="customTags">Optional custom tags for the request.</param>
        /// <returns>A Task that resolves with the operation response.</returns>
        public static Task<OperationResponse> sendViaHttpAsync(RequestType requestType, RequestRole role, OperationRequest request, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null)
        {
            var taskCompletionSource = new TaskCompletionSource<OperationResponse>();

            GNNetwork.sendViaHttp(requestType, role, request, response =>
            {
                taskCompletionSource.SetResult(response);
            }, overrideAuthToken, overrideSecretKey, customTags);

            return taskCompletionSource.Task;
        }

        /// <summary>
        /// Sends a request via socket with strongly-typed request and response.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="request">The request object to send.</param>
        /// <param name="onResponse">Optional callback to handle the response.</param>
        /// <param name="overrideAuthToken">Optional token to override the default authentication token.</param>
        /// <param name="overrideSecretKey">Optional secret key to override the default key.</param>
        /// <param name="customTags">Optional custom tags for the request.</param>
        public static void sendViaSocket<TRequest, TResponse>(TRequest request, Action<TResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null) where TRequest : CustomOperationRequest where TResponse : CustomOperationResponse, new()
        {
            GNNetwork.sendViaSocket(request.getRequestType(), request.getRole(), request.build(), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Sends a request via socket asynchronously with strongly-typed request and response.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="request">The request object to send.</param>
        /// <param name="overrideAuthToken">Optional token to override the default authentication token.</param>
        /// <param name="overrideSecretKey">Optional secret key to override the default key.</param>
        /// <param name="customTags">Optional custom tags for the request.</param>
        /// <returns>A Task that resolves with the typed response.</returns>
        public static Task<TResponse> sendViaSocketAsync<TRequest, TResponse>(TRequest request, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null) where TRequest : CustomOperationRequest where TResponse : CustomOperationResponse, new()
        {
            var taskCompletionSource = new TaskCompletionSource<TResponse>();

            GNNetwork.sendViaSocket<TRequest, TResponse>(request, response =>
            {
                taskCompletionSource.SetResult(response);
            }, overrideAuthToken, overrideSecretKey, customTags);

            return taskCompletionSource.Task;
        }

        // Similar comments for other methods (HTTP variants and generics)

        /// <summary>
        /// Sends a request via HTTP with strongly-typed request and response.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="request">The request object to send.</param>
        /// <param name="onResponse">Optional callback to handle the response.</param>
        /// <param name="overrideAuthToken">Optional token to override the default authentication token.</param>
        /// <param name="overrideSecretKey">Optional secret key to override the default key.</param>
        /// <param name="customTags">Optional custom tags for the request.</param>
        public static void sendViaHttp<TRequest, TResponse>(TRequest request, Action<TResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null) where TRequest : CustomOperationRequest where TResponse : CustomOperationResponse, new()
        {
            GNNetwork.sendViaHttp(request.getRequestType(), request.getRole(), request.build(), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Sends a request via HTTP asynchronously with strongly-typed request and response.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="request">The request object to send.</param>
        /// <param name="overrideAuthToken">Optional token to override the default authentication token.</param>
        /// <param name="overrideSecretKey">Optional secret key to override the default key.</param>
        /// <param name="customTags">Optional custom tags for the request.</param>
        /// <returns>A Task that resolves with the typed response.</returns>
        public static Task<TResponse> sendViaHttpAsync<TRequest, TResponse>(TRequest request, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null) where TRequest : CustomOperationRequest where TResponse : CustomOperationResponse, new()
        {
            var taskCompletionSource = new TaskCompletionSource<TResponse>();

            GNNetwork.sendViaHttp<TRequest, TResponse>(request, response =>
            {
                taskCompletionSource.SetResult(response);
            }, overrideAuthToken, overrideSecretKey, customTags);

            return taskCompletionSource.Task;
        }

        /// <summary>
        /// Sends a request via socket with a strongly-typed response.
        /// </summary>
        /// <typeparam name="TResponse">The type of the response object.</typeparam>
        /// <param name="requestType">The type of the request being sent.</param>
        /// <param name="role">The role of the request being sent.</param>
        /// <param name="request">The request data to send.</param>
        /// <param name="onResponse">Optional callback to handle the strongly-typed response.</param>
        /// <param name="overrideAuthToken">Optional authentication token to override the default value.</param>
        /// <param name="overrideSecretKey">Optional secret key to override the default value.</param>
        /// <param name="customTags">Optional custom tags to send with the request.</param>
        public static void sendViaSocket<TResponse>(RequestType requestType, RequestRole role, OperationRequest request, Action<TResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null) where TResponse : CustomOperationResponse, new()
        {
            GNNetwork.sendViaSocket(requestType, role, request, response =>
            {
                if (response == null) return;

                var customOperationResponse = new TResponse() { };
                customOperationResponse.setupOperationResponse(response);

                onResponse?.Invoke(customOperationResponse);
            }, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Sends a request via socket asynchronously with a strongly-typed response.
        /// </summary>
        /// <typeparam name="TResponse">The type of the response object.</typeparam>
        /// <param name="requestType">The type of the request being sent.</param>
        /// <param name="role">The role of the request being sent.</param>
        /// <param name="request">The request data to send.</param>
        /// <param name="overrideAuthToken">Optional authentication token to override the default value.</param>
        /// <param name="overrideSecretKey">Optional secret key to override the default value.</param>
        /// <param name="customTags">Optional custom tags to send with the request.</param>
        /// <returns>A Task that resolves to the strongly-typed response.</returns>
        public static Task<TResponse> sendViaSocketAsync<TResponse>(RequestType requestType, RequestRole role, OperationRequest request, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null) where TResponse : CustomOperationResponse, new()
        {
            var taskCompletionSource = new TaskCompletionSource<TResponse>();

            GNNetwork.sendViaSocket<TResponse>(requestType, role, request, response =>
            {
                taskCompletionSource.SetResult(response);
            }, overrideAuthToken, overrideSecretKey, customTags);

            return taskCompletionSource.Task;
        }

        /// <summary>
        /// Sends a request via HTTP with a strongly-typed response.
        /// </summary>
        /// <typeparam name="TResponse">The type of the response object.</typeparam>
        /// <param name="requestType">The type of the request being sent.</param>
        /// <param name="role">The role of the request being sent.</param>
        /// <param name="request">The request data to send.</param>
        /// <param name="onResponse">Optional callback to handle the strongly-typed response.</param>
        /// <param name="overrideAuthToken">Optional authentication token to override the default value.</param>
        /// <param name="overrideSecretKey">Optional secret key to override the default value.</param>
        /// <param name="customTags">Optional custom tags to send with the request.</param>
        public static void sendViaHttp<TResponse>(RequestType requestType, RequestRole role, OperationRequest request, Action<TResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null) where TResponse : CustomOperationResponse, new()
        {
            GNNetwork.sendViaHttp(requestType, role, request, response =>
            {
                if (response == null) return;

                var customOperationResponse = new TResponse() { };
                customOperationResponse.setupOperationResponse(response);

                onResponse?.Invoke(customOperationResponse);
            }, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Sends a request via HTTP asynchronously with a strongly-typed response.
        /// </summary>
        /// <typeparam name="TResponse">The type of the response object.</typeparam>
        /// <param name="requestType">The type of the request being sent.</param>
        /// <param name="role">The role of the request being sent.</param>
        /// <param name="request">The request data to send.</param>
        /// <param name="overrideAuthToken">Optional authentication token to override the default value.</param>
        /// <param name="overrideSecretKey">Optional secret key to override the default value.</param>
        /// <param name="customTags">Optional custom tags to send with the request.</param>
        /// <returns>A Task that resolves to the strongly-typed response.</returns>
        public static Task<TResponse> sendViaHttpAsync<TResponse>(RequestType requestType, RequestRole role, OperationRequest request, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null) where TResponse : CustomOperationResponse, new()
        {
            var taskCompletionSource = new TaskCompletionSource<TResponse>();

            GNNetwork.sendViaHttp<TResponse>(requestType, role, request, response =>
            {
                taskCompletionSource.SetResult(response);
            }, overrideAuthToken, overrideSecretKey, customTags);

            return taskCompletionSource.Task;
        }

        /// <summary>
        /// Connects to the socket server.
        /// </summary>
        /// <param name="_onSocketConnect">Optional callback invoked when the socket is connected.</param>
        public static void connectSocket(Action _onSocketConnect = null)
        {
            GNNetwork.peer.connectSocket(_onSocketConnect);
        }

        /// <summary>
        /// Disconnects from the socket server.
        /// </summary>
        /// <param name="_onSocketDisconnect">Optional callback invoked when the socket is disconnected.</param>
        public static void disconnectSocket(Action _onSocketDisconnect = null)
        {
            GNNetwork.peer.disconnectSocket(_onSocketDisconnect);
        }

        /// <summary>
        /// Subscribes to event handlers for socket events.
        /// </summary>
        /// <param name="_onEventHandler">The handler to invoke when an event occurs.</param>
        public static void setOnEventHandler(Action<OperationEvent> _onEventHandler)
        {
            GNNetwork.peer.setOnEventHandler(_onEventHandler);
        }

        /// <summary>
        /// Subscribes a handler to be invoked when the socket connects successfully.
        /// </summary>
        /// <param name="onConnectHandler">The action to execute when the socket connects.</param>
        public static void subscriberOnConnectHandler(Action onConnectHandler)
        {
            GNNetwork.peer.setOnConnectHandler(onConnectHandler);
        }

        /// <summary>
        /// Subscribes a handler to be invoked when the socket disconnects.
        /// </summary>
        /// <param name="onDisconnectHandler">The action to execute when the socket disconnects.</param>
        public static void subscriberOnDisconnectHandler(Action onDisconnectHandler)
        {
            GNNetwork.peer.setOnDisconnectHandler(onDisconnectHandler);
        }

        /// <summary>
        /// Unsubscribes a previously subscribed handler for socket connection events.
        /// </summary>
        /// <param name="onConnectHandler">The action to remove from connection event handlers.</param>
        public static void unscriberOnConnectHandler(Action onConnectHandler)
        {
            GNNetwork.peer.removeOnConnectHandler(onConnectHandler);
        }

        /// <summary>
        /// Unsubscribes a previously subscribed handler for socket disconnection events.
        /// </summary>
        /// <param name="onDisconnectHandler">The action to remove from disconnection event handlers.</param>
        public static void unsubscriberOnDisconnectHandler(Action onDisconnectHandler)
        {
            GNNetwork.peer.removeOnDisconnectHandler(onDisconnectHandler);
        }

        public static void subscriberServerEventHandler(IServerEventHandler serverEventHandler)
        {
            GNNetwork.peer.subscriberServerEventHandler(serverEventHandler);
        }

    }

}
