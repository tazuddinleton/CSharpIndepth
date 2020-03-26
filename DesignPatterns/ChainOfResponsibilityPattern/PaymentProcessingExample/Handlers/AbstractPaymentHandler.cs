using DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities;
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
            Next?.Handle(request);
        }

        public IHandler<Order> SetNext(IHandler<Order> next)
        {
            return Next = next;
        }
    }
}
