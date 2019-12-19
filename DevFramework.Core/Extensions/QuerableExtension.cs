using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFramework.Core.Infrastructure.Extensions
{
    public static class QuerableExtension
    {
        public static IQueryable<T> GetFilterQuery<T>(this IQueryable<T> query, string filter)
        {
            var opList = new List<string>() { "<", ">", "<=", ">=", "=", "<>" };
            // Filtering
            //if (filter != null)
            //{
            //    foreach (var f in filter)
            //    {
            //        if (f.Property == null || f.Value == null) continue;
            //        try
            //        {
            //            // getting property type with reflection
            //            System.Reflection.PropertyInfo propertyInfo = typeof(T).GetProperty(f.Property);

            //            f.Value = f.Value.Trim();

            //            if (string.IsNullOrEmpty(f.Value))
            //                continue;

            //            string filterOperation = "=";
            //            foreach (string op in opList)
            //            {
            //                // TODO: valid operation ( ex: => : >= ) 
            //                if (f.Value.StartsWith(op))
            //                {
            //                    filterOperation = op;
            //                    f.Value = f.Value.Replace(filterOperation, "");
            //                    break;
            //                }
            //            }
            //            if (propertyInfo.PropertyType == typeof(decimal) || propertyInfo.PropertyType == typeof(decimal?) ||
            //                propertyInfo.PropertyType == typeof(byte) || propertyInfo.PropertyType == typeof(byte?) ||
            //                propertyInfo.PropertyType == typeof(int) || propertyInfo.PropertyType == typeof(int?) ||
            //                propertyInfo.PropertyType == typeof(long) || propertyInfo.PropertyType == typeof(long?) ||
            //                propertyInfo.PropertyType == typeof(double) || propertyInfo.PropertyType == typeof(double?))
            //            {
            //                query = query.AsQueryable().Where(f.Property + filterOperation + f.Value);
            //            }
            //            else if (propertyInfo.PropertyType.IsEnum)
            //            {
            //                query = query.AsQueryable().Where(f.Property + filterOperation + string.Format("\"{0}\"", f.Value));
            //            }
            //            else if (propertyInfo.PropertyType == typeof(bool) || propertyInfo.PropertyType == typeof(bool?))
            //            {
            //                query = query.AsQueryable().Where(f.Property + "==" + f.Value);
            //            }
            //            else if (propertyInfo.PropertyType == typeof(DateTime) || propertyInfo.PropertyType == typeof(DateTime?))
            //            {
            //                DateTime date;
            //                var parsedDateTime = DateTime.Parse(f.Value);

            //                if (DateTime.TryParse(f.Value, out date))
            //                {
            //                    if (date.Hour == 0 && date.Minute == 0 && date.Second == 0 && date.Millisecond == 0)
            //                    {
            //                        query = (query.AsQueryable())
            //                            .Where(f.Property + ">= (@0)", parsedDateTime)
            //                            .Where(f.Property + "< (@0)", parsedDateTime.AddDays(1));
            //                    }
            //                    else
            //                    {
            //                        query = (query.AsQueryable())
            //                            .Where(f.Property + "== (@0)", parsedDateTime);
            //                    }
            //                }
            //            }
            //            else if (propertyInfo.PropertyType == typeof(string))
            //            {
            //                query = (query.AsQueryable()).Where(f.Property + ".Contains(@0)", f.Value);
            //            }
            //        }
            //        catch //(Exception ex)
            //        {
            //            // TODO: when we catch a filed that is not in the model fields
            //        }
            //    }
            //}

            return query;
        }
    }
}
