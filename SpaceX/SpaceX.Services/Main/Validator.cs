using System.Collections.Generic;
using System;

namespace SpaceX.Services.Main
{
    public static class Validator
    {
        /// <summary>
        /// Checks collections for an empty result
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns>No object or value is returned by this method when it completes.</returns>
        public static void CheckCollection<T>(this ICollection<T> collection)
        {
            if (collection.Count == 0)
            {
                throw new ArgumentNullException("Collections count is null");
            }
        }

        /// <summary>
        /// Testing for null before converting an object to a string
        /// </summary>
        /// <param name="value">Object value</param>
        /// <param name="message">String message for displaying to the user</param>
        /// <returns></returns>
        public static string EmptyIfNull(this object value, string message)
        {
            if (value == null)
            {
                return message;
            }

            return value.ToString();
        }
    }
}
