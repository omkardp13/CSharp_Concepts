using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            Person person1 = new Person() { Name="John" };

            Person person2 = person1; //person2 referances the same object as person1
            person1.Name = "Onkar";

            Console.WriteLine(person1.Name);
            Console.WriteLine(person2.Name);
            Console.Read();


        }
    }
}
