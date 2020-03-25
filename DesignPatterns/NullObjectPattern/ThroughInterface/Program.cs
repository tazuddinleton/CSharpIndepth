using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NullObject.ThroughInterface
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            IPersonRepository personRepository = new PersonRepository();
            var person = personRepository.GetPerson(1);
            var person2 = personRepository.GetPerson(2);
            var person3 = personRepository.GetPerson(3);

            PersonView view = new PersonView();
            view.Render(person);
            view.Render(person2);
            view.Render(person3);

            Console.ReadKey();
        }
    }
}
