using System;
using System.Collections.Generic;

namespace Common {
    public static class EnumerableExtentions {
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> enumerable, Action<T> action) {
            foreach (var item in enumerable) {
                action(item);
            }
            return enumerable;
        }
    }
}