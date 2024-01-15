using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        public class Car : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("Driving a car.");
            }
        }

        public class Motorcycle : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("Riding a motorcycle.");
            }
        }

        static void Main(string[] args)
        {
            VehicleFactory vehicleFactory = new VehicleFactory();

            IVehicle car = vehicleFactory.CreateVehicle("car");
            car.Drive(); // Output: Driving a car.

            IVehicle motorcycle = vehicleFactory.CreateVehicle("motorcycle");
            motorcycle.Drive(); // Output: Riding a motorcycle.
            Console.Read();
        }
    }
}
