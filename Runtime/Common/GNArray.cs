namespace XmobiTea.GearN.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Represents a GNData array, which can be used for request or response data.
    /// </summary>
    public class GNArray : GNData
    {
        /// <summary>
        /// A builder class to help construct a GNArray.
        /// </summary>
        public class Builder
        {
            /// <summary>
            /// The internal list representing the array.
            /// </summary>
            private List<object> array;

            /// <summary>
            /// Adds a value to the internal array.
            /// </summary>
            /// <param name="value">The value to add, must be a supported type.</param>
            /// <returns>The current Builder instance.</returns>
            public Builder add(object value)
            {
                this.array.Add(value);
                return this;
            }

            /// <summary>
            /// Adds a collection of values to the internal array.
            /// </summary>
            /// <param name="list">The list of values to add.</param>
            /// <returns>The current Builder instance.</returns>
            public Builder addAll(System.Collections.IList list)
            {
                foreach (var o in list)
                {
                    this.add(o);
                }
                return this;
            }

            /// <summary>
            /// Builds and returns the GNArray.
            /// </summary>
            /// <returns>The constructed GNArray instance.</returns>
            public GNArray build()
            {
                var answer = new GNArray();
                foreach (var o in this.array)
                {
                    answer.add(o);
                }
                return answer;
            }

            /// <summary>
            /// Initializes a new instance of the Builder class.
            /// </summary>
            public Builder()
            {
                this.array = new List<object>();
            }
        }

        /// <summary>
        /// The internal array storing the data.
        /// </summary>
        private List<object> array;

        /// <summary>
        /// Initializes a new instance of the GNArray class.
        /// </summary>
        public GNArray()
        {
            this.array = new List<object>();
        }

        /// <summary>
        /// Adds a value to the GNArray.
        /// </summary>
        /// <param name="value">The value to add.</param>
        public void add(object value)
        {
            this.array.Add(GNData.createUseDataFromOriginData(value));
        }

        /// <summary>
        /// Gets or sets a value in the GNArray by index.
        /// </summary>
        /// <param name="index">The index of the value.</param>
        /// <returns>The value at the specified index.</returns>
        public object this[int index]
        {
            get => this.get<object>(index);
            set => this.array[index] = GNData.createUseDataFromOriginData(value);
        }

        /// <summary>
        /// Gets all values in the GNArray as a collection.
        /// </summary>
        /// <returns>A collection of all values in the GNArray.</returns>
        public ICollection<object> values()
        {
            return this.array;
        }

        /// <summary>
        /// Clears all elements in the GNArray.
        /// </summary>
        public void clear()
        {
            this.array.Clear();
        }

        /// <summary>
        /// Removes a value at the specified index.
        /// </summary>
        /// <param name="index">The index of the value to remove.</param>
        /// <returns>True if the value was removed.</returns>
        public bool remove(int index)
        {
            this.array.RemoveAt(index);
            return true;
        }

        /// <summary>
        /// Gets the number of elements in the GNArray.
        /// </summary>
        /// <returns>The number of elements.</returns>
        public int count()
        {
            return this.array.Count;
        }

        /// <summary>
        /// Gets a value at the specified index.
        /// </summary>
        /// <typeparam name="T">The expected type of the value.</typeparam>
        /// <param name="k">The index.</param>
        /// <param name="defaultValue">The default value to return if the index is invalid.</param>
        /// <returns>The value at the index or the default value.</returns>
        protected object get<T>(int k, T defaultValue = default(T))
        {
            if (k < 0 || k > this.array.Count - 1) return defaultValue;

            var value = this.array[k];
            if (value == null) return defaultValue;

            return value is T t ? t : value;
        }

        /// <summary>
        /// Converts the GNArray to an array of the specified type.
        /// </summary>
        /// <typeparam name="T">The target type.</typeparam>
        /// <returns>An array of the target type.</returns>
        public T[] toArray<T>()
        {
            var answer = new T[this.array.Count];
            for (var i = 0; i < this.array.Count; i++)
            {
                answer[i] = (T)this.customGet(i);
            }
            return answer;
        }

        /// <summary>
        /// Converts the GNArray to a list of the specified type.
        /// </summary>
        /// <typeparam name="T">The target type.</typeparam>
        /// <returns>A list of the target type.</returns>
        public IList<T> toList<T>()
        {
            var answer = new List<T>();
            for (var i = 0; i < this.array.Count; i++)
            {
                answer.Add((T)this.customGet(i));
            }
            return answer;
        }

        /// <summary>
        /// Helper method to retrieve and convert a value at a specified index based on its type.
        /// </summary>
        /// <param name="k">The index of the value.</param>
        /// <returns>The converted value or null if the index is invalid.</returns>
        private object customGet(int k)
        {
            var obj = this.get<object>(k);
            if (obj == null) return null;

            var objType = obj.GetType();
            if (objType == typeof(byte)) return this.getByte(k);
            else if (objType == typeof(sbyte)) return this.getSByte(k);
            else if (objType == typeof(short)) return this.getShort(k);
            else if (objType == typeof(int)) return this.getInt(k);
            else if (objType == typeof(float)) return this.getFloat(k);
            else if (objType == typeof(long)) return this.getLong(k);
            else if (objType == typeof(double)) return this.getDouble(k);
            else if (objType == typeof(bool)) return this.getBool(k);
            else if (objType == typeof(string)) return this.getString(k);
            else if (objType == typeof(GNArray) || objType == typeof(System.Collections.IList)) return this.getGNArray(k);
            else if (objType == typeof(GNHashtable) || objType == typeof(System.Collections.IDictionary)) return this.getGNHashtable(k);

            return obj;
        }

        /// <summary>
        /// Retrieves a byte value at the specified index.
        /// </summary>
        public byte getByte(int k, byte defaultValue = 0)
        {
            return Convert.ToByte(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves an sbyte value at the specified index.
        /// </summary>
        public sbyte getSByte(int k, sbyte defaultValue = 0)
        {
            return Convert.ToSByte(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves a short value at the specified index.
        /// </summary>
        public short getShort(int k, short defaultValue = 0)
        {
            return Convert.ToInt16(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves an int value at the specified index.
        /// </summary>
        public int getInt(int k, int defaultValue = 0)
        {
            return Convert.ToInt32(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves a float value at the specified index.
        /// </summary>
        public float getFloat(int k, float defaultValue = 0)
        {
            return Convert.ToSingle(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves a long value at the specified index.
        /// </summary>
        public long getLong(int k, long defaultValue = 0)
        {
            return Convert.ToInt64(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves a double value at the specified index.
        /// </summary>
        public double getDouble(int k, double defaultValue = 0)
        {
            return Convert.ToDouble(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves a bool value at the specified index.
        /// </summary>
        public bool getBool(int k, bool defaultValue = false)
        {
            return Convert.ToBoolean(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves a string value at the specified index.
        /// </summary>
        public string getString(int k, string defaultValue = null)
        {
            return Convert.ToString(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves an object value at the specified index.
        /// </summary>
        public object getObject(int k, object defaultValue = null)
        {
            return this.get(k, defaultValue);
        }

        /// <summary>
        /// Retrieves an array of the specified type at the specified index.
        /// </summary>
        public T[] getArray<T>(int k, T[] defaultValue = null)
        {
            var value0 = this.getGNArray(k);
            if (value0 != null)
            {
                return value0.toArray<T>();
            }

            return defaultValue;
        }

        /// <summary>
        /// Retrieves a list of the specified type at the specified index.
        /// </summary>
        public IList<T> getList<T>(int k, IList<T> defaultValue = null)
        {
            var value0 = this.getGNArray(k);
            if (value0 != null)
            {
                return value0.toList<T>();
            }

            return defaultValue;
        }

        /// <summary>
        /// Retrieves a GNArray value at the specified index.
        /// </summary>
        public GNArray getGNArray(int k, GNArray defaultValue = null)
        {
            return (GNArray)this.get(k, defaultValue);
        }

        /// <summary>
        /// Retrieves a GNHashtable value at the specified index.
        /// </summary>
        public GNHashtable getGNHashtable(int k, GNHashtable defaultValue = null)
        {
            return (GNHashtable)this.get(k, defaultValue);
        }

        /// <summary>
        /// Converts the GNArray into a data object suitable for serialization.
        /// </summary>
        public override object toData()
        {
            var answer = new List<object>();

            foreach (var c in this.array)
            {
                answer.Add(GNData.createDataFromUseData(c));
            }

            return answer;
        }

        /// <summary>
        /// Converts the GNArray into a string representation.
        /// </summary>
        public override string toString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("[");

            for (var i = 0; i < this.array.Count; i++)
            {
                if (i != 0) stringBuilder.Append(",");

                var value = this.array[i];

                if (value == null) stringBuilder.Append("null");
                else if (value is GNData gnData) stringBuilder.Append(gnData.ToString());
                else if (value is string valueStr) stringBuilder.Append("\"" + valueStr + "\"");
                else if (value is bool boolValue) stringBuilder.Append(boolValue.ToString().ToLower());
                else stringBuilder.Append(value);
            }

            stringBuilder.Append("]");
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Returns the string representation of the GNArray.
        /// </summary>
        public override string ToString()
        {
            return this.toString();
        }

    }

}
