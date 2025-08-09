namespace XmobiTea.GearN.Constant
{
    /// <summary>
    /// Defines constant return codes used to represent various operation outcomes.
    /// </summary>
    public class ReturnCode
    {
        /// <summary>
        /// Indicates that the provided secret is invalid.
        /// </summary>
        public const int SecretInvalid = -10;

        /// <summary>
        /// Indicates that the request was rejected due to exceeding the maximum allowed size.
        /// </summary>
        public const int MaxSizeRequestReject = -9;

        /// <summary>
        /// Indicates that the request was rejected due to exceeding the maximum allowed request limit.
        /// </summary>
        public const int MaxRequestReject = -8;

        /// <summary>
        /// Indicates that the request was rejected due to exceeding the maximum concurrent users limit.
        /// </summary>
        public const int MaxCCUReject = -7;

        /// <summary>
        /// Indicates that the operation is not authorized.
        /// </summary>
        public const int OperationNotAuthorized = -6;

        /// <summary>
        /// Indicates that the request contains invalid parameters.
        /// </summary>
        public const int InvalidRequestParameters = -5;

        /// <summary>
        /// Indicates that the operation is invalid.
        /// </summary>
        public const int OperationInvalid = -4;

        /// <summary>
        /// Indicates an internal server error.
        /// </summary>
        public const int InternalServerError = -3;

        /// <summary>
        /// Indicates that the operation is not allowed.
        /// </summary>
        public const int OperationNotAllow = -2;

        /// <summary>
        /// Indicates that the operation timed out.
        /// </summary>
        public const int OperationTimeout = -1;

        /// <summary>
        /// Indicates an unknown error occurred.
        /// </summary>
        public const int UnknownError = 0;

        /// <summary>
        /// Indicates that the operation completed successfully.
        /// </summary>
        public const int Ok = 1;

        /// <summary>
        /// Private constructor to prevent instantiation of this utility class.
        /// </summary>
        private ReturnCode() { }
    }
}
