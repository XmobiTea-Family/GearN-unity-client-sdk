namespace XmobiTea.GearN
{
    using System.Threading.Tasks;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Models;

    /// <summary>
    /// The main API for authentication operations.
    /// </summary>
    public class AuthenticateApi
    {
        /// <summary>
        /// API for server-specific operations.
        /// </summary>
        public ServerApi server { get; } = new ServerApi();

        /// <summary>
        /// API for admin-specific operations.
        /// </summary>
        public AdminApi admin { get; } = new AdminApi();

        /// <summary>
        /// Login using account credentials.
        /// </summary>
        /// <param name="requestData">The request data containing the account credentials.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void loginByAccount(AuthenticateModels.LoginByAccountRequestData requestData, Action1<AuthenticateResponseModels.LoginByAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous login using account credentials.
        /// </summary>
        /// <param name="requestData">The request data containing the account credentials.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        /// <returns>A task representing the asynchronous operation, returning the operation response.</returns>
        public Task<AuthenticateResponseModels.LoginByAccountOperationResponse> loginByAccountAsync(AuthenticateModels.LoginByAccountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.LoginByAccountOperationRequest, AuthenticateResponseModels.LoginByAccountOperationResponse>(new AuthenticateRequestModels.LoginByAccountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Login using Android device ID.
        /// </summary>
        /// <param name="requestData">The request data containing the Android device ID.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void loginByAndroidDeviceId(AuthenticateModels.LoginByAndroidDeviceIdRequestData requestData, Action1<AuthenticateResponseModels.LoginByAndroidDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByAndroidDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous login using Android device ID.
        /// </summary>
        /// <param name="requestData">The request data containing the Android device ID.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        /// <returns>A task representing the asynchronous operation, returning the operation response.</returns>
        public Task<AuthenticateResponseModels.LoginByAndroidDeviceIdOperationResponse> loginByAndroidDeviceIdAsync(AuthenticateModels.LoginByAndroidDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.LoginByAndroidDeviceIdOperationRequest, AuthenticateResponseModels.LoginByAndroidDeviceIdOperationResponse>(new AuthenticateRequestModels.LoginByAndroidDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Login using Apple ID.
        /// </summary>
        /// <param name="requestData">The request data containing the Apple ID.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void loginByApple(AuthenticateModels.LoginByAppleRequestData requestData, Action1<AuthenticateResponseModels.LoginByAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous login using Apple ID.
        /// </summary>
        /// <param name="requestData">The request data containing the Apple ID.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        /// <returns>A task representing the asynchronous operation, returning the operation response.</returns>
        public Task<AuthenticateResponseModels.LoginByAppleOperationResponse> loginByAppleAsync(AuthenticateModels.LoginByAppleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.LoginByAppleOperationRequest, AuthenticateResponseModels.LoginByAppleOperationResponse>(new AuthenticateRequestModels.LoginByAppleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Login using a custom device ID.
        /// </summary>
        /// <param name="requestData">The request data containing the custom device ID.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void loginByCustomDeviceId(AuthenticateModels.LoginByCustomDeviceIdRequestData requestData, Action1<AuthenticateResponseModels.LoginByCustomDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByCustomDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous login using a custom device ID.
        /// </summary>
        /// <param name="requestData">The request data containing the custom device ID.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        /// <returns>A task representing the asynchronous operation, returning the operation response.</returns>
        public Task<AuthenticateResponseModels.LoginByCustomDeviceIdOperationResponse> loginByCustomDeviceIdAsync(AuthenticateModels.LoginByCustomDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.LoginByCustomDeviceIdOperationRequest, AuthenticateResponseModels.LoginByCustomDeviceIdOperationResponse>(new AuthenticateRequestModels.LoginByCustomDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Login using a custom ID.
        /// </summary>
        /// <param name="requestData">The request data containing the custom ID.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void loginByCustomId(AuthenticateModels.LoginByCustomIdRequestData requestData, Action1<AuthenticateResponseModels.LoginByCustomIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByCustomIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous login using a custom ID.
        /// </summary>
        /// <param name="requestData">The request data containing the custom ID.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        /// <returns>A task representing the asynchronous operation, returning the operation response.</returns>
        public Task<AuthenticateResponseModels.LoginByCustomIdOperationResponse> loginByCustomIdAsync(AuthenticateModels.LoginByCustomIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.LoginByCustomIdOperationRequest, AuthenticateResponseModels.LoginByCustomIdOperationResponse>(new AuthenticateRequestModels.LoginByCustomIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Login using an editor device ID.
        /// </summary>
        /// <param name="requestData">The request data containing the editor device ID.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void loginByEditorDeviceId(AuthenticateModels.LoginByEditorDeviceIdRequestData requestData, Action1<AuthenticateResponseModels.LoginByEditorDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByEditorDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous login using an editor device ID.
        /// </summary>
        /// <param name="requestData">The request data containing the editor device ID.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        /// <returns>A task representing the asynchronous operation, returning the operation response.</returns>
        public Task<AuthenticateResponseModels.LoginByEditorDeviceIdOperationResponse> loginByEditorDeviceIdAsync(AuthenticateModels.LoginByEditorDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.LoginByEditorDeviceIdOperationRequest, AuthenticateResponseModels.LoginByEditorDeviceIdOperationResponse>(new AuthenticateRequestModels.LoginByEditorDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Login using a Facebook account.
        /// </summary>
        /// <param name="requestData">The request data containing Facebook account information.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void loginByFacebook(AuthenticateModels.LoginByFacebookRequestData requestData, Action1<AuthenticateResponseModels.LoginByFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous login using a Facebook account.
        /// </summary>
        /// <param name="requestData">The request data containing Facebook account information.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public Task<AuthenticateResponseModels.LoginByFacebookOperationResponse> loginByFacebookAsync(AuthenticateModels.LoginByFacebookRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.LoginByFacebookOperationRequest, AuthenticateResponseModels.LoginByFacebookOperationResponse>(new AuthenticateRequestModels.LoginByFacebookOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Login using a generic service.
        /// </summary>
        /// <param name="requestData">The request data containing generic service information.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void loginByGenericService(AuthenticateModels.LoginByGenericServiceRequestData requestData, Action1<AuthenticateResponseModels.LoginByGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous login using a generic service.
        /// </summary>
        /// <param name="requestData">The request data containing generic service information.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        /// <returns>A task representing the asynchronous operation, returning the operation response.</returns>
        public Task<AuthenticateResponseModels.LoginByGenericServiceOperationResponse> loginByGenericServiceAsync(AuthenticateModels.LoginByGenericServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.LoginByGenericServiceOperationRequest, AuthenticateResponseModels.LoginByGenericServiceOperationResponse>(new AuthenticateRequestModels.LoginByGenericServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Login using a Google account.
        /// </summary>
        /// <param name="requestData">The request data containing Google account information.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void loginByGoogle(AuthenticateModels.LoginByGoogleRequestData requestData, Action1<AuthenticateResponseModels.LoginByGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous login using a Google account.
        /// </summary>
        /// <param name="requestData">The request data containing Google account information.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        /// <returns>A task representing the asynchronous operation, returning the operation response.</returns>
        public Task<AuthenticateResponseModels.LoginByGoogleOperationResponse> loginByGoogleAsync(AuthenticateModels.LoginByGoogleRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.LoginByGoogleOperationRequest, AuthenticateResponseModels.LoginByGoogleOperationResponse>(new AuthenticateRequestModels.LoginByGoogleOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Login using a Google play game service account.
        /// </summary>
        /// <param name="requestData">The request data containing Google account information.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void loginByGooglePlayGameService(AuthenticateModels.LoginByGooglePlayGameServiceRequestData requestData, Action1<AuthenticateResponseModels.LoginByGooglePlayGameServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByGooglePlayGameServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous login using a Google play game service account.
        /// </summary>
        /// <param name="requestData">The request data containing Google account information.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        /// <returns>A task representing the asynchronous operation, returning the operation response.</returns>
        public Task<AuthenticateResponseModels.LoginByGooglePlayGameServiceOperationResponse> loginByGooglePlayGameServiceAsync(AuthenticateModels.LoginByGooglePlayGameServiceRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.LoginByGooglePlayGameServiceOperationRequest, AuthenticateResponseModels.LoginByGooglePlayGameServiceOperationResponse>(new AuthenticateRequestModels.LoginByGooglePlayGameServiceOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Login using a Game Center account.
        /// </summary>
        /// <param name="requestData">The request data containing Google account information.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void loginByGameCenter(AuthenticateModels.LoginByGameCenterRequestData requestData, Action1<AuthenticateResponseModels.LoginByGameCenterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByGameCenterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous login using a Game Center account.
        /// </summary>
        /// <param name="requestData">The request data containing Google account information.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        /// <returns>A task representing the asynchronous operation, returning the operation response.</returns>
        public Task<AuthenticateResponseModels.LoginByGameCenterOperationResponse> loginByGameCenterAsync(AuthenticateModels.LoginByGameCenterRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.LoginByGameCenterOperationRequest, AuthenticateResponseModels.LoginByGameCenterOperationResponse>(new AuthenticateRequestModels.LoginByGameCenterOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Login using an iOS device ID.
        /// </summary>
        /// <param name="requestData">The request data containing iOS device ID information.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void loginByiOSDeviceId(AuthenticateModels.LoginByiOSDeviceIdRequestData requestData, Action1<AuthenticateResponseModels.LoginByiOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByiOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous login using an iOS device ID.
        /// </summary>
        /// <param name="requestData">The request data containing iOS device ID information.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        /// <returns>A task representing the asynchronous operation, returning the operation response.</returns>
        public Task<AuthenticateResponseModels.LoginByiOSDeviceIdOperationResponse> loginByiOSDeviceIdAsync(AuthenticateModels.LoginByiOSDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.LoginByiOSDeviceIdOperationRequest, AuthenticateResponseModels.LoginByiOSDeviceIdOperationResponse>(new AuthenticateRequestModels.LoginByiOSDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Login using a Linux device ID.
        /// </summary>
        /// <param name="requestData">The request data containing Linux device ID information.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void loginByLinuxDeviceId(AuthenticateModels.LoginByLinuxDeviceIdRequestData requestData, Action1<AuthenticateResponseModels.LoginByLinuxDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByLinuxDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous login using a Linux device ID.
        /// </summary>
        /// <param name="requestData">The request data containing Linux device ID information.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        /// <returns>A task representing the asynchronous operation, returning the operation response.</returns>
        public Task<AuthenticateResponseModels.LoginByLinuxDeviceIdOperationResponse> loginByLinuxDeviceIdAsync(AuthenticateModels.LoginByLinuxDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.LoginByLinuxDeviceIdOperationRequest, AuthenticateResponseModels.LoginByLinuxDeviceIdOperationResponse>(new AuthenticateRequestModels.LoginByLinuxDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Login using a macOS device ID.
        /// </summary>
        /// <param name="requestData">The request data containing macOS device ID information.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void loginByMacOSDeviceId(AuthenticateModels.LoginByMacOSDeviceIdRequestData requestData, Action1<AuthenticateResponseModels.LoginByMacOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByMacOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous login using a macOS device ID.
        /// </summary>
        /// <param name="requestData">The request data containing macOS device ID information.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        /// <returns>A task representing the asynchronous operation, returning the operation response.</returns>
        public Task<AuthenticateResponseModels.LoginByMacOSDeviceIdOperationResponse> loginByMacOSDeviceIdAsync(AuthenticateModels.LoginByMacOSDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.LoginByMacOSDeviceIdOperationRequest, AuthenticateResponseModels.LoginByMacOSDeviceIdOperationResponse>(new AuthenticateRequestModels.LoginByMacOSDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Login using a Windows device ID.
        /// </summary>
        /// <param name="requestData">The request data containing Windows device ID information.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void loginByWindowsDeviceId(AuthenticateModels.LoginByWindowsDeviceIdRequestData requestData, Action1<AuthenticateResponseModels.LoginByWindowsDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByWindowsDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous login using a Windows device ID.
        /// </summary>
        /// <param name="requestData">The request data containing Windows device ID information.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        /// <returns>A task representing the asynchronous operation, returning the operation response.</returns>
        public Task<AuthenticateResponseModels.LoginByWindowsDeviceIdOperationResponse> loginByWindowsDeviceIdAsync(AuthenticateModels.LoginByWindowsDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.LoginByWindowsDeviceIdOperationRequest, AuthenticateResponseModels.LoginByWindowsDeviceIdOperationResponse>(new AuthenticateRequestModels.LoginByWindowsDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Login using a Windows Phone device ID.
        /// </summary>
        /// <param name="requestData">The request data containing Windows Phone device ID information.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void loginByWindowsPhoneDeviceId(AuthenticateModels.LoginByWindowsPhoneDeviceIdRequestData requestData, Action1<AuthenticateResponseModels.LoginByWindowsPhoneDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.LoginByWindowsPhoneDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous login using a Windows Phone device ID.
        /// </summary>
        /// <param name="requestData">The request data containing Windows Phone device ID information.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        /// <returns>A task representing the asynchronous operation, returning the operation response.</returns>
        public Task<AuthenticateResponseModels.LoginByWindowsPhoneDeviceIdOperationResponse> loginByWindowsPhoneDeviceIdAsync(AuthenticateModels.LoginByWindowsPhoneDeviceIdRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.LoginByWindowsPhoneDeviceIdOperationRequest, AuthenticateResponseModels.LoginByWindowsPhoneDeviceIdOperationResponse>(new AuthenticateRequestModels.LoginByWindowsPhoneDeviceIdOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Register a new account.
        /// </summary>
        /// <param name="requestData">The request data containing account registration information.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void registerAccount(AuthenticateModels.RegisterAccountRequestData requestData, Action1<AuthenticateResponseModels.RegisterAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.RegisterAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous registration of a new account.
        /// </summary>
        /// <param name="requestData">The request data containing account registration information.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        /// <returns>A task representing the asynchronous operation, returning the operation response.</returns>
        public Task<AuthenticateResponseModels.RegisterAccountOperationResponse> registerAccountAsync(AuthenticateModels.RegisterAccountRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.RegisterAccountOperationRequest, AuthenticateResponseModels.RegisterAccountOperationResponse>(new AuthenticateRequestModels.RegisterAccountOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Refresh the authentication token.
        /// </summary>
        /// <param name="requestData">The request data containing the refresh token information.</param>
        /// <param name="onResponse">Callback to handle the response of the operation.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        public void refreshAuthToken(AuthenticateModels.RefreshAuthTokenRequestData requestData, Action1<AuthenticateResponseModels.RefreshAuthTokenOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new AuthenticateRequestModels.RefreshAuthTokenOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        /// <summary>
        /// Asynchronous refresh of the authentication token.
        /// </summary>
        /// <param name="requestData">The request data containing the refresh token information.</param>
        /// <param name="overrideAuthToken">Optional override for the authentication token.</param>
        /// <param name="overrideSecretKey">Optional override for the secret key.</param>
        /// <param name="customTags">Custom tags to send along with the request.</param>
        /// <param name="timeout">The timeout duration for the request, in seconds.</param>
        /// <returns>A task representing the asynchronous operation, returning the operation response.</returns>
        public Task<AuthenticateResponseModels.RefreshAuthTokenOperationResponse> refreshAuthTokenAsync(AuthenticateModels.RefreshAuthTokenRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<AuthenticateRequestModels.RefreshAuthTokenOperationRequest, AuthenticateResponseModels.RefreshAuthTokenOperationResponse>(new AuthenticateRequestModels.RefreshAuthTokenOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public class ServerApi
        {
        }

        public class AdminApi
        {
        }

    }

    public static partial class GNNetwork
    {

        public static AuthenticateApi authenticate { get; }
    }

}
