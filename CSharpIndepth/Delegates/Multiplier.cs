using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIndepth.Delegates
{
    delegate double Function(double x);
    public class Multiplier
    {
        double factor;
        public Multiplier(double factor)
        {
            this.factor = factor;
        }
        public double Multiply(double x)
        {
            return x * factor;
        }
    }
}
