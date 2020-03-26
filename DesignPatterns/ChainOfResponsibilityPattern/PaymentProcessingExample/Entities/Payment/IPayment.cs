using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities
{
    public interface IPayment
    {
        decimal Amount { get; }
        PaymentProvider Provider { get; }
    }
}
