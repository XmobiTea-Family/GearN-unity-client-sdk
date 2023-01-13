namespace XmobiTea.GN.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GNHashtable : GNData
    {
        public class Builder
        {
            private IDictionary<string, object> originObject;

            public Builder Add(string key, object value)
            {
                this.originObject[key] = value;

                return this;
            }

            public Builder AddAll(System.Collections.IDictionary dict)
            {
                var keys = dict.Keys;
                foreach (var key in keys)
                {
                    if (key is string keyStr)
                    {
                        this.Add(keyStr, dict[key]);
                    }
                }

                return this;
            }

            public GNHashtable Build()
            {
                var awnser = new GNHashtable();

                var keys = originObject.Keys;
                foreach (var key in keys)
                {
                    awnser.Add(key, originObject[key]);
                }

                return awnser;
            }

            public Builder()
            {
                this.originObject = new Dictionary<string, object>();
            }
        }

        private IDictionary<string, object> originObject;

        public GNHashtable()
        {
            this.originObject = new Dictionary<string, object>();
        }

        public void Add(string key, object value)
        {
            this.originObject[key] = CreateUseDataFromOriginData(value);
        }

        public ICollection<object> Values()
        {
            return this.originObject.Values;
        }

        public ICollection<string> Keys()
        {
            return this.originObject.Keys;
        }

        public bool ContainsKey(string key)
        {
            return this.originObject.ContainsKey(key);
        }

        public void Clear()
        {
            this.originObject.Clear();
        }

        public bool Remove(string key)
        {
            return this.originObject.Remove(key);
        }

        public int Count()
        {
            return this.originObject.Count;
        }

        protected object Get<T>(string k, T defaultValue = default(T))
        {
            if (this.originObject.ContainsKey(k))
            {
                var value = this.originObject[k];

                if (value == null) return defaultValue;

                if (value is T t)
                {
                    return t;
                }

                return value;
            }

            return defaultValue;
        }

        public byte GetByte(string k, byte defaultValue = 0)
        {
            return Convert.ToByte(this.Get(k, defaultValue));
        }

        public sbyte GetSByte(string k, sbyte defaultValue = 0)
        {
            return Convert.ToSByte(this.Get(k, defaultValue));
        }

        public short GetShort(string k, short defaultValue = 0)
        {
            return Convert.ToInt16(this.Get(k, defaultValue));
        }

        public int GetInt(string k, int defaultValue = 0)
        {
            return Convert.ToInt32(this.Get(k, defaultValue));
        }

        public float GetFloat(string k, float defaultValue = 0)
        {
            return Convert.ToSingle(this.Get(k, defaultValue));
        }

        public long GetLong(string k, long defaultValue = 0)
        {
            return Convert.ToInt64(this.Get(k, defaultValue));
        }

        public double GetDouble(string k, double defaultValue = 0)
        {
            return Convert.ToDouble(this.Get(k, defaultValue));
        }

        public bool GetBool(string k, bool defaultValue = false)
        {
            return Convert.ToBoolean(this.Get(k, defaultValue));
        }

        public string GetString(string k, string defaultValue = null)
        {
            return Convert.ToString(this.Get(k, defaultValue));
        }

        public object GetObject(string k, object defaultValue = null)
        {
            return this.Get(k, defaultValue);
        }

        public T[] GetArray<T>(string k, T[] defaultValue = null)
        {
            var value0 = this.GetGNArray(k);
            if (value0 != null)
            {
                return value0.ToArray<T>();
            }

            return defaultValue;
        }

        public IList<T> GetList<T>(string k, IList<T> defaultValue = null)
        {
            var value0 = this.GetGNArray(k);
            if (value0 != null)
            {
                return value0.ToList<T>();
            }

            return defaultValue;
        }

        public GNArray GetGNArray(string k, GNArray defaultValue = null)
        {
            return (GNArray)this.Get(k, defaultValue);
        }

        public GNHashtable GetGNHashtable(string k, GNHashtable defaultValue = null)
        {
            return (GNHashtable)this.Get(k, defaultValue);
        }

        public override object ToData()
        {
            var answer = new Dictionary<string, object>();

            foreach (var c in this.originObject)
            {
                answer.Add(c.Key, CreateGNDataFromUseData(c.Value));
            }

            return answer;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("{");

            var i = 0;
            foreach (var c in this.originObject)
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

    }

}
