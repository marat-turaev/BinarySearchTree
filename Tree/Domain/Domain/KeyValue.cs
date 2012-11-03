﻿namespace Domain {
    public class KeyValue<TKey, TValue> {
        public KeyValue(TKey key, TValue value) {
            Key = key;
            Value = value;
        }

        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
}