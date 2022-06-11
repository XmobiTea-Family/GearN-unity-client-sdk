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

        public override void Clear()
        {
            originArray.Clear();
        }

        public override bool Remove(int index)
        {
            originArray.RemoveAt(index);

            return true;
        }

        public override int Count()
        {
            return originArray.Count;
        }

        protected override object Get<T>(int k, T defaultValue = default(T))
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
