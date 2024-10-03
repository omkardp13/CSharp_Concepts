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
            int x = 5;
            fun(x);
            Console.Read();
        }

        static void fun(int n)
        {
            if(n>0)
            {
                Console.WriteLine(n);
                fun(n-1);
            }
        }
    }
}
