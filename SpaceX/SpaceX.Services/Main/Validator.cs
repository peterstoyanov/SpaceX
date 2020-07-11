using System.Collections.Generic;
using System;

namespace SpaceX.Services.Main
{
    public static class Validator
    {
        public static void CheckCollection<T>(this ICollection<T> collection)
        {
            if (collection.Count == 0)
            {
                throw new ArgumentNullException("Collections count is null");
            }
        }

        public static string EmptyIfNull(this object value, string message)
        {
            if (value == null)
                return message;
            return value.ToString();
        }
    }
}
