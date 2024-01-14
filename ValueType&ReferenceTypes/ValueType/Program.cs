using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a= 10;
            int b = a; //b gets copy of value a
            a = 20;
           
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.Read();
        }
    }
}
