using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NullObject.ThroughInheritance
{
    public class PersonView
    {
        public PersonView()
        {            
        }
        public void Render(NullPerson person)
        {
            Console.WriteLine($"FirstName : {person.FirstName}, LastName: {person.LastName}");
        }
    }
}
