Open/Closed Principle (OCP): this principle states that s/w entities (such as classes,modules,functions etc) should be open for extension but closed for modification.
In simple terms ,you should be able to extend the behaviour of module without modifying it's source code this can achived through inheritance,composition and abstraction.


In the abouve example the shape class is open for extension as you can create new shapes by extending it(e.g adding a tringle class).howver it closed for modification,as you don't need to modify the existing shape classes to add new shapes
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Open/Closed Principle:
The Open/Closed Principle is one of the SOLID principles in object-oriented programming, stating that software entities (classes, modules, functions, etc.) should be open for extension but closed for modification. This means that the behavior of a module can be extended without modifying its source code.

Here's a simple example in C# to demonstrate this principle.

Step 1: Define a base class
We'll start with a simple base class for a Shape that has a method to calculate the area.

public abstract class Shape
{
    public abstract double CalculateArea();
}

Step 2: Define derived classes
Next, we define two derived classes, Circle and Rectangle, which extend the Shape class by implementing the CalculateArea method.


public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

Step 3: Use the base class and derived classes
Now, we can create instances of Circle and Rectangle and use them without modifying their base class or the existing derived classes.

public class Program
{
    public static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(5),
            new Rectangle(4, 6)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area: {shape.CalculateArea()}");
        }
    }
}

Step 4: Extending functionality without modifying existing code
Suppose we now want to add a new shape, Triangle. We can extend the functionality by creating a new class that inherits from Shape without modifying the existing Shape, Circle, or Rectangle classes.


public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(double baseLength, double height)
    {
        Base = baseLength;
        Height = height;
    }

    public override double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}

Step 5: Use the new derived class
We can now use the Triangle class just like the other shapes.


public class Program
{
    public static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Triangle(3, 4)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area: {shape.CalculateArea()}");
        }
    }
}

Summary
In this example, we adhered to the Open/Closed Principle by defining a base class Shape that is open for extension (we can create new shapes like Triangle) but closed for modification (we didn't need to change existing classes Shape, Circle, or Rectangle when adding the new Triangle class). This way, the system can be extended with new functionality without altering the existing code, reducing the risk of introducing bugs.
