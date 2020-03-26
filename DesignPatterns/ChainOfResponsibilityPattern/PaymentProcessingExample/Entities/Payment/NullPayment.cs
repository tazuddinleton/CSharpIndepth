using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities
{
    public class NullPayment : IPayment
    {
        public decimal Amount => 0;

        public PaymentProvider Provider => 0;
    }
}
