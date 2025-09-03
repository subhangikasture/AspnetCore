using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    internal class Platinum : ICreditCard
    {
       public string GetCardType()
        {
            return "Platonum";
        }
       public  int GetCreditLimit()
        {
            return 15000;
        }

       public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
