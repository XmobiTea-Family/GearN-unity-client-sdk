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

    public interface DataMemberBaseArgs
    {
        string code { get; set; }
        bool isOptional { get; set; }

    }

    public interface DataMemberArgs : DataMemberBaseArgs
    {
        GNFieldDataType? gnFieldType { get; }

    }

    public interface StringDataMemberArgs : DataMemberArgs
    {
        string? defaultValue { get; set; }
        bool? mustNonNull { get; set; }
        int? minLength { get; set; }
        int? maxLength { get; set; }

    }

    public interface BooleanDataMemberArgs : DataMemberArgs
    {
        bool? defaultValue { get; set; }

    }

    public interface NumberDataMemberArgs : DataMemberArgs
    {
        double? defaultValue { get; set; }
        double? minValue { get; set; }
        double? maxValue { get; set; }
        bool? mustInt { get; set; }

    }

    public interface GNHashtableDataMemberArgs : DataMemberArgs
    {
        GNHashtable? defaultValue { get; set; }
        bool? mustNonNull { get; set; }
        int? minLength { get; set; }
        int? maxLength { get; set; }
    }

    public interface GNArrayDataMemberArgs : DataMemberArgs
    {
        GNArray? defaultValue { get; set; }
        bool? mustNonNull { get; set; }
        int? minLength { get; set; }
        int? maxLength { get; set; }
        Type? elementCls { get; set; }
    }

    [AttributeUsage(AttributeTargets.Field, Inherited = true)]
    public class DataMemberAttribute : System.Attribute, DataMemberArgs
    {
        public GNFieldDataType? gnFieldType => GNFieldDataType.Other;

        public string code  { get; set; }
        public bool isOptional  { get; set; }

        public object defaultValue { get; set; }
    }

    [AttributeUsage(AttributeTargets.Field, Inherited = true)]
    public class StringDataMemberAttribute : System.Attribute, StringDataMemberArgs
    {
        public string defaultValue  { get; set; }
        public bool? mustNonNull  { get; set; }
        public int? minLength  { get; set; }
        public int? maxLength  { get; set; }

        public GNFieldDataType? gnFieldType => GNFieldDataType.String;

        public string code  { get; set; }
        public bool isOptional  { get; set; }
    }

    [AttributeUsage(AttributeTargets.Field, Inherited = true)]
    public class BooleanDataMemberAttribute : System.Attribute, BooleanDataMemberArgs
    {
        public bool? defaultValue  { get; set; }

        public GNFieldDataType? gnFieldType =>  GNFieldDataType.Boolean;

        public string code  { get; set; }
        public bool isOptional  { get; set; }
    }

    [AttributeUsage(AttributeTargets.Field, Inherited = true)]
    public class GNHashtableDataMemberAttribute : System.Attribute, GNHashtableDataMemberArgs
    {
        public GNHashtable defaultValue  { get; set; }
        public bool? mustNonNull  { get; set; }
        public int? minLength  { get; set; }
        public int? maxLength  { get; set; }

        public GNFieldDataType? gnFieldType => GNFieldDataType.GNHashtable;

        public string code  { get; set; }
        public bool isOptional  { get; set; }
    }

    [AttributeUsage(AttributeTargets.Field, Inherited = true)]
    public class GNArrayDataMemberAttribute : System.Attribute, GNArrayDataMemberArgs
    {
        public GNArray defaultValue  { get; set; }
        public bool? mustNonNull  { get; set; }
        public int? minLength  { get; set; }
        public int? maxLength  { get; set; }
        public Type elementCls  { get; set; }

        public GNFieldDataType? gnFieldType => GNFieldDataType.GNArray;

        public string code  { get; set; }
        public bool isOptional  { get; set; }
    }

    [AttributeUsage(AttributeTargets.Field, Inherited = true)]
    public class NumberDataMemberAttribute : System.Attribute, NumberDataMemberArgs
    {
        public double? defaultValue  { get; set; }
        public double? minValue  { get; set; }
        public double? maxValue  { get; set; }
        public bool? mustInt  { get; set; }

        public GNFieldDataType? gnFieldType => GNFieldDataType.Number;

        public string code { get; set; }
        public bool isOptional { get; set; }
    }
}
