using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIndepth.ExpressionTrees
{
    public class ExpressionTreesTest
    {
        public static void Main(string[] args)
        {
            // lamda 
            Func<string, string> toUpper = str => str.ToUpper();
            // expression
            Expression<Func<string, string>> toUpperExp = str => str.ToUpper();


            var prm = Expression.Parameter(typeof(string));
            var toUpperMethod = typeof(string).GetMethod("ToUpper", Type.EmptyTypes);
            
            Expression.Call(prm, toUpperMethod);
            

            //var list = toUpperExp.Parameters.ToList();


            //Console.WriteLine(toUpperExp.Compile()("hello world"));
            //Console.WriteLine(toUpper("hello world"));

            Console.ReadLine();           

        }
    }
}
