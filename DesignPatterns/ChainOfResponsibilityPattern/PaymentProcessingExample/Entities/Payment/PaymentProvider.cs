using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities
{
    public enum PaymentProvider
    {
        Paypal = 1,
        CreditCard,
        Invoice
    }
}
