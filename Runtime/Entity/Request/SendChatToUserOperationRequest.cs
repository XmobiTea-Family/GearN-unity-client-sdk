namespace XmobiTea.GN.Entity.Request
{
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public class SendChatToUserOperationRequest : CustomOperationRequest
    {
        protected override int operationCode => OperationCode.SendChatToUser;

        protected override bool operationEncrypted => true;

        public SendChatToUserOperationRequest(string userId, string message, bool? saveToDatabase = false, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            this.operationParameters = new GNHashtable.Builder()
                .Add(ChatParameterCode.UserId, userId)
                .Add(ChatParameterCode.Message, message)
                .Build();

            if (saveToDatabase != null) this.operationParameters.Add(ChatParameterCode.SaveToDatabase, saveToDatabase.GetValueOrDefault());
        }

    }

}
