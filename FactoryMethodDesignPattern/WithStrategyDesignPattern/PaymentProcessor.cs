using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithStrategyDesignPattern
{
    internal class PaymentProcessor
    {
        IPaymentStrategy _paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }
        public void ProcessPayment(decimal amount)
        {
            _paymentStrategy.pay(100000);
        }
    }
}
