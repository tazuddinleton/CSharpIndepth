using DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.PaymentProcessors
{
    public class PaypalPaymentProcessor : IPaymentProcessor
    {
        public void CancelPayment(Order order)
        {
            var payment = order.SelectedPayments.Get(PaymentProvider.Paypal);
            order.CancelPayment(payment);
        }

        public void FinalizePayment(Order order)
        {
            var payment = order.SelectedPayments.Get(PaymentProvider.Paypal);
            order.ConfirmPayment(payment);
        }
    }
}
