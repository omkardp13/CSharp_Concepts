using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal  class Program
    {
     
        interface IPrint
        {
            void Print();
        }
     interface IScanner
        {
            void Scan();
        }

        class Photocopyer : IPrint, IScanner
        {
            public void Print()
            {
                Console.WriteLine("Printing...");
            }

            public void Scan()
            {
                Console.WriteLine("Scanning...");
            }
        }



        static void Main(string[] args)
        {

            Photocopyer obj = new Photocopyer();
            obj.Print();
            obj.Scan();
            Console.ReadKey();
        }
    }
}
