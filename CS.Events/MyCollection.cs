using System.Collections;

namespace CS.Events;

public class MyCollection<T> : IEnumerable<T>
{
    readonly List<T> _collection = new List<T>();
        
    private event Action<T> ItemAdded;

    public void Add(T item)
    {
        _collection.Add(item);
        ItemAdded?.Invoke(item);
    }
        
    public void OnItemAdded(Action<T> onItemAdded)
    {
        ItemAdded += onItemAdded;
    }
    public IEnumerator<T> GetEnumerator()
    {
        return _collection.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}