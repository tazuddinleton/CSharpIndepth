using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities
{
    public class LineItems : IEnumerable<LineItem>
    {

        private List<LineItem> _lineItems;
        private decimal _totalPrice;
        
        public LineItems()
        {
            _lineItems = new List<LineItem>();
            _totalPrice = 0;
        }

        public void Add(Item item, int qty)
        {
            _lineItems.Add(new LineItem(item, qty));
            _totalPrice += item.Price * qty;
        }

        public decimal TotalPrice()
        {
            return _totalPrice;
        }

        public IEnumerator<LineItem> GetEnumerator()
        {
            return _lineItems.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
