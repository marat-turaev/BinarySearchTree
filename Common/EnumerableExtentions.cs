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

    public static class ObjectExtentions {
        public static T Try<T>(this T t, Action<T> action) where T : class {
            if (t != null) {
                action(t);
            }
            return t;
        }
    }
}