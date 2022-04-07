namespace XmobiTea.GN.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GNHashtable : GNData
    {
        public class Builder
        {
            private IDictionary<int, object> originObject;

            public Builder Add(int key, object value)
            {
                originObject[key] = value;

                return this;
            }

            public Builder AddAll(System.Collections.IDictionary dict)
            {
                var keys = dict.Keys;
                foreach (var key in keys)
                {
                    if (key is string keyStr)
                    {
                        int keyInt;
                        if (int.TryParse(keyStr, out keyInt))
                        {
                            Add(keyInt, dict[key]);
                        }
                    }
                    else if (key is int keyInt)
                    {
                        Add(keyInt, dict[key]);
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
                originObject = new Dictionary<int, object>();
            }
        }

        private IDictionary<int, object> originObject;

        public GNHashtable()
        {
            this.originObject = new Dictionary<int, object>();
        }

        public void Add(int key, object value)
        {
            originObject[key] = CreateUseDataFromOriginData(value);
        }

        public ICollection<object> Values()
        {
            return originObject.Values;
        }

        public ICollection<int> Keys()
        {
            return originObject.Keys;
        }

        public bool ContainsKey(int key)
        {
            return originObject.ContainsKey(key);
        }

        public override void Clear()
        {
            originObject.Clear();
        }

        public override bool Remove(int key)
        {
            return originObject.Remove(key);
        }

        public override int Count()
        {
            return originObject.Count;
        }

        protected override object Get<T>(int k, T defaultValue = default(T))
        {
            if (originObject.ContainsKey(k))
            {
                var value = originObject[k];

                if (value == null) return defaultValue;

                if (value is T t)
                {
                    return t;
                }

                return value;
            }

            return defaultValue;
        }

        public override object ToData()
        {
            var answer = new Dictionary<int, object>();

            foreach (var c in originObject)
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
            foreach (var c in originObject)
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