using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User(
                    "Bob", "99-xx-22-yy", 
                    new RegionInfo("BD"), 
                    new DateTimeOffset(1980, 01, 01, 00, 00, 00, TimeSpan.FromHours(1))
                    );

            var processor = new UserProcessor();
            var result = processor.Register(user);
            Console.WriteLine(result);
            Console.ReadKey(); 
        }
    }
}
