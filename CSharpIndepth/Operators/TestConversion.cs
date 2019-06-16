using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIndepth
{
    
    class TestConversion
    {
        static void Main(string[] args)
        {            
            try
            {
                Digit digit = new Digit(3);
                byte b = digit; // implicit conversion

                Digit d = (Digit)b; // explicit conversion
                digit = new Digit(30);
            }            
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception occured.", ex);
            }
        }
    }
}
