namespace XmobiTea.GN.Networking
{
    using System;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;

    internal interface IPeer
    {
        void InitPeer();

        void Enqueue(RequestType requestType, RequestRole requestRole, OperationRequest operationRequest, Action<OperationResponse> onOperationResponse, string authToken, string secretKey, GNHashtable customTags);

        bool IsUsing();

        void Service();
    }

}
