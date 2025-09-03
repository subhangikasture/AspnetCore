using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    internal class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium";
        }
        public int GetCreditLimit()
        {
            return 20000;
        }

        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
}
