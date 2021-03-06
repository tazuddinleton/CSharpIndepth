﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NullObject.ThroughInheritance
{
    public class Person : NullPerson
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public Person(int id, string fname, string lname)
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
        }

        public Person()
        {
        }
    }
}
