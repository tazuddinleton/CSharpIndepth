using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpIndepth.Collections
{
    public class ItemGroup<TKey, TValue> where TValue : class
    {
        private Dictionary<TKey, List<TValue>> _dict = new Dictionary<TKey, List<TValue>>();

        private Func<TValue, TKey> _makeKey;
               

        public ItemGroup(Func<TValue, TKey> keySelector)
        {
            _makeKey = keySelector;                     
        }

        public ItemGroup(IEnumerable<TValue> items, Func<TValue, TKey> getKey)
        {
            _makeKey = getKey;
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public void Add(TValue value)
        {
            var key = _makeKey(value);
            List<TValue> existing;
            if (!_dict.TryGetValue(key, out existing))
            {
                _dict.Add(key, new List<TValue>() { value });
            }
            else
            {
                existing.Add(value);
            }
        }

        public Dictionary<TKey, List<TValue>> ToDictionary()
        {
            return _dict;
        }
    }
}
