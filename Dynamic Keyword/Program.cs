using System;

class Program
{
    static void Main()
    {
        // Using dynamic
        dynamic dynamicValue = "Hello, World!";
        Console.WriteLine(dynamicValue); // Output: Hello, World!

        // Changing the type of the dynamic variable at runtime
        dynamicValue = 42;
        Console.WriteLine(dynamicValue); // Output: 42

        // Using dynamic to call a method not known at compile time
        dynamicValue = new { Name = "Alice", Age = 30 };
        Console.WriteLine(dynamicValue.Name); // Output: Alice
        Console.WriteLine(dynamicValue.Age);  // Output: 30
        Console.Read();
        // Invalid code - This will only throw an error at runtime
        // Console.WriteLine(dynamicValue.NonExistentProperty); 
    }
}
