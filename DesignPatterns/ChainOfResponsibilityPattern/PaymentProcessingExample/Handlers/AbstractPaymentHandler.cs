using DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities;
using DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Handlers
{
    public class AbstractPaymentHandler : IHandler<Order>
    {
        private IHandler<Order> Next { get; set; }
        public virtual void Handle(Order request)
        {
            if (Next == null && request.AmountDue > 0)
                throw new InsufficientPaymentException();
            if (request.AmountDue > 0)
                Next.Handle(request);
        }

        public IHandler<Order> SetNext(IHandler<Order> next)
        {
            return Next = next;
        }
    }
}
