using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_by_Reference
{
    internal class Program
    {
        /*
         * Pass by reference sends the memory address of the variable to the method, 
         * allowing modifications to the original value.

         */
        static void Increment(ref int x)
        {
            x++;
            Console.WriteLine("Inside Increment method: " + x);
        }

        static void Main(string[] args)
        {
            int number = 5;
            Increment(ref number);
            Console.WriteLine("Original value: " + number);
            Console.Read();
        }
    }
}
