using System;

class Program
{
    static void Main()
    {
        // Creating a tuple
        var person = ("John", 30, "Engineer");

        // Accessing tuple elements
        Console.WriteLine($"Name: {person.Item1}");
        Console.WriteLine($"Age: {person.Item2}");
        Console.WriteLine($"Profession: {person.Item3}");

        // Using a named tuple
        var car = (Make: "Toyota", Model: "Camry", Year: 2021);
        Console.WriteLine($"Car Make: {car.Make}");
        Console.WriteLine($"Car Model: {car.Model}");
        Console.WriteLine($"Car Year: {car.Year}");

        // Returning a tuple from a method
        var result = GetUserInfo();
        Console.WriteLine($"User Info: Name = {result.Name}, Age = {result.Age}");
        Console.Read();
    }

    // Method returning a tuple
    static (string Name, int Age) GetUserInfo()
    {
        string name = "Alice";
        int age = 25;
        return (name, age);
    }
}
