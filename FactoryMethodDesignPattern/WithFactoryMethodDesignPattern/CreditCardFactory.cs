using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithFactoryMethodDesignPattern
{
    internal class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard card = null;
            if(cardType.Equals("MoneyBack", StringComparison.OrdinalIgnoreCase))
            {
                card = new MoneyBack();
            }
            else if (cardType.Equals("Platinum", StringComparison.OrdinalIgnoreCase))
            {
                card = new Platinum();
            }
            else  if (cardType.Equals("MoneyBack", StringComparison.OrdinalIgnoreCase))
            {
                card = new Titanium();
            }

            return card;
        }
    }
}
