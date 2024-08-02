using System.Linq.Expressions;

namespace CS.ExpressionTrees;

public class Program
{
    public static void Main(string[] args)
    {
        // lamda 
        Func<string, string> toUpper = str => str.ToUpper();
        // expression
        Expression<Func<string, string>> toUpperExp = str => str.ToUpper();
            
        // lamda and expression are syntactially same
        // only difference is the way it is declared
        // lamdas do thing
        // expressions describe the lamda that does the thing


        var prm = Expression.Parameter(typeof(string));
        var toUpperMethod = typeof(string).GetMethod("ToUpper", Type.EmptyTypes);
            
        Expression.Call(prm, toUpperMethod);
            

        //var list = toUpperExp.Parameters.ToList();


        //Console.WriteLine(toUpperExp.Compile()("hello world"));
        //Console.WriteLine(toUpper("hello world"));

        Console.ReadLine();           

    }
}