namespace XmobiTea.GN.Common
{
    /// <summary>
    /// The base class for GNData, providing core functionalities for handling GNData structures.
    /// </summary>
    public abstract class GNData : IGNData
    {
        /// <summary>
        /// Converts origin data (e.g., list or dictionary) into a GNData structure.
        /// </summary>
        /// <param name="value">The value to convert. It can be a list, dictionary, or any other object.</param>
        /// <returns>A GNArray, GNHashtable, or the original value depending on the input type.</returns>
        protected static object createUseDataFromOriginData(object value)
        {
            if (value == null) return null;

            if (value is System.Collections.IList list)
            {
                var answer = new GNArray.Builder().addAll(list).build();
                return answer;
            }

            if (value is System.Collections.IDictionary dict)
            {
                var answer = new GNHashtable.Builder().addAll(dict).build();
                return answer;
            }

            return value;
        }

        /// <summary>
        /// Converts GNData structures (GNArray, GNHashtable) into a serializable data format.
        /// </summary>
        /// <param name="value">The GNData object to convert.</param>
        /// <returns>A serialized representation of the GNData object or the original value.</returns>
        protected static object createDataFromUseData(object value)
        {
            if (value == null) return null;

            if (value is IGNData gnData)
            {
                return gnData.toData();
            }

            return value;
        }

        /// <summary>
        /// Converts the current GNData object into a serializable data format.
        /// </summary>
        /// <returns>A serializable representation of the GNData object.</returns>
        public abstract object toData();

        /// <summary>
        /// Converts the current GNData object into a string representation.
        /// </summary>
        /// <returns>A string representation of the GNData object.</returns>
        public abstract string toString();
    }
}
