using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DevFramework.Core.Utils
{
    public static class EnumUtil<T>
    {
        public static List<EnumList> GetList()
        {
            var array = (T[])(System.Enum.GetValues(typeof(T)).Cast<T>());
            return array.Select(a => new EnumList
            {
                Title = GetDisplayValue(a),
                Value = Convert.ToInt32(a),

            }).ToList();
        }

        public static string GetDisplayValue(T value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            var descriptionAttributes = fieldInfo.GetCustomAttributes(
                typeof(DisplayAttribute), false) as DisplayAttribute[];

            if (descriptionAttributes == null) return string.Empty;
            return (descriptionAttributes.Length > 0) ? descriptionAttributes[0].Name : value.ToString();
        }
    }

    public class EnumList
    {
        public string Title { get; set; }
        public int Value { get; set; }
    }
}
