using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithFactory_StrategyDesignPattern
{
    internal class PaymentStrategyFactory
    {
        public IPaymentStrategy CreatePaymentStrategy(string type)
        {
            switch (type)
            {
                case "CreditCard": return new CreditPayment();
                case "PayPal": return new PayPalPayment();
                default: throw new ArgumentException("Invalid payment mode");
            }

        }
    }
}
