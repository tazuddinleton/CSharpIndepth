using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities
{
    public class Item
    {
        public string Name { get; }
        public string Description { get; }
        public decimal Price { get; }

        public Item(string name, string desc, decimal price)
        {
            Name = name;
            Description = desc;
            Price = price;
        }
    }
}
