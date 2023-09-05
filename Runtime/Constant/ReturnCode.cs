namespace XmobiTea.GN.Constant
{
    public class ReturnCode
    {
        public const int SecretInvalid = -10;
        public const int MaxSizeRequestReject = -9;
        public const int MaxRequestReject = -8;
        public const int MaxCCUReject = -7;

        public const int OperationNotAuthorized = -6;
        public const int InvalidRequestParameters = -5;
        public const int OperationInvalid = -4;
        public const int InternalServerError = -3;
        public const int OperationNotAllow = -2;
        public const int OperationTimeout = -1;

        public const int UnknownError = 0;

        public const int Ok = 1;

        private ReturnCode() { }
    }
}
