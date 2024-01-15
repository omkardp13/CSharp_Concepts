using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegates
{
    public delegate void Calculations(int num1, int num2);
    internal class Program
    {
        public static void Addition(int num1,int num2)
        {
            int result=num1 + num2;
            Console.WriteLine(result);
        }

        public static void Substraction(int num1,int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Calculations obj = new Calculations(Addition);
            obj += Substraction;
            obj(150,100);
            Console.Read();
        }
    }
}
