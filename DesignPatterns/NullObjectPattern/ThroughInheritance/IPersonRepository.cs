namespace DesignPatterns.NullObject.ThroughInheritance
{
    public interface IPersonRepository
    {
        NullPerson GetPerson(int id);
    }
}