using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NullObject.ThroughInheritance
{
    public class NullPerson
    {
        public int Id
        { get { return -1; } }
        public string FirstName 
        {
            get { return ""; }             
        }
        public string LastName 
        {
            get { return ""; }
        }

        public NullPerson() { }
    }
}
