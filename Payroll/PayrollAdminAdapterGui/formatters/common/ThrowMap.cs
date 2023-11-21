namespace PayrollAdminAdapterGui.formatters.common
{
    public class ThrowMap<K, V>
    {
        private Dictionary<K, V> map = new Dictionary<K, V>();

        protected void Put(K key, V value)
        {
            map[key] = value;
        }

        protected V GetOrThrow(K key)
        {
            if (!map.ContainsKey(key))
                throw new KeyNotFoundException($"Key not found: {key}");
            return map[key];
        }
    }


}