using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIndepth.Indexers
{
    class TestIndexers
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student(1, "Student 1", 100);

            s1[0] = "Math";
            s1[2] = "Physics";

            Console.WriteLine(s1[0]);
            Console.WriteLine(s1[111]);
        }
    }
}
