namespace XmobiTea.GN.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The GNData dictionary, it store Dictionary can be use to request or response
    /// </summary>
    public class GNHashtable : GNData
    {
        public class Builder
        {
            private IDictionary<string, object> dict;

            public Builder add(string key, object value)
            {
                this.dict[key] = value;

                return this;
            }

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

            public GNHashtable build()
            {
                var awnser = new GNHashtable();

                var keys = this.dict.Keys;
                foreach (var key in keys)
                {
                    awnser.add(key, this.dict[key]);
                }

                return awnser;
            }

            public Builder()
            {
                this.dict = new Dictionary<string, object>();
            }
        }

        private IDictionary<string, object> dict;

        public GNHashtable()
        {
            this.dict = new Dictionary<string, object>();
        }

        public void add(string key, object value)
        {
            this.dict[key] = GNData.createUseDataFromOriginData(value);
        }

        public ICollection<object> values()
        {
            return this.dict.Values;
        }

        public ICollection<string> keys()
        {
            return this.dict.Keys;
        }

        public bool containsKey(string key)
        {
            return this.dict.ContainsKey(key);
        }

        public void clear()
        {
            this.dict.Clear();
        }

        public bool remove(string key)
        {
            return this.dict.Remove(key);
        }

        public int count()
        {
            return this.dict.Count;
        }

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

        public byte getByte(string k, byte defaultValue = 0)
        {
            return Convert.ToByte(this.get(k, defaultValue));
        }

        public sbyte getSByte(string k, sbyte defaultValue = 0)
        {
            return Convert.ToSByte(this.get(k, defaultValue));
        }

        public short getShort(string k, short defaultValue = 0)
        {
            return Convert.ToInt16(this.get(k, defaultValue));
        }

        public int getInt(string k, int defaultValue = 0)
        {
            return Convert.ToInt32(this.get(k, defaultValue));
        }

        public float getFloat(string k, float defaultValue = 0)
        {
            return Convert.ToSingle(this.get(k, defaultValue));
        }

        public long getLong(string k, long defaultValue = 0)
        {
            return Convert.ToInt64(this.get(k, defaultValue));
        }

        public double getDouble(string k, double defaultValue = 0)
        {
            return Convert.ToDouble(this.get(k, defaultValue));
        }

        public bool getBool(string k, bool defaultValue = false)
        {
            return Convert.ToBoolean(this.get(k, defaultValue));
        }

        public string getString(string k, string defaultValue = null)
        {
            return Convert.ToString(this.get(k, defaultValue));
        }

        public object getObject(string k, object defaultValue = null)
        {
            return this.get(k, defaultValue);
        }

        public T[] getArray<T>(string k, T[] defaultValue = null)
        {
            var value0 = this.getGNArray(k);
            if (value0 != null)
            {
                return value0.toArray<T>();
            }

            return defaultValue;
        }

        public IList<T> getList<T>(string k, IList<T> defaultValue = null)
        {
            var value0 = this.getGNArray(k);
            if (value0 != null)
            {
                return value0.toList<T>();
            }

            return defaultValue;
        }

        public GNArray getGNArray(string k, GNArray defaultValue = null)
        {
            return (GNArray)this.get(k, defaultValue);
        }

        public GNHashtable getGNHashtable(string k, GNHashtable defaultValue = null)
        {
            return (GNHashtable)this.get(k, defaultValue);
        }

        public override object toData()
        {
            var answer = new Dictionary<string, object>();

            foreach (var c in this.dict)
            {
                answer.Add(c.Key, GNData.createDataFromUseData(c.Value));
            }

            return answer;
        }

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
                if (value == null) stringBuilder.Append("\"" + c.Key.ToString() + "\"" + ":null");
                else if (value is GNData gnData) stringBuilder.Append("\"" + c.Key.ToString() + "\"" + ":" + gnData.ToString());
                else if (value is string valueStr) stringBuilder.Append("\"" + c.Key.ToString() + "\"" + ":" + "\"" + valueStr + "\"");
                else if (value is bool boolValue) stringBuilder.Append("\"" + c.Key.ToString() + "\"" + ":" + boolValue.ToString().ToLower());
                else stringBuilder.Append("\"" + c.Key.ToString() + "\"" + ":" + value);
            }

            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return this.toString();
        }

    }

}
