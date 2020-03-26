using DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.PaymentProcessors
{
    public interface IPaymentProcessor
    {
        void FinalizePayment(Order order);
        void CancelPayment(Order order);
    }
}  
