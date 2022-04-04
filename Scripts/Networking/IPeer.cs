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
            this.timeout = UnityEngine.Time.realtimeSinceStartup + 15;
            this.firstSend = 0;
            this.secondsSend = 0;
        }

        public void OnSend()
        {
            this.timeout = UnityEngine.Time.realtimeSinceStartup + this.operationRequest.GetTimeOut();
            this.firstSend = UnityEngine.Time.realtimeSinceStartup;
        }

        public void OnRecv()
        {
            this.secondsSend = UnityEngine.Time.realtimeSinceStartup;
        }

        public float GetExecuteTimerInMs()
        {
            return (this.secondsSend - this.firstSend) / 1000;
        }

        public float GetTimeout()
        {
            return timeout;
        }

        public OperationRequest GetOperationRequest()
        {
            return operationRequest;
        }

        public Action<OperationResponse> GetCallback()
        {
            return onOperationResponse;
        }
    }

    internal interface IPeer
    {
        void InitPeer();
        void Enqueue(OperationRequest operationRequest, Action<OperationResponse> onOperationResponse);
    }
}

