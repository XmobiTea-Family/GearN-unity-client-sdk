namespace XmobiTea.GN.Unity
{
    using XmobiTea.GN.Networking;

    internal class ServiceUpdate : UnityEngine.MonoBehaviour
    {
        internal NetworkingPeer peer;

        private void update()
        {
            this.peer?.service();
        }

        void Update()
        {
            this.update();
        }
    }

}
