using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIndepth
{
    public delegate void LogText();    
    public class TestEvents
    {
        static void LogMello()
        {
            Console.WriteLine("Hey Mello!");
        }

        static event LogText Click;
        static void Main(string[] args)
        {
            Click += () => Console.WriteLine("Hello L");
            Click += () => Console.WriteLine("Hello KIRA");
            Click += LogMello;
            Click.Invoke();

            MyCollection<string> names = new MyCollection<string>();            
            names.OnItemAdded(name => {
                Console.WriteLine("You have added a name: " + name);
            });
            names.Add("Haruhi Suzumiya");
            names.Add("Hero Hamada");            
            
        }        
    }
}
