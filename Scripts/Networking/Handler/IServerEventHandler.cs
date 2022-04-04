namespace XmobiTea.GN.Networking
{
    using XmobiTea.GN.Entity;

    internal interface IServerEventHandler
    {
        int GetEventCode();
        void Handle(OperationEvent operationEvent);
    }
}