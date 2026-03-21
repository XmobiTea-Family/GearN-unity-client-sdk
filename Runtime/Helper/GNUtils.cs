namespace XmobiTea.GearN.Helper
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Entity.Models;

    /// <summary>
    /// Provides helper conversions for common GearN model collections.
    /// </summary>
    public static class GNUtils
    {
        /// <summary>
        /// Converts the input values to datas dictionary.
        /// </summary>
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

        /// <summary>
        /// Converts the input values to tags dictionary.
        /// </summary>
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

        /// <summary>
        /// Converts the input values to currencies dictionary.
        /// </summary>
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

        /// <summary>
        /// Converts the input values to statistics dictionary.
        /// </summary>
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

        /// <summary>
        /// Converts the input values to inventories dictionary.
        /// </summary>
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

        /// <summary>
        /// Converts the input values to group dictionary.
        /// </summary>
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

    /// <summary>
    /// Provides extension helpers for converting GearN model collections into dictionaries.
    /// </summary>
    public static class GNExtensions
    {
        /// <summary>
        /// Converts the input values to dictionary.
        /// </summary>
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

        /// <summary>
        /// Converts the input values to dictionary.
        /// </summary>
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

        /// <summary>
        /// Converts the input values to dictionary.
        /// </summary>
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

        /// <summary>
        /// Converts the input values to dictionary.
        /// </summary>
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

        /// <summary>
        /// Converts the input values to dictionary.
        /// </summary>
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

        /// <summary>
        /// Converts the input values to dictionary.
        /// </summary>
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