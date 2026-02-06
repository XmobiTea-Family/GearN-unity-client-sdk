namespace XmobiTea.GearN.Entity
{
    using System;
    using System.Reflection;
    using XmobiTea.GearN.Common;

    /// <summary>
    /// Enhanced metadata for an object field in the GN system.
    /// </summary>
    public interface IGNEnhancedObjectFieldMetadata : GNObjectFieldMetadata
    {
        /// <summary>
        /// Gets or sets the code associated with the field.
        /// </summary>
        string code { get; set; }

        /// <summary>
        /// Gets or sets whether the field is optional.
        /// </summary>
        bool isOptional { get; set; }

        /// <summary>
        /// Gets or sets the data type of the field.
        /// </summary>
        GNFieldDataType gnFieldType { get; set; }

        /// <summary>
        /// Gets or sets the default value of the field.
        /// </summary>
        object defaultValue { get; set; }

        /// <summary>
        /// Gets or sets whether the active condition validation is valid.
        /// </summary>
        bool activeConditionValid { get; set; }

        /// <summary>
        /// Gets or sets whether the field must be non-null.
        /// </summary>
        bool? mustNonNull { get; set; }

        /// <summary>
        /// Gets or sets the minimum length for the field's value, if applicable.
        /// </summary>
        int? minLength { get; set; }

        /// <summary>
        /// Gets or sets the maximum length for the field's value, if applicable.
        /// </summary>
        int? maxLength { get; set; }

        /// <summary>
        /// Gets or sets the minimum value for the field, if applicable.
        /// </summary>
        double? minValue { get; set; }

        /// <summary>
        /// Gets or sets the maximum value for the field, if applicable.
        /// </summary>
        double? maxValue { get; set; }

        /// <summary>
        /// Gets or sets whether the field's value must be an integer.
        /// </summary>
        bool? mustInt { get; set; }
    }

    /// <summary>
    /// Implementation of the enhanced metadata for an object field in the GN system.
    /// </summary>
    public class GNEnhancedObjectFieldMetadata : IGNEnhancedObjectFieldMetadata
    {
        /// <inheritdoc/>
        public string code { get; set; }

        /// <inheritdoc/>
        public bool isOptional { get; set; }

        /// <inheritdoc/>
        public GNFieldDataType gnFieldType { get; set; }

        /// <inheritdoc/>
        public object defaultValue { get; set; }

        /// <inheritdoc/>
        public bool activeConditionValid { get; set; }

        /// <inheritdoc/>
        public bool? mustNonNull { get; set; }

        /// <inheritdoc/>
        public int? minLength { get; set; }

        /// <inheritdoc/>
        public int? maxLength { get; set; }

        /// <inheritdoc/>
        public double? minValue { get; set; }

        /// <inheritdoc/>
        public double? maxValue { get; set; }

        /// <inheritdoc/>
        public bool? mustInt { get; set; }

        /// <inheritdoc/>
        public string name { get; }

        /// <inheritdoc/>
        public FieldDataType fieldType { get; }

        /// <inheritdoc/>
        public Type cls { get; }

        /// <inheritdoc/>
        public FieldInfo fieldInfo { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GNEnhancedObjectFieldMetadata"/> class.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="fieldType">The type of data stored in the field.</param>
        /// <param name="cls">The class type associated with the field.</param>
        /// <param name="fieldInfo">The reflection field information for the field.</param>
        public GNEnhancedObjectFieldMetadata(string name, FieldDataType fieldType, Type cls, FieldInfo fieldInfo)
        {
            this.name = name;
            this.fieldType = fieldType;
            this.cls = cls;
            this.fieldInfo = fieldInfo;
        }
    }

    /// <summary>
    /// Enumeration of GN field data types.
    /// </summary>
    public enum GNFieldDataType
    {
        /// <summary>
        /// Represents an undefined or other data type.
        /// </summary>
        Other = 0,

        /// <summary>
        /// Represents numeric data types (e.g., int, float, double).
        /// </summary>
        Number = 1,

        /// <summary>
        /// Represents string data types.
        /// </summary>
        String = 2,

        /// <summary>
        /// Represents boolean data types.
        /// </summary>
        Boolean = 3,

        /// <summary>
        /// Represents GNHashtable data types.
        /// </summary>
        GNHashtable = 4,

        /// <summary>
        /// Represents GNArray data types.
        /// </summary>
        GNArray = 5,
    }

    /// <summary>
    /// Base attribute for data member fields with optional metadata.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public class DataMemberAttribute : Attribute
    {
        /// <summary>
        /// Gets the field data type, defaults to Other.
        /// </summary>
        public virtual GNFieldDataType gnFieldType => GNFieldDataType.Other;

        /// <summary>
        /// Gets or sets the code associated with the field.
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// Gets or sets whether the field is optional. Default is false.
        /// </summary>
        public bool isOptional { get; set; } = false;

        /// <summary>
        /// Gets or sets the default value for the field.
        /// </summary>
        public object defaultValue { get; set; } = null;
    }

    /// <summary>
    /// Attribute for string data member fields with additional constraints.
    /// </summary>
    public class StringDataMemberAttribute : DataMemberAttribute
    {
        /// <summary>
        /// Overrides the field data type to String.
        /// </summary>
        public override GNFieldDataType gnFieldType => GNFieldDataType.String;

        /// <summary>
        /// Gets or sets the default value for the string field.
        /// </summary>
        public new string defaultValue { get; set; }

        /// <summary>
        /// Gets or sets whether the string must be non-null. Default is false.
        /// </summary>
        public bool mustNonNull { get; set; } = false;

        /// <summary>
        /// Gets or sets the minimum length for the string. Default is -1 (no constraint).
        /// </summary>
        public int minLength { get; set; } = -1;

        /// <summary>
        /// Gets or sets the maximum length for the string. Default is -1 (no constraint).
        /// </summary>
        public int maxLength { get; set; } = -1;
    }

    /// <summary>
    /// Attribute for boolean data member fields with additional constraints.
    /// </summary>
    public class BooleanDataMemberAttribute : DataMemberAttribute
    {
        /// <summary>
        /// Overrides the field data type to Boolean.
        /// </summary>
        public override GNFieldDataType gnFieldType => GNFieldDataType.Boolean;

        /// <summary>
        /// Gets or sets the default value for the boolean field. Default is false.
        /// </summary>
        public new bool defaultValue { get; set; } = false;
    }

    /// <summary>
    /// Attribute for GNHashtable data member fields with additional constraints.
    /// </summary>
    public class GNHashtableDataMemberAttribute : DataMemberAttribute
    {
        /// <summary>
        /// Overrides the field data type to GNHashtable.
        /// </summary>
        public override GNFieldDataType gnFieldType => GNFieldDataType.GNHashtable;

        /// <summary>
        /// Gets or sets the default value for the GNHashtable field.
        /// </summary>
        public new GNHashtable defaultValue { get; set; } = null;

        /// <summary>
        /// Gets or sets whether the GNHashtable must be non-null. Default is false.
        /// </summary>
        public bool mustNonNull { get; set; } = false;

        /// <summary>
        /// Gets or sets the minimum length for the GNHashtable. Default is -1 (no constraint).
        /// </summary>
        public int minLength { get; set; } = -1;

        /// <summary>
        /// Gets or sets the maximum length for the GNHashtable. Default is -1 (no constraint).
        /// </summary>
        public int maxLength { get; set; } = -1;
    }

    /// <summary>
    /// Attribute for GNArray data member fields with additional constraints.
    /// </summary>
    public class GNArrayDataMemberAttribute : DataMemberAttribute
    {
        /// <summary>
        /// Overrides the field data type to GNArray.
        /// </summary>
        public override GNFieldDataType gnFieldType => GNFieldDataType.GNArray;

        /// <summary>
        /// Gets or sets the default value for the GNArray field.
        /// </summary>
        public new GNArray defaultValue { get; set; } = null;

        /// <summary>
        /// Gets or sets whether the GNArray must be non-null. Default is false.
        /// </summary>
        public bool mustNonNull { get; set; } = false;

        /// <summary>
        /// Gets or sets the minimum length for the GNArray. Default is -1 (no constraint).
        /// </summary>
        public int minLength { get; set; } = -1;

        /// <summary>
        /// Gets or sets the maximum length for the GNArray. Default is -1 (no constraint).
        /// </summary>
        public int maxLength { get; set; } = -1;

        /// <summary>
        /// Gets or sets the type of elements in the GNArray.
        /// </summary>
        public Type elementCls { get; set; } = null;
    }

    /// <summary>
    /// Attribute for numeric data member fields with additional constraints.
    /// </summary>
    public class NumberDataMemberAttribute : DataMemberAttribute
    {
        /// <summary>
        /// Overrides the field data type to Number.
        /// </summary>
        public override GNFieldDataType gnFieldType => GNFieldDataType.Number;

        /// <summary>
        /// Gets or sets the default value for the numeric field.
        /// </summary>
        public new double defaultValue { get; set; }

        /// <summary>
        /// Gets or sets the minimum value for the numeric field. Default is -1 (no constraint).
        /// </summary>
        public double minValue { get; set; } = -1;

        /// <summary>
        /// Gets or sets the maximum value for the numeric field. Default is -1 (no constraint).
        /// </summary>
        public double maxValue { get; set; } = -1;

        /// <summary>
        /// Gets or sets whether the numeric field must be an integer. Default is false.
        /// </summary>
        public bool mustInt { get; set; } = false;
    }

}
