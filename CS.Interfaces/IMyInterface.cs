namespace CS.Interfaces;

interface IMyInterface<T>
{
    IEnumerable<T> Get();
    ICollection<T> Get(int take, int skip);
}