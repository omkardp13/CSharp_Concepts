using System;
using System.Collections.Generic;

namespace CompileTimePolymorphism
{
    class Program
    {
        public static IEnumerable<int> GetNumbers(int upto)
        {
            for(int i=0;i<upto;i++)
            {
                yield return i;
                Console.WriteLine("print");
            }
        }
        public static void Main(string[] args) 
        {

          IEnumerable<int> numbers = GetNumbers(10);

          foreach(var number in numbers)
            {
                Console.WriteLine(number);

            }
            Console.Read();

        }
    }
}