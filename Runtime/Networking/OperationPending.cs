namespace XmobiTea.GN.Networking
{
    using System;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;

    public struct OperationPending
    {
        private OperationRequest operationRequest;
        private RequestType requestType;
        private RequestRole requestRole;
        private string authToken;
        private string secretKey;
        private GNHashtable customTags;
        private Action<OperationResponse> onOperationResponse;
        private float timeout;

        private float firstSend;
        private float secondsSend;

        public OperationPending(RequestType requestType, RequestRole requestRole, OperationRequest operationRequest, Action<OperationResponse> onOperationResponse, string authToken, string secretKey, GNHashtable customTags)
        {
            this.operationRequest = operationRequest;
            this.onOperationResponse = onOperationResponse;
            this.timeout = UnityEngine.Time.realtimeSinceStartup + OperationRequest.DefaultTimeOut;
            this.firstSend = 0;
            this.secondsSend = 0;

            this.requestType = requestType;
            this.requestRole = requestRole;
            this.authToken = authToken;
            this.secretKey = secretKey;
            this.customTags = customTags;
        }

        public RequestType GetRequestType()
        {
            return this.requestType;
        }

        public RequestRole GetRequestRole()
        {
            return this.requestRole;
        }

        public string GetAuthToken()
        {
            return this.authToken;
        }

        public string GetSecretKey()
        {
            return this.secretKey;
        }

        public GNHashtable GetCustomTags()
        {
            return this.customTags;
        }

        public void OnSend()
        {
            this.firstSend = UnityEngine.Time.realtimeSinceStartup;
            this.timeout = this.firstSend + this.operationRequest.GetTimeout();
        }

        public void OnRecv()
        {
            this.secondsSend = UnityEngine.Time.realtimeSinceStartup;
        }

        public float GetExecuteTimerInMs()
        {
            return (this.secondsSend - this.firstSend) * 1000;
        }

        public bool IsTimeout()
        {
            return this.timeout < UnityEngine.Time.realtimeSinceStartup;
        }

        public OperationRequest GetOperationRequest()
        {
            return this.operationRequest;
        }

        public Action<OperationResponse> GetCallback()
        {
            return this.onOperationResponse;
        }

    }

}
