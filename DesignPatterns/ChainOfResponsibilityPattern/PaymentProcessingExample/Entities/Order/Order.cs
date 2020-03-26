using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities
{
    public class Order
    {

        public LineItems LineItems { get; }
        public SelectedPayments SelectedPayments { get; }
        public decimal AmountDue => LineItems.TotalPrice() - TotalPaid;
        public decimal TotalPaid { get; private set; }
        public string ShippingStatus 
        {
            get 
            {
                if (AmountDue == 0)
                    return "Ready for shipment.";
                return "Waiting for payment.";
            }
        }

        public Order()
        {
            LineItems = new LineItems();
            SelectedPayments = new SelectedPayments();
        }

        

        public void AddPayment(IPayment payment)
        {
            TotalPaid += payment.Amount;
        }
    }
}
