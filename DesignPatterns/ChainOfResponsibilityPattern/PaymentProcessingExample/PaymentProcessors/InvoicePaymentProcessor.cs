using DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.PaymentProcessors
{
    public class InvoicePaymentProcessor : IPaymentProcessor
    {
        public void Finalize(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
