namespace XmobiTea.GN.Networking
{
    using XmobiTea.GN.Entity;

    public interface IServerEventHandler
    {
        int GetEventCode();

        void Handle(OperationEvent operationEvent);

    }

}
