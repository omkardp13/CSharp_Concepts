using System;

namespace StringExtensions
{
    public static class StringExtensionMethods
    {
        // Extension method to get the first character of the string
        public static char GETFirstAlphabate(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("String is null or empty.");
            }

            return str[0];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = "DEMO";
            string z = "ABC";

            Console.WriteLine(z.GETFirstAlphabate()); // Output: 'A'
            Console.WriteLine(s.GETFirstAlphabate()); // Output: 'D'
            Console.Read();
        }
    }
}
