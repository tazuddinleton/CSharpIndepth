namespace CS.Interfaces;

class MyClass : IMyInterface<string>
{
    public IEnumerable<string> Get()
    {
        return new List<string>();
    }

    public ICollection<string> Get(int take, int skip)
    {
        return new List<string>().Skip(skip).Take(take).ToList();
    }
}