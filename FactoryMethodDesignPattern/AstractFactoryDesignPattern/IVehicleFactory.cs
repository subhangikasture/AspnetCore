using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstractFactoryDesignPattern
{
    internal interface IVehicleFactory
    {
        ICar CreateCar();
        IBike CreateBike();

    }
}
