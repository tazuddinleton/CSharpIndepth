using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Exceptions
{
    public class InsufficientPaymentException : Exception
    {
        public InsufficientPaymentException(string msg) : base(msg)
        { }

        public InsufficientPaymentException()
        { }
    }
}
