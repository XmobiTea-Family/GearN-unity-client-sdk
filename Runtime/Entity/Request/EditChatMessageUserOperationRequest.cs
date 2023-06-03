namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class EditChatMessageUserOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.EditChatMessageUser;

        protected override bool operationEncrypted => true;

        public EditChatMessageUserOperationRequest(long tsCreate, string userId, string message = null, bool? isDelete = null, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(ChatParameterCode.TsCreate, tsCreate)
                .Add(ChatParameterCode.UserId, userId)
                .Build();

            if (message != null) this.operationParameters.Add(ChatParameterCode.Message, message);
            if (isDelete != null) this.operationParameters.Add(ChatParameterCode.IsDelete, isDelete.GetValueOrDefault());
        }

    }

}
