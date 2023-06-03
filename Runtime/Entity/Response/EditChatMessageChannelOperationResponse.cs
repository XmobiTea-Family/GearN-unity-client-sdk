namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class EditChatMessageChannelOperationResponse : CustomOperationResponse
    {

        public override void SetupOperationResponse(OperationResponse operationResponse)
        {
            base.SetupOperationResponse(operationResponse);

            if (!this.HasError())
            {
                if (this.errorCode == ChatErrorCode.Ok)
                {

                }
                else if (this.errorCode == ChatErrorCode.UserDoesNotSender)
                {

                }
            }
        }

    }

}
