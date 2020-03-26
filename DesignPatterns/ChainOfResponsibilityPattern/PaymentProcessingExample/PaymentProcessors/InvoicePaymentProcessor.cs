using DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.PaymentProcessors
{
    public class InvoicePaymentProcessor : IPaymentProcessor
    {
        public void CancelPayment(Order order)
        {
            var payment = order.SelectedPayments.Get(PaymentProvider.Invoice);
            order.CancelPayment(payment);
        }

        public void FinalizePayment(Order order)
        {
            var payment = order.SelectedPayments.Get(PaymentProvider.Invoice);
            order.ConfirmPayment(payment);
        }
    }
}
