Mobile class in class there is Calling(),Messaging(),Camera() 

this extends class 
Iphone have Calling(),Messaging(),Camera()
Samsubg have Calling(),Messaging(),Camera()
Nokia(Basic) Calling(),Messaging() not Camera() 

pls do first two points of solid principles c#

--->

To demonstrate the first two points of the SOLID principles (Single Responsibility Principle and Open/Closed Principle) in C#, we can create a class structure that includes a base Mobile class and derived classes for Iphone, Samsung, and Nokia. Here’s how we can implement this:

Single Responsibility Principle (SRP): Each class should have only one reason to change. We ensure that each class handles only its specific functionalities.
Open/Closed Principle (OCP): Software entities should be open for extension but closed for modification. We achieve this by using inheritance and interfaces, allowing us to extend functionalities without modifying existing code.

Step 1: Define Interfaces
First, we'll define interfaces for the common functionalities (Calling, Messaging, Camera).


public interface ICalling
{
    void Call();
}

public interface IMessaging
{
    void SendMessage();
}

public interface ICamera
{
    void TakePhoto();
}


Step 2: Create the Base Class
Create a base class Mobile that will implement the basic functionalities.

public abstract class Mobile : ICalling, IMessaging
{
    public abstract void Call();
    public abstract void SendMessage();
}


Step 3: Extend the Base Class for Specific Models

Extend the base class for each specific mobile model. Implement the additional functionalities where required.

public class Iphone : Mobile, ICamera
{
    public override void Call()
    {
        Console.WriteLine("Iphone Calling...");
    }

    public override void SendMessage()
    {
        Console.WriteLine("Iphone Sending Message...");
    }

    public void TakePhoto()
    {
        Console.WriteLine("Iphone Taking Photo...");
    }
}

public class Samsung : Mobile, ICamera
{
    public override void Call()
    {
        Console.WriteLine("Samsung Calling...");
    }

    public override void SendMessage()
    {
        Console.WriteLine("Samsung Sending Message...");
    }

    public void TakePhoto()
    {
        Console.WriteLine("Samsung Taking Photo...");
    }
}

public class Nokia : Mobile
{
    public override void Call()
    {
        Console.WriteLine("Nokia Calling...");
    }

    public override void SendMessage()
    {
        Console.WriteLine("Nokia Sending Message...");
    }
}


Example Usage
Here is an example of how to use these classes:

public class Program
{
    public static void Main(string[] args)
    {
        Mobile iphone = new Iphone();
        iphone.Call();
        iphone.SendMessage();
        ((ICamera)iphone).TakePhoto();

        Mobile samsung = new Samsung();
        samsung.Call();
        samsung.SendMessage();
        ((ICamera)samsung).TakePhoto();

        Mobile nokia = new Nokia();
        nokia.Call();
        nokia.SendMessage();
        // Nokia does not have a camera
    }
}
Explanation
SRP: Each class (Iphone, Samsung, Nokia) has a single responsibility, which is to define the functionalities specific to that mobile model.
OCP: The base Mobile class is closed for modification but open for extension. We can add new mobile models by creating new classes without modifying the existing codebase.
This structure adheres to the first two principles of SOLID, ensuring maintainable and extensible code.






