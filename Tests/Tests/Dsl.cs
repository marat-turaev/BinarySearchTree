using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Tests {
    public static class DSL {
        public static KeyValue<T, T> AsKeyValue<T>(this T value) {
            return new KeyValue<T, T>(value, value);
        }

        public static IEnumerable<KeyValue<T, T>> AsKeyValueList<T>(this IEnumerable<T> enumerable) {
            return
                from item in enumerable
                select new KeyValue<T, T>(item, item);
        }
    }
}