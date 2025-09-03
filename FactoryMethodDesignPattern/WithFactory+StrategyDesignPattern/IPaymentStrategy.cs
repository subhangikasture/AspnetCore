using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithFactory_StrategyDesignPattern
{
    internal interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}
