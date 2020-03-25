using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIndepth.Interface
{

    interface MyInterface<T>
    {
        IEnumerable<T> Get();
        ICollection<T> Get(int take, int skip);
    }


    class MyClass : MyInterface<string>
    {
        public IEnumerable<string> Get()
        {
            return new List<string>();
        }

        public ICollection<string> Get(int take, int skip)
        {
            return new List<string>().Skip(skip).Take(take).ToList();
        }
    }

    class TestInterface
    {

    }
}
