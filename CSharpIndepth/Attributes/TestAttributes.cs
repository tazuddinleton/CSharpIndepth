using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIndepth.Attributes
{
    class TestAttributes
    {
        public static void Main(string[] args)
        {
            var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.GetCustomAttributes<VendorInfoAttribute>().Count() > 0
                        select t;

            foreach (var type in types)
            {
                Console.WriteLine(type.Name);
                var atts = type.GetCustomAttributes<VendorInfoAttribute>();

                foreach (var att in atts)
                {
                    Console.WriteLine(att.CompanyName);
                    Console.WriteLine(att.ProductVersion);
                }
            }

        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class VendorInfoAttribute : Attribute
    {
        public string CompanyName { get; set; }
        public int ProductVersion { get; set; }
    }
    
    [VendorInfo(CompanyName ="Adobe Corp", ProductVersion = 11)]
    public class PhotoEditor
    {
        public int MyProperty { get; set; }

        private void PrivateMethod()
        {
            Console.WriteLine("Photo editor private method");
        }

        public void PublicMethod()
        {
            Console.WriteLine("HELLO FROM Photo editor public method");
        }
    }

    [VendorInfo(CompanyName ="Mozilla", ProductVersion =38)]
    public class WebBrowser
    {

    }
}
