namespace XmobiTea.GearN.Entity
{
    /// <summary>
    /// Enum representing the various data types for object fields.
    /// </summary>
    public enum FieldDataType
    {
        /// <summary>
        /// Boolean data type.
        /// </summary>
        Boolean = 0,

        /// <summary>
        /// Numeric data type.
        /// </summary>
        Number = 1,

        /// <summary>
        /// String data type.
        /// </summary>
        String = 2,

        /// <summary>
        /// Array data type.
        /// </summary>
        Array = 3,

        /// <summary>
        /// Object data type.
        /// </summary>
        Object = 4,
    }

    /// <summary>
    /// Metadata describing a field in a GN object.
    /// </summary>
    public interface GNObjectFieldMetadata
    {
        /// <summary>
        /// Gets the name of the field.
        /// </summary>
        string name { get; }

        /// <summary>
        /// Gets the type of the field.
        /// </summary>
        FieldDataType fieldType { get; }

        /// <summary>
        /// Gets the class type of the field, if applicable.
        /// </summary>
        System.Type cls { get; }
    }

    /// <summary>
    /// Metadata describing a GN object.
    /// </summary>
    public interface GNObjectMetadata
    {
        /// <summary>
        /// Gets the unique identifier for the GN object.
        /// </summary>
        string id { get; }

        /// <summary>
        /// Gets an array of field metadata for the GN object.
        /// </summary>
        GNObjectFieldMetadata[] fields { get; }
    }
}
