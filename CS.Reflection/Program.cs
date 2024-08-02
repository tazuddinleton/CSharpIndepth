using System.Reflection;
using CS.Attributes;

namespace CS.Reflection;

public class Program
{
    public static void Main(string[] args)
    {
        var assembly = Assembly.GetExecutingAssembly();
        Console.WriteLine(assembly.FullName);
        var types = assembly.GetTypes()
            .Where(x => x.GetCustomAttributes<VendorInfoAttribute>().Any());
            
        foreach (var type in types)
        {
            Console.WriteLine(type.Name);

            var method = type.GetMethod("PublicMethod");
            if (method != null)
            {

                var insta = Activator.CreateInstance(type);
                method.Invoke(insta, null);
            }

            var props = type.GetProperties();
            foreach (var item in props)
            {
                Console.WriteLine("\tProperties: "+ item.Name);
            }                
        }
    }
}