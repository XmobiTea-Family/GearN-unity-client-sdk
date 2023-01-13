namespace XmobiTea.GN.Networking
{
    using System;

    using XmobiTea.GN.Entity;

    public struct OperationPending
    {
        private OperationRequest operationRequest;
        private Action<OperationResponse> onOperationResponse;
        private float timeout;

        private float firstSend;
        private float secondsSend;

        public OperationPending(OperationRequest operationRequest, Action<OperationResponse> onOperationResponse)
        {
            this.operationRequest = operationRequest;
            this.onOperationResponse = onOperationResponse;
            this.timeout = UnityEngine.Time.realtimeSinceStartup + OperationRequest.DefaultTimeOut;
            this.firstSend = 0;
            this.secondsSend = 0;
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
