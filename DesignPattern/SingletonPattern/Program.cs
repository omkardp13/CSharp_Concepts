using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    public class Singleton
    {
        // Private static instance variable
        private static Singleton instance;

        // Private constructor prevents instantiation from other classes
        private Singleton()
        {
        }

        // Public method to provide access to the singleton instance
        public static Singleton GetInstance()
        {
            // If the instance is null, create a new instance
            if (instance == null)
            {
                instance = new Singleton();
            }

            // Return the existing instance
            return instance;
        }

        // Add other methods and properties here
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Get the singleton instance
            Singleton singletonInstance1 = Singleton.GetInstance();
            Singleton singletonInstance2 = Singleton.GetInstance();

            // Both instances will be the same object
            Console.WriteLine(singletonInstance1 == singletonInstance2); // Output: True

            // Call a method on the singleton instance
            singletonInstance1.PrintMessage("Hello, Singleton Pattern!");
            Console.Read();
        }
    }

}
