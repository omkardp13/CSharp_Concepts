using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;
namespace ConsoleApp1
{
    public static class CalculatorExtensions
    {
        public static int Multiply(this Program program, int a, int b)
        {
            return a * b;
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {

            Program obj = new Program();
            Console.WriteLine("Addition is: "+obj.Add(12,10));
            Console.WriteLine("Multiplication is: " + obj.Multiply(12, 10));
            Console.ReadKey();
        }
    }
}
