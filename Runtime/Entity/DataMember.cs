using System;
using XmobiTea.GN.Common;

namespace XmobiTea.GN.Entity
{
    public interface GNEnhancedObjectFieldMetadata : GNObjectFieldMetadata
    {
        string code { get; set; }
        bool isOptional { get; set; }
        GNFieldDataType gnFieldType { get; set; }
        object defaultValue { get; set; }

        bool activeConditionValid { get; set; }

        bool? mustNonNull { get; set; }
        int? minLength { get; set; }
        int? maxLength { get; set; }
        double? minValue { get; set; }
        double? maxValue { get; set; }
        bool? mustInt { get; set; }
    }

    public enum GNFieldDataType
    {
        Other = 0,
        Number = 1,
        String = 2,
        Boolean = 3,
        GNHashtable = 4,
        GNArray = 5,

    }

    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public class DataMemberAttribute : Attribute
    {
        public virtual GNFieldDataType gnFieldType => GNFieldDataType.Other;

        public string code { get; set; }
        public bool isOptional { get; set; } = false;

        public object defaultValue { get; set; } = null;
    }

    public class StringDataMemberAttribute : DataMemberAttribute
    {
        public override GNFieldDataType gnFieldType => GNFieldDataType.String;

        public new string defaultValue { get; set; }

        public bool mustNonNull { get; set; } = false;
        public int minLength { get; set; } = -1;
        public int maxLength { get; set; } = -1;
    }

    public class BooleanDataMemberAttribute : DataMemberAttribute
    {
        public override GNFieldDataType gnFieldType => GNFieldDataType.Boolean;

        public new bool defaultValue { get; set; } = false;
    }

    public class GNHashtableDataMemberAttribute : DataMemberAttribute
    {
        public override GNFieldDataType gnFieldType => GNFieldDataType.GNHashtable;

        public new GNHashtable defaultValue { get; set; } = null;
        public bool mustNonNull { get; set; } = false;
        public int minLength { get; set; } = -1;
        public int maxLength { get; set; } = -1;
    }

    public class GNArrayDataMemberAttribute : DataMemberAttribute
    {
        public override GNFieldDataType gnFieldType => GNFieldDataType.GNArray;

        public new GNArray defaultValue { get; set; } = null;
        public bool mustNonNull { get; set; } = false;
        public int minLength { get; set; } = -1;
        public int maxLength { get; set; } = -1;
        public Type elementCls { get; set; } = null;
    }

    public class NumberDataMemberAttribute : DataMemberAttribute
    {
        public override GNFieldDataType gnFieldType => GNFieldDataType.Number;

        public new double defaultValue { get; set; }
        public double minValue { get; set; } = -1;
        public double maxValue { get; set; } = -1;
        public bool mustInt { get; set; } = false;
    }
}
