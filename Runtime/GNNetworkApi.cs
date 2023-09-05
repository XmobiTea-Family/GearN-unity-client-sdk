namespace XmobiTea.GN
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Entity.Response;

    using System;
    using XmobiTea.GN.Networking;
    using XmobiTea.GN.Constant;
    using System.Collections.Generic;
    using XmobiTea.GN.Entity;

    public static partial class GNNetwork
    {
        public static void SyncTs(Action<long> onResponse = null)
        {
            peer.SyncTs(onResponse);
        }

        public static void AccountLogin(string username, string password, Action<LoginOperationResponse> onResponse = null)
        {
            peer.AccountLogin(username, password, onResponse);
        }

    }

}
