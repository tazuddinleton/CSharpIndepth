using DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities;
using DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Exceptions;
using DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.PaymentProcessors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Handlers
{
    public class CreditCardPaymentHandler : AbstractPaymentHandler
    {

        private readonly IPaymentProcessor processor = new CreditCardPaymentProcessor();
        public override void Handle(Order request)
        {
            Console.WriteLine("Now Processing: " + GetType().Name);
            processor.FinalizePayment(request);                        
            try
            {
                base.Handle(request);
            }
            catch (InsufficientPaymentException ex)
            {
                processor.CancelPayment(request);
                throw ex;
            }
        }
    }
}
