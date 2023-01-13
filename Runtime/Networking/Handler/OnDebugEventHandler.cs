namespace XmobiTea.GN.Networking
{
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;

    public class OnDebugEventHandler : IServerEventHandler
    {
        public int GetEventCode() => EventCode.OnDebug;

        public void Handle(OperationEvent operationEvent)
        {
            UnityEngine.Debug.Log(operationEvent);
        }

    }

}
