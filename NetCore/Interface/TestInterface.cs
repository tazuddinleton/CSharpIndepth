using System;
using System.Collections.Generic;

namespace NetCore
{
    /*
     Interface can have private members but have to have a default implementation
         */
    interface MyInterface<T>
    {
        IEnumerable<T> Get();
        private ICollection<T> Get(int take, int skip)
        {
            return new List<T>();
        }
    }

    class MyClass : MyInterface<string>
    {
        

        public IEnumerable<string> Get()
        {
            throw new NotImplementedException();
        }
    }

    class TestInterface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
