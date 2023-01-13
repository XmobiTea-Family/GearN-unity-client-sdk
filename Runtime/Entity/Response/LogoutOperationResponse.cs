using XmobiTea.GN.Logger;

namespace XmobiTea.GN.Entity.Response
{
    public class LogoutOperationResponse : CustomOperationResponse
    {

        public override void SetupOperationResponse(OperationResponse operationResponse)
        {
            base.SetupOperationResponse(operationResponse);

            if (!this.hasError)
            {
                GNNetwork.authToken = string.Empty;
                GNNetwork.userId = string.Empty;

                GNDebug.Log("[GN] Logout success.");
            }
            else
            {
                GNDebug.LogError("[GN] You need login before logout.");
            }
        }

    }

}
