namespace DesignPatterns.NullObject.ThroughInterface
{
    public interface IPersonRepository
    {
        IPerson GetPerson(int id);
    }
}