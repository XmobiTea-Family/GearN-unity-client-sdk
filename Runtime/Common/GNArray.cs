namespace XmobiTea.GN.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The GNData array, it store Array can be use to request or response
    /// </summary>
    public class GNArray : GNData
    {
        /// <summary>
        /// Builder for GNArray
        /// </summary>
        public class Builder
        {
            /// <summary>
            /// The origin array
            /// </summary>
            private List<object> array;

            /// <summary>
            /// Add a value to origin array
            /// </summary>
            /// <param name="value">The value type must is string, bool, number, Map or Array</param>
            /// <returns></returns>
            public Builder add(object value)
            {
                this.array.Add(value);

                return this;
            }

            /// <summary>
            /// Add some values to origin array
            /// </summary>
            /// <param name="list">The element value type must is type string, bool, number, Map or Array</param>
            /// <returns></returns>
            public Builder addAll(System.Collections.IList list)
            {
                foreach (var o in list)
                {
                    this.add(o);
                }

                return this;
            }

            /// <summary>
            /// Build GNArray
            /// </summary>
            /// <returns></returns>
            public GNArray build()
            {
                var awnser = new GNArray();

                foreach (var o in this.array)
                {
                    awnser.add(o);
                }

                return awnser;
            }

            /// <summary>
            /// Constructor for GNArray builder
            /// </summary>
            public Builder()
            {
                this.array = new List<object>();
            }
        }

        /// <summary>
        /// The GN array
        /// </summary>
        private List<object> array;

        /// <summary>
        /// The constructor for GNArray
        /// </summary>
        public GNArray()
        {
            this.array = new List<object>();
        }

        /// <summary>
        /// Add a value
        /// </summary>
        /// <param name="value">The </param>
        public void add(object value)
        {
            this.array.Add(GNData.createUseDataFromOriginData(value));
        }

        public ICollection<object> values()
        {
            return this.array;
        }

        public void clear()
        {
            this.array.Clear();
        }

        public bool remove(int index)
        {
            this.array.RemoveAt(index);

            return true;
        }

        public int count()
        {
            return this.array.Count;
        }

        protected object get<T>(int k, T defaultValue = default(T))
        {
            if (k < 0 || k > this.array.Count - 1) return defaultValue;

            var value = this.array[k];

            if (value == null) return defaultValue;

            if (value is T t)
            {
                return t;
            }

            return value;
        }

        public T[] toArray<T>()
        {
            var answer = new T[this.array.Count];

            for (var i = 0; i < this.array.Count; i++)
            {
                answer[i] = (T)this.customGet(i);
            }

            return answer;
        }

        public IList<T> toList<T>()
        {
            var answer = new List<T>();

            for (var i = 0; i < this.array.Count; i++)
            {
                answer.Add((T)this.customGet(i));
            }

            return answer;
        }

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

        public byte getByte(int k, byte defaultValue = 0)
        {
            return Convert.ToByte(this.get(k, defaultValue));
        }

        public sbyte getSByte(int k, sbyte defaultValue = 0)
        {
            return Convert.ToSByte(this.get(k, defaultValue));
        }

        public short getShort(int k, short defaultValue = 0)
        {
            return Convert.ToInt16(this.get(k, defaultValue));
        }

        public int getInt(int k, int defaultValue = 0)
        {
            return Convert.ToInt32(this.get(k, defaultValue));
        }

        public float getFloat(int k, float defaultValue = 0)
        {
            return Convert.ToSingle(this.get(k, defaultValue));
        }

        public long getLong(int k, long defaultValue = 0)
        {
            return Convert.ToInt64(this.get(k, defaultValue));
        }

        public double getDouble(int k, double defaultValue = 0)
        {
            return Convert.ToDouble(this.get(k, defaultValue));
        }

        public bool getBool(int k, bool defaultValue = false)
        {
            return Convert.ToBoolean(this.get(k, defaultValue));
        }

        public string getString(int k, string defaultValue = null)
        {
            return Convert.ToString(this.get(k, defaultValue));
        }

        public object getObject(int k, object defaultValue = null)
        {
            return this.get(k, defaultValue);
        }

        public T[] getArray<T>(int k, T[] defaultValue = null)
        {
            var value0 = this.getGNArray(k);
            if (value0 != null)
            {
                return value0.toArray<T>();
            }

            return defaultValue;
        }

        public IList<T> getList<T>(int k, IList<T> defaultValue = null)
        {
            var value0 = this.getGNArray(k);
            if (value0 != null)
            {
                return value0.toList<T>();
            }

            return defaultValue;
        }

        public GNArray getGNArray(int k, GNArray defaultValue = null)
        {
            return (GNArray)this.get(k, defaultValue);
        }

        public GNHashtable getGNHashtable(int k, GNHashtable defaultValue = null)
        {
            return (GNHashtable)this.get(k, defaultValue);
        }

        public override object toData()
        {
            var answer = new List<object>();

            foreach (var c in this.array)
            {
                answer.Add(GNData.createDataFromUseData(c));
            }

            return answer;
        }

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

        public override string ToString()
        {
            return this.toString();
        }

    }

}
