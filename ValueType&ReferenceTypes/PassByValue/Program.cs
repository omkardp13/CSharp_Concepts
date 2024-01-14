using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_by_Value
{
    internal class Program
    {
        static void Increment(int x)
        {
            x++;
            Console.WriteLine("Inside Increment method: " + x);
        }

        static void Main(string[] args)
        {
            int number = 5;
            Increment(number);
            Console.WriteLine("Original value: " + number);
            Console.Read();
        }
    }
}
