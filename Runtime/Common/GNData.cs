namespace XmobiTea.GearN.Common
{
    using System;

    /// <summary>
    /// The base class for GNData, providing core functionalities for handling GNData structures.
    /// </summary>
    public abstract class GNData : IGNData
    {
        private static readonly Type typeOfByte = typeof(byte);
        private static readonly Type typeOfSByte = typeof(sbyte);
        private static readonly Type typeOfShort = typeof(short);
        private static readonly Type typeOfUShort = typeof(ushort);
        private static readonly Type typeOfInt = typeof(int);
        private static readonly Type typeOfUInt = typeof(uint);
        private static readonly Type typeOfFloat = typeof(float);
        private static readonly Type typeOfLong = typeof(long);
        private static readonly Type typeOfULong = typeof(ulong);
        private static readonly Type typeOfDouble = typeof(double);

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

            var valueType = value.GetType();
            if (valueType.GetType().IsEnum)
            {
                var underlyingValueType = Enum.GetUnderlyingType(valueType);

                if (underlyingValueType == GNData.typeOfByte) return Convert.ToByte(value);
                else if (underlyingValueType == GNData.typeOfSByte) return Convert.ToSByte(value);
                else if (underlyingValueType == GNData.typeOfShort) return Convert.ToInt16(value);
                else if (underlyingValueType == GNData.typeOfUShort) return Convert.ToUInt16(value);
                else if (underlyingValueType == GNData.typeOfInt) return Convert.ToInt32(value);
                else if (underlyingValueType == GNData.typeOfUInt) return Convert.ToUInt32(value);
                else if (underlyingValueType == GNData.typeOfFloat) return Convert.ToSingle(value);
                else if (underlyingValueType == GNData.typeOfLong) return Convert.ToInt64(value);
                else if (underlyingValueType == GNData.typeOfULong) return Convert.ToUInt64(value);
                else if (underlyingValueType == GNData.typeOfDouble) return Convert.ToDouble(value);
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
