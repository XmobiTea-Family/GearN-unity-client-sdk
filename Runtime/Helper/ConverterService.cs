namespace XmobiTea.GN.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Entity;

    internal class DataMemberFieldInfoTypeMapper
    {
        private Dictionary<Type, GNEnhancedObjectFieldMetadata[]> declaredFieldsMap;

        public GNEnhancedObjectFieldMetadata[] getGNEnhancedObjectFieldMetadata(System.Type cls)
        {
            GNEnhancedObjectFieldMetadata[] declaredFields;

            if (this.declaredFieldsMap.ContainsKey(cls)) declaredFields = this.declaredFieldsMap[cls];
            else
            {
                var fieldInfoLst = new List<FieldInfo>();

                var currentCls = cls;

                while (true)
                {
                    var allDeclaredFields = currentCls.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly).Where(field => field.GetCustomAttribute<DataMemberAttribute>(true) != null);

                    foreach (var field in allDeclaredFields)
                    {
                        var thisDeclaredField = fieldInfoLst.Find(x => x.Name.Equals(field.Name));

                        if (thisDeclaredField == null) fieldInfoLst.Add(field);
                    }

                    if (currentCls.BaseType == typeof(object))
                    {
                        break;
                    }

                    currentCls = currentCls.BaseType;
                }

                declaredFields = new GNEnhancedObjectFieldMetadata[fieldInfoLst.Count];

                for (var i = 0; i < fieldInfoLst.Count; i++)
                {
                    GNEnhancedObjectFieldMetadata gnEnhancedObjectFieldMetadata;

                    var field = fieldInfoLst[i];

                    var dataMemberAnno = field.GetCustomAttribute<DataMemberAttribute>(true);

                    if (dataMemberAnno is StringDataMemberAttribute stringDataMemberAnno)
                    {
                        gnEnhancedObjectFieldMetadata = new GNEnhancedObjectFieldMetadata(field.Name, FieldDataType.String, field.FieldType, field);

                        gnEnhancedObjectFieldMetadata.defaultValue = stringDataMemberAnno.defaultValue;
                        gnEnhancedObjectFieldMetadata.mustNonNull = stringDataMemberAnno.mustNonNull;
                        gnEnhancedObjectFieldMetadata.minLength = stringDataMemberAnno.minLength;
                        gnEnhancedObjectFieldMetadata.maxLength = stringDataMemberAnno.maxLength;
                    }
                    else if (dataMemberAnno is BooleanDataMemberAttribute booleanDataMemberAnno)
                    {
                        gnEnhancedObjectFieldMetadata = new GNEnhancedObjectFieldMetadata(field.Name, FieldDataType.Boolean, field.FieldType, field);

                        gnEnhancedObjectFieldMetadata.defaultValue = booleanDataMemberAnno.defaultValue;
                    }
                    else if (dataMemberAnno is GNHashtableDataMemberAttribute gnHashtableDataMemberAnno)
                    {
                        gnEnhancedObjectFieldMetadata = new GNEnhancedObjectFieldMetadata(field.Name, FieldDataType.Object, field.FieldType, field);

                        gnEnhancedObjectFieldMetadata.defaultValue = gnHashtableDataMemberAnno.defaultValue;
                        gnEnhancedObjectFieldMetadata.mustNonNull = gnHashtableDataMemberAnno.mustNonNull;
                        gnEnhancedObjectFieldMetadata.minLength = gnHashtableDataMemberAnno.minLength;
                        gnEnhancedObjectFieldMetadata.maxLength = gnHashtableDataMemberAnno.maxLength;
                    }
                    else if (dataMemberAnno is GNArrayDataMemberAttribute gnArrayDataMemberAnno)
                    {
                        gnEnhancedObjectFieldMetadata = new GNEnhancedObjectFieldMetadata(field.Name, FieldDataType.Array, gnArrayDataMemberAnno.elementCls == null ? field.FieldType : gnArrayDataMemberAnno.elementCls, field);

                        gnEnhancedObjectFieldMetadata.defaultValue = gnArrayDataMemberAnno.defaultValue;
                        gnEnhancedObjectFieldMetadata.mustNonNull = gnArrayDataMemberAnno.mustNonNull;
                        gnEnhancedObjectFieldMetadata.minLength = gnArrayDataMemberAnno.minLength;
                        gnEnhancedObjectFieldMetadata.maxLength = gnArrayDataMemberAnno.maxLength;
                    }
                    else if (dataMemberAnno is NumberDataMemberAttribute numberDataMemberAnno)
                    {
                        gnEnhancedObjectFieldMetadata = new GNEnhancedObjectFieldMetadata(field.Name, FieldDataType.Number, field.FieldType, field);

                        gnEnhancedObjectFieldMetadata.defaultValue = numberDataMemberAnno.defaultValue;
                        gnEnhancedObjectFieldMetadata.minValue = numberDataMemberAnno.minValue;
                        gnEnhancedObjectFieldMetadata.maxValue = numberDataMemberAnno.maxValue;
                        gnEnhancedObjectFieldMetadata.mustInt = numberDataMemberAnno.mustInt;
                    }
                    else
                    {
                        gnEnhancedObjectFieldMetadata = new GNEnhancedObjectFieldMetadata(field.Name, FieldDataType.Object, field.FieldType, field);

                        gnEnhancedObjectFieldMetadata.defaultValue = dataMemberAnno.defaultValue;
                    }

                    gnEnhancedObjectFieldMetadata.code = dataMemberAnno.code;
                    gnEnhancedObjectFieldMetadata.isOptional = dataMemberAnno.isOptional;
                    gnEnhancedObjectFieldMetadata.gnFieldType = dataMemberAnno.gnFieldType;

                    declaredFields[i] = gnEnhancedObjectFieldMetadata;
                }

                this.declaredFieldsMap[cls] = declaredFields;
            }

            return declaredFields;
        }

        public DataMemberFieldInfoTypeMapper()
        {
            this.declaredFieldsMap = new Dictionary<Type, GNEnhancedObjectFieldMetadata[]>();
        }
    }

    internal class DeserializeConverter
    {
        private DataMemberFieldInfoTypeMapper dataMemberFieldInfoMapper;

        private Type typeOfByte;
        private Type typeOfSByte;
        private Type typeOfShort;
        private Type typeOfInt;
        private Type typeOfFloat;
        private Type typeOfLong;
        private Type typeOfDouble;
        private Type typeOfBool;
        private Type typeOfString;
        private Type typeOfGNArray;
        private Type typeOfGNHashtable;

        public object deserializeObject(GNHashtable gnHashtable, Type cls)
        {
            if (gnHashtable == null) return null;

            var declaredFields = this.dataMemberFieldInfoMapper.getGNEnhancedObjectFieldMetadata(cls);

            var answer = Activator.CreateInstance(cls);

            foreach (var declaredField in declaredFields)
            {
                var value = gnHashtable.getObject(declaredField.code);

                if (declaredField.gnFieldType == GNFieldDataType.String)
                {
                    if (value == null) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                    else if (value is string) declaredField.fieldInfo.SetValue(answer, value);
                }
                else if (declaredField.gnFieldType == GNFieldDataType.Boolean)
                {
                    if (value == null) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                    else if (value is bool) declaredField.fieldInfo.SetValue(answer, value);
                }
                else if (declaredField.gnFieldType == GNFieldDataType.GNHashtable)
                {
                    if (value == null)
                    {
                        if (declaredField.defaultValue != null)
                        {
                            if (declaredField.fieldInfo.FieldType == typeOfGNHashtable) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                            else if (declaredField.fieldInfo.FieldType == typeof(System.Collections.IDictionary)) declaredField.fieldInfo.SetValue(answer, ((GNHashtable)(declaredField.defaultValue)).toData());
                            else declaredField.fieldInfo.SetValue(answer, this.deserializeObject((GNHashtable)declaredField.defaultValue, declaredField.cls));
                        }
                    }
                    else
                    {
                        if (declaredField.fieldInfo.FieldType == typeOfGNHashtable) declaredField.fieldInfo.SetValue(answer, value);
                        else if (declaredField.fieldInfo.FieldType == typeof(System.Collections.IDictionary)) declaredField.fieldInfo.SetValue(answer, ((IGNData)value).toData());
                        else declaredField.fieldInfo.SetValue(answer, this.deserializeObject((GNHashtable)value, declaredField.cls));
                    }
                }
                else if (declaredField.gnFieldType == GNFieldDataType.GNArray)
                {
                    if (value == null)
                    {
                        if (declaredField.defaultValue != null)
                        {
                            if (declaredField.fieldInfo.FieldType == typeOfGNArray) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                            else if (declaredField.fieldInfo.FieldType == typeof(System.Collections.IList)) declaredField.fieldInfo.SetValue(answer, ((GNArray)declaredField.defaultValue).toData());
                        }
                    }
                    else
                    {
                        if (declaredField.fieldInfo.FieldType == typeOfGNArray) declaredField.fieldInfo.SetValue(answer, value);
                        else if (declaredField.fieldInfo.FieldType == typeof(System.Collections.IList)) declaredField.fieldInfo.SetValue(answer, ((IGNData)value).toData());
                    }
                }
                else if (declaredField.gnFieldType == GNFieldDataType.Number)
                {
                    if (value == null) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                    else if (ConverterService.isNumber(value)) declaredField.fieldInfo.SetValue(answer, value);
                }
                else
                {
                    if (value == null)
                    {
                        if (declaredField.defaultValue != null)
                        {
                            if (declaredField.fieldInfo.FieldType == typeOfByte) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                            else if (declaredField.fieldInfo.FieldType == typeOfSByte) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                            else if (declaredField.fieldInfo.FieldType == typeOfShort) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                            else if (declaredField.fieldInfo.FieldType == typeOfInt) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                            else if (declaredField.fieldInfo.FieldType == typeOfFloat) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                            else if (declaredField.fieldInfo.FieldType == typeOfLong) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                            else if (declaredField.fieldInfo.FieldType == typeOfDouble) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                            else if (declaredField.fieldInfo.FieldType == typeOfBool) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                            else if (declaredField.fieldInfo.FieldType == typeOfString) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                            else if (declaredField.fieldInfo.FieldType == typeOfGNArray) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                            else if (declaredField.fieldInfo.FieldType == typeof(System.Collections.IList)) declaredField.fieldInfo.SetValue(answer, ((IGNData)declaredField.defaultValue).toData());
                            else if (declaredField.fieldInfo.FieldType == typeOfGNHashtable) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                            else if (declaredField.fieldInfo.FieldType == typeof(System.Collections.IDictionary)) declaredField.fieldInfo.SetValue(answer, ((IGNData)declaredField.defaultValue).toData());
                            else declaredField.fieldInfo.SetValue(answer, this.deserializeObject((GNHashtable)declaredField.defaultValue, declaredField.cls));
                        }
                    }
                    else
                    {
                        if (declaredField.fieldInfo.FieldType == typeOfByte) declaredField.fieldInfo.SetValue(answer, value);
                        else if (declaredField.fieldInfo.FieldType == typeOfSByte) declaredField.fieldInfo.SetValue(answer, value);
                        else if (declaredField.fieldInfo.FieldType == typeOfShort) declaredField.fieldInfo.SetValue(answer, value);
                        else if (declaredField.fieldInfo.FieldType == typeOfInt) declaredField.fieldInfo.SetValue(answer, value);
                        else if (declaredField.fieldInfo.FieldType == typeOfFloat) declaredField.fieldInfo.SetValue(answer, value);
                        else if (declaredField.fieldInfo.FieldType == typeOfLong) declaredField.fieldInfo.SetValue(answer, value);
                        else if (declaredField.fieldInfo.FieldType == typeOfDouble) declaredField.fieldInfo.SetValue(answer, value);
                        else if (declaredField.fieldInfo.FieldType == typeOfBool) declaredField.fieldInfo.SetValue(answer, value);
                        else if (declaredField.fieldInfo.FieldType == typeOfString) declaredField.fieldInfo.SetValue(answer, value);
                        else if (declaredField.fieldInfo.FieldType == typeOfGNArray) declaredField.fieldInfo.SetValue(answer, value);
                        else if (declaredField.fieldInfo.FieldType == typeof(System.Collections.IList)) declaredField.fieldInfo.SetValue(answer, ((IGNData)value).toData());
                        else if (declaredField.fieldInfo.FieldType == typeOfGNHashtable) declaredField.fieldInfo.SetValue(answer, value);
                        else if (declaredField.fieldInfo.FieldType == typeof(System.Collections.IDictionary)) declaredField.fieldInfo.SetValue(answer, ((IGNData)value).toData());
                        else declaredField.fieldInfo.SetValue(answer, this.deserializeObject((GNHashtable)value, declaredField.cls));
                    }
                }
            }

            return answer;
        }

        public System.Collections.IList deserializeArray(GNArray gnArray, Type cls)
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
                        answer.Add(this.deserializeArray(gnArray.getGNArray(i), cls));
                    else
                        answer.Add(this.deserializeObject(gnArray.getGNHashtable(i), cls));
                }
            }

            return answer;
        }

        public DeserializeConverter(DataMemberFieldInfoTypeMapper dataMemberFieldInfoMapper)
        {
            this.typeOfByte = typeof(byte);
            this.typeOfSByte = typeof(sbyte);
            this.typeOfShort = typeof(short);
            this.typeOfInt = typeof(int);
            this.typeOfFloat = typeof(float);
            this.typeOfLong = typeof(long);
            this.typeOfDouble = typeof(double);
            this.typeOfBool = typeof(bool);
            this.typeOfString = typeof(string);
            this.typeOfGNArray = typeof(GNArray);
            this.typeOfGNHashtable = typeof(GNHashtable);

            this.dataMemberFieldInfoMapper = dataMemberFieldInfoMapper;
        }
    }

    internal class SerializeConverter
    {
        private DataMemberFieldInfoTypeMapper dataMemberFieldInfoMapper;

        public GNHashtable serializeObject(object obj)
        {
            if (obj == null) return null;

            var type = obj.GetType();

            var declaredFields = this.dataMemberFieldInfoMapper.getGNEnhancedObjectFieldMetadata(type);

            var answer = new GNHashtable();

            foreach (var declaredField in declaredFields)
            {
                var value = declaredField.fieldInfo.GetValue(obj);

                if (value == null)
                {
                    if (!declaredField.isOptional) answer.add(declaredField.code, null);
                }
                else
                {
                    if (declaredField.gnFieldType == GNFieldDataType.String)
                    {
                        if (value is string) answer.add(declaredField.code, value);
                    }
                    else if (declaredField.gnFieldType == GNFieldDataType.Boolean)
                    {
                        if (value is bool) answer.add(declaredField.code, value);
                    }
                    else if (declaredField.gnFieldType == GNFieldDataType.GNHashtable)
                    {
                        if (value is GNHashtable) answer.add(declaredField.code, value);
                        else if (value is System.Collections.IDictionary valueDict) answer.add(declaredField.code, new GNHashtable.Builder().addAll(valueDict).build());
                        else answer.add(declaredField.code, this.serializeObject(value));
                    }
                    else if (declaredField.gnFieldType == GNFieldDataType.GNArray)
                    {
                        if (value is GNArray) answer.add(declaredField.code, value);
                        else if (value is System.Collections.IList valueLst) answer.add(declaredField.code, this.serializeArray(valueLst));
                    }
                    else if (declaredField.gnFieldType == GNFieldDataType.Number)
                    {
                        if (ConverterService.isNumber(value)) answer.add(declaredField.code, value);
                    }
                    else
                    {
                        if (value is string) answer.add(declaredField.code, value);
                        else if (value is bool) answer.add(declaredField.code, value);
                        else if (ConverterService.isNumber(value)) answer.add(declaredField.code, value);
                        else if (value is IGNData) answer.add(declaredField.code, value);
                        else if (value is System.Collections.IList valueLst) answer.add(declaredField.code, this.serializeArray(valueLst));
                        else if (value is System.Collections.IDictionary valueDict) answer.add(declaredField.code, new GNHashtable.Builder().addAll(valueDict).build());
                        else answer.add(declaredField.code, this.serializeObject(value));
                    }
                }
            }

            return answer;
        }

        public GNArray serializeArray(System.Collections.IList objLst)
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
                else if (obj is System.Collections.IList iList) answer.add(this.serializeArray(iList));
                else answer.add(this.serializeObject(obj));
            }

            return answer;
        }

        public SerializeConverter(DataMemberFieldInfoTypeMapper dataMemberFieldInfoMapper)
        {
            this.dataMemberFieldInfoMapper = dataMemberFieldInfoMapper;
        }
    }

    public class ConverterService
    {
        private static SerializeConverter serializeConverter;
        private static DeserializeConverter deserializeConverter;

        public static T deserializeObject<T>(GNHashtable gnHashtable)
        {
            return (T)ConverterService.deserializeObject(gnHashtable, typeof(T));
        }

        public static object deserializeObject(GNHashtable gnHashtable, Type cls)
        {
            return ConverterService.deserializeConverter.deserializeObject(gnHashtable, cls);
        }

        public static System.Collections.IList deserializeArray<T>(GNArray gnArray)
        {
            return ConverterService.deserializeArray<T>(gnArray);
        }

        public static System.Collections.IList deserializeArray(GNArray gnArray, Type cls)
        {
            return ConverterService.deserializeConverter.deserializeArray(gnArray, cls);
        }

        public static GNHashtable serializeObject(object obj)
        {
            return ConverterService.serializeConverter.serializeObject(obj);
        }

        public static GNArray serializeArray(System.Collections.IList objLst)
        {
            return ConverterService.serializeConverter.serializeArray(objLst);
        }

        static ConverterService()
        {
            var dataMemberFieldInfoMapper = new DataMemberFieldInfoTypeMapper();

            ConverterService.serializeConverter = new SerializeConverter(dataMemberFieldInfoMapper);
            ConverterService.deserializeConverter = new DeserializeConverter(dataMemberFieldInfoMapper);
        }

        public static bool isNumber(object value)
        {
            return (value is byte
                    || value is sbyte
                    || value is short
                    || value is int
                    || value is float
                    || value is long
                    || value is double);
        }

        public static bool isInteger(object value)
        {
            return (value is byte
                || value is sbyte
                || value is short
                || value is int
                || value is long);
        }
    }

}
