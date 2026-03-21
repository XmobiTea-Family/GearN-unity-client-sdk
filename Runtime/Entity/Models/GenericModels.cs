namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;

    /// <summary>
    /// Defines shared payload models reused across multiple GearN domains.
    /// </summary>
    public class GenericModels
    {
        /// <summary>
        /// Represents the avatar item component.
        /// </summary>
        public class AvatarItem
        {
            /// <summary>
            /// Stores the type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Type)]
            public int type;

            /// <summary>
            /// Stores the value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Value)]
            public string value;

        }

        /// <summary>
        /// Represents the tag item component.
        /// </summary>
        public class TagItem
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key)]
            public string key;

            /// <summary>
            /// Stores the value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Value)]
            public string value;

        }

        /// <summary>
        /// Represents the ban item component.
        /// </summary>
        public class BanItem
        {
            /// <summary>
            /// Stores the timestamp expire value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsExpire)]
            public long tsExpire;

            /// <summary>
            /// Stores the reason value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Reason)]
            public string reason;

        }

        /// <summary>
        /// Represents the data item component.
        /// </summary>
        public class DataItem
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key)]
            public string key;

            /// <summary>
            /// Stores the value.
            /// </summary>
            [DataMember(code = ParameterCode.Value)]
            public object value;

        }

        /// <summary>
        /// Represents the currency item component.
        /// </summary>
        public class CurrencyItem
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key)]
            public string key;

            /// <summary>
            /// Stores the value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Value)]
            public double value;

        }

        /// <summary>
        /// Represents the statistics item component.
        /// </summary>
        public class StatisticsItem
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key)]
            public string key;

            /// <summary>
            /// Stores the value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Value)]
            public double value;

        }

        /// <summary>
        /// Represents the character item component.
        /// </summary>
        public class CharacterItem
        {
            /// <summary>
            /// Stores the character ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CharacterId)]
            public string characterId;

            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId)]
            public string catalogId;

        }

        /// <summary>
        /// Represents the owner item component.
        /// </summary>
        public class OwnerItem
        {
            /// <summary>
            /// Stores the type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Type)]
            public int type;

            /// <summary>
            /// Stores the ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Id)]
            public string id;

        }

        /// <summary>
        /// Represents the remove status item component.
        /// </summary>
        public class RemoveStatusItem
        {
            /// <summary>
            /// Stores the timestamp remove value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsRemove)]
            public long tsRemove;

            /// <summary>
            /// Stores the reason value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Reason, isOptional = true)]
            public string? reason;

        }

        /// <summary>
        /// Represents the inventory item component.
        /// </summary>
        public class InventoryItem
        {
            /// <summary>
            /// Stores the item ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ItemId)]
            public string itemId;

            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId)]
            public string catalogId;

            /// <summary>
            /// Stores the class ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ClassId)]
            public string classId;

        }

        /// <summary>
        /// Represents the group item component.
        /// </summary>
        public class GroupItem
        {
            /// <summary>
            /// Stores the group ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GroupId)]
            public string groupId;

            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId)]
            public string catalogId;

            /// <summary>
            /// Stores the status value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Status)]
            public int status;

            /// <summary>
            /// Stores the timestamp last status update value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsLastStatusUpdate)]
            public long tsLastStatusUpdate;

        }

        /// <summary>
        /// Represents the friend item component.
        /// </summary>
        public class FriendItem
        {
            /// <summary>
            /// Stores the friend ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FriendId)]
            public string friendId;

            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId)]
            public string catalogId;

            /// <summary>
            /// Stores the status value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Status)]
            public int status;

            /// <summary>
            /// Stores the timestamp last status update value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsLastStatusUpdate)]
            public long tsLastStatusUpdate;

        }

        /// <summary>
        /// Represents the member item component.
        /// </summary>
        public class MemberItem
        {
            /// <summary>
            /// Stores the member ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.MemberId)]
            public string memberId;

            /// <summary>
            /// Stores the status value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Status)]
            public int status;

        }

    }

}