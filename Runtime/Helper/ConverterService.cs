namespace XmobiTea.GearN.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Entity;

    /// <summary>
    /// Mapper class for extracting and caching metadata of fields in a class decorated with DataMember attributes.
    /// </summary>
    internal class DataMemberFieldInfoTypeMapper
    {
        // A cache to store metadata mappings of fields for each class type
        private Dictionary<Type, GNEnhancedObjectFieldMetadata[]> declaredFieldsMap;

        // Retrieves metadata for all fields in a class, including inherited ones
        public GNEnhancedObjectFieldMetadata[] getGNEnhancedObjectFieldMetadata(System.Type cls)
        {
            GNEnhancedObjectFieldMetadata[] declaredFields;

            // If the class has been mapped, return the cached metadata
            if (this.declaredFieldsMap.ContainsKey(cls))
            {
                declaredFields = this.declaredFieldsMap[cls];
            }
            else
            {
                // List to store all found fields
                var fieldInfoLst = new List<FieldInfo>();

                var currentCls = cls;

                // Iterate through the class hierarchy to find all fields
                while (true)
                {
                    // Retrieve all fields marked with the DataMemberAttribute
                    var allDeclaredFields = currentCls.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                        .Where(field => field.GetCustomAttribute<DataMemberAttribute>(true) != null);

                    foreach (var field in allDeclaredFields)
                    {
                        // Check if the field already exists in the list, add it if not
                        var thisDeclaredField = fieldInfoLst.Find(x => x.Name.Equals(field.Name));
                        if (thisDeclaredField == null) fieldInfoLst.Add(field);
                    }

                    // If we have reached the base class (object), exit the loop
                    if (currentCls.BaseType == typeof(object)) break;

                    currentCls = currentCls.BaseType;
                }

                // Create an array to hold the metadata for the fields
                declaredFields = new GNEnhancedObjectFieldMetadata[fieldInfoLst.Count];

                for (var i = 0; i < fieldInfoLst.Count; i++)
                {
                    GNEnhancedObjectFieldMetadata gnEnhancedObjectFieldMetadata;

                    var field = fieldInfoLst[i];

                    // Retrieve the attribute information for the field
                    var dataMemberAnno = field.GetCustomAttribute<DataMemberAttribute>(true);

                    // Handle each specific type of attribute and map its data to GNEnhancedObjectFieldMetadata
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

                    // Map common properties from the attribute to the metadata
                    gnEnhancedObjectFieldMetadata.code = dataMemberAnno.code;
                    gnEnhancedObjectFieldMetadata.isOptional = dataMemberAnno.isOptional;
                    gnEnhancedObjectFieldMetadata.gnFieldType = dataMemberAnno.gnFieldType;

                    // Add the field metadata to the array
                    declaredFields[i] = gnEnhancedObjectFieldMetadata;
                }

                // Cache the metadata for future access
                this.declaredFieldsMap[cls] = declaredFields;
            }

            return declaredFields;
        }

        // Constructor initializes the declaredFieldsMap dictionary
        public DataMemberFieldInfoTypeMapper()
        {
            this.declaredFieldsMap = new Dictionary<Type, GNEnhancedObjectFieldMetadata[]>();
        }
    }

    /// <summary>
    /// Class responsible for deserializing objects and arrays from GNHashtable and GNArray
    /// </summary>
    internal class DeserializeConverter
    {
        // Mapper to retrieve metadata for fields with DataMember attributes
        private DataMemberFieldInfoTypeMapper dataMemberFieldInfoMapper { get; }

        // Cached type definitions for common types
        private Type typeOfByte { get; }
        private Type typeOfSByte { get; }
        private Type typeOfShort { get; }
        private Type typeOfUShort { get; }
        private Type typeOfInt { get; }
        private Type typeOfUInt { get; }
        private Type typeOfFloat { get; }
        private Type typeOfLong { get; }
        private Type typeOfULong { get; }
        private Type typeOfDouble { get; }
        private Type typeOfBool { get; }
        private Type typeOfString { get; }
        private Type typeOfGNArray { get; }
        private Type typeOfGNHashtable { get; }

        bool TryGetNullable(FieldInfo fieldInfo, out Type tType)
        {
            tType = Nullable.GetUnderlyingType(fieldInfo.FieldType);
            return tType != null;
        }

        /// <summary>
        /// Deserializes a GNHashtable into an object of the specified type.
        /// </summary>
        /// <param name="gnHashtable">The GNHashtable to deserialize.</param>
        /// <param name="cls">The type of the object to create.</param>
        /// <returns>An instance of the specified type populated with data from the GNHashtable.</returns>
        public object deserializeObject(GNHashtable gnHashtable, Type cls)
        {
            // Return null if the input is null
            if (gnHashtable == null) return null;

            // Retrieve metadata for all fields in the target type
            var declaredFields = this.dataMemberFieldInfoMapper.getGNEnhancedObjectFieldMetadata(cls);

            // Create an instance of the target class
            var answer = Activator.CreateInstance(cls);

            // Iterate through each field and populate its value from the GNHashtable
            foreach (var declaredField in declaredFields)
            {
                // Retrieve the value for the field based on its code
                var value = gnHashtable.getObject(declaredField.code);

                // Handle field types based on GNFieldDataType
                if (declaredField.gnFieldType == GNFieldDataType.String)
                {
                    if (value == null) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                    else if (value is string valueStr)
                    {
                        if (declaredField.fieldInfo.FieldType.IsEnum) declaredField.fieldInfo.SetValue(answer, Enum.Parse(declaredField.fieldInfo.FieldType, valueStr, true));
                        else declaredField.fieldInfo.SetValue(answer, valueStr);
                    }
                }
                else if (declaredField.gnFieldType == GNFieldDataType.Boolean)
                {
                    if (value == null) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                    else if (value is bool) declaredField.fieldInfo.SetValue(answer, value);
                }
                else if (declaredField.gnFieldType == GNFieldDataType.GNHashtable)
                {
                    // Handle nested objects
                    if (value == null)
                    {
                        if (declaredField.defaultValue != null)
                        {
                            if (declaredField.fieldInfo.FieldType == this.typeOfGNHashtable) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                            else if (declaredField.fieldInfo.FieldType == typeof(System.Collections.IDictionary)) declaredField.fieldInfo.SetValue(answer, ((GNHashtable)(declaredField.defaultValue)).toData());
                            else declaredField.fieldInfo.SetValue(answer, this.deserializeObject((GNHashtable)declaredField.defaultValue, declaredField.cls));
                        }
                    }
                    else
                    {
                        if (declaredField.fieldInfo.FieldType == this.typeOfGNHashtable) declaredField.fieldInfo.SetValue(answer, value);
                        else if (declaredField.fieldInfo.FieldType == typeof(System.Collections.IDictionary)) declaredField.fieldInfo.SetValue(answer, ((IGNData)value).toData());
                        else declaredField.fieldInfo.SetValue(answer, this.deserializeObject((GNHashtable)value, declaredField.cls));
                    }
                }
                else if (declaredField.gnFieldType == GNFieldDataType.GNArray)
                {
                    // Handle arrays
                    if (value == null)
                    {
                        if (declaredField.defaultValue != null)
                        {
                            if (declaredField.fieldInfo.FieldType == this.typeOfGNArray) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                            else if (declaredField.fieldInfo.FieldType == typeof(System.Collections.IList)) declaredField.fieldInfo.SetValue(answer, ((GNArray)declaredField.defaultValue).toData());
                            else declaredField.fieldInfo.SetValue(answer, this.castList(this.deserializeArray((GNArray)declaredField.defaultValue, declaredField.cls), declaredField.cls, declaredField.fieldInfo.FieldType.IsArray));
                        }
                    }
                    else
                    {
                        if (declaredField.fieldInfo.FieldType == this.typeOfGNArray) declaredField.fieldInfo.SetValue(answer, value);
                        else if (declaredField.fieldInfo.FieldType == typeof(System.Collections.IList)) declaredField.fieldInfo.SetValue(answer, ((IGNData)value).toData());
                        else declaredField.fieldInfo.SetValue(answer, this.castList(this.deserializeArray((GNArray)value, declaredField.cls), declaredField.cls, declaredField.fieldInfo.FieldType.IsArray));
                    }
                }
                else if (declaredField.gnFieldType == GNFieldDataType.Number)
                {
                    object lastValue;

                    if (value == null) lastValue = declaredField.defaultValue;
                    else lastValue = value;

                    if (ConverterService.isNumber(lastValue))
                    {
                        if (declaredField.fieldInfo.FieldType.IsEnum) declaredField.fieldInfo.SetValue(answer, Enum.ToObject(declaredField.fieldInfo.FieldType, lastValue));
                        else
                        {
                            if (TryGetNullable(declaredField.fieldInfo, out var tType))
                            {
                                var typeCode = Type.GetTypeCode(tType);

                                if (typeCode == TypeCode.SByte) declaredField.fieldInfo.SetValue(answer, Convert.ToSByte(lastValue));
                                else if (typeCode == TypeCode.Byte) declaredField.fieldInfo.SetValue(answer, Convert.ToByte(lastValue));
                                else if (typeCode == TypeCode.Int16) declaredField.fieldInfo.SetValue(answer, Convert.ToInt16(lastValue));
                                else if (typeCode == TypeCode.UInt16) declaredField.fieldInfo.SetValue(answer, Convert.ToUInt16(lastValue));
                                else if (typeCode == TypeCode.Int32) declaredField.fieldInfo.SetValue(answer, Convert.ToInt32(lastValue));
                                else if (typeCode == TypeCode.UInt32) declaredField.fieldInfo.SetValue(answer, Convert.ToUInt32(lastValue));
                                else if (typeCode == TypeCode.Int64) declaredField.fieldInfo.SetValue(answer, Convert.ToInt64(lastValue));
                                else if (typeCode == TypeCode.UInt64) declaredField.fieldInfo.SetValue(answer, Convert.ToUInt64(lastValue));
                                else if (typeCode == TypeCode.Single) declaredField.fieldInfo.SetValue(answer, Convert.ToSingle(lastValue));
                                else if (typeCode == TypeCode.Double) declaredField.fieldInfo.SetValue(answer, Convert.ToDouble(lastValue));
                            }
                            else
                            {
                                if (declaredField.fieldInfo.FieldType == this.typeOfByte) declaredField.fieldInfo.SetValue(answer, Convert.ToByte(lastValue));
                                else if (declaredField.fieldInfo.FieldType == this.typeOfSByte) declaredField.fieldInfo.SetValue(answer, Convert.ToSByte(lastValue));
                                else if (declaredField.fieldInfo.FieldType == this.typeOfShort) declaredField.fieldInfo.SetValue(answer, Convert.ToInt16(lastValue));
                                else if (declaredField.fieldInfo.FieldType == this.typeOfUShort) declaredField.fieldInfo.SetValue(answer, Convert.ToUInt16(lastValue));
                                else if (declaredField.fieldInfo.FieldType == this.typeOfInt) declaredField.fieldInfo.SetValue(answer, Convert.ToInt32(lastValue));
                                else if (declaredField.fieldInfo.FieldType == this.typeOfUInt) declaredField.fieldInfo.SetValue(answer, Convert.ToUInt32(lastValue));
                                else if (declaredField.fieldInfo.FieldType == this.typeOfFloat) declaredField.fieldInfo.SetValue(answer, Convert.ToSingle(lastValue));
                                else if (declaredField.fieldInfo.FieldType == this.typeOfLong) declaredField.fieldInfo.SetValue(answer, Convert.ToInt64(lastValue));
                                else if (declaredField.fieldInfo.FieldType == this.typeOfULong) declaredField.fieldInfo.SetValue(answer, Convert.ToUInt64(lastValue));
                                else if (declaredField.fieldInfo.FieldType == this.typeOfDouble) declaredField.fieldInfo.SetValue(answer, Convert.ToDouble(lastValue));
                                else declaredField.fieldInfo.SetValue(answer, value);
                            }
                        }
                    }
                }
                else
                {
                    // Handle other primitive types
                    if (value == null)
                    {
                        if (declaredField.defaultValue != null)
                        {
                            if (declaredField.fieldInfo.FieldType == this.typeOfByte) declaredField.fieldInfo.SetValue(answer, Convert.ToByte(declaredField.defaultValue));
                            else if (declaredField.fieldInfo.FieldType == this.typeOfSByte) declaredField.fieldInfo.SetValue(answer, Convert.ToSByte(declaredField.defaultValue));
                            else if (declaredField.fieldInfo.FieldType == this.typeOfShort) declaredField.fieldInfo.SetValue(answer, Convert.ToInt16(declaredField.defaultValue));
                            else if (declaredField.fieldInfo.FieldType == this.typeOfUShort) declaredField.fieldInfo.SetValue(answer, Convert.ToUInt16(declaredField.defaultValue));
                            else if (declaredField.fieldInfo.FieldType == this.typeOfInt) declaredField.fieldInfo.SetValue(answer, Convert.ToInt32(declaredField.defaultValue));
                            else if (declaredField.fieldInfo.FieldType == this.typeOfUInt) declaredField.fieldInfo.SetValue(answer, Convert.ToUInt32(declaredField.defaultValue));
                            else if (declaredField.fieldInfo.FieldType == this.typeOfFloat) declaredField.fieldInfo.SetValue(answer, Convert.ToSingle(declaredField.defaultValue));
                            else if (declaredField.fieldInfo.FieldType == this.typeOfLong) declaredField.fieldInfo.SetValue(answer, Convert.ToInt64(declaredField.defaultValue));
                            else if (declaredField.fieldInfo.FieldType == this.typeOfULong) declaredField.fieldInfo.SetValue(answer, Convert.ToUInt64(declaredField.defaultValue));
                            else if (declaredField.fieldInfo.FieldType == this.typeOfDouble) declaredField.fieldInfo.SetValue(answer, Convert.ToDouble(declaredField.defaultValue));
                            else if (declaredField.fieldInfo.FieldType == this.typeOfBool) declaredField.fieldInfo.SetValue(answer, Convert.ToBoolean(declaredField.defaultValue));
                            else if (declaredField.fieldInfo.FieldType == this.typeOfString) declaredField.fieldInfo.SetValue(answer, Convert.ToString(declaredField.defaultValue));
                            else if (declaredField.fieldInfo.FieldType == this.typeOfGNArray) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                            else if (declaredField.fieldInfo.FieldType == typeof(System.Collections.IList)) declaredField.fieldInfo.SetValue(answer, ((IGNData)declaredField.defaultValue).toData());
                            else if (declaredField.fieldInfo.FieldType == this.typeOfGNHashtable) declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                            else if (declaredField.fieldInfo.FieldType == typeof(System.Collections.IDictionary)) declaredField.fieldInfo.SetValue(answer, ((IGNData)declaredField.defaultValue).toData());
                            else declaredField.fieldInfo.SetValue(answer, declaredField.defaultValue);
                        }
                    }
                    else
                    {
                        if (declaredField.fieldInfo.FieldType == this.typeOfByte) declaredField.fieldInfo.SetValue(answer, Convert.ToByte(value));
                        else if (declaredField.fieldInfo.FieldType == this.typeOfSByte) declaredField.fieldInfo.SetValue(answer, Convert.ToSByte(value));
                        else if (declaredField.fieldInfo.FieldType == this.typeOfShort) declaredField.fieldInfo.SetValue(answer, Convert.ToInt16(value));
                        else if (declaredField.fieldInfo.FieldType == this.typeOfUShort) declaredField.fieldInfo.SetValue(answer, Convert.ToUInt16(value));
                        else if (declaredField.fieldInfo.FieldType == this.typeOfInt) declaredField.fieldInfo.SetValue(answer, Convert.ToInt32(value));
                        else if (declaredField.fieldInfo.FieldType == this.typeOfUInt) declaredField.fieldInfo.SetValue(answer, Convert.ToUInt32(value));
                        else if (declaredField.fieldInfo.FieldType == this.typeOfFloat) declaredField.fieldInfo.SetValue(answer, Convert.ToSingle(value));
                        else if (declaredField.fieldInfo.FieldType == this.typeOfLong) declaredField.fieldInfo.SetValue(answer, Convert.ToInt64(value));
                        else if (declaredField.fieldInfo.FieldType == this.typeOfULong) declaredField.fieldInfo.SetValue(answer, Convert.ToUInt64(value));
                        else if (declaredField.fieldInfo.FieldType == this.typeOfDouble) declaredField.fieldInfo.SetValue(answer, Convert.ToDouble(value));
                        else if (declaredField.fieldInfo.FieldType == this.typeOfBool) declaredField.fieldInfo.SetValue(answer, Convert.ToBoolean(value));
                        else if (declaredField.fieldInfo.FieldType == this.typeOfString) declaredField.fieldInfo.SetValue(answer, Convert.ToString(value));
                        else if (declaredField.fieldInfo.FieldType == this.typeOfGNArray) declaredField.fieldInfo.SetValue(answer, value);
                        else if (declaredField.fieldInfo.FieldType == typeof(System.Collections.IList)) declaredField.fieldInfo.SetValue(answer, ((IGNData)value).toData());
                        else if (declaredField.fieldInfo.FieldType == this.typeOfGNHashtable) declaredField.fieldInfo.SetValue(answer, value);
                        else if (declaredField.fieldInfo.FieldType == typeof(System.Collections.IDictionary)) declaredField.fieldInfo.SetValue(answer, ((IGNData)value).toData());
                        else
                        {
                            if (declaredField.fieldInfo.FieldType.IsEnum) declaredField.fieldInfo.SetValue(answer, Enum.ToObject(declaredField.fieldInfo.FieldType, value));
                            else declaredField.fieldInfo.SetValue(answer, value);
                        }
                    }
                }
            }

            return answer;
        }

        /// <summary>
        /// Deserializes a GNArray into a list of objects of the specified type.
        /// </summary>
        /// <param name="gnArray">The GNArray to deserialize.</param>
        /// <param name="cls">The type of objects in the resulting list.</param>
        /// <returns>A list of objects of the specified type.</returns>
        public System.Collections.IList deserializeArray(GNArray gnArray, Type cls)
        {
            if (gnArray == null) return null;

            var answer = new System.Collections.Generic.List<object>();

            // Deserialize each element in the array
            for (var i = 0; i < gnArray.count(); i++)
            {
                var value = gnArray.getObject(i);
                if (value == null) answer.Add(null);
                else
                {
                    var typeOfValue = value.GetType();

                    if (cls == this.typeOfByte) answer.Add(value);
                    else if (cls == this.typeOfSByte) answer.Add(value);
                    else if (cls == this.typeOfShort) answer.Add(value);
                    else if (cls == this.typeOfUShort) answer.Add(value);
                    else if (cls == this.typeOfInt) answer.Add(value);
                    else if (cls == this.typeOfUInt) answer.Add(value);
                    else if (cls == this.typeOfFloat) answer.Add(value);
                    else if (cls == this.typeOfLong) answer.Add(value);
                    else if (cls == this.typeOfULong) answer.Add(value);
                    else if (cls == this.typeOfDouble) answer.Add(value);
                    else if (cls == this.typeOfBool) answer.Add(value);
                    else if (cls == this.typeOfString) answer.Add(value);
                    else if (cls == this.typeOfGNArray) answer.Add(value);
                    else if (cls == this.typeOfGNHashtable) answer.Add(value);
                    else if (typeOfValue == typeof(System.Collections.IList))
                        answer.Add(this.deserializeArray(gnArray.getGNArray(i), cls));
                    else
                    {
                        if (cls.IsEnum) answer.Add(Enum.ToObject(typeOfValue, System.Convert.ToByte(value)));
                        else answer.Add(this.deserializeObject(gnArray.getGNHashtable(i), cls));
                    }
                }
            }

            return answer;
        }

        public System.Collections.IList castList(System.Collections.IList objectLst, System.Type cls, bool isArray)
        {
            if (isArray)
            {
                var answer = System.Array.CreateInstance(cls, objectLst.Count);

                for (int i = 0; i < objectLst.Count; i++)
                    answer.SetValue(System.Convert.ChangeType(objectLst[i], cls), i);

                return answer;
            }
            else
            {
                if (cls == typeof(object)) return objectLst;

                var typeOfList = typeof(System.Collections.Generic.List<>).MakeGenericType(cls);
                var answer = (System.Collections.IList)System.Activator.CreateInstance(typeOfList);

                foreach (var item in objectLst)
                    answer.Add(System.Convert.ChangeType(item, cls));

                return answer;
            }
        }

        /// <summary>
        /// Constructor for DeserializeConverter.
        /// Initializes type mappings and field info mapper.
        /// </summary>
        /// <param name="dataMemberFieldInfoMapper">The mapper for field metadata.</param>
        public DeserializeConverter(DataMemberFieldInfoTypeMapper dataMemberFieldInfoMapper)
        {
            this.dataMemberFieldInfoMapper = dataMemberFieldInfoMapper;

            this.typeOfByte = typeof(byte);
            this.typeOfSByte = typeof(sbyte);
            this.typeOfShort = typeof(short);
            this.typeOfUShort = typeof(ushort);
            this.typeOfInt = typeof(int);
            this.typeOfUInt = typeof(uint);
            this.typeOfFloat = typeof(float);
            this.typeOfLong = typeof(long);
            this.typeOfULong = typeof(ulong);
            this.typeOfDouble = typeof(double);
            this.typeOfBool = typeof(bool);
            this.typeOfString = typeof(string);
            this.typeOfGNArray = typeof(GNArray);
            this.typeOfGNHashtable = typeof(GNHashtable);

        }
    }

    /// <summary>
    /// Class responsible for serializing objects and arrays into GNHashtable and GNArray.
    /// </summary>
    internal class SerializeConverter
    {
        // Mapper to retrieve metadata for fields with DataMember attributes.
        private DataMemberFieldInfoTypeMapper dataMemberFieldInfoMapper;

        private Type typeOfByte { get; }
        private Type typeOfSByte { get; }
        private Type typeOfShort { get; }
        private Type typeOfUShort { get; }
        private Type typeOfInt { get; }
        private Type typeOfUInt { get; }
        private Type typeOfFloat { get; }
        private Type typeOfLong { get; }
        private Type typeOfULong { get; }
        private Type typeOfDouble { get; }

        /// <summary>
        /// Serializes an object into a GNHashtable.
        /// </summary>
        /// <param name="obj">The object to serialize.</param>
        /// <returns>A GNHashtable representing the serialized object.</returns>
        public GNHashtable serializeObject(object obj)
        {
            // Return null if the input object is null.
            if (obj == null) return null;

            // Get the type of the input object.
            var type = obj.GetType();

            // Retrieve metadata for all fields in the object's type.
            var declaredFields = this.dataMemberFieldInfoMapper.getGNEnhancedObjectFieldMetadata(type);

            // Initialize the result GNHashtable.
            var answer = new GNHashtable();

            // Iterate through each field and populate the GNHashtable.
            foreach (var declaredField in declaredFields)
            {
                // Get the value of the field from the object.
                var value = declaredField.fieldInfo.GetValue(obj);

                if (value == null)
                {
                    // Add null value if the field is not optional.
                    if (!declaredField.isOptional) answer.add(declaredField.code, null);
                }
                else
                {
                    // Handle serialization based on the GNFieldDataType.
                    if (declaredField.gnFieldType == GNFieldDataType.String)
                    {
                        if (value is string) answer.add(declaredField.code, value);
                        else answer.add(declaredField.code, value.ToString());
                    }
                    else if (declaredField.gnFieldType == GNFieldDataType.Boolean)
                    {
                        if (value is bool) answer.add(declaredField.code, value);
                    }
                    else if (declaredField.gnFieldType == GNFieldDataType.GNHashtable)
                    {
                        // Handle GNHashtable fields or nested objects.
                        if (value is GNHashtable) answer.add(declaredField.code, value);
                        else if (value is System.Collections.IDictionary valueDict) answer.add(declaredField.code, new GNHashtable.Builder().addAll(valueDict).build());
                        else answer.add(declaredField.code, this.serializeObject(value));
                    }
                    else if (declaredField.gnFieldType == GNFieldDataType.GNArray)
                    {
                        // Handle GNArray fields or lists.
                        if (value is GNArray) answer.add(declaredField.code, value);
                        else if (value is System.Collections.IList valueLst) answer.add(declaredField.code, this.serializeArray(valueLst));
                    }
                    else if (declaredField.gnFieldType == GNFieldDataType.Number)
                    {
                        // Handle numeric fields.
                        if (ConverterService.isNumber(value)) answer.add(declaredField.code, value);
                        else
                        {
                            var valueType = value.GetType();

                            if (valueType.IsEnum)
                            {
                                var underlyingValueType = Enum.GetUnderlyingType(valueType);

                                if (underlyingValueType == this.typeOfByte) answer.add(declaredField.code, Convert.ToByte(value));
                                else if (underlyingValueType == this.typeOfSByte) answer.add(declaredField.code, Convert.ToSByte(value));
                                else if (underlyingValueType == this.typeOfShort) answer.add(declaredField.code, Convert.ToInt16(value));
                                else if (underlyingValueType == this.typeOfUShort) answer.add(declaredField.code, Convert.ToUInt16(value));
                                else if (underlyingValueType == this.typeOfInt) answer.add(declaredField.code, Convert.ToInt32(value));
                                else if (underlyingValueType == this.typeOfUInt) answer.add(declaredField.code, Convert.ToUInt32(value));
                                else if (underlyingValueType == this.typeOfFloat) answer.add(declaredField.code, Convert.ToSingle(value));
                                else if (underlyingValueType == this.typeOfLong) answer.add(declaredField.code, Convert.ToInt64(value));
                                else if (underlyingValueType == this.typeOfULong) answer.add(declaredField.code, Convert.ToUInt64(value));
                                else if (underlyingValueType == this.typeOfDouble) answer.add(declaredField.code, Convert.ToDouble(value));
                            }
                        }
                    }
                    else
                    {
                        // Handle other types.
                        if (value is string) answer.add(declaredField.code, value);
                        else if (value is bool) answer.add(declaredField.code, value);
                        else if (ConverterService.isNumber(value)) answer.add(declaredField.code, value);
                        else if (value is IGNData) answer.add(declaredField.code, value);
                        else if (value is System.Collections.IList valueLst) answer.add(declaredField.code, this.serializeArray(valueLst));
                        else if (value is System.Collections.IDictionary valueDict) answer.add(declaredField.code, new GNHashtable.Builder().addAll(valueDict).build());
                        else
                        {
                            var valueType = value.GetType();

                            if (valueType.IsEnum)
                            {
                                var underlyingValueType = Enum.GetUnderlyingType(valueType);

                                if (underlyingValueType == this.typeOfByte) answer.add(declaredField.code, Convert.ToByte(value));
                                else if (underlyingValueType == this.typeOfSByte) answer.add(declaredField.code, Convert.ToSByte(value));
                                else if (underlyingValueType == this.typeOfShort) answer.add(declaredField.code, Convert.ToInt16(value));
                                else if (underlyingValueType == this.typeOfUShort) answer.add(declaredField.code, Convert.ToUInt16(value));
                                else if (underlyingValueType == this.typeOfInt) answer.add(declaredField.code, Convert.ToInt32(value));
                                else if (underlyingValueType == this.typeOfUInt) answer.add(declaredField.code, Convert.ToUInt32(value));
                                else if (underlyingValueType == this.typeOfFloat) answer.add(declaredField.code, Convert.ToSingle(value));
                                else if (underlyingValueType == this.typeOfLong) answer.add(declaredField.code, Convert.ToInt64(value));
                                else if (underlyingValueType == this.typeOfULong) answer.add(declaredField.code, Convert.ToUInt64(value));
                                else if (underlyingValueType == this.typeOfDouble) answer.add(declaredField.code, Convert.ToDouble(value));
                            }
                            else answer.add(declaredField.code, this.serializeObject(value));
                        }
                    }
                }
            }

            return answer;
        }

        /// <summary>
        /// Serializes a list into a GNArray.
        /// </summary>
        /// <param name="objLst">The list to serialize.</param>
        /// <returns>A GNArray representing the serialized list.</returns>
        public GNArray serializeArray(System.Collections.IList objLst)
        {
            // Return null if the input list is null.
            if (objLst == null) return null;

            // Initialize the result GNArray.
            var answer = new GNArray();

            // Iterate through each element in the list.
            for (var i = 0; i < objLst.Count; i++)
            {
                var obj = objLst[i];

                if (obj == null) answer.add(null);
                else if (obj is string) answer.add(obj);
                else if (obj is bool) answer.add(obj);
                else if (ConverterService.isNumber(obj)) answer.add(obj);
                else if (obj is IGNData) answer.add(obj);
                else if (obj is System.Collections.IList iList) answer.add(this.serializeArray(iList));
                else
                {
                    var valueType = obj.GetType();

                    if (valueType.IsEnum)
                    {
                        var underlyingValueType = Enum.GetUnderlyingType(valueType);

                        if (underlyingValueType == this.typeOfByte) answer.add(Convert.ToByte(obj));
                        else if (underlyingValueType == this.typeOfSByte) answer.add(Convert.ToSByte(obj));
                        else if (underlyingValueType == this.typeOfShort) answer.add(Convert.ToInt16(obj));
                        else if (underlyingValueType == this.typeOfUShort) answer.add(Convert.ToUInt16(obj));
                        else if (underlyingValueType == this.typeOfInt) answer.add(Convert.ToInt32(obj));
                        else if (underlyingValueType == this.typeOfUInt) answer.add(Convert.ToUInt32(obj));
                        else if (underlyingValueType == this.typeOfFloat) answer.add(Convert.ToSingle(obj));
                        else if (underlyingValueType == this.typeOfLong) answer.add(Convert.ToInt64(obj));
                        else if (underlyingValueType == this.typeOfULong) answer.add(Convert.ToUInt64(obj));
                        else if (underlyingValueType == this.typeOfDouble) answer.add(Convert.ToDouble(obj));
                    }
                    else answer.add(this.serializeObject(obj));
                }
            }

            return answer;
        }

        /// <summary>
        /// Constructor for SerializeConverter.
        /// </summary>
        /// <param name="dataMemberFieldInfoMapper">The mapper for field metadata.</param>
        public SerializeConverter(DataMemberFieldInfoTypeMapper dataMemberFieldInfoMapper)
        {
            this.dataMemberFieldInfoMapper = dataMemberFieldInfoMapper;

            this.typeOfByte = typeof(byte);
            this.typeOfSByte = typeof(sbyte);
            this.typeOfShort = typeof(short);
            this.typeOfUShort = typeof(ushort);
            this.typeOfInt = typeof(int);
            this.typeOfUInt = typeof(uint);
            this.typeOfFloat = typeof(float);
            this.typeOfLong = typeof(long);
            this.typeOfULong = typeof(ulong);
            this.typeOfDouble = typeof(double);
        }
    }

    /// <summary>
    /// Service class providing serialization and deserialization functionality.
    /// Handles conversion of objects to GNHashtable/GNArray and vice versa.
    /// </summary>
    public static class ConverterService
    {
        // Private static instances for serialization and deserialization operations.
        private static SerializeConverter serializeConverter;
        private static DeserializeConverter deserializeConverter;

        /// <summary>
        /// Deserializes a GNHashtable into a strongly-typed object.
        /// </summary>
        /// <typeparam name="T">The target object type.</typeparam>
        /// <param name="gnHashtable">The GNHashtable to deserialize.</param>
        /// <returns>The deserialized object of type T.</returns>
        public static T deserializeObject<T>(GNHashtable gnHashtable)
        {
            return (T)ConverterService.deserializeObject(gnHashtable, typeof(T));
        }

        /// <summary>
        /// Deserializes a GNHashtable into an object of the specified type.
        /// </summary>
        /// <param name="gnHashtable">The GNHashtable to deserialize.</param>
        /// <param name="cls">The type to deserialize into.</param>
        /// <returns>The deserialized object.</returns>
        public static object deserializeObject(GNHashtable gnHashtable, Type cls)
        {
            return ConverterService.deserializeConverter.deserializeObject(gnHashtable, cls);
        }

        /// <summary>
        /// Deserializes a GNArray into a strongly-typed list.
        /// </summary>
        /// <typeparam name="T">The element type of the resulting list.</typeparam>
        /// <param name="gnArray">The GNArray to deserialize.</param>
        /// <returns>A list of deserialized elements.</returns>
        public static System.Collections.IList deserializeArray<T>(GNArray gnArray)
        {
            return ConverterService.deserializeArray(gnArray, typeof(T));
        }

        /// <summary>
        /// Deserializes a GNArray into a list of a specified type.
        /// </summary>
        /// <param name="gnArray">The GNArray to deserialize.</param>
        /// <param name="cls">The target element type.</param>
        /// <returns>A list of deserialized elements.</returns>
        public static System.Collections.IList deserializeArray(GNArray gnArray, Type cls)
        {
            var answer = ConverterService.deserializeConverter.deserializeArray(gnArray, cls);

            return ConverterService.deserializeConverter.castList(answer, cls, false);
        }

        /// <summary>
        /// Serializes an object into a GNHashtable.
        /// </summary>
        /// <param name="obj">The object to serialize.</param>
        /// <returns>A GNHashtable representing the serialized object.</returns>
        public static GNHashtable serializeObject(object obj)
        {
            return ConverterService.serializeConverter.serializeObject(obj);
        }

        /// <summary>
        /// Serializes a list into a GNArray.
        /// </summary>
        /// <param name="objLst">The list to serialize.</param>
        /// <returns>A GNArray representing the serialized list.</returns>
        public static GNArray serializeArray(System.Collections.IList objLst)
        {
            return ConverterService.serializeConverter.serializeArray(objLst);
        }

        /// <summary>
        /// Static constructor to initialize the SerializeConverter and DeserializeConverter instances.
        /// </summary>
        static ConverterService()
        {
            // Create a shared DataMemberFieldInfoTypeMapper for both converters.
            var dataMemberFieldInfoMapper = new DataMemberFieldInfoTypeMapper();

            ConverterService.serializeConverter = new SerializeConverter(dataMemberFieldInfoMapper);
            ConverterService.deserializeConverter = new DeserializeConverter(dataMemberFieldInfoMapper);
        }

        /// <summary>
        /// Checks if a value is a numeric type.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>True if the value is a numeric type; otherwise, false.</returns>
        public static bool isNumber(object value)
        {
            return (value is byte
                    || value is sbyte
                    || value is short
                    || value is ushort
                    || value is int
                    || value is uint
                    || value is float
                    || value is long
                    || value is ulong
                    || value is double);
        }

        /// <summary>
        /// Checks if a value is an integer type.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>True if the value is an integer type; otherwise, false.</returns>
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
