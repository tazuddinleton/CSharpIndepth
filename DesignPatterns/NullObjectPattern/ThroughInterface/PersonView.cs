using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NullObject.ThroughInterface
{
    public class PersonView
    {
        public PersonView()
        {
            
        }
        public void Render(IPerson person)
        {
            Console.WriteLine($"FirstName : {person.FirstName}, LastName: {person.LastName}");
        }
    }
}
