using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithStrategyDesignPattern
{
    internal class CreditCardPayment : IPaymentStrategy
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"Credit card payment : {amount}");
        }
    }
}
