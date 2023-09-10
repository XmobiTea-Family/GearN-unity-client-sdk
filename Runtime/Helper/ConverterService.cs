namespace XmobiTea.GN.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Entity;

    public class DataMemberFieldInfoTypeMapper
    {
        private Dictionary<Type, FieldInfo[]> declaredFieldsMap;

        public FieldInfo[] getGNEnhancedObjectFieldMetadata(System.Type cls)
        {
            FieldInfo[] declaredFields;

            if (this.declaredFieldsMap.ContainsKey(cls)) declaredFields = this.declaredFieldsMap[cls];
            else
            {
                var declaredFieldLst = new List<FieldInfo>();

                var currentCls = cls;

                while (true)
                {
                    var allDeclaredFields = currentCls.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly).Where(field => field.GetCustomAttribute<DataMemberAttribute>(true) != null);

                    foreach (var field in allDeclaredFields)
                    {
                        var thisDeclaredField = declaredFieldLst.Find(x => x.Name.Equals(field.Name));

                        if (thisDeclaredField == null) declaredFieldLst.Add(field);
                    }

                    if (currentCls.BaseType == typeof(object))
                    {
                        break;
                    }

                    currentCls = currentCls.BaseType;
                }

                declaredFields = declaredFieldLst.ToArray();

                this.declaredFieldsMap[cls] = declaredFields;
            }

            return declaredFields;
        }

        public DataMemberFieldInfoTypeMapper()
        {
            this.declaredFieldsMap = new Dictionary<Type, FieldInfo[]>();
        }
    }

    public class ConverterService
    {
        private static DataMemberFieldInfoTypeMapper dataMemberFieldInfoMapper = new DataMemberFieldInfoTypeMapper();

        private static Type typeOfByte => typeof(byte);
        private static Type typeOfSByte => typeof(sbyte);
        private static Type typeOfShort => typeof(short);
        private static Type typeOfInt => typeof(int);
        private static Type typeOfFloat => typeof(float);
        private static Type typeOfLong => typeof(long);
        private static Type typeOfDouble => typeof(double);
        private static Type typeOfBool => typeof(bool);
        private static Type typeOfString => typeof(string);
        private static Type typeOfGNArray => typeof(GNArray);
        private static Type typeOfGNHashtable => typeof(GNHashtable);

        public static T deserializeObject<T>(GNHashtable gnHashtable)
        {
            return (T)ConverterService.deserializeObject(gnHashtable, typeof(T));
        }

        public static object deserializeObject(GNHashtable gnHashtable, Type type)
        {
            if (gnHashtable == null) return null;

            var fieldInfos = ConverterService.dataMemberFieldInfoMapper.getGNEnhancedObjectFieldMetadata(type);

            var answer = Activator.CreateInstance(type);

            foreach (var field in fieldInfos)
            {
                var dataMemberAnno = field.GetCustomAttribute<DataMemberAttribute>(true);

                var value = gnHashtable.getObject(dataMemberAnno.code);

                if (dataMemberAnno is StringDataMemberAttribute stringDataMemberAnno)
                {
                    if (value == null) field.SetValue(answer, stringDataMemberAnno.defaultValue);
                    else if (value is string) field.SetValue(answer, value);
                }
                else if (dataMemberAnno is BooleanDataMemberAttribute booleanDataMemberAnno)
                {
                    if (value == null) field.SetValue(answer, booleanDataMemberAnno.defaultValue);
                    else if (value is bool) field.SetValue(answer, value);
                }
                else if (dataMemberAnno is GNHashtableDataMemberAttribute gnHashtableDataMemberAnno)
                {
                    if (value == null)
                    {
                        if (gnHashtableDataMemberAnno.defaultValue != null)
                        {
                            if (field.FieldType == typeOfGNHashtable) field.SetValue(answer, gnHashtableDataMemberAnno.defaultValue);
                            else if (field.FieldType == typeof(System.Collections.IDictionary)) field.SetValue(answer, gnHashtableDataMemberAnno.defaultValue.toData());
                            else field.SetValue(answer, ConverterService.deserializeObject(gnHashtableDataMemberAnno.defaultValue, field.FieldType));
                        }
                    }
                    else
                    {
                        if (field.FieldType == typeOfGNHashtable) field.SetValue(answer, value);
                        else if (field.FieldType == typeof(System.Collections.IDictionary)) field.SetValue(answer, ((IGNData)value).toData());
                        else field.SetValue(answer, ConverterService.deserializeObject((GNHashtable)value, field.FieldType));
                    }
                }
                else if (dataMemberAnno is GNArrayDataMemberAttribute gnArrayDataMemberAnno)
                {
                    if (value == null)
                    {
                        if (gnArrayDataMemberAnno.defaultValue != null)
                        {
                            if (field.FieldType == typeOfGNArray) field.SetValue(answer, gnArrayDataMemberAnno.defaultValue);
                            else if (field.FieldType == typeof(System.Collections.IList)) field.SetValue(answer, gnArrayDataMemberAnno.defaultValue.toData());
                        }
                    }
                    else
                    {
                        if (field.FieldType == typeOfGNArray) field.SetValue(answer, value);
                        else if (field.FieldType == typeof(System.Collections.IList)) field.SetValue(answer, ((IGNData)value).toData());
                    }
                }
                else if (dataMemberAnno is NumberDataMemberAttribute numberDataMemberAnno)
                {
                    if (value == null) field.SetValue(answer, numberDataMemberAnno.defaultValue);
                    else if (ConverterService.isNumber(value)) field.SetValue(answer, value);

                    //var typeOfField = field.FieldType;

                    //if (typeOfField == typeOfByte) field.SetValue(answer, gnHashtable.getByte(dataMemberAnno.code, Convert.ToByte(numberDataMemberAnno.defaultValue)));
                    //else if (typeOfField == typeOfSByte) field.SetValue(answer, gnHashtable.getSByte(dataMemberAnno.code, Convert.ToSByte(numberDataMemberAnno.defaultValue)));
                    //else if (typeOfField == typeOfShort) field.SetValue(answer, gnHashtable.getShort(dataMemberAnno.code, Convert.ToInt16(numberDataMemberAnno.defaultValue)));
                    //else if (typeOfField == typeOfInt) field.SetValue(answer, gnHashtable.getInt(dataMemberAnno.code, Convert.ToInt32(numberDataMemberAnno.defaultValue)));
                    //else if (typeOfField == typeOfFloat) field.SetValue(answer, gnHashtable.getFloat(dataMemberAnno.code, Convert.ToSingle(numberDataMemberAnno.defaultValue)));
                    //else if (typeOfField == typeOfLong) field.SetValue(answer, gnHashtable.getLong(dataMemberAnno.code, Convert.ToInt64(numberDataMemberAnno.defaultValue)));
                    //else if (typeOfField == typeOfDouble) field.SetValue(answer, gnHashtable.getDouble(dataMemberAnno.code, Convert.ToDouble(numberDataMemberAnno.defaultValue)));
                    //else field.SetValue(answer, numberDataMemberAnno.defaultValue);

                    //field.SetValue(answer, gnHashtable.getDouble(dataMemberAnno.code, numberDataMemberAnno.defaultValue));
                }
                else
                {
                    if (value == null)
                    {
                        if (dataMemberAnno.defaultValue != null)
                        {
                            if (field.FieldType == typeOfByte) field.SetValue(answer, dataMemberAnno.defaultValue);
                            else if (field.FieldType == typeOfSByte) field.SetValue(answer, dataMemberAnno.defaultValue);
                            else if (field.FieldType == typeOfShort) field.SetValue(answer, dataMemberAnno.defaultValue);
                            else if (field.FieldType == typeOfInt) field.SetValue(answer, dataMemberAnno.defaultValue);
                            else if (field.FieldType == typeOfFloat) field.SetValue(answer, dataMemberAnno.defaultValue);
                            else if (field.FieldType == typeOfLong) field.SetValue(answer, dataMemberAnno.defaultValue);
                            else if (field.FieldType == typeOfDouble) field.SetValue(answer, dataMemberAnno.defaultValue);
                            else if (field.FieldType == typeOfBool) field.SetValue(answer, dataMemberAnno.defaultValue);
                            else if (field.FieldType == typeOfString) field.SetValue(answer, dataMemberAnno.defaultValue);
                            else if (field.FieldType == typeOfGNArray) field.SetValue(answer, dataMemberAnno.defaultValue);
                            else if (field.FieldType == typeof(System.Collections.IList)) field.SetValue(answer, ((IGNData)dataMemberAnno.defaultValue).toData());
                            else if (field.FieldType == typeOfGNHashtable) field.SetValue(answer, dataMemberAnno.defaultValue);
                            else if (field.FieldType == typeof(System.Collections.IDictionary)) field.SetValue(answer, ((IGNData)dataMemberAnno.defaultValue).toData());
                            else field.SetValue(answer, ConverterService.deserializeObject((GNHashtable)dataMemberAnno.defaultValue, field.FieldType));
                        }
                    }
                    else
                    {
                        if (field.FieldType == typeOfByte) field.SetValue(answer, value);
                        else if (field.FieldType == typeOfSByte) field.SetValue(answer, value);
                        else if (field.FieldType == typeOfShort) field.SetValue(answer, value);
                        else if (field.FieldType == typeOfInt) field.SetValue(answer, value);
                        else if (field.FieldType == typeOfFloat) field.SetValue(answer, value);
                        else if (field.FieldType == typeOfLong) field.SetValue(answer, value);
                        else if (field.FieldType == typeOfDouble) field.SetValue(answer, value);
                        else if (field.FieldType == typeOfBool) field.SetValue(answer, value);
                        else if (field.FieldType == typeOfString) field.SetValue(answer, value);
                        else if (field.FieldType == typeOfGNArray) field.SetValue(answer, value);
                        else if (field.FieldType == typeof(System.Collections.IList)) field.SetValue(answer, ((IGNData)value).toData());
                        else if (field.FieldType == typeOfGNHashtable) field.SetValue(answer, value);
                        else if (field.FieldType == typeof(System.Collections.IDictionary)) field.SetValue(answer, ((IGNData)value).toData());
                        else field.SetValue(answer, ConverterService.deserializeObject((GNHashtable)value, field.FieldType));
                    }
                }
            }

            return answer;
        }

        public static System.Collections.IList deserializeArray<T>(GNArray gnArray)
        {
            var cls = typeof(T);

            var array = ConverterService.deserializeArray(gnArray, cls);

            if (array == null) return null;

            var answer = new List<T>();

            for (var i = 0; i < array.Count; i++)
            {
                answer.Add((T)array[i]);
            }

            return answer;
        }

        public static System.Collections.IList deserializeArray(GNArray gnArray, Type cls)
        {
            if (gnArray == null) return null;

            var answer = new System.Collections.Generic.List<object>();

            for (var i = 0; i < gnArray.count(); i++)
            {
                var value = gnArray.getObject(i);
                if (value == null) answer.Add(null);
                else
                {
                    var typeOfValue = value.GetType();

                    if (cls == typeOfByte) answer.Add(value);
                    else if (cls == typeOfSByte) answer.Add(value);
                    else if (cls == typeOfShort) answer.Add(value);
                    else if (cls == typeOfInt) answer.Add(value);
                    else if (cls == typeOfFloat) answer.Add(value);
                    else if (cls == typeOfLong) answer.Add(value);
                    else if (cls == typeOfDouble) answer.Add(value);
                    else if (cls == typeOfBool) answer.Add(value);
                    else if (cls == typeOfString) answer.Add(value);
                    else if (cls == typeOfGNArray) answer.Add(value);
                    else if (cls == typeOfGNHashtable) answer.Add(value);
                    else if (typeOfValue == typeof(System.Collections.IList))
                        answer.Add(ConverterService.deserializeArray(gnArray.getGNArray(i), cls));
                    else
                        answer.Add(ConverterService.deserializeObject(gnArray.getGNHashtable(i), cls));
                }
            }

            return answer;
        }

        public static GNHashtable serializeObject(object obj)
        {
            if (obj == null) return null;

            var type = obj.GetType();

            var fieldInfos = dataMemberFieldInfoMapper.getGNEnhancedObjectFieldMetadata(type);

            var answer = new GNHashtable();

            foreach (var field in fieldInfos)
            {
                var dataMemberAnno = field.GetCustomAttribute<DataMemberAttribute>(true);

                var value = field.GetValue(obj);

                if (value == null)
                {
                    if (!dataMemberAnno.isOptional) answer.add(dataMemberAnno.code, null);
                }
                else
                {
                    if (dataMemberAnno is StringDataMemberAttribute stringDataMemberAnno)
                    {
                        if (value is string) answer.add(dataMemberAnno.code, value);
                    }
                    else if (dataMemberAnno is BooleanDataMemberAttribute booleanDataMemberAnno)
                    {
                        if (value is bool) answer.add(dataMemberAnno.code, value);
                    }
                    else if (dataMemberAnno is GNHashtableDataMemberAttribute gnHashtableDataMemberAnno)
                    {
                        if (value is GNHashtable) answer.add(dataMemberAnno.code, value);
                        else if (value is System.Collections.IDictionary valueDict) answer.add(dataMemberAnno.code, new GNHashtable.Builder().addAll(valueDict).build());
                        else answer.add(dataMemberAnno.code, ConverterService.serializeObject(value));
                    }
                    else if (dataMemberAnno is GNArrayDataMemberAttribute gnArrayDataMemberAnno)
                    {
                        if (value is GNArray) answer.add(dataMemberAnno.code, value);
                        else if (value is System.Collections.IList valueLst) answer.add(dataMemberAnno.code, ConverterService.serializeArray(valueLst));
                    }
                    else if (dataMemberAnno is NumberDataMemberAttribute numberDataMemberAnno)
                    {
                        if (ConverterService.isNumber(value)) answer.add(dataMemberAnno.code, value);
                    }
                    else
                    {
                        if (value is string) answer.add(dataMemberAnno.code, value);
                        else if (value is bool) answer.add(dataMemberAnno.code, value);
                        else if (ConverterService.isNumber(value)) answer.add(dataMemberAnno.code, value);
                        else if (value is IGNData) answer.add(dataMemberAnno.code, value);
                        else if (value is System.Collections.IList valueLst) answer.add(dataMemberAnno.code, ConverterService.serializeArray(valueLst));
                        else if (value is System.Collections.IDictionary valueDict) answer.add(dataMemberAnno.code, new GNHashtable.Builder().addAll(valueDict).build());
                        else answer.add(dataMemberAnno.code, ConverterService.serializeObject(value));
                    }
                }
            }

            return answer;
        }

        public static GNArray serializeArray(System.Collections.IList objLst)
        {
            if (objLst == null) return null;

            var answer = new GNArray();

            for (var i = 0; i < objLst.Count; i++)
            {
                var obj = objLst[i];

                if (obj == null) answer.add(null);
                else if (obj is string) answer.add(obj);
                else if (obj is bool) answer.add(obj);
                else if (ConverterService.isNumber(obj)) answer.add(obj);
                else if (obj is IGNData) answer.add(obj);
                else if (obj is System.Collections.IList) answer.add(ConverterService.serializeArray((System.Collections.IList)obj));
                else answer.add(ConverterService.serializeObject(obj));
            }

            return answer;
        }

        private static bool isNumber(object value)
        {
            return (value is byte
                || value is sbyte
                || value is short
                || value is int
                || value is float
                || value is long
                || value is double);
        }

        private static bool isInteger(object value)
        {
            return (value is byte
                || value is sbyte
                || value is short
                || value is int
                || value is long);
        }
    }

}
