using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithFactory_StrategyDesignPattern
{
    internal class CreditPayment :IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Credit card payment : {amount}");
        }
    }
}
