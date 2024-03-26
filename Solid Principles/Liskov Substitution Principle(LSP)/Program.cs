using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal  class Program
    {
      class vehicle
      {
            public virtual void Move()
            {
                Console.WriteLine("Moving...");
            }
      }
      class car : vehicle
      {
            public override void Move() 
            {
                Console.WriteLine("Driving...");           
            }
      }

      class bicycle:vehicle
      {
            public override void Move()
            {
                Console.WriteLine("Riding...");
            }
      }

        static void MoveAll(vehicle[] vehicle)
        {
            foreach (var v in vehicle) 
            { 
                v.Move();
            }
        }

        static void Main(string[] args)
        {
            

            car objcar=new car();
            bicycle objbicycle=new bicycle();
            vehicle[] vehicles = { objcar, objbicycle };
            MoveAll(vehicles);
            Console.ReadLine();
        }
    }
}
