using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities
{
    public class Payment : IPayment
    {
        public PaymentProvider Provider { get; }
        public decimal Amount { get; }

        public Payment(PaymentProvider provider, decimal amount)
        {
            Provider = provider;
            Amount = amount;
        }
    }
}
