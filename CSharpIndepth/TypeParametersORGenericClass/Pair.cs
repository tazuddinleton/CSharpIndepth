using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIndepth
{
    public class Pair <Tkey, Tvalue>
    {
        public Tkey Key;
        public Tvalue Value;
        public Pair(Tkey key, Tvalue value)
        {
            this.Key = key;
            this.Value = value;
        }        
    }
}
