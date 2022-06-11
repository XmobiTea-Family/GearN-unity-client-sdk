namespace XmobiTea.GN.Common
{
    using System;
    using System.Collections.Generic;

    public class GNData : IGNData
    {
        protected static object CreateUseDataFromOriginData(object value)
        {
            if (value == null) return null;

            if (value is System.Collections.IList list)
            {
                var answer = new GNArray();

                for (var i = 0; i < list.Count; i++)
                {
                    answer.Add(list[i]);
                }

                return answer;
            }

            if (value is System.Collections.IDictionary dict)
            {
                var answer = new GNHashtable.Builder().AddAll(dict).Build();

                return answer;
            }

            return value;
        }

        protected static object CreateGNDataFromUseData(object value)
        {
            if (value == null) return null;

            if (value is IGNData gnData)
            {
                return gnData.ToData();
            }

            return value;
        }

        public virtual void Clear() { }

        public virtual bool Remove(int k) { return false; }

        public virtual int Count() { return 0; }

        protected virtual object Get<T>(int k, T defaultValue = default(T))
        {
            return defaultValue;
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

        public virtual object ToData() { return null; }
    }
}
