using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Gatecoin.Streaming.Common.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var fi = value.GetType().GetField(value.ToString());
            var attribute = fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false).OfType<DescriptionAttribute>().FirstOrDefault();
            return attribute != null ? attribute.Description : value.ToString();
        }

        public static bool IsOneOf<T>(this T value, T value1, T value2, params T[] otherValues)
        {
            var values = new List<T> {value1, value2};
            values.AddRange(otherValues);
            return values.Contains(value);
        }
    }
}