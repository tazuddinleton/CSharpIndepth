using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities
{
    public class LineItem
    {
        public Item Item { get; }
        public int Quantity { get; }

        public LineItem(Item item, int qty)
        {
            Item = item;
            Quantity = qty;
        }
    }
}
