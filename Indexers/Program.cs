using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class NumberCollection
        {
            private int[] numbers = new int[5];

            // Indexer to access elements in the array
            public int this[int index]
            {
                get
                {
                    if (index >= 0 && index < numbers.Length)
                    {
                        return numbers[index];
                    }
                    else
                    {
                        throw new IndexOutOfRangeException("Invalid index");
                    }
                }
                set
                {
                    if (index >= 0 && index < numbers.Length)
                    {
                        numbers[index] = value;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException("Invalid index");
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            NumberCollection collection = new NumberCollection();
            collection[0] = 10; // Setting the first element
            collection[1] = 20; // Setting the second element

            Console.WriteLine(collection[0]); // Output: 10
            Console.WriteLine(collection[1]); // Output: 20
            Console.Read();
        }
    }
}
