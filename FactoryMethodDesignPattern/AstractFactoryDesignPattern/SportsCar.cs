using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstractFactoryDesignPattern
{
    internal class SportsCar :ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Sports Car");
        }
    }
}
