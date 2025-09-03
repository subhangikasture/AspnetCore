using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithStrategyDesignPattern
{
    internal class PayPalPayment :IPaymentStrategy
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"Pay pal payment : {amount}");
        }
    }
}
