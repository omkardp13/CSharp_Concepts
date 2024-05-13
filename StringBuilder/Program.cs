using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Create a new StringBuilder instance
        StringBuilder stringBuilder = new StringBuilder();

        // Append strings to the StringBuilder
        stringBuilder.Append("Hello");
        stringBuilder.Append(" ");
        stringBuilder.Append("world");

        // Append a newline character
        stringBuilder.AppendLine();

        // Append formatted string
        int number = 10;
        stringBuilder.AppendFormat("The number is {0}.", number);

        // Get the final string
    //    string finalString = stringBuilder.ToString();

        // Print the final string
        Console.WriteLine(stringBuilder);
        Console.ReadLine();
    }
}
