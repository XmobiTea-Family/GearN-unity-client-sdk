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
            this.timeout = UnityEngine.Time.realtimeSinceStartup + OperationRequest.defaultTimeOut;
            this.firstSend = 0;
            this.secondsSend = 0;

            this.requestType = requestType;
            this.requestRole = requestRole;
            this.authToken = authToken;
            this.secretKey = secretKey;
            this.customTags = customTags;
        }

        public RequestType getRequestType()
        {
            return this.requestType;
        }

        public RequestRole getRequestRole()
        {
            return this.requestRole;
        }

        public string getAuthToken()
        {
            return this.authToken;
        }

        public string getSecretKey()
        {
            return this.secretKey;
        }

        public GNHashtable getCustomTags()
        {
            return this.customTags;
        }

        public void onSend()
        {
            this.firstSend = UnityEngine.Time.realtimeSinceStartup;
            this.timeout = this.firstSend + this.operationRequest.getTimeout();
        }

        public void onRecv()
        {
            this.secondsSend = UnityEngine.Time.realtimeSinceStartup;
        }

        public float getExecuteTimerInMs()
        {
            return (this.secondsSend - this.firstSend) * 1000;
        }

        public bool isTimeout()
        {
            return this.timeout < UnityEngine.Time.realtimeSinceStartup;
        }

        public OperationRequest getOperationRequest()
        {
            return this.operationRequest;
        }

        public Action<OperationResponse> getCallback()
        {
            return this.onOperationResponse;
        }

    }

}
