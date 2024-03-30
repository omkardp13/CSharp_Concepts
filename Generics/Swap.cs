using System;

public class Program
{
    // Generic method to swap two values of any type
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    public static void Main()
    {
        int x = 10, y = 20;
        Console.WriteLine("Before swap: x = {0}, y = {1}", x, y);

        // Call the Swap method with int parameters
        Swap<int>(ref x, ref y);

        Console.WriteLine("After swap: x = {0}, y = {1}", x, y);

        string s1 = "hello", s2 = "world";
        Console.WriteLine("Before swap: s1 = {0}, s2 = {1}", s1, s2);

        // Call the Swap method with string parameters
        Swap<string>(ref s1, ref s2);

        Console.WriteLine("After swap: s1 = {0}, s2 = {1}", s1, s2);
        Console.Read();
    }
}
