using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIndepth.Delegates
{
    public class TestDelegate
    {
        static double Square(double x)
        {
            return x * x;
        }
        static double[] Apply(double[] a, Function f)
        {
            double[] result = new double[a.Length];
            for (int i = 0; i < a.Length; i++) result[i] = f(a[i]);
            return result;
        }
        static void Main(string[] args)
        {
            double[] a = { 0.0, 0.5, 1.0 };
            double[] square = Apply(a, Square);
            double[] sines = Apply(a, Math.Sin);
            Multiplier multiplier = new Multiplier(2.0);
            double[] doubles = Apply(a, multiplier.Multiply);
            double[] triples = Apply(a, (double x) => x * 3);
        }
    }
}
