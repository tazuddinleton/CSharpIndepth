using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NullObject.ThroughInterface
{
    public class NullPerson : IPerson
    {
        public int Id => -1;

        public string FirstName => "Default";

        public string LastName => "Person";
    }
}
