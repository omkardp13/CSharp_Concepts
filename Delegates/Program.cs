using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Calculations(int a, int b);
    internal class Program
    {
       public static void Addition(int a,int b)
        {
            int result = a + b;
            Console.WriteLine("Addition Result:"+result);
        }

        static void Main(string[] args)
        {
            Calculations obj = new Calculations(Program.Addition);
            obj.Invoke(20,10);
            Console.Read();
        }
    }
}
