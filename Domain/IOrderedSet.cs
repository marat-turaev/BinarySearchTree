﻿using System;
using System.Collections.Generic;

namespace Domain {
    internal interface IOrderedSet<TKey, TValue> where TKey : IComparable<TKey> {
        TValue this[TKey key] { get; }
        TValue Minimum { get; }
        TValue Maximum { get; }
        void Delete(TKey key);
        void Insert(KeyValue<TKey, TValue> value);
        TValue Predecessor(TKey key);
        TValue Successor(TKey key);
        IEnumerable<TValue> Sort();
    }
}