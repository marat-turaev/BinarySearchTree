using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Tests.Domain {
    public static class Dsl {
        public static IEnumerable<KeyValue<TValue, TValue>> AsKeyValueList<TValue>(this IEnumerable<TValue> enumerable) {
            return
                from item in enumerable
                select new KeyValue<TValue, TValue>(item, item);
        }
    }
}