namespace XmobiTea.GN.Entity.Models
{
	using XmobiTea.GN.Constant;

	public class GenericModels
	{
		public class AvatarItem
		{
			[NumberDataMember(code = GNParameterCode.Type)]
			public int type;

			[StringDataMember(code = GNParameterCode.Value)]
			public string value;

		}

		public class TagItem
		{
			[StringDataMember(code = GNParameterCode.Key)]
			public string key;

			[StringDataMember(code = GNParameterCode.Value)]
			public string value;

		}

		public class BanItem
		{
			[NumberDataMember(code = GNParameterCode.TsExpire)]
			public long tsExpire;

			[StringDataMember(code = GNParameterCode.Reason)]
			public string reason;

		}

		public class DataItem
		{
			[StringDataMember(code = GNParameterCode.Key)]
			public string key;

			[DataMember(code = GNParameterCode.Value)]
			public object value;

		}

		public class CurrencyItem
		{
			[StringDataMember(code = GNParameterCode.Key)]
			public string key;

			[NumberDataMember(code = GNParameterCode.Value)]
			public double value;

		}

		public class StatisticsItem
		{
			[StringDataMember(code = GNParameterCode.Key)]
			public string key;

			[NumberDataMember(code = GNParameterCode.Value)]
			public double value;

		}

		public class OwnerItem
		{
			[NumberDataMember(code = GNParameterCode.Type)]
			public int type;

			[StringDataMember(code = GNParameterCode.Id)]
			public string id;

		}

		public class RemoveStatusItem
		{
			[NumberDataMember(code = GNParameterCode.TsRemove)]
			public long tsRemove;

			[StringDataMember(code = GNParameterCode.Reason, isOptional = true)]
			public string? reason;

		}

		public class InventoryItem
        {
			[StringDataMember(code = GNParameterCode.ItemId)]
			public string itemId;

			[StringDataMember(code = GNParameterCode.CatalogId)]
			public string catalogId;

			[StringDataMember(code = GNParameterCode.ClassId)]
			public string classId;

		}

		public class GroupItem
        {
			[StringDataMember(code = GNParameterCode.GroupId)]
			public string groupId;

			[StringDataMember(code = GNParameterCode.CatalogId)]
			public string catalogId;

			[NumberDataMember(code = GNParameterCode.Status)]
			public int status;

			[NumberDataMember(code = GNParameterCode.TsLastStatusUpdate)]
			public long tsLastStatusUpdate;

		}

		public class FriendItem
        {
			[StringDataMember(code = GNParameterCode.FriendId)]
			public string groupId;

			[StringDataMember(code = GNParameterCode.CatalogId)]
			public string catalogId;

			[NumberDataMember(code = GNParameterCode.Status)]
			public int status;

			[NumberDataMember(code = GNParameterCode.TsLastStatusUpdate)]
			public long tsLastStatusUpdate;

		}

	}

}
