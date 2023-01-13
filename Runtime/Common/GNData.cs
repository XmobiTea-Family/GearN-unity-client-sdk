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

        public virtual object ToData() { return null; }
    }
}
