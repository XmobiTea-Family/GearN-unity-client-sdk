namespace XmobiTea.GearN.Unity
{
    using XmobiTea.GearN.Networking;

    /// <summary>
    /// The ServiceUpdate class is responsible for updating and handling network services.
    /// </summary>
    internal class ServiceUpdate : UnityEngine.MonoBehaviour
    {
        /// <summary>
        /// The NetworkingPeer instance used to perform network operations.
        /// </summary>
        internal NetworkingPeer peer;

        /// <summary>
        /// Handles the logic to update the network service.
        /// </summary>
        private void update()
        {
            // Calls the service() method of the peer object if it is not null.
            this.peer?.service();
        }

        /// <summary>
        /// Unity's Update method, called once per frame.
        /// </summary>
        void Update()
        {
            // Invokes the custom update() method to handle network logic.
            this.update();
        }
    }
}
