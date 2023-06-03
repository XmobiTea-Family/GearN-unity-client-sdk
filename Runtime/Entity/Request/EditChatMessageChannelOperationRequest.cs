namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class EditChatMessageChannelOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.EditChatMessageChannel;

        protected override bool operationEncrypted => true;

        public EditChatMessageChannelOperationRequest(long tsCreate, string channel, string message = null, bool? isDelete = null, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(ChatParameterCode.TsCreate, tsCreate)
                .Add(ChatParameterCode.Channel, channel)
                .Build();

            if (message != null) this.operationParameters.Add(ChatParameterCode.Message, message);
            if (isDelete != null) this.operationParameters.Add(ChatParameterCode.IsDelete, isDelete.GetValueOrDefault());
        }

    }

}
