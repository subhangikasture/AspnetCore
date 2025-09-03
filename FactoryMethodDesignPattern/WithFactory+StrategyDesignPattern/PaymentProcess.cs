using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithFactory_StrategyDesignPattern
{
    internal class PaymentProcess
    {
        IPaymentStrategy _paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }
        
        public void ProcessPayment(decimal amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }
}
