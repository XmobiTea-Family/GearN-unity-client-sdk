namespace XmobiTea.GN.Entity.Response
{
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;

    public class FindPlayerOperationResponse : CustomOperationResponse
    {
        public List<string> playerLst { get; private set; }

        public override void SetupOperationResponse(OperationResponse operationResponse)
        {
            base.SetupOperationResponse(operationResponse);

            if (!this.HasError())
            {
                if (this.errorCode == FriendErrorCode.Ok)
                {
                    this.playerLst = this.parameters.GetList<string>(FriendParameterCode.PlayerLst) as List<string>;
                }
            }
        }

    }

}
