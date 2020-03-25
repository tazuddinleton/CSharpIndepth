using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIndepth.Class
{

    abstract class Item
    {
        public abstract string GetName();
        public virtual string GetItemCode()
        {
            return "xx-xx-xx";
        }
        
    }

    class Pen : Item
    {
        public override string GetName()
        {
            throw new NotImplementedException();
        }

        public override sealed string GetItemCode()
        {
            return "PEN-xx-xx";
        }

    }

    class BlackPen : Pen
    {
        //public override string GetItemCode()
        //{
        //    return "BPEN-xx-xx";
        //}
    }

    static class TestInheritance
    {
        static void Main(string[] args)
        {
            var p = new Pen();
            var bp = new BlackPen();
            Console.WriteLine(p.GetItemCode());
            Console.WriteLine(bp.GetItemCode());

            Console.ReadLine();
        }
    }
}
