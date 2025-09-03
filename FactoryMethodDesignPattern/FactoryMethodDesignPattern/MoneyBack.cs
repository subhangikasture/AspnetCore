using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    internal class MoneyBack : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 1000;
        }

        public string GetCardType()
        {
            return "Money back";
        }

        public int GetCreditLimit()
        {
            return 10000;
        }
    }
}
