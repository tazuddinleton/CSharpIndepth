using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIndepth.Class
{


    class MethodOverload
    {

        private static string _name = "My name is foo";
        public string GetName()
        {
            return _name;
        }

        public string GetName(string name)
        {
            return _name + " "+ name;
        }
        public string GetName(string fname, string lname)
        {
            return fname + " " + lname;
        }

        public string GetName(int fname, int lname)
        {
            return fname + " " + lname;
        }

        public string GetName(string lname, string fname, int count)
        {
            return fname + " " + lname;
        }

        public string GetName(int count, string lname, string fname)
        {
            return fname + " " + lname;
        }
    }


    static class TestOverLoad
    {
        
        static void Main(string[] args)
        { 
        
        }
    }
}
