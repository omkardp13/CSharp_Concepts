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
            int sum, difference;
            CalculateSumDiffrence(10,5,out sum,out difference);
            Console.WriteLine("Addition is:" + sum);
            Console.WriteLine("Substraction is:" + difference);
            Console.Read();
        }

        static void CalculateSumDiffrence(int a,int b,out int sum,out int diffrence)
        {
            sum = a + b;
            diffrence = a- b;
        }

    }
}
