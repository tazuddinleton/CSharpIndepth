using System;
using System.Globalization;

namespace DesignPatterns.ChainOfResponsibilityPattern
{
    public class User
    {
        public string Name { get; }
        public string SSN { get; }
        public RegionInfo Region { get; }        
        public int Age {get;}

        public User(string name, string ssn, RegionInfo region, DateTimeOffset offset)
        {
            Name = name;
            SSN = ssn;
            Region = region;
            Age = offset.Year;

        }
    }
}