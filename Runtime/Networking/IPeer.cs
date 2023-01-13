namespace XmobiTea.GN.Networking
{
    using System;

    using XmobiTea.GN.Entity;

    internal interface IPeer
    {
        void InitPeer();

        void Enqueue(OperationRequest operationRequest, Action<OperationResponse> onOperationResponse);

        bool IsUsing();

        void Service();
    }

}
