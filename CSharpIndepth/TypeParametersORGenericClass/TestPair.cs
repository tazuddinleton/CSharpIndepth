using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIndepth
{
    public class TestPair
    {
        static void Main(string[] args)
        {
            List<Pair<string, int>> list = new List<Pair<string, int>>();

            list.Add(new Pair<string, int>("first_arrival", 100));
            list.Add(new Pair<string, int>("second_arrival", 200));


            List<Pair<int, object>> objPairs = new List<Pair<int, object>>();
            objPairs.Add(new Pair<int, object>(1, new object()));
            objPairs.Add(new Pair<int, object>(2, new object()));

        }
    }
}
