using CSharpIndepth.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIndepth.Operators
{
    
    class TestOperratorOvrloads
    {
        static void Main(string[] args)
        {            
            try
            {
                Student s1 = new Student(1, "Student 1", 50);
                Student s2 = new Student(1, "Student 1", 100);
                Student s3 = s1 + s2;
                Console.ReadLine();

            }            
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception occured.", ex);
            }
        }

        static void Conversions()
        {
            Digit digit = new Digit(3);
            byte b = digit; 

            Digit d = (Digit)b; 
            digit = new Digit(30);
        }
    }
}
