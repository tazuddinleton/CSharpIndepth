using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIndepth.Class
{

    struct Point
    {
        
        public int X;
        public int Y;       
    }

    class StaticClass
    {
        static readonly long Count;
        static StaticClass()
        {
            Count = 100;
        }
    }

    class Singleton
    {

        private static Singleton _instance;
        public static int Count = 0;
        private Singleton()
        {
            Count += 1;
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
                _instance = new Singleton();
            return _instance;
        }
    }

 

    static class TestClass
    {
        static void Main(string[] args)
        {

            var s1 = Singleton.GetInstance();
            var s2 = Singleton.GetInstance();
                        
        }
    }
}
