using DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities;
using DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Exceptions;
using DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample
{
    static class  Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            order.LineItems.Add(new Item("Item1", "Desc 1", 499), 2);
            order.LineItems.Add(new Item("Item2", "Desc 2", 1799), 2);

            order.SelectedPayments.Add(new Payment(PaymentProvider.Paypal, 1000));
            order.SelectedPayments.Add(new Payment(PaymentProvider.CreditCard, 1797));

            Console.WriteLine(order.AmountDue);
            Console.WriteLine(order.ShippingStatus.ToString());

            try
            {
                var handler = new PaypalPaymentHandler();
                handler.SetNext(new CreditCardPaymentHandler())
                       .SetNext(new InvoicePaymentHandler());
                handler.Handle(order);
            }
            catch (InsufficientPaymentException ex)
            {
                
            }

            Console.WriteLine(order.AmountDue);
            Console.WriteLine(order.ShippingStatus.ToString());
        }
    }
}
