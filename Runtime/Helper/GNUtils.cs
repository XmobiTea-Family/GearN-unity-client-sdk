namespace XmobiTea.GearN.Helper
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Entity.Models;

    public static class GNUtils
    {
        public static IDictionary<string, GenericModels.DataItem> toDatasDictionary(IList<GenericModels.DataItem> datas)
        {
            if (datas == null) return null;

            var answer = new Dictionary<string, GenericModels.DataItem>();

            for (var i = 0; i < datas.Count; i++)
            {
                var data = datas[i];

                answer.Add(data.key, data);
            }

            return answer;
        }

        public static IDictionary<string, GenericModels.TagItem> toTagsDictionary(IList<GenericModels.TagItem> tags)
        {
            if (tags == null) return null;

            var answer = new Dictionary<string, GenericModels.TagItem>();

            for (var i = 0; i < tags.Count; i++)
            {
                var tag = tags[i];

                answer.Add(tag.key, tag);
            }

            return answer;
        }

        public static IDictionary<string, GenericModels.CurrencyItem> toCurrenciesDictionary(IList<GenericModels.CurrencyItem> currencies)
        {
            if (currencies == null) return null;

            var answer = new Dictionary<string, GenericModels.CurrencyItem>();

            for (var i = 0; i < currencies.Count; i++)
            {
                var currency = currencies[i];

                answer.Add(currency.key, currency);
            }

            return answer;
        }

        public static IDictionary<string, GenericModels.StatisticsItem> toStatisticsDictionary(IList<GenericModels.StatisticsItem> statistics)
        {
            if (statistics == null) return null;

            var answer = new Dictionary<string, GenericModels.StatisticsItem>();

            for (var i = 0; i < statistics.Count; i++)
            {
                var statistic = statistics[i];

                answer.Add(statistic.key, statistic);
            }

            return answer;
        }

        public static IDictionary<string, GenericModels.InventoryItem> toInventoriesDictionary(IList<GenericModels.InventoryItem> inventories)
        {
            if (inventories == null) return null;

            var answer = new Dictionary<string, GenericModels.InventoryItem>();

            for (var i = 0; i < inventories.Count; i++)
            {
                var inventory = inventories[i];

                answer.Add(inventory.itemId, inventory);
            }

            return answer;
        }

        public static IDictionary<string, GenericModels.GroupItem> toGroupDictionary(IList<GenericModels.GroupItem> groups)
        {
            if (groups == null) return null;

            var answer = new Dictionary<string, GenericModels.GroupItem>();

            for (var i = 0; i < groups.Count; i++)
            {
                var group = groups[i];

                answer.Add(group.groupId, group);
            }

            return answer;
        }

    }

    public static class GNExtensions
    {
        public static IDictionary<string, GenericModels.DataItem> toDictionary(this IList<GenericModels.DataItem> datas)
        {
            if (datas == null) return null;

            var answer = new Dictionary<string, GenericModels.DataItem>();

            for (var i = 0; i < datas.Count; i++)
            {
                var data = datas[i];

                answer.Add(data.key, data);
            }

            return answer;
        }

        public static IDictionary<string, GenericModels.TagItem> toDictionary(this IList<GenericModels.TagItem> tags)
        {
            if (tags == null) return null;

            var answer = new Dictionary<string, GenericModels.TagItem>();

            for (var i = 0; i < tags.Count; i++)
            {
                var tag = tags[i];

                answer.Add(tag.key, tag);
            }

            return answer;
        }

        public static IDictionary<string, GenericModels.CurrencyItem> toDictionary(this IList<GenericModels.CurrencyItem> currencies)
        {
            if (currencies == null) return null;

            var answer = new Dictionary<string, GenericModels.CurrencyItem>();

            for (var i = 0; i < currencies.Count; i++)
            {
                var currency = currencies[i];

                answer.Add(currency.key, currency);
            }

            return answer;
        }

        public static IDictionary<string, GenericModels.StatisticsItem> toDictionary(this IList<GenericModels.StatisticsItem> statistics)
        {
            if (statistics == null) return null;

            var answer = new Dictionary<string, GenericModels.StatisticsItem>();

            for (var i = 0; i < statistics.Count; i++)
            {
                var statistic = statistics[i];

                answer.Add(statistic.key, statistic);
            }

            return answer;
        }

        public static IDictionary<string, GenericModels.InventoryItem> toDictionary(this IList<GenericModels.InventoryItem> inventories)
        {
            if (inventories == null) return null;

            var answer = new Dictionary<string, GenericModels.InventoryItem>();

            for (var i = 0; i < inventories.Count; i++)
            {
                var inventory = inventories[i];

                answer.Add(inventory.itemId, inventory);
            }

            return answer;
        }

        public static IDictionary<string, GenericModels.GroupItem> toDictionary(this IList<GenericModels.GroupItem> groups)
        {
            if (groups == null) return null;

            var answer = new Dictionary<string, GenericModels.GroupItem>();

            for (var i = 0; i < groups.Count; i++)
            {
                var group = groups[i];

                answer.Add(group.groupId, group);
            }

            return answer;
        }

    }

}
