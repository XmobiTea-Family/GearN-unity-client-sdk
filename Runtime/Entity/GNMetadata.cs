namespace XmobiTea.GN.Entity
{
    using System;

    public enum FieldDataType
    {
        Boolean = 0,
        Number = 1,
        String = 2,
        Array = 3,
        Object = 4,
    }

    public interface GNObjectFieldMetadata
    {
        string name { get; }
        FieldDataType fieldType { get; }
        Type cls { get; }
    }

    public interface GNObjectMetadata
    {
        string id { get; }
        GNObjectFieldMetadata[] fields { get; }
    }

}
