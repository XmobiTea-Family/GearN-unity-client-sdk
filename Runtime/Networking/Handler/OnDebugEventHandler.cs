namespace XmobiTea.GN.Networking
{
    using UnityEngine;
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity;

    public class OnDebugEventHandler : IServerEventHandler
    {
        public int GetEventCode() => EventCode.OnDebug;

        public void Handle(OperationEvent operationEvent)
        {
            Debug.Log(operationEvent);
        }
    }
}
