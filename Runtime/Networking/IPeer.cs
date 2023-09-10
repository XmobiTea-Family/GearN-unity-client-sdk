namespace XmobiTea.GN.Networking
{
    using System;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;

    internal interface IPeer
    {
        void initPeer();

        void enqueue(RequestType requestType, RequestRole requestRole, OperationRequest operationRequest, Action<OperationResponse> onOperationResponse, string authToken, string secretKey, GNHashtable customTags);

        bool isUsing();

        void service();
    }

}
