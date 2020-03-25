using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.NullObject.ThroughInheritance
{
    public class PersonRepository : IPersonRepository
    {

        private IList<NullPerson> _people;
        public PersonRepository()
        {
            _people = new List<NullPerson>();
            _people.Add(new Person(1, "John", "Stuart"));
            _people.Add(new Person(2, "Bob", "Marley"));
        }



        public NullPerson GetPerson(int id)
        {
            var person = _people.SingleOrDefault(p => p.Id == id);
            if (person == null)
                return new NullPerson();
            return person;
        }
    }
}
