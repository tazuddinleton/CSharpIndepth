using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NullObject.ThroughInterface
{
    public interface IPerson
    {
        int Id { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}
