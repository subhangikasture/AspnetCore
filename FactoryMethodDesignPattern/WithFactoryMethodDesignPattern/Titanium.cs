using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithFactoryMethodDesignPattern
{
    internal class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            throw new NotImplementedException();
        }

        public string GetCardType()
        {
            throw new NotImplementedException();
        }

        public int GetCreditLimit()
        {
            throw new NotImplementedException();
        }
    }
}
