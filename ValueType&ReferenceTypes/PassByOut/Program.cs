using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_By_Out
{
    internal class Program
    {
        /*
         * Pass by reference sends the memory address of the variable to the method, allowing modifications to the original value.
        *Pass by output is similar to pass by reference, 
        *but the parameter doesn't need to be initialized before being passed to the method; it must be assigned a value inside the method.
        *
        */
        static void Increment(out int x)
        {
            // The out parameter must be assigned a value before leaving the method.
            x = 0;
            x++;
            Console.WriteLine("Inside Increment method: " + x);
        }

        static void Main(string[] args)
        {
            int number;
            Increment(out number);
            Console.WriteLine("Original value: " + number);
            Console.ReadLine();
        }
    }
}
