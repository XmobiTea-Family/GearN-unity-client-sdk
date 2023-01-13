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
            this.originArray.Add(CreateUseDataFromOriginData(value));
        }

        public ICollection<object> Values()
        {
            return this.originArray;
        }

        public void Clear()
        {
            this.originArray.Clear();
        }

        public bool Remove(int index)
        {
            this.originArray.RemoveAt(index);

            return true;
        }

        public int Count()
        {
            return this.originArray.Count;
        }

        protected object Get<T>(int k, T defaultValue = default(T))
        {
            if (k < 0 || k > this.originArray.Count - 1) return defaultValue;

            var value = this.originArray[k];

            if (value == null) return defaultValue;

            if (value is T t)
            {
                return t;
            }

            return value;
        }

        public T[] ToArray<T>()
        {
            var answer = new T[this.originArray.Count];

            for (var i = 0; i < this.originArray.Count; i++)
            {
                answer[i] = (T)this.CustomGet(i);
            }

            return answer;
        }

        public IList<T> ToList<T>()
        {
            var answer = new List<T>();

            for (var i = 0; i < this.originArray.Count; i++)
            {
                answer.Add((T)this.CustomGet(i));
            }

            return answer;
        }

        private object CustomGet(int k)
        {
            var obj = this.Get<object>(k);
            if (obj == null) return null;

            var objType = obj.GetType();
            if (objType == typeof(byte)) return this.GetByte(k);
            else if (objType == typeof(sbyte)) return this.GetSByte(k);
            else if (objType == typeof(short)) return this.GetShort(k);
            else if (objType == typeof(int)) return this.GetInt(k);
            else if (objType == typeof(float)) return this.GetFloat(k);
            else if (objType == typeof(long)) return this.GetLong(k);
            else if (objType == typeof(double)) return this.GetDouble(k);
            else if (objType == typeof(bool)) return this.GetBool(k);
            else if (objType == typeof(string)) return this.GetString(k);
            else if (objType == typeof(GNArray) || objType == typeof(System.Collections.IList)) return this.GetGNArray(k);
            else if (objType == typeof(GNHashtable) || objType == typeof(System.Collections.IDictionary)) return this.GetGNHashtable(k);

            return obj;
        }

        public byte GetByte(int k, byte defaultValue = 0)
        {
            return Convert.ToByte(this.Get(k, defaultValue));
        }

        public sbyte GetSByte(int k, sbyte defaultValue = 0)
        {
            return Convert.ToSByte(this.Get(k, defaultValue));
        }

        public short GetShort(int k, short defaultValue = 0)
        {
            return Convert.ToInt16(this.Get(k, defaultValue));
        }

        public int GetInt(int k, int defaultValue = 0)
        {
            return Convert.ToInt32(this.Get(k, defaultValue));
        }

        public float GetFloat(int k, float defaultValue = 0)
        {
            return Convert.ToSingle(this.Get(k, defaultValue));
        }

        public long GetLong(int k, long defaultValue = 0)
        {
            return Convert.ToInt64(this.Get(k, defaultValue));
        }

        public double GetDouble(int k, double defaultValue = 0)
        {
            return Convert.ToDouble(this.Get(k, defaultValue));
        }

        public bool GetBool(int k, bool defaultValue = false)
        {
            return Convert.ToBoolean(this.Get(k, defaultValue));
        }

        public string GetString(int k, string defaultValue = null)
        {
            return Convert.ToString(this.Get(k, defaultValue));
        }

        public object GetObject(int k, object defaultValue = null)
        {
            return this.Get(k, defaultValue);
        }

        public T[] GetArray<T>(int k, T[] defaultValue = null)
        {
            var value0 = this.GetGNArray(k);
            if (value0 != null)
            {
                return value0.ToArray<T>();
            }

            return defaultValue;
        }

        public IList<T> GetList<T>(int k, IList<T> defaultValue = null)
        {
            var value0 = this.GetGNArray(k);
            if (value0 != null)
            {
                return value0.ToList<T>();
            }

            return defaultValue;
        }

        public GNArray GetGNArray(int k, GNArray defaultValue = null)
        {
            return (GNArray)this.Get(k, defaultValue);
        }

        public GNHashtable GetGNHashtable(int k, GNHashtable defaultValue = null)
        {
            return (GNHashtable)this.Get(k, defaultValue);
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
