namespace XmobiTea.GearN.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// A hashtable implementation for GNData, supporting serialization and custom key-value storage.
    /// </summary>
    public class GNHashtable : GNData
    {
        public class Builder
        {
            private IDictionary<string, object> dict;

            /// <summary>
            /// Adds a key-value pair to the internal dictionary.
            /// </summary>
            /// <param name="key">The key for the entry, must be a string.</param>
            /// <param name="value">The value for the entry.</param>
            /// <returns>The current Builder instance.</returns>
            public Builder add(string key, object value)
            {
                this.dict[key] = value;

                return this;
            }

            /// <summary>
            /// Adds all key-value pairs from an existing dictionary to the internal dictionary.
            /// </summary>
            /// <param name="dict">The dictionary containing key-value pairs to add.</param>
            /// <returns>The current Builder instance.</returns>
            public Builder addAll(System.Collections.IDictionary dict)
            {
                var keys = dict.Keys;
                foreach (var key in keys)
                {
                    if (key is string keyStr)
                    {
                        this.add(keyStr, dict[key]);
                    }
                }
                return this;
            }

            /// <summary>
            /// Constructs a new GNHashtable instance using the current key-value pairs.
            /// </summary>
            /// <returns>A GNHashtable containing the added key-value pairs.</returns>
            public GNHashtable build()
            {
                var answer = new GNHashtable();

                var keys = this.dict.Keys;
                foreach (var key in keys)
                {
                    answer.add(key, this.dict[key]);
                }

                return answer;
            }

            /// <summary>
            /// Initializes a new instance of the Builder class.
            /// </summary>
            public Builder()
            {
                this.dict = new Dictionary<string, object>();
            }
        }

        private IDictionary<string, object> dict;

        /// <summary>
        /// Initializes a new instance of the GNHashtable class.
        /// </summary>
        public GNHashtable()
        {
            this.dict = new Dictionary<string, object>();
        }

        /// <summary>
        /// Adds or updates a key-value pair in the hashtable.
        /// </summary>
        /// <param name="key">The key to add or update.</param>
        /// <param name="value">The value associated with the key.</param>
        public void add(string key, object value)
        {
            this.dict[key] = GNData.createUseDataFromOriginData(value);
        }

        /// <summary>
        /// Gets or sets the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key to get or set.</param>
        /// <returns>The value associated with the key.</returns>
        public object this[string key]
        {
            get => this.getObject(key);
            set => this.add(key, value);
        }

        /// <summary>
        /// Gets a collection of all values in the hashtable.
        /// </summary>
        /// <returns>A collection of all values in the hashtable.</returns>
        public ICollection<object> values()
        {
            return this.dict.Values;
        }

        /// <summary>
        /// Gets a collection of all keys in the hashtable.
        /// </summary>
        /// <returns>A collection of all keys in the hashtable.</returns>
        public ICollection<string> keys()
        {
            return this.dict.Keys;
        }

        /// <summary>
        /// Determines whether the hashtable contains the specified key.
        /// </summary>
        /// <param name="key">The key to locate.</param>
        /// <returns>true if the hashtable contains the key; otherwise, false.</returns>
        public bool containsKey(string key)
        {
            return this.dict.ContainsKey(key);
        }

        /// <summary>
        /// Removes all key-value pairs from the hashtable.
        /// </summary>
        public void clear()
        {
            this.dict.Clear();
        }

        /// <summary>
        /// Removes the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key of the value to remove.</param>
        /// <returns>true if the value was successfully removed; otherwise, false.</returns>
        public bool remove(string key)
        {
            return this.dict.Remove(key);
        }

        /// <summary>
        /// Gets the number of key-value pairs in the hashtable.
        /// </summary>
        /// <returns>The number of key-value pairs in the hashtable.</returns>
        public int count()
        {
            return this.dict.Count;
        }

        /// <summary>
        /// Retrieves the value associated with the specified key, or a default value if the key does not exist.
        /// </summary>
        /// <typeparam name="T">The expected type of the value.</typeparam>
        /// <param name="k">The key to locate.</param>
        /// <param name="defaultValue">The default value to return if the key is not found.</param>
        /// <returns>The value associated with the key, or the default value if the key is not found.</returns>
        protected object get<T>(string k, T defaultValue = default(T))
        {
            if (this.dict.ContainsKey(k))
            {
                var value = this.dict[k];

                if (value == null) return defaultValue;

                if (value is T t)
                {
                    return t;
                }

                return value;
            }

            return defaultValue;
        }

        /// <summary>
        /// Retrieves a byte value from the hashtable for the specified key.
        /// </summary>
        /// <param name="k">The key to lookup in the hashtable.</param>
        /// <param name="defaultValue">The default value to return if the key does not exist or the value cannot be converted.</param>
        /// <returns>The byte value associated with the key or the default value.</returns>
        public byte getByte(string k, byte defaultValue = 0)
        {
            return Convert.ToByte(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves a signed byte (sbyte) value from the hashtable for the specified key.
        /// </summary>
        /// <param name="k">The key to lookup in the hashtable.</param>
        /// <param name="defaultValue">The default value to return if the key does not exist or the value cannot be converted.</param>
        /// <returns>The sbyte value associated with the key or the default value.</returns>
        public sbyte getSByte(string k, sbyte defaultValue = 0)
        {
            return Convert.ToSByte(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves a short value from the hashtable for the specified key.
        /// </summary>
        /// <param name="k">The key to lookup in the hashtable.</param>
        /// <param name="defaultValue">The default value to return if the key does not exist or the value cannot be converted.</param>
        /// <returns>The short value associated with the key or the default value.</returns>
        public short getShort(string k, short defaultValue = 0)
        {
            return Convert.ToInt16(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves an integer value from the hashtable for the specified key.
        /// </summary>
        /// <param name="k">The key to lookup in the hashtable.</param>
        /// <param name="defaultValue">The default value to return if the key does not exist or the value cannot be converted.</param>
        /// <returns>The integer value associated with the key or the default value.</returns>
        public int getInt(string k, int defaultValue = 0)
        {
            return Convert.ToInt32(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves a float value from the hashtable for the specified key.
        /// </summary>
        /// <param name="k">The key to lookup in the hashtable.</param>
        /// <param name="defaultValue">The default value to return if the key does not exist or the value cannot be converted.</param>
        /// <returns>The float value associated with the key or the default value.</returns>
        public float getFloat(string k, float defaultValue = 0)
        {
            return Convert.ToSingle(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves a long value from the hashtable for the specified key.
        /// </summary>
        /// <param name="k">The key to lookup in the hashtable.</param>
        /// <param name="defaultValue">The default value to return if the key does not exist or the value cannot be converted.</param>
        /// <returns>The long value associated with the key or the default value.</returns>
        public long getLong(string k, long defaultValue = 0)
        {
            return Convert.ToInt64(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves a double value from the hashtable for the specified key.
        /// </summary>
        /// <param name="k">The key to lookup in the hashtable.</param>
        /// <param name="defaultValue">The default value to return if the key does not exist or the value cannot be converted.</param>
        /// <returns>The double value associated with the key or the default value.</returns>
        public double getDouble(string k, double defaultValue = 0)
        {
            return Convert.ToDouble(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves a boolean value from the hashtable for the specified key.
        /// </summary>
        /// <param name="k">The key to lookup in the hashtable.</param>
        /// <param name="defaultValue">The default value to return if the key does not exist or the value cannot be converted.</param>
        /// <returns>The boolean value associated with the key or the default value.</returns>
        public bool getBool(string k, bool defaultValue = false)
        {
            return Convert.ToBoolean(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves a string value from the hashtable for the specified key.
        /// </summary>
        /// <param name="k">The key to lookup in the hashtable.</param>
        /// <param name="defaultValue">The default value to return if the key does not exist or the value cannot be converted.</param>
        /// <returns>The string value associated with the key or the default value.</returns>
        public string getString(string k, string defaultValue = null)
        {
            return Convert.ToString(this.get(k, defaultValue));
        }

        /// <summary>
        /// Retrieves a raw object from the hashtable for the specified key.
        /// </summary>
        /// <param name="k">The key to lookup in the hashtable.</param>
        /// <param name="defaultValue">The default value to return if the key does not exist or the value cannot be converted.</param>
        /// <returns>The object associated with the key or the default value.</returns>
        public object getObject(string k, object defaultValue = null)
        {
            return this.get(k, defaultValue);
        }

        /// <summary>
        /// Retrieves an array of type <typeparamref name="T"/> from the hashtable for the specified key.
        /// </summary>
        /// <param name="k">The key to lookup in the hashtable.</param>
        /// <param name="defaultValue">The default value to return if the key does not exist or cannot be converted.</param>
        /// <returns>An array of type <typeparamref name="T"/> or the default value.</returns>
        public T[] getArray<T>(string k, T[] defaultValue = null)
        {
            var value0 = this.getGNArray(k);
            if (value0 != null)
            {
                return value0.toArray<T>();
            }

            return defaultValue;
        }

        /// <summary>
        /// Retrieves a list of type <typeparamref name="T"/> from the hashtable for the specified key.
        /// </summary>
        /// <param name="k">The key to lookup in the hashtable.</param>
        /// <param name="defaultValue">The default value to return if the key does not exist or cannot be converted.</param>
        /// <returns>A list of type <typeparamref name="T"/> or the default value.</returns>
        public IList<T> getList<T>(string k, IList<T> defaultValue = null)
        {
            var value0 = this.getGNArray(k);
            if (value0 != null)
            {
                return value0.toList<T>();
            }

            return defaultValue;
        }

        /// <summary>
        /// Retrieves a <see cref="GNArray"/> from the hashtable for the specified key.
        /// </summary>
        /// <param name="k">The key to lookup in the hashtable.</param>
        /// <param name="defaultValue">The default value to return if the key does not exist or cannot be converted.</param>
        /// <returns>A <see cref="GNArray"/> or the default value.</returns>
        public GNArray getGNArray(string k, GNArray defaultValue = null)
        {
            return (GNArray)this.get(k, defaultValue);
        }

        /// <summary>
        /// Retrieves a <see cref="GNHashtable"/> from the hashtable for the specified key.
        /// </summary>
        /// <param name="k">The key to lookup in the hashtable.</param>
        /// <param name="defaultValue">The default value to return if the key does not exist or cannot be converted.</param>
        /// <returns>A <see cref="GNHashtable"/> or the default value.</returns>
        public GNHashtable getGNHashtable(string k, GNHashtable defaultValue = null)
        {
            return (GNHashtable)this.get(k, defaultValue);
        }

        /// <summary>
        /// Converts the hashtable to a raw data dictionary suitable for external use.
        /// </summary>
        /// <returns>A dictionary containing the hashtable's key-value pairs as raw data.</returns>
        public override object toData()
        {
            var answer = new Dictionary<string, object>();

            foreach (var c in this.dict)
            {
                answer.Add(c.Key, GNData.createDataFromUseData(c.Value));
            }

            return answer;
        }

        /// <summary>
        /// Converts the hashtable to its string representation in JSON-like format.
        /// </summary>
        /// <returns>A string representing the hashtable.</returns>
        public override string toString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("{");

            var i = 0;
            foreach (var c in this.dict)
            {
                if (i != 0) stringBuilder.Append(",");

                i++;
                var value = c.Value;
                if (value == null) stringBuilder.Append($"\"{c.Key}\":null");
                else if (value is GNData gnData) stringBuilder.Append($"\"{c.Key}\":{gnData.ToString()}");
                else if (value is string valueStr) stringBuilder.Append($"\"{c.Key}\":\"{valueStr}\"");
                else if (value is bool boolValue) stringBuilder.Append($"\"{c.Key}\":{boolValue.ToString().ToLower()}");
                else stringBuilder.Append($"\"{c.Key}\":{value}");
            }

            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Overrides the default <see cref="object.ToString"/> method to return the hashtable's string representation.
        /// </summary>
        /// <returns>A string representing the hashtable.</returns>
        public override string ToString()
        {
            return this.toString();
        }
    }

}
