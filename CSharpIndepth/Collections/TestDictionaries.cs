using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIndepth.Collections
{
    public static class TestDictionaries
    {
        public static void Main(string[] args)
        {
            List<Item> items = GetItems();
            
            var group = new ItemGroup<long, Item>(items, item => item.Id);            

            var groupH = group.ToDictionary();

            Console.ReadKey();
        }



        private static List<Item> GetItems()
        {
            return new List<Item>(){
            new Item() { Id = 1, Name = "Item1", Amount = 10 },
            new Item() { Id = 2,  Name = "Item2", Amount = 10 },
            new Item() { Id = 1, Name = "Item1", Amount = 10 },
            new Item() { Id = 2, Name = "Item2", Amount = 10 } };
        }
    }
}
