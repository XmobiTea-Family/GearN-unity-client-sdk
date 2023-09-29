namespace XmobiTea.GN.Common
{

    /// <summary>
    /// The base class for GNData
    /// </summary>
    public abstract class GNData : IGNData
    {
        protected static object createUseDataFromOriginData(object value)
        {
            if (value == null) return null;

            if (value is System.Collections.IList list)
            {
                var answer = new GNArray.Builder().addAll(list).build();

                return answer;
            }

            if (value is System.Collections.IDictionary dict)
            {
                var answer = new GNHashtable.Builder().addAll(dict).build();

                return answer;
            }

            return value;
        }

        protected static object createDataFromUseData(object value)
        {
            if (value == null) return null;

            if (value is IGNData gnData)
            {
                return gnData.toData();
            }

            return value;
        }

        public abstract object toData();

        public abstract string toString();

    }

}
