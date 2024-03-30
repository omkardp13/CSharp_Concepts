using System;

public class Calculator<T>
{
    // Addition method
    public T Add(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x + y;
    }

    // Subtraction method
    public T Subtract(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x - y;
    }

    // Multiplication method
    public T Multiply(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x * y;
    }

    // Division method
    public T Divide(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        if (y == 0)
        {
            throw new ArgumentException("Division by zero");
        }
        return x / y;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator<int> intCalculator = new Calculator<int>();
        Console.WriteLine("Addition: " + intCalculator.Add(10, 5));
        Console.WriteLine("Subtraction: " + intCalculator.Subtract(10, 5));
        Console.WriteLine("Multiplication: " + intCalculator.Multiply(10, 5));
        Console.WriteLine("Division: " + intCalculator.Divide(10, 5));

        Calculator<double> doubleCalculator = new Calculator<double>();
        Console.WriteLine("Addition: " + doubleCalculator.Add(10.5, 5.5));
        Console.WriteLine("Subtraction: " + doubleCalculator.Subtract(10.5, 5.5));
        Console.WriteLine("Multiplication: " + doubleCalculator.Multiply(10.5, 5.5));
        Console.WriteLine("Division: " + doubleCalculator.Divide(10.5, 5.5));
    }
}
