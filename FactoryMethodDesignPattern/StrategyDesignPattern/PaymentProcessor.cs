using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    internal class PaymentProcessor
    {
        public void ProcessPayment(string paymentType, decimal amount)
        {
            if(paymentType == "CreditCard")
            {
                Console.WriteLine($"Processing credit card payment of {amount:c}");
            }
            else if(paymentType == "PayPal")
            {
                Console.WriteLine($"Processing PayPal payment of {amount:c}");
            }
            else if(paymentType == "BitCoin")
            {
                Console.WriteLine($"Processing BitCoin payment of {amount:c}");
            }
            else
            {
                throw new ArgumentException("Inavlid payment type");
            }
        }
    }
}
