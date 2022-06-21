using XmobiTea.GN.Logger;

namespace XmobiTea.GN.Entity.Response
{
    public class LogoutOperationResponse : CustomOperationResponse
    {
        public LogoutOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!hasError)
            {
                GNNetwork.authToken = string.Empty;

                GNDebug.Log("[GN] Logout success.");
            }
            else
            {
                GNDebug.LogError("[GN] You need login before logout.");
            }
        }
    }
}
