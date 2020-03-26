﻿using DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities;
using DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Handlers
{
    public class InvoicePaymentHandler : AbstractPaymentHandler
    {
        public override void Handle(Order request)
        {
            Console.WriteLine("Now Processing: " + GetType().Name);
            var payment = request.SelectedPayments.Get(PaymentProvider.Invoice);
            // TODO: payment verification 
            request.ConfirmPayment(payment);
            try
            {
                base.Handle(request);
            }
            catch (InsufficientPaymentException ex)
            {
                request.CancelPayment(payment);
                throw ex;
            }
        }
    }
}