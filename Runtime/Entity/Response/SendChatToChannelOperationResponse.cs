namespace XmobiTea.GN.Entity.Response
{
    using XmobiTea.GN.Constant;

    public class SendChatToChannelOperationResponse : CustomOperationResponse
    {

        public override void SetupOperationResponse(OperationResponse operationResponse)
        {
            base.SetupOperationResponse(operationResponse);

            if (!this.HasError())
            {
                if (this.errorCode == ChatErrorCode.Ok)
                {

                }
            }
        }

    }

}
