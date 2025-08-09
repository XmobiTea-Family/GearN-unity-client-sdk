namespace XmobiTea.GearN.Networking
{
    /// <summary>
    /// Represents the authentication status of a user.
    /// </summary>
    public class AuthenticateStatus
    {
        private string authToken; // Stores the authentication token.
        private string userId;    // Stores the user ID.

        /// <summary>
        /// Gets the authentication token.
        /// </summary>
        /// <returns>The current authentication token.</returns>
        public string getAuthToken()
        {
            return this.authToken;
        }

        /// <summary>
        /// Sets the authentication token.
        /// </summary>
        /// <param name="authToken">The authentication token to set.</param>
        internal void setAuthToken(string authToken)
        {
            this.authToken = authToken;
        }

        // Uncomment this method if needed in the future to validate login and token expiry.
        // /// <summary>
        // /// Checks if the user is logged in and the authentication token is valid.
        // /// </summary>
        // /// <returns>True if logged in and valid, otherwise false.</returns>
        // public bool isLoginAndValid()
        // {
        //     return string.IsNullOrEmpty(this.authToken) && (authTokenTsExpire == -1 || GNNetwork.getServerTimestamp() < authTokenTsExpire);
        // }

        /// <summary>
        /// Gets the user ID.
        /// </summary>
        /// <returns>The current user ID.</returns>
        public string getUserId()
        {
            return this.userId;
        }

        /// <summary>
        /// Sets the user ID.
        /// </summary>
        /// <param name="userId">The user ID to set.</param>
        internal void setUserId(string userId)
        {
            this.userId = userId;
        }
    }
}
