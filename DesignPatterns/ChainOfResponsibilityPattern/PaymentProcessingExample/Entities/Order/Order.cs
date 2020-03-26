using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities
{
    public class Order
    {
        private event Action _onPaymentConfirmed;
        private event Action _onPaymentCanceled;
        public LineItems LineItems { get; }        
        public SelectedPayments SelectedPayments { get; }
        public decimal TotalPaid { get; private set; }
        public decimal AmountDue => LineItems.TotalPrice() - TotalPaid;        
        public ShiptmentStatus ShippingStatus { get; private set; }

        public Order()
        {
            LineItems = new LineItems();
            LineItems.OnItemAdded(UpdateShiptmentStatus);
            LineItems.OnItemRemoved(UpdateShiptmentStatus);
            SelectedPayments = new SelectedPayments();

            _onPaymentConfirmed += UpdateShiptmentStatus;
            _onPaymentCanceled += UpdateShiptmentStatus;
        }
        
        public void ConfirmPayment(IPayment payment)
        {
            TotalPaid += payment.Amount;
            _onPaymentConfirmed.Invoke();
        }

        public void CancelPayment(IPayment payment)
        {
            TotalPaid -= payment.Amount;
            _onPaymentCanceled.Invoke();
        }

        private void UpdateShiptmentStatus()
        {
            if (AmountDue == 0)
                ShippingStatus = ShiptmentStatus.ReadyForShipment;
            else
                ShippingStatus = ShiptmentStatus.WaitingForPayment;            
        }
    }
}
