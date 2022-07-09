namespace XmobiTea.GN.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GNArray : GNData
    {
        public class Builder
        {
            private List<object> originArray;

            public Builder Add(object value)
            {
                originArray.Add(value);

                return this;
            }

            public Builder AddAll(System.Collections.IList list)
            {
                foreach (var o in list)
                {
                    Add(o);
                }

                return this;
            }

            public GNArray Build()
            {
                var awnser = new GNArray();

                foreach (var o in originArray)
                {
                    awnser.Add(o);
                }

                return awnser;
            }

            public Builder()
            {
                originArray = new List<object>();
            }
        }

        private List<object> originArray;

        public GNArray()
        {
            this.originArray = new List<object>();
        }

        public void Add(object value)
        {
            originArray.Add(CreateUseDataFromOriginData(value));
        }

        public ICollection<object> Values()
        {
            return originArray;
        }

        public void Clear()
        {
            originArray.Clear();
        }

        public bool Remove(int index)
        {
            originArray.RemoveAt(index);

            return true;
        }

        public int Count()
        {
            return originArray.Count;
        }

        protected object Get<T>(int k, T defaultValue = default(T))
        {
            if (k < 0 || k > originArray.Count - 1) return defaultValue;

            var value = originArray[k];
            
            if (value == null) return defaultValue;

            if (value is T t)
            {
                return t;
            }

            return value;
        }

        public T[] ToArray<T>()
        {
            var answer = new T[originArray.Count];

            for (var i = 0; i < originArray.Count; i++)
            {
                answer[i] = (T)Get<T>(i);
            }

            return answer;
        }

        public IList<T> ToList<T>()
        {
            var answer = new List<T>();

            for (var i = 0; i < originArray.Count; i++)
            {
                answer.Add((T)Get<T>(i));
            }

            return answer;
        }

        public byte GetByte(int k, byte defaultValue = 0)
        {
            return Convert.ToByte(Get(k, defaultValue));
        }

        public sbyte GetSByte(int k, sbyte defaultValue = 0)
        {
            return Convert.ToSByte(Get(k, defaultValue));
        }

        public short GetShort(int k, short defaultValue = 0)
        {
            return Convert.ToInt16(Get(k, defaultValue));
        }

        public int GetInt(int k, int defaultValue = 0)
        {
            return Convert.ToInt32(Get(k, defaultValue));
        }

        public float GetFloat(int k, float defaultValue = 0)
        {
            return Convert.ToSingle(Get(k, defaultValue));
        }

        public long GetLong(int k, long defaultValue = 0)
        {
            return Convert.ToInt64(Get(k, defaultValue));
        }

        public double GetDouble(int k, double defaultValue = 0)
        {
            return Convert.ToDouble(Get(k, defaultValue));
        }

        public bool GetBool(int k, bool defaultValue = false)
        {
            return Convert.ToBoolean(Get(k, defaultValue));
        }

        public string GetString(int k, string defaultValue = null)
        {
            return Convert.ToString(Get(k, defaultValue));
        }

        public object GetObject(int k, object defaultValue = null)
        {
            return Get(k, defaultValue);
        }

        public T[] GetArray<T>(int k, T[] defaultValue = null)
        {
            var value0 = GetGNArray(k);
            if (value0 != null)
            {
                return value0.ToArray<T>();
            }

            return defaultValue;
        }

        public IList<T> GetList<T>(int k, IList<T> defaultValue = null)
        {
            var value0 = GetGNArray(k);
            if (value0 != null)
            {
                return value0.ToList<T>();
            }

            return defaultValue;
        }

        public GNArray GetGNArray(int k, GNArray defaultValue = null)
        {
            return (GNArray)Get(k, defaultValue);
        }

        public GNHashtable GetGNHashtable(int k, GNHashtable defaultValue = null)
        {
            return (GNHashtable)Get(k, defaultValue);
        }

        public override object ToData()
        {
            var answer = new List<object>();

            foreach (var c in originArray)
            {
                answer.Add(CreateGNDataFromUseData(c));
            }

            return answer;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("[");

            for (var i = 0; i < originArray.Count; i++)
            {
                if (i != 0) stringBuilder.Append(",");

                var value = originArray[i];

                if (value == null) stringBuilder.Append("null");
                else if (value is GNData gnData) stringBuilder.Append(gnData.ToString());
                else if (value is string valueStr) stringBuilder.Append("\"" + valueStr + "\"");
                else if (value is bool boolValue) stringBuilder.Append(boolValue.ToString().ToLower());
                else stringBuilder.Append(value);
            }

            stringBuilder.Append("]");
            return stringBuilder.ToString();
        }
    }
}
