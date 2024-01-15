using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class VehicleFactory
    {
        public IVehicle CreateVehicle(string vehicleType)
        {
            IVehicle vehicle = null;

            if (vehicleType.ToLower() == "car")
            {
                vehicle = new Program.Car();
            }
            else if (vehicleType.ToLower() == "motorcycle")
            {
                vehicle = new Program.Motorcycle();
            }

            return vehicle;
        }
    }
}
