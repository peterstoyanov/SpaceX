using System.Collections.Generic;
using System;

namespace SpaceX.Services.Utilities
{
    public static class Validator
    {
        public static void CheckCollection<T>(this ICollection<T> collection)
        {
            if (collection.Count == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
