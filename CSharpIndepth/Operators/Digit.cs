using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIndepth
{
    public struct Digit
    {
        byte value;
        public Digit(byte val)
        {
            if (val > 9)
            {
                throw new ArgumentException();
            }
            this.value = val;
        }

        public static explicit operator Digit(byte b)
        {
            Digit d = new Digit(b);
            Console.WriteLine("Explicit Converstion occured");
            return d;
        }

        public static implicit operator byte(Digit d)
        {
            Console.WriteLine("Implicit Converstion occured");
            return d.value;
        }
    }
}
