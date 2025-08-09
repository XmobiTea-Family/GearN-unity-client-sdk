namespace XmobiTea.GearN.Common
{
    /// <summary>
    /// Interface defining the structure for GNData objects.
    /// </summary>
    public interface IGNData
    {
        /// <summary>
        /// Converts the current GNData object into a serializable data format.
        /// </summary>
        /// <returns>A serializable representation of the GNData object.</returns>
        object toData();

        /// <summary>
        /// Converts the current GNData object into a string representation.
        /// </summary>
        /// <returns>A string representation of the GNData object.</returns>
        string toString();
    }
}
