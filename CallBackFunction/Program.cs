using System;
using System.Text;

class Program
{
    public static void MyCallbackFunction(string message)
    {
        Console.WriteLine("Callback received with message: " + message);
    }

    public static void ProcessData(Action<string> callback)
    {
        string processedData = "Hello from ProcessData";
        callback(processedData);
    }

    public static void StartProcessing()
    {
        ProcessData(MyCallbackFunction);
    }


    static void Main()
    {
        StartProcessing();
        Console.ReadKey();
    }
}
