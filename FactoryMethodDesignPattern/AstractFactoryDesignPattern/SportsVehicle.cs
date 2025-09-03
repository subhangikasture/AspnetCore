using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstractFactoryDesignPattern
{
    internal class SportsVehicle : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new SportsBike();
        }
        public ICar CreateCar()
        {
            return new SportsCar();
        }
    }
}
