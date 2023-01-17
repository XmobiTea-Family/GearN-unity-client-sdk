namespace XmobiTea.GN.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using XmobiTea.GN.Common;

    [AttributeUsage(AttributeTargets.Field, Inherited = true)]
    public class GNDataMemberAttribute : Attribute
    {
        public string ParameterCode { get; set; }
        public object DefaultValue { get; set; }

        public GNDataMemberAttribute(string parameterCode, object defaultValue = null)
        {
            this.ParameterCode = parameterCode;
            this.DefaultValue = defaultValue;
        }
    }

    public interface IGNObject { }

    public class ConverterService
    {
        private static Dictionary<Type, FieldInfo[]> declaredFieldsMap = new Dictionary<Type, FieldInfo[]>();

        //private static Type typeOfByte => typeof(byte);
        //private static Type typeOfSByte => typeof(sbyte);
        //private static Type typeOfShort => typeof(short);
        //private static Type typeOfInt => typeof(int);
        //private static Type typeOfFloat => typeof(float);
        //private static Type typeOfLong => typeof(long);
        //private static Type typeOfDouble => typeof(double);
        //private static Type typeOfBool => typeof(bool);
        //private static Type typeOfString => typeof(string);
        //private static Type typeOfGNArray => typeof(GNArray);
        //private static Type typeOfGNHashtable => typeof(GNHashtable);

        public static T ConvertObject<T>(GNHashtable hashtable) where T : class, IGNObject
        {
            if (hashtable == null) return null;

            var type = typeof(T);

            FieldInfo[] fieldInfos = null;

            if (declaredFieldsMap.ContainsKey(type)) fieldInfos = declaredFieldsMap[type];
            else
            {
                fieldInfos = type.GetFields(BindingFlags.NonPublic | BindingFlags.Public).Where(field => field.GetCustomAttribute<GNDataMemberAttribute>(true) != null).ToArray();

                declaredFieldsMap[type] = fieldInfos;
            }

            var answer = Activator.CreateInstance(type);

            foreach (var field in fieldInfos)
            {
                var dataMemberAnno = field.GetCustomAttribute<GNDataMemberAttribute>(true);

                var value = hashtable.GetObject(dataMemberAnno.ParameterCode, dataMemberAnno.DefaultValue);

                field.SetValue(answer, value);
            }

            return (T)answer;
        }
    }
}
