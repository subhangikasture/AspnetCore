using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstractFactoryDesignPattern
{
    internal class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Regular Bike");
        }
    }
}
