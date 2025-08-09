namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;

    public class GenericModels
    {
        public class AvatarItem
        {
            [NumberDataMember(code = ParameterCode.Type)]
            public int type;

            [StringDataMember(code = ParameterCode.Value)]
            public string value;

        }

        public class TagItem
        {
            [StringDataMember(code = ParameterCode.Key)]
            public string key;

            [StringDataMember(code = ParameterCode.Value)]
            public string value;

        }

        public class BanItem
        {
            [NumberDataMember(code = ParameterCode.TsExpire)]
            public long tsExpire;

            [StringDataMember(code = ParameterCode.Reason)]
            public string reason;

        }

        public class DataItem
        {
            [StringDataMember(code = ParameterCode.Key)]
            public string key;

            [DataMember(code = ParameterCode.Value)]
            public object value;

        }

        public class CurrencyItem
        {
            [StringDataMember(code = ParameterCode.Key)]
            public string key;

            [NumberDataMember(code = ParameterCode.Value)]
            public double value;

        }

        public class StatisticsItem
        {
            [StringDataMember(code = ParameterCode.Key)]
            public string key;

            [NumberDataMember(code = ParameterCode.Value)]
            public double value;

        }

        public class CharacterItem
        {
            [StringDataMember(code = ParameterCode.CharacterId)]
            public string characterId;

            [StringDataMember(code = ParameterCode.CatalogId)]
            public string catalogId;

        }

        public class OwnerItem
        {
            [NumberDataMember(code = ParameterCode.Type)]
            public int type;

            [StringDataMember(code = ParameterCode.Id)]
            public string id;

        }

        public class RemoveStatusItem
        {
            [NumberDataMember(code = ParameterCode.TsRemove)]
            public long tsRemove;

            [StringDataMember(code = ParameterCode.Reason, isOptional = true)]
            public string? reason;

        }

        public class InventoryItem
        {
            [StringDataMember(code = ParameterCode.ItemId)]
            public string itemId;

            [StringDataMember(code = ParameterCode.CatalogId)]
            public string catalogId;

            [StringDataMember(code = ParameterCode.ClassId)]
            public string classId;

        }

        public class GroupItem
        {
            [StringDataMember(code = ParameterCode.GroupId)]
            public string groupId;

            [StringDataMember(code = ParameterCode.CatalogId)]
            public string catalogId;

            [NumberDataMember(code = ParameterCode.Status)]
            public int status;

            [NumberDataMember(code = ParameterCode.TsLastStatusUpdate)]
            public long tsLastStatusUpdate;

        }

        public class FriendItem
        {
            [StringDataMember(code = ParameterCode.FriendId)]
            public string friendId;

            [StringDataMember(code = ParameterCode.CatalogId)]
            public string catalogId;

            [NumberDataMember(code = ParameterCode.Status)]
            public int status;

            [NumberDataMember(code = ParameterCode.TsLastStatusUpdate)]
            public long tsLastStatusUpdate;

        }

        public class MemberItem
        {
            [StringDataMember(code = ParameterCode.MemberId)]
            public string memberId;

            [NumberDataMember(code = ParameterCode.Status)]
            public int status;

        }

    }

}
