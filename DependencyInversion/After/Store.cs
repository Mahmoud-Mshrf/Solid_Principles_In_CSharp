using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.After
{
    // in this example, we have a Store class that depends on the IPaymentGateWay interface.
    // The IPaymentGateWay interface is an abstraction.
    // The Store class does not depend on the Stripe and PayPal classes directly.
    // The Stripe and PayPal classes are low-level modules that implement the IPaymentGateWay interface.

    class Store
    {
        private IPaymentGateWay _paymentGateWay;
        public void SetPaymentGateWay(IPaymentGateWay paymentGateWay)
        {
            _paymentGateWay = paymentGateWay;
        }
        public void SellItem()
        {
            _paymentGateWay.ProcessPayment();
        }
    }
    interface IPaymentGateWay
    {
        void ProcessPayment();
    }
    class Stripe : IPaymentGateWay
    {
        public void ProcessPayment()
        {
            // process payment
        }
    }
    class PayPal : IPaymentGateWay
    {
        public void ProcessPayment()
        {
            // process payment
        }
    }
}
