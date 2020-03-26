using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.PaymentProcessingExample.Entities
{
    public class SelectedPayments : IEnumerable<IPayment>
    {

        private List<IPayment> _paymentMehtods;
        public SelectedPayments()
        {
            _paymentMehtods = new List<IPayment>();
        }

        public void Add(Payment paymentMethod)
        {
            _paymentMehtods.Add(paymentMethod);
        }

        public IPayment Get(PaymentProvider provider)
        {
            var result = _paymentMehtods.FirstOrDefault(x => x.Provider == provider);
            if (result == null)
                return new NullPayment();
            return result;
        }

        public IEnumerator<IPayment> GetEnumerator()
        {            
            return _paymentMehtods.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
