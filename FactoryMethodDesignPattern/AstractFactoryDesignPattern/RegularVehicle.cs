using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstractFactoryDesignPattern
{
    internal class RegularVehicle : IVehicleFactory
    {
        public ICar CreateCar()
        {
            return new RegularCar();
        }
        public IBike CreateBike()
        {
            return new RegularBike();
        }
    }
}
